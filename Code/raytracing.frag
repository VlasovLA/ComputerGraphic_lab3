#version 430
out vec4 FragColor;
in vec3 glPosition;

const float EPSILON = 0.001;
const float BIG = 1000000.0;
const int DIFFUSE_REFLECTION = 1;
const int MIRROR_REFLECTION = 2;
const int REFRACTION = 3;

uniform int BigSphereMat; //�������� �����
uniform int Walls = 1;
uniform int CubeMat; //�������� ����
uniform int TetrMat;//�������� ���������
uniform vec3 ColSphere;			//���� �����
uniform vec3 ColCube;				//���� ����
uniform vec3 ColTetr;				//���� ���������
uniform int Depth;					//�������
uniform float ReflCube;
uniform float RefrCube;
uniform float ReflSph;
uniform float RefrSph;
uniform float ReflTetr;
uniform float RefrTetr;

/*** DATA STRUCTURES ***/
struct SIntersection //�����������
{
	float Time;
	vec3 Point;
	vec3 Normal;
	vec3 Color;
	// ambient, diffuse and specular coeffs
	vec4 LightCoeffs;
	// 0 - non-reflection, 1 - mirror
	float ReflectionCoef;
	float RefractionCoef;
	int MaterialType;
};

struct SCamera //������
{
	vec3 Position;
	vec3 View;
	vec3 Up;
	vec3 Side;
	// ��������� ������ ��������� �����������
	vec2 Scale;
};

struct SRay //���
{
	vec3 Origin;
	vec3 Direction;
};

struct SLight //�������� �����
{
	vec3 Position;
};

struct SMaterial //��������
{
	//diffuse color
	vec3 Color;
	// ambient, diffuse and specular coeffs
	vec4 LightCoeffs;
	// 0 - non-reflection, 1 - mirror
	float ReflectionCoef;
	float RefractionCoef;
	int MaterialType;
};

struct SSphere //�����
{
	vec3 Center;
	float Radius;
	int MaterialIdx;
};

struct STriangle //�����������
{
	vec3 v1;
	vec3 v2;
	vec3 v3;
	int MaterialIdx;
};

struct SCub	// ���
{
	STriangle[12] trianglesub;
};

struct SThetr	// ��������
{
		STriangle[4] trianglesthetr;
};

struct STracingRay
{
	SRay ray;
	float contribution;
	int depth;
};

/** GLOBAL VAR **/
STriangle triangles[12];
SSphere spheres[2];
SCub cubs;
SThetr thetr;
SLight light;
SMaterial materials[8];

/** FUNCTION **/
SRay GenerateRay ( SCamera uCamera )
{
	vec2 coords = glPosition.xy * uCamera.Scale;
	vec3 direction = uCamera.View + uCamera.Side * coords.x + uCamera.Up * coords.y;
	return SRay ( uCamera.Position, normalize(direction) );
}

SCamera initializeDefaultCamera()
{
	//** CAMERA **//
	SCamera camera;
	camera.Position = vec3(-4.0, 3.0, -20.0);
	camera.View = vec3(0.0, 0.0, 1.0);
	camera.Up = vec3(0.0, 1.0, 0.0);
	camera.Side = vec3(1.0, 0.0, 0.0);
	camera.Scale = vec2(1.0);
	return camera;

}

void initializeDefaultScene()
{
	/** TRIANGLES **/
	/* left wall */
	triangles[0].v1 = vec3(-12.0,-12.0,-12.0);
	triangles[0].v2 = vec3(-12.0, 12.0, 12.0);
	triangles[0].v3 = vec3(-12.0, 12.0,-12.0);
	triangles[0].MaterialIdx = 0;
	triangles[1].v1 = vec3(-12.0,-12.0,-12.0);
	triangles[1].v2 = vec3(-12.0,-12.0, 12.0);
	triangles[1].v3 = vec3(-12.0, 12.0, 12.0);
	triangles[1].MaterialIdx = 0;
	/* back wall */
	triangles[2].v1 = vec3(-12.0,-12.0, 12.0);
	triangles[2].v2 = vec3(12.0,-12.0, 12.0);
	triangles[2].v3 = vec3(-12.0, 12.0, 12.0);
	triangles[2].MaterialIdx = 2;
	triangles[3].v1 = vec3(12.0, 12.0, 12.0);
	triangles[3].v2 = vec3(-12.0, 12.0, 12.0);
	triangles[3].v3 = vec3(12.0,-12.0, 12.0);
	triangles[3].MaterialIdx = 2;
	/*right wall */ 
	triangles[4].v1 = vec3(12.0, 12.0, 12.0);
	triangles[4].v2 = vec3(12.0, -12.0, 12.0); 
	triangles[4].v3 = vec3(12.0, 12.0, -12.0); 
	triangles[4].MaterialIdx = 1; 
	triangles[5].v1 = vec3(12.0, 12.0, -12.0); 
	triangles[5].v2 = vec3(12.0, -12.0, 12.0); 
	triangles[5].v3 = vec3(12.0, -12.0, -12.0); 
	triangles[5].MaterialIdx = 1; 
	/*down wall */ 
	triangles[6].v1 = vec3(-12.0,-12.0, 12.0);		
	triangles[6].v2 = vec3(-12.0,-12.0,-12.0); 
	triangles[6].v3 = vec3( 12.0,-12.0, 12.0); 
	triangles[6].MaterialIdx = 3; 
	triangles[7].v1 = vec3(12.0, -12.0, -12.0); 
	triangles[7].v2 = vec3(12.0, -12.0, 12.0); 
	triangles[7].v3 = vec3(-12.0,-12.0,-12.0); 
	triangles[7].MaterialIdx = 3; 
	/*up wall */ 
	triangles[8].v1 = vec3(-12.0, 12.0,-12.0); 
	triangles[8].v2 = vec3(-12.0, 12.0, 12.0);		
	triangles[8].v3 = vec3(12.0, 12.0, 12.0); 
	triangles[8].MaterialIdx = 3; 
	triangles[9].v1 = vec3(-12.0, 12.0, -12.0); 
	triangles[9].v2 = vec3(12.0, 12.0, 12.0); 
	triangles[9].v3 = vec3(12.0, 12.0, -12.0); 
	triangles[9].MaterialIdx = 3; 	
	/* front wall */
	triangles[10].v1 = vec3(-120.0,-120.0, -52.0);
	triangles[10].v3 = vec3(120.0, -120.0, -52.0);
	triangles[10].v2 = vec3(-120.0, 120.0, -52.0);
	triangles[10].MaterialIdx = 2;
	triangles[11].v1 = vec3(120.0, 120.0, -52.0);
	triangles[11].v3 = vec3(-120.0, 120.0, -52.0);
	triangles[11].v2 = vec3(120.0, -120.0, -52.0);
	triangles[11].MaterialIdx = 2;


	/** SPHERES **/
	if (BigSphereMat != 0)
	{
		/*big sphere*/
		spheres[0].Center = vec3(-8.0,-3.0,-5.0);
		spheres[0].Radius = 3.0;
		spheres[0].MaterialIdx = 4;
	}

	/** cubs **/
	if (CubeMat != 0)
	{
		/*front wall*/
		cubs.trianglesub[0].v1 = vec3(3.5, -1.5, -1.5);
		cubs.trianglesub[0].v2 = vec3(6.5, -1.5, -1.5);
		cubs.trianglesub[0].v3 = vec3(3.5, 3.5, -1.5);
		cubs.trianglesub[0].MaterialIdx = 7;
		cubs.trianglesub[1].v1 = vec3(6.5, 3.5, -1.5);
		cubs.trianglesub[1].v2 = vec3(3.5, 3.5, -1.5);
		cubs.trianglesub[1].v3 = vec3(6.5, -1.5, -1.5);
		cubs.trianglesub[1].MaterialIdx = 7;
		/*back wall*/
		cubs.trianglesub[2].v1 = vec3(3.5, -1.5, 1.5);
		cubs.trianglesub[2].v2 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[2].v3 = vec3(3.5, 3.5, 1.5);
		cubs.trianglesub[2].MaterialIdx = 6;
		cubs.trianglesub[3].v1 = vec3(6.5, 3.5, 1.5);
		cubs.trianglesub[3].v2 = vec3(3.5, 3.5, 1.5);
		cubs.trianglesub[3].v3 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[3].MaterialIdx = 7;
		/*left wall*/
		cubs.trianglesub[4].v1 = vec3(3.5, -1.5, -1.5);
		cubs.trianglesub[4].v2 = vec3(3.5, 3.5, 1.5);
		cubs.trianglesub[4].v3 = vec3(3.5, 3.5, -1.5);
		cubs.trianglesub[4].MaterialIdx = 7;
		cubs.trianglesub[5].v1 = vec3(3.5, -1.5, -1.5);
		cubs.trianglesub[5].v2 = vec3(3.5, -1.5, 1.5);
		cubs.trianglesub[5].v3 = vec3(3.5, 3.5, 1.5);
		cubs.trianglesub[5].MaterialIdx = 7;
		/*right wall*/
		cubs.trianglesub[6].v1 = vec3(6.5, 3.5, 1.5);
		cubs.trianglesub[6].v2 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[6].v3 = vec3(6.5, 3.5, -1.5);
		cubs.trianglesub[6].MaterialIdx = 7;
		cubs.trianglesub[7].v1 = vec3(6.5, 3.5, -1.5);
		cubs.trianglesub[7].v2 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[7].v3 = vec3(6.5, -1.5, -1.5);
		cubs.trianglesub[7].MaterialIdx = 7;
		/*top wall*/
		cubs.trianglesub[8].v1 = vec3(3.5, 3.5, -1.5);
		cubs.trianglesub[8].v2 = vec3(3.5, 3.5, 1.5);
		cubs.trianglesub[8].v3 = vec3(6.5, 3.5, 1.5);
		cubs.trianglesub[8].MaterialIdx = 7;
		cubs.trianglesub[9].v1 = vec3(3.5, 3.5, -1.5);
		cubs.trianglesub[9].v2 = vec3(6.5, 3.5, 1.5);
		cubs.trianglesub[9].v3 = vec3(6.5, 3.5, -1.5);
		cubs.trianglesub[9].MaterialIdx = 7;
		/*down wall*/
		cubs.trianglesub[10].v1 = vec3(3.5, -1.5, 1.5);
		cubs.trianglesub[10].v2 = vec3(3.5, -1.5, -1.5);
		cubs.trianglesub[10].v3 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[10].MaterialIdx = 7;
		cubs.trianglesub[11].v1 = vec3(6.5, -1.5, -1.5);
		cubs.trianglesub[11].v2 = vec3(6.5, -1.5, 1.5);
		cubs.trianglesub[11].v3 = vec3(3.5, -1.5, -1.5);
		cubs.trianglesub[11].MaterialIdx = 7;
	}

	if (TetrMat != 0)
	{
	/** thetr **/
		thetr.trianglesthetr[0].v1 = vec3(-2.5, -2.5, 2.5);
		thetr.trianglesthetr[0].v2 = vec3(-2.5, -2.5, -2.5);
		thetr.trianglesthetr[0].v3 = vec3(2.5, -2.5, 2.5);
		thetr.trianglesthetr[0].MaterialIdx = 6;
		thetr.trianglesthetr[1].v1 = vec3(-2.5, -2.5, 2.5);
		thetr.trianglesthetr[1].v2 = vec3(2.5, -2.5, 2.5);
		thetr.trianglesthetr[1].v3 = vec3(-2.5, 2.5, 0.0);
		thetr.trianglesthetr[1].MaterialIdx = 6;
		thetr.trianglesthetr[2].v1 = vec3(-2.5, -2.5, -2.5);
		thetr.trianglesthetr[2].v2 = vec3(2.5, -2.5, 2.5);
		thetr.trianglesthetr[2].v3 = vec3(-2.5, 2.5, 0.0);
		thetr.trianglesthetr[2].MaterialIdx = 6;
		thetr.trianglesthetr[3].v1 = vec3(-2.5, -2.5, 2.5);
		thetr.trianglesthetr[3].v2 = vec3(-2.5, -2.5, -2.5);
		thetr.trianglesthetr[3].v3 = vec3(-2.5, 2.5, 0.0);
		thetr.trianglesthetr[3].MaterialIdx = 6;
	}
}

void initializeDefaultLightMaterials()
{
	//** LIGHT **//
	light.Position = vec3(0.0, 2.0, -4.0f);
	/** MATERIALS **/
	vec4 lightCoefs = vec4(0.4,0.9,0.0,512.0);

	/*left wall Material*/
	materials[0].Color = vec3(0.0, 0.8, 0.0);
	materials[0].LightCoeffs = vec4(lightCoefs);
	materials[0].ReflectionCoef = 0.5;
	materials[0].RefractionCoef = 1.0;
	if (Walls == 1)
	{
		materials[0].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (Walls == 2)
	{
		materials[0].MaterialType = MIRROR_REFLECTION;
	}

	/*right wall Material*/
	materials[1].Color = vec3(0.0, 0.0, 0.8);
	materials[1].LightCoeffs = vec4(lightCoefs);
	materials[1].ReflectionCoef = 0.5;
	materials[1].RefractionCoef = 1.0;
	if (Walls == 1)
	{
		materials[1].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (Walls == 2)
	{
		materials[1].MaterialType = MIRROR_REFLECTION;
	}

	/*back and front wall  Material*/
	materials[2].Color = vec3(0.8, 0.0, 0.8);	
	materials[2].LightCoeffs = vec4(lightCoefs);
	materials[2].ReflectionCoef = 0.5;
	materials[2].RefractionCoef = 1.0;
	if (Walls == 1)
	{
		materials[2].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (Walls == 2)
	{
		materials[2].MaterialType = MIRROR_REFLECTION;
	}

	/*top and down wall  Material*/
	materials[3].Color = vec3(0.8, 0.8, 0.0);	
	materials[3].LightCoeffs = vec4(lightCoefs);
	materials[3].ReflectionCoef = 0.5;
	materials[3].RefractionCoef = 1.0;
	if (Walls == 1)
	{
		materials[3].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (Walls == 2)
	{
		materials[3].MaterialType = MIRROR_REFLECTION;
	}

	/*big sphere material*/
	materials[4].Color = ColSphere;	
	materials[4].LightCoeffs = vec4(lightCoefs);
	materials[4].ReflectionCoef = ReflSph;
	materials[4].RefractionCoef = RefrSph;
	if (BigSphereMat == 1)
	{
		materials[4].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (BigSphereMat == 2)
	{
		materials[4].MaterialType = MIRROR_REFLECTION;
	}
	else if (BigSphereMat == 3)
	{
		materials[4].MaterialType = REFRACTION;
	}


	/*cub material*/
	materials[7].Color = ColCube;	
	materials[7].LightCoeffs = vec4(lightCoefs);
	materials[7].ReflectionCoef = ReflCube;
	materials[7].RefractionCoef = RefrCube;	
	if (CubeMat == 1)
	{
		materials[7].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (CubeMat == 2)
	{
		materials[7].MaterialType = MIRROR_REFLECTION;
	}
	else if (CubeMat == 3)
	{
		materials[7].MaterialType = REFRACTION;
	}

	
	/*thetr material*/
	materials[6].Color = ColTetr;	
	materials[6].LightCoeffs = vec4(lightCoefs);
	materials[6].ReflectionCoef = ReflTetr;
	materials[6].RefractionCoef = RefrTetr;
	if (TetrMat == 1)
	{
		materials[6].MaterialType = DIFFUSE_REFLECTION;
	}
	else if (TetrMat == 2)
	{
		materials[6].MaterialType = MIRROR_REFLECTION;
	}
	else if (TetrMat == 3)
	{
		materials[6].MaterialType = REFRACTION;
	}
}

bool IntersectSphere ( SSphere sphere, SRay ray, float start, float final, out float time )
{
	ray.Origin -= sphere.Center;
	float A = dot ( ray.Direction, ray.Direction );
	float B = dot ( ray.Direction, ray.Origin );
	float C = dot ( ray.Origin, ray.Origin ) - sphere.Radius * sphere.Radius;
	float D = B * B - A * C;
	if ( D > 0.0 )
	{
		D = sqrt ( D );
		//time = min ( max ( 0.0, ( -B - D ) / A ), ( -B + D ) / A );
		float t1 = ( -B - D ) / A;
		float t2 = ( -B + D ) / A;
		if(t1 < 0 && t2 < 0)
		return false;
	if(min(t1, t2) < 0)
	{
		time = max(t1,t2);
		return true;
	}
		time = min(t1, t2);
		return true;
	}
	return false;
}

bool IntersectTriangle (SRay ray, vec3 v1, vec3 v2, vec3 v3, out float time )
{
	time = -1;
	vec3 A = v2 - v1;
	vec3 B = v3 - v1;
	// no need to normalize vector
	vec3 N = cross(A, B);
	// N
	// // Step 1: finding P
	// // check if ray and plane are parallel ?
	float NdotRayDirection = dot(N, ray.Direction);
	if (abs(NdotRayDirection) < 0.001)
		return false;
	// they are parallel so they don't intersect !
	// compute d parameter using equation 2
	float d = dot(N, v1);
	// compute t (equation 3)
	float t = -(dot(N, ray.Origin) - d) / NdotRayDirection;
	// check if the triangle is in behind the ray
	if (t < 0)
		return false;
	// the triangle is behind
	// compute the intersection point using equation 1
	vec3 P = ray.Origin + t * ray.Direction;
	// // Step 2: inside-outside test //
	vec3 C;
	// vector perpendicular to triangle's plane
	// edge 0
	vec3 edge1 = v2 - v1;
	vec3 VP1 = P - v1;
	C = cross(edge1, VP1);
	if (dot(N, C) < 0)
		return false;
	// P is on the right side
	// edge 1
	vec3 edge2 = v3 - v2;
	vec3 VP2 = P - v2;
	C = cross(edge2, VP2);
	if (dot(N, C) < 0)
		return false;
	// P is on the right side
	// edge 2
	vec3 edge3 = v1 - v3;
	vec3 VP3 = P - v3;
	C = cross(edge3, VP3);
	if (dot(N, C) < 0)
		return false;
	// P is on the right side;
	time = t;
		return true;
	// this ray hits the triangle
}

bool Raytrace ( SRay ray, float start, float final, inout SIntersection intersect )
{
	bool result = false;
	float test = start;
	intersect.Time = final;
	//calculate intersect with Big sphere 
	if( IntersectSphere (spheres[0], ray, start, final, test ) && (test < intersect.Time) && (BigSphereMat != 0))
	{
		intersect.Time = test;
		intersect.Point = ray.Origin + ray.Direction * test;
		intersect.Normal = normalize ( intersect.Point - spheres[0].Center );
		if (distance(ray.Origin, spheres[0].Center) < spheres[0].Radius)
		{
			intersect.Normal = -intersect.Normal;
		}
		SMaterial material = materials[spheres[0].MaterialIdx];
		intersect.Color = material.Color;
		intersect.LightCoeffs = material.LightCoeffs;
		intersect.ReflectionCoef = material.ReflectionCoef;
		intersect.RefractionCoef = material.RefractionCoef;
		intersect.MaterialType = material.MaterialType;
		result = true;
	}
	

	//calculate intersect with triangles
	for(int i = 0; i < 12; i++)
	{
		STriangle triangle = triangles[i];
		if(IntersectTriangle(ray, triangle.v1, triangle.v2, triangle.v3, test) && test < intersect.Time)
		{
			intersect.Time = test;
			intersect.Point = ray.Origin + ray.Direction * test;
			intersect.Normal = normalize(cross(triangle.v1 - triangle.v2, triangle.v3 - triangle.v2));

			SMaterial material = materials[triangle.MaterialIdx];
			if (dot(intersect.Normal, ray.Direction) > 0)
			{
				intersect.Normal = -intersect.Normal;
			}
			intersect.Color = material.Color;
			intersect.LightCoeffs = material.LightCoeffs;
			intersect.ReflectionCoef = material.ReflectionCoef;
			intersect.RefractionCoef = material.RefractionCoef;
			intersect.MaterialType = material.MaterialType;
			result = true;
		}
	}

	//calculate intersect with cub
	for(int i = 0; i < 12; i++)
	{
		STriangle cubtr = cubs.trianglesub[i];
		if(IntersectTriangle(ray, cubtr.v1, cubtr.v2, cubtr.v3, test) && test < intersect.Time && CubeMat != 0)
		{
			intersect.Time = test;
			intersect.Point = ray.Origin + ray.Direction * test;
			intersect.Normal = normalize(cross(cubtr.v1 - cubtr.v2, cubtr.v3 - cubtr.v2));

			SMaterial material = materials[cubtr.MaterialIdx];

			intersect.Color = material.Color;
			intersect.LightCoeffs = material.LightCoeffs;
			intersect.ReflectionCoef = material.ReflectionCoef;
			intersect.RefractionCoef = material.RefractionCoef;
			intersect.MaterialType = material.MaterialType;
			result = true;
		}
	}

	//calculate intersect with thetr
	for(int i = 0; i < 4; i++)
	{
		STriangle thetrtr = thetr.trianglesthetr[i];
		if(IntersectTriangle(ray, thetrtr.v1, thetrtr.v2, thetrtr.v3, test) && test < intersect.Time && TetrMat != 0)
		{
			intersect.Time = test;
			intersect.Point = ray.Origin + ray.Direction * test;
			intersect.Normal = normalize(cross(thetrtr.v1 - thetrtr.v2, thetrtr.v3 - thetrtr.v2));

			SMaterial material = materials[thetrtr.MaterialIdx];

			intersect.Color = material.Color;
			intersect.LightCoeffs = material.LightCoeffs;
			intersect.ReflectionCoef = material.ReflectionCoef;
			intersect.RefractionCoef = material.RefractionCoef;
			intersect.MaterialType = material.MaterialType;
			result = true;
		}
	}
	return result;
}

float Shadow(SLight currLight, SIntersection intersect)
{
	// Point is lighted
	float shadowing = 1.0;
	// Vector to the light source
	vec3 direction = normalize(currLight.Position - intersect.Point);
	// Generation shadow ray for this light source
	SRay shadowRay = SRay(intersect.Point + direction * 0.001, direction);
	// Distance to the light source
	float distanceLight = distance(currLight.Position, shadowRay.Origin);
	// ...test intersection this ray with each scene object
	SIntersection shadowIntersect;
	shadowIntersect.Time = 1000000.0;
	// trace ray from shadow ray begining to light source position
	if(Raytrace(shadowRay, 0, distanceLight,	shadowIntersect))
	{
		// this light source is invisible in the intercection point
		shadowing = 0.0;
	}
	return shadowing;
}

vec3 Phong ( SIntersection intersect, SLight currLight, SCamera uCamera)
{
	float shadow = Shadow(currLight, intersect);
	vec3 ulight = normalize ( currLight.Position - intersect.Point );
	float diffuse = max(dot(ulight, intersect.Normal), 0.0);
	vec3 view = normalize(uCamera.Position - intersect.Point);
	vec3 reflected= reflect( -view, intersect.Normal );
	float specular = pow(max(dot(reflected, ulight), 0.0), intersect.LightCoeffs.w);
	return intersect.LightCoeffs.x * intersect.Color + 
		intersect.LightCoeffs.y * diffuse * vec3(0.5, 0.5, 0.5) * shadow +
		intersect.LightCoeffs.z * specular * 1;
}

/** STACK **/
struct Stack
{	
	int count;
	STracingRay ar[10];
};

Stack st;

bool isEmpty()
{
	return (st.count <= 0);
}

bool isFull()
{
    return (st.count == 10);
}

void push(STracingRay ray)
{
	if(!isFull())
		st.ar[st.count++] = ray;
}

STracingRay pop()
{
	if(!isEmpty())
		return st.ar[--st.count];
	else
		return st.ar[st.count];
}

void main ( void )
{
	SIntersection intersect;
	st.count = 0;
	float start = 0;
	float final = 1000000.0;
	//intersect.Time = 1000000.0;
	SCamera uCamera = initializeDefaultCamera();
	SRay ray = GenerateRay( uCamera);
	vec3 resultColor = vec3(0,0,0);
	initializeDefaultLightMaterials();
	initializeDefaultScene();
	STracingRay trRay = STracingRay(ray, 1, Depth);
	push(trRay);
	while(!isEmpty())
	{
		STracingRay trRay = pop();
		if (trRay.depth <= 0)
			continue;
		ray = trRay.ray;
		SIntersection intersect;
		intersect.Time = 1000000.0;
		start = 0;
		final = 1000000.0;
		if (Raytrace(ray, start, final, intersect))
		{
			switch(intersect.MaterialType)
			{
				case DIFFUSE_REFLECTION:
				{
					resultColor += trRay.contribution * Phong ( intersect, light, uCamera );
					break;
				}
				case MIRROR_REFLECTION:
				{
					if(!isFull())
					{
						//resultColor = vec3(1, 1, 0);
						if(intersect.ReflectionCoef < 1)
						{
							float contribution = trRay.contribution * (1 - intersect.ReflectionCoef);
							resultColor += contribution * Phong(intersect, light, uCamera);
						}
						vec3 reflectDirection = reflect(ray.Direction, intersect.Normal);
						// creare reflection ray
						float contribution = trRay.contribution * intersect.ReflectionCoef;
						STracingRay reflectRay = STracingRay(SRay(intersect.Point + reflectDirection * 0.001, reflectDirection), contribution, trRay.depth - 1);
						push(reflectRay);
					}
					
					break;
				}
				case REFRACTION:
				{
					if(!isFull())
					{
						//resultColor = vec3(1, 0, 1);
						float ior;
						int sign;
						if (dot(ray.Direction, intersect.Normal) < 0) ior = 1.0 / intersect.RefractionCoef;
							 else ior = intersect.RefractionCoef;
						if (dot(ray.Direction, intersect.Normal) < 0) sign = 1;
							else sign = -1;                     
						vec3 refractionDirection = normalize(refract(ray.Direction,  intersect.Normal * sign, ior));
						vec3 refractionRayOrig = intersect.Point + 0.001 * refractionDirection;
						STracingRay refractRay = STracingRay(SRay(refractionRayOrig, refractionDirection), trRay.contribution, trRay.depth - 1);
						push(refractRay);	
					}
				}

			} // switch
		} // if (Raytrace(ray, start, final, intersect))
	} // while(!isEmpty())
	
	FragColor = vec4 (resultColor, 1.0);
}
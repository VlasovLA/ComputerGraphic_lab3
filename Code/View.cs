using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace WindowsFormsApp1
{
    class View
    {
        private int BasicProgramID;
        private uint BasicVertexShader;
        private uint BasicFragmentShader;
        private Vector3[] vertdata;
        private int vbo_position;
        private int attribute_vpos;
        private int uniform_pos;
        private int uniform_aspect;
        private double aspect;

        private int CubeMat = 0;
        private int NextCubeMat = 0;
        private int SphereMat = 0;
        private int NextSphereMat = 0;
        private int TetrMat = 0;
        private int NextTetrMat = 0;
        private int Depth = 0;
        private int NextDepth = 5;
        private float reflSph = 0;
        private float NextreflSph = 0.5f;
        private float refrSph = 0;
        private float NextrefrSph = 1.3f;
        private float reflCube = 0;
        private float NextreflCube = 0.5f;
        private float refrCub = 0;
        private float NextrefrCube = 1f;
        private float reflTetr = 0;
        private float NextreflTetr = 0.5f;
        private float refrTetr = 0;
        private float NextrefrTetr = 1f;
        private Vector3 ColCube = new Vector3(0.0f, 0.0f, 0.0f);
        private Vector3 NextColCube = new Vector3(0.0f, 1.0f, 0.0f);
        private Vector3 ColSphere = new Vector3(0.0f, 0.0f, 0.0f);
        private Vector3 NextColBigSphere = new Vector3(1.0f, 0.0f, 0.0f); 
        private Vector3 ColTetr = new Vector3(0.0f, 0.0f, 0.0f);
        private Vector3 NextColTetr = new Vector3(0.0f, 0.0f, 1.0f);

        Vector3 cameraPosition = new Vector3(4, 3, 4);
        Vector3 cameraDirection = new Vector3(0, 0, 0);
        Vector3 CameraUp = new Vector3(0, 0, 1);
        public float latitude = 47.98f;
        public float longitude = 60.41f;
        public float radius = 5.385f;


        public void Setup(int width, int height)
        {
            GL.ClearColor(Color.DarkGray);          //заливка одним цветом
            GL.ShadeModel(ShadingModel.Smooth); //отрисовка с интерполяцией яркости
            GL.Enable(EnableCap.DepthTest);         //буфер глубины
        }

        public void Update()
        {
            cameraPosition = new Vector3(
                (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Cos(Math.PI / 180.0f * longitude)),
                (float)(radius * Math.Cos(Math.PI / 180.0f * latitude) * Math.Sin(Math.PI / 180.0f * longitude)),
                (float)(radius * Math.Sin(Math.PI / 180.0f * latitude)));

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            Matrix4 viewMat = Matrix4.LookAt(cameraPosition, cameraDirection, CameraUp);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMat);
            Render();

        }
        public void Render()
        {
            GL.UseProgram(BasicProgramID);

            int location = GL.GetUniformLocation(BasicProgramID, "CubeMat");
            if ((location != -1) && (NextCubeMat != CubeMat))
            {
                CubeMat = NextCubeMat;
                GL.Uniform1(location, CubeMat);
            }
            location = GL.GetUniformLocation(BasicProgramID, "BigSphereMat");
            if ((location != -1) && (NextSphereMat != SphereMat))
            {
                SphereMat = NextSphereMat;
                GL.Uniform1(location, SphereMat);
            }
            location = GL.GetUniformLocation(BasicProgramID, "TetrMat");
            if ((location != -1) && (NextTetrMat != TetrMat))
            {
                TetrMat = NextTetrMat;
                GL.Uniform1(location, TetrMat);
            }
            location = GL.GetUniformLocation(BasicProgramID, "ColSphere");
            if ((location != -1) && (NextColBigSphere != ColSphere))
            {
                ColSphere = NextColBigSphere;
                GL.Uniform3(location, ColSphere.X, ColSphere.Y, ColSphere.Z);
            }
            location = GL.GetUniformLocation(BasicProgramID, "ColCube");
            if ((location != -1) && (NextColCube != ColCube))
            {
                ColCube = NextColCube;
                GL.Uniform3(location, ColCube.X, ColCube.Y, ColCube.Z);
            }
            location = GL.GetUniformLocation(BasicProgramID, "ColTetr");
            if ((location != -1) && (NextColTetr != ColTetr))
            {
                ColTetr = NextColTetr;
                GL.Uniform3(location, ColTetr.X, ColTetr.Y, ColTetr.Z);
            }
            location = GL.GetUniformLocation(BasicProgramID, "Depth");
            if ((location != -1) && (NextDepth != Depth))
            {
                Depth = NextDepth;
                GL.Uniform1(location, Depth);
            }

            location = GL.GetUniformLocation(BasicProgramID, "ReflCube");
            if ((location != -1) && (NextreflCube != reflCube))
            {
                reflCube = NextreflCube;
                GL.Uniform1(location, reflCube);
            }
            location = GL.GetUniformLocation(BasicProgramID, "RefrCube");
            if ((location != -1) && (NextrefrCube != refrCub))
            {
                refrCub = NextrefrCube;
                GL.Uniform1(location, refrCub);
            }
            location = GL.GetUniformLocation(BasicProgramID, "ReflSph");
            if ((location != -1) && (NextreflSph != reflSph))
            {
                reflSph = NextreflSph;
                GL.Uniform1(location, reflSph);
            }
            location = GL.GetUniformLocation(BasicProgramID, "RefrSph");
            if ((location != -1) && (NextrefrSph != refrSph))
            {
                refrSph = NextrefrSph;
                GL.Uniform1(location, refrSph);
            }
            location = GL.GetUniformLocation(BasicProgramID, "ReflTetr");
            if ((location != -1) && (NextreflTetr != reflTetr))
            {
                reflTetr = NextreflTetr;
                GL.Uniform1(location, reflTetr);
            }
            location = GL.GetUniformLocation(BasicProgramID, "RefrTetr");
            if ((location != -1) && (NextrefrTetr != refrTetr))
            {
                refrTetr = NextrefrTetr;
                GL.Uniform1(location, refrTetr);
            }

            cameraPosition = new Vector3(1, 1, 3);
            vertdata = new Vector3[] {
                new Vector3(-1f, -1f, 0f),
                new Vector3( 1f, -1f, 0f),
                new Vector3( 1f, 1f, 0f),
                new Vector3(-1f, 1f, 0f) };
            GL.GenBuffers(1, out vbo_position);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.BufferData<Vector3>(BufferTarget.ArrayBuffer, (IntPtr)(vertdata.Length *
                                                                      Vector3.SizeInBytes), vertdata, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(attribute_vpos, 3, VertexAttribPointerType.Float, false, 0, 0);
           
            GL.Uniform3(uniform_pos, cameraPosition);
            GL.Uniform1(uniform_aspect, aspect);
            GL.UseProgram(BasicProgramID);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            GL.EnableClientState(ArrayCap.VertexArray);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo_position);
            GL.VertexPointer(3, VertexPointerType.Float, Vector3.SizeInBytes, 0);

            GL.DrawArrays(PrimitiveType.Quads, 0, vertdata.Length);
           
        }

        public void SetCubeMat(int i)
        {
            NextCubeMat = i;
        }

        public void SetSphereMat(int i)
        {
            NextSphereMat = i;
        }

        public void SetDepth(int i)
        {
            NextDepth = i;
        }

        public void SetTetrMat(int i)
        {
            NextTetrMat = i;
        }


        public void SetWalls(int i)
        {
            int location = GL.GetUniformLocation(BasicProgramID, "Walls");
            if (location != -1)
            {
                GL.Uniform1(location, i);
            }
        }
        public void SetCubeProp(float rl, float rr)
        {
            NextreflCube = rl;
            NextrefrCube = rr;
        }

        public void SetColCube(float x, float y, float z)
        {
            NextColCube = new Vector3(x, y, z);
        }

        public void SetSphereProp(float rl, float rr)
        {
            NextreflSph = rl;
            NextrefrSph = rr;
        }

        public void SetColSph(float x, float y, float z)
        {
            NextColBigSphere = new Vector3(x, y, z);
        }

        public void SetTetrProp(float rl, float rr)
        {
            NextreflTetr = rl;
            NextrefrTetr = rr;
        }

        public void SetColTetr(float x, float y, float z)
        {
            NextColTetr = new Vector3(x, y, z);
        }

        void loadShader(String filename, ShaderType type, uint program, out uint address)
        {
            address = (uint) GL.CreateShader(type);
            using (System.IO.StreamReader sr = new StreamReader(filename))
            {
                GL.ShaderSource((int) address, sr.ReadToEnd());
            }
            GL.CompileShader(address);
            GL.AttachShader(program, address);
            Console.WriteLine(GL.GetShaderInfoLog((int) address));
        }

        public void InitShader()
        {
            BasicProgramID = GL.CreateProgram(); // создание объекта программы
            loadShader("..\\..\\raytracing.vert", ShaderType.VertexShader, (uint) BasicProgramID,

                out BasicVertexShader);

            loadShader("..\\..\\raytracing.frag", ShaderType.FragmentShader, (uint) BasicProgramID,

                out BasicFragmentShader);
           
            int status = 0;

            GL.LinkProgram(BasicProgramID);
            // Проверяем успех компоновки

            GL.GetProgram(BasicProgramID, GetProgramParameterName.LinkStatus, out status);
            Console.WriteLine(GL.GetProgramInfoLog(BasicProgramID));
        }
    }
}

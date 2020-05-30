using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private View view = new View();

        public Form1()
        {
            InitializeComponent();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            view.Setup(glControl1.Width, glControl1.Height);

            view.InitShader();

        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            view.Update();

            glControl1.SwapBuffers();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            view.Setup(glControl1.Width, glControl1.Height);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetCubeMat(1);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetCubeMat(3);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetCubeMat(2);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetSphereMat(1);
                view.Update();

                glControl1.SwapBuffers();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z, refl, refr;
            if (reflcub.TextLength > 0)
            {
                if (double.TryParse(reflcub.Text, out refl))
                {
                    if (refl < 0.0)
                    {
                        reflcub.Text = "0,0";
                        refl = 0.0;
                    }
                }
                else
                {
                    reflcub.Text = "0,0";
                    refl = 0.0;
                }
            }
            else
            {
                reflcub.Text = "0,0";
                refl = 0.0;
            }

            if (refrcub.TextLength > 0)
            {
                if (double.TryParse(refrcub.Text, out refr))
                {
                    if (refr < 0.0)
                    {
                        refrcub.Text = "0,0";
                        refr = 0.0;
                    }
                }
                else
                {
                    refrcub.Text = "0,0";
                    refr = 0.0;
                }
            }
            else
            {
                refrcub.Text = "0,0";
                refr = 0.0;
            }

            
            view.SetCubeProp((float)refl, (float)refr);
            view.Update();

            glControl1.SwapBuffers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            depth.Text = trackBar1.Value.ToString();
            view.SetDepth(trackBar1.Value);
            view.Update();

            glControl1.SwapBuffers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z, refl, refr;
            if (reflsph.TextLength > 0)
            {
                if (double.TryParse(reflsph.Text, out refl))
                {
                    if (refl < 0.0)
                    {
                        reflsph.Text = "0,0";
                        refl = 0.0;
                    }
                }
                else
                {
                    reflsph.Text = "0,0";
                    refl = 0.0;
                }
            }
            else
            {
                reflsph.Text = "0,0";
                refl = 0.0;
            }

            if (refrsph.TextLength > 0)
            {
                if (double.TryParse(refrsph.Text, out refr))
                {
                    if (refr < 0.0)
                    {
                        refrsph.Text = "0,0";
                        refr = 0.0;
                    }
                }
                else
                {
                    refrsph.Text = "0,0";
                    refr  = 0.0;
                }
            }
            else
            {
                refrsph.Text = "0,0";
                refr = 0.0;
            }

            view.SetSphereProp((float)refl, (float)refr);
            view.Update();

            glControl1.SwapBuffers();
        }


        private void button5_Click(object sender, EventArgs e)
        {
        double x, y, z, refl, refr;
            if (refltet.TextLength > 0)
            {
                if (double.TryParse(refltet.Text, out refl))
                {
                    if (refl < 0.0)
                    {
                        refltet.Text = "0,0";
                        refl = 0.0;
                    }
                }
                else
                {
                    refltet.Text = "0,0";
                    refl = 0.0;
                }
            }
            else
            {
                refltet.Text = "0,0";
                refl = 0.0;
            }

            if (refrtet.TextLength > 0)
            {
                if (double.TryParse(refrtet.Text, out refr))
                {
                    if (refr < 0.0)
                    {
                        refrtet.Text = "0,0";
                        refr = 0.0;
                    }
                }
                else
                {
                    refrtet.Text = "0,0";
                    refr = 0.0;
                }
            }
            else
            {
                refrtet.Text = "0,0";
                refr = 0.0;
            }

            
            view.SetTetrProp((float)refl, (float)refr);
            view.Update();

            glControl1.SwapBuffers();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetWalls(1);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetWalls(2);
                view.Update();

                glControl1.SwapBuffers();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = labelCubeCol.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                labelCubeCol.BackColor = MyDialog.Color;

            view.SetColCube((float)(MyDialog.Color.R / 255f), (float)(MyDialog.Color.G / 255f), (float)(MyDialog.Color.B / 255f));
            view.Update();

            glControl1.SwapBuffers();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = labelSphCol.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                labelSphCol.BackColor = MyDialog.Color;

            view.SetColSph((float)(MyDialog.Color.R / 255f), (float)(MyDialog.Color.G / 255f), (float)(MyDialog.Color.B / 255f));
            view.Update();

            glControl1.SwapBuffers();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = labelTetCol.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                labelTetCol.BackColor = MyDialog.Color;

            view.SetColTetr((float)(MyDialog.Color.R / 255f), (float)(MyDialog.Color.G / 255f), (float)(MyDialog.Color.B / 255f)); view.Update();

            glControl1.SwapBuffers();

        }

        private void checkBoxTet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTet.Checked)
            {
                radioButton7.Show();
                radioButton8.Show();
                radioButton9.Show();
                labelTetCol.Show();
                button5.Show();
                button7.Show();
                label6.Show();
                label5.Show();
                refltet.Show();
                refrtet.Show();

                radioButton8.Checked = true;
            }
            else
            {
                view.SetTetrMat(0);
                view.Update();

                glControl1.SwapBuffers();

                radioButton7.Hide();
                radioButton8.Hide();
                radioButton9.Hide();
                labelTetCol.Hide();
                button5.Hide();
                button7.Hide();
                label6.Hide();
                label5.Hide();
                refltet.Hide();
                refrtet.Hide();
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
            }

        }

        private void checkBoxSph_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSph.Checked)
            {
                radioButton1.Show();
                button3.Show();
                radioButton5.Show();
                radioButton6.Show();
                labelSphCol.Show();
                button4.Show();
                label2.Show();
                label3.Show();
                reflsph.Show();
                refrsph.Show();

                radioButton1.Checked = true;
            }
            else
            {
                view.SetSphereMat(0);
                view.Update();

                glControl1.SwapBuffers();

                radioButton1.Hide();
                button3.Hide();
                radioButton5.Hide();
                radioButton6.Hide();
                labelSphCol.Hide();
                button4.Hide();
                label2.Hide();
                label3.Hide();
                reflsph.Hide();
                refrsph.Hide();
                radioButton1.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
            }

        }

        private void checkBoxCube_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCube.Checked)
            {
                radioButton2.Show();
                button2.Show();
                radioButton3.Show();
                radioButton4.Show();
                labelCubeCol.Show();
                button6.Show();
                label14.Show();
                label3.Show();
                reflcub.Show();
                refrcub.Show();

                radioButton2.Checked = true;
            }
            else
            {
                view.SetCubeMat(0);
                view.Update();

                glControl1.SwapBuffers();

                radioButton2.Hide();
                button2.Hide();
                radioButton3.Hide();
                radioButton4.Hide();
                labelCubeCol.Hide();
                button6.Hide();
                label14.Hide();
                label3.Hide();
                reflcub.Hide();
                refrcub.Hide();
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetSphereMat(2);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetSphereMat(3);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetTetrMat(1);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetTetrMat(2);
                view.Update();

                glControl1.SwapBuffers();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                view.SetTetrMat(3);
                view.Update();

                glControl1.SwapBuffers();
            }
        }
    }
}

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.depth = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTetCol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.refltet = new System.Windows.Forms.TextBox();
            this.checkBoxTet = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.refrtet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.labelSphCol = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBoxSph = new System.Windows.Forms.CheckBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.refrsph = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.reflsph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelCubeCol = new System.Windows.Forms.Label();
            this.checkBoxCube = new System.Windows.Forms.CheckBox();
            this.refrcub = new System.Windows.Forms.TextBox();
            this.reflcub = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(671, 553);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.depth);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(677, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 553);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // depth
            // 
            this.depth.BackColor = System.Drawing.Color.LightSlateGray;
            this.depth.Location = new System.Drawing.Point(261, 35);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(25, 45);
            this.depth.TabIndex = 16;
            this.depth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.radioButton18);
            this.groupBox6.Controls.Add(this.radioButton17);
            this.groupBox6.Location = new System.Drawing.Point(110, 86);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(212, 82);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(121, 47);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(86, 17);
            this.radioButton18.TabIndex = 1;
            this.radioButton18.Text = "Зеркальное";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Checked = true;
            this.radioButton17.Location = new System.Drawing.Point(22, 47);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(77, 17);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "Размытое";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(156, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "Глубина рейтрейсинга";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(283, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightSlateGray;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(59, 35);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(202, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.radioButton9);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.labelTetCol);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.radioButton8);
            this.groupBox5.Controls.Add(this.refltet);
            this.groupBox5.Controls.Add(this.checkBoxTet);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.radioButton7);
            this.groupBox5.Controls.Add(this.refrtet);
            this.groupBox5.Location = new System.Drawing.Point(6, 431);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(419, 116);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Изменить цвет";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(183, 48);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(144, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Text = "Зеркальное отражение";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Visible = false;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Преломление";
            this.label5.Visible = false;
            // 
            // labelTetCol
            // 
            this.labelTetCol.BackColor = System.Drawing.Color.Blue;
            this.labelTetCol.Location = new System.Drawing.Point(123, 81);
            this.labelTetCol.Name = "labelTetCol";
            this.labelTetCol.Size = new System.Drawing.Size(15, 15);
            this.labelTetCol.TabIndex = 18;
            this.labelTetCol.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отражение";
            this.label6.Visible = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(183, 24);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(135, 17);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.Text = "Размытое отражение";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Visible = false;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // refltet
            // 
            this.refltet.Location = new System.Drawing.Point(356, 23);
            this.refltet.Name = "refltet";
            this.refltet.Size = new System.Drawing.Size(41, 20);
            this.refltet.TabIndex = 15;
            this.refltet.Text = "0,5";
            this.refltet.Visible = false;
            // 
            // checkBoxTet
            // 
            this.checkBoxTet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTet.Location = new System.Drawing.Point(21, 23);
            this.checkBoxTet.Name = "checkBoxTet";
            this.checkBoxTet.Size = new System.Drawing.Size(102, 47);
            this.checkBoxTet.TabIndex = 17;
            this.checkBoxTet.Text = "Тэтраэдр";
            this.checkBoxTet.UseVisualStyleBackColor = true;
            this.checkBoxTet.CheckedChanged += new System.EventHandler(this.checkBoxTet_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Применить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(183, 72);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(95, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "Преломление";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // refrtet
            // 
            this.refrtet.Location = new System.Drawing.Point(356, 63);
            this.refrtet.Name = "refrtet";
            this.refrtet.Size = new System.Drawing.Size(41, 20);
            this.refrtet.TabIndex = 16;
            this.refrtet.Text = "1,0";
            this.refrtet.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.labelSphCol);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.checkBoxSph);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.refrsph);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.reflsph);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Изменить цвет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(184, 56);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(144, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Зеркальное отражение";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // labelSphCol
            // 
            this.labelSphCol.BackColor = System.Drawing.Color.Red;
            this.labelSphCol.ForeColor = System.Drawing.Color.Black;
            this.labelSphCol.Location = new System.Drawing.Point(123, 92);
            this.labelSphCol.Name = "labelSphCol";
            this.labelSphCol.Size = new System.Drawing.Size(15, 15);
            this.labelSphCol.TabIndex = 18;
            this.labelSphCol.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(184, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Размытое отражение";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBoxSph
            // 
            this.checkBoxSph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSph.Location = new System.Drawing.Point(21, 26);
            this.checkBoxSph.Name = "checkBoxSph";
            this.checkBoxSph.Size = new System.Drawing.Size(86, 47);
            this.checkBoxSph.TabIndex = 17;
            this.checkBoxSph.Text = "Сфера";
            this.checkBoxSph.UseVisualStyleBackColor = true;
            this.checkBoxSph.CheckedChanged += new System.EventHandler(this.checkBoxSph_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(184, 80);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(95, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Преломление";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // refrsph
            // 
            this.refrsph.Location = new System.Drawing.Point(357, 70);
            this.refrsph.Name = "refrsph";
            this.refrsph.Size = new System.Drawing.Size(41, 20);
            this.refrsph.TabIndex = 16;
            this.refrsph.Text = "1,0";
            this.refrsph.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Применить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reflsph
            // 
            this.reflsph.Location = new System.Drawing.Point(357, 30);
            this.reflsph.Name = "reflsph";
            this.reflsph.Size = new System.Drawing.Size(41, 20);
            this.reflsph.TabIndex = 15;
            this.reflsph.Text = "0,5";
            this.reflsph.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Отражение";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Преломление";
            this.label3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.labelCubeCol);
            this.groupBox2.Controls.Add(this.checkBoxCube);
            this.groupBox2.Controls.Add(this.refrcub);
            this.groupBox2.Controls.Add(this.reflcub);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(6, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Изменить цвет";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelCubeCol
            // 
            this.labelCubeCol.BackColor = System.Drawing.Color.Lime;
            this.labelCubeCol.Location = new System.Drawing.Point(123, 78);
            this.labelCubeCol.Name = "labelCubeCol";
            this.labelCubeCol.Size = new System.Drawing.Size(15, 15);
            this.labelCubeCol.TabIndex = 18;
            this.labelCubeCol.Visible = false;
            // 
            // checkBoxCube
            // 
            this.checkBoxCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCube.Location = new System.Drawing.Point(21, 26);
            this.checkBoxCube.Name = "checkBoxCube";
            this.checkBoxCube.Size = new System.Drawing.Size(85, 47);
            this.checkBoxCube.TabIndex = 17;
            this.checkBoxCube.Text = "Куб";
            this.checkBoxCube.UseVisualStyleBackColor = true;
            this.checkBoxCube.CheckedChanged += new System.EventHandler(this.checkBoxCube_CheckedChanged);
            // 
            // refrcub
            // 
            this.refrcub.Location = new System.Drawing.Point(356, 66);
            this.refrcub.Name = "refrcub";
            this.refrcub.Size = new System.Drawing.Size(41, 20);
            this.refrcub.TabIndex = 16;
            this.refrcub.Text = "1,0";
            this.refrcub.Visible = false;
            // 
            // reflcub
            // 
            this.reflcub.Location = new System.Drawing.Point(356, 26);
            this.reflcub.Name = "reflcub";
            this.reflcub.Size = new System.Drawing.Size(41, 20);
            this.reflcub.TabIndex = 15;
            this.reflcub.Text = "0,5";
            this.reflcub.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Преломление";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Отражение";
            this.label13.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(183, 76);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Преломление";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(183, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Зеркальное отражение";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Размытое отражение";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип отражения стен";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.glControl1);
            this.MinimumSize = new System.Drawing.Size(1007, 567);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox refrcub;
        private System.Windows.Forms.TextBox reflcub;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.CheckBox checkBoxCube;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTetCol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.TextBox refltet;
        private System.Windows.Forms.CheckBox checkBoxTet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TextBox refrtet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label labelSphCol;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBoxSph;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox refrsph;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox reflsph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelCubeCol;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
    }
}


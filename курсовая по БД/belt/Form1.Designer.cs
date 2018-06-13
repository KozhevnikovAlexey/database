namespace belt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.moshnost = new System.Windows.Forms.Label();
            this.Moshnost_znachenie = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Speed_znachenie = new System.Windows.Forms.TextBox();
            this.Speed = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.poiskaa_m = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moshnost
            // 
            this.moshnost.BackColor = System.Drawing.Color.Transparent;
            this.moshnost.Location = new System.Drawing.Point(26, 176);
            this.moshnost.Name = "moshnost";
            this.moshnost.Size = new System.Drawing.Size(117, 19);
            this.moshnost.TabIndex = 0;
            this.moshnost.Text = "Мощность ( < 50)";
            this.moshnost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moshnost.Click += new System.EventHandler(this.moshnost_Click);
            // 
            // Moshnost_znachenie
            // 
            this.Moshnost_znachenie.Location = new System.Drawing.Point(173, 176);
            this.Moshnost_znachenie.Name = "Moshnost_znachenie";
            this.Moshnost_znachenie.Size = new System.Drawing.Size(51, 20);
            this.Moshnost_znachenie.TabIndex = 1;
            this.Moshnost_znachenie.Text = "1";
            this.Moshnost_znachenie.TextChanged += new System.EventHandler(this.Moshnost_znachenie_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(274, 232);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Minimum = 70;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(249, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 180;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(274, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Угол обхвата = 110 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton17);
            this.groupBox3.Controls.Add(this.radioButton16);
            this.groupBox3.Controls.Add(this.radioButton15);
            this.groupBox3.Controls.Add(this.radioButton14);
            this.groupBox3.Controls.Add(this.radioButton13);
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Location = new System.Drawing.Point(25, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 179);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Характер нагрузки и тип приводного двигателя";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(160, 96);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(130, 17);
            this.radioButton17.TabIndex = 7;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "Ударная нагрузка(2)";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(160, 73);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(130, 17);
            this.radioButton16.TabIndex = 6;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "Ударная нагрузка(1)";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(160, 50);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(157, 17);
            this.radioButton15.TabIndex = 5;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "Значительная нагрузка(2)";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(160, 27);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(157, 17);
            this.radioButton14.TabIndex = 4;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Значительная нагрузка(1)";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(6, 96);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(144, 17);
            this.radioButton13.TabIndex = 3;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Умеренная нагрузка(2)";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 73);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(144, 17);
            this.radioButton12.TabIndex = 2;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Умеренная нагрузка(1)";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 50);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(141, 17);
            this.radioButton11.TabIndex = 1;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Спокойная нагрузка(2)";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 27);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(141, 17);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Спокойная нагрузка(1)";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(561, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Speed_znachenie
            // 
            this.Speed_znachenie.Location = new System.Drawing.Point(173, 209);
            this.Speed_znachenie.Name = "Speed_znachenie";
            this.Speed_znachenie.Size = new System.Drawing.Size(51, 20);
            this.Speed_znachenie.TabIndex = 31;
            this.Speed_znachenie.Text = "1";
            this.Speed_znachenie.TextChanged += new System.EventHandler(this.Speed_znachenie_TextChanged);
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.SystemColors.Control;
            this.Speed.Location = new System.Drawing.Point(26, 209);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(117, 19);
            this.Speed.TabIndex = 30;
            this.Speed.Text = "Скорость ( < 35)";
            this.Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Speed.Click += new System.EventHandler(this.label19_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton20);
            this.groupBox4.Controls.Add(this.radioButton21);
            this.groupBox4.Location = new System.Drawing.Point(25, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 60);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Площадь сечения (S10)";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(9, 39);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(43, 17);
            this.radioButton20.TabIndex = 1;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "330";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(9, 16);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(37, 17);
            this.radioButton21.TabIndex = 0;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "60";
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton21.CheckedChanged += new System.EventHandler(this.radioButton21_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton18);
            this.groupBox5.Controls.Add(this.radioButton19);
            this.groupBox5.Controls.Add(this.radioButton22);
            this.groupBox5.Controls.Add(this.radioButton23);
            this.groupBox5.Location = new System.Drawing.Point(561, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 115);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Предаточное число";
            this.groupBox5.Visible = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(11, 84);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(37, 17);
            this.radioButton18.TabIndex = 3;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = ">3";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(11, 62);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(40, 17);
            this.radioButton19.TabIndex = 2;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "1,5";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(11, 39);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(46, 17);
            this.radioButton22.TabIndex = 1;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "1,20";
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton22_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(11, 16);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(46, 17);
            this.radioButton23.TabIndex = 0;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "1,05";
            this.radioButton23.UseVisualStyleBackColor = true;
            this.radioButton23.CheckedChanged += new System.EventHandler(this.radioButton23_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton28);
            this.groupBox6.Controls.Add(this.radioButton29);
            this.groupBox6.Controls.Add(this.radioButton24);
            this.groupBox6.Controls.Add(this.radioButton25);
            this.groupBox6.Controls.Add(this.radioButton26);
            this.groupBox6.Controls.Add(this.radioButton27);
            this.groupBox6.Location = new System.Drawing.Point(394, 333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 179);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выбор длины ремня";
            this.groupBox6.Visible = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.Location = new System.Drawing.Point(3, 131);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(49, 17);
            this.radioButton28.TabIndex = 5;
            this.radioButton28.TabStop = true;
            this.radioButton28.Text = "2625";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.Location = new System.Drawing.Point(3, 108);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(49, 17);
            this.radioButton29.TabIndex = 4;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "2250";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(3, 85);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(49, 17);
            this.radioButton24.TabIndex = 3;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "1875";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(3, 62);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(49, 17);
            this.radioButton25.TabIndex = 2;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "1500";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(3, 39);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(49, 17);
            this.radioButton26.TabIndex = 1;
            this.radioButton26.TabStop = true;
            this.radioButton26.Text = "1150";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(3, 16);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(43, 17);
            this.radioButton27.TabIndex = 0;
            this.radioButton27.TabStop = true;
            this.radioButton27.Text = "750";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton30);
            this.groupBox7.Controls.Add(this.radioButton31);
            this.groupBox7.Controls.Add(this.radioButton32);
            this.groupBox7.Controls.Add(this.radioButton33);
            this.groupBox7.Controls.Add(this.radioButton34);
            this.groupBox7.Controls.Add(this.radioButton35);
            this.groupBox7.Location = new System.Drawing.Point(394, 333);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(129, 179);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Выбор длины ремня";
            this.groupBox7.Visible = false;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(3, 131);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(49, 17);
            this.radioButton30.TabIndex = 5;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "5250";
            this.radioButton30.UseVisualStyleBackColor = true;
            this.radioButton30.CheckedChanged += new System.EventHandler(this.radioButton30_CheckedChanged);
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.Location = new System.Drawing.Point(3, 108);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(49, 17);
            this.radioButton31.TabIndex = 4;
            this.radioButton31.TabStop = true;
            this.radioButton31.Text = "4500";
            this.radioButton31.UseVisualStyleBackColor = true;
            this.radioButton31.CheckedChanged += new System.EventHandler(this.radioButton31_CheckedChanged);
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Location = new System.Drawing.Point(3, 85);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(49, 17);
            this.radioButton32.TabIndex = 3;
            this.radioButton32.TabStop = true;
            this.radioButton32.Text = "3750";
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.Location = new System.Drawing.Point(3, 62);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(49, 17);
            this.radioButton33.TabIndex = 2;
            this.radioButton33.TabStop = true;
            this.radioButton33.Text = "3000";
            this.radioButton33.UseVisualStyleBackColor = true;
            this.radioButton33.CheckedChanged += new System.EventHandler(this.radioButton33_CheckedChanged);
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.Location = new System.Drawing.Point(3, 39);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(49, 17);
            this.radioButton34.TabIndex = 1;
            this.radioButton34.TabStop = true;
            this.radioButton34.Text = "2250";
            this.radioButton34.UseVisualStyleBackColor = true;
            this.radioButton34.CheckedChanged += new System.EventHandler(this.radioButton34_CheckedChanged);
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.Location = new System.Drawing.Point(3, 16);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(49, 17);
            this.radioButton35.TabIndex = 0;
            this.radioButton35.TabStop = true;
            this.radioButton35.Text = "1500";
            this.radioButton35.UseVisualStyleBackColor = true;
            this.radioButton35.CheckedChanged += new System.EventHandler(this.radioButton35_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(561, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 67);
            this.button2.TabIndex = 38;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(561, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 67);
            this.button3.TabIndex = 39;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // poiskaa_m
            // 
            this.poiskaa_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poiskaa_m.Location = new System.Drawing.Point(806, 401);
            this.poiskaa_m.Name = "poiskaa_m";
            this.poiskaa_m.Size = new System.Drawing.Size(206, 31);
            this.poiskaa_m.TabIndex = 43;
            this.poiskaa_m.Visible = false;
            this.poiskaa_m.TextChanged += new System.EventHandler(this.poiskaa_m_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Z",
            "F",
            "N",
            "V",
            "S10",
            "SIGMA_F",
            "DEL_SIG_F",
            "DEL_SIG_ n",
            "DP1",
            "C1",
            "C3",
            "CL"});
            this.listBox1.Location = new System.Drawing.Point(806, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 108);
            this.listBox1.TabIndex = 48;
            this.listBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Location = new System.Drawing.Point(806, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 105);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            this.groupBox1.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(91, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "<=";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(11, 62);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "=";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(11, 39);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = ">";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(11, 16);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(31, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "<";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(91, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = ">=";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(806, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 67);
            this.button4.TabIndex = 50;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(958, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 66);
            this.button5.TabIndex = 51;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 518);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.poiskaa_m);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Speed_znachenie);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Moshnost_znachenie);
            this.Controls.Add(this.moshnost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moshnost;
        private System.Windows.Forms.TextBox Moshnost_znachenie;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Speed_znachenie;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton28;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton31;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.RadioButton radioButton33;
        private System.Windows.Forms.RadioButton radioButton34;
        private System.Windows.Forms.RadioButton radioButton35;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox poiskaa_m;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


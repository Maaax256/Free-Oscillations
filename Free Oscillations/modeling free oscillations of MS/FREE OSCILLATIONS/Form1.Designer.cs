
namespace FREE_OSCILLATIONS
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
                
                if (cyl1 != null)
                cyl1.Dispose();
                
                if (d3d != null)
                d3d.Dispose();
            }
            // Освобождаем занятые ранее ресурсы
            
           
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
            this.My_menuStrip = new System.Windows.Forms.MenuStrip();
            this.механізмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намалюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стертиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зупинитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рухатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графікКоливаньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DU_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.My_menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // My_menuStrip
            // 
            this.My_menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.My_menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.My_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.My_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.механізмToolStripMenuItem,
            this.графікКоливаньToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.My_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.My_menuStrip.Name = "My_menuStrip";
            this.My_menuStrip.Size = new System.Drawing.Size(1318, 36);
            this.My_menuStrip.TabIndex = 0;
            this.My_menuStrip.Text = "menuStrip2";
            // 
            // механізмToolStripMenuItem
            // 
            this.механізмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.намалюватиToolStripMenuItem,
            this.стертиToolStripMenuItem,
            this.зупинитиToolStripMenuItem,
            this.рухатиToolStripMenuItem});
            this.механізмToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.механізмToolStripMenuItem.Name = "механізмToolStripMenuItem";
            this.механізмToolStripMenuItem.Size = new System.Drawing.Size(125, 32);
            this.механізмToolStripMenuItem.Text = "Mechanism";
            // 
            // намалюватиToolStripMenuItem
            // 
            this.намалюватиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.намалюватиToolStripMenuItem.Name = "намалюватиToolStripMenuItem";
            this.намалюватиToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.намалюватиToolStripMenuItem.Text = "Draw";
            this.намалюватиToolStripMenuItem.Click += new System.EventHandler(this.намалюватиToolStripMenuItem_Click);
            // 
            // стертиToolStripMenuItem
            // 
            this.стертиToolStripMenuItem.Enabled = false;
            this.стертиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.стертиToolStripMenuItem.Name = "стертиToolStripMenuItem";
            this.стертиToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.стертиToolStripMenuItem.Text = "Erase";
            this.стертиToolStripMenuItem.Click += new System.EventHandler(this.стертиToolStripMenuItem_Click);
            // 
            // зупинитиToolStripMenuItem
            // 
            this.зупинитиToolStripMenuItem.Enabled = false;
            this.зупинитиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.зупинитиToolStripMenuItem.Name = "зупинитиToolStripMenuItem";
            this.зупинитиToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.зупинитиToolStripMenuItem.Text = "Stop";
            this.зупинитиToolStripMenuItem.Click += new System.EventHandler(this.зупинитиToolStripMenuItem_Click_1);
            // 
            // рухатиToolStripMenuItem
            // 
            this.рухатиToolStripMenuItem.Enabled = false;
            this.рухатиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.рухатиToolStripMenuItem.Name = "рухатиToolStripMenuItem";
            this.рухатиToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.рухатиToolStripMenuItem.Text = "Start motion";
            this.рухатиToolStripMenuItem.Click += new System.EventHandler(this.рухатиToolStripMenuItem_Click_1);
            // 
            // графікКоливаньToolStripMenuItem
            // 
            this.графікКоливаньToolStripMenuItem.Enabled = false;
            this.графікКоливаньToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.графікКоливаньToolStripMenuItem.Name = "графікКоливаньToolStripMenuItem";
            this.графікКоливаньToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.графікКоливаньToolStripMenuItem.Text = "Оscillation chart";
            this.графікКоливаньToolStripMenuItem.Click += new System.EventHandler(this.графікКоливаньToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(57, 32);
            this.вихідToolStripMenuItem.Text = "Exit";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.DU_label);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.numericUpDown9);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDown8);
            this.panel1.Controls.Add(this.numericUpDown7);
            this.panel1.Controls.Add(this.numericUpDown6);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 129);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(633, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 18);
            this.label22.TabIndex = 45;
            this.label22.Text = "м";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(398, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 18);
            this.label19.TabIndex = 45;
            this.label19.Text = "рад";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(166, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 18);
            this.label16.TabIndex = 45;
            this.label16.Text = "с";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(165, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "с";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Location = new System.Drawing.Point(632, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 18);
            this.label21.TabIndex = 44;
            this.label21.Text = "м";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(397, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 18);
            this.label18.TabIndex = 44;
            this.label18.Text = "м";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(165, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 18);
            this.label15.TabIndex = 44;
            this.label15.Text = "кг";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(164, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "кг";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Location = new System.Drawing.Point(632, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 18);
            this.label20.TabIndex = 43;
            this.label20.Text = "Н/см";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(397, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 18);
            this.label17.TabIndex = 43;
            this.label17.Text = "м";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(165, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 18);
            this.label14.TabIndex = 43;
            this.label14.Text = "кг";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(164, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "кг";
            // 
            // DU_label
            // 
            this.DU_label.AutoSize = true;
            this.DU_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DU_label.ForeColor = System.Drawing.Color.Navy;
            this.DU_label.Location = new System.Drawing.Point(718, 96);
            this.DU_label.Name = "DU_label";
            this.DU_label.Size = new System.Drawing.Size(30, 24);
            this.DU_label.TabIndex = 42;
            this.DU_label.Text = "f =";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(961, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 74);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Navy;
            this.radioButton1.Location = new System.Drawing.Point(11, 35);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Solid";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(115, 35);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Wireframe";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown9.DecimalPlaces = 2;
            this.numericUpDown9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown9.Location = new System.Drawing.Point(537, 94);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown9.TabIndex = 18;
            this.numericUpDown9.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown9_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(500, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "f=";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown8.DecimalPlaces = 2;
            this.numericUpDown8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown8.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown8.Location = new System.Drawing.Point(304, 95);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            157,
            0,
            0,
            131072});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            157,
            0,
            0,
            -2147352576});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown8.TabIndex = 16;
            this.numericUpDown8.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown7.Location = new System.Drawing.Point(70, 93);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown7.TabIndex = 15;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown6.Location = new System.Drawing.Point(537, 52);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown6.TabIndex = 14;
            this.numericUpDown6.Value = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown5.Location = new System.Drawing.Point(537, 8);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown5.TabIndex = 13;
            this.numericUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown4.Location = new System.Drawing.Point(302, 55);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown4.TabIndex = 12;
            this.numericUpDown4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(302, 11);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown3.TabIndex = 11;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown2.Location = new System.Drawing.Point(69, 53);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown1.Location = new System.Drawing.Point(69, 9);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 30);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(243, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "fi_0=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(13, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "t_0=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(476, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "alfa=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(497, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "с=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(262, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "R=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(261, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "L=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(261, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "R=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "m2=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "m1=";
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1297, 36);
            this.vScrollBar1.Maximum = 90;
            this.vScrollBar1.Minimum = -90;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 518);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 683);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.My_menuStrip);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.My_menuStrip;
            this.Name = "Form1";
            this.Text = "Information technology for modeling free oscillations of  a mechanical system";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.My_menuStrip.ResumeLayout(false);
            this.My_menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.MenuStrip My_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem механізмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намалюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стертиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рухатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зупинитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графікКоливаньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label DU_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}


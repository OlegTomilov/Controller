namespace ChinaTest
{
    partial class SettingsMotorWindow
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            comboBox5 = new ComboBox();
            label11 = new Label();
            comboBox6 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            comboBox7 = new ComboBox();
            label15 = new Label();
            comboBox8 = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            comboBox9 = new ComboBox();
            label19 = new Label();
            comboBox10 = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            comboBox11 = new ComboBox();
            label23 = new Label();
            comboBox12 = new ComboBox();
            label24 = new Label();
            label25 = new Label();
            comboBox13 = new ComboBox();
            comboBox14 = new ComboBox();
            comboBox15 = new ComboBox();
            comboBox16 = new ComboBox();
            comboBox17 = new ComboBox();
            comboBox18 = new ComboBox();
            comboBox19 = new ComboBox();
            button2 = new Button();
            comboBox20 = new ComboBox();
            comboBox21 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 1;
            label2.Text = "Передаточное \r\nотношение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Деление шага";
            // 
            // button1
            // 
            button1.Location = new Point(74, 350);
            button1.Name = "button1";
            button1.Size = new Size(111, 55);
            button1.TabIndex = 7;
            button1.Text = "Colculate X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_X;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 147);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Шаг угла";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 85);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 8;
            label5.Text = "Тип подвижки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 118);
            label6.Name = "label6";
            label6.Size = new Size(136, 19);
            label6.TabIndex = 10;
            label6.Text = "Единица измерения";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TranslationStage", "RotaryStage", "GoniometrStage" });
            comboBox1.Location = new Point(154, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(71, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "mm", "Degree", "Step" });
            comboBox2.Location = new Point(154, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(71, 23);
            comboBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(74, 32);
            label7.Name = "label7";
            label7.Size = new Size(35, 37);
            label7.TabIndex = 13;
            label7.Text = "Х";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "8", "4", "2", "1" });
            comboBox3.Location = new Point(154, 172);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(72, 23);
            comboBox3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 214);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 15;
            label8.Text = "Шаг винта";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0.5", "1", "1.5", "4", "5" });
            comboBox4.Location = new Point(154, 206);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(72, 23);
            comboBox4.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 281);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 17;
            label9.Text = "Длина подвижки";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(296, 281);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 32;
            label10.Text = "Длина подвижки";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "0.5", "1", "1.5", "4", "5" });
            comboBox5.Location = new Point(438, 206);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(71, 23);
            comboBox5.TabIndex = 31;
            comboBox5.SelectedIndexChanged += comboBox5_ScrewLeadY;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 214);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 30;
            label11.Text = "Шаг винта";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "8", "4", "2", "1" });
            comboBox6.Location = new Point(438, 172);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(71, 23);
            comboBox6.TabIndex = 29;
            comboBox6.SelectedIndexChanged += comboBox6_SubdivisionY;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(358, 32);
            label12.Name = "label12";
            label12.Size = new Size(33, 37);
            label12.TabIndex = 28;
            label12.Text = "Y";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(296, 147);
            label13.Name = "label13";
            label13.Size = new Size(64, 19);
            label13.TabIndex = 19;
            label13.Text = "Шаг угла";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(296, 118);
            label14.Name = "label14";
            label14.Size = new Size(136, 19);
            label14.TabIndex = 25;
            label14.Text = "Единица измерения";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "mm", "Degree", "Step" });
            comboBox7.Location = new Point(438, 114);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(71, 23);
            comboBox7.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(296, 85);
            label15.Name = "label15";
            label15.Size = new Size(100, 19);
            label15.TabIndex = 24;
            label15.Text = "Тип подвижки";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "TranslationStage", "RotaryStage", "GoniometrStage" });
            comboBox8.Location = new Point(438, 85);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(71, 23);
            comboBox8.TabIndex = 26;
            comboBox8.SelectedIndexChanged += comboBox8_StageTypeY;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(296, 181);
            label16.Name = "label16";
            label16.Size = new Size(85, 15);
            label16.TabIndex = 21;
            label16.Text = "Деление шага";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(296, 243);
            label17.Name = "label17";
            label17.Size = new Size(89, 30);
            label17.TabIndex = 20;
            label17.Text = "Передаточное \r\nотношение";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(569, 281);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 47;
            label18.Text = "Длина подвижки";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "0.5", "1", "1.5", "4", "5" });
            comboBox9.Location = new Point(711, 206);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(72, 23);
            comboBox9.TabIndex = 46;
            comboBox9.SelectedIndexChanged += comboBox9_ScrewLeadZ;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(569, 214);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 45;
            label19.Text = "Шаг винта";
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "8", "4", "2", "1" });
            comboBox10.Location = new Point(711, 172);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(72, 23);
            comboBox10.TabIndex = 44;
            comboBox10.SelectedIndexChanged += comboBox10_SubdivisionZ;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(631, 32);
            label20.Name = "label20";
            label20.Size = new Size(33, 37);
            label20.TabIndex = 43;
            label20.Text = "Z";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(569, 147);
            label21.Name = "label21";
            label21.Size = new Size(64, 19);
            label21.TabIndex = 34;
            label21.Text = "Шаг угла";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(569, 118);
            label22.Name = "label22";
            label22.Size = new Size(136, 19);
            label22.TabIndex = 40;
            label22.Text = "Единица измерения";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "mm", "Degree", "Step" });
            comboBox11.Location = new Point(711, 114);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(72, 23);
            comboBox11.TabIndex = 42;
            comboBox11.SelectedIndexChanged += comboBox11_RuningUnitZ;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(569, 85);
            label23.Name = "label23";
            label23.Size = new Size(100, 19);
            label23.TabIndex = 39;
            label23.Text = "Тип подвижки";
            // 
            // comboBox12
            // 
            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "TranslationStage", "RotaryStage", "GoniometrStage" });
            comboBox12.Location = new Point(711, 85);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(72, 23);
            comboBox12.TabIndex = 41;
            comboBox12.SelectedIndexChanged += comboBox12_StageTypeZ;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(569, 181);
            label24.Name = "label24";
            label24.Size = new Size(85, 15);
            label24.TabIndex = 36;
            label24.Text = "Деление шага";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(569, 243);
            label25.Name = "label25";
            label25.Size = new Size(89, 30);
            label25.TabIndex = 35;
            label25.Text = "Передаточное \r\nотношение";
            // 
            // comboBox13
            // 
            comboBox13.FormattingEnabled = true;
            comboBox13.Items.AddRange(new object[] { "1.8", "0.9" });
            comboBox13.Location = new Point(154, 143);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(71, 23);
            comboBox13.TabIndex = 49;
            // 
            // comboBox14
            // 
            comboBox14.FormattingEnabled = true;
            comboBox14.Items.AddRange(new object[] { "1.8", "0.9" });
            comboBox14.Location = new Point(438, 143);
            comboBox14.Name = "comboBox14";
            comboBox14.Size = new Size(71, 23);
            comboBox14.TabIndex = 50;
            comboBox14.SelectedIndexChanged += comboBox14_StepperAngleY;
            // 
            // comboBox15
            // 
            comboBox15.FormattingEnabled = true;
            comboBox15.Items.AddRange(new object[] { "1.8", "0.9" });
            comboBox15.Location = new Point(711, 143);
            comboBox15.Name = "comboBox15";
            comboBox15.Size = new Size(72, 23);
            comboBox15.TabIndex = 51;
            comboBox15.SelectedIndexChanged += comboBox15_StepperAngleZ;
            // 
            // comboBox16
            // 
            comboBox16.FormattingEnabled = true;
            comboBox16.Items.AddRange(new object[] { "20", "25", "50", "100", "250", "300", "400", "500", "600", "850", "1000" });
            comboBox16.Location = new Point(155, 273);
            comboBox16.Name = "comboBox16";
            comboBox16.Size = new Size(71, 23);
            comboBox16.TabIndex = 52;
            // 
            // comboBox17
            // 
            comboBox17.FormattingEnabled = true;
            comboBox17.Items.AddRange(new object[] { "72", "90", "180", "360", "252", "576", "6", "352", "400", "720" });
            comboBox17.Location = new Point(155, 240);
            comboBox17.Name = "comboBox17";
            comboBox17.Size = new Size(70, 23);
            comboBox17.TabIndex = 53;
            comboBox17.SelectedIndexChanged += comboBox17_TransmoccionRatio;
            // 
            // comboBox18
            // 
            comboBox18.FormattingEnabled = true;
            comboBox18.Items.AddRange(new object[] { "72", "90", "180", "360", "252", "576", "6", "352", "400", "720" });
            comboBox18.Location = new Point(438, 240);
            comboBox18.Name = "comboBox18";
            comboBox18.Size = new Size(71, 23);
            comboBox18.TabIndex = 54;
            comboBox18.SelectedIndexChanged += comboBox18_TransmissionRatioY;
            // 
            // comboBox19
            // 
            comboBox19.FormattingEnabled = true;
            comboBox19.Items.AddRange(new object[] { "20", "25", "50", "100", "250", "300", "400", "500", "600", "850", "1000" });
            comboBox19.Location = new Point(438, 273);
            comboBox19.Name = "comboBox19";
            comboBox19.Size = new Size(71, 23);
            comboBox19.TabIndex = 55;
            comboBox19.SelectedIndexChanged += comboBox19_TravelRangeY;
            // 
            // button2
            // 
            button2.Location = new Point(358, 350);
            button2.Name = "button2";
            button2.Size = new Size(111, 55);
            button2.TabIndex = 56;
            button2.Text = "Colculate Y";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Y;
            // 
            // comboBox20
            // 
            comboBox20.FormattingEnabled = true;
            comboBox20.Items.AddRange(new object[] { "72", "90", "180", "360", "252", "576", "6", "352", "400", "720" });
            comboBox20.Location = new Point(711, 243);
            comboBox20.Name = "comboBox20";
            comboBox20.Size = new Size(72, 23);
            comboBox20.TabIndex = 57;
            comboBox20.SelectedIndexChanged += comboBox20_TransmissionRatioZ;
            // 
            // comboBox21
            // 
            comboBox21.FormattingEnabled = true;
            comboBox21.Items.AddRange(new object[] { "20", "25", "50", "100", "250", "300", "400", "500", "600", "850", "1000" });
            comboBox21.Location = new Point(711, 273);
            comboBox21.Name = "comboBox21";
            comboBox21.Size = new Size(73, 23);
            comboBox21.TabIndex = 58;
            comboBox21.SelectedIndexChanged += comboBox21_TravelRangeZ;
            // 
            // button3
            // 
            button3.Location = new Point(594, 350);
            button3.Name = "button3";
            button3.Size = new Size(111, 55);
            button3.TabIndex = 59;
            button3.Text = "Colculate Z";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Z;
            // 
            // SettingsMotorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(comboBox21);
            Controls.Add(comboBox20);
            Controls.Add(button2);
            Controls.Add(comboBox19);
            Controls.Add(comboBox18);
            Controls.Add(comboBox17);
            Controls.Add(comboBox16);
            Controls.Add(comboBox15);
            Controls.Add(comboBox14);
            Controls.Add(comboBox13);
            Controls.Add(label18);
            Controls.Add(comboBox9);
            Controls.Add(label19);
            Controls.Add(comboBox10);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(comboBox11);
            Controls.Add(label23);
            Controls.Add(comboBox12);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label10);
            Controls.Add(comboBox5);
            Controls.Add(label11);
            Controls.Add(comboBox6);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(comboBox7);
            Controls.Add(label15);
            Controls.Add(comboBox8);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(comboBox4);
            Controls.Add(label8);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SettingsMotorWindow";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox4;
        private Label label9;
        private Label label10;
        private ComboBox comboBox5;
        private Label label11;
        private ComboBox comboBox6;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox comboBox7;
        private Label label15;
        private ComboBox comboBox8;
        private Label label16;
        private Label label17;
        private Label label18;
        private ComboBox comboBox9;
        private Label label19;
        private ComboBox comboBox10;
        private Label label20;
        private Label label21;
        private Label label22;
        private ComboBox comboBox11;
        private Label label23;
        private ComboBox comboBox12;
        private Label label24;
        private Label label25;
        private ComboBox comboBox13;
        private ComboBox comboBox14;
        private ComboBox comboBox15;
        private ComboBox comboBox16;
        private ComboBox comboBox17;
        private ComboBox comboBox18;
        private ComboBox comboBox19;
        private Button button2;
        private ComboBox comboBox20;
        private ComboBox comboBox21;
        private Button button3;
    }
}
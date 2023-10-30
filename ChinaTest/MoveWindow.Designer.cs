namespace ChinaTest
{
    partial class MoveWindow
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
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(33, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "X";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_X;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(33, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Y";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_Y;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(33, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Z";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_Z;
            // 
            // button1
            // 
            button1.Location = new Point(261, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Home;
            // 
            // button2
            // 
            button2.Location = new Point(261, 73);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Stop;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "100";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextSpeed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Скорость:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextPoint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(551, 66);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Точка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 28);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 11;
            label4.Text = "Текущая позиция Х";
            // 
            // button3
            // 
            button3.Location = new Point(621, 109);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Рун";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Run;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 56);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 13;
            label5.Text = "Текущая позиция Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 81);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 14;
            label6.Text = "Текущая позиция Z";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "2", "1", "0.5", "0.1", "0.05", "0.01", "0.005", "0.001" });
            comboBox1.Location = new Point(261, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 210);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 20;
            label3.Text = "Шаг ручного перемещения: ";
            // 
            // MoveWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "MoveWindow";
            Text = "MoveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Button button3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label3;
    }
}
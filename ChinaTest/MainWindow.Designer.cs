namespace ChinaTest
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 70);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите порт:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_Port;
            // 
            // button1
            // 
            button1.Location = new Point(148, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Connect;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 70);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Статус подключения";
            // 
            // button2
            // 
            button2.Location = new Point(88, 257);
            button2.Name = "button2";
            button2.Size = new Size(96, 63);
            button2.TabIndex = 4;
            button2.Text = "Настройки двигателя";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_OpenSttingsWindow;
            // 
            // button3
            // 
            button3.Location = new Point(280, 257);
            button3.Name = "button3";
            button3.Size = new Size(104, 63);
            button3.TabIndex = 5;
            button3.Text = "Управление подвижками";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_OpenMoveWindow;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Form1";
            FormClosed += MainWindow_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}
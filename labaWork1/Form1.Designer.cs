namespace labaWork1
{
    partial class Form1
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
            program = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // program
            // 
            program.FlatAppearance.BorderColor = Color.Black;
            program.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            program.Location = new Point(12, 33);
            program.Margin = new Padding(3, 4, 3, 4);
            program.Name = "program";
            program.Size = new Size(247, 165);
            program.TabIndex = 0;
            program.Text = "О программе ";
            program.UseVisualStyleBackColor = true;
            program.Click += program_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(306, 33);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(280, 165);
            button1.TabIndex = 1;
            button1.Text = "Задание лаб работа";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(963, 33);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(247, 165);
            button2.TabIndex = 2;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(637, 33);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(280, 165);
            button3.TabIndex = 3;
            button3.Text = "Задание дз";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 252);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(program);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2168, 1118);
            Name = "Form1";
            Text = "Лабораторная работа 1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button program;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

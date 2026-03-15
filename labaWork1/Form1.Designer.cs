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
            SuspendLayout();
            // 
            // program
            // 
            program.FlatAppearance.BorderColor = Color.Black;
            program.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            program.Location = new Point(104, 315);
            program.Name = "program";
            program.Size = new Size(216, 124);
            program.TabIndex = 0;
            program.Text = "О программе ";
            program.UseVisualStyleBackColor = true;
            program.Click += program_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(818, 315);
            button1.Name = "button1";
            button1.Size = new Size(216, 124);
            button1.TabIndex = 1;
            button1.Text = "Задание";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(1482, 315);
            button2.Name = "button2";
            button2.Size = new Size(216, 124);
            button2.TabIndex = 2;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1883, 811);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(program);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1899, 850);
            MinimumSize = new Size(1899, 850);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button program;
        private Button button1;
        private Button button2;
    }
}

namespace labaWork1
{
    partial class Task1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            txt = new TextBox();
            lblRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "Задание 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(36, 189);
            label2.Name = "label2";
            label2.Size = new Size(519, 32);
            label2.TabIndex = 1;
            label2.Text = "Введите n (целое неотрицательное число)";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(324, 240);
            button1.Name = "button1";
            button1.Size = new Size(222, 42);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt
            // 
            txt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txt.Location = new Point(36, 240);
            txt.Name = "txt";
            txt.Size = new Size(222, 39);
            txt.TabIndex = 3;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRes.Location = new Point(751, 189);
            lblRes.MaximumSize = new Size(400, 0);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(88, 32);
            lblRes.TabIndex = 4;
            lblRes.Text = "Ответ:";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 738);
            Controls.Add(lblRes);
            Controls.Add(txt);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1435, 777);
            MinimumSize = new Size(1435, 777);
            Name = "Task1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox txt;
        private Label lblRes;
    }
}
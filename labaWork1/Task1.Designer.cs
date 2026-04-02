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
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 0;
            label1.Text = "Задание 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(41, 252);
            label2.Name = "label2";
            label2.Size = new Size(642, 41);
            label2.TabIndex = 1;
            label2.Text = "Введите n (целое неотрицательное число)";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(370, 320);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(254, 56);
            button1.TabIndex = 2;
            button1.Text = "Ввод";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt
            // 
            txt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txt.Location = new Point(41, 320);
            txt.Margin = new Padding(3, 4, 3, 4);
            txt.Name = "txt";
            txt.Size = new Size(253, 47);
            txt.TabIndex = 3;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRes.Location = new Point(858, 252);
            lblRes.MaximumSize = new Size(457, 0);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(110, 41);
            lblRes.TabIndex = 4;
            lblRes.Text = "Ответ:";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 973);
            Controls.Add(lblRes);
            Controls.Add(txt);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1637, 1020);
            MinimumSize = new Size(1637, 1020);
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
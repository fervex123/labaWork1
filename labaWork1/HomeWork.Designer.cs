namespace labaWork1
{
    partial class HomeWork
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
            transl = new Button();
            orig = new TextBox();
            osnova = new TextBox();
            change = new Button();
            lab = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "Система счисления с онснованием:";
            // 
            // transl
            // 
            transl.Location = new Point(170, 147);
            transl.Name = "transl";
            transl.Size = new Size(75, 23);
            transl.TabIndex = 1;
            transl.Text = "Перевести ";
            transl.UseVisualStyleBackColor = true;
            transl.Visible = false;
            transl.Click += transl_Click;
            // 
            // orig
            // 
            orig.Location = new Point(39, 147);
            orig.Name = "orig";
            orig.Size = new Size(100, 23);
            orig.TabIndex = 2;
            orig.Visible = false;
            // 
            // osnova
            // 
            osnova.Location = new Point(251, 54);
            osnova.Name = "osnova";
            osnova.Size = new Size(100, 23);
            osnova.TabIndex = 3;
            // 
            // change
            // 
            change.Location = new Point(357, 54);
            change.Name = "change";
            change.Size = new Size(75, 23);
            change.TabIndex = 4;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(365, 158);
            lab.Name = "lab";
            lab.Size = new Size(41, 15);
            lab.TabIndex = 5;
            lab.Text = "Ответ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 264);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // HomeWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lab);
            Controls.Add(change);
            Controls.Add(osnova);
            Controls.Add(orig);
            Controls.Add(transl);
            Controls.Add(label1);
            Name = "HomeWork";
            Text = "HomeWork";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button transl;
        private TextBox orig;
        private TextBox osnova;
        private Button change;
        private Label lab;
        private Label label2;
    }
}
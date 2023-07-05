namespace SınavOrtHesaplama
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxSınav1 = new TextBox();
            tbxSınav3 = new TextBox();
            tbxSınav2 = new TextBox();
            tbxResult = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 136);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Sınav 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 136);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Sınav 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Sınav 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 271);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 3;
            label4.Text = "Sınavların ortalaması";
            // 
            // tbxSınav1
            // 
            tbxSınav1.Location = new Point(106, 196);
            tbxSınav1.Name = "tbxSınav1";
            tbxSınav1.Size = new Size(150, 31);
            tbxSınav1.TabIndex = 4;
            // 
            // tbxSınav3
            // 
            tbxSınav3.Location = new Point(539, 196);
            tbxSınav3.Name = "tbxSınav3";
            tbxSınav3.Size = new Size(150, 31);
            tbxSınav3.TabIndex = 5;
            // 
            // tbxSınav2
            // 
            tbxSınav2.Location = new Point(322, 196);
            tbxSınav2.Name = "tbxSınav2";
            tbxSınav2.Size = new Size(150, 31);
            tbxSınav2.TabIndex = 6;
            tbxSınav2.TextChanged += tbxSınav2_TextChanged;
            // 
            // tbxResult
            // 
            tbxResult.BackColor = SystemColors.ActiveCaption;
            tbxResult.Location = new Point(322, 310);
            tbxResult.Name = "tbxResult";
            tbxResult.ReadOnly = true;
            tbxResult.Size = new Size(150, 31);
            tbxResult.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 111);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Vivaldi", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(98, 15);
            label5.Name = "label5";
            label5.Size = new Size(626, 67);
            label5.TabIndex = 0;
            label5.Text = "Sınav Ortalama Hesaplama";
            label5.Click += label5_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(143, 394);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(573, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(panel1);
            Controls.Add(tbxResult);
            Controls.Add(tbxSınav2);
            Controls.Add(tbxSınav3);
            Controls.Add(tbxSınav1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sınav Ort Hesaplama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxSınav1;
        private TextBox tbxSınav3;
        private TextBox tbxSınav2;
        private TextBox tbxResult;
        private Panel panel1;
        private Label label5;
        private Button btnCalculate;
        private Button btnClear;
    }
}
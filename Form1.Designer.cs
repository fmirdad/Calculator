namespace Calculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Addition = new RadioButton();
            Minus = new RadioButton();
            Multiply = new RadioButton();
            Power = new RadioButton();
            Calculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 23);
            textBox3.TabIndex = 2;
            // 
            // Addition
            // 
            Addition.AutoSize = true;
            Addition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Addition.Location = new Point(456, 90);
            Addition.Name = "Addition";
            Addition.Size = new Size(37, 23);
            Addition.TabIndex = 3;
            Addition.TabStop = true;
            Addition.Text = "+";
            Addition.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            Minus.AutoSize = true;
            Minus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Minus.Location = new Point(456, 150);
            Minus.Name = "Minus";
            Minus.Size = new Size(33, 23);
            Minus.TabIndex = 4;
            Minus.TabStop = true;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            Multiply.AutoSize = true;
            Multiply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Multiply.Location = new Point(456, 210);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(33, 23);
            Multiply.TabIndex = 5;
            Multiply.TabStop = true;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            // 
            // Power
            // 
            Power.AutoSize = true;
            Power.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Power.Location = new Point(456, 270);
            Power.Name = "Power";
            Power.Size = new Size(70, 23);
            Power.TabIndex = 6;
            Power.TabStop = true;
            Power.Text = "Power";
            Power.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Calculate.Location = new Point(112, 270);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(147, 56);
            Calculate.TabIndex = 7;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 8;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(35, 150);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 9;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(35, 211);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 10;
            label3.Text = "Number 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 426);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Calculate);
            Controls.Add(Power);
            Controls.Add(Multiply);
            Controls.Add(Minus);
            Controls.Add(Addition);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton Addition;
        private RadioButton Minus;
        private RadioButton Multiply;
        private RadioButton Power;
        private Button Calculate;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

namespace Area1
{
    partial class frmArea3
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
            Vender3 = new Button();
            Vender2 = new Button();
            Vender1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // Vender3
            // 
            Vender3.BackColor = Color.Blue;
            Vender3.FlatStyle = FlatStyle.Flat;
            Vender3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Vender3.ForeColor = Color.White;
            Vender3.Location = new Point(460, 271);
            Vender3.Name = "Vender3";
            Vender3.Size = new Size(75, 23);
            Vender3.TabIndex = 20;
            Vender3.Text = "Vender";
            Vender3.UseVisualStyleBackColor = false;
            Vender3.Click += Vender3_Click;
            // 
            // Vender2
            // 
            Vender2.BackColor = Color.Blue;
            Vender2.FlatStyle = FlatStyle.Flat;
            Vender2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Vender2.ForeColor = Color.White;
            Vender2.Location = new Point(460, 189);
            Vender2.Name = "Vender2";
            Vender2.Size = new Size(75, 23);
            Vender2.TabIndex = 19;
            Vender2.Text = "Vender";
            Vender2.UseVisualStyleBackColor = false;
            Vender2.Click += Vender2_Click;
            // 
            // Vender1
            // 
            Vender1.BackColor = Color.Blue;
            Vender1.FlatStyle = FlatStyle.Flat;
            Vender1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Vender1.ForeColor = Color.White;
            Vender1.Location = new Point(460, 106);
            Vender1.Name = "Vender1";
            Vender1.Size = new Size(75, 23);
            Vender1.TabIndex = 18;
            Vender1.Text = "Vender";
            Vender1.UseVisualStyleBackColor = false;
            Vender1.Click += Vender1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Blue;
            textBox4.Location = new Point(26, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(407, 28);
            textBox4.TabIndex = 17;
            textBox4.Text = "Modelo: Ford Ranger | Preço R$ 49.927,00";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Blue;
            textBox3.Location = new Point(26, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(407, 28);
            textBox3.TabIndex = 16;
            textBox3.Text = "Modelo: Honda HR-V | Preço R$ 53.438,00";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Blue;
            textBox2.Location = new Point(26, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(428, 28);
            textBox2.TabIndex = 15;
            textBox2.Text = "Modelo: Toyota Corolla | Preço R$ 55.022,00";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Blue;
            textBox5.Location = new Point(206, 29);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 36);
            textBox5.TabIndex = 14;
            textBox5.Text = "ÁREA 3";
            // 
            // frmArea3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 348);
            Controls.Add(Vender3);
            Controls.Add(Vender2);
            Controls.Add(Vender1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Name = "frmArea3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Vender3;
        private Button Vender2;
        private Button Vender1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox5;
    }
}
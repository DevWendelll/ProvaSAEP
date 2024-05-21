namespace TelaVendaAutomovel
{
    partial class frmVendas
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
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Blue;
            textBox2.Location = new Point(98, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 28);
            textBox2.TabIndex = 15;
            textBox2.Text = "Cliente: ";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Blue;
            textBox5.Location = new Point(237, 31);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 36);
            textBox5.TabIndex = 14;
            textBox5.Text = "XYZ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 23);
            comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(197, 177);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(326, 23);
            comboBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(21, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 28);
            textBox1.TabIndex = 18;
            textBox1.Text = "Concessionária: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 320);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda de Automóvel";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}
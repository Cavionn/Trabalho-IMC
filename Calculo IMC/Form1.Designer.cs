namespace Calculo_IMC
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
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnCalcular = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "ALTURA(m):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "PESO(Kg):";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(31, 58);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(255, 31);
            txtAltura.TabIndex = 2;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(31, 133);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(255, 31);
            txtPeso.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(31, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 191);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 349);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnCalcular;
        private Label label3;
    }
}
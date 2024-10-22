namespace Codigo2024Clase21
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
            btnSumar = new Button();
            txtValorB = new TextBox();
            txtValorA = new TextBox();
            btnMultiplicar = new Button();
            btnRestar = new Button();
            btnDividir = new Button();
            btnSumarDividir = new Button();
            btnCuarta = new Button();
            btnTablaMultiplicar = new Button();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(154, 213);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 49);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtValorB
            // 
            txtValorB.Location = new Point(360, 66);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(125, 27);
            txtValorB.TabIndex = 1;
            // 
            // txtValorA
            // 
            txtValorA.Location = new Point(154, 66);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new Size(125, 27);
            txtValorA.TabIndex = 2;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(270, 213);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 49);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(391, 213);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(94, 49);
            btnRestar.TabIndex = 4;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(507, 213);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 49);
            btnDividir.TabIndex = 5;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnSumarDividir
            // 
            btnSumarDividir.Location = new Point(154, 311);
            btnSumarDividir.Name = "btnSumarDividir";
            btnSumarDividir.Size = new Size(94, 49);
            btnSumarDividir.TabIndex = 6;
            btnSumarDividir.Text = "Sumar y Dividir";
            btnSumarDividir.UseVisualStyleBackColor = true;
            btnSumarDividir.Click += btnSumarDividir_Click;
            // 
            // btnCuarta
            // 
            btnCuarta.Location = new Point(280, 311);
            btnCuarta.Name = "btnCuarta";
            btnCuarta.Size = new Size(94, 51);
            btnCuarta.TabIndex = 7;
            btnCuarta.Text = "Calcular4taCategoria";
            btnCuarta.UseVisualStyleBackColor = true;
            btnCuarta.Click += btnCuarta_Click;
            // 
            // btnTablaMultiplicar
            // 
            btnTablaMultiplicar.Location = new Point(391, 311);
            btnTablaMultiplicar.Name = "btnTablaMultiplicar";
            btnTablaMultiplicar.Size = new Size(94, 49);
            btnTablaMultiplicar.TabIndex = 8;
            btnTablaMultiplicar.Text = "Tabla Multiplicar";
            btnTablaMultiplicar.UseVisualStyleBackColor = true;
            btnTablaMultiplicar.Click += btnTablaMultiplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTablaMultiplicar);
            Controls.Add(btnCuarta);
            Controls.Add(btnSumarDividir);
            Controls.Add(btnDividir);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplicar);
            Controls.Add(txtValorA);
            Controls.Add(txtValorB);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtValorB;
        private TextBox txtValorA;
        private Button btnMultiplicar;
        private Button btnRestar;
        private Button btnDividir;
        private Button btnSumarDividir;
        private Button btnCuarta;
        private Button btnTablaMultiplicar;
    }
}

namespace WinFormsApp1
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
            this.VerRespuesta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelresultado = new System.Windows.Forms.Label();
            this.textNEntero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VerRespuesta
            // 
            this.VerRespuesta.Location = new System.Drawing.Point(79, 111);
            this.VerRespuesta.Name = "VerRespuesta";
            this.VerRespuesta.Size = new System.Drawing.Size(75, 23);
            this.VerRespuesta.TabIndex = 0;
            this.VerRespuesta.Text = "Ver Resultado";
            this.VerRespuesta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Número Entero";
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Location = new System.Drawing.Point(229, 115);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(131, 15);
            this.labelresultado.TabIndex = 2;
            this.labelresultado.Text = "El número es Par/Impar";
            // 
            // textNEntero
            // 
            this.textNEntero.Location = new System.Drawing.Point(239, 39);
            this.textNEntero.Name = "textNEntero";
            this.textNEntero.Size = new System.Drawing.Size(91, 23);
            this.textNEntero.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.textNEntero);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerRespuesta);
            this.Name = "Form1";
            this.Text = "Programa Par o Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button VerRespuesta;
        private Label label1;
        private Label labelresultado;
        private TextBox textNEntero;
    }
}
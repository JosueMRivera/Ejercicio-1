
namespace Ejercicio_1
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.ejecutarbt = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero:";
            // 
            // numerotxt
            // 
            this.numerotxt.Location = new System.Drawing.Point(141, 34);
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(121, 20);
            this.numerotxt.TabIndex = 1;
            // 
            // ejecutarbt
            // 
            this.ejecutarbt.Location = new System.Drawing.Point(141, 60);
            this.ejecutarbt.Name = "ejecutarbt";
            this.ejecutarbt.Size = new System.Drawing.Size(121, 28);
            this.ejecutarbt.TabIndex = 2;
            this.ejecutarbt.Text = "Ejecutar";
            this.ejecutarbt.UseVisualStyleBackColor = true;
            this.ejecutarbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 231);
            this.Controls.Add(this.ejecutarbt);
            this.Controls.Add(this.numerotxt);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerotxt;
        private System.Windows.Forms.Button ejecutarbt;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}


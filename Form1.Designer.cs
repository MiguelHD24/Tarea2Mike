namespace Tarea2Mike
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMensajeOriginal = new System.Windows.Forms.TextBox();
            this.BtnEncryptar = new System.Windows.Forms.Button();
            this.BtnDesencryptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encryptar ";
            // 
            // TxtMensajeOriginal
            // 
            this.TxtMensajeOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensajeOriginal.Location = new System.Drawing.Point(292, 107);
            this.TxtMensajeOriginal.Name = "TxtMensajeOriginal";
            this.TxtMensajeOriginal.Size = new System.Drawing.Size(179, 30);
            this.TxtMensajeOriginal.TabIndex = 2;
            this.TxtMensajeOriginal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnEncryptar
            // 
            this.BtnEncryptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncryptar.Location = new System.Drawing.Point(145, 252);
            this.BtnEncryptar.Name = "BtnEncryptar";
            this.BtnEncryptar.Size = new System.Drawing.Size(132, 40);
            this.BtnEncryptar.TabIndex = 3;
            this.BtnEncryptar.Text = "Cifrar";
            this.BtnEncryptar.UseVisualStyleBackColor = true;
            this.BtnEncryptar.Click += new System.EventHandler(this.BtnEncryptar_Click);
            // 
            // BtnDesencryptar
            // 
            this.BtnDesencryptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesencryptar.Location = new System.Drawing.Point(343, 252);
            this.BtnDesencryptar.Name = "BtnDesencryptar";
            this.BtnDesencryptar.Size = new System.Drawing.Size(137, 39);
            this.BtnDesencryptar.TabIndex = 4;
            this.BtnDesencryptar.Text = "Descifrar";
            this.BtnDesencryptar.UseVisualStyleBackColor = true;
            this.BtnDesencryptar.Click += new System.EventHandler(this.BtnDesencryptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la clave";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(292, 162);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(179, 30);
            this.txtClave.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDesencryptar);
            this.Controls.Add(this.BtnEncryptar);
            this.Controls.Add(this.TxtMensajeOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMensajeOriginal;
        private System.Windows.Forms.Button BtnEncryptar;
        private System.Windows.Forms.Button BtnDesencryptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
    }
}


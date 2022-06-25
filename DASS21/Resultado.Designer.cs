namespace DASS21
{
    partial class Resultado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.LblDepresion = new System.Windows.Forms.Label();
            this.lblResDepresion = new System.Windows.Forms.Label();
            this.lblAnsiedad = new System.Windows.Forms.Label();
            this.lblResAnsiedad = new System.Windows.Forms.Label();
            this.lblEstres = new System.Windows.Forms.Label();
            this.lblResEstres = new System.Windows.Forms.Label();
            this.lblTPaciente = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "lblNombre";
            // 
            // LblDepresion
            // 
            this.LblDepresion.AutoSize = true;
            this.LblDepresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepresion.Location = new System.Drawing.Point(28, 99);
            this.LblDepresion.Name = "LblDepresion";
            this.LblDepresion.Size = new System.Drawing.Size(86, 20);
            this.LblDepresion.TabIndex = 1;
            this.LblDepresion.Text = "Depresión:";
            // 
            // lblResDepresion
            // 
            this.lblResDepresion.AutoSize = true;
            this.lblResDepresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDepresion.Location = new System.Drawing.Point(28, 131);
            this.lblResDepresion.Name = "lblResDepresion";
            this.lblResDepresion.Size = new System.Drawing.Size(126, 20);
            this.lblResDepresion.TabIndex = 2;
            this.lblResDepresion.Text = "lblResDepresion";
            // 
            // lblAnsiedad
            // 
            this.lblAnsiedad.AutoSize = true;
            this.lblAnsiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsiedad.Location = new System.Drawing.Point(28, 170);
            this.lblAnsiedad.Name = "lblAnsiedad";
            this.lblAnsiedad.Size = new System.Drawing.Size(80, 20);
            this.lblAnsiedad.TabIndex = 3;
            this.lblAnsiedad.Text = "Ansiedad:";
            // 
            // lblResAnsiedad
            // 
            this.lblResAnsiedad.AutoSize = true;
            this.lblResAnsiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResAnsiedad.Location = new System.Drawing.Point(28, 200);
            this.lblResAnsiedad.Name = "lblResAnsiedad";
            this.lblResAnsiedad.Size = new System.Drawing.Size(120, 20);
            this.lblResAnsiedad.TabIndex = 4;
            this.lblResAnsiedad.Text = "lblResAnsiedad";
            // 
            // lblEstres
            // 
            this.lblEstres.AutoSize = true;
            this.lblEstres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstres.Location = new System.Drawing.Point(28, 235);
            this.lblEstres.Name = "lblEstres";
            this.lblEstres.Size = new System.Drawing.Size(59, 20);
            this.lblEstres.TabIndex = 5;
            this.lblEstres.Text = "Estrés:";
            // 
            // lblResEstres
            // 
            this.lblResEstres.AutoSize = true;
            this.lblResEstres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEstres.Location = new System.Drawing.Point(28, 269);
            this.lblResEstres.Name = "lblResEstres";
            this.lblResEstres.Size = new System.Drawing.Size(99, 20);
            this.lblResEstres.TabIndex = 6;
            this.lblResEstres.Text = "lblResEstres";
            // 
            // lblTPaciente
            // 
            this.lblTPaciente.AutoSize = true;
            this.lblTPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPaciente.Location = new System.Drawing.Point(28, 26);
            this.lblTPaciente.Name = "lblTPaciente";
            this.lblTPaciente.Size = new System.Drawing.Size(75, 20);
            this.lblTPaciente.TabIndex = 7;
            this.lblTPaciente.Text = "Paciente:";
            this.lblTPaciente.Click += new System.EventHandler(this.lblTPaciente_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(322, 335);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(175, 33);
            this.CerrarBtn.TabIndex = 8;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.lblTPaciente);
            this.Controls.Add(this.lblResEstres);
            this.Controls.Add(this.lblEstres);
            this.Controls.Add(this.lblResAnsiedad);
            this.Controls.Add(this.lblAnsiedad);
            this.Controls.Add(this.lblResDepresion);
            this.Controls.Add(this.LblDepresion);
            this.Controls.Add(this.lblNombre);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label LblDepresion;
        private System.Windows.Forms.Label lblResDepresion;
        private System.Windows.Forms.Label lblAnsiedad;
        private System.Windows.Forms.Label lblResAnsiedad;
        private System.Windows.Forms.Label lblEstres;
        private System.Windows.Forms.Label lblResEstres;
        private System.Windows.Forms.Label lblTPaciente;
        private System.Windows.Forms.Button CerrarBtn;
    }
}
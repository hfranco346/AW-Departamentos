namespace AW_Departamentos
{
    partial class EliminarDepartamento
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
            this.gbEliminarDepartamento = new System.Windows.Forms.GroupBox();
            this.lstDepartamentos = new System.Windows.Forms.ListBox();
            this.btnCargarDepartamentos = new System.Windows.Forms.Button();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.lblEstadoEliminacion = new System.Windows.Forms.Label();
            this.gbEliminarDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminarDepartamento
            // 
            this.gbEliminarDepartamento.Controls.Add(this.lblEstadoEliminacion);
            this.gbEliminarDepartamento.Controls.Add(this.btnEliminarDepartamento);
            this.gbEliminarDepartamento.Controls.Add(this.btnCargarDepartamentos);
            this.gbEliminarDepartamento.Controls.Add(this.lstDepartamentos);
            this.gbEliminarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminarDepartamento.Location = new System.Drawing.Point(12, 12);
            this.gbEliminarDepartamento.Name = "gbEliminarDepartamento";
            this.gbEliminarDepartamento.Size = new System.Drawing.Size(468, 292);
            this.gbEliminarDepartamento.TabIndex = 0;
            this.gbEliminarDepartamento.TabStop = false;
            this.gbEliminarDepartamento.Text = "Eliminar Departamento";
            // 
            // lstDepartamentos
            // 
            this.lstDepartamentos.FormattingEnabled = true;
            this.lstDepartamentos.ItemHeight = 20;
            this.lstDepartamentos.Location = new System.Drawing.Point(16, 37);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(231, 204);
            this.lstDepartamentos.TabIndex = 0;
            // 
            // btnCargarDepartamentos
            // 
            this.btnCargarDepartamentos.Location = new System.Drawing.Point(253, 75);
            this.btnCargarDepartamentos.Name = "btnCargarDepartamentos";
            this.btnCargarDepartamentos.Size = new System.Drawing.Size(209, 48);
            this.btnCargarDepartamentos.TabIndex = 1;
            this.btnCargarDepartamentos.Text = "Cargar listado de departamentos";
            this.btnCargarDepartamentos.UseVisualStyleBackColor = true;
            this.btnCargarDepartamentos.Click += new System.EventHandler(this.btnCargarDepartamentos_Click);
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(253, 152);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(209, 48);
            this.btnEliminarDepartamento.TabIndex = 2;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // lblEstadoEliminacion
            // 
            this.lblEstadoEliminacion.Location = new System.Drawing.Point(6, 244);
            this.lblEstadoEliminacion.Name = "lblEstadoEliminacion";
            this.lblEstadoEliminacion.Size = new System.Drawing.Size(456, 45);
            this.lblEstadoEliminacion.TabIndex = 3;
            this.lblEstadoEliminacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.gbEliminarDepartamento);
            this.Name = "EliminarDepartamento";
            this.Text = "Eliminar Departamento";
            this.gbEliminarDepartamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminarDepartamento;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnCargarDepartamentos;
        private System.Windows.Forms.ListBox lstDepartamentos;
        private System.Windows.Forms.Label lblEstadoEliminacion;
    }
}
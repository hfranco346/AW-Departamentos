namespace AW_Departamentos
{
    partial class frmMenuPrincipal
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
            this.gbDepartamentos = new System.Windows.Forms.GroupBox();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnActualizarDepartamento = new System.Windows.Forms.Button();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.btnListarDepartamentos = new System.Windows.Forms.Button();
            this.gbDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Controls.Add(this.btnEliminarDepartamento);
            this.gbDepartamentos.Controls.Add(this.btnActualizarDepartamento);
            this.gbDepartamentos.Controls.Add(this.btnCrearDepartamento);
            this.gbDepartamentos.Controls.Add(this.btnListarDepartamentos);
            this.gbDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartamentos.Location = new System.Drawing.Point(12, 0);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Size = new System.Drawing.Size(461, 227);
            this.gbDepartamentos.TabIndex = 0;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Opciones disponibles para departamentos";
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(257, 148);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(190, 43);
            this.btnEliminarDepartamento.TabIndex = 4;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.Location = new System.Drawing.Point(20, 148);
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(190, 43);
            this.btnActualizarDepartamento.TabIndex = 3;
            this.btnActualizarDepartamento.Text = "Actualizar Departamento";
            this.btnActualizarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(257, 56);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(190, 43);
            this.btnCrearDepartamento.TabIndex = 2;
            this.btnCrearDepartamento.Text = "Crear Departamento";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // btnListarDepartamentos
            // 
            this.btnListarDepartamentos.Location = new System.Drawing.Point(20, 56);
            this.btnListarDepartamentos.Name = "btnListarDepartamentos";
            this.btnListarDepartamentos.Size = new System.Drawing.Size(190, 43);
            this.btnListarDepartamentos.TabIndex = 1;
            this.btnListarDepartamentos.Text = "Listar Departamentos";
            this.btnListarDepartamentos.UseVisualStyleBackColor = true;
            this.btnListarDepartamentos.Click += new System.EventHandler(this.btnListarDepartamentos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 243);
            this.Controls.Add(this.gbDepartamentos);
            this.Name = "frmMenuPrincipal";
            this.Text = "Operaciones CRUD con departamentos Adventure Works";
            this.gbDepartamentos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnActualizarDepartamento;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.Button btnListarDepartamentos;
    }
}


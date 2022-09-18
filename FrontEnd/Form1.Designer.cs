namespace FrontEnd
{
    partial class Mi_Trabajo_Practico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtAsignacionDiario = new System.Windows.Forms.TextBox();
            this.TxtDiasLaburados = new System.Windows.Forms.TextBox();
            this.btnAlmacenarRegistro = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalDevengado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.error502 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error502)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ASIGNACION SALARIO POR DIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIAS LABURADOS";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(241, 33);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(241, 72);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.TxtIdentificacion.TabIndex = 5;
            // 
            // TxtAsignacionDiario
            // 
            this.TxtAsignacionDiario.Location = new System.Drawing.Point(241, 119);
            this.TxtAsignacionDiario.Name = "TxtAsignacionDiario";
            this.TxtAsignacionDiario.Size = new System.Drawing.Size(100, 20);
            this.TxtAsignacionDiario.TabIndex = 6;
            // 
            // TxtDiasLaburados
            // 
            this.TxtDiasLaburados.Location = new System.Drawing.Point(241, 165);
            this.TxtDiasLaburados.Name = "TxtDiasLaburados";
            this.TxtDiasLaburados.Size = new System.Drawing.Size(100, 20);
            this.TxtDiasLaburados.TabIndex = 7;
            // 
            // btnAlmacenarRegistro
            // 
            this.btnAlmacenarRegistro.Location = new System.Drawing.Point(180, 230);
            this.btnAlmacenarRegistro.Name = "btnAlmacenarRegistro";
            this.btnAlmacenarRegistro.Size = new System.Drawing.Size(253, 39);
            this.btnAlmacenarRegistro.TabIndex = 8;
            this.btnAlmacenarRegistro.Text = "GUARDAR REGISTRO DE EMPLEADO";
            this.btnAlmacenarRegistro.UseVisualStyleBackColor = true;
            this.btnAlmacenarRegistro.Click += new System.EventHandler(this.btnAlmacenarRegistro_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(204, 300);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(191, 23);
            this.btnCalcularSalario.TabIndex = 9;
            this.btnCalcularSalario.Text = "CALCULAR SALARIO";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "VALOR TOTAL DEVENGADO";
            // 
            // TxtTotalDevengado
            // 
            this.TxtTotalDevengado.Location = new System.Drawing.Point(241, 334);
            this.TxtTotalDevengado.Name = "TxtTotalDevengado";
            this.TxtTotalDevengado.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalDevengado.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(90, 377);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(388, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // error502
            // 
            this.error502.ContainerControl = this;
            // 
            // Mi_Trabajo_Practico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.TxtTotalDevengado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnAlmacenarRegistro);
            this.Controls.Add(this.TxtDiasLaburados);
            this.Controls.Add(this.TxtAsignacionDiario);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mi_Trabajo_Practico";
            this.Text = "Mi trabajo Practico";
            ((System.ComponentModel.ISupportInitialize)(this.error502)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtAsignacionDiario;
        private System.Windows.Forms.TextBox TxtDiasLaburados;
        private System.Windows.Forms.Button btnAlmacenarRegistro;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalDevengado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider error502;
    }
}


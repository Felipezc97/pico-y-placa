namespace ProgramaPicoPlaca
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
            this.gbxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblIngresoPlaca = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIngresoFecha = new System.Windows.Forms.Label();
            this.lblIngresoHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.btnPredecir = new System.Windows.Forms.Button();
            this.gbxIngresoDatos.SuspendLayout();
            this.gbxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIngresoDatos
            // 
            this.gbxIngresoDatos.Controls.Add(this.txtPlaca);
            this.gbxIngresoDatos.Controls.Add(this.lblIngresoPlaca);
            this.gbxIngresoDatos.Controls.Add(this.dtpFecha);
            this.gbxIngresoDatos.Controls.Add(this.lblIngresoFecha);
            this.gbxIngresoDatos.Controls.Add(this.lblIngresoHora);
            this.gbxIngresoDatos.Controls.Add(this.dtpHora);
            this.gbxIngresoDatos.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.gbxIngresoDatos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxIngresoDatos.Location = new System.Drawing.Point(104, 56);
            this.gbxIngresoDatos.Name = "gbxIngresoDatos";
            this.gbxIngresoDatos.Size = new System.Drawing.Size(288, 164);
            this.gbxIngresoDatos.TabIndex = 16;
            this.gbxIngresoDatos.TabStop = false;
            this.gbxIngresoDatos.Text = "Ingreso de datos";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(182, 31);
            this.txtPlaca.Mask = ">AAA-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(69, 24);
            this.txtPlaca.TabIndex = 31;
            // 
            // lblIngresoPlaca
            // 
            this.lblIngresoPlaca.AutoSize = true;
            this.lblIngresoPlaca.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lblIngresoPlaca.Location = new System.Drawing.Point(29, 34);
            this.lblIngresoPlaca.Name = "lblIngresoPlaca";
            this.lblIngresoPlaca.Size = new System.Drawing.Size(151, 17);
            this.lblIngresoPlaca.TabIndex = 29;
            this.lblIngresoPlaca.Text = "Ingrese la placa del auto: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(134, 72);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(111, 24);
            this.dtpFecha.TabIndex = 26;
            // 
            // lblIngresoFecha
            // 
            this.lblIngresoFecha.AutoSize = true;
            this.lblIngresoFecha.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lblIngresoFecha.Location = new System.Drawing.Point(33, 76);
            this.lblIngresoFecha.Name = "lblIngresoFecha";
            this.lblIngresoFecha.Size = new System.Drawing.Size(100, 17);
            this.lblIngresoFecha.TabIndex = 25;
            this.lblIngresoFecha.Text = "Ingrese la fecha:";
            // 
            // lblIngresoHora
            // 
            this.lblIngresoHora.AutoSize = true;
            this.lblIngresoHora.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.lblIngresoHora.Location = new System.Drawing.Point(55, 122);
            this.lblIngresoHora.Name = "lblIngresoHora";
            this.lblIngresoHora.Size = new System.Drawing.Size(95, 17);
            this.lblIngresoHora.TabIndex = 23;
            this.lblIngresoHora.Text = "Ingrese la hora:";
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(150, 118);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(74, 24);
            this.dtpHora.TabIndex = 24;
            // 
            // gbxResultados
            // 
            this.gbxResultados.Controls.Add(this.lblResultado);
            this.gbxResultados.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.gbxResultados.Location = new System.Drawing.Point(104, 298);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(288, 49);
            this.gbxResultados.TabIndex = 18;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(6, 20);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "PREDICCIÓN PICO Y PLACA";
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.btnNuevaConsulta.Location = new System.Drawing.Point(254, 236);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(163, 36);
            this.btnNuevaConsulta.TabIndex = 23;
            this.btnNuevaConsulta.Text = "Nueva consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // btnPredecir
            // 
            this.btnPredecir.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.btnPredecir.Location = new System.Drawing.Point(80, 236);
            this.btnPredecir.Name = "btnPredecir";
            this.btnPredecir.Size = new System.Drawing.Size(163, 36);
            this.btnPredecir.TabIndex = 22;
            this.btnPredecir.Text = "Predecir estado";
            this.btnPredecir.UseVisualStyleBackColor = true;
            this.btnPredecir.Click += new System.EventHandler(this.btnPredecir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 359);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.btnPredecir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxResultados);
            this.Controls.Add(this.gbxIngresoDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxIngresoDatos.ResumeLayout(false);
            this.gbxIngresoDatos.PerformLayout();
            this.gbxResultados.ResumeLayout(false);
            this.gbxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIngresoDatos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblIngresoFecha;
        private System.Windows.Forms.Label lblIngresoHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresoPlaca;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Button btnPredecir;
    }
}


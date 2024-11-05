namespace Ejercicio1_Despachos
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecibirCorrespondencia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrepararCamion = new System.Windows.Forms.Button();
            this.lbxVerSectorCarga = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxListadoAEntregar = new System.Windows.Forms.ListBox();
            this.btnEntregarPaquete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbDireccionProximo = new System.Windows.Forms.TextBox();
            this.tbNombreProximo = new System.Windows.Forms.TextBox();
            this.tbDNIProximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(68, 28);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(122, 20);
            this.tbDNI.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 66);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(122, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(68, 103);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(122, 123);
            this.tbDireccion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecibirCorrespondencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sector de Atención al Cliente";
            // 
            // btnRecibirCorrespondencia
            // 
            this.btnRecibirCorrespondencia.Location = new System.Drawing.Point(17, 254);
            this.btnRecibirCorrespondencia.Name = "btnRecibirCorrespondencia";
            this.btnRecibirCorrespondencia.Size = new System.Drawing.Size(173, 47);
            this.btnRecibirCorrespondencia.TabIndex = 6;
            this.btnRecibirCorrespondencia.Text = "Recibir Correspondencia";
            this.btnRecibirCorrespondencia.UseVisualStyleBackColor = true;
            this.btnRecibirCorrespondencia.Click += new System.EventHandler(this.btnRecibirCorrespondencia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrepararCamion);
            this.groupBox2.Controls.Add(this.lbxVerSectorCarga);
            this.groupBox2.Location = new System.Drawing.Point(229, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 319);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquetes en el Sector de Embarque";
            // 
            // btnPrepararCamion
            // 
            this.btnPrepararCamion.Location = new System.Drawing.Point(76, 253);
            this.btnPrepararCamion.Name = "btnPrepararCamion";
            this.btnPrepararCamion.Size = new System.Drawing.Size(144, 47);
            this.btnPrepararCamion.TabIndex = 1;
            this.btnPrepararCamion.Text = "Preparar Camión";
            this.btnPrepararCamion.UseVisualStyleBackColor = true;
            this.btnPrepararCamion.Click += new System.EventHandler(this.btnPrepararCamion_Click);
            // 
            // lbxVerSectorCarga
            // 
            this.lbxVerSectorCarga.FormattingEnabled = true;
            this.lbxVerSectorCarga.Location = new System.Drawing.Point(7, 20);
            this.lbxVerSectorCarga.Name = "lbxVerSectorCarga";
            this.lbxVerSectorCarga.Size = new System.Drawing.Size(280, 212);
            this.lbxVerSectorCarga.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbxListadoAEntregar);
            this.groupBox3.Controls.Add(this.btnEntregarPaquete);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(529, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 319);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarea de Reparto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Listado a Entregar";
            // 
            // lbxListadoAEntregar
            // 
            this.lbxListadoAEntregar.FormattingEnabled = true;
            this.lbxListadoAEntregar.Location = new System.Drawing.Point(7, 183);
            this.lbxListadoAEntregar.Name = "lbxListadoAEntregar";
            this.lbxListadoAEntregar.Size = new System.Drawing.Size(231, 121);
            this.lbxListadoAEntregar.TabIndex = 3;
            // 
            // btnEntregarPaquete
            // 
            this.btnEntregarPaquete.Location = new System.Drawing.Point(138, 134);
            this.btnEntregarPaquete.Name = "btnEntregarPaquete";
            this.btnEntregarPaquete.Size = new System.Drawing.Size(112, 23);
            this.btnEntregarPaquete.TabIndex = 2;
            this.btnEntregarPaquete.Text = "Entregar Paquete";
            this.btnEntregarPaquete.UseVisualStyleBackColor = true;
            this.btnEntregarPaquete.Click += new System.EventHandler(this.btnEntregarPaquete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar Reparto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIniciarReparto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbDireccionProximo);
            this.groupBox4.Controls.Add(this.tbNombreProximo);
            this.groupBox4.Controls.Add(this.tbDNIProximo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 98);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Próximo a Entregar";
            // 
            // tbDireccionProximo
            // 
            this.tbDireccionProximo.Enabled = false;
            this.tbDireccionProximo.Location = new System.Drawing.Point(104, 71);
            this.tbDireccionProximo.Name = "tbDireccionProximo";
            this.tbDireccionProximo.Size = new System.Drawing.Size(100, 20);
            this.tbDireccionProximo.TabIndex = 5;
            // 
            // tbNombreProximo
            // 
            this.tbNombreProximo.Enabled = false;
            this.tbNombreProximo.Location = new System.Drawing.Point(104, 45);
            this.tbNombreProximo.Name = "tbNombreProximo";
            this.tbNombreProximo.Size = new System.Drawing.Size(100, 20);
            this.tbNombreProximo.TabIndex = 4;
            // 
            // tbDNIProximo
            // 
            this.tbDNIProximo.Enabled = false;
            this.tbDNIProximo.Location = new System.Drawing.Point(104, 16);
            this.tbDNIProximo.Name = "tbDNIProximo";
            this.tbDNIProximo.Size = new System.Drawing.Size(100, 20);
            this.tbDNIProximo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecibirCorrespondencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrepararCamion;
        private System.Windows.Forms.ListBox lbxVerSectorCarga;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxListadoAEntregar;
        private System.Windows.Forms.Button btnEntregarPaquete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDireccionProximo;
        private System.Windows.Forms.TextBox tbNombreProximo;
        private System.Windows.Forms.TextBox tbDNIProximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


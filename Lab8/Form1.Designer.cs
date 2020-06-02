namespace Lab8
{
    partial class App
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
            this.AgregarL = new System.Windows.Forms.Button();
            this.RevisarInf = new System.Windows.Forms.Button();
            this.Desplegar = new System.Windows.Forms.Button();
            this.PanelAgregarLocal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Button();
            this.textnIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textHoraAtencion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelCategoria = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.btnContinuar2 = new System.Windows.Forms.Button();
            this.PanelRest = new System.Windows.Forms.Panel();
            this.txtBool = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.PanelAgregarLocal.SuspendLayout();
            this.PanelCategoria.SuspendLayout();
            this.PanelRest.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgregarL
            // 
            this.AgregarL.Location = new System.Drawing.Point(254, 108);
            this.AgregarL.Name = "AgregarL";
            this.AgregarL.Size = new System.Drawing.Size(175, 67);
            this.AgregarL.TabIndex = 0;
            this.AgregarL.Text = "Agregar Local";
            this.AgregarL.UseVisualStyleBackColor = true;
            this.AgregarL.Click += new System.EventHandler(this.AgregarL_Click);
            // 
            // RevisarInf
            // 
            this.RevisarInf.Location = new System.Drawing.Point(254, 181);
            this.RevisarInf.Name = "RevisarInf";
            this.RevisarInf.Size = new System.Drawing.Size(175, 67);
            this.RevisarInf.TabIndex = 1;
            this.RevisarInf.Text = "Revisar informacion de locales";
            this.RevisarInf.UseVisualStyleBackColor = true;
            this.RevisarInf.Click += new System.EventHandler(this.RevisarInf_Click);
            // 
            // Desplegar
            // 
            this.Desplegar.Location = new System.Drawing.Point(254, 254);
            this.Desplegar.Name = "Desplegar";
            this.Desplegar.Size = new System.Drawing.Size(175, 67);
            this.Desplegar.TabIndex = 2;
            this.Desplegar.Text = "Desplegar info de locales";
            this.Desplegar.UseVisualStyleBackColor = true;
            // 
            // PanelAgregarLocal
            // 
            this.PanelAgregarLocal.Controls.Add(this.PanelCategoria);
            this.PanelAgregarLocal.Controls.Add(this.label4);
            this.PanelAgregarLocal.Controls.Add(this.textHoraAtencion);
            this.PanelAgregarLocal.Controls.Add(this.label3);
            this.PanelAgregarLocal.Controls.Add(this.label2);
            this.PanelAgregarLocal.Controls.Add(this.textnIdentificador);
            this.PanelAgregarLocal.Controls.Add(this.label1);
            this.PanelAgregarLocal.Controls.Add(this.textName);
            this.PanelAgregarLocal.Controls.Add(this.Nombre);
            this.PanelAgregarLocal.Location = new System.Drawing.Point(454, 12);
            this.PanelAgregarLocal.Name = "PanelAgregarLocal";
            this.PanelAgregarLocal.Size = new System.Drawing.Size(805, 453);
            this.PanelAgregarLocal.TabIndex = 3;
            this.PanelAgregarLocal.Visible = false;
            this.PanelAgregarLocal.Paint += new System.Windows.Forms.PaintEventHandler(this.AgregarLocal_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del dueño";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(322, 80);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(214, 22);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(322, 304);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(142, 50);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Continuar";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // textnIdentificador
            // 
            this.textnIdentificador.Location = new System.Drawing.Point(322, 130);
            this.textnIdentificador.Name = "textnIdentificador";
            this.textnIdentificador.Size = new System.Drawing.Size(214, 22);
            this.textnIdentificador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora de atencion. ";
            // 
            // textHoraAtencion
            // 
            this.textHoraAtencion.Location = new System.Drawing.Point(322, 181);
            this.textHoraAtencion.Name = "textHoraAtencion";
            this.textHoraAtencion.Size = new System.Drawing.Size(214, 22);
            this.textHoraAtencion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Por favor ingresar en formato: (15:30-21:30)";
            // 
            // PanelCategoria
            // 
            this.PanelCategoria.Controls.Add(this.btnContinuar2);
            this.PanelCategoria.Controls.Add(this.comboCategoria);
            this.PanelCategoria.Controls.Add(this.label7);
            this.PanelCategoria.Controls.Add(this.label6);
            this.PanelCategoria.Controls.Add(this.label5);
            this.PanelCategoria.Location = new System.Drawing.Point(730, 30);
            this.PanelCategoria.Name = "PanelCategoria";
            this.PanelCategoria.Size = new System.Drawing.Size(577, 375);
            this.PanelCategoria.TabIndex = 8;
            this.PanelCategoria.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Elegir la categoria que pertenece el local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Recuerda que existen 4 categorias.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Elegir";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Cine",
            "Tienda",
            "Restaurant",
            "Recreacional"});
            this.comboCategoria.Location = new System.Drawing.Point(322, 151);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 24);
            this.comboCategoria.TabIndex = 3;
            this.comboCategoria.Text = "Categorias";
            // 
            // btnContinuar2
            // 
            this.btnContinuar2.Location = new System.Drawing.Point(315, 212);
            this.btnContinuar2.Name = "btnContinuar2";
            this.btnContinuar2.Size = new System.Drawing.Size(113, 54);
            this.btnContinuar2.TabIndex = 4;
            this.btnContinuar2.Text = "Continuar";
            this.btnContinuar2.UseVisualStyleBackColor = true;
            this.btnContinuar2.Click += new System.EventHandler(this.btnContinuar2_Click);
            // 
            // PanelRest
            // 
            this.PanelRest.Controls.Add(this.Volver);
            this.PanelRest.Controls.Add(this.label8);
            this.PanelRest.Controls.Add(this.txtBool);
            this.PanelRest.Location = new System.Drawing.Point(808, 0);
            this.PanelRest.Name = "PanelRest";
            this.PanelRest.Size = new System.Drawing.Size(798, 452);
            this.PanelRest.TabIndex = 5;
            this.PanelRest.Visible = false;
            // 
            // txtBool
            // 
            this.txtBool.Location = new System.Drawing.Point(276, 150);
            this.txtBool.Name = "txtBool";
            this.txtBool.Size = new System.Drawing.Size(206, 22);
            this.txtBool.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Diga SI/NO si tiene mesa exclusiva";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(330, 194);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(98, 54);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver al menu";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 516);
            this.Controls.Add(this.PanelRest);
            this.Controls.Add(this.PanelAgregarLocal);
            this.Controls.Add(this.Desplegar);
            this.Controls.Add(this.RevisarInf);
            this.Controls.Add(this.AgregarL);
            this.Name = "App";
            this.Text = "App";
            this.PanelAgregarLocal.ResumeLayout(false);
            this.PanelAgregarLocal.PerformLayout();
            this.PanelCategoria.ResumeLayout(false);
            this.PanelCategoria.PerformLayout();
            this.PanelRest.ResumeLayout(false);
            this.PanelRest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarL;
        private System.Windows.Forms.Button RevisarInf;
        private System.Windows.Forms.Button Desplegar;
        private System.Windows.Forms.Panel PanelAgregarLocal;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHoraAtencion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelCategoria;
        private System.Windows.Forms.Button btnContinuar2;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelRest;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBool;
    }
}


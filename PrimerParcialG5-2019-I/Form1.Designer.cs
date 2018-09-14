namespace PrimerParcialG5_2019_I
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
            this.txtbSumar = new System.Windows.Forms.TextBox();
            this.lbSumar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbImprimir = new System.Windows.Forms.Label();
            this.txtbImprimir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPromediar = new System.Windows.Forms.Label();
            this.txtbPromediar = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPromediar = new System.Windows.Forms.Button();
            this.rdbIngresado = new System.Windows.Forms.RadioButton();
            this.rdbInverso = new System.Windows.Forms.RadioButton();
            this.rdbPar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arreglo Sumar";
            // 
            // txtbSumar
            // 
            this.txtbSumar.Location = new System.Drawing.Point(112, 39);
            this.txtbSumar.Name = "txtbSumar";
            this.txtbSumar.Size = new System.Drawing.Size(228, 20);
            this.txtbSumar.TabIndex = 1;
            // 
            // lbSumar
            // 
            this.lbSumar.AutoSize = true;
            this.lbSumar.Location = new System.Drawing.Point(375, 46);
            this.lbSumar.Name = "lbSumar";
            this.lbSumar.Size = new System.Drawing.Size(55, 13);
            this.lbSumar.TabIndex = 0;
            this.lbSumar.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Imprime";
            // 
            // lbImprimir
            // 
            this.lbImprimir.AutoSize = true;
            this.lbImprimir.Location = new System.Drawing.Point(375, 107);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(55, 13);
            this.lbImprimir.TabIndex = 0;
            this.lbImprimir.Text = "Resultado";
            // 
            // txtbImprimir
            // 
            this.txtbImprimir.Location = new System.Drawing.Point(112, 100);
            this.txtbImprimir.Name = "txtbImprimir";
            this.txtbImprimir.Size = new System.Drawing.Size(228, 20);
            this.txtbImprimir.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Promedio";
            // 
            // lbPromediar
            // 
            this.lbPromediar.AutoSize = true;
            this.lbPromediar.Location = new System.Drawing.Point(375, 166);
            this.lbPromediar.Name = "lbPromediar";
            this.lbPromediar.Size = new System.Drawing.Size(60, 13);
            this.lbPromediar.TabIndex = 0;
            this.lbPromediar.Text = "Resultados";
            // 
            // txtbPromediar
            // 
            this.txtbPromediar.Location = new System.Drawing.Point(112, 159);
            this.txtbPromediar.Name = "txtbPromediar";
            this.txtbPromediar.Size = new System.Drawing.Size(228, 20);
            this.txtbPromediar.TabIndex = 1;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(79, 229);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(198, 229);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(335, 229);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(75, 23);
            this.btnPromediar.TabIndex = 2;
            this.btnPromediar.Text = "Promedio";
            this.btnPromediar.UseVisualStyleBackColor = true;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // rdbIngresado
            // 
            this.rdbIngresado.AutoSize = true;
            this.rdbIngresado.Location = new System.Drawing.Point(121, 77);
            this.rdbIngresado.Name = "rdbIngresado";
            this.rdbIngresado.Size = new System.Drawing.Size(72, 17);
            this.rdbIngresado.TabIndex = 3;
            this.rdbIngresado.TabStop = true;
            this.rdbIngresado.Text = "Ingresado";
            this.rdbIngresado.UseVisualStyleBackColor = true;
            // 
            // rdbInverso
            // 
            this.rdbInverso.AutoSize = true;
            this.rdbInverso.Location = new System.Drawing.Point(227, 77);
            this.rdbInverso.Name = "rdbInverso";
            this.rdbInverso.Size = new System.Drawing.Size(60, 17);
            this.rdbInverso.TabIndex = 3;
            this.rdbInverso.TabStop = true;
            this.rdbInverso.Text = "Inverso";
            this.rdbInverso.UseVisualStyleBackColor = true;
            // 
            // rdbPar
            // 
            this.rdbPar.AutoSize = true;
            this.rdbPar.Location = new System.Drawing.Point(303, 77);
            this.rdbPar.Name = "rdbPar";
            this.rdbPar.Size = new System.Drawing.Size(73, 17);
            this.rdbPar.TabIndex = 3;
            this.rdbPar.TabStop = true;
            this.rdbPar.Text = "Índice Par";
            this.rdbPar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 306);
            this.Controls.Add(this.rdbPar);
            this.Controls.Add(this.rdbInverso);
            this.Controls.Add(this.rdbIngresado);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtbPromediar);
            this.Controls.Add(this.lbPromediar);
            this.Controls.Add(this.txtbImprimir);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbSumar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSumar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbSumar;
        private System.Windows.Forms.Label lbSumar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbImprimir;
        private System.Windows.Forms.TextBox txtbImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPromediar;
        private System.Windows.Forms.TextBox txtbPromediar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.RadioButton rdbIngresado;
        private System.Windows.Forms.RadioButton rdbInverso;
        private System.Windows.Forms.RadioButton rdbPar;
    }
}


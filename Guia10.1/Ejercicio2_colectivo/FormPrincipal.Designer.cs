namespace Ejercicio2_colectivo
{
    partial class FormPrincipal
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
            this.gbLLegadaViaje = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMMFin = new System.Windows.Forms.TextBox();
            this.tbHHFin = new System.Windows.Forms.TextBox();
            this.lbxResultadoFinal = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.gbParada = new System.Windows.Forms.GroupBox();
            this.lbxResultadoParada = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDescienden = new System.Windows.Forms.TextBox();
            this.tbAscienden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMMSalida = new System.Windows.Forms.TextBox();
            this.tbHHSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMMParada = new System.Windows.Forms.TextBox();
            this.tbHHParada = new System.Windows.Forms.TextBox();
            this.btnRegistrarParada = new System.Windows.Forms.Button();
            this.gbInicioViaje = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidadAsientos = new System.Windows.Forms.TextBox();
            this.tbMMInicio = new System.Windows.Forms.TextBox();
            this.tbHHInicio = new System.Windows.Forms.TextBox();
            this.btnIniciarRecorrido = new System.Windows.Forms.Button();
            this.gbLLegadaViaje.SuspendLayout();
            this.gbParada.SuspendLayout();
            this.gbInicioViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLLegadaViaje
            // 
            this.gbLLegadaViaje.Controls.Add(this.label11);
            this.gbLLegadaViaje.Controls.Add(this.tbMMFin);
            this.gbLLegadaViaje.Controls.Add(this.tbHHFin);
            this.gbLLegadaViaje.Controls.Add(this.lbxResultadoFinal);
            this.gbLLegadaViaje.Controls.Add(this.label10);
            this.gbLLegadaViaje.Controls.Add(this.btnFinalizarViaje);
            this.gbLLegadaViaje.Enabled = false;
            this.gbLLegadaViaje.Location = new System.Drawing.Point(686, 4);
            this.gbLLegadaViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLLegadaViaje.Name = "gbLLegadaViaje";
            this.gbLLegadaViaje.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLLegadaViaje.Size = new System.Drawing.Size(388, 335);
            this.gbLLegadaViaje.TabIndex = 5;
            this.gbLLegadaViaje.TabStop = false;
            this.gbLLegadaViaje.Text = "Finalizar Recorrido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = ":";
            // 
            // tbMMFin
            // 
            this.tbMMFin.Location = new System.Drawing.Point(305, 41);
            this.tbMMFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMMFin.Name = "tbMMFin";
            this.tbMMFin.Size = new System.Drawing.Size(53, 22);
            this.tbMMFin.TabIndex = 15;
            // 
            // tbHHFin
            // 
            this.tbHHFin.Location = new System.Drawing.Point(221, 41);
            this.tbHHFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHHFin.Name = "tbHHFin";
            this.tbHHFin.Size = new System.Drawing.Size(53, 22);
            this.tbHHFin.TabIndex = 14;
            // 
            // lbxResultadoFinal
            // 
            this.lbxResultadoFinal.FormattingEnabled = true;
            this.lbxResultadoFinal.ItemHeight = 16;
            this.lbxResultadoFinal.Location = new System.Drawing.Point(8, 145);
            this.lbxResultadoFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxResultadoFinal.Name = "lbxResultadoFinal";
            this.lbxResultadoFinal.Size = new System.Drawing.Size(368, 180);
            this.lbxResultadoFinal.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hora de Finalización (HH:MM)";
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(147, 80);
            this.btnFinalizarViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(88, 58);
            this.btnFinalizarViaje.TabIndex = 0;
            this.btnFinalizarViaje.Text = "Finalizar Recorrido";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            this.btnFinalizarViaje.Click += new System.EventHandler(this.btnFinalizarViaje_Click);
            // 
            // gbParada
            // 
            this.gbParada.Controls.Add(this.lbxResultadoParada);
            this.gbParada.Controls.Add(this.label9);
            this.gbParada.Controls.Add(this.tbDescienden);
            this.gbParada.Controls.Add(this.tbAscienden);
            this.gbParada.Controls.Add(this.label8);
            this.gbParada.Controls.Add(this.label7);
            this.gbParada.Controls.Add(this.label6);
            this.gbParada.Controls.Add(this.label4);
            this.gbParada.Controls.Add(this.tbMMSalida);
            this.gbParada.Controls.Add(this.tbHHSalida);
            this.gbParada.Controls.Add(this.label5);
            this.gbParada.Controls.Add(this.tbMMParada);
            this.gbParada.Controls.Add(this.tbHHParada);
            this.gbParada.Controls.Add(this.btnRegistrarParada);
            this.gbParada.Enabled = false;
            this.gbParada.Location = new System.Drawing.Point(353, 5);
            this.gbParada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbParada.Name = "gbParada";
            this.gbParada.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbParada.Size = new System.Drawing.Size(325, 335);
            this.gbParada.TabIndex = 4;
            this.gbParada.TabStop = false;
            this.gbParada.Text = "Parada";
            // 
            // lbxResultadoParada
            // 
            this.lbxResultadoParada.FormattingEnabled = true;
            this.lbxResultadoParada.ItemHeight = 16;
            this.lbxResultadoParada.Location = new System.Drawing.Point(8, 242);
            this.lbxResultadoParada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxResultadoParada.Name = "lbxResultadoParada";
            this.lbxResultadoParada.Size = new System.Drawing.Size(308, 84);
            this.lbxResultadoParada.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descienden";
            // 
            // tbDescienden
            // 
            this.tbDescienden.Location = new System.Drawing.Point(163, 59);
            this.tbDescienden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescienden.Name = "tbDescienden";
            this.tbDescienden.Size = new System.Drawing.Size(53, 22);
            this.tbDescienden.TabIndex = 17;
            // 
            // tbAscienden
            // 
            this.tbAscienden.Location = new System.Drawing.Point(163, 128);
            this.tbAscienden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAscienden.Name = "tbAscienden";
            this.tbAscienden.Size = new System.Drawing.Size(53, 22);
            this.tbAscienden.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ascienden";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salida: (HH:MM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "LLegada: (HH:MM)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = ":";
            // 
            // tbMMSalida
            // 
            this.tbMMSalida.Location = new System.Drawing.Point(243, 96);
            this.tbMMSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMMSalida.Name = "tbMMSalida";
            this.tbMMSalida.Size = new System.Drawing.Size(53, 22);
            this.tbMMSalida.TabIndex = 12;
            // 
            // tbHHSalida
            // 
            this.tbHHSalida.Location = new System.Drawing.Point(163, 96);
            this.tbHHSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHHSalida.Name = "tbHHSalida";
            this.tbHHSalida.Size = new System.Drawing.Size(53, 22);
            this.tbHHSalida.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // tbMMParada
            // 
            this.tbMMParada.Location = new System.Drawing.Point(243, 27);
            this.tbMMParada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMMParada.Name = "tbMMParada";
            this.tbMMParada.Size = new System.Drawing.Size(53, 22);
            this.tbMMParada.TabIndex = 9;
            // 
            // tbHHParada
            // 
            this.tbHHParada.Location = new System.Drawing.Point(163, 27);
            this.tbHHParada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHHParada.Name = "tbHHParada";
            this.tbHHParada.Size = new System.Drawing.Size(53, 22);
            this.tbHHParada.TabIndex = 8;
            // 
            // btnRegistrarParada
            // 
            this.btnRegistrarParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarParada.Location = new System.Drawing.Point(115, 175);
            this.btnRegistrarParada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarParada.Name = "btnRegistrarParada";
            this.btnRegistrarParada.Size = new System.Drawing.Size(103, 53);
            this.btnRegistrarParada.TabIndex = 0;
            this.btnRegistrarParada.Text = "Registrar Parada";
            this.btnRegistrarParada.UseVisualStyleBackColor = true;
            this.btnRegistrarParada.Click += new System.EventHandler(this.btnRegistrarParada_Click);
            // 
            // gbInicioViaje
            // 
            this.gbInicioViaje.Controls.Add(this.label3);
            this.gbInicioViaje.Controls.Add(this.label2);
            this.gbInicioViaje.Controls.Add(this.label1);
            this.gbInicioViaje.Controls.Add(this.tbCantidadAsientos);
            this.gbInicioViaje.Controls.Add(this.tbMMInicio);
            this.gbInicioViaje.Controls.Add(this.tbHHInicio);
            this.gbInicioViaje.Controls.Add(this.btnIniciarRecorrido);
            this.gbInicioViaje.Location = new System.Drawing.Point(3, 4);
            this.gbInicioViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInicioViaje.Name = "gbInicioViaje";
            this.gbInicioViaje.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInicioViaje.Size = new System.Drawing.Size(342, 335);
            this.gbInicioViaje.TabIndex = 3;
            this.gbInicioViaje.TabStop = false;
            this.gbInicioViaje.Text = "Iniciar Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de Asientos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora de Partida: (HH:MM)";
            // 
            // tbCantidadAsientos
            // 
            this.tbCantidadAsientos.Location = new System.Drawing.Point(197, 97);
            this.tbCantidadAsientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCantidadAsientos.Name = "tbCantidadAsientos";
            this.tbCantidadAsientos.Size = new System.Drawing.Size(101, 22);
            this.tbCantidadAsientos.TabIndex = 3;
            // 
            // tbMMInicio
            // 
            this.tbMMInicio.Location = new System.Drawing.Point(281, 65);
            this.tbMMInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMMInicio.Name = "tbMMInicio";
            this.tbMMInicio.Size = new System.Drawing.Size(53, 22);
            this.tbMMInicio.TabIndex = 2;
            // 
            // tbHHInicio
            // 
            this.tbHHInicio.Location = new System.Drawing.Point(197, 65);
            this.tbHHInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHHInicio.Name = "tbHHInicio";
            this.tbHHInicio.Size = new System.Drawing.Size(53, 22);
            this.tbHHInicio.TabIndex = 1;
            // 
            // btnIniciarRecorrido
            // 
            this.btnIniciarRecorrido.Location = new System.Drawing.Point(156, 247);
            this.btnIniciarRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciarRecorrido.Name = "btnIniciarRecorrido";
            this.btnIniciarRecorrido.Size = new System.Drawing.Size(96, 53);
            this.btnIniciarRecorrido.TabIndex = 0;
            this.btnIniciarRecorrido.Text = "Iniciar Recorrido";
            this.btnIniciarRecorrido.UseVisualStyleBackColor = true;
            this.btnIniciarRecorrido.Click += new System.EventHandler(this.btnIniciarRecorrido_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 345);
            this.Controls.Add(this.gbLLegadaViaje);
            this.Controls.Add(this.gbParada);
            this.Controls.Add(this.gbInicioViaje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Empresa de colectivos";
            this.gbLLegadaViaje.ResumeLayout(false);
            this.gbLLegadaViaje.PerformLayout();
            this.gbParada.ResumeLayout(false);
            this.gbParada.PerformLayout();
            this.gbInicioViaje.ResumeLayout(false);
            this.gbInicioViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLLegadaViaje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMMFin;
        private System.Windows.Forms.TextBox tbHHFin;
        private System.Windows.Forms.ListBox lbxResultadoFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFinalizarViaje;
        private System.Windows.Forms.GroupBox gbParada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDescienden;
        private System.Windows.Forms.TextBox tbAscienden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMMSalida;
        private System.Windows.Forms.TextBox tbHHSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMMParada;
        private System.Windows.Forms.TextBox tbHHParada;
        private System.Windows.Forms.Button btnRegistrarParada;
        private System.Windows.Forms.GroupBox gbInicioViaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidadAsientos;
        private System.Windows.Forms.TextBox tbMMInicio;
        private System.Windows.Forms.TextBox tbHHInicio;
        private System.Windows.Forms.Button btnIniciarRecorrido;
        private System.Windows.Forms.ListBox lbxResultadoParada;
    }
}


using System.ComponentModel;

namespace Proyecto
{
    partial class frmEditaEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.txtTituloEvento = new System.Windows.Forms.TextBox();
            this.txtAsistentes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Enabled = false;
            this.txtIdEvento.Location = new System.Drawing.Point(177, 25);
            this.txtIdEvento.MaxLength = 10;
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(83, 20);
            this.txtIdEvento.TabIndex = 0;
            // 
            // txtTituloEvento
            // 
            this.txtTituloEvento.Location = new System.Drawing.Point(177, 67);
            this.txtTituloEvento.MaxLength = 100;
            this.txtTituloEvento.Name = "txtTituloEvento";
            this.txtTituloEvento.Size = new System.Drawing.Size(414, 20);
            this.txtTituloEvento.TabIndex = 1;
            // 
            // txtAsistentes
            // 
            this.txtAsistentes.Location = new System.Drawing.Point(178, 113);
            this.txtAsistentes.MaxLength = 10;
            this.txtAsistentes.Name = "txtAsistentes";
            this.txtAsistentes.Size = new System.Drawing.Size(82, 20);
            this.txtAsistentes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Evento:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Título Evento:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(63, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total de Asistentes";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(63, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 43);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 43);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmEditaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (229)))), ((int) (((byte) (233)))), ((int) (((byte) (240)))));
            this.ClientSize = new System.Drawing.Size(617, 251);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAsistentes);
            this.Controls.Add(this.txtTituloEvento);
            this.Controls.Add(this.txtIdEvento);
            this.Name = "frmEditaEvento";
            this.Text = "Edición de eventos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.TextBox txtAsistentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox txtTituloEvento;

        private System.Windows.Forms.TextBox txtIdEvento;

        #endregion
    }
}
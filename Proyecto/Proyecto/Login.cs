using System;
using System.Windows.Forms;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {   
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlInicio = new System.Windows.Forms.TabControl();
            this.tabInicioLogin1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIniciaSesion = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblPantallaIniciosesion = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtAdName = new System.Windows.Forms.TextBox();
            this.txtAdPassword = new System.Windows.Forms.TextBox();
            this.btmInicioLoginAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxUsuarioLoginUsua = new System.Windows.Forms.TextBox();
            this.btnHomeU = new System.Windows.Forms.Button();
            this.txtboxContraLoginUsua = new System.Windows.Forms.TextBox();
            this.btnLoginUsuario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlInicio.SuspendLayout();
            this.tabInicioLogin1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlInicio, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlInicio
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControlInicio, 2);
            this.tabControlInicio.Controls.Add(this.tabInicioLogin1);
            this.tabControlInicio.Controls.Add(this.tabControlAdmin);
            this.tabControlInicio.Controls.Add(this.tabUsuario);
            this.tabControlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInicio.Location = new System.Drawing.Point(3, 3);
            this.tabControlInicio.Name = "tabControlInicio";
            this.tableLayoutPanel1.SetRowSpan(this.tabControlInicio, 2);
            this.tabControlInicio.SelectedIndex = 0;
            this.tabControlInicio.Size = new System.Drawing.Size(661, 766);
            this.tabControlInicio.TabIndex = 0;
            // 
            // tabInicioLogin1
            // 
            this.tabInicioLogin1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (222)))), ((int) (((byte) (233)))));
            this.tabInicioLogin1.Controls.Add(this.label15);
            this.tabInicioLogin1.Controls.Add(this.label14);
            this.tabInicioLogin1.Controls.Add(this.label13);
            this.tabInicioLogin1.Controls.Add(this.label12);
            this.tabInicioLogin1.Controls.Add(this.groupBox1);
            this.tabInicioLogin1.Location = new System.Drawing.Point(4, 22);
            this.tabInicioLogin1.Name = "tabInicioLogin1";
            this.tabInicioLogin1.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicioLogin1.Size = new System.Drawing.Size(653, 740);
            this.tabInicioLogin1.TabIndex = 0;
            this.tabInicioLogin1.Text = "tabPage1";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.label15.Location = new System.Drawing.Point(609, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 574);
            this.label15.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 574);
            this.label14.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.label13.Location = new System.Drawing.Point(6, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(640, 73);
            this.label13.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(640, 65);
            this.label12.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblIniciaSesion);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.lblPantallaIniciosesion);
            this.groupBox1.Controls.Add(this.btnUsuario);
            this.groupBox1.Location = new System.Drawing.Point(87, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 510);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(488, 100);
            this.label9.TabIndex = 7;
            this.label9.Text = "BINAES";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIniciaSesion
            // 
            this.lblIniciaSesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.lblIniciaSesion.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIniciaSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIniciaSesion.Location = new System.Drawing.Point(6, 143);
            this.lblIniciaSesion.Name = "lblIniciaSesion";
            this.lblIniciaSesion.Size = new System.Drawing.Size(488, 79);
            this.lblIniciaSesion.TabIndex = 3;
            this.lblIniciaSesion.Text = "Inica sesión";
            this.lblIniciaSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdmin.Image = ((System.Drawing.Image) (resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(276, 338);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(170, 98);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblPantallaIniciosesion
            // 
            this.lblPantallaIniciosesion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.lblPantallaIniciosesion.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPantallaIniciosesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPantallaIniciosesion.Location = new System.Drawing.Point(6, 222);
            this.lblPantallaIniciosesion.Name = "lblPantallaIniciosesion";
            this.lblPantallaIniciosesion.Size = new System.Drawing.Size(488, 79);
            this.lblPantallaIniciosesion.TabIndex = 6;
            this.lblPantallaIniciosesion.Text = "¿Cómo deseas iniciar sessión?";
            this.lblPantallaIniciosesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Image = ((System.Drawing.Image) (resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(64, 338);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(170, 98);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (222)))), ((int) (((byte) (233)))));
            this.tabControlAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabControlAdmin.Controls.Add(this.groupBox2);
            this.tabControlAdmin.Controls.Add(this.label4);
            this.tabControlAdmin.Controls.Add(this.label3);
            this.tabControlAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlAdmin.Size = new System.Drawing.Size(653, 740);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.Text = "Admin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtAdName);
            this.groupBox2.Controls.Add(this.txtAdPassword);
            this.groupBox2.Controls.Add(this.btmInicioLoginAdmin);
            this.groupBox2.Location = new System.Drawing.Point(59, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 602);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(445, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 48);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(89, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 78);
            this.label11.TabIndex = 10;
            this.label11.Text = "Administrador";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(89, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Contraseña";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(101, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(259, 26);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Recuerdame";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtAdName
            // 
            this.txtAdName.Location = new System.Drawing.Point(229, 180);
            this.txtAdName.Multiline = true;
            this.txtAdName.Name = "txtAdName";
            this.txtAdName.Size = new System.Drawing.Size(216, 28);
            this.txtAdName.TabIndex = 3;
            // 
            // txtAdPassword
            // 
            this.txtAdPassword.Location = new System.Drawing.Point(229, 229);
            this.txtAdPassword.Multiline = true;
            this.txtAdPassword.Name = "txtAdPassword";
            this.txtAdPassword.PasswordChar = '*';
            this.txtAdPassword.Size = new System.Drawing.Size(216, 28);
            this.txtAdPassword.TabIndex = 4;
            // 
            // btmInicioLoginAdmin
            // 
            this.btmInicioLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (222)))), ((int) (((byte) (233)))));
            this.btmInicioLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmInicioLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btmInicioLoginAdmin.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.btmInicioLoginAdmin.Location = new System.Drawing.Point(101, 353);
            this.btmInicioLoginAdmin.Name = "btmInicioLoginAdmin";
            this.btmInicioLoginAdmin.Size = new System.Drawing.Size(344, 54);
            this.btmInicioLoginAdmin.TabIndex = 5;
            this.btmInicioLoginAdmin.Text = "Login";
            this.btmInicioLoginAdmin.UseVisualStyleBackColor = false;
            this.btmInicioLoginAdmin.Click += new System.EventHandler(this.btmLoginAd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(92, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(115, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 1;
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (222)))), ((int) (((byte) (233)))));
            this.tabUsuario.Controls.Add(this.groupBox3);
            this.tabUsuario.Controls.Add(this.label7);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(653, 740);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.groupBox3.Controls.Add(this.txtboxUsuarioLoginUsua);
            this.groupBox3.Controls.Add(this.btnHomeU);
            this.groupBox3.Controls.Add(this.txtboxContraLoginUsua);
            this.groupBox3.Controls.Add(this.btnLoginUsuario);
            this.groupBox3.Location = new System.Drawing.Point(63, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 577);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtboxUsuarioLoginUsua
            // 
            this.txtboxUsuarioLoginUsua.Location = new System.Drawing.Point(157, 179);
            this.txtboxUsuarioLoginUsua.Multiline = true;
            this.txtboxUsuarioLoginUsua.Name = "txtboxUsuarioLoginUsua";
            this.txtboxUsuarioLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxUsuarioLoginUsua.TabIndex = 3;
            // 
            // btnHomeU
            // 
            this.btnHomeU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeU.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHomeU.Image = ((System.Drawing.Image) (resources.GetObject("btnHomeU.Image")));
            this.btnHomeU.Location = new System.Drawing.Point(420, 488);
            this.btnHomeU.Name = "btnHomeU";
            this.btnHomeU.Size = new System.Drawing.Size(70, 48);
            this.btnHomeU.TabIndex = 7;
            this.btnHomeU.UseVisualStyleBackColor = true;
            this.btnHomeU.Click += new System.EventHandler(this.btnHomeU_Click);
            // 
            // txtboxContraLoginUsua
            // 
            this.txtboxContraLoginUsua.Location = new System.Drawing.Point(157, 243);
            this.txtboxContraLoginUsua.Multiline = true;
            this.txtboxContraLoginUsua.Name = "txtboxContraLoginUsua";
            this.txtboxContraLoginUsua.Size = new System.Drawing.Size(226, 31);
            this.txtboxContraLoginUsua.TabIndex = 4;
            // 
            // btnLoginUsuario
            // 
            this.btnLoginUsuario.Location = new System.Drawing.Point(166, 321);
            this.btnLoginUsuario.Name = "btnLoginUsuario";
            this.btnLoginUsuario.Size = new System.Drawing.Size(206, 54);
            this.btnLoginUsuario.TabIndex = 5;
            this.btnLoginUsuario.Text = "Login";
            this.btnLoginUsuario.UseVisualStyleBackColor = true;
            this.btnLoginUsuario.Click += new System.EventHandler(this.btnLoginUsuario_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(83, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 38);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(114, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 1;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 772);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlInicio.ResumeLayout(false);
            this.tabInicioLogin1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label lblPantallaIniciosesion;

        private System.Windows.Forms.Button btnAdmin;

        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblIniciaSesion;

        private System.Windows.Forms.Button btnHomeU;

        private System.Windows.Forms.TextBox txtboxContraLoginUsua;
        private System.Windows.Forms.Button btnLoginUsuario;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxUsuarioLoginUsua;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button btmInicioLoginAdmin;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdName;
        private System.Windows.Forms.TextBox txtAdPassword;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TabPage tabUsuario;

        private System.Windows.Forms.TabControl tabControlInicio;
        private System.Windows.Forms.TabPage tabInicioLogin1;
        private System.Windows.Forms.TabPage tabControlAdmin;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        

        private void btmLoginAd_Click(object sender, EventArgs e)
        {
            if (txtAdName.Text == "admin" && txtAdPassword.Text == "Claro")
            {
                using (frmPrincipal Ventana = new frmPrincipal("admin"))
                {
                    DialogResult Resultado = Ventana.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Información Incorrecta", "Inicio de Sesión", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            
        }

        private void btnLoginUsuario_Click(object sender, EventArgs e)
        {
            using (frmPrincipal Ventana = new frmPrincipal("usuario"))
            {
                DialogResult Resultado = Ventana.ShowDialog();
                if (Resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Your logged was succeed!!", "Cuenta Usuario", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }

            }
        }


        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 2;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 0;
        }

        private void btnHomeU_Click(object sender, EventArgs e)
        {
            tabControlInicio.SelectedIndex = 0;
        }
    }
}
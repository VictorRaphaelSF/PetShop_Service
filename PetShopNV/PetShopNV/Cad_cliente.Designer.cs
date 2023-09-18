namespace PetShopNV
{
    partial class Cad_cliente
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btt_minimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btt_fechar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nmcliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.nmtelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_login = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btt_localizar = new Guna.UI2.WinForms.Guna2Button();
            this.nmcpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_sair = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btt_minimizar
            // 
            this.btt_minimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_minimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_minimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_minimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_minimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_minimizar.ForeColor = System.Drawing.Color.White;
            this.btt_minimizar.Location = new System.Drawing.Point(330, 12);
            this.btt_minimizar.Name = "btt_minimizar";
            this.btt_minimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btt_minimizar.TabIndex = 10;
            this.btt_minimizar.Text = "━";
            this.btt_minimizar.Click += new System.EventHandler(this.btt_minimizar_Click);
            // 
            // btt_fechar
            // 
            this.btt_fechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_fechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_fechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_fechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_fechar.ForeColor = System.Drawing.Color.White;
            this.btt_fechar.Location = new System.Drawing.Point(366, 12);
            this.btt_fechar.Name = "btt_fechar";
            this.btt_fechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_fechar.Size = new System.Drawing.Size(30, 30);
            this.btt_fechar.TabIndex = 9;
            this.btt_fechar.Text = "X";
            this.btt_fechar.Click += new System.EventHandler(this.btt_fechar_Click);
            // 
            // nmcliente
            // 
            this.nmcliente.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmcliente.BorderRadius = 10;
            this.nmcliente.BorderThickness = 2;
            this.nmcliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmcliente.DefaultText = "";
            this.nmcliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmcliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmcliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmcliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmcliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmcliente.Location = new System.Drawing.Point(84, 139);
            this.nmcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcliente.MaxLength = 100;
            this.nmcliente.Name = "nmcliente";
            this.nmcliente.PasswordChar = '\0';
            this.nmcliente.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmcliente.PlaceholderText = "Nome do cliente";
            this.nmcliente.SelectedText = "";
            this.nmcliente.Size = new System.Drawing.Size(230, 40);
            this.nmcliente.TabIndex = 12;
            // 
            // nmtelefone
            // 
            this.nmtelefone.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmtelefone.BorderRadius = 10;
            this.nmtelefone.BorderThickness = 2;
            this.nmtelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmtelefone.DefaultText = "";
            this.nmtelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmtelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmtelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmtelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmtelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmtelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmtelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmtelefone.Location = new System.Drawing.Point(84, 200);
            this.nmtelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmtelefone.MaxLength = 11;
            this.nmtelefone.Name = "nmtelefone";
            this.nmtelefone.PasswordChar = '\0';
            this.nmtelefone.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmtelefone.PlaceholderText = "Telefone(Cel)";
            this.nmtelefone.SelectedText = "";
            this.nmtelefone.Size = new System.Drawing.Size(230, 40);
            this.nmtelefone.TabIndex = 13;
            // 
            // btt_login
            // 
            this.btt_login.BackColor = System.Drawing.Color.Transparent;
            this.btt_login.BorderRadius = 20;
            this.btt_login.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btt_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_login.ForeColor = System.Drawing.Color.White;
            this.btt_login.Location = new System.Drawing.Point(213, 332);
            this.btt_login.Name = "btt_login";
            this.btt_login.Size = new System.Drawing.Size(167, 43);
            this.btt_login.TabIndex = 15;
            this.btt_login.Text = "Cadastrar";
            this.btt_login.Click += new System.EventHandler(this.btt_login_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_titulo.Location = new System.Drawing.Point(79, 4);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(237, 41);
            this.lbl_titulo.TabIndex = 17;
            this.lbl_titulo.Text = "Cadastrar Cliente";
            // 
            // btt_localizar
            // 
            this.btt_localizar.BackColor = System.Drawing.Color.Transparent;
            this.btt_localizar.BorderRadius = 20;
            this.btt_localizar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btt_localizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_localizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_localizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_localizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_localizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_localizar.ForeColor = System.Drawing.Color.White;
            this.btt_localizar.Location = new System.Drawing.Point(25, 332);
            this.btt_localizar.Name = "btt_localizar";
            this.btt_localizar.Size = new System.Drawing.Size(167, 43);
            this.btt_localizar.TabIndex = 18;
            this.btt_localizar.Text = "Localizar cliente";
            this.btt_localizar.Click += new System.EventHandler(this.btt_localizar_Click_1);
            // 
            // nmcpf
            // 
            this.nmcpf.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmcpf.BorderRadius = 10;
            this.nmcpf.BorderThickness = 2;
            this.nmcpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmcpf.DefaultText = "";
            this.nmcpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmcpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmcpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmcpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmcpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmcpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmcpf.Location = new System.Drawing.Point(84, 264);
            this.nmcpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcpf.MaxLength = 11;
            this.nmcpf.Name = "nmcpf";
            this.nmcpf.PasswordChar = '\0';
            this.nmcpf.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmcpf.PlaceholderText = "CPF";
            this.nmcpf.SelectedText = "";
            this.nmcpf.Size = new System.Drawing.Size(230, 40);
            this.nmcpf.TabIndex = 14;
            // 
            // btt_sair
            // 
            this.btt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btt_sair.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_sair.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_sair.Image = global::PetShopNV.Properties.Resources.sair1;
            this.btt_sair.ImageOffset = new System.Drawing.Point(0, 0);
            this.btt_sair.ImageRotate = 0F;
            this.btt_sair.Location = new System.Drawing.Point(12, 8);
            this.btt_sair.Name = "btt_sair";
            this.btt_sair.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_sair.Size = new System.Drawing.Size(81, 75);
            this.btt_sair.TabIndex = 11;
            this.btt_sair.Click += new System.EventHandler(this.btt_sair_Click);
            // 
            // Cad_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.btt_localizar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btt_login);
            this.Controls.Add(this.nmcpf);
            this.Controls.Add(this.nmtelefone);
            this.Controls.Add(this.nmcliente);
            this.Controls.Add(this.btt_sair);
            this.Controls.Add(this.btt_minimizar);
            this.Controls.Add(this.btt_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cad_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_cliente";
            this.Load += new System.EventHandler(this.Cad_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton btt_minimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btt_fechar;
        private Guna.UI2.WinForms.Guna2ImageButton btt_sair;
        private Guna.UI2.WinForms.Guna2TextBox nmcliente;
        private Guna.UI2.WinForms.Guna2TextBox nmtelefone;
        private Guna.UI2.WinForms.Guna2Button btt_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2Button btt_localizar;
        private Guna.UI2.WinForms.Guna2TextBox nmcpf;
    }
}
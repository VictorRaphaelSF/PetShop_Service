namespace PetShopNV
{
    partial class Cad_pet
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
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btt_login = new Guna.UI2.WinForms.Guna2Button();
            this.nmraca = new Guna.UI2.WinForms.Guna2TextBox();
            this.nmpet = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_minimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btt_fechar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btt_sair = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_localizar = new Guna.UI2.WinForms.Guna2Button();
            this.cpftext = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_titulo.Location = new System.Drawing.Point(103, 6);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(183, 41);
            this.lbl_titulo.TabIndex = 26;
            this.lbl_titulo.Text = "Cadastrar Pet";
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
            this.btt_login.TabIndex = 25;
            this.btt_login.Text = "Cadastrar";
            this.btt_login.Click += new System.EventHandler(this.btt_login_Click);
            // 
            // nmraca
            // 
            this.nmraca.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmraca.BorderRadius = 10;
            this.nmraca.BorderThickness = 2;
            this.nmraca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmraca.DefaultText = "";
            this.nmraca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmraca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmraca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmraca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmraca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmraca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmraca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmraca.Location = new System.Drawing.Point(84, 200);
            this.nmraca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmraca.MaxLength = 11;
            this.nmraca.Name = "nmraca";
            this.nmraca.PasswordChar = '\0';
            this.nmraca.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmraca.PlaceholderText = "Porte(Raça)";
            this.nmraca.SelectedText = "";
            this.nmraca.Size = new System.Drawing.Size(230, 40);
            this.nmraca.TabIndex = 23;
            // 
            // nmpet
            // 
            this.nmpet.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmpet.BorderRadius = 10;
            this.nmpet.BorderThickness = 2;
            this.nmpet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmpet.DefaultText = "";
            this.nmpet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmpet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmpet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmpet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmpet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmpet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmpet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmpet.Location = new System.Drawing.Point(84, 139);
            this.nmpet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmpet.MaxLength = 100;
            this.nmpet.Name = "nmpet";
            this.nmpet.PasswordChar = '\0';
            this.nmpet.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmpet.PlaceholderText = "Nome do pet";
            this.nmpet.SelectedText = "";
            this.nmpet.Size = new System.Drawing.Size(230, 40);
            this.nmpet.TabIndex = 22;
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
            this.btt_minimizar.TabIndex = 20;
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
            this.btt_fechar.TabIndex = 19;
            this.btt_fechar.Text = "X";
            this.btt_fechar.Click += new System.EventHandler(this.btt_fechar_Click);
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
            this.btt_sair.TabIndex = 21;
            this.btt_sair.Click += new System.EventHandler(this.btt_sair_Click);
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
            this.btt_localizar.TabIndex = 27;
            this.btt_localizar.Text = "Localizar cliente";
            this.btt_localizar.Click += new System.EventHandler(this.btt_localizar_Click);
            // 
            // cpftext
            // 
            this.cpftext.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cpftext.BorderRadius = 10;
            this.cpftext.BorderThickness = 2;
            this.cpftext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cpftext.DefaultText = "";
            this.cpftext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cpftext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cpftext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cpftext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cpftext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cpftext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpftext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cpftext.Location = new System.Drawing.Point(84, 264);
            this.cpftext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpftext.MaxLength = 11;
            this.cpftext.Name = "cpftext";
            this.cpftext.PasswordChar = '\0';
            this.cpftext.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.cpftext.PlaceholderText = "CPF do Cliente";
            this.cpftext.SelectedText = "";
            this.cpftext.Size = new System.Drawing.Size(230, 40);
            this.cpftext.TabIndex = 28;
            // 
            // Cad_pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.cpftext);
            this.Controls.Add(this.btt_localizar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btt_login);
            this.Controls.Add(this.nmraca);
            this.Controls.Add(this.nmpet);
            this.Controls.Add(this.btt_sair);
            this.Controls.Add(this.btt_minimizar);
            this.Controls.Add(this.btt_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cad_pet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_pet";
            this.Load += new System.EventHandler(this.Cad_pet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2Button btt_login;
        private Guna.UI2.WinForms.Guna2TextBox nmraca;
        private Guna.UI2.WinForms.Guna2TextBox nmpet;
        private Guna.UI2.WinForms.Guna2ImageButton btt_sair;
        private Guna.UI2.WinForms.Guna2CircleButton btt_minimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btt_fechar;
        private Guna.UI2.WinForms.Guna2Button btt_localizar;
        private Guna.UI2.WinForms.Guna2TextBox cpftext;
    }
}
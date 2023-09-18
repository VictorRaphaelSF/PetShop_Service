namespace PetShopNV
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usuariotext = new Guna.UI2.WinForms.Guna2TextBox();
            this.senhatext = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_login = new Guna.UI2.WinForms.Guna2Button();
            this.Borda = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btt_fechar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btt_minimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.img_logo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_titulo.Location = new System.Drawing.Point(82, 73);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(251, 67);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cão Amigo";
            // 
            // usuariotext
            // 
            this.usuariotext.BorderColor = System.Drawing.SystemColors.Highlight;
            this.usuariotext.BorderRadius = 10;
            this.usuariotext.BorderThickness = 2;
            this.usuariotext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuariotext.DefaultText = "";
            this.usuariotext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usuariotext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usuariotext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usuariotext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usuariotext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usuariotext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usuariotext.Location = new System.Drawing.Point(93, 188);
            this.usuariotext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usuariotext.MaxLength = 100;
            this.usuariotext.Name = "usuariotext";
            this.usuariotext.PasswordChar = '\0';
            this.usuariotext.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.usuariotext.PlaceholderText = "Usuario";
            this.usuariotext.SelectedText = "";
            this.usuariotext.Size = new System.Drawing.Size(227, 36);
            this.usuariotext.TabIndex = 1;
            this.usuariotext.TextChanged += new System.EventHandler(this.usuariotext_TextChanged);
            // 
            // senhatext
            // 
            this.senhatext.BorderColor = System.Drawing.SystemColors.Highlight;
            this.senhatext.BorderRadius = 10;
            this.senhatext.BorderThickness = 2;
            this.senhatext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senhatext.DefaultText = "";
            this.senhatext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.senhatext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.senhatext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhatext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhatext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.senhatext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.senhatext.Location = new System.Drawing.Point(93, 257);
            this.senhatext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.senhatext.MaxLength = 18;
            this.senhatext.Name = "senhatext";
            this.senhatext.PasswordChar = '*';
            this.senhatext.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.senhatext.PlaceholderText = "Senha";
            this.senhatext.SelectedText = "";
            this.senhatext.Size = new System.Drawing.Size(227, 36);
            this.senhatext.TabIndex = 2;
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
            this.btt_login.Location = new System.Drawing.Point(122, 329);
            this.btt_login.Name = "btt_login";
            this.btt_login.Size = new System.Drawing.Size(167, 43);
            this.btt_login.TabIndex = 3;
            this.btt_login.Text = "Login";
            this.btt_login.Click += new System.EventHandler(this.btt_login_Click);
            // 
            // Borda
            // 
            this.Borda.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
            this.Borda.ContainerControl = this;
            this.Borda.DockIndicatorColor = System.Drawing.Color.Gray;
            this.Borda.DockIndicatorTransparencyValue = 0.6D;
            this.Borda.TransparentWhileDrag = true;
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
            this.btt_fechar.TabIndex = 5;
            this.btt_fechar.Text = "X";
            this.btt_fechar.Click += new System.EventHandler(this.btt_fechar_Click);
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
            this.btt_minimizar.TabIndex = 6;
            this.btt_minimizar.Text = "━";
            this.btt_minimizar.Click += new System.EventHandler(this.btt_minimizar_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::PetShopNV.Properties.Resources.dogrun21;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(310, 378);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(84, 91);
            this.guna2ImageButton1.TabIndex = 15;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = global::PetShopNV.Properties.Resources.patinha;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 130F;
            this.guna2ImageButton2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.guna2ImageButton2.Location = new System.Drawing.Point(0, 135);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(87, 89);
            this.guna2ImageButton2.TabIndex = 14;
            // 
            // img_logo
            // 
            this.img_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img_logo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_logo.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_logo.Image = global::PetShopNV.Properties.Resources.DOGZINHO;
            this.img_logo.ImageOffset = new System.Drawing.Point(0, 0);
            this.img_logo.ImageRotate = 0F;
            this.img_logo.Location = new System.Drawing.Point(173, 30);
            this.img_logo.Name = "img_logo";
            this.img_logo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.img_logo.Size = new System.Drawing.Size(64, 54);
            this.img_logo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.btt_minimizar);
            this.Controls.Add(this.btt_fechar);
            this.Controls.Add(this.btt_login);
            this.Controls.Add(this.senhatext);
            this.Controls.Add(this.usuariotext);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2TextBox usuariotext;
        private Guna.UI2.WinForms.Guna2TextBox senhatext;
        private Guna.UI2.WinForms.Guna2Button btt_login;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borda;
        private Guna.UI2.WinForms.Guna2CircleButton btt_minimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btt_fechar;
        private Guna.UI2.WinForms.Guna2ImageButton img_logo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}


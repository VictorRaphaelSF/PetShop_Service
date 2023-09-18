namespace PetShopNV
{
    partial class Localizar
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
            this.pesquisartext = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableloca = new System.Windows.Forms.ListView();
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btt_loca = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.btt_minimizar.Location = new System.Drawing.Point(501, 12);
            this.btt_minimizar.Name = "btt_minimizar";
            this.btt_minimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btt_minimizar.TabIndex = 14;
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
            this.btt_fechar.Location = new System.Drawing.Point(537, 12);
            this.btt_fechar.Name = "btt_fechar";
            this.btt_fechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_fechar.Size = new System.Drawing.Size(30, 30);
            this.btt_fechar.TabIndex = 13;
            this.btt_fechar.Text = "X";
            this.btt_fechar.Click += new System.EventHandler(this.btt_fechar_Click);
            // 
            // pesquisartext
            // 
            this.pesquisartext.BorderColor = System.Drawing.SystemColors.Highlight;
            this.pesquisartext.BorderRadius = 10;
            this.pesquisartext.BorderThickness = 2;
            this.pesquisartext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pesquisartext.DefaultText = "";
            this.pesquisartext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pesquisartext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pesquisartext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pesquisartext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pesquisartext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pesquisartext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisartext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pesquisartext.Location = new System.Drawing.Point(24, 108);
            this.pesquisartext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pesquisartext.MaxLength = 100;
            this.pesquisartext.Name = "pesquisartext";
            this.pesquisartext.PasswordChar = '\0';
            this.pesquisartext.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pesquisartext.PlaceholderText = "Pesquisar cliente";
            this.pesquisartext.SelectedText = "";
            this.pesquisartext.Size = new System.Drawing.Size(449, 36);
            this.pesquisartext.TabIndex = 15;
            this.pesquisartext.TextChanged += new System.EventHandler(this.pesquisartext_TextChanged);
            // 
            // tableloca
            // 
            this.tableloca.HideSelection = false;
            this.tableloca.Location = new System.Drawing.Point(18, 167);
            this.tableloca.Name = "tableloca";
            this.tableloca.Size = new System.Drawing.Size(547, 225);
            this.tableloca.TabIndex = 16;
            this.tableloca.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_titulo.Location = new System.Drawing.Point(208, -1);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(147, 49);
            this.lbl_titulo.TabIndex = 17;
            this.lbl_titulo.Text = "Localizar";
            // 
            // btt_loca
            // 
            this.btt_loca.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_loca.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_loca.Image = global::PetShopNV.Properties.Resources.search1;
            this.btt_loca.ImageOffset = new System.Drawing.Point(0, 0);
            this.btt_loca.ImageRotate = 0F;
            this.btt_loca.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_loca.Location = new System.Drawing.Point(485, 96);
            this.btt_loca.Name = "btt_loca";
            this.btt_loca.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_loca.Size = new System.Drawing.Size(52, 59);
            this.btt_loca.TabIndex = 18;
            this.btt_loca.Click += new System.EventHandler(this.guna2ImageButton1_Click);
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
            this.btt_sair.TabIndex = 12;
            this.btt_sair.Click += new System.EventHandler(this.btt_sair_Click);
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btt_loca);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.tableloca);
            this.Controls.Add(this.pesquisartext);
            this.Controls.Add(this.btt_minimizar);
            this.Controls.Add(this.btt_fechar);
            this.Controls.Add(this.btt_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Localizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.Load += new System.EventHandler(this.Localizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton btt_sair;
        private Guna.UI2.WinForms.Guna2CircleButton btt_minimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btt_fechar;
        private System.Windows.Forms.ListView tableloca;
        private Guna.UI2.WinForms.Guna2TextBox pesquisartext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2ImageButton btt_loca;
    }
}
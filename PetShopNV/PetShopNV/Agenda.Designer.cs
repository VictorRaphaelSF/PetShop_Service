namespace PetShopNV
{
    partial class Agenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbl_titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nmvalor = new Guna.UI2.WinForms.Guna2TextBox();
            this.nmcliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_sair = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_minimizar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btt_fechar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbboxserviço = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_serviço = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbboxmes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_mes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_dia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbboxdia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_hora = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ccbboxhora = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_pet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbboxpet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btt_loca = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_nmusu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_agendar = new Guna.UI2.WinForms.Guna2Button();
            this.btt_carregar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_minuto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbboxminutos = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
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
            this.lbl_titulo.Location = new System.Drawing.Point(399, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(193, 41);
            this.lbl_titulo.TabIndex = 21;
            this.lbl_titulo.Text = "Agendamento";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // nmvalor
            // 
            this.nmvalor.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nmvalor.BorderRadius = 10;
            this.nmvalor.BorderThickness = 2;
            this.nmvalor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmvalor.DefaultText = "";
            this.nmvalor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmvalor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmvalor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmvalor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmvalor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmvalor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmvalor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmvalor.Location = new System.Drawing.Point(53, 351);
            this.nmvalor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmvalor.MaxLength = 11;
            this.nmvalor.Name = "nmvalor";
            this.nmvalor.PasswordChar = '\0';
            this.nmvalor.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmvalor.PlaceholderText = "Valor";
            this.nmvalor.SelectedText = "";
            this.nmvalor.Size = new System.Drawing.Size(230, 40);
            this.nmvalor.TabIndex = 20;
            this.nmvalor.TextChanged += new System.EventHandler(this.nmcpf_TextChanged);
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
            this.nmcliente.Location = new System.Drawing.Point(53, 94);
            this.nmcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmcliente.MaxLength = 11;
            this.nmcliente.Name = "nmcliente";
            this.nmcliente.PasswordChar = '\0';
            this.nmcliente.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nmcliente.PlaceholderText = "CPF do cliente";
            this.nmcliente.SelectedText = "";
            this.nmcliente.Size = new System.Drawing.Size(230, 40);
            this.nmcliente.TabIndex = 18;
            this.nmcliente.TextChanged += new System.EventHandler(this.nmcliente_TextChanged);
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
            this.btt_sair.TabIndex = 24;
            this.btt_sair.Click += new System.EventHandler(this.btt_sair_Click);
            // 
            // btt_minimizar
            // 
            this.btt_minimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_minimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_minimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_minimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_minimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_minimizar.ForeColor = System.Drawing.Color.White;
            this.btt_minimizar.Location = new System.Drawing.Point(943, 12);
            this.btt_minimizar.Name = "btt_minimizar";
            this.btt_minimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_minimizar.Size = new System.Drawing.Size(30, 30);
            this.btt_minimizar.TabIndex = 23;
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
            this.btt_fechar.Location = new System.Drawing.Point(979, 12);
            this.btt_fechar.Name = "btt_fechar";
            this.btt_fechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btt_fechar.Size = new System.Drawing.Size(30, 30);
            this.btt_fechar.TabIndex = 22;
            this.btt_fechar.Text = "X";
            this.btt_fechar.Click += new System.EventHandler(this.btt_fechar_Click);
            // 
            // cbboxserviço
            // 
            this.cbboxserviço.BackColor = System.Drawing.Color.Transparent;
            this.cbboxserviço.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cbboxserviço.BorderRadius = 10;
            this.cbboxserviço.BorderThickness = 2;
            this.cbboxserviço.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxserviço.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxserviço.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxserviço.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxserviço.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxserviço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxserviço.ItemHeight = 30;
            this.cbboxserviço.Items.AddRange(new object[] {
            "Banho",
            "Tosa",
            "Banho e Tosa"});
            this.cbboxserviço.Location = new System.Drawing.Point(53, 223);
            this.cbboxserviço.Name = "cbboxserviço";
            this.cbboxserviço.Size = new System.Drawing.Size(230, 36);
            this.cbboxserviço.TabIndex = 25;
            // 
            // lbl_serviço
            // 
            this.lbl_serviço.BackColor = System.Drawing.Color.Transparent;
            this.lbl_serviço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serviço.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_serviço.Location = new System.Drawing.Point(137, 199);
            this.lbl_serviço.Name = "lbl_serviço";
            this.lbl_serviço.Size = new System.Drawing.Size(55, 22);
            this.lbl_serviço.TabIndex = 26;
            this.lbl_serviço.Text = "Serviço";
            // 
            // cbboxmes
            // 
            this.cbboxmes.BackColor = System.Drawing.Color.Transparent;
            this.cbboxmes.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cbboxmes.BorderRadius = 10;
            this.cbboxmes.BorderThickness = 2;
            this.cbboxmes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxmes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxmes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxmes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxmes.ItemHeight = 30;
            this.cbboxmes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbboxmes.Location = new System.Drawing.Point(8, 426);
            this.cbboxmes.Name = "cbboxmes";
            this.cbboxmes.Size = new System.Drawing.Size(85, 36);
            this.cbboxmes.TabIndex = 27;
            // 
            // lbl_mes
            // 
            this.lbl_mes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_mes.Location = new System.Drawing.Point(32, 398);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(33, 22);
            this.lbl_mes.TabIndex = 28;
            this.lbl_mes.Text = "Mês";
            // 
            // lbl_dia
            // 
            this.lbl_dia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_dia.Location = new System.Drawing.Point(127, 398);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(27, 22);
            this.lbl_dia.TabIndex = 30;
            this.lbl_dia.Text = "Dia";
            // 
            // cbboxdia
            // 
            this.cbboxdia.BackColor = System.Drawing.Color.Transparent;
            this.cbboxdia.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cbboxdia.BorderRadius = 10;
            this.cbboxdia.BorderThickness = 2;
            this.cbboxdia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxdia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxdia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxdia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxdia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxdia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxdia.ItemHeight = 30;
            this.cbboxdia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbboxdia.Location = new System.Drawing.Point(99, 426);
            this.cbboxdia.Name = "cbboxdia";
            this.cbboxdia.Size = new System.Drawing.Size(85, 36);
            this.cbboxdia.TabIndex = 29;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_hora.Location = new System.Drawing.Point(210, 398);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(38, 22);
            this.lbl_hora.TabIndex = 32;
            this.lbl_hora.Text = "Hora";
            // 
            // ccbboxhora
            // 
            this.ccbboxhora.BackColor = System.Drawing.Color.Transparent;
            this.ccbboxhora.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ccbboxhora.BorderRadius = 10;
            this.ccbboxhora.BorderThickness = 2;
            this.ccbboxhora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbboxhora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbboxhora.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbboxhora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ccbboxhora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ccbboxhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ccbboxhora.ItemHeight = 30;
            this.ccbboxhora.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ccbboxhora.Location = new System.Drawing.Point(190, 426);
            this.ccbboxhora.Name = "ccbboxhora";
            this.ccbboxhora.Size = new System.Drawing.Size(85, 36);
            this.ccbboxhora.TabIndex = 31;
            // 
            // lbl_pet
            // 
            this.lbl_pet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pet.Location = new System.Drawing.Point(145, 267);
            this.lbl_pet.Name = "lbl_pet";
            this.lbl_pet.Size = new System.Drawing.Size(35, 22);
            this.lbl_pet.TabIndex = 34;
            this.lbl_pet.Text = "Pets";
            // 
            // cbboxpet
            // 
            this.cbboxpet.BackColor = System.Drawing.Color.Transparent;
            this.cbboxpet.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cbboxpet.BorderRadius = 10;
            this.cbboxpet.BorderThickness = 2;
            this.cbboxpet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxpet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxpet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxpet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxpet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxpet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxpet.ItemHeight = 30;
            this.cbboxpet.Location = new System.Drawing.Point(53, 290);
            this.cbboxpet.Name = "cbboxpet";
            this.cbboxpet.Size = new System.Drawing.Size(230, 36);
            this.cbboxpet.TabIndex = 33;
            this.cbboxpet.SelectedIndexChanged += new System.EventHandler(this.cbboxpet_SelectedIndexChanged);
            // 
            // btt_loca
            // 
            this.btt_loca.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_loca.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_loca.Image = global::PetShopNV.Properties.Resources.search1;
            this.btt_loca.ImageOffset = new System.Drawing.Point(0, 0);
            this.btt_loca.ImageRotate = 0F;
            this.btt_loca.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_loca.Location = new System.Drawing.Point(285, 84);
            this.btt_loca.Name = "btt_loca";
            this.btt_loca.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_loca.Size = new System.Drawing.Size(52, 59);
            this.btt_loca.TabIndex = 35;
            this.btt_loca.Click += new System.EventHandler(this.btt_loca_Click);
            // 
            // txt_nmusu
            // 
            this.txt_nmusu.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txt_nmusu.BorderRadius = 10;
            this.txt_nmusu.BorderThickness = 2;
            this.txt_nmusu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nmusu.DefaultText = "";
            this.txt_nmusu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nmusu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nmusu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmusu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nmusu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmusu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nmusu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nmusu.Location = new System.Drawing.Point(53, 157);
            this.txt_nmusu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nmusu.MaxLength = 11;
            this.txt_nmusu.Name = "txt_nmusu";
            this.txt_nmusu.PasswordChar = '\0';
            this.txt_nmusu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_nmusu.PlaceholderText = "Nome do cliente";
            this.txt_nmusu.ReadOnly = true;
            this.txt_nmusu.SelectedText = "";
            this.txt_nmusu.Size = new System.Drawing.Size(230, 40);
            this.txt_nmusu.TabIndex = 39;
            // 
            // btt_agendar
            // 
            this.btt_agendar.BackColor = System.Drawing.Color.Transparent;
            this.btt_agendar.BorderRadius = 20;
            this.btt_agendar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btt_agendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btt_agendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btt_agendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btt_agendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btt_agendar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_agendar.ForeColor = System.Drawing.Color.White;
            this.btt_agendar.Location = new System.Drawing.Point(83, 478);
            this.btt_agendar.Name = "btt_agendar";
            this.btt_agendar.Size = new System.Drawing.Size(167, 43);
            this.btt_agendar.TabIndex = 40;
            this.btt_agendar.Text = "Agendar";
            this.btt_agendar.Click += new System.EventHandler(this.btt_agendar_Click);
            // 
            // btt_carregar
            // 
            this.btt_carregar.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_carregar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_carregar.Image = global::PetShopNV.Properties.Resources.search1;
            this.btt_carregar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btt_carregar.ImageRotate = 0F;
            this.btt_carregar.ImageSize = new System.Drawing.Size(50, 50);
            this.btt_carregar.Location = new System.Drawing.Point(943, 451);
            this.btt_carregar.Name = "btt_carregar";
            this.btt_carregar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btt_carregar.Size = new System.Drawing.Size(52, 59);
            this.btt_carregar.TabIndex = 41;
            this.btt_carregar.Click += new System.EventHandler(this.btt_carregar_Click);
            // 
            // DataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.Location = new System.Drawing.Point(385, 95);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(614, 350);
            this.DataGrid.TabIndex = 42;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.ThemeStyle.HeaderStyle.Height = 15;
            this.DataGrid.ThemeStyle.ReadOnly = false;
            this.DataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // lbl_minuto
            // 
            this.lbl_minuto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minuto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_minuto.Location = new System.Drawing.Point(293, 399);
            this.lbl_minuto.Name = "lbl_minuto";
            this.lbl_minuto.Size = new System.Drawing.Size(59, 22);
            this.lbl_minuto.TabIndex = 44;
            this.lbl_minuto.Text = "Minutos";
            // 
            // cbboxminutos
            // 
            this.cbboxminutos.BackColor = System.Drawing.Color.Transparent;
            this.cbboxminutos.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cbboxminutos.BorderRadius = 10;
            this.cbboxminutos.BorderThickness = 2;
            this.cbboxminutos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxminutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxminutos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxminutos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxminutos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxminutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxminutos.ItemHeight = 30;
            this.cbboxminutos.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "59"});
            this.cbboxminutos.Location = new System.Drawing.Point(281, 426);
            this.cbboxminutos.Name = "cbboxminutos";
            this.cbboxminutos.Size = new System.Drawing.Size(85, 36);
            this.cbboxminutos.TabIndex = 43;
            // 
            // Agenda
            // 
            this.AccessibleDescription = "Serviço";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.lbl_minuto);
            this.Controls.Add(this.cbboxminutos);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btt_carregar);
            this.Controls.Add(this.btt_agendar);
            this.Controls.Add(this.txt_nmusu);
            this.Controls.Add(this.btt_loca);
            this.Controls.Add(this.lbl_pet);
            this.Controls.Add(this.cbboxpet);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.ccbboxhora);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.cbboxdia);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.cbboxmes);
            this.Controls.Add(this.lbl_serviço);
            this.Controls.Add(this.cbboxserviço);
            this.Controls.Add(this.btt_sair);
            this.Controls.Add(this.btt_minimizar);
            this.Controls.Add(this.btt_fechar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.nmvalor);
            this.Controls.Add(this.nmcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_titulo;
        private Guna.UI2.WinForms.Guna2TextBox nmvalor;
        private Guna.UI2.WinForms.Guna2TextBox nmcliente;
        private Guna.UI2.WinForms.Guna2ImageButton btt_sair;
        private Guna.UI2.WinForms.Guna2CircleButton btt_minimizar;
        private Guna.UI2.WinForms.Guna2CircleButton btt_fechar;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxserviço;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_serviço;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_hora;
        private Guna.UI2.WinForms.Guna2ComboBox ccbboxhora;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dia;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxdia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_mes;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxmes;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_pet;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxpet;
        private Guna.UI2.WinForms.Guna2ImageButton btt_loca;
        private Guna.UI2.WinForms.Guna2TextBox txt_nmusu;
        private Guna.UI2.WinForms.Guna2Button btt_agendar;
        private Guna.UI2.WinForms.Guna2ImageButton btt_carregar;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_minuto;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxminutos;
    }
}
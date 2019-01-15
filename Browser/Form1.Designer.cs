namespace Browser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btArrowLeft = new System.Windows.Forms.ToolStripButton();
            this.btArrowRight = new System.Windows.Forms.ToolStripButton();
            this.btRecarregar = new System.Windows.Forms.ToolStripButton();
            this.btHome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripOpcao = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemYahoo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.exiberBarrasDeFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btFavoritos = new System.Windows.Forms.ToolStripButton();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.wbPage = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripMenu.SuspendLayout();
            this.toolStripOpcao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btArrowLeft,
            this.btArrowRight,
            this.btRecarregar,
            this.btHome});
            this.toolStripMenu.Location = new System.Drawing.Point(4, 4);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(104, 25);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btArrowLeft
            // 
            this.btArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.btArrowLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btArrowLeft.Image = ((System.Drawing.Image)(resources.GetObject("btArrowLeft.Image")));
            this.btArrowLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btArrowLeft.Name = "btArrowLeft";
            this.btArrowLeft.Size = new System.Drawing.Size(23, 22);
            this.btArrowLeft.Text = "Voltar";
            this.btArrowLeft.Click += new System.EventHandler(this.btArrowLeft_Click);
            // 
            // btArrowRight
            // 
            this.btArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.btArrowRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btArrowRight.Image = ((System.Drawing.Image)(resources.GetObject("btArrowRight.Image")));
            this.btArrowRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btArrowRight.Name = "btArrowRight";
            this.btArrowRight.Size = new System.Drawing.Size(23, 22);
            this.btArrowRight.Text = "Avançar";
            this.btArrowRight.Click += new System.EventHandler(this.btArrowRight_Click);
            // 
            // btRecarregar
            // 
            this.btRecarregar.BackColor = System.Drawing.Color.Transparent;
            this.btRecarregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRecarregar.Image = ((System.Drawing.Image)(resources.GetObject("btRecarregar.Image")));
            this.btRecarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRecarregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(23, 22);
            this.btRecarregar.Text = "Recarregar esta página";
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(23, 22);
            this.btHome.Text = "Abrir á pagina inicial";
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Location = new System.Drawing.Point(4, 33);
            this.toolStrip2.MinimumSize = new System.Drawing.Size(1128, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1128, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripOpcao
            // 
            this.toolStripOpcao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripOpcao.BackColor = System.Drawing.Color.Transparent;
            this.toolStripOpcao.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripOpcao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.btFavoritos});
            this.toolStripOpcao.Location = new System.Drawing.Point(1034, 4);
            this.toolStripOpcao.Name = "toolStripOpcao";
            this.toolStripOpcao.Size = new System.Drawing.Size(98, 25);
            this.toolStripOpcao.TabIndex = 10;
            this.toolStripOpcao.Text = "toolStrip3";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItemSair});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton1";
            this.toolStripSplitButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGoogle,
            this.toolStripMenuItemYahoo,
            this.toolStripMenuItemBig});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Mecanismo de Busca";
            // 
            // toolStripMenuItemGoogle
            // 
            this.toolStripMenuItemGoogle.Checked = true;
            this.toolStripMenuItemGoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemGoogle.Name = "toolStripMenuItemGoogle";
            this.toolStripMenuItemGoogle.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemGoogle.Text = "Google";
            this.toolStripMenuItemGoogle.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // toolStripMenuItemYahoo
            // 
            this.toolStripMenuItemYahoo.Name = "toolStripMenuItemYahoo";
            this.toolStripMenuItemYahoo.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemYahoo.Text = "Yahoo";
            this.toolStripMenuItemYahoo.Click += new System.EventHandler(this.yahooToolStripMenuItem_Click);
            // 
            // toolStripMenuItemBig
            // 
            this.toolStripMenuItemBig.Name = "toolStripMenuItemBig";
            this.toolStripMenuItemBig.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItemBig.Text = "Big";
            this.toolStripMenuItemBig.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.exiberBarrasDeFavoritosToolStripMenuItem,
            this.toolStripMenuItem8});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem5.Text = "Favoritos";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem6.Text = "Adicionar está pagina aos Favoritos";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.btFavoritos_Click);
            // 
            // exiberBarrasDeFavoritosToolStripMenuItem
            // 
            this.exiberBarrasDeFavoritosToolStripMenuItem.Checked = true;
            this.exiberBarrasDeFavoritosToolStripMenuItem.CheckOnClick = true;
            this.exiberBarrasDeFavoritosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exiberBarrasDeFavoritosToolStripMenuItem.Name = "exiberBarrasDeFavoritosToolStripMenuItem";
            this.exiberBarrasDeFavoritosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.exiberBarrasDeFavoritosToolStripMenuItem.Text = "Exiber barras de favoritos";
            this.exiberBarrasDeFavoritosToolStripMenuItem.Click += new System.EventHandler(this.exiberBarrasDeFavoritosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(260, 22);
            this.toolStripMenuItem8.Text = "Resetar os Favoritos";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.limparOsFavoritosToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItemSair.Text = "Sair";
            this.toolStripMenuItemSair.Click += new System.EventHandler(this.toolStripMenuItemSair_Click);
            // 
            // btFavoritos
            // 
            this.btFavoritos.BackColor = System.Drawing.Color.Transparent;
            this.btFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("btFavoritos.Image")));
            this.btFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFavoritos.Name = "btFavoritos";
            this.btFavoritos.Size = new System.Drawing.Size(23, 22);
            this.btFavoritos.Text = "toolStripButton7";
            this.btFavoritos.Click += new System.EventHandler(this.btFavoritos_Click);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.ItemHeight = 16;
            this.cbPesquisa.Location = new System.Drawing.Point(110, 5);
            this.cbPesquisa.MaxLength = 30;
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(953, 24);
            this.cbPesquisa.TabIndex = 11;
            this.cbPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPesquisa_KeyPress);
            // 
            // wbPage
            // 
            this.wbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbPage.Location = new System.Drawing.Point(0, 60);
            this.wbPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPage.Name = "wbPage";
            this.wbPage.Size = new System.Drawing.Size(1134, 577);
            this.wbPage.TabIndex = 13;
            this.wbPage.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.wbPage.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            this.wbPage.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 635);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 26);
            this.panel1.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBar1.Location = new System.Drawing.Point(1, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 22);
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wbPage);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.toolStripOpcao);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "FireBoto®";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.toolStripOpcao.ResumeLayout(false);
            this.toolStripOpcao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btArrowLeft;
        private System.Windows.Forms.ToolStripButton btArrowRight;
        private System.Windows.Forms.ToolStripButton btRecarregar;
        private System.Windows.Forms.ToolStripButton btHome;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStripOpcao;
        private System.Windows.Forms.ToolStripButton btFavoritos;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGoogle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemYahoo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exiberBarrasDeFavoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSair;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.WebBrowser wbPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


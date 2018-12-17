namespace XPTO.Forms
{
    partial class XptoForm
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
            this.XptoTabControl = new System.Windows.Forms.TabControl();
            this.ClienteTab = new System.Windows.Forms.TabPage();
            this.ClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.ProdutoTab = new System.Windows.Forms.TabPage();
            this.ProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.ClienteProdutoTab = new System.Windows.Forms.TabPage();
            this.ClienteProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.AtualizarButton = new System.Windows.Forms.Button();
            this.ExtrairDadosArquivosButton = new System.Windows.Forms.Button();
            this.XptoTabControl.SuspendLayout();
            this.ClienteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).BeginInit();
            this.ProdutoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).BeginInit();
            this.ClienteProdutoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // XptoTabControl
            // 
            this.XptoTabControl.Controls.Add(this.ClienteTab);
            this.XptoTabControl.Controls.Add(this.ProdutoTab);
            this.XptoTabControl.Controls.Add(this.ClienteProdutoTab);
            this.XptoTabControl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XptoTabControl.Location = new System.Drawing.Point(12, 12);
            this.XptoTabControl.Name = "XptoTabControl";
            this.XptoTabControl.SelectedIndex = 0;
            this.XptoTabControl.Size = new System.Drawing.Size(931, 291);
            this.XptoTabControl.TabIndex = 0;
            // 
            // ClienteTab
            // 
            this.ClienteTab.Controls.Add(this.ClienteDataGridView);
            this.ClienteTab.Location = new System.Drawing.Point(4, 23);
            this.ClienteTab.Name = "ClienteTab";
            this.ClienteTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClienteTab.Size = new System.Drawing.Size(923, 264);
            this.ClienteTab.TabIndex = 0;
            this.ClienteTab.Text = "Clientes";
            this.ClienteTab.UseVisualStyleBackColor = true;
            // 
            // ClienteDataGridView
            // 
            this.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteDataGridView.Location = new System.Drawing.Point(20, 18);
            this.ClienteDataGridView.Name = "ClienteDataGridView";
            this.ClienteDataGridView.Size = new System.Drawing.Size(873, 221);
            this.ClienteDataGridView.TabIndex = 0;
            // 
            // ProdutoTab
            // 
            this.ProdutoTab.Controls.Add(this.ProdutoDataGridView);
            this.ProdutoTab.Location = new System.Drawing.Point(4, 23);
            this.ProdutoTab.Name = "ProdutoTab";
            this.ProdutoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProdutoTab.Size = new System.Drawing.Size(923, 264);
            this.ProdutoTab.TabIndex = 1;
            this.ProdutoTab.Text = "Produtos";
            this.ProdutoTab.UseVisualStyleBackColor = true;
            // 
            // ProdutoDataGridView
            // 
            this.ProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutoDataGridView.Location = new System.Drawing.Point(24, 27);
            this.ProdutoDataGridView.Name = "ProdutoDataGridView";
            this.ProdutoDataGridView.Size = new System.Drawing.Size(834, 208);
            this.ProdutoDataGridView.TabIndex = 0;
            // 
            // ClienteProdutoTab
            // 
            this.ClienteProdutoTab.Controls.Add(this.ClienteProdutoDataGridView);
            this.ClienteProdutoTab.Location = new System.Drawing.Point(4, 23);
            this.ClienteProdutoTab.Name = "ClienteProdutoTab";
            this.ClienteProdutoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClienteProdutoTab.Size = new System.Drawing.Size(923, 264);
            this.ClienteProdutoTab.TabIndex = 2;
            this.ClienteProdutoTab.Text = "Clientes / Produtos";
            this.ClienteProdutoTab.UseVisualStyleBackColor = true;
            // 
            // ClienteProdutoDataGridView
            // 
            this.ClienteProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteProdutoDataGridView.Location = new System.Drawing.Point(23, 26);
            this.ClienteProdutoDataGridView.Name = "ClienteProdutoDataGridView";
            this.ClienteProdutoDataGridView.Size = new System.Drawing.Size(848, 197);
            this.ClienteProdutoDataGridView.TabIndex = 0;
            // 
            // AtualizarButton
            // 
            this.AtualizarButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarButton.Location = new System.Drawing.Point(812, 310);
            this.AtualizarButton.Name = "AtualizarButton";
            this.AtualizarButton.Size = new System.Drawing.Size(127, 39);
            this.AtualizarButton.TabIndex = 1;
            this.AtualizarButton.Text = "&Atualizar";
            this.AtualizarButton.UseVisualStyleBackColor = true;
            this.AtualizarButton.Click += new System.EventHandler(this.AtualizarButton_Click);
            // 
            // ExtrairDadosArquivosButton
            // 
            this.ExtrairDadosArquivosButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtrairDadosArquivosButton.Location = new System.Drawing.Point(562, 310);
            this.ExtrairDadosArquivosButton.Name = "ExtrairDadosArquivosButton";
            this.ExtrairDadosArquivosButton.Size = new System.Drawing.Size(233, 39);
            this.ExtrairDadosArquivosButton.TabIndex = 2;
            this.ExtrairDadosArquivosButton.Text = "Extrair dados dos arquivos";
            this.ExtrairDadosArquivosButton.UseVisualStyleBackColor = true;
            this.ExtrairDadosArquivosButton.Click += new System.EventHandler(this.ExtrairDadosArquivosButton_Click);
            // 
            // XptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 361);
            this.Controls.Add(this.ExtrairDadosArquivosButton);
            this.Controls.Add(this.AtualizarButton);
            this.Controls.Add(this.XptoTabControl);
            this.Name = "XptoForm";
            this.Text = "XPTO";
            this.XptoTabControl.ResumeLayout(false);
            this.ClienteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDataGridView)).EndInit();
            this.ProdutoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoDataGridView)).EndInit();
            this.ClienteProdutoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl XptoTabControl;
        private System.Windows.Forms.TabPage ClienteTab;
        private System.Windows.Forms.DataGridView ClienteDataGridView;
        private System.Windows.Forms.TabPage ProdutoTab;
        private System.Windows.Forms.TabPage ClienteProdutoTab;
        private System.Windows.Forms.DataGridView ProdutoDataGridView;
        private System.Windows.Forms.DataGridView ClienteProdutoDataGridView;
        private System.Windows.Forms.Button AtualizarButton;
        private System.Windows.Forms.Button ExtrairDadosArquivosButton;
    }
}


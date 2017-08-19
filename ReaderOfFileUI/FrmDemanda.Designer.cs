namespace ReaderOfFileUI
{
    partial class FrmDemanda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnCarga = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsAtualizar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(13, 37);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(51, 13);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho:";
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(192, 60);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 1;
            this.btnCarga.Text = "Carga";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(65, 34);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(202, 20);
            this.txtCaminho.TabIndex = 2;
            this.txtCaminho.Text = "C:\\Users\\Neuclair Junior\\Downloads\\2011-10.TXT";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // rdbSim
            // 
            this.rdbSim.AccessibleDescription = "cmsAtualizar";
            this.rdbSim.AutoSize = true;
            this.rdbSim.Checked = true;
            this.rdbSim.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSim.Location = new System.Drawing.Point(174, 7);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 5;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // rdbNao
            // 
            this.rdbNao.AccessibleDescription = "cmsAtualizar";
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(222, 7);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 6;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Atualizar demandas existentes?";
            // 
            // cmsAtualizar
            // 
            this.cmsAtualizar.Name = "cmsAtualizar";
            this.cmsAtualizar.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.lblCaminho);
            this.Name = "FrmDemanda";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAtualizar;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaderOfFileBLL;
using ReaderOfFileDTO;

namespace ReaderOfFileUI
{
    public partial class FrmDemanda : Form
    {
        public FrmDemanda()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            DemandaBLL dmdBLL = BLLFactory.DemandaBLL;

            progressBar1.Value += 50;

            try
            {
                dmdBLL.salvarDemanda(txtCaminho.Text, rdbSim.Checked ? "sim" : "não");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar1.Value += 50;

            btnCarga.Enabled = false;
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            btnCarga.Enabled = true;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            btnCarga.Enabled = true;
        }
    }
}

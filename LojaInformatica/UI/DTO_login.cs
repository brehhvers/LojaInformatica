using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica
{
    public partial class DTO_login : Form
    {
        public DTO_login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
           /* lblImpostor.Visible = true;

            int loop = 1, cont = 0;
            while ( loop < 50 )
            {
                BackColor = Color.Black;
                pnlUsuario.BackColor = Color.Red;
                pnlSenha.BackColor = Color.Red;
                lblSenha.ForeColor = Color.Black;
                lblUsuario.ForeColor = Color.Black;
                btnCriarConta.BackColor = Color.Red;
                btnCriarConta.ForeColor = Color.Black;
                btnCriarConta.Text = "IMPOSTOR";
                btnEntrar.BackColor = Color.Red;
                btnEntrar.ForeColor = Color.Black;
                btnEntrar.Text = "IMPOSTOR";
            lblImpostor.Visible = true;
                

              /*  while (cont < 500)
                {
                    cont++;
                }

                cont = 0;
                while (loop % 2 == 0)
                {
                    BackColor = Color.Red;
                    pnlUsuario.BackColor = Color.Black;
                    pnlSenha.BackColor = Color.Black;
                    lblSenha.ForeColor = Color.Red;
                    lblUsuario.ForeColor = Color.Red;
                    btnCriarConta.BackColor = Color.Black;
                    btnCriarConta.ForeColor = Color.Black;
              /*  }

                while (cont < 500)
                {
                    cont++;
                }

                loop++;
            }


            */

        }
    }
}

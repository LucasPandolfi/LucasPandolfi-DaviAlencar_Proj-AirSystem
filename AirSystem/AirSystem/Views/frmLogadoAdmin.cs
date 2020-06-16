using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmLogadoAdmin : Form
    {
        public frmLogadoAdmin()
        {
            InitializeComponent();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            frmListarUsuario newMDIChild = new frmListarUsuario();
            // Set the Parent Form of the Child window.
            
            // Display the new form.
            newMDIChild.Show();
        }
    }
}

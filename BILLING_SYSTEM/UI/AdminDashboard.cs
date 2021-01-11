using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BILLING_SYSTEM
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            changeTheAppearanceForMnuStrip();
        }

        public void changeTheAppearanceForMnuStrip()
        {
            menuStripAdmin.BackColor = Color.FromArgb(134, 194, 50);
            menuStripAdmin.ForeColor = Color.White;
            menuStripAdmin.Font = new Font("Calibri", 16);
            menuStripAdmin.Font = new Font(menuStripAdmin.Font, FontStyle.Bold);

        }

        private void labelFooter_Click(object sender, EventArgs e)
        {

        }
    }
}

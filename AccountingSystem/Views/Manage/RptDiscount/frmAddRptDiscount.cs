using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.Views.Manage.RptDiscount
{
    public partial class frmAddRptDiscount : Form
    {
        private readonly frmRptDiscounts _frmRptDiscounts;
        public frmAddRptDiscount(frmRptDiscounts frmRptDiscounts)
        {
            InitializeComponent();
            _frmRptDiscounts = frmRptDiscounts;
            Helper.LoadFormIcon(this);
        }

        private void frmAddRptDiscount_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using xafExample.Module.BusinessObjects;

namespace Solution1.Module.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IObjectSpace ObjectSpace { get; set; }
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> P = ObjectSpace.GetObjects<Product>().ToList();
            gridLookUpEdit1.Properties.DataSource = P;
            gridLookUpEdit1.Refresh();
            Orders = ObjectSpace.FindObject<Orders>(new BinaryOperator("Id", OrderId));
            gridControl1.DataSource = Orders.Orderdetailss;
            gridControl1.Refresh();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = Orders.Orderdetailss.Where(s => s.productId != null && s.productId.Id == (gridLookUpEdit1.EditValue as Product).Id).ToList();
            gridControl1.RefreshDataSource();
        }
    }
}

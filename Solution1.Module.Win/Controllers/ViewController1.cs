using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xafExample.Module.BusinessObjects;

namespace Solution1.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController1 : ViewController
    {
        public ViewController1()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            TargetObjectType = typeof(Orders);
            TargetViewType = ViewType.Any;
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void Дэлгэрэнгүй_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curentOrder = View.CurrentObject as Orders;
            if (curentOrder != null)
            {

                var frm = new Form1();
                frm.ObjectSpace = View.ObjectSpace;
                frm.OrderId = curentOrder.Id;
                frm.ShowDialog();
            }
        }

        private void btnnemeh_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curentOrder = View.CurrentObject as Orders;
            if ( curentOrder != null)
            {
                for(int i=0; i<10; i++)
                {
                    Product product = View.ObjectSpace.FindObject<Product>(new BinaryOperator("Id", 1));
                    Usertypes od = View.ObjectSpace.CreateObject<Usertypes>();
                    od.orderId = curentOrder;
                    
                    od.Une = 1500;
                    od.Too = 13;
                    od.Niit = od.Une * od.Too;
                    od.Save();
                }
                View.ObjectSpace.CommitChanges();
                View.ObjectSpace.Refresh();
            }
        }

        private void btndelete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var curentOrder = View.CurrentObject as Orders;
            if (curentOrder != null)
            {
                View.ObjectSpace.Delete(curentOrder.Orderdetailss);
                View.ObjectSpace.CommitChanges();
                View.ObjectSpace.Refresh();
            }
        }

        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            //Usertypes usertypes = (Usertypes)View.CurrentObject;
            IObjectSpace space = Application.CreateNestedObjectSpace(typeof(Usertypes));

        }
    }
}

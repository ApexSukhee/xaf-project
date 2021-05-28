using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.ExpressApp.DC;
using System.Windows.Forms;


namespace xafExample.Module.BusinessObjects
{
    [XafDisplayName("Захиалгa")]
    public class Orders : XPLiteObject
    {
        public Orders(Session session)
            : base(session)
        {
        }
        [Key(true)]
        public int Id { get; set; }

        public string ordernumber { get; set; }
        public DateTime Deliverydate { get; set; }
        public Users UsirId { get; set; }
        public DateTime Createdate { get; set; }

        [XafDisplayName("Захиалгын дэлгэрэнгүй ")]
        [Association]
        public XPCollection<Usertypes> Orderdetailss
        {
            get { return GetCollection<Usertypes>("Orderdetailss"); }
        }
        protected override void OnSaving()
        {
            base.OnSaving();
        }

        protected override void OnSaved()
        {
            base.OnSaved();
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Createdate = DateTime.Now;
        }

    }

}
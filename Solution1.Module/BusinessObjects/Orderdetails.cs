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
    [XafDisplayName("Захиалгын дэлгэрэнгүй мэдээлэл")]
    public class Usertypes : XPLiteObject
    {
     

        public Usertypes(Session session)
            : base(session)
        {
        }
        [Key(true)]
        public int Id { get; set; }
        [Association]
        [XafDisplayName("Захиалга")]
        public Orders orderId
        {
            get
            {
                return GetPropertyValue<Orders>("orderId");
            }
            set
            {
                SetPropertyValue("orderId", value);
            }
        }

        [XafDisplayName("Бүтээгдэхүүн")]
        public Product productId
        {
            get
            {
                return GetPropertyValue<Product>("productId");
            }
            set
            {
                SetPropertyValue("productId", value);
                if (!IsLoading && !IsSaving && value != null)
                {
                    Une = value.price;
                    OnChanged("Une");
                }

            }
        }
        public DateTime Createdate { get; set; }
        public double Une { get; set; }
        public double Too
        {
            get
            {
                return GetPropertyValue<double>("Too");
            }
            set
            {

                SetPropertyValue("Too", value);
                if (!IsLoading && !IsSaving)
                {
                    Niit = value * Une;
                    OnChanged("Niit");
                }
            }
        }

        public double Niit { get; set; }
        public object Product { get; set; }

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
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
    [XafDisplayName("Бүтээгдэхүүн")]
    public class Producttype : XPLiteObject
    {
        public Producttype(Session session)
            : base(session)
        {
        }
        [Key(true)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime createdate { get; set; }

  

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
            createdate = DateTime.Now;
        }

    }

}
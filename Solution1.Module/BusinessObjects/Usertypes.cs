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
    [XafDisplayName("Хэрэглэгчийн төрөл")]
    public class Usertypes : XPLiteObject
    {
        public Usertypes(Session session)
            : base(session)
        {
        }
        [Key(true)]
        public int Id { get; set; }

        public string Name { get; set; }

        protected override void OnSaving()
        {
            base.OnSaving();
        }

        protected override void OnSaved()
        {
            base.OnSaved();
        }


    }

}
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
    [XafDisplayName("Хэрэглэгч")]
    public class Users : XPLiteObject
    {
        public Users(Session session)
            : base(session)
        {
        }
        [Key(true)]
        public int Id { get; set; }


        public string Name { get; set; }

        public string Code { get; set; }

        public string lastname { get; set; } 

        [XafDisplayName("Үүсгэсэн огноо ")]
        public DateTime createdate { get; set; }

        [XafDisplayName("Хэрэглэгчийн төрөл ")]
        public Usertypes UsertypeId { get; set; }


       
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
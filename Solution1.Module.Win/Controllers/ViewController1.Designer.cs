
namespace Solution1.Module.Win.Controllers
{
    partial class ViewController1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Дэлгэрэнгүй = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.btnnemeh = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.btndelete = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // Дэлгэрэнгүй
            // 
            this.Дэлгэрэнгүй.Caption = null;
            this.Дэлгэрэнгүй.ConfirmationMessage = null;
            this.Дэлгэрэнгүй.Id = "88eb5654-53d9-4956-b7e0-29d7e88bb22a";
            this.Дэлгэрэнгүй.ToolTip = null;
            this.Дэлгэрэнгүй.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.Дэлгэрэнгүй_Execute);
            // 
            // btnnemeh
            // 
            this.btnnemeh.Caption = null;
            this.btnnemeh.ConfirmationMessage = null;
            this.btnnemeh.Id = "2c4bc025-681c-4d7e-bb55-c3a26e41c1da";
            this.btnnemeh.ToolTip = null;
            this.btnnemeh.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.btnnemeh_Execute);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Устгах";
            this.btndelete.ConfirmationMessage = null;
            this.btndelete.Id = "c18dd28e-ebf6-4f0d-b628-d834d1d1647e";
            this.btndelete.ToolTip = null;
            this.btndelete.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.btndelete_Execute);
            // 
            // popupWindowShowAction1
            // 
            this.popupWindowShowAction1.AcceptButtonCaption = null;
            this.popupWindowShowAction1.CancelButtonCaption = null;
            this.popupWindowShowAction1.Caption = "Create Usertype";
            this.popupWindowShowAction1.ConfirmationMessage = null;
            this.popupWindowShowAction1.Id = "90b21f3b-1c6c-4332-a28f-ad8d37a53c45";
            this.popupWindowShowAction1.ToolTip = null;
            this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
            // 
            // ViewController1
            // 
            this.Actions.Add(this.Дэлгэрэнгүй);
            this.Actions.Add(this.btnnemeh);
            this.Actions.Add(this.btndelete);
            this.Actions.Add(this.popupWindowShowAction1);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction Дэлгэрэнгүй;
        private DevExpress.ExpressApp.Actions.SimpleAction btnnemeh;
        private DevExpress.ExpressApp.Actions.SimpleAction btndelete;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction1;
    }
}

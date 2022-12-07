// Developer Express Code Central Example:
// How to iterate through all ASPxFormLayout items
// 
// This example demonstrates how to iterate through all ASPxFormLayout items using
// the LayoutGroupBase.ForEach method
// (http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxFormLayoutLayoutGroupBasetopic).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4574

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {  }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        foreach(var item in layout.Items) {
            if(item is LayoutGroupBase)
                (item as LayoutGroupBase).ForEach(GetNestedControls);
        }
    }
    void GetNestedControls(LayoutItemBase item) {       
            if(item is LayoutItem)
                SetValue(item as LayoutItem);
       
    }
    static void SetValue(LayoutItem c) {
        foreach(Control control in c.Controls) {
            ASPxEdit editor = control as ASPxEdit;
            if (editor != null)
            {
                editor.Value = DateTime.Now.ToString();                
            }
        }
    }
}
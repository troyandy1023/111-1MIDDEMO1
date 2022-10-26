using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lit_Msg.Text = Request.Form.Get("tb_Num");
            lit_Msg1.Text = Request.Form.Get("rbl_Phone");
            lit_Msg2.Text = Request.Form.Get("txt_Phone");
            lit_Msg3.Text = Request.Form.Get("dpl_City");
            lit_Msg4.Text = Request.Form.Get("dpl_Area");
        }
    }
}
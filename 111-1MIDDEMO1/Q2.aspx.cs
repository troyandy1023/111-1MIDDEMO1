using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[2] { "台北市", "新北市" };
        string[,] s_Area = new string[2, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int ct = 0; ct < s_City.Length; ct++)
                {
                    ListItem ol = new ListItem();
                    ol.Text = s_City[ct];
                    ol.Value = s_City[ct];
                    dpl_City.Items.Add(ol);
                }
                mt_GenSecondList();
            }
        }
        protected void mt_GenSecondList()
        {
            int ind = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for (int ct = 0; ct < s_Area.GetLength(1); ct++)
            {
                ListItem ol = new ListItem();
                ol.Text = ol.Value = s_Area[ind, ct];
                dpl_Area.Items.Add(ol);
            }
        }


        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
    }
}
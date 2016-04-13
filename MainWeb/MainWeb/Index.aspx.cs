using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace MainWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIndent_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Trim() == string.Empty) return;

            string inputXml = inputBox.Text;
            outputBox.Text = System.Xml.Linq.XElement.Parse(inputXml).ToString();
        }
    }
}
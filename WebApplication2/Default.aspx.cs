using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using WebApplication1;

public partial class Default_aspx  : BaseWebPage {

    public void Randomize(object sender, EventArgs e) {
        Random r = new Random();
        FormView1.PageIndex = r.Next(FormView1.PageCount);
	}

    public void DoStuff()
    {

        Data.GetStuff<DataTable>(1);

    }

}
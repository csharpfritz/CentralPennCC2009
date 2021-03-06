<%@ Application Language="C#" %>

<script runat="server">

	void Application_Start(object sender, EventArgs e) {
		SiteMap.SiteMapResolve += new SiteMapResolveEventHandler(AppendQueryString);
		if (!Roles.RoleExists("Administrators")) Roles.CreateRole("Administrators");
		if (!Roles.RoleExists("Friends")) Roles.CreateRole("Friends");

        AddRoutes();
    
    }

	SiteMapNode AppendQueryString(object o, SiteMapResolveEventArgs e) {
		if (SiteMap.CurrentNode != null) {
			SiteMapNode temp;
			temp = SiteMap.CurrentNode.Clone(true);
			Uri u = new Uri(e.Context.Request.Url.ToString());
			temp.Url += u.Query;
			if (temp.ParentNode != null) {
				temp.ParentNode.Url += u.Query;
			}
			return temp;
		} else {
			return null;
		}
	}

    public void AddRoutes()
    {
        System.Web.Routing.RouteTable.Routes.MapRoute("Default",
                                   "home/{action}/{id}",
                                   new { controller = "Home", action = "Index", id = "" });
    }
    
    	
</script>

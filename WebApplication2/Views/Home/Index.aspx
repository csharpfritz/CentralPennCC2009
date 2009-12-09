<%@ Page Language="C#" MasterPageFile="~/Default.master" Inherits="System.Web.Mvc.ViewPage<ViewModel<Person>>" %>
<%@ Import Namespace="WebApplication1.Controllers"%>

<asp:Content ID="mainContent" runat=server ContentPlaceHolderID=Main>

<link rel="Stylesheet" type="text/css" href="<%= Model.css %>" />

Here is my new Home/Index page!

<br />
<br />

Hello <%= Html.Encode(Model.model.FirstName) %>
 <%= Html.Encode(Model.model.LastName) %>
Yay!

<%
   // Html.RenderPartial("CommonHomePage");%>


</asp:Content>

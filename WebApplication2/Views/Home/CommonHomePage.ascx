<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<input type="text" name="newValue" value="<%= ViewData.ContainsKey("newValue") ? ViewData["newValue"].ToString() : "" %>" />
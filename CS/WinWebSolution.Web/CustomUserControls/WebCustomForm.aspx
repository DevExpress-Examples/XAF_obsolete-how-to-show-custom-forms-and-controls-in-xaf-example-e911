<%-- BeginRegion TagPrefix and page properties --%>
<%@ Page Language="C#" AutoEventWireup="True" Inherits="WebCustomForm" Codebehind="WebCustomForm.aspx.cs" %>
<%@ Register Src="WebCustomUserControl.ascx" TagName="WebCustomUserControl" TagPrefix="uc1" %>
<%-- EndRegion --%>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>WebCustomForm</title>
</head>
<body>
<form id="form2" runat="server">
    <uc1:WebCustomUserControl id="WebCustomUserControl1" runat="server">
    </uc1:WebCustomUserControl>
</form>
</body>
</html>
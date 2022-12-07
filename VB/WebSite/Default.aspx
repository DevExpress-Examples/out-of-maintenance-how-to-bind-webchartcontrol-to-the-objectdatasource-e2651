<%@ Page ValidateRequest="False" Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb"
	Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">

	<div>
		<p>
			GroupId:
			<asp:DropDownList ID="ddlGroupId" runat="server" AutoPostBack="True" Width="100px">
				<asp:ListItem Value="[All]"></asp:ListItem>
				<asp:ListItem Value="A"></asp:ListItem>
				<asp:ListItem Value="B"></asp:ListItem>
				<asp:ListItem Value="C"></asp:ListItem>
			</asp:DropDownList>
		</p>
		<dxchartsui:WebChartControl ID="WebChartControl1" runat="server" Height="260px" Width="700px"
			DataSourceID="ObjectDataSource1" SeriesDataMember="GroupName">
			<SeriesTemplate  
				ArgumentDataMember="Description"
				ValueDataMembersSerializable="Price" />
		</dxchartsui:WebChartControl>
	</div>

	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetInvoices"
		TypeName="Invoice">
		<SelectParameters>
			<asp:ControlParameter Name="groupId" ControlID="ddlGroupId" DefaultValue="[All]"
				PropertyName="SelectedValue" Type="String" />
		</SelectParameters>
	</asp:ObjectDataSource>

	</form>
</body>
</html>
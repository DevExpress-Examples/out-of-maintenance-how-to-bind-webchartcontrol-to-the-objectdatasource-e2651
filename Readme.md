<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572776/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2651)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Invoice.cs](./CS/WebSite/App_Code/Invoice.cs) (VB: [Invoice.vb](./VB/WebSite/App_Code/Invoice.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to bind WebChartControl to the ObjectDataSource
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2651/)**
<!-- run online end -->


<p>This example illustrates how to bind a WebChartControl to the special ASP.NET datasource component - <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.objectdatasource.aspx"><u>ObjectDataSource</u></a>. To do this, you should simply assign the ObjectDataSource name to the WebChartControl.DataSourceID property. Data for the chart is returned by the method specified via the ObjectDataSource.SelectMethod property. Note that you can use its SelectParameters collection to pass any parameter to the data retrieval method. This way, you can implement data filtering without any lines of code. Please refer to the Default.aspx markup, for implementation details.</p>

<br/>



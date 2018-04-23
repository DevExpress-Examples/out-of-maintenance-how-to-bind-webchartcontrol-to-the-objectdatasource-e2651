# How to bind WebChartControl to the ObjectDataSource


<p>This example illustrates how to bind a WebChartControl to the special ASP.NET datasource component - <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.objectdatasource.aspx"><u>ObjectDataSource</u></a>. To do this, you should simply assign the ObjectDataSource name to the WebChartControl.DataSourceID property. Data for the chart is returned by the method specified via the ObjectDataSource.SelectMethod property. Note that you can use its SelectParameters collection to pass any parameter to the data retrieval method. This way, you can implement data filtering without any lines of code. Please refer to the Default.aspx markup, for implementation details.</p>

<br/>



<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620442/14.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T130182)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ChartClientCustomizeSeries/Form1.cs) (VB: [Form1.vb](./VB/ChartClientCustomizeSeries/Form1.vb))
<!-- default file list end -->
# How to customize series of a chart range control client at runtime


This example shows how to adjust series of a numeric chart range control client using the <strong>ChartRangeControlClientBase.CustomizeSeries </strong>event. This event occurs before a series of the chart range control client is drawn in the range control's viewport. <br /><br />Use the <strong>ClientDataSourceProviderCustomizeSeriesEventArgs.View</strong> property to change the series view of the chart range control client. In addition, you can access the data source value using the <strong>ClientDataSourceProviderCustomizeSeriesEventArgs.DataSourceValue</strong> property. <br /><br />

<br/>



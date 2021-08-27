<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648766/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4338)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/DxSample/DataHelper.cs) (VB: [DataHelper.vb](./VB/DxSample/DataHelper.vb))
* [FilterAlignmentConverter.cs](./CS/DxSample/FilterAlignmentConverter.cs) (VB: [FilterAlignmentConverter.vb](./VB/DxSample/FilterAlignmentConverter.vb))
* [FilterAlingment.cs](./CS/DxSample/FilterAlingment.cs) (VB: [FilterAlingment.vb](./VB/DxSample/FilterAlingment.vb))
* [MainWindow.xaml](./CS/DxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DxSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DxSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to change Filter Button alignment within a column header


<p>This example demonstrates how to change Filter Button alignment within a column header. For this, it's necessary to re-define the x:Key="{dxgt:GridColumnHeaderThemeKey ResourceKey=ControlTemplate}" control template, create the FilterAlignment attached property and attach it to the column. If you are using themes, you need to re-define a control template for your theme and add it's name to the key - x:Key="{dxgt:GridColumnHeaderThemeKey ResourceKey=ControlTemplate, ThemeName=DXStyle}"<br /><br /></p>
<p>Update:<br />Starting with version 14.1, the filter icon is arranged by the ColumnHeaderDockPanel element. To change the filter icon position, create a ColumnHeaderDockPanel descendant and override its ArrangeOverride method.</p>

<br/>



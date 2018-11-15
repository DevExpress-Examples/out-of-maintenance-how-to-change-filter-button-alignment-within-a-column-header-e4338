<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/DxSample/DataHelper.cs) (VB: [DataHelper.vb](./VB/DxSample/DataHelper.vb))
* [FilterAlignmentConverter.cs](./CS/DxSample/FilterAlignmentConverter.cs) (VB: [FilterAlignmentConverter.vb](./VB/DxSample/FilterAlignmentConverter.vb))
* [FilterAlingment.cs](./CS/DxSample/FilterAlingment.cs) (VB: [FilterAlingment.vb](./VB/DxSample/FilterAlingment.vb))
* [MainWindow.xaml](./CS/DxSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DxSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/DxSample/MainWindow.xaml))
<!-- default file list end -->
# How to change Filter Button alignment within a column header


<p>This example demonstrates how to change Filter Button alignment within a column header. For this, it's necessary to re-define the x:Key="{dxgt:GridColumnHeaderThemeKey ResourceKey=ControlTemplate}" control template, create the FilterAlignment attached property and attach it to the column. If you are using themes, you need to re-define a control template for your theme and add it's name to the key - x:Key="{dxgt:GridColumnHeaderThemeKey ResourceKey=ControlTemplate, ThemeName=DXStyle}"<br /><br /></p>
<p>Update:<br />Starting with version 14.1, the filter icon is arranged by the ColumnHeaderDockPanel element. To change the filter icon position, create a ColumnHeaderDockPanel descendant and override its ArrangeOverride method.</p>

<br/>



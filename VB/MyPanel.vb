Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication6
	Public Class MyColumnHeaderDockPanel
		Inherits ColumnHeaderDockPanel

		Private Function IsDocked(ByVal element As UIElement) As Boolean
			Return element Is HeaderPresenter OrElse element Is HeaderCustomizationArea OrElse element Is FilterPresenter OrElse element Is SortIndicator
		End Function

		Protected Overrides Function ArrangeOverride(ByVal finalSize As Size) As Size
			Dim left As Double = ContentMargin.Left
			Dim right As Double = ContentMargin.Right
'INSTANT VB NOTE: The variable height was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim height_Renamed As Double = Math.Max(0, finalSize.Height - (ContentMargin.Top + ContentMargin.Bottom))
			For Each child As UIElement In Children
				If Not IsDocked(child) Then
					child.Arrange(New Rect(0, 0, finalSize.Width, finalSize.Height))
				End If
			Next child
			If SortIndicator IsNot Nothing Then
				right = ArrangeRight(SortIndicator, right + 10, finalSize.Width, height_Renamed)
			End If
			If HeaderCustomizationArea IsNot Nothing Then
				right = ArrangeRight(HeaderCustomizationArea, right, finalSize.Width, height_Renamed)
			End If
			Select Case ContainerAlignment
				Case System.Windows.HorizontalAlignment.Left
					If HeaderPresenter IsNot Nothing Then
						left = ArrangeLeft(HeaderPresenter, left, height_Renamed)
					End If
					If FilterPresenter IsNot Nothing Then
						left = ArrangeLeft(FilterPresenter, finalSize.Width - FilterPresenter.DesiredSize.Width, height_Renamed)
					End If
				Case System.Windows.HorizontalAlignment.Right
					If FilterPresenter IsNot Nothing Then
						right = ArrangeRight(FilterPresenter, right, finalSize.Width, height_Renamed)
					End If
					If HeaderPresenter IsNot Nothing Then
						right = ArrangeRight(HeaderPresenter, right, finalSize.Width, height_Renamed)
					End If
				Case System.Windows.HorizontalAlignment.Stretch
					If FilterPresenter IsNot Nothing Then
						right = ArrangeRight(FilterPresenter, right, finalSize.Width, height_Renamed)
					End If
					If HeaderPresenter IsNot Nothing Then
						left = ArrangeStretch(HeaderPresenter, left, right, finalSize.Width, height_Renamed)
					End If
				Case System.Windows.HorizontalAlignment.Center
					If HeaderPresenter IsNot Nothing Then
						Dim total As Double = (HeaderPresenter.DesiredSize.Width + (If(FilterPresenter IsNot Nothing, FilterPresenter.DesiredSize.Width, 0R)))
						Dim indent As Double = Math.Max(0, left + (finalSize.Width - left - right - total) / 2)
						left = ArrangeCenter(HeaderPresenter, height_Renamed, indent)
					End If
					If FilterPresenter IsNot Nothing Then
						left = ArrangeLeft(FilterPresenter, left, height_Renamed)
					End If
			End Select
			Return finalSize
		End Function
		'double ArrangeLeft(UIElement element, double left, double height)
		'{
		'    if (element.GetType() == typeof(TextBlock))
		'    {
		'        element.Arrange(new Rect(18, ContentMargin.Top, element.DesiredSize.Width, height));
		'    }
		'    else if (element.GetType() == typeof(ComboBoxEdit))
		'    {
		'        element.Arrange(new Rect(2, ContentMargin.Top, element.DesiredSize.Width, height));
		'    }
		'    else element.Arrange(new Rect(left, ContentMargin.Top, element.DesiredSize.Width, height));
		'    return left + element.DesiredSize.Width;
		'}
		Private Function ArrangeLeft(ByVal element As UIElement, ByVal left As Double, ByVal height As Double) As Double
			element.Arrange(New Rect(left, ContentMargin.Top, element.DesiredSize.Width, height))
			Return left + element.DesiredSize.Width
		End Function

		Private Function ArrangeRight(ByVal element As UIElement, ByVal right As Double, ByVal width As Double, ByVal height As Double) As Double
			element.Arrange(New Rect(Math.Max(0, width - right - element.DesiredSize.Width), ContentMargin.Top, element.DesiredSize.Width, height))
			Return right + element.DesiredSize.Width
		End Function
		Private Function ArrangeStretch(ByVal element As UIElement, ByVal left As Double, ByVal right As Double, ByVal width As Double, ByVal height As Double) As Double
			element.Arrange(New Rect(left, ContentMargin.Top, Math.Max(0, width - (left + right)), height))
			Return width - right
		End Function
		Private Function ArrangeCenter(ByVal element As UIElement, ByVal height As Double, ByVal indent As Double) As Double
			element.Arrange(New Rect(indent, ContentMargin.Top, element.DesiredSize.Width, height))
			Return indent + element.DesiredSize.Width
		End Function
	End Class
End Namespace

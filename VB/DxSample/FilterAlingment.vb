Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows

Namespace DxSample
	Friend Class FilterAlingment
		Public Shared ReadOnly FilterAlingmentProperty As DependencyProperty = DependencyProperty.RegisterAttached("FilterAlingment", GetType(HorizontalAlignment), GetType(FilterAlingment), New UIPropertyMetadata(Nothing))

		Public Shared Function GetFilterAlingment(ByVal target As DependencyObject) As HorizontalAlignment
			Return CType(target.GetValue(FilterAlingmentProperty), HorizontalAlignment)
		End Function

		Public Shared Sub SetFilterAlingment(ByVal target As DependencyObject, ByVal value As HorizontalAlignment)
			target.SetValue(FilterAlingmentProperty, value)
		End Sub
	End Class
End Namespace

Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Input

Namespace WpfApplication6
	Public Class ViewModel

		Private _List As ObservableCollection(Of Task)

		Public ReadOnly Property List() As ObservableCollection(Of Task)
			Get
				_List = New ObservableCollection(Of Task)()
				For i As Integer = 0 To 19
					_List.Add(New Task() With {.Name = "Task " & i, .FirstValue = i, .SecondValue = i * i, .IsCompleted = i Mod 2 <> 0})
				Next i
				Return _List
			End Get
		End Property

		Public Class Task
			Public Property Name() As String
			Public Property FirstValue() As Integer
			Public Property SecondValue() As Integer
			Public Property IsCompleted() As Boolean
		End Class
	End Class
End Namespace

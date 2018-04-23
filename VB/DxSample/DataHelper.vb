Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections.ObjectModel

Namespace DxSample
	Public NotInheritable Class DataHelper
		Private Sub New()
		End Sub
		Public Shared Function GetData() As ObservableCollection(Of Customer)
			Dim customers As New ObservableCollection(Of Customer) (New Customer() {New Customer("Maria", " Anders", "Berlin", "Germany"), New Customer("Antonio","Moreno","México D.F.","Mexico")})
			Return customers
		End Function

	End Class

	Public Class Customer
        Public Sub New(ByVal _firstName As String, ByVal _lastName As String, ByVal _city As String, ByVal _country As String)
            FirstName = _firstName
            LastName = _lastName
            City = _city
            Country = _country
        End Sub
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateLastName As String
		Public Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
		Private privateCity As String
		Public Property City() As String
			Get
				Return privateCity
			End Get
			Set(ByVal value As String)
				privateCity = value
			End Set
		End Property
		Private privateCountry As String
		Public Property Country() As String
			Get
				Return privateCountry
			End Get
			Set(ByVal value As String)
				privateCountry = value
			End Set
		End Property

	End Class
End Namespace

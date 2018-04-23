Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Public Class Invoice
	Private groupName_Renamed As String

	Public Property GroupName() As String
		Get
			Return groupName_Renamed
		End Get
		Set(ByVal value As String)
			groupName_Renamed = value
		End Set
	End Property
	Private description_Renamed As String

	Public Property Description() As String
		Get
			Return description_Renamed
		End Get
		Set(ByVal value As String)
			description_Renamed = value
		End Set
	End Property
	Private price_Renamed As Decimal

	Public Property Price() As Decimal
		Get
			Return price_Renamed
		End Get
		Set(ByVal value As Decimal)
			price_Renamed = value
		End Set
	End Property

	Public Sub New(ByVal groupName As String, ByVal description As String, ByVal price As Decimal)
		Me.GroupName = groupName
		Me.Description = description
		Me.Price = price
	End Sub

	Public Shared Function GetInvoices(ByVal groupId As String) As List(Of Invoice)
		Dim invoices As New List(Of Invoice)(10)
		Dim rnd As New Random()

		If groupId <> "[All]" Then
			For i As Integer = 0 To 2
				invoices.Add(New Invoice(groupId, "Invoice" & (i + 1).ToString(), rnd.Next(10, 30)))
			Next i
		Else
			Dim groupIds() As String = { "A", "B", "C" }

			For i As Integer = 0 To 8
				invoices.Add(New Invoice(groupIds(i \ 3), "Invoice" & ((i + 1) Mod 3).ToString(), rnd.Next(10, 30)))
			Next i
		End If

		Return invoices
	End Function

End Class

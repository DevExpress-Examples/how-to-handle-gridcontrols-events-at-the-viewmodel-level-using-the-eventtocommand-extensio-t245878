Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Collections.ObjectModel
Imports EventToCommandExample.Models
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.Mvvm

Namespace EventToCommandExample.ViewModels
	Public Class MainViewModel
		Inherits ViewModelBase
		Private _StatusInfo As String
		Public Property StatusInfo() As String
			Get
				Return _StatusInfo
			End Get
			Set(ByVal value As String)
				If _StatusInfo = value Then
					Return
				End If
				_StatusInfo = value
				RaisePropertyChanged("StatusInfo")
			End Set
		End Property

		Private privateGridData As ObservableCollection(Of SampleData)
		Public Property GridData() As ObservableCollection(Of SampleData)
			Get
				Return privateGridData
			End Get
			Private Set(ByVal value As ObservableCollection(Of SampleData))
				privateGridData = value
			End Set
		End Property

		Private privateIsEditingAllowedCommand As DelegateCommand(Of ShowingEditorEventArgs)
		Public Property IsEditingAllowedCommand() As DelegateCommand(Of ShowingEditorEventArgs)
			Get
				Return privateIsEditingAllowedCommand
			End Get
			Private Set(ByVal value As DelegateCommand(Of ShowingEditorEventArgs))
				privateIsEditingAllowedCommand = value
			End Set
		End Property
		Private privateShowRowDetailsCommand As DelegateCommand(Of SampleData)
		Public Property ShowRowDetailsCommand() As DelegateCommand(Of SampleData)
			Get
				Return privateShowRowDetailsCommand
			End Get
			Private Set(ByVal value As DelegateCommand(Of SampleData))
				privateShowRowDetailsCommand = value
			End Set
		End Property
		Private privateUpdateStatusInfoCommand As DelegateCommand(Of String)
		Public Property UpdateStatusInfoCommand() As DelegateCommand(Of String)
			Get
				Return privateUpdateStatusInfoCommand
			End Get
			Private Set(ByVal value As DelegateCommand(Of String))
				privateUpdateStatusInfoCommand = value
			End Set
		End Property

		Public Sub New()

			GridData = New ObservableCollection(Of SampleData)()
			Dim rnd As New Random()
			For i As Integer = 0 To 9
				GridData.Add(New SampleData() With {.ID = i, .Text = "Row#" & i.ToString(), .Value = rnd.Next(100)})

			Next i
			IsEditingAllowedCommand = New DelegateCommand(Of ShowingEditorEventArgs)(AddressOf OnIsEditingAllowed)

			ShowRowDetailsCommand = New DelegateCommand(Of SampleData)(AddressOf OnShowRowDetails)

			UpdateStatusInfoCommand = New DelegateCommand(Of String)(AddressOf OnUpdateStatusInfo)
		End Sub

		Private Sub OnIsEditingAllowed(ByVal args As ShowingEditorEventArgs)
			args.Cancel = (CType(args.Row, SampleData)).Value Mod 2 = 0
		End Sub

		Private Sub OnShowRowDetails(ByVal row As SampleData)
			If row IsNot Nothing Then
				MessageBox.Show(row.Text)
			End If
		End Sub

		Private Sub OnUpdateStatusInfo(ByVal fieldName As String)
			StatusInfo = "Focused column = " & fieldName
		End Sub
	End Class
End Namespace

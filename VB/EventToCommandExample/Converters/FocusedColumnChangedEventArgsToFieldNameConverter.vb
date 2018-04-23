Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Mvvm.UI

Namespace EventToCommandExample.Converters
	Public Class FocusedColumnChangedEventArgsToFieldNameConverter
		Inherits EventArgsConverterBase(Of EventArgs)
		Protected Overrides Function Convert(ByVal e As EventArgs) As Object
			Dim args As CurrentColumnChangedEventArgs = CType(e, CurrentColumnChangedEventArgs)
			If args Is Nothing OrElse args.NewColumn Is Nothing Then
				Return String.Empty
			End If
			Return args.NewColumn.FieldName
		End Function
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Input
Imports EventToCommandExample.Models
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Utils
Imports System.Windows
Imports DevExpress.Xpf.Mvvm.UI

Namespace EventToCommandExample.Converters
	Public Class MouseButtonEventArgsToGridRowConverter
		Inherits EventArgsConverterBase(Of EventArgs)
		Protected Overrides Function Convert(ByVal e As EventArgs) As Object
			Dim args As MouseButtonEventArgs = CType(e, MouseButtonEventArgs)
			Dim view As TableView = LayoutHelper.FindParentObject(Of TableView)(TryCast(args.OriginalSource, DependencyObject))
			Dim rowHandle As Integer = view.GetRowHandleByMouseEventArgs(args)
			Return TryCast(view.Grid.GetRow(rowHandle), SampleData)
		End Function
	End Class
End Namespace

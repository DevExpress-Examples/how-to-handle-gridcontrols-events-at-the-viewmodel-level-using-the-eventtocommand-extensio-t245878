Imports Microsoft.VisualBasic
Imports EventToCommandExample.ViewModels
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace EventToCommandExample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Me.DataContext = New MainViewModel()
		End Sub
	End Class
End Namespace

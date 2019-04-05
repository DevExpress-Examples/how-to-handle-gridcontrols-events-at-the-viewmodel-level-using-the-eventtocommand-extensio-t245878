<!-- default file list -->
*Files to look at*:

* [EventToCommandExampleTestPage.aspx](./CS/EventToCommandExample.Web/EventToCommandExampleTestPage.aspx) (VB: [EventToCommandExampleTestPage.aspx](./VB/EventToCommandExample.Web/EventToCommandExampleTestPage.aspx))
* [FocusedColumnChangedEventArgsToFieldNameConverter.cs](./CS/EventToCommandExample/Converters/FocusedColumnChangedEventArgsToFieldNameConverter.cs) (VB: [FocusedColumnChangedEventArgsToFieldNameConverter.vb](./VB/EventToCommandExample/Converters/FocusedColumnChangedEventArgsToFieldNameConverter.vb))
* [MouseButtonEventArgsToGridRowConverter.cs](./CS/EventToCommandExample/Converters/MouseButtonEventArgsToGridRowConverter.cs) (VB: [MouseButtonEventArgsToGridRowConverter.vb](./VB/EventToCommandExample/Converters/MouseButtonEventArgsToGridRowConverter.vb))
* [MainPage.xaml](./CS/EventToCommandExample/MainPage.xaml) (VB: [MainPage.xaml](./VB/EventToCommandExample/MainPage.xaml))
* [MainPage.xaml.cs](./CS/EventToCommandExample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/EventToCommandExample/MainPage.xaml.vb))
* [SampleData.cs](./CS/EventToCommandExample/Modules/SampleData.cs) (VB: [SampleData.vb](./VB/EventToCommandExample/Modules/SampleData.vb))
* [MainViewModel.cs](./CS/EventToCommandExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/EventToCommandExample/ViewModels/MainViewModel.vb))
<!-- default file list end -->
# How to handle GridControl's events at the ViewModel level using the EventToCommand extension from MVVM Framework


MVVM Framework provides a powerful EventToCommand feature that allows delegating event processing logic to the ViewModel level. This example illustrates how to use this functionality to process DXGrid events.<br /><br />The EventToCommand class provides the PassEventArgsToCommand option that allows passing the corresponding EventArgs as a command parameter. However, it is not good MVVM practice (even though it might be necessary in certain cases) to make a ViewModel aware of event arguments. It is better to extract necessary information from event arguments and then pass this information as a command parameter. To do this, use EventArgsConverter.<br /><br />So, this example demonstrates the following cases:<br /><br />1) How to invoke a command from a ViewModel when an event is raised. In this example, the built-in BestFitColumns command is invoked when the View's Loaded event is triggered.<br /><br />2) How to invoke a command from a ViewModel when an event is raised and pass event arguments as a command parameter. This approach is used to delegate processing the ShowingEditor event to the ViewModel level.<br /><br />3) How to invoke a command from a ViewModel when an event is raised, extract necessary information from event arguments using a Converter and then pass it as a parameter. The View's MouseDoubleClick and FocusedColumnChanged events are processed in this manner.<br /><br />Note this approach can be used for other controls as well. This example also illustrates how to process a BarItem's ItemDoubleClick event in this manner.<br /><br /><em>To implement similar functionality in WPF, see <a href="https://www.devexpress.com/Support/Center/p/E3263">E3263</a>.</em>

<br/>



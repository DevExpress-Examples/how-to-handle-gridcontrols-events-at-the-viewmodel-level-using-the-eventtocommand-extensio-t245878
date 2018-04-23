using System;
using System.Linq;
using System.Windows.Input;
using EventToCommandExample.Models;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.Native;
using DevExpress.Utils;
using System.Windows;
using DevExpress.Xpf.Mvvm.UI;

namespace EventToCommandExample.Converters {
    public class MouseButtonEventArgsToGridRowConverter : EventArgsConverterBase<EventArgs> {
        protected override object Convert(EventArgs e) {
            MouseButtonEventArgs args = (MouseButtonEventArgs)e;
            TableView view = LayoutHelper.FindParentObject<TableView>(args.OriginalSource as DependencyObject);
            int rowHandle = view.GetRowHandleByMouseEventArgs(args);
            return view.Grid.GetRow(rowHandle) as SampleData;
        }
    }
}

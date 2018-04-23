using System;
using System.Linq;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Mvvm.UI;

namespace EventToCommandExample.Converters {
    public class FocusedColumnChangedEventArgsToFieldNameConverter : EventArgsConverterBase<EventArgs> {
        protected override object Convert(EventArgs e) {
            CurrentColumnChangedEventArgs args = (CurrentColumnChangedEventArgs)e;
            if(args == null || args.NewColumn == null) {
                return String.Empty;
            }
            return args.NewColumn.FieldName;
        }
    }
}

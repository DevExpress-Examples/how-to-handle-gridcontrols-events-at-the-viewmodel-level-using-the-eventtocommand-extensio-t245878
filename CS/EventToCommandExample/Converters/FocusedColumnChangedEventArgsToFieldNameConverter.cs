using System;
using System.Linq;
using DevExpress.Xpf.Grid;
using DevExpress.Mvvm.UI;

namespace EventToCommandExample.Converters {
    public class FocusedColumnChangedEventArgsToFieldNameConverter : EventArgsConverterBase<EventArgs> {
        protected override object Convert(object sender, EventArgs e) {
            CurrentColumnChangedEventArgs args = (CurrentColumnChangedEventArgs)e;
            if(args == null || args.NewColumn == null) {
                return String.Empty;
            }
            return args.NewColumn.FieldName;
        }
    }
}

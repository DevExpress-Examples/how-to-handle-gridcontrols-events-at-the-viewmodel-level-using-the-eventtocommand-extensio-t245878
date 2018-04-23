using System;
using System.Linq;
using System.Collections.ObjectModel;
using EventToCommandExample.Models;
using DevExpress.Xpf.Grid;
using System.Windows;
using DevExpress.Xpf.Mvvm;

namespace EventToCommandExample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _StatusInfo;
        public string StatusInfo
        {
            get
            {
                return _StatusInfo;
            }
            set
            {
                if (_StatusInfo == value)
                {
                    return;
                }
                _StatusInfo = value;
                RaisePropertyChanged("StatusInfo");
            }
        }

        public ObservableCollection<SampleData> GridData { get; private set; }

        public DelegateCommand<ShowingEditorEventArgs> IsEditingAllowedCommand { get; private set; }
        public DelegateCommand<SampleData> ShowRowDetailsCommand { get; private set; }
        public DelegateCommand<string> UpdateStatusInfoCommand { get; private set; }

        public MainViewModel()
        {

            GridData = new ObservableCollection<SampleData>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                GridData.Add(new SampleData()
                { ID = i,
                    Text = "Row#" + i.ToString(),
                    Value = rnd.Next(100) });

            }
            IsEditingAllowedCommand = new DelegateCommand<ShowingEditorEventArgs>(OnIsEditingAllowed);

            ShowRowDetailsCommand = new DelegateCommand<SampleData>(OnShowRowDetails);

            UpdateStatusInfoCommand = new DelegateCommand<string>(OnUpdateStatusInfo);
        }

        private void OnIsEditingAllowed(ShowingEditorEventArgs args)
        {
            args.Cancel = ((SampleData)args.Row).Value % 2 == 0;
        }

        private void OnShowRowDetails(SampleData row)
        {
            if (row != null)
            {
                MessageBox.Show(row.Text);
            }
        }

        private void OnUpdateStatusInfo(string fieldName)
        {
            StatusInfo = "Focused column = " + fieldName;
        }
    }
}

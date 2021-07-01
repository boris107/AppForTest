using LibraryTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public const string path = "Text.txt";
        private int w = 3;
        public int W
        {
            get { return w; }
            set
            {
                if (value % 2 > 0)
                    w = value;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Data> dataList;
        public List<Data> DataList
        {
            get
            {
                return dataList;
            }
            set
            {
                dataList = value;
                OnPropertyChanged(nameof(DataList));
            }
        }

        private Model.ProcessingData processingData = new Model.ProcessingData();
        private Model.ProcessingData ProcessingData
        {
            get
            {
                return processingData;
            }
            set
            {
                processingData = value;
                OnPropertyChanged(nameof(ProcessingData));
            }
        }
        int[] arrParameters;
        public int[] ArrParameters
        {
            get
            {
                return arrParameters;
            }
            set
            {
                arrParameters = value;
                OnPropertyChanged(nameof(ArrParameters));
            }
        }
        List<int> medianaList;
        public List<int> MedianaList
        {
            get 
            { 
                return medianaList; 
            }
            set 
            {
                medianaList = value;
                OnPropertyChanged(nameof(MedianaList));
            }
        }
        public void GetMedianaFilter()
        {
            if (DataList != null && DataList.Count > 0)
                MedianaList = ProcessingData.MedianaFilter(ArrParameters, W);             
        }
        public void GetDataList()
        {
            DataList = ProcessingData.dataTypeList;
        }
        public void GetFlowData()
        {
            if (DataList != null && DataList.Count > 0)
                ArrParameters = ProcessingData.GetFlowData(DataList);
        }
        public void SortDataType()
        {
            if (DataList != null && DataList.Count > 0)
                DataList = ProcessingData.SortTypeArrParameters(DataList);
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

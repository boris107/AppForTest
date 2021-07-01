using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest.Model
{
    public class ProcessingData : ICalculateMediana
    {
        public List<Data> dataTypeList { get; set; } = DataFromFile.GetDataFromFile(ViewModel.MainViewModel.path);
        //Перечисление операций с числами
        enum Operation
        {
            Sum = 1,
            Mul = 2,
            Max = 3,
            Min = 4
        }        
        // Метод предназначен для обработки параметров для каждого типа
        public int[] GetFlowData(List<Data> dataList)
        {
            int[] R = new int[dataList.Count];
            SumMul sum = new SumMul(); // посчитать сумму
            SumMul mul = new SumMul(); // посчитать произведене
            MaxMin min = new MaxMin(); // посчитать минимум
            MaxMin max = new MaxMin(); // посчитать максимум
            for (int i = 0; i < dataList.Count; i++)
            {
                Operation operation = (Operation)dataList[i].TypeId;
                switch (operation)
                {
                    case Operation.Sum:
                        R[i] = sum.Calculate(dataList[i].TypeId, dataList[i].ArrParameters);
                        break;
                    case Operation.Mul:
                        R[i] = mul.Calculate(dataList[i].TypeId, dataList[i].ArrParameters);
                        break;
                    case Operation.Max:
                        R[i] = max.Calculate(dataList[i].TypeId, dataList[i].ArrParameters);
                        break;
                    case Operation.Min:
                        R[i] = min.Calculate(dataList[i].TypeId, dataList[i].ArrParameters);
                        break;
                    default:
                        R[i] = 0;
                        break;
                }
            }
            return R;

        }
        // Метод предназначен для фильтрации массива, который работает таким образом, что пробегается по комбинациям массива исходя из окна W
        // если W равно 3, а длинна массива 8, то это будет 6 комбинаций по 3 и чтобы иметь 8 комбинаций, нужно прибавать вначале число из первого значения массива
        // и в конце из последнего значения массива и по каждой комбинации находим медиану и получаем отфильтрованный массив данных.
        public List<int> MedianaFilter(int[] r, int w)
        {
            List<int> medianaList = new List<int>();

            int countNewElementAfter = 0; // количество недостающих элементов в начале массива 
            int countNewElementBefore = 0; // количество недостающих элементов в конце массива
            int n = w - 1; // общее колечество комбинаций
            int count = 0; // общее количество комбинаций для перебора массива
            int countSdvigNormal = 1 + (r.Length - w); // количество сдвигов комбинаций
            if (n % 2 == 0)
            {
                countNewElementAfter = countNewElementBefore = count = n / 2;
                if (count > r.Length / 2 )
                    count = r.Length / 2;
            }
            // заполняем недостающие значения для комбинации (массива) в начале 
            for (int i = 0; i < count; i++)
            {
                int mediana = 0; // медиана 
                if (countNewElementAfter > 0)
                {
                    List<int> mass = new List<int>();
                    for (int q = 0; q < countNewElementAfter; q++)
                    {
                        mass.Add(r[0]);
                    }
                    mass.AddRange(r.Take(w - countNewElementAfter));
                    mass.Sort();
                    mediana = mass[mass.Count / 2];
                    countNewElementAfter--;
                }
                medianaList.Add(mediana);
            }
            // середина, где мы заполняем уже из нашего приходящего массива значения
            for (int i = 0; i < countSdvigNormal; i++)
            {
                int mediana = 0;
                List<int> mass = new List<int>();
                mass.AddRange(r.Skip(i).Take(w));
                mass.Sort();
                mediana = mass[mass.Count / 2];
                medianaList.Add(mediana);
            }
            // заполняем недостающие значения для комбинации (массива) в конце
            for (int i = 1; i <= count; i++)
            {
                int mediana = 0; 
                if (countNewElementBefore > 0)
                {
                    List<int> mass = new List<int>();
                    mass.AddRange(r.Skip(i + (r.Length - w)));
                    while (mass.Count < w)
                    {
                        mass.Add(r[r.Length - 1]);
                    }
                    mass.Sort();
                    mediana = mass[mass.Count / 2];
                    countNewElementBefore--;
                }
                medianaList.Add(mediana);
            }
            return medianaList;
        }
        // сортировка потока данных по типу, для объединения параметров одинаковых типов
        public List<Data> SortTypeArrParameters(List<Data> dataList)
        {
            List<Data> sortedList = new List<Data>();
            int lenArrParameters = 0;
            int typeId = 0;
            int[] parameters;
            foreach (var data in dataList.Where(x => x.TypeId == 1))
            {
                lenArrParameters += data.ArrParameters.Length;
                typeId = data.TypeId;
            }
            parameters = AddParameters(lenArrParameters, dataList.Where(x => x.TypeId == 1));
            sortedList.Add(new Data() { TypeId = typeId, ArrParameters = parameters });
            lenArrParameters = 0;
            foreach (var data in dataList.Where(x => x.TypeId == 2))
            {
                lenArrParameters += data.ArrParameters.Length;
                typeId = data.TypeId;
            }
            parameters = AddParameters(lenArrParameters, dataList.Where(x => x.TypeId == 2));
            sortedList.Add(new Data() { TypeId = typeId, ArrParameters = parameters });
            lenArrParameters = 0;
            foreach (var data in dataList.Where(x => x.TypeId == 3))
            {
                lenArrParameters += data.ArrParameters.Length;
                typeId = data.TypeId;
            }
            parameters = AddParameters(lenArrParameters, dataList.Where(x => x.TypeId == 3));
            sortedList.Add(new Data() { TypeId = typeId, ArrParameters = parameters });
            lenArrParameters = 0;
            foreach (var data in dataList.Where(x => x.TypeId == 4))
            {
                lenArrParameters += data.ArrParameters.Length;
                typeId = data.TypeId;
            }
            parameters = AddParameters(lenArrParameters, dataList.Where(x => x.TypeId == 4));
            sortedList.Add(new Data() { TypeId = typeId, ArrParameters = parameters });
            lenArrParameters = 0;
            return sortedList;
        }
        // объединение параметров одинаковых типов
        private int[] AddParameters(int lenArrParameters, IEnumerable<Data> dataList)
        {
            int[] result = new int[lenArrParameters];
            int i = 0;
            foreach (var data in dataList)
            {
                for (int j = 0; j < data.ArrParameters.Length; j++)
                {
                    result[i] = data.ArrParameters[j];
                    i++;
                }
            }
            return result;
        }
    }
 }

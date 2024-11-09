using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    public delegate void AddDataDelegate(IEnumerable<object> data);
    public delegate void DeleteDataDelegate(int index);
    public delegate void GenerateDataDelegate(int count);
    public interface IView
    {
        event AddDataDelegate AddDataEvent;
        event DeleteDataDelegate DeleteDataEvent;
        event GenerateDataDelegate GenerateDataEvent;

        void ReloadForm(IEnumerable<IEnumerable<object>> data);
    }
}

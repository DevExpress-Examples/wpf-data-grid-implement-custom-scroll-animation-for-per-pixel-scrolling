using System.Collections.ObjectModel;

namespace DXGrid_CustomScrollAnimation {
    public class TestDataObject {
        public int ID { get; set; }
        public string Value { get; set; }
    }
    public class TestData {
        public static ObservableCollection<TestDataObject> GetData() {
            ObservableCollection<TestDataObject> list = new ObservableCollection<TestDataObject>();
            for (int i = 0; i < 100; i++)
                list.Add(new TestDataObject() { ID = i, Value = string.Format("Value {0}", i) });
            return list;
        }
    }
}

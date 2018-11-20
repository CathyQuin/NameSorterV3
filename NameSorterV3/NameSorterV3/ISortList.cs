namespace NameSorterV3 {
    public interface ISortList {
        void AddItem(string inputValue);
        void DoSorting();
        string GetItemDisplayValue(int inputIndex);
        int ListCount();
        string OutputList();
    }
}
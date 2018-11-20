namespace NameSorterV3 {
    public interface ISortList {
        void AddPerson(string inputValue);
        void DoSorting();
        string GetItemDisplayName(int inputIndex);
        int ListCount();
        string OutputList();
    }
}
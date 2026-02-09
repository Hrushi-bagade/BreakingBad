public interface IPracticeModule
{
    string Name { get; }
    void ShowMenu();
    void Execute(int choice);
}

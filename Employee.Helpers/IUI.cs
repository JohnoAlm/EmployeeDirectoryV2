namespace Employee.Helpers
{
    //Interface namnkonvention att namnet startar med I.
    //Klasser som implementerar IUI måste implemnetera GetInput() samt Print(string message)
    public interface IUI
    {
        string? GetInput();
        void Print(string message);
    }
}
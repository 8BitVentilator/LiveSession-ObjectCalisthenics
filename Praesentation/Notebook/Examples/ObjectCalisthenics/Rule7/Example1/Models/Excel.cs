namespace ObjectCalisthenics.Rule7.Example1.Models
{
    public class Excel : IExcel
    {
        public void SetValue(string cell, object value) => Console.WriteLine($"Schreibe Wert '{value}' in Zelle '{cell}'");
    }
}

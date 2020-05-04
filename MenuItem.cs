namespace CaspianDeveloperExercise
{
    public class MenuItem
    {
        public string Name { get; set; }

        public ENUM_Temp Temp { get; set; }

        public double Price {get; set;}
    }

    public enum ENUM_Temp
    {
        Hot,
        Cold
    }
}
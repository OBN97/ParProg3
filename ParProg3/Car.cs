namespace ParProg3;

public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string RegisteringsNr { get; set; }
    public int Kilometers { get; set; }

    public Car(string model, int year, string registeringsNr, int kilometers)
    {
        Model = model;
        Year = year;
        RegisteringsNr = registeringsNr;
        Kilometers = kilometers;
    }
    
    
}
namespace ExamenParcial1POO2;

public class EmployeModel : EntityBase
{
    public EmployeModel()
    {
    }

    public string Role { get; set; }
    public decimal Salary { get; set; }
    public int Seniority { get; set; }
    
}
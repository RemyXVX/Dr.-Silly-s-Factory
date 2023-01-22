namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get; set;}
    public string EngineerName {get; set;}
    public string EngineerDescription {get; set;}
    public int MachineId {get; set;}
    public Machine Machine {get; set;}
  }
} 
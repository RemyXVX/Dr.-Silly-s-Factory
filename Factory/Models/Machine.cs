using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get; set;}
    public string MachineName {get; set;}
    public string MachineDetails {get; set;}
    // public int EngineerId { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
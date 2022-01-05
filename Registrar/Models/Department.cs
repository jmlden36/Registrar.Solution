using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntitiesC = new HashSet<DepartmentCourse>();
      this.JoinEntitiesS = new HashSet<DepartmentStudent>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public virtual ICollection<DepartmentCourse> JoinEntitiesC { get; set; }
    public virtual ICollection<DepartmentStudent> JoinEntitiesS { get; set; }
  }
}
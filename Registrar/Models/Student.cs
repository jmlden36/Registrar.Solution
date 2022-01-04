using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime DateEnrolled { get; set; }
    public virtual ICollection<CourseItem> JoinEntities { get; }
  }
}
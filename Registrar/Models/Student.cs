using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
      this.JoinEntitiesS = new HashSet<DepartmentStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime DateEnrolled { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; }
    public virtual ICollection<DepartmentStudent> JoinEntitiesS { get; }
  }
}
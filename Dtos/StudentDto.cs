using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Dtos
{
    public class StudentDto
    {
        public int  id { get; set; }
        public String Name { get; set; } = string.Empty;
        public int Age{ get; set; }
        public int StudentId { get; set; }
        public String Status { get; set; } = string.Empty;
    }
}
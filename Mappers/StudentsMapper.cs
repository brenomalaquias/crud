using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;
using projeto.Dtos;

namespace projeto.Mappers
{
    public static class StudentsMapper
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto
            {
                id = student.id,
                Name = student.Name,
                Age = student.Age,
                StudentId = student.StudentId,
                Status = student.Status
              
            };
        }
        
    }
}
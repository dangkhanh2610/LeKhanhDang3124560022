using DapperApi.Models;

namespace DapperApi.Repositories;

public interface IStudentRepository
{
    IEnumerable<Student> GetAll();
    IEnumerable<StudentWithCourses> GetAllWithCourses();
    Student? GetById(int id);
    IEnumerable<Student> SearchByName(string name);
    void Create(Student student);
    void Update(Student student);
    void Delete(int id);  
}
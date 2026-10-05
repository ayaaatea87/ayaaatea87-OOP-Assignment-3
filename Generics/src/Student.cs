using System;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class StudentStore
{
    private readonly List<Student> _students = new List<Student>();

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public Student GetById(int id)
    {
        foreach (var student in _students)
        {
            if (student.Id == id)
                return student;
        }

        return null;
    }

    public List<Student> GetAll()
    {
        return _students;
    }

    public void Remove(int id)
    {
        for (int i = 0; i < _students.Count; i++)
        {
            if (_students[i].Id == id)
            {
                _students.RemoveAt(i);
                return;
            }
        }
    }
}

using RestASPNET.DTO;
using RestASPNET.Model;
using RestASPNET.Persistence;

namespace RestASPNET.Repository;

public interface IPersonRepository
{
    public Person Add(Person person);
    public Person Update(Person person, long id);
    public Person FindById(long id);
    public List<Person> FindAll();

    public void Delete(long id);
}

public class PersonRepository : IPersonRepository
{
    private Context _context;

    public PersonRepository(Context context)
    {
        _context = context;
    }
    
    public Person Add(Person person)
    {
        _context.Add(person);
        _context.SaveChanges();
        return person;
    }

    public Person Update(Person person, long id)
    {
        person.Id = id;
        _context.Update(person);
        _context.SaveChanges();
        return person;
    }

    public Person FindById(long id)
    {
        return _context.Persons.Find(id);
    }

    public List<Person> FindAll()
    {
        return _context.Persons.ToList();
    }

    public void Delete(long id)
    {
        var person = _context.Persons.Find(id);
        if (person != null)
        { 
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
    }
}

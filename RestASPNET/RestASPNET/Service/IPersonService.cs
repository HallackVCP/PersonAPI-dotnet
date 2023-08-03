using RestASPNET.DTO;
using RestASPNET.Model;
using RestASPNET.Repository;

namespace RestASPNET.Service;

public interface IPersonService
{
    PersonDTO Create(PersonDTO personDto);
    PersonDTO Update(PersonDTO personDto, long id);
    PersonDTO FindById(long id);

    List<PersonDTO> FindAll();
    void Delete(long id);
}

public class PersonService : IPersonService
{
    private IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public PersonDTO Create(PersonDTO personDto)
    {
        return Mapper.Mapper.ModelToDto(_personRepository.Add(Mapper.Mapper.DtoToModel(personDto)));
    }

    public PersonDTO Update(PersonDTO personDto, long id)
    {
        return Mapper.Mapper.ModelToDto(_personRepository.Update(Mapper.Mapper.DtoToModel(personDto), id));
    }

    public PersonDTO FindById(long id)
    {
        Person person = _personRepository.FindById(id);
        return person == null ? null : Mapper.Mapper.ModelToDto(person);
    }

    public List<PersonDTO> FindAll()
    {
        List<Person> lsPerson = _personRepository.FindAll();
        List<PersonDTO> lsPersonDto = new List<PersonDTO>();
        foreach (var person in lsPerson)
        {
            lsPersonDto.Add(Mapper.Mapper.ModelToDto(person));
        }

        return lsPersonDto;
    }

    public void Delete(long id)
    {
        _personRepository.Delete(id);
    }
}
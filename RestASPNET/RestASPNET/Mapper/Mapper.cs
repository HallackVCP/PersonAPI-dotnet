using RestASPNET.DTO;
using RestASPNET.Model;

namespace RestASPNET.Mapper;

public static class Mapper
{
    public static Person DtoToModel(PersonDTO personDto)
    {
        Person person = new Person();
        person.Address = personDto.Address;
        person.Gender = personDto.Gender;
        person.FirstName = personDto.FirstName;
        person.LastName = personDto.LastName;
        return person;
    }

    public static PersonDTO ModelToDto(Person person)
    {
        PersonDTO personDto = new PersonDTO();
        personDto.Address = person.Address;
        personDto.Gender = person.Gender;
        personDto.FirstName = person.FirstName;
        personDto.LastName = person.LastName;
        return personDto;
    }
    
}
﻿using System.ComponentModel.DataAnnotations;

namespace RestASPNET.Model;

public class Person
{
    [Key]
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
}
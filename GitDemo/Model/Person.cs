using System;
using System.Collections.Generic;

namespace GitDemo.Model
{
    public class Person
    {
        public DateTime DateOfBirth { get; set; }
        public List<string> Skills { get; set; } = new();
        public string Address {get;set;}
        public string Name {get;set; }  
        public string PhoneNumber {get;set; }
        public string Email {get;set; }
    }
}

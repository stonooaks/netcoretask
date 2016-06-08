using System;
using System.ComponentModel.DataAnnotations;

namespace netcoretask
{
    
    public class TaskType {

        public int ID { get; set; }
        public string Type { get; set; }
    }

    public class Customer {

        public int ID {get;set;}

        public string Name {get;set;}

        public string Contact {get;set;}

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
    public class Task {

        public int ID {get;set;}
        public string Description { get; set; }

        public DateTime CompletedDate {get;set;}

        public TaskType Type {get; set; }

        public Customer Customer {get;set;}
    }
}
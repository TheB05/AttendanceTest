using System;
using System.ComponentModel.DataAnnotations;

class Student{
    public String id { get; set; } = string.Empty;

    public string Name { get; set; } = "";

    public string Lastname { get; set; } = "";

    public string Grade { get; set; } = "";

    public string ClassID { get; set; } = "";

    public DateTime Date { get; set; } = DateTime.Now;

    public string Motive { get; set; } = "";
}
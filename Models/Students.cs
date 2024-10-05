using System;
using System.ComponentModel.DataAnnotations;

class Student{
    public String id { get; set; } = string.Empty;

    [Required (ErrorMessage = "Debe incluir el nombre del estudiante.")]
    public string Name { get; set; } = "";

    [Required (ErrorMessage = "Debe incluir el apellido del estudiante.")]
    public string Lastname { get; set; } = "";

    [Required (ErrorMessage = "Debe incluir el curso del estudiante. (4-A)")]
    public string Grade { get; set; } = "";

    [Required (ErrorMessage = "Debe incluir la matrícula del estudiante.")]
    public string ClassID { get; set; } = "";

    public DateTime Date { get; set; } = DateTime.Now;

    [Required (ErrorMessage = "Debe incluir el motivo de tardanza.")]
    public string Motive { get; set; } = "";
}
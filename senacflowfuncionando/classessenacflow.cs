using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senacflowfuncionando
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public int IdProfessor { get; set; }
        public int IdSala { get; set; }
        public DateTime DataAtual { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
    }
    public class Limpeza
    {
        public int IdLimpeza { get; set; }
        public int IdLocal { get; set; }
        public DateTime DataLimpeza { get; set; }
        public string Hora { get; set; }
        public string Responsavel { get; set; }
        public string Status { get; set; }
    }
    public class admin
    {
        public int id { get; set; }
        public string loginadmin { get; set; }
        public string senhaadmin { get; set; }
    }
    public class Professor
    {
        public int IdProfessor { get; set; }
        public string NomeCompleto { get; set; }
        public int IdDisciplina { get; set; }
    }
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public string NomeDisciplina { get; set; }
    }
}

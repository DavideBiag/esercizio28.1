using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._1_nuovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Persona
    {
        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }

        public string Nome
        {
            get => default;
            set
            {
            }
        }

        public string Cognome
        {
            get => default;
            set
            {
            }
        }

        public DateTime DataDiNascita
        {
            get => default;
            set
            {
            }
        }
    }

    public class Insegnante : Persona
    {
        public Materia Materia
        {
            get => default;
            set
            {
            }
        }

        public Insegnante(Materia materia, string nome, string cognome, DateTime dataDiNascita) : base(nome,cognome, dataDiNascita)
        {
            Materia = materia;
        }
    }

    public class Studente : Persona
    {
        private Voto[] insiemeVoti = new Voto[20];

        public Studente(string nome,string cognome, DateTime dataDiNascita): base(nome,cognome,dataDiNascita)
        {
        }
    }

    public class Voto
    {
        public int Valore
        {
            get => default;
            set
            {
            }
        }

        public DateTime Data
        {
            get => default;
            set
            {
            }
        }

       
        public Materia Materia
        {
            get => default;
            set
            {
            }
        }

        public Voto(int valore, DateTime data, Materia materia)
        {
            Valore = valore;
            Data = data;
            Materia = materia;
        }
    }

    public class Materia
    {
        public Materia(string nome, string iD)
        {
            Nome = nome;
            ID = iD;
        }

        public string Nome
        {
            get => default;
            set
            {
            }
        }

        public string ID
        {
            get => default;
            set
            {
            }
        }
    }
}

using System.Globalization;
using System.Linq;

namespace LivrariaLinq
{
    public class ListaDeAlunos
    {
        public static List<Aluno> LoadAlunos()
        {
            List<Aluno> output = new List<Aluno>();

            string dateFormat = "M/d/yyyy";

            output.Add(new Aluno { PrimeiroNome = "Torres", Apelido = "Carlos", DataNascimento = DateTime.ParseExact("2/25/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 20 });
            output.Add(new Aluno { PrimeiroNome = "Jesuita", Apelido = "Susana", DataNascimento = DateTime.ParseExact("3/31/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 12 });
            output.Add(new Aluno { PrimeiroNome = "Susana", Apelido = "Sousa", DataNascimento = DateTime.ParseExact("1/3/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 1 });
            output.Add(new Aluno { PrimeiroNome = "Sara", Apelido = "Jesuita", DataNascimento = DateTime.ParseExact("3/6/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 8 });
            output.Add(new Aluno { PrimeiroNome = "Janota", Apelido = "Duarte", DataNascimento = DateTime.ParseExact("2/10/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 7 });
            output.Add(new Aluno { PrimeiroNome = "Maria", Apelido = "Susana", DataNascimento = DateTime.ParseExact("1/23/1970", dateFormat, CultureInfo.InvariantCulture), DisciplinasFeitas = 16 });

            return output;
        }
    }
}

/*
 public static List<Aluno> LoadAlunos()
{
    List<Aluno> output = new List<Aluno>();

    output.Add(new Aluno { PrimeiroNome = "Torres", Apelido = "Carlos", DataNascimento = Convert.ToDateTime("2/25/1970"), DisciplinasFeitas = 20 });

    output.Add(new Aluno { PrimeiroNome = "Jesuita", Apelido = "Susana", DataNascimento = Convert.ToDateTime("3/31/1970"), DisciplinasFeitas = 12 });

    output.Add(new Aluno { PrimeiroNome = "Susana", Apelido = "Sousa", DataNascimento = Convert.ToDateTime("1/3/1970"), DisciplinasFeitas = 1 });

    output.Add(new Aluno { PrimeiroNome = "Sara", Apelido = "Jesuita", DataNascimento = Convert.ToDateTime("3/6/1970"), DisciplinasFeitas = 8 });

    output.Add(new Aluno { PrimeiroNome = "Janota", Apelido = "Duarte", DataNascimento = Convert.ToDateTime("2/10/1970"), DisciplinasFeitas = 7 });

    output.Add(new Aluno { PrimeiroNome = "Maria", Apelido = "Susana", DataNascimento = Convert.ToDateTime("1/23/1970"), DisciplinasFeitas = 16 });

    return output;

 //Esta versão não corre na versão mais recente do VS Studio
}*/

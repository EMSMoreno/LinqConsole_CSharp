using LivrariaLinq;
using System.Globalization;
using System.Linq;

namespace LinqConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();

            //Ordenar lista por apelido
            Alunos = Alunos.OrderByDescending(x => x.Apelido).ToList();

            //Alunos = Alunos.OrderByDescending(x => x.Apelido).ThenByDescending(x => x.DisciplinasFeitas).ToList();

            //Alunos = Alunos.Where(x => x.DisciplinasFeitas >  10 && x.DataNascimento.Month == 3).ToList();

            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"{aluno.PrimeiroNome} " +
                                  $"{aluno.Apelido} " +
                                  $"({aluno.DataNascimento.ToShortDateString()}) " +
                                  $"DisciplinasFeitas: {aluno.DisciplinasFeitas}");
            }

            int totalDeDisciplinasFeitas = Alunos.Sum(x => x.DisciplinasFeitas);
            double mediaDeDisciplinasFeitas = Alunos.Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de disciplinas feitas: {totalDeDisciplinasFeitas}");
            Console.WriteLine($"Media de disciplinas feitas: {mediaDeDisciplinasFeitas:N2}");

            totalDeDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Sum(x => x.DisciplinasFeitas);

            mediaDeDisciplinasFeitas = Alunos.Where(x => x.DataNascimento.Month == 2).Average(x => x.DisciplinasFeitas);

            Console.WriteLine($"Total de disciplinas feitas: {totalDeDisciplinasFeitas}");
            Console.WriteLine($"Media de disciplinas feitas: {mediaDeDisciplinasFeitas:N2}");

            Console.ReadKey();
        }
    }
}
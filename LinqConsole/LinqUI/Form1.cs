using LivrariaLinq;

namespace LinqUI
{
    public partial class Form1 : Form
    {
        List<Aluno> Alunos = ListaDeAlunos.LoadAlunos();

        public Form1()
        {
            InitializeComponent();
            InitCombo();
        }

        private void InitCombo()
        {
            ComboBoxTodosAlunos.DataSource = Alunos;
            ComboBoxTodosAlunos.DisplayMember = "NomeCompleto";

            ListBoxFiltro.DataSource = Alunos.Where(x => x.DisciplinasFeitas > 10).OrderBy(x => x.PrimeiroNome).ThenBy(x => x.Apelido).ToList();

            ListBoxFiltro.DisplayMember = "NomeCompleto";
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)ComboBoxTodosAlunos.SelectedItem;

            alunoSelecionado.DisciplinasFeitas = Convert.ToInt32(NumericUpDownDisciplinasFeitas.Value);

            UpdateData();
        }

        private void ComboBoxTodosAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)ComboBoxTodosAlunos.SelectedItem;

            NumericUpDownDisciplinasFeitas.Value = alunoSelecionado.DisciplinasFeitas;

        }

        private void UpdateData()
        {
            ListBoxFiltro.DataSource = Alunos.Where(x => x.DisciplinasFeitas > 10).OrderBy(x => x.PrimeiroNome).ThenBy(x => x.Apelido).ToList();
        }

        
    }
}

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo") ;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            String Conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, Conteudo);
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}

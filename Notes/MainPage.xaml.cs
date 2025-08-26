
namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo") ;

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(caminho))
                CaixaEditor.Text =  File.ReadAllText(caminho);



        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            String Conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, Conteudo);


            if (CaixaEditor.Text == string.Empty)
                DisplayAlert("Arquivo Não Encontrado", "Esse arquivo não existe", "Fechar");

            else
                DisplayAlert("Arquivo salvo", $"Seu arquivo {Conteudo} foi salvo com sucesso em {caminho} ", "OK");




        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            File.Delete(caminho);
            DisplayAlert("Arquivo Apagado", "Arquivo apagado com sucesso!", "OK 👍👍👍");

            CaixaEditor.Text = String.Empty;
        
            


        }



    }

}

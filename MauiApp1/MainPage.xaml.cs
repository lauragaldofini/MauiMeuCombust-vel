namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            double gasolina = Convert.ToDouble(txt_gasolina.Text);
            double etanol = Convert.ToDouble(txt_etanol.Text);

            string msg = $"Compensa mais";

            if (etanol > (gasolina * 0.7))
            {
                msg += "gasolina";
            }
            else
            {
                msg += "etanol";
            }
            DisplayAlert("Resultado", msg, "fechar");
        }
    }

}

using CadastrarEvento.Models;

namespace CadastrarEvento.Views
{
    public partial class CadastrarEvento : ContentPage
    {


        public CadastrarEvento()
        {
            InitializeComponent();

            dtpck_I.MinimumDate = DateTime.Today;
            dtpck_I.MaximumDate = DateTime.Today.AddMonths(6);
            dtpck_F.MinimumDate = dtpck_I.Date.AddDays(1);
            dtpck_F.MaximumDate = dtpck_I.Date.AddDays(6);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Contas contas = new Contas
                {
                    Conv = Convert.ToInt32(stp_Np.Value),
                    DpckF = dtpck_F.Date,
                    DpckI = dtpck_I.Date,
                    Nome = txt_nameEvent.Text,
                    Local=txt_eventplace.Text,
                };

                 await Navigation.PushAsync(new EventoCadastrado() { BindingContext = contas});
                

            }


            catch (Exception ex)
            {
                await DisplayAlert("ops", ex.Message, "ok");
            }

        }

        private void dtpck_I_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker element = sender as DatePicker;

            DateTime selected_date_in = element.Date;

            dtpck_F.MinimumDate = selected_date_in.AddDays(1);
            dtpck_F.MaximumDate = selected_date_in.AddMonths(6);
        }
    }

}

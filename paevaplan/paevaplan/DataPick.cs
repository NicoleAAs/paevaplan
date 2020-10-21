using System;
using Xamarin.Forms;

class MainPage : ContentPage
{
    Label label;
    DatePicker datePicker;
    public MainPage()
    {
        label = new Label { Text = "Select Date" };
        datePicker = new DatePicker
        {
            Format = "D",
            MaximumDate = DateTime.Now.AddDays(5),
            MinimumDate = DateTime.Now.AddDays(-5)
        };
        datePicker.DateSelected += datePicker_DateSelected;
        StackLayout stack = new StackLayout { Children = { label, datePicker } };
        this.Content = stack;
    }

    private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        label.Text = "You Choosed " + e.NewDate.ToString("dd/MM/yyyy");
    }
}
    


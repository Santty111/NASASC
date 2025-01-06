using MauiApp1.ViewModels;
namespace MauiApp1.Views;

public partial class ApodPageSC : ContentPage
{
    public ApodPageSC()
    {
        InitializeComponent();
        BindingContext = new ApodViewModel();
    }
}
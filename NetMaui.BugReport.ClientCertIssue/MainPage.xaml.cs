using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace NetMaui.BugReport.ClientCertIssue;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var handler = new HttpClientHandler();
        handler.ClientCertificateOptions = ClientCertificateOption.Manual;
        handler.SslProtocols = SslProtocols.Tls12;
        handler.ClientCertificates.Add(new X509Certificate2());
        count = handler.ClientCertificates.Count;
        CounterBtn.Text = $"Certificates count {count}";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}



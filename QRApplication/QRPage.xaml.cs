using Net.ConnectCode.BarcodeFontsStandard2D;

namespace QRApplication;

public partial class QRPage : ContentPage
{
    private double R = 0;
    private double G = 0;
    private double B = 0;

    public QRPage(string qr)
    {
        InitializeComponent();

        QR qrcode = new QR(qr, "M", 0);
        QRCodeBarcode.Text = qrcode.Encode();
    }

    void RSliderValue(object sender, ValueChangedEventArgs args)
    {
        R = args.NewValue;
        rLabelValue.Text = args.NewValue.ToString("F3");
        QRCodeBarcode.TextColor = Color.FromRgb(R, G, B);
    }

    void GSliderValue(object sender, ValueChangedEventArgs args)
    {
        G = args.NewValue;
        gLabelValue.Text = args.NewValue.ToString("F3");
        QRCodeBarcode.TextColor = Color.FromRgb(R, G, B);
    }

    void BSliderValue(object sender, ValueChangedEventArgs args)
    {
        B = args.NewValue;
        bLabelValue.Text = args.NewValue.ToString("F3");
        QRCodeBarcode.TextColor = Color.FromRgb(R, G, B);
    }
}
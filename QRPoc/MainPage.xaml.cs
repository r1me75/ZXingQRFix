#if (ANDROID || IOS || MACCATALYST)
using System.Diagnostics;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;
#endif
namespace QRPoc;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		#if (ANDROID || IOS || MACCATALYST)
        CameraBarcodeReaderView cameraBarcodeReaderView = new CameraBarcodeReaderView() {
			IsDetecting = true,
			IsTorchOn = false,
			HeightRequest = 300,
			WidthRequest = 300,
			Options = new BarcodeReaderOptions()
			{
				Formats = BarcodeFormat.QrCode
			}
		};
		cameraBarcodeReaderView.BarcodesDetected += HandleDetectedBarcodes;

		layout.Add(cameraBarcodeReaderView);
		#endif   
	}

	#if (ANDROID || IOS || MACCATALYST)

    protected void HandleDetectedBarcodes(object sender, BarcodeDetectionEventArgs e)
    {
		Dispatcher.Dispatch(() =>
		{
			qrResult.Text = $"{e.Results[0].Value} -> {e.Results[0].Format}";
		});
    }
	#endif

}


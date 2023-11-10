namespace MauiPermissionRequestSample;

public partial class MainPage : ContentPage
{
	int sensorCount, cameraCount, locationCount = 0;    

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnSensorRequested(object sender, EventArgs e)
	{
        sensorCount++;

		try
		{
			var status = await Permissions.RequestAsync<Permissions.Sensors>();
			debugText.Text += $"Sensor Permission Request result: {status}, click counter {sensorCount}\n";
		}
		catch (Exception ex)
		{
			debugText.Text += ex.ToString();
		}
	}

    private async void OnCameraRequested(object sender, EventArgs e)
    {
        cameraCount++;

        try
        {
            var status = await Permissions.RequestAsync<Permissions.Camera>();
            debugText.Text += $"Camera Permission Request result: {status}, click counter {cameraCount}\n";
        }
        catch (Exception ex)
        {
            debugText.Text += ex.ToString();
        }
    }

    private async void OnLocationRequested(object sender, EventArgs e)
    {
        locationCount++;

        try
        {
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            debugText.Text += $"Location Permission Request result: {status}, click counter {locationCount}\n";
        }
        catch (Exception ex)
        {
            debugText.Text += ex.ToString();
        }
    }
}


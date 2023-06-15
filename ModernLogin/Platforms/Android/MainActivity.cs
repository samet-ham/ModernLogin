using Android.App;
using Android.Content.PM;
using Android.OS;
using Color = Android.Graphics.Color;

namespace ModernLogin;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        if(Build.VERSION.SdkInt >= BuildVersionCodes.M)
        {
            Window.SetStatusBarColor(Color.ParseColor("#d3d3d3"));
            Window.SetNavigationBarColor(Color.ParseColor("#d3d3d3"));
        }
    }
}

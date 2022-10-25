

namespace CheckBoxes;

public partial class MainPage : ContentPage
{
	//int count = 0;

	double RedColor = 0;
	double GreenColor = 0;
	double BlueColor = 0;
	float newOpacity = 1;

	public MainPage()
	{
		InitializeComponent();

        //OneSlider.DragStartedCommand = new Command(ValueStartChange);
        //OneSlider.ValueChanged+= ValueStartChange;
    }
    private void SetColor()
    {
		PalleteEllipse.Fill = Color.FromRgba(RedColor/255, GreenColor/255, BlueColor/255, newOpacity) ;
    }

    private void SetRedColor(object color, ValueChangedEventArgs e)
	{
		RedColor = e.NewValue;
		RedSlider.Value = RedColor;
		RedStepper.Value = RedColor;
 		SetColor();
    }

	private void SetGreenColor(object color, ValueChangedEventArgs e)
	{
		GreenColor = e.NewValue;
        GreenSlider.Value = GreenColor;
		GreenStepper.Value = GreenColor;
        SetColor();
    }

	private void SetBlueColor(object color, ValueChangedEventArgs e)
	{
		BlueColor = e.NewValue;
        BlueSlider.Value = BlueColor;
		BlueStepper.Value = BlueColor;
        SetColor();
    }

	private void SetOpacity(object opacity, ValueChangedEventArgs e)
	{
        newOpacity = (float)e.NewValue;
		OpacitySlider.Value = newOpacity;
		OpacityStepper.Value = newOpacity;
        SetColor();
    }

	//private void ValueStartChange()
	//{
	//	Li.Text = "Мы изменили значение";
	//}

 //   private void ValueStartChange(object a, ValueChangedEventArgs e)
 //   {
	//	Li.Text = e.NewValue.ToString();
 //   }

 //   private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	//{

	//}

	//private void OneSlider_DragStarted()
	//{

	//}

	//private void OneSlider_ValueChanged()
	//{

	//}


}
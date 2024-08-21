using Microsoft.VisualBasic;

namespace Module01Exercise01;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
        EntryofName.IsVisible = false;
        EntryofEmail.IsVisible = false;
        PickerDateofBirth.IsVisible = false;
        BioEditor.IsVisible = false;

        DisplayAlert("Entered Values", "Hey Hey!", "Ok", "Cancel");

        DisplayAlert("Entered Values", "{local:CurrentDateExtension}", "Ok", "Cancel");

		this.BindingContext = this;
    }

	private void Event_Edit (object sender, EventArgs e)
	{
		DisplayedName.IsVisible = false;
		DisplayedEmail.IsVisible = false;
		DisplayedDoB.IsVisible = false;
		DisplayedBio.IsVisible = false;

		EntryofName.IsVisible = true;
		EntryofEmail.IsVisible = true;
		PickerDateofBirth.IsVisible = true;
		BioEditor.IsVisible = true;

		EditButton.IsVisible = false;
		CancelButton.IsVisible = true;
		SaveButton.IsVisible = true;
	}

	private void Event_Cancel (object sender, EventArgs e)
	{
        DisplayedName.IsVisible = true;
        DisplayedEmail.IsVisible = true;
        DisplayedDoB.IsVisible = true;
        DisplayedBio.IsVisible = true;

        EntryofName.IsVisible = false;
        EntryofEmail.IsVisible = false;
        PickerDateofBirth.IsVisible = false;
        BioEditor.IsVisible = false;

        CancelButton.IsVisible= false;
		SaveButton.IsVisible = false;
		EditButton.IsVisible = true;
	}

	private void Event_Save (object sender, EventArgs e)
	{
        DisplayedName.IsVisible = true;
        DisplayedEmail.IsVisible = true;
        DisplayedDoB.IsVisible = true;
        DisplayedBio.IsVisible = true;

        EntryofName.IsVisible = false;
        EntryofEmail.IsVisible = false;
        PickerDateofBirth.IsVisible = false;
        BioEditor.IsVisible = false;

        CancelButton.IsVisible = false;
		SaveButton.IsVisible= false;
		EditButton.IsVisible = true;

		string userName = EntryofName.Text;
		string userEmail = EntryofEmail.Text;
		DateTime userDoB = PickerDateofBirth.Date;
		string userBio = BioEditor.Text;

		this.Resources["DynamicUsername"] = userName;

        DisplayAlert("Entered Values", $"Name: {userName}\nEmail:{userEmail}\nDate of Birth: {userDoB}\nBio: {userBio}", "Ok", "Cancel");
    }

    private void Event_ChangeBackground_Gray(object sender, EventArgs e)
    {
        this.Resources["DynamicBackgroundColor"] = Colors.Gray;
    }

    private void Event_ChangeBackground_LightGray (object sender, EventArgs e)
	{
        this.Resources["DynamicBackgroundColor"] = Colors.LightGray;
    }

	private void Event_ChangeBackground_LightPink (object sender, EventArgs e)
	{
        this.Resources["DynamicBackgroundColor"] = Colors.LightPink;
    }

    private void PickerDateofBirth_DateSelected(object sender, DateChangedEventArgs e)
    {

    }
}
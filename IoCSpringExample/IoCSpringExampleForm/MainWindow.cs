using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	#region "Eventos de la ventana"

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnExitButtonPressEvent (object o, ButtonPressEventArgs args)
	{
		exitApplication ();
	}
	
	protected void OnBtnSaveButtonPressEvent (object o, ButtonPressEventArgs args)
	{
        SaveEntry(txtEntry.Text, CalendarEntryDate.GetDate, txtEntryDescription.ModifyText);
	}

	#endregion


	
	private void exitApplication ()
	{
		Application.Quit ();
	}


    void SaveEntry(string text, DateTime getDate, string modifyText)
    {
       
    }
}

using System;
using System.Collections.Generic;
using Gtk;
using System.Linq;
using IoCSpringExampleForm.BussinessLayer;

public partial class MainWindow: Gtk.Window
{	

    #region "variables privadas"
    private ManageEntries _manageEntries;
    #endregion

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
        _manageEntries = new ManageEntries();
        txtAllEntryDescription.Buffer.Text = LoadEntriesMonth(CalendarEntryDate.GetDate());
    }

	#region "Eventos de la ventana"

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

    protected void OnBtnExitClicked (object sender, EventArgs e)
    {
        exitApplication ();
    }

    protected void OnBtnAddEntryClicked (object sender, EventArgs e)
    {
        AddEntry(txtEntry.Text, txtEntryDescription.Buffer.Text, CalendarEntryDate.GetDate());
    }
        
    protected void OnCalendarEntryDateMonthChanged (object sender, EventArgs e)
    {
        txtAllEntryDescription.Buffer.Text = LoadEntriesMonth(((Calendar)sender).GetDate()); 
    }
    
	#endregion

    #region "Funciones privadas"

    private void exitApplication ()
    {
        Application.Quit();
    }

    private string LoadEntriesMonth(DateTime selectMonth)
    {
        var entries = _manageEntries.GetEntriesSelectedMonth(selectMonth);
        string lineas = string.Empty;
        foreach (var item in entries)
        {
           lineas =  string.Concat(lineas, item.date.ToShortDateString(), ": ", item.nameEntry, " ----> ", item.Entry, "\n");
        }
        return lineas;
    }

    void AddEntry(string Entrytext, string EntryDescription, DateTime getDate)
    {
        _manageEntries.addEntry(Entrytext, EntryDescription, getDate);
    }

    #endregion




}

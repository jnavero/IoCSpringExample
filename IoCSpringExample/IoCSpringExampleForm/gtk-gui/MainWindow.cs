
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox3;
	private global::Gtk.VBox vbox4;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label lblEntryName;
	private global::Gtk.Entry txtEntry;
	private global::Gtk.Calendar calendar1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView txtEntry1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button btnShowEntries;
	private global::Gtk.Button btnSave;
	private global::Gtk.Button btnExit;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblEntryName = new global::Gtk.Label ();
		this.lblEntryName.Name = "lblEntryName";
		this.lblEntryName.LabelProp = global::Mono.Unix.Catalog.GetString ("Entry name: ");
		this.hbox2.Add (this.lblEntryName);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lblEntryName]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtEntry = new global::Gtk.Entry ();
		this.txtEntry.CanFocus = true;
		this.txtEntry.Name = "txtEntry";
		this.txtEntry.IsEditable = true;
		this.txtEntry.InvisibleChar = '•';
		this.hbox2.Add (this.txtEntry);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtEntry]));
		w2.Position = 1;
		this.vbox4.Add (this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.calendar1 = new global::Gtk.Calendar ();
		this.calendar1.CanFocus = true;
		this.calendar1.Name = "calendar1";
		this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.vbox4.Add (this.calendar1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.calendar1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txtEntry1 = new global::Gtk.TextView ();
		this.txtEntry1.CanFocus = true;
		this.txtEntry1.Name = "txtEntry1";
		this.GtkScrolledWindow.Add (this.txtEntry1);
		this.vbox4.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
		w6.Position = 2;
		this.vbox3.Add (this.vbox4);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
		w7.Position = 0;
		// Container child vbox3.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.vbox3.Add (this.fixed1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.fixed1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 9;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnShowEntries = new global::Gtk.Button ();
		this.btnShowEntries.CanFocus = true;
		this.btnShowEntries.Name = "btnShowEntries";
		this.btnShowEntries.UseUnderline = true;
		this.btnShowEntries.Label = global::Mono.Unix.Catalog.GetString ("Show Entries");
		this.hbox1.Add (this.btnShowEntries);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnShowEntries]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnSave = new global::Gtk.Button ();
		this.btnSave.CanFocus = true;
		this.btnSave.Name = "btnSave";
		this.btnSave.UseUnderline = true;
		this.btnSave.Label = global::Mono.Unix.Catalog.GetString ("Save");
		this.hbox1.Add (this.btnSave);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnSave]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnExit = new global::Gtk.Button ();
		this.btnExit.CanFocus = true;
		this.btnExit.Name = "btnExit";
		this.btnExit.UseUnderline = true;
		this.btnExit.Label = "Exit";
		this.hbox1.Add (this.btnExit);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnExit]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 356;
		this.DefaultHeight = 359;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}

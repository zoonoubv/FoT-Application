
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.FileChooserButton filechooserbutton1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.RadioButton radioResource1;
	private global::Gtk.RadioButton radioResource2;
	private global::Gtk.Label labelClient1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Label labelProject1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label labelClient2;
	private global::Gtk.Entry entry3;
	private global::Gtk.Label labelProject2;
	private global::Gtk.Entry entry4;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button buttonQuit;
	private global::Gtk.HSeparator hseparator1;
	private global::Gtk.Button buttonContinue;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 500;
		this.HeightRequest = 400;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
		this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(9));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.WidthRequest = 250;
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.hbox3.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.WidthRequest = 210;
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.label2.Justify = ((global::Gtk.Justification)(1));
		this.hbox3.Add (this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.filechooserbutton1 = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooserbutton1.Name = "filechooserbutton1";
		this.vbox2.Add (this.filechooserbutton1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.filechooserbutton1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.radioResource1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("1 project"));
		this.radioResource1.TooltipMarkup = "1 Project in a day";
		this.radioResource1.HeightRequest = 50;
		this.radioResource1.CanFocus = true;
		this.radioResource1.Name = "radioResource1";
		this.radioResource1.DrawIndicator = true;
		this.radioResource1.UseUnderline = true;
		this.radioResource1.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox1.Add (this.radioResource1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.radioResource1]));
		w6.Position = 0;
		w6.Padding = ((uint)(50));
		// Container child hbox1.Gtk.Box+BoxChild
		this.radioResource2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("2 projects"));
		this.radioResource2.TooltipMarkup = "2 projects in a day";
		this.radioResource2.CanFocus = true;
		this.radioResource2.Name = "radioResource2";
		this.radioResource2.DrawIndicator = true;
		this.radioResource2.UseUnderline = true;
		this.radioResource2.Group = this.radioResource1.Group;
		this.hbox1.Add (this.radioResource2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.radioResource2]));
		w7.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelClient1 = new global::Gtk.Label ();
		this.labelClient1.Name = "labelClient1";
		this.labelClient1.LabelProp = global::Mono.Unix.Catalog.GetString ("Please enter the first client name below.");
		this.labelClient1.Wrap = true;
		this.labelClient1.Justify = ((global::Gtk.Justification)(3));
		this.vbox1.Add (this.labelClient1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelClient1]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.vbox1.Add (this.entry1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry1]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelProject1 = new global::Gtk.Label ();
		this.labelProject1.Name = "labelProject1";
		this.labelProject1.LabelProp = global::Mono.Unix.Catalog.GetString ("Please enter the first project name below.");
		this.labelProject1.Wrap = true;
		this.vbox1.Add (this.labelProject1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelProject1]));
		w11.Position = 4;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.vbox1.Add (this.entry2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry2]));
		w12.Position = 5;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelClient2 = new global::Gtk.Label ();
		this.labelClient2.Name = "labelClient2";
		this.labelClient2.LabelProp = global::Mono.Unix.Catalog.GetString ("Please enter the second client name below. ");
		this.labelClient2.Wrap = true;
		this.vbox1.Add (this.labelClient2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelClient2]));
		w13.Position = 6;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.vbox1.Add (this.entry3);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry3]));
		w14.Position = 7;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelProject2 = new global::Gtk.Label ();
		this.labelProject2.Name = "labelProject2";
		this.labelProject2.LabelProp = global::Mono.Unix.Catalog.GetString ("Please enter the second project name below.");
		this.labelProject2.Wrap = true;
		this.vbox1.Add (this.labelProject2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelProject2]));
		w15.Position = 8;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.HeightRequest = 0;
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.vbox1.Add (this.entry4);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry4]));
		w16.Position = 9;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.buttonQuit = new global::Gtk.Button ();
		this.buttonQuit.TooltipMarkup = "Quit application";
		this.buttonQuit.WidthRequest = 100;
		this.buttonQuit.CanFocus = true;
		this.buttonQuit.Name = "buttonQuit";
		this.buttonQuit.UseUnderline = true;
		this.buttonQuit.Label = global::Mono.Unix.Catalog.GetString ("Quit");
		this.hbox2.Add (this.buttonQuit);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonQuit]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.hbox2.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hseparator1]));
		w18.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.buttonContinue = new global::Gtk.Button ();
		this.buttonContinue.TooltipMarkup = "Create client and project folders";
		this.buttonContinue.WidthRequest = 100;
		this.buttonContinue.CanFocus = true;
		this.buttonContinue.Name = "buttonContinue";
		this.buttonContinue.UseUnderline = true;
		this.buttonContinue.Label = global::Mono.Unix.Catalog.GetString ("Create Folders");
		this.hbox2.Add (this.buttonContinue);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonContinue]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w20.Position = 10;
		w20.Expand = false;
		w20.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 500;
		this.DefaultHeight = 500;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.radioResource2.Toggled += new global::System.EventHandler (this.OnRadioResource2Toggled);
		this.buttonQuit.Clicked += new global::System.EventHandler (this.OnButtonQuitClicked);
		this.buttonContinue.Clicked += new global::System.EventHandler (this.OnButtonContinueClicked);
	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace FoT
{
	public partial class EnvironmentChooser
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox9;
		private global::Gtk.ComboBox combobox2;
		private global::Gtk.ComboBox combobox4;
		private global::Gtk.ComboBox combobox3;
		private global::Gtk.HBox hbox3;
		private global::Gtk.VBox vbox10;
		private global::Gtk.VBox vbox13;
		private global::Gtk.RadioButton radiobutton6;
		private global::Gtk.RadioButton radiobutton7;
		private global::Gtk.RadioButton radiobutton11;
		private global::Gtk.VBox vbox12;
		private global::Gtk.RadioButton radiobutton12;
		private global::Gtk.RadioButton radiobutton15;
		private global::Gtk.RadioButton radiobutton16;
		private global::Gtk.VBox vbox11;
		private global::Gtk.VBox vbox15;
		private global::Gtk.RadioButton radiobutton8;
		private global::Gtk.RadioButton radiobutton9;
		private global::Gtk.RadioButton radiobutton10;
		private global::Gtk.VBox vbox14;
		private global::Gtk.RadioButton radiobutton13;
		private global::Gtk.RadioButton radiobutton14;
		private global::Gtk.RadioButton radiobutton17;
		private global::Gtk.VSeparator vseparator2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FoT.EnvironmentChooser
			this.WidthRequest = 600;
			this.Name = "FoT.EnvironmentChooser";
			this.Title = global::Mono.Unix.Catalog.GetString ("EnvironmentChooser");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child FoT.EnvironmentChooser.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.combobox2 = global::Gtk.ComboBox.NewText ();
			this.combobox2.WidthRequest = 585;
			this.combobox2.Name = "combobox2";
			this.vbox9.Add (this.combobox2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.combobox2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.combobox4 = global::Gtk.ComboBox.NewText ();
			this.combobox4.WidthRequest = 585;
			this.combobox4.Name = "combobox4";
			this.vbox9.Add (this.combobox4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.combobox4]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.combobox3 = global::Gtk.ComboBox.NewText ();
			this.combobox3.WidthRequest = 585;
			this.combobox3.Name = "combobox3";
			this.vbox9.Add (this.combobox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.combobox3]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox ();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.radiobutton6 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton6"));
			this.radiobutton6.CanFocus = true;
			this.radiobutton6.Name = "radiobutton6";
			this.radiobutton6.Active = false;
			this.radiobutton6.DrawIndicator = true;
			this.radiobutton6.UseUnderline = true;
			this.radiobutton6.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox13.Add (this.radiobutton6);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.radiobutton6]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.radiobutton7 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton7"));
			this.radiobutton7.CanFocus = true;
			this.radiobutton7.Name = "radiobutton7";
			this.radiobutton7.Active = false;
			this.radiobutton7.DrawIndicator = true;
			this.radiobutton7.UseUnderline = true;
			this.radiobutton7.Group = this.radiobutton6.Group;
			this.vbox13.Add (this.radiobutton7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.radiobutton7]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.radiobutton11 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton11"));
			this.radiobutton11.CanFocus = true;
			this.radiobutton11.Name = "radiobutton11";
			this.radiobutton11.Active = false;
			this.radiobutton11.DrawIndicator = true;
			this.radiobutton11.UseUnderline = true;
			this.radiobutton11.Group = this.radiobutton6.Group;
			this.vbox13.Add (this.radiobutton11);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.radiobutton11]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox10.Add (this.vbox13);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.vbox13]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox ();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.radiobutton12 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton12"));
			this.radiobutton12.CanFocus = true;
			this.radiobutton12.Name = "radiobutton12";
			this.radiobutton12.Active = false;
			this.radiobutton12.DrawIndicator = true;
			this.radiobutton12.UseUnderline = true;
			this.radiobutton12.Group = this.radiobutton6.Group;
			this.vbox12.Add (this.radiobutton12);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.radiobutton12]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.radiobutton15 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton15"));
			this.radiobutton15.CanFocus = true;
			this.radiobutton15.Name = "radiobutton15";
			this.radiobutton15.Active = false;
			this.radiobutton15.DrawIndicator = true;
			this.radiobutton15.UseUnderline = true;
			this.radiobutton15.Group = this.radiobutton6.Group;
			this.vbox12.Add (this.radiobutton15);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.radiobutton15]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.radiobutton16 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton16"));
			this.radiobutton16.CanFocus = true;
			this.radiobutton16.Name = "radiobutton16";
			this.radiobutton16.Active = false;
			this.radiobutton16.DrawIndicator = true;
			this.radiobutton16.UseUnderline = true;
			this.radiobutton16.Group = this.radiobutton6.Group;
			this.vbox12.Add (this.radiobutton16);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.radiobutton16]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox10.Add (this.vbox12);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.vbox12]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.hbox3.Add (this.vbox10);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox10]));
			w12.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox ();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox ();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.radiobutton8 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton8"));
			this.radiobutton8.CanFocus = true;
			this.radiobutton8.Name = "radiobutton8";
			this.radiobutton8.Active = false;
			this.radiobutton8.DrawIndicator = true;
			this.radiobutton8.UseUnderline = true;
			this.radiobutton8.Group = this.radiobutton6.Group;
			this.vbox15.Add (this.radiobutton8);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.radiobutton8]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.radiobutton9 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton9"));
			this.radiobutton9.CanFocus = true;
			this.radiobutton9.Name = "radiobutton9";
			this.radiobutton9.Active = false;
			this.radiobutton9.DrawIndicator = true;
			this.radiobutton9.UseUnderline = true;
			this.radiobutton9.Group = this.radiobutton6.Group;
			this.vbox15.Add (this.radiobutton9);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.radiobutton9]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.radiobutton10 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton10"));
			this.radiobutton10.CanFocus = true;
			this.radiobutton10.Name = "radiobutton10";
			this.radiobutton10.Active = false;
			this.radiobutton10.DrawIndicator = true;
			this.radiobutton10.UseUnderline = true;
			this.radiobutton10.Group = this.radiobutton6.Group;
			this.vbox15.Add (this.radiobutton10);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.radiobutton10]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox11.Add (this.vbox15);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.vbox15]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox ();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.radiobutton13 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton13"));
			this.radiobutton13.CanFocus = true;
			this.radiobutton13.Name = "radiobutton13";
			this.radiobutton13.Active = false;
			this.radiobutton13.DrawIndicator = true;
			this.radiobutton13.UseUnderline = true;
			this.radiobutton13.Group = this.radiobutton6.Group;
			this.vbox14.Add (this.radiobutton13);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.radiobutton13]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.radiobutton14 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton14"));
			this.radiobutton14.CanFocus = true;
			this.radiobutton14.Name = "radiobutton14";
			this.radiobutton14.Active = false;
			this.radiobutton14.DrawIndicator = true;
			this.radiobutton14.UseUnderline = true;
			this.radiobutton14.Group = this.radiobutton6.Group;
			this.vbox14.Add (this.radiobutton14);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.radiobutton14]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.radiobutton17 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("radiobutton17"));
			this.radiobutton17.CanFocus = true;
			this.radiobutton17.Name = "radiobutton17";
			this.radiobutton17.Active = false;
			this.radiobutton17.DrawIndicator = true;
			this.radiobutton17.UseUnderline = true;
			this.radiobutton17.Group = this.radiobutton6.Group;
			this.vbox14.Add (this.radiobutton17);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.radiobutton17]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox11.Add (this.vbox14);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.vbox14]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.hbox3.Add (this.vbox11);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox11]));
			w21.Position = 1;
			this.vbox9.Add (this.hbox3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox3]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox1.Add (this.vbox9);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox9]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add (this.vseparator2);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vseparator2]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 600;
			this.DefaultHeight = 300;
			this.Show ();
			this.combobox2.Changed += new global::System.EventHandler (this.OnCombobox2Changed);
		}
	}
}

// This file has been generated by the GUI designer. Do not modify.
namespace FoT
{
	public partial class EnvironmentChooser
	{
		private global::Gtk.HBox hbox26;
		private global::Gtk.VBox LeftSide1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView EnviroTree;
		private global::Gtk.HBox LeftSideLower1;
		private global::Gtk.Button button1;
		private global::Gtk.HSeparator hseparator3;
		private global::Gtk.Button button2;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Button button3;
		private global::Gtk.VBox RightSideAll1;
		private global::Gtk.HBox RightUpper1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView textview1;
		private global::Gtk.VBox RightSideControls1;
		private global::Gtk.VSeparator vseparator1;
		private global::Gtk.Button button4;
		private global::Gtk.Button button5;
		private global::Gtk.Button button6;
		private global::Gtk.VSeparator vseparator2;
		private global::Gtk.HBox RightSideLower1;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Button button7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FoT.EnvironmentChooser
			this.WidthRequest = 700;
			this.Name = "FoT.EnvironmentChooser";
			this.Title = global::Mono.Unix.Catalog.GetString ("EnvironmentChooser");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child FoT.EnvironmentChooser.Gtk.Container+ContainerChild
			this.hbox26 = new global::Gtk.HBox ();
			this.hbox26.Name = "hbox26";
			this.hbox26.Spacing = 6;
			// Container child hbox26.Gtk.Box+BoxChild
			this.LeftSide1 = new global::Gtk.VBox ();
			this.LeftSide1.Name = "LeftSide1";
			this.LeftSide1.Spacing = 6;
			// Container child LeftSide1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.EnviroTree = new global::Gtk.TreeView ();
			this.EnviroTree.WidthRequest = 300;
			this.EnviroTree.CanFocus = true;
			this.EnviroTree.Name = "EnviroTree";
			this.EnviroTree.EnableSearch = false;
			this.EnviroTree.RulesHint = true;
			this.GtkScrolledWindow.Add (this.EnviroTree);
			this.LeftSide1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.LeftSide1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child LeftSide1.Gtk.Box+BoxChild
			this.LeftSideLower1 = new global::Gtk.HBox ();
			this.LeftSideLower1.Name = "LeftSideLower1";
			this.LeftSideLower1.Spacing = 6;
			// Container child LeftSideLower1.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.WidthRequest = 100;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Quit");
			this.LeftSideLower1.Add (this.button1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.LeftSideLower1 [this.button1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child LeftSideLower1.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.LeftSideLower1.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.LeftSideLower1 [this.hseparator3]));
			w4.Position = 1;
			// Container child LeftSideLower1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.WidthRequest = 100;
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Clear all");
			this.LeftSideLower1.Add (this.button2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.LeftSideLower1 [this.button2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child LeftSideLower1.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.LeftSideLower1.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.LeftSideLower1 [this.hseparator2]));
			w6.Position = 3;
			// Container child LeftSideLower1.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.WidthRequest = 100;
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("Add Selected");
			this.LeftSideLower1.Add (this.button3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.LeftSideLower1 [this.button3]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			this.LeftSide1.Add (this.LeftSideLower1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.LeftSide1 [this.LeftSideLower1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox26.Add (this.LeftSide1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox26 [this.LeftSide1]));
			w9.Position = 0;
			// Container child hbox26.Gtk.Box+BoxChild
			this.RightSideAll1 = new global::Gtk.VBox ();
			this.RightSideAll1.Name = "RightSideAll1";
			this.RightSideAll1.Spacing = 6;
			// Container child RightSideAll1.Gtk.Box+BoxChild
			this.RightUpper1 = new global::Gtk.HBox ();
			this.RightUpper1.Name = "RightUpper1";
			this.RightUpper1.Spacing = 6;
			// Container child RightUpper1.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.LeftMargin = 5;
			this.textview1.Indent = 1;
			this.GtkScrolledWindow1.Add (this.textview1);
			this.RightUpper1.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.RightUpper1 [this.GtkScrolledWindow1]));
			w11.Position = 0;
			// Container child RightUpper1.Gtk.Box+BoxChild
			this.RightSideControls1 = new global::Gtk.VBox ();
			this.RightSideControls1.Name = "RightSideControls1";
			this.RightSideControls1.Spacing = 6;
			// Container child RightSideControls1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.RightSideControls1.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.RightSideControls1 [this.vseparator1]));
			w12.Position = 0;
			// Container child RightSideControls1.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button ();
			this.button4.WidthRequest = 150;
			this.button4.Sensitive = false;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString ("Remove Selected");
			this.RightSideControls1.Add (this.button4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.RightSideControls1 [this.button4]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child RightSideControls1.Gtk.Box+BoxChild
			this.button5 = new global::Gtk.Button ();
			this.button5.WidthRequest = 150;
			this.button5.Sensitive = false;
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString ("Primary Desktop");
			this.RightSideControls1.Add (this.button5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.RightSideControls1 [this.button5]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child RightSideControls1.Gtk.Box+BoxChild
			this.button6 = new global::Gtk.Button ();
			this.button6.WidthRequest = 150;
			this.button6.Sensitive = false;
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString ("Primary Device");
			this.RightSideControls1.Add (this.button6);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.RightSideControls1 [this.button6]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child RightSideControls1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.RightSideControls1.Add (this.vseparator2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.RightSideControls1 [this.vseparator2]));
			w16.Position = 4;
			this.RightUpper1.Add (this.RightSideControls1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.RightUpper1 [this.RightSideControls1]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.RightSideAll1.Add (this.RightUpper1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.RightSideAll1 [this.RightUpper1]));
			w18.Position = 0;
			// Container child RightSideAll1.Gtk.Box+BoxChild
			this.RightSideLower1 = new global::Gtk.HBox ();
			this.RightSideLower1.Name = "RightSideLower1";
			this.RightSideLower1.Spacing = 6;
			// Container child RightSideLower1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.RightSideLower1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.RightSideLower1 [this.hseparator1]));
			w19.Position = 0;
			// Container child RightSideLower1.Gtk.Box+BoxChild
			this.button7 = new global::Gtk.Button ();
			this.button7.WidthRequest = 150;
			this.button7.CanFocus = true;
			this.button7.Name = "button7";
			this.button7.UseUnderline = true;
			this.button7.Label = global::Mono.Unix.Catalog.GetString ("Continue");
			this.RightSideLower1.Add (this.button7);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.RightSideLower1 [this.button7]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.RightSideAll1.Add (this.RightSideLower1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.RightSideAll1 [this.RightSideLower1]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox26.Add (this.RightSideAll1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox26 [this.RightSideAll1]));
			w22.Position = 1;
			this.Add (this.hbox26);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1062;
			this.DefaultHeight = 607;
			this.Show ();
			this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}

// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.AddinAuthoring {
    
    
    public partial class SelectRepositoryDialog {
        
        private Gtk.VBox vbox4;
        
        private Gtk.Label label11;
        
        private Gtk.HBox hbox1;
        
        private Gtk.ScrolledWindow scrolledwindow4;
        
        private Gtk.TreeView tree;
        
        private Gtk.VBox vbox2;
        
        private Gtk.Button buttonAdd;
        
        private Gtk.Button buttonRemove;
        
        private Gtk.Button button155;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.AddinAuthoring.SelectRepositoryDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.AddinAuthoring.SelectRepositoryDialog";
            this.Title = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Select Add-in Registry");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child MonoDevelop.AddinAuthoring.SelectRepositoryDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            this.vbox4.BorderWidth = ((uint)(6));
            // Container child vbox4.Gtk.Box+BoxChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Select the add-in registry for the new add-in:");
            this.vbox4.Add(this.label11);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox4[this.label11]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.scrolledwindow4 = new Gtk.ScrolledWindow();
            this.scrolledwindow4.CanFocus = true;
            this.scrolledwindow4.Name = "scrolledwindow4";
            this.scrolledwindow4.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow4.Gtk.Container+ContainerChild
            this.tree = new Gtk.TreeView();
            this.tree.CanFocus = true;
            this.tree.Name = "tree";
            this.tree.HeadersVisible = false;
            this.tree.HeadersClickable = true;
            this.scrolledwindow4.Add(this.tree);
            this.hbox1.Add(this.scrolledwindow4);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.scrolledwindow4]));
            w4.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.buttonAdd = new Gtk.Button();
            this.buttonAdd.CanFocus = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseStock = true;
            this.buttonAdd.UseUnderline = true;
            this.buttonAdd.Label = "gtk-add";
            this.vbox2.Add(this.buttonAdd);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.buttonAdd]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.buttonRemove = new Gtk.Button();
            this.buttonRemove.CanFocus = true;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseStock = true;
            this.buttonRemove.UseUnderline = true;
            this.buttonRemove.Label = "gtk-remove";
            this.vbox2.Add(this.buttonRemove);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.buttonRemove]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.hbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox4.Add(this.hbox1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
            w8.Position = 1;
            w1.Add(this.vbox4);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.vbox4]));
            w9.Position = 0;
            // Internal child MonoDevelop.AddinAuthoring.SelectRepositoryDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "MonoDevelop.AddinAuthoring.SelectRepositoryDialog_ActionArea";
            w10.Spacing = 6;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.AddinAuthoring.SelectRepositoryDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button155 = new Gtk.Button();
            this.button155.CanDefault = true;
            this.button155.CanFocus = true;
            this.button155.Name = "button155";
            this.button155.UseStock = true;
            this.button155.UseUnderline = true;
            this.button155.Label = "gtk-cancel";
            this.AddActionWidget(this.button155, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.button155]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child MonoDevelop.AddinAuthoring.SelectRepositoryDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 575;
            this.DefaultHeight = 398;
            this.Show();
            this.buttonAdd.Clicked += new System.EventHandler(this.OnButtonAddClicked);
            this.buttonRemove.Clicked += new System.EventHandler(this.OnButtonRemoveClicked);
        }
    }
}

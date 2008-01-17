// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mono.Addins.Gui {
    
    
    internal partial class AddinManagerDialog {
        
        private Gtk.VBox vbox93;
        
        private Gtk.HBox hbox85;
        
        private Gtk.Image imageInstall;
        
        private Gtk.Label label144;
        
        private Gtk.HBox hbox73;
        
        private Gtk.Label label134;
        
        private Gtk.HBox hbox65;
        
        private Gtk.HBox hbox72;
        
        private Gtk.ScrolledWindow scrolledwindow13;
        
        private Gtk.TreeView addinTree;
        
        private Gtk.VBox vbox933;
        
        private Gtk.Button btnInstall;
        
        private Gtk.Button btnRepositories;
        
        private Gtk.HSeparator hseparator4;
        
        private Gtk.Button btnUninstall;
        
        private Gtk.Button btnEnable;
        
        private Gtk.Button btnDisable;
        
        private Gtk.Button btnInfo;
        
        private Gtk.Button btnClose;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Addins.Gui.AddinManagerDialog
            this.Name = "Mono.Addins.Gui.AddinManagerDialog";
            this.Title = Mono.Unix.Catalog.GetString("Add-in Manager");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.BorderWidth = ((uint)(6));
            this.DefaultWidth = 700;
            this.DefaultHeight = 550;
            // Internal child Mono.Addins.Gui.AddinManagerDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox8";
            w1.Spacing = 3;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox8.Gtk.Box+BoxChild
            this.vbox93 = new Gtk.VBox();
            this.vbox93.Name = "vbox93";
            this.vbox93.Spacing = 6;
            this.vbox93.BorderWidth = ((uint)(6));
            // Container child vbox93.Gtk.Box+BoxChild
            this.hbox85 = new Gtk.HBox();
            this.hbox85.Name = "hbox85";
            this.hbox85.Spacing = 12;
            // Container child hbox85.Gtk.Box+BoxChild
            this.imageInstall = new Gtk.Image();
            this.imageInstall.Name = "imageInstall";
            this.imageInstall.Yalign = 0F;
            this.imageInstall.Pixbuf = Gdk.Pixbuf.LoadFromResource("system-software-update.png");
            this.hbox85.Add(this.imageInstall);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox85[this.imageInstall]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox85.Gtk.Box+BoxChild
            this.label144 = new Gtk.Label();
            this.label144.Name = "label144";
            this.label144.LabelProp = Mono.Unix.Catalog.GetString("<big><b>Add-in Manager</b></big>");
            this.label144.UseMarkup = true;
            this.hbox85.Add(this.label144);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox85[this.label144]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox93.Add(this.hbox85);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox93[this.hbox85]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox93.Gtk.Box+BoxChild
            this.hbox73 = new Gtk.HBox();
            this.hbox73.Name = "hbox73";
            this.hbox73.Spacing = 12;
            // Container child hbox73.Gtk.Box+BoxChild
            this.label134 = new Gtk.Label();
            this.label134.Name = "label134";
            this.label134.Xalign = 0F;
            this.label134.LabelProp = Mono.Unix.Catalog.GetString("The following add-ins are currently installed:");
            this.hbox73.Add(this.label134);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox73[this.label134]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox93.Add(this.hbox73);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox93[this.hbox73]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox93.Gtk.Box+BoxChild
            this.hbox65 = new Gtk.HBox();
            this.hbox65.Name = "hbox65";
            this.hbox65.Spacing = 12;
            // Container child hbox65.Gtk.Box+BoxChild
            this.hbox72 = new Gtk.HBox();
            this.hbox72.Name = "hbox72";
            this.hbox72.Spacing = 12;
            // Container child hbox72.Gtk.Box+BoxChild
            this.scrolledwindow13 = new Gtk.ScrolledWindow();
            this.scrolledwindow13.CanFocus = true;
            this.scrolledwindow13.Name = "scrolledwindow13";
            this.scrolledwindow13.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow13.Gtk.Container+ContainerChild
            this.addinTree = new Gtk.TreeView();
            this.addinTree.CanFocus = true;
            this.addinTree.Name = "addinTree";
            this.addinTree.HeadersClickable = true;
            this.scrolledwindow13.Add(this.addinTree);
            this.hbox72.Add(this.scrolledwindow13);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox72[this.scrolledwindow13]));
            w8.Position = 0;
            // Container child hbox72.Gtk.Box+BoxChild
            this.vbox933 = new Gtk.VBox();
            this.vbox933.Name = "vbox933";
            this.vbox933.Spacing = 5;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnInstall = new Gtk.Button();
            this.btnInstall.CanFocus = true;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.UseUnderline = true;
            // Container child btnInstall.Gtk.Container+ContainerChild
            Gtk.Alignment w9 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w10 = new Gtk.HBox();
            w10.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w11 = new Gtk.Image();
            w11.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-add", Gtk.IconSize.Button, 20);
            w10.Add(w11);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w13 = new Gtk.Label();
            w13.LabelProp = Mono.Unix.Catalog.GetString("_Install Add-ins...");
            w13.UseUnderline = true;
            w10.Add(w13);
            w9.Add(w10);
            this.btnInstall.Add(w9);
            this.vbox933.Add(this.btnInstall);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnInstall]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnRepositories = new Gtk.Button();
            this.btnRepositories.CanFocus = true;
            this.btnRepositories.Name = "btnRepositories";
            this.btnRepositories.UseUnderline = true;
            this.btnRepositories.Label = Mono.Unix.Catalog.GetString("_Repositories...");
            this.vbox933.Add(this.btnRepositories);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnRepositories]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.hseparator4 = new Gtk.HSeparator();
            this.hseparator4.Name = "hseparator4";
            this.vbox933.Add(this.hseparator4);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox933[this.hseparator4]));
            w19.Position = 2;
            w19.Expand = false;
            w19.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnUninstall = new Gtk.Button();
            this.btnUninstall.CanFocus = true;
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.UseUnderline = true;
            // Container child btnUninstall.Gtk.Container+ContainerChild
            Gtk.Alignment w20 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            Gtk.HBox w21 = new Gtk.HBox();
            w21.Spacing = 2;
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Image w22 = new Gtk.Image();
            w22.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-remove", Gtk.IconSize.Button, 20);
            w21.Add(w22);
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Label w24 = new Gtk.Label();
            w24.LabelProp = Mono.Unix.Catalog.GetString("_Uninstall...");
            w24.UseUnderline = true;
            w21.Add(w24);
            w20.Add(w21);
            this.btnUninstall.Add(w20);
            this.vbox933.Add(this.btnUninstall);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnUninstall]));
            w28.Position = 3;
            w28.Expand = false;
            w28.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnEnable = new Gtk.Button();
            this.btnEnable.CanFocus = true;
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.UseUnderline = true;
            // Container child btnEnable.Gtk.Container+ContainerChild
            Gtk.Alignment w29 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            Gtk.HBox w30 = new Gtk.HBox();
            w30.Spacing = 2;
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Image w31 = new Gtk.Image();
            w31.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-yes", Gtk.IconSize.Button, 20);
            w30.Add(w31);
            // Container child GtkHBox2.Gtk.Container+ContainerChild
            Gtk.Label w33 = new Gtk.Label();
            w33.LabelProp = Mono.Unix.Catalog.GetString("Enable");
            w33.UseUnderline = true;
            w30.Add(w33);
            w29.Add(w30);
            this.btnEnable.Add(w29);
            this.vbox933.Add(this.btnEnable);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnEnable]));
            w37.Position = 4;
            w37.Expand = false;
            w37.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnDisable = new Gtk.Button();
            this.btnDisable.CanFocus = true;
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.UseUnderline = true;
            // Container child btnDisable.Gtk.Container+ContainerChild
            Gtk.Alignment w38 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment3.Gtk.Container+ContainerChild
            Gtk.HBox w39 = new Gtk.HBox();
            w39.Spacing = 2;
            // Container child GtkHBox3.Gtk.Container+ContainerChild
            Gtk.Image w40 = new Gtk.Image();
            w40.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-no", Gtk.IconSize.Button, 20);
            w39.Add(w40);
            // Container child GtkHBox3.Gtk.Container+ContainerChild
            Gtk.Label w42 = new Gtk.Label();
            w42.LabelProp = Mono.Unix.Catalog.GetString("Disable");
            w42.UseUnderline = true;
            w39.Add(w42);
            w38.Add(w39);
            this.btnDisable.Add(w38);
            this.vbox933.Add(this.btnDisable);
            Gtk.Box.BoxChild w46 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnDisable]));
            w46.Position = 5;
            w46.Expand = false;
            w46.Fill = false;
            // Container child vbox933.Gtk.Box+BoxChild
            this.btnInfo = new Gtk.Button();
            this.btnInfo.CanFocus = true;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseStock = true;
            this.btnInfo.UseUnderline = true;
            this.btnInfo.Label = "gtk-dialog-info";
            this.vbox933.Add(this.btnInfo);
            Gtk.Box.BoxChild w47 = ((Gtk.Box.BoxChild)(this.vbox933[this.btnInfo]));
            w47.Position = 6;
            w47.Expand = false;
            w47.Fill = false;
            this.hbox72.Add(this.vbox933);
            Gtk.Box.BoxChild w48 = ((Gtk.Box.BoxChild)(this.hbox72[this.vbox933]));
            w48.Position = 1;
            w48.Expand = false;
            w48.Fill = false;
            this.hbox65.Add(this.hbox72);
            Gtk.Box.BoxChild w49 = ((Gtk.Box.BoxChild)(this.hbox65[this.hbox72]));
            w49.Position = 0;
            this.vbox93.Add(this.hbox65);
            Gtk.Box.BoxChild w50 = ((Gtk.Box.BoxChild)(this.vbox93[this.hbox65]));
            w50.Position = 2;
            w1.Add(this.vbox93);
            Gtk.Box.BoxChild w51 = ((Gtk.Box.BoxChild)(w1[this.vbox93]));
            w51.Position = 0;
            // Internal child Mono.Addins.Gui.AddinManagerDialog.ActionArea
            Gtk.HButtonBox w52 = this.ActionArea;
            w52.Name = "dialog-action_area8";
            w52.Spacing = 10;
            w52.BorderWidth = ((uint)(5));
            w52.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area8.Gtk.ButtonBox+ButtonBoxChild
            this.btnClose = new Gtk.Button();
            this.btnClose.CanDefault = true;
            this.btnClose.CanFocus = true;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseStock = true;
            this.btnClose.UseUnderline = true;
            this.btnClose.Label = "gtk-close";
            this.AddActionWidget(this.btnClose, -7);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.addinTree.CursorChanged += new System.EventHandler(this.OnSelectionChanged);
            this.btnInstall.Clicked += new System.EventHandler(this.OnInstall);
            this.btnRepositories.Clicked += new System.EventHandler(this.OnManageRepos);
            this.btnUninstall.Clicked += new System.EventHandler(this.OnUninstall);
            this.btnEnable.Clicked += new System.EventHandler(this.OnEnable);
            this.btnDisable.Clicked += new System.EventHandler(this.OnDisable);
            this.btnInfo.Clicked += new System.EventHandler(this.OnShowInfo);
        }
    }
}

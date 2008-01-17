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
    
    
    internal partial class AddinInstallDialog {
        
        private Gtk.Notebook wizardNotebook;
        
        private Gtk.VBox vbox82;
        
        private Gtk.Label label113;
        
        private Gtk.HBox hbox66;
        
        private Gtk.Label label112;
        
        private Gtk.ComboBox repoCombo;
        
        private Gtk.Button button1;
        
        private Gtk.Button btnManageSites;
        
        private Gtk.HBox hbox70;
        
        private Gtk.VBox vbox92;
        
        private Gtk.ScrolledWindow scrolledwindow18;
        
        private Gtk.TreeView addinTree;
        
        private Gtk.HBox hbox83;
        
        private Gtk.ComboBox filterComboBox;
        
        private Gtk.Button btnInfo;
        
        private Gtk.Button btnUnselectAll;
        
        private Gtk.Button btnSelectAll;
        
        private Gtk.Label label108;
        
        private Gtk.ScrolledWindow scrolledwindow19;
        
        private Gtk.HBox hbox82;
        
        private Gtk.Image imageInstall;
        
        private Gtk.Label labelSummary;
        
        private Gtk.Label label124;
        
        private Gtk.VBox vbox86;
        
        private Gtk.Label label1;
        
        private Gtk.Label globalProgressLabel;
        
        private Gtk.ProgressBar mainProgressBar;
        
        private Gtk.Label label2;
        
        private Gtk.Label label110;
        
        private Gtk.ScrolledWindow scrolledwindow20;
        
        private Gtk.VBox vbox91;
        
        private Gtk.Label label130;
        
        private Gtk.Image imageError;
        
        private Gtk.Image imageWarn;
        
        private Gtk.Image imageInfo;
        
        private Gtk.HBox hbox71;
        
        private Gtk.Label labelResult;
        
        private Gtk.Label label131;
        
        private Gtk.Label label111;
        
        private Gtk.HButtonBox dialog_action_area9;
        
        private Gtk.Button btnCancel;
        
        private Gtk.Button btnPrev;
        
        private Gtk.Button btnNext;
        
        private Gtk.Button btnOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Addins.Gui.AddinInstallDialog
            this.Name = "Mono.Addins.Gui.AddinInstallDialog";
            this.Title = Mono.Unix.Catalog.GetString("Add-in Installation");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.DefaultWidth = 725;
            this.DefaultHeight = 550;
            // Internal child Mono.Addins.Gui.AddinInstallDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox9";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox9.Gtk.Box+BoxChild
            this.wizardNotebook = new Gtk.Notebook();
            this.wizardNotebook.CanFocus = true;
            this.wizardNotebook.Name = "wizardNotebook";
            this.wizardNotebook.CurrentPage = 0;
            this.wizardNotebook.ShowBorder = false;
            this.wizardNotebook.BorderWidth = ((uint)(6));
            // Container child wizardNotebook.Gtk.Notebook+NotebookChild
            this.vbox82 = new Gtk.VBox();
            this.vbox82.Name = "vbox82";
            this.vbox82.Spacing = 12;
            // Container child vbox82.Gtk.Box+BoxChild
            this.label113 = new Gtk.Label();
            this.label113.Name = "label113";
            this.label113.Xalign = 0F;
            this.label113.LabelProp = Mono.Unix.Catalog.GetString("<b>Select the add-ins to install and click on Next</b>");
            this.label113.UseMarkup = true;
            this.vbox82.Add(this.label113);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox82[this.label113]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox82.Gtk.Box+BoxChild
            this.hbox66 = new Gtk.HBox();
            this.hbox66.Name = "hbox66";
            this.hbox66.Spacing = 6;
            // Container child hbox66.Gtk.Box+BoxChild
            this.label112 = new Gtk.Label();
            this.label112.Name = "label112";
            this.label112.LabelProp = Mono.Unix.Catalog.GetString("Install from:");
            this.hbox66.Add(this.label112);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox66[this.label112]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox66.Gtk.Box+BoxChild
            this.repoCombo = new Gtk.ComboBox();
            this.repoCombo.Name = "repoCombo";
            this.hbox66.Add(this.repoCombo);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox66[this.repoCombo]));
            w4.Position = 1;
            // Container child hbox66.Gtk.Box+BoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseStock = true;
            this.button1.UseUnderline = true;
            this.button1.Label = "gtk-refresh";
            this.hbox66.Add(this.button1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox66[this.button1]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbox66.Gtk.Box+BoxChild
            this.btnManageSites = new Gtk.Button();
            this.btnManageSites.CanFocus = true;
            this.btnManageSites.Name = "btnManageSites";
            this.btnManageSites.UseUnderline = true;
            this.btnManageSites.Label = Mono.Unix.Catalog.GetString("_Repositories...");
            this.hbox66.Add(this.btnManageSites);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox66[this.btnManageSites]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            this.vbox82.Add(this.hbox66);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox82[this.hbox66]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox82.Gtk.Box+BoxChild
            this.hbox70 = new Gtk.HBox();
            this.hbox70.Name = "hbox70";
            this.hbox70.Spacing = 12;
            // Container child hbox70.Gtk.Box+BoxChild
            this.vbox92 = new Gtk.VBox();
            this.vbox92.Name = "vbox92";
            this.vbox92.Spacing = 6;
            // Container child vbox92.Gtk.Box+BoxChild
            this.scrolledwindow18 = new Gtk.ScrolledWindow();
            this.scrolledwindow18.CanFocus = true;
            this.scrolledwindow18.Name = "scrolledwindow18";
            this.scrolledwindow18.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow18.Gtk.Container+ContainerChild
            this.addinTree = new Gtk.TreeView();
            this.addinTree.CanFocus = true;
            this.addinTree.Name = "addinTree";
            this.addinTree.HeadersClickable = true;
            this.scrolledwindow18.Add(this.addinTree);
            this.vbox92.Add(this.scrolledwindow18);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox92[this.scrolledwindow18]));
            w9.Position = 0;
            // Container child vbox92.Gtk.Box+BoxChild
            this.hbox83 = new Gtk.HBox();
            this.hbox83.Name = "hbox83";
            this.hbox83.Spacing = 6;
            // Container child hbox83.Gtk.Box+BoxChild
            this.filterComboBox = Gtk.ComboBox.NewText();
            this.filterComboBox.AppendText(Mono.Unix.Catalog.GetString("Show all packages"));
            this.filterComboBox.AppendText(Mono.Unix.Catalog.GetString("Show new versions only"));
            this.filterComboBox.AppendText(Mono.Unix.Catalog.GetString("Show updates only"));
            this.filterComboBox.Name = "filterComboBox";
            this.hbox83.Add(this.filterComboBox);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox83[this.filterComboBox]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child hbox83.Gtk.Box+BoxChild
            this.btnInfo = new Gtk.Button();
            this.btnInfo.CanFocus = true;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseStock = true;
            this.btnInfo.UseUnderline = true;
            this.btnInfo.Label = "gtk-dialog-info";
            this.hbox83.Add(this.btnInfo);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox83[this.btnInfo]));
            w11.PackType = ((Gtk.PackType)(1));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox83.Gtk.Box+BoxChild
            this.btnUnselectAll = new Gtk.Button();
            this.btnUnselectAll.CanFocus = true;
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.UseUnderline = true;
            this.btnUnselectAll.Label = Mono.Unix.Catalog.GetString("_Unselect All");
            this.hbox83.Add(this.btnUnselectAll);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox83[this.btnUnselectAll]));
            w12.PackType = ((Gtk.PackType)(1));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child hbox83.Gtk.Box+BoxChild
            this.btnSelectAll = new Gtk.Button();
            this.btnSelectAll.CanFocus = true;
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.UseUnderline = true;
            this.btnSelectAll.Label = Mono.Unix.Catalog.GetString("Select _All");
            this.hbox83.Add(this.btnSelectAll);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox83[this.btnSelectAll]));
            w13.PackType = ((Gtk.PackType)(1));
            w13.Position = 3;
            w13.Expand = false;
            w13.Fill = false;
            this.vbox92.Add(this.hbox83);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox92[this.hbox83]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            this.hbox70.Add(this.vbox92);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox70[this.vbox92]));
            w15.Position = 0;
            this.vbox82.Add(this.hbox70);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox82[this.hbox70]));
            w16.Position = 2;
            this.wizardNotebook.Add(this.vbox82);
            // Notebook tab
            this.label108 = new Gtk.Label();
            this.label108.Name = "label108";
            this.label108.LabelProp = "label108";
            this.wizardNotebook.SetTabLabel(this.vbox82, this.label108);
            this.label108.ShowAll();
            // Container child wizardNotebook.Gtk.Notebook+NotebookChild
            this.scrolledwindow19 = new Gtk.ScrolledWindow();
            this.scrolledwindow19.CanFocus = true;
            this.scrolledwindow19.Name = "scrolledwindow19";
            // Container child scrolledwindow19.Gtk.Container+ContainerChild
            Gtk.Viewport w18 = new Gtk.Viewport();
            // Container child viewport1.Gtk.Container+ContainerChild
            this.hbox82 = new Gtk.HBox();
            this.hbox82.Name = "hbox82";
            this.hbox82.Spacing = 12;
            this.hbox82.BorderWidth = ((uint)(12));
            // Container child hbox82.Gtk.Box+BoxChild
            this.imageInstall = new Gtk.Image();
            this.imageInstall.Name = "imageInstall";
            this.imageInstall.Xalign = 0F;
            this.imageInstall.Yalign = 0F;
            this.imageInstall.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", Gtk.IconSize.Dialog, 48);
            this.hbox82.Add(this.imageInstall);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox82[this.imageInstall]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Container child hbox82.Gtk.Box+BoxChild
            this.labelSummary = new Gtk.Label();
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Xpad = 6;
            this.labelSummary.Ypad = 6;
            this.labelSummary.Xalign = 0F;
            this.labelSummary.Yalign = 0F;
            this.labelSummary.LabelProp = "<b>The following add-ins will be installed:</b>\n\nC# language binding\nC# language IDE extension\n\n<b>The following add-ins are required by the selected add-ins</b>\n\nNUnit add-in\nNAnt add-in\n\nasd\nasd\na\nsd\nasd\nasd\na\nsda\nsd\nas\nda\nsd\nasd\n";
            this.labelSummary.UseMarkup = true;
            this.labelSummary.Wrap = true;
            this.hbox82.Add(this.labelSummary);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox82[this.labelSummary]));
            w20.Position = 1;
            w20.Expand = false;
            w20.Fill = false;
            w18.Add(this.hbox82);
            this.scrolledwindow19.Add(w18);
            this.wizardNotebook.Add(this.scrolledwindow19);
            Gtk.Notebook.NotebookChild w23 = ((Gtk.Notebook.NotebookChild)(this.wizardNotebook[this.scrolledwindow19]));
            w23.Position = 1;
            // Notebook tab
            this.label124 = new Gtk.Label();
            this.label124.Name = "label124";
            this.label124.LabelProp = Mono.Unix.Catalog.GetString("label124");
            this.wizardNotebook.SetTabLabel(this.scrolledwindow19, this.label124);
            this.label124.ShowAll();
            // Container child wizardNotebook.Gtk.Notebook+NotebookChild
            this.vbox86 = new Gtk.VBox();
            this.vbox86.Name = "vbox86";
            this.vbox86.Spacing = 6;
            this.vbox86.BorderWidth = ((uint)(61));
            // Container child vbox86.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = "";
            this.vbox86.Add(this.label1);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox86[this.label1]));
            w24.Position = 0;
            // Container child vbox86.Gtk.Box+BoxChild
            this.globalProgressLabel = new Gtk.Label();
            this.globalProgressLabel.Name = "globalProgressLabel";
            this.globalProgressLabel.Xalign = 0F;
            this.globalProgressLabel.LabelProp = Mono.Unix.Catalog.GetString("Overall Progress:");
            this.globalProgressLabel.Ellipsize = ((Pango.EllipsizeMode)(3));
            this.vbox86.Add(this.globalProgressLabel);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox86[this.globalProgressLabel]));
            w25.Position = 1;
            w25.Expand = false;
            w25.Fill = false;
            // Container child vbox86.Gtk.Box+BoxChild
            this.mainProgressBar = new Gtk.ProgressBar();
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.PulseStep = 10000000149;
            this.vbox86.Add(this.mainProgressBar);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox86[this.mainProgressBar]));
            w26.Position = 2;
            w26.Expand = false;
            w26.Fill = false;
            // Container child vbox86.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = "";
            this.vbox86.Add(this.label2);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vbox86[this.label2]));
            w27.Position = 3;
            this.wizardNotebook.Add(this.vbox86);
            Gtk.Notebook.NotebookChild w28 = ((Gtk.Notebook.NotebookChild)(this.wizardNotebook[this.vbox86]));
            w28.Position = 2;
            // Notebook tab
            this.label110 = new Gtk.Label();
            this.label110.Name = "label110";
            this.label110.LabelProp = "label110";
            this.wizardNotebook.SetTabLabel(this.vbox86, this.label110);
            this.label110.ShowAll();
            // Container child wizardNotebook.Gtk.Notebook+NotebookChild
            this.scrolledwindow20 = new Gtk.ScrolledWindow();
            this.scrolledwindow20.CanFocus = true;
            this.scrolledwindow20.Name = "scrolledwindow20";
            // Container child scrolledwindow20.Gtk.Container+ContainerChild
            Gtk.Viewport w29 = new Gtk.Viewport();
            // Container child viewport3.Gtk.Container+ContainerChild
            this.vbox91 = new Gtk.VBox();
            this.vbox91.Name = "vbox91";
            // Container child vbox91.Gtk.Box+BoxChild
            this.label130 = new Gtk.Label();
            this.label130.Name = "label130";
            this.label130.LabelProp = "";
            this.vbox91.Add(this.label130);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vbox91[this.label130]));
            w30.Position = 0;
            // Container child vbox91.Gtk.Box+BoxChild
            this.imageError = new Gtk.Image();
            this.imageError.Name = "imageError";
            this.imageError.Yalign = 1F;
            this.imageError.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", Gtk.IconSize.Dialog, 48);
            this.vbox91.Add(this.imageError);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.vbox91[this.imageError]));
            w31.Position = 1;
            w31.Expand = false;
            w31.Fill = false;
            w31.Padding = ((uint)(5));
            // Container child vbox91.Gtk.Box+BoxChild
            this.imageWarn = new Gtk.Image();
            this.imageWarn.Name = "imageWarn";
            this.imageWarn.Yalign = 1F;
            this.imageWarn.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-warning", Gtk.IconSize.Dialog, 48);
            this.vbox91.Add(this.imageWarn);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.vbox91[this.imageWarn]));
            w32.Position = 2;
            w32.Expand = false;
            w32.Fill = false;
            // Container child vbox91.Gtk.Box+BoxChild
            this.imageInfo = new Gtk.Image();
            this.imageInfo.Name = "imageInfo";
            this.imageInfo.Yalign = 1F;
            this.imageInfo.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", Gtk.IconSize.Dialog, 48);
            this.vbox91.Add(this.imageInfo);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.vbox91[this.imageInfo]));
            w33.Position = 3;
            w33.Expand = false;
            w33.Fill = false;
            // Container child vbox91.Gtk.Box+BoxChild
            this.hbox71 = new Gtk.HBox();
            this.hbox71.Name = "hbox71";
            // Container child hbox71.Gtk.Box+BoxChild
            this.labelResult = new Gtk.Label();
            this.labelResult.WidthRequest = 450;
            this.labelResult.Name = "labelResult";
            this.labelResult.Ypad = 9;
            this.labelResult.Yalign = 0F;
            this.labelResult.LabelProp = "Done";
            this.labelResult.UseMarkup = true;
            this.labelResult.Wrap = true;
            this.labelResult.Justify = ((Gtk.Justification)(2));
            this.hbox71.Add(this.labelResult);
            Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(this.hbox71[this.labelResult]));
            w34.PackType = ((Gtk.PackType)(1));
            w34.Position = 0;
            this.vbox91.Add(this.hbox71);
            Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(this.vbox91[this.hbox71]));
            w35.Position = 4;
            w35.Expand = false;
            w35.Fill = false;
            // Container child vbox91.Gtk.Box+BoxChild
            this.label131 = new Gtk.Label();
            this.label131.Name = "label131";
            this.label131.LabelProp = "";
            this.vbox91.Add(this.label131);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.vbox91[this.label131]));
            w36.Position = 5;
            w29.Add(this.vbox91);
            this.scrolledwindow20.Add(w29);
            this.wizardNotebook.Add(this.scrolledwindow20);
            Gtk.Notebook.NotebookChild w39 = ((Gtk.Notebook.NotebookChild)(this.wizardNotebook[this.scrolledwindow20]));
            w39.Position = 3;
            // Notebook tab
            this.label111 = new Gtk.Label();
            this.label111.Name = "label111";
            this.label111.LabelProp = "label111";
            this.wizardNotebook.SetTabLabel(this.scrolledwindow20, this.label111);
            this.label111.ShowAll();
            w1.Add(this.wizardNotebook);
            Gtk.Box.BoxChild w40 = ((Gtk.Box.BoxChild)(w1[this.wizardNotebook]));
            w40.Position = 0;
            // Container child dialog-vbox9.Gtk.Box+BoxChild
            this.dialog_action_area9 = new Gtk.HButtonBox();
            this.dialog_action_area9.Name = "dialog_action_area9";
            this.dialog_action_area9.Spacing = 9;
            this.dialog_action_area9.BorderWidth = ((uint)(6));
            this.dialog_action_area9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog_action_area9.Gtk.ButtonBox+ButtonBoxChild
            this.btnCancel = new Gtk.Button();
            this.btnCancel.CanDefault = true;
            this.btnCancel.CanFocus = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseStock = true;
            this.btnCancel.UseUnderline = true;
            this.btnCancel.Label = "gtk-cancel";
            this.dialog_action_area9.Add(this.btnCancel);
            // Container child dialog_action_area9.Gtk.ButtonBox+ButtonBoxChild
            this.btnPrev = new Gtk.Button();
            this.btnPrev.CanDefault = true;
            this.btnPrev.CanFocus = true;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.UseStock = true;
            this.btnPrev.UseUnderline = true;
            this.btnPrev.Label = "gtk-go-back";
            this.dialog_action_area9.Add(this.btnPrev);
            Gtk.ButtonBox.ButtonBoxChild w42 = ((Gtk.ButtonBox.ButtonBoxChild)(this.dialog_action_area9[this.btnPrev]));
            w42.Position = 1;
            // Container child dialog_action_area9.Gtk.ButtonBox+ButtonBoxChild
            this.btnNext = new Gtk.Button();
            this.btnNext.CanDefault = true;
            this.btnNext.CanFocus = true;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseStock = true;
            this.btnNext.UseUnderline = true;
            this.btnNext.Label = "gtk-go-forward";
            this.dialog_action_area9.Add(this.btnNext);
            Gtk.ButtonBox.ButtonBoxChild w43 = ((Gtk.ButtonBox.ButtonBoxChild)(this.dialog_action_area9[this.btnNext]));
            w43.Position = 2;
            // Container child dialog_action_area9.Gtk.ButtonBox+ButtonBoxChild
            this.btnOk = new Gtk.Button();
            this.btnOk.CanDefault = true;
            this.btnOk.CanFocus = true;
            this.btnOk.Name = "btnOk";
            this.btnOk.UseStock = true;
            this.btnOk.UseUnderline = true;
            this.btnOk.Label = "gtk-ok";
            this.dialog_action_area9.Add(this.btnOk);
            Gtk.ButtonBox.ButtonBoxChild w44 = ((Gtk.ButtonBox.ButtonBoxChild)(this.dialog_action_area9[this.btnOk]));
            w44.Position = 3;
            w1.Add(this.dialog_action_area9);
            Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(w1[this.dialog_action_area9]));
            w45.PackType = ((Gtk.PackType)(1));
            w45.Position = 2;
            w45.Expand = false;
            w45.Fill = false;
            // Internal child Mono.Addins.Gui.AddinInstallDialog.ActionArea
            Gtk.HButtonBox w46 = this.ActionArea;
            w46.Name = "hbuttonbox1";
            w46.Spacing = 6;
            w46.BorderWidth = ((uint)(5));
            w46.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.btnOk.Hide();
            w46.Hide();
            this.Show();
            this.repoCombo.Changed += new System.EventHandler(this.OnRepoChanged);
            this.button1.Clicked += new System.EventHandler(this.OnUpdateRepo);
            this.btnManageSites.Clicked += new System.EventHandler(this.OnManageSites);
            this.addinTree.CursorChanged += new System.EventHandler(this.OnActiveAddinChanged);
            this.filterComboBox.Changed += new System.EventHandler(this.OnFilterChanged);
            this.btnSelectAll.Clicked += new System.EventHandler(this.OnSelectAll);
            this.btnUnselectAll.Clicked += new System.EventHandler(this.OnUnselectAll);
            this.btnInfo.Clicked += new System.EventHandler(this.OnShowInfo);
            this.btnCancel.Clicked += new System.EventHandler(this.OnCancel);
            this.btnPrev.Clicked += new System.EventHandler(this.OnPrevPage);
            this.btnNext.Clicked += new System.EventHandler(this.OnNextPage);
            this.btnOk.Clicked += new System.EventHandler(this.OnOk);
        }
    }
}

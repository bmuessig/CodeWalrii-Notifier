
// This file has been generated by the GUI designer. Do not modify.
namespace CodeWalriiNotify
{
	public partial class SettingsDialog
	{
		private global::Gtk.Notebook tabControl;
		
		private global::Gtk.ScrolledWindow notifierScroll;
		
		private global::Gtk.Table notifierTable;
		
		private global::Gtk.FileChooserButton audioFileSel;
		
		private global::Gtk.Label audioFileSelLbl;
		
		private global::Gtk.CheckButton audioNotifyCb;
		
		private global::Gtk.Label audioNotifyCbLbl;
		
		private global::Gtk.Entry feedTitleTxt;
		
		private global::Gtk.Label feedUrlTxLbl;
		
		private global::Gtk.Entry feedUrlTxt;
		
		private global::Gtk.FileChooserButton iconFileSel;
		
		private global::Gtk.Label iconFileSelLbl;
		
		private global::Gtk.Label maxPostsDcLbl;
		
		private global::Gtk.SpinButton maxPostsDec;
		
		private global::Gtk.Label queryIntervalDcLbl;
		
		private global::Gtk.SpinButton queryIntervalDec;
		
		private global::Gtk.Label serverNameTxLbl;
		
		private global::Gtk.CheckButton visualNotifyCb;
		
		private global::Gtk.Label visualNotifyCbLbl;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.ScrolledWindow styleScroll;
		
		private global::Gtk.Table styleTable;
		
		private global::Gtk.Label authorFgClLbl;
		
		private global::Gtk.ColorButton authorFgColorBtn;
		
		private global::Gtk.CheckButton bodyAntiAliasCb;
		
		private global::Gtk.Label bodyAntiAliasCbLbl;
		
		private global::Gtk.Label bodyBgClLbl;
		
		private global::Gtk.ColorButton bodyBgColorBtn;
		
		private global::Gtk.ScrolledWindow bodyFormatScroll;
		
		private global::Gtk.TextView bodyFormatTxt;
		
		private global::Gtk.Label bodyFormatTxLbl;
		
		private global::Gtk.Label detailFnLbl;
		
		private global::Gtk.FontButton detailFontBtn;
		
		private global::Gtk.Label footerBgClLbl;
		
		private global::Gtk.ColorButton footerBgColorBtn;
		
		private global::Gtk.Label headerBgClLbl;
		
		private global::Gtk.ColorButton headerBgColorBtn;
		
		private global::Gtk.Label timeFgClLbl;
		
		private global::Gtk.ColorButton timeFgColorBtn;
		
		private global::Gtk.Label titleFgClLbl;
		
		private global::Gtk.ColorButton titleFgColorBtn;
		
		private global::Gtk.Label titleFnLbl;
		
		private global::Gtk.FontButton titleFontBtn;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Button cancelButton;
		
		private global::Gtk.Button defaultsButton;
		
		private global::Gtk.Button okButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CodeWalriiNotify.SettingsDialog
			this.Name = "CodeWalriiNotify.SettingsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Dnd);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child CodeWalriiNotify.SettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialogVbox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialogVbox.Gtk.Box+BoxChild
			this.tabControl = new global::Gtk.Notebook ();
			this.tabControl.CanFocus = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.CurrentPage = 0;
			// Container child tabControl.Gtk.Notebook+NotebookChild
			this.notifierScroll = new global::Gtk.ScrolledWindow ();
			this.notifierScroll.CanFocus = true;
			this.notifierScroll.Name = "notifierScroll";
			this.notifierScroll.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.notifierScroll.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.notifierScroll.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child notifierScroll.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.notifierTable = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.notifierTable.Name = "notifierTable";
			this.notifierTable.RowSpacing = ((uint)(6));
			this.notifierTable.ColumnSpacing = ((uint)(6));
			this.notifierTable.BorderWidth = ((uint)(6));
			// Container child notifierTable.Gtk.Table+TableChild
			this.audioFileSel = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.audioFileSel.Name = "audioFileSel";
			this.notifierTable.Add (this.audioFileSel);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.audioFileSel]));
			w3.TopAttach = ((uint)(6));
			w3.BottomAttach = ((uint)(7));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.audioFileSelLbl = new global::Gtk.Label ();
			this.audioFileSelLbl.Name = "audioFileSelLbl";
			this.audioFileSelLbl.Xalign = 0F;
			this.audioFileSelLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Audio File");
			this.notifierTable.Add (this.audioFileSelLbl);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.audioFileSelLbl]));
			w4.TopAttach = ((uint)(6));
			w4.BottomAttach = ((uint)(7));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.audioNotifyCb = new global::Gtk.CheckButton ();
			this.audioNotifyCb.CanFocus = true;
			this.audioNotifyCb.Name = "audioNotifyCb";
			this.audioNotifyCb.Label = "";
			this.audioNotifyCb.DrawIndicator = true;
			this.notifierTable.Add (this.audioNotifyCb);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.audioNotifyCb]));
			w5.TopAttach = ((uint)(5));
			w5.BottomAttach = ((uint)(6));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(1));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.audioNotifyCbLbl = new global::Gtk.Label ();
			this.audioNotifyCbLbl.Name = "audioNotifyCbLbl";
			this.audioNotifyCbLbl.Xalign = 0F;
			this.audioNotifyCbLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Audio Notify");
			this.notifierTable.Add (this.audioNotifyCbLbl);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.audioNotifyCbLbl]));
			w6.TopAttach = ((uint)(5));
			w6.BottomAttach = ((uint)(6));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.feedTitleTxt = new global::Gtk.Entry ();
			this.feedTitleTxt.CanFocus = true;
			this.feedTitleTxt.Name = "feedTitleTxt";
			this.feedTitleTxt.IsEditable = true;
			this.feedTitleTxt.InvisibleChar = '●';
			this.notifierTable.Add (this.feedTitleTxt);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.feedTitleTxt]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.feedUrlTxLbl = new global::Gtk.Label ();
			this.feedUrlTxLbl.Name = "feedUrlTxLbl";
			this.feedUrlTxLbl.Xalign = 0F;
			this.feedUrlTxLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Feed URL");
			this.notifierTable.Add (this.feedUrlTxLbl);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.feedUrlTxLbl]));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.feedUrlTxt = new global::Gtk.Entry ();
			this.feedUrlTxt.CanFocus = true;
			this.feedUrlTxt.Name = "feedUrlTxt";
			this.feedUrlTxt.IsEditable = true;
			this.feedUrlTxt.InvisibleChar = '●';
			this.notifierTable.Add (this.feedUrlTxt);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.feedUrlTxt]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.iconFileSel = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.iconFileSel.Name = "iconFileSel";
			this.notifierTable.Add (this.iconFileSel);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.iconFileSel]));
			w10.TopAttach = ((uint)(7));
			w10.BottomAttach = ((uint)(8));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.iconFileSelLbl = new global::Gtk.Label ();
			this.iconFileSelLbl.Name = "iconFileSelLbl";
			this.iconFileSelLbl.Xalign = 0F;
			this.iconFileSelLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Icon File");
			this.notifierTable.Add (this.iconFileSelLbl);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.iconFileSelLbl]));
			w11.TopAttach = ((uint)(7));
			w11.BottomAttach = ((uint)(8));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.maxPostsDcLbl = new global::Gtk.Label ();
			this.maxPostsDcLbl.Name = "maxPostsDcLbl";
			this.maxPostsDcLbl.Xalign = 0F;
			this.maxPostsDcLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Maximum Posts");
			this.notifierTable.Add (this.maxPostsDcLbl);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.maxPostsDcLbl]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.maxPostsDec = new global::Gtk.SpinButton (1D, 100D, 1D);
			this.maxPostsDec.CanFocus = true;
			this.maxPostsDec.Name = "maxPostsDec";
			this.maxPostsDec.Adjustment.PageIncrement = 1D;
			this.maxPostsDec.ClimbRate = 1D;
			this.maxPostsDec.Numeric = true;
			this.maxPostsDec.Value = 1D;
			this.notifierTable.Add (this.maxPostsDec);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.maxPostsDec]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.queryIntervalDcLbl = new global::Gtk.Label ();
			this.queryIntervalDcLbl.Name = "queryIntervalDcLbl";
			this.queryIntervalDcLbl.Xalign = 0F;
			this.queryIntervalDcLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Query Interval (sec)");
			this.notifierTable.Add (this.queryIntervalDcLbl);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.queryIntervalDcLbl]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.queryIntervalDec = new global::Gtk.SpinButton (10D, 10000000000D, 1D);
			this.queryIntervalDec.CanFocus = true;
			this.queryIntervalDec.Name = "queryIntervalDec";
			this.queryIntervalDec.Adjustment.PageIncrement = 1D;
			this.queryIntervalDec.ClimbRate = 1D;
			this.queryIntervalDec.Numeric = true;
			this.queryIntervalDec.Value = 10D;
			this.notifierTable.Add (this.queryIntervalDec);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.queryIntervalDec]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.serverNameTxLbl = new global::Gtk.Label ();
			this.serverNameTxLbl.Name = "serverNameTxLbl";
			this.serverNameTxLbl.Xalign = 0F;
			this.serverNameTxLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Feed Title");
			this.notifierTable.Add (this.serverNameTxLbl);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.serverNameTxLbl]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.visualNotifyCb = new global::Gtk.CheckButton ();
			this.visualNotifyCb.CanFocus = true;
			this.visualNotifyCb.Name = "visualNotifyCb";
			this.visualNotifyCb.Label = "";
			this.visualNotifyCb.DrawIndicator = true;
			this.notifierTable.Add (this.visualNotifyCb);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.visualNotifyCb]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(1));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child notifierTable.Gtk.Table+TableChild
			this.visualNotifyCbLbl = new global::Gtk.Label ();
			this.visualNotifyCbLbl.Name = "visualNotifyCbLbl";
			this.visualNotifyCbLbl.Xalign = 0F;
			this.visualNotifyCbLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Visual Notify");
			this.notifierTable.Add (this.visualNotifyCbLbl);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.notifierTable [this.visualNotifyCbLbl]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			w2.Add (this.notifierTable);
			this.notifierScroll.Add (w2);
			this.tabControl.Add (this.notifierScroll);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Notifier Settings");
			this.tabControl.SetTabLabel (this.notifierScroll, this.label1);
			this.label1.ShowAll ();
			// Container child tabControl.Gtk.Notebook+NotebookChild
			this.styleScroll = new global::Gtk.ScrolledWindow ();
			this.styleScroll.CanFocus = true;
			this.styleScroll.Name = "styleScroll";
			this.styleScroll.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.styleScroll.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.styleScroll.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child styleScroll.Gtk.Container+ContainerChild
			global::Gtk.Viewport w22 = new global::Gtk.Viewport ();
			w22.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.styleTable = new global::Gtk.Table (((uint)(10)), ((uint)(2)), false);
			this.styleTable.Name = "styleTable";
			this.styleTable.RowSpacing = ((uint)(6));
			this.styleTable.ColumnSpacing = ((uint)(6));
			this.styleTable.BorderWidth = ((uint)(6));
			// Container child styleTable.Gtk.Table+TableChild
			this.authorFgClLbl = new global::Gtk.Label ();
			this.authorFgClLbl.Name = "authorFgClLbl";
			this.authorFgClLbl.Xalign = 0F;
			this.authorFgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Author Forecolor");
			this.styleTable.Add (this.authorFgClLbl);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.styleTable [this.authorFgClLbl]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.authorFgColorBtn = new global::Gtk.ColorButton ();
			this.authorFgColorBtn.CanFocus = true;
			this.authorFgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.authorFgColorBtn.Name = "authorFgColorBtn";
			this.styleTable.Add (this.authorFgColorBtn);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.styleTable [this.authorFgColorBtn]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(1));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyAntiAliasCb = new global::Gtk.CheckButton ();
			this.bodyAntiAliasCb.CanFocus = true;
			this.bodyAntiAliasCb.Name = "bodyAntiAliasCb";
			this.bodyAntiAliasCb.Label = "";
			this.bodyAntiAliasCb.DrawIndicator = true;
			this.styleTable.Add (this.bodyAntiAliasCb);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyAntiAliasCb]));
			w25.TopAttach = ((uint)(9));
			w25.BottomAttach = ((uint)(10));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(1));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyAntiAliasCbLbl = new global::Gtk.Label ();
			this.bodyAntiAliasCbLbl.Name = "bodyAntiAliasCbLbl";
			this.bodyAntiAliasCbLbl.Xalign = 0F;
			this.bodyAntiAliasCbLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Body Use Anti Alias");
			this.styleTable.Add (this.bodyAntiAliasCbLbl);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyAntiAliasCbLbl]));
			w26.TopAttach = ((uint)(9));
			w26.BottomAttach = ((uint)(10));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyBgClLbl = new global::Gtk.Label ();
			this.bodyBgClLbl.Name = "bodyBgClLbl";
			this.bodyBgClLbl.Xalign = 0F;
			this.bodyBgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Body Backcolor");
			this.styleTable.Add (this.bodyBgClLbl);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyBgClLbl]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyBgColorBtn = new global::Gtk.ColorButton ();
			this.bodyBgColorBtn.CanFocus = true;
			this.bodyBgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.bodyBgColorBtn.Name = "bodyBgColorBtn";
			this.styleTable.Add (this.bodyBgColorBtn);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyBgColorBtn]));
			w28.TopAttach = ((uint)(3));
			w28.BottomAttach = ((uint)(4));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(1));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyFormatScroll = new global::Gtk.ScrolledWindow ();
			this.bodyFormatScroll.Name = "bodyFormatScroll";
			this.bodyFormatScroll.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child bodyFormatScroll.Gtk.Container+ContainerChild
			this.bodyFormatTxt = new global::Gtk.TextView ();
			this.bodyFormatTxt.CanFocus = true;
			this.bodyFormatTxt.Name = "bodyFormatTxt";
			this.bodyFormatScroll.Add (this.bodyFormatTxt);
			this.styleTable.Add (this.bodyFormatScroll);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyFormatScroll]));
			w30.TopAttach = ((uint)(8));
			w30.BottomAttach = ((uint)(9));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.bodyFormatTxLbl = new global::Gtk.Label ();
			this.bodyFormatTxLbl.Name = "bodyFormatTxLbl";
			this.bodyFormatTxLbl.Xalign = 0F;
			this.bodyFormatTxLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Body Format");
			this.styleTable.Add (this.bodyFormatTxLbl);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.styleTable [this.bodyFormatTxLbl]));
			w31.TopAttach = ((uint)(8));
			w31.BottomAttach = ((uint)(9));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.detailFnLbl = new global::Gtk.Label ();
			this.detailFnLbl.Name = "detailFnLbl";
			this.detailFnLbl.Xalign = 0F;
			this.detailFnLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Detail Font");
			this.styleTable.Add (this.detailFnLbl);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.styleTable [this.detailFnLbl]));
			w32.TopAttach = ((uint)(7));
			w32.BottomAttach = ((uint)(8));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.detailFontBtn = new global::Gtk.FontButton ();
			this.detailFontBtn.CanFocus = true;
			this.detailFontBtn.Name = "detailFontBtn";
			this.styleTable.Add (this.detailFontBtn);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.styleTable [this.detailFontBtn]));
			w33.TopAttach = ((uint)(7));
			w33.BottomAttach = ((uint)(8));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.footerBgClLbl = new global::Gtk.Label ();
			this.footerBgClLbl.Name = "footerBgClLbl";
			this.footerBgClLbl.Xalign = 0F;
			this.footerBgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Footer Backcolor");
			this.styleTable.Add (this.footerBgClLbl);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.styleTable [this.footerBgClLbl]));
			w34.TopAttach = ((uint)(4));
			w34.BottomAttach = ((uint)(5));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.footerBgColorBtn = new global::Gtk.ColorButton ();
			this.footerBgColorBtn.CanFocus = true;
			this.footerBgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.footerBgColorBtn.Name = "footerBgColorBtn";
			this.styleTable.Add (this.footerBgColorBtn);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.styleTable [this.footerBgColorBtn]));
			w35.TopAttach = ((uint)(4));
			w35.BottomAttach = ((uint)(5));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.XOptions = ((global::Gtk.AttachOptions)(1));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.headerBgClLbl = new global::Gtk.Label ();
			this.headerBgClLbl.Name = "headerBgClLbl";
			this.headerBgClLbl.Xalign = 0F;
			this.headerBgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Header Backcolor");
			this.styleTable.Add (this.headerBgClLbl);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.styleTable [this.headerBgClLbl]));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.headerBgColorBtn = new global::Gtk.ColorButton ();
			this.headerBgColorBtn.CanFocus = true;
			this.headerBgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.headerBgColorBtn.Name = "headerBgColorBtn";
			this.styleTable.Add (this.headerBgColorBtn);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.styleTable [this.headerBgColorBtn]));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(1));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.timeFgClLbl = new global::Gtk.Label ();
			this.timeFgClLbl.Name = "timeFgClLbl";
			this.timeFgClLbl.Xalign = 0F;
			this.timeFgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Timestamp Forecolor");
			this.styleTable.Add (this.timeFgClLbl);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.styleTable [this.timeFgClLbl]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.timeFgColorBtn = new global::Gtk.ColorButton ();
			this.timeFgColorBtn.CanFocus = true;
			this.timeFgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.timeFgColorBtn.Name = "timeFgColorBtn";
			this.styleTable.Add (this.timeFgColorBtn);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.styleTable [this.timeFgColorBtn]));
			w39.TopAttach = ((uint)(1));
			w39.BottomAttach = ((uint)(2));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(0));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.titleFgClLbl = new global::Gtk.Label ();
			this.titleFgClLbl.Name = "titleFgClLbl";
			this.titleFgClLbl.Xalign = 0F;
			this.titleFgClLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Title Forecolor");
			this.styleTable.Add (this.titleFgClLbl);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.styleTable [this.titleFgClLbl]));
			w40.TopAttach = ((uint)(2));
			w40.BottomAttach = ((uint)(3));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.titleFgColorBtn = new global::Gtk.ColorButton ();
			this.titleFgColorBtn.CanFocus = true;
			this.titleFgColorBtn.Events = ((global::Gdk.EventMask)(784));
			this.titleFgColorBtn.Name = "titleFgColorBtn";
			this.styleTable.Add (this.titleFgColorBtn);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.styleTable [this.titleFgColorBtn]));
			w41.TopAttach = ((uint)(2));
			w41.BottomAttach = ((uint)(3));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(1));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.titleFnLbl = new global::Gtk.Label ();
			this.titleFnLbl.Name = "titleFnLbl";
			this.titleFnLbl.Xalign = 0F;
			this.titleFnLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Title Font");
			this.styleTable.Add (this.titleFnLbl);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.styleTable [this.titleFnLbl]));
			w42.TopAttach = ((uint)(6));
			w42.BottomAttach = ((uint)(7));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child styleTable.Gtk.Table+TableChild
			this.titleFontBtn = new global::Gtk.FontButton ();
			this.titleFontBtn.CanFocus = true;
			this.titleFontBtn.Name = "titleFontBtn";
			this.styleTable.Add (this.titleFontBtn);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.styleTable [this.titleFontBtn]));
			w43.TopAttach = ((uint)(6));
			w43.BottomAttach = ((uint)(7));
			w43.LeftAttach = ((uint)(1));
			w43.RightAttach = ((uint)(2));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			w22.Add (this.styleTable);
			this.styleScroll.Add (w22);
			this.tabControl.Add (this.styleScroll);
			global::Gtk.Notebook.NotebookChild w46 = ((global::Gtk.Notebook.NotebookChild)(this.tabControl [this.styleScroll]));
			w46.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Style Settings");
			this.tabControl.SetTabLabel (this.styleScroll, this.label2);
			this.label2.ShowAll ();
			w1.Add (this.tabControl);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(w1 [this.tabControl]));
			w47.Position = 0;
			// Internal child CodeWalriiNotify.SettingsDialog.ActionArea
			global::Gtk.HButtonBox w48 = this.ActionArea;
			w48.Name = "dialogActionArea";
			w48.Spacing = 10;
			w48.BorderWidth = ((uint)(5));
			w48.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialogActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.cancelButton = new global::Gtk.Button ();
			this.cancelButton.CanDefault = true;
			this.cancelButton.CanFocus = true;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseStock = true;
			this.cancelButton.UseUnderline = true;
			this.cancelButton.Label = "gtk-cancel";
			this.AddActionWidget (this.cancelButton, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w49 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w48 [this.cancelButton]));
			w49.Expand = false;
			w49.Fill = false;
			// Container child dialogActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.defaultsButton = new global::Gtk.Button ();
			this.defaultsButton.CanFocus = true;
			this.defaultsButton.Name = "defaultsButton";
			this.defaultsButton.UseUnderline = true;
			this.defaultsButton.Label = global::Mono.Unix.Catalog.GetString ("Load defaults");
			this.AddActionWidget (this.defaultsButton, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w50 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w48 [this.defaultsButton]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			// Container child dialogActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.okButton = new global::Gtk.Button ();
			this.okButton.CanDefault = true;
			this.okButton.CanFocus = true;
			this.okButton.Name = "okButton";
			this.okButton.UseStock = true;
			this.okButton.UseUnderline = true;
			this.okButton.Label = "gtk-ok";
			this.AddActionWidget (this.okButton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w51 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w48 [this.okButton]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 503;
			this.DefaultHeight = 314;
			this.Show ();
			this.cancelButton.Clicked += new global::System.EventHandler (this.OnCancelButtonClicked);
			this.defaultsButton.Clicked += new global::System.EventHandler (this.OnDefaultsButtonClicked);
			this.okButton.Clicked += new global::System.EventHandler (this.OnOkButtonClicked);
		}
	}
}


// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.SourceEditor.OptionPanels
{
	internal partial class CompletionOptionsPanel
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.VBox vbox5;

		private global::Gtk.CheckButton autoCodeCompletionCheckbutton;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox suggestionModeHbox;

		private global::Gtk.Label label1;

		private global::Gtk.RadioButton completeOnAllRadiobutton;

		private global::Gtk.RadioButton completeOnEnterRadiobutton;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Fixed fixed3;

		private global::Gtk.CheckButton includeKeywordsCheckbutton;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Fixed fixed4;

		private global::Gtk.CheckButton includeCodeSnippetsCheckbutton;

		private global::Gtk.CheckButton showImportsCheckbutton;

		private global::Gtk.CheckButton insertParenthesesCheckbutton;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.RadioButton openingRadiobutton;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.RadioButton bothRadiobutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.SourceEditor.OptionPanels.CompletionOptionsPanel
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.SourceEditor.OptionPanels.CompletionOptionsPanel";
			// Container child MonoDevelop.SourceEditor.OptionPanels.CompletionOptionsPanel.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(12));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.autoCodeCompletionCheckbutton = new global::Gtk.CheckButton();
			this.autoCodeCompletionCheckbutton.CanFocus = true;
			this.autoCodeCompletionCheckbutton.Name = "autoCodeCompletionCheckbutton";
			this.autoCodeCompletionCheckbutton.Label = global::Mono.Unix.Catalog.GetString("_Show completion list after a character is typed");
			this.autoCodeCompletionCheckbutton.DrawIndicator = true;
			this.autoCodeCompletionCheckbutton.UseUnderline = true;
			this.vbox5.Add(this.autoCodeCompletionCheckbutton);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.autoCodeCompletionCheckbutton]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(24));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.suggestionModeHbox = new global::Gtk.HBox();
			this.suggestionModeHbox.Name = "suggestionModeHbox";
			this.suggestionModeHbox.Spacing = 6;
			// Container child suggestionModeHbox.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Complete after typing:");
			this.suggestionModeHbox.Add(this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.suggestionModeHbox[this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			// Container child suggestionModeHbox.Gtk.Box+BoxChild
			this.completeOnAllRadiobutton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Enter, Space, Tab, Period"));
			this.completeOnAllRadiobutton.CanFocus = true;
			this.completeOnAllRadiobutton.Name = "completeOnAllRadiobutton";
			this.completeOnAllRadiobutton.DrawIndicator = true;
			this.completeOnAllRadiobutton.UseUnderline = true;
			this.completeOnAllRadiobutton.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.suggestionModeHbox.Add(this.completeOnAllRadiobutton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.suggestionModeHbox[this.completeOnAllRadiobutton]));
			w3.Position = 1;
			w3.Expand = false;
			// Container child suggestionModeHbox.Gtk.Box+BoxChild
			this.completeOnEnterRadiobutton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Enter only"));
			this.completeOnEnterRadiobutton.CanFocus = true;
			this.completeOnEnterRadiobutton.Name = "completeOnEnterRadiobutton";
			this.completeOnEnterRadiobutton.DrawIndicator = true;
			this.completeOnEnterRadiobutton.UseUnderline = true;
			this.completeOnEnterRadiobutton.Group = this.completeOnAllRadiobutton.Group;
			this.suggestionModeHbox.Add(this.completeOnEnterRadiobutton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.suggestionModeHbox[this.completeOnEnterRadiobutton]));
			w4.Position = 2;
			w4.Expand = false;
			this.alignment1.Add(this.suggestionModeHbox);
			this.vbox5.Add(this.alignment1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.alignment1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox4.Add(this.fixed3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.fixed3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Padding = ((uint)(6));
			// Container child hbox4.Gtk.Box+BoxChild
			this.includeKeywordsCheckbutton = new global::Gtk.CheckButton();
			this.includeKeywordsCheckbutton.CanFocus = true;
			this.includeKeywordsCheckbutton.Name = "includeKeywordsCheckbutton";
			this.includeKeywordsCheckbutton.Label = global::Mono.Unix.Catalog.GetString("Include _keywords in completion list");
			this.includeKeywordsCheckbutton.DrawIndicator = true;
			this.includeKeywordsCheckbutton.UseUnderline = true;
			this.hbox4.Add(this.includeKeywordsCheckbutton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.includeKeywordsCheckbutton]));
			w8.Position = 1;
			this.vbox5.Add(this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox4]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.fixed4 = new global::Gtk.Fixed();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.hbox5.Add(this.fixed4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.fixed4]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Padding = ((uint)(6));
			// Container child hbox5.Gtk.Box+BoxChild
			this.includeCodeSnippetsCheckbutton = new global::Gtk.CheckButton();
			this.includeCodeSnippetsCheckbutton.CanFocus = true;
			this.includeCodeSnippetsCheckbutton.Name = "includeCodeSnippetsCheckbutton";
			this.includeCodeSnippetsCheckbutton.Label = global::Mono.Unix.Catalog.GetString("Include _code snippets in completion list");
			this.includeCodeSnippetsCheckbutton.DrawIndicator = true;
			this.includeCodeSnippetsCheckbutton.UseUnderline = true;
			this.hbox5.Add(this.includeCodeSnippetsCheckbutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.includeCodeSnippetsCheckbutton]));
			w11.Position = 1;
			this.vbox5.Add(this.hbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox5]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.showImportsCheckbutton = new global::Gtk.CheckButton();
			this.showImportsCheckbutton.CanFocus = true;
			this.showImportsCheckbutton.Name = "showImportsCheckbutton";
			this.showImportsCheckbutton.Label = global::Mono.Unix.Catalog.GetString("_Show import items");
			this.showImportsCheckbutton.DrawIndicator = true;
			this.showImportsCheckbutton.UseUnderline = true;
			this.vbox5.Add(this.showImportsCheckbutton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.showImportsCheckbutton]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.insertParenthesesCheckbutton = new global::Gtk.CheckButton();
			this.insertParenthesesCheckbutton.CanFocus = true;
			this.insertParenthesesCheckbutton.Name = "insertParenthesesCheckbutton";
			this.insertParenthesesCheckbutton.Label = global::Mono.Unix.Catalog.GetString("A_utomatically insert parentheses after completion:");
			this.insertParenthesesCheckbutton.DrawIndicator = true;
			this.insertParenthesesCheckbutton.UseUnderline = true;
			this.vbox5.Add(this.insertParenthesesCheckbutton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.insertParenthesesCheckbutton]));
			w14.Position = 5;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add(this.fixed1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.fixed1]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Padding = ((uint)(6));
			// Container child hbox2.Gtk.Box+BoxChild
			this.openingRadiobutton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Opening only"));
			this.openingRadiobutton.CanFocus = true;
			this.openingRadiobutton.Name = "openingRadiobutton";
			this.openingRadiobutton.DrawIndicator = true;
			this.openingRadiobutton.UseUnderline = true;
			this.openingRadiobutton.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox2.Add(this.openingRadiobutton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.openingRadiobutton]));
			w16.Position = 1;
			this.vbox5.Add(this.hbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
			w17.Position = 6;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.hbox3.Add(this.fixed2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.fixed2]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Padding = ((uint)(6));
			// Container child hbox3.Gtk.Box+BoxChild
			this.bothRadiobutton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Both opening and closing"));
			this.bothRadiobutton.CanFocus = true;
			this.bothRadiobutton.Name = "bothRadiobutton";
			this.bothRadiobutton.DrawIndicator = true;
			this.bothRadiobutton.UseUnderline = true;
			this.bothRadiobutton.Group = this.openingRadiobutton.Group;
			this.hbox3.Add(this.bothRadiobutton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.bothRadiobutton]));
			w19.Position = 1;
			this.vbox5.Add(this.hbox3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
			w20.Position = 7;
			w20.Expand = false;
			w20.Fill = false;
			this.alignment3.Add(this.vbox5);
			this.vbox1.Add(this.alignment3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment3]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}

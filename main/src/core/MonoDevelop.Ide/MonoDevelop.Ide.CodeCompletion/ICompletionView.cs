//
// CodeCompletionSession.cs
//
// Author:
//       Lluis Sanchez <llsan@microsoft.com>
//
// Copyright (c) 2017 Microsoft
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Gdk;
using Gtk;
using MonoDevelop.Ide.Editor.Extension;

namespace MonoDevelop.Ide.CodeCompletion
{
	[Obsolete ("Use the Microsoft.VisualStudio.Language.Intellisense.AsyncCompletion APIs")]
	interface ICompletionView
	{
		void Initialize (IListDataProvider provider, ICompletionViewEventSink eventSink);
		void ShowFilteredItems (CompletionListFilterResult filterResult);

		void MoveCursor (int relative);
		void PageDown ();
		void PageUp ();

		void ResetState ();
		void ResetSizes ();

		void ShowLoadingMessage ();
		void HideLoadingMessage ();

		void Show ();
		void Hide ();
		void Destroy ();

		void Reposition (int triggerX, int triggerY, int triggerHeight, bool force);
		void RepositionWindow (Xwt.Rectangle? r);

		void ShowPreviewCompletionEntry ();
		bool RepositionDeclarationViewWindow (TooltipInformationWindow declarationviewwindow, int selectedItem);

		int SelectedItemIndex { get; set; }
		bool InCategoryMode { get; set; }
		bool SelectionEnabled { get; set; }

		bool Visible { get; }

		Xwt.Rectangle Allocation { get; }
		int X { get; }
		int Y { get; }

		Gtk.Window TransientFor { get; set; }
	}
}

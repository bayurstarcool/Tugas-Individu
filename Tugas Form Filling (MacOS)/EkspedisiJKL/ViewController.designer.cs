// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace EkspedisiJKL
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField berat { get; set; }

		[Outlet]
		AppKit.NSTextField namaPenerima { get; set; }

		[Outlet]
		AppKit.NSTextField namaPengirim { get; set; }

		[Outlet]
		AppKit.NSTextField perkg { get; set; }

		[Outlet]
		AppKit.NSDatePicker today { get; set; }

		[Outlet]
		AppKit.NSTextField totalBiaya { get; set; }

		[Outlet]
		AppKit.NSTextField tujuan { get; set; }

		[Action ("noResi:")]
		partial void noResi (Foundation.NSObject sender);

		[Action ("simpan:")]
		partial void simpan (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (namaPengirim != null) {
				namaPengirim.Dispose ();
				namaPengirim = null;
			}

			if (namaPenerima != null) {
				namaPenerima.Dispose ();
				namaPenerima = null;
			}

			if (today != null) {
				today.Dispose ();
				today = null;
			}

			if (tujuan != null) {
				tujuan.Dispose ();
				tujuan = null;
			}

			if (perkg != null) {
				perkg.Dispose ();
				perkg = null;
			}

			if (berat != null) {
				berat.Dispose ();
				berat = null;
			}

			if (totalBiaya != null) {
				totalBiaya.Dispose ();
				totalBiaya = null;
			}
		}
	}
}

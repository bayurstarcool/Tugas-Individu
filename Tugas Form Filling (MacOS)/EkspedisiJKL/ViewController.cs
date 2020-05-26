using System;

using AppKit;
using Foundation;

namespace EkspedisiJKL
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            today.DateValue = NSDate.Now;
            perkg.IntValue = 7000;
            berat.Changed += (sender, e) =>
            {
                totalBiaya.IntValue = (berat.IntValue * perkg.IntValue);
            };
            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        partial void simpan(NSObject sender)
        {
            Console.WriteLine(("Simpan pressed"));
            namaPengirim.StringValue = "OK";
            tujuan.StringValue = "Surabaya";
            Console.WriteLine((namaPengirim.StringValue));
        
        }

    }
}

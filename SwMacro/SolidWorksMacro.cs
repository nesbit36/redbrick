using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Runtime.InteropServices;
using System;

namespace redbrick.csproj
{
    public partial class SolidWorksMacro
    {
        public void Main()
        {
            //RedBrick rb = new RedBrick(this.swApp);
            //rb.ShowDialog();
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToLongTimeString());
            DrawingRedbrick drb = new DrawingRedbrick(this.swApp);
            drb.ShowDialog();
        }

        /// <summary>
        ///  The SldWorks swApp variable is pre-assigned for you.
        /// </summary>
        public SldWorks swApp;
    }
}



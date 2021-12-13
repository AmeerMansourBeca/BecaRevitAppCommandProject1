using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using BecaRevitAppCommandProject1.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BecaRevitAppCommandProject1
{
    class TabNameTabApp_NEEDTOBECHANGED : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            RibbonUI.CreateUI(a);

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}

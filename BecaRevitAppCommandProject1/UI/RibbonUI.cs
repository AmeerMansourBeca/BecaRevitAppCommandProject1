using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace BecaRevitAppCommandProject1.UI
{
    internal static class RibbonUI
    {
        private const string tabName = "****"; //NEED TO BE CHANGED

        public static void CreateUI(UIControlledApplication application)
        {
            application.CreateRibbonTab(tabName);
            CreateRibbonPanels(application);
        }

        private static void CreateRibbonPanels(UIControlledApplication application)
        {
            #region TEMPLATE

            //var currentDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            //RibbonPanel panel_ElectricalTools = application.CreateRibbonPanel(tabName, "Electrical Tools");



            //#region Buttons
            ////Electrical Tools Panel
            //PushButtonData powerBIM = RevitRibbonUtility.makePushButton("DB and Circuit Checker", "PowerBIM", System.IO.Path.Combine(currentDir, "Beca.Revit.Commands.PowerBIM.dll"),
            //    "Beca.Revit.Commands.PowerBIM.RevitCommands.BecaPowerBIMMain", Properties.Resources.becaMEP_PowerBIM, "Calculate and Check DBs and Circuits");
            //panel_ElectricalTools.AddItem(powerBIM);

            //PushButtonData cctvDesign = RevitRibbonUtility.makePushButton("BecaCCTVdesign", "CCTV", System.IO.Path.Combine(currentDir, "Beca.Revit.Commands.CCTV.dll"),
            //    "Beca.Revit.Commands.CCTV.RevitCommands.BecaMEPCameraView", Properties.Resources.BecaMEP_CCTVdesign, "CCTV Camera View Design");
            //panel_ElectricalTools.AddItem(cctvDesign);

            //PushButtonData ALP = RevitRibbonUtility.makePushButton("AGILightPlacement", "ALP", System.IO.Path.Combine(currentDir, "Beca.Revit.Commands.BecaALP.dll"),
            //    "Beca.Revit.Commands.BecaALP.RevitCommands.BecaALPCommand", Properties.Resources.becaMEP_ALP, "Place AGI lighting fixture from Excel file");
            //panel_ElectricalTools.AddItem(ALP);

            //PushButtonData LPD = RevitRibbonUtility.makePushButton("LPD Exporter", "LPD", System.IO.Path.Combine(currentDir, "Beca.Revit.Commands.BecaLPD.dll"),
            //    "Beca.Revit.Commands.BecaLPD.RevitCommands.BecaLPDCommand", Properties.Resources.becaMEP_LPD, "Export Section J6 and H1 Calcs");
            //panel_ElectricalTools.AddItem(LPD);


            //#endregion
            #endregion

        }
    }
}

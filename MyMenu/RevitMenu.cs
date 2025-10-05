using System;
using System.Windows.Media.Imaging;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Revit.SDK.Samples.AreaReinCurve.CS;


namespace MyMenu
{
    [Transaction(TransactionMode.Manual)]
    public class RevitMenu : IExternalApplication
    {       

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("Автоматизация Revit");
            var panel = application.CreateRibbonPanel("Автоматизация Revit","Задание 3");
            var button = new PushButtonData(
                "myButton",
                "AreaReinCurve",
                "C:\\Users\\fokinsv\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2019\\AreaReinCurve\\AreaReinCurve.dll",
                "Revit.SDK.Samples.AreaReinCurve.CS.AreaReinCurve"
                );
            BitmapImage bitmap = new BitmapImage(
                new Uri("C:\\Users\\fokinsv\\AppData\\Roaming\\Autodesk\\Revit\\Addins\\2019\\MyMenu\\img\\Validate32.png",UriKind.Absolute));
            button.LargeImage=bitmap;
            panel.AddItem(button);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace PluginCommand;

[Transaction(TransactionMode.Manual)]
public class Command: IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        TaskDialog.Show("Hello", "It'sworking");
        return Result.Succeeded;
    }
}
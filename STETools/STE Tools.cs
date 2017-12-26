using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace STETools
{
    public partial class STE_Tools
    {
        private SerialNumberGenerator _serialNumberGenerator;

        private void STE_Tools_Load(object sender, RibbonUIEventArgs e)
        {
            _serialNumberGenerator = new SerialNumberGenerator();
        }

        private void generateButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (!(Globals.ThisAddIn.Application.Selection is Range selection)) return;
            foreach (Range cell in selection)
            {
                cell.Value2 = _serialNumberGenerator.Generate();
            }
        }
    }
}

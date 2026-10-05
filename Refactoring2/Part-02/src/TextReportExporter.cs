using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring2.Part_02.src
{
    public class TextReportExporter : ReportExporter
    {
        protected override string Format(List<string[]> rows) =>
            string.Join(
                Environment.NewLine,
                rows.Select(r => string.Join(" | ", r)));
    }
}

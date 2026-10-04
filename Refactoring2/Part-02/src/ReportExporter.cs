using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring2.Part_02.src
{
    public abstract class ReportExporter
    {
        public void Export(string path)
        {
            var rows = Load();

            if (!Validate(rows))
                throw new InvalidOperationException("Invalid data");

            var content = Format(rows);

            Save(path, content);
        }

        private List<string[]> Load() =>
            new List<string[]>
            {
              new[] { "Id", "Name" },
              new[] { "1", "Keyboard" },
              new[] { "2", "Mouse" }
            };

        private bool Validate(List<string[]> rows) =>
            rows.Count > 1 && rows[0].Length > 0;

        protected abstract string Format(List<string[]> rows);

        private void Save(string path, string content) =>
            File.WriteAllText(path, content);
    }
}

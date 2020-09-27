using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace MoonScriptEditor
{
    public class DSList
    {
        private static Regex Regex = new Regex("\"[^\"]+\"|[\\w]+", RegexOptions.Compiled);

        public DSList(string filename)
        {
            this.FileName = filename;

            foreach (var line in File.ReadAllLines(this.FileName))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith(";") || line.StartsWith("["))
                    continue;

                var matches = Regex.Matches(line);
                var hints = new List<string>();

                if (!int.TryParse(matches[0].Value, out var level))
                    throw new InvalidDataException(nameof(filename) + " contains an invalid formatted trigger: " + line);

                if (!int.TryParse(matches[1].Value, out var category))
                    throw new InvalidDataException(nameof(filename) + " contains an invalid formatted trigger: " + line);

                if (!int.TryParse(matches[2].Value, out var id))
                    throw new InvalidDataException(nameof(filename) + " contains an invalid formatted trigger: " + line);

                if (matches.Count < 4)
                    throw new InvalidDataException(nameof(filename) + " contains an invalid formatted trigger: " + line);

                var description = matches[3].Value.Substring(1, matches[3].Value.Length - 2);

                if (matches.Count > 4)
                    for (var i = 4; i <= matches.Count - 1; i++)
                        hints.Add(matches[i].Value.Substring(1, matches[i].Value.Length - 2));

                this.Triggers.Add((category, id, description, hints.ToArray()));
            }
        }

        public List<(int category, int id, string description, string[] hints)> Triggers
            = new List<(int category, int id, string description, string[] hints)>();

        public string FileName { get; }
    }
}
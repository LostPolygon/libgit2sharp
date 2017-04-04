using System;
using System.Collections.Generic;
using System.Text;

namespace LibGit2Sharp.Core
{
    internal static partial class Compat {
        public static class String {
            public static bool IsNullOrWhiteSpace(string value) {
                if (value == null) return true;
                return string.IsNullOrEmpty(value.Trim());
            }

            public static string Join(string separator, IEnumerable<string> values)
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                if (separator == null)
                    separator = string.Empty;

                using (IEnumerator<string> enumerator = values.GetEnumerator())
                {
                    if (!enumerator.MoveNext())
                        return string.Empty;

                    StringBuilder sb = new StringBuilder(16);
                    if (enumerator.Current != null)
                        sb.Append(enumerator.Current);

                    while (enumerator.MoveNext())
                    {
                        sb.Append(separator);
                        if (enumerator.Current != null)
                            sb.Append(enumerator.Current);
                    }

                    return sb.ToString();
                }
            }
        }
    }
}

using System;

namespace LibGit2Sharp.Core
{
    internal static partial class Compat {
        public static class Path {
            public static string Combine(params string[] paths) {
                if (paths == null)
                    throw new ArgumentNullException("paths");

                if (paths.Length == 2)
                    return System.IO.Path.Combine(paths[0], paths[1]);

                string result = paths[0];
                for (int i = 1; i < paths.Length; i++) {
                    result = System.IO.Path.Combine(result, paths[i]);
                }

                return result;
            }
        }
    }
}

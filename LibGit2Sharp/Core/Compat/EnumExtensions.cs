using System;

namespace LibGit2Sharp.Core.CompatExtensions {
    internal static class EnumExtensions {
        public static bool HasFlag(this Enum value, Enum flag)  {
            if (value == null)
                return false;

            if (value == null)
                throw new ArgumentNullException("flag");

            if (!value.GetType().IsEnum)
                throw new ArgumentException("value must be an Enum");

            long num = Convert.ToInt64(flag);
            return (Convert.ToInt64(value) & num) == num;
        }
    }
}
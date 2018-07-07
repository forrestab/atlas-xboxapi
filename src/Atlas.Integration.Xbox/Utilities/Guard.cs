using System;

namespace Atlas.Integration.Xbox.Utilities
{
    public static class Guard
    {
        public static void AgainstNullArgument<T>(string argumentName, T argument)
            where T : class
        {
            if (argument == null)
            {
                throw new ArgumentNullException($"{argumentName} is null.", argumentName);
            }
        }
    }
}

using System;

namespace ParameterisedTests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class InputAttribute : Attribute
    {
        public InputAttribute(params object[] parameters)
        {
            Parameters = parameters;
        }

        public object[] Parameters { get; private set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Fixie.Conventions;

namespace ParameterisedTests
{
    class ParameterisingConvention : Convention
    {
        public ParameterisingConvention()
        {
            Parameters(FromInputAttributes);
        }

        IEnumerable<object[]> FromInputAttributes(MethodInfo method)
        {
            var inputAttributes = method.GetCustomAttributes<InputAttribute>(true).ToArray();

            if (!inputAttributes.Any())
            {
                yield return null;
            }
            else
            {
                foreach (var input in inputAttributes)
                    yield return input.Parameters;
            }
        }
    }
}

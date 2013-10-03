using System.Diagnostics;

using Fixie.Conventions;

namespace TestWithConvention
{
    public class MyConvention : Convention
    {
        public MyConvention()
        {
            Classes.NameEndsWith("PleaseRun");

            Methods.Where(methodInfo => methodInfo.Name.EndsWith("PleaseRun"));

            CaseExecution.Wrap(
                (@case, wrapper, action) =>
                {
                    Debug.Print(@case.Name);
                    action();
                    Debug.Print("{0} - finished", @case.Name);
                });
        }
    }
}

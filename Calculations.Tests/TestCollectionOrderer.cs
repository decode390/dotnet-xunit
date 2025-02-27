using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests;

// To AssemblyInfo.cs
// 1st param: Namespace.Classname
// 2nd param: Project.Name
// [assembly: TestCollectionOrderer("Calculations.Tests.TestCollectionOrderer", "Calculations.Tests")]
public class TestCollectionOrderer : ITestCollectionOrderer
{
    public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
    {
        return testCollections.OrderBy(x => x.DisplayName);
    }
}
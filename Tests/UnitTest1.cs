using NetArchTest.Rules;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FailingTypesShouldBeEmptyWhenInterfacesAreTested()
        {
            var result = Types.InNamespace("A")
                .That()
                .AreInterfaces()
                .Should()
                .HaveDependencyOn("B")
                .GetResult();

            Assert.Null(result.FailingTypes);
        }

        [Fact]
        public void FailingTypesShouldBeEmptyWhenClassesAreTested()
        {
            var result = Types.InNamespace("A")
                .That()
                .AreNotInterfaces()
                .Should()
                .HaveDependencyOn("B")
                .GetResult();

            Assert.Null(result.FailingTypes);
        }
    }
}

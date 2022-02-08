using System.Collections.Generic;
using System.Text;
using NullableTypesTask;
using NUnit.Framework;

namespace NullableTypeExtensions.Tests
{
    [TestFixture]
    public class NullableTypeExtensionsTests
    {
        private static IEnumerable<TestCaseData> DataCases
        {
            get
            {
                yield return new TestCaseData("Kathy").Returns(false);
                yield return new TestCaseData(string.Empty).Returns(false);
                yield return new TestCaseData(new object()).Returns(false);
                yield return new TestCaseData(new StringBuilder()).Returns(false);
                yield return new TestCaseData(null).Returns(true);
                yield return new TestCaseData(new char?('t')).Returns(false);
            }
        }

        [TestCaseSource(nameof(DataCases))]
        public bool IsNullTests(object variable) => variable.IsNull();

        [Test]
        public void IsNull_With_Nullable_Integer_Return_True()
        {
            int? x = null;
            Assert.True(x.IsNull());
        }

        [Test]
        public void IsNull_With_Nullable_Integer_Return_False()
        {
            int? x = 12;
            Assert.False(x.IsNull());
        }
    }
}

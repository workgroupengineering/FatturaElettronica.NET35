using System.Collections.Generic;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
#if NET35
    public static class CollectionAssert
    {
        public static void AreEqual<T>(T[] expected, T[] actual)
        {
            if (ReferenceEquals(expected, actual) == false)
            {
                Assert.IsFalse(expected == null || actual == null, "Actual array is not same of expected.");
                Assert.IsFalse(expected.Length != actual.Length, "Actual array lenght is not same of expected.");
                var comparer = EqualityComparer<T>.Default;
                for (int i = 0; i < expected.Length; i++)
                {
                    Assert.IsTrue(comparer.Equals(expected[i], actual[i]),$"Item at index {i} of actual array is not same of expected ({actual[i]}!={expected[i]})");
                }
            }
        }

    }
#endif
}

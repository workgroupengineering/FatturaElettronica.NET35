using System;
using System.Globalization;
using NUnit.Framework;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{

    public class TestClass : TestFixtureAttribute { }

    public class TestMethod : TestAttribute { }

    public class TestInitialize : SetUpAttribute { }


    //
    // Summary:
    //     A collection of helper classes to test various conditions within unit tests.
    //     If the condition being tested is not met, an exception is thrown.
    public sealed class Assert
    {
        //
        // Summary:
        //     Gets the singleton instance of the Assert functionality.
        //
        // Remarks:
        //     Users can use this to plug-in custom assertions through C# extension methods.
        //     For instance, the signature of a custom assertion provider could be "public static
        //     void IsOfType<T>(this Assert assert, object obj)" Users could then use a syntax
        //     similar to the default assertions which in this case is "Assert.That.IsOfType<Dog>(animal);"
        //     More documentation is at "https://github.com/Microsoft/testfx-docs".
        public static Assert That { get; }

        //
        // Summary:
        //     Tests whether the specified values are equal and throws an exception if the two
        //     values are not equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first value to compare. This is the value the tests expects.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual<T>(T expected, T actual, string message, params object[] parameters)
            => NUnit.Framework.Assert.AreEqual(expected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified objects are equal and throws an exception if the
        //     two objects are not equal. Different numeric types are treated as unequal even
        //     if the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the object the tests expects.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(object expected, object actual)
         => NUnit.Framework.Assert.AreEqual(expected, actual);
        //
        // Summary:
        //     Tests whether the specified objects are equal and throws an exception if the
        //     two objects are not equal. Different numeric types are treated as unequal even
        //     if the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the object the tests expects.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(object expected, object actual, string message)
         => NUnit.Framework.Assert.AreEqual(expected, actual, message);
        //
        // Summary:
        //     Tests whether the specified objects are equal and throws an exception if the
        //     two objects are not equal. Different numeric types are treated as unequal even
        //     if the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the object the tests expects.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(object expected, object actual, string message, params object[] parameters)
         => NUnit.Framework.Assert.AreEqual(expected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified floats are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first float to compare. This is the float the tests expects.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(float expected, float actual, float delta)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta);

        //
        // Summary:
        //     Tests whether the specified floats are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first float to compare. This is the float the tests expects.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        //   message:
        //     The message to include in the exception when actual is different than expected
        //     by more than delta. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(float expected, float actual, float delta, string message)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message);
        //
        // Summary:
        //     Tests whether the specified floats are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first float to compare. This is the float the tests expects.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        //   message:
        //     The message to include in the exception when actual is different than expected
        //     by more than delta. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(float expected, float actual, float delta, string message, params object[] parameters)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message, parameters);
        //
        // Summary:
        //     Tests whether the specified doubles are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first double to compare. This is the double the tests expects.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(double expected, double actual, double delta)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta);
        //
        // Summary:
        //     Tests whether the specified doubles are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first double to compare. This is the double the tests expects.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        //   message:
        //     The message to include in the exception when actual is different than expected
        //     by more than delta. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(double expected, double actual, double delta, string message)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message);
        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase)
            => NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase) == 0);
        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase, string message)
            => NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase) == 0, message);
        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase) == 0, message, parameters);
        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture) =>
            NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase, culture) == 0);
        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message) =>
            NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase, culture) == 0, message);

        //
        // Summary:
        //     Tests whether the specified strings are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first string to compare. This is the string the tests expects.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsTrue(string.Compare(expected, actual, ignoreCase, culture) == 0, message, parameters);
        //
        // Summary:
        //     Tests whether the specified values are equal and throws an exception if the two
        //     values are not equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first value to compare. This is the value the tests expects.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not equal to expected.
        //     The message is shown in test results.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual<T>(T expected, T actual, string message)
            => NUnit.Framework.Assert.AreEqual(expected, actual, message);
        //
        // Summary:
        //     Tests whether the specified values are equal and throws an exception if the two
        //     values are not equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   expected:
        //     The first value to compare. This is the value the tests expects.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual<T>(T expected, T actual)
            => NUnit.Framework.Assert.AreEqual(expected, actual);
        //
        // Summary:
        //     Tests whether the specified doubles are equal and throws an exception if they
        //     are not equal.
        //
        // Parameters:
        //   expected:
        //     The first double to compare. This is the double the tests expects.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than expected by more than delta.
        //
        //   message:
        //     The message to include in the exception when actual is different than expected
        //     by more than delta. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected is not equal to actual.
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] parameters)
            => NUnit.Framework.Assert.AreEqual(expected, actual, delta, message, parameters);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase)
            => NUnit.Framework.Assert.IsFalse(string.Compare(notExpected, actual, ignoreCase) == 0);
        //
        // Summary:
        //     Tests whether the specified floats are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first float to compare. This is the float the test expects not to match actual.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected or
        //     different by less than delta. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(float notExpected, float actual, float delta, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsTrue(Math.Abs(actual - notExpected) > delta, message, parameters);
        //
        // Summary:
        //     Tests whether the specified floats are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first float to compare. This is the float the test expects not to match actual.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected or
        //     different by less than delta. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(float notExpected, float actual, float delta, string message)
            => NUnit.Framework.Assert.IsTrue(Math.Abs(actual - notExpected) > delta, message);
        //
        // Summary:
        //     Tests whether the specified floats are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first float to compare. This is the float the test expects not to match actual.
        //
        //   actual:
        //     The second float to compare. This is the float produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(float notExpected, float actual, float delta)
            => NUnit.Framework.Assert.IsTrue(Math.Abs(actual - notExpected) > delta);
        //
        // Summary:
        //     Tests whether the specified doubles are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first double to compare. This is the double the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected or
        //     different by less than delta. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(double notExpected, double actual, double delta, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsTrue(Math.Abs(actual - notExpected) > delta, message, parameters);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message)
            => NUnit.Framework.Assert.IsTrue(string.Compare(notExpected, actual, ignoreCase) != 0, message);
        //
        // Summary:
        //     Tests whether the specified objects are unequal and throws an exception if the
        //     two objects are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(object notExpected, object actual, string message, params object[] parameters)
            => NUnit.Framework.Assert.AreNotEqual(notExpected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified doubles are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first double to compare. This is the double the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected or
        //     different by less than delta. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(double notExpected, double actual, double delta, string message) =>
            NUnit.Framework.Assert.IsTrue(Math.Abs(notExpected - actual) > delta, message);
        //
        // Summary:
        //     Tests whether the specified objects are unequal and throws an exception if the
        //     two objects are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(object notExpected, object actual, string message) =>
            NUnit.Framework.Assert.AreNotEqual(notExpected, actual, message);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal. The invariant culture is used for the comparison.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsFalse(string.Compare(notExpected, actual, ignoreCase) == 0, message, parameters);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture) =>
            NUnit.Framework.Assert.IsFalse(string.Compare(notExpected, actual, ignoreCase, culture) == 0);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message) =>
            NUnit.Framework.Assert.IsFalse(string.Compare(notExpected, actual, ignoreCase) == 0, message);
        //
        // Summary:
        //     Tests whether the specified values are unequal and throws an exception if the
        //     two values are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first value to compare. This is the value the test expects not to match actual.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual<T>(T notExpected, T actual, string message, params object[] parameters) =>
            NUnit.Framework.Assert.AreNotEqual(notExpected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified values are unequal and throws an exception if the
        //     two values are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first value to compare. This is the value the test expects not to match actual.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual<T>(T notExpected, T actual, string message) =>
            NUnit.Framework.Assert.AreNotEqual(notExpected, actual, message);
        //
        // Summary:
        //     Tests whether the specified values are unequal and throws an exception if the
        //     two values are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first value to compare. This is the value the test expects not to match actual.
        //
        //   actual:
        //     The second value to compare. This is the value produced by the code under test.
        //
        // Type parameters:
        //   T:
        //     The type of values to compare.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual<T>(T notExpected, T actual) =>
            NUnit.Framework.Assert.AreNotEqual(notExpected, actual);
        //
        // Summary:
        //     Tests whether the specified strings are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first string to compare. This is the string the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second string to compare. This is the string produced by the code under test.
        //
        //   ignoreCase:
        //     A Boolean indicating a case-sensitive or insensitive comparison. (true indicates
        //     a case-insensitive comparison.)
        //
        //   culture:
        //     A CultureInfo object that supplies culture-specific comparison information.
        //
        //   message:
        //     The message to include in the exception when actual is equal to notExpected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsFalse(string.Compare(notExpected, actual, ignoreCase, culture) == 0, message, parameters);
        //
        // Summary:
        //     Tests whether the specified objects are unequal and throws an exception if the
        //     two objects are equal. Different numeric types are treated as unequal even if
        //     the logical values are equal. 42L is not equal to 42.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the object produced by the code under test.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(object notExpected, object actual) =>
            NUnit.Framework.Assert.AreNotEqual(notExpected, actual);
        //
        // Summary:
        //     Tests whether the specified doubles are unequal and throws an exception if they
        //     are equal.
        //
        // Parameters:
        //   notExpected:
        //     The first double to compare. This is the double the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second double to compare. This is the double produced by the code under test.
        //
        //   delta:
        //     The required accuracy. An exception will be thrown only if actual is different
        //     than notExpected by at most delta.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected is equal to actual.
        public static void AreNotEqual(double notExpected, double actual, double delta) =>
            NUnit.Framework.Assert.IsFalse(Math.Abs(notExpected - actual) < delta);
        //
        // Summary:
        //     Tests whether the specified objects refer to different objects and throws an
        //     exception if the two inputs refer to the same object.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is the same as notExpected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected refers to the same object as actual.
        public static void AreNotSame(object notExpected, object actual, string message, params object[] parameters) =>
            NUnit.Framework.Assert.AreNotSame(notExpected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified objects refer to different objects and throws an
        //     exception if the two inputs refer to the same object.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is the same as notExpected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected refers to the same object as actual.
        public static void AreNotSame(object notExpected, object actual, string message) =>
            NUnit.Framework.Assert.AreNotSame(notExpected, actual, message);
        //
        // Summary:
        //     Tests whether the specified objects refer to different objects and throws an
        //     exception if the two inputs refer to the same object.
        //
        // Parameters:
        //   notExpected:
        //     The first object to compare. This is the value the test expects not to match
        //     actual.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if notExpected refers to the same object as actual.
        public static void AreNotSame(object notExpected, object actual) =>
            NUnit.Framework.Assert.AreNotSame(notExpected, actual);
        //
        // Summary:
        //     Tests whether the specified objects both refer to the same object and throws
        //     an exception if the two inputs do not refer to the same object.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the value the test expects.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected does not refer to the same object as actual.
        public static void AreSame(object expected, object actual) =>
            NUnit.Framework.Assert.AreSame(expected, actual);
        //
        // Summary:
        //     Tests whether the specified objects both refer to the same object and throws
        //     an exception if the two inputs do not refer to the same object.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the value the test expects.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not the same as expected.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected does not refer to the same object as actual.
        public static void AreSame(object expected, object actual, string message, params object[] parameters) =>
            NUnit.Framework.Assert.AreSame(expected, actual, message, parameters);
        //
        // Summary:
        //     Tests whether the specified objects both refer to the same object and throws
        //     an exception if the two inputs do not refer to the same object.
        //
        // Parameters:
        //   expected:
        //     The first object to compare. This is the value the test expects.
        //
        //   actual:
        //     The second object to compare. This is the value produced by the code under test.
        //
        //   message:
        //     The message to include in the exception when actual is not the same as expected.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if expected does not refer to the same object as actual.
        public static void AreSame(object expected, object actual, string message) =>
            NUnit.Framework.Assert.AreSame(expected, actual, message);
        //
        // Summary:
        //     Static equals overloads are used for comparing instances of two types for reference
        //     equality. This method should not be used for comparison of two instances for
        //     equality. This object will always throw with Assert.Fail. Please use Assert.AreEqual
        //     and associated overloads in your unit tests.
        //
        // Parameters:
        //   objA:
        //     Object A
        //
        //   objB:
        //     Object B
        //
        // Returns:
        //     False, always.
        public new static bool Equals(object objA, object objB) =>
            NUnit.Framework.Assert.Equals(objA, objB);
        //
        // Summary:
        //     Throws an AssertFailedException.
        //
        // Parameters:
        //   message:
        //     The message to include in the exception. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Always thrown.
        public static void Fail(string message, params object[] parameters) =>
            NUnit.Framework.Assert.Fail(message, parameters);
        //
        // Summary:
        //     Throws an AssertFailedException.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Always thrown.
        public static void Fail() =>
            NUnit.Framework.Assert.Fail();
        //
        // Summary:
        //     Throws an AssertFailedException.
        //
        // Parameters:
        //   message:
        //     The message to include in the exception. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Always thrown.
        public static void Fail(string message) =>
            NUnit.Framework.Assert.Fail(message);
        //
        // Summary:
        //     Throws an AssertInconclusiveException.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException:
        //     Always thrown.
        public static void Inconclusive() =>
            NUnit.Framework.Assert.Inconclusive();
        //
        // Summary:
        //     Throws an AssertInconclusiveException.
        //
        // Parameters:
        //   message:
        //     The message to include in the exception. The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException:
        //     Always thrown.
        public static void Inconclusive(string message, params object[] parameters) =>
            NUnit.Framework.Assert.Inconclusive(message, parameters);
        //
        // Summary:
        //     Throws an AssertInconclusiveException.
        //
        // Parameters:
        //   message:
        //     The message to include in the exception. The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException:
        //     Always thrown.
        public static void Inconclusive(string message) =>
            NUnit.Framework.Assert.Inconclusive(message);
        //
        // Summary:
        //     Tests whether the specified condition is false and throws an exception if the
        //     condition is true.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be false.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is true.
        public static void IsFalse(bool condition) =>
            NUnit.Framework.Assert.IsFalse(condition);
        //
        // Summary:
        //     Tests whether the specified condition is false and throws an exception if the
        //     condition is true.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be false.
        //
        //   message:
        //     The message to include in the exception when condition is true. The message is
        //     shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is true.
        public static void IsFalse(bool condition, string message) =>
            NUnit.Framework.Assert.IsFalse(condition, message);
        //
        // Summary:
        //     Tests whether the specified condition is false and throws an exception if the
        //     condition is true.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be false.
        //
        //   message:
        //     The message to include in the exception when condition is true. The message is
        //     shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is true.
        public static void IsFalse(bool condition, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsFalse(condition, message, parameters);
        //
        // Summary:
        //     Tests whether the specified object is an instance of the expected type and throws
        //     an exception if the expected type is not in the inheritance hierarchy of the
        //     object.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be of the specified type.
        //
        //   expectedType:
        //     The expected type of value.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null or expectedType is not in the inheritance hierarchy of
        //     value.
        public static void IsInstanceOfType(object value, Type expectedType) =>
            NUnit.Framework.Assert.IsInstanceOf(expectedType, value);
        //
        // Summary:
        //     Tests whether the specified object is an instance of the expected type and throws
        //     an exception if the expected type is not in the inheritance hierarchy of the
        //     object.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be of the specified type.
        //
        //   expectedType:
        //     The expected type of value.
        //
        //   message:
        //     The message to include in the exception when value is not an instance of expectedType.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null or expectedType is not in the inheritance hierarchy of
        //     value.
        public static void IsInstanceOfType(object value, Type expectedType, string message) =>
            NUnit.Framework.Assert.IsInstanceOf(expectedType, value, message);
        //
        // Summary:
        //     Tests whether the specified object is an instance of the expected type and throws
        //     an exception if the expected type is not in the inheritance hierarchy of the
        //     object.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be of the specified type.
        //
        //   expectedType:
        //     The expected type of value.
        //
        //   message:
        //     The message to include in the exception when value is not an instance of expectedType.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null or expectedType is not in the inheritance hierarchy of
        //     value.
        public static void IsInstanceOfType(object value, Type expectedType, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsInstanceOf(expectedType, value, message, parameters);
        //
        // Summary:
        //     Tests whether the specified object is not an instance of the wrong type and throws
        //     an exception if the specified type is in the inheritance hierarchy of the object.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be of the specified type.
        //
        //   wrongType:
        //     The type that value should not be.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null and wrongType is in the inheritance hierarchy of
        //     value.
        public static void IsNotInstanceOfType(object value, Type wrongType) =>
            NUnit.Framework.Assert.IsNotInstanceOf(wrongType, value);
        //
        // Summary:
        //     Tests whether the specified object is not an instance of the wrong type and throws
        //     an exception if the specified type is in the inheritance hierarchy of the object.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be of the specified type.
        //
        //   wrongType:
        //     The type that value should not be.
        //
        //   message:
        //     The message to include in the exception when value is an instance of wrongType.
        //     The message is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null and wrongType is in the inheritance hierarchy of
        //     value.
        public static void IsNotInstanceOfType(object value, Type wrongType, string message, params object[] parameters) =>
            NUnit.Framework.Assert.IsNotInstanceOf(wrongType, value, message, parameters);
        //
        // Summary:
        //     Tests whether the specified object is not an instance of the wrong type and throws
        //     an exception if the specified type is in the inheritance hierarchy of the object.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be of the specified type.
        //
        //   wrongType:
        //     The type that value should not be.
        //
        //   message:
        //     The message to include in the exception when value is an instance of wrongType.
        //     The message is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null and wrongType is in the inheritance hierarchy of
        //     value.
        public static void IsNotInstanceOfType(object value, Type wrongType, string message)
            => NUnit.Framework.Assert.IsNotInstanceOf(wrongType, value, message);
        //
        // Summary:
        //     Tests whether the specified object is non-null and throws an exception if it
        //     is null.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be null.
        //
        //   message:
        //     The message to include in the exception when value is null. The message is shown
        //     in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null.
        public static void IsNotNull(object value, string message)
            => NUnit.Framework.Assert.IsNotNull(value, message);
        //
        // Summary:
        //     Tests whether the specified object is non-null and throws an exception if it
        //     is null.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be null.
        //
        //   message:
        //     The message to include in the exception when value is null. The message is shown
        //     in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null.
        public static void IsNotNull(object value, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsNotNull(value, message, parameters);
        //
        // Summary:
        //     Tests whether the specified object is non-null and throws an exception if it
        //     is null.
        //
        // Parameters:
        //   value:
        //     The object the test expects not to be null.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is null.
        public static void IsNotNull(object value)
            => NUnit.Framework.Assert.IsNotNull(value);
        //
        // Summary:
        //     Tests whether the specified object is null and throws an exception if it is not.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be null.
        //
        //   message:
        //     The message to include in the exception when value is not null. The message is
        //     shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null.
        public static void IsNull(object value, string message)
            => NUnit.Framework.Assert.IsNull(value, message);
        //
        // Summary:
        //     Tests whether the specified object is null and throws an exception if it is not.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be null.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null.
        public static void IsNull(object value)
            => NUnit.Framework.Assert.IsNull(value);
        //
        // Summary:
        //     Tests whether the specified object is null and throws an exception if it is not.
        //
        // Parameters:
        //   value:
        //     The object the test expects to be null.
        //
        //   message:
        //     The message to include in the exception when value is not null. The message is
        //     shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if value is not null.
        public static void IsNull(object value, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsNull(value, message, parameters);
        //
        // Summary:
        //     Tests whether the specified condition is true and throws an exception if the
        //     condition is false.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be true.
        //
        //   message:
        //     The message to include in the exception when condition is false. The message
        //     is shown in test results.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is false.
        public static void IsTrue(bool condition, string message)
            => NUnit.Framework.Assert.IsTrue(condition, message);
        //
        // Summary:
        //     Tests whether the specified condition is true and throws an exception if the
        //     condition is false.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be true.
        //
        //   message:
        //     The message to include in the exception when condition is false. The message
        //     is shown in test results.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is false.
        public static void IsTrue(bool condition, string message, params object[] parameters)
            => NUnit.Framework.Assert.IsTrue(condition, message, parameters);
        //
        // Summary:
        //     Tests whether the specified condition is true and throws an exception if the
        //     condition is false.
        //
        // Parameters:
        //   condition:
        //     The condition the test expects to be true.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if condition is false.
        public static void IsTrue(bool condition)
            => NUnit.Framework.Assert.IsTrue(condition);
        //
        // Summary:
        //     Replaces null characters ('\0') with "\\0".
        //
        // Parameters:
        //   input:
        //     The string to search.
        //
        // Returns:
        //     The converted string with null characters replaced by "\\0".
        //
        // Remarks:
        //     This is only public and still present to preserve compatibility with the V1 framework.
        public static string ReplaceNullChars(string input)
        {
            if (string.IsNullOrEmpty(input) == false)
            {
                input = input.Replace("\0", "\\0");
            }
            return input;
        }

        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throws exception of type T.
        public static T ThrowsException<T>(Action action) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail();
            }
            return exception as T;
        }
        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        //   message:
        //     The message to include in the exception when action does not throws exception
        //     of type T.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throws exception of type T.
        public static T ThrowsException<T>(Action action, string message) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail(message);
            }
            return exception as T;
        }
        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throws exception of type T.
        public static T ThrowsException<T>(Func<object> action) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail();
            }
            return exception as T;
        }
        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        //   message:
        //     The message to include in the exception when action does not throws exception
        //     of type T.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throws exception of type T.
        public static T ThrowsException<T>(Func<object> action, string message) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail(message);
            }
            return exception as T;
        }
        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        //   message:
        //     The message to include in the exception when action does not throws exception
        //     of type T.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throw exception of type T.
        public static T ThrowsException<T>(Func<object> action, string message, params object[] parameters) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail(message, parameters);
            }
            return exception as T;
        }
        //
        // Summary:
        //     Tests whether the code specified by delegate action throws exact given exception
        //     of type T (and not of derived type) and throws AssertFailedException if code
        //     does not throws exception or throws exception of type other than T.
        //
        // Parameters:
        //   action:
        //     Delegate to code to be tested and which is expected to throw exception.
        //
        //   message:
        //     The message to include in the exception when action does not throws exception
        //     of type T.
        //
        //   parameters:
        //     An array of parameters to use when formatting message.
        //
        // Type parameters:
        //   T:
        //     Type of exception expected to be thrown.
        //
        // Returns:
        //     The exception that was thrown.
        //
        // Exceptions:
        //   T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException:
        //     Thrown if action does not throws exception of type T.
        public static T ThrowsException<T>(Action action, string message, params object[] parameters) where T : Exception
        {
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e as T;
            }
            if (!(exception is T))
            {
                Fail(message, parameters);
            }
            return exception as T;
        }

    }

}

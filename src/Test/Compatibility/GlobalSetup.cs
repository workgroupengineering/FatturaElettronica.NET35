using NUnit.Framework;
using System;

[SetUpFixture]
public class GlobalSetup
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
        // or identically under the hoods
       // Directory.SetCurrentDirectory(TestContext.CurrentContext.TestDirectory);
    }
}
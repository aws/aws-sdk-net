using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SigninServiceClientHelpersTest
    {
        [TestMethod]
        public void EnsureClientAvailable_AssemblyMissing_ThrowsWithAssemblyName()
        {
            var exception = Assert.ThrowsExactly<InvalidOperationException>(() => SigninServiceClientHelpers.EnsureClientAvailable(
                "AWSSDK.MissingForTest", "Amazon.MissingForTest.Client", "Amazon.MissingForTest.Config", "RegisterMissingForTest"));

            StringAssert.Contains(exception.Message, "AWSSDK.MissingForTest");
        }
    }
}

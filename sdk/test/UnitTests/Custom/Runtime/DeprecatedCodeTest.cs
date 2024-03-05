using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Runtime.Internal;
using System.Threading;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DeprecatedCodeTest
    {
#if BCL
        /// <summary>
        /// Although AsyncRunner isn't used anymore older versions of AWSSDK.DynamoDBv2 still reference it.
        /// This test is to make sure we don't remove the class on accident breakinng older versions of AWSSDK.DynamoDBv2
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestAsyncRunner()
        {
            StringBuilder sb = new StringBuilder();
            var task = AsyncRunner.Run(() => sb.Append("Done"), default(CancellationToken));
            task.Wait();
            Assert.AreEqual("Done", sb.ToString());
        }
#endif
    }
}

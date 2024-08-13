using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2.Model;
using System.Reflection;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon;

namespace AWSSDK_DotNet.UnitTests.EC2
{
    [TestClass]
    public class EC2IpRangePropertyTest
    {
        /// <summary>
        /// The IpRange property values are copied one by one when creating a new IpRange object.
        /// This test ensures that no new property has been added to the IpRange object without the .NET SDK team being notified.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void ValidatePropertyCountEC2IpRange()
        {
            Assert.AreEqual(typeof(IpRange).GetProperties().Length, 2);  
        }
    }
}

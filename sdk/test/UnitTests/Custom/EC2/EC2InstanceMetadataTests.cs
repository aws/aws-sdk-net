using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2.Model;
using System.Reflection;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon;

namespace AWSSDK_DotNet35.UnitTests.EC2
{
    [TestClass]
    public class EC2InstanceMetadataTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void TestAccessingEC2InstanceMetadataProperties()
        {
            var metadataType = typeof(Amazon.Util.EC2InstanceMetadata);
            var allMembers = metadataType.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

            foreach (var member in allMembers)
            {
                var fi = member as FieldInfo;
                var pi = member as PropertyInfo;

                object value;
                if (pi != null)
                {
                    value = pi.GetValue(null);
                    // all properties should return null on non-EC2 instances
                    Assert.IsNull(value, "Property {0} should be null", pi.Name);
                }
                else if (fi != null)
                {
                    value = fi.GetValue(null);
                    // all fields should return non-null on non-EC2 instances
                    Assert.IsNotNull(value, "Field {0} should not be null", fi.Name);
                }
            }
        }
    }
}

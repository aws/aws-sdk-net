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
            using (var servlet = new AWSSDK_DotNet.CommonTest.Utils.ResponseTestServlet())
            {
                servlet.Response = string.Empty;
                servlet.StatusCode = 404;

                var metadataType = typeof(Amazon.Util.EC2InstanceMetadata);
                var currentEMSValue = GetField(metadataType, "EC2_METADATA_SVC");

                Action setEMSAction = () => SetEC2InstanceMetadataFields(metadataType, servlet.ServiceURL);
                Action resetEMSAction = () => SetEC2InstanceMetadataFields(metadataType, currentEMSValue);

                using (new DisposableSwitch(setEMSAction, resetEMSAction))
                {
                    var allMembers = metadataType.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    foreach (var member in allMembers)
                    {
                        var fi = member as FieldInfo;
                        var pi = member as PropertyInfo;

                        object value;

                        // make and exception for IsIMDSEnabled property
                        if (pi != null && !pi.Name.Equals("IsIMDSEnabled"))
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

        /*
            public static readonly string
            EC2_METADATA_SVC = "http://169.254.169.254",
            LATEST = "/latest",
            EC2_METADATA_ROOT = EC2_METADATA_SVC + LATEST + "/meta-data",
            EC2_USERDATA_ROOT = EC2_METADATA_SVC + LATEST + "/user-data",
            EC2_DYNAMICDATA_ROOT = EC2_METADATA_SVC + LATEST + "/dynamic";
        */

        private static void SetEC2InstanceMetadataFields(Type metadataType, string address)
        {
            var latest = Amazon.Util.EC2InstanceMetadata.LATEST;
            SetField(metadataType, "EC2_METADATA_SVC", address);
            SetField(metadataType, "EC2_METADATA_ROOT", address + latest + "/meta-data");
            SetField(metadataType, "EC2_USERDATA_ROOT", address + latest + "/user-data");
            SetField(metadataType, "EC2_DYNAMICDATA_ROOT", address + latest + "/dynamic");
        }
        private static string GetField(Type metadataType, string fieldName)
        {
            var fi = metadataType.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
            return fi.GetValue(null) as string;
        }
        private static void SetField(Type metadataType, string fieldName, string fieldValue)
        {
            var fi = metadataType.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
            fi.SetValue(null, fieldValue);
        }
    }
}

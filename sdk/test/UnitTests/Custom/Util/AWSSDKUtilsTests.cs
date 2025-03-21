/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSSDKUtilsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestUserAgentValue()
        {
            var metadataType = typeof(AWSSDKUtils);
            var fi = metadataType.GetField("_userAgent", BindingFlags.NonPublic | BindingFlags.Static);
            var userAgentValue = fi.GetValue(null) as string;
            Assert.IsNotNull(userAgentValue);

            //The user-agent will have a format similar to one of the following depending on OS and version of .NET:
            //aws-sdk-dotnet-coreclr/ aws-sdk-dotnet-core/3.3.31.8 .NET_Core/4.6.27129.04 OS/Microsoft_Windows_10.0.17134
            var regex = new System.Text.RegularExpressions.Regex("aws-sdk-dotnet-.+md/aws-sdk-dotnet-core#");
            Assert.IsTrue(regex.IsMatch(userAgentValue));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestNewUserAgentValue()
        {
            var metadataType = typeof(AWSSDKUtils);
            var fi = metadataType.GetField("_userAgent", BindingFlags.NonPublic | BindingFlags.Static);
            var userAgentValue = fi.GetValue(null) as string;
            Assert.IsNotNull(userAgentValue);

            //The user-agent will have a format similar to one of the following depending on OS and version of .NET:
            //"aws-sdk-dotnet-45/3.7.300.16 md/aws-sdk-dotnet-core#3.7.300.16 ua/2.0 os/windows#6.2.9200.0 lang/.NET_Runtime#4.0 md/.NET_Framework#4.8.09037"
            var regexStr = @"aws-sdk-dotnet-([^ ]+) +ua/([\d.]+) +os/([^ ]+) +lang/.+#([\d.]+) +md/.NET_Framework#([\d.]+) .+";
            var regex = new System.Text.RegularExpressions.Regex(regexStr);
            Assert.IsTrue(regex.IsMatch(userAgentValue), $"User agent \"{userAgentValue}\" fails regex \"{regexStr}\"");
            Assert.IsTrue(userAgentValue.Contains("md/aws-sdk-dotnet-core#"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestWhiteSpaceCompression()
        {
            const string text = "qqdglmcdoxtqiwwlucjv      xtehwhfhchtkhgoufyzgtkxvgcmcyvifp  sgseqpnzvaecjcwdjsylcilfkh";
            Assert.IsFalse(AWSSDKUtils.CompressSpaces(text).Contains("  "));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestIsAbsolutePathBadInput()
        {
            Assert.IsFalse(AWSSDKUtils.IsAbsolutePath(new string(Path.GetInvalidPathChars())));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestIsAbsolutePathEmpty()
        {
            Assert.IsFalse(AWSSDKUtils.IsAbsolutePath(""));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestIsAbsolutePath()
        {
            Assert.IsTrue(AWSSDKUtils.IsAbsolutePath(Directory.GetCurrentDirectory()));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestIsAbsolutePathFailsForRelative()
        {
            Assert.IsFalse(AWSSDKUtils.IsAbsolutePath(Path.Combine(".", "File")));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestIsPropertySet()
        {
            var shape = new Amazon.EC2.Model.CreateCapacityReservationRequest();
            Assert.IsFalse(AWSSDKUtils.IsPropertySet(shape, nameof(shape.EbsOptimized)));
            Assert.IsFalse(AWSSDKUtils.IsPropertySet(shape, nameof(shape.EndDate)));
            Assert.IsFalse(AWSSDKUtils.IsPropertySet(shape, nameof(shape.ClientToken)));

            shape.EbsOptimized = true;
            shape.EndDate = DateTime.UtcNow;
            shape.ClientToken = "";

            Assert.IsTrue(AWSSDKUtils.IsPropertySet(shape, nameof(shape.EbsOptimized)));
            Assert.IsTrue(AWSSDKUtils.IsPropertySet(shape, nameof(shape.EndDate)));
            Assert.IsTrue(AWSSDKUtils.IsPropertySet(shape, nameof(shape.ClientToken)));

            try
            {
                AWSSDKUtils.IsPropertySet(shape, "foo");
                Assert.Fail();
            }
            catch (Exception e)
            {
                //We expect ArgumentException for non existing properties
                Assert.IsInstanceOfType(e, typeof(ArgumentException));
            }

            try
            {
                AWSSDKUtils.IsPropertySet(Amazon.EC2.PrincipalType.Account, "foo");
                Assert.Fail();
            }
            catch (Exception e)
            {
                //We expect ArgumentException for classes in non-Model namespaces
                Assert.IsInstanceOfType(e, typeof(ArgumentException));
            }

            var s3Shape = new Amazon.S3.Model.PutObjectTaggingRequest();
            try
            {
                AWSSDKUtils.IsPropertySet(s3Shape, nameof(s3Shape.BucketName));
                Assert.Fail();
            }
            catch (Exception e)
            {
                //We expect ArgumentException for S3 model classes
                Assert.IsInstanceOfType(e, typeof(ArgumentException));
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void ConvertFromUnixEpochSeconds()
        {
            // Sample UTC value: 9/8/2020 18:48:34
            var expectedDateTime = new DateTime(2020, 9, 8, 18, 48, 34, DateTimeKind.Utc);
            var dateTime = AWSSDKUtils.ConvertFromUnixEpochMilliseconds(1599590914000);
            
            Assert.AreEqual(expectedDateTime, dateTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void ConvertFromUnixEpochMilliseconds()
        {
            // Sample UTC value: 9/8/2020 18:48:34.970
            var expectedDateTime = new DateTime(2020, 9, 8, 18, 48, 34, DateTimeKind.Utc).AddMilliseconds(970);
            var dateTime = AWSSDKUtils.ConvertFromUnixEpochMilliseconds(1599590914970);
            
            Assert.AreEqual(expectedDateTime, dateTime);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("Hello World", true, "48656c6c6f20576f726c64")]
        [DataRow("Hello World", false, "48656C6C6F20576F726C64")]
        [DataTestMethod]
        public void ToHex(string input, bool lowercase, string expectedResult)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hexString = AWSSDKUtils.ToHex(bytes, lowercase);

            Assert.AreEqual(expectedResult, hexString);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataTestMethod]
        [DataRow(null, null)]
        [DataRow("no-delimiters-at-all", "")]
        [DataRow("delimiter-end-of-string.", "")]
        [DataRow("relative-path/no-file-extension", "")]
        [DataRow("relative-path\\no-file-extension", "")]
        [DataRow("relative-path:no-file-extension", "")]
        [DataRow("simple-file.pdf", ".pdf")]
        [DataRow("relative-path/with-file-extension.pdf", ".pdf")]
        [DataRow("relative-path.with-dot/with-file-extension.pdf", ".pdf")]
        public void GetExtension(string input, string expected)
        {
            var actual = AWSSDKUtils.GetExtension(input);

            Assert.AreEqual(expected, actual);
        }
    }
}

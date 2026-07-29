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
using Amazon.Runtime.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

#if NETFRAMEWORK
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
#endif

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("qqdglmcdoxtqiwwlucjv      xtehwhfhchtkhgoufyzgtkxvgcmcyvifp  sgseqpnzvaecjcwdjsylcilfkh", "qqdglmcdoxtqiwwlucjv xtehwhfhchtkhgoufyzgtkxvgcmcyvifp sgseqpnzvaecjcwdjsylcilfkh")]
        [DataRow("input \ttext", "input text")]
        [DataRow("input \ntext", "input text")]
        [DataRow("input \r\ntext", "input text")]
        [DataRow("input\ttext", "input text")]
        [DataRow(" input text ", " input text ")]
        public void CompressSpaces_ReplacesWhitespaceWithSingleSpace_WhenInputContainsVariousWhitespaceCharacters(string inputText, string expected)
        {
            var compressed = AWSSDKUtils.CompressSpaces(inputText);
            Assert.AreEqual(expected, compressed);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void CompressSpaces_ReturnsSameString_WhenInputContainsSingleSpaceOnly()
        {
            const string input = "input text";
            var compressed = AWSSDKUtils.CompressSpaces(input);
            Assert.AreSame(input, compressed);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("  hello world  ", "hello world")]
        [DataRow("  hello   world  ", "hello world")]
        [DataRow("hello world", "hello world")]
        [DataRow(" A  B  C  ", "A B C")]
        [DataRow("   A   B \tC D ", "A B C D")]
        [DataRow("   AB  C D  ", "AB C D")]
        [DataRow("A  B C  D  ", "A B C D")]
        [DataRow("  ", "")]
        public void CompressSpaces_TrimsLeadingAndTrailing_WhenTrimIsTrue(string inputText, string expected)
        {
            var compressed = AWSSDKUtils.CompressSpaces(inputText, trim: true);
            Assert.AreEqual(expected, compressed);
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
            var shape = new Amazon.DynamoDBv2.Model.CreateTableRequest();
            Assert.IsFalse(AWSSDKUtils.IsPropertySet(shape, nameof(shape.DeletionProtectionEnabled)));
            Assert.IsFalse(AWSSDKUtils.IsPropertySet(shape, nameof(shape.TableName)));

            shape.DeletionProtectionEnabled = true;
            shape.TableName = "";

            Assert.IsTrue(AWSSDKUtils.IsPropertySet(shape, nameof(shape.DeletionProtectionEnabled)));
            Assert.IsTrue(AWSSDKUtils.IsPropertySet(shape, nameof(shape.TableName)));

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
                AWSSDKUtils.IsPropertySet(Amazon.DynamoDBv2.BillingMode.PAY_PER_REQUEST, "foo");
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
        [TestMethod]
        public void ToHex(string input, bool lowercase, string expectedResult)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hexString = AWSSDKUtils.ToHex(bytes, lowercase);

            Assert.AreEqual(expectedResult, hexString);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
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

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void GenerateMemoryStreamFromString_ReturnsReadableStream_WhenInputIsValid()
        {
            var input = "Hello World";
            var expectedBytes = Encoding.UTF8.GetBytes(input);
            using var memoryStream = AWSSDKUtils.GenerateMemoryStreamFromString(input);
            var actualBytes = new byte[memoryStream.Length];
            memoryStream.Read(actualBytes, 0, actualBytes.Length);
            CollectionAssert.AreEqual(expectedBytes, actualBytes);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void DictionariesAreEqual_ReturnsTrue_WhenDictionariesAreEqual()
        {
            var dict1 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
            var dict2 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
            Assert.IsTrue(AWSSDKUtils.DictionariesAreEqual(dict1, dict2));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void DictionariesAreEqual_ReturnsFalse_WhenDictionariesAreNotEqual()
        {
            var dict1 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
            var dict2 = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "differentValue" }
            };
            Assert.IsFalse(AWSSDKUtils.DictionariesAreEqual(dict1, dict2));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("12345")]
        [TestMethod]
        public void HexStringToBytes_ThrowsArgumentOutOfRangeException_WhenInputIsInvalid(string input)
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => AWSSDKUtils.HexStringToBytes(input));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void HexStringToBytes_ThrowsFormatException_WhenInputIsNotValidHexString()
        {
            Assert.ThrowsExactly<FormatException>(() => AWSSDKUtils.HexStringToBytes("123H"));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("48656c6c6f20576f726c64", "Hello World")]
        [DataRow("48656C6C6F20576F726C64", "Hello World")]
        [TestMethod]
        public void HexStringToBytes_ReturnsCorrectBytes_WhenInputIsValidHexString(string hexString, string expectedString)
        {
            var expectedBytes = Encoding.UTF8.GetBytes(expectedString);
            var actualBytes = AWSSDKUtils.HexStringToBytes(hexString);
            CollectionAssert.AreEqual(expectedBytes, actualBytes);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void GenerateChecksumForBytes_ReturnsCorrectChecksum_WhenHexEncodingIsUsed()
        {
            var input = "Hello World";
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var expectedChecksum = "B10A8DB164E0754105B7A99BE72E3FE5";
            var actualChecksum = AWSSDKUtils.GenerateChecksumForBytes(inputBytes, false);
            Assert.AreEqual(expectedChecksum, actualChecksum);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        [DataRow("https://example.com", "POST\nexample.com\n/")]
        [DataRow("https://example.com/", "POST\nexample.com\n/")]
        [DataRow("https://example.com/path", "POST\nexample.com\n/path")]
        public void CalculateStringToSignV2_ShouldReturnStringWithoutTrailingWhitespace_WhenCalledWithEmptyParameterCollection(string serviceUrl, string expectedResult)
        {
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(new ParameterCollection(), serviceUrl);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void CalculateStringToSignV2_ShouldReturnStringWithSingleParameter_WhenCalledWithParameterCollectionSizedOne()
        {
            var parameters = new ParameterCollection
            {
                { "param1", "value1" }
            };
            var serviceUrl = "https://example.com/path";
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceUrl);
            var expectedResult = "POST\nexample.com\n/path\nparam1=value1";
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void CalculateStringToSignV2_ShouldReturnStringWithMultipleParameters_WhenCalledWithNonEmptyParameterCollectionSizedTwo()
        {
            var parameters = new ParameterCollection
            {
                { "param1", "value1" },
                { "param2", "value2" }
            };
            var serviceUrl = "https://example.com/path";
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceUrl);
            var expectedResult = "POST\nexample.com\n/path\nparam1=value1&param2=value2";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void CalculateStringToSignV2_ShouldReturnSanitizedString_WhenServiceUrlContainsSpecialCharacters()
        {
            var parameters = new ParameterCollection();
            var serviceUrl = "https://example.com/path with spaces";
            var expectedResult = "POST\nexample.com\n/path%2520with%2520spaces";
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceUrl);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void CalculateStringToSignV2_ShouldReturnSanitizedStringWithoutQuery_WhenServiceUrlContainsQuery()
        {
            var parameters = new ParameterCollection();
            var serviceUrl = "https://example.com/path?query=param";
            var expectedResult = "POST\nexample.com\n/path";
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceUrl);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [TestMethod]
        public void CalculateStringToSignV2_ShouldReturnSanitizedStringWithEncodedParameters_WhenParametersContainSpecialCharacters()
        {
            var parameters = new ParameterCollection
            {
                { "param1&", "value1=" }
            };
            var serviceUrl = "https://example.com";
            var expectedResult = "POST\nexample.com\n/\nparam1%26=value1%3D";
            var actualResult = AWSSDKUtils.CalculateStringToSignV2(parameters, serviceUrl);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

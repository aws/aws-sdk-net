/*
 * Copyright 2015-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using System.Globalization;
using Amazon.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AWSSDKUtilsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_NoChanges()
        {
            var testUrl = "http://xyz.amazonaws.com/path/value1%2Fvalue2";
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode(testUrl, true);
            Assert.AreEqual(testUrl, encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_Encoding()
        {            
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode("http://xyz.amazonaws.com/path%1/value1%2Fvalue2", true);
            Assert.AreEqual("http://xyz.amazonaws.com/path%251/value1%2Fvalue2", encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_NotAPath()
        {            
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode("/xyz/def%2Fhij/abc/", false);
            Assert.AreEqual("%2Fxyz%2Fdef%2Fhij%2Fabc%2F", encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_EmptyString()
        {            
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode(string.Empty, true);
            Assert.AreEqual(string.Empty, encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_NullString()
        {
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode(null, true);
            Assert.AreEqual(null, encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_EncodedSlashAlone()
        {
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode("%2F", true);
            Assert.AreEqual("%2F", encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_EndingEncodedSlash()
        {
            var testUrl = "http://xyz.amazonaws.com/path%2F";
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode(testUrl, true);
            Assert.AreEqual(testUrl, encodedUrl);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        public void TestProtectSlashUrlEncode_StartingEncodedSlash()
        {
            var testUrl = "%2Fabc123";
            var encodedUrl = AWSSDKUtils.ProtectEncodedSlashUrlEncode(testUrl, true);
            Assert.AreEqual(testUrl, encodedUrl);
        }

    }
}

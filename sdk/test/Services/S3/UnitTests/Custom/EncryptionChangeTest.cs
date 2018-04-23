/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Encryption.Internal;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EncryptionChangeTest
    {
        private const string ExpectedHash = "6D128C72FFFDCD7BD85ACA1A7BD600AB3BD1F9F9D57EF56DE422B184594B5C28";
        private const string Message = "Manually run EncryptionInteropTest.cs and EncryptionInteropTest.java.";

        private static readonly List<string> SourceFiles = new List<string>
            {
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\AmazonS3EncryptionClient.cs",
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\EncryptionMaterials.cs",
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\EncryptionUtils.cs",
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\Internal\\SetupDecryptionHandler.cs",
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\Internal\\SetupEncryptionHandler.cs",
                 "Services\\S3\\Custom\\_bcl+coreclr\\Encryption\\UploadPartContextForEncryption.cs",
            };

        [TestMethod]
        [TestCategory("S3")]
        public void MakeSureEncryptionInteropTestIsUpToDate()
        {
            AssertExtensions.AssertSourceCodeUnchanged(SourceFiles, ExpectedHash, Message);
        }
    }
}
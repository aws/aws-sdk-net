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
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// To run these tests you need two AWS accounts.
    /// To run the tests:
    /// 1. Create a bucket in account A and set it up to be a requester pays bucket.
    /// 2. Put the bucket name into the BucketName variable.
    /// 3. Create an object in the new bucket with key "testobject.txt" and contents "testing".
    /// 4. Give account B read permission on the object.
    /// 5. Create a stored profile with credentials for account A and put the name in the OwningProfileName variable.
    /// 6. Create a stored profile with credentials for account B and put the name in the OtherProfileName variable.
    /// 7. Commment or remove the [Ignore] attribute.
    /// 8. Run the tests.
    /// </summary>
    [Ignore]
    [TestClass]
    public class RequesterPaysTests : TestBase<AmazonS3Client>
    {
        private const string BucketName = "";
        private const string OwningProfileName = "";
        private const string OtherProfileName = "";

        private const string Key = "testobject.txt";
        private const string Content = "testing";

        private static readonly RegionEndpoint Region = RegionEndpoint.USWest2;

        [TestMethod]
        [TestCategory("S3")]
        public void RequesterPaysFromOwningAccountSigV2()
        {
            TestRequesterPays(OwningProfileName, RequestPayer.Requester, false);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RequesterPaysFromOtherAccountSigV2()
        {
            TestRequesterPays(OtherProfileName, RequestPayer.Requester, false);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RequesterPaysFromOwningAccountSigV4()
        {
            TestRequesterPays(OwningProfileName, RequestPayer.Requester, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RequesterPaysFromOtherAccountSigV4()
        {
            TestRequesterPays(OtherProfileName, RequestPayer.Requester, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MissingRequesterPaysFromOwningAccountSigV2()
        {
            TestRequesterPays(OwningProfileName, null, false);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MissingRequesterPaysFromOtherAccountSigV2()
        {
            AssertExtensions.ExpectException(() =>
            {
                TestRequesterPays(OtherProfileName, null, false);
            }, typeof(WebException), "The remote server returned an error: (403) Forbidden.");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MissingRequesterPaysFromOwningAccountSigV4()
        {
            TestRequesterPays(OwningProfileName, null, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MissingRequesterPaysFromOtherAccountSigV4()
        {
            AssertExtensions.ExpectException(() =>
            {
                TestRequesterPays(OtherProfileName, null, true);
            }, typeof(WebException), "The remote server returned an error: (403) Forbidden.");
        }

        private void TestRequesterPays(string profileName, RequestPayer requestPayer, bool useSigV4)
        {
            var originalUseSigV4 = AWSConfigsS3.UseSignatureVersion4;
            try
            {
                AWSConfigsS3.UseSignatureVersion4 = useSigV4;

                CredentialProfile profile;
                var credsFile = new CredentialProfileStoreChain();
                if (credsFile.TryGetProfile(profileName, out profile))
                {
                    var credentials = AWSCredentialsFactory.GetAWSCredentials(profile, credsFile);

                    var client = new AmazonS3Client(credentials, Region);
                    var url = client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = BucketName,
                        Key = Key,
                        Expires = DateTime.Now.AddMinutes(20),
                        RequestPayer = requestPayer
                    });

                    var wc = new WebClient();
                    Assert.AreEqual(wc.DownloadString(url), Content);
                }
                else
                {
                    throw new ArgumentException("The profile " + profileName + "does not exist.");
                }
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = originalUseSigV4;
            }
        }
    }
}
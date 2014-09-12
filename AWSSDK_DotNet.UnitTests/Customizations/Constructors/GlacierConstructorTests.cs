/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Glacier;
using Amazon.Glacier.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class GlacierConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void AbortMultipartUploadRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.AbortMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.AbortMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void CompleteMultipartUploadRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.CompleteMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.CompleteMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void CreateVaultRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.CreateVaultRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.CreateVaultRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void DeleteArchiveRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteArchiveRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteArchiveRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void DeleteVaultRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteVaultRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteVaultRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void DeleteVaultNotificationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteVaultNotificationsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DeleteVaultNotificationsRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void DescribeJobRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DescribeJobRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DescribeJobRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void DescribeVaultRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DescribeVaultRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.DescribeVaultRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void GetJobOutputRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.GetJobOutputRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.GetJobOutputRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void GetVaultNotificationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.GetVaultNotificationsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.GetVaultNotificationsRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void InitiateJobRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.InitiateJobRequest), new System.Type[] { typeof(string), typeof(JobParameters), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.InitiateJobRequest), new System.Type[] { typeof(string), typeof(string), typeof(JobParameters), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void InitiateMultipartUploadRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.InitiateMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), typeof(long), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.InitiateMultipartUploadRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(long), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void ListJobsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListJobsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListJobsRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void ListMultipartUploadsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListMultipartUploadsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListMultipartUploadsRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void ListPartsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListPartsRequest), new System.Type[] { typeof(string), typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListPartsRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void ListVaultsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListVaultsRequest), new System.Type[] { typeof(string), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.ListVaultsRequest), new System.Type[] { typeof(string), typeof(string), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void SetVaultNotificationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.SetVaultNotificationsRequest), new System.Type[] { typeof(string), typeof(VaultNotificationConfig), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.SetVaultNotificationsRequest), new System.Type[] { typeof(string), typeof(string), typeof(VaultNotificationConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void UploadArchiveRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.UploadArchiveRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(Stream), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.UploadArchiveRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Stream), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("Glacier")]
        public void UploadMultipartPartRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.UploadMultipartPartRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Stream), });
            EnsureConstructorExists(typeof(Amazon.Glacier.Model.UploadMultipartPartRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(Stream), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}
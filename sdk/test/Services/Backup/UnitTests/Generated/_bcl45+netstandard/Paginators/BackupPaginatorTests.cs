#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */

using Amazon.Backup;
using Amazon.Backup.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BackupPaginatorTests
    {
        private static Mock<AmazonBackupClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBackupClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupPlansTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlansRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupPlansResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupPlansResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupPlans(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupPlans(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupPlansTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlansRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupPlansResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupPlans(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupPlans(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupPlanTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupPlanTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupPlanTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupPlanTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupPlanTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupPlanTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupPlanTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupPlanVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlanVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupPlanVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupPlanVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupPlanVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupPlanVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupPlanVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupPlanVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupPlanVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupPlanVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupPlanVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupSelectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupSelectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupSelectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupSelectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupSelections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupSelections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupSelectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupSelectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupSelectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupSelections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupSelections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListBackupVaultsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupVaultsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBackupVaultsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBackupVaultsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBackupVaults(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBackupVaults(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBackupVaultsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBackupVaultsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBackupVaultsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBackupVaults(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBackupVaults(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListCopyJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCopyJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCopyJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCopyJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCopyJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCopyJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCopyJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCopyJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCopyJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCopyJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCopyJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListProtectedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProtectedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProtectedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProtectedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProtectedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProtectedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListProtectedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProtectedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProtectedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListRecoveryPointsByBackupVaultTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecoveryPointsByBackupVault(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecoveryPointsByBackupVault(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecoveryPointsByBackupVaultTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecoveryPointsByBackupVaultResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecoveryPointsByBackupVault(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecoveryPointsByBackupVault(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListRecoveryPointsByResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecoveryPointsByResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecoveryPointsByResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecoveryPointsByResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecoveryPointsByResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecoveryPointsByResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecoveryPointsByResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListRestoreJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRestoreJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRestoreJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRestoreJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRestoreJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRestoreJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRestoreJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRestoreJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRestoreJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRestoreJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRestoreJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        public void ListTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Backup")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
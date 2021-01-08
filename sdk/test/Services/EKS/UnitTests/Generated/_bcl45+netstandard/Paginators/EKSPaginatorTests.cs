#if !NETSTANDARD13
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

/*
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */

using Amazon.EKS;
using Amazon.EKS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class EKSPaginatorTests
    {
        private static Mock<AmazonEKSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonEKSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void DescribeAddonVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAddonVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAddonVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAddonVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAddonVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAddonVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAddonVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAddonVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAddonVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAddonVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAddonVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void ListAddonsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAddonsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAddonsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAddonsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAddons(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAddons(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAddonsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAddonsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAddonsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAddons(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAddons(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void ListClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void ListFargateProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFargateProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFargateProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFargateProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFargateProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFargateProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFargateProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFargateProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFargateProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFargateProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFargateProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void ListNodegroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNodegroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNodegroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNodegroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNodegroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNodegroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNodegroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNodegroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNodegroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNodegroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNodegroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        public void ListUpdatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUpdatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUpdatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUpdatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUpdates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUpdates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EKS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUpdatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUpdatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListUpdatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUpdates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUpdates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
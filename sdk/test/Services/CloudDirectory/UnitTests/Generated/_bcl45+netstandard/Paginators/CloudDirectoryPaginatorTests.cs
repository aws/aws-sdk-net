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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */

using Amazon.CloudDirectory;
using Amazon.CloudDirectory.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudDirectoryPaginatorTests
    {
        private static Mock<AmazonCloudDirectoryClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudDirectoryClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListAppliedSchemaArnsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppliedSchemaArnsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppliedSchemaArnsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppliedSchemaArnsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppliedSchemaArns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppliedSchemaArns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppliedSchemaArnsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppliedSchemaArnsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppliedSchemaArnsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppliedSchemaArns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppliedSchemaArns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListAttachedIndicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedIndicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttachedIndicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttachedIndicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttachedIndices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttachedIndices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttachedIndicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedIndicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttachedIndicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttachedIndices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttachedIndices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListDevelopmentSchemaArnsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevelopmentSchemaArnsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevelopmentSchemaArnsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevelopmentSchemaArnsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevelopmentSchemaArns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevelopmentSchemaArns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevelopmentSchemaArnsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevelopmentSchemaArnsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevelopmentSchemaArnsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevelopmentSchemaArns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevelopmentSchemaArns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListDirectoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDirectoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDirectoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDirectoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDirectories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDirectories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDirectoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDirectoriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDirectoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDirectories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDirectories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListFacetAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFacetAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFacetAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFacetAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFacetAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFacetAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFacetAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFacetAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFacetAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFacetAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFacetAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListFacetNamesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFacetNamesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFacetNamesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFacetNamesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFacetNames(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFacetNames(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFacetNamesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFacetNamesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFacetNamesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFacetNames(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFacetNames(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListIndexTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIndexRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIndexResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIndexResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIndex(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIndex(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIndexTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIndexRequest>();

            var response = InstantiateClassGenerator.Execute<ListIndexResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIndex(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIndex(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListManagedSchemaArnsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedSchemaArnsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListManagedSchemaArnsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListManagedSchemaArnsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListManagedSchemaArns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListManagedSchemaArns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListManagedSchemaArnsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedSchemaArnsRequest>();

            var response = InstantiateClassGenerator.Execute<ListManagedSchemaArnsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListManagedSchemaArns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListManagedSchemaArns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListObjectAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListObjectAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListObjectAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListObjectChildrenTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectChildrenRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectChildrenResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectChildrenResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListObjectChildren(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectChildren(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectChildrenTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectChildrenRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectChildrenResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListObjectChildren(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectChildren(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListObjectParentPathsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectParentPathsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectParentPathsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectParentPathsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListObjectParentPaths(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectParentPaths(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectParentPathsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectParentPathsRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectParentPathsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListObjectParentPaths(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectParentPaths(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListObjectParentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectParentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectParentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectParentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListObjectParents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectParents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectParentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectParentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectParentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListObjectParents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectParents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListObjectPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListObjectPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListObjectPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListPolicyAttachmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyAttachmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPolicyAttachmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPolicyAttachmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPolicyAttachments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicyAttachments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPolicyAttachmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyAttachmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPolicyAttachmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPolicyAttachments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicyAttachments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListPublishedSchemaArnsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPublishedSchemaArnsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPublishedSchemaArnsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPublishedSchemaArnsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPublishedSchemaArns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPublishedSchemaArns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPublishedSchemaArnsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPublishedSchemaArnsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPublishedSchemaArnsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPublishedSchemaArns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPublishedSchemaArns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListTypedLinkFacetAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTypedLinkFacetAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTypedLinkFacetAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTypedLinkFacetAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTypedLinkFacetAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTypedLinkFacetAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTypedLinkFacetAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTypedLinkFacetAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTypedLinkFacetAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTypedLinkFacetAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTypedLinkFacetAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void ListTypedLinkFacetNamesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTypedLinkFacetNamesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTypedLinkFacetNamesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTypedLinkFacetNamesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTypedLinkFacetNames(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTypedLinkFacetNames(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTypedLinkFacetNamesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTypedLinkFacetNamesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTypedLinkFacetNamesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTypedLinkFacetNames(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTypedLinkFacetNames(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        public void LookupPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<LookupPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<LookupPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<LookupPolicyResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.LookupPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.LookupPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudDirectory")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void LookupPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<LookupPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<LookupPolicyResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.LookupPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.LookupPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
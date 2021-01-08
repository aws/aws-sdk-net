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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */

using Amazon.ACMPCA;
using Amazon.ACMPCA.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ACMPCAPaginatorTests
    {
        private static Mock<AmazonACMPCAClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonACMPCAClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ACMPCA")]
        public void ListCertificateAuthoritiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificateAuthoritiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCertificateAuthoritiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCertificateAuthoritiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCertificateAuthorities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCertificateAuthorities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ACMPCA")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCertificateAuthoritiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificateAuthoritiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCertificateAuthoritiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCertificateAuthorities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCertificateAuthorities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ACMPCA")]
        public void ListPermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ACMPCA")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ACMPCA")]
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
        [TestCategory("ACMPCA")]
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
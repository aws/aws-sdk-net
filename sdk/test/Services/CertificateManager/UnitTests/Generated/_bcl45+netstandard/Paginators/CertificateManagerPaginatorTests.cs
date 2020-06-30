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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */

using Amazon.CertificateManager;
using Amazon.CertificateManager.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CertificateManagerPaginatorTests
    {
        private static Mock<AmazonCertificateManagerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCertificateManagerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CertificateManager")]
        public void ListCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CertificateManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
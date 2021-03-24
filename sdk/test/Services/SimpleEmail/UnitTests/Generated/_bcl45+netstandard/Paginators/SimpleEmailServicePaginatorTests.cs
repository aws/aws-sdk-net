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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleEmailServicePaginatorTests
    {
        private static Mock<AmazonSimpleEmailServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleEmailServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmail")]
        public void ListCustomVerificationEmailTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomVerificationEmailTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomVerificationEmailTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomVerificationEmailTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomVerificationEmailTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomVerificationEmailTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmail")]
        public void ListIdentitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIdentitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIdentitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIdentities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIdentities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIdentitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentitiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListIdentitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIdentities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIdentities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
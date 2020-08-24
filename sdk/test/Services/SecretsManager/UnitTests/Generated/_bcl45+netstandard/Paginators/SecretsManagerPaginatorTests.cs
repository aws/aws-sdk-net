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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */

using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SecretsManagerPaginatorTests
    {
        private static Mock<AmazonSecretsManagerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSecretsManagerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecretsManager")]
        public void ListSecretsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecretsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecretsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecretsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecrets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecrets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecretsManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecretsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecretsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecretsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecrets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecrets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecretsManager")]
        public void ListSecretVersionIdsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecretVersionIdsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecretVersionIdsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecretVersionIdsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecretVersionIds(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecretVersionIds(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SecretsManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecretVersionIdsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecretVersionIdsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecretVersionIdsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecretVersionIds(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecretVersionIds(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
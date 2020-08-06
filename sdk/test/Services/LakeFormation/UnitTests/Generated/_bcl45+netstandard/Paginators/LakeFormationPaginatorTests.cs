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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */

using Amazon.LakeFormation;
using Amazon.LakeFormation.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LakeFormationPaginatorTests
    {
        private static Mock<AmazonLakeFormationClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLakeFormationClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void GetEffectivePermissionsForPathTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEffectivePermissionsForPath(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEffectivePermissionsForPath(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEffectivePermissionsForPathTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathRequest>();

            var response = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEffectivePermissionsForPath(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEffectivePermissionsForPath(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
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
        [TestCategory("LakeFormation")]
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
        [TestCategory("LakeFormation")]
        public void ListResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */

using Amazon.AppStream;
using Amazon.AppStream.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppStreamPaginatorTests
    {
        private static Mock<AmazonAppStreamClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppStreamClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppStream")]
        public void DescribeImagePermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagePermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImagePermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImagePermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImagePermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImagePermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppStream")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImagePermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagePermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImagePermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImagePermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImagePermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppStream")]
        public void DescribeImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppStream")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
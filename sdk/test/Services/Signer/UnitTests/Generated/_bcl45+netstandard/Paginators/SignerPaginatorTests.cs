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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */

using Amazon.Signer;
using Amazon.Signer.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SignerPaginatorTests
    {
        private static Mock<AmazonSignerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSignerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        public void ListSigningJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSigningJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSigningJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSigningJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSigningJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSigningJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSigningJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSigningJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSigningJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        public void ListSigningPlatformsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningPlatformsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSigningPlatformsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSigningPlatformsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSigningPlatforms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSigningPlatforms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSigningPlatformsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningPlatformsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSigningPlatformsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSigningPlatforms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSigningPlatforms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        public void ListSigningProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSigningProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSigningProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSigningProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSigningProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Signer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSigningProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSigningProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSigningProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSigningProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSigningProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
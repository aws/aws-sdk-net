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
 * Do not modify this file. This file is generated from the cloudfront-2016-01-28.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CloudFront;
using Amazon.CloudFront.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class CloudFrontConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.CreateCloudFrontOriginAccessIdentityRequest), new System.Type[] { typeof(CloudFrontOriginAccessIdentityConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void CreateDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.CreateDistributionRequest), new System.Type[] { typeof(DistributionConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void CreateInvalidationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.CreateInvalidationRequest), new System.Type[] { typeof(string), typeof(InvalidationBatch), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void CreateStreamingDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.CreateStreamingDistributionRequest), new System.Type[] { typeof(StreamingDistributionConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.DeleteCloudFrontOriginAccessIdentityRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void DeleteDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.DeleteDistributionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void DeleteStreamingDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.DeleteStreamingDistributionRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetCloudFrontOriginAccessIdentityRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentityConfigRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetCloudFrontOriginAccessIdentityConfigRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetDistributionRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetDistributionConfigRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetDistributionConfigRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetInvalidationRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetInvalidationRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetStreamingDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetStreamingDistributionRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void GetStreamingDistributionConfigRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.GetStreamingDistributionConfigRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void ListCloudFrontOriginAccessIdentitiesRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void ListDistributionsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void ListInvalidationsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.ListInvalidationsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void ListStreamingDistributionsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentityRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.UpdateCloudFrontOriginAccessIdentityRequest), new System.Type[] { typeof(string), typeof(string), typeof(CloudFrontOriginAccessIdentityConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void UpdateDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.UpdateDistributionRequest), new System.Type[] { typeof(string), typeof(string), typeof(DistributionConfig), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("CloudFront")]
        public void UpdateStreamingDistributionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.CloudFront.Model.UpdateStreamingDistributionRequest), new System.Type[] { typeof(string), typeof(string), typeof(StreamingDistributionConfig), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}
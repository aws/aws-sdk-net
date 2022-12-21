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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.TranscribeService.Endpoints;
using Amazon.TranscribeService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class TranscribeServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cn.transcribe.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://fips.transcribe.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://transcribe.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cn.transcribe.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("TranscribeService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new TranscribeServiceEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonTranscribeServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}
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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Signin.Endpoints;
using Amazon.Signin.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class SigninEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Control Plane operation in us-east-1 (aws partition)")]
        public void Control_Plane_operation_in_useast1_aws_partition_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["IsControlPlane"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Control Plane operation in cn-north-1 (aws-cn partition)")]
        public void Control_Plane_operation_in_cnnorth1_awscn_partition_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["IsControlPlane"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Data Plane operation in us-east-1")]
        public void Data_Plane_operation_in_useast1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["IsControlPlane"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-1.signin.aws.amazon.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Data Plane operation in us-east-1 (IsControlPlane not set)")]
        public void Data_Plane_operation_in_useast1_IsControlPlane_not_set_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-1.signin.aws.amazon.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Data Plane operation in cn-north-1")]
        public void Data_Plane_operation_in_cnnorth1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["IsControlPlane"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cn-north-1.signin.amazonaws.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Data Plane operation in us-gov-west-1")]
        public void Data_Plane_operation_in_usgovwest1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["IsControlPlane"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-gov-west-1.signin.amazonaws-us-gov.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("FIPS endpoint in us-gov-west-1 (global endpoint)")]
        public void FIPS_endpoint_in_usgovwest1_global_endpoint_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin-fips.amazonaws-us-gov.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("FIPS endpoint in us-gov-east-1 (regional endpoint)")]
        public void FIPS_endpoint_in_usgoveast1_regional_endpoint_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-gov-east-1.signin-fips.amazonaws-us-gov.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("FIPS endpoint in us-east-1")]
        public void FIPS_endpoint_in_useast1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("DualStack falls through to default SDK endpoint in us-east-1 (aws partition)")]
        public void DualStack_falls_through_to_default_SDK_endpoint_in_useast1_aws_partition_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("DualStack falls through to default SDK endpoint in cn-north-1 (aws-cn partition)")]
        public void DualStack_falls_through_to_default_SDK_endpoint_in_cnnorth1_awscn_partition_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("DualStack falls through to default SDK endpoint in us-gov-west-1 (aws-us-gov partition)")]
        public void DualStack_falls_through_to_default_SDK_endpoint_in_usgovwest1_awsusgov_partition_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://signin.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("Custom SDK endpoint override")]
        public void Custom_SDK_endpoint_override_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://custom.signin.example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://custom.signin.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("ISO partition (us-iso-east-1)")]
        public void ISO_partition_usisoeast1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-iso-east-1.signin.c2shome.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Signin")]
        [Description("ISO-B partition (us-isob-east-1)")]
        public void ISOB_partition_usisobeast1_Test()
        {
            var parameters = new SigninEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSigninEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-isob-east-1.signin.sc2shome.sgov.gov", endpoint.URL);
        }

    }
}
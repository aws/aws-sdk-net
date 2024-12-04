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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.CertificateManager;
using Amazon.CertificateManager.Model;

namespace AWSSDK_DotNet.IntegrationTests.SmokeTestsV2
{
    [TestClass]
    public class CertificateManagerSmokeTestsV2
    {

        [TestMethod]
        [TestCategory("SmokeTests")]
        [TestCategory("ACM")]
        public async Task ListCertificatesSuccess()
        {
            var serviceConfig = new AmazonCertificateManagerConfig();
            
            // TODO: Apply any other config settings required for the service config.
            serviceConfig.RegionEndpoint = RegionEndpoint.GetBySystemName("us-west-2");
            var serviceClient = new AmazonCertificateManagerClient(serviceConfig);

            // TODO: Add any input from the test case to the request object.
            var request = new ListCertificatesRequest();

            // TODO: Handle when test cases are testing a failure condition. That means catching the exception and verifing we got the right exception.
            var response = await serviceClient.ListCertificatesAsync(request);

            await Task.CompletedTask;
        }

        [TestMethod]
        [TestCategory("SmokeTests")]
        [TestCategory("ACM")]
        public async Task GetCertificateFailure()
        {
            var serviceConfig = new AmazonCertificateManagerConfig();
            
            // TODO: Apply any other config settings required for the service config.
            serviceConfig.RegionEndpoint = RegionEndpoint.GetBySystemName("us-west-2");
            var serviceClient = new AmazonCertificateManagerClient(serviceConfig);

            // TODO: Add any input from the test case to the request object.
            var request = new GetCertificateRequest();

            // TODO: Handle when test cases are testing a failure condition. That means catching the exception and verifing we got the right exception.
            var response = await serviceClient.GetCertificateAsync(request);

            await Task.CompletedTask;
        }
    }
}
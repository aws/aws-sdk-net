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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.CertificateManager.Internal;

namespace Amazon.CertificateManager.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving CertificateManager endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonCertificateManagerEndpointProvider"/> and <see cref="AmazonCertificateManagerEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class CertificateManagerEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// CertificateManagerEndpointParameters constructor
        /// </summary>
        public CertificateManagerEndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
        }

        /// <summary>
        /// The AWS region to send requests to.
        /// </summary>
        public string Region
        {
            get => (string)this["Region"];
            set => this["Region"] = value;
        }

        /// <summary>
        /// Override the endpoint used to send requests.
        /// </summary>
        public string Endpoint
        {
            get => (string)this["Endpoint"];
            set => this["Endpoint"] = value;
        }

        /// <summary>
        /// Use FIPS endpoints.
        /// </summary>
        public bool? UseFIPS
        {
            get => (bool?)this["UseFIPS"];
            set => this["UseFIPS"] = value;
        }

        /// <summary>
        /// Use dual-stack endpoints.
        /// </summary>
        public bool? UseDualStack
        {
            get => (bool?)this["UseDualStack"];
            set => this["UseDualStack"] = value;
        }

        /// <summary>
        /// The service type: ACM or ACM-ACME. Injected via @staticContextParams.
        /// </summary>
        public string ServiceType
        {
            get => (string)this["ServiceType"];
            set => this["ServiceType"] = value;
        }
    }
}

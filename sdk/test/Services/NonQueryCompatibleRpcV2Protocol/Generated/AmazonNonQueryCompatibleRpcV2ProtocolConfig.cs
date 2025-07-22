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
 * Do not modify this file. This file is generated from the non-query-compatible-rpcv2-protocol-2025-06-20.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.NonQueryCompatibleRpcV2Protocol.Internal;

namespace Amazon.NonQueryCompatibleRpcV2Protocol
{
    /// <summary>
    /// Configuration for accessing Amazon NonQueryCompatibleRpcV2Protocol service
    /// </summary>
    public partial class AmazonNonQueryCompatibleRpcV2ProtocolConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Non Query Compatible RpcV2 Protocol", "4.0");


        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Non Query Compatible RpcV2 Protocol";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonNonQueryCompatibleRpcV2ProtocolConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonNonQueryCompatibleRpcV2ProtocolDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Non Query Compatible RpcV2 Protocol";
            this.AuthenticationServiceName = "nonquerycompatiblerpcv2protocol";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "nonquerycompatiblerpcv2protocol";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2025-06-20";
            }
        }

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent
        {
            get
            {
                return _userAgent;
            }
        }

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            // If the current service doesn't have an endpoint rule set (which is the case for configs
            // that are used for testing), we'll return a placeholder endpoint so that unit tests pass.
            return new Endpoint(this.ServiceURL ?? "https://example.com");
        }

    }
}
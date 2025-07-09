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
 * Do not modify this file. This file is generated from the query-compatible-json-rpc-10-2020-07-14.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.QueryCompatibleJSONRPC10.Internal;

namespace Amazon.QueryCompatibleJSONRPC10
{
    /// <summary>
    /// Configuration for accessing Amazon QueryCompatibleJSONRPC10 service
    /// </summary>
    public partial class AmazonQueryCompatibleJSONRPC10Config : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Query Compatible JSON RPC 10", "4.0");


        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Query Compatible JSON RPC 10";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonQueryCompatibleJSONRPC10Config()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonQueryCompatibleJSONRPC10DefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Query Compatible JSON RPC 10";
            this.AuthenticationServiceName = "query-compatible-jsonrpc10";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "query-compatible-jsonrpc10";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2020-07-14";
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
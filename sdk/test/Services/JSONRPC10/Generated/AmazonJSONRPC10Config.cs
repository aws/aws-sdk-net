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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.JSONRPC10.Internal;

namespace Amazon.JSONRPC10
{
    /// <summary>
    /// Configuration for accessing Amazon JSONRPC10 service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonJSONRPC10Config : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("JSON RPC 10", "3.3");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "JSON RPC 10";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonJSONRPC10Config()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonJSONRPC10DefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "JSON RPC 10";
            this.AuthenticationServiceName = "jsonrpc10";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "jsonrpc10";
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

    }
}
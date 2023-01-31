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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Neptune.Internal;

namespace Amazon.Neptune
{
    /// <summary>
    /// Configuration for accessing Amazon Neptune service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonNeptuneConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("3.7.101.60");

        private string _userAgent = UserAgentString;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonNeptuneConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonNeptuneDefaultConfiguration.GetAllConfigurations()))
        {
            this.AuthenticationServiceName = "rds";
            this.EndpointProvider = new AmazonNeptuneEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "rds";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2014-10-31";
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
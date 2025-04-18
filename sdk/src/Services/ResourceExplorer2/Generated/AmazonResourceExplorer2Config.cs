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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.ResourceExplorer2.Internal;

namespace Amazon.ResourceExplorer2
{
    /// <summary>
    /// Configuration for accessing Amazon ResourceExplorer2 service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonResourceExplorer2Config : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Resource Explorer 2", "3.7.402.91");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Resource Explorer 2";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonResourceExplorer2Config()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonResourceExplorer2DefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Resource Explorer 2";
            this.AuthenticationServiceName = "resource-explorer-2";
            this.EndpointProvider = new AmazonResourceExplorer2EndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "resource-explorer-2";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2022-07-28";
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
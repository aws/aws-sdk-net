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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.WellArchitected.Internal;

namespace Amazon.WellArchitected
{
    /// <summary>
    /// Configuration for accessing Amazon WellArchitected service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonWellArchitectedConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("WellArchitected", "3.7.400.137");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "WellArchitected";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonWellArchitectedConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonWellArchitectedDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "WellArchitected";
            this.AuthenticationServiceName = "wellarchitected";
            this.EndpointProvider = new AmazonWellArchitectedEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "wellarchitected";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2020-03-31";
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
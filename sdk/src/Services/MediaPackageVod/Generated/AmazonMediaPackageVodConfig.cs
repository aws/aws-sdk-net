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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Util.Internal;
using Amazon.MediaPackageVod.Internal;

namespace Amazon.MediaPackageVod
{
    /// <summary>
    /// Configuration for accessing Amazon MediaPackageVod service
    /// </summary>
    public partial class AmazonMediaPackageVodConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("3.7.101.14");

        private string _userAgent = UserAgentString;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonMediaPackageVodConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonMediaPackageVodDefaultConfiguration.GetAllConfigurations()))
        {
            this.AuthenticationServiceName = "mediapackage-vod";
            this.EndpointProvider = new AmazonMediaPackageVodEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "mediapackage-vod";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2018-11-07";
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
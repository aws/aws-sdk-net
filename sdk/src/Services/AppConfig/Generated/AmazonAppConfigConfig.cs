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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.AppConfig.Internal;

namespace Amazon.AppConfig
{
    /// <summary>
    /// Configuration for accessing Amazon AppConfig service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonAppConfigConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("AppConfig", "3.7.403.84");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "AppConfig";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonAppConfigConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonAppConfigDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "AppConfig";
            this.AuthenticationServiceName = "appconfig";
            this.EndpointProvider = new AmazonAppConfigEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "appconfig";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2019-10-09";
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
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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.SocialMessaging.Internal;

namespace Amazon.SocialMessaging
{
    /// <summary>
    /// Configuration for accessing Amazon SocialMessaging service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonSocialMessagingConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("SocialMessaging", "3.7.401.36");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "SocialMessaging";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonSocialMessagingConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonSocialMessagingDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "SocialMessaging";
            this.AuthenticationServiceName = "social-messaging";
            this.EndpointProvider = new AmazonSocialMessagingEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "social-messaging";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2024-01-01";
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
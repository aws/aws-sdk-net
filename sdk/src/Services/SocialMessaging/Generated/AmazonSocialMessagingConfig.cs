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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
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
<<<<<<< HEAD
            InternalSDKUtils.BuildUserAgentString("SocialMessaging", "4.0.0.0");

        private static readonly AmazonSocialMessagingEndpointResolver EndpointResolver =
            new AmazonSocialMessagingEndpointResolver();
||||||| Commit version number update changes
            InternalSDKUtils.BuildUserAgentString("SocialMessaging", "3.7.401.11");
=======
            InternalSDKUtils.BuildUserAgentString("SocialMessaging", "3.7.401.29");
>>>>>>> 155cf7e693f514d013f0b7a90cc36b7db1c33d52

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

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public override Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            var requestContext = new RequestContext(false, new AWS4Signer())
            {
                ClientConfig = this,
                OriginalRequest = parameters.Request,
                Request = new DefaultRequest(parameters.Request, ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            return EndpointResolver.GetEndpoint(executionContext);
        }


    }
}
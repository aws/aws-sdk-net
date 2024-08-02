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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.NimbleStudio.Internal;

namespace Amazon.NimbleStudio
{
    /// <summary>
    /// Configuration for accessing Amazon NimbleStudio service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonNimbleStudioConfig : ClientConfig
    {
        private static readonly string UserAgentString =
<<<<<<< HEAD
            InternalSDKUtils.BuildUserAgentString("nimble", "4.0.0.0");

        private static readonly AmazonNimbleStudioEndpointResolver EndpointResolver =
            new AmazonNimbleStudioEndpointResolver();
||||||| Commit version number update changes
            InternalSDKUtils.BuildUserAgentString("nimble", "3.7.300.84");
=======
            InternalSDKUtils.BuildUserAgentString("nimble", "3.7.400.2");
>>>>>>> 2b0190e05c1787d2530d4c1a94beb3208b2b9f8e

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "nimble";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonNimbleStudioConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonNimbleStudioDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "nimble";
            this.AuthenticationServiceName = "nimble";
            this.EndpointProvider = new AmazonNimbleStudioEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "nimble";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2020-08-01";
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
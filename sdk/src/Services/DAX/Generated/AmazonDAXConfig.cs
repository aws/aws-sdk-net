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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.DAX.Internal;

namespace Amazon.DAX
{
    /// <summary>
    /// Configuration for accessing Amazon DAX service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonDAXConfig : ClientConfig
    {
        private static readonly string UserAgentString =
<<<<<<< HEAD
            InternalSDKUtils.BuildUserAgentString("DAX", "4.0.0.0");

        private static readonly AmazonDAXEndpointResolver EndpointResolver =
            new AmazonDAXEndpointResolver();
||||||| Commit version number update changes
            InternalSDKUtils.BuildUserAgentString("DAX", "3.7.400.104");
=======
            InternalSDKUtils.BuildUserAgentString("DAX", "3.7.400.118");
>>>>>>> f99aaf0517635c39009fed2c01894d0702bca488

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "DAX";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonDAXConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonDAXDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "DAX";
            this.AuthenticationServiceName = "dax";
            this.EndpointProvider = new AmazonDAXEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "dax";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2017-04-19";
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
            var requestContext = new RequestContext(false)
            {
                ClientConfig = this,
                OriginalRequest = parameters.Request,
                Request = new DefaultRequest(parameters.Request, ServiceId)
                {
                    AlternateEndpoint = parameters.AlternateEndpoint
                }
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            return EndpointResolver.GetEndpoint(executionContext);
        }


    }
}
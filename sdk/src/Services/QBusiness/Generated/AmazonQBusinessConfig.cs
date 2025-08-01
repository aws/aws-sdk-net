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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.QBusiness.Internal;

namespace Amazon.QBusiness
{
    /// <summary>
    /// Configuration for accessing Amazon QBusiness service
    /// </summary>
    public partial class AmazonQBusinessConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("QBusiness", "4.0.3.3");

        private static readonly AmazonQBusinessEndpointResolver EndpointResolver =
            new AmazonQBusinessEndpointResolver();

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "QBusiness";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonQBusinessConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonQBusinessDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "QBusiness";
            this.AuthenticationServiceName = "qbusiness";
            this.EndpointProvider = new AmazonQBusinessEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "qbusiness";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2023-11-27";
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
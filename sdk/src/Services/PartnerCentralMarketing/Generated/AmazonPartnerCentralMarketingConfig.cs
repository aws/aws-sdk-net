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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.PartnerCentralMarketing.Internal;

namespace Amazon.PartnerCentralMarketing
{
    /// <summary>
    /// Configuration for accessing Partner Central Marketing API
    /// </summary>
    public partial class AmazonPartnerCentralMarketingConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("PartnerCentral Marketing", "4.0");

        private static readonly AmazonPartnerCentralMarketingEndpointResolver EndpointResolver =
            new AmazonPartnerCentralMarketingEndpointResolver();

        private string _userAgent = UserAgentString;

        /// <summary>
        /// The ServiceId, which is the unique identifier for a service.
        /// </summary>
        public static new string ServiceId => "PartnerCentral Marketing";

        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonPartnerCentralMarketingConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonPartnerCentralMarketingDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "PartnerCentral Marketing";
            this.AuthenticationServiceName = "partnercentral-marketing";
            this.EndpointProvider = new AmazonPartnerCentralMarketingEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName => "partnercentral-marketing";

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion => "2026-05-31";

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent => _userAgent;

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

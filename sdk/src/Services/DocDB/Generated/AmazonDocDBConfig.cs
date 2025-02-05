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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.DocDB.Internal;

namespace Amazon.DocDB
{
    /// <summary>
    /// Configuration for accessing Amazon DocDB service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonDocDBConfig : ClientConfig
    {
        private static readonly string UserAgentString =
<<<<<<< HEAD
            InternalSDKUtils.BuildUserAgentString("DocDB", "4.0.0.0");

        private static readonly AmazonDocDBEndpointResolver EndpointResolver =
            new AmazonDocDBEndpointResolver();
||||||| Commit version number update changes
            InternalSDKUtils.BuildUserAgentString("DocDB", "3.7.402.2");
=======
            InternalSDKUtils.BuildUserAgentString("DocDB", "3.7.402.20");
>>>>>>> 155cf7e693f514d013f0b7a90cc36b7db1c33d52

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "DocDB";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonDocDBConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonDocDBDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "DocDB";
            this.AuthenticationServiceName = "rds";
            this.EndpointProvider = new AmazonDocDBEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "rds";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2014-10-31";
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
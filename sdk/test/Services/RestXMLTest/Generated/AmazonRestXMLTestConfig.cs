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
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Endpoints;
using Amazon.RestXMLTest.Internal;

namespace Amazon.RestXMLTest
{
    /// <summary>
    /// Configuration for accessing Amazon RestXMLTest service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonRestXMLTestConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Rest-XML-Test", "4.0");


        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Rest-XML-Test";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonRestXMLTestConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonRestXMLTestDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Rest-XML-Test";
            this.AuthenticationServiceName = "Rest-XML-Test";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "rest-xml-test";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2014-01-01";
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
        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            // If the current service doesn't have an endpoint rule set (which is the case for configs
            // that are used for testing), we'll return a placeholder endpoint so that unit tests pass.
            return new Endpoint(this.ServiceURL ?? "https://example.com");
        }

    }
}
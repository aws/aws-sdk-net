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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.Ep2complexparameters.Internal;

namespace Amazon.Ep2complexparameters
{
    /// <summary>
    /// Configuration for accessing Amazon Ep2complexparameters service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonEp2complexparametersConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Ep2-complex-parameters", "3.3");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Ep2-complex-parameters";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonEp2complexparametersConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonEp2complexparametersDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Ep2-complex-parameters";
            this.AuthenticationServiceName = "ep2";
            this.EndpointProvider = new AmazonEp2complexparametersEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "ep2";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2022-08-24";
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
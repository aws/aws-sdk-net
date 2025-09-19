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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.IoTThingsGraph.Internal;

namespace Amazon.IoTThingsGraph
{
    /// <summary>
    /// Configuration for accessing Amazon IoTThingsGraph service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonIoTThingsGraphConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("IoTThingsGraph", "3.7.501.12");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "IoTThingsGraph";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonIoTThingsGraphConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonIoTThingsGraphDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "IoTThingsGraph";
            this.AuthenticationServiceName = "iotthingsgraph";
            this.EndpointProvider = new AmazonIoTThingsGraphEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "iotthingsgraph";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2018-09-06";
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
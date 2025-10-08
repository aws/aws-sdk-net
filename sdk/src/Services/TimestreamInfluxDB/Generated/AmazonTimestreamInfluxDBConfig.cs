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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.TimestreamInfluxDB.Internal;

namespace Amazon.TimestreamInfluxDB
{
    /// <summary>
    /// Configuration for accessing Amazon TimestreamInfluxDB service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonTimestreamInfluxDBConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Timestream InfluxDB", "3.7.502.19");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Timestream InfluxDB";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonTimestreamInfluxDBConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonTimestreamInfluxDBDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Timestream InfluxDB";
            this.AuthenticationServiceName = "timestream-influxdb";
            this.EndpointProvider = new AmazonTimestreamInfluxDBEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "timestream-influxdb";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2023-01-27";
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
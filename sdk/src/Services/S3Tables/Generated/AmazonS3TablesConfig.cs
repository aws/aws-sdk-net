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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.S3Tables.Internal;

namespace Amazon.S3Tables
{
    /// <summary>
    /// Configuration for accessing Amazon S3Tables service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonS3TablesConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("S3Tables", "3.7.401.9");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "S3Tables";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonS3TablesConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonS3TablesDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "S3Tables";
            this.AuthenticationServiceName = "s3tables";
            this.EndpointProvider = new AmazonS3TablesEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "s3tables";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2018-05-10";
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
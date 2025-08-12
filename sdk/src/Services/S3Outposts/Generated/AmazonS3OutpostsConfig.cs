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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.S3Outposts.Internal;

namespace Amazon.S3Outposts
{
    /// <summary>
    /// Configuration for accessing Amazon S3Outposts service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonS3OutpostsConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("S3Outposts", "3.7.500.7");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "S3Outposts";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonS3OutpostsConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonS3OutpostsDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "S3Outposts";
            this.AuthenticationServiceName = "s3-outposts";
            this.EndpointProvider = new AmazonS3OutpostsEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "s3-outposts";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2017-07-25";
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
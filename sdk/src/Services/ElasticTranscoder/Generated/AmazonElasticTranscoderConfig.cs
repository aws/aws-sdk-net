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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.ElasticTranscoder.Internal;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Configuration for accessing Amazon ElasticTranscoder service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonElasticTranscoderConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("Elastic Transcoder", "3.7.400.137");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "Elastic Transcoder";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonElasticTranscoderConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonElasticTranscoderDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "Elastic Transcoder";
            this.AuthenticationServiceName = "elastictranscoder";
            this.EndpointProvider = new AmazonElasticTranscoderEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "elastictranscoder";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2012-09-25";
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
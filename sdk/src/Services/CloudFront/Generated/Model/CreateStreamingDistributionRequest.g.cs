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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamingDistribution operation. This API
    /// is deprecated. Amazon CloudFront is deprecating real-time messaging protocol (RTMP)
    /// distributions on December 31, 2020. For more information, <a href="http://forums.aws.amazon.com/ann.jspa?annID=7356">read
    /// the announcement</a> on the Amazon CloudFront discussion forum.
    /// </summary>
    public partial class CreateStreamingDistributionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateStreamingDistributionRequest() { }

        /// <summary>
        /// Instantiates CreateStreamingDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="streamingDistributionConfig">The streaming distribution's configuration information.</param>
        public CreateStreamingDistributionRequest(StreamingDistributionConfig streamingDistributionConfig)
        {
            this.StreamingDistributionConfig = streamingDistributionConfig;
        }

        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. 
        /// <para>
        /// The streaming distribution's configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamingDistributionConfig StreamingDistributionConfig { get; set; }

        /// <summary>
        /// Checks to see if the StreamingDistributionConfig property is set.
        /// </summary>
        internal bool IsSetStreamingDistributionConfig() => this.StreamingDistributionConfig != null;
    }
}

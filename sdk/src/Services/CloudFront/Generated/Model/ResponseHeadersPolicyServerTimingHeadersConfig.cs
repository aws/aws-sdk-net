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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
    /// A configuration for enabling the <c>Server-Timing</c> header in HTTP responses sent
    /// from CloudFront. CloudFront adds this header to HTTP responses that it sends in response
    /// to requests that match a cache behavior that's associated with this response headers
    /// policy.
    /// 
    ///  
    /// <para>
    /// You can use the <c>Server-Timing</c> header to view metrics that can help you gain
    /// insights about the behavior and performance of CloudFront. For example, you can see
    /// which cache layer served a cache hit, or the first byte latency from the origin when
    /// there was a cache miss. You can use the metrics in the <c>Server-Timing</c> header
    /// to troubleshoot issues or test the efficiency of your CloudFront configuration. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/understanding-response-headers-policies.html#server-timing-header">Server-Timing
    /// header</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ResponseHeadersPolicyServerTimingHeadersConfig
    {
        private bool? _enabled;
        private double? _samplingRate;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A Boolean that determines whether CloudFront adds the <c>Server-Timing</c> header
        /// to HTTP responses that it sends in response to requests that match a cache behavior
        /// that's associated with this response headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamplingRate. 
        /// <para>
        /// A number 0–100 (inclusive) that specifies the percentage of responses that you want
        /// CloudFront to add the <c>Server-Timing</c> header to. When you set the sampling rate
        /// to 100, CloudFront adds the <c>Server-Timing</c> header to the HTTP response for every
        /// request that matches the cache behavior that this response headers policy is attached
        /// to. When you set it to 50, CloudFront adds the header to 50% of the responses for
        /// requests that match the cache behavior. You can set the sampling rate to any number
        /// 0–100 with up to four decimal places.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? SamplingRate
        {
            get { return this._samplingRate; }
            set { this._samplingRate = value; }
        }

        // Check to see if SamplingRate property is set
        internal bool IsSetSamplingRate()
        {
            return this._samplingRate.HasValue; 
        }

    }
}
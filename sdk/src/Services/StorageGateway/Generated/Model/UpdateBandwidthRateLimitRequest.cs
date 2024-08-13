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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBandwidthRateLimit operation.
    /// Updates the bandwidth rate limits of a gateway. You can update both the upload and
    /// download bandwidth rate limit or specify only one of the two. If you don't set a bandwidth
    /// rate limit, the existing rate limit remains. This operation is supported only for
    /// the stored volume, cached volume, and tape gateway types. To update bandwidth rate
    /// limits for S3 file gateways, use <a>UpdateBandwidthRateLimitSchedule</a>.
    /// 
    ///  
    /// <para>
    /// By default, a gateway's bandwidth rate limits are not set. If you don't set any limit,
    /// the gateway does not have any limitations on its bandwidth usage and could potentially
    /// use the maximum available bandwidth.
    /// </para>
    ///  
    /// <para>
    /// To specify which gateway to update, use the Amazon Resource Name (ARN) of the gateway
    /// in your request.
    /// </para>
    /// </summary>
    public partial class UpdateBandwidthRateLimitRequest : AmazonStorageGatewayRequest
    {
        private long? _averageDownloadRateLimitInBitsPerSec;
        private long? _averageUploadRateLimitInBitsPerSec;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property AverageDownloadRateLimitInBitsPerSec. 
        /// <para>
        /// The average download bandwidth rate limit in bits per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=102400)]
        public long? AverageDownloadRateLimitInBitsPerSec
        {
            get { return this._averageDownloadRateLimitInBitsPerSec; }
            set { this._averageDownloadRateLimitInBitsPerSec = value; }
        }

        // Check to see if AverageDownloadRateLimitInBitsPerSec property is set
        internal bool IsSetAverageDownloadRateLimitInBitsPerSec()
        {
            return this._averageDownloadRateLimitInBitsPerSec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AverageUploadRateLimitInBitsPerSec. 
        /// <para>
        /// The average upload bandwidth rate limit in bits per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=51200)]
        public long? AverageUploadRateLimitInBitsPerSec
        {
            get { return this._averageUploadRateLimitInBitsPerSec; }
            set { this._averageUploadRateLimitInBitsPerSec = value; }
        }

        // Check to see if AverageUploadRateLimitInBitsPerSec property is set
        internal bool IsSetAverageUploadRateLimitInBitsPerSec()
        {
            return this._averageUploadRateLimitInBitsPerSec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

    }
}
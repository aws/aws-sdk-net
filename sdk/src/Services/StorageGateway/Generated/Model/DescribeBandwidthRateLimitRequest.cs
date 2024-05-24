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
    /// Container for the parameters to the DescribeBandwidthRateLimit operation.
    /// Returns the bandwidth rate limits of a gateway. By default, these limits are not set,
    /// which means no bandwidth rate limiting is in effect. This operation is supported only
    /// for the stored volume, cached volume, and tape gateway types. To describe bandwidth
    /// rate limits for S3 file gateways, use <a>DescribeBandwidthRateLimitSchedule</a>.
    /// 
    ///  
    /// <para>
    /// This operation returns a value for a bandwidth rate limit only if the limit is set.
    /// If no limits are set for the gateway, then this operation returns only the gateway
    /// ARN in the response body. To specify which gateway to describe, use the Amazon Resource
    /// Name (ARN) of the gateway in your request.
    /// </para>
    /// </summary>
    public partial class DescribeBandwidthRateLimitRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

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
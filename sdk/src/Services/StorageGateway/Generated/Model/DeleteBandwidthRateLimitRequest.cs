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
    /// Container for the parameters to the DeleteBandwidthRateLimit operation.
    /// Deletes the bandwidth rate limits of a gateway. You can delete either the upload and
    /// download bandwidth rate limit, or you can delete both. If you delete only one of the
    /// limits, the other limit remains unchanged. To specify which gateway to work with,
    /// use the Amazon Resource Name (ARN) of the gateway in your request. This operation
    /// is supported only for the stored volume, cached volume, and tape gateway types.
    /// </summary>
    public partial class DeleteBandwidthRateLimitRequest : AmazonStorageGatewayRequest
    {
        private string _bandwidthType;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property BandwidthType. 
        /// <para>
        /// One of the BandwidthType values that indicates the gateway bandwidth rate limit to
        /// delete.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>UPLOAD</c> | <c>DOWNLOAD</c> | <c>ALL</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=25)]
        public string BandwidthType
        {
            get { return this._bandwidthType; }
            set { this._bandwidthType = value; }
        }

        // Check to see if BandwidthType property is set
        internal bool IsSetBandwidthType()
        {
            return this._bandwidthType != null;
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
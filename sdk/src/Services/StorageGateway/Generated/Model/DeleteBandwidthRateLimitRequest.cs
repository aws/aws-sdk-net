/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBandwidthRateLimit operation.
    /// This operation deletes the bandwidth rate limits of a gateway. You can delete either
    /// the upload and download bandwidth rate limit, or you can delete both. If you delete
    /// only one of the limits, the other limit remains unchanged. To specify which gateway
    /// to work with, use the Amazon Resource Name (ARN) of the gateway in your request.
    /// </summary>
    public partial class DeleteBandwidthRateLimitRequest : AmazonStorageGatewayRequest
    {
        private string _bandwidthType;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property BandwidthType.
        /// </summary>
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
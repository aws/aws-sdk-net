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
    /// Container for the parameters to the UpdateBandwidthRateLimitSchedule operation.
    /// Updates the bandwidth rate limit schedule for a specified gateway. By default, gateways
    /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
    /// is in effect. Use this to initiate or update a gateway's bandwidth rate limit schedule.
    /// This operation is supported for volume, tape, and S3 file gateways. S3 file gateways
    /// support bandwidth rate limits for upload only. FSx file gateways do not support bandwidth
    /// rate limits.
    /// </summary>
    public partial class UpdateBandwidthRateLimitScheduleRequest : AmazonStorageGatewayRequest
    {
        private List<BandwidthRateLimitInterval> _bandwidthRateLimitIntervals = AWSConfigs.InitializeCollections ? new List<BandwidthRateLimitInterval>() : null;
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property BandwidthRateLimitIntervals. 
        /// <para>
        ///  An array containing bandwidth rate limit schedule intervals for a gateway. When no
        /// bandwidth rate limit intervals have been scheduled, the array is empty. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<BandwidthRateLimitInterval> BandwidthRateLimitIntervals
        {
            get { return this._bandwidthRateLimitIntervals; }
            set { this._bandwidthRateLimitIntervals = value; }
        }

        // Check to see if BandwidthRateLimitIntervals property is set
        internal bool IsSetBandwidthRateLimitIntervals()
        {
            return this._bandwidthRateLimitIntervals != null && (this._bandwidthRateLimitIntervals.Count > 0 || !AWSConfigs.InitializeCollections); 
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
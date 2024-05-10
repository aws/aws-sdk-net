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
    /// Container for the parameters to the DescribeBandwidthRateLimitSchedule operation.
    /// Returns information about the bandwidth rate limit schedule of a gateway. By default,
    /// gateways do not have bandwidth rate limit schedules, which means no bandwidth rate
    /// limiting is in effect. This operation is supported only for volume, tape and S3 file
    /// gateways. FSx file gateways do not support bandwidth rate limits.
    /// 
    ///  
    /// <para>
    /// This operation returns information about a gateway's bandwidth rate limit schedule.
    /// A bandwidth rate limit schedule consists of one or more bandwidth rate limit intervals.
    /// A bandwidth rate limit interval defines a period of time on one or more days of the
    /// week, during which bandwidth rate limits are specified for uploading, downloading,
    /// or both. 
    /// </para>
    ///  
    /// <para>
    ///  A bandwidth rate limit interval consists of one or more days of the week, a start
    /// hour and minute, an ending hour and minute, and bandwidth rate limits for uploading
    /// and downloading 
    /// </para>
    ///  
    /// <para>
    ///  If no bandwidth rate limit schedule intervals are set for the gateway, this operation
    /// returns an empty response. To specify which gateway to describe, use the Amazon Resource
    /// Name (ARN) of the gateway in your request.
    /// </para>
    /// </summary>
    public partial class DescribeBandwidthRateLimitScheduleRequest : AmazonStorageGatewayRequest
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
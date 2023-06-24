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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the PutBandwidthRateLimitSchedule operation.
    /// This action sets the bandwidth rate limit schedule for a specified gateway. By default,
    /// gateways do not have a bandwidth rate limit schedule, which means no bandwidth rate
    /// limiting is in effect. Use this to initiate a gateway's bandwidth rate limit schedule.
    /// </summary>
    public partial class PutBandwidthRateLimitScheduleRequest : AmazonBackupGatewayRequest
    {
        private List<BandwidthRateLimitInterval> _bandwidthRateLimitIntervals = new List<BandwidthRateLimitInterval>();
        private string _gatewayArn;

        /// <summary>
        /// Gets and sets the property BandwidthRateLimitIntervals. 
        /// <para>
        /// An array containing bandwidth rate limit schedule intervals for a gateway. When no
        /// bandwidth rate limit intervals have been scheduled, the array is empty.
        /// </para>
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
            return this._bandwidthRateLimitIntervals != null && this._bandwidthRateLimitIntervals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_BGW_ListGateways.html">
        /// <code>ListGateways</code> </a> operation to return a list of gateways for your account
        /// and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

    }
}
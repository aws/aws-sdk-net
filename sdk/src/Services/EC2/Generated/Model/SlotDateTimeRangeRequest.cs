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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the time period for a Scheduled Instance to start its first schedule. The
    /// time period must span less than one day.
    /// </summary>
    public partial class SlotDateTimeRangeRequest
    {
        private DateTime? _earliestTime;
        private DateTime? _latestTime;

        /// <summary>
        /// Gets and sets the property EarliestTime. 
        /// <para>
        /// The earliest date and time, in UTC, for the Scheduled Instance to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EarliestTime
        {
            get { return this._earliestTime; }
            set { this._earliestTime = value; }
        }

        // Check to see if EarliestTime property is set
        internal bool IsSetEarliestTime()
        {
            return this._earliestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestTime. 
        /// <para>
        /// The latest date and time, in UTC, for the Scheduled Instance to start. This value
        /// must be later than or equal to the earliest date and at most three months in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LatestTime
        {
            get { return this._latestTime; }
            set { this._latestTime = value; }
        }

        // Check to see if LatestTime property is set
        internal bool IsSetLatestTime()
        {
            return this._latestTime.HasValue; 
        }

    }
}
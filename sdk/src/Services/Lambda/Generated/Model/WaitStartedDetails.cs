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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about a wait operation that has started.
    /// </summary>
    public partial class WaitStartedDetails
    {
        private int? _duration;
        private DateTime? _scheduledEndTimestamp;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration to wait, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledEndTimestamp. 
        /// <para>
        /// The date and time when the wait operation is scheduled to complete, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ScheduledEndTimestamp
        {
            get { return this._scheduledEndTimestamp.GetValueOrDefault(); }
            set { this._scheduledEndTimestamp = value; }
        }

        // Check to see if ScheduledEndTimestamp property is set
        internal bool IsSetScheduledEndTimestamp()
        {
            return this._scheduledEndTimestamp.HasValue; 
        }

    }
}
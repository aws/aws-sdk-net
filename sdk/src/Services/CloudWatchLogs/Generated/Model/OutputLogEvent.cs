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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a log event.
    /// </summary>
    public partial class OutputLogEvent
    {
        private DateTime? _ingestionTime;
        private string _message;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property IngestionTime. 
        /// <para>
        /// The time the event was ingested, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime IngestionTime
        {
            get { return this._ingestionTime.GetValueOrDefault(); }
            set { this._ingestionTime = value; }
        }

        // Check to see if IngestionTime property is set
        internal bool IsSetIngestionTime()
        {
            return this._ingestionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The data contained in the log event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time the event occurred, expressed as the number of milliseconds after <code>Jan
        /// 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}
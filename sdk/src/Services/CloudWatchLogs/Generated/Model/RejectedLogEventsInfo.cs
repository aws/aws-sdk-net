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
    /// Represents the rejected events.
    /// </summary>
    public partial class RejectedLogEventsInfo
    {
        private int? _expiredLogEventEndIndex;
        private int? _tooNewLogEventStartIndex;
        private int? _tooOldLogEventEndIndex;

        /// <summary>
        /// Gets and sets the property ExpiredLogEventEndIndex. 
        /// <para>
        /// The expired log events.
        /// </para>
        /// </summary>
        public int ExpiredLogEventEndIndex
        {
            get { return this._expiredLogEventEndIndex.GetValueOrDefault(); }
            set { this._expiredLogEventEndIndex = value; }
        }

        // Check to see if ExpiredLogEventEndIndex property is set
        internal bool IsSetExpiredLogEventEndIndex()
        {
            return this._expiredLogEventEndIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TooNewLogEventStartIndex. 
        /// <para>
        /// The log events that are too new.
        /// </para>
        /// </summary>
        public int TooNewLogEventStartIndex
        {
            get { return this._tooNewLogEventStartIndex.GetValueOrDefault(); }
            set { this._tooNewLogEventStartIndex = value; }
        }

        // Check to see if TooNewLogEventStartIndex property is set
        internal bool IsSetTooNewLogEventStartIndex()
        {
            return this._tooNewLogEventStartIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TooOldLogEventEndIndex. 
        /// <para>
        /// The log events that are dated too far in the past.
        /// </para>
        /// </summary>
        public int TooOldLogEventEndIndex
        {
            get { return this._tooOldLogEventEndIndex.GetValueOrDefault(); }
            set { this._tooOldLogEventEndIndex = value; }
        }

        // Check to see if TooOldLogEventEndIndex property is set
        internal bool IsSetTooOldLogEventEndIndex()
        {
            return this._tooOldLogEventEndIndex.HasValue; 
        }

    }
}
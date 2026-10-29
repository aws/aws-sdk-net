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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents the rejected events.
    /// </summary>
    public partial class RejectedLogEventsInfo
    {
        /// <summary>
        /// Gets and sets the property ExpiredLogEventEndIndex. 
        /// <para>
        /// The expired log events.
        /// </para>
        /// </summary>
        public int? ExpiredLogEventEndIndex { get; set; }

        /// <summary>
        /// Checks to see if the ExpiredLogEventEndIndex property is set.
        /// </summary>
        internal bool IsSetExpiredLogEventEndIndex() => this.ExpiredLogEventEndIndex.HasValue;

        /// <summary>
        /// Gets and sets the property TooNewLogEventStartIndex. 
        /// <para>
        /// The index of the first log event that is too new. This field is inclusive.
        /// </para>
        /// </summary>
        public int? TooNewLogEventStartIndex { get; set; }

        /// <summary>
        /// Checks to see if the TooNewLogEventStartIndex property is set.
        /// </summary>
        internal bool IsSetTooNewLogEventStartIndex() => this.TooNewLogEventStartIndex.HasValue;

        /// <summary>
        /// Gets and sets the property TooOldLogEventEndIndex. 
        /// <para>
        /// The index of the last log event that is too old. This field is exclusive.
        /// </para>
        /// </summary>
        public int? TooOldLogEventEndIndex { get; set; }

        /// <summary>
        /// Checks to see if the TooOldLogEventEndIndex property is set.
        /// </summary>
        internal bool IsSetTooOldLogEventEndIndex() => this.TooOldLogEventEndIndex.HasValue;
    }
}

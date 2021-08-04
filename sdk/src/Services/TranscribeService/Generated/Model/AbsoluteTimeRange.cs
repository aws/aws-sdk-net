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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// A time range, set in seconds, between two points in the call.
    /// </summary>
    public partial class AbsoluteTimeRange
    {
        private long? _endTime;
        private long? _first;
        private long? _last;
        private long? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A value that indicates the end of the time range in milliseconds. To set absolute
        /// time range, you must specify a start time and an end time. For example, if you specify
        /// the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// StartTime - 10000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Endtime - 50000
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The time range is set between 10,000 milliseconds and 50,000 milliseconds into the
        /// call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property First. 
        /// <para>
        /// A time range from the beginning of the call to the value that you've specified. For
        /// example, if you specify 100000, the time range is set to the first 100,000 milliseconds
        /// of the call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long First
        {
            get { return this._first.GetValueOrDefault(); }
            set { this._first = value; }
        }

        // Check to see if First property is set
        internal bool IsSetFirst()
        {
            return this._first.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Last. 
        /// <para>
        /// A time range from the value that you've specified to the end of the call. For example,
        /// if you specify 100000, the time range is set to the last 100,000 milliseconds of the
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long Last
        {
            get { return this._last.GetValueOrDefault(); }
            set { this._last = value; }
        }

        // Check to see if Last property is set
        internal bool IsSetLast()
        {
            return this._last.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A value that indicates the beginning of the time range in seconds. To set absolute
        /// time range, you must specify a start time and an end time. For example, if you specify
        /// the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// StartTime - 10000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Endtime - 50000
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The time range is set between 10,000 milliseconds and 50,000 milliseconds into the
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}
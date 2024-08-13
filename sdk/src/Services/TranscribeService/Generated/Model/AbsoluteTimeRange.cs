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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// A time range, in milliseconds, between two points in your media file.
    /// 
    ///  
    /// <para>
    /// You can use <c>StartTime</c> and <c>EndTime</c> to search a custom segment. For example,
    /// setting <c>StartTime</c> to 10000 and <c>EndTime</c> to 50000 only searches for your
    /// specified criteria in the audio contained between the 10,000 millisecond mark and
    /// the 50,000 millisecond mark of your media file. You must use <c>StartTime</c> and
    /// <c>EndTime</c> as a set; that is, if you include one, you must include both.
    /// </para>
    ///  
    /// <para>
    /// You can use also <c>First</c> to search from the start of the audio until the time
    /// that you specify, or <c>Last</c> to search from the time that you specify until the
    /// end of the audio. For example, setting <c>First</c> to 50000 only searches for your
    /// specified criteria in the audio contained between the start of the media file to the
    /// 50,000 millisecond mark. You can use <c>First</c> and <c>Last</c> independently of
    /// each other.
    /// </para>
    ///  
    /// <para>
    /// If you prefer to use percentage instead of milliseconds, see .
    /// </para>
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
        /// The time, in milliseconds, when Amazon Transcribe stops searching for the specified
        /// criteria in your audio. If you include <c>EndTime</c> in your request, you must also
        /// include <c>StartTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long? EndTime
        {
            get { return this._endTime; }
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
        /// The time, in milliseconds, from the start of your media file until the specified value.
        /// Amazon Transcribe searches for your specified criteria in this time segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long? First
        {
            get { return this._first; }
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
        /// The time, in milliseconds, from the specified value until the end of your media file.
        /// Amazon Transcribe searches for your specified criteria in this time segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long? Last
        {
            get { return this._last; }
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
        /// The time, in milliseconds, when Amazon Transcribe starts searching for the specified
        /// criteria in your audio. If you include <c>StartTime</c> in your request, you must
        /// also include <c>EndTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=14400000)]
        public long? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}
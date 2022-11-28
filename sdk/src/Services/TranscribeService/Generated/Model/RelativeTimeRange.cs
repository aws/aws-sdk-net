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
    /// A time range, in percentage, between two points in your media file.
    /// 
    ///  
    /// <para>
    /// You can use <code>StartPercentage</code> and <code>EndPercentage</code> to search
    /// a custom segment. For example, setting <code>StartPercentage</code> to 10 and <code>EndPercentage</code>
    /// to 50 only searches for your specified criteria in the audio contained between the
    /// 10 percent mark and the 50 percent mark of your media file.
    /// </para>
    ///  
    /// <para>
    /// You can use also <code>First</code> to search from the start of the media file until
    /// the time that you specify. Or use <code>Last</code> to search from the time that you
    /// specify until the end of the media file. For example, setting <code>First</code> to
    /// 10 only searches for your specified criteria in the audio contained in the first 10
    /// percent of the media file.
    /// </para>
    ///  
    /// <para>
    /// If you prefer to use milliseconds instead of percentage, see .
    /// </para>
    /// </summary>
    public partial class RelativeTimeRange
    {
        private int? _endPercentage;
        private int? _first;
        private int? _last;
        private int? _startPercentage;

        /// <summary>
        /// Gets and sets the property EndPercentage. 
        /// <para>
        /// The time, in percentage, when Amazon Transcribe stops searching for the specified
        /// criteria in your media file. If you include <code>EndPercentage</code> in your request,
        /// you must also include <code>StartPercentage</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int EndPercentage
        {
            get { return this._endPercentage.GetValueOrDefault(); }
            set { this._endPercentage = value; }
        }

        // Check to see if EndPercentage property is set
        internal bool IsSetEndPercentage()
        {
            return this._endPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property First. 
        /// <para>
        /// The time, in percentage, from the start of your media file until the specified value.
        /// Amazon Transcribe searches for your specified criteria in this time segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int First
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
        /// The time, in percentage, from the specified value until the end of your media file.
        /// Amazon Transcribe searches for your specified criteria in this time segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Last
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
        /// Gets and sets the property StartPercentage. 
        /// <para>
        /// The time, in percentage, when Amazon Transcribe starts searching for the specified
        /// criteria in your media file. If you include <code>StartPercentage</code> in your request,
        /// you must also include <code>EndPercentage</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int StartPercentage
        {
            get { return this._startPercentage.GetValueOrDefault(); }
            set { this._startPercentage = value; }
        }

        // Check to see if StartPercentage property is set
        internal bool IsSetStartPercentage()
        {
            return this._startPercentage.HasValue; 
        }

    }
}
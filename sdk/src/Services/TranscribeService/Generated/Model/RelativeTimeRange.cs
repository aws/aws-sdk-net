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
    /// An object that allows percentages to specify the proportion of the call where you
    /// would like to apply a filter. For example, you can specify the first half of the call.
    /// You can also specify the period of time between halfway through to three-quarters
    /// of the way through the call. Because the length of conversation can vary between calls,
    /// you can apply relative time ranges across all calls.
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
        /// A value that indicates the percentage of the end of the time range. To set a relative
        /// time range, you must specify a start percentage and an end percentage. For example,
        /// if you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// StartPercentage - 10
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EndPercentage - 50
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This looks at the time range starting from 10% of the way into the call to 50% of
        /// the way through the call. For a call that lasts 100,000 milliseconds, this example
        /// range would apply from the 10,000 millisecond mark to the 50,000 millisecond mark.
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
        /// A range that takes the portion of the call up to the time in milliseconds set by the
        /// value that you've specified. For example, if you specify <code>120000</code>, the
        /// time range is set for the first 120,000 milliseconds of the call.
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
        /// A range that takes the portion of the call from the time in milliseconds set by the
        /// value that you've specified to the end of the call. For example, if you specify <code>120000</code>,
        /// the time range is set for the last 120,000 milliseconds of the call.
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
        /// A value that indicates the percentage of the beginning of the time range. To set a
        /// relative time range, you must specify a start percentage and an end percentage. For
        /// example, if you specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// StartPercentage - 10
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EndPercentage - 50
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This looks at the time range starting from 10% of the way into the call to 50% of
        /// the way through the call. For a call that lasts 100,000 milliseconds, this example
        /// range would apply from the 10,000 millisecond mark to the 50,000 millisecond mark.
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
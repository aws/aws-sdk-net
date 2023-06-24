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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The time range drill down filter.
    /// </summary>
    public partial class TimeRangeDrillDownFilter
    {
        private ColumnIdentifier _column;
        private DateTime? _rangeMaximum;
        private DateTime? _rangeMinimum;
        private TimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property RangeMaximum. 
        /// <para>
        /// The maximum value for the filter value range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RangeMaximum
        {
            get { return this._rangeMaximum.GetValueOrDefault(); }
            set { this._rangeMaximum = value; }
        }

        // Check to see if RangeMaximum property is set
        internal bool IsSetRangeMaximum()
        {
            return this._rangeMaximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RangeMinimum. 
        /// <para>
        /// The minimum value for the filter value range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RangeMinimum
        {
            get { return this._rangeMinimum.GetValueOrDefault(); }
            set { this._rangeMinimum = value; }
        }

        // Check to see if RangeMinimum property is set
        internal bool IsSetRangeMinimum()
        {
            return this._rangeMinimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <code>DateTime</code> values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

    }
}
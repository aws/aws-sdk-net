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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Entity that comprises information on large gaps between consecutive timestamps in
    /// data.
    /// </summary>
    public partial class LargeTimestampGaps
    {
        private int? _maxTimestampGapInDays;
        private int? _numberOfLargeTimestampGaps;
        private StatisticalIssueStatus _status;

        /// <summary>
        /// Gets and sets the property MaxTimestampGapInDays. 
        /// <para>
        ///  Indicates the size of the largest timestamp gap, in days. 
        /// </para>
        /// </summary>
        public int MaxTimestampGapInDays
        {
            get { return this._maxTimestampGapInDays.GetValueOrDefault(); }
            set { this._maxTimestampGapInDays = value; }
        }

        // Check to see if MaxTimestampGapInDays property is set
        internal bool IsSetMaxTimestampGapInDays()
        {
            return this._maxTimestampGapInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfLargeTimestampGaps. 
        /// <para>
        ///  Indicates the number of large timestamp gaps, if there are any. 
        /// </para>
        /// </summary>
        public int NumberOfLargeTimestampGaps
        {
            get { return this._numberOfLargeTimestampGaps.GetValueOrDefault(); }
            set { this._numberOfLargeTimestampGaps = value; }
        }

        // Check to see if NumberOfLargeTimestampGaps property is set
        internal bool IsSetNumberOfLargeTimestampGaps()
        {
            return this._numberOfLargeTimestampGaps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Indicates whether there is a potential data issue related to large gaps in timestamps.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatisticalIssueStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
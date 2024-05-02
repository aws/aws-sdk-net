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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains statistics information. The DFE engine uses information about the data in
    /// your Neptune graph to make effective trade-offs when planning query execution. This
    /// information takes the form of statistics that include so-called characteristic sets
    /// and predicate statistics that can guide query planning. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/neptune-dfe-statistics.html">Managing
    /// statistics for the Neptune DFE to use</a>.
    /// </summary>
    public partial class Statistics
    {
        private bool? _active;
        private bool? _autoCompute;
        private DateTime? _date;
        private string _note;
        private StatisticsSummary _signatureInfo;
        private string _statisticsId;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Indicates whether or not DFE statistics generation is enabled at all.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoCompute. 
        /// <para>
        /// Indicates whether or not automatic statistics generation is enabled.
        /// </para>
        /// </summary>
        public bool? AutoCompute
        {
            get { return this._autoCompute; }
            set { this._autoCompute = value; }
        }

        // Check to see if AutoCompute property is set
        internal bool IsSetAutoCompute()
        {
            return this._autoCompute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The UTC time at which DFE statistics have most recently been generated.
        /// </para>
        /// </summary>
        public DateTime? Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A note about problems in the case where statistics are invalid.
        /// </para>
        /// </summary>
        public string Note
        {
            get { return this._note; }
            set { this._note = value; }
        }

        // Check to see if Note property is set
        internal bool IsSetNote()
        {
            return this._note != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureInfo. 
        /// <para>
        /// A StatisticsSummary structure that contains:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>signatureCount</c> - The total number of signatures across all characteristic
        /// sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instanceCount</c> - The total number of characteristic-set instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>predicateCount</c> - The total number of unique predicates.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatisticsSummary SignatureInfo
        {
            get { return this._signatureInfo; }
            set { this._signatureInfo = value; }
        }

        // Check to see if SignatureInfo property is set
        internal bool IsSetSignatureInfo()
        {
            return this._signatureInfo != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticsId. 
        /// <para>
        /// Reports the ID of the current statistics generation run. A value of -1 indicates that
        /// no statistics have been generated.
        /// </para>
        /// </summary>
        public string StatisticsId
        {
            get { return this._statisticsId; }
            set { this._statisticsId = value; }
        }

        // Check to see if StatisticsId property is set
        internal bool IsSetStatisticsId()
        {
            return this._statisticsId != null;
        }

    }
}
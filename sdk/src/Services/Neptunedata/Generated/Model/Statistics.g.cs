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
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Indicates whether or not DFE statistics generation is enabled at all.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property AutoCompute. 
        /// <para>
        /// Indicates whether or not automatic statistics generation is enabled.
        /// </para>
        /// </summary>
        public bool? AutoCompute { get; set; }

        /// <summary>
        /// Checks to see if the AutoCompute property is set.
        /// </summary>
        internal bool IsSetAutoCompute() => this.AutoCompute.HasValue;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The UTC time at which DFE statistics have most recently been generated.
        /// </para>
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// A note about problems in the case where statistics are invalid.
        /// </para>
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

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
        public StatisticsSummary SignatureInfo { get; set; }

        /// <summary>
        /// Checks to see if the SignatureInfo property is set.
        /// </summary>
        internal bool IsSetSignatureInfo() => this.SignatureInfo != null;

        /// <summary>
        /// Gets and sets the property StatisticsId. 
        /// <para>
        /// Reports the ID of the current statistics generation run. A value of -1 indicates that
        /// no statistics have been generated.
        /// </para>
        /// </summary>
        public string StatisticsId { get; set; }

        /// <summary>
        /// Checks to see if the StatisticsId property is set.
        /// </summary>
        internal bool IsSetStatisticsId() => this.StatisticsId != null;
    }
}

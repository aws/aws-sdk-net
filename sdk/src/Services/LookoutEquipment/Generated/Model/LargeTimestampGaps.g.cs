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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Entity that comprises information on large gaps between consecutive timestamps in
    /// data.
    /// </summary>
    public partial class LargeTimestampGaps
    {
        /// <summary>
        /// Gets and sets the property MaxTimestampGapInDays. 
        /// <para>
        ///  Indicates the size of the largest timestamp gap, in days. 
        /// </para>
        /// </summary>
        public int? MaxTimestampGapInDays { get; set; }

        /// <summary>
        /// Checks to see if the MaxTimestampGapInDays property is set.
        /// </summary>
        internal bool IsSetMaxTimestampGapInDays() => this.MaxTimestampGapInDays.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfLargeTimestampGaps. 
        /// <para>
        ///  Indicates the number of large timestamp gaps, if there are any. 
        /// </para>
        /// </summary>
        public int? NumberOfLargeTimestampGaps { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfLargeTimestampGaps property is set.
        /// </summary>
        internal bool IsSetNumberOfLargeTimestampGaps() => this.NumberOfLargeTimestampGaps.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Indicates whether there is a potential data issue related to large gaps in timestamps.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StatisticalIssueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

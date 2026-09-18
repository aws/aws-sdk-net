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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A milestone return object.
    /// </summary>
    public partial class Milestone
    {
        /// <summary>
        /// Gets and sets the property MilestoneName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string MilestoneName { get; set; }

        /// <summary>
        /// Checks to see if the MilestoneName property is set.
        /// </summary>
        internal bool IsSetMilestoneName() => this.MilestoneName != null;

        /// <summary>
        /// Gets and sets the property MilestoneNumber.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MilestoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the MilestoneNumber property is set.
        /// </summary>
        internal bool IsSetMilestoneNumber() => this.MilestoneNumber.HasValue;

        /// <summary>
        /// Gets and sets the property RecordedAt. 
        /// <para>
        /// The date and time when the milestone was recorded.
        /// </para>
        /// </summary>
        public DateTime? RecordedAt { get; set; }

        /// <summary>
        /// Checks to see if the RecordedAt property is set.
        /// </summary>
        internal bool IsSetRecordedAt() => this.RecordedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Workload.
        /// </summary>
        public Workload Workload { get; set; }

        /// <summary>
        /// Checks to see if the Workload property is set.
        /// </summary>
        internal bool IsSetWorkload() => this.Workload != null;
    }
}

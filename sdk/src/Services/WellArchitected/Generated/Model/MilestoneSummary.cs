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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
    /// A milestone summary return object.
    /// </summary>
    public partial class MilestoneSummary
    {
        private string _milestoneName;
        private int? _milestoneNumber;
        private DateTime? _recordedAt;
        private WorkloadSummary _workloadSummary;

        /// <summary>
        /// Gets and sets the property MilestoneName.
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string MilestoneName
        {
            get { return this._milestoneName; }
            set { this._milestoneName = value; }
        }

        // Check to see if MilestoneName property is set
        internal bool IsSetMilestoneName()
        {
            return this._milestoneName != null;
        }

        /// <summary>
        /// Gets and sets the property MilestoneNumber.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MilestoneNumber
        {
            get { return this._milestoneNumber; }
            set { this._milestoneNumber = value; }
        }

        // Check to see if MilestoneNumber property is set
        internal bool IsSetMilestoneNumber()
        {
            return this._milestoneNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordedAt.
        /// </summary>
        public DateTime? RecordedAt
        {
            get { return this._recordedAt; }
            set { this._recordedAt = value; }
        }

        // Check to see if RecordedAt property is set
        internal bool IsSetRecordedAt()
        {
            return this._recordedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkloadSummary.
        /// </summary>
        public WorkloadSummary WorkloadSummary
        {
            get { return this._workloadSummary; }
            set { this._workloadSummary = value; }
        }

        // Check to see if WorkloadSummary property is set
        internal bool IsSetWorkloadSummary()
        {
            return this._workloadSummary != null;
        }

    }
}
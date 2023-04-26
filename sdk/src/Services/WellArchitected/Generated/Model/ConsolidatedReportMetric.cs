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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A metric that contributes to the consolidated report.
    /// </summary>
    public partial class ConsolidatedReportMetric
    {
        private List<LensMetric> _lenses = new List<LensMetric>();
        private int? _lensesAppliedCount;
        private MetricType _metricType;
        private Dictionary<string, int> _riskCounts = new Dictionary<string, int>();
        private DateTime? _updatedAt;
        private string _workloadArn;
        private string _workloadId;
        private string _workloadName;

        /// <summary>
        /// Gets and sets the property Lenses. 
        /// <para>
        /// The metrics for the lenses in the workload.
        /// </para>
        /// </summary>
        public List<LensMetric> Lenses
        {
            get { return this._lenses; }
            set { this._lenses = value; }
        }

        // Check to see if Lenses property is set
        internal bool IsSetLenses()
        {
            return this._lenses != null && this._lenses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LensesAppliedCount. 
        /// <para>
        /// The total number of lenses applied to the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int LensesAppliedCount
        {
            get { return this._lensesAppliedCount.GetValueOrDefault(); }
            set { this._lensesAppliedCount = value; }
        }

        // Check to see if LensesAppliedCount property is set
        internal bool IsSetLensesAppliedCount()
        {
            return this._lensesAppliedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// The metric type of a metric in the consolidated report. Currently only WORKLOAD metric
        /// types are supported.
        /// </para>
        /// </summary>
        public MetricType MetricType
        {
            get { return this._metricType; }
            set { this._metricType = value; }
        }

        // Check to see if MetricType property is set
        internal bool IsSetMetricType()
        {
            return this._metricType != null;
        }

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// </summary>
        public Dictionary<string, int> RiskCounts
        {
            get { return this._riskCounts; }
            set { this._riskCounts = value; }
        }

        // Check to see if RiskCounts property is set
        internal bool IsSetRiskCounts()
        {
            return this._riskCounts != null && this._riskCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt.
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkloadArn.
        /// </summary>
        public string WorkloadArn
        {
            get { return this._workloadArn; }
            set { this._workloadArn = value; }
        }

        // Check to see if WorkloadArn property is set
        internal bool IsSetWorkloadArn()
        {
            return this._workloadArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min=3, Max=100)]
        public string WorkloadName
        {
            get { return this._workloadName; }
            set { this._workloadName = value; }
        }

        // Check to see if WorkloadName property is set
        internal bool IsSetWorkloadName()
        {
            return this._workloadName != null;
        }

    }
}
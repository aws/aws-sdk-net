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
    /// A metric that contributes to the consolidated report.
    /// </summary>
    public partial class ConsolidatedReportMetric
    {
        /// <summary>
        /// Gets and sets the property Lenses. 
        /// <para>
        /// The metrics for the lenses in the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LensMetric> Lenses { get; set; } = AWSConfigs.InitializeCollections ? new List<LensMetric>() : null;

        /// <summary>
        /// Checks to see if the Lenses property is set.
        /// </summary>
        internal bool IsSetLenses() => this.Lenses != null && (this.Lenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LensesAppliedCount. 
        /// <para>
        /// The total number of lenses applied to the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? LensesAppliedCount { get; set; }

        /// <summary>
        /// Checks to see if the LensesAppliedCount property is set.
        /// </summary>
        internal bool IsSetLensesAppliedCount() => this.LensesAppliedCount.HasValue;

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        /// The metric type of a metric in the consolidated report. Currently only WORKLOAD metric
        /// types are supported.
        /// </para>
        /// </summary>
        public MetricType MetricType { get; set; }

        /// <summary>
        /// Checks to see if the MetricType property is set.
        /// </summary>
        internal bool IsSetMetricType() => this.MetricType != null;

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> RiskCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the RiskCounts property is set.
        /// </summary>
        internal bool IsSetRiskCounts() => this.RiskCounts != null && (this.RiskCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the consolidated report metric was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkloadArn.
        /// </summary>
        public string WorkloadArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadArn property is set.
        /// </summary>
        internal bool IsSetWorkloadArn() => this.WorkloadArn != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}

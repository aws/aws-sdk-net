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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Contains the estimated impact of creating, updating, or deleting an account-level
    /// retention policy. The analysis compares the effective retention period of each log
    /// group, which accounts for all account-level retention policies that apply to it, before
    /// and after the change. Log groups in the Delivery class are not included.
    /// </summary>
    public partial class DryRunResult
    {
        /// <summary>
        /// Gets and sets the property DecreasedRetentionLogGroupCount. 
        /// <para>
        /// The number of log groups whose effective retention period would become shorter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DecreasedRetentionLogGroupCount { get; set; }

        /// <summary>
        /// Checks to see if the DecreasedRetentionLogGroupCount property is set.
        /// </summary>
        internal bool IsSetDecreasedRetentionLogGroupCount() => this.DecreasedRetentionLogGroupCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedAnalysisCount. 
        /// <para>
        /// The number of log groups in the scope of the policy that could not be analyzed. These
        /// log groups are not included in <c>totalMatchedLogGroups</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? FailedAnalysisCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedAnalysisCount property is set.
        /// </summary>
        internal bool IsSetFailedAnalysisCount() => this.FailedAnalysisCount.HasValue;

        /// <summary>
        /// Gets and sets the property IncreasedRetentionLogGroupCount. 
        /// <para>
        /// The number of log groups whose effective retention period would become longer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? IncreasedRetentionLogGroupCount { get; set; }

        /// <summary>
        /// Checks to see if the IncreasedRetentionLogGroupCount property is set.
        /// </summary>
        internal bool IsSetIncreasedRetentionLogGroupCount() => this.IncreasedRetentionLogGroupCount.HasValue;

        /// <summary>
        /// Gets and sets the property TopLogGroupsImpacted. 
        /// <para>
        /// Up to 20 log groups in the scope of the policy, sorted by stored bytes in descending
        /// order. This list can include log groups whose effective retention period would not
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogGroupImpact> TopLogGroupsImpacted { get; set; } = AWSConfigs.InitializeCollections ? new List<LogGroupImpact>() : null;

        /// <summary>
        /// Checks to see if the TopLogGroupsImpacted property is set.
        /// </summary>
        internal bool IsSetTopLogGroupsImpacted() => this.TopLogGroupsImpacted != null && (this.TopLogGroupsImpacted.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalMatchedLogGroups. 
        /// <para>
        /// The number of log groups in the scope of the policy that were analyzed. This value
        /// is the sum of <c>increasedRetentionLogGroupCount</c>, <c>decreasedRetentionLogGroupCount</c>,
        /// and <c>unchangedRetentionLogGroupCount</c>, and does not include log groups that could
        /// not be analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalMatchedLogGroups { get; set; }

        /// <summary>
        /// Checks to see if the TotalMatchedLogGroups property is set.
        /// </summary>
        internal bool IsSetTotalMatchedLogGroups() => this.TotalMatchedLogGroups.HasValue;

        /// <summary>
        /// Gets and sets the property UnchangedRetentionLogGroupCount. 
        /// <para>
        /// The number of log groups whose effective retention period would not change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UnchangedRetentionLogGroupCount { get; set; }

        /// <summary>
        /// Checks to see if the UnchangedRetentionLogGroupCount property is set.
        /// </summary>
        internal bool IsSetUnchangedRetentionLogGroupCount() => this.UnchangedRetentionLogGroupCount.HasValue;
    }
}

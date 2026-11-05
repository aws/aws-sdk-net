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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeAuditMitigationActionsTask operation.
    /// </summary>
    public partial class DescribeAuditMitigationActionsTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionsDefinition. 
        /// <para>
        /// Specifies the mitigation actions and their parameters that are applied as part of
        /// this task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MitigationAction> ActionsDefinition { get; set; } = AWSConfigs.InitializeCollections ? new List<MitigationAction>() : null;

        /// <summary>
        /// Checks to see if the ActionsDefinition property is set.
        /// </summary>
        internal bool IsSetActionsDefinition() => this.ActionsDefinition != null && (this.ActionsDefinition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuditCheckToActionsMapping. 
        /// <para>
        /// Specifies the mitigation actions that should be applied to specific audit checks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> AuditCheckToActionsMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the AuditCheckToActionsMapping property is set.
        /// </summary>
        internal bool IsSetAuditCheckToActionsMapping() => this.AuditCheckToActionsMapping != null && (this.AuditCheckToActionsMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the task was completed or canceled.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the task was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Identifies the findings to which the mitigation actions are applied. This can be by
        /// audit checks, by audit task, or a set of findings.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TaskStatistics. 
        /// <para>
        /// Aggregate counts of the results when the mitigation tasks were applied to the findings
        /// for this audit mitigation actions task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TaskStatisticsForAuditCheck> TaskStatistics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TaskStatisticsForAuditCheck>() : null;

        /// <summary>
        /// Checks to see if the TaskStatistics property is set.
        /// </summary>
        internal bool IsSetTaskStatistics() => this.TaskStatistics != null && (this.TaskStatistics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The current status of the task.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}

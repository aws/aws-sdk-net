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
    /// The summary of the mitigation action tasks.
    /// </summary>
    public partial class DetectMitigationActionsTaskSummary
    {
        /// <summary>
        /// Gets and sets the property ActionsDefinition. 
        /// <para>
        ///  The definition of the actions. 
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
        /// Gets and sets the property OnlyActiveViolationsIncluded. 
        /// <para>
        ///  Includes only active violations. 
        /// </para>
        /// </summary>
        public bool? OnlyActiveViolationsIncluded { get; set; }

        /// <summary>
        /// Checks to see if the OnlyActiveViolationsIncluded property is set.
        /// </summary>
        internal bool IsSetOnlyActiveViolationsIncluded() => this.OnlyActiveViolationsIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property SuppressedAlertsIncluded. 
        /// <para>
        ///  Includes suppressed alerts. 
        /// </para>
        /// </summary>
        public bool? SuppressedAlertsIncluded { get; set; }

        /// <summary>
        /// Checks to see if the SuppressedAlertsIncluded property is set.
        /// </summary>
        internal bool IsSetSuppressedAlertsIncluded() => this.SuppressedAlertsIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  Specifies the ML Detect findings to which the mitigation actions are applied. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TaskEndTime. 
        /// <para>
        ///  The date the task ended. 
        /// </para>
        /// </summary>
        public DateTime? TaskEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskEndTime property is set.
        /// </summary>
        internal bool IsSetTaskEndTime() => this.TaskEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        ///  The date the task started. 
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartTime property is set.
        /// </summary>
        internal bool IsSetTaskStartTime() => this.TaskStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskStatistics. 
        /// <para>
        ///  The statistics of a mitigation action task. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskStatistics TaskStatistics { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatistics property is set.
        /// </summary>
        internal bool IsSetTaskStatistics() => this.TaskStatistics != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        ///  The status of the task. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;

        /// <summary>
        /// Gets and sets the property ViolationEventOccurrenceRange. 
        /// <para>
        ///  Specifies the time period of which violation events occurred between. 
        /// </para>
        /// </summary>
        public ViolationEventOccurrenceRange ViolationEventOccurrenceRange { get; set; }

        /// <summary>
        /// Checks to see if the ViolationEventOccurrenceRange property is set.
        /// </summary>
        internal bool IsSetViolationEventOccurrenceRange() => this.ViolationEventOccurrenceRange != null;
    }
}

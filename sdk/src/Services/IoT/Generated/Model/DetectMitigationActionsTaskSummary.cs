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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private List<MitigationAction> _actionsDefinition = AWSConfigs.InitializeCollections ? new List<MitigationAction>() : null;
        private bool? _onlyActiveViolationsIncluded;
        private bool? _suppressedAlertsIncluded;
        private DetectMitigationActionsTaskTarget _target;
        private DateTime? _taskEndTime;
        private string _taskId;
        private DateTime? _taskStartTime;
        private DetectMitigationActionsTaskStatistics _taskStatistics;
        private DetectMitigationActionsTaskStatus _taskStatus;
        private ViolationEventOccurrenceRange _violationEventOccurrenceRange;

        /// <summary>
        /// Gets and sets the property ActionsDefinition. 
        /// <para>
        ///  The definition of the actions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MitigationAction> ActionsDefinition
        {
            get { return this._actionsDefinition; }
            set { this._actionsDefinition = value; }
        }

        // Check to see if ActionsDefinition property is set
        internal bool IsSetActionsDefinition()
        {
            return this._actionsDefinition != null && (this._actionsDefinition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnlyActiveViolationsIncluded. 
        /// <para>
        ///  Includes only active violations. 
        /// </para>
        /// </summary>
        public bool? OnlyActiveViolationsIncluded
        {
            get { return this._onlyActiveViolationsIncluded; }
            set { this._onlyActiveViolationsIncluded = value; }
        }

        // Check to see if OnlyActiveViolationsIncluded property is set
        internal bool IsSetOnlyActiveViolationsIncluded()
        {
            return this._onlyActiveViolationsIncluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuppressedAlertsIncluded. 
        /// <para>
        ///  Includes suppressed alerts. 
        /// </para>
        /// </summary>
        public bool? SuppressedAlertsIncluded
        {
            get { return this._suppressedAlertsIncluded; }
            set { this._suppressedAlertsIncluded = value; }
        }

        // Check to see if SuppressedAlertsIncluded property is set
        internal bool IsSetSuppressedAlertsIncluded()
        {
            return this._suppressedAlertsIncluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  Specifies the ML Detect findings to which the mitigation actions are applied. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TaskEndTime. 
        /// <para>
        ///  The date the task ended. 
        /// </para>
        /// </summary>
        public DateTime? TaskEndTime
        {
            get { return this._taskEndTime; }
            set { this._taskEndTime = value; }
        }

        // Check to see if TaskEndTime property is set
        internal bool IsSetTaskEndTime()
        {
            return this._taskEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        ///  The date the task started. 
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime
        {
            get { return this._taskStartTime; }
            set { this._taskStartTime = value; }
        }

        // Check to see if TaskStartTime property is set
        internal bool IsSetTaskStartTime()
        {
            return this._taskStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskStatistics. 
        /// <para>
        ///  The statistics of a mitigation action task. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskStatistics TaskStatistics
        {
            get { return this._taskStatistics; }
            set { this._taskStatistics = value; }
        }

        // Check to see if TaskStatistics property is set
        internal bool IsSetTaskStatistics()
        {
            return this._taskStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        ///  The status of the task. 
        /// </para>
        /// </summary>
        public DetectMitigationActionsTaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationEventOccurrenceRange. 
        /// <para>
        ///  Specifies the time period of which violation events occurred between. 
        /// </para>
        /// </summary>
        public ViolationEventOccurrenceRange ViolationEventOccurrenceRange
        {
            get { return this._violationEventOccurrenceRange; }
            set { this._violationEventOccurrenceRange = value; }
        }

        // Check to see if ViolationEventOccurrenceRange property is set
        internal bool IsSetViolationEventOccurrenceRange()
        {
            return this._violationEventOccurrenceRange != null;
        }

    }
}
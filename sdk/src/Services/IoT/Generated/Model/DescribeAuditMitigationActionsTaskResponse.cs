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
    /// This is the response object from the DescribeAuditMitigationActionsTask operation.
    /// </summary>
    public partial class DescribeAuditMitigationActionsTaskResponse : AmazonWebServiceResponse
    {
        private List<MitigationAction> _actionsDefinition = AWSConfigs.InitializeCollections ? new List<MitigationAction>() : null;
        private Dictionary<string, List<string>> _auditCheckToActionsMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private DateTime? _endTime;
        private DateTime? _startTime;
        private AuditMitigationActionsTaskTarget _target;
        private Dictionary<string, TaskStatisticsForAuditCheck> _taskStatistics = AWSConfigs.InitializeCollections ? new Dictionary<string, TaskStatisticsForAuditCheck>() : null;
        private AuditMitigationActionsTaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property ActionsDefinition. 
        /// <para>
        /// Specifies the mitigation actions and their parameters that are applied as part of
        /// this task.
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
        /// Gets and sets the property AuditCheckToActionsMapping. 
        /// <para>
        /// Specifies the mitigation actions that should be applied to specific audit checks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> AuditCheckToActionsMapping
        {
            get { return this._auditCheckToActionsMapping; }
            set { this._auditCheckToActionsMapping = value; }
        }

        // Check to see if AuditCheckToActionsMapping property is set
        internal bool IsSetAuditCheckToActionsMapping()
        {
            return this._auditCheckToActionsMapping != null && (this._auditCheckToActionsMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the task was completed or canceled.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the task was started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Identifies the findings to which the mitigation actions are applied. This can be by
        /// audit checks, by audit task, or a set of findings.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskTarget Target
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
        /// Gets and sets the property TaskStatistics. 
        /// <para>
        /// Aggregate counts of the results when the mitigation tasks were applied to the findings
        /// for this audit mitigation actions task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TaskStatisticsForAuditCheck> TaskStatistics
        {
            get { return this._taskStatistics; }
            set { this._taskStatistics = value; }
        }

        // Check to see if TaskStatistics property is set
        internal bool IsSetTaskStatistics()
        {
            return this._taskStatistics != null && (this._taskStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The current status of the task.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}
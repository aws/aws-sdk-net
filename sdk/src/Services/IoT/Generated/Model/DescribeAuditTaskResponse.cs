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
    /// This is the response object from the DescribeAuditTask operation.
    /// </summary>
    public partial class DescribeAuditTaskResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, AuditCheckDetails> _auditDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditCheckDetails>() : null;
        private string _scheduledAuditName;
        private DateTime? _taskStartTime;
        private TaskStatistics _taskStatistics;
        private AuditTaskStatus _taskStatus;
        private AuditTaskType _taskType;

        /// <summary>
        /// Gets and sets the property AuditDetails. 
        /// <para>
        /// Detailed information about each check performed during this audit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditCheckDetails> AuditDetails
        {
            get { return this._auditDetails; }
            set { this._auditDetails = value; }
        }

        // Check to see if AuditDetails property is set
        internal bool IsSetAuditDetails()
        {
            return this._auditDetails != null && (this._auditDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name of the scheduled audit (only if the audit was a scheduled audit).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ScheduledAuditName
        {
            get { return this._scheduledAuditName; }
            set { this._scheduledAuditName = value; }
        }

        // Check to see if ScheduledAuditName property is set
        internal bool IsSetScheduledAuditName()
        {
            return this._scheduledAuditName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the audit started.
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
        /// Statistical information about the audit.
        /// </para>
        /// </summary>
        public TaskStatistics TaskStatistics
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
        /// The status of the audit: one of "IN_PROGRESS", "COMPLETED", "FAILED", or "CANCELED".
        /// </para>
        /// </summary>
        public AuditTaskStatus TaskStatus
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
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of audit: "ON_DEMAND_AUDIT_TASK" or "SCHEDULED_AUDIT_TASK".
        /// </para>
        /// </summary>
        public AuditTaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

    }
}
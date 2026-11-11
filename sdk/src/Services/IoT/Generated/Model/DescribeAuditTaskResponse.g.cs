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
    /// This is the response object from the DescribeAuditTask operation.
    /// </summary>
    public partial class DescribeAuditTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuditDetails. 
        /// <para>
        /// Detailed information about each check performed during this audit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AuditCheckDetails> AuditDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AuditCheckDetails>() : null;

        /// <summary>
        /// Checks to see if the AuditDetails property is set.
        /// </summary>
        internal bool IsSetAuditDetails() => this.AuditDetails != null && (this.AuditDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name of the scheduled audit (only if the audit was a scheduled audit).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ScheduledAuditName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAuditName property is set.
        /// </summary>
        internal bool IsSetScheduledAuditName() => this.ScheduledAuditName != null;

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the audit started.
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
        /// Statistical information about the audit.
        /// </para>
        /// </summary>
        public TaskStatistics TaskStatistics { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatistics property is set.
        /// </summary>
        internal bool IsSetTaskStatistics() => this.TaskStatistics != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// The status of the audit: one of "IN_PROGRESS", "COMPLETED", "FAILED", or "CANCELED".
        /// </para>
        /// </summary>
        public AuditTaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of audit: "ON_DEMAND_AUDIT_TASK" or "SCHEDULED_AUDIT_TASK".
        /// </para>
        /// </summary>
        public AuditTaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;
    }
}

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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information about a scheduled backup plan execution, including the execution
    /// time, rule type, and associated rule identifier.
    /// </summary>
    public partial class ScheduledPlanExecutionMember
    {
        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The timestamp when the backup is scheduled to run, in Unix format and Coordinated
        /// Universal Time (UTC). The value is accurate to milliseconds.
        /// </para>
        /// </summary>
        public DateTime? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property RuleExecutionType. 
        /// <para>
        /// The type of backup rule execution. Valid values are <c>CONTINUOUS</c> (point-in-time
        /// recovery), <c>SNAPSHOTS</c> (snapshot backups), or <c>CONTINUOUS_AND_SNAPSHOTS</c>
        /// (both types combined).
        /// </para>
        /// </summary>
        public RuleExecutionType RuleExecutionType { get; set; }

        /// <summary>
        /// Checks to see if the RuleExecutionType property is set.
        /// </summary>
        internal bool IsSetRuleExecutionType() => this.RuleExecutionType != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The unique identifier of the backup rule that will execute at the scheduled time.
        /// </para>
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;
    }
}

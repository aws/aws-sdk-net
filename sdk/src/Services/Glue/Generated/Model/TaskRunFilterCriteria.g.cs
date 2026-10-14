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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The criteria that are used to filter the task runs for the machine learning transform.
    /// </summary>
    public partial class TaskRunFilterCriteria
    {
        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter on task runs started after this date.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartedAfter property is set.
        /// </summary>
        internal bool IsSetStartedAfter() => this.StartedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter on task runs started before this date.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartedBefore property is set.
        /// </summary>
        internal bool IsSetStartedBefore() => this.StartedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the task run.
        /// </para>
        /// </summary>
        public TaskStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskRunType. 
        /// <para>
        /// The type of task run.
        /// </para>
        /// </summary>
        public TaskType TaskRunType { get; set; }

        /// <summary>
        /// Checks to see if the TaskRunType property is set.
        /// </summary>
        internal bool IsSetTaskRunType() => this.TaskRunType != null;
    }
}

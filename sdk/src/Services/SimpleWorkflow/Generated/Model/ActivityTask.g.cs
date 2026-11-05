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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Unit of work sent to an activity worker.
    /// </summary>
    public partial class ActivityTask
    {
        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        /// The unique ID of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ActivityId property is set.
        /// </summary>
        internal bool IsSetActivityId() => this.ActivityId != null;

        /// <summary>
        /// Gets and sets the property ActivityType. 
        /// <para>
        /// The type of this activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Checks to see if the ActivityType property is set.
        /// </summary>
        internal bool IsSetActivityType() => this.ActivityType != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The inputs provided when the activity task was scheduled. The form of the input is
        /// user defined and should be meaningful to the activity implementation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>ActivityTaskStarted</c> event recorded in the history.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the StartedEventId property is set.
        /// </summary>
        internal bool IsSetStartedEventId() => this.StartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The opaque string used as a handle on the task. This token is used by workers to communicate
        /// progress and response information back to the system about the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TaskToken { get; set; }

        /// <summary>
        /// Checks to see if the TaskToken property is set.
        /// </summary>
        internal bool IsSetTaskToken() => this.TaskToken != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The workflow execution that started this activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecution WorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecution property is set.
        /// </summary>
        internal bool IsSetWorkflowExecution() => this.WorkflowExecution != null;
    }
}

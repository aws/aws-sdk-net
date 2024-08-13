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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
        private string _activityId;
        private ActivityType _activityType;
        private string _input;
        private long? _startedEventId;
        private string _taskToken;
        private WorkflowExecution _workflowExecution;

        /// <summary>
        /// Gets and sets the property ActivityId. 
        /// <para>
        /// The unique ID of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ActivityId
        {
            get { return this._activityId; }
            set { this._activityId = value; }
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this._activityId != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityType. 
        /// <para>
        /// The type of this activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivityType ActivityType
        {
            get { return this._activityType; }
            set { this._activityType = value; }
        }

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this._activityType != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The inputs provided when the activity task was scheduled. The form of the input is
        /// user defined and should be meaningful to the activity implementation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>ActivityTaskStarted</c> event recorded in the history.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? StartedEventId
        {
            get { return this._startedEventId; }
            set { this._startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this._startedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The opaque string used as a handle on the task. This token is used by workers to communicate
        /// progress and response information back to the system about the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The workflow execution that started this activity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowExecution WorkflowExecution
        {
            get { return this._workflowExecution; }
            set { this._workflowExecution = value; }
        }

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this._workflowExecution != null;
        }

    }
}
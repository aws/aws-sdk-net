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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// This is the response object from the GetTaskInstance operation.
    /// </summary>
    public partial class GetTaskInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttemptNumber. 
        /// <para>
        /// The attempt number for this task instance.
        /// </para>
        /// </summary>
        public int? AttemptNumber { get; set; }

        /// <summary>
        /// Checks to see if the AttemptNumber property is set.
        /// </summary>
        internal bool IsSetAttemptNumber() => this.AttemptNumber.HasValue;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the task instance execution in seconds. This value is null if the
        /// task is not complete.
        /// </para>
        /// </summary>
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the task instance completed execution, in ISO 8601 date-time format.
        /// This value is null if the task is not complete.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message if the task instance failed. This value is null if the task completed
        /// successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The CloudWatch log stream name for this task instance execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogStream { get; set; }

        /// <summary>
        /// Checks to see if the LogStream property is set.
        /// </summary>
        internal bool IsSetLogStream() => this.LogStream != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the task instance was last modified, in ISO 8601 date-time format.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OperatorName. 
        /// <para>
        /// The name of the Apache Airflow operator used for this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperatorName { get; set; }

        /// <summary>
        /// Checks to see if the OperatorName property is set.
        /// </summary>
        internal bool IsSetOperatorName() => this.OperatorName != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of the workflow run that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the task instance started execution, in ISO 8601 date-time format.
        /// This value is null if the task has not started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the task instance.
        /// </para>
        /// </summary>
        public TaskInstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task definition within the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskInstanceId. 
        /// <para>
        /// The unique identifier of this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the TaskInstanceId property is set.
        /// </summary>
        internal bool IsSetTaskInstanceId() => this.TaskInstanceId != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version of the workflow that contains this task instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;

        /// <summary>
        /// Gets and sets the property Xcom. 
        /// <para>
        /// Cross-communication data exchanged between tasks in the workflow execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Xcom { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Xcom property is set.
        /// </summary>
        internal bool IsSetXcom() => this.Xcom != null && (this.Xcom.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

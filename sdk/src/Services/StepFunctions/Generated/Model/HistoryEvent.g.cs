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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about the events of an execution.
    /// </summary>
    public partial class HistoryEvent
    {
        /// <summary>
        /// Gets and sets the property ActivityFailedEventDetails.
        /// </summary>
        public ActivityFailedEventDetails ActivityFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivityFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetActivityFailedEventDetails() => this.ActivityFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ActivityScheduleFailedEventDetails. 
        /// <para>
        /// Contains details about an activity schedule event that failed during an execution.
        /// </para>
        /// </summary>
        public ActivityScheduleFailedEventDetails ActivityScheduleFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivityScheduleFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetActivityScheduleFailedEventDetails() => this.ActivityScheduleFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ActivityScheduledEventDetails.
        /// </summary>
        public ActivityScheduledEventDetails ActivityScheduledEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivityScheduledEventDetails property is set.
        /// </summary>
        internal bool IsSetActivityScheduledEventDetails() => this.ActivityScheduledEventDetails != null;

        /// <summary>
        /// Gets and sets the property ActivityStartedEventDetails.
        /// </summary>
        public ActivityStartedEventDetails ActivityStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetActivityStartedEventDetails() => this.ActivityStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ActivitySucceededEventDetails.
        /// </summary>
        public ActivitySucceededEventDetails ActivitySucceededEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivitySucceededEventDetails property is set.
        /// </summary>
        internal bool IsSetActivitySucceededEventDetails() => this.ActivitySucceededEventDetails != null;

        /// <summary>
        /// Gets and sets the property ActivityTimedOutEventDetails.
        /// </summary>
        public ActivityTimedOutEventDetails ActivityTimedOutEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTimedOutEventDetails property is set.
        /// </summary>
        internal bool IsSetActivityTimedOutEventDetails() => this.ActivityTimedOutEventDetails != null;

        /// <summary>
        /// Gets and sets the property EvaluationFailedEventDetails. 
        /// <para>
        /// Contains details about an evaluation failure that occurred while processing a state.
        /// </para>
        /// </summary>
        public EvaluationFailedEventDetails EvaluationFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetEvaluationFailedEventDetails() => this.EvaluationFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionAbortedEventDetails.
        /// </summary>
        public ExecutionAbortedEventDetails ExecutionAbortedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionAbortedEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionAbortedEventDetails() => this.ExecutionAbortedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionFailedEventDetails.
        /// </summary>
        public ExecutionFailedEventDetails ExecutionFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionFailedEventDetails() => this.ExecutionFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionRedrivenEventDetails. 
        /// <para>
        /// Contains details about the redrive attempt of an execution.
        /// </para>
        /// </summary>
        public ExecutionRedrivenEventDetails ExecutionRedrivenEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRedrivenEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionRedrivenEventDetails() => this.ExecutionRedrivenEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionStartedEventDetails.
        /// </summary>
        public ExecutionStartedEventDetails ExecutionStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionStartedEventDetails() => this.ExecutionStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionSucceededEventDetails.
        /// </summary>
        public ExecutionSucceededEventDetails ExecutionSucceededEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionSucceededEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionSucceededEventDetails() => this.ExecutionSucceededEventDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimedOutEventDetails.
        /// </summary>
        public ExecutionTimedOutEventDetails ExecutionTimedOutEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimedOutEventDetails property is set.
        /// </summary>
        internal bool IsSetExecutionTimedOutEventDetails() => this.ExecutionTimedOutEventDetails != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the event. Events are numbered sequentially, starting at one.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property LambdaFunctionFailedEventDetails.
        /// </summary>
        public LambdaFunctionFailedEventDetails LambdaFunctionFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionFailedEventDetails() => this.LambdaFunctionFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduleFailedEventDetails.
        /// </summary>
        public LambdaFunctionScheduleFailedEventDetails LambdaFunctionScheduleFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionScheduleFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionScheduleFailedEventDetails() => this.LambdaFunctionScheduleFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduledEventDetails.
        /// </summary>
        public LambdaFunctionScheduledEventDetails LambdaFunctionScheduledEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionScheduledEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionScheduledEventDetails() => this.LambdaFunctionScheduledEventDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionStartFailedEventDetails. 
        /// <para>
        /// Contains details about a lambda function that failed to start during an execution.
        /// </para>
        /// </summary>
        public LambdaFunctionStartFailedEventDetails LambdaFunctionStartFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionStartFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionStartFailedEventDetails() => this.LambdaFunctionStartFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionSucceededEventDetails. 
        /// <para>
        /// Contains details about a Lambda function that terminated successfully during an execution.
        /// </para>
        /// </summary>
        public LambdaFunctionSucceededEventDetails LambdaFunctionSucceededEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionSucceededEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionSucceededEventDetails() => this.LambdaFunctionSucceededEventDetails != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionTimedOutEventDetails.
        /// </summary>
        public LambdaFunctionTimedOutEventDetails LambdaFunctionTimedOutEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionTimedOutEventDetails property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionTimedOutEventDetails() => this.LambdaFunctionTimedOutEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapIterationAbortedEventDetails. 
        /// <para>
        /// Contains details about an iteration of a Map state that was aborted.
        /// </para>
        /// </summary>
        public MapIterationEventDetails MapIterationAbortedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapIterationAbortedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapIterationAbortedEventDetails() => this.MapIterationAbortedEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapIterationFailedEventDetails. 
        /// <para>
        /// Contains details about an iteration of a Map state that failed.
        /// </para>
        /// </summary>
        public MapIterationEventDetails MapIterationFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapIterationFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapIterationFailedEventDetails() => this.MapIterationFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapIterationStartedEventDetails. 
        /// <para>
        /// Contains details about an iteration of a Map state that was started.
        /// </para>
        /// </summary>
        public MapIterationEventDetails MapIterationStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapIterationStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapIterationStartedEventDetails() => this.MapIterationStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapIterationSucceededEventDetails. 
        /// <para>
        /// Contains details about an iteration of a Map state that succeeded.
        /// </para>
        /// </summary>
        public MapIterationEventDetails MapIterationSucceededEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapIterationSucceededEventDetails property is set.
        /// </summary>
        internal bool IsSetMapIterationSucceededEventDetails() => this.MapIterationSucceededEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapRunFailedEventDetails. 
        /// <para>
        /// Contains error and cause details about a Map Run that failed.
        /// </para>
        /// </summary>
        public MapRunFailedEventDetails MapRunFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapRunFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapRunFailedEventDetails() => this.MapRunFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapRunRedrivenEventDetails. 
        /// <para>
        /// Contains details about the redrive attempt of a Map Run.
        /// </para>
        /// </summary>
        public MapRunRedrivenEventDetails MapRunRedrivenEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapRunRedrivenEventDetails property is set.
        /// </summary>
        internal bool IsSetMapRunRedrivenEventDetails() => this.MapRunRedrivenEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapRunStartedEventDetails. 
        /// <para>
        /// Contains details, such as <c>mapRunArn</c>, and the start date and time of a Map Run.
        /// <c>mapRunArn</c> is the Amazon Resource Name (ARN) of the Map Run that was started.
        /// </para>
        /// </summary>
        public MapRunStartedEventDetails MapRunStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapRunStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapRunStartedEventDetails() => this.MapRunStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property MapStateStartedEventDetails. 
        /// <para>
        /// Contains details about Map state that was started.
        /// </para>
        /// </summary>
        public MapStateStartedEventDetails MapStateStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the MapStateStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetMapStateStartedEventDetails() => this.MapStateStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property PreviousEventId. 
        /// <para>
        /// The id of the previous event.
        /// </para>
        /// </summary>
        public long? PreviousEventId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousEventId property is set.
        /// </summary>
        internal bool IsSetPreviousEventId() => this.PreviousEventId.HasValue;

        /// <summary>
        /// Gets and sets the property StateEnteredEventDetails.
        /// </summary>
        public StateEnteredEventDetails StateEnteredEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateEnteredEventDetails property is set.
        /// </summary>
        internal bool IsSetStateEnteredEventDetails() => this.StateEnteredEventDetails != null;

        /// <summary>
        /// Gets and sets the property StateExitedEventDetails.
        /// </summary>
        public StateExitedEventDetails StateExitedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateExitedEventDetails property is set.
        /// </summary>
        internal bool IsSetStateExitedEventDetails() => this.StateExitedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskFailedEventDetails. 
        /// <para>
        /// Contains details about the failure of a task.
        /// </para>
        /// </summary>
        public TaskFailedEventDetails TaskFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskFailedEventDetails() => this.TaskFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskScheduledEventDetails. 
        /// <para>
        /// Contains details about a task that was scheduled.
        /// </para>
        /// </summary>
        public TaskScheduledEventDetails TaskScheduledEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskScheduledEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskScheduledEventDetails() => this.TaskScheduledEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskStartFailedEventDetails. 
        /// <para>
        /// Contains details about a task that failed to start.
        /// </para>
        /// </summary>
        public TaskStartFailedEventDetails TaskStartFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskStartFailedEventDetails() => this.TaskStartFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskStartedEventDetails. 
        /// <para>
        /// Contains details about a task that was started.
        /// </para>
        /// </summary>
        public TaskStartedEventDetails TaskStartedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartedEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskStartedEventDetails() => this.TaskStartedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskSubmitFailedEventDetails. 
        /// <para>
        /// Contains details about a task that where the submit failed.
        /// </para>
        /// </summary>
        public TaskSubmitFailedEventDetails TaskSubmitFailedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskSubmitFailedEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskSubmitFailedEventDetails() => this.TaskSubmitFailedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskSubmittedEventDetails. 
        /// <para>
        /// Contains details about a submitted task.
        /// </para>
        /// </summary>
        public TaskSubmittedEventDetails TaskSubmittedEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskSubmittedEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskSubmittedEventDetails() => this.TaskSubmittedEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskSucceededEventDetails. 
        /// <para>
        /// Contains details about a task that succeeded.
        /// </para>
        /// </summary>
        public TaskSucceededEventDetails TaskSucceededEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskSucceededEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskSucceededEventDetails() => this.TaskSucceededEventDetails != null;

        /// <summary>
        /// Gets and sets the property TaskTimedOutEventDetails. 
        /// <para>
        /// Contains details about a task that timed out.
        /// </para>
        /// </summary>
        public TaskTimedOutEventDetails TaskTimedOutEventDetails { get; set; }

        /// <summary>
        /// Checks to see if the TaskTimedOutEventDetails property is set.
        /// </summary>
        internal bool IsSetTaskTimedOutEventDetails() => this.TaskTimedOutEventDetails != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time the event occurred, expressed in seconds and fractional milliseconds
        /// since the Unix epoch, which is defined as January 1, 1970, at 00:00:00 Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HistoryEventType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

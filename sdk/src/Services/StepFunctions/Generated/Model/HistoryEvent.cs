/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HistoryEvent
    {
        private ActivityFailedEventDetails _activityFailedEventDetails;
        private ActivityScheduledEventDetails _activityScheduledEventDetails;
        private ActivityScheduleFailedEventDetails _activityScheduleFailedEventDetails;
        private ActivityStartedEventDetails _activityStartedEventDetails;
        private ActivitySucceededEventDetails _activitySucceededEventDetails;
        private ActivityTimedOutEventDetails _activityTimedOutEventDetails;
        private ExecutionAbortedEventDetails _executionAbortedEventDetails;
        private ExecutionFailedEventDetails _executionFailedEventDetails;
        private ExecutionStartedEventDetails _executionStartedEventDetails;
        private ExecutionSucceededEventDetails _executionSucceededEventDetails;
        private ExecutionTimedOutEventDetails _executionTimedOutEventDetails;
        private long? _id;
        private LambdaFunctionFailedEventDetails _lambdaFunctionFailedEventDetails;
        private LambdaFunctionScheduledEventDetails _lambdaFunctionScheduledEventDetails;
        private LambdaFunctionScheduleFailedEventDetails _lambdaFunctionScheduleFailedEventDetails;
        private LambdaFunctionStartFailedEventDetails _lambdaFunctionStartFailedEventDetails;
        private LambdaFunctionSucceededEventDetails _lambdaFunctionSucceededEventDetails;
        private LambdaFunctionTimedOutEventDetails _lambdaFunctionTimedOutEventDetails;
        private long? _previousEventId;
        private StateEnteredEventDetails _stateEnteredEventDetails;
        private StateExitedEventDetails _stateExitedEventDetails;
        private DateTime? _timestamp;
        private HistoryEventType _type;

        /// <summary>
        /// Gets and sets the property ActivityFailedEventDetails.
        /// </summary>
        public ActivityFailedEventDetails ActivityFailedEventDetails
        {
            get { return this._activityFailedEventDetails; }
            set { this._activityFailedEventDetails = value; }
        }

        // Check to see if ActivityFailedEventDetails property is set
        internal bool IsSetActivityFailedEventDetails()
        {
            return this._activityFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityScheduledEventDetails.
        /// </summary>
        public ActivityScheduledEventDetails ActivityScheduledEventDetails
        {
            get { return this._activityScheduledEventDetails; }
            set { this._activityScheduledEventDetails = value; }
        }

        // Check to see if ActivityScheduledEventDetails property is set
        internal bool IsSetActivityScheduledEventDetails()
        {
            return this._activityScheduledEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityScheduleFailedEventDetails.
        /// </summary>
        public ActivityScheduleFailedEventDetails ActivityScheduleFailedEventDetails
        {
            get { return this._activityScheduleFailedEventDetails; }
            set { this._activityScheduleFailedEventDetails = value; }
        }

        // Check to see if ActivityScheduleFailedEventDetails property is set
        internal bool IsSetActivityScheduleFailedEventDetails()
        {
            return this._activityScheduleFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityStartedEventDetails.
        /// </summary>
        public ActivityStartedEventDetails ActivityStartedEventDetails
        {
            get { return this._activityStartedEventDetails; }
            set { this._activityStartedEventDetails = value; }
        }

        // Check to see if ActivityStartedEventDetails property is set
        internal bool IsSetActivityStartedEventDetails()
        {
            return this._activityStartedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ActivitySucceededEventDetails.
        /// </summary>
        public ActivitySucceededEventDetails ActivitySucceededEventDetails
        {
            get { return this._activitySucceededEventDetails; }
            set { this._activitySucceededEventDetails = value; }
        }

        // Check to see if ActivitySucceededEventDetails property is set
        internal bool IsSetActivitySucceededEventDetails()
        {
            return this._activitySucceededEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ActivityTimedOutEventDetails.
        /// </summary>
        public ActivityTimedOutEventDetails ActivityTimedOutEventDetails
        {
            get { return this._activityTimedOutEventDetails; }
            set { this._activityTimedOutEventDetails = value; }
        }

        // Check to see if ActivityTimedOutEventDetails property is set
        internal bool IsSetActivityTimedOutEventDetails()
        {
            return this._activityTimedOutEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionAbortedEventDetails.
        /// </summary>
        public ExecutionAbortedEventDetails ExecutionAbortedEventDetails
        {
            get { return this._executionAbortedEventDetails; }
            set { this._executionAbortedEventDetails = value; }
        }

        // Check to see if ExecutionAbortedEventDetails property is set
        internal bool IsSetExecutionAbortedEventDetails()
        {
            return this._executionAbortedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionFailedEventDetails.
        /// </summary>
        public ExecutionFailedEventDetails ExecutionFailedEventDetails
        {
            get { return this._executionFailedEventDetails; }
            set { this._executionFailedEventDetails = value; }
        }

        // Check to see if ExecutionFailedEventDetails property is set
        internal bool IsSetExecutionFailedEventDetails()
        {
            return this._executionFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartedEventDetails.
        /// </summary>
        public ExecutionStartedEventDetails ExecutionStartedEventDetails
        {
            get { return this._executionStartedEventDetails; }
            set { this._executionStartedEventDetails = value; }
        }

        // Check to see if ExecutionStartedEventDetails property is set
        internal bool IsSetExecutionStartedEventDetails()
        {
            return this._executionStartedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionSucceededEventDetails.
        /// </summary>
        public ExecutionSucceededEventDetails ExecutionSucceededEventDetails
        {
            get { return this._executionSucceededEventDetails; }
            set { this._executionSucceededEventDetails = value; }
        }

        // Check to see if ExecutionSucceededEventDetails property is set
        internal bool IsSetExecutionSucceededEventDetails()
        {
            return this._executionSucceededEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimedOutEventDetails.
        /// </summary>
        public ExecutionTimedOutEventDetails ExecutionTimedOutEventDetails
        {
            get { return this._executionTimedOutEventDetails; }
            set { this._executionTimedOutEventDetails = value; }
        }

        // Check to see if ExecutionTimedOutEventDetails property is set
        internal bool IsSetExecutionTimedOutEventDetails()
        {
            return this._executionTimedOutEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the event. Events are numbered sequentially, starting at one.
        /// </para>
        /// </summary>
        public long Id
        {
            get { return this._id.GetValueOrDefault(); }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionFailedEventDetails.
        /// </summary>
        public LambdaFunctionFailedEventDetails LambdaFunctionFailedEventDetails
        {
            get { return this._lambdaFunctionFailedEventDetails; }
            set { this._lambdaFunctionFailedEventDetails = value; }
        }

        // Check to see if LambdaFunctionFailedEventDetails property is set
        internal bool IsSetLambdaFunctionFailedEventDetails()
        {
            return this._lambdaFunctionFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduledEventDetails.
        /// </summary>
        public LambdaFunctionScheduledEventDetails LambdaFunctionScheduledEventDetails
        {
            get { return this._lambdaFunctionScheduledEventDetails; }
            set { this._lambdaFunctionScheduledEventDetails = value; }
        }

        // Check to see if LambdaFunctionScheduledEventDetails property is set
        internal bool IsSetLambdaFunctionScheduledEventDetails()
        {
            return this._lambdaFunctionScheduledEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionScheduleFailedEventDetails.
        /// </summary>
        public LambdaFunctionScheduleFailedEventDetails LambdaFunctionScheduleFailedEventDetails
        {
            get { return this._lambdaFunctionScheduleFailedEventDetails; }
            set { this._lambdaFunctionScheduleFailedEventDetails = value; }
        }

        // Check to see if LambdaFunctionScheduleFailedEventDetails property is set
        internal bool IsSetLambdaFunctionScheduleFailedEventDetails()
        {
            return this._lambdaFunctionScheduleFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionStartFailedEventDetails.
        /// </summary>
        public LambdaFunctionStartFailedEventDetails LambdaFunctionStartFailedEventDetails
        {
            get { return this._lambdaFunctionStartFailedEventDetails; }
            set { this._lambdaFunctionStartFailedEventDetails = value; }
        }

        // Check to see if LambdaFunctionStartFailedEventDetails property is set
        internal bool IsSetLambdaFunctionStartFailedEventDetails()
        {
            return this._lambdaFunctionStartFailedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionSucceededEventDetails.
        /// </summary>
        public LambdaFunctionSucceededEventDetails LambdaFunctionSucceededEventDetails
        {
            get { return this._lambdaFunctionSucceededEventDetails; }
            set { this._lambdaFunctionSucceededEventDetails = value; }
        }

        // Check to see if LambdaFunctionSucceededEventDetails property is set
        internal bool IsSetLambdaFunctionSucceededEventDetails()
        {
            return this._lambdaFunctionSucceededEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionTimedOutEventDetails.
        /// </summary>
        public LambdaFunctionTimedOutEventDetails LambdaFunctionTimedOutEventDetails
        {
            get { return this._lambdaFunctionTimedOutEventDetails; }
            set { this._lambdaFunctionTimedOutEventDetails = value; }
        }

        // Check to see if LambdaFunctionTimedOutEventDetails property is set
        internal bool IsSetLambdaFunctionTimedOutEventDetails()
        {
            return this._lambdaFunctionTimedOutEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousEventId. 
        /// <para>
        /// The id of the previous event.
        /// </para>
        /// </summary>
        public long PreviousEventId
        {
            get { return this._previousEventId.GetValueOrDefault(); }
            set { this._previousEventId = value; }
        }

        // Check to see if PreviousEventId property is set
        internal bool IsSetPreviousEventId()
        {
            return this._previousEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateEnteredEventDetails.
        /// </summary>
        public StateEnteredEventDetails StateEnteredEventDetails
        {
            get { return this._stateEnteredEventDetails; }
            set { this._stateEnteredEventDetails = value; }
        }

        // Check to see if StateEnteredEventDetails property is set
        internal bool IsSetStateEnteredEventDetails()
        {
            return this._stateEnteredEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StateExitedEventDetails.
        /// </summary>
        public StateExitedEventDetails StateExitedEventDetails
        {
            get { return this._stateExitedEventDetails; }
            set { this._stateExitedEventDetails = value; }
        }

        // Check to see if StateExitedEventDetails property is set
        internal bool IsSetStateExitedEventDetails()
        {
            return this._stateExitedEventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date the event occured.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        public HistoryEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
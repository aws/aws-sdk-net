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

using Amazon.Runtime;

namespace Amazon.SimpleWorkflow
{

    /// <summary>
    /// Constants used for properties of type ActivityTaskTimeoutType.
    /// </summary>
    public class ActivityTaskTimeoutType : ConstantClass
    {

        /// <summary>
        /// Constant HEARTBEAT for ActivityTaskTimeoutType
        /// </summary>
        public static readonly ActivityTaskTimeoutType HEARTBEAT = new ActivityTaskTimeoutType("HEARTBEAT");
        /// <summary>
        /// Constant SCHEDULE_TO_CLOSE for ActivityTaskTimeoutType
        /// </summary>
        public static readonly ActivityTaskTimeoutType SCHEDULE_TO_CLOSE = new ActivityTaskTimeoutType("SCHEDULE_TO_CLOSE");
        /// <summary>
        /// Constant SCHEDULE_TO_START for ActivityTaskTimeoutType
        /// </summary>
        public static readonly ActivityTaskTimeoutType SCHEDULE_TO_START = new ActivityTaskTimeoutType("SCHEDULE_TO_START");
        /// <summary>
        /// Constant START_TO_CLOSE for ActivityTaskTimeoutType
        /// </summary>
        public static readonly ActivityTaskTimeoutType START_TO_CLOSE = new ActivityTaskTimeoutType("START_TO_CLOSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityTaskTimeoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityTaskTimeoutType FindValue(string value)
        {
            return FindValue<ActivityTaskTimeoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityTaskTimeoutType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancelTimerFailedCause.
    /// </summary>
    public class CancelTimerFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for CancelTimerFailedCause
        /// </summary>
        public static readonly CancelTimerFailedCause OPERATION_NOT_PERMITTED = new CancelTimerFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant TIMER_ID_UNKNOWN for CancelTimerFailedCause
        /// </summary>
        public static readonly CancelTimerFailedCause TIMER_ID_UNKNOWN = new CancelTimerFailedCause("TIMER_ID_UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancelTimerFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelTimerFailedCause FindValue(string value)
        {
            return FindValue<CancelTimerFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancelTimerFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CancelWorkflowExecutionFailedCause.
    /// </summary>
    public class CancelWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for CancelWorkflowExecutionFailedCause
        /// </summary>
        public static readonly CancelWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new CancelWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant UNHANDLED_DECISION for CancelWorkflowExecutionFailedCause
        /// </summary>
        public static readonly CancelWorkflowExecutionFailedCause UNHANDLED_DECISION = new CancelWorkflowExecutionFailedCause("UNHANDLED_DECISION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancelWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<CancelWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancelWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChildPolicy.
    /// </summary>
    public class ChildPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ABANDON for ChildPolicy
        /// </summary>
        public static readonly ChildPolicy ABANDON = new ChildPolicy("ABANDON");
        /// <summary>
        /// Constant REQUEST_CANCEL for ChildPolicy
        /// </summary>
        public static readonly ChildPolicy REQUEST_CANCEL = new ChildPolicy("REQUEST_CANCEL");
        /// <summary>
        /// Constant TERMINATE for ChildPolicy
        /// </summary>
        public static readonly ChildPolicy TERMINATE = new ChildPolicy("TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChildPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChildPolicy FindValue(string value)
        {
            return FindValue<ChildPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChildPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloseStatus.
    /// </summary>
    public class CloseStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for CloseStatus
        /// </summary>
        public static readonly CloseStatus CANCELED = new CloseStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for CloseStatus
        /// </summary>
        public static readonly CloseStatus COMPLETED = new CloseStatus("COMPLETED");
        /// <summary>
        /// Constant CONTINUED_AS_NEW for CloseStatus
        /// </summary>
        public static readonly CloseStatus CONTINUED_AS_NEW = new CloseStatus("CONTINUED_AS_NEW");
        /// <summary>
        /// Constant FAILED for CloseStatus
        /// </summary>
        public static readonly CloseStatus FAILED = new CloseStatus("FAILED");
        /// <summary>
        /// Constant TERMINATED for CloseStatus
        /// </summary>
        public static readonly CloseStatus TERMINATED = new CloseStatus("TERMINATED");
        /// <summary>
        /// Constant TIMED_OUT for CloseStatus
        /// </summary>
        public static readonly CloseStatus TIMED_OUT = new CloseStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloseStatus FindValue(string value)
        {
            return FindValue<CloseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompleteWorkflowExecutionFailedCause.
    /// </summary>
    public class CompleteWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for CompleteWorkflowExecutionFailedCause
        /// </summary>
        public static readonly CompleteWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new CompleteWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant UNHANDLED_DECISION for CompleteWorkflowExecutionFailedCause
        /// </summary>
        public static readonly CompleteWorkflowExecutionFailedCause UNHANDLED_DECISION = new CompleteWorkflowExecutionFailedCause("UNHANDLED_DECISION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompleteWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompleteWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<CompleteWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompleteWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContinueAsNewWorkflowExecutionFailedCause.
    /// </summary>
    public class ContinueAsNewWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUE_AS_NEW_WORKFLOW_EXECUTION_RATE_EXCEEDED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause CONTINUE_AS_NEW_WORKFLOW_EXECUTION_RATE_EXCEEDED = new ContinueAsNewWorkflowExecutionFailedCause("CONTINUE_AS_NEW_WORKFLOW_EXECUTION_RATE_EXCEEDED");
        /// <summary>
        /// Constant DEFAULT_CHILD_POLICY_UNDEFINED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause DEFAULT_CHILD_POLICY_UNDEFINED = new ContinueAsNewWorkflowExecutionFailedCause("DEFAULT_CHILD_POLICY_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED = new ContinueAsNewWorkflowExecutionFailedCause("DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_TASK_LIST_UNDEFINED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause DEFAULT_TASK_LIST_UNDEFINED = new ContinueAsNewWorkflowExecutionFailedCause("DEFAULT_TASK_LIST_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED = new ContinueAsNewWorkflowExecutionFailedCause("DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new ContinueAsNewWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant UNHANDLED_DECISION for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause UNHANDLED_DECISION = new ContinueAsNewWorkflowExecutionFailedCause("UNHANDLED_DECISION");
        /// <summary>
        /// Constant WORKFLOW_TYPE_DEPRECATED for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause WORKFLOW_TYPE_DEPRECATED = new ContinueAsNewWorkflowExecutionFailedCause("WORKFLOW_TYPE_DEPRECATED");
        /// <summary>
        /// Constant WORKFLOW_TYPE_DOES_NOT_EXIST for ContinueAsNewWorkflowExecutionFailedCause
        /// </summary>
        public static readonly ContinueAsNewWorkflowExecutionFailedCause WORKFLOW_TYPE_DOES_NOT_EXIST = new ContinueAsNewWorkflowExecutionFailedCause("WORKFLOW_TYPE_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContinueAsNewWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContinueAsNewWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<ContinueAsNewWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContinueAsNewWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DecisionTaskTimeoutType.
    /// </summary>
    public class DecisionTaskTimeoutType : ConstantClass
    {

        /// <summary>
        /// Constant START_TO_CLOSE for DecisionTaskTimeoutType
        /// </summary>
        public static readonly DecisionTaskTimeoutType START_TO_CLOSE = new DecisionTaskTimeoutType("START_TO_CLOSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DecisionTaskTimeoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DecisionTaskTimeoutType FindValue(string value)
        {
            return FindValue<DecisionTaskTimeoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DecisionTaskTimeoutType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DecisionType.
    /// </summary>
    public class DecisionType : ConstantClass
    {

        /// <summary>
        /// Constant CancelTimer for DecisionType
        /// </summary>
        public static readonly DecisionType CancelTimer = new DecisionType("CancelTimer");
        /// <summary>
        /// Constant CancelWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType CancelWorkflowExecution = new DecisionType("CancelWorkflowExecution");
        /// <summary>
        /// Constant CompleteWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType CompleteWorkflowExecution = new DecisionType("CompleteWorkflowExecution");
        /// <summary>
        /// Constant ContinueAsNewWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType ContinueAsNewWorkflowExecution = new DecisionType("ContinueAsNewWorkflowExecution");
        /// <summary>
        /// Constant FailWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType FailWorkflowExecution = new DecisionType("FailWorkflowExecution");
        /// <summary>
        /// Constant RecordMarker for DecisionType
        /// </summary>
        public static readonly DecisionType RecordMarker = new DecisionType("RecordMarker");
        /// <summary>
        /// Constant RequestCancelActivityTask for DecisionType
        /// </summary>
        public static readonly DecisionType RequestCancelActivityTask = new DecisionType("RequestCancelActivityTask");
        /// <summary>
        /// Constant RequestCancelExternalWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType RequestCancelExternalWorkflowExecution = new DecisionType("RequestCancelExternalWorkflowExecution");
        /// <summary>
        /// Constant ScheduleActivityTask for DecisionType
        /// </summary>
        public static readonly DecisionType ScheduleActivityTask = new DecisionType("ScheduleActivityTask");
        /// <summary>
        /// Constant ScheduleLambdaFunction for DecisionType
        /// </summary>
        public static readonly DecisionType ScheduleLambdaFunction = new DecisionType("ScheduleLambdaFunction");
        /// <summary>
        /// Constant SignalExternalWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType SignalExternalWorkflowExecution = new DecisionType("SignalExternalWorkflowExecution");
        /// <summary>
        /// Constant StartChildWorkflowExecution for DecisionType
        /// </summary>
        public static readonly DecisionType StartChildWorkflowExecution = new DecisionType("StartChildWorkflowExecution");
        /// <summary>
        /// Constant StartTimer for DecisionType
        /// </summary>
        public static readonly DecisionType StartTimer = new DecisionType("StartTimer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DecisionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DecisionType FindValue(string value)
        {
            return FindValue<DecisionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DecisionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant ActivityTaskCanceled for EventType
        /// </summary>
        public static readonly EventType ActivityTaskCanceled = new EventType("ActivityTaskCanceled");
        /// <summary>
        /// Constant ActivityTaskCancelRequested for EventType
        /// </summary>
        public static readonly EventType ActivityTaskCancelRequested = new EventType("ActivityTaskCancelRequested");
        /// <summary>
        /// Constant ActivityTaskCompleted for EventType
        /// </summary>
        public static readonly EventType ActivityTaskCompleted = new EventType("ActivityTaskCompleted");
        /// <summary>
        /// Constant ActivityTaskFailed for EventType
        /// </summary>
        public static readonly EventType ActivityTaskFailed = new EventType("ActivityTaskFailed");
        /// <summary>
        /// Constant ActivityTaskScheduled for EventType
        /// </summary>
        public static readonly EventType ActivityTaskScheduled = new EventType("ActivityTaskScheduled");
        /// <summary>
        /// Constant ActivityTaskStarted for EventType
        /// </summary>
        public static readonly EventType ActivityTaskStarted = new EventType("ActivityTaskStarted");
        /// <summary>
        /// Constant ActivityTaskTimedOut for EventType
        /// </summary>
        public static readonly EventType ActivityTaskTimedOut = new EventType("ActivityTaskTimedOut");
        /// <summary>
        /// Constant CancelTimerFailed for EventType
        /// </summary>
        public static readonly EventType CancelTimerFailed = new EventType("CancelTimerFailed");
        /// <summary>
        /// Constant CancelWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType CancelWorkflowExecutionFailed = new EventType("CancelWorkflowExecutionFailed");
        /// <summary>
        /// Constant ChildWorkflowExecutionCanceled for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionCanceled = new EventType("ChildWorkflowExecutionCanceled");
        /// <summary>
        /// Constant ChildWorkflowExecutionCompleted for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionCompleted = new EventType("ChildWorkflowExecutionCompleted");
        /// <summary>
        /// Constant ChildWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionFailed = new EventType("ChildWorkflowExecutionFailed");
        /// <summary>
        /// Constant ChildWorkflowExecutionStarted for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionStarted = new EventType("ChildWorkflowExecutionStarted");
        /// <summary>
        /// Constant ChildWorkflowExecutionTerminated for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionTerminated = new EventType("ChildWorkflowExecutionTerminated");
        /// <summary>
        /// Constant ChildWorkflowExecutionTimedOut for EventType
        /// </summary>
        public static readonly EventType ChildWorkflowExecutionTimedOut = new EventType("ChildWorkflowExecutionTimedOut");
        /// <summary>
        /// Constant CompleteWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType CompleteWorkflowExecutionFailed = new EventType("CompleteWorkflowExecutionFailed");
        /// <summary>
        /// Constant ContinueAsNewWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType ContinueAsNewWorkflowExecutionFailed = new EventType("ContinueAsNewWorkflowExecutionFailed");
        /// <summary>
        /// Constant DecisionTaskCompleted for EventType
        /// </summary>
        public static readonly EventType DecisionTaskCompleted = new EventType("DecisionTaskCompleted");
        /// <summary>
        /// Constant DecisionTaskScheduled for EventType
        /// </summary>
        public static readonly EventType DecisionTaskScheduled = new EventType("DecisionTaskScheduled");
        /// <summary>
        /// Constant DecisionTaskStarted for EventType
        /// </summary>
        public static readonly EventType DecisionTaskStarted = new EventType("DecisionTaskStarted");
        /// <summary>
        /// Constant DecisionTaskTimedOut for EventType
        /// </summary>
        public static readonly EventType DecisionTaskTimedOut = new EventType("DecisionTaskTimedOut");
        /// <summary>
        /// Constant ExternalWorkflowExecutionCancelRequested for EventType
        /// </summary>
        public static readonly EventType ExternalWorkflowExecutionCancelRequested = new EventType("ExternalWorkflowExecutionCancelRequested");
        /// <summary>
        /// Constant ExternalWorkflowExecutionSignaled for EventType
        /// </summary>
        public static readonly EventType ExternalWorkflowExecutionSignaled = new EventType("ExternalWorkflowExecutionSignaled");
        /// <summary>
        /// Constant FailWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType FailWorkflowExecutionFailed = new EventType("FailWorkflowExecutionFailed");
        /// <summary>
        /// Constant LambdaFunctionCompleted for EventType
        /// </summary>
        public static readonly EventType LambdaFunctionCompleted = new EventType("LambdaFunctionCompleted");
        /// <summary>
        /// Constant LambdaFunctionFailed for EventType
        /// </summary>
        public static readonly EventType LambdaFunctionFailed = new EventType("LambdaFunctionFailed");
        /// <summary>
        /// Constant LambdaFunctionScheduled for EventType
        /// </summary>
        public static readonly EventType LambdaFunctionScheduled = new EventType("LambdaFunctionScheduled");
        /// <summary>
        /// Constant LambdaFunctionStarted for EventType
        /// </summary>
        public static readonly EventType LambdaFunctionStarted = new EventType("LambdaFunctionStarted");
        /// <summary>
        /// Constant LambdaFunctionTimedOut for EventType
        /// </summary>
        public static readonly EventType LambdaFunctionTimedOut = new EventType("LambdaFunctionTimedOut");
        /// <summary>
        /// Constant MarkerRecorded for EventType
        /// </summary>
        public static readonly EventType MarkerRecorded = new EventType("MarkerRecorded");
        /// <summary>
        /// Constant RecordMarkerFailed for EventType
        /// </summary>
        public static readonly EventType RecordMarkerFailed = new EventType("RecordMarkerFailed");
        /// <summary>
        /// Constant RequestCancelActivityTaskFailed for EventType
        /// </summary>
        public static readonly EventType RequestCancelActivityTaskFailed = new EventType("RequestCancelActivityTaskFailed");
        /// <summary>
        /// Constant RequestCancelExternalWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType RequestCancelExternalWorkflowExecutionFailed = new EventType("RequestCancelExternalWorkflowExecutionFailed");
        /// <summary>
        /// Constant RequestCancelExternalWorkflowExecutionInitiated for EventType
        /// </summary>
        public static readonly EventType RequestCancelExternalWorkflowExecutionInitiated = new EventType("RequestCancelExternalWorkflowExecutionInitiated");
        /// <summary>
        /// Constant ScheduleActivityTaskFailed for EventType
        /// </summary>
        public static readonly EventType ScheduleActivityTaskFailed = new EventType("ScheduleActivityTaskFailed");
        /// <summary>
        /// Constant ScheduleLambdaFunctionFailed for EventType
        /// </summary>
        public static readonly EventType ScheduleLambdaFunctionFailed = new EventType("ScheduleLambdaFunctionFailed");
        /// <summary>
        /// Constant SignalExternalWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType SignalExternalWorkflowExecutionFailed = new EventType("SignalExternalWorkflowExecutionFailed");
        /// <summary>
        /// Constant SignalExternalWorkflowExecutionInitiated for EventType
        /// </summary>
        public static readonly EventType SignalExternalWorkflowExecutionInitiated = new EventType("SignalExternalWorkflowExecutionInitiated");
        /// <summary>
        /// Constant StartChildWorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType StartChildWorkflowExecutionFailed = new EventType("StartChildWorkflowExecutionFailed");
        /// <summary>
        /// Constant StartChildWorkflowExecutionInitiated for EventType
        /// </summary>
        public static readonly EventType StartChildWorkflowExecutionInitiated = new EventType("StartChildWorkflowExecutionInitiated");
        /// <summary>
        /// Constant StartLambdaFunctionFailed for EventType
        /// </summary>
        public static readonly EventType StartLambdaFunctionFailed = new EventType("StartLambdaFunctionFailed");
        /// <summary>
        /// Constant StartTimerFailed for EventType
        /// </summary>
        public static readonly EventType StartTimerFailed = new EventType("StartTimerFailed");
        /// <summary>
        /// Constant TimerCanceled for EventType
        /// </summary>
        public static readonly EventType TimerCanceled = new EventType("TimerCanceled");
        /// <summary>
        /// Constant TimerFired for EventType
        /// </summary>
        public static readonly EventType TimerFired = new EventType("TimerFired");
        /// <summary>
        /// Constant TimerStarted for EventType
        /// </summary>
        public static readonly EventType TimerStarted = new EventType("TimerStarted");
        /// <summary>
        /// Constant WorkflowExecutionCanceled for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionCanceled = new EventType("WorkflowExecutionCanceled");
        /// <summary>
        /// Constant WorkflowExecutionCancelRequested for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionCancelRequested = new EventType("WorkflowExecutionCancelRequested");
        /// <summary>
        /// Constant WorkflowExecutionCompleted for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionCompleted = new EventType("WorkflowExecutionCompleted");
        /// <summary>
        /// Constant WorkflowExecutionContinuedAsNew for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionContinuedAsNew = new EventType("WorkflowExecutionContinuedAsNew");
        /// <summary>
        /// Constant WorkflowExecutionFailed for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionFailed = new EventType("WorkflowExecutionFailed");
        /// <summary>
        /// Constant WorkflowExecutionSignaled for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionSignaled = new EventType("WorkflowExecutionSignaled");
        /// <summary>
        /// Constant WorkflowExecutionStarted for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionStarted = new EventType("WorkflowExecutionStarted");
        /// <summary>
        /// Constant WorkflowExecutionTerminated for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionTerminated = new EventType("WorkflowExecutionTerminated");
        /// <summary>
        /// Constant WorkflowExecutionTimedOut for EventType
        /// </summary>
        public static readonly EventType WorkflowExecutionTimedOut = new EventType("WorkflowExecutionTimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus CLOSED = new ExecutionStatus("CLOSED");
        /// <summary>
        /// Constant OPEN for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus OPEN = new ExecutionStatus("OPEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailWorkflowExecutionFailedCause.
    /// </summary>
    public class FailWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for FailWorkflowExecutionFailedCause
        /// </summary>
        public static readonly FailWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new FailWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant UNHANDLED_DECISION for FailWorkflowExecutionFailedCause
        /// </summary>
        public static readonly FailWorkflowExecutionFailedCause UNHANDLED_DECISION = new FailWorkflowExecutionFailedCause("UNHANDLED_DECISION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<FailWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaFunctionTimeoutType.
    /// </summary>
    public class LambdaFunctionTimeoutType : ConstantClass
    {

        /// <summary>
        /// Constant START_TO_CLOSE for LambdaFunctionTimeoutType
        /// </summary>
        public static readonly LambdaFunctionTimeoutType START_TO_CLOSE = new LambdaFunctionTimeoutType("START_TO_CLOSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionTimeoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionTimeoutType FindValue(string value)
        {
            return FindValue<LambdaFunctionTimeoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionTimeoutType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordMarkerFailedCause.
    /// </summary>
    public class RecordMarkerFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for RecordMarkerFailedCause
        /// </summary>
        public static readonly RecordMarkerFailedCause OPERATION_NOT_PERMITTED = new RecordMarkerFailedCause("OPERATION_NOT_PERMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordMarkerFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordMarkerFailedCause FindValue(string value)
        {
            return FindValue<RecordMarkerFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordMarkerFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPRECATED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus DEPRECATED = new RegistrationStatus("DEPRECATED");
        /// <summary>
        /// Constant REGISTERED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REGISTERED = new RegistrationStatus("REGISTERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestCancelActivityTaskFailedCause.
    /// </summary>
    public class RequestCancelActivityTaskFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVITY_ID_UNKNOWN for RequestCancelActivityTaskFailedCause
        /// </summary>
        public static readonly RequestCancelActivityTaskFailedCause ACTIVITY_ID_UNKNOWN = new RequestCancelActivityTaskFailedCause("ACTIVITY_ID_UNKNOWN");
        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for RequestCancelActivityTaskFailedCause
        /// </summary>
        public static readonly RequestCancelActivityTaskFailedCause OPERATION_NOT_PERMITTED = new RequestCancelActivityTaskFailedCause("OPERATION_NOT_PERMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestCancelActivityTaskFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestCancelActivityTaskFailedCause FindValue(string value)
        {
            return FindValue<RequestCancelActivityTaskFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestCancelActivityTaskFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestCancelExternalWorkflowExecutionFailedCause.
    /// </summary>
    public class RequestCancelExternalWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for RequestCancelExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly RequestCancelExternalWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new RequestCancelExternalWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant REQUEST_CANCEL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED for RequestCancelExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly RequestCancelExternalWorkflowExecutionFailedCause REQUEST_CANCEL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED = new RequestCancelExternalWorkflowExecutionFailedCause("REQUEST_CANCEL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED");
        /// <summary>
        /// Constant UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION for RequestCancelExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly RequestCancelExternalWorkflowExecutionFailedCause UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION = new RequestCancelExternalWorkflowExecutionFailedCause("UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestCancelExternalWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestCancelExternalWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<RequestCancelExternalWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestCancelExternalWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleActivityTaskFailedCause.
    /// </summary>
    public class ScheduleActivityTaskFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVITY_CREATION_RATE_EXCEEDED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause ACTIVITY_CREATION_RATE_EXCEEDED = new ScheduleActivityTaskFailedCause("ACTIVITY_CREATION_RATE_EXCEEDED");
        /// <summary>
        /// Constant ACTIVITY_ID_ALREADY_IN_USE for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause ACTIVITY_ID_ALREADY_IN_USE = new ScheduleActivityTaskFailedCause("ACTIVITY_ID_ALREADY_IN_USE");
        /// <summary>
        /// Constant ACTIVITY_TYPE_DEPRECATED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause ACTIVITY_TYPE_DEPRECATED = new ScheduleActivityTaskFailedCause("ACTIVITY_TYPE_DEPRECATED");
        /// <summary>
        /// Constant ACTIVITY_TYPE_DOES_NOT_EXIST for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause ACTIVITY_TYPE_DOES_NOT_EXIST = new ScheduleActivityTaskFailedCause("ACTIVITY_TYPE_DOES_NOT_EXIST");
        /// <summary>
        /// Constant DEFAULT_HEARTBEAT_TIMEOUT_UNDEFINED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause DEFAULT_HEARTBEAT_TIMEOUT_UNDEFINED = new ScheduleActivityTaskFailedCause("DEFAULT_HEARTBEAT_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_SCHEDULE_TO_CLOSE_TIMEOUT_UNDEFINED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause DEFAULT_SCHEDULE_TO_CLOSE_TIMEOUT_UNDEFINED = new ScheduleActivityTaskFailedCause("DEFAULT_SCHEDULE_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_SCHEDULE_TO_START_TIMEOUT_UNDEFINED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause DEFAULT_SCHEDULE_TO_START_TIMEOUT_UNDEFINED = new ScheduleActivityTaskFailedCause("DEFAULT_SCHEDULE_TO_START_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_START_TO_CLOSE_TIMEOUT_UNDEFINED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause DEFAULT_START_TO_CLOSE_TIMEOUT_UNDEFINED = new ScheduleActivityTaskFailedCause("DEFAULT_START_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_TASK_LIST_UNDEFINED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause DEFAULT_TASK_LIST_UNDEFINED = new ScheduleActivityTaskFailedCause("DEFAULT_TASK_LIST_UNDEFINED");
        /// <summary>
        /// Constant OPEN_ACTIVITIES_LIMIT_EXCEEDED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause OPEN_ACTIVITIES_LIMIT_EXCEEDED = new ScheduleActivityTaskFailedCause("OPEN_ACTIVITIES_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for ScheduleActivityTaskFailedCause
        /// </summary>
        public static readonly ScheduleActivityTaskFailedCause OPERATION_NOT_PERMITTED = new ScheduleActivityTaskFailedCause("OPERATION_NOT_PERMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleActivityTaskFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleActivityTaskFailedCause FindValue(string value)
        {
            return FindValue<ScheduleActivityTaskFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleActivityTaskFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleLambdaFunctionFailedCause.
    /// </summary>
    public class ScheduleLambdaFunctionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant ID_ALREADY_IN_USE for ScheduleLambdaFunctionFailedCause
        /// </summary>
        public static readonly ScheduleLambdaFunctionFailedCause ID_ALREADY_IN_USE = new ScheduleLambdaFunctionFailedCause("ID_ALREADY_IN_USE");
        /// <summary>
        /// Constant LAMBDA_FUNCTION_CREATION_RATE_EXCEEDED for ScheduleLambdaFunctionFailedCause
        /// </summary>
        public static readonly ScheduleLambdaFunctionFailedCause LAMBDA_FUNCTION_CREATION_RATE_EXCEEDED = new ScheduleLambdaFunctionFailedCause("LAMBDA_FUNCTION_CREATION_RATE_EXCEEDED");
        /// <summary>
        /// Constant LAMBDA_SERVICE_NOT_AVAILABLE_IN_REGION for ScheduleLambdaFunctionFailedCause
        /// </summary>
        public static readonly ScheduleLambdaFunctionFailedCause LAMBDA_SERVICE_NOT_AVAILABLE_IN_REGION = new ScheduleLambdaFunctionFailedCause("LAMBDA_SERVICE_NOT_AVAILABLE_IN_REGION");
        /// <summary>
        /// Constant OPEN_LAMBDA_FUNCTIONS_LIMIT_EXCEEDED for ScheduleLambdaFunctionFailedCause
        /// </summary>
        public static readonly ScheduleLambdaFunctionFailedCause OPEN_LAMBDA_FUNCTIONS_LIMIT_EXCEEDED = new ScheduleLambdaFunctionFailedCause("OPEN_LAMBDA_FUNCTIONS_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleLambdaFunctionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleLambdaFunctionFailedCause FindValue(string value)
        {
            return FindValue<ScheduleLambdaFunctionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleLambdaFunctionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalExternalWorkflowExecutionFailedCause.
    /// </summary>
    public class SignalExternalWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for SignalExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly SignalExternalWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new SignalExternalWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant SIGNAL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED for SignalExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly SignalExternalWorkflowExecutionFailedCause SIGNAL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED = new SignalExternalWorkflowExecutionFailedCause("SIGNAL_EXTERNAL_WORKFLOW_EXECUTION_RATE_EXCEEDED");
        /// <summary>
        /// Constant UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION for SignalExternalWorkflowExecutionFailedCause
        /// </summary>
        public static readonly SignalExternalWorkflowExecutionFailedCause UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION = new SignalExternalWorkflowExecutionFailedCause("UNKNOWN_EXTERNAL_WORKFLOW_EXECUTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalExternalWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalExternalWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<SignalExternalWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalExternalWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartChildWorkflowExecutionFailedCause.
    /// </summary>
    public class StartChildWorkflowExecutionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant CHILD_CREATION_RATE_EXCEEDED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause CHILD_CREATION_RATE_EXCEEDED = new StartChildWorkflowExecutionFailedCause("CHILD_CREATION_RATE_EXCEEDED");
        /// <summary>
        /// Constant DEFAULT_CHILD_POLICY_UNDEFINED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause DEFAULT_CHILD_POLICY_UNDEFINED = new StartChildWorkflowExecutionFailedCause("DEFAULT_CHILD_POLICY_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED = new StartChildWorkflowExecutionFailedCause("DEFAULT_EXECUTION_START_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_TASK_LIST_UNDEFINED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause DEFAULT_TASK_LIST_UNDEFINED = new StartChildWorkflowExecutionFailedCause("DEFAULT_TASK_LIST_UNDEFINED");
        /// <summary>
        /// Constant DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED = new StartChildWorkflowExecutionFailedCause("DEFAULT_TASK_START_TO_CLOSE_TIMEOUT_UNDEFINED");
        /// <summary>
        /// Constant OPEN_CHILDREN_LIMIT_EXCEEDED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause OPEN_CHILDREN_LIMIT_EXCEEDED = new StartChildWorkflowExecutionFailedCause("OPEN_CHILDREN_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OPEN_WORKFLOWS_LIMIT_EXCEEDED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause OPEN_WORKFLOWS_LIMIT_EXCEEDED = new StartChildWorkflowExecutionFailedCause("OPEN_WORKFLOWS_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause OPERATION_NOT_PERMITTED = new StartChildWorkflowExecutionFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant WORKFLOW_ALREADY_RUNNING for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause WORKFLOW_ALREADY_RUNNING = new StartChildWorkflowExecutionFailedCause("WORKFLOW_ALREADY_RUNNING");
        /// <summary>
        /// Constant WORKFLOW_TYPE_DEPRECATED for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause WORKFLOW_TYPE_DEPRECATED = new StartChildWorkflowExecutionFailedCause("WORKFLOW_TYPE_DEPRECATED");
        /// <summary>
        /// Constant WORKFLOW_TYPE_DOES_NOT_EXIST for StartChildWorkflowExecutionFailedCause
        /// </summary>
        public static readonly StartChildWorkflowExecutionFailedCause WORKFLOW_TYPE_DOES_NOT_EXIST = new StartChildWorkflowExecutionFailedCause("WORKFLOW_TYPE_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartChildWorkflowExecutionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartChildWorkflowExecutionFailedCause FindValue(string value)
        {
            return FindValue<StartChildWorkflowExecutionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartChildWorkflowExecutionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartLambdaFunctionFailedCause.
    /// </summary>
    public class StartLambdaFunctionFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant ASSUME_ROLE_FAILED for StartLambdaFunctionFailedCause
        /// </summary>
        public static readonly StartLambdaFunctionFailedCause ASSUME_ROLE_FAILED = new StartLambdaFunctionFailedCause("ASSUME_ROLE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartLambdaFunctionFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartLambdaFunctionFailedCause FindValue(string value)
        {
            return FindValue<StartLambdaFunctionFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartLambdaFunctionFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartTimerFailedCause.
    /// </summary>
    public class StartTimerFailedCause : ConstantClass
    {

        /// <summary>
        /// Constant OPEN_TIMERS_LIMIT_EXCEEDED for StartTimerFailedCause
        /// </summary>
        public static readonly StartTimerFailedCause OPEN_TIMERS_LIMIT_EXCEEDED = new StartTimerFailedCause("OPEN_TIMERS_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OPERATION_NOT_PERMITTED for StartTimerFailedCause
        /// </summary>
        public static readonly StartTimerFailedCause OPERATION_NOT_PERMITTED = new StartTimerFailedCause("OPERATION_NOT_PERMITTED");
        /// <summary>
        /// Constant TIMER_CREATION_RATE_EXCEEDED for StartTimerFailedCause
        /// </summary>
        public static readonly StartTimerFailedCause TIMER_CREATION_RATE_EXCEEDED = new StartTimerFailedCause("TIMER_CREATION_RATE_EXCEEDED");
        /// <summary>
        /// Constant TIMER_ID_ALREADY_IN_USE for StartTimerFailedCause
        /// </summary>
        public static readonly StartTimerFailedCause TIMER_ID_ALREADY_IN_USE = new StartTimerFailedCause("TIMER_ID_ALREADY_IN_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartTimerFailedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartTimerFailedCause FindValue(string value)
        {
            return FindValue<StartTimerFailedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartTimerFailedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowExecutionCancelRequestedCause.
    /// </summary>
    public class WorkflowExecutionCancelRequestedCause : ConstantClass
    {

        /// <summary>
        /// Constant CHILD_POLICY_APPLIED for WorkflowExecutionCancelRequestedCause
        /// </summary>
        public static readonly WorkflowExecutionCancelRequestedCause CHILD_POLICY_APPLIED = new WorkflowExecutionCancelRequestedCause("CHILD_POLICY_APPLIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowExecutionCancelRequestedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowExecutionCancelRequestedCause FindValue(string value)
        {
            return FindValue<WorkflowExecutionCancelRequestedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowExecutionCancelRequestedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowExecutionTerminatedCause.
    /// </summary>
    public class WorkflowExecutionTerminatedCause : ConstantClass
    {

        /// <summary>
        /// Constant CHILD_POLICY_APPLIED for WorkflowExecutionTerminatedCause
        /// </summary>
        public static readonly WorkflowExecutionTerminatedCause CHILD_POLICY_APPLIED = new WorkflowExecutionTerminatedCause("CHILD_POLICY_APPLIED");
        /// <summary>
        /// Constant EVENT_LIMIT_EXCEEDED for WorkflowExecutionTerminatedCause
        /// </summary>
        public static readonly WorkflowExecutionTerminatedCause EVENT_LIMIT_EXCEEDED = new WorkflowExecutionTerminatedCause("EVENT_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OPERATOR_INITIATED for WorkflowExecutionTerminatedCause
        /// </summary>
        public static readonly WorkflowExecutionTerminatedCause OPERATOR_INITIATED = new WorkflowExecutionTerminatedCause("OPERATOR_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowExecutionTerminatedCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowExecutionTerminatedCause FindValue(string value)
        {
            return FindValue<WorkflowExecutionTerminatedCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowExecutionTerminatedCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowExecutionTimeoutType.
    /// </summary>
    public class WorkflowExecutionTimeoutType : ConstantClass
    {

        /// <summary>
        /// Constant START_TO_CLOSE for WorkflowExecutionTimeoutType
        /// </summary>
        public static readonly WorkflowExecutionTimeoutType START_TO_CLOSE = new WorkflowExecutionTimeoutType("START_TO_CLOSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowExecutionTimeoutType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowExecutionTimeoutType FindValue(string value)
        {
            return FindValue<WorkflowExecutionTimeoutType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowExecutionTimeoutType(string value)
        {
            return FindValue(value);
        }
    }

}
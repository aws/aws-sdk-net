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

using Amazon.Runtime;

namespace Amazon.StepFunctions
{

    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus ABORTED = new ExecutionStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus RUNNING = new ExecutionStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus SUCCEEDED = new ExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus TIMED_OUT = new ExecutionStatus("TIMED_OUT");

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
    /// Constants used for properties of type HistoryEventType.
    /// </summary>
    public class HistoryEventType : ConstantClass
    {

        /// <summary>
        /// Constant ActivityFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivityFailed = new HistoryEventType("ActivityFailed");
        /// <summary>
        /// Constant ActivityScheduled for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivityScheduled = new HistoryEventType("ActivityScheduled");
        /// <summary>
        /// Constant ActivityScheduleFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivityScheduleFailed = new HistoryEventType("ActivityScheduleFailed");
        /// <summary>
        /// Constant ActivityStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivityStarted = new HistoryEventType("ActivityStarted");
        /// <summary>
        /// Constant ActivitySucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivitySucceeded = new HistoryEventType("ActivitySucceeded");
        /// <summary>
        /// Constant ActivityTimedOut for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ActivityTimedOut = new HistoryEventType("ActivityTimedOut");
        /// <summary>
        /// Constant ChoiceStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ChoiceStateEntered = new HistoryEventType("ChoiceStateEntered");
        /// <summary>
        /// Constant ChoiceStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ChoiceStateExited = new HistoryEventType("ChoiceStateExited");
        /// <summary>
        /// Constant ExecutionAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionAborted = new HistoryEventType("ExecutionAborted");
        /// <summary>
        /// Constant ExecutionFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionFailed = new HistoryEventType("ExecutionFailed");
        /// <summary>
        /// Constant ExecutionStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionStarted = new HistoryEventType("ExecutionStarted");
        /// <summary>
        /// Constant ExecutionSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionSucceeded = new HistoryEventType("ExecutionSucceeded");
        /// <summary>
        /// Constant ExecutionTimedOut for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionTimedOut = new HistoryEventType("ExecutionTimedOut");
        /// <summary>
        /// Constant FailStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType FailStateEntered = new HistoryEventType("FailStateEntered");
        /// <summary>
        /// Constant LambdaFunctionFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionFailed = new HistoryEventType("LambdaFunctionFailed");
        /// <summary>
        /// Constant LambdaFunctionScheduled for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionScheduled = new HistoryEventType("LambdaFunctionScheduled");
        /// <summary>
        /// Constant LambdaFunctionScheduleFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionScheduleFailed = new HistoryEventType("LambdaFunctionScheduleFailed");
        /// <summary>
        /// Constant LambdaFunctionStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionStarted = new HistoryEventType("LambdaFunctionStarted");
        /// <summary>
        /// Constant LambdaFunctionStartFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionStartFailed = new HistoryEventType("LambdaFunctionStartFailed");
        /// <summary>
        /// Constant LambdaFunctionSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionSucceeded = new HistoryEventType("LambdaFunctionSucceeded");
        /// <summary>
        /// Constant LambdaFunctionTimedOut for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType LambdaFunctionTimedOut = new HistoryEventType("LambdaFunctionTimedOut");
        /// <summary>
        /// Constant ParallelStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateEntered = new HistoryEventType("ParallelStateEntered");
        /// <summary>
        /// Constant ParallelStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateExited = new HistoryEventType("ParallelStateExited");
        /// <summary>
        /// Constant PassStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType PassStateEntered = new HistoryEventType("PassStateEntered");
        /// <summary>
        /// Constant PassStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType PassStateExited = new HistoryEventType("PassStateExited");
        /// <summary>
        /// Constant SucceedStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType SucceedStateEntered = new HistoryEventType("SucceedStateEntered");
        /// <summary>
        /// Constant SucceedStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType SucceedStateExited = new HistoryEventType("SucceedStateExited");
        /// <summary>
        /// Constant TaskStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStateEntered = new HistoryEventType("TaskStateEntered");
        /// <summary>
        /// Constant TaskStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStateExited = new HistoryEventType("TaskStateExited");
        /// <summary>
        /// Constant WaitStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType WaitStateEntered = new HistoryEventType("WaitStateEntered");
        /// <summary>
        /// Constant WaitStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType WaitStateExited = new HistoryEventType("WaitStateExited");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistoryEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoryEventType FindValue(string value)
        {
            return FindValue<HistoryEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistoryEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StateMachineStatus.
    /// </summary>
    public class StateMachineStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StateMachineStatus
        /// </summary>
        public static readonly StateMachineStatus ACTIVE = new StateMachineStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for StateMachineStatus
        /// </summary>
        public static readonly StateMachineStatus DELETING = new StateMachineStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateMachineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateMachineStatus FindValue(string value)
        {
            return FindValue<StateMachineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateMachineStatus(string value)
        {
            return FindValue(value);
        }
    }

}
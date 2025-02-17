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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.StepFunctions
{

    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_OWNED_KEY = new EncryptionType("AWS_OWNED_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_MANAGED_KMS_KEY = new EncryptionType("CUSTOMER_MANAGED_KMS_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionRedriveFilter.
    /// </summary>
    public class ExecutionRedriveFilter : ConstantClass
    {

        /// <summary>
        /// Constant NOT_REDRIVEN for ExecutionRedriveFilter
        /// </summary>
        public static readonly ExecutionRedriveFilter NOT_REDRIVEN = new ExecutionRedriveFilter("NOT_REDRIVEN");
        /// <summary>
        /// Constant REDRIVEN for ExecutionRedriveFilter
        /// </summary>
        public static readonly ExecutionRedriveFilter REDRIVEN = new ExecutionRedriveFilter("REDRIVEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionRedriveFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionRedriveFilter FindValue(string value)
        {
            return FindValue<ExecutionRedriveFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionRedriveFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionRedriveStatus.
    /// </summary>
    public class ExecutionRedriveStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_REDRIVABLE for ExecutionRedriveStatus
        /// </summary>
        public static readonly ExecutionRedriveStatus NOT_REDRIVABLE = new ExecutionRedriveStatus("NOT_REDRIVABLE");
        /// <summary>
        /// Constant REDRIVABLE for ExecutionRedriveStatus
        /// </summary>
        public static readonly ExecutionRedriveStatus REDRIVABLE = new ExecutionRedriveStatus("REDRIVABLE");
        /// <summary>
        /// Constant REDRIVABLE_BY_MAP_RUN for ExecutionRedriveStatus
        /// </summary>
        public static readonly ExecutionRedriveStatus REDRIVABLE_BY_MAP_RUN = new ExecutionRedriveStatus("REDRIVABLE_BY_MAP_RUN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionRedriveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionRedriveStatus FindValue(string value)
        {
            return FindValue<ExecutionRedriveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionRedriveStatus(string value)
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
        /// Constant ABORTED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus ABORTED = new ExecutionStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant PENDING_REDRIVE for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus PENDING_REDRIVE = new ExecutionStatus("PENDING_REDRIVE");
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
        /// Constant EvaluationFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType EvaluationFailed = new HistoryEventType("EvaluationFailed");
        /// <summary>
        /// Constant ExecutionAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionAborted = new HistoryEventType("ExecutionAborted");
        /// <summary>
        /// Constant ExecutionFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionFailed = new HistoryEventType("ExecutionFailed");
        /// <summary>
        /// Constant ExecutionRedriven for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ExecutionRedriven = new HistoryEventType("ExecutionRedriven");
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
        /// Constant MapIterationAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapIterationAborted = new HistoryEventType("MapIterationAborted");
        /// <summary>
        /// Constant MapIterationFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapIterationFailed = new HistoryEventType("MapIterationFailed");
        /// <summary>
        /// Constant MapIterationStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapIterationStarted = new HistoryEventType("MapIterationStarted");
        /// <summary>
        /// Constant MapIterationSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapIterationSucceeded = new HistoryEventType("MapIterationSucceeded");
        /// <summary>
        /// Constant MapRunAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapRunAborted = new HistoryEventType("MapRunAborted");
        /// <summary>
        /// Constant MapRunFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapRunFailed = new HistoryEventType("MapRunFailed");
        /// <summary>
        /// Constant MapRunRedriven for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapRunRedriven = new HistoryEventType("MapRunRedriven");
        /// <summary>
        /// Constant MapRunStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapRunStarted = new HistoryEventType("MapRunStarted");
        /// <summary>
        /// Constant MapRunSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapRunSucceeded = new HistoryEventType("MapRunSucceeded");
        /// <summary>
        /// Constant MapStateAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateAborted = new HistoryEventType("MapStateAborted");
        /// <summary>
        /// Constant MapStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateEntered = new HistoryEventType("MapStateEntered");
        /// <summary>
        /// Constant MapStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateExited = new HistoryEventType("MapStateExited");
        /// <summary>
        /// Constant MapStateFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateFailed = new HistoryEventType("MapStateFailed");
        /// <summary>
        /// Constant MapStateStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateStarted = new HistoryEventType("MapStateStarted");
        /// <summary>
        /// Constant MapStateSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType MapStateSucceeded = new HistoryEventType("MapStateSucceeded");
        /// <summary>
        /// Constant ParallelStateAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateAborted = new HistoryEventType("ParallelStateAborted");
        /// <summary>
        /// Constant ParallelStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateEntered = new HistoryEventType("ParallelStateEntered");
        /// <summary>
        /// Constant ParallelStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateExited = new HistoryEventType("ParallelStateExited");
        /// <summary>
        /// Constant ParallelStateFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateFailed = new HistoryEventType("ParallelStateFailed");
        /// <summary>
        /// Constant ParallelStateStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateStarted = new HistoryEventType("ParallelStateStarted");
        /// <summary>
        /// Constant ParallelStateSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType ParallelStateSucceeded = new HistoryEventType("ParallelStateSucceeded");
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
        /// Constant TaskFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskFailed = new HistoryEventType("TaskFailed");
        /// <summary>
        /// Constant TaskScheduled for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskScheduled = new HistoryEventType("TaskScheduled");
        /// <summary>
        /// Constant TaskStarted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStarted = new HistoryEventType("TaskStarted");
        /// <summary>
        /// Constant TaskStartFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStartFailed = new HistoryEventType("TaskStartFailed");
        /// <summary>
        /// Constant TaskStateAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStateAborted = new HistoryEventType("TaskStateAborted");
        /// <summary>
        /// Constant TaskStateEntered for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStateEntered = new HistoryEventType("TaskStateEntered");
        /// <summary>
        /// Constant TaskStateExited for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskStateExited = new HistoryEventType("TaskStateExited");
        /// <summary>
        /// Constant TaskSubmitFailed for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskSubmitFailed = new HistoryEventType("TaskSubmitFailed");
        /// <summary>
        /// Constant TaskSubmitted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskSubmitted = new HistoryEventType("TaskSubmitted");
        /// <summary>
        /// Constant TaskSucceeded for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskSucceeded = new HistoryEventType("TaskSucceeded");
        /// <summary>
        /// Constant TaskTimedOut for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType TaskTimedOut = new HistoryEventType("TaskTimedOut");
        /// <summary>
        /// Constant WaitStateAborted for HistoryEventType
        /// </summary>
        public static readonly HistoryEventType WaitStateAborted = new HistoryEventType("WaitStateAborted");
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
    /// Constants used for properties of type IncludedData.
    /// </summary>
    public class IncludedData : ConstantClass
    {

        /// <summary>
        /// Constant ALL_DATA for IncludedData
        /// </summary>
        public static readonly IncludedData ALL_DATA = new IncludedData("ALL_DATA");
        /// <summary>
        /// Constant METADATA_ONLY for IncludedData
        /// </summary>
        public static readonly IncludedData METADATA_ONLY = new IncludedData("METADATA_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncludedData(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncludedData FindValue(string value)
        {
            return FindValue<IncludedData>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncludedData(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InspectionLevel.
    /// </summary>
    public class InspectionLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for InspectionLevel
        /// </summary>
        public static readonly InspectionLevel DEBUG = new InspectionLevel("DEBUG");
        /// <summary>
        /// Constant INFO for InspectionLevel
        /// </summary>
        public static readonly InspectionLevel INFO = new InspectionLevel("INFO");
        /// <summary>
        /// Constant TRACE for InspectionLevel
        /// </summary>
        public static readonly InspectionLevel TRACE = new InspectionLevel("TRACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InspectionLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InspectionLevel FindValue(string value)
        {
            return FindValue<InspectionLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InspectionLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KmsKeyState.
    /// </summary>
    public class KmsKeyState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for KmsKeyState
        /// </summary>
        public static readonly KmsKeyState CREATING = new KmsKeyState("CREATING");
        /// <summary>
        /// Constant DISABLED for KmsKeyState
        /// </summary>
        public static readonly KmsKeyState DISABLED = new KmsKeyState("DISABLED");
        /// <summary>
        /// Constant PENDING_DELETION for KmsKeyState
        /// </summary>
        public static readonly KmsKeyState PENDING_DELETION = new KmsKeyState("PENDING_DELETION");
        /// <summary>
        /// Constant PENDING_IMPORT for KmsKeyState
        /// </summary>
        public static readonly KmsKeyState PENDING_IMPORT = new KmsKeyState("PENDING_IMPORT");
        /// <summary>
        /// Constant UNAVAILABLE for KmsKeyState
        /// </summary>
        public static readonly KmsKeyState UNAVAILABLE = new KmsKeyState("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KmsKeyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KmsKeyState FindValue(string value)
        {
            return FindValue<KmsKeyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KmsKeyState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for LogLevel
        /// </summary>
        public static readonly LogLevel ALL = new LogLevel("ALL");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant FATAL for LogLevel
        /// </summary>
        public static readonly LogLevel FATAL = new LogLevel("FATAL");
        /// <summary>
        /// Constant OFF for LogLevel
        /// </summary>
        public static readonly LogLevel OFF = new LogLevel("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapRunStatus.
    /// </summary>
    public class MapRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for MapRunStatus
        /// </summary>
        public static readonly MapRunStatus ABORTED = new MapRunStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for MapRunStatus
        /// </summary>
        public static readonly MapRunStatus FAILED = new MapRunStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for MapRunStatus
        /// </summary>
        public static readonly MapRunStatus RUNNING = new MapRunStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for MapRunStatus
        /// </summary>
        public static readonly MapRunStatus SUCCEEDED = new MapRunStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapRunStatus FindValue(string value)
        {
            return FindValue<MapRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapRunStatus(string value)
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


    /// <summary>
    /// Constants used for properties of type StateMachineType.
    /// </summary>
    public class StateMachineType : ConstantClass
    {

        /// <summary>
        /// Constant EXPRESS for StateMachineType
        /// </summary>
        public static readonly StateMachineType EXPRESS = new StateMachineType("EXPRESS");
        /// <summary>
        /// Constant STANDARD for StateMachineType
        /// </summary>
        public static readonly StateMachineType STANDARD = new StateMachineType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateMachineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateMachineType FindValue(string value)
        {
            return FindValue<StateMachineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateMachineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyncExecutionStatus.
    /// </summary>
    public class SyncExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for SyncExecutionStatus
        /// </summary>
        public static readonly SyncExecutionStatus FAILED = new SyncExecutionStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for SyncExecutionStatus
        /// </summary>
        public static readonly SyncExecutionStatus SUCCEEDED = new SyncExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for SyncExecutionStatus
        /// </summary>
        public static readonly SyncExecutionStatus TIMED_OUT = new SyncExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncExecutionStatus FindValue(string value)
        {
            return FindValue<SyncExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestExecutionStatus.
    /// </summary>
    public class TestExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CAUGHT_ERROR for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus CAUGHT_ERROR = new TestExecutionStatus("CAUGHT_ERROR");
        /// <summary>
        /// Constant FAILED for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus FAILED = new TestExecutionStatus("FAILED");
        /// <summary>
        /// Constant RETRIABLE for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus RETRIABLE = new TestExecutionStatus("RETRIABLE");
        /// <summary>
        /// Constant SUCCEEDED for TestExecutionStatus
        /// </summary>
        public static readonly TestExecutionStatus SUCCEEDED = new TestExecutionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestExecutionStatus FindValue(string value)
        {
            return FindValue<TestExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidateStateMachineDefinitionResultCode.
    /// </summary>
    public class ValidateStateMachineDefinitionResultCode : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for ValidateStateMachineDefinitionResultCode
        /// </summary>
        public static readonly ValidateStateMachineDefinitionResultCode FAIL = new ValidateStateMachineDefinitionResultCode("FAIL");
        /// <summary>
        /// Constant OK for ValidateStateMachineDefinitionResultCode
        /// </summary>
        public static readonly ValidateStateMachineDefinitionResultCode OK = new ValidateStateMachineDefinitionResultCode("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidateStateMachineDefinitionResultCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidateStateMachineDefinitionResultCode FindValue(string value)
        {
            return FindValue<ValidateStateMachineDefinitionResultCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidateStateMachineDefinitionResultCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidateStateMachineDefinitionSeverity.
    /// </summary>
    public class ValidateStateMachineDefinitionSeverity : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for ValidateStateMachineDefinitionSeverity
        /// </summary>
        public static readonly ValidateStateMachineDefinitionSeverity ERROR = new ValidateStateMachineDefinitionSeverity("ERROR");
        /// <summary>
        /// Constant WARNING for ValidateStateMachineDefinitionSeverity
        /// </summary>
        public static readonly ValidateStateMachineDefinitionSeverity WARNING = new ValidateStateMachineDefinitionSeverity("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidateStateMachineDefinitionSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidateStateMachineDefinitionSeverity FindValue(string value)
        {
            return FindValue<ValidateStateMachineDefinitionSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidateStateMachineDefinitionSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant API_DOES_NOT_SUPPORT_LABELED_ARNS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason API_DOES_NOT_SUPPORT_LABELED_ARNS = new ValidationExceptionReason("API_DOES_NOT_SUPPORT_LABELED_ARNS");
        /// <summary>
        /// Constant CANNOT_UPDATE_COMPLETED_MAP_RUN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_UPDATE_COMPLETED_MAP_RUN = new ValidationExceptionReason("CANNOT_UPDATE_COMPLETED_MAP_RUN");
        /// <summary>
        /// Constant INVALID_ROUTING_CONFIGURATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ROUTING_CONFIGURATION = new ValidationExceptionReason("INVALID_ROUTING_CONFIGURATION");
        /// <summary>
        /// Constant MISSING_REQUIRED_PARAMETER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_REQUIRED_PARAMETER = new ValidationExceptionReason("MISSING_REQUIRED_PARAMETER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}
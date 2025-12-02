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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lambda
{

    /// <summary>
    /// Constants used for properties of type ApplicationLogLevel.
    /// </summary>
    public class ApplicationLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel DEBUG = new ApplicationLogLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel ERROR = new ApplicationLogLevel("ERROR");
        /// <summary>
        /// Constant FATAL for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel FATAL = new ApplicationLogLevel("FATAL");
        /// <summary>
        /// Constant INFO for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel INFO = new ApplicationLogLevel("INFO");
        /// <summary>
        /// Constant TRACE for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel TRACE = new ApplicationLogLevel("TRACE");
        /// <summary>
        /// Constant WARN for ApplicationLogLevel
        /// </summary>
        public static readonly ApplicationLogLevel WARN = new ApplicationLogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationLogLevel FindValue(string value)
        {
            return FindValue<ApplicationLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant Arm64 for Architecture
        /// </summary>
        public static readonly Architecture Arm64 = new Architecture("arm64");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderPredefinedMetricType.
    /// </summary>
    public class CapacityProviderPredefinedMetricType : ConstantClass
    {

        /// <summary>
        /// Constant LambdaCapacityProviderAverageCPUUtilization for CapacityProviderPredefinedMetricType
        /// </summary>
        public static readonly CapacityProviderPredefinedMetricType LambdaCapacityProviderAverageCPUUtilization = new CapacityProviderPredefinedMetricType("LambdaCapacityProviderAverageCPUUtilization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderPredefinedMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderPredefinedMetricType FindValue(string value)
        {
            return FindValue<CapacityProviderPredefinedMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderPredefinedMetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderScalingMode.
    /// </summary>
    public class CapacityProviderScalingMode : ConstantClass
    {

        /// <summary>
        /// Constant Auto for CapacityProviderScalingMode
        /// </summary>
        public static readonly CapacityProviderScalingMode Auto = new CapacityProviderScalingMode("Auto");
        /// <summary>
        /// Constant Manual for CapacityProviderScalingMode
        /// </summary>
        public static readonly CapacityProviderScalingMode Manual = new CapacityProviderScalingMode("Manual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderScalingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderScalingMode FindValue(string value)
        {
            return FindValue<CapacityProviderScalingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderScalingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityProviderState.
    /// </summary>
    public class CapacityProviderState : ConstantClass
    {

        /// <summary>
        /// Constant Active for CapacityProviderState
        /// </summary>
        public static readonly CapacityProviderState Active = new CapacityProviderState("Active");
        /// <summary>
        /// Constant Deleting for CapacityProviderState
        /// </summary>
        public static readonly CapacityProviderState Deleting = new CapacityProviderState("Deleting");
        /// <summary>
        /// Constant Failed for CapacityProviderState
        /// </summary>
        public static readonly CapacityProviderState Failed = new CapacityProviderState("Failed");
        /// <summary>
        /// Constant Pending for CapacityProviderState
        /// </summary>
        public static readonly CapacityProviderState Pending = new CapacityProviderState("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityProviderState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityProviderState FindValue(string value)
        {
            return FindValue<CapacityProviderState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityProviderState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeSigningPolicy.
    /// </summary>
    public class CodeSigningPolicy : ConstantClass
    {

        /// <summary>
        /// Constant Enforce for CodeSigningPolicy
        /// </summary>
        public static readonly CodeSigningPolicy Enforce = new CodeSigningPolicy("Enforce");
        /// <summary>
        /// Constant Warn for CodeSigningPolicy
        /// </summary>
        public static readonly CodeSigningPolicy Warn = new CodeSigningPolicy("Warn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeSigningPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeSigningPolicy FindValue(string value)
        {
            return FindValue<CodeSigningPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeSigningPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndPointType.
    /// </summary>
    public class EndPointType : ConstantClass
    {

        /// <summary>
        /// Constant KAFKA_BOOTSTRAP_SERVERS for EndPointType
        /// </summary>
        public static readonly EndPointType KAFKA_BOOTSTRAP_SERVERS = new EndPointType("KAFKA_BOOTSTRAP_SERVERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndPointType FindValue(string value)
        {
            return FindValue<EndPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceMappingMetric.
    /// </summary>
    public class EventSourceMappingMetric : ConstantClass
    {

        /// <summary>
        /// Constant EventCount for EventSourceMappingMetric
        /// </summary>
        public static readonly EventSourceMappingMetric EventCount = new EventSourceMappingMetric("EventCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceMappingMetric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceMappingMetric FindValue(string value)
        {
            return FindValue<EventSourceMappingMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceMappingMetric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourcePosition.
    /// </summary>
    public class EventSourcePosition : ConstantClass
    {

        /// <summary>
        /// Constant AT_TIMESTAMP for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition AT_TIMESTAMP = new EventSourcePosition("AT_TIMESTAMP");
        /// <summary>
        /// Constant LATEST for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition LATEST = new EventSourcePosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for EventSourcePosition
        /// </summary>
        public static readonly EventSourcePosition TRIM_HORIZON = new EventSourcePosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourcePosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourcePosition FindValue(string value)
        {
            return FindValue<EventSourcePosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourcePosition(string value)
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
        /// Constant CallbackFailed for EventType
        /// </summary>
        public static readonly EventType CallbackFailed = new EventType("CallbackFailed");
        /// <summary>
        /// Constant CallbackStarted for EventType
        /// </summary>
        public static readonly EventType CallbackStarted = new EventType("CallbackStarted");
        /// <summary>
        /// Constant CallbackSucceeded for EventType
        /// </summary>
        public static readonly EventType CallbackSucceeded = new EventType("CallbackSucceeded");
        /// <summary>
        /// Constant CallbackTimedOut for EventType
        /// </summary>
        public static readonly EventType CallbackTimedOut = new EventType("CallbackTimedOut");
        /// <summary>
        /// Constant ChainedInvokeFailed for EventType
        /// </summary>
        public static readonly EventType ChainedInvokeFailed = new EventType("ChainedInvokeFailed");
        /// <summary>
        /// Constant ChainedInvokeStarted for EventType
        /// </summary>
        public static readonly EventType ChainedInvokeStarted = new EventType("ChainedInvokeStarted");
        /// <summary>
        /// Constant ChainedInvokeStopped for EventType
        /// </summary>
        public static readonly EventType ChainedInvokeStopped = new EventType("ChainedInvokeStopped");
        /// <summary>
        /// Constant ChainedInvokeSucceeded for EventType
        /// </summary>
        public static readonly EventType ChainedInvokeSucceeded = new EventType("ChainedInvokeSucceeded");
        /// <summary>
        /// Constant ChainedInvokeTimedOut for EventType
        /// </summary>
        public static readonly EventType ChainedInvokeTimedOut = new EventType("ChainedInvokeTimedOut");
        /// <summary>
        /// Constant ContextFailed for EventType
        /// </summary>
        public static readonly EventType ContextFailed = new EventType("ContextFailed");
        /// <summary>
        /// Constant ContextStarted for EventType
        /// </summary>
        public static readonly EventType ContextStarted = new EventType("ContextStarted");
        /// <summary>
        /// Constant ContextSucceeded for EventType
        /// </summary>
        public static readonly EventType ContextSucceeded = new EventType("ContextSucceeded");
        /// <summary>
        /// Constant ExecutionFailed for EventType
        /// </summary>
        public static readonly EventType ExecutionFailed = new EventType("ExecutionFailed");
        /// <summary>
        /// Constant ExecutionStarted for EventType
        /// </summary>
        public static readonly EventType ExecutionStarted = new EventType("ExecutionStarted");
        /// <summary>
        /// Constant ExecutionStopped for EventType
        /// </summary>
        public static readonly EventType ExecutionStopped = new EventType("ExecutionStopped");
        /// <summary>
        /// Constant ExecutionSucceeded for EventType
        /// </summary>
        public static readonly EventType ExecutionSucceeded = new EventType("ExecutionSucceeded");
        /// <summary>
        /// Constant ExecutionTimedOut for EventType
        /// </summary>
        public static readonly EventType ExecutionTimedOut = new EventType("ExecutionTimedOut");
        /// <summary>
        /// Constant InvocationCompleted for EventType
        /// </summary>
        public static readonly EventType InvocationCompleted = new EventType("InvocationCompleted");
        /// <summary>
        /// Constant StepFailed for EventType
        /// </summary>
        public static readonly EventType StepFailed = new EventType("StepFailed");
        /// <summary>
        /// Constant StepStarted for EventType
        /// </summary>
        public static readonly EventType StepStarted = new EventType("StepStarted");
        /// <summary>
        /// Constant StepSucceeded for EventType
        /// </summary>
        public static readonly EventType StepSucceeded = new EventType("StepSucceeded");
        /// <summary>
        /// Constant WaitCancelled for EventType
        /// </summary>
        public static readonly EventType WaitCancelled = new EventType("WaitCancelled");
        /// <summary>
        /// Constant WaitStarted for EventType
        /// </summary>
        public static readonly EventType WaitStarted = new EventType("WaitStarted");
        /// <summary>
        /// Constant WaitSucceeded for EventType
        /// </summary>
        public static readonly EventType WaitSucceeded = new EventType("WaitSucceeded");

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
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus RUNNING = new ExecutionStatus("RUNNING");
        /// <summary>
        /// Constant STOPPED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus STOPPED = new ExecutionStatus("STOPPED");
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
    /// Constants used for properties of type FullDocument.
    /// </summary>
    public class FullDocument : ConstantClass
    {

        /// <summary>
        /// Constant Default for FullDocument
        /// </summary>
        public static readonly FullDocument Default = new FullDocument("Default");
        /// <summary>
        /// Constant UpdateLookup for FullDocument
        /// </summary>
        public static readonly FullDocument UpdateLookup = new FullDocument("UpdateLookup");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FullDocument(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FullDocument FindValue(string value)
        {
            return FindValue<FullDocument>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FullDocument(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionResponseType.
    /// </summary>
    public class FunctionResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ReportBatchItemFailures for FunctionResponseType
        /// </summary>
        public static readonly FunctionResponseType ReportBatchItemFailures = new FunctionResponseType("ReportBatchItemFailures");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionResponseType FindValue(string value)
        {
            return FindValue<FunctionResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionResponseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionUrlAuthType.
    /// </summary>
    public class FunctionUrlAuthType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for FunctionUrlAuthType
        /// </summary>
        public static readonly FunctionUrlAuthType AWS_IAM = new FunctionUrlAuthType("AWS_IAM");
        /// <summary>
        /// Constant NONE for FunctionUrlAuthType
        /// </summary>
        public static readonly FunctionUrlAuthType NONE = new FunctionUrlAuthType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionUrlAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionUrlAuthType FindValue(string value)
        {
            return FindValue<FunctionUrlAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionUrlAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionVersion.
    /// </summary>
    public class FunctionVersion : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FunctionVersion
        /// </summary>
        public static readonly FunctionVersion ALL = new FunctionVersion("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionVersion FindValue(string value)
        {
            return FindValue<FunctionVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FunctionVersionLatestPublished.
    /// </summary>
    public class FunctionVersionLatestPublished : ConstantClass
    {

        /// <summary>
        /// Constant LATEST_PUBLISHED for FunctionVersionLatestPublished
        /// </summary>
        public static readonly FunctionVersionLatestPublished LATEST_PUBLISHED = new FunctionVersionLatestPublished("LATEST_PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FunctionVersionLatestPublished(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FunctionVersionLatestPublished FindValue(string value)
        {
            return FindValue<FunctionVersionLatestPublished>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FunctionVersionLatestPublished(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant DryRun for InvocationType
        /// </summary>
        public static readonly InvocationType DryRun = new InvocationType("DryRun");
        /// <summary>
        /// Constant Event for InvocationType
        /// </summary>
        public static readonly InvocationType Event = new InvocationType("Event");
        /// <summary>
        /// Constant RequestResponse for InvocationType
        /// </summary>
        public static readonly InvocationType RequestResponse = new InvocationType("RequestResponse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvokeMode.
    /// </summary>
    public class InvokeMode : ConstantClass
    {

        /// <summary>
        /// Constant BUFFERED for InvokeMode
        /// </summary>
        public static readonly InvokeMode BUFFERED = new InvokeMode("BUFFERED");
        /// <summary>
        /// Constant RESPONSE_STREAM for InvokeMode
        /// </summary>
        public static readonly InvokeMode RESPONSE_STREAM = new InvokeMode("RESPONSE_STREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvokeMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvokeMode FindValue(string value)
        {
            return FindValue<InvokeMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvokeMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaSchemaRegistryAuthType.
    /// </summary>
    public class KafkaSchemaRegistryAuthType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC_AUTH for KafkaSchemaRegistryAuthType
        /// </summary>
        public static readonly KafkaSchemaRegistryAuthType BASIC_AUTH = new KafkaSchemaRegistryAuthType("BASIC_AUTH");
        /// <summary>
        /// Constant CLIENT_CERTIFICATE_TLS_AUTH for KafkaSchemaRegistryAuthType
        /// </summary>
        public static readonly KafkaSchemaRegistryAuthType CLIENT_CERTIFICATE_TLS_AUTH = new KafkaSchemaRegistryAuthType("CLIENT_CERTIFICATE_TLS_AUTH");
        /// <summary>
        /// Constant SERVER_ROOT_CA_CERTIFICATE for KafkaSchemaRegistryAuthType
        /// </summary>
        public static readonly KafkaSchemaRegistryAuthType SERVER_ROOT_CA_CERTIFICATE = new KafkaSchemaRegistryAuthType("SERVER_ROOT_CA_CERTIFICATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaSchemaRegistryAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaSchemaRegistryAuthType FindValue(string value)
        {
            return FindValue<KafkaSchemaRegistryAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaSchemaRegistryAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaSchemaValidationAttribute.
    /// </summary>
    public class KafkaSchemaValidationAttribute : ConstantClass
    {

        /// <summary>
        /// Constant KEY for KafkaSchemaValidationAttribute
        /// </summary>
        public static readonly KafkaSchemaValidationAttribute KEY = new KafkaSchemaValidationAttribute("KEY");
        /// <summary>
        /// Constant VALUE for KafkaSchemaValidationAttribute
        /// </summary>
        public static readonly KafkaSchemaValidationAttribute VALUE = new KafkaSchemaValidationAttribute("VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaSchemaValidationAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaSchemaValidationAttribute FindValue(string value)
        {
            return FindValue<KafkaSchemaValidationAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaSchemaValidationAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastUpdateStatus.
    /// </summary>
    public class LastUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus Failed = new LastUpdateStatus("Failed");
        /// <summary>
        /// Constant InProgress for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus InProgress = new LastUpdateStatus("InProgress");
        /// <summary>
        /// Constant Successful for LastUpdateStatus
        /// </summary>
        public static readonly LastUpdateStatus Successful = new LastUpdateStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastUpdateStatus FindValue(string value)
        {
            return FindValue<LastUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastUpdateStatusReasonCode.
    /// </summary>
    public class LastUpdateStatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CapacityProviderScalingLimitExceeded for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode CapacityProviderScalingLimitExceeded = new LastUpdateStatusReasonCode("CapacityProviderScalingLimitExceeded");
        /// <summary>
        /// Constant DisabledKMSKey for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode DisabledKMSKey = new LastUpdateStatusReasonCode("DisabledKMSKey");
        /// <summary>
        /// Constant EC2RequestLimitExceeded for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EC2RequestLimitExceeded = new LastUpdateStatusReasonCode("EC2RequestLimitExceeded");
        /// <summary>
        /// Constant EFSIOError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSIOError = new LastUpdateStatusReasonCode("EFSIOError");
        /// <summary>
        /// Constant EFSMountConnectivityError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountConnectivityError = new LastUpdateStatusReasonCode("EFSMountConnectivityError");
        /// <summary>
        /// Constant EFSMountFailure for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountFailure = new LastUpdateStatusReasonCode("EFSMountFailure");
        /// <summary>
        /// Constant EFSMountTimeout for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EFSMountTimeout = new LastUpdateStatusReasonCode("EFSMountTimeout");
        /// <summary>
        /// Constant EniLimitExceeded for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode EniLimitExceeded = new LastUpdateStatusReasonCode("EniLimitExceeded");
        /// <summary>
        /// Constant FunctionError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionError = new LastUpdateStatusReasonCode("FunctionError");
        /// <summary>
        /// Constant FunctionErrorExtensionInitError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorExtensionInitError = new LastUpdateStatusReasonCode("FunctionError.ExtensionInitError");
        /// <summary>
        /// Constant FunctionErrorInitResourceExhausted for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorInitResourceExhausted = new LastUpdateStatusReasonCode("FunctionError.InitResourceExhausted");
        /// <summary>
        /// Constant FunctionErrorInitTimeout for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorInitTimeout = new LastUpdateStatusReasonCode("FunctionError.InitTimeout");
        /// <summary>
        /// Constant FunctionErrorInvalidEntryPoint for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorInvalidEntryPoint = new LastUpdateStatusReasonCode("FunctionError.InvalidEntryPoint");
        /// <summary>
        /// Constant FunctionErrorInvalidWorkingDirectory for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorInvalidWorkingDirectory = new LastUpdateStatusReasonCode("FunctionError.InvalidWorkingDirectory");
        /// <summary>
        /// Constant FunctionErrorPermissionDenied for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorPermissionDenied = new LastUpdateStatusReasonCode("FunctionError.PermissionDenied");
        /// <summary>
        /// Constant FunctionErrorRuntimeInitError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorRuntimeInitError = new LastUpdateStatusReasonCode("FunctionError.RuntimeInitError");
        /// <summary>
        /// Constant FunctionErrorTooManyExtensions for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode FunctionErrorTooManyExtensions = new LastUpdateStatusReasonCode("FunctionError.TooManyExtensions");
        /// <summary>
        /// Constant ImageAccessDenied for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode ImageAccessDenied = new LastUpdateStatusReasonCode("ImageAccessDenied");
        /// <summary>
        /// Constant ImageDeleted for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode ImageDeleted = new LastUpdateStatusReasonCode("ImageDeleted");
        /// <summary>
        /// Constant InsufficientCapacity for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InsufficientCapacity = new LastUpdateStatusReasonCode("InsufficientCapacity");
        /// <summary>
        /// Constant InsufficientRolePermissions for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InsufficientRolePermissions = new LastUpdateStatusReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InternalError = new LastUpdateStatusReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidConfiguration for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidConfiguration = new LastUpdateStatusReasonCode("InvalidConfiguration");
        /// <summary>
        /// Constant InvalidImage for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidImage = new LastUpdateStatusReasonCode("InvalidImage");
        /// <summary>
        /// Constant InvalidRuntime for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidRuntime = new LastUpdateStatusReasonCode("InvalidRuntime");
        /// <summary>
        /// Constant InvalidSecurityGroup for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidSecurityGroup = new LastUpdateStatusReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidStateKMSKey for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidStateKMSKey = new LastUpdateStatusReasonCode("InvalidStateKMSKey");
        /// <summary>
        /// Constant InvalidSubnet for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidSubnet = new LastUpdateStatusReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant InvalidZipFileException for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode InvalidZipFileException = new LastUpdateStatusReasonCode("InvalidZipFileException");
        /// <summary>
        /// Constant KMSKeyAccessDenied for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode KMSKeyAccessDenied = new LastUpdateStatusReasonCode("KMSKeyAccessDenied");
        /// <summary>
        /// Constant KMSKeyNotFound for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode KMSKeyNotFound = new LastUpdateStatusReasonCode("KMSKeyNotFound");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode SubnetOutOfIPAddresses = new LastUpdateStatusReasonCode("SubnetOutOfIPAddresses");
        /// <summary>
        /// Constant VcpuLimitExceeded for LastUpdateStatusReasonCode
        /// </summary>
        public static readonly LastUpdateStatusReasonCode VcpuLimitExceeded = new LastUpdateStatusReasonCode("VcpuLimitExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastUpdateStatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastUpdateStatusReasonCode FindValue(string value)
        {
            return FindValue<LastUpdateStatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastUpdateStatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogFormat.
    /// </summary>
    public class LogFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for LogFormat
        /// </summary>
        public static readonly LogFormat JSON = new LogFormat("JSON");
        /// <summary>
        /// Constant Text for LogFormat
        /// </summary>
        public static readonly LogFormat Text = new LogFormat("Text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFormat FindValue(string value)
        {
            return FindValue<LogFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant None for LogType
        /// </summary>
        public static readonly LogType None = new LogType("None");
        /// <summary>
        /// Constant Tail for LogType
        /// </summary>
        public static readonly LogType Tail = new LogType("Tail");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationAction.
    /// </summary>
    public class OperationAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for OperationAction
        /// </summary>
        public static readonly OperationAction CANCEL = new OperationAction("CANCEL");
        /// <summary>
        /// Constant FAIL for OperationAction
        /// </summary>
        public static readonly OperationAction FAIL = new OperationAction("FAIL");
        /// <summary>
        /// Constant RETRY for OperationAction
        /// </summary>
        public static readonly OperationAction RETRY = new OperationAction("RETRY");
        /// <summary>
        /// Constant START for OperationAction
        /// </summary>
        public static readonly OperationAction START = new OperationAction("START");
        /// <summary>
        /// Constant SUCCEED for OperationAction
        /// </summary>
        public static readonly OperationAction SUCCEED = new OperationAction("SUCCEED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationAction FindValue(string value)
        {
            return FindValue<OperationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for OperationStatus
        /// </summary>
        public static readonly OperationStatus CANCELLED = new OperationStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAILED = new OperationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for OperationStatus
        /// </summary>
        public static readonly OperationStatus PENDING = new OperationStatus("PENDING");
        /// <summary>
        /// Constant READY for OperationStatus
        /// </summary>
        public static readonly OperationStatus READY = new OperationStatus("READY");
        /// <summary>
        /// Constant STARTED for OperationStatus
        /// </summary>
        public static readonly OperationStatus STARTED = new OperationStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for OperationStatus
        /// </summary>
        public static readonly OperationStatus STOPPED = new OperationStatus("STOPPED");
        /// <summary>
        /// Constant SUCCEEDED for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCEEDED = new OperationStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for OperationStatus
        /// </summary>
        public static readonly OperationStatus TIMED_OUT = new OperationStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant CALLBACK for OperationType
        /// </summary>
        public static readonly OperationType CALLBACK = new OperationType("CALLBACK");
        /// <summary>
        /// Constant CHAINED_INVOKE for OperationType
        /// </summary>
        public static readonly OperationType CHAINED_INVOKE = new OperationType("CHAINED_INVOKE");
        /// <summary>
        /// Constant CONTEXT for OperationType
        /// </summary>
        public static readonly OperationType CONTEXT = new OperationType("CONTEXT");
        /// <summary>
        /// Constant EXECUTION for OperationType
        /// </summary>
        public static readonly OperationType EXECUTION = new OperationType("EXECUTION");
        /// <summary>
        /// Constant STEP for OperationType
        /// </summary>
        public static readonly OperationType STEP = new OperationType("STEP");
        /// <summary>
        /// Constant WAIT for OperationType
        /// </summary>
        public static readonly OperationType WAIT = new OperationType("WAIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageType.
    /// </summary>
    public class PackageType : ConstantClass
    {

        /// <summary>
        /// Constant Image for PackageType
        /// </summary>
        public static readonly PackageType Image = new PackageType("Image");
        /// <summary>
        /// Constant Zip for PackageType
        /// </summary>
        public static readonly PackageType Zip = new PackageType("Zip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageType FindValue(string value)
        {
            return FindValue<PackageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedConcurrencyStatusEnum.
    /// </summary>
    public class ProvisionedConcurrencyStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum FAILED = new ProvisionedConcurrencyStatusEnum("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum IN_PROGRESS = new ProvisionedConcurrencyStatusEnum("IN_PROGRESS");
        /// <summary>
        /// Constant READY for ProvisionedConcurrencyStatusEnum
        /// </summary>
        public static readonly ProvisionedConcurrencyStatusEnum READY = new ProvisionedConcurrencyStatusEnum("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedConcurrencyStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedConcurrencyStatusEnum FindValue(string value)
        {
            return FindValue<ProvisionedConcurrencyStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedConcurrencyStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecursiveLoop.
    /// </summary>
    public class RecursiveLoop : ConstantClass
    {

        /// <summary>
        /// Constant Allow for RecursiveLoop
        /// </summary>
        public static readonly RecursiveLoop Allow = new RecursiveLoop("Allow");
        /// <summary>
        /// Constant Terminate for RecursiveLoop
        /// </summary>
        public static readonly RecursiveLoop Terminate = new RecursiveLoop("Terminate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecursiveLoop(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecursiveLoop FindValue(string value)
        {
            return FindValue<RecursiveLoop>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecursiveLoop(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseStreamingInvocationType.
    /// </summary>
    public class ResponseStreamingInvocationType : ConstantClass
    {

        /// <summary>
        /// Constant DryRun for ResponseStreamingInvocationType
        /// </summary>
        public static readonly ResponseStreamingInvocationType DryRun = new ResponseStreamingInvocationType("DryRun");
        /// <summary>
        /// Constant RequestResponse for ResponseStreamingInvocationType
        /// </summary>
        public static readonly ResponseStreamingInvocationType RequestResponse = new ResponseStreamingInvocationType("RequestResponse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseStreamingInvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseStreamingInvocationType FindValue(string value)
        {
            return FindValue<ResponseStreamingInvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseStreamingInvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant Dotnet6 for Runtime
        /// </summary>
        public static readonly Runtime Dotnet6 = new Runtime("dotnet6");
        /// <summary>
        /// Constant Dotnet8 for Runtime
        /// </summary>
        public static readonly Runtime Dotnet8 = new Runtime("dotnet8");
        /// <summary>
        /// Constant Dotnetcore10 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore10 = new Runtime("dotnetcore1.0");
        /// <summary>
        /// Constant Dotnetcore20 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore20 = new Runtime("dotnetcore2.0");
        /// <summary>
        /// Constant Dotnetcore21 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore21 = new Runtime("dotnetcore2.1");
        /// <summary>
        /// Constant Dotnetcore31 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore31 = new Runtime("dotnetcore3.1");
        /// <summary>
        /// Constant Go1X for Runtime
        /// </summary>
        public static readonly Runtime Go1X = new Runtime("go1.x");
        /// <summary>
        /// Constant Java11 for Runtime
        /// </summary>
        public static readonly Runtime Java11 = new Runtime("java11");
        /// <summary>
        /// Constant Java17 for Runtime
        /// </summary>
        public static readonly Runtime Java17 = new Runtime("java17");
        /// <summary>
        /// Constant Java21 for Runtime
        /// </summary>
        public static readonly Runtime Java21 = new Runtime("java21");
        /// <summary>
        /// Constant Java25 for Runtime
        /// </summary>
        public static readonly Runtime Java25 = new Runtime("java25");
        /// <summary>
        /// Constant Java8 for Runtime
        /// </summary>
        public static readonly Runtime Java8 = new Runtime("java8");
        /// <summary>
        /// Constant Java8Al2 for Runtime
        /// </summary>
        public static readonly Runtime Java8Al2 = new Runtime("java8.al2");
        /// <summary>
        /// Constant Nodejs for Runtime
        /// </summary>
        public static readonly Runtime Nodejs = new Runtime("nodejs");
        /// <summary>
        /// Constant Nodejs10X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs10X = new Runtime("nodejs10.x");
        /// <summary>
        /// Constant Nodejs12X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs12X = new Runtime("nodejs12.x");
        /// <summary>
        /// Constant Nodejs14X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs14X = new Runtime("nodejs14.x");
        /// <summary>
        /// Constant Nodejs16X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs16X = new Runtime("nodejs16.x");
        /// <summary>
        /// Constant Nodejs18X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs18X = new Runtime("nodejs18.x");
        /// <summary>
        /// Constant Nodejs20X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs20X = new Runtime("nodejs20.x");
        /// <summary>
        /// Constant Nodejs22X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs22X = new Runtime("nodejs22.x");
        /// <summary>
        /// Constant Nodejs24X for Runtime
        /// </summary>
        public static readonly Runtime Nodejs24X = new Runtime("nodejs24.x");
        /// <summary>
        /// Constant Nodejs43 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs43 = new Runtime("nodejs4.3");
        /// <summary>
        /// Constant Nodejs43Edge for Runtime
        /// </summary>
        public static readonly Runtime Nodejs43Edge = new Runtime("nodejs4.3-edge");
        /// <summary>
        /// Constant Nodejs610 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs610 = new Runtime("nodejs6.10");
        /// <summary>
        /// Constant Nodejs810 for Runtime
        /// </summary>
        public static readonly Runtime Nodejs810 = new Runtime("nodejs8.10");
        /// <summary>
        /// Constant Provided for Runtime
        /// </summary>
        public static readonly Runtime Provided = new Runtime("provided");
        /// <summary>
        /// Constant ProvidedAl2 for Runtime
        /// </summary>
        public static readonly Runtime ProvidedAl2 = new Runtime("provided.al2");
        /// <summary>
        /// Constant ProvidedAl2023 for Runtime
        /// </summary>
        public static readonly Runtime ProvidedAl2023 = new Runtime("provided.al2023");
        /// <summary>
        /// Constant Python27 for Runtime
        /// </summary>
        public static readonly Runtime Python27 = new Runtime("python2.7");
        /// <summary>
        /// Constant Python310 for Runtime
        /// </summary>
        public static readonly Runtime Python310 = new Runtime("python3.10");
        /// <summary>
        /// Constant Python311 for Runtime
        /// </summary>
        public static readonly Runtime Python311 = new Runtime("python3.11");
        /// <summary>
        /// Constant Python312 for Runtime
        /// </summary>
        public static readonly Runtime Python312 = new Runtime("python3.12");
        /// <summary>
        /// Constant Python313 for Runtime
        /// </summary>
        public static readonly Runtime Python313 = new Runtime("python3.13");
        /// <summary>
        /// Constant Python314 for Runtime
        /// </summary>
        public static readonly Runtime Python314 = new Runtime("python3.14");
        /// <summary>
        /// Constant Python36 for Runtime
        /// </summary>
        public static readonly Runtime Python36 = new Runtime("python3.6");
        /// <summary>
        /// Constant Python37 for Runtime
        /// </summary>
        public static readonly Runtime Python37 = new Runtime("python3.7");
        /// <summary>
        /// Constant Python38 for Runtime
        /// </summary>
        public static readonly Runtime Python38 = new Runtime("python3.8");
        /// <summary>
        /// Constant Python39 for Runtime
        /// </summary>
        public static readonly Runtime Python39 = new Runtime("python3.9");
        /// <summary>
        /// Constant Ruby25 for Runtime
        /// </summary>
        public static readonly Runtime Ruby25 = new Runtime("ruby2.5");
        /// <summary>
        /// Constant Ruby27 for Runtime
        /// </summary>
        public static readonly Runtime Ruby27 = new Runtime("ruby2.7");
        /// <summary>
        /// Constant Ruby32 for Runtime
        /// </summary>
        public static readonly Runtime Ruby32 = new Runtime("ruby3.2");
        /// <summary>
        /// Constant Ruby33 for Runtime
        /// </summary>
        public static readonly Runtime Ruby33 = new Runtime("ruby3.3");
        /// <summary>
        /// Constant Ruby34 for Runtime
        /// </summary>
        public static readonly Runtime Ruby34 = new Runtime("ruby3.4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Runtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Runtime FindValue(string value)
        {
            return FindValue<Runtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Runtime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaRegistryEventRecordFormat.
    /// </summary>
    public class SchemaRegistryEventRecordFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for SchemaRegistryEventRecordFormat
        /// </summary>
        public static readonly SchemaRegistryEventRecordFormat JSON = new SchemaRegistryEventRecordFormat("JSON");
        /// <summary>
        /// Constant SOURCE for SchemaRegistryEventRecordFormat
        /// </summary>
        public static readonly SchemaRegistryEventRecordFormat SOURCE = new SchemaRegistryEventRecordFormat("SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaRegistryEventRecordFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaRegistryEventRecordFormat FindValue(string value)
        {
            return FindValue<SchemaRegistryEventRecordFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaRegistryEventRecordFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapStartApplyOn.
    /// </summary>
    public class SnapStartApplyOn : ConstantClass
    {

        /// <summary>
        /// Constant None for SnapStartApplyOn
        /// </summary>
        public static readonly SnapStartApplyOn None = new SnapStartApplyOn("None");
        /// <summary>
        /// Constant PublishedVersions for SnapStartApplyOn
        /// </summary>
        public static readonly SnapStartApplyOn PublishedVersions = new SnapStartApplyOn("PublishedVersions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapStartApplyOn(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapStartApplyOn FindValue(string value)
        {
            return FindValue<SnapStartApplyOn>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapStartApplyOn(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapStartOptimizationStatus.
    /// </summary>
    public class SnapStartOptimizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Off for SnapStartOptimizationStatus
        /// </summary>
        public static readonly SnapStartOptimizationStatus Off = new SnapStartOptimizationStatus("Off");
        /// <summary>
        /// Constant On for SnapStartOptimizationStatus
        /// </summary>
        public static readonly SnapStartOptimizationStatus On = new SnapStartOptimizationStatus("On");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapStartOptimizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapStartOptimizationStatus FindValue(string value)
        {
            return FindValue<SnapStartOptimizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapStartOptimizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceAccessType.
    /// </summary>
    public class SourceAccessType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType BASIC_AUTH = new SourceAccessType("BASIC_AUTH");
        /// <summary>
        /// Constant CLIENT_CERTIFICATE_TLS_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType CLIENT_CERTIFICATE_TLS_AUTH = new SourceAccessType("CLIENT_CERTIFICATE_TLS_AUTH");
        /// <summary>
        /// Constant SASL_SCRAM_256_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SASL_SCRAM_256_AUTH = new SourceAccessType("SASL_SCRAM_256_AUTH");
        /// <summary>
        /// Constant SASL_SCRAM_512_AUTH for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SASL_SCRAM_512_AUTH = new SourceAccessType("SASL_SCRAM_512_AUTH");
        /// <summary>
        /// Constant SERVER_ROOT_CA_CERTIFICATE for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType SERVER_ROOT_CA_CERTIFICATE = new SourceAccessType("SERVER_ROOT_CA_CERTIFICATE");
        /// <summary>
        /// Constant VIRTUAL_HOST for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VIRTUAL_HOST = new SourceAccessType("VIRTUAL_HOST");
        /// <summary>
        /// Constant VPC_SECURITY_GROUP for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VPC_SECURITY_GROUP = new SourceAccessType("VPC_SECURITY_GROUP");
        /// <summary>
        /// Constant VPC_SUBNET for SourceAccessType
        /// </summary>
        public static readonly SourceAccessType VPC_SUBNET = new SourceAccessType("VPC_SUBNET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceAccessType FindValue(string value)
        {
            return FindValue<SourceAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant Active for State
        /// </summary>
        public static readonly State Active = new State("Active");
        /// <summary>
        /// Constant ActiveNonInvocable for State
        /// </summary>
        public static readonly State ActiveNonInvocable = new State("ActiveNonInvocable");
        /// <summary>
        /// Constant Deactivated for State
        /// </summary>
        public static readonly State Deactivated = new State("Deactivated");
        /// <summary>
        /// Constant Deactivating for State
        /// </summary>
        public static readonly State Deactivating = new State("Deactivating");
        /// <summary>
        /// Constant Deleting for State
        /// </summary>
        public static readonly State Deleting = new State("Deleting");
        /// <summary>
        /// Constant Failed for State
        /// </summary>
        public static readonly State Failed = new State("Failed");
        /// <summary>
        /// Constant Inactive for State
        /// </summary>
        public static readonly State Inactive = new State("Inactive");
        /// <summary>
        /// Constant Pending for State
        /// </summary>
        public static readonly State Pending = new State("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StateReasonCode.
    /// </summary>
    public class StateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant CapacityProviderScalingLimitExceeded for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode CapacityProviderScalingLimitExceeded = new StateReasonCode("CapacityProviderScalingLimitExceeded");
        /// <summary>
        /// Constant Creating for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Creating = new StateReasonCode("Creating");
        /// <summary>
        /// Constant DisabledKMSKey for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode DisabledKMSKey = new StateReasonCode("DisabledKMSKey");
        /// <summary>
        /// Constant DrainingDurableExecutions for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode DrainingDurableExecutions = new StateReasonCode("DrainingDurableExecutions");
        /// <summary>
        /// Constant EC2RequestLimitExceeded for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EC2RequestLimitExceeded = new StateReasonCode("EC2RequestLimitExceeded");
        /// <summary>
        /// Constant EFSIOError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSIOError = new StateReasonCode("EFSIOError");
        /// <summary>
        /// Constant EFSMountConnectivityError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountConnectivityError = new StateReasonCode("EFSMountConnectivityError");
        /// <summary>
        /// Constant EFSMountFailure for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountFailure = new StateReasonCode("EFSMountFailure");
        /// <summary>
        /// Constant EFSMountTimeout for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EFSMountTimeout = new StateReasonCode("EFSMountTimeout");
        /// <summary>
        /// Constant EniLimitExceeded for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode EniLimitExceeded = new StateReasonCode("EniLimitExceeded");
        /// <summary>
        /// Constant FunctionError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionError = new StateReasonCode("FunctionError");
        /// <summary>
        /// Constant FunctionErrorExtensionInitError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorExtensionInitError = new StateReasonCode("FunctionError.ExtensionInitError");
        /// <summary>
        /// Constant FunctionErrorInitResourceExhausted for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorInitResourceExhausted = new StateReasonCode("FunctionError.InitResourceExhausted");
        /// <summary>
        /// Constant FunctionErrorInitTimeout for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorInitTimeout = new StateReasonCode("FunctionError.InitTimeout");
        /// <summary>
        /// Constant FunctionErrorInvalidEntryPoint for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorInvalidEntryPoint = new StateReasonCode("FunctionError.InvalidEntryPoint");
        /// <summary>
        /// Constant FunctionErrorInvalidWorkingDirectory for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorInvalidWorkingDirectory = new StateReasonCode("FunctionError.InvalidWorkingDirectory");
        /// <summary>
        /// Constant FunctionErrorPermissionDenied for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorPermissionDenied = new StateReasonCode("FunctionError.PermissionDenied");
        /// <summary>
        /// Constant FunctionErrorRuntimeInitError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorRuntimeInitError = new StateReasonCode("FunctionError.RuntimeInitError");
        /// <summary>
        /// Constant FunctionErrorTooManyExtensions for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode FunctionErrorTooManyExtensions = new StateReasonCode("FunctionError.TooManyExtensions");
        /// <summary>
        /// Constant Idle for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Idle = new StateReasonCode("Idle");
        /// <summary>
        /// Constant ImageAccessDenied for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode ImageAccessDenied = new StateReasonCode("ImageAccessDenied");
        /// <summary>
        /// Constant ImageDeleted for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode ImageDeleted = new StateReasonCode("ImageDeleted");
        /// <summary>
        /// Constant InsufficientCapacity for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InsufficientCapacity = new StateReasonCode("InsufficientCapacity");
        /// <summary>
        /// Constant InsufficientRolePermissions for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InsufficientRolePermissions = new StateReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InternalError = new StateReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidConfiguration for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidConfiguration = new StateReasonCode("InvalidConfiguration");
        /// <summary>
        /// Constant InvalidImage for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidImage = new StateReasonCode("InvalidImage");
        /// <summary>
        /// Constant InvalidRuntime for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidRuntime = new StateReasonCode("InvalidRuntime");
        /// <summary>
        /// Constant InvalidSecurityGroup for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidSecurityGroup = new StateReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidStateKMSKey for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidStateKMSKey = new StateReasonCode("InvalidStateKMSKey");
        /// <summary>
        /// Constant InvalidSubnet for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidSubnet = new StateReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant InvalidZipFileException for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode InvalidZipFileException = new StateReasonCode("InvalidZipFileException");
        /// <summary>
        /// Constant KMSKeyAccessDenied for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode KMSKeyAccessDenied = new StateReasonCode("KMSKeyAccessDenied");
        /// <summary>
        /// Constant KMSKeyNotFound for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode KMSKeyNotFound = new StateReasonCode("KMSKeyNotFound");
        /// <summary>
        /// Constant Restoring for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode Restoring = new StateReasonCode("Restoring");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode SubnetOutOfIPAddresses = new StateReasonCode("SubnetOutOfIPAddresses");
        /// <summary>
        /// Constant VcpuLimitExceeded for StateReasonCode
        /// </summary>
        public static readonly StateReasonCode VcpuLimitExceeded = new StateReasonCode("VcpuLimitExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateReasonCode FindValue(string value)
        {
            return FindValue<StateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SystemLogLevel.
    /// </summary>
    public class SystemLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel DEBUG = new SystemLogLevel("DEBUG");
        /// <summary>
        /// Constant INFO for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel INFO = new SystemLogLevel("INFO");
        /// <summary>
        /// Constant WARN for SystemLogLevel
        /// </summary>
        public static readonly SystemLogLevel WARN = new SystemLogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SystemLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SystemLogLevel FindValue(string value)
        {
            return FindValue<SystemLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SystemLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TenantIsolationMode.
    /// </summary>
    public class TenantIsolationMode : ConstantClass
    {

        /// <summary>
        /// Constant PER_TENANT for TenantIsolationMode
        /// </summary>
        public static readonly TenantIsolationMode PER_TENANT = new TenantIsolationMode("PER_TENANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TenantIsolationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TenantIsolationMode FindValue(string value)
        {
            return FindValue<TenantIsolationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TenantIsolationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThrottleReason.
    /// </summary>
    public class ThrottleReason : ConstantClass
    {

        /// <summary>
        /// Constant CallerRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason CallerRateLimitExceeded = new ThrottleReason("CallerRateLimitExceeded");
        /// <summary>
        /// Constant ConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentInvocationLimitExceeded = new ThrottleReason("ConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ConcurrentSnapshotCreateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentSnapshotCreateLimitExceeded = new ThrottleReason("ConcurrentSnapshotCreateLimitExceeded");
        /// <summary>
        /// Constant FunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason FunctionInvocationRateLimitExceeded = new ThrottleReason("FunctionInvocationRateLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionConcurrentInvocationLimitExceeded = new ThrottleReason("ReservedFunctionConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionInvocationRateLimitExceeded = new ThrottleReason("ReservedFunctionInvocationRateLimitExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThrottleReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThrottleReason FindValue(string value)
        {
            return FindValue<ThrottleReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThrottleReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TracingMode.
    /// </summary>
    public class TracingMode : ConstantClass
    {

        /// <summary>
        /// Constant Active for TracingMode
        /// </summary>
        public static readonly TracingMode Active = new TracingMode("Active");
        /// <summary>
        /// Constant PassThrough for TracingMode
        /// </summary>
        public static readonly TracingMode PassThrough = new TracingMode("PassThrough");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TracingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TracingMode FindValue(string value)
        {
            return FindValue<TracingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TracingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateRuntimeOn.
    /// </summary>
    public class UpdateRuntimeOn : ConstantClass
    {

        /// <summary>
        /// Constant Auto for UpdateRuntimeOn
        /// </summary>
        public static readonly UpdateRuntimeOn Auto = new UpdateRuntimeOn("Auto");
        /// <summary>
        /// Constant FunctionUpdate for UpdateRuntimeOn
        /// </summary>
        public static readonly UpdateRuntimeOn FunctionUpdate = new UpdateRuntimeOn("FunctionUpdate");
        /// <summary>
        /// Constant Manual for UpdateRuntimeOn
        /// </summary>
        public static readonly UpdateRuntimeOn Manual = new UpdateRuntimeOn("Manual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateRuntimeOn(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateRuntimeOn FindValue(string value)
        {
            return FindValue<UpdateRuntimeOn>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateRuntimeOn(string value)
        {
            return FindValue(value);
        }
    }

}
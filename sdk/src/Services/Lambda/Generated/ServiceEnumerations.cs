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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Lambda
{

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
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant Dotnetcore10 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore10 = new Runtime("dotnetcore1.0");
        /// <summary>
        /// Constant Dotnetcore20 for Runtime
        /// </summary>
        public static readonly Runtime Dotnetcore20 = new Runtime("dotnetcore2.0");
        /// <summary>
        /// Constant Go1X for Runtime
        /// </summary>
        public static readonly Runtime Go1X = new Runtime("go1.x");
        /// <summary>
        /// Constant Java8 for Runtime
        /// </summary>
        public static readonly Runtime Java8 = new Runtime("java8");
        /// <summary>
        /// Constant Nodejs for Runtime
        /// </summary>
        public static readonly Runtime Nodejs = new Runtime("nodejs");
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
        /// Constant Python27 for Runtime
        /// </summary>
        public static readonly Runtime Python27 = new Runtime("python2.7");
        /// <summary>
        /// Constant Python36 for Runtime
        /// </summary>
        public static readonly Runtime Python36 = new Runtime("python3.6");

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

}
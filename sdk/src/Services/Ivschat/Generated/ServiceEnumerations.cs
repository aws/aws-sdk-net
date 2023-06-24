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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Ivschat
{

    /// <summary>
    /// Constants used for properties of type ChatTokenCapability.
    /// </summary>
    public class ChatTokenCapability : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_MESSAGE for ChatTokenCapability
        /// </summary>
        public static readonly ChatTokenCapability DELETE_MESSAGE = new ChatTokenCapability("DELETE_MESSAGE");
        /// <summary>
        /// Constant DISCONNECT_USER for ChatTokenCapability
        /// </summary>
        public static readonly ChatTokenCapability DISCONNECT_USER = new ChatTokenCapability("DISCONNECT_USER");
        /// <summary>
        /// Constant SEND_MESSAGE for ChatTokenCapability
        /// </summary>
        public static readonly ChatTokenCapability SEND_MESSAGE = new ChatTokenCapability("SEND_MESSAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChatTokenCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChatTokenCapability FindValue(string value)
        {
            return FindValue<ChatTokenCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChatTokenCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CreateLoggingConfigurationState.
    /// </summary>
    public class CreateLoggingConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CreateLoggingConfigurationState
        /// </summary>
        public static readonly CreateLoggingConfigurationState ACTIVE = new CreateLoggingConfigurationState("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreateLoggingConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreateLoggingConfigurationState FindValue(string value)
        {
            return FindValue<CreateLoggingConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreateLoggingConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FallbackResult.
    /// </summary>
    public class FallbackResult : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for FallbackResult
        /// </summary>
        public static readonly FallbackResult ALLOW = new FallbackResult("ALLOW");
        /// <summary>
        /// Constant DENY for FallbackResult
        /// </summary>
        public static readonly FallbackResult DENY = new FallbackResult("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FallbackResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FallbackResult FindValue(string value)
        {
            return FindValue<FallbackResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FallbackResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingConfigurationState.
    /// </summary>
    public class LoggingConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState ACTIVE = new LoggingConfigurationState("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState CREATE_FAILED = new LoggingConfigurationState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState CREATING = new LoggingConfigurationState("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState DELETE_FAILED = new LoggingConfigurationState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState DELETING = new LoggingConfigurationState("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState UPDATE_FAILED = new LoggingConfigurationState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for LoggingConfigurationState
        /// </summary>
        public static readonly LoggingConfigurationState UPDATING = new LoggingConfigurationState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingConfigurationState FindValue(string value)
        {
            return FindValue<LoggingConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ROOM for ResourceType
        /// </summary>
        public static readonly ResourceType ROOM = new ResourceType("ROOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateLoggingConfigurationState.
    /// </summary>
    public class UpdateLoggingConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for UpdateLoggingConfigurationState
        /// </summary>
        public static readonly UpdateLoggingConfigurationState ACTIVE = new UpdateLoggingConfigurationState("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateLoggingConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateLoggingConfigurationState FindValue(string value)
        {
            return FindValue<UpdateLoggingConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateLoggingConfigurationState(string value)
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
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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
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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgentRuntime
{

    /// <summary>
    /// Constants used for properties of type ActionGroupSignature.
    /// </summary>
    public class ActionGroupSignature : ConstantClass
    {

        /// <summary>
        /// Constant AMAZONCodeInterpreter for ActionGroupSignature
        /// </summary>
        public static readonly ActionGroupSignature AMAZONCodeInterpreter = new ActionGroupSignature("AMAZON.CodeInterpreter");
        /// <summary>
        /// Constant AMAZONUserInput for ActionGroupSignature
        /// </summary>
        public static readonly ActionGroupSignature AMAZONUserInput = new ActionGroupSignature("AMAZON.UserInput");
        /// <summary>
        /// Constant ANTHROPICBash for ActionGroupSignature
        /// </summary>
        public static readonly ActionGroupSignature ANTHROPICBash = new ActionGroupSignature("ANTHROPIC.Bash");
        /// <summary>
        /// Constant ANTHROPICComputer for ActionGroupSignature
        /// </summary>
        public static readonly ActionGroupSignature ANTHROPICComputer = new ActionGroupSignature("ANTHROPIC.Computer");
        /// <summary>
        /// Constant ANTHROPICTextEditor for ActionGroupSignature
        /// </summary>
        public static readonly ActionGroupSignature ANTHROPICTextEditor = new ActionGroupSignature("ANTHROPIC.TextEditor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionGroupSignature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionGroupSignature FindValue(string value)
        {
            return FindValue<ActionGroupSignature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionGroupSignature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionInvocationType.
    /// </summary>
    public class ActionInvocationType : ConstantClass
    {

        /// <summary>
        /// Constant RESULT for ActionInvocationType
        /// </summary>
        public static readonly ActionInvocationType RESULT = new ActionInvocationType("RESULT");
        /// <summary>
        /// Constant USER_CONFIRMATION for ActionInvocationType
        /// </summary>
        public static readonly ActionInvocationType USER_CONFIRMATION = new ActionInvocationType("USER_CONFIRMATION");
        /// <summary>
        /// Constant USER_CONFIRMATION_AND_RESULT for ActionInvocationType
        /// </summary>
        public static readonly ActionInvocationType USER_CONFIRMATION_AND_RESULT = new ActionInvocationType("USER_CONFIRMATION_AND_RESULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionInvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionInvocationType FindValue(string value)
        {
            return FindValue<ActionInvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionInvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentCollaboration.
    /// </summary>
    public class AgentCollaboration : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AgentCollaboration
        /// </summary>
        public static readonly AgentCollaboration DISABLED = new AgentCollaboration("DISABLED");
        /// <summary>
        /// Constant SUPERVISOR for AgentCollaboration
        /// </summary>
        public static readonly AgentCollaboration SUPERVISOR = new AgentCollaboration("SUPERVISOR");
        /// <summary>
        /// Constant SUPERVISOR_ROUTER for AgentCollaboration
        /// </summary>
        public static readonly AgentCollaboration SUPERVISOR_ROUTER = new AgentCollaboration("SUPERVISOR_ROUTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentCollaboration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentCollaboration FindValue(string value)
        {
            return FindValue<AgentCollaboration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentCollaboration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeType.
    /// </summary>
    public class AttributeType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for AttributeType
        /// </summary>
        public static readonly AttributeType BOOLEAN = new AttributeType("BOOLEAN");
        /// <summary>
        /// Constant NUMBER for AttributeType
        /// </summary>
        public static readonly AttributeType NUMBER = new AttributeType("NUMBER");
        /// <summary>
        /// Constant STRING for AttributeType
        /// </summary>
        public static readonly AttributeType STRING = new AttributeType("STRING");
        /// <summary>
        /// Constant STRING_LIST for AttributeType
        /// </summary>
        public static readonly AttributeType STRING_LIST = new AttributeType("STRING_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeType FindValue(string value)
        {
            return FindValue<AttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfirmationState.
    /// </summary>
    public class ConfirmationState : ConstantClass
    {

        /// <summary>
        /// Constant CONFIRM for ConfirmationState
        /// </summary>
        public static readonly ConfirmationState CONFIRM = new ConfirmationState("CONFIRM");
        /// <summary>
        /// Constant DENY for ConfirmationState
        /// </summary>
        public static readonly ConfirmationState DENY = new ConfirmationState("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfirmationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfirmationState FindValue(string value)
        {
            return FindValue<ConfirmationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfirmationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationRole.
    /// </summary>
    public class ConversationRole : ConstantClass
    {

        /// <summary>
        /// Constant Assistant for ConversationRole
        /// </summary>
        public static readonly ConversationRole Assistant = new ConversationRole("assistant");
        /// <summary>
        /// Constant User for ConversationRole
        /// </summary>
        public static readonly ConversationRole User = new ConversationRole("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationRole FindValue(string value)
        {
            return FindValue<ConversationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CreationMode.
    /// </summary>
    public class CreationMode : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for CreationMode
        /// </summary>
        public static readonly CreationMode DEFAULT = new CreationMode("DEFAULT");
        /// <summary>
        /// Constant OVERRIDDEN for CreationMode
        /// </summary>
        public static readonly CreationMode OVERRIDDEN = new CreationMode("OVERRIDDEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreationMode FindValue(string value)
        {
            return FindValue<CreationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomControlMethod.
    /// </summary>
    public class CustomControlMethod : ConstantClass
    {

        /// <summary>
        /// Constant RETURN_CONTROL for CustomControlMethod
        /// </summary>
        public static readonly CustomControlMethod RETURN_CONTROL = new CustomControlMethod("RETURN_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomControlMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomControlMethod FindValue(string value)
        {
            return FindValue<CustomControlMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomControlMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionType.
    /// </summary>
    public class ExecutionType : ConstantClass
    {

        /// <summary>
        /// Constant LAMBDA for ExecutionType
        /// </summary>
        public static readonly ExecutionType LAMBDA = new ExecutionType("LAMBDA");
        /// <summary>
        /// Constant RETURN_CONTROL for ExecutionType
        /// </summary>
        public static readonly ExecutionType RETURN_CONTROL = new ExecutionType("RETURN_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionType FindValue(string value)
        {
            return FindValue<ExecutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalSourceType.
    /// </summary>
    public class ExternalSourceType : ConstantClass
    {

        /// <summary>
        /// Constant BYTE_CONTENT for ExternalSourceType
        /// </summary>
        public static readonly ExternalSourceType BYTE_CONTENT = new ExternalSourceType("BYTE_CONTENT");
        /// <summary>
        /// Constant S3 for ExternalSourceType
        /// </summary>
        public static readonly ExternalSourceType S3 = new ExternalSourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalSourceType FindValue(string value)
        {
            return FindValue<ExternalSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSourceType.
    /// </summary>
    public class FileSourceType : ConstantClass
    {

        /// <summary>
        /// Constant BYTE_CONTENT for FileSourceType
        /// </summary>
        public static readonly FileSourceType BYTE_CONTENT = new FileSourceType("BYTE_CONTENT");
        /// <summary>
        /// Constant S3 for FileSourceType
        /// </summary>
        public static readonly FileSourceType S3 = new FileSourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSourceType FindValue(string value)
        {
            return FindValue<FileSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileUseCase.
    /// </summary>
    public class FileUseCase : ConstantClass
    {

        /// <summary>
        /// Constant CHAT for FileUseCase
        /// </summary>
        public static readonly FileUseCase CHAT = new FileUseCase("CHAT");
        /// <summary>
        /// Constant CODE_INTERPRETER for FileUseCase
        /// </summary>
        public static readonly FileUseCase CODE_INTERPRETER = new FileUseCase("CODE_INTERPRETER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileUseCase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileUseCase FindValue(string value)
        {
            return FindValue<FileUseCase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileUseCase(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowCompletionReason.
    /// </summary>
    public class FlowCompletionReason : ConstantClass
    {

        /// <summary>
        /// Constant INPUT_REQUIRED for FlowCompletionReason
        /// </summary>
        public static readonly FlowCompletionReason INPUT_REQUIRED = new FlowCompletionReason("INPUT_REQUIRED");
        /// <summary>
        /// Constant SUCCESS for FlowCompletionReason
        /// </summary>
        public static readonly FlowCompletionReason SUCCESS = new FlowCompletionReason("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowCompletionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowCompletionReason FindValue(string value)
        {
            return FindValue<FlowCompletionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowCompletionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowControlNodeType.
    /// </summary>
    public class FlowControlNodeType : ConstantClass
    {

        /// <summary>
        /// Constant Iterator for FlowControlNodeType
        /// </summary>
        public static readonly FlowControlNodeType Iterator = new FlowControlNodeType("Iterator");
        /// <summary>
        /// Constant Loop for FlowControlNodeType
        /// </summary>
        public static readonly FlowControlNodeType Loop = new FlowControlNodeType("Loop");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowControlNodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowControlNodeType FindValue(string value)
        {
            return FindValue<FlowControlNodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowControlNodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowErrorCode.
    /// </summary>
    public class FlowErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVER for FlowErrorCode
        /// </summary>
        public static readonly FlowErrorCode INTERNAL_SERVER = new FlowErrorCode("INTERNAL_SERVER");
        /// <summary>
        /// Constant NODE_EXECUTION_FAILED for FlowErrorCode
        /// </summary>
        public static readonly FlowErrorCode NODE_EXECUTION_FAILED = new FlowErrorCode("NODE_EXECUTION_FAILED");
        /// <summary>
        /// Constant VALIDATION for FlowErrorCode
        /// </summary>
        public static readonly FlowErrorCode VALIDATION = new FlowErrorCode("VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowErrorCode FindValue(string value)
        {
            return FindValue<FlowErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowExecutionErrorType.
    /// </summary>
    public class FlowExecutionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ExecutionTimedOut for FlowExecutionErrorType
        /// </summary>
        public static readonly FlowExecutionErrorType ExecutionTimedOut = new FlowExecutionErrorType("ExecutionTimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowExecutionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowExecutionErrorType FindValue(string value)
        {
            return FindValue<FlowExecutionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowExecutionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowExecutionEventType.
    /// </summary>
    public class FlowExecutionEventType : ConstantClass
    {

        /// <summary>
        /// Constant Flow for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType Flow = new FlowExecutionEventType("Flow");
        /// <summary>
        /// Constant Node for FlowExecutionEventType
        /// </summary>
        public static readonly FlowExecutionEventType Node = new FlowExecutionEventType("Node");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowExecutionEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowExecutionEventType FindValue(string value)
        {
            return FindValue<FlowExecutionEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowExecutionEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowExecutionStatus.
    /// </summary>
    public class FlowExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Aborted for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus Aborted = new FlowExecutionStatus("Aborted");
        /// <summary>
        /// Constant Failed for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus Failed = new FlowExecutionStatus("Failed");
        /// <summary>
        /// Constant Running for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus Running = new FlowExecutionStatus("Running");
        /// <summary>
        /// Constant Succeeded for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus Succeeded = new FlowExecutionStatus("Succeeded");
        /// <summary>
        /// Constant TimedOut for FlowExecutionStatus
        /// </summary>
        public static readonly FlowExecutionStatus TimedOut = new FlowExecutionStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowExecutionStatus FindValue(string value)
        {
            return FindValue<FlowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowNodeInputCategory.
    /// </summary>
    public class FlowNodeInputCategory : ConstantClass
    {

        /// <summary>
        /// Constant ExitLoop for FlowNodeInputCategory
        /// </summary>
        public static readonly FlowNodeInputCategory ExitLoop = new FlowNodeInputCategory("ExitLoop");
        /// <summary>
        /// Constant LoopCondition for FlowNodeInputCategory
        /// </summary>
        public static readonly FlowNodeInputCategory LoopCondition = new FlowNodeInputCategory("LoopCondition");
        /// <summary>
        /// Constant ReturnValueToLoopStart for FlowNodeInputCategory
        /// </summary>
        public static readonly FlowNodeInputCategory ReturnValueToLoopStart = new FlowNodeInputCategory("ReturnValueToLoopStart");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowNodeInputCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowNodeInputCategory FindValue(string value)
        {
            return FindValue<FlowNodeInputCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowNodeInputCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowNodeIODataType.
    /// </summary>
    public class FlowNodeIODataType : ConstantClass
    {

        /// <summary>
        /// Constant Array for FlowNodeIODataType
        /// </summary>
        public static readonly FlowNodeIODataType Array = new FlowNodeIODataType("Array");
        /// <summary>
        /// Constant Boolean for FlowNodeIODataType
        /// </summary>
        public static readonly FlowNodeIODataType Boolean = new FlowNodeIODataType("Boolean");
        /// <summary>
        /// Constant Number for FlowNodeIODataType
        /// </summary>
        public static readonly FlowNodeIODataType Number = new FlowNodeIODataType("Number");
        /// <summary>
        /// Constant Object for FlowNodeIODataType
        /// </summary>
        public static readonly FlowNodeIODataType Object = new FlowNodeIODataType("Object");
        /// <summary>
        /// Constant String for FlowNodeIODataType
        /// </summary>
        public static readonly FlowNodeIODataType String = new FlowNodeIODataType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowNodeIODataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowNodeIODataType FindValue(string value)
        {
            return FindValue<FlowNodeIODataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowNodeIODataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedQueryType.
    /// </summary>
    public class GeneratedQueryType : ConstantClass
    {

        /// <summary>
        /// Constant REDSHIFT_SQL for GeneratedQueryType
        /// </summary>
        public static readonly GeneratedQueryType REDSHIFT_SQL = new GeneratedQueryType("REDSHIFT_SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedQueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedQueryType FindValue(string value)
        {
            return FindValue<GeneratedQueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedQueryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuadrailAction.
    /// </summary>
    public class GuadrailAction : ConstantClass
    {

        /// <summary>
        /// Constant INTERVENED for GuadrailAction
        /// </summary>
        public static readonly GuadrailAction INTERVENED = new GuadrailAction("INTERVENED");
        /// <summary>
        /// Constant NONE for GuadrailAction
        /// </summary>
        public static readonly GuadrailAction NONE = new GuadrailAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuadrailAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuadrailAction FindValue(string value)
        {
            return FindValue<GuadrailAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuadrailAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailAction.
    /// </summary>
    public class GuardrailAction : ConstantClass
    {

        /// <summary>
        /// Constant INTERVENED for GuardrailAction
        /// </summary>
        public static readonly GuardrailAction INTERVENED = new GuardrailAction("INTERVENED");
        /// <summary>
        /// Constant NONE for GuardrailAction
        /// </summary>
        public static readonly GuardrailAction NONE = new GuardrailAction("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailAction FindValue(string value)
        {
            return FindValue<GuardrailAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentFilterConfidence.
    /// </summary>
    public class GuardrailContentFilterConfidence : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence HIGH = new GuardrailContentFilterConfidence("HIGH");
        /// <summary>
        /// Constant LOW for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence LOW = new GuardrailContentFilterConfidence("LOW");
        /// <summary>
        /// Constant MEDIUM for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence MEDIUM = new GuardrailContentFilterConfidence("MEDIUM");
        /// <summary>
        /// Constant NONE for GuardrailContentFilterConfidence
        /// </summary>
        public static readonly GuardrailContentFilterConfidence NONE = new GuardrailContentFilterConfidence("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentFilterConfidence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentFilterConfidence FindValue(string value)
        {
            return FindValue<GuardrailContentFilterConfidence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentFilterConfidence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentFilterType.
    /// </summary>
    public class GuardrailContentFilterType : ConstantClass
    {

        /// <summary>
        /// Constant HATE for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType HATE = new GuardrailContentFilterType("HATE");
        /// <summary>
        /// Constant INSULTS for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType INSULTS = new GuardrailContentFilterType("INSULTS");
        /// <summary>
        /// Constant MISCONDUCT for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType MISCONDUCT = new GuardrailContentFilterType("MISCONDUCT");
        /// <summary>
        /// Constant PROMPT_ATTACK for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType PROMPT_ATTACK = new GuardrailContentFilterType("PROMPT_ATTACK");
        /// <summary>
        /// Constant SEXUAL for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType SEXUAL = new GuardrailContentFilterType("SEXUAL");
        /// <summary>
        /// Constant VIOLENCE for GuardrailContentFilterType
        /// </summary>
        public static readonly GuardrailContentFilterType VIOLENCE = new GuardrailContentFilterType("VIOLENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentFilterType FindValue(string value)
        {
            return FindValue<GuardrailContentFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailContentPolicyAction.
    /// </summary>
    public class GuardrailContentPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailContentPolicyAction
        /// </summary>
        public static readonly GuardrailContentPolicyAction BLOCKED = new GuardrailContentPolicyAction("BLOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContentPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContentPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailContentPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContentPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailManagedWordType.
    /// </summary>
    public class GuardrailManagedWordType : ConstantClass
    {

        /// <summary>
        /// Constant PROFANITY for GuardrailManagedWordType
        /// </summary>
        public static readonly GuardrailManagedWordType PROFANITY = new GuardrailManagedWordType("PROFANITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailManagedWordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailManagedWordType FindValue(string value)
        {
            return FindValue<GuardrailManagedWordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailManagedWordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailPiiEntityType.
    /// </summary>
    public class GuardrailPiiEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType ADDRESS = new GuardrailPiiEntityType("ADDRESS");
        /// <summary>
        /// Constant AGE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AGE = new GuardrailPiiEntityType("AGE");
        /// <summary>
        /// Constant AWS_ACCESS_KEY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AWS_ACCESS_KEY = new GuardrailPiiEntityType("AWS_ACCESS_KEY");
        /// <summary>
        /// Constant AWS_SECRET_KEY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType AWS_SECRET_KEY = new GuardrailPiiEntityType("AWS_SECRET_KEY");
        /// <summary>
        /// Constant CA_HEALTH_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CA_HEALTH_NUMBER = new GuardrailPiiEntityType("CA_HEALTH_NUMBER");
        /// <summary>
        /// Constant CA_SOCIAL_INSURANCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CA_SOCIAL_INSURANCE_NUMBER = new GuardrailPiiEntityType("CA_SOCIAL_INSURANCE_NUMBER");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_CVV for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_CVV = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_CVV");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_EXPIRY for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_EXPIRY = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_EXPIRY");
        /// <summary>
        /// Constant CREDIT_DEBIT_CARD_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType CREDIT_DEBIT_CARD_NUMBER = new GuardrailPiiEntityType("CREDIT_DEBIT_CARD_NUMBER");
        /// <summary>
        /// Constant DRIVER_ID for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType DRIVER_ID = new GuardrailPiiEntityType("DRIVER_ID");
        /// <summary>
        /// Constant EMAIL for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType EMAIL = new GuardrailPiiEntityType("EMAIL");
        /// <summary>
        /// Constant INTERNATIONAL_BANK_ACCOUNT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType INTERNATIONAL_BANK_ACCOUNT_NUMBER = new GuardrailPiiEntityType("INTERNATIONAL_BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant IP_ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType IP_ADDRESS = new GuardrailPiiEntityType("IP_ADDRESS");
        /// <summary>
        /// Constant LICENSE_PLATE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType LICENSE_PLATE = new GuardrailPiiEntityType("LICENSE_PLATE");
        /// <summary>
        /// Constant MAC_ADDRESS for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType MAC_ADDRESS = new GuardrailPiiEntityType("MAC_ADDRESS");
        /// <summary>
        /// Constant NAME for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType NAME = new GuardrailPiiEntityType("NAME");
        /// <summary>
        /// Constant PASSWORD for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PASSWORD = new GuardrailPiiEntityType("PASSWORD");
        /// <summary>
        /// Constant PHONE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PHONE = new GuardrailPiiEntityType("PHONE");
        /// <summary>
        /// Constant PIN for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType PIN = new GuardrailPiiEntityType("PIN");
        /// <summary>
        /// Constant SWIFT_CODE for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType SWIFT_CODE = new GuardrailPiiEntityType("SWIFT_CODE");
        /// <summary>
        /// Constant UK_NATIONAL_HEALTH_SERVICE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_NATIONAL_HEALTH_SERVICE_NUMBER = new GuardrailPiiEntityType("UK_NATIONAL_HEALTH_SERVICE_NUMBER");
        /// <summary>
        /// Constant UK_NATIONAL_INSURANCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_NATIONAL_INSURANCE_NUMBER = new GuardrailPiiEntityType("UK_NATIONAL_INSURANCE_NUMBER");
        /// <summary>
        /// Constant UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER = new GuardrailPiiEntityType("UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER");
        /// <summary>
        /// Constant URL for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType URL = new GuardrailPiiEntityType("URL");
        /// <summary>
        /// Constant US_BANK_ACCOUNT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_BANK_ACCOUNT_NUMBER = new GuardrailPiiEntityType("US_BANK_ACCOUNT_NUMBER");
        /// <summary>
        /// Constant US_BANK_ROUTING_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_BANK_ROUTING_NUMBER = new GuardrailPiiEntityType("US_BANK_ROUTING_NUMBER");
        /// <summary>
        /// Constant US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER = new GuardrailPiiEntityType("US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER");
        /// <summary>
        /// Constant US_PASSPORT_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_PASSPORT_NUMBER = new GuardrailPiiEntityType("US_PASSPORT_NUMBER");
        /// <summary>
        /// Constant US_SOCIAL_SECURITY_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType US_SOCIAL_SECURITY_NUMBER = new GuardrailPiiEntityType("US_SOCIAL_SECURITY_NUMBER");
        /// <summary>
        /// Constant USERNAME for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType USERNAME = new GuardrailPiiEntityType("USERNAME");
        /// <summary>
        /// Constant VEHICLE_IDENTIFICATION_NUMBER for GuardrailPiiEntityType
        /// </summary>
        public static readonly GuardrailPiiEntityType VEHICLE_IDENTIFICATION_NUMBER = new GuardrailPiiEntityType("VEHICLE_IDENTIFICATION_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailPiiEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailPiiEntityType FindValue(string value)
        {
            return FindValue<GuardrailPiiEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailPiiEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailSensitiveInformationPolicyAction.
    /// </summary>
    public class GuardrailSensitiveInformationPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMIZED for GuardrailSensitiveInformationPolicyAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationPolicyAction ANONYMIZED = new GuardrailSensitiveInformationPolicyAction("ANONYMIZED");
        /// <summary>
        /// Constant BLOCKED for GuardrailSensitiveInformationPolicyAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationPolicyAction BLOCKED = new GuardrailSensitiveInformationPolicyAction("BLOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailSensitiveInformationPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailSensitiveInformationPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailSensitiveInformationPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailSensitiveInformationPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailTopicPolicyAction.
    /// </summary>
    public class GuardrailTopicPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailTopicPolicyAction
        /// </summary>
        public static readonly GuardrailTopicPolicyAction BLOCKED = new GuardrailTopicPolicyAction("BLOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailTopicPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailTopicPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailTopicPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailTopicPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailTopicType.
    /// </summary>
    public class GuardrailTopicType : ConstantClass
    {

        /// <summary>
        /// Constant DENY for GuardrailTopicType
        /// </summary>
        public static readonly GuardrailTopicType DENY = new GuardrailTopicType("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailTopicType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailTopicType FindValue(string value)
        {
            return FindValue<GuardrailTopicType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailTopicType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailWordPolicyAction.
    /// </summary>
    public class GuardrailWordPolicyAction : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED for GuardrailWordPolicyAction
        /// </summary>
        public static readonly GuardrailWordPolicyAction BLOCKED = new GuardrailWordPolicyAction("BLOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailWordPolicyAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailWordPolicyAction FindValue(string value)
        {
            return FindValue<GuardrailWordPolicyAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailWordPolicyAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFormat.
    /// </summary>
    public class ImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Gif for ImageFormat
        /// </summary>
        public static readonly ImageFormat Gif = new ImageFormat("gif");
        /// <summary>
        /// Constant Jpeg for ImageFormat
        /// </summary>
        public static readonly ImageFormat Jpeg = new ImageFormat("jpeg");
        /// <summary>
        /// Constant Png for ImageFormat
        /// </summary>
        public static readonly ImageFormat Png = new ImageFormat("png");
        /// <summary>
        /// Constant Webp for ImageFormat
        /// </summary>
        public static readonly ImageFormat Webp = new ImageFormat("webp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFormat FindValue(string value)
        {
            return FindValue<ImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageInputFormat.
    /// </summary>
    public class ImageInputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Gif for ImageInputFormat
        /// </summary>
        public static readonly ImageInputFormat Gif = new ImageInputFormat("gif");
        /// <summary>
        /// Constant Jpeg for ImageInputFormat
        /// </summary>
        public static readonly ImageInputFormat Jpeg = new ImageInputFormat("jpeg");
        /// <summary>
        /// Constant Png for ImageInputFormat
        /// </summary>
        public static readonly ImageInputFormat Png = new ImageInputFormat("png");
        /// <summary>
        /// Constant Webp for ImageInputFormat
        /// </summary>
        public static readonly ImageInputFormat Webp = new ImageInputFormat("webp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageInputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageInputFormat FindValue(string value)
        {
            return FindValue<ImageInputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageInputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputQueryType.
    /// </summary>
    public class InputQueryType : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for InputQueryType
        /// </summary>
        public static readonly InputQueryType TEXT = new InputQueryType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputQueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputQueryType FindValue(string value)
        {
            return FindValue<InputQueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputQueryType(string value)
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
        /// Constant ACTION_GROUP for InvocationType
        /// </summary>
        public static readonly InvocationType ACTION_GROUP = new InvocationType("ACTION_GROUP");
        /// <summary>
        /// Constant ACTION_GROUP_CODE_INTERPRETER for InvocationType
        /// </summary>
        public static readonly InvocationType ACTION_GROUP_CODE_INTERPRETER = new InvocationType("ACTION_GROUP_CODE_INTERPRETER");
        /// <summary>
        /// Constant AGENT_COLLABORATOR for InvocationType
        /// </summary>
        public static readonly InvocationType AGENT_COLLABORATOR = new InvocationType("AGENT_COLLABORATOR");
        /// <summary>
        /// Constant FINISH for InvocationType
        /// </summary>
        public static readonly InvocationType FINISH = new InvocationType("FINISH");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for InvocationType
        /// </summary>
        public static readonly InvocationType KNOWLEDGE_BASE = new InvocationType("KNOWLEDGE_BASE");

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
    /// Constants used for properties of type MemoryType.
    /// </summary>
    public class MemoryType : ConstantClass
    {

        /// <summary>
        /// Constant SESSION_SUMMARY for MemoryType
        /// </summary>
        public static readonly MemoryType SESSION_SUMMARY = new MemoryType("SESSION_SUMMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryType FindValue(string value)
        {
            return FindValue<MemoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeErrorCode.
    /// </summary>
    public class NodeErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_GATEWAY for NodeErrorCode
        /// </summary>
        public static readonly NodeErrorCode BAD_GATEWAY = new NodeErrorCode("BAD_GATEWAY");
        /// <summary>
        /// Constant DEPENDENCY_FAILED for NodeErrorCode
        /// </summary>
        public static readonly NodeErrorCode DEPENDENCY_FAILED = new NodeErrorCode("DEPENDENCY_FAILED");
        /// <summary>
        /// Constant INTERNAL_SERVER for NodeErrorCode
        /// </summary>
        public static readonly NodeErrorCode INTERNAL_SERVER = new NodeErrorCode("INTERNAL_SERVER");
        /// <summary>
        /// Constant VALIDATION for NodeErrorCode
        /// </summary>
        public static readonly NodeErrorCode VALIDATION = new NodeErrorCode("VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeErrorCode FindValue(string value)
        {
            return FindValue<NodeErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeType.
    /// </summary>
    public class NodeType : ConstantClass
    {

        /// <summary>
        /// Constant ConditionNode for NodeType
        /// </summary>
        public static readonly NodeType ConditionNode = new NodeType("ConditionNode");
        /// <summary>
        /// Constant FlowInputNode for NodeType
        /// </summary>
        public static readonly NodeType FlowInputNode = new NodeType("FlowInputNode");
        /// <summary>
        /// Constant FlowOutputNode for NodeType
        /// </summary>
        public static readonly NodeType FlowOutputNode = new NodeType("FlowOutputNode");
        /// <summary>
        /// Constant KnowledgeBaseNode for NodeType
        /// </summary>
        public static readonly NodeType KnowledgeBaseNode = new NodeType("KnowledgeBaseNode");
        /// <summary>
        /// Constant LambdaFunctionNode for NodeType
        /// </summary>
        public static readonly NodeType LambdaFunctionNode = new NodeType("LambdaFunctionNode");
        /// <summary>
        /// Constant LexNode for NodeType
        /// </summary>
        public static readonly NodeType LexNode = new NodeType("LexNode");
        /// <summary>
        /// Constant PromptNode for NodeType
        /// </summary>
        public static readonly NodeType PromptNode = new NodeType("PromptNode");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeType FindValue(string value)
        {
            return FindValue<NodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrchestrationType.
    /// </summary>
    public class OrchestrationType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_ORCHESTRATION for OrchestrationType
        /// </summary>
        public static readonly OrchestrationType CUSTOM_ORCHESTRATION = new OrchestrationType("CUSTOM_ORCHESTRATION");
        /// <summary>
        /// Constant DEFAULT for OrchestrationType
        /// </summary>
        public static readonly OrchestrationType DEFAULT = new OrchestrationType("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrchestrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrchestrationType FindValue(string value)
        {
            return FindValue<OrchestrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrchestrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant Array for ParameterType
        /// </summary>
        public static readonly ParameterType Array = new ParameterType("array");
        /// <summary>
        /// Constant Boolean for ParameterType
        /// </summary>
        public static readonly ParameterType Boolean = new ParameterType("boolean");
        /// <summary>
        /// Constant Integer for ParameterType
        /// </summary>
        public static readonly ParameterType Integer = new ParameterType("integer");
        /// <summary>
        /// Constant Number for ParameterType
        /// </summary>
        public static readonly ParameterType Number = new ParameterType("number");
        /// <summary>
        /// Constant String for ParameterType
        /// </summary>
        public static readonly ParameterType String = new ParameterType("string");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PayloadType.
    /// </summary>
    public class PayloadType : ConstantClass
    {

        /// <summary>
        /// Constant RETURN_CONTROL for PayloadType
        /// </summary>
        public static readonly PayloadType RETURN_CONTROL = new PayloadType("RETURN_CONTROL");
        /// <summary>
        /// Constant TEXT for PayloadType
        /// </summary>
        public static readonly PayloadType TEXT = new PayloadType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PayloadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PayloadType FindValue(string value)
        {
            return FindValue<PayloadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PayloadType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PerformanceConfigLatency.
    /// </summary>
    public class PerformanceConfigLatency : ConstantClass
    {

        /// <summary>
        /// Constant Optimized for PerformanceConfigLatency
        /// </summary>
        public static readonly PerformanceConfigLatency Optimized = new PerformanceConfigLatency("optimized");
        /// <summary>
        /// Constant Standard for PerformanceConfigLatency
        /// </summary>
        public static readonly PerformanceConfigLatency Standard = new PerformanceConfigLatency("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PerformanceConfigLatency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PerformanceConfigLatency FindValue(string value)
        {
            return FindValue<PerformanceConfigLatency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PerformanceConfigLatency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PromptState.
    /// </summary>
    public class PromptState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PromptState
        /// </summary>
        public static readonly PromptState DISABLED = new PromptState("DISABLED");
        /// <summary>
        /// Constant ENABLED for PromptState
        /// </summary>
        public static readonly PromptState ENABLED = new PromptState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromptState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromptState FindValue(string value)
        {
            return FindValue<PromptState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromptState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PromptType.
    /// </summary>
    public class PromptType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE_RESPONSE_GENERATION for PromptType
        /// </summary>
        public static readonly PromptType KNOWLEDGE_BASE_RESPONSE_GENERATION = new PromptType("KNOWLEDGE_BASE_RESPONSE_GENERATION");
        /// <summary>
        /// Constant ORCHESTRATION for PromptType
        /// </summary>
        public static readonly PromptType ORCHESTRATION = new PromptType("ORCHESTRATION");
        /// <summary>
        /// Constant POST_PROCESSING for PromptType
        /// </summary>
        public static readonly PromptType POST_PROCESSING = new PromptType("POST_PROCESSING");
        /// <summary>
        /// Constant PRE_PROCESSING for PromptType
        /// </summary>
        public static readonly PromptType PRE_PROCESSING = new PromptType("PRE_PROCESSING");
        /// <summary>
        /// Constant ROUTING_CLASSIFIER for PromptType
        /// </summary>
        public static readonly PromptType ROUTING_CLASSIFIER = new PromptType("ROUTING_CLASSIFIER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromptType FindValue(string value)
        {
            return FindValue<PromptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryTransformationMode.
    /// </summary>
    public class QueryTransformationMode : ConstantClass
    {

        /// <summary>
        /// Constant TEXT_TO_SQL for QueryTransformationMode
        /// </summary>
        public static readonly QueryTransformationMode TEXT_TO_SQL = new QueryTransformationMode("TEXT_TO_SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryTransformationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryTransformationMode FindValue(string value)
        {
            return FindValue<QueryTransformationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryTransformationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryTransformationType.
    /// </summary>
    public class QueryTransformationType : ConstantClass
    {

        /// <summary>
        /// Constant QUERY_DECOMPOSITION for QueryTransformationType
        /// </summary>
        public static readonly QueryTransformationType QUERY_DECOMPOSITION = new QueryTransformationType("QUERY_DECOMPOSITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryTransformationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryTransformationType FindValue(string value)
        {
            return FindValue<QueryTransformationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryTransformationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelayConversationHistory.
    /// </summary>
    public class RelayConversationHistory : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RelayConversationHistory
        /// </summary>
        public static readonly RelayConversationHistory DISABLED = new RelayConversationHistory("DISABLED");
        /// <summary>
        /// Constant TO_COLLABORATOR for RelayConversationHistory
        /// </summary>
        public static readonly RelayConversationHistory TO_COLLABORATOR = new RelayConversationHistory("TO_COLLABORATOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelayConversationHistory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelayConversationHistory FindValue(string value)
        {
            return FindValue<RelayConversationHistory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelayConversationHistory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequireConfirmation.
    /// </summary>
    public class RequireConfirmation : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RequireConfirmation
        /// </summary>
        public static readonly RequireConfirmation DISABLED = new RequireConfirmation("DISABLED");
        /// <summary>
        /// Constant ENABLED for RequireConfirmation
        /// </summary>
        public static readonly RequireConfirmation ENABLED = new RequireConfirmation("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequireConfirmation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequireConfirmation FindValue(string value)
        {
            return FindValue<RequireConfirmation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequireConfirmation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RerankDocumentType.
    /// </summary>
    public class RerankDocumentType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for RerankDocumentType
        /// </summary>
        public static readonly RerankDocumentType JSON = new RerankDocumentType("JSON");
        /// <summary>
        /// Constant TEXT for RerankDocumentType
        /// </summary>
        public static readonly RerankDocumentType TEXT = new RerankDocumentType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RerankDocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RerankDocumentType FindValue(string value)
        {
            return FindValue<RerankDocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RerankDocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RerankingConfigurationType.
    /// </summary>
    public class RerankingConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant BEDROCK_RERANKING_MODEL for RerankingConfigurationType
        /// </summary>
        public static readonly RerankingConfigurationType BEDROCK_RERANKING_MODEL = new RerankingConfigurationType("BEDROCK_RERANKING_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RerankingConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RerankingConfigurationType FindValue(string value)
        {
            return FindValue<RerankingConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RerankingConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RerankingMetadataSelectionMode.
    /// </summary>
    public class RerankingMetadataSelectionMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RerankingMetadataSelectionMode
        /// </summary>
        public static readonly RerankingMetadataSelectionMode ALL = new RerankingMetadataSelectionMode("ALL");
        /// <summary>
        /// Constant SELECTIVE for RerankingMetadataSelectionMode
        /// </summary>
        public static readonly RerankingMetadataSelectionMode SELECTIVE = new RerankingMetadataSelectionMode("SELECTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RerankingMetadataSelectionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RerankingMetadataSelectionMode FindValue(string value)
        {
            return FindValue<RerankingMetadataSelectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RerankingMetadataSelectionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RerankQueryContentType.
    /// </summary>
    public class RerankQueryContentType : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for RerankQueryContentType
        /// </summary>
        public static readonly RerankQueryContentType TEXT = new RerankQueryContentType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RerankQueryContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RerankQueryContentType FindValue(string value)
        {
            return FindValue<RerankQueryContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RerankQueryContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RerankSourceType.
    /// </summary>
    public class RerankSourceType : ConstantClass
    {

        /// <summary>
        /// Constant INLINE for RerankSourceType
        /// </summary>
        public static readonly RerankSourceType INLINE = new RerankSourceType("INLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RerankSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RerankSourceType FindValue(string value)
        {
            return FindValue<RerankSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RerankSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseState.
    /// </summary>
    public class ResponseState : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for ResponseState
        /// </summary>
        public static readonly ResponseState FAILURE = new ResponseState("FAILURE");
        /// <summary>
        /// Constant REPROMPT for ResponseState
        /// </summary>
        public static readonly ResponseState REPROMPT = new ResponseState("REPROMPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseState FindValue(string value)
        {
            return FindValue<ResponseState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrievalResultContentColumnType.
    /// </summary>
    public class RetrievalResultContentColumnType : ConstantClass
    {

        /// <summary>
        /// Constant BLOB for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType BLOB = new RetrievalResultContentColumnType("BLOB");
        /// <summary>
        /// Constant BOOLEAN for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType BOOLEAN = new RetrievalResultContentColumnType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType DOUBLE = new RetrievalResultContentColumnType("DOUBLE");
        /// <summary>
        /// Constant LONG for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType LONG = new RetrievalResultContentColumnType("LONG");
        /// <summary>
        /// Constant NULL for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType NULL = new RetrievalResultContentColumnType("NULL");
        /// <summary>
        /// Constant STRING for RetrievalResultContentColumnType
        /// </summary>
        public static readonly RetrievalResultContentColumnType STRING = new RetrievalResultContentColumnType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrievalResultContentColumnType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrievalResultContentColumnType FindValue(string value)
        {
            return FindValue<RetrievalResultContentColumnType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrievalResultContentColumnType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrievalResultContentType.
    /// </summary>
    public class RetrievalResultContentType : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE for RetrievalResultContentType
        /// </summary>
        public static readonly RetrievalResultContentType IMAGE = new RetrievalResultContentType("IMAGE");
        /// <summary>
        /// Constant ROW for RetrievalResultContentType
        /// </summary>
        public static readonly RetrievalResultContentType ROW = new RetrievalResultContentType("ROW");
        /// <summary>
        /// Constant TEXT for RetrievalResultContentType
        /// </summary>
        public static readonly RetrievalResultContentType TEXT = new RetrievalResultContentType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrievalResultContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrievalResultContentType FindValue(string value)
        {
            return FindValue<RetrievalResultContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrievalResultContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrievalResultLocationType.
    /// </summary>
    public class RetrievalResultLocationType : ConstantClass
    {

        /// <summary>
        /// Constant CONFLUENCE for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType CONFLUENCE = new RetrievalResultLocationType("CONFLUENCE");
        /// <summary>
        /// Constant CUSTOM for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType CUSTOM = new RetrievalResultLocationType("CUSTOM");
        /// <summary>
        /// Constant KENDRA for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType KENDRA = new RetrievalResultLocationType("KENDRA");
        /// <summary>
        /// Constant S3 for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType S3 = new RetrievalResultLocationType("S3");
        /// <summary>
        /// Constant SALESFORCE for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType SALESFORCE = new RetrievalResultLocationType("SALESFORCE");
        /// <summary>
        /// Constant SHAREPOINT for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType SHAREPOINT = new RetrievalResultLocationType("SHAREPOINT");
        /// <summary>
        /// Constant SQL for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType SQL = new RetrievalResultLocationType("SQL");
        /// <summary>
        /// Constant WEB for RetrievalResultLocationType
        /// </summary>
        public static readonly RetrievalResultLocationType WEB = new RetrievalResultLocationType("WEB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrievalResultLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrievalResultLocationType FindValue(string value)
        {
            return FindValue<RetrievalResultLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrievalResultLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrieveAndGenerateType.
    /// </summary>
    public class RetrieveAndGenerateType : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL_SOURCES for RetrieveAndGenerateType
        /// </summary>
        public static readonly RetrieveAndGenerateType EXTERNAL_SOURCES = new RetrieveAndGenerateType("EXTERNAL_SOURCES");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for RetrieveAndGenerateType
        /// </summary>
        public static readonly RetrieveAndGenerateType KNOWLEDGE_BASE = new RetrieveAndGenerateType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrieveAndGenerateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrieveAndGenerateType FindValue(string value)
        {
            return FindValue<RetrieveAndGenerateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrieveAndGenerateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchType.
    /// </summary>
    public class SearchType : ConstantClass
    {

        /// <summary>
        /// Constant HYBRID for SearchType
        /// </summary>
        public static readonly SearchType HYBRID = new SearchType("HYBRID");
        /// <summary>
        /// Constant SEMANTIC for SearchType
        /// </summary>
        public static readonly SearchType SEMANTIC = new SearchType("SEMANTIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchType FindValue(string value)
        {
            return FindValue<SearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SessionStatus
        /// </summary>
        public static readonly SessionStatus ACTIVE = new SessionStatus("ACTIVE");
        /// <summary>
        /// Constant ENDED for SessionStatus
        /// </summary>
        public static readonly SessionStatus ENDED = new SessionStatus("ENDED");
        /// <summary>
        /// Constant EXPIRED for SessionStatus
        /// </summary>
        public static readonly SessionStatus EXPIRED = new SessionStatus("EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Source.
    /// </summary>
    public class Source : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_GROUP for Source
        /// </summary>
        public static readonly Source ACTION_GROUP = new Source("ACTION_GROUP");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for Source
        /// </summary>
        public static readonly Source KNOWLEDGE_BASE = new Source("KNOWLEDGE_BASE");
        /// <summary>
        /// Constant PARSER for Source
        /// </summary>
        public static readonly Source PARSER = new Source("PARSER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Source FindValue(string value)
        {
            return FindValue<Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextToSqlConfigurationType.
    /// </summary>
    public class TextToSqlConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for TextToSqlConfigurationType
        /// </summary>
        public static readonly TextToSqlConfigurationType KNOWLEDGE_BASE = new TextToSqlConfigurationType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextToSqlConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextToSqlConfigurationType FindValue(string value)
        {
            return FindValue<TextToSqlConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextToSqlConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_GROUP for Type
        /// </summary>
        public static readonly Type ACTION_GROUP = new Type("ACTION_GROUP");
        /// <summary>
        /// Constant AGENT_COLLABORATOR for Type
        /// </summary>
        public static readonly Type AGENT_COLLABORATOR = new Type("AGENT_COLLABORATOR");
        /// <summary>
        /// Constant ASK_USER for Type
        /// </summary>
        public static readonly Type ASK_USER = new Type("ASK_USER");
        /// <summary>
        /// Constant FINISH for Type
        /// </summary>
        public static readonly Type FINISH = new Type("FINISH");
        /// <summary>
        /// Constant KNOWLEDGE_BASE for Type
        /// </summary>
        public static readonly Type KNOWLEDGE_BASE = new Type("KNOWLEDGE_BASE");
        /// <summary>
        /// Constant REPROMPT for Type
        /// </summary>
        public static readonly Type REPROMPT = new Type("REPROMPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VectorSearchRerankingConfigurationType.
    /// </summary>
    public class VectorSearchRerankingConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant BEDROCK_RERANKING_MODEL for VectorSearchRerankingConfigurationType
        /// </summary>
        public static readonly VectorSearchRerankingConfigurationType BEDROCK_RERANKING_MODEL = new VectorSearchRerankingConfigurationType("BEDROCK_RERANKING_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VectorSearchRerankingConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VectorSearchRerankingConfigurationType FindValue(string value)
        {
            return FindValue<VectorSearchRerankingConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VectorSearchRerankingConfigurationType(string value)
        {
            return FindValue(value);
        }
    }

}
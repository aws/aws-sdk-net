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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgentCore
{

    /// <summary>
    /// Constants used for properties of type AutomationStreamStatus.
    /// </summary>
    public class AutomationStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutomationStreamStatus
        /// </summary>
        public static readonly AutomationStreamStatus DISABLED = new AutomationStreamStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutomationStreamStatus
        /// </summary>
        public static readonly AutomationStreamStatus ENABLED = new AutomationStreamStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationStreamStatus FindValue(string value)
        {
            return FindValue<AutomationStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserActionStatus.
    /// </summary>
    public class BrowserActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BrowserActionStatus
        /// </summary>
        public static readonly BrowserActionStatus FAILED = new BrowserActionStatus("FAILED");
        /// <summary>
        /// Constant SUCCESS for BrowserActionStatus
        /// </summary>
        public static readonly BrowserActionStatus SUCCESS = new BrowserActionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserActionStatus FindValue(string value)
        {
            return FindValue<BrowserActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserEnterprisePolicyType.
    /// </summary>
    public class BrowserEnterprisePolicyType : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED for BrowserEnterprisePolicyType
        /// </summary>
        public static readonly BrowserEnterprisePolicyType MANAGED = new BrowserEnterprisePolicyType("MANAGED");
        /// <summary>
        /// Constant RECOMMENDED for BrowserEnterprisePolicyType
        /// </summary>
        public static readonly BrowserEnterprisePolicyType RECOMMENDED = new BrowserEnterprisePolicyType("RECOMMENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserEnterprisePolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserEnterprisePolicyType FindValue(string value)
        {
            return FindValue<BrowserEnterprisePolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserEnterprisePolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserSessionStatus.
    /// </summary>
    public class BrowserSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant READY for BrowserSessionStatus
        /// </summary>
        public static readonly BrowserSessionStatus READY = new BrowserSessionStatus("READY");
        /// <summary>
        /// Constant TERMINATED for BrowserSessionStatus
        /// </summary>
        public static readonly BrowserSessionStatus TERMINATED = new BrowserSessionStatus("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserSessionStatus FindValue(string value)
        {
            return FindValue<BrowserSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeInterpreterSessionStatus.
    /// </summary>
    public class CodeInterpreterSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant READY for CodeInterpreterSessionStatus
        /// </summary>
        public static readonly CodeInterpreterSessionStatus READY = new CodeInterpreterSessionStatus("READY");
        /// <summary>
        /// Constant TERMINATED for CodeInterpreterSessionStatus
        /// </summary>
        public static readonly CodeInterpreterSessionStatus TERMINATED = new CodeInterpreterSessionStatus("TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeInterpreterSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeInterpreterSessionStatus FindValue(string value)
        {
            return FindValue<CodeInterpreterSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeInterpreterSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandExecutionStatus.
    /// </summary>
    public class CommandExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CommandExecutionStatus
        /// </summary>
        public static readonly CommandExecutionStatus COMPLETED = new CommandExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant TIMED_OUT for CommandExecutionStatus
        /// </summary>
        public static readonly CommandExecutionStatus TIMED_OUT = new CommandExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandExecutionStatus FindValue(string value)
        {
            return FindValue<CommandExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentBlockType.
    /// </summary>
    public class ContentBlockType : ConstantClass
    {

        /// <summary>
        /// Constant Image for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Image = new ContentBlockType("image");
        /// <summary>
        /// Constant Resource for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Resource = new ContentBlockType("resource");
        /// <summary>
        /// Constant Resource_link for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Resource_link = new ContentBlockType("resource_link");
        /// <summary>
        /// Constant Text for ContentBlockType
        /// </summary>
        public static readonly ContentBlockType Text = new ContentBlockType("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentBlockType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentBlockType FindValue(string value)
        {
            return FindValue<ContentBlockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentBlockType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescriptorType.
    /// </summary>
    public class DescriptorType : ConstantClass
    {

        /// <summary>
        /// Constant A2A for DescriptorType
        /// </summary>
        public static readonly DescriptorType A2A = new DescriptorType("A2A");
        /// <summary>
        /// Constant AGENT_SKILLS for DescriptorType
        /// </summary>
        public static readonly DescriptorType AGENT_SKILLS = new DescriptorType("AGENT_SKILLS");
        /// <summary>
        /// Constant CUSTOM for DescriptorType
        /// </summary>
        public static readonly DescriptorType CUSTOM = new DescriptorType("CUSTOM");
        /// <summary>
        /// Constant MCP for DescriptorType
        /// </summary>
        public static readonly DescriptorType MCP = new DescriptorType("MCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescriptorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescriptorType FindValue(string value)
        {
            return FindValue<DescriptorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescriptorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventFilterCondition.
    /// </summary>
    public class EventFilterCondition : ConstantClass
    {

        /// <summary>
        /// Constant HAS_EVENTS for EventFilterCondition
        /// </summary>
        public static readonly EventFilterCondition HAS_EVENTS = new EventFilterCondition("HAS_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventFilterCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventFilterCondition FindValue(string value)
        {
            return FindValue<EventFilterCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventFilterCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExtractionJobStatus.
    /// </summary>
    public class ExtractionJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ExtractionJobStatus
        /// </summary>
        public static readonly ExtractionJobStatus FAILED = new ExtractionJobStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExtractionJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtractionJobStatus FindValue(string value)
        {
            return FindValue<ExtractionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtractionJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarnessConversationRole.
    /// </summary>
    public class HarnessConversationRole : ConstantClass
    {

        /// <summary>
        /// Constant Assistant for HarnessConversationRole
        /// </summary>
        public static readonly HarnessConversationRole Assistant = new HarnessConversationRole("assistant");
        /// <summary>
        /// Constant User for HarnessConversationRole
        /// </summary>
        public static readonly HarnessConversationRole User = new HarnessConversationRole("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarnessConversationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessConversationRole FindValue(string value)
        {
            return FindValue<HarnessConversationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessConversationRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarnessStopReason.
    /// </summary>
    public class HarnessStopReason : ConstantClass
    {

        /// <summary>
        /// Constant Content_filtered for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Content_filtered = new HarnessStopReason("content_filtered");
        /// <summary>
        /// Constant End_turn for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason End_turn = new HarnessStopReason("end_turn");
        /// <summary>
        /// Constant Interrupted for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Interrupted = new HarnessStopReason("interrupted");
        /// <summary>
        /// Constant Malformed_model_output for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Malformed_model_output = new HarnessStopReason("malformed_model_output");
        /// <summary>
        /// Constant Malformed_tool_use for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Malformed_tool_use = new HarnessStopReason("malformed_tool_use");
        /// <summary>
        /// Constant Max_iterations_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_iterations_exceeded = new HarnessStopReason("max_iterations_exceeded");
        /// <summary>
        /// Constant Max_output_tokens_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_output_tokens_exceeded = new HarnessStopReason("max_output_tokens_exceeded");
        /// <summary>
        /// Constant Max_tokens for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Max_tokens = new HarnessStopReason("max_tokens");
        /// <summary>
        /// Constant Model_context_window_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Model_context_window_exceeded = new HarnessStopReason("model_context_window_exceeded");
        /// <summary>
        /// Constant Partial_turn for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Partial_turn = new HarnessStopReason("partial_turn");
        /// <summary>
        /// Constant Stop_sequence for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Stop_sequence = new HarnessStopReason("stop_sequence");
        /// <summary>
        /// Constant Timeout_exceeded for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Timeout_exceeded = new HarnessStopReason("timeout_exceeded");
        /// <summary>
        /// Constant Tool_result for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Tool_result = new HarnessStopReason("tool_result");
        /// <summary>
        /// Constant Tool_use for HarnessStopReason
        /// </summary>
        public static readonly HarnessStopReason Tool_use = new HarnessStopReason("tool_use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarnessStopReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessStopReason FindValue(string value)
        {
            return FindValue<HarnessStopReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessStopReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarnessToolType.
    /// </summary>
    public class HarnessToolType : ConstantClass
    {

        /// <summary>
        /// Constant Agentcore_browser for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_browser = new HarnessToolType("agentcore_browser");
        /// <summary>
        /// Constant Agentcore_code_interpreter for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_code_interpreter = new HarnessToolType("agentcore_code_interpreter");
        /// <summary>
        /// Constant Agentcore_gateway for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Agentcore_gateway = new HarnessToolType("agentcore_gateway");
        /// <summary>
        /// Constant Inline_function for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Inline_function = new HarnessToolType("inline_function");
        /// <summary>
        /// Constant Remote_mcp for HarnessToolType
        /// </summary>
        public static readonly HarnessToolType Remote_mcp = new HarnessToolType("remote_mcp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarnessToolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolType FindValue(string value)
        {
            return FindValue<HarnessToolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarnessToolUseStatus.
    /// </summary>
    public class HarnessToolUseStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for HarnessToolUseStatus
        /// </summary>
        public static readonly HarnessToolUseStatus Error = new HarnessToolUseStatus("error");
        /// <summary>
        /// Constant Success for HarnessToolUseStatus
        /// </summary>
        public static readonly HarnessToolUseStatus Success = new HarnessToolUseStatus("success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarnessToolUseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolUseStatus FindValue(string value)
        {
            return FindValue<HarnessToolUseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolUseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HarnessToolUseType.
    /// </summary>
    public class HarnessToolUseType : ConstantClass
    {

        /// <summary>
        /// Constant Mcp_tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Mcp_tool_use = new HarnessToolUseType("mcp_tool_use");
        /// <summary>
        /// Constant Server_tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Server_tool_use = new HarnessToolUseType("server_tool_use");
        /// <summary>
        /// Constant Tool_use for HarnessToolUseType
        /// </summary>
        public static readonly HarnessToolUseType Tool_use = new HarnessToolUseType("tool_use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HarnessToolUseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HarnessToolUseType FindValue(string value)
        {
            return FindValue<HarnessToolUseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HarnessToolUseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageRuntime.
    /// </summary>
    public class LanguageRuntime : ConstantClass
    {

        /// <summary>
        /// Constant Deno for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Deno = new LanguageRuntime("deno");
        /// <summary>
        /// Constant Nodejs for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Nodejs = new LanguageRuntime("nodejs");
        /// <summary>
        /// Constant Python for LanguageRuntime
        /// </summary>
        public static readonly LanguageRuntime Python = new LanguageRuntime("python");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageRuntime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageRuntime FindValue(string value)
        {
            return FindValue<LanguageRuntime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageRuntime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemoryRecordStatus.
    /// </summary>
    public class MemoryRecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for MemoryRecordStatus
        /// </summary>
        public static readonly MemoryRecordStatus FAILED = new MemoryRecordStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for MemoryRecordStatus
        /// </summary>
        public static readonly MemoryRecordStatus SUCCEEDED = new MemoryRecordStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryRecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryRecordStatus FindValue(string value)
        {
            return FindValue<MemoryRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryRecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MouseButton.
    /// </summary>
    public class MouseButton : ConstantClass
    {

        /// <summary>
        /// Constant LEFT for MouseButton
        /// </summary>
        public static readonly MouseButton LEFT = new MouseButton("LEFT");
        /// <summary>
        /// Constant MIDDLE for MouseButton
        /// </summary>
        public static readonly MouseButton MIDDLE = new MouseButton("MIDDLE");
        /// <summary>
        /// Constant RIGHT for MouseButton
        /// </summary>
        public static readonly MouseButton RIGHT = new MouseButton("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MouseButton(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MouseButton FindValue(string value)
        {
            return FindValue<MouseButton>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MouseButton(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Oauth2FlowType.
    /// </summary>
    public class Oauth2FlowType : ConstantClass
    {

        /// <summary>
        /// Constant M2M for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType M2M = new Oauth2FlowType("M2M");
        /// <summary>
        /// Constant USER_FEDERATION for Oauth2FlowType
        /// </summary>
        public static readonly Oauth2FlowType USER_FEDERATION = new Oauth2FlowType("USER_FEDERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Oauth2FlowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Oauth2FlowType FindValue(string value)
        {
            return FindValue<Oauth2FlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Oauth2FlowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OAuthGrantType.
    /// </summary>
    public class OAuthGrantType : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZATION_CODE for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType AUTHORIZATION_CODE = new OAuthGrantType("AUTHORIZATION_CODE");
        /// <summary>
        /// Constant CLIENT_CREDENTIALS for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType CLIENT_CREDENTIALS = new OAuthGrantType("CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuthGrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthGrantType FindValue(string value)
        {
            return FindValue<OAuthGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthGrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatorType.
    /// </summary>
    public class OperatorType : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS_TO for OperatorType
        /// </summary>
        public static readonly OperatorType EQUALS_TO = new OperatorType("EQUALS_TO");
        /// <summary>
        /// Constant EXISTS for OperatorType
        /// </summary>
        public static readonly OperatorType EXISTS = new OperatorType("EXISTS");
        /// <summary>
        /// Constant NOT_EXISTS for OperatorType
        /// </summary>
        public static readonly OperatorType NOT_EXISTS = new OperatorType("NOT_EXISTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatorType FindValue(string value)
        {
            return FindValue<OperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProgrammingLanguage.
    /// </summary>
    public class ProgrammingLanguage : ConstantClass
    {

        /// <summary>
        /// Constant Javascript for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Javascript = new ProgrammingLanguage("javascript");
        /// <summary>
        /// Constant Python for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Python = new ProgrammingLanguage("python");
        /// <summary>
        /// Constant Typescript for ProgrammingLanguage
        /// </summary>
        public static readonly ProgrammingLanguage Typescript = new ProgrammingLanguage("typescript");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProgrammingLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProgrammingLanguage FindValue(string value)
        {
            return FindValue<ProgrammingLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProgrammingLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordStatus.
    /// </summary>
    public class RegistryRecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus APPROVED = new RegistryRecordStatus("APPROVED");
        /// <summary>
        /// Constant DEPRECATED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DEPRECATED = new RegistryRecordStatus("DEPRECATED");
        /// <summary>
        /// Constant DRAFT for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DRAFT = new RegistryRecordStatus("DRAFT");
        /// <summary>
        /// Constant PENDING_APPROVAL for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus PENDING_APPROVAL = new RegistryRecordStatus("PENDING_APPROVAL");
        /// <summary>
        /// Constant REJECTED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus REJECTED = new RegistryRecordStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordStatus FindValue(string value)
        {
            return FindValue<RegistryRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceContentType.
    /// </summary>
    public class ResourceContentType : ConstantClass
    {

        /// <summary>
        /// Constant Blob for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType Blob = new ResourceContentType("blob");
        /// <summary>
        /// Constant Text for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType Text = new ResourceContentType("text");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceContentType FindValue(string value)
        {
            return FindValue<ResourceContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Role.
    /// </summary>
    public class Role : ConstantClass
    {

        /// <summary>
        /// Constant ASSISTANT for Role
        /// </summary>
        public static readonly Role ASSISTANT = new Role("ASSISTANT");
        /// <summary>
        /// Constant OTHER for Role
        /// </summary>
        public static readonly Role OTHER = new Role("OTHER");
        /// <summary>
        /// Constant TOOL for Role
        /// </summary>
        public static readonly Role TOOL = new Role("TOOL");
        /// <summary>
        /// Constant USER for Role
        /// </summary>
        public static readonly Role USER = new Role("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Role(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Role FindValue(string value)
        {
            return FindValue<Role>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Role(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScreenshotFormat.
    /// </summary>
    public class ScreenshotFormat : ConstantClass
    {

        /// <summary>
        /// Constant PNG for ScreenshotFormat
        /// </summary>
        public static readonly ScreenshotFormat PNG = new ScreenshotFormat("PNG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScreenshotFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScreenshotFormat FindValue(string value)
        {
            return FindValue<ScreenshotFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScreenshotFormat(string value)
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
        /// Constant FAILED for SessionStatus
        /// </summary>
        public static readonly SessionStatus FAILED = new SessionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SessionStatus
        /// </summary>
        public static readonly SessionStatus IN_PROGRESS = new SessionStatus("IN_PROGRESS");

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
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant Canceled for TaskStatus
        /// </summary>
        public static readonly TaskStatus Canceled = new TaskStatus("canceled");
        /// <summary>
        /// Constant Completed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Completed = new TaskStatus("completed");
        /// <summary>
        /// Constant Failed for TaskStatus
        /// </summary>
        public static readonly TaskStatus Failed = new TaskStatus("failed");
        /// <summary>
        /// Constant Submitted for TaskStatus
        /// </summary>
        public static readonly TaskStatus Submitted = new TaskStatus("submitted");
        /// <summary>
        /// Constant Working for TaskStatus
        /// </summary>
        public static readonly TaskStatus Working = new TaskStatus("working");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ToolName.
    /// </summary>
    public class ToolName : ConstantClass
    {

        /// <summary>
        /// Constant ExecuteCode for ToolName
        /// </summary>
        public static readonly ToolName ExecuteCode = new ToolName("executeCode");
        /// <summary>
        /// Constant ExecuteCommand for ToolName
        /// </summary>
        public static readonly ToolName ExecuteCommand = new ToolName("executeCommand");
        /// <summary>
        /// Constant GetTask for ToolName
        /// </summary>
        public static readonly ToolName GetTask = new ToolName("getTask");
        /// <summary>
        /// Constant ListFiles for ToolName
        /// </summary>
        public static readonly ToolName ListFiles = new ToolName("listFiles");
        /// <summary>
        /// Constant ReadFiles for ToolName
        /// </summary>
        public static readonly ToolName ReadFiles = new ToolName("readFiles");
        /// <summary>
        /// Constant RemoveFiles for ToolName
        /// </summary>
        public static readonly ToolName RemoveFiles = new ToolName("removeFiles");
        /// <summary>
        /// Constant StartCommandExecution for ToolName
        /// </summary>
        public static readonly ToolName StartCommandExecution = new ToolName("startCommandExecution");
        /// <summary>
        /// Constant StopTask for ToolName
        /// </summary>
        public static readonly ToolName StopTask = new ToolName("stopTask");
        /// <summary>
        /// Constant WriteFiles for ToolName
        /// </summary>
        public static readonly ToolName WriteFiles = new ToolName("writeFiles");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolName FindValue(string value)
        {
            return FindValue<ToolName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolName(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant EventInOtherSession for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason EventInOtherSession = new ValidationExceptionReason("EventInOtherSession");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant IdempotentParameterMismatchException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason IdempotentParameterMismatchException = new ValidationExceptionReason("IdempotentParameterMismatchException");
        /// <summary>
        /// Constant ResourceConflict for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ResourceConflict = new ValidationExceptionReason("ResourceConflict");

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
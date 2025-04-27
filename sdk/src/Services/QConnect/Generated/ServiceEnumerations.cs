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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QConnect
{

    /// <summary>
    /// Constants used for properties of type AIAgentAssociationConfigurationType.
    /// </summary>
    public class AIAgentAssociationConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for AIAgentAssociationConfigurationType
        /// </summary>
        public static readonly AIAgentAssociationConfigurationType KNOWLEDGE_BASE = new AIAgentAssociationConfigurationType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AIAgentAssociationConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AIAgentAssociationConfigurationType FindValue(string value)
        {
            return FindValue<AIAgentAssociationConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AIAgentAssociationConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AIAgentType.
    /// </summary>
    public class AIAgentType : ConstantClass
    {

        /// <summary>
        /// Constant ANSWER_RECOMMENDATION for AIAgentType
        /// </summary>
        public static readonly AIAgentType ANSWER_RECOMMENDATION = new AIAgentType("ANSWER_RECOMMENDATION");
        /// <summary>
        /// Constant MANUAL_SEARCH for AIAgentType
        /// </summary>
        public static readonly AIAgentType MANUAL_SEARCH = new AIAgentType("MANUAL_SEARCH");
        /// <summary>
        /// Constant SELF_SERVICE for AIAgentType
        /// </summary>
        public static readonly AIAgentType SELF_SERVICE = new AIAgentType("SELF_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AIAgentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AIAgentType FindValue(string value)
        {
            return FindValue<AIAgentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AIAgentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AIPromptAPIFormat.
    /// </summary>
    public class AIPromptAPIFormat : ConstantClass
    {

        /// <summary>
        /// Constant ANTHROPIC_CLAUDE_MESSAGES for AIPromptAPIFormat
        /// </summary>
        public static readonly AIPromptAPIFormat ANTHROPIC_CLAUDE_MESSAGES = new AIPromptAPIFormat("ANTHROPIC_CLAUDE_MESSAGES");
        /// <summary>
        /// Constant ANTHROPIC_CLAUDE_TEXT_COMPLETIONS for AIPromptAPIFormat
        /// </summary>
        public static readonly AIPromptAPIFormat ANTHROPIC_CLAUDE_TEXT_COMPLETIONS = new AIPromptAPIFormat("ANTHROPIC_CLAUDE_TEXT_COMPLETIONS");
        /// <summary>
        /// Constant MESSAGES for AIPromptAPIFormat
        /// </summary>
        public static readonly AIPromptAPIFormat MESSAGES = new AIPromptAPIFormat("MESSAGES");
        /// <summary>
        /// Constant TEXT_COMPLETIONS for AIPromptAPIFormat
        /// </summary>
        public static readonly AIPromptAPIFormat TEXT_COMPLETIONS = new AIPromptAPIFormat("TEXT_COMPLETIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AIPromptAPIFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AIPromptAPIFormat FindValue(string value)
        {
            return FindValue<AIPromptAPIFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AIPromptAPIFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AIPromptTemplateType.
    /// </summary>
    public class AIPromptTemplateType : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for AIPromptTemplateType
        /// </summary>
        public static readonly AIPromptTemplateType TEXT = new AIPromptTemplateType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AIPromptTemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AIPromptTemplateType FindValue(string value)
        {
            return FindValue<AIPromptTemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AIPromptTemplateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AIPromptType.
    /// </summary>
    public class AIPromptType : ConstantClass
    {

        /// <summary>
        /// Constant ANSWER_GENERATION for AIPromptType
        /// </summary>
        public static readonly AIPromptType ANSWER_GENERATION = new AIPromptType("ANSWER_GENERATION");
        /// <summary>
        /// Constant INTENT_LABELING_GENERATION for AIPromptType
        /// </summary>
        public static readonly AIPromptType INTENT_LABELING_GENERATION = new AIPromptType("INTENT_LABELING_GENERATION");
        /// <summary>
        /// Constant QUERY_REFORMULATION for AIPromptType
        /// </summary>
        public static readonly AIPromptType QUERY_REFORMULATION = new AIPromptType("QUERY_REFORMULATION");
        /// <summary>
        /// Constant SELF_SERVICE_ANSWER_GENERATION for AIPromptType
        /// </summary>
        public static readonly AIPromptType SELF_SERVICE_ANSWER_GENERATION = new AIPromptType("SELF_SERVICE_ANSWER_GENERATION");
        /// <summary>
        /// Constant SELF_SERVICE_PRE_PROCESSING for AIPromptType
        /// </summary>
        public static readonly AIPromptType SELF_SERVICE_PRE_PROCESSING = new AIPromptType("SELF_SERVICE_PRE_PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AIPromptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AIPromptType FindValue(string value)
        {
            return FindValue<AIPromptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AIPromptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssistantCapabilityType.
    /// </summary>
    public class AssistantCapabilityType : ConstantClass
    {

        /// <summary>
        /// Constant V1 for AssistantCapabilityType
        /// </summary>
        public static readonly AssistantCapabilityType V1 = new AssistantCapabilityType("V1");
        /// <summary>
        /// Constant V2 for AssistantCapabilityType
        /// </summary>
        public static readonly AssistantCapabilityType V2 = new AssistantCapabilityType("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssistantCapabilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssistantCapabilityType FindValue(string value)
        {
            return FindValue<AssistantCapabilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssistantCapabilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssistantStatus.
    /// </summary>
    public class AssistantStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus ACTIVE = new AssistantStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus CREATE_FAILED = new AssistantStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus CREATE_IN_PROGRESS = new AssistantStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus DELETE_FAILED = new AssistantStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus DELETE_IN_PROGRESS = new AssistantStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for AssistantStatus
        /// </summary>
        public static readonly AssistantStatus DELETED = new AssistantStatus("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssistantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssistantStatus FindValue(string value)
        {
            return FindValue<AssistantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssistantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssistantType.
    /// </summary>
    public class AssistantType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for AssistantType
        /// </summary>
        public static readonly AssistantType AGENT = new AssistantType("AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssistantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssistantType FindValue(string value)
        {
            return FindValue<AssistantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssistantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationType.
    /// </summary>
    public class AssociationType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for AssociationType
        /// </summary>
        public static readonly AssociationType KNOWLEDGE_BASE = new AssociationType("KNOWLEDGE_BASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationType FindValue(string value)
        {
            return FindValue<AssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelSubtype.
    /// </summary>
    public class ChannelSubtype : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for ChannelSubtype
        /// </summary>
        public static readonly ChannelSubtype EMAIL = new ChannelSubtype("EMAIL");
        /// <summary>
        /// Constant SMS for ChannelSubtype
        /// </summary>
        public static readonly ChannelSubtype SMS = new ChannelSubtype("SMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelSubtype FindValue(string value)
        {
            return FindValue<ChannelSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChunkingStrategy.
    /// </summary>
    public class ChunkingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FIXED_SIZE for ChunkingStrategy
        /// </summary>
        public static readonly ChunkingStrategy FIXED_SIZE = new ChunkingStrategy("FIXED_SIZE");
        /// <summary>
        /// Constant HIERARCHICAL for ChunkingStrategy
        /// </summary>
        public static readonly ChunkingStrategy HIERARCHICAL = new ChunkingStrategy("HIERARCHICAL");
        /// <summary>
        /// Constant NONE for ChunkingStrategy
        /// </summary>
        public static readonly ChunkingStrategy NONE = new ChunkingStrategy("NONE");
        /// <summary>
        /// Constant SEMANTIC for ChunkingStrategy
        /// </summary>
        public static readonly ChunkingStrategy SEMANTIC = new ChunkingStrategy("SEMANTIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChunkingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChunkingStrategy FindValue(string value)
        {
            return FindValue<ChunkingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChunkingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentAssociationType.
    /// </summary>
    public class ContentAssociationType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_CONNECT_GUIDE for ContentAssociationType
        /// </summary>
        public static readonly ContentAssociationType AMAZON_CONNECT_GUIDE = new ContentAssociationType("AMAZON_CONNECT_GUIDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentAssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentAssociationType FindValue(string value)
        {
            return FindValue<ContentAssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentAssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentDisposition.
    /// </summary>
    public class ContentDisposition : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT for ContentDisposition
        /// </summary>
        public static readonly ContentDisposition ATTACHMENT = new ContentDisposition("ATTACHMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentDisposition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentDisposition FindValue(string value)
        {
            return FindValue<ContentDisposition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentDisposition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentStatus.
    /// </summary>
    public class ContentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContentStatus
        /// </summary>
        public static readonly ContentStatus ACTIVE = new ContentStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ContentStatus
        /// </summary>
        public static readonly ContentStatus CREATE_FAILED = new ContentStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ContentStatus
        /// </summary>
        public static readonly ContentStatus CREATE_IN_PROGRESS = new ContentStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ContentStatus
        /// </summary>
        public static readonly ContentStatus DELETE_FAILED = new ContentStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ContentStatus
        /// </summary>
        public static readonly ContentStatus DELETE_IN_PROGRESS = new ContentStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for ContentStatus
        /// </summary>
        public static readonly ContentStatus DELETED = new ContentStatus("DELETED");
        /// <summary>
        /// Constant UPDATE_FAILED for ContentStatus
        /// </summary>
        public static readonly ContentStatus UPDATE_FAILED = new ContentStatus("UPDATE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentStatus FindValue(string value)
        {
            return FindValue<ContentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationStatus.
    /// </summary>
    public class ConversationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for ConversationStatus
        /// </summary>
        public static readonly ConversationStatus CLOSED = new ConversationStatus("CLOSED");
        /// <summary>
        /// Constant PROCESSING for ConversationStatus
        /// </summary>
        public static readonly ConversationStatus PROCESSING = new ConversationStatus("PROCESSING");
        /// <summary>
        /// Constant READY for ConversationStatus
        /// </summary>
        public static readonly ConversationStatus READY = new ConversationStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationStatus FindValue(string value)
        {
            return FindValue<ConversationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConversationStatusReason.
    /// </summary>
    public class ConversationStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ConversationStatusReason
        /// </summary>
        public static readonly ConversationStatusReason FAILED = new ConversationStatusReason("FAILED");
        /// <summary>
        /// Constant REJECTED for ConversationStatusReason
        /// </summary>
        public static readonly ConversationStatusReason REJECTED = new ConversationStatusReason("REJECTED");
        /// <summary>
        /// Constant SUCCESS for ConversationStatusReason
        /// </summary>
        public static readonly ConversationStatusReason SUCCESS = new ConversationStatusReason("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationStatusReason FindValue(string value)
        {
            return FindValue<ConversationStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalSource.
    /// </summary>
    public class ExternalSource : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_CONNECT for ExternalSource
        /// </summary>
        public static readonly ExternalSource AMAZON_CONNECT = new ExternalSource("AMAZON_CONNECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalSource FindValue(string value)
        {
            return FindValue<ExternalSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterField.
    /// </summary>
    public class FilterField : ConstantClass
    {

        /// <summary>
        /// Constant NAME for FilterField
        /// </summary>
        public static readonly FilterField NAME = new FilterField("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterField FindValue(string value)
        {
            return FindValue<FilterField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterOperator.
    /// </summary>
    public class FilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for FilterOperator
        /// </summary>
        public static readonly FilterOperator EQUALS = new FilterOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperator FindValue(string value)
        {
            return FindValue<FilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperator(string value)
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
    /// Constants used for properties of type GuardrailContextualGroundingFilterType.
    /// </summary>
    public class GuardrailContextualGroundingFilterType : ConstantClass
    {

        /// <summary>
        /// Constant GROUNDING for GuardrailContextualGroundingFilterType
        /// </summary>
        public static readonly GuardrailContextualGroundingFilterType GROUNDING = new GuardrailContextualGroundingFilterType("GROUNDING");
        /// <summary>
        /// Constant RELEVANCE for GuardrailContextualGroundingFilterType
        /// </summary>
        public static readonly GuardrailContextualGroundingFilterType RELEVANCE = new GuardrailContextualGroundingFilterType("RELEVANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailContextualGroundingFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailContextualGroundingFilterType FindValue(string value)
        {
            return FindValue<GuardrailContextualGroundingFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailContextualGroundingFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailFilterStrength.
    /// </summary>
    public class GuardrailFilterStrength : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength HIGH = new GuardrailFilterStrength("HIGH");
        /// <summary>
        /// Constant LOW for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength LOW = new GuardrailFilterStrength("LOW");
        /// <summary>
        /// Constant MEDIUM for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength MEDIUM = new GuardrailFilterStrength("MEDIUM");
        /// <summary>
        /// Constant NONE for GuardrailFilterStrength
        /// </summary>
        public static readonly GuardrailFilterStrength NONE = new GuardrailFilterStrength("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailFilterStrength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailFilterStrength FindValue(string value)
        {
            return FindValue<GuardrailFilterStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailFilterStrength(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GuardrailManagedWordsType.
    /// </summary>
    public class GuardrailManagedWordsType : ConstantClass
    {

        /// <summary>
        /// Constant PROFANITY for GuardrailManagedWordsType
        /// </summary>
        public static readonly GuardrailManagedWordsType PROFANITY = new GuardrailManagedWordsType("PROFANITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailManagedWordsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailManagedWordsType FindValue(string value)
        {
            return FindValue<GuardrailManagedWordsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailManagedWordsType(string value)
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
    /// Constants used for properties of type GuardrailSensitiveInformationAction.
    /// </summary>
    public class GuardrailSensitiveInformationAction : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMIZE for GuardrailSensitiveInformationAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationAction ANONYMIZE = new GuardrailSensitiveInformationAction("ANONYMIZE");
        /// <summary>
        /// Constant BLOCK for GuardrailSensitiveInformationAction
        /// </summary>
        public static readonly GuardrailSensitiveInformationAction BLOCK = new GuardrailSensitiveInformationAction("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GuardrailSensitiveInformationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GuardrailSensitiveInformationAction FindValue(string value)
        {
            return FindValue<GuardrailSensitiveInformationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GuardrailSensitiveInformationAction(string value)
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
    /// Constants used for properties of type ImportJobStatus.
    /// </summary>
    public class ImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus COMPLETE = new ImportJobStatus("COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus DELETE_FAILED = new ImportJobStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus DELETE_IN_PROGRESS = new ImportJobStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus DELETED = new ImportJobStatus("DELETED");
        /// <summary>
        /// Constant FAILED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus FAILED = new ImportJobStatus("FAILED");
        /// <summary>
        /// Constant START_IN_PROGRESS for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus START_IN_PROGRESS = new ImportJobStatus("START_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportJobStatus FindValue(string value)
        {
            return FindValue<ImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportJobType.
    /// </summary>
    public class ImportJobType : ConstantClass
    {

        /// <summary>
        /// Constant QUICK_RESPONSES for ImportJobType
        /// </summary>
        public static readonly ImportJobType QUICK_RESPONSES = new ImportJobType("QUICK_RESPONSES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportJobType FindValue(string value)
        {
            return FindValue<ImportJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KnowledgeBaseSearchType.
    /// </summary>
    public class KnowledgeBaseSearchType : ConstantClass
    {

        /// <summary>
        /// Constant HYBRID for KnowledgeBaseSearchType
        /// </summary>
        public static readonly KnowledgeBaseSearchType HYBRID = new KnowledgeBaseSearchType("HYBRID");
        /// <summary>
        /// Constant SEMANTIC for KnowledgeBaseSearchType
        /// </summary>
        public static readonly KnowledgeBaseSearchType SEMANTIC = new KnowledgeBaseSearchType("SEMANTIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnowledgeBaseSearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnowledgeBaseSearchType FindValue(string value)
        {
            return FindValue<KnowledgeBaseSearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnowledgeBaseSearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KnowledgeBaseStatus.
    /// </summary>
    public class KnowledgeBaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus ACTIVE = new KnowledgeBaseStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus CREATE_FAILED = new KnowledgeBaseStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus CREATE_IN_PROGRESS = new KnowledgeBaseStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus DELETE_FAILED = new KnowledgeBaseStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus DELETE_IN_PROGRESS = new KnowledgeBaseStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus DELETED = new KnowledgeBaseStatus("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnowledgeBaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnowledgeBaseStatus FindValue(string value)
        {
            return FindValue<KnowledgeBaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnowledgeBaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KnowledgeBaseType.
    /// </summary>
    public class KnowledgeBaseType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType CUSTOM = new KnowledgeBaseType("CUSTOM");
        /// <summary>
        /// Constant EXTERNAL for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType EXTERNAL = new KnowledgeBaseType("EXTERNAL");
        /// <summary>
        /// Constant MANAGED for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType MANAGED = new KnowledgeBaseType("MANAGED");
        /// <summary>
        /// Constant MESSAGE_TEMPLATES for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType MESSAGE_TEMPLATES = new KnowledgeBaseType("MESSAGE_TEMPLATES");
        /// <summary>
        /// Constant QUICK_RESPONSES for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType QUICK_RESPONSES = new KnowledgeBaseType("QUICK_RESPONSES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnowledgeBaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnowledgeBaseType FindValue(string value)
        {
            return FindValue<KnowledgeBaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnowledgeBaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageTemplateAttributeType.
    /// </summary>
    public class MessageTemplateAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for MessageTemplateAttributeType
        /// </summary>
        public static readonly MessageTemplateAttributeType AGENT = new MessageTemplateAttributeType("AGENT");
        /// <summary>
        /// Constant CUSTOM for MessageTemplateAttributeType
        /// </summary>
        public static readonly MessageTemplateAttributeType CUSTOM = new MessageTemplateAttributeType("CUSTOM");
        /// <summary>
        /// Constant CUSTOMER_PROFILE for MessageTemplateAttributeType
        /// </summary>
        public static readonly MessageTemplateAttributeType CUSTOMER_PROFILE = new MessageTemplateAttributeType("CUSTOMER_PROFILE");
        /// <summary>
        /// Constant SYSTEM for MessageTemplateAttributeType
        /// </summary>
        public static readonly MessageTemplateAttributeType SYSTEM = new MessageTemplateAttributeType("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageTemplateAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageTemplateAttributeType FindValue(string value)
        {
            return FindValue<MessageTemplateAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageTemplateAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageTemplateFilterOperator.
    /// </summary>
    public class MessageTemplateFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for MessageTemplateFilterOperator
        /// </summary>
        public static readonly MessageTemplateFilterOperator EQUALS = new MessageTemplateFilterOperator("EQUALS");
        /// <summary>
        /// Constant PREFIX for MessageTemplateFilterOperator
        /// </summary>
        public static readonly MessageTemplateFilterOperator PREFIX = new MessageTemplateFilterOperator("PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageTemplateFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageTemplateFilterOperator FindValue(string value)
        {
            return FindValue<MessageTemplateFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageTemplateFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageTemplateQueryOperator.
    /// </summary>
    public class MessageTemplateQueryOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for MessageTemplateQueryOperator
        /// </summary>
        public static readonly MessageTemplateQueryOperator CONTAINS = new MessageTemplateQueryOperator("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_AND_PREFIX for MessageTemplateQueryOperator
        /// </summary>
        public static readonly MessageTemplateQueryOperator CONTAINS_AND_PREFIX = new MessageTemplateQueryOperator("CONTAINS_AND_PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageTemplateQueryOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageTemplateQueryOperator FindValue(string value)
        {
            return FindValue<MessageTemplateQueryOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageTemplateQueryOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for MessageType
        /// </summary>
        public static readonly MessageType TEXT = new MessageType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant ASC for Order
        /// </summary>
        public static readonly Order ASC = new Order("ASC");
        /// <summary>
        /// Constant DESC for Order
        /// </summary>
        public static readonly Order DESC = new Order("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Origin.
    /// </summary>
    public class Origin : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER for Origin
        /// </summary>
        public static readonly Origin CUSTOMER = new Origin("CUSTOMER");
        /// <summary>
        /// Constant SYSTEM for Origin
        /// </summary>
        public static readonly Origin SYSTEM = new Origin("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Origin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Origin FindValue(string value)
        {
            return FindValue<Origin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Origin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParsingStrategy.
    /// </summary>
    public class ParsingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant BEDROCK_FOUNDATION_MODEL for ParsingStrategy
        /// </summary>
        public static readonly ParsingStrategy BEDROCK_FOUNDATION_MODEL = new ParsingStrategy("BEDROCK_FOUNDATION_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParsingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParsingStrategy FindValue(string value)
        {
            return FindValue<ParsingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParsingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Participant.
    /// </summary>
    public class Participant : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for Participant
        /// </summary>
        public static readonly Participant AGENT = new Participant("AGENT");
        /// <summary>
        /// Constant BOT for Participant
        /// </summary>
        public static readonly Participant BOT = new Participant("BOT");
        /// <summary>
        /// Constant CUSTOMER for Participant
        /// </summary>
        public static readonly Participant CUSTOMER = new Participant("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Participant(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Participant FindValue(string value)
        {
            return FindValue<Participant>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Participant(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Priority.
    /// </summary>
    public class Priority : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Priority
        /// </summary>
        public static readonly Priority HIGH = new Priority("HIGH");
        /// <summary>
        /// Constant LOW for Priority
        /// </summary>
        public static readonly Priority LOW = new Priority("LOW");
        /// <summary>
        /// Constant MEDIUM for Priority
        /// </summary>
        public static readonly Priority MEDIUM = new Priority("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Priority(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Priority FindValue(string value)
        {
            return FindValue<Priority>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Priority(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryConditionComparisonOperator.
    /// </summary>
    public class QueryConditionComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for QueryConditionComparisonOperator
        /// </summary>
        public static readonly QueryConditionComparisonOperator EQUALS = new QueryConditionComparisonOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryConditionComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryConditionComparisonOperator FindValue(string value)
        {
            return FindValue<QueryConditionComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryConditionComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryConditionFieldName.
    /// </summary>
    public class QueryConditionFieldName : ConstantClass
    {

        /// <summary>
        /// Constant RESULT_TYPE for QueryConditionFieldName
        /// </summary>
        public static readonly QueryConditionFieldName RESULT_TYPE = new QueryConditionFieldName("RESULT_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryConditionFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryConditionFieldName FindValue(string value)
        {
            return FindValue<QueryConditionFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryConditionFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryResultType.
    /// </summary>
    public class QueryResultType : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED_GENERATIVE_ANSWER_CHUNK for QueryResultType
        /// </summary>
        public static readonly QueryResultType BLOCKED_GENERATIVE_ANSWER_CHUNK = new QueryResultType("BLOCKED_GENERATIVE_ANSWER_CHUNK");
        /// <summary>
        /// Constant BLOCKED_INTENT_ANSWER_CHUNK for QueryResultType
        /// </summary>
        public static readonly QueryResultType BLOCKED_INTENT_ANSWER_CHUNK = new QueryResultType("BLOCKED_INTENT_ANSWER_CHUNK");
        /// <summary>
        /// Constant GENERATIVE_ANSWER for QueryResultType
        /// </summary>
        public static readonly QueryResultType GENERATIVE_ANSWER = new QueryResultType("GENERATIVE_ANSWER");
        /// <summary>
        /// Constant GENERATIVE_ANSWER_CHUNK for QueryResultType
        /// </summary>
        public static readonly QueryResultType GENERATIVE_ANSWER_CHUNK = new QueryResultType("GENERATIVE_ANSWER_CHUNK");
        /// <summary>
        /// Constant INTENT_ANSWER for QueryResultType
        /// </summary>
        public static readonly QueryResultType INTENT_ANSWER = new QueryResultType("INTENT_ANSWER");
        /// <summary>
        /// Constant INTENT_ANSWER_CHUNK for QueryResultType
        /// </summary>
        public static readonly QueryResultType INTENT_ANSWER_CHUNK = new QueryResultType("INTENT_ANSWER_CHUNK");
        /// <summary>
        /// Constant KNOWLEDGE_CONTENT for QueryResultType
        /// </summary>
        public static readonly QueryResultType KNOWLEDGE_CONTENT = new QueryResultType("KNOWLEDGE_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryResultType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryResultType FindValue(string value)
        {
            return FindValue<QueryResultType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryResultType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuickResponseFilterOperator.
    /// </summary>
    public class QuickResponseFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for QuickResponseFilterOperator
        /// </summary>
        public static readonly QuickResponseFilterOperator EQUALS = new QuickResponseFilterOperator("EQUALS");
        /// <summary>
        /// Constant PREFIX for QuickResponseFilterOperator
        /// </summary>
        public static readonly QuickResponseFilterOperator PREFIX = new QuickResponseFilterOperator("PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuickResponseFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuickResponseFilterOperator FindValue(string value)
        {
            return FindValue<QuickResponseFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuickResponseFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuickResponseQueryOperator.
    /// </summary>
    public class QuickResponseQueryOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for QuickResponseQueryOperator
        /// </summary>
        public static readonly QuickResponseQueryOperator CONTAINS = new QuickResponseQueryOperator("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_AND_PREFIX for QuickResponseQueryOperator
        /// </summary>
        public static readonly QuickResponseQueryOperator CONTAINS_AND_PREFIX = new QuickResponseQueryOperator("CONTAINS_AND_PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuickResponseQueryOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuickResponseQueryOperator FindValue(string value)
        {
            return FindValue<QuickResponseQueryOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuickResponseQueryOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuickResponseStatus.
    /// </summary>
    public class QuickResponseStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus CREATE_FAILED = new QuickResponseStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus CREATE_IN_PROGRESS = new QuickResponseStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATED for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus CREATED = new QuickResponseStatus("CREATED");
        /// <summary>
        /// Constant DELETE_FAILED for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus DELETE_FAILED = new QuickResponseStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus DELETE_IN_PROGRESS = new QuickResponseStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus DELETED = new QuickResponseStatus("DELETED");
        /// <summary>
        /// Constant UPDATE_FAILED for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus UPDATE_FAILED = new QuickResponseStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for QuickResponseStatus
        /// </summary>
        public static readonly QuickResponseStatus UPDATE_IN_PROGRESS = new QuickResponseStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuickResponseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuickResponseStatus FindValue(string value)
        {
            return FindValue<QuickResponseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuickResponseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationSourceType.
    /// </summary>
    public class RecommendationSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ISSUE_DETECTION for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType ISSUE_DETECTION = new RecommendationSourceType("ISSUE_DETECTION");
        /// <summary>
        /// Constant OTHER for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType OTHER = new RecommendationSourceType("OTHER");
        /// <summary>
        /// Constant RULE_EVALUATION for RecommendationSourceType
        /// </summary>
        public static readonly RecommendationSourceType RULE_EVALUATION = new RecommendationSourceType("RULE_EVALUATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationSourceType FindValue(string value)
        {
            return FindValue<RecommendationSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationTriggerType.
    /// </summary>
    public class RecommendationTriggerType : ConstantClass
    {

        /// <summary>
        /// Constant GENERATIVE for RecommendationTriggerType
        /// </summary>
        public static readonly RecommendationTriggerType GENERATIVE = new RecommendationTriggerType("GENERATIVE");
        /// <summary>
        /// Constant QUERY for RecommendationTriggerType
        /// </summary>
        public static readonly RecommendationTriggerType QUERY = new RecommendationTriggerType("QUERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationTriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationTriggerType FindValue(string value)
        {
            return FindValue<RecommendationTriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationTriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant BLOCKED_GENERATIVE_ANSWER_CHUNK for RecommendationType
        /// </summary>
        public static readonly RecommendationType BLOCKED_GENERATIVE_ANSWER_CHUNK = new RecommendationType("BLOCKED_GENERATIVE_ANSWER_CHUNK");
        /// <summary>
        /// Constant BLOCKED_INTENT_ANSWER_CHUNK for RecommendationType
        /// </summary>
        public static readonly RecommendationType BLOCKED_INTENT_ANSWER_CHUNK = new RecommendationType("BLOCKED_INTENT_ANSWER_CHUNK");
        /// <summary>
        /// Constant DETECTED_INTENT for RecommendationType
        /// </summary>
        public static readonly RecommendationType DETECTED_INTENT = new RecommendationType("DETECTED_INTENT");
        /// <summary>
        /// Constant GENERATIVE_ANSWER for RecommendationType
        /// </summary>
        public static readonly RecommendationType GENERATIVE_ANSWER = new RecommendationType("GENERATIVE_ANSWER");
        /// <summary>
        /// Constant GENERATIVE_ANSWER_CHUNK for RecommendationType
        /// </summary>
        public static readonly RecommendationType GENERATIVE_ANSWER_CHUNK = new RecommendationType("GENERATIVE_ANSWER_CHUNK");
        /// <summary>
        /// Constant GENERATIVE_RESPONSE for RecommendationType
        /// </summary>
        public static readonly RecommendationType GENERATIVE_RESPONSE = new RecommendationType("GENERATIVE_RESPONSE");
        /// <summary>
        /// Constant INTENT_ANSWER_CHUNK for RecommendationType
        /// </summary>
        public static readonly RecommendationType INTENT_ANSWER_CHUNK = new RecommendationType("INTENT_ANSWER_CHUNK");
        /// <summary>
        /// Constant KNOWLEDGE_CONTENT for RecommendationType
        /// </summary>
        public static readonly RecommendationType KNOWLEDGE_CONTENT = new RecommendationType("KNOWLEDGE_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceType.
    /// </summary>
    public class ReferenceType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_BASE for ReferenceType
        /// </summary>
        public static readonly ReferenceType KNOWLEDGE_BASE = new ReferenceType("KNOWLEDGE_BASE");
        /// <summary>
        /// Constant WEB_CRAWLER for ReferenceType
        /// </summary>
        public static readonly ReferenceType WEB_CRAWLER = new ReferenceType("WEB_CRAWLER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceType FindValue(string value)
        {
            return FindValue<ReferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Relevance.
    /// </summary>
    public class Relevance : ConstantClass
    {

        /// <summary>
        /// Constant HELPFUL for Relevance
        /// </summary>
        public static readonly Relevance HELPFUL = new Relevance("HELPFUL");
        /// <summary>
        /// Constant NOT_HELPFUL for Relevance
        /// </summary>
        public static readonly Relevance NOT_HELPFUL = new Relevance("NOT_HELPFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Relevance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Relevance FindValue(string value)
        {
            return FindValue<Relevance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Relevance(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelevanceLevel.
    /// </summary>
    public class RelevanceLevel : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for RelevanceLevel
        /// </summary>
        public static readonly RelevanceLevel HIGH = new RelevanceLevel("HIGH");
        /// <summary>
        /// Constant LOW for RelevanceLevel
        /// </summary>
        public static readonly RelevanceLevel LOW = new RelevanceLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for RelevanceLevel
        /// </summary>
        public static readonly RelevanceLevel MEDIUM = new RelevanceLevel("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelevanceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelevanceLevel FindValue(string value)
        {
            return FindValue<RelevanceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelevanceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionDataNamespace.
    /// </summary>
    public class SessionDataNamespace : ConstantClass
    {

        /// <summary>
        /// Constant Custom for SessionDataNamespace
        /// </summary>
        public static readonly SessionDataNamespace Custom = new SessionDataNamespace("Custom");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionDataNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionDataNamespace FindValue(string value)
        {
            return FindValue<SessionDataNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionDataNamespace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceContentType.
    /// </summary>
    public class SourceContentType : ConstantClass
    {

        /// <summary>
        /// Constant KNOWLEDGE_CONTENT for SourceContentType
        /// </summary>
        public static readonly SourceContentType KNOWLEDGE_CONTENT = new SourceContentType("KNOWLEDGE_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceContentType FindValue(string value)
        {
            return FindValue<SourceContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for Status
        /// </summary>
        public static readonly Status CREATE_FAILED = new Status("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for Status
        /// </summary>
        public static readonly Status CREATE_IN_PROGRESS = new Status("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for Status
        /// </summary>
        public static readonly Status DELETE_FAILED = new Status("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for Status
        /// </summary>
        public static readonly Status DELETE_IN_PROGRESS = new Status("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for Status
        /// </summary>
        public static readonly Status DELETED = new Status("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyncStatus.
    /// </summary>
    public class SyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_IN_PROGRESS for SyncStatus
        /// </summary>
        public static readonly SyncStatus CREATE_IN_PROGRESS = new SyncStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant SYNC_FAILED for SyncStatus
        /// </summary>
        public static readonly SyncStatus SYNC_FAILED = new SyncStatus("SYNC_FAILED");
        /// <summary>
        /// Constant SYNC_SUCCESS for SyncStatus
        /// </summary>
        public static readonly SyncStatus SYNC_SUCCESS = new SyncStatus("SYNC_SUCCESS");
        /// <summary>
        /// Constant SYNCING_IN_PROGRESS for SyncStatus
        /// </summary>
        public static readonly SyncStatus SYNCING_IN_PROGRESS = new SyncStatus("SYNCING_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncStatus FindValue(string value)
        {
            return FindValue<SyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant RECOMMENDATION for TargetType
        /// </summary>
        public static readonly TargetType RECOMMENDATION = new TargetType("RECOMMENDATION");
        /// <summary>
        /// Constant RESULT for TargetType
        /// </summary>
        public static readonly TargetType RESULT = new TargetType("RESULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisibilityStatus.
    /// </summary>
    public class VisibilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED for VisibilityStatus
        /// </summary>
        public static readonly VisibilityStatus PUBLISHED = new VisibilityStatus("PUBLISHED");
        /// <summary>
        /// Constant SAVED for VisibilityStatus
        /// </summary>
        public static readonly VisibilityStatus SAVED = new VisibilityStatus("SAVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisibilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisibilityStatus FindValue(string value)
        {
            return FindValue<VisibilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisibilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebScopeType.
    /// </summary>
    public class WebScopeType : ConstantClass
    {

        /// <summary>
        /// Constant HOST_ONLY for WebScopeType
        /// </summary>
        public static readonly WebScopeType HOST_ONLY = new WebScopeType("HOST_ONLY");
        /// <summary>
        /// Constant SUBDOMAINS for WebScopeType
        /// </summary>
        public static readonly WebScopeType SUBDOMAINS = new WebScopeType("SUBDOMAINS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebScopeType FindValue(string value)
        {
            return FindValue<WebScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebScopeType(string value)
        {
            return FindValue(value);
        }
    }

}
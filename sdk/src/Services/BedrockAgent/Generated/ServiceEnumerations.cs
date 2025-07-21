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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgent
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
    /// Constants used for properties of type ActionGroupState.
    /// </summary>
    public class ActionGroupState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ActionGroupState
        /// </summary>
        public static readonly ActionGroupState DISABLED = new ActionGroupState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ActionGroupState
        /// </summary>
        public static readonly ActionGroupState ENABLED = new ActionGroupState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionGroupState FindValue(string value)
        {
            return FindValue<ActionGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionGroupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentAliasStatus.
    /// </summary>
    public class AgentAliasStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus CREATING = new AgentAliasStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus DELETING = new AgentAliasStatus("DELETING");
        /// <summary>
        /// Constant DISSOCIATED for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus DISSOCIATED = new AgentAliasStatus("DISSOCIATED");
        /// <summary>
        /// Constant FAILED for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus FAILED = new AgentAliasStatus("FAILED");
        /// <summary>
        /// Constant PREPARED for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus PREPARED = new AgentAliasStatus("PREPARED");
        /// <summary>
        /// Constant UPDATING for AgentAliasStatus
        /// </summary>
        public static readonly AgentAliasStatus UPDATING = new AgentAliasStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentAliasStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentAliasStatus FindValue(string value)
        {
            return FindValue<AgentAliasStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentAliasStatus(string value)
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
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for AgentStatus
        /// </summary>
        public static readonly AgentStatus CREATING = new AgentStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AgentStatus
        /// </summary>
        public static readonly AgentStatus DELETING = new AgentStatus("DELETING");
        /// <summary>
        /// Constant FAILED for AgentStatus
        /// </summary>
        public static readonly AgentStatus FAILED = new AgentStatus("FAILED");
        /// <summary>
        /// Constant NOT_PREPARED for AgentStatus
        /// </summary>
        public static readonly AgentStatus NOT_PREPARED = new AgentStatus("NOT_PREPARED");
        /// <summary>
        /// Constant PREPARED for AgentStatus
        /// </summary>
        public static readonly AgentStatus PREPARED = new AgentStatus("PREPARED");
        /// <summary>
        /// Constant PREPARING for AgentStatus
        /// </summary>
        public static readonly AgentStatus PREPARING = new AgentStatus("PREPARING");
        /// <summary>
        /// Constant UPDATING for AgentStatus
        /// </summary>
        public static readonly AgentStatus UPDATING = new AgentStatus("UPDATING");
        /// <summary>
        /// Constant VERSIONING for AgentStatus
        /// </summary>
        public static readonly AgentStatus VERSIONING = new AgentStatus("VERSIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatus FindValue(string value)
        {
            return FindValue<AgentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AliasInvocationState.
    /// </summary>
    public class AliasInvocationState : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT_INVOCATIONS for AliasInvocationState
        /// </summary>
        public static readonly AliasInvocationState ACCEPT_INVOCATIONS = new AliasInvocationState("ACCEPT_INVOCATIONS");
        /// <summary>
        /// Constant REJECT_INVOCATIONS for AliasInvocationState
        /// </summary>
        public static readonly AliasInvocationState REJECT_INVOCATIONS = new AliasInvocationState("REJECT_INVOCATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AliasInvocationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AliasInvocationState FindValue(string value)
        {
            return FindValue<AliasInvocationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AliasInvocationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CachePointType.
    /// </summary>
    public class CachePointType : ConstantClass
    {

        /// <summary>
        /// Constant Default for CachePointType
        /// </summary>
        public static readonly CachePointType Default = new CachePointType("default");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CachePointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CachePointType FindValue(string value)
        {
            return FindValue<CachePointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CachePointType(string value)
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
    /// Constants used for properties of type ConcurrencyType.
    /// </summary>
    public class ConcurrencyType : ConstantClass
    {

        /// <summary>
        /// Constant Automatic for ConcurrencyType
        /// </summary>
        public static readonly ConcurrencyType Automatic = new ConcurrencyType("Automatic");
        /// <summary>
        /// Constant Manual for ConcurrencyType
        /// </summary>
        public static readonly ConcurrencyType Manual = new ConcurrencyType("Manual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConcurrencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConcurrencyType FindValue(string value)
        {
            return FindValue<ConcurrencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConcurrencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceAuthType.
    /// </summary>
    public class ConfluenceAuthType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for ConfluenceAuthType
        /// </summary>
        public static readonly ConfluenceAuthType BASIC = new ConfluenceAuthType("BASIC");
        /// <summary>
        /// Constant OAUTH2_CLIENT_CREDENTIALS for ConfluenceAuthType
        /// </summary>
        public static readonly ConfluenceAuthType OAUTH2_CLIENT_CREDENTIALS = new ConfluenceAuthType("OAUTH2_CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceAuthType FindValue(string value)
        {
            return FindValue<ConfluenceAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceHostType.
    /// </summary>
    public class ConfluenceHostType : ConstantClass
    {

        /// <summary>
        /// Constant SAAS for ConfluenceHostType
        /// </summary>
        public static readonly ConfluenceHostType SAAS = new ConfluenceHostType("SAAS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceHostType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceHostType FindValue(string value)
        {
            return FindValue<ConfluenceHostType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceHostType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentDataSourceType.
    /// </summary>
    public class ContentDataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for ContentDataSourceType
        /// </summary>
        public static readonly ContentDataSourceType CUSTOM = new ContentDataSourceType("CUSTOM");
        /// <summary>
        /// Constant S3 for ContentDataSourceType
        /// </summary>
        public static readonly ContentDataSourceType S3 = new ContentDataSourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentDataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentDataSourceType FindValue(string value)
        {
            return FindValue<ContentDataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentDataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContextEnrichmentType.
    /// </summary>
    public class ContextEnrichmentType : ConstantClass
    {

        /// <summary>
        /// Constant BEDROCK_FOUNDATION_MODEL for ContextEnrichmentType
        /// </summary>
        public static readonly ContextEnrichmentType BEDROCK_FOUNDATION_MODEL = new ContextEnrichmentType("BEDROCK_FOUNDATION_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContextEnrichmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContextEnrichmentType FindValue(string value)
        {
            return FindValue<ContextEnrichmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContextEnrichmentType(string value)
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
    /// Constants used for properties of type CrawlFilterConfigurationType.
    /// </summary>
    public class CrawlFilterConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant PATTERN for CrawlFilterConfigurationType
        /// </summary>
        public static readonly CrawlFilterConfigurationType PATTERN = new CrawlFilterConfigurationType("PATTERN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlFilterConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlFilterConfigurationType FindValue(string value)
        {
            return FindValue<CrawlFilterConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlFilterConfigurationType(string value)
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
    /// Constants used for properties of type CustomSourceType.
    /// </summary>
    public class CustomSourceType : ConstantClass
    {

        /// <summary>
        /// Constant IN_LINE for CustomSourceType
        /// </summary>
        public static readonly CustomSourceType IN_LINE = new CustomSourceType("IN_LINE");
        /// <summary>
        /// Constant S3_LOCATION for CustomSourceType
        /// </summary>
        public static readonly CustomSourceType S3_LOCATION = new CustomSourceType("S3_LOCATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomSourceType FindValue(string value)
        {
            return FindValue<CustomSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataDeletionPolicy.
    /// </summary>
    public class DataDeletionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for DataDeletionPolicy
        /// </summary>
        public static readonly DataDeletionPolicy DELETE = new DataDeletionPolicy("DELETE");
        /// <summary>
        /// Constant RETAIN for DataDeletionPolicy
        /// </summary>
        public static readonly DataDeletionPolicy RETAIN = new DataDeletionPolicy("RETAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataDeletionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataDeletionPolicy FindValue(string value)
        {
            return FindValue<DataDeletionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataDeletionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus AVAILABLE = new DataSourceStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETE_UNSUCCESSFUL for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETE_UNSUCCESSFUL = new DataSourceStatus("DELETE_UNSUCCESSFUL");
        /// <summary>
        /// Constant DELETING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETING = new DataSourceStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CONFLUENCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType CONFLUENCE = new DataSourceType("CONFLUENCE");
        /// <summary>
        /// Constant CUSTOM for DataSourceType
        /// </summary>
        public static readonly DataSourceType CUSTOM = new DataSourceType("CUSTOM");
        /// <summary>
        /// Constant REDSHIFT_METADATA for DataSourceType
        /// </summary>
        public static readonly DataSourceType REDSHIFT_METADATA = new DataSourceType("REDSHIFT_METADATA");
        /// <summary>
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");
        /// <summary>
        /// Constant SALESFORCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SALESFORCE = new DataSourceType("SALESFORCE");
        /// <summary>
        /// Constant SHAREPOINT for DataSourceType
        /// </summary>
        public static readonly DataSourceType SHAREPOINT = new DataSourceType("SHAREPOINT");
        /// <summary>
        /// Constant WEB for DataSourceType
        /// </summary>
        public static readonly DataSourceType WEB = new DataSourceType("WEB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatus.
    /// </summary>
    public class DocumentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_IN_PROGRESS for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus DELETE_IN_PROGRESS = new DocumentStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETING for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus DELETING = new DocumentStatus("DELETING");
        /// <summary>
        /// Constant FAILED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus FAILED = new DocumentStatus("FAILED");
        /// <summary>
        /// Constant IGNORED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus IGNORED = new DocumentStatus("IGNORED");
        /// <summary>
        /// Constant IN_PROGRESS for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus IN_PROGRESS = new DocumentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INDEXED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus INDEXED = new DocumentStatus("INDEXED");
        /// <summary>
        /// Constant METADATA_PARTIALLY_INDEXED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus METADATA_PARTIALLY_INDEXED = new DocumentStatus("METADATA_PARTIALLY_INDEXED");
        /// <summary>
        /// Constant METADATA_UPDATE_FAILED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus METADATA_UPDATE_FAILED = new DocumentStatus("METADATA_UPDATE_FAILED");
        /// <summary>
        /// Constant NOT_FOUND for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus NOT_FOUND = new DocumentStatus("NOT_FOUND");
        /// <summary>
        /// Constant PARTIALLY_INDEXED for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus PARTIALLY_INDEXED = new DocumentStatus("PARTIALLY_INDEXED");
        /// <summary>
        /// Constant PENDING for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus PENDING = new DocumentStatus("PENDING");
        /// <summary>
        /// Constant STARTING for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus STARTING = new DocumentStatus("STARTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatus FindValue(string value)
        {
            return FindValue<DocumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmbeddingDataType.
    /// </summary>
    public class EmbeddingDataType : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for EmbeddingDataType
        /// </summary>
        public static readonly EmbeddingDataType BINARY = new EmbeddingDataType("BINARY");
        /// <summary>
        /// Constant FLOAT32 for EmbeddingDataType
        /// </summary>
        public static readonly EmbeddingDataType FLOAT32 = new EmbeddingDataType("FLOAT32");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddingDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddingDataType FindValue(string value)
        {
            return FindValue<EmbeddingDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddingDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnrichmentStrategyMethod.
    /// </summary>
    public class EnrichmentStrategyMethod : ConstantClass
    {

        /// <summary>
        /// Constant CHUNK_ENTITY_EXTRACTION for EnrichmentStrategyMethod
        /// </summary>
        public static readonly EnrichmentStrategyMethod CHUNK_ENTITY_EXTRACTION = new EnrichmentStrategyMethod("CHUNK_ENTITY_EXTRACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrichmentStrategyMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrichmentStrategyMethod FindValue(string value)
        {
            return FindValue<EnrichmentStrategyMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrichmentStrategyMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowConnectionType.
    /// </summary>
    public class FlowConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant Conditional for FlowConnectionType
        /// </summary>
        public static readonly FlowConnectionType Conditional = new FlowConnectionType("Conditional");
        /// <summary>
        /// Constant Data for FlowConnectionType
        /// </summary>
        public static readonly FlowConnectionType Data = new FlowConnectionType("Data");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowConnectionType FindValue(string value)
        {
            return FindValue<FlowConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowConnectionType(string value)
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
    /// Constants used for properties of type FlowNodeType.
    /// </summary>
    public class FlowNodeType : ConstantClass
    {

        /// <summary>
        /// Constant Agent for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Agent = new FlowNodeType("Agent");
        /// <summary>
        /// Constant Collector for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Collector = new FlowNodeType("Collector");
        /// <summary>
        /// Constant Condition for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Condition = new FlowNodeType("Condition");
        /// <summary>
        /// Constant InlineCode for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType InlineCode = new FlowNodeType("InlineCode");
        /// <summary>
        /// Constant Input for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Input = new FlowNodeType("Input");
        /// <summary>
        /// Constant Iterator for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Iterator = new FlowNodeType("Iterator");
        /// <summary>
        /// Constant KnowledgeBase for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType KnowledgeBase = new FlowNodeType("KnowledgeBase");
        /// <summary>
        /// Constant LambdaFunction for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType LambdaFunction = new FlowNodeType("LambdaFunction");
        /// <summary>
        /// Constant Lex for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Lex = new FlowNodeType("Lex");
        /// <summary>
        /// Constant Loop for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Loop = new FlowNodeType("Loop");
        /// <summary>
        /// Constant LoopController for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType LoopController = new FlowNodeType("LoopController");
        /// <summary>
        /// Constant LoopInput for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType LoopInput = new FlowNodeType("LoopInput");
        /// <summary>
        /// Constant Output for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Output = new FlowNodeType("Output");
        /// <summary>
        /// Constant Prompt for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Prompt = new FlowNodeType("Prompt");
        /// <summary>
        /// Constant Retrieval for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Retrieval = new FlowNodeType("Retrieval");
        /// <summary>
        /// Constant Storage for FlowNodeType
        /// </summary>
        public static readonly FlowNodeType Storage = new FlowNodeType("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowNodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowNodeType FindValue(string value)
        {
            return FindValue<FlowNodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowNodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowStatus.
    /// </summary>
    public class FlowStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for FlowStatus
        /// </summary>
        public static readonly FlowStatus Failed = new FlowStatus("Failed");
        /// <summary>
        /// Constant NotPrepared for FlowStatus
        /// </summary>
        public static readonly FlowStatus NotPrepared = new FlowStatus("NotPrepared");
        /// <summary>
        /// Constant Prepared for FlowStatus
        /// </summary>
        public static readonly FlowStatus Prepared = new FlowStatus("Prepared");
        /// <summary>
        /// Constant Preparing for FlowStatus
        /// </summary>
        public static readonly FlowStatus Preparing = new FlowStatus("Preparing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowStatus FindValue(string value)
        {
            return FindValue<FlowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowValidationSeverity.
    /// </summary>
    public class FlowValidationSeverity : ConstantClass
    {

        /// <summary>
        /// Constant Error for FlowValidationSeverity
        /// </summary>
        public static readonly FlowValidationSeverity Error = new FlowValidationSeverity("Error");
        /// <summary>
        /// Constant Warning for FlowValidationSeverity
        /// </summary>
        public static readonly FlowValidationSeverity Warning = new FlowValidationSeverity("Warning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowValidationSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowValidationSeverity FindValue(string value)
        {
            return FindValue<FlowValidationSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowValidationSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowValidationType.
    /// </summary>
    public class FlowValidationType : ConstantClass
    {

        /// <summary>
        /// Constant CyclicConnection for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType CyclicConnection = new FlowValidationType("CyclicConnection");
        /// <summary>
        /// Constant DuplicateConditionExpression for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType DuplicateConditionExpression = new FlowValidationType("DuplicateConditionExpression");
        /// <summary>
        /// Constant DuplicateConnections for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType DuplicateConnections = new FlowValidationType("DuplicateConnections");
        /// <summary>
        /// Constant IncompatibleConnectionDataType for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType IncompatibleConnectionDataType = new FlowValidationType("IncompatibleConnectionDataType");
        /// <summary>
        /// Constant InvalidLoopBoundary for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType InvalidLoopBoundary = new FlowValidationType("InvalidLoopBoundary");
        /// <summary>
        /// Constant LoopIncompatibleNodeType for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType LoopIncompatibleNodeType = new FlowValidationType("LoopIncompatibleNodeType");
        /// <summary>
        /// Constant MalformedConditionExpression for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MalformedConditionExpression = new FlowValidationType("MalformedConditionExpression");
        /// <summary>
        /// Constant MalformedNodeInputExpression for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MalformedNodeInputExpression = new FlowValidationType("MalformedNodeInputExpression");
        /// <summary>
        /// Constant MismatchedNodeInputType for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MismatchedNodeInputType = new FlowValidationType("MismatchedNodeInputType");
        /// <summary>
        /// Constant MismatchedNodeOutputType for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MismatchedNodeOutputType = new FlowValidationType("MismatchedNodeOutputType");
        /// <summary>
        /// Constant MissingConnectionConfiguration for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingConnectionConfiguration = new FlowValidationType("MissingConnectionConfiguration");
        /// <summary>
        /// Constant MissingDefaultCondition for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingDefaultCondition = new FlowValidationType("MissingDefaultCondition");
        /// <summary>
        /// Constant MissingEndingNodes for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingEndingNodes = new FlowValidationType("MissingEndingNodes");
        /// <summary>
        /// Constant MissingLoopControllerNode for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingLoopControllerNode = new FlowValidationType("MissingLoopControllerNode");
        /// <summary>
        /// Constant MissingLoopInputNode for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingLoopInputNode = new FlowValidationType("MissingLoopInputNode");
        /// <summary>
        /// Constant MissingNodeConfiguration for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingNodeConfiguration = new FlowValidationType("MissingNodeConfiguration");
        /// <summary>
        /// Constant MissingNodeInput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingNodeInput = new FlowValidationType("MissingNodeInput");
        /// <summary>
        /// Constant MissingNodeOutput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingNodeOutput = new FlowValidationType("MissingNodeOutput");
        /// <summary>
        /// Constant MissingStartingNodes for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MissingStartingNodes = new FlowValidationType("MissingStartingNodes");
        /// <summary>
        /// Constant MultipleLoopControllerNodes for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MultipleLoopControllerNodes = new FlowValidationType("MultipleLoopControllerNodes");
        /// <summary>
        /// Constant MultipleLoopInputNodes for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MultipleLoopInputNodes = new FlowValidationType("MultipleLoopInputNodes");
        /// <summary>
        /// Constant MultipleNodeInputConnections for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType MultipleNodeInputConnections = new FlowValidationType("MultipleNodeInputConnections");
        /// <summary>
        /// Constant UnfulfilledNodeInput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnfulfilledNodeInput = new FlowValidationType("UnfulfilledNodeInput");
        /// <summary>
        /// Constant UnknownConnectionCondition for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownConnectionCondition = new FlowValidationType("UnknownConnectionCondition");
        /// <summary>
        /// Constant UnknownConnectionSource for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownConnectionSource = new FlowValidationType("UnknownConnectionSource");
        /// <summary>
        /// Constant UnknownConnectionSourceOutput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownConnectionSourceOutput = new FlowValidationType("UnknownConnectionSourceOutput");
        /// <summary>
        /// Constant UnknownConnectionTarget for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownConnectionTarget = new FlowValidationType("UnknownConnectionTarget");
        /// <summary>
        /// Constant UnknownConnectionTargetInput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownConnectionTargetInput = new FlowValidationType("UnknownConnectionTargetInput");
        /// <summary>
        /// Constant UnknownNodeInput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownNodeInput = new FlowValidationType("UnknownNodeInput");
        /// <summary>
        /// Constant UnknownNodeOutput for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnknownNodeOutput = new FlowValidationType("UnknownNodeOutput");
        /// <summary>
        /// Constant UnreachableNode for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnreachableNode = new FlowValidationType("UnreachableNode");
        /// <summary>
        /// Constant UnsatisfiedConnectionConditions for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType UnsatisfiedConnectionConditions = new FlowValidationType("UnsatisfiedConnectionConditions");
        /// <summary>
        /// Constant Unspecified for FlowValidationType
        /// </summary>
        public static readonly FlowValidationType Unspecified = new FlowValidationType("Unspecified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowValidationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowValidationType FindValue(string value)
        {
            return FindValue<FlowValidationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowValidationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncludeExclude.
    /// </summary>
    public class IncludeExclude : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for IncludeExclude
        /// </summary>
        public static readonly IncludeExclude EXCLUDE = new IncludeExclude("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for IncludeExclude
        /// </summary>
        public static readonly IncludeExclude INCLUDE = new IncludeExclude("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncludeExclude(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncludeExclude FindValue(string value)
        {
            return FindValue<IncludeExclude>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncludeExclude(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncompatibleLoopNodeType.
    /// </summary>
    public class IncompatibleLoopNodeType : ConstantClass
    {

        /// <summary>
        /// Constant Collector for IncompatibleLoopNodeType
        /// </summary>
        public static readonly IncompatibleLoopNodeType Collector = new IncompatibleLoopNodeType("Collector");
        /// <summary>
        /// Constant Condition for IncompatibleLoopNodeType
        /// </summary>
        public static readonly IncompatibleLoopNodeType Condition = new IncompatibleLoopNodeType("Condition");
        /// <summary>
        /// Constant Input for IncompatibleLoopNodeType
        /// </summary>
        public static readonly IncompatibleLoopNodeType Input = new IncompatibleLoopNodeType("Input");
        /// <summary>
        /// Constant Iterator for IncompatibleLoopNodeType
        /// </summary>
        public static readonly IncompatibleLoopNodeType Iterator = new IncompatibleLoopNodeType("Iterator");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncompatibleLoopNodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncompatibleLoopNodeType FindValue(string value)
        {
            return FindValue<IncompatibleLoopNodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncompatibleLoopNodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionJobFilterAttribute.
    /// </summary>
    public class IngestionJobFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant STATUS for IngestionJobFilterAttribute
        /// </summary>
        public static readonly IngestionJobFilterAttribute STATUS = new IngestionJobFilterAttribute("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionJobFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobFilterAttribute FindValue(string value)
        {
            return FindValue<IngestionJobFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionJobFilterOperator.
    /// </summary>
    public class IngestionJobFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for IngestionJobFilterOperator
        /// </summary>
        public static readonly IngestionJobFilterOperator EQ = new IngestionJobFilterOperator("EQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionJobFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobFilterOperator FindValue(string value)
        {
            return FindValue<IngestionJobFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionJobSortByAttribute.
    /// </summary>
    public class IngestionJobSortByAttribute : ConstantClass
    {

        /// <summary>
        /// Constant STARTED_AT for IngestionJobSortByAttribute
        /// </summary>
        public static readonly IngestionJobSortByAttribute STARTED_AT = new IngestionJobSortByAttribute("STARTED_AT");
        /// <summary>
        /// Constant STATUS for IngestionJobSortByAttribute
        /// </summary>
        public static readonly IngestionJobSortByAttribute STATUS = new IngestionJobSortByAttribute("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionJobSortByAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobSortByAttribute FindValue(string value)
        {
            return FindValue<IngestionJobSortByAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobSortByAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionJobStatus.
    /// </summary>
    public class IngestionJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus COMPLETE = new IngestionJobStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus FAILED = new IngestionJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus IN_PROGRESS = new IngestionJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant STARTING for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus STARTING = new IngestionJobStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus STOPPED = new IngestionJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for IngestionJobStatus
        /// </summary>
        public static readonly IngestionJobStatus STOPPING = new IngestionJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionJobStatus FindValue(string value)
        {
            return FindValue<IngestionJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InlineContentType.
    /// </summary>
    public class InlineContentType : ConstantClass
    {

        /// <summary>
        /// Constant BYTE for InlineContentType
        /// </summary>
        public static readonly InlineContentType BYTE = new InlineContentType("BYTE");
        /// <summary>
        /// Constant TEXT for InlineContentType
        /// </summary>
        public static readonly InlineContentType TEXT = new InlineContentType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InlineContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InlineContentType FindValue(string value)
        {
            return FindValue<InlineContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InlineContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KnowledgeBaseState.
    /// </summary>
    public class KnowledgeBaseState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for KnowledgeBaseState
        /// </summary>
        public static readonly KnowledgeBaseState DISABLED = new KnowledgeBaseState("DISABLED");
        /// <summary>
        /// Constant ENABLED for KnowledgeBaseState
        /// </summary>
        public static readonly KnowledgeBaseState ENABLED = new KnowledgeBaseState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnowledgeBaseState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnowledgeBaseState FindValue(string value)
        {
            return FindValue<KnowledgeBaseState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnowledgeBaseState(string value)
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
        /// Constant CREATING for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus CREATING = new KnowledgeBaseStatus("CREATING");
        /// <summary>
        /// Constant DELETE_UNSUCCESSFUL for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus DELETE_UNSUCCESSFUL = new KnowledgeBaseStatus("DELETE_UNSUCCESSFUL");
        /// <summary>
        /// Constant DELETING for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus DELETING = new KnowledgeBaseStatus("DELETING");
        /// <summary>
        /// Constant FAILED for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus FAILED = new KnowledgeBaseStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for KnowledgeBaseStatus
        /// </summary>
        public static readonly KnowledgeBaseStatus UPDATING = new KnowledgeBaseStatus("UPDATING");

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
    /// Constants used for properties of type KnowledgeBaseStorageType.
    /// </summary>
    public class KnowledgeBaseStorageType : ConstantClass
    {

        /// <summary>
        /// Constant MONGO_DB_ATLAS for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType MONGO_DB_ATLAS = new KnowledgeBaseStorageType("MONGO_DB_ATLAS");
        /// <summary>
        /// Constant NEPTUNE_ANALYTICS for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType NEPTUNE_ANALYTICS = new KnowledgeBaseStorageType("NEPTUNE_ANALYTICS");
        /// <summary>
        /// Constant OPENSEARCH_MANAGED_CLUSTER for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType OPENSEARCH_MANAGED_CLUSTER = new KnowledgeBaseStorageType("OPENSEARCH_MANAGED_CLUSTER");
        /// <summary>
        /// Constant OPENSEARCH_SERVERLESS for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType OPENSEARCH_SERVERLESS = new KnowledgeBaseStorageType("OPENSEARCH_SERVERLESS");
        /// <summary>
        /// Constant PINECONE for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType PINECONE = new KnowledgeBaseStorageType("PINECONE");
        /// <summary>
        /// Constant RDS for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType RDS = new KnowledgeBaseStorageType("RDS");
        /// <summary>
        /// Constant REDIS_ENTERPRISE_CLOUD for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType REDIS_ENTERPRISE_CLOUD = new KnowledgeBaseStorageType("REDIS_ENTERPRISE_CLOUD");
        /// <summary>
        /// Constant S3_VECTORS for KnowledgeBaseStorageType
        /// </summary>
        public static readonly KnowledgeBaseStorageType S3_VECTORS = new KnowledgeBaseStorageType("S3_VECTORS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnowledgeBaseStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnowledgeBaseStorageType FindValue(string value)
        {
            return FindValue<KnowledgeBaseStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnowledgeBaseStorageType(string value)
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
        /// Constant KENDRA for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType KENDRA = new KnowledgeBaseType("KENDRA");
        /// <summary>
        /// Constant SQL for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType SQL = new KnowledgeBaseType("SQL");
        /// <summary>
        /// Constant VECTOR for KnowledgeBaseType
        /// </summary>
        public static readonly KnowledgeBaseType VECTOR = new KnowledgeBaseType("VECTOR");

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
    /// Constants used for properties of type MetadataSourceType.
    /// </summary>
    public class MetadataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant IN_LINE_ATTRIBUTE for MetadataSourceType
        /// </summary>
        public static readonly MetadataSourceType IN_LINE_ATTRIBUTE = new MetadataSourceType("IN_LINE_ATTRIBUTE");
        /// <summary>
        /// Constant S3_LOCATION for MetadataSourceType
        /// </summary>
        public static readonly MetadataSourceType S3_LOCATION = new MetadataSourceType("S3_LOCATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataSourceType FindValue(string value)
        {
            return FindValue<MetadataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataValueType.
    /// </summary>
    public class MetadataValueType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for MetadataValueType
        /// </summary>
        public static readonly MetadataValueType BOOLEAN = new MetadataValueType("BOOLEAN");
        /// <summary>
        /// Constant NUMBER for MetadataValueType
        /// </summary>
        public static readonly MetadataValueType NUMBER = new MetadataValueType("NUMBER");
        /// <summary>
        /// Constant STRING for MetadataValueType
        /// </summary>
        public static readonly MetadataValueType STRING = new MetadataValueType("STRING");
        /// <summary>
        /// Constant STRING_LIST for MetadataValueType
        /// </summary>
        public static readonly MetadataValueType STRING_LIST = new MetadataValueType("STRING_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataValueType FindValue(string value)
        {
            return FindValue<MetadataValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataValueType(string value)
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
    /// Constants used for properties of type ParsingModality.
    /// </summary>
    public class ParsingModality : ConstantClass
    {

        /// <summary>
        /// Constant MULTIMODAL for ParsingModality
        /// </summary>
        public static readonly ParsingModality MULTIMODAL = new ParsingModality("MULTIMODAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParsingModality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParsingModality FindValue(string value)
        {
            return FindValue<ParsingModality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParsingModality(string value)
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
        /// Constant BEDROCK_DATA_AUTOMATION for ParsingStrategy
        /// </summary>
        public static readonly ParsingStrategy BEDROCK_DATA_AUTOMATION = new ParsingStrategy("BEDROCK_DATA_AUTOMATION");
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
    /// Constants used for properties of type PromptTemplateType.
    /// </summary>
    public class PromptTemplateType : ConstantClass
    {

        /// <summary>
        /// Constant CHAT for PromptTemplateType
        /// </summary>
        public static readonly PromptTemplateType CHAT = new PromptTemplateType("CHAT");
        /// <summary>
        /// Constant TEXT for PromptTemplateType
        /// </summary>
        public static readonly PromptTemplateType TEXT = new PromptTemplateType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromptTemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromptTemplateType FindValue(string value)
        {
            return FindValue<PromptTemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromptTemplateType(string value)
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
        /// Constant MEMORY_SUMMARIZATION for PromptType
        /// </summary>
        public static readonly PromptType MEMORY_SUMMARIZATION = new PromptType("MEMORY_SUMMARIZATION");
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
    /// Constants used for properties of type QueryEngineType.
    /// </summary>
    public class QueryEngineType : ConstantClass
    {

        /// <summary>
        /// Constant REDSHIFT for QueryEngineType
        /// </summary>
        public static readonly QueryEngineType REDSHIFT = new QueryEngineType("REDSHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryEngineType FindValue(string value)
        {
            return FindValue<QueryEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftProvisionedAuthType.
    /// </summary>
    public class RedshiftProvisionedAuthType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for RedshiftProvisionedAuthType
        /// </summary>
        public static readonly RedshiftProvisionedAuthType IAM = new RedshiftProvisionedAuthType("IAM");
        /// <summary>
        /// Constant USERNAME for RedshiftProvisionedAuthType
        /// </summary>
        public static readonly RedshiftProvisionedAuthType USERNAME = new RedshiftProvisionedAuthType("USERNAME");
        /// <summary>
        /// Constant USERNAME_PASSWORD for RedshiftProvisionedAuthType
        /// </summary>
        public static readonly RedshiftProvisionedAuthType USERNAME_PASSWORD = new RedshiftProvisionedAuthType("USERNAME_PASSWORD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftProvisionedAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftProvisionedAuthType FindValue(string value)
        {
            return FindValue<RedshiftProvisionedAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftProvisionedAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftQueryEngineStorageType.
    /// </summary>
    public class RedshiftQueryEngineStorageType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_DATA_CATALOG for RedshiftQueryEngineStorageType
        /// </summary>
        public static readonly RedshiftQueryEngineStorageType AWS_DATA_CATALOG = new RedshiftQueryEngineStorageType("AWS_DATA_CATALOG");
        /// <summary>
        /// Constant REDSHIFT for RedshiftQueryEngineStorageType
        /// </summary>
        public static readonly RedshiftQueryEngineStorageType REDSHIFT = new RedshiftQueryEngineStorageType("REDSHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftQueryEngineStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftQueryEngineStorageType FindValue(string value)
        {
            return FindValue<RedshiftQueryEngineStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftQueryEngineStorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftQueryEngineType.
    /// </summary>
    public class RedshiftQueryEngineType : ConstantClass
    {

        /// <summary>
        /// Constant PROVISIONED for RedshiftQueryEngineType
        /// </summary>
        public static readonly RedshiftQueryEngineType PROVISIONED = new RedshiftQueryEngineType("PROVISIONED");
        /// <summary>
        /// Constant SERVERLESS for RedshiftQueryEngineType
        /// </summary>
        public static readonly RedshiftQueryEngineType SERVERLESS = new RedshiftQueryEngineType("SERVERLESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftQueryEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftQueryEngineType FindValue(string value)
        {
            return FindValue<RedshiftQueryEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftQueryEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedshiftServerlessAuthType.
    /// </summary>
    public class RedshiftServerlessAuthType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for RedshiftServerlessAuthType
        /// </summary>
        public static readonly RedshiftServerlessAuthType IAM = new RedshiftServerlessAuthType("IAM");
        /// <summary>
        /// Constant USERNAME_PASSWORD for RedshiftServerlessAuthType
        /// </summary>
        public static readonly RedshiftServerlessAuthType USERNAME_PASSWORD = new RedshiftServerlessAuthType("USERNAME_PASSWORD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedshiftServerlessAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedshiftServerlessAuthType FindValue(string value)
        {
            return FindValue<RedshiftServerlessAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedshiftServerlessAuthType(string value)
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
    /// Constants used for properties of type SalesforceAuthType.
    /// </summary>
    public class SalesforceAuthType : ConstantClass
    {

        /// <summary>
        /// Constant OAUTH2_CLIENT_CREDENTIALS for SalesforceAuthType
        /// </summary>
        public static readonly SalesforceAuthType OAUTH2_CLIENT_CREDENTIALS = new SalesforceAuthType("OAUTH2_CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceAuthType FindValue(string value)
        {
            return FindValue<SalesforceAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharePointAuthType.
    /// </summary>
    public class SharePointAuthType : ConstantClass
    {

        /// <summary>
        /// Constant OAUTH2_CLIENT_CREDENTIALS for SharePointAuthType
        /// </summary>
        public static readonly SharePointAuthType OAUTH2_CLIENT_CREDENTIALS = new SharePointAuthType("OAUTH2_CLIENT_CREDENTIALS");
        /// <summary>
        /// Constant OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS for SharePointAuthType
        /// </summary>
        public static readonly SharePointAuthType OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS = new SharePointAuthType("OAUTH2_SHAREPOINT_APP_ONLY_CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharePointAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharePointAuthType FindValue(string value)
        {
            return FindValue<SharePointAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharePointAuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharePointHostType.
    /// </summary>
    public class SharePointHostType : ConstantClass
    {

        /// <summary>
        /// Constant ONLINE for SharePointHostType
        /// </summary>
        public static readonly SharePointHostType ONLINE = new SharePointHostType("ONLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharePointHostType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharePointHostType FindValue(string value)
        {
            return FindValue<SharePointHostType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharePointHostType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepType.
    /// </summary>
    public class StepType : ConstantClass
    {

        /// <summary>
        /// Constant POST_CHUNKING for StepType
        /// </summary>
        public static readonly StepType POST_CHUNKING = new StepType("POST_CHUNKING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepType FindValue(string value)
        {
            return FindValue<StepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupplementalDataStorageLocationType.
    /// </summary>
    public class SupplementalDataStorageLocationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for SupplementalDataStorageLocationType
        /// </summary>
        public static readonly SupplementalDataStorageLocationType S3 = new SupplementalDataStorageLocationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupplementalDataStorageLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupplementalDataStorageLocationType FindValue(string value)
        {
            return FindValue<SupplementalDataStorageLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupplementalDataStorageLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportedLanguages.
    /// </summary>
    public class SupportedLanguages : ConstantClass
    {

        /// <summary>
        /// Constant Python_3 for SupportedLanguages
        /// </summary>
        public static readonly SupportedLanguages Python_3 = new SupportedLanguages("Python_3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedLanguages(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedLanguages FindValue(string value)
        {
            return FindValue<SupportedLanguages>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedLanguages(string value)
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
        /// Constant Array for Type
        /// </summary>
        public static readonly Type Array = new Type("array");
        /// <summary>
        /// Constant Boolean for Type
        /// </summary>
        public static readonly Type Boolean = new Type("boolean");
        /// <summary>
        /// Constant Integer for Type
        /// </summary>
        public static readonly Type Integer = new Type("integer");
        /// <summary>
        /// Constant Number for Type
        /// </summary>
        public static readonly Type Number = new Type("number");
        /// <summary>
        /// Constant String for Type
        /// </summary>
        public static readonly Type String = new Type("string");

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
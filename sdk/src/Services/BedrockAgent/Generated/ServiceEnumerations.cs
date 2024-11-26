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
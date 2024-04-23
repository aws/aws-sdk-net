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
        /// Constant NONE for ChunkingStrategy
        /// </summary>
        public static readonly ChunkingStrategy NONE = new ChunkingStrategy("NONE");

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
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus AVAILABLE = new DataSourceStatus("AVAILABLE");
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
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");

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

}
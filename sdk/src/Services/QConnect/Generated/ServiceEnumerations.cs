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
        /// Constant GENERATIVE_ANSWER for QueryResultType
        /// </summary>
        public static readonly QueryResultType GENERATIVE_ANSWER = new QueryResultType("GENERATIVE_ANSWER");
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
        /// Constant GENERATIVE_ANSWER for RecommendationType
        /// </summary>
        public static readonly RecommendationType GENERATIVE_ANSWER = new RecommendationType("GENERATIVE_ANSWER");
        /// <summary>
        /// Constant GENERATIVE_RESPONSE for RecommendationType
        /// </summary>
        public static readonly RecommendationType GENERATIVE_RESPONSE = new RecommendationType("GENERATIVE_RESPONSE");
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

}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.OpenSearchMemory
{
    /// <summary>
    /// Constants used for properties of type BatchGetEventErrorCode.
    /// </summary>
    public class BatchGetEventErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant ACCESS_DENIED for BatchGetEventErrorCode
        /// </summary>
        public static readonly BatchGetEventErrorCode ACCESS_DENIED = new BatchGetEventErrorCode("ACCESS_DENIED");

        /// <summary>
        /// Constant INTERNAL_SERVER for BatchGetEventErrorCode
        /// </summary>
        public static readonly BatchGetEventErrorCode INTERNAL_SERVER = new BatchGetEventErrorCode("INTERNAL_SERVER");

        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for BatchGetEventErrorCode
        /// </summary>
        public static readonly BatchGetEventErrorCode RESOURCE_NOT_FOUND = new BatchGetEventErrorCode("RESOURCE_NOT_FOUND");

        /// <summary>
        /// Constant THROTTLING for BatchGetEventErrorCode
        /// </summary>
        public static readonly BatchGetEventErrorCode THROTTLING = new BatchGetEventErrorCode("THROTTLING");

        /// <summary>
        /// Constructs a custom BatchGetEventErrorCode for a value not among the defined constants.
        /// </summary>
        public BatchGetEventErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetEventErrorCode FindValue(string value)
        {
            return FindValue<BatchGetEventErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetEventErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BlobContentType.
    /// </summary>
    public class BlobContentType : ConstantClass
    {
        /// <summary>
        /// Constant ApplicationPdf for BlobContentType
        /// </summary>
        public static readonly BlobContentType ApplicationPdf = new BlobContentType("application/pdf");

        /// <summary>
        /// Constant ImageJpeg for BlobContentType
        /// </summary>
        public static readonly BlobContentType ImageJpeg = new BlobContentType("image/jpeg");

        /// <summary>
        /// Constant ImagePng for BlobContentType
        /// </summary>
        public static readonly BlobContentType ImagePng = new BlobContentType("image/png");

        /// <summary>
        /// Constructs a custom BlobContentType for a value not among the defined constants.
        /// </summary>
        public BlobContentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlobContentType FindValue(string value)
        {
            return FindValue<BlobContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlobContentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MemorySortField.
    /// </summary>
    public class MemorySortField : ConstantClass
    {
        /// <summary>
        /// Constant CREATED_AT for MemorySortField
        /// </summary>
        public static readonly MemorySortField CREATED_AT = new MemorySortField("CREATED_AT");

        /// <summary>
        /// Constant UPDATED_AT for MemorySortField
        /// </summary>
        public static readonly MemorySortField UPDATED_AT = new MemorySortField("UPDATED_AT");

        /// <summary>
        /// Constructs a custom MemorySortField for a value not among the defined constants.
        /// </summary>
        public MemorySortField(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemorySortField FindValue(string value)
        {
            return FindValue<MemorySortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemorySortField(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MemoryStrategyType.
    /// </summary>
    public class MemoryStrategyType : ConstantClass
    {
        /// <summary>
        /// Constant CUSTOM for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType CUSTOM = new MemoryStrategyType("CUSTOM");

        /// <summary>
        /// Constant SEMANTIC for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType SEMANTIC = new MemoryStrategyType("SEMANTIC");

        /// <summary>
        /// Constant SUMMARY for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType SUMMARY = new MemoryStrategyType("SUMMARY");

        /// <summary>
        /// Constructs a custom MemoryStrategyType for a value not among the defined constants.
        /// </summary>
        public MemoryStrategyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryStrategyType FindValue(string value)
        {
            return FindValue<MemoryStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryStrategyType(string value)
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
        /// Constant CUSTOM for MemoryType
        /// </summary>
        public static readonly MemoryType CUSTOM = new MemoryType("CUSTOM");

        /// <summary>
        /// Constant SEMANTIC for MemoryType
        /// </summary>
        public static readonly MemoryType SEMANTIC = new MemoryType("SEMANTIC");

        /// <summary>
        /// Constant SUMMARY for MemoryType
        /// </summary>
        public static readonly MemoryType SUMMARY = new MemoryType("SUMMARY");

        /// <summary>
        /// Constructs a custom MemoryType for a value not among the defined constants.
        /// </summary>
        public MemoryType(string value) : base(value) { }

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
    /// Constants used for properties of type MessageRole.
    /// </summary>
    public class MessageRole : ConstantClass
    {
        /// <summary>
        /// Constant ASSISTANT for MessageRole
        /// </summary>
        public static readonly MessageRole ASSISTANT = new MessageRole("ASSISTANT");

        /// <summary>
        /// Constant SYSTEM for MessageRole
        /// </summary>
        public static readonly MessageRole SYSTEM = new MessageRole("SYSTEM");

        /// <summary>
        /// Constant USER for MessageRole
        /// </summary>
        public static readonly MessageRole USER = new MessageRole("USER");

        /// <summary>
        /// Constructs a custom MessageRole for a value not among the defined constants.
        /// </summary>
        public MessageRole(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageRole FindValue(string value)
        {
            return FindValue<MessageRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageRole(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MetadataMode.
    /// </summary>
    public class MetadataMode : ConstantClass
    {
        /// <summary>
        /// Constant MERGE for MetadataMode
        /// </summary>
        public static readonly MetadataMode MERGE = new MetadataMode("MERGE");

        /// <summary>
        /// Constant REPLACE for MetadataMode
        /// </summary>
        public static readonly MetadataMode REPLACE = new MetadataMode("REPLACE");

        /// <summary>
        /// Constructs a custom MetadataMode for a value not among the defined constants.
        /// </summary>
        public MetadataMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataMode FindValue(string value)
        {
            return FindValue<MetadataMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataMode(string value)
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
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");

        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// Constructs a custom SortOrder for a value not among the defined constants.
        /// </summary>
        public SortOrder(string value) : base(value) { }

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
    /// Constants used for properties of type SpaceStatus.
    /// </summary>
    public class SpaceStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus ACTIVE = new SpaceStatus("ACTIVE");

        /// <summary>
        /// Constant CREATING for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus CREATING = new SpaceStatus("CREATING");

        /// <summary>
        /// Constant DELETED for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus DELETED = new SpaceStatus("DELETED");

        /// <summary>
        /// Constant DELETING for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus DELETING = new SpaceStatus("DELETING");

        /// <summary>
        /// Constant FAILED for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus FAILED = new SpaceStatus("FAILED");

        /// <summary>
        /// Constant UPDATING for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus UPDATING = new SpaceStatus("UPDATING");

        /// <summary>
        /// Constructs a custom SpaceStatus for a value not among the defined constants.
        /// </summary>
        public SpaceStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpaceStatus FindValue(string value)
        {
            return FindValue<SpaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpaceStatus(string value)
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
        /// Constant DisallowedQueryType for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DisallowedQueryType = new ValidationExceptionReason("disallowedQueryType");

        /// <summary>
        /// Constant FieldIndexMismatch for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldIndexMismatch = new ValidationExceptionReason("fieldIndexMismatch");

        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");

        /// <summary>
        /// Constant InvalidNextToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidNextToken = new ValidationExceptionReason("invalidNextToken");

        /// <summary>
        /// Constant MalformedQueryBody for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MalformedQueryBody = new ValidationExceptionReason("malformedQueryBody");

        /// <summary>
        /// Constant NonFilterableField for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason NonFilterableField = new ValidationExceptionReason("nonFilterableField");

        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");

        /// <summary>
        /// Constant QueryBodyTooLarge for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QueryBodyTooLarge = new ValidationExceptionReason("queryBodyTooLarge");

        /// <summary>
        /// Constant QueryNestingTooDeep for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QueryNestingTooDeep = new ValidationExceptionReason("queryNestingTooDeep");

        /// <summary>
        /// Constant UnboundedPattern for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnboundedPattern = new ValidationExceptionReason("unboundedPattern");

        /// <summary>
        /// Constant UnknownField for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownField = new ValidationExceptionReason("unknownField");

        /// <summary>
        /// Constant UnsupportedField for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedField = new ValidationExceptionReason("unsupportedField");

        /// <summary>
        /// Constant UnsupportedParameter for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedParameter = new ValidationExceptionReason("unsupportedParameter");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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

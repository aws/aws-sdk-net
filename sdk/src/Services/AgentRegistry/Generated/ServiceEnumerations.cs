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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AgentRegistry
{

    /// <summary>
    /// Constants used for properties of type BatchGetDiscoverableRegistryRecordErrorCode.
    /// </summary>
    public class BatchGetDiscoverableRegistryRecordErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for BatchGetDiscoverableRegistryRecordErrorCode
        /// </summary>
        public static readonly BatchGetDiscoverableRegistryRecordErrorCode ACCESS_DENIED = new BatchGetDiscoverableRegistryRecordErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for BatchGetDiscoverableRegistryRecordErrorCode
        /// </summary>
        public static readonly BatchGetDiscoverableRegistryRecordErrorCode INTERNAL_ERROR = new BatchGetDiscoverableRegistryRecordErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for BatchGetDiscoverableRegistryRecordErrorCode
        /// </summary>
        public static readonly BatchGetDiscoverableRegistryRecordErrorCode RESOURCE_NOT_FOUND = new BatchGetDiscoverableRegistryRecordErrorCode("RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetDiscoverableRegistryRecordErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetDiscoverableRegistryRecordErrorCode FindValue(string value)
        {
            return FindValue<BatchGetDiscoverableRegistryRecordErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetDiscoverableRegistryRecordErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordType.
    /// </summary>
    public class RecordType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for RecordType
        /// </summary>
        public static readonly RecordType AGENT = new RecordType("AGENT");
        /// <summary>
        /// Constant CUSTOM for RecordType
        /// </summary>
        public static readonly RecordType CUSTOM = new RecordType("CUSTOM");
        /// <summary>
        /// Constant MCP for RecordType
        /// </summary>
        public static readonly RecordType MCP = new RecordType("MCP");
        /// <summary>
        /// Constant SKILL for RecordType
        /// </summary>
        public static readonly RecordType SKILL = new RecordType("SKILL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordType FindValue(string value)
        {
            return FindValue<RecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordFilterName.
    /// </summary>
    public class RegistryRecordFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DescriptorType for RegistryRecordFilterName
        /// </summary>
        public static readonly RegistryRecordFilterName DescriptorType = new RegistryRecordFilterName("descriptorType");
        /// <summary>
        /// Constant RecordType for RegistryRecordFilterName
        /// </summary>
        public static readonly RegistryRecordFilterName RecordType = new RegistryRecordFilterName("recordType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordFilterName FindValue(string value)
        {
            return FindValue<RegistryRecordFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordFilterName(string value)
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
        /// Constant CREATE_FAILED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus CREATE_FAILED = new RegistryRecordStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus CREATING = new RegistryRecordStatus("CREATING");
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
        /// Constant UPDATE_FAILED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATE_FAILED = new RegistryRecordStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATING = new RegistryRecordStatus("UPDATING");

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
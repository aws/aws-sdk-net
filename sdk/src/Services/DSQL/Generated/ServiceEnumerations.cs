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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DSQL
{

    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ACTIVE = new ClusterStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETED = new ClusterStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus FAILED = new ClusterStatus("FAILED");
        /// <summary>
        /// Constant IDLE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus IDLE = new ClusterStatus("IDLE");
        /// <summary>
        /// Constant INACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus INACTIVE = new ClusterStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING_DELETE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus PENDING_DELETE = new ClusterStatus("PENDING_DELETE");
        /// <summary>
        /// Constant PENDING_SETUP for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus PENDING_SETUP = new ClusterStatus("PENDING_SETUP");
        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionStatus.
    /// </summary>
    public class EncryptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus ENABLED = new EncryptionStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus ENABLING = new EncryptionStatus("ENABLING");
        /// <summary>
        /// Constant KMS_KEY_INACCESSIBLE for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus KMS_KEY_INACCESSIBLE = new EncryptionStatus("KMS_KEY_INACCESSIBLE");
        /// <summary>
        /// Constant UPDATING for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus UPDATING = new EncryptionStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionStatus FindValue(string value)
        {
            return FindValue<EncryptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_OWNED_KMS_KEY = new EncryptionType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_MANAGED_KMS_KEY = new EncryptionType("CUSTOMER_MANAGED_KMS_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamFailureErrorCode.
    /// </summary>
    public class StreamFailureErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER_CMK_INACCESSIBLE for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode CLUSTER_CMK_INACCESSIBLE = new StreamFailureErrorCode("CLUSTER_CMK_INACCESSIBLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode INTERNAL_ERROR = new StreamFailureErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant KINESIS_ACCESS_DENIED for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode KINESIS_ACCESS_DENIED = new StreamFailureErrorCode("KINESIS_ACCESS_DENIED");
        /// <summary>
        /// Constant KINESIS_KMS_ACCESS_DENIED for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode KINESIS_KMS_ACCESS_DENIED = new StreamFailureErrorCode("KINESIS_KMS_ACCESS_DENIED");
        /// <summary>
        /// Constant KINESIS_OVERSIZE_RECORD for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode KINESIS_OVERSIZE_RECORD = new StreamFailureErrorCode("KINESIS_OVERSIZE_RECORD");
        /// <summary>
        /// Constant KINESIS_STREAM_NOT_FOUND for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode KINESIS_STREAM_NOT_FOUND = new StreamFailureErrorCode("KINESIS_STREAM_NOT_FOUND");
        /// <summary>
        /// Constant KINESIS_THROUGHPUT_EXCEEDED for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode KINESIS_THROUGHPUT_EXCEEDED = new StreamFailureErrorCode("KINESIS_THROUGHPUT_EXCEEDED");
        /// <summary>
        /// Constant ROLE_ACCESS_DENIED for StreamFailureErrorCode
        /// </summary>
        public static readonly StreamFailureErrorCode ROLE_ACCESS_DENIED = new StreamFailureErrorCode("ROLE_ACCESS_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamFailureErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamFailureErrorCode FindValue(string value)
        {
            return FindValue<StreamFailureErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamFailureErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamFormat.
    /// </summary>
    public class StreamFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for StreamFormat
        /// </summary>
        public static readonly StreamFormat JSON = new StreamFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamFormat FindValue(string value)
        {
            return FindValue<StreamFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamOrdering.
    /// </summary>
    public class StreamOrdering : ConstantClass
    {

        /// <summary>
        /// Constant UNORDERED for StreamOrdering
        /// </summary>
        public static readonly StreamOrdering UNORDERED = new StreamOrdering("UNORDERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamOrdering(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamOrdering FindValue(string value)
        {
            return FindValue<StreamOrdering>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamOrdering(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamStatus.
    /// </summary>
    public class StreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamStatus
        /// </summary>
        public static readonly StreamStatus ACTIVE = new StreamStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for StreamStatus
        /// </summary>
        public static readonly StreamStatus CREATING = new StreamStatus("CREATING");
        /// <summary>
        /// Constant DELETED for StreamStatus
        /// </summary>
        public static readonly StreamStatus DELETED = new StreamStatus("DELETED");
        /// <summary>
        /// Constant DELETING for StreamStatus
        /// </summary>
        public static readonly StreamStatus DELETING = new StreamStatus("DELETING");
        /// <summary>
        /// Constant FAILED for StreamStatus
        /// </summary>
        public static readonly StreamStatus FAILED = new StreamStatus("FAILED");
        /// <summary>
        /// Constant IMPAIRED for StreamStatus
        /// </summary>
        public static readonly StreamStatus IMPAIRED = new StreamStatus("IMPAIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamStatus FindValue(string value)
        {
            return FindValue<StreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamStatus(string value)
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
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant DeletionProtectionEnabled for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DeletionProtectionEnabled = new ValidationExceptionReason("deletionProtectionEnabled");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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
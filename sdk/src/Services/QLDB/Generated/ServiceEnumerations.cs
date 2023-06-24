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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QLDB
{

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
    /// Constants used for properties of type ErrorCause.
    /// </summary>
    public class ErrorCause : ConstantClass
    {

        /// <summary>
        /// Constant IAM_PERMISSION_REVOKED for ErrorCause
        /// </summary>
        public static readonly ErrorCause IAM_PERMISSION_REVOKED = new ErrorCause("IAM_PERMISSION_REVOKED");
        /// <summary>
        /// Constant KINESIS_STREAM_NOT_FOUND for ErrorCause
        /// </summary>
        public static readonly ErrorCause KINESIS_STREAM_NOT_FOUND = new ErrorCause("KINESIS_STREAM_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCause(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCause FindValue(string value)
        {
            return FindValue<ErrorCause>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCause(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportStatus.
    /// </summary>
    public class ExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExportStatus
        /// </summary>
        public static readonly ExportStatus CANCELLED = new ExportStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExportStatus
        /// </summary>
        public static readonly ExportStatus COMPLETED = new ExportStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for ExportStatus
        /// </summary>
        public static readonly ExportStatus IN_PROGRESS = new ExportStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatus FindValue(string value)
        {
            return FindValue<ExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LedgerState.
    /// </summary>
    public class LedgerState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for LedgerState
        /// </summary>
        public static readonly LedgerState ACTIVE = new LedgerState("ACTIVE");
        /// <summary>
        /// Constant CREATING for LedgerState
        /// </summary>
        public static readonly LedgerState CREATING = new LedgerState("CREATING");
        /// <summary>
        /// Constant DELETED for LedgerState
        /// </summary>
        public static readonly LedgerState DELETED = new LedgerState("DELETED");
        /// <summary>
        /// Constant DELETING for LedgerState
        /// </summary>
        public static readonly LedgerState DELETING = new LedgerState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LedgerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LedgerState FindValue(string value)
        {
            return FindValue<LedgerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LedgerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant ION_BINARY for OutputFormat
        /// </summary>
        public static readonly OutputFormat ION_BINARY = new OutputFormat("ION_BINARY");
        /// <summary>
        /// Constant ION_TEXT for OutputFormat
        /// </summary>
        public static readonly OutputFormat ION_TEXT = new OutputFormat("ION_TEXT");
        /// <summary>
        /// Constant JSON for OutputFormat
        /// </summary>
        public static readonly OutputFormat JSON = new OutputFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionsMode.
    /// </summary>
    public class PermissionsMode : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ALL for PermissionsMode
        /// </summary>
        public static readonly PermissionsMode ALLOW_ALL = new PermissionsMode("ALLOW_ALL");
        /// <summary>
        /// Constant STANDARD for PermissionsMode
        /// </summary>
        public static readonly PermissionsMode STANDARD = new PermissionsMode("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionsMode FindValue(string value)
        {
            return FindValue<PermissionsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectEncryptionType.
    /// </summary>
    public class S3ObjectEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant NO_ENCRYPTION for S3ObjectEncryptionType
        /// </summary>
        public static readonly S3ObjectEncryptionType NO_ENCRYPTION = new S3ObjectEncryptionType("NO_ENCRYPTION");
        /// <summary>
        /// Constant SSE_KMS for S3ObjectEncryptionType
        /// </summary>
        public static readonly S3ObjectEncryptionType SSE_KMS = new S3ObjectEncryptionType("SSE_KMS");
        /// <summary>
        /// Constant SSE_S3 for S3ObjectEncryptionType
        /// </summary>
        public static readonly S3ObjectEncryptionType SSE_S3 = new S3ObjectEncryptionType("SSE_S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectEncryptionType FindValue(string value)
        {
            return FindValue<S3ObjectEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectEncryptionType(string value)
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
        /// Constant CANCELED for StreamStatus
        /// </summary>
        public static readonly StreamStatus CANCELED = new StreamStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for StreamStatus
        /// </summary>
        public static readonly StreamStatus COMPLETED = new StreamStatus("COMPLETED");
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

}
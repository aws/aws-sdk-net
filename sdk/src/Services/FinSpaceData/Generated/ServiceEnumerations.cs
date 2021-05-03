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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FinSpaceData
{

    /// <summary>
    /// Constants used for properties of type ChangesetStatus.
    /// </summary>
    public class ChangesetStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus FAILED = new ChangesetStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus PENDING = new ChangesetStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus RUNNING = new ChangesetStatus("RUNNING");
        /// <summary>
        /// Constant STOP_REQUESTED for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus STOP_REQUESTED = new ChangesetStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant SUCCESS for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus SUCCESS = new ChangesetStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangesetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangesetStatus FindValue(string value)
        {
            return FindValue<ChangesetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangesetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant APPEND for ChangeType
        /// </summary>
        public static readonly ChangeType APPEND = new ChangeType("APPEND");
        /// <summary>
        /// Constant MODIFY for ChangeType
        /// </summary>
        public static readonly ChangeType MODIFY = new ChangeType("MODIFY");
        /// <summary>
        /// Constant REPLACE for ChangeType
        /// </summary>
        public static readonly ChangeType REPLACE = new ChangeType("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCategory.
    /// </summary>
    public class ErrorCategory : ConstantClass
    {

        /// <summary>
        /// Constant A_user_recoverable_error_has_occurred for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory A_user_recoverable_error_has_occurred = new ErrorCategory("A_user_recoverable_error_has_occurred");
        /// <summary>
        /// Constant An_internal_error_has_occurred for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory An_internal_error_has_occurred = new ErrorCategory("An_internal_error_has_occurred");
        /// <summary>
        /// Constant Cancelled for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory Cancelled = new ErrorCategory("Cancelled");
        /// <summary>
        /// Constant Missing_required_permission_to_perform_this_request for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory Missing_required_permission_to_perform_this_request = new ErrorCategory("Missing_required_permission_to_perform_this_request");
        /// <summary>
        /// Constant One_or_more_inputs_to_this_request_were_not_found for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory One_or_more_inputs_to_this_request_were_not_found = new ErrorCategory("One_or_more_inputs_to_this_request_were_not_found");
        /// <summary>
        /// Constant Service_limits_have_been_exceeded for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory Service_limits_have_been_exceeded = new ErrorCategory("Service_limits_have_been_exceeded");
        /// <summary>
        /// Constant The_inputs_to_this_request_are_invalid for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory The_inputs_to_this_request_are_invalid = new ErrorCategory("The_inputs_to_this_request_are_invalid");
        /// <summary>
        /// Constant The_system_temporarily_lacks_sufficient_resources_to_process_the_request for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory The_system_temporarily_lacks_sufficient_resources_to_process_the_request = new ErrorCategory("The_system_temporarily_lacks_sufficient_resources_to_process_the_request");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCategory FindValue(string value)
        {
            return FindValue<ErrorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormatType.
    /// </summary>
    public class FormatType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for FormatType
        /// </summary>
        public static readonly FormatType CSV = new FormatType("CSV");
        /// <summary>
        /// Constant JSON for FormatType
        /// </summary>
        public static readonly FormatType JSON = new FormatType("JSON");
        /// <summary>
        /// Constant PARQUET for FormatType
        /// </summary>
        public static readonly FormatType PARQUET = new FormatType("PARQUET");
        /// <summary>
        /// Constant XML for FormatType
        /// </summary>
        public static readonly FormatType XML = new FormatType("XML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormatType FindValue(string value)
        {
            return FindValue<FormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {

        /// <summary>
        /// Constant INGESTION for LocationType
        /// </summary>
        public static readonly LocationType INGESTION = new LocationType("INGESTION");
        /// <summary>
        /// Constant SAGEMAKER for LocationType
        /// </summary>
        public static readonly LocationType SAGEMAKER = new LocationType("SAGEMAKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for SourceType
        /// </summary>
        public static readonly SourceType S3 = new SourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }

}
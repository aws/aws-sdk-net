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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Artifact
{

    /// <summary>
    /// Constants used for properties of type AcceptanceType.
    /// </summary>
    public class AcceptanceType : ConstantClass
    {

        /// <summary>
        /// Constant EXPLICIT for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType EXPLICIT = new AcceptanceType("EXPLICIT");
        /// <summary>
        /// Constant PASSTHROUGH for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType PASSTHROUGH = new AcceptanceType("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptanceType FindValue(string value)
        {
            return FindValue<AcceptanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgreementType.
    /// </summary>
    public class AgreementType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for AgreementType
        /// </summary>
        public static readonly AgreementType CUSTOM = new AgreementType("CUSTOM");
        /// <summary>
        /// Constant DEFAULT for AgreementType
        /// </summary>
        public static readonly AgreementType DEFAULT = new AgreementType("DEFAULT");
        /// <summary>
        /// Constant MODIFIED for AgreementType
        /// </summary>
        public static readonly AgreementType MODIFIED = new AgreementType("MODIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgreementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgreementType FindValue(string value)
        {
            return FindValue<AgreementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgreementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerAgreementState.
    /// </summary>
    public class CustomerAgreementState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CustomerAgreementState
        /// </summary>
        public static readonly CustomerAgreementState ACTIVE = new CustomerAgreementState("ACTIVE");
        /// <summary>
        /// Constant AWS_TERMINATED for CustomerAgreementState
        /// </summary>
        public static readonly CustomerAgreementState AWS_TERMINATED = new CustomerAgreementState("AWS_TERMINATED");
        /// <summary>
        /// Constant CUSTOMER_TERMINATED for CustomerAgreementState
        /// </summary>
        public static readonly CustomerAgreementState CUSTOMER_TERMINATED = new CustomerAgreementState("CUSTOMER_TERMINATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerAgreementState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerAgreementState FindValue(string value)
        {
            return FindValue<CustomerAgreementState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerAgreementState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationSubscriptionStatus.
    /// </summary>
    public class NotificationSubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SUBSCRIBED for NotificationSubscriptionStatus
        /// </summary>
        public static readonly NotificationSubscriptionStatus NOT_SUBSCRIBED = new NotificationSubscriptionStatus("NOT_SUBSCRIBED");
        /// <summary>
        /// Constant SUBSCRIBED for NotificationSubscriptionStatus
        /// </summary>
        public static readonly NotificationSubscriptionStatus SUBSCRIBED = new NotificationSubscriptionStatus("SUBSCRIBED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationSubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationSubscriptionStatus FindValue(string value)
        {
            return FindValue<NotificationSubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationSubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublishedState.
    /// </summary>
    public class PublishedState : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED for PublishedState
        /// </summary>
        public static readonly PublishedState PUBLISHED = new PublishedState("PUBLISHED");
        /// <summary>
        /// Constant UNPUBLISHED for PublishedState
        /// </summary>
        public static readonly PublishedState UNPUBLISHED = new PublishedState("UNPUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublishedState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublishedState FindValue(string value)
        {
            return FindValue<PublishedState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublishedState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadState.
    /// </summary>
    public class UploadState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for UploadState
        /// </summary>
        public static readonly UploadState COMPLETE = new UploadState("COMPLETE");
        /// <summary>
        /// Constant FAILED for UploadState
        /// </summary>
        public static readonly UploadState FAILED = new UploadState("FAILED");
        /// <summary>
        /// Constant FAULT for UploadState
        /// </summary>
        public static readonly UploadState FAULT = new UploadState("FAULT");
        /// <summary>
        /// Constant PROCESSING for UploadState
        /// </summary>
        public static readonly UploadState PROCESSING = new UploadState("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadState FindValue(string value)
        {
            return FindValue<UploadState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadState(string value)
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
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant InvalidToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidToken = new ValidationExceptionReason("invalidToken");
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
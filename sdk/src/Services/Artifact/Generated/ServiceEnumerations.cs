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
    /// Constants used for properties of type InputSource.
    /// </summary>
    public class InputSource : ConstantClass
    {

        /// <summary>
        /// Constant FILE for InputSource
        /// </summary>
        public static readonly InputSource FILE = new InputSource("FILE");
        /// <summary>
        /// Constant TEXT for InputSource
        /// </summary>
        public static readonly InputSource TEXT = new InputSource("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputSource FindValue(string value)
        {
            return FindValue<InputSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InquiryStatus.
    /// </summary>
    public class InquiryStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for InquiryStatus
        /// </summary>
        public static readonly InquiryStatus COMPLETED = new InquiryStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for InquiryStatus
        /// </summary>
        public static readonly InquiryStatus FAILED = new InquiryStatus("FAILED");
        /// <summary>
        /// Constant HUMAN_REVIEW for InquiryStatus
        /// </summary>
        public static readonly InquiryStatus HUMAN_REVIEW = new InquiryStatus("HUMAN_REVIEW");
        /// <summary>
        /// Constant PROCESSING for InquiryStatus
        /// </summary>
        public static readonly InquiryStatus PROCESSING = new InquiryStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InquiryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InquiryStatus FindValue(string value)
        {
            return FindValue<InquiryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InquiryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InquiryStatusMessage.
    /// </summary>
    public class InquiryStatusMessage : ConstantClass
    {

        /// <summary>
        /// Constant AnInternalErrorOccurredWhileProcessingTheInquiryTryAgainAtALaterTime for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage AnInternalErrorOccurredWhileProcessingTheInquiryTryAgainAtALaterTime = new InquiryStatusMessage("An internal error occurred while processing the inquiry. Try again at a later time.");
        /// <summary>
        /// Constant ComplianceInquiryProcessingIsComplete for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage ComplianceInquiryProcessingIsComplete = new InquiryStatusMessage("Compliance inquiry processing is complete.");
        /// <summary>
        /// Constant ComplianceInquiryProcessingIsCompleteOneOrMoreQueriesEncounteredErrorsDuringProcessing for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage ComplianceInquiryProcessingIsCompleteOneOrMoreQueriesEncounteredErrorsDuringProcessing = new InquiryStatusMessage("Compliance inquiry processing is complete. One or more queries encountered errors during processing.");
        /// <summary>
        /// Constant ComplianceInquiryProcessingIsInProgress for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage ComplianceInquiryProcessingIsInProgress = new InquiryStatusMessage("Compliance inquiry processing is in-progress.");
        /// <summary>
        /// Constant HumanReviewIsInProgress for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage HumanReviewIsInProgress = new InquiryStatusMessage("Human review is in progress.");
        /// <summary>
        /// Constant MalwareWasDetectedOnTheFileProvideANewFileAndTryAgain for InquiryStatusMessage
        /// </summary>
        public static readonly InquiryStatusMessage MalwareWasDetectedOnTheFileProvideANewFileAndTryAgain = new InquiryStatusMessage("Malware was detected on the file. Provide a new file and try again.");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InquiryStatusMessage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InquiryStatusMessage FindValue(string value)
        {
            return FindValue<InquiryStatusMessage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InquiryStatusMessage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InquirySupportMode.
    /// </summary>
    public class InquirySupportMode : ConstantClass
    {

        /// <summary>
        /// Constant AI_ONLY for InquirySupportMode
        /// </summary>
        public static readonly InquirySupportMode AI_ONLY = new InquirySupportMode("AI_ONLY");
        /// <summary>
        /// Constant FULL_SUPPORT for InquirySupportMode
        /// </summary>
        public static readonly InquirySupportMode FULL_SUPPORT = new InquirySupportMode("FULL_SUPPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InquirySupportMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InquirySupportMode FindValue(string value)
        {
            return FindValue<InquirySupportMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InquirySupportMode(string value)
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
    /// Constants used for properties of type QueryStatus.
    /// </summary>
    public class QueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for QueryStatus
        /// </summary>
        public static readonly QueryStatus COMPLETED = new QueryStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FAILED = new QueryStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for QueryStatus
        /// </summary>
        public static readonly QueryStatus PROCESSING = new QueryStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatus FindValue(string value)
        {
            return FindValue<QueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStatusMessage.
    /// </summary>
    public class QueryStatusMessage : ConstantClass
    {

        /// <summary>
        /// Constant AnInternalErrorOccurredWhileProcessingTheQueryTryAgainAtALaterTime for QueryStatusMessage
        /// </summary>
        public static readonly QueryStatusMessage AnInternalErrorOccurredWhileProcessingTheQueryTryAgainAtALaterTime = new QueryStatusMessage("An internal error occurred while processing the query. Try again at a later time.");
        /// <summary>
        /// Constant QueryContainsRestrictedOrUnsupportedContent for QueryStatusMessage
        /// </summary>
        public static readonly QueryStatusMessage QueryContainsRestrictedOrUnsupportedContent = new QueryStatusMessage("Query contains restricted or unsupported content.");
        /// <summary>
        /// Constant QueryIsPendingHumanReview for QueryStatusMessage
        /// </summary>
        public static readonly QueryStatusMessage QueryIsPendingHumanReview = new QueryStatusMessage("Query is pending human review.");
        /// <summary>
        /// Constant QueryProcessingIsComplete for QueryStatusMessage
        /// </summary>
        public static readonly QueryStatusMessage QueryProcessingIsComplete = new QueryStatusMessage("Query processing is complete.");
        /// <summary>
        /// Constant QueryProcessingIsInProgress for QueryStatusMessage
        /// </summary>
        public static readonly QueryStatusMessage QueryProcessingIsInProgress = new QueryStatusMessage("Query processing is in-progress.");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatusMessage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatusMessage FindValue(string value)
        {
            return FindValue<QueryStatusMessage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatusMessage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewType.
    /// </summary>
    public class ReviewType : ConstantClass
    {

        /// <summary>
        /// Constant AI for ReviewType
        /// </summary>
        public static readonly ReviewType AI = new ReviewType("AI");
        /// <summary>
        /// Constant HUMAN for ReviewType
        /// </summary>
        public static readonly ReviewType HUMAN = new ReviewType("HUMAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewType FindValue(string value)
        {
            return FindValue<ReviewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewType(string value)
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
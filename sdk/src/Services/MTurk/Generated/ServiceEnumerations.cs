/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MTurk
{

    /// <summary>
    /// Constants used for properties of type AssignmentStatus.
    /// </summary>
    public class AssignmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus Approved = new AssignmentStatus("Approved");
        /// <summary>
        /// Constant Rejected for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus Rejected = new AssignmentStatus("Rejected");
        /// <summary>
        /// Constant Submitted for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus Submitted = new AssignmentStatus("Submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatus FindValue(string value)
        {
            return FindValue<AssignmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparator.
    /// </summary>
    public class Comparator : ConstantClass
    {

        /// <summary>
        /// Constant DoesNotExist for Comparator
        /// </summary>
        public static readonly Comparator DoesNotExist = new Comparator("DoesNotExist");
        /// <summary>
        /// Constant EqualTo for Comparator
        /// </summary>
        public static readonly Comparator EqualTo = new Comparator("EqualTo");
        /// <summary>
        /// Constant Exists for Comparator
        /// </summary>
        public static readonly Comparator Exists = new Comparator("Exists");
        /// <summary>
        /// Constant GreaterThan for Comparator
        /// </summary>
        public static readonly Comparator GreaterThan = new Comparator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqualTo for Comparator
        /// </summary>
        public static readonly Comparator GreaterThanOrEqualTo = new Comparator("GreaterThanOrEqualTo");
        /// <summary>
        /// Constant In for Comparator
        /// </summary>
        public static readonly Comparator In = new Comparator("In");
        /// <summary>
        /// Constant LessThan for Comparator
        /// </summary>
        public static readonly Comparator LessThan = new Comparator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqualTo for Comparator
        /// </summary>
        public static readonly Comparator LessThanOrEqualTo = new Comparator("LessThanOrEqualTo");
        /// <summary>
        /// Constant NotEqualTo for Comparator
        /// </summary>
        public static readonly Comparator NotEqualTo = new Comparator("NotEqualTo");
        /// <summary>
        /// Constant NotIn for Comparator
        /// </summary>
        public static readonly Comparator NotIn = new Comparator("NotIn");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparator FindValue(string value)
        {
            return FindValue<Comparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant AssignmentAbandoned for EventType
        /// </summary>
        public static readonly EventType AssignmentAbandoned = new EventType("AssignmentAbandoned");
        /// <summary>
        /// Constant AssignmentAccepted for EventType
        /// </summary>
        public static readonly EventType AssignmentAccepted = new EventType("AssignmentAccepted");
        /// <summary>
        /// Constant AssignmentApproved for EventType
        /// </summary>
        public static readonly EventType AssignmentApproved = new EventType("AssignmentApproved");
        /// <summary>
        /// Constant AssignmentRejected for EventType
        /// </summary>
        public static readonly EventType AssignmentRejected = new EventType("AssignmentRejected");
        /// <summary>
        /// Constant AssignmentReturned for EventType
        /// </summary>
        public static readonly EventType AssignmentReturned = new EventType("AssignmentReturned");
        /// <summary>
        /// Constant AssignmentSubmitted for EventType
        /// </summary>
        public static readonly EventType AssignmentSubmitted = new EventType("AssignmentSubmitted");
        /// <summary>
        /// Constant HITCreated for EventType
        /// </summary>
        public static readonly EventType HITCreated = new EventType("HITCreated");
        /// <summary>
        /// Constant HITDisposed for EventType
        /// </summary>
        public static readonly EventType HITDisposed = new EventType("HITDisposed");
        /// <summary>
        /// Constant HITExpired for EventType
        /// </summary>
        public static readonly EventType HITExpired = new EventType("HITExpired");
        /// <summary>
        /// Constant HITExtended for EventType
        /// </summary>
        public static readonly EventType HITExtended = new EventType("HITExtended");
        /// <summary>
        /// Constant HITReviewable for EventType
        /// </summary>
        public static readonly EventType HITReviewable = new EventType("HITReviewable");
        /// <summary>
        /// Constant Ping for EventType
        /// </summary>
        public static readonly EventType Ping = new EventType("Ping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HITAccessActions.
    /// </summary>
    public class HITAccessActions : ConstantClass
    {

        /// <summary>
        /// Constant Accept for HITAccessActions
        /// </summary>
        public static readonly HITAccessActions Accept = new HITAccessActions("Accept");
        /// <summary>
        /// Constant DiscoverPreviewAndAccept for HITAccessActions
        /// </summary>
        public static readonly HITAccessActions DiscoverPreviewAndAccept = new HITAccessActions("DiscoverPreviewAndAccept");
        /// <summary>
        /// Constant PreviewAndAccept for HITAccessActions
        /// </summary>
        public static readonly HITAccessActions PreviewAndAccept = new HITAccessActions("PreviewAndAccept");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HITAccessActions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HITAccessActions FindValue(string value)
        {
            return FindValue<HITAccessActions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HITAccessActions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HITReviewStatus.
    /// </summary>
    public class HITReviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant MarkedForReview for HITReviewStatus
        /// </summary>
        public static readonly HITReviewStatus MarkedForReview = new HITReviewStatus("MarkedForReview");
        /// <summary>
        /// Constant NotReviewed for HITReviewStatus
        /// </summary>
        public static readonly HITReviewStatus NotReviewed = new HITReviewStatus("NotReviewed");
        /// <summary>
        /// Constant ReviewedAppropriate for HITReviewStatus
        /// </summary>
        public static readonly HITReviewStatus ReviewedAppropriate = new HITReviewStatus("ReviewedAppropriate");
        /// <summary>
        /// Constant ReviewedInappropriate for HITReviewStatus
        /// </summary>
        public static readonly HITReviewStatus ReviewedInappropriate = new HITReviewStatus("ReviewedInappropriate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HITReviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HITReviewStatus FindValue(string value)
        {
            return FindValue<HITReviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HITReviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HITStatus.
    /// </summary>
    public class HITStatus : ConstantClass
    {

        /// <summary>
        /// Constant Assignable for HITStatus
        /// </summary>
        public static readonly HITStatus Assignable = new HITStatus("Assignable");
        /// <summary>
        /// Constant Disposed for HITStatus
        /// </summary>
        public static readonly HITStatus Disposed = new HITStatus("Disposed");
        /// <summary>
        /// Constant Reviewable for HITStatus
        /// </summary>
        public static readonly HITStatus Reviewable = new HITStatus("Reviewable");
        /// <summary>
        /// Constant Reviewing for HITStatus
        /// </summary>
        public static readonly HITStatus Reviewing = new HITStatus("Reviewing");
        /// <summary>
        /// Constant Unassignable for HITStatus
        /// </summary>
        public static readonly HITStatus Unassignable = new HITStatus("Unassignable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HITStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HITStatus FindValue(string value)
        {
            return FindValue<HITStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HITStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationTransport.
    /// </summary>
    public class NotificationTransport : ConstantClass
    {

        /// <summary>
        /// Constant Email for NotificationTransport
        /// </summary>
        public static readonly NotificationTransport Email = new NotificationTransport("Email");
        /// <summary>
        /// Constant SNS for NotificationTransport
        /// </summary>
        public static readonly NotificationTransport SNS = new NotificationTransport("SNS");
        /// <summary>
        /// Constant SQS for NotificationTransport
        /// </summary>
        public static readonly NotificationTransport SQS = new NotificationTransport("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationTransport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationTransport FindValue(string value)
        {
            return FindValue<NotificationTransport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationTransport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotifyWorkersFailureCode.
    /// </summary>
    public class NotifyWorkersFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant HardFailure for NotifyWorkersFailureCode
        /// </summary>
        public static readonly NotifyWorkersFailureCode HardFailure = new NotifyWorkersFailureCode("HardFailure");
        /// <summary>
        /// Constant SoftFailure for NotifyWorkersFailureCode
        /// </summary>
        public static readonly NotifyWorkersFailureCode SoftFailure = new NotifyWorkersFailureCode("SoftFailure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotifyWorkersFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotifyWorkersFailureCode FindValue(string value)
        {
            return FindValue<NotifyWorkersFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotifyWorkersFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QualificationStatus.
    /// </summary>
    public class QualificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Granted for QualificationStatus
        /// </summary>
        public static readonly QualificationStatus Granted = new QualificationStatus("Granted");
        /// <summary>
        /// Constant Revoked for QualificationStatus
        /// </summary>
        public static readonly QualificationStatus Revoked = new QualificationStatus("Revoked");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QualificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QualificationStatus FindValue(string value)
        {
            return FindValue<QualificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QualificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QualificationTypeStatus.
    /// </summary>
    public class QualificationTypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for QualificationTypeStatus
        /// </summary>
        public static readonly QualificationTypeStatus Active = new QualificationTypeStatus("Active");
        /// <summary>
        /// Constant Inactive for QualificationTypeStatus
        /// </summary>
        public static readonly QualificationTypeStatus Inactive = new QualificationTypeStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QualificationTypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QualificationTypeStatus FindValue(string value)
        {
            return FindValue<QualificationTypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QualificationTypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewableHITStatus.
    /// </summary>
    public class ReviewableHITStatus : ConstantClass
    {

        /// <summary>
        /// Constant Reviewable for ReviewableHITStatus
        /// </summary>
        public static readonly ReviewableHITStatus Reviewable = new ReviewableHITStatus("Reviewable");
        /// <summary>
        /// Constant Reviewing for ReviewableHITStatus
        /// </summary>
        public static readonly ReviewableHITStatus Reviewing = new ReviewableHITStatus("Reviewing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewableHITStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewableHITStatus FindValue(string value)
        {
            return FindValue<ReviewableHITStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewableHITStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewActionStatus.
    /// </summary>
    public class ReviewActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ReviewActionStatus
        /// </summary>
        public static readonly ReviewActionStatus Cancelled = new ReviewActionStatus("Cancelled");
        /// <summary>
        /// Constant Failed for ReviewActionStatus
        /// </summary>
        public static readonly ReviewActionStatus Failed = new ReviewActionStatus("Failed");
        /// <summary>
        /// Constant Intended for ReviewActionStatus
        /// </summary>
        public static readonly ReviewActionStatus Intended = new ReviewActionStatus("Intended");
        /// <summary>
        /// Constant Succeeded for ReviewActionStatus
        /// </summary>
        public static readonly ReviewActionStatus Succeeded = new ReviewActionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewActionStatus FindValue(string value)
        {
            return FindValue<ReviewActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewPolicyLevel.
    /// </summary>
    public class ReviewPolicyLevel : ConstantClass
    {

        /// <summary>
        /// Constant Assignment for ReviewPolicyLevel
        /// </summary>
        public static readonly ReviewPolicyLevel Assignment = new ReviewPolicyLevel("Assignment");
        /// <summary>
        /// Constant HIT for ReviewPolicyLevel
        /// </summary>
        public static readonly ReviewPolicyLevel HIT = new ReviewPolicyLevel("HIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewPolicyLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewPolicyLevel FindValue(string value)
        {
            return FindValue<ReviewPolicyLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewPolicyLevel(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WellArchitected
{

    /// <summary>
    /// Constants used for properties of type DifferenceStatus.
    /// </summary>
    public class DifferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus DELETED = new DifferenceStatus("DELETED");
        /// <summary>
        /// Constant NEW for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus NEW = new DifferenceStatus("NEW");
        /// <summary>
        /// Constant UPDATED for DifferenceStatus
        /// </summary>
        public static readonly DifferenceStatus UPDATED = new DifferenceStatus("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DifferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DifferenceStatus FindValue(string value)
        {
            return FindValue<DifferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DifferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LensStatus.
    /// </summary>
    public class LensStatus : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT for LensStatus
        /// </summary>
        public static readonly LensStatus CURRENT = new LensStatus("CURRENT");
        /// <summary>
        /// Constant DEPRECATED for LensStatus
        /// </summary>
        public static readonly LensStatus DEPRECATED = new LensStatus("DEPRECATED");
        /// <summary>
        /// Constant NOT_CURRENT for LensStatus
        /// </summary>
        public static readonly LensStatus NOT_CURRENT = new LensStatus("NOT_CURRENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LensStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LensStatus FindValue(string value)
        {
            return FindValue<LensStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LensStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant LENS_VERSION_DEPRECATED for NotificationType
        /// </summary>
        public static readonly NotificationType LENS_VERSION_DEPRECATED = new NotificationType("LENS_VERSION_DEPRECATED");
        /// <summary>
        /// Constant LENS_VERSION_UPGRADED for NotificationType
        /// </summary>
        public static readonly NotificationType LENS_VERSION_UPGRADED = new NotificationType("LENS_VERSION_UPGRADED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for PermissionType
        /// </summary>
        public static readonly PermissionType CONTRIBUTOR = new PermissionType("CONTRIBUTOR");
        /// <summary>
        /// Constant READONLY for PermissionType
        /// </summary>
        public static readonly PermissionType READONLY = new PermissionType("READONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Risk.
    /// </summary>
    public class Risk : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Risk
        /// </summary>
        public static readonly Risk HIGH = new Risk("HIGH");
        /// <summary>
        /// Constant MEDIUM for Risk
        /// </summary>
        public static readonly Risk MEDIUM = new Risk("MEDIUM");
        /// <summary>
        /// Constant NONE for Risk
        /// </summary>
        public static readonly Risk NONE = new Risk("NONE");
        /// <summary>
        /// Constant NOT_APPLICABLE for Risk
        /// </summary>
        public static readonly Risk NOT_APPLICABLE = new Risk("NOT_APPLICABLE");
        /// <summary>
        /// Constant UNANSWERED for Risk
        /// </summary>
        public static readonly Risk UNANSWERED = new Risk("UNANSWERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Risk(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Risk FindValue(string value)
        {
            return FindValue<Risk>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Risk(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareInvitationAction.
    /// </summary>
    public class ShareInvitationAction : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for ShareInvitationAction
        /// </summary>
        public static readonly ShareInvitationAction ACCEPT = new ShareInvitationAction("ACCEPT");
        /// <summary>
        /// Constant REJECT for ShareInvitationAction
        /// </summary>
        public static readonly ShareInvitationAction REJECT = new ShareInvitationAction("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareInvitationAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareInvitationAction FindValue(string value)
        {
            return FindValue<ShareInvitationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareInvitationAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareStatus.
    /// </summary>
    public class ShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for ShareStatus
        /// </summary>
        public static readonly ShareStatus ACCEPTED = new ShareStatus("ACCEPTED");
        /// <summary>
        /// Constant EXPIRED for ShareStatus
        /// </summary>
        public static readonly ShareStatus EXPIRED = new ShareStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for ShareStatus
        /// </summary>
        public static readonly ShareStatus PENDING = new ShareStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for ShareStatus
        /// </summary>
        public static readonly ShareStatus REJECTED = new ShareStatus("REJECTED");
        /// <summary>
        /// Constant REVOKED for ShareStatus
        /// </summary>
        public static readonly ShareStatus REVOKED = new ShareStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatus FindValue(string value)
        {
            return FindValue<ShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatus(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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


    /// <summary>
    /// Constants used for properties of type WorkloadEnvironment.
    /// </summary>
    public class WorkloadEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant PREPRODUCTION for WorkloadEnvironment
        /// </summary>
        public static readonly WorkloadEnvironment PREPRODUCTION = new WorkloadEnvironment("PREPRODUCTION");
        /// <summary>
        /// Constant PRODUCTION for WorkloadEnvironment
        /// </summary>
        public static readonly WorkloadEnvironment PRODUCTION = new WorkloadEnvironment("PRODUCTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEnvironment FindValue(string value)
        {
            return FindValue<WorkloadEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadImprovementStatus.
    /// </summary>
    public class WorkloadImprovementStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus COMPLETE = new WorkloadImprovementStatus("COMPLETE");
        /// <summary>
        /// Constant IN_PROGRESS for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus IN_PROGRESS = new WorkloadImprovementStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_APPLICABLE for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus NOT_APPLICABLE = new WorkloadImprovementStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant NOT_STARTED for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus NOT_STARTED = new WorkloadImprovementStatus("NOT_STARTED");
        /// <summary>
        /// Constant RISK_ACKNOWLEDGED for WorkloadImprovementStatus
        /// </summary>
        public static readonly WorkloadImprovementStatus RISK_ACKNOWLEDGED = new WorkloadImprovementStatus("RISK_ACKNOWLEDGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadImprovementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadImprovementStatus FindValue(string value)
        {
            return FindValue<WorkloadImprovementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadImprovementStatus(string value)
        {
            return FindValue(value);
        }
    }

}
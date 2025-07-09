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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MPA
{

    /// <summary>
    /// Constants used for properties of type ActionCompletionStrategy.
    /// </summary>
    public class ActionCompletionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_COMPLETION_UPON_APPROVAL for ActionCompletionStrategy
        /// </summary>
        public static readonly ActionCompletionStrategy AUTO_COMPLETION_UPON_APPROVAL = new ActionCompletionStrategy("AUTO_COMPLETION_UPON_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionCompletionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionCompletionStrategy FindValue(string value)
        {
            return FindValue<ActionCompletionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionCompletionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApprovalTeamStatus.
    /// </summary>
    public class ApprovalTeamStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ApprovalTeamStatus
        /// </summary>
        public static readonly ApprovalTeamStatus ACTIVE = new ApprovalTeamStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for ApprovalTeamStatus
        /// </summary>
        public static readonly ApprovalTeamStatus DELETING = new ApprovalTeamStatus("DELETING");
        /// <summary>
        /// Constant INACTIVE for ApprovalTeamStatus
        /// </summary>
        public static readonly ApprovalTeamStatus INACTIVE = new ApprovalTeamStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for ApprovalTeamStatus
        /// </summary>
        public static readonly ApprovalTeamStatus PENDING = new ApprovalTeamStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApprovalTeamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalTeamStatus FindValue(string value)
        {
            return FindValue<ApprovalTeamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalTeamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApprovalTeamStatusCode.
    /// </summary>
    public class ApprovalTeamStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_FAILED_APPROVAL for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode DELETE_FAILED_APPROVAL = new ApprovalTeamStatusCode("DELETE_FAILED_APPROVAL");
        /// <summary>
        /// Constant DELETE_FAILED_VALIDATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode DELETE_FAILED_VALIDATION = new ApprovalTeamStatusCode("DELETE_FAILED_VALIDATION");
        /// <summary>
        /// Constant DELETE_PENDING_APPROVAL for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode DELETE_PENDING_APPROVAL = new ApprovalTeamStatusCode("DELETE_PENDING_APPROVAL");
        /// <summary>
        /// Constant FAILED_ACTIVATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode FAILED_ACTIVATION = new ApprovalTeamStatusCode("FAILED_ACTIVATION");
        /// <summary>
        /// Constant FAILED_VALIDATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode FAILED_VALIDATION = new ApprovalTeamStatusCode("FAILED_VALIDATION");
        /// <summary>
        /// Constant PENDING_ACTIVATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode PENDING_ACTIVATION = new ApprovalTeamStatusCode("PENDING_ACTIVATION");
        /// <summary>
        /// Constant UPDATE_FAILED_ACTIVATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode UPDATE_FAILED_ACTIVATION = new ApprovalTeamStatusCode("UPDATE_FAILED_ACTIVATION");
        /// <summary>
        /// Constant UPDATE_FAILED_APPROVAL for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode UPDATE_FAILED_APPROVAL = new ApprovalTeamStatusCode("UPDATE_FAILED_APPROVAL");
        /// <summary>
        /// Constant UPDATE_FAILED_VALIDATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode UPDATE_FAILED_VALIDATION = new ApprovalTeamStatusCode("UPDATE_FAILED_VALIDATION");
        /// <summary>
        /// Constant UPDATE_PENDING_ACTIVATION for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode UPDATE_PENDING_ACTIVATION = new ApprovalTeamStatusCode("UPDATE_PENDING_ACTIVATION");
        /// <summary>
        /// Constant UPDATE_PENDING_APPROVAL for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode UPDATE_PENDING_APPROVAL = new ApprovalTeamStatusCode("UPDATE_PENDING_APPROVAL");
        /// <summary>
        /// Constant VALIDATING for ApprovalTeamStatusCode
        /// </summary>
        public static readonly ApprovalTeamStatusCode VALIDATING = new ApprovalTeamStatusCode("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApprovalTeamStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalTeamStatusCode FindValue(string value)
        {
            return FindValue<ApprovalTeamStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalTeamStatusCode(string value)
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
        /// Constant ActionName for FilterField
        /// </summary>
        public static readonly FilterField ActionName = new FilterField("ActionName");
        /// <summary>
        /// Constant ApprovalTeamName for FilterField
        /// </summary>
        public static readonly FilterField ApprovalTeamName = new FilterField("ApprovalTeamName");
        /// <summary>
        /// Constant InitiationTime for FilterField
        /// </summary>
        public static readonly FilterField InitiationTime = new FilterField("InitiationTime");
        /// <summary>
        /// Constant SessionStatus for FilterField
        /// </summary>
        public static readonly FilterField SessionStatus = new FilterField("SessionStatus");
        /// <summary>
        /// Constant Vote for FilterField
        /// </summary>
        public static readonly FilterField Vote = new FilterField("Vote");
        /// <summary>
        /// Constant VotingTime for FilterField
        /// </summary>
        public static readonly FilterField VotingTime = new FilterField("VotingTime");

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
    /// Constants used for properties of type IdentitySourceStatus.
    /// </summary>
    public class IdentitySourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IdentitySourceStatus
        /// </summary>
        public static readonly IdentitySourceStatus ACTIVE = new IdentitySourceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for IdentitySourceStatus
        /// </summary>
        public static readonly IdentitySourceStatus CREATING = new IdentitySourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for IdentitySourceStatus
        /// </summary>
        public static readonly IdentitySourceStatus DELETING = new IdentitySourceStatus("DELETING");
        /// <summary>
        /// Constant ERROR for IdentitySourceStatus
        /// </summary>
        public static readonly IdentitySourceStatus ERROR = new IdentitySourceStatus("ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentitySourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentitySourceStatus FindValue(string value)
        {
            return FindValue<IdentitySourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentitySourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentitySourceStatusCode.
    /// </summary>
    public class IdentitySourceStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for IdentitySourceStatusCode
        /// </summary>
        public static readonly IdentitySourceStatusCode ACCESS_DENIED = new IdentitySourceStatusCode("ACCESS_DENIED");
        /// <summary>
        /// Constant DELETION_FAILED for IdentitySourceStatusCode
        /// </summary>
        public static readonly IdentitySourceStatusCode DELETION_FAILED = new IdentitySourceStatusCode("DELETION_FAILED");
        /// <summary>
        /// Constant IDC_INSTANCE_NOT_FOUND for IdentitySourceStatusCode
        /// </summary>
        public static readonly IdentitySourceStatusCode IDC_INSTANCE_NOT_FOUND = new IdentitySourceStatusCode("IDC_INSTANCE_NOT_FOUND");
        /// <summary>
        /// Constant IDC_INSTANCE_NOT_VALID for IdentitySourceStatusCode
        /// </summary>
        public static readonly IdentitySourceStatusCode IDC_INSTANCE_NOT_VALID = new IdentitySourceStatusCode("IDC_INSTANCE_NOT_VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentitySourceStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentitySourceStatusCode FindValue(string value)
        {
            return FindValue<IdentitySourceStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentitySourceStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentitySourceType.
    /// </summary>
    public class IdentitySourceType : ConstantClass
    {

        /// <summary>
        /// Constant IAM_IDENTITY_CENTER for IdentitySourceType
        /// </summary>
        public static readonly IdentitySourceType IAM_IDENTITY_CENTER = new IdentitySourceType("IAM_IDENTITY_CENTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentitySourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentitySourceType FindValue(string value)
        {
            return FindValue<IdentitySourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentitySourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityStatus.
    /// </summary>
    public class IdentityStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for IdentityStatus
        /// </summary>
        public static readonly IdentityStatus ACCEPTED = new IdentityStatus("ACCEPTED");
        /// <summary>
        /// Constant INVALID for IdentityStatus
        /// </summary>
        public static readonly IdentityStatus INVALID = new IdentityStatus("INVALID");
        /// <summary>
        /// Constant PENDING for IdentityStatus
        /// </summary>
        public static readonly IdentityStatus PENDING = new IdentityStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for IdentityStatus
        /// </summary>
        public static readonly IdentityStatus REJECTED = new IdentityStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityStatus FindValue(string value)
        {
            return FindValue<IdentityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for Operator
        /// </summary>
        public static readonly Operator BETWEEN = new Operator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for Operator
        /// </summary>
        public static readonly Operator CONTAINS = new Operator("CONTAINS");
        /// <summary>
        /// Constant EQ for Operator
        /// </summary>
        public static readonly Operator EQ = new Operator("EQ");
        /// <summary>
        /// Constant GT for Operator
        /// </summary>
        public static readonly Operator GT = new Operator("GT");
        /// <summary>
        /// Constant GTE for Operator
        /// </summary>
        public static readonly Operator GTE = new Operator("GTE");
        /// <summary>
        /// Constant LT for Operator
        /// </summary>
        public static readonly Operator LT = new Operator("LT");
        /// <summary>
        /// Constant LTE for Operator
        /// </summary>
        public static readonly Operator LTE = new Operator("LTE");
        /// <summary>
        /// Constant NE for Operator
        /// </summary>
        public static readonly Operator NE = new Operator("NE");
        /// <summary>
        /// Constant NOT_CONTAINS for Operator
        /// </summary>
        public static readonly Operator NOT_CONTAINS = new Operator("NOT_CONTAINS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyStatus.
    /// </summary>
    public class PolicyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHABLE for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus ATTACHABLE = new PolicyStatus("ATTACHABLE");
        /// <summary>
        /// Constant DEPRECATED for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus DEPRECATED = new PolicyStatus("DEPRECATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyStatus FindValue(string value)
        {
            return FindValue<PolicyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for PolicyType
        /// </summary>
        public static readonly PolicyType AWS_MANAGED = new PolicyType("AWS_MANAGED");
        /// <summary>
        /// Constant AWS_RAM for PolicyType
        /// </summary>
        public static readonly PolicyType AWS_RAM = new PolicyType("AWS_RAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionExecutionStatus.
    /// </summary>
    public class SessionExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTED for SessionExecutionStatus
        /// </summary>
        public static readonly SessionExecutionStatus EXECUTED = new SessionExecutionStatus("EXECUTED");
        /// <summary>
        /// Constant FAILED for SessionExecutionStatus
        /// </summary>
        public static readonly SessionExecutionStatus FAILED = new SessionExecutionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for SessionExecutionStatus
        /// </summary>
        public static readonly SessionExecutionStatus PENDING = new SessionExecutionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionExecutionStatus FindValue(string value)
        {
            return FindValue<SessionExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionResponse.
    /// </summary>
    public class SessionResponse : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for SessionResponse
        /// </summary>
        public static readonly SessionResponse APPROVED = new SessionResponse("APPROVED");
        /// <summary>
        /// Constant NO_RESPONSE for SessionResponse
        /// </summary>
        public static readonly SessionResponse NO_RESPONSE = new SessionResponse("NO_RESPONSE");
        /// <summary>
        /// Constant REJECTED for SessionResponse
        /// </summary>
        public static readonly SessionResponse REJECTED = new SessionResponse("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionResponse FindValue(string value)
        {
            return FindValue<SessionResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for SessionStatus
        /// </summary>
        public static readonly SessionStatus APPROVED = new SessionStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for SessionStatus
        /// </summary>
        public static readonly SessionStatus CANCELLED = new SessionStatus("CANCELLED");
        /// <summary>
        /// Constant CREATING for SessionStatus
        /// </summary>
        public static readonly SessionStatus CREATING = new SessionStatus("CREATING");
        /// <summary>
        /// Constant FAILED for SessionStatus
        /// </summary>
        public static readonly SessionStatus FAILED = new SessionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for SessionStatus
        /// </summary>
        public static readonly SessionStatus PENDING = new SessionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionStatusCode.
    /// </summary>
    public class SessionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_CHANGED for SessionStatusCode
        /// </summary>
        public static readonly SessionStatusCode CONFIGURATION_CHANGED = new SessionStatusCode("CONFIGURATION_CHANGED");
        /// <summary>
        /// Constant EXPIRED for SessionStatusCode
        /// </summary>
        public static readonly SessionStatusCode EXPIRED = new SessionStatusCode("EXPIRED");
        /// <summary>
        /// Constant REJECTED for SessionStatusCode
        /// </summary>
        public static readonly SessionStatusCode REJECTED = new SessionStatusCode("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatusCode FindValue(string value)
        {
            return FindValue<SessionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatusCode(string value)
        {
            return FindValue(value);
        }
    }

}
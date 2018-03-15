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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Organizations
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedForDependencyExceptionReason.
    /// </summary>
    public class AccessDeniedForDependencyExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED_DURING_CREATE_SERVICE_LINKED_ROLE for AccessDeniedForDependencyExceptionReason
        /// </summary>
        public static readonly AccessDeniedForDependencyExceptionReason ACCESS_DENIED_DURING_CREATE_SERVICE_LINKED_ROLE = new AccessDeniedForDependencyExceptionReason("ACCESS_DENIED_DURING_CREATE_SERVICE_LINKED_ROLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedForDependencyExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedForDependencyExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedForDependencyExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedForDependencyExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountJoinedMethod.
    /// </summary>
    public class AccountJoinedMethod : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for AccountJoinedMethod
        /// </summary>
        public static readonly AccountJoinedMethod CREATED = new AccountJoinedMethod("CREATED");
        /// <summary>
        /// Constant INVITED for AccountJoinedMethod
        /// </summary>
        public static readonly AccountJoinedMethod INVITED = new AccountJoinedMethod("INVITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountJoinedMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountJoinedMethod FindValue(string value)
        {
            return FindValue<AccountJoinedMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountJoinedMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountStatus.
    /// </summary>
    public class AccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AccountStatus
        /// </summary>
        public static readonly AccountStatus ACTIVE = new AccountStatus("ACTIVE");
        /// <summary>
        /// Constant SUSPENDED for AccountStatus
        /// </summary>
        public static readonly AccountStatus SUSPENDED = new AccountStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountStatus FindValue(string value)
        {
            return FindValue<AccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_ORGANIZATIONS_SERVICE_LINKED_ROLE for ActionType
        /// </summary>
        public static readonly ActionType ADD_ORGANIZATIONS_SERVICE_LINKED_ROLE = new ActionType("ADD_ORGANIZATIONS_SERVICE_LINKED_ROLE");
        /// <summary>
        /// Constant APPROVE_ALL_FEATURES for ActionType
        /// </summary>
        public static readonly ActionType APPROVE_ALL_FEATURES = new ActionType("APPROVE_ALL_FEATURES");
        /// <summary>
        /// Constant ENABLE_ALL_FEATURES for ActionType
        /// </summary>
        public static readonly ActionType ENABLE_ALL_FEATURES = new ActionType("ENABLE_ALL_FEATURES");
        /// <summary>
        /// Constant INVITE for ActionType
        /// </summary>
        public static readonly ActionType INVITE = new ActionType("INVITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChildType.
    /// </summary>
    public class ChildType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for ChildType
        /// </summary>
        public static readonly ChildType ACCOUNT = new ChildType("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATIONAL_UNIT for ChildType
        /// </summary>
        public static readonly ChildType ORGANIZATIONAL_UNIT = new ChildType("ORGANIZATIONAL_UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChildType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChildType FindValue(string value)
        {
            return FindValue<ChildType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChildType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConstraintViolationExceptionReason.
    /// </summary>
    public class ConstraintViolationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_CANNOT_LEAVE_ORGANIZATION for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ACCOUNT_CANNOT_LEAVE_ORGANIZATION = new ConstraintViolationExceptionReason("ACCOUNT_CANNOT_LEAVE_ORGANIZATION");
        /// <summary>
        /// Constant ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA = new ConstraintViolationExceptionReason("ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA");
        /// <summary>
        /// Constant ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION = new ConstraintViolationExceptionReason("ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION");
        /// <summary>
        /// Constant ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ACCOUNT_NUMBER_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ACCOUNT_NUMBER_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("ACCOUNT_NUMBER_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant HANDSHAKE_RATE_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason HANDSHAKE_RATE_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("HANDSHAKE_RATE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE = new ConstraintViolationExceptionReason("MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE");
        /// <summary>
        /// Constant MASTER_ACCOUNT_MISSING_CONTACT_INFO for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MASTER_ACCOUNT_MISSING_CONTACT_INFO = new ConstraintViolationExceptionReason("MASTER_ACCOUNT_MISSING_CONTACT_INFO");
        /// <summary>
        /// Constant MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED = new ConstraintViolationExceptionReason("MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED");
        /// <summary>
        /// Constant MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED = new ConstraintViolationExceptionReason("MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED");
        /// <summary>
        /// Constant MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ORGANIZATION_NOT_IN_ALL_FEATURES_MODE for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason ORGANIZATION_NOT_IN_ALL_FEATURES_MODE = new ConstraintViolationExceptionReason("ORGANIZATION_NOT_IN_ALL_FEATURES_MODE");
        /// <summary>
        /// Constant OU_DEPTH_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason OU_DEPTH_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("OU_DEPTH_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant OU_NUMBER_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason OU_NUMBER_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("OU_NUMBER_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant POLICY_NUMBER_LIMIT_EXCEEDED for ConstraintViolationExceptionReason
        /// </summary>
        public static readonly ConstraintViolationExceptionReason POLICY_NUMBER_LIMIT_EXCEEDED = new ConstraintViolationExceptionReason("POLICY_NUMBER_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConstraintViolationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConstraintViolationExceptionReason FindValue(string value)
        {
            return FindValue<ConstraintViolationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConstraintViolationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CreateAccountFailureReason.
    /// </summary>
    public class CreateAccountFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_LIMIT_EXCEEDED for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason ACCOUNT_LIMIT_EXCEEDED = new CreateAccountFailureReason("ACCOUNT_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant CONCURRENT_ACCOUNT_MODIFICATION for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason CONCURRENT_ACCOUNT_MODIFICATION = new CreateAccountFailureReason("CONCURRENT_ACCOUNT_MODIFICATION");
        /// <summary>
        /// Constant EMAIL_ALREADY_EXISTS for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason EMAIL_ALREADY_EXISTS = new CreateAccountFailureReason("EMAIL_ALREADY_EXISTS");
        /// <summary>
        /// Constant INTERNAL_FAILURE for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason INTERNAL_FAILURE = new CreateAccountFailureReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant INVALID_ADDRESS for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason INVALID_ADDRESS = new CreateAccountFailureReason("INVALID_ADDRESS");
        /// <summary>
        /// Constant INVALID_EMAIL for CreateAccountFailureReason
        /// </summary>
        public static readonly CreateAccountFailureReason INVALID_EMAIL = new CreateAccountFailureReason("INVALID_EMAIL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreateAccountFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreateAccountFailureReason FindValue(string value)
        {
            return FindValue<CreateAccountFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreateAccountFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CreateAccountState.
    /// </summary>
    public class CreateAccountState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CreateAccountState
        /// </summary>
        public static readonly CreateAccountState FAILED = new CreateAccountState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CreateAccountState
        /// </summary>
        public static readonly CreateAccountState IN_PROGRESS = new CreateAccountState("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for CreateAccountState
        /// </summary>
        public static readonly CreateAccountState SUCCEEDED = new CreateAccountState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreateAccountState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreateAccountState FindValue(string value)
        {
            return FindValue<CreateAccountState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreateAccountState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakeConstraintViolationExceptionReason.
    /// </summary>
    public class HandshakeConstraintViolationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_NUMBER_LIMIT_EXCEEDED for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason ACCOUNT_NUMBER_LIMIT_EXCEEDED = new HandshakeConstraintViolationExceptionReason("ACCOUNT_NUMBER_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ALREADY_IN_AN_ORGANIZATION for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason ALREADY_IN_AN_ORGANIZATION = new HandshakeConstraintViolationExceptionReason("ALREADY_IN_AN_ORGANIZATION");
        /// <summary>
        /// Constant HANDSHAKE_RATE_LIMIT_EXCEEDED for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason HANDSHAKE_RATE_LIMIT_EXCEEDED = new HandshakeConstraintViolationExceptionReason("HANDSHAKE_RATE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES = new HandshakeConstraintViolationExceptionReason("INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES");
        /// <summary>
        /// Constant ORGANIZATION_ALREADY_HAS_ALL_FEATURES for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason ORGANIZATION_ALREADY_HAS_ALL_FEATURES = new HandshakeConstraintViolationExceptionReason("ORGANIZATION_ALREADY_HAS_ALL_FEATURES");
        /// <summary>
        /// Constant ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD = new HandshakeConstraintViolationExceptionReason("ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD");
        /// <summary>
        /// Constant ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED = new HandshakeConstraintViolationExceptionReason("ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant PAYMENT_INSTRUMENT_REQUIRED for HandshakeConstraintViolationExceptionReason
        /// </summary>
        public static readonly HandshakeConstraintViolationExceptionReason PAYMENT_INSTRUMENT_REQUIRED = new HandshakeConstraintViolationExceptionReason("PAYMENT_INSTRUMENT_REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakeConstraintViolationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakeConstraintViolationExceptionReason FindValue(string value)
        {
            return FindValue<HandshakeConstraintViolationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakeConstraintViolationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakePartyType.
    /// </summary>
    public class HandshakePartyType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for HandshakePartyType
        /// </summary>
        public static readonly HandshakePartyType ACCOUNT = new HandshakePartyType("ACCOUNT");
        /// <summary>
        /// Constant EMAIL for HandshakePartyType
        /// </summary>
        public static readonly HandshakePartyType EMAIL = new HandshakePartyType("EMAIL");
        /// <summary>
        /// Constant ORGANIZATION for HandshakePartyType
        /// </summary>
        public static readonly HandshakePartyType ORGANIZATION = new HandshakePartyType("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakePartyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakePartyType FindValue(string value)
        {
            return FindValue<HandshakePartyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakePartyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakeResourceType.
    /// </summary>
    public class HandshakeResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType ACCOUNT = new HandshakeResourceType("ACCOUNT");
        /// <summary>
        /// Constant EMAIL for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType EMAIL = new HandshakeResourceType("EMAIL");
        /// <summary>
        /// Constant MASTER_EMAIL for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType MASTER_EMAIL = new HandshakeResourceType("MASTER_EMAIL");
        /// <summary>
        /// Constant MASTER_NAME for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType MASTER_NAME = new HandshakeResourceType("MASTER_NAME");
        /// <summary>
        /// Constant NOTES for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType NOTES = new HandshakeResourceType("NOTES");
        /// <summary>
        /// Constant ORGANIZATION for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType ORGANIZATION = new HandshakeResourceType("ORGANIZATION");
        /// <summary>
        /// Constant ORGANIZATION_FEATURE_SET for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType ORGANIZATION_FEATURE_SET = new HandshakeResourceType("ORGANIZATION_FEATURE_SET");
        /// <summary>
        /// Constant PARENT_HANDSHAKE for HandshakeResourceType
        /// </summary>
        public static readonly HandshakeResourceType PARENT_HANDSHAKE = new HandshakeResourceType("PARENT_HANDSHAKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakeResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakeResourceType FindValue(string value)
        {
            return FindValue<HandshakeResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakeResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakeState.
    /// </summary>
    public class HandshakeState : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for HandshakeState
        /// </summary>
        public static readonly HandshakeState ACCEPTED = new HandshakeState("ACCEPTED");
        /// <summary>
        /// Constant CANCELED for HandshakeState
        /// </summary>
        public static readonly HandshakeState CANCELED = new HandshakeState("CANCELED");
        /// <summary>
        /// Constant DECLINED for HandshakeState
        /// </summary>
        public static readonly HandshakeState DECLINED = new HandshakeState("DECLINED");
        /// <summary>
        /// Constant EXPIRED for HandshakeState
        /// </summary>
        public static readonly HandshakeState EXPIRED = new HandshakeState("EXPIRED");
        /// <summary>
        /// Constant OPEN for HandshakeState
        /// </summary>
        public static readonly HandshakeState OPEN = new HandshakeState("OPEN");
        /// <summary>
        /// Constant REQUESTED for HandshakeState
        /// </summary>
        public static readonly HandshakeState REQUESTED = new HandshakeState("REQUESTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakeState FindValue(string value)
        {
            return FindValue<HandshakeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IAMUserAccessToBilling.
    /// </summary>
    public class IAMUserAccessToBilling : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for IAMUserAccessToBilling
        /// </summary>
        public static readonly IAMUserAccessToBilling ALLOW = new IAMUserAccessToBilling("ALLOW");
        /// <summary>
        /// Constant DENY for IAMUserAccessToBilling
        /// </summary>
        public static readonly IAMUserAccessToBilling DENY = new IAMUserAccessToBilling("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IAMUserAccessToBilling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IAMUserAccessToBilling FindValue(string value)
        {
            return FindValue<IAMUserAccessToBilling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IAMUserAccessToBilling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidInputExceptionReason.
    /// </summary>
    public class InvalidInputExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant IMMUTABLE_POLICY for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason IMMUTABLE_POLICY = new InvalidInputExceptionReason("IMMUTABLE_POLICY");
        /// <summary>
        /// Constant INPUT_REQUIRED for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INPUT_REQUIRED = new InvalidInputExceptionReason("INPUT_REQUIRED");
        /// <summary>
        /// Constant INVALID_ENUM for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_ENUM = new InvalidInputExceptionReason("INVALID_ENUM");
        /// <summary>
        /// Constant INVALID_FULL_NAME_TARGET for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_FULL_NAME_TARGET = new InvalidInputExceptionReason("INVALID_FULL_NAME_TARGET");
        /// <summary>
        /// Constant INVALID_LIST_MEMBER for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_LIST_MEMBER = new InvalidInputExceptionReason("INVALID_LIST_MEMBER");
        /// <summary>
        /// Constant INVALID_NEXT_TOKEN for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_NEXT_TOKEN = new InvalidInputExceptionReason("INVALID_NEXT_TOKEN");
        /// <summary>
        /// Constant INVALID_PARTY_TYPE_TARGET for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_PARTY_TYPE_TARGET = new InvalidInputExceptionReason("INVALID_PARTY_TYPE_TARGET");
        /// <summary>
        /// Constant INVALID_PATTERN for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_PATTERN = new InvalidInputExceptionReason("INVALID_PATTERN");
        /// <summary>
        /// Constant INVALID_PATTERN_TARGET_ID for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_PATTERN_TARGET_ID = new InvalidInputExceptionReason("INVALID_PATTERN_TARGET_ID");
        /// <summary>
        /// Constant INVALID_ROLE_NAME for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_ROLE_NAME = new InvalidInputExceptionReason("INVALID_ROLE_NAME");
        /// <summary>
        /// Constant INVALID_SYNTAX_ORGANIZATION_ARN for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_SYNTAX_ORGANIZATION_ARN = new InvalidInputExceptionReason("INVALID_SYNTAX_ORGANIZATION_ARN");
        /// <summary>
        /// Constant INVALID_SYNTAX_POLICY_ID for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason INVALID_SYNTAX_POLICY_ID = new InvalidInputExceptionReason("INVALID_SYNTAX_POLICY_ID");
        /// <summary>
        /// Constant MAX_LENGTH_EXCEEDED for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MAX_LENGTH_EXCEEDED = new InvalidInputExceptionReason("MAX_LENGTH_EXCEEDED");
        /// <summary>
        /// Constant MAX_LIMIT_EXCEEDED_FILTER for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MAX_LIMIT_EXCEEDED_FILTER = new InvalidInputExceptionReason("MAX_LIMIT_EXCEEDED_FILTER");
        /// <summary>
        /// Constant MAX_VALUE_EXCEEDED for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MAX_VALUE_EXCEEDED = new InvalidInputExceptionReason("MAX_VALUE_EXCEEDED");
        /// <summary>
        /// Constant MIN_LENGTH_EXCEEDED for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MIN_LENGTH_EXCEEDED = new InvalidInputExceptionReason("MIN_LENGTH_EXCEEDED");
        /// <summary>
        /// Constant MIN_VALUE_EXCEEDED for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MIN_VALUE_EXCEEDED = new InvalidInputExceptionReason("MIN_VALUE_EXCEEDED");
        /// <summary>
        /// Constant MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS = new InvalidInputExceptionReason("MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS");
        /// <summary>
        /// Constant UNRECOGNIZED_SERVICE_PRINCIPAL for InvalidInputExceptionReason
        /// </summary>
        public static readonly InvalidInputExceptionReason UNRECOGNIZED_SERVICE_PRINCIPAL = new InvalidInputExceptionReason("UNRECOGNIZED_SERVICE_PRINCIPAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidInputExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidInputExceptionReason FindValue(string value)
        {
            return FindValue<InvalidInputExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidInputExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationFeatureSet.
    /// </summary>
    public class OrganizationFeatureSet : ConstantClass
    {

        /// <summary>
        /// Constant ALL for OrganizationFeatureSet
        /// </summary>
        public static readonly OrganizationFeatureSet ALL = new OrganizationFeatureSet("ALL");
        /// <summary>
        /// Constant CONSOLIDATED_BILLING for OrganizationFeatureSet
        /// </summary>
        public static readonly OrganizationFeatureSet CONSOLIDATED_BILLING = new OrganizationFeatureSet("CONSOLIDATED_BILLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationFeatureSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationFeatureSet FindValue(string value)
        {
            return FindValue<OrganizationFeatureSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationFeatureSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParentType.
    /// </summary>
    public class ParentType : ConstantClass
    {

        /// <summary>
        /// Constant ORGANIZATIONAL_UNIT for ParentType
        /// </summary>
        public static readonly ParentType ORGANIZATIONAL_UNIT = new ParentType("ORGANIZATIONAL_UNIT");
        /// <summary>
        /// Constant ROOT for ParentType
        /// </summary>
        public static readonly ParentType ROOT = new ParentType("ROOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParentType FindValue(string value)
        {
            return FindValue<ParentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParentType(string value)
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
        /// Constant SERVICE_CONTROL_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType SERVICE_CONTROL_POLICY = new PolicyType("SERVICE_CONTROL_POLICY");

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
    /// Constants used for properties of type PolicyTypeStatus.
    /// </summary>
    public class PolicyTypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for PolicyTypeStatus
        /// </summary>
        public static readonly PolicyTypeStatus ENABLED = new PolicyTypeStatus("ENABLED");
        /// <summary>
        /// Constant PENDING_DISABLE for PolicyTypeStatus
        /// </summary>
        public static readonly PolicyTypeStatus PENDING_DISABLE = new PolicyTypeStatus("PENDING_DISABLE");
        /// <summary>
        /// Constant PENDING_ENABLE for PolicyTypeStatus
        /// </summary>
        public static readonly PolicyTypeStatus PENDING_ENABLE = new PolicyTypeStatus("PENDING_ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyTypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyTypeStatus FindValue(string value)
        {
            return FindValue<PolicyTypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyTypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for TargetType
        /// </summary>
        public static readonly TargetType ACCOUNT = new TargetType("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATIONAL_UNIT for TargetType
        /// </summary>
        public static readonly TargetType ORGANIZATIONAL_UNIT = new TargetType("ORGANIZATIONAL_UNIT");
        /// <summary>
        /// Constant ROOT for TargetType
        /// </summary>
        public static readonly TargetType ROOT = new TargetType("ROOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }

}
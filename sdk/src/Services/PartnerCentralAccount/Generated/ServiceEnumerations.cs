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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PartnerCentralAccount
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason ACCESS_DENIED = new AccessDeniedExceptionReason("ACCESS_DENIED");
        /// <summary>
        /// Constant INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE = new AccessDeniedExceptionReason("INCOMPATIBLE_BENEFIT_AWS_PARTNER_STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessType.
    /// </summary>
    public class AccessType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ALL for AccessType
        /// </summary>
        public static readonly AccessType ALLOW_ALL = new AccessType("ALLOW_ALL");
        /// <summary>
        /// Constant ALLOW_BY_DEFAULT_DENY_SOME for AccessType
        /// </summary>
        public static readonly AccessType ALLOW_BY_DEFAULT_DENY_SOME = new AccessType("ALLOW_BY_DEFAULT_DENY_SOME");
        /// <summary>
        /// Constant DENY_ALL for AccessType
        /// </summary>
        public static readonly AccessType DENY_ALL = new AccessType("DENY_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessType FindValue(string value)
        {
            return FindValue<AccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BusinessValidationCode.
    /// </summary>
    public class BusinessValidationCode : ConstantClass
    {

        /// <summary>
        /// Constant INCOMPATIBLE_CONNECTION_INVITATION_REQUEST for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INCOMPATIBLE_CONNECTION_INVITATION_REQUEST = new BusinessValidationCode("INCOMPATIBLE_CONNECTION_INVITATION_REQUEST");
        /// <summary>
        /// Constant INCOMPATIBLE_DOMAIN for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INCOMPATIBLE_DOMAIN = new BusinessValidationCode("INCOMPATIBLE_DOMAIN");
        /// <summary>
        /// Constant INCOMPATIBLE_IDENTITY_VERIFICATION_STATUS for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INCOMPATIBLE_IDENTITY_VERIFICATION_STATUS = new BusinessValidationCode("INCOMPATIBLE_IDENTITY_VERIFICATION_STATUS");
        /// <summary>
        /// Constant INCOMPATIBLE_KNOW_YOUR_BUSINESS_STATUS for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INCOMPATIBLE_KNOW_YOUR_BUSINESS_STATUS = new BusinessValidationCode("INCOMPATIBLE_KNOW_YOUR_BUSINESS_STATUS");
        /// <summary>
        /// Constant INCOMPATIBLE_LEGAL_NAME for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INCOMPATIBLE_LEGAL_NAME = new BusinessValidationCode("INCOMPATIBLE_LEGAL_NAME");
        /// <summary>
        /// Constant INVALID_ACCOUNT_LINKING_STATUS for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INVALID_ACCOUNT_LINKING_STATUS = new BusinessValidationCode("INVALID_ACCOUNT_LINKING_STATUS");
        /// <summary>
        /// Constant INVALID_ACCOUNT_STATE for BusinessValidationCode
        /// </summary>
        public static readonly BusinessValidationCode INVALID_ACCOUNT_STATE = new BusinessValidationCode("INVALID_ACCOUNT_STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusinessValidationCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusinessValidationCode FindValue(string value)
        {
            return FindValue<BusinessValidationCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusinessValidationCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICT_CLIENT_TOKEN for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONFLICT_CLIENT_TOKEN = new ConflictExceptionReason("CONFLICT_CLIENT_TOKEN");
        /// <summary>
        /// Constant DUPLICATE_CONNECTION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DUPLICATE_CONNECTION = new ConflictExceptionReason("DUPLICATE_CONNECTION");
        /// <summary>
        /// Constant DUPLICATE_CONNECTION_INVITATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DUPLICATE_CONNECTION_INVITATION = new ConflictExceptionReason("DUPLICATE_CONNECTION_INVITATION");
        /// <summary>
        /// Constant DUPLICATE_PARTNER for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DUPLICATE_PARTNER = new ConflictExceptionReason("DUPLICATE_PARTNER");
        /// <summary>
        /// Constant INCOMPATIBLE_CONNECTION_INVITATION_RECEIVER for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_CONNECTION_INVITATION_RECEIVER = new ConflictExceptionReason("INCOMPATIBLE_CONNECTION_INVITATION_RECEIVER");
        /// <summary>
        /// Constant INCOMPATIBLE_CONNECTION_INVITATION_STATE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_CONNECTION_INVITATION_STATE = new ConflictExceptionReason("INCOMPATIBLE_CONNECTION_INVITATION_STATE");
        /// <summary>
        /// Constant INCOMPATIBLE_CONNECTION_PREFERENCES_REVISION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_CONNECTION_PREFERENCES_REVISION = new ConflictExceptionReason("INCOMPATIBLE_CONNECTION_PREFERENCES_REVISION");
        /// <summary>
        /// Constant INCOMPATIBLE_CONNECTION_STATE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_CONNECTION_STATE = new ConflictExceptionReason("INCOMPATIBLE_CONNECTION_STATE");
        /// <summary>
        /// Constant INCOMPATIBLE_PARTNER_PROFILE_TASK_STATE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_PARTNER_PROFILE_TASK_STATE = new ConflictExceptionReason("INCOMPATIBLE_PARTNER_PROFILE_TASK_STATE");
        /// <summary>
        /// Constant INCOMPATIBLE_PROFILE_STATE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason INCOMPATIBLE_PROFILE_STATE = new ConflictExceptionReason("INCOMPATIBLE_PROFILE_STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant OPPORTUNITY_COLLABORATION for ConnectionType
        /// </summary>
        public static readonly ConnectionType OPPORTUNITY_COLLABORATION = new ConnectionType("OPPORTUNITY_COLLABORATION");
        /// <summary>
        /// Constant SUBSIDIARY for ConnectionType
        /// </summary>
        public static readonly ConnectionType SUBSIDIARY = new ConnectionType("SUBSIDIARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionTypeStatus.
    /// </summary>
    public class ConnectionTypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConnectionTypeStatus
        /// </summary>
        public static readonly ConnectionTypeStatus ACTIVE = new ConnectionTypeStatus("ACTIVE");
        /// <summary>
        /// Constant CANCELED for ConnectionTypeStatus
        /// </summary>
        public static readonly ConnectionTypeStatus CANCELED = new ConnectionTypeStatus("CANCELED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionTypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionTypeStatus FindValue(string value)
        {
            return FindValue<ConnectionTypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionTypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldValidationCode.
    /// </summary>
    public class FieldValidationCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NOT_PERMITTED for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode ACTION_NOT_PERMITTED = new FieldValidationCode("ACTION_NOT_PERMITTED");
        /// <summary>
        /// Constant DUPLICATE_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode DUPLICATE_VALUE = new FieldValidationCode("DUPLICATE_VALUE");
        /// <summary>
        /// Constant INVALID_ENUM_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_ENUM_VALUE = new FieldValidationCode("INVALID_ENUM_VALUE");
        /// <summary>
        /// Constant INVALID_STRING_FORMAT for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_STRING_FORMAT = new FieldValidationCode("INVALID_STRING_FORMAT");
        /// <summary>
        /// Constant INVALID_VALUE for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode INVALID_VALUE = new FieldValidationCode("INVALID_VALUE");
        /// <summary>
        /// Constant REQUIRED_FIELD_MISSING for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode REQUIRED_FIELD_MISSING = new FieldValidationCode("REQUIRED_FIELD_MISSING");
        /// <summary>
        /// Constant TOO_MANY_VALUES for FieldValidationCode
        /// </summary>
        public static readonly FieldValidationCode TOO_MANY_VALUES = new FieldValidationCode("TOO_MANY_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldValidationCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldValidationCode FindValue(string value)
        {
            return FindValue<FieldValidationCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldValidationCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndustrySegment.
    /// </summary>
    public class IndustrySegment : ConstantClass
    {

        /// <summary>
        /// Constant AGRICULTURE_MINING for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment AGRICULTURE_MINING = new IndustrySegment("AGRICULTURE_MINING");
        /// <summary>
        /// Constant BIOTECHNOLOGY for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment BIOTECHNOLOGY = new IndustrySegment("BIOTECHNOLOGY");
        /// <summary>
        /// Constant BUSINESS_CONSUMER_SERVICES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment BUSINESS_CONSUMER_SERVICES = new IndustrySegment("BUSINESS_CONSUMER_SERVICES");
        /// <summary>
        /// Constant BUSINESS_SERV for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment BUSINESS_SERV = new IndustrySegment("BUSINESS_SERV");
        /// <summary>
        /// Constant COMMUNICATIONS for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment COMMUNICATIONS = new IndustrySegment("COMMUNICATIONS");
        /// <summary>
        /// Constant COMPUTER_HARDWARE for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment COMPUTER_HARDWARE = new IndustrySegment("COMPUTER_HARDWARE");
        /// <summary>
        /// Constant COMPUTER_SOFTWARE for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment COMPUTER_SOFTWARE = new IndustrySegment("COMPUTER_SOFTWARE");
        /// <summary>
        /// Constant COMPUTERS_ELECTRONICS for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment COMPUTERS_ELECTRONICS = new IndustrySegment("COMPUTERS_ELECTRONICS");
        /// <summary>
        /// Constant CONSUMER_GOODS for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment CONSUMER_GOODS = new IndustrySegment("CONSUMER_GOODS");
        /// <summary>
        /// Constant CONSUMER_RELATED for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment CONSUMER_RELATED = new IndustrySegment("CONSUMER_RELATED");
        /// <summary>
        /// Constant EDUCATION for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment EDUCATION = new IndustrySegment("EDUCATION");
        /// <summary>
        /// Constant ENERGY_UTILITIES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment ENERGY_UTILITIES = new IndustrySegment("ENERGY_UTILITIES");
        /// <summary>
        /// Constant FINANCIAL_SERVICES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment FINANCIAL_SERVICES = new IndustrySegment("FINANCIAL_SERVICES");
        /// <summary>
        /// Constant GAMING for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment GAMING = new IndustrySegment("GAMING");
        /// <summary>
        /// Constant GOVERNMENT for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment GOVERNMENT = new IndustrySegment("GOVERNMENT");
        /// <summary>
        /// Constant GOVERNMENT_EDUCATION_PUBLIC_SERVICES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment GOVERNMENT_EDUCATION_PUBLIC_SERVICES = new IndustrySegment("GOVERNMENT_EDUCATION_PUBLIC_SERVICES");
        /// <summary>
        /// Constant HEALTHCARE for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment HEALTHCARE = new IndustrySegment("HEALTHCARE");
        /// <summary>
        /// Constant HEALTHCARE_PHARMACEUTICALS_BIOTECH for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment HEALTHCARE_PHARMACEUTICALS_BIOTECH = new IndustrySegment("HEALTHCARE_PHARMACEUTICALS_BIOTECH");
        /// <summary>
        /// Constant INDUSTRIAL_ENERGY for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment INDUSTRIAL_ENERGY = new IndustrySegment("INDUSTRIAL_ENERGY");
        /// <summary>
        /// Constant INTERNET_SPECIFIC for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment INTERNET_SPECIFIC = new IndustrySegment("INTERNET_SPECIFIC");
        /// <summary>
        /// Constant LIFE_SCIENCES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment LIFE_SCIENCES = new IndustrySegment("LIFE_SCIENCES");
        /// <summary>
        /// Constant MANUFACTURING for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment MANUFACTURING = new IndustrySegment("MANUFACTURING");
        /// <summary>
        /// Constant MEDIA_ENTERTAINMENT for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment MEDIA_ENTERTAINMENT = new IndustrySegment("MEDIA_ENTERTAINMENT");
        /// <summary>
        /// Constant MEDIA_ENTERTAINMENT_LEISURE for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment MEDIA_ENTERTAINMENT_LEISURE = new IndustrySegment("MEDIA_ENTERTAINMENT_LEISURE");
        /// <summary>
        /// Constant MEDICAL_HEALTH for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment MEDICAL_HEALTH = new IndustrySegment("MEDICAL_HEALTH");
        /// <summary>
        /// Constant NON_PROFIT_ORGANIZATION for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment NON_PROFIT_ORGANIZATION = new IndustrySegment("NON_PROFIT_ORGANIZATION");
        /// <summary>
        /// Constant OTHER for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment OTHER = new IndustrySegment("OTHER");
        /// <summary>
        /// Constant PROFESSIONAL_SERVICES for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment PROFESSIONAL_SERVICES = new IndustrySegment("PROFESSIONAL_SERVICES");
        /// <summary>
        /// Constant REAL_ESTATE_CONSTRUCTION for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment REAL_ESTATE_CONSTRUCTION = new IndustrySegment("REAL_ESTATE_CONSTRUCTION");
        /// <summary>
        /// Constant RETAIL for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment RETAIL = new IndustrySegment("RETAIL");
        /// <summary>
        /// Constant RETAIL_WHOLESALE_DISTRIBUTION for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment RETAIL_WHOLESALE_DISTRIBUTION = new IndustrySegment("RETAIL_WHOLESALE_DISTRIBUTION");
        /// <summary>
        /// Constant SEMICONDUCTOR_ELECTR for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment SEMICONDUCTOR_ELECTR = new IndustrySegment("SEMICONDUCTOR_ELECTR");
        /// <summary>
        /// Constant SOFTWARE_INTERNET for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment SOFTWARE_INTERNET = new IndustrySegment("SOFTWARE_INTERNET");
        /// <summary>
        /// Constant TELECOMMUNICATIONS for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment TELECOMMUNICATIONS = new IndustrySegment("TELECOMMUNICATIONS");
        /// <summary>
        /// Constant TRANSPORTATION_LOGISTICS for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment TRANSPORTATION_LOGISTICS = new IndustrySegment("TRANSPORTATION_LOGISTICS");
        /// <summary>
        /// Constant TRAVEL_HOSPITALITY for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment TRAVEL_HOSPITALITY = new IndustrySegment("TRAVEL_HOSPITALITY");
        /// <summary>
        /// Constant WHOLESALE_DISTRIBUTION for IndustrySegment
        /// </summary>
        public static readonly IndustrySegment WHOLESALE_DISTRIBUTION = new IndustrySegment("WHOLESALE_DISTRIBUTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndustrySegment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndustrySegment FindValue(string value)
        {
            return FindValue<IndustrySegment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndustrySegment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvitationStatus.
    /// </summary>
    public class InvitationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus ACCEPTED = new InvitationStatus("ACCEPTED");
        /// <summary>
        /// Constant CANCELED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus CANCELED = new InvitationStatus("CANCELED");
        /// <summary>
        /// Constant EXPIRED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus EXPIRED = new InvitationStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus PENDING = new InvitationStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus REJECTED = new InvitationStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvitationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvitationStatus FindValue(string value)
        {
            return FindValue<InvitationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvitationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantType.
    /// </summary>
    public class ParticipantType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVER for ParticipantType
        /// </summary>
        public static readonly ParticipantType RECEIVER = new ParticipantType("RECEIVER");
        /// <summary>
        /// Constant SENDER for ParticipantType
        /// </summary>
        public static readonly ParticipantType SENDER = new ParticipantType("SENDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantType FindValue(string value)
        {
            return FindValue<ParticipantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrimarySolutionType.
    /// </summary>
    public class PrimarySolutionType : ConstantClass
    {

        /// <summary>
        /// Constant COMMUNICATION_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType COMMUNICATION_SERVICES = new PrimarySolutionType("COMMUNICATION_SERVICES");
        /// <summary>
        /// Constant CONSULTING_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType CONSULTING_SERVICES = new PrimarySolutionType("CONSULTING_SERVICES");
        /// <summary>
        /// Constant HARDWARE_PRODUCTS for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType HARDWARE_PRODUCTS = new PrimarySolutionType("HARDWARE_PRODUCTS");
        /// <summary>
        /// Constant MANAGED_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType MANAGED_SERVICES = new PrimarySolutionType("MANAGED_SERVICES");
        /// <summary>
        /// Constant PROFESSIONAL_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType PROFESSIONAL_SERVICES = new PrimarySolutionType("PROFESSIONAL_SERVICES");
        /// <summary>
        /// Constant SOFTWARE_PRODUCTS for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType SOFTWARE_PRODUCTS = new PrimarySolutionType("SOFTWARE_PRODUCTS");
        /// <summary>
        /// Constant TRAINING_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType TRAINING_SERVICES = new PrimarySolutionType("TRAINING_SERVICES");
        /// <summary>
        /// Constant VALUE_ADDED_RESALE_AWS_SERVICES for PrimarySolutionType
        /// </summary>
        public static readonly PrimarySolutionType VALUE_ADDED_RESALE_AWS_SERVICES = new PrimarySolutionType("VALUE_ADDED_RESALE_AWS_SERVICES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrimarySolutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrimarySolutionType FindValue(string value)
        {
            return FindValue<PrimarySolutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrimarySolutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileTaskStatus.
    /// </summary>
    public class ProfileTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for ProfileTaskStatus
        /// </summary>
        public static readonly ProfileTaskStatus CANCELED = new ProfileTaskStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for ProfileTaskStatus
        /// </summary>
        public static readonly ProfileTaskStatus FAILED = new ProfileTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ProfileTaskStatus
        /// </summary>
        public static readonly ProfileTaskStatus IN_PROGRESS = new ProfileTaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ProfileTaskStatus
        /// </summary>
        public static readonly ProfileTaskStatus SUCCEEDED = new ProfileTaskStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileTaskStatus FindValue(string value)
        {
            return FindValue<ProfileTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileValidationErrorReason.
    /// </summary>
    public class ProfileValidationErrorReason : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_PROFILE for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason DUPLICATE_PROFILE = new ProfileValidationErrorReason("DUPLICATE_PROFILE");
        /// <summary>
        /// Constant INVALID_CONTENT for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_CONTENT = new ProfileValidationErrorReason("INVALID_CONTENT");
        /// <summary>
        /// Constant INVALID_LOGO for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_LOGO = new ProfileValidationErrorReason("INVALID_LOGO");
        /// <summary>
        /// Constant INVALID_LOGO_FILE for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_LOGO_FILE = new ProfileValidationErrorReason("INVALID_LOGO_FILE");
        /// <summary>
        /// Constant INVALID_LOGO_SIZE for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_LOGO_SIZE = new ProfileValidationErrorReason("INVALID_LOGO_SIZE");
        /// <summary>
        /// Constant INVALID_LOGO_URL for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_LOGO_URL = new ProfileValidationErrorReason("INVALID_LOGO_URL");
        /// <summary>
        /// Constant INVALID_WEBSITE_URL for ProfileValidationErrorReason
        /// </summary>
        public static readonly ProfileValidationErrorReason INVALID_WEBSITE_URL = new ProfileValidationErrorReason("INVALID_WEBSITE_URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileValidationErrorReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileValidationErrorReason FindValue(string value)
        {
            return FindValue<ProfileValidationErrorReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileValidationErrorReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileVisibility.
    /// </summary>
    public class ProfileVisibility : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for ProfileVisibility
        /// </summary>
        public static readonly ProfileVisibility PRIVATE = new ProfileVisibility("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for ProfileVisibility
        /// </summary>
        public static readonly ProfileVisibility PUBLIC = new ProfileVisibility("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileVisibility FindValue(string value)
        {
            return FindValue<ProfileVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceNotFoundExceptionReason.
    /// </summary>
    public class ResourceNotFoundExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTION_INVITATION_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason CONNECTION_INVITATION_NOT_FOUND = new ResourceNotFoundExceptionReason("CONNECTION_INVITATION_NOT_FOUND");
        /// <summary>
        /// Constant CONNECTION_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason CONNECTION_NOT_FOUND = new ResourceNotFoundExceptionReason("CONNECTION_NOT_FOUND");
        /// <summary>
        /// Constant PARTNER_DOMAIN_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason PARTNER_DOMAIN_NOT_FOUND = new ResourceNotFoundExceptionReason("PARTNER_DOMAIN_NOT_FOUND");
        /// <summary>
        /// Constant PARTNER_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason PARTNER_NOT_FOUND = new ResourceNotFoundExceptionReason("PARTNER_NOT_FOUND");
        /// <summary>
        /// Constant PARTNER_PROFILE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason PARTNER_PROFILE_NOT_FOUND = new ResourceNotFoundExceptionReason("PARTNER_PROFILE_NOT_FOUND");
        /// <summary>
        /// Constant PARTNER_PROFILE_TASK_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason PARTNER_PROFILE_TASK_NOT_FOUND = new ResourceNotFoundExceptionReason("PARTNER_PROFILE_TASK_NOT_FOUND");
        /// <summary>
        /// Constant RECEIVER_PROFILE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason RECEIVER_PROFILE_NOT_FOUND = new ResourceNotFoundExceptionReason("RECEIVER_PROFILE_NOT_FOUND");
        /// <summary>
        /// Constant SENDER_PROFILE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason SENDER_PROFILE_NOT_FOUND = new ResourceNotFoundExceptionReason("SENDER_PROFILE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceNotFoundExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceNotFoundExceptionReason FindValue(string value)
        {
            return FindValue<ResourceNotFoundExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceNotFoundExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceQuotaExceededExceptionReason.
    /// </summary>
    public class ServiceQuotaExceededExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant LIMIT_EXCEEDED_NUMBER_OF_DOMAIN for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason LIMIT_EXCEEDED_NUMBER_OF_DOMAIN = new ServiceQuotaExceededExceptionReason("LIMIT_EXCEEDED_NUMBER_OF_DOMAIN");
        /// <summary>
        /// Constant LIMIT_EXCEEDED_NUMBER_OF_EMAIL for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason LIMIT_EXCEEDED_NUMBER_OF_EMAIL = new ServiceQuotaExceededExceptionReason("LIMIT_EXCEEDED_NUMBER_OF_EMAIL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceQuotaExceededExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceQuotaExceededExceptionReason FindValue(string value)
        {
            return FindValue<ServiceQuotaExceededExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceQuotaExceededExceptionReason(string value)
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
        /// Constant BUSINESS_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BUSINESS_VALIDATION_FAILED = new ValidationExceptionReason("BUSINESS_VALIDATION_FAILED");
        /// <summary>
        /// Constant REQUEST_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REQUEST_VALIDATION_FAILED = new ValidationExceptionReason("REQUEST_VALIDATION_FAILED");

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
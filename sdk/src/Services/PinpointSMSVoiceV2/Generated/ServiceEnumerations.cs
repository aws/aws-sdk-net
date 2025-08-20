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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PinpointSMSVoiceV2
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_DISABLED for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason ACCOUNT_DISABLED = new AccessDeniedExceptionReason("ACCOUNT_DISABLED");
        /// <summary>
        /// Constant INSUFFICIENT_ACCOUNT_REPUTATION for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason INSUFFICIENT_ACCOUNT_REPUTATION = new AccessDeniedExceptionReason("INSUFFICIENT_ACCOUNT_REPUTATION");

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
    /// Constants used for properties of type AccountAttributeName.
    /// </summary>
    public class AccountAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_TIER for AccountAttributeName
        /// </summary>
        public static readonly AccountAttributeName ACCOUNT_TIER = new AccountAttributeName("ACCOUNT_TIER");
        /// <summary>
        /// Constant DEFAULT_PROTECT_CONFIGURATION_ID for AccountAttributeName
        /// </summary>
        public static readonly AccountAttributeName DEFAULT_PROTECT_CONFIGURATION_ID = new AccountAttributeName("DEFAULT_PROTECT_CONFIGURATION_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountAttributeName FindValue(string value)
        {
            return FindValue<AccountAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountLimitName.
    /// </summary>
    public class AccountLimitName : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION_SETS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName CONFIGURATION_SETS = new AccountLimitName("CONFIGURATION_SETS");
        /// <summary>
        /// Constant OPT_OUT_LISTS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName OPT_OUT_LISTS = new AccountLimitName("OPT_OUT_LISTS");
        /// <summary>
        /// Constant PHONE_NUMBERS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName PHONE_NUMBERS = new AccountLimitName("PHONE_NUMBERS");
        /// <summary>
        /// Constant POOLS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName POOLS = new AccountLimitName("POOLS");
        /// <summary>
        /// Constant REGISTRATION_ATTACHMENTS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName REGISTRATION_ATTACHMENTS = new AccountLimitName("REGISTRATION_ATTACHMENTS");
        /// <summary>
        /// Constant REGISTRATIONS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName REGISTRATIONS = new AccountLimitName("REGISTRATIONS");
        /// <summary>
        /// Constant SENDER_IDS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName SENDER_IDS = new AccountLimitName("SENDER_IDS");
        /// <summary>
        /// Constant VERIFIED_DESTINATION_NUMBERS for AccountLimitName
        /// </summary>
        public static readonly AccountLimitName VERIFIED_DESTINATION_NUMBERS = new AccountLimitName("VERIFIED_DESTINATION_NUMBERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountLimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountLimitName FindValue(string value)
        {
            return FindValue<AccountLimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountLimitName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentStatus.
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus DELETED = new AttachmentStatus("DELETED");
        /// <summary>
        /// Constant UPLOAD_COMPLETE for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus UPLOAD_COMPLETE = new AttachmentStatus("UPLOAD_COMPLETE");
        /// <summary>
        /// Constant UPLOAD_FAILED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus UPLOAD_FAILED = new AttachmentStatus("UPLOAD_FAILED");
        /// <summary>
        /// Constant UPLOAD_IN_PROGRESS for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus UPLOAD_IN_PROGRESS = new AttachmentStatus("UPLOAD_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentUploadErrorReason.
    /// </summary>
    public class AttachmentUploadErrorReason : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for AttachmentUploadErrorReason
        /// </summary>
        public static readonly AttachmentUploadErrorReason INTERNAL_ERROR = new AttachmentUploadErrorReason("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentUploadErrorReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentUploadErrorReason FindValue(string value)
        {
            return FindValue<AttachmentUploadErrorReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentUploadErrorReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationSetFilterName.
    /// </summary>
    public class ConfigurationSetFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DefaultMessageFeedbackEnabled for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName DefaultMessageFeedbackEnabled = new ConfigurationSetFilterName("default-message-feedback-enabled");
        /// <summary>
        /// Constant DefaultMessageType for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName DefaultMessageType = new ConfigurationSetFilterName("default-message-type");
        /// <summary>
        /// Constant DefaultSenderId for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName DefaultSenderId = new ConfigurationSetFilterName("default-sender-id");
        /// <summary>
        /// Constant EventDestinationName for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName EventDestinationName = new ConfigurationSetFilterName("event-destination-name");
        /// <summary>
        /// Constant MatchingEventTypes for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName MatchingEventTypes = new ConfigurationSetFilterName("matching-event-types");
        /// <summary>
        /// Constant ProtectConfigurationId for ConfigurationSetFilterName
        /// </summary>
        public static readonly ConfigurationSetFilterName ProtectConfigurationId = new ConfigurationSetFilterName("protect-configuration-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationSetFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationSetFilterName FindValue(string value)
        {
            return FindValue<ConfigurationSetFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationSetFilterName(string value)
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
        /// Constant CREATE_REGISTRATION_VERSION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CREATE_REGISTRATION_VERSION_NOT_ALLOWED = new ConflictExceptionReason("CREATE_REGISTRATION_VERSION_NOT_ALLOWED");
        /// <summary>
        /// Constant DELETION_PROTECTION_ENABLED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DELETION_PROTECTION_ENABLED = new ConflictExceptionReason("DELETION_PROTECTION_ENABLED");
        /// <summary>
        /// Constant DESTINATION_COUNTRY_BLOCKED_BY_PROTECT_CONFIGURATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DESTINATION_COUNTRY_BLOCKED_BY_PROTECT_CONFIGURATION = new ConflictExceptionReason("DESTINATION_COUNTRY_BLOCKED_BY_PROTECT_CONFIGURATION");
        /// <summary>
        /// Constant DESTINATION_PHONE_NUMBER_BLOCKED_BY_PROTECT_NUMBER_OVERRIDE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DESTINATION_PHONE_NUMBER_BLOCKED_BY_PROTECT_NUMBER_OVERRIDE = new ConflictExceptionReason("DESTINATION_PHONE_NUMBER_BLOCKED_BY_PROTECT_NUMBER_OVERRIDE");
        /// <summary>
        /// Constant DESTINATION_PHONE_NUMBER_NOT_VERIFIED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DESTINATION_PHONE_NUMBER_NOT_VERIFIED = new ConflictExceptionReason("DESTINATION_PHONE_NUMBER_NOT_VERIFIED");
        /// <summary>
        /// Constant DESTINATION_PHONE_NUMBER_OPTED_OUT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DESTINATION_PHONE_NUMBER_OPTED_OUT = new ConflictExceptionReason("DESTINATION_PHONE_NUMBER_OPTED_OUT");
        /// <summary>
        /// Constant DISASSOCIATE_REGISTRATION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DISASSOCIATE_REGISTRATION_NOT_ALLOWED = new ConflictExceptionReason("DISASSOCIATE_REGISTRATION_NOT_ALLOWED");
        /// <summary>
        /// Constant DISCARD_REGISTRATION_VERSION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason DISCARD_REGISTRATION_VERSION_NOT_ALLOWED = new ConflictExceptionReason("DISCARD_REGISTRATION_VERSION_NOT_ALLOWED");
        /// <summary>
        /// Constant EDIT_REGISTRATION_FIELD_VALUES_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason EDIT_REGISTRATION_FIELD_VALUES_NOT_ALLOWED = new ConflictExceptionReason("EDIT_REGISTRATION_FIELD_VALUES_NOT_ALLOWED");
        /// <summary>
        /// Constant EVENT_DESTINATION_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason EVENT_DESTINATION_MISMATCH = new ConflictExceptionReason("EVENT_DESTINATION_MISMATCH");
        /// <summary>
        /// Constant KEYWORD_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason KEYWORD_MISMATCH = new ConflictExceptionReason("KEYWORD_MISMATCH");
        /// <summary>
        /// Constant LAST_PHONE_NUMBER for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason LAST_PHONE_NUMBER = new ConflictExceptionReason("LAST_PHONE_NUMBER");
        /// <summary>
        /// Constant MESSAGE_TYPE_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason MESSAGE_TYPE_MISMATCH = new ConflictExceptionReason("MESSAGE_TYPE_MISMATCH");
        /// <summary>
        /// Constant NO_ORIGINATION_IDENTITIES_FOUND for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason NO_ORIGINATION_IDENTITIES_FOUND = new ConflictExceptionReason("NO_ORIGINATION_IDENTITIES_FOUND");
        /// <summary>
        /// Constant NUMBER_CAPABILITIES_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason NUMBER_CAPABILITIES_MISMATCH = new ConflictExceptionReason("NUMBER_CAPABILITIES_MISMATCH");
        /// <summary>
        /// Constant OPT_OUT_LIST_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason OPT_OUT_LIST_MISMATCH = new ConflictExceptionReason("OPT_OUT_LIST_MISMATCH");
        /// <summary>
        /// Constant PHONE_NUMBER_ASSOCIATED_TO_POOL for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PHONE_NUMBER_ASSOCIATED_TO_POOL = new ConflictExceptionReason("PHONE_NUMBER_ASSOCIATED_TO_POOL");
        /// <summary>
        /// Constant PHONE_NUMBER_ASSOCIATED_TO_REGISTRATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PHONE_NUMBER_ASSOCIATED_TO_REGISTRATION = new ConflictExceptionReason("PHONE_NUMBER_ASSOCIATED_TO_REGISTRATION");
        /// <summary>
        /// Constant PHONE_NUMBER_NOT_ASSOCIATED_TO_POOL for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PHONE_NUMBER_NOT_ASSOCIATED_TO_POOL = new ConflictExceptionReason("PHONE_NUMBER_NOT_ASSOCIATED_TO_POOL");
        /// <summary>
        /// Constant PHONE_NUMBER_NOT_IN_REGISTRATION_REGION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PHONE_NUMBER_NOT_IN_REGISTRATION_REGION = new ConflictExceptionReason("PHONE_NUMBER_NOT_IN_REGISTRATION_REGION");
        /// <summary>
        /// Constant PROTECT_CONFIGURATION_ASSOCIATED_WITH_CONFIGURATION_SET for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PROTECT_CONFIGURATION_ASSOCIATED_WITH_CONFIGURATION_SET = new ConflictExceptionReason("PROTECT_CONFIGURATION_ASSOCIATED_WITH_CONFIGURATION_SET");
        /// <summary>
        /// Constant PROTECT_CONFIGURATION_IS_ACCOUNT_DEFAULT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PROTECT_CONFIGURATION_IS_ACCOUNT_DEFAULT = new ConflictExceptionReason("PROTECT_CONFIGURATION_IS_ACCOUNT_DEFAULT");
        /// <summary>
        /// Constant PROTECT_CONFIGURATION_NOT_ASSOCIATED_WITH_CONFIGURATION_SET for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PROTECT_CONFIGURATION_NOT_ASSOCIATED_WITH_CONFIGURATION_SET = new ConflictExceptionReason("PROTECT_CONFIGURATION_NOT_ASSOCIATED_WITH_CONFIGURATION_SET");
        /// <summary>
        /// Constant REGISTRATION_ALREADY_SUBMITTED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason REGISTRATION_ALREADY_SUBMITTED = new ConflictExceptionReason("REGISTRATION_ALREADY_SUBMITTED");
        /// <summary>
        /// Constant REGISTRATION_NOT_COMPLETE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason REGISTRATION_NOT_COMPLETE = new ConflictExceptionReason("REGISTRATION_NOT_COMPLETE");
        /// <summary>
        /// Constant RESOURCE_ALREADY_EXISTS for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_ALREADY_EXISTS = new ConflictExceptionReason("RESOURCE_ALREADY_EXISTS");
        /// <summary>
        /// Constant RESOURCE_DELETION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_DELETION_NOT_ALLOWED = new ConflictExceptionReason("RESOURCE_DELETION_NOT_ALLOWED");
        /// <summary>
        /// Constant RESOURCE_MODIFICATION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_MODIFICATION_NOT_ALLOWED = new ConflictExceptionReason("RESOURCE_MODIFICATION_NOT_ALLOWED");
        /// <summary>
        /// Constant RESOURCE_NOT_ACTIVE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_NOT_ACTIVE = new ConflictExceptionReason("RESOURCE_NOT_ACTIVE");
        /// <summary>
        /// Constant RESOURCE_NOT_EMPTY for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_NOT_EMPTY = new ConflictExceptionReason("RESOURCE_NOT_EMPTY");
        /// <summary>
        /// Constant SELF_MANAGED_OPT_OUTS_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SELF_MANAGED_OPT_OUTS_MISMATCH = new ConflictExceptionReason("SELF_MANAGED_OPT_OUTS_MISMATCH");
        /// <summary>
        /// Constant SENDER_ID_ASSOCIATED_TO_POOL for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SENDER_ID_ASSOCIATED_TO_POOL = new ConflictExceptionReason("SENDER_ID_ASSOCIATED_TO_POOL");
        /// <summary>
        /// Constant SUBMIT_REGISTRATION_VERSION_NOT_ALLOWED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SUBMIT_REGISTRATION_VERSION_NOT_ALLOWED = new ConflictExceptionReason("SUBMIT_REGISTRATION_VERSION_NOT_ALLOWED");
        /// <summary>
        /// Constant TWO_WAY_CONFIG_MISMATCH for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason TWO_WAY_CONFIG_MISMATCH = new ConflictExceptionReason("TWO_WAY_CONFIG_MISMATCH");
        /// <summary>
        /// Constant VERIFICATION_ALREADY_COMPLETE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason VERIFICATION_ALREADY_COMPLETE = new ConflictExceptionReason("VERIFICATION_ALREADY_COMPLETE");
        /// <summary>
        /// Constant VERIFICATION_CODE_EXPIRED for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason VERIFICATION_CODE_EXPIRED = new ConflictExceptionReason("VERIFICATION_CODE_EXPIRED");

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
    /// Constants used for properties of type DestinationCountryParameterKey.
    /// </summary>
    public class DestinationCountryParameterKey : ConstantClass
    {

        /// <summary>
        /// Constant IN_ENTITY_ID for DestinationCountryParameterKey
        /// </summary>
        public static readonly DestinationCountryParameterKey IN_ENTITY_ID = new DestinationCountryParameterKey("IN_ENTITY_ID");
        /// <summary>
        /// Constant IN_TEMPLATE_ID for DestinationCountryParameterKey
        /// </summary>
        public static readonly DestinationCountryParameterKey IN_TEMPLATE_ID = new DestinationCountryParameterKey("IN_TEMPLATE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationCountryParameterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationCountryParameterKey FindValue(string value)
        {
            return FindValue<DestinationCountryParameterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationCountryParameterKey(string value)
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
        /// Constant ALL for EventType
        /// </summary>
        public static readonly EventType ALL = new EventType("ALL");
        /// <summary>
        /// Constant MEDIA_ALL for EventType
        /// </summary>
        public static readonly EventType MEDIA_ALL = new EventType("MEDIA_ALL");
        /// <summary>
        /// Constant MEDIA_BLOCKED for EventType
        /// </summary>
        public static readonly EventType MEDIA_BLOCKED = new EventType("MEDIA_BLOCKED");
        /// <summary>
        /// Constant MEDIA_CARRIER_BLOCKED for EventType
        /// </summary>
        public static readonly EventType MEDIA_CARRIER_BLOCKED = new EventType("MEDIA_CARRIER_BLOCKED");
        /// <summary>
        /// Constant MEDIA_CARRIER_UNREACHABLE for EventType
        /// </summary>
        public static readonly EventType MEDIA_CARRIER_UNREACHABLE = new EventType("MEDIA_CARRIER_UNREACHABLE");
        /// <summary>
        /// Constant MEDIA_DELIVERED for EventType
        /// </summary>
        public static readonly EventType MEDIA_DELIVERED = new EventType("MEDIA_DELIVERED");
        /// <summary>
        /// Constant MEDIA_FILE_INACCESSIBLE for EventType
        /// </summary>
        public static readonly EventType MEDIA_FILE_INACCESSIBLE = new EventType("MEDIA_FILE_INACCESSIBLE");
        /// <summary>
        /// Constant MEDIA_FILE_SIZE_EXCEEDED for EventType
        /// </summary>
        public static readonly EventType MEDIA_FILE_SIZE_EXCEEDED = new EventType("MEDIA_FILE_SIZE_EXCEEDED");
        /// <summary>
        /// Constant MEDIA_FILE_TYPE_UNSUPPORTED for EventType
        /// </summary>
        public static readonly EventType MEDIA_FILE_TYPE_UNSUPPORTED = new EventType("MEDIA_FILE_TYPE_UNSUPPORTED");
        /// <summary>
        /// Constant MEDIA_INVALID for EventType
        /// </summary>
        public static readonly EventType MEDIA_INVALID = new EventType("MEDIA_INVALID");
        /// <summary>
        /// Constant MEDIA_INVALID_MESSAGE for EventType
        /// </summary>
        public static readonly EventType MEDIA_INVALID_MESSAGE = new EventType("MEDIA_INVALID_MESSAGE");
        /// <summary>
        /// Constant MEDIA_PENDING for EventType
        /// </summary>
        public static readonly EventType MEDIA_PENDING = new EventType("MEDIA_PENDING");
        /// <summary>
        /// Constant MEDIA_QUEUED for EventType
        /// </summary>
        public static readonly EventType MEDIA_QUEUED = new EventType("MEDIA_QUEUED");
        /// <summary>
        /// Constant MEDIA_SPAM for EventType
        /// </summary>
        public static readonly EventType MEDIA_SPAM = new EventType("MEDIA_SPAM");
        /// <summary>
        /// Constant MEDIA_SUCCESSFUL for EventType
        /// </summary>
        public static readonly EventType MEDIA_SUCCESSFUL = new EventType("MEDIA_SUCCESSFUL");
        /// <summary>
        /// Constant MEDIA_TTL_EXPIRED for EventType
        /// </summary>
        public static readonly EventType MEDIA_TTL_EXPIRED = new EventType("MEDIA_TTL_EXPIRED");
        /// <summary>
        /// Constant MEDIA_UNKNOWN for EventType
        /// </summary>
        public static readonly EventType MEDIA_UNKNOWN = new EventType("MEDIA_UNKNOWN");
        /// <summary>
        /// Constant MEDIA_UNREACHABLE for EventType
        /// </summary>
        public static readonly EventType MEDIA_UNREACHABLE = new EventType("MEDIA_UNREACHABLE");
        /// <summary>
        /// Constant TEXT_ALL for EventType
        /// </summary>
        public static readonly EventType TEXT_ALL = new EventType("TEXT_ALL");
        /// <summary>
        /// Constant TEXT_BLOCKED for EventType
        /// </summary>
        public static readonly EventType TEXT_BLOCKED = new EventType("TEXT_BLOCKED");
        /// <summary>
        /// Constant TEXT_CARRIER_BLOCKED for EventType
        /// </summary>
        public static readonly EventType TEXT_CARRIER_BLOCKED = new EventType("TEXT_CARRIER_BLOCKED");
        /// <summary>
        /// Constant TEXT_CARRIER_UNREACHABLE for EventType
        /// </summary>
        public static readonly EventType TEXT_CARRIER_UNREACHABLE = new EventType("TEXT_CARRIER_UNREACHABLE");
        /// <summary>
        /// Constant TEXT_DELIVERED for EventType
        /// </summary>
        public static readonly EventType TEXT_DELIVERED = new EventType("TEXT_DELIVERED");
        /// <summary>
        /// Constant TEXT_INVALID for EventType
        /// </summary>
        public static readonly EventType TEXT_INVALID = new EventType("TEXT_INVALID");
        /// <summary>
        /// Constant TEXT_INVALID_MESSAGE for EventType
        /// </summary>
        public static readonly EventType TEXT_INVALID_MESSAGE = new EventType("TEXT_INVALID_MESSAGE");
        /// <summary>
        /// Constant TEXT_PENDING for EventType
        /// </summary>
        public static readonly EventType TEXT_PENDING = new EventType("TEXT_PENDING");
        /// <summary>
        /// Constant TEXT_PROTECT_BLOCKED for EventType
        /// </summary>
        public static readonly EventType TEXT_PROTECT_BLOCKED = new EventType("TEXT_PROTECT_BLOCKED");
        /// <summary>
        /// Constant TEXT_QUEUED for EventType
        /// </summary>
        public static readonly EventType TEXT_QUEUED = new EventType("TEXT_QUEUED");
        /// <summary>
        /// Constant TEXT_SENT for EventType
        /// </summary>
        public static readonly EventType TEXT_SENT = new EventType("TEXT_SENT");
        /// <summary>
        /// Constant TEXT_SPAM for EventType
        /// </summary>
        public static readonly EventType TEXT_SPAM = new EventType("TEXT_SPAM");
        /// <summary>
        /// Constant TEXT_SUCCESSFUL for EventType
        /// </summary>
        public static readonly EventType TEXT_SUCCESSFUL = new EventType("TEXT_SUCCESSFUL");
        /// <summary>
        /// Constant TEXT_TTL_EXPIRED for EventType
        /// </summary>
        public static readonly EventType TEXT_TTL_EXPIRED = new EventType("TEXT_TTL_EXPIRED");
        /// <summary>
        /// Constant TEXT_UNKNOWN for EventType
        /// </summary>
        public static readonly EventType TEXT_UNKNOWN = new EventType("TEXT_UNKNOWN");
        /// <summary>
        /// Constant TEXT_UNREACHABLE for EventType
        /// </summary>
        public static readonly EventType TEXT_UNREACHABLE = new EventType("TEXT_UNREACHABLE");
        /// <summary>
        /// Constant VOICE_ALL for EventType
        /// </summary>
        public static readonly EventType VOICE_ALL = new EventType("VOICE_ALL");
        /// <summary>
        /// Constant VOICE_ANSWERED for EventType
        /// </summary>
        public static readonly EventType VOICE_ANSWERED = new EventType("VOICE_ANSWERED");
        /// <summary>
        /// Constant VOICE_BUSY for EventType
        /// </summary>
        public static readonly EventType VOICE_BUSY = new EventType("VOICE_BUSY");
        /// <summary>
        /// Constant VOICE_COMPLETED for EventType
        /// </summary>
        public static readonly EventType VOICE_COMPLETED = new EventType("VOICE_COMPLETED");
        /// <summary>
        /// Constant VOICE_FAILED for EventType
        /// </summary>
        public static readonly EventType VOICE_FAILED = new EventType("VOICE_FAILED");
        /// <summary>
        /// Constant VOICE_INITIATED for EventType
        /// </summary>
        public static readonly EventType VOICE_INITIATED = new EventType("VOICE_INITIATED");
        /// <summary>
        /// Constant VOICE_NO_ANSWER for EventType
        /// </summary>
        public static readonly EventType VOICE_NO_ANSWER = new EventType("VOICE_NO_ANSWER");
        /// <summary>
        /// Constant VOICE_RINGING for EventType
        /// </summary>
        public static readonly EventType VOICE_RINGING = new EventType("VOICE_RINGING");
        /// <summary>
        /// Constant VOICE_TTL_EXPIRED for EventType
        /// </summary>
        public static readonly EventType VOICE_TTL_EXPIRED = new EventType("VOICE_TTL_EXPIRED");

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
    /// Constants used for properties of type FieldRequirement.
    /// </summary>
    public class FieldRequirement : ConstantClass
    {

        /// <summary>
        /// Constant CONDITIONAL for FieldRequirement
        /// </summary>
        public static readonly FieldRequirement CONDITIONAL = new FieldRequirement("CONDITIONAL");
        /// <summary>
        /// Constant OPTIONAL for FieldRequirement
        /// </summary>
        public static readonly FieldRequirement OPTIONAL = new FieldRequirement("OPTIONAL");
        /// <summary>
        /// Constant REQUIRED for FieldRequirement
        /// </summary>
        public static readonly FieldRequirement REQUIRED = new FieldRequirement("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldRequirement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldRequirement FindValue(string value)
        {
            return FindValue<FieldRequirement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldRequirement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldType.
    /// </summary>
    public class FieldType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT for FieldType
        /// </summary>
        public static readonly FieldType ATTACHMENT = new FieldType("ATTACHMENT");
        /// <summary>
        /// Constant SELECT for FieldType
        /// </summary>
        public static readonly FieldType SELECT = new FieldType("SELECT");
        /// <summary>
        /// Constant TEXT for FieldType
        /// </summary>
        public static readonly FieldType TEXT = new FieldType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldType FindValue(string value)
        {
            return FindValue<FieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeywordAction.
    /// </summary>
    public class KeywordAction : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC_RESPONSE for KeywordAction
        /// </summary>
        public static readonly KeywordAction AUTOMATIC_RESPONSE = new KeywordAction("AUTOMATIC_RESPONSE");
        /// <summary>
        /// Constant OPT_IN for KeywordAction
        /// </summary>
        public static readonly KeywordAction OPT_IN = new KeywordAction("OPT_IN");
        /// <summary>
        /// Constant OPT_OUT for KeywordAction
        /// </summary>
        public static readonly KeywordAction OPT_OUT = new KeywordAction("OPT_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeywordAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeywordAction FindValue(string value)
        {
            return FindValue<KeywordAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeywordAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeywordFilterName.
    /// </summary>
    public class KeywordFilterName : ConstantClass
    {

        /// <summary>
        /// Constant KeywordAction for KeywordFilterName
        /// </summary>
        public static readonly KeywordFilterName KeywordAction = new KeywordFilterName("keyword-action");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeywordFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeywordFilterName FindValue(string value)
        {
            return FindValue<KeywordFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeywordFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DE_DE for LanguageCode
        /// </summary>
        public static readonly LanguageCode DE_DE = new LanguageCode("DE_DE");
        /// <summary>
        /// Constant EN_GB for LanguageCode
        /// </summary>
        public static readonly LanguageCode EN_GB = new LanguageCode("EN_GB");
        /// <summary>
        /// Constant EN_US for LanguageCode
        /// </summary>
        public static readonly LanguageCode EN_US = new LanguageCode("EN_US");
        /// <summary>
        /// Constant ES_419 for LanguageCode
        /// </summary>
        public static readonly LanguageCode ES_419 = new LanguageCode("ES_419");
        /// <summary>
        /// Constant ES_ES for LanguageCode
        /// </summary>
        public static readonly LanguageCode ES_ES = new LanguageCode("ES_ES");
        /// <summary>
        /// Constant FR_CA for LanguageCode
        /// </summary>
        public static readonly LanguageCode FR_CA = new LanguageCode("FR_CA");
        /// <summary>
        /// Constant FR_FR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FR_FR = new LanguageCode("FR_FR");
        /// <summary>
        /// Constant IT_IT for LanguageCode
        /// </summary>
        public static readonly LanguageCode IT_IT = new LanguageCode("IT_IT");
        /// <summary>
        /// Constant JA_JP for LanguageCode
        /// </summary>
        public static readonly LanguageCode JA_JP = new LanguageCode("JA_JP");
        /// <summary>
        /// Constant KO_KR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KO_KR = new LanguageCode("KO_KR");
        /// <summary>
        /// Constant PT_BR for LanguageCode
        /// </summary>
        public static readonly LanguageCode PT_BR = new LanguageCode("PT_BR");
        /// <summary>
        /// Constant ZH_CN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZH_CN = new LanguageCode("ZH_CN");
        /// <summary>
        /// Constant ZH_TW for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZH_TW = new LanguageCode("ZH_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageFeedbackStatus.
    /// </summary>
    public class MessageFeedbackStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for MessageFeedbackStatus
        /// </summary>
        public static readonly MessageFeedbackStatus FAILED = new MessageFeedbackStatus("FAILED");
        /// <summary>
        /// Constant RECEIVED for MessageFeedbackStatus
        /// </summary>
        public static readonly MessageFeedbackStatus RECEIVED = new MessageFeedbackStatus("RECEIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageFeedbackStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageFeedbackStatus FindValue(string value)
        {
            return FindValue<MessageFeedbackStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageFeedbackStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant PROMOTIONAL for MessageType
        /// </summary>
        public static readonly MessageType PROMOTIONAL = new MessageType("PROMOTIONAL");
        /// <summary>
        /// Constant TRANSACTIONAL for MessageType
        /// </summary>
        public static readonly MessageType TRANSACTIONAL = new MessageType("TRANSACTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberCapability.
    /// </summary>
    public class NumberCapability : ConstantClass
    {

        /// <summary>
        /// Constant MMS for NumberCapability
        /// </summary>
        public static readonly NumberCapability MMS = new NumberCapability("MMS");
        /// <summary>
        /// Constant SMS for NumberCapability
        /// </summary>
        public static readonly NumberCapability SMS = new NumberCapability("SMS");
        /// <summary>
        /// Constant VOICE for NumberCapability
        /// </summary>
        public static readonly NumberCapability VOICE = new NumberCapability("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberCapability FindValue(string value)
        {
            return FindValue<NumberCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberStatus.
    /// </summary>
    public class NumberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NumberStatus
        /// </summary>
        public static readonly NumberStatus ACTIVE = new NumberStatus("ACTIVE");
        /// <summary>
        /// Constant ASSOCIATING for NumberStatus
        /// </summary>
        public static readonly NumberStatus ASSOCIATING = new NumberStatus("ASSOCIATING");
        /// <summary>
        /// Constant DELETED for NumberStatus
        /// </summary>
        public static readonly NumberStatus DELETED = new NumberStatus("DELETED");
        /// <summary>
        /// Constant DISASSOCIATING for NumberStatus
        /// </summary>
        public static readonly NumberStatus DISASSOCIATING = new NumberStatus("DISASSOCIATING");
        /// <summary>
        /// Constant PENDING for NumberStatus
        /// </summary>
        public static readonly NumberStatus PENDING = new NumberStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberStatus FindValue(string value)
        {
            return FindValue<NumberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberType.
    /// </summary>
    public class NumberType : ConstantClass
    {

        /// <summary>
        /// Constant LONG_CODE for NumberType
        /// </summary>
        public static readonly NumberType LONG_CODE = new NumberType("LONG_CODE");
        /// <summary>
        /// Constant SHORT_CODE for NumberType
        /// </summary>
        public static readonly NumberType SHORT_CODE = new NumberType("SHORT_CODE");
        /// <summary>
        /// Constant SIMULATOR for NumberType
        /// </summary>
        public static readonly NumberType SIMULATOR = new NumberType("SIMULATOR");
        /// <summary>
        /// Constant TEN_DLC for NumberType
        /// </summary>
        public static readonly NumberType TEN_DLC = new NumberType("TEN_DLC");
        /// <summary>
        /// Constant TOLL_FREE for NumberType
        /// </summary>
        public static readonly NumberType TOLL_FREE = new NumberType("TOLL_FREE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberType FindValue(string value)
        {
            return FindValue<NumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptedOutFilterName.
    /// </summary>
    public class OptedOutFilterName : ConstantClass
    {

        /// <summary>
        /// Constant EndUserOptedOut for OptedOutFilterName
        /// </summary>
        public static readonly OptedOutFilterName EndUserOptedOut = new OptedOutFilterName("end-user-opted-out");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptedOutFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptedOutFilterName FindValue(string value)
        {
            return FindValue<OptedOutFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptedOutFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Owner.
    /// </summary>
    public class Owner : ConstantClass
    {

        /// <summary>
        /// Constant SELF for Owner
        /// </summary>
        public static readonly Owner SELF = new Owner("SELF");
        /// <summary>
        /// Constant SHARED for Owner
        /// </summary>
        public static readonly Owner SHARED = new Owner("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Owner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Owner FindValue(string value)
        {
            return FindValue<Owner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Owner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberFilterName.
    /// </summary>
    public class PhoneNumberFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DeletionProtectionEnabled for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName DeletionProtectionEnabled = new PhoneNumberFilterName("deletion-protection-enabled");
        /// <summary>
        /// Constant IsoCountryCode for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName IsoCountryCode = new PhoneNumberFilterName("iso-country-code");
        /// <summary>
        /// Constant MessageType for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName MessageType = new PhoneNumberFilterName("message-type");
        /// <summary>
        /// Constant NumberCapability for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName NumberCapability = new PhoneNumberFilterName("number-capability");
        /// <summary>
        /// Constant NumberType for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName NumberType = new PhoneNumberFilterName("number-type");
        /// <summary>
        /// Constant OptOutListName for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName OptOutListName = new PhoneNumberFilterName("opt-out-list-name");
        /// <summary>
        /// Constant SelfManagedOptOutsEnabled for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName SelfManagedOptOutsEnabled = new PhoneNumberFilterName("self-managed-opt-outs-enabled");
        /// <summary>
        /// Constant Status for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName Status = new PhoneNumberFilterName("status");
        /// <summary>
        /// Constant TwoWayChannelArn for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName TwoWayChannelArn = new PhoneNumberFilterName("two-way-channel-arn");
        /// <summary>
        /// Constant TwoWayEnabled for PhoneNumberFilterName
        /// </summary>
        public static readonly PhoneNumberFilterName TwoWayEnabled = new PhoneNumberFilterName("two-way-enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberFilterName FindValue(string value)
        {
            return FindValue<PhoneNumberFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PoolFilterName.
    /// </summary>
    public class PoolFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DeletionProtectionEnabled for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName DeletionProtectionEnabled = new PoolFilterName("deletion-protection-enabled");
        /// <summary>
        /// Constant MessageType for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName MessageType = new PoolFilterName("message-type");
        /// <summary>
        /// Constant OptOutListName for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName OptOutListName = new PoolFilterName("opt-out-list-name");
        /// <summary>
        /// Constant SelfManagedOptOutsEnabled for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName SelfManagedOptOutsEnabled = new PoolFilterName("self-managed-opt-outs-enabled");
        /// <summary>
        /// Constant SharedRoutesEnabled for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName SharedRoutesEnabled = new PoolFilterName("shared-routes-enabled");
        /// <summary>
        /// Constant Status for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName Status = new PoolFilterName("status");
        /// <summary>
        /// Constant TwoWayChannelArn for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName TwoWayChannelArn = new PoolFilterName("two-way-channel-arn");
        /// <summary>
        /// Constant TwoWayEnabled for PoolFilterName
        /// </summary>
        public static readonly PoolFilterName TwoWayEnabled = new PoolFilterName("two-way-enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PoolFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PoolFilterName FindValue(string value)
        {
            return FindValue<PoolFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PoolFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PoolOriginationIdentitiesFilterName.
    /// </summary>
    public class PoolOriginationIdentitiesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant IsoCountryCode for PoolOriginationIdentitiesFilterName
        /// </summary>
        public static readonly PoolOriginationIdentitiesFilterName IsoCountryCode = new PoolOriginationIdentitiesFilterName("iso-country-code");
        /// <summary>
        /// Constant NumberCapability for PoolOriginationIdentitiesFilterName
        /// </summary>
        public static readonly PoolOriginationIdentitiesFilterName NumberCapability = new PoolOriginationIdentitiesFilterName("number-capability");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PoolOriginationIdentitiesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PoolOriginationIdentitiesFilterName FindValue(string value)
        {
            return FindValue<PoolOriginationIdentitiesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PoolOriginationIdentitiesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PoolStatus.
    /// </summary>
    public class PoolStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PoolStatus
        /// </summary>
        public static readonly PoolStatus ACTIVE = new PoolStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for PoolStatus
        /// </summary>
        public static readonly PoolStatus CREATING = new PoolStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PoolStatus
        /// </summary>
        public static readonly PoolStatus DELETING = new PoolStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PoolStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PoolStatus FindValue(string value)
        {
            return FindValue<PoolStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PoolStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectConfigurationFilterName.
    /// </summary>
    public class ProtectConfigurationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant AccountDefault for ProtectConfigurationFilterName
        /// </summary>
        public static readonly ProtectConfigurationFilterName AccountDefault = new ProtectConfigurationFilterName("account-default");
        /// <summary>
        /// Constant DeletionProtectionEnabled for ProtectConfigurationFilterName
        /// </summary>
        public static readonly ProtectConfigurationFilterName DeletionProtectionEnabled = new ProtectConfigurationFilterName("deletion-protection-enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectConfigurationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectConfigurationFilterName FindValue(string value)
        {
            return FindValue<ProtectConfigurationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectConfigurationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectConfigurationRuleOverrideAction.
    /// </summary>
    public class ProtectConfigurationRuleOverrideAction : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for ProtectConfigurationRuleOverrideAction
        /// </summary>
        public static readonly ProtectConfigurationRuleOverrideAction ALLOW = new ProtectConfigurationRuleOverrideAction("ALLOW");
        /// <summary>
        /// Constant BLOCK for ProtectConfigurationRuleOverrideAction
        /// </summary>
        public static readonly ProtectConfigurationRuleOverrideAction BLOCK = new ProtectConfigurationRuleOverrideAction("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectConfigurationRuleOverrideAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectConfigurationRuleOverrideAction FindValue(string value)
        {
            return FindValue<ProtectConfigurationRuleOverrideAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectConfigurationRuleOverrideAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectConfigurationRuleSetNumberOverrideFilterName.
    /// </summary>
    public class ProtectConfigurationRuleSetNumberOverrideFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Action for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName Action = new ProtectConfigurationRuleSetNumberOverrideFilterName("action");
        /// <summary>
        /// Constant CreatedAfter for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName CreatedAfter = new ProtectConfigurationRuleSetNumberOverrideFilterName("created-after");
        /// <summary>
        /// Constant CreatedBefore for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName CreatedBefore = new ProtectConfigurationRuleSetNumberOverrideFilterName("created-before");
        /// <summary>
        /// Constant DestinationPhoneNumberBeginsWith for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName DestinationPhoneNumberBeginsWith = new ProtectConfigurationRuleSetNumberOverrideFilterName("destination-phone-number-begins-with");
        /// <summary>
        /// Constant ExpiresAfter for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName ExpiresAfter = new ProtectConfigurationRuleSetNumberOverrideFilterName("expires-after");
        /// <summary>
        /// Constant ExpiresBefore for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName ExpiresBefore = new ProtectConfigurationRuleSetNumberOverrideFilterName("expires-before");
        /// <summary>
        /// Constant IsoCountryCode for ProtectConfigurationRuleSetNumberOverrideFilterName
        /// </summary>
        public static readonly ProtectConfigurationRuleSetNumberOverrideFilterName IsoCountryCode = new ProtectConfigurationRuleSetNumberOverrideFilterName("iso-country-code");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectConfigurationRuleSetNumberOverrideFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectConfigurationRuleSetNumberOverrideFilterName FindValue(string value)
        {
            return FindValue<ProtectConfigurationRuleSetNumberOverrideFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectConfigurationRuleSetNumberOverrideFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectStatus.
    /// </summary>
    public class ProtectStatus : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for ProtectStatus
        /// </summary>
        public static readonly ProtectStatus ALLOW = new ProtectStatus("ALLOW");
        /// <summary>
        /// Constant BLOCK for ProtectStatus
        /// </summary>
        public static readonly ProtectStatus BLOCK = new ProtectStatus("BLOCK");
        /// <summary>
        /// Constant FILTER for ProtectStatus
        /// </summary>
        public static readonly ProtectStatus FILTER = new ProtectStatus("FILTER");
        /// <summary>
        /// Constant MONITOR for ProtectStatus
        /// </summary>
        public static readonly ProtectStatus MONITOR = new ProtectStatus("MONITOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectStatus FindValue(string value)
        {
            return FindValue<ProtectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationAssociationBehavior.
    /// </summary>
    public class RegistrationAssociationBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATE_AFTER_COMPLETE for RegistrationAssociationBehavior
        /// </summary>
        public static readonly RegistrationAssociationBehavior ASSOCIATE_AFTER_COMPLETE = new RegistrationAssociationBehavior("ASSOCIATE_AFTER_COMPLETE");
        /// <summary>
        /// Constant ASSOCIATE_BEFORE_SUBMIT for RegistrationAssociationBehavior
        /// </summary>
        public static readonly RegistrationAssociationBehavior ASSOCIATE_BEFORE_SUBMIT = new RegistrationAssociationBehavior("ASSOCIATE_BEFORE_SUBMIT");
        /// <summary>
        /// Constant ASSOCIATE_ON_APPROVAL for RegistrationAssociationBehavior
        /// </summary>
        public static readonly RegistrationAssociationBehavior ASSOCIATE_ON_APPROVAL = new RegistrationAssociationBehavior("ASSOCIATE_ON_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationAssociationBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationAssociationBehavior FindValue(string value)
        {
            return FindValue<RegistrationAssociationBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationAssociationBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationAssociationFilterName.
    /// </summary>
    public class RegistrationAssociationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant IsoCountryCode for RegistrationAssociationFilterName
        /// </summary>
        public static readonly RegistrationAssociationFilterName IsoCountryCode = new RegistrationAssociationFilterName("iso-country-code");
        /// <summary>
        /// Constant ResourceType for RegistrationAssociationFilterName
        /// </summary>
        public static readonly RegistrationAssociationFilterName ResourceType = new RegistrationAssociationFilterName("resource-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationAssociationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationAssociationFilterName FindValue(string value)
        {
            return FindValue<RegistrationAssociationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationAssociationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationAttachmentFilterName.
    /// </summary>
    public class RegistrationAttachmentFilterName : ConstantClass
    {

        /// <summary>
        /// Constant AttachmentStatus for RegistrationAttachmentFilterName
        /// </summary>
        public static readonly RegistrationAttachmentFilterName AttachmentStatus = new RegistrationAttachmentFilterName("attachment-status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationAttachmentFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationAttachmentFilterName FindValue(string value)
        {
            return FindValue<RegistrationAttachmentFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationAttachmentFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationDisassociationBehavior.
    /// </summary>
    public class RegistrationDisassociationBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_REGISTRATION_DISASSOCIATES for RegistrationDisassociationBehavior
        /// </summary>
        public static readonly RegistrationDisassociationBehavior DELETE_REGISTRATION_DISASSOCIATES = new RegistrationDisassociationBehavior("DELETE_REGISTRATION_DISASSOCIATES");
        /// <summary>
        /// Constant DISASSOCIATE_ALL_ALLOWS_DELETE_REGISTRATION for RegistrationDisassociationBehavior
        /// </summary>
        public static readonly RegistrationDisassociationBehavior DISASSOCIATE_ALL_ALLOWS_DELETE_REGISTRATION = new RegistrationDisassociationBehavior("DISASSOCIATE_ALL_ALLOWS_DELETE_REGISTRATION");
        /// <summary>
        /// Constant DISASSOCIATE_ALL_CLOSES_REGISTRATION for RegistrationDisassociationBehavior
        /// </summary>
        public static readonly RegistrationDisassociationBehavior DISASSOCIATE_ALL_CLOSES_REGISTRATION = new RegistrationDisassociationBehavior("DISASSOCIATE_ALL_CLOSES_REGISTRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationDisassociationBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationDisassociationBehavior FindValue(string value)
        {
            return FindValue<RegistrationDisassociationBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationDisassociationBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationFilterName.
    /// </summary>
    public class RegistrationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant RegistrationStatus for RegistrationFilterName
        /// </summary>
        public static readonly RegistrationFilterName RegistrationStatus = new RegistrationFilterName("registration-status");
        /// <summary>
        /// Constant RegistrationType for RegistrationFilterName
        /// </summary>
        public static readonly RegistrationFilterName RegistrationType = new RegistrationFilterName("registration-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationFilterName FindValue(string value)
        {
            return FindValue<RegistrationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus CLOSED = new RegistrationStatus("CLOSED");
        /// <summary>
        /// Constant COMPLETE for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus COMPLETE = new RegistrationStatus("COMPLETE");
        /// <summary>
        /// Constant CREATED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus CREATED = new RegistrationStatus("CREATED");
        /// <summary>
        /// Constant DELETED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus DELETED = new RegistrationStatus("DELETED");
        /// <summary>
        /// Constant PROVISIONING for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus PROVISIONING = new RegistrationStatus("PROVISIONING");
        /// <summary>
        /// Constant REQUIRES_AUTHENTICATION for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REQUIRES_AUTHENTICATION = new RegistrationStatus("REQUIRES_AUTHENTICATION");
        /// <summary>
        /// Constant REQUIRES_UPDATES for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REQUIRES_UPDATES = new RegistrationStatus("REQUIRES_UPDATES");
        /// <summary>
        /// Constant REVIEWING for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REVIEWING = new RegistrationStatus("REVIEWING");
        /// <summary>
        /// Constant SUBMITTED for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus SUBMITTED = new RegistrationStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationTypeFilterName.
    /// </summary>
    public class RegistrationTypeFilterName : ConstantClass
    {

        /// <summary>
        /// Constant SupportedAssociationIsoCountryCode for RegistrationTypeFilterName
        /// </summary>
        public static readonly RegistrationTypeFilterName SupportedAssociationIsoCountryCode = new RegistrationTypeFilterName("supported-association-iso-country-code");
        /// <summary>
        /// Constant SupportedAssociationResourceType for RegistrationTypeFilterName
        /// </summary>
        public static readonly RegistrationTypeFilterName SupportedAssociationResourceType = new RegistrationTypeFilterName("supported-association-resource-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationTypeFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationTypeFilterName FindValue(string value)
        {
            return FindValue<RegistrationTypeFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationTypeFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationVersionFilterName.
    /// </summary>
    public class RegistrationVersionFilterName : ConstantClass
    {

        /// <summary>
        /// Constant RegistrationVersionStatus for RegistrationVersionFilterName
        /// </summary>
        public static readonly RegistrationVersionFilterName RegistrationVersionStatus = new RegistrationVersionFilterName("registration-version-status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationVersionFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationVersionFilterName FindValue(string value)
        {
            return FindValue<RegistrationVersionFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationVersionFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationVersionStatus.
    /// </summary>
    public class RegistrationVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus APPROVED = new RegistrationVersionStatus("APPROVED");
        /// <summary>
        /// Constant ARCHIVED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus ARCHIVED = new RegistrationVersionStatus("ARCHIVED");
        /// <summary>
        /// Constant DENIED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus DENIED = new RegistrationVersionStatus("DENIED");
        /// <summary>
        /// Constant DISCARDED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus DISCARDED = new RegistrationVersionStatus("DISCARDED");
        /// <summary>
        /// Constant DRAFT for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus DRAFT = new RegistrationVersionStatus("DRAFT");
        /// <summary>
        /// Constant REQUIRES_AUTHENTICATION for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus REQUIRES_AUTHENTICATION = new RegistrationVersionStatus("REQUIRES_AUTHENTICATION");
        /// <summary>
        /// Constant REVIEWING for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus REVIEWING = new RegistrationVersionStatus("REVIEWING");
        /// <summary>
        /// Constant REVOKED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus REVOKED = new RegistrationVersionStatus("REVOKED");
        /// <summary>
        /// Constant SUBMITTED for RegistrationVersionStatus
        /// </summary>
        public static readonly RegistrationVersionStatus SUBMITTED = new RegistrationVersionStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationVersionStatus FindValue(string value)
        {
            return FindValue<RegistrationVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestableNumberType.
    /// </summary>
    public class RequestableNumberType : ConstantClass
    {

        /// <summary>
        /// Constant LONG_CODE for RequestableNumberType
        /// </summary>
        public static readonly RequestableNumberType LONG_CODE = new RequestableNumberType("LONG_CODE");
        /// <summary>
        /// Constant SIMULATOR for RequestableNumberType
        /// </summary>
        public static readonly RequestableNumberType SIMULATOR = new RequestableNumberType("SIMULATOR");
        /// <summary>
        /// Constant TEN_DLC for RequestableNumberType
        /// </summary>
        public static readonly RequestableNumberType TEN_DLC = new RequestableNumberType("TEN_DLC");
        /// <summary>
        /// Constant TOLL_FREE for RequestableNumberType
        /// </summary>
        public static readonly RequestableNumberType TOLL_FREE = new RequestableNumberType("TOLL_FREE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestableNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestableNumberType FindValue(string value)
        {
            return FindValue<RequestableNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestableNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Account for ResourceType
        /// </summary>
        public static readonly ResourceType Account = new ResourceType("account");
        /// <summary>
        /// Constant ConfigurationSet for ResourceType
        /// </summary>
        public static readonly ResourceType ConfigurationSet = new ResourceType("configuration-set");
        /// <summary>
        /// Constant EventDestination for ResourceType
        /// </summary>
        public static readonly ResourceType EventDestination = new ResourceType("event-destination");
        /// <summary>
        /// Constant Keyword for ResourceType
        /// </summary>
        public static readonly ResourceType Keyword = new ResourceType("keyword");
        /// <summary>
        /// Constant Message for ResourceType
        /// </summary>
        public static readonly ResourceType Message = new ResourceType("message");
        /// <summary>
        /// Constant MessageTemplate for ResourceType
        /// </summary>
        public static readonly ResourceType MessageTemplate = new ResourceType("message-template");
        /// <summary>
        /// Constant OptedOutNumber for ResourceType
        /// </summary>
        public static readonly ResourceType OptedOutNumber = new ResourceType("opted-out-number");
        /// <summary>
        /// Constant OptOutList for ResourceType
        /// </summary>
        public static readonly ResourceType OptOutList = new ResourceType("opt-out-list");
        /// <summary>
        /// Constant PhoneNumber for ResourceType
        /// </summary>
        public static readonly ResourceType PhoneNumber = new ResourceType("phone-number");
        /// <summary>
        /// Constant Policy for ResourceType
        /// </summary>
        public static readonly ResourceType Policy = new ResourceType("policy");
        /// <summary>
        /// Constant Pool for ResourceType
        /// </summary>
        public static readonly ResourceType Pool = new ResourceType("pool");
        /// <summary>
        /// Constant ProtectConfiguration for ResourceType
        /// </summary>
        public static readonly ResourceType ProtectConfiguration = new ResourceType("protect-configuration");
        /// <summary>
        /// Constant Registration for ResourceType
        /// </summary>
        public static readonly ResourceType Registration = new ResourceType("registration");
        /// <summary>
        /// Constant RegistrationAttachment for ResourceType
        /// </summary>
        public static readonly ResourceType RegistrationAttachment = new ResourceType("registration-attachment");
        /// <summary>
        /// Constant SenderId for ResourceType
        /// </summary>
        public static readonly ResourceType SenderId = new ResourceType("sender-id");
        /// <summary>
        /// Constant VerifiedDestinationNumber for ResourceType
        /// </summary>
        public static readonly ResourceType VerifiedDestinationNumber = new ResourceType("verified-destination-number");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SenderIdFilterName.
    /// </summary>
    public class SenderIdFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DeletionProtectionEnabled for SenderIdFilterName
        /// </summary>
        public static readonly SenderIdFilterName DeletionProtectionEnabled = new SenderIdFilterName("deletion-protection-enabled");
        /// <summary>
        /// Constant IsoCountryCode for SenderIdFilterName
        /// </summary>
        public static readonly SenderIdFilterName IsoCountryCode = new SenderIdFilterName("iso-country-code");
        /// <summary>
        /// Constant MessageType for SenderIdFilterName
        /// </summary>
        public static readonly SenderIdFilterName MessageType = new SenderIdFilterName("message-type");
        /// <summary>
        /// Constant Registered for SenderIdFilterName
        /// </summary>
        public static readonly SenderIdFilterName Registered = new SenderIdFilterName("registered");
        /// <summary>
        /// Constant SenderId for SenderIdFilterName
        /// </summary>
        public static readonly SenderIdFilterName SenderId = new SenderIdFilterName("sender-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SenderIdFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SenderIdFilterName FindValue(string value)
        {
            return FindValue<SenderIdFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SenderIdFilterName(string value)
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
        /// Constant ASSOCIATIONS_PER_REGISTRATION for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason ASSOCIATIONS_PER_REGISTRATION = new ServiceQuotaExceededExceptionReason("ASSOCIATIONS_PER_REGISTRATION");
        /// <summary>
        /// Constant CONFIGURATION_SETS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason CONFIGURATION_SETS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("CONFIGURATION_SETS_PER_ACCOUNT");
        /// <summary>
        /// Constant DAILY_DESTINATION_CALL_LIMIT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason DAILY_DESTINATION_CALL_LIMIT = new ServiceQuotaExceededExceptionReason("DAILY_DESTINATION_CALL_LIMIT");
        /// <summary>
        /// Constant EVENT_DESTINATIONS_PER_CONFIGURATION_SET for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason EVENT_DESTINATIONS_PER_CONFIGURATION_SET = new ServiceQuotaExceededExceptionReason("EVENT_DESTINATIONS_PER_CONFIGURATION_SET");
        /// <summary>
        /// Constant KEYWORDS_PER_PHONE_NUMBER for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason KEYWORDS_PER_PHONE_NUMBER = new ServiceQuotaExceededExceptionReason("KEYWORDS_PER_PHONE_NUMBER");
        /// <summary>
        /// Constant KEYWORDS_PER_POOL for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason KEYWORDS_PER_POOL = new ServiceQuotaExceededExceptionReason("KEYWORDS_PER_POOL");
        /// <summary>
        /// Constant MONTHLY_SPEND_LIMIT_REACHED_FOR_MEDIA for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason MONTHLY_SPEND_LIMIT_REACHED_FOR_MEDIA = new ServiceQuotaExceededExceptionReason("MONTHLY_SPEND_LIMIT_REACHED_FOR_MEDIA");
        /// <summary>
        /// Constant MONTHLY_SPEND_LIMIT_REACHED_FOR_TEXT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason MONTHLY_SPEND_LIMIT_REACHED_FOR_TEXT = new ServiceQuotaExceededExceptionReason("MONTHLY_SPEND_LIMIT_REACHED_FOR_TEXT");
        /// <summary>
        /// Constant MONTHLY_SPEND_LIMIT_REACHED_FOR_VOICE for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason MONTHLY_SPEND_LIMIT_REACHED_FOR_VOICE = new ServiceQuotaExceededExceptionReason("MONTHLY_SPEND_LIMIT_REACHED_FOR_VOICE");
        /// <summary>
        /// Constant OPT_OUT_LISTS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason OPT_OUT_LISTS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("OPT_OUT_LISTS_PER_ACCOUNT");
        /// <summary>
        /// Constant ORIGINATION_IDENTITIES_PER_POOL for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason ORIGINATION_IDENTITIES_PER_POOL = new ServiceQuotaExceededExceptionReason("ORIGINATION_IDENTITIES_PER_POOL");
        /// <summary>
        /// Constant PHONE_NUMBERS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason PHONE_NUMBERS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("PHONE_NUMBERS_PER_ACCOUNT");
        /// <summary>
        /// Constant PHONE_NUMBERS_PER_REGISTRATION for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason PHONE_NUMBERS_PER_REGISTRATION = new ServiceQuotaExceededExceptionReason("PHONE_NUMBERS_PER_REGISTRATION");
        /// <summary>
        /// Constant POOLS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason POOLS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("POOLS_PER_ACCOUNT");
        /// <summary>
        /// Constant PROTECT_CONFIGURATIONS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason PROTECT_CONFIGURATIONS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("PROTECT_CONFIGURATIONS_PER_ACCOUNT");
        /// <summary>
        /// Constant REGISTRATION_ATTACHMENTS_CREATED_PER_DAY for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason REGISTRATION_ATTACHMENTS_CREATED_PER_DAY = new ServiceQuotaExceededExceptionReason("REGISTRATION_ATTACHMENTS_CREATED_PER_DAY");
        /// <summary>
        /// Constant REGISTRATION_ATTACHMENTS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason REGISTRATION_ATTACHMENTS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("REGISTRATION_ATTACHMENTS_PER_ACCOUNT");
        /// <summary>
        /// Constant REGISTRATION_VERSIONS_CREATED_PER_DAY for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason REGISTRATION_VERSIONS_CREATED_PER_DAY = new ServiceQuotaExceededExceptionReason("REGISTRATION_VERSIONS_CREATED_PER_DAY");
        /// <summary>
        /// Constant REGISTRATIONS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason REGISTRATIONS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("REGISTRATIONS_PER_ACCOUNT");
        /// <summary>
        /// Constant SENDER_IDS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason SENDER_IDS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("SENDER_IDS_PER_ACCOUNT");
        /// <summary>
        /// Constant TAGS_PER_RESOURCE for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason TAGS_PER_RESOURCE = new ServiceQuotaExceededExceptionReason("TAGS_PER_RESOURCE");
        /// <summary>
        /// Constant VERIFICATION_ATTEMPTS_PER_DAY for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason VERIFICATION_ATTEMPTS_PER_DAY = new ServiceQuotaExceededExceptionReason("VERIFICATION_ATTEMPTS_PER_DAY");
        /// <summary>
        /// Constant VERIFIED_DESTINATION_NUMBERS_PER_ACCOUNT for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason VERIFIED_DESTINATION_NUMBERS_PER_ACCOUNT = new ServiceQuotaExceededExceptionReason("VERIFIED_DESTINATION_NUMBERS_PER_ACCOUNT");

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
    /// Constants used for properties of type SpendLimitName.
    /// </summary>
    public class SpendLimitName : ConstantClass
    {

        /// <summary>
        /// Constant MEDIA_MESSAGE_MONTHLY_SPEND_LIMIT for SpendLimitName
        /// </summary>
        public static readonly SpendLimitName MEDIA_MESSAGE_MONTHLY_SPEND_LIMIT = new SpendLimitName("MEDIA_MESSAGE_MONTHLY_SPEND_LIMIT");
        /// <summary>
        /// Constant TEXT_MESSAGE_MONTHLY_SPEND_LIMIT for SpendLimitName
        /// </summary>
        public static readonly SpendLimitName TEXT_MESSAGE_MONTHLY_SPEND_LIMIT = new SpendLimitName("TEXT_MESSAGE_MONTHLY_SPEND_LIMIT");
        /// <summary>
        /// Constant VOICE_MESSAGE_MONTHLY_SPEND_LIMIT for SpendLimitName
        /// </summary>
        public static readonly SpendLimitName VOICE_MESSAGE_MONTHLY_SPEND_LIMIT = new SpendLimitName("VOICE_MESSAGE_MONTHLY_SPEND_LIMIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpendLimitName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpendLimitName FindValue(string value)
        {
            return FindValue<SpendLimitName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpendLimitName(string value)
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
        /// Constant ATTACHMENT_TYPE_NOT_SUPPORTED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ATTACHMENT_TYPE_NOT_SUPPORTED = new ValidationExceptionReason("ATTACHMENT_TYPE_NOT_SUPPORTED");
        /// <summary>
        /// Constant CANNOT_ADD_OPTED_OUT_NUMBER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_ADD_OPTED_OUT_NUMBER = new ValidationExceptionReason("CANNOT_ADD_OPTED_OUT_NUMBER");
        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant COUNTRY_CODE_MISMATCH for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason COUNTRY_CODE_MISMATCH = new ValidationExceptionReason("COUNTRY_CODE_MISMATCH");
        /// <summary>
        /// Constant DESTINATION_COUNTRY_BLOCKED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DESTINATION_COUNTRY_BLOCKED = new ValidationExceptionReason("DESTINATION_COUNTRY_BLOCKED");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant INTERNATIONAL_SENDING_NOT_SUPPORTED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INTERNATIONAL_SENDING_NOT_SUPPORTED = new ValidationExceptionReason("INTERNATIONAL_SENDING_NOT_SUPPORTED");
        /// <summary>
        /// Constant INVALID_ARN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ARN = new ValidationExceptionReason("INVALID_ARN");
        /// <summary>
        /// Constant INVALID_FILTER_VALUES for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_FILTER_VALUES = new ValidationExceptionReason("INVALID_FILTER_VALUES");
        /// <summary>
        /// Constant INVALID_IDENTITY_FOR_DESTINATION_COUNTRY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_IDENTITY_FOR_DESTINATION_COUNTRY = new ValidationExceptionReason("INVALID_IDENTITY_FOR_DESTINATION_COUNTRY");
        /// <summary>
        /// Constant INVALID_NEXT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_NEXT_TOKEN = new ValidationExceptionReason("INVALID_NEXT_TOKEN");
        /// <summary>
        /// Constant INVALID_PARAMETER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PARAMETER = new ValidationExceptionReason("INVALID_PARAMETER");
        /// <summary>
        /// Constant INVALID_REGISTRATION_ASSOCIATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_REGISTRATION_ASSOCIATION = new ValidationExceptionReason("INVALID_REGISTRATION_ASSOCIATION");
        /// <summary>
        /// Constant INVALID_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_REQUEST = new ValidationExceptionReason("INVALID_REQUEST");
        /// <summary>
        /// Constant MAXIMUM_SIZE_EXCEEDED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MAXIMUM_SIZE_EXCEEDED = new ValidationExceptionReason("MAXIMUM_SIZE_EXCEEDED");
        /// <summary>
        /// Constant MEDIA_TYPE_NOT_SUPPORTED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MEDIA_TYPE_NOT_SUPPORTED = new ValidationExceptionReason("MEDIA_TYPE_NOT_SUPPORTED");
        /// <summary>
        /// Constant MISSING_PARAMETER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_PARAMETER = new ValidationExceptionReason("MISSING_PARAMETER");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant PARAMETERS_CANNOT_BE_USED_TOGETHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PARAMETERS_CANNOT_BE_USED_TOGETHER = new ValidationExceptionReason("PARAMETERS_CANNOT_BE_USED_TOGETHER");
        /// <summary>
        /// Constant PHONE_NUMBER_CANNOT_BE_OPTED_IN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PHONE_NUMBER_CANNOT_BE_OPTED_IN = new ValidationExceptionReason("PHONE_NUMBER_CANNOT_BE_OPTED_IN");
        /// <summary>
        /// Constant PHONE_NUMBER_CANNOT_BE_RELEASED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PHONE_NUMBER_CANNOT_BE_RELEASED = new ValidationExceptionReason("PHONE_NUMBER_CANNOT_BE_RELEASED");
        /// <summary>
        /// Constant PRICE_OVER_THRESHOLD for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PRICE_OVER_THRESHOLD = new ValidationExceptionReason("PRICE_OVER_THRESHOLD");
        /// <summary>
        /// Constant REGISTRATION_FIELD_CANNOT_BE_DELETED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REGISTRATION_FIELD_CANNOT_BE_DELETED = new ValidationExceptionReason("REGISTRATION_FIELD_CANNOT_BE_DELETED");
        /// <summary>
        /// Constant REQUESTED_SPEND_LIMIT_HIGHER_THAN_SERVICE_LIMIT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REQUESTED_SPEND_LIMIT_HIGHER_THAN_SERVICE_LIMIT = new ValidationExceptionReason("REQUESTED_SPEND_LIMIT_HIGHER_THAN_SERVICE_LIMIT");
        /// <summary>
        /// Constant RESOURCE_NOT_ACCESSIBLE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason RESOURCE_NOT_ACCESSIBLE = new ValidationExceptionReason("RESOURCE_NOT_ACCESSIBLE");
        /// <summary>
        /// Constant SENDER_ID_NOT_REGISTERED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason SENDER_ID_NOT_REGISTERED = new ValidationExceptionReason("SENDER_ID_NOT_REGISTERED");
        /// <summary>
        /// Constant SENDER_ID_NOT_SUPPORTED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason SENDER_ID_NOT_SUPPORTED = new ValidationExceptionReason("SENDER_ID_NOT_SUPPORTED");
        /// <summary>
        /// Constant SENDER_ID_REQUIRES_REGISTRATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason SENDER_ID_REQUIRES_REGISTRATION = new ValidationExceptionReason("SENDER_ID_REQUIRES_REGISTRATION");
        /// <summary>
        /// Constant TWO_WAY_CHANNEL_NOT_PRESENT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TWO_WAY_CHANNEL_NOT_PRESENT = new ValidationExceptionReason("TWO_WAY_CHANNEL_NOT_PRESENT");
        /// <summary>
        /// Constant TWO_WAY_NOT_ENABLED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TWO_WAY_NOT_ENABLED = new ValidationExceptionReason("TWO_WAY_NOT_ENABLED");
        /// <summary>
        /// Constant TWO_WAY_NOT_SUPPORTED_IN_COUNTRY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TWO_WAY_NOT_SUPPORTED_IN_COUNTRY = new ValidationExceptionReason("TWO_WAY_NOT_SUPPORTED_IN_COUNTRY");
        /// <summary>
        /// Constant TWO_WAY_NOT_SUPPORTED_IN_REGION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TWO_WAY_NOT_SUPPORTED_IN_REGION = new ValidationExceptionReason("TWO_WAY_NOT_SUPPORTED_IN_REGION");
        /// <summary>
        /// Constant TWO_WAY_TOPIC_NOT_PRESENT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason TWO_WAY_TOPIC_NOT_PRESENT = new ValidationExceptionReason("TWO_WAY_TOPIC_NOT_PRESENT");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");
        /// <summary>
        /// Constant UNKNOWN_REGISTRATION_FIELD for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_REGISTRATION_FIELD = new ValidationExceptionReason("UNKNOWN_REGISTRATION_FIELD");
        /// <summary>
        /// Constant UNKNOWN_REGISTRATION_SECTION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_REGISTRATION_SECTION = new ValidationExceptionReason("UNKNOWN_REGISTRATION_SECTION");
        /// <summary>
        /// Constant UNKNOWN_REGISTRATION_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_REGISTRATION_TYPE = new ValidationExceptionReason("UNKNOWN_REGISTRATION_TYPE");
        /// <summary>
        /// Constant UNKNOWN_REGISTRATION_VERSION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_REGISTRATION_VERSION = new ValidationExceptionReason("UNKNOWN_REGISTRATION_VERSION");
        /// <summary>
        /// Constant UNSPECIFIED_PARAMETER_NOT_SUPPORTED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSPECIFIED_PARAMETER_NOT_SUPPORTED = new ValidationExceptionReason("UNSPECIFIED_PARAMETER_NOT_SUPPORTED");
        /// <summary>
        /// Constant VERIFICATION_CODE_MISMATCH for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason VERIFICATION_CODE_MISMATCH = new ValidationExceptionReason("VERIFICATION_CODE_MISMATCH");
        /// <summary>
        /// Constant VOICE_CAPABILITY_NOT_AVAILABLE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason VOICE_CAPABILITY_NOT_AVAILABLE = new ValidationExceptionReason("VOICE_CAPABILITY_NOT_AVAILABLE");

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
    /// Constants used for properties of type VerificationChannel.
    /// </summary>
    public class VerificationChannel : ConstantClass
    {

        /// <summary>
        /// Constant TEXT for VerificationChannel
        /// </summary>
        public static readonly VerificationChannel TEXT = new VerificationChannel("TEXT");
        /// <summary>
        /// Constant VOICE for VerificationChannel
        /// </summary>
        public static readonly VerificationChannel VOICE = new VerificationChannel("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationChannel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationChannel FindValue(string value)
        {
            return FindValue<VerificationChannel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationChannel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationStatus.
    /// </summary>
    public class VerificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus PENDING = new VerificationStatus("PENDING");
        /// <summary>
        /// Constant VERIFIED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus VERIFIED = new VerificationStatus("VERIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationStatus FindValue(string value)
        {
            return FindValue<VerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerifiedDestinationNumberFilterName.
    /// </summary>
    public class VerifiedDestinationNumberFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Status for VerifiedDestinationNumberFilterName
        /// </summary>
        public static readonly VerifiedDestinationNumberFilterName Status = new VerifiedDestinationNumberFilterName("status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerifiedDestinationNumberFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerifiedDestinationNumberFilterName FindValue(string value)
        {
            return FindValue<VerifiedDestinationNumberFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerifiedDestinationNumberFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceId.
    /// </summary>
    public class VoiceId : ConstantClass
    {

        /// <summary>
        /// Constant AMY for VoiceId
        /// </summary>
        public static readonly VoiceId AMY = new VoiceId("AMY");
        /// <summary>
        /// Constant ASTRID for VoiceId
        /// </summary>
        public static readonly VoiceId ASTRID = new VoiceId("ASTRID");
        /// <summary>
        /// Constant BIANCA for VoiceId
        /// </summary>
        public static readonly VoiceId BIANCA = new VoiceId("BIANCA");
        /// <summary>
        /// Constant BRIAN for VoiceId
        /// </summary>
        public static readonly VoiceId BRIAN = new VoiceId("BRIAN");
        /// <summary>
        /// Constant CAMILA for VoiceId
        /// </summary>
        public static readonly VoiceId CAMILA = new VoiceId("CAMILA");
        /// <summary>
        /// Constant CARLA for VoiceId
        /// </summary>
        public static readonly VoiceId CARLA = new VoiceId("CARLA");
        /// <summary>
        /// Constant CARMEN for VoiceId
        /// </summary>
        public static readonly VoiceId CARMEN = new VoiceId("CARMEN");
        /// <summary>
        /// Constant CELINE for VoiceId
        /// </summary>
        public static readonly VoiceId CELINE = new VoiceId("CELINE");
        /// <summary>
        /// Constant CHANTAL for VoiceId
        /// </summary>
        public static readonly VoiceId CHANTAL = new VoiceId("CHANTAL");
        /// <summary>
        /// Constant CONCHITA for VoiceId
        /// </summary>
        public static readonly VoiceId CONCHITA = new VoiceId("CONCHITA");
        /// <summary>
        /// Constant CRISTIANO for VoiceId
        /// </summary>
        public static readonly VoiceId CRISTIANO = new VoiceId("CRISTIANO");
        /// <summary>
        /// Constant DORA for VoiceId
        /// </summary>
        public static readonly VoiceId DORA = new VoiceId("DORA");
        /// <summary>
        /// Constant EMMA for VoiceId
        /// </summary>
        public static readonly VoiceId EMMA = new VoiceId("EMMA");
        /// <summary>
        /// Constant ENRIQUE for VoiceId
        /// </summary>
        public static readonly VoiceId ENRIQUE = new VoiceId("ENRIQUE");
        /// <summary>
        /// Constant EWA for VoiceId
        /// </summary>
        public static readonly VoiceId EWA = new VoiceId("EWA");
        /// <summary>
        /// Constant FILIZ for VoiceId
        /// </summary>
        public static readonly VoiceId FILIZ = new VoiceId("FILIZ");
        /// <summary>
        /// Constant GERAINT for VoiceId
        /// </summary>
        public static readonly VoiceId GERAINT = new VoiceId("GERAINT");
        /// <summary>
        /// Constant GIORGIO for VoiceId
        /// </summary>
        public static readonly VoiceId GIORGIO = new VoiceId("GIORGIO");
        /// <summary>
        /// Constant GWYNETH for VoiceId
        /// </summary>
        public static readonly VoiceId GWYNETH = new VoiceId("GWYNETH");
        /// <summary>
        /// Constant HANS for VoiceId
        /// </summary>
        public static readonly VoiceId HANS = new VoiceId("HANS");
        /// <summary>
        /// Constant INES for VoiceId
        /// </summary>
        public static readonly VoiceId INES = new VoiceId("INES");
        /// <summary>
        /// Constant IVY for VoiceId
        /// </summary>
        public static readonly VoiceId IVY = new VoiceId("IVY");
        /// <summary>
        /// Constant JACEK for VoiceId
        /// </summary>
        public static readonly VoiceId JACEK = new VoiceId("JACEK");
        /// <summary>
        /// Constant JAN for VoiceId
        /// </summary>
        public static readonly VoiceId JAN = new VoiceId("JAN");
        /// <summary>
        /// Constant JOANNA for VoiceId
        /// </summary>
        public static readonly VoiceId JOANNA = new VoiceId("JOANNA");
        /// <summary>
        /// Constant JOEY for VoiceId
        /// </summary>
        public static readonly VoiceId JOEY = new VoiceId("JOEY");
        /// <summary>
        /// Constant JUSTIN for VoiceId
        /// </summary>
        public static readonly VoiceId JUSTIN = new VoiceId("JUSTIN");
        /// <summary>
        /// Constant KARL for VoiceId
        /// </summary>
        public static readonly VoiceId KARL = new VoiceId("KARL");
        /// <summary>
        /// Constant KENDRA for VoiceId
        /// </summary>
        public static readonly VoiceId KENDRA = new VoiceId("KENDRA");
        /// <summary>
        /// Constant KIMBERLY for VoiceId
        /// </summary>
        public static readonly VoiceId KIMBERLY = new VoiceId("KIMBERLY");
        /// <summary>
        /// Constant LEA for VoiceId
        /// </summary>
        public static readonly VoiceId LEA = new VoiceId("LEA");
        /// <summary>
        /// Constant LIV for VoiceId
        /// </summary>
        public static readonly VoiceId LIV = new VoiceId("LIV");
        /// <summary>
        /// Constant LOTTE for VoiceId
        /// </summary>
        public static readonly VoiceId LOTTE = new VoiceId("LOTTE");
        /// <summary>
        /// Constant LUCIA for VoiceId
        /// </summary>
        public static readonly VoiceId LUCIA = new VoiceId("LUCIA");
        /// <summary>
        /// Constant LUPE for VoiceId
        /// </summary>
        public static readonly VoiceId LUPE = new VoiceId("LUPE");
        /// <summary>
        /// Constant MADS for VoiceId
        /// </summary>
        public static readonly VoiceId MADS = new VoiceId("MADS");
        /// <summary>
        /// Constant MAJA for VoiceId
        /// </summary>
        public static readonly VoiceId MAJA = new VoiceId("MAJA");
        /// <summary>
        /// Constant MARLENE for VoiceId
        /// </summary>
        public static readonly VoiceId MARLENE = new VoiceId("MARLENE");
        /// <summary>
        /// Constant MATHIEU for VoiceId
        /// </summary>
        public static readonly VoiceId MATHIEU = new VoiceId("MATHIEU");
        /// <summary>
        /// Constant MATTHEW for VoiceId
        /// </summary>
        public static readonly VoiceId MATTHEW = new VoiceId("MATTHEW");
        /// <summary>
        /// Constant MAXIM for VoiceId
        /// </summary>
        public static readonly VoiceId MAXIM = new VoiceId("MAXIM");
        /// <summary>
        /// Constant MIA for VoiceId
        /// </summary>
        public static readonly VoiceId MIA = new VoiceId("MIA");
        /// <summary>
        /// Constant MIGUEL for VoiceId
        /// </summary>
        public static readonly VoiceId MIGUEL = new VoiceId("MIGUEL");
        /// <summary>
        /// Constant MIZUKI for VoiceId
        /// </summary>
        public static readonly VoiceId MIZUKI = new VoiceId("MIZUKI");
        /// <summary>
        /// Constant NAJA for VoiceId
        /// </summary>
        public static readonly VoiceId NAJA = new VoiceId("NAJA");
        /// <summary>
        /// Constant NICOLE for VoiceId
        /// </summary>
        public static readonly VoiceId NICOLE = new VoiceId("NICOLE");
        /// <summary>
        /// Constant PENELOPE for VoiceId
        /// </summary>
        public static readonly VoiceId PENELOPE = new VoiceId("PENELOPE");
        /// <summary>
        /// Constant RAVEENA for VoiceId
        /// </summary>
        public static readonly VoiceId RAVEENA = new VoiceId("RAVEENA");
        /// <summary>
        /// Constant RICARDO for VoiceId
        /// </summary>
        public static readonly VoiceId RICARDO = new VoiceId("RICARDO");
        /// <summary>
        /// Constant RUBEN for VoiceId
        /// </summary>
        public static readonly VoiceId RUBEN = new VoiceId("RUBEN");
        /// <summary>
        /// Constant RUSSELL for VoiceId
        /// </summary>
        public static readonly VoiceId RUSSELL = new VoiceId("RUSSELL");
        /// <summary>
        /// Constant SALLI for VoiceId
        /// </summary>
        public static readonly VoiceId SALLI = new VoiceId("SALLI");
        /// <summary>
        /// Constant SEOYEON for VoiceId
        /// </summary>
        public static readonly VoiceId SEOYEON = new VoiceId("SEOYEON");
        /// <summary>
        /// Constant TAKUMI for VoiceId
        /// </summary>
        public static readonly VoiceId TAKUMI = new VoiceId("TAKUMI");
        /// <summary>
        /// Constant TATYANA for VoiceId
        /// </summary>
        public static readonly VoiceId TATYANA = new VoiceId("TATYANA");
        /// <summary>
        /// Constant VICKI for VoiceId
        /// </summary>
        public static readonly VoiceId VICKI = new VoiceId("VICKI");
        /// <summary>
        /// Constant VITORIA for VoiceId
        /// </summary>
        public static readonly VoiceId VITORIA = new VoiceId("VITORIA");
        /// <summary>
        /// Constant ZEINA for VoiceId
        /// </summary>
        public static readonly VoiceId ZEINA = new VoiceId("ZEINA");
        /// <summary>
        /// Constant ZHIYU for VoiceId
        /// </summary>
        public static readonly VoiceId ZHIYU = new VoiceId("ZHIYU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceId FindValue(string value)
        {
            return FindValue<VoiceId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceId(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceMessageBodyTextType.
    /// </summary>
    public class VoiceMessageBodyTextType : ConstantClass
    {

        /// <summary>
        /// Constant SSML for VoiceMessageBodyTextType
        /// </summary>
        public static readonly VoiceMessageBodyTextType SSML = new VoiceMessageBodyTextType("SSML");
        /// <summary>
        /// Constant TEXT for VoiceMessageBodyTextType
        /// </summary>
        public static readonly VoiceMessageBodyTextType TEXT = new VoiceMessageBodyTextType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceMessageBodyTextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceMessageBodyTextType FindValue(string value)
        {
            return FindValue<VoiceMessageBodyTextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceMessageBodyTextType(string value)
        {
            return FindValue(value);
        }
    }

}
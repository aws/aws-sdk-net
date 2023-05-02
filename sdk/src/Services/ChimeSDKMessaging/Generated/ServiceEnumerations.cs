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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ChimeSDKMessaging
{

    /// <summary>
    /// Constants used for properties of type AllowNotifications.
    /// </summary>
    public class AllowNotifications : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AllowNotifications
        /// </summary>
        public static readonly AllowNotifications ALL = new AllowNotifications("ALL");
        /// <summary>
        /// Constant FILTERED for AllowNotifications
        /// </summary>
        public static readonly AllowNotifications FILTERED = new AllowNotifications("FILTERED");
        /// <summary>
        /// Constant NONE for AllowNotifications
        /// </summary>
        public static readonly AllowNotifications NONE = new AllowNotifications("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowNotifications(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowNotifications FindValue(string value)
        {
            return FindValue<AllowNotifications>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowNotifications(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelMembershipType.
    /// </summary>
    public class ChannelMembershipType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for ChannelMembershipType
        /// </summary>
        public static readonly ChannelMembershipType DEFAULT = new ChannelMembershipType("DEFAULT");
        /// <summary>
        /// Constant HIDDEN for ChannelMembershipType
        /// </summary>
        public static readonly ChannelMembershipType HIDDEN = new ChannelMembershipType("HIDDEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelMembershipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelMembershipType FindValue(string value)
        {
            return FindValue<ChannelMembershipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelMembershipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelMessagePersistenceType.
    /// </summary>
    public class ChannelMessagePersistenceType : ConstantClass
    {

        /// <summary>
        /// Constant NON_PERSISTENT for ChannelMessagePersistenceType
        /// </summary>
        public static readonly ChannelMessagePersistenceType NON_PERSISTENT = new ChannelMessagePersistenceType("NON_PERSISTENT");
        /// <summary>
        /// Constant PERSISTENT for ChannelMessagePersistenceType
        /// </summary>
        public static readonly ChannelMessagePersistenceType PERSISTENT = new ChannelMessagePersistenceType("PERSISTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelMessagePersistenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelMessagePersistenceType FindValue(string value)
        {
            return FindValue<ChannelMessagePersistenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelMessagePersistenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelMessageStatus.
    /// </summary>
    public class ChannelMessageStatus : ConstantClass
    {

        /// <summary>
        /// Constant DENIED for ChannelMessageStatus
        /// </summary>
        public static readonly ChannelMessageStatus DENIED = new ChannelMessageStatus("DENIED");
        /// <summary>
        /// Constant FAILED for ChannelMessageStatus
        /// </summary>
        public static readonly ChannelMessageStatus FAILED = new ChannelMessageStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ChannelMessageStatus
        /// </summary>
        public static readonly ChannelMessageStatus PENDING = new ChannelMessageStatus("PENDING");
        /// <summary>
        /// Constant SENT for ChannelMessageStatus
        /// </summary>
        public static readonly ChannelMessageStatus SENT = new ChannelMessageStatus("SENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelMessageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelMessageStatus FindValue(string value)
        {
            return FindValue<ChannelMessageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelMessageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelMessageType.
    /// </summary>
    public class ChannelMessageType : ConstantClass
    {

        /// <summary>
        /// Constant CONTROL for ChannelMessageType
        /// </summary>
        public static readonly ChannelMessageType CONTROL = new ChannelMessageType("CONTROL");
        /// <summary>
        /// Constant STANDARD for ChannelMessageType
        /// </summary>
        public static readonly ChannelMessageType STANDARD = new ChannelMessageType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelMessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelMessageType FindValue(string value)
        {
            return FindValue<ChannelMessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelMessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelMode.
    /// </summary>
    public class ChannelMode : ConstantClass
    {

        /// <summary>
        /// Constant RESTRICTED for ChannelMode
        /// </summary>
        public static readonly ChannelMode RESTRICTED = new ChannelMode("RESTRICTED");
        /// <summary>
        /// Constant UNRESTRICTED for ChannelMode
        /// </summary>
        public static readonly ChannelMode UNRESTRICTED = new ChannelMode("UNRESTRICTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelMode FindValue(string value)
        {
            return FindValue<ChannelMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelPrivacy.
    /// </summary>
    public class ChannelPrivacy : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for ChannelPrivacy
        /// </summary>
        public static readonly ChannelPrivacy PRIVATE = new ChannelPrivacy("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for ChannelPrivacy
        /// </summary>
        public static readonly ChannelPrivacy PUBLIC = new ChannelPrivacy("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelPrivacy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelPrivacy FindValue(string value)
        {
            return FindValue<ChannelPrivacy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelPrivacy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AccessDenied = new ErrorCode("AccessDenied");
        /// <summary>
        /// Constant BadRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode BadRequest = new ErrorCode("BadRequest");
        /// <summary>
        /// Constant Conflict for ErrorCode
        /// </summary>
        public static readonly ErrorCode Conflict = new ErrorCode("Conflict");
        /// <summary>
        /// Constant Forbidden for ErrorCode
        /// </summary>
        public static readonly ErrorCode Forbidden = new ErrorCode("Forbidden");
        /// <summary>
        /// Constant NotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotFound = new ErrorCode("NotFound");
        /// <summary>
        /// Constant PhoneNumberAssociationsExist for ErrorCode
        /// </summary>
        public static readonly ErrorCode PhoneNumberAssociationsExist = new ErrorCode("PhoneNumberAssociationsExist");
        /// <summary>
        /// Constant PreconditionFailed for ErrorCode
        /// </summary>
        public static readonly ErrorCode PreconditionFailed = new ErrorCode("PreconditionFailed");
        /// <summary>
        /// Constant ResourceLimitExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceLimitExceeded = new ErrorCode("ResourceLimitExceeded");
        /// <summary>
        /// Constant ServiceFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceFailure = new ErrorCode("ServiceFailure");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant Throttled for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttled = new ErrorCode("Throttled");
        /// <summary>
        /// Constant Throttling for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttling = new ErrorCode("Throttling");
        /// <summary>
        /// Constant Unauthorized for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unauthorized = new ErrorCode("Unauthorized");
        /// <summary>
        /// Constant Unprocessable for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unprocessable = new ErrorCode("Unprocessable");
        /// <summary>
        /// Constant VoiceConnectorGroupAssociationsExist for ErrorCode
        /// </summary>
        public static readonly ErrorCode VoiceConnectorGroupAssociationsExist = new ErrorCode("VoiceConnectorGroupAssociationsExist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpirationCriterion.
    /// </summary>
    public class ExpirationCriterion : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIMESTAMP for ExpirationCriterion
        /// </summary>
        public static readonly ExpirationCriterion CREATED_TIMESTAMP = new ExpirationCriterion("CREATED_TIMESTAMP");
        /// <summary>
        /// Constant LAST_MESSAGE_TIMESTAMP for ExpirationCriterion
        /// </summary>
        public static readonly ExpirationCriterion LAST_MESSAGE_TIMESTAMP = new ExpirationCriterion("LAST_MESSAGE_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationCriterion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationCriterion FindValue(string value)
        {
            return FindValue<ExpirationCriterion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationCriterion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FallbackAction.
    /// </summary>
    public class FallbackAction : ConstantClass
    {

        /// <summary>
        /// Constant ABORT for FallbackAction
        /// </summary>
        public static readonly FallbackAction ABORT = new FallbackAction("ABORT");
        /// <summary>
        /// Constant CONTINUE for FallbackAction
        /// </summary>
        public static readonly FallbackAction CONTINUE = new FallbackAction("CONTINUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FallbackAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FallbackAction FindValue(string value)
        {
            return FindValue<FallbackAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FallbackAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvocationType.
    /// </summary>
    public class InvocationType : ConstantClass
    {

        /// <summary>
        /// Constant ASYNC for InvocationType
        /// </summary>
        public static readonly InvocationType ASYNC = new InvocationType("ASYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvocationType FindValue(string value)
        {
            return FindValue<InvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessagingDataType.
    /// </summary>
    public class MessagingDataType : ConstantClass
    {

        /// <summary>
        /// Constant Channel for MessagingDataType
        /// </summary>
        public static readonly MessagingDataType Channel = new MessagingDataType("Channel");
        /// <summary>
        /// Constant ChannelMessage for MessagingDataType
        /// </summary>
        public static readonly MessagingDataType ChannelMessage = new MessagingDataType("ChannelMessage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessagingDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessagingDataType FindValue(string value)
        {
            return FindValue<MessagingDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessagingDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PushNotificationType.
    /// </summary>
    public class PushNotificationType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for PushNotificationType
        /// </summary>
        public static readonly PushNotificationType DEFAULT = new PushNotificationType("DEFAULT");
        /// <summary>
        /// Constant VOIP for PushNotificationType
        /// </summary>
        public static readonly PushNotificationType VOIP = new PushNotificationType("VOIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PushNotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PushNotificationType FindValue(string value)
        {
            return FindValue<PushNotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PushNotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchFieldKey.
    /// </summary>
    public class SearchFieldKey : ConstantClass
    {

        /// <summary>
        /// Constant MEMBERS for SearchFieldKey
        /// </summary>
        public static readonly SearchFieldKey MEMBERS = new SearchFieldKey("MEMBERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchFieldKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchFieldKey FindValue(string value)
        {
            return FindValue<SearchFieldKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchFieldKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchFieldOperator.
    /// </summary>
    public class SearchFieldOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for SearchFieldOperator
        /// </summary>
        public static readonly SearchFieldOperator EQUALS = new SearchFieldOperator("EQUALS");
        /// <summary>
        /// Constant INCLUDES for SearchFieldOperator
        /// </summary>
        public static readonly SearchFieldOperator INCLUDES = new SearchFieldOperator("INCLUDES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchFieldOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchFieldOperator FindValue(string value)
        {
            return FindValue<SearchFieldOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchFieldOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }

}
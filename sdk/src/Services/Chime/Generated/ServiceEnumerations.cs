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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Chime
{

    /// <summary>
    /// Constants used for properties of type AccountStatus.
    /// </summary>
    public class AccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for AccountStatus
        /// </summary>
        public static readonly AccountStatus Active = new AccountStatus("Active");
        /// <summary>
        /// Constant Suspended for AccountStatus
        /// </summary>
        public static readonly AccountStatus Suspended = new AccountStatus("Suspended");

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
    /// Constants used for properties of type AccountType.
    /// </summary>
    public class AccountType : ConstantClass
    {

        /// <summary>
        /// Constant EnterpriseDirectory for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseDirectory = new AccountType("EnterpriseDirectory");
        /// <summary>
        /// Constant EnterpriseLWA for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseLWA = new AccountType("EnterpriseLWA");
        /// <summary>
        /// Constant EnterpriseOIDC for AccountType
        /// </summary>
        public static readonly AccountType EnterpriseOIDC = new AccountType("EnterpriseOIDC");
        /// <summary>
        /// Constant Team for AccountType
        /// </summary>
        public static readonly AccountType Team = new AccountType("Team");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountType FindValue(string value)
        {
            return FindValue<AccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BotType.
    /// </summary>
    public class BotType : ConstantClass
    {

        /// <summary>
        /// Constant ChatBot for BotType
        /// </summary>
        public static readonly BotType ChatBot = new BotType("ChatBot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BotType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotType FindValue(string value)
        {
            return FindValue<BotType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallingNameStatus.
    /// </summary>
    public class CallingNameStatus : ConstantClass
    {

        /// <summary>
        /// Constant Unassigned for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus Unassigned = new CallingNameStatus("Unassigned");
        /// <summary>
        /// Constant UpdateFailed for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateFailed = new CallingNameStatus("UpdateFailed");
        /// <summary>
        /// Constant UpdateInProgress for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateInProgress = new CallingNameStatus("UpdateInProgress");
        /// <summary>
        /// Constant UpdateSucceeded for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateSucceeded = new CallingNameStatus("UpdateSucceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallingNameStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallingNameStatus FindValue(string value)
        {
            return FindValue<CallingNameStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallingNameStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmailStatus.
    /// </summary>
    public class EmailStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for EmailStatus
        /// </summary>
        public static readonly EmailStatus Failed = new EmailStatus("Failed");
        /// <summary>
        /// Constant NotSent for EmailStatus
        /// </summary>
        public static readonly EmailStatus NotSent = new EmailStatus("NotSent");
        /// <summary>
        /// Constant Sent for EmailStatus
        /// </summary>
        public static readonly EmailStatus Sent = new EmailStatus("Sent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmailStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmailStatus FindValue(string value)
        {
            return FindValue<EmailStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmailStatus(string value)
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
    /// Constants used for properties of type InviteStatus.
    /// </summary>
    public class InviteStatus : ConstantClass
    {

        /// <summary>
        /// Constant Accepted for InviteStatus
        /// </summary>
        public static readonly InviteStatus Accepted = new InviteStatus("Accepted");
        /// <summary>
        /// Constant Failed for InviteStatus
        /// </summary>
        public static readonly InviteStatus Failed = new InviteStatus("Failed");
        /// <summary>
        /// Constant Pending for InviteStatus
        /// </summary>
        public static readonly InviteStatus Pending = new InviteStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InviteStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InviteStatus FindValue(string value)
        {
            return FindValue<InviteStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InviteStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type License.
    /// </summary>
    public class License : ConstantClass
    {

        /// <summary>
        /// Constant Basic for License
        /// </summary>
        public static readonly License Basic = new License("Basic");
        /// <summary>
        /// Constant Plus for License
        /// </summary>
        public static readonly License Plus = new License("Plus");
        /// <summary>
        /// Constant Pro for License
        /// </summary>
        public static readonly License Pro = new License("Pro");
        /// <summary>
        /// Constant ProTrial for License
        /// </summary>
        public static readonly License ProTrial = new License("ProTrial");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public License(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static License FindValue(string value)
        {
            return FindValue<License>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator License(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberType.
    /// </summary>
    public class MemberType : ConstantClass
    {

        /// <summary>
        /// Constant Bot for MemberType
        /// </summary>
        public static readonly MemberType Bot = new MemberType("Bot");
        /// <summary>
        /// Constant User for MemberType
        /// </summary>
        public static readonly MemberType User = new MemberType("User");
        /// <summary>
        /// Constant Webhook for MemberType
        /// </summary>
        public static readonly MemberType Webhook = new MemberType("Webhook");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberType FindValue(string value)
        {
            return FindValue<MemberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderedPhoneNumberStatus.
    /// </summary>
    public class OrderedPhoneNumberStatus : ConstantClass
    {

        /// <summary>
        /// Constant Acquired for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Acquired = new OrderedPhoneNumberStatus("Acquired");
        /// <summary>
        /// Constant Failed for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Failed = new OrderedPhoneNumberStatus("Failed");
        /// <summary>
        /// Constant Processing for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Processing = new OrderedPhoneNumberStatus("Processing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderedPhoneNumberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderedPhoneNumberStatus FindValue(string value)
        {
            return FindValue<OrderedPhoneNumberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderedPhoneNumberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberAssociationName.
    /// </summary>
    public class PhoneNumberAssociationName : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName AccountId = new PhoneNumberAssociationName("AccountId");
        /// <summary>
        /// Constant SipRuleId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName SipRuleId = new PhoneNumberAssociationName("SipRuleId");
        /// <summary>
        /// Constant UserId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName UserId = new PhoneNumberAssociationName("UserId");
        /// <summary>
        /// Constant VoiceConnectorGroupId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName VoiceConnectorGroupId = new PhoneNumberAssociationName("VoiceConnectorGroupId");
        /// <summary>
        /// Constant VoiceConnectorId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName VoiceConnectorId = new PhoneNumberAssociationName("VoiceConnectorId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberAssociationName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberAssociationName FindValue(string value)
        {
            return FindValue<PhoneNumberAssociationName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberAssociationName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberOrderStatus.
    /// </summary>
    public class PhoneNumberOrderStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Failed = new PhoneNumberOrderStatus("Failed");
        /// <summary>
        /// Constant Partial for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Partial = new PhoneNumberOrderStatus("Partial");
        /// <summary>
        /// Constant Processing for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Processing = new PhoneNumberOrderStatus("Processing");
        /// <summary>
        /// Constant Successful for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Successful = new PhoneNumberOrderStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberOrderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberOrderStatus FindValue(string value)
        {
            return FindValue<PhoneNumberOrderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberOrderStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberProductType.
    /// </summary>
    public class PhoneNumberProductType : ConstantClass
    {

        /// <summary>
        /// Constant BusinessCalling for PhoneNumberProductType
        /// </summary>
        public static readonly PhoneNumberProductType BusinessCalling = new PhoneNumberProductType("BusinessCalling");
        /// <summary>
        /// Constant SipMediaApplicationDialIn for PhoneNumberProductType
        /// </summary>
        public static readonly PhoneNumberProductType SipMediaApplicationDialIn = new PhoneNumberProductType("SipMediaApplicationDialIn");
        /// <summary>
        /// Constant VoiceConnector for PhoneNumberProductType
        /// </summary>
        public static readonly PhoneNumberProductType VoiceConnector = new PhoneNumberProductType("VoiceConnector");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberProductType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberProductType FindValue(string value)
        {
            return FindValue<PhoneNumberProductType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberProductType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberStatus.
    /// </summary>
    public class PhoneNumberStatus : ConstantClass
    {

        /// <summary>
        /// Constant AcquireFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus AcquireFailed = new PhoneNumberStatus("AcquireFailed");
        /// <summary>
        /// Constant AcquireInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus AcquireInProgress = new PhoneNumberStatus("AcquireInProgress");
        /// <summary>
        /// Constant Assigned for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus Assigned = new PhoneNumberStatus("Assigned");
        /// <summary>
        /// Constant DeleteFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus DeleteFailed = new PhoneNumberStatus("DeleteFailed");
        /// <summary>
        /// Constant DeleteInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus DeleteInProgress = new PhoneNumberStatus("DeleteInProgress");
        /// <summary>
        /// Constant ReleaseFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus ReleaseFailed = new PhoneNumberStatus("ReleaseFailed");
        /// <summary>
        /// Constant ReleaseInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus ReleaseInProgress = new PhoneNumberStatus("ReleaseInProgress");
        /// <summary>
        /// Constant Unassigned for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus Unassigned = new PhoneNumberStatus("Unassigned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberStatus FindValue(string value)
        {
            return FindValue<PhoneNumberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberType.
    /// </summary>
    public class PhoneNumberType : ConstantClass
    {

        /// <summary>
        /// Constant Local for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType Local = new PhoneNumberType("Local");
        /// <summary>
        /// Constant TollFree for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType TollFree = new PhoneNumberType("TollFree");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberType FindValue(string value)
        {
            return FindValue<PhoneNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberType(string value)
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
        /// Constant Registered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Registered = new RegistrationStatus("Registered");
        /// <summary>
        /// Constant Suspended for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Suspended = new RegistrationStatus("Suspended");
        /// <summary>
        /// Constant Unregistered for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus Unregistered = new RegistrationStatus("Unregistered");

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
    /// Constants used for properties of type RoomMembershipRole.
    /// </summary>
    public class RoomMembershipRole : ConstantClass
    {

        /// <summary>
        /// Constant Administrator for RoomMembershipRole
        /// </summary>
        public static readonly RoomMembershipRole Administrator = new RoomMembershipRole("Administrator");
        /// <summary>
        /// Constant Member for RoomMembershipRole
        /// </summary>
        public static readonly RoomMembershipRole Member = new RoomMembershipRole("Member");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoomMembershipRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoomMembershipRole FindValue(string value)
        {
            return FindValue<RoomMembershipRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoomMembershipRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant PrivateUser for UserType
        /// </summary>
        public static readonly UserType PrivateUser = new UserType("PrivateUser");
        /// <summary>
        /// Constant SharedDevice for UserType
        /// </summary>
        public static readonly UserType SharedDevice = new UserType("SharedDevice");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
        {
            return FindValue(value);
        }
    }

}
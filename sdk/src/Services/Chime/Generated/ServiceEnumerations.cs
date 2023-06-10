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
    /// Constants used for properties of type AppInstanceDataType.
    /// </summary>
    public class AppInstanceDataType : ConstantClass
    {

        /// <summary>
        /// Constant Channel for AppInstanceDataType
        /// </summary>
        public static readonly AppInstanceDataType Channel = new AppInstanceDataType("Channel");
        /// <summary>
        /// Constant ChannelMessage for AppInstanceDataType
        /// </summary>
        public static readonly AppInstanceDataType ChannelMessage = new AppInstanceDataType("ChannelMessage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppInstanceDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppInstanceDataType FindValue(string value)
        {
            return FindValue<AppInstanceDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppInstanceDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactsState.
    /// </summary>
    public class ArtifactsState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Disabled = new ArtifactsState("Disabled");
        /// <summary>
        /// Constant Enabled for ArtifactsState
        /// </summary>
        public static readonly ArtifactsState Enabled = new ArtifactsState("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactsState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactsState FindValue(string value)
        {
            return FindValue<ArtifactsState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactsState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AudioMuxType.
    /// </summary>
    public class AudioMuxType : ConstantClass
    {

        /// <summary>
        /// Constant AudioOnly for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioOnly = new AudioMuxType("AudioOnly");
        /// <summary>
        /// Constant AudioWithActiveSpeakerVideo for AudioMuxType
        /// </summary>
        public static readonly AudioMuxType AudioWithActiveSpeakerVideo = new AudioMuxType("AudioWithActiveSpeakerVideo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AudioMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AudioMuxType FindValue(string value)
        {
            return FindValue<AudioMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AudioMuxType(string value)
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
    /// Constants used for properties of type Capability.
    /// </summary>
    public class Capability : ConstantClass
    {

        /// <summary>
        /// Constant SMS for Capability
        /// </summary>
        public static readonly Capability SMS = new Capability("SMS");
        /// <summary>
        /// Constant Voice for Capability
        /// </summary>
        public static readonly Capability Voice = new Capability("Voice");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Capability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Capability FindValue(string value)
        {
            return FindValue<Capability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Capability(string value)
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
    /// Constants used for properties of type ContentMuxType.
    /// </summary>
    public class ContentMuxType : ConstantClass
    {

        /// <summary>
        /// Constant ContentOnly for ContentMuxType
        /// </summary>
        public static readonly ContentMuxType ContentOnly = new ContentMuxType("ContentOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentMuxType FindValue(string value)
        {
            return FindValue<ContentMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentMuxType(string value)
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
    /// Constants used for properties of type GeoMatchLevel.
    /// </summary>
    public class GeoMatchLevel : ConstantClass
    {

        /// <summary>
        /// Constant AreaCode for GeoMatchLevel
        /// </summary>
        public static readonly GeoMatchLevel AreaCode = new GeoMatchLevel("AreaCode");
        /// <summary>
        /// Constant Country for GeoMatchLevel
        /// </summary>
        public static readonly GeoMatchLevel Country = new GeoMatchLevel("Country");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoMatchLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoMatchLevel FindValue(string value)
        {
            return FindValue<GeoMatchLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoMatchLevel(string value)
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
    /// Constants used for properties of type MediaPipelineSinkType.
    /// </summary>
    public class MediaPipelineSinkType : ConstantClass
    {

        /// <summary>
        /// Constant S3Bucket for MediaPipelineSinkType
        /// </summary>
        public static readonly MediaPipelineSinkType S3Bucket = new MediaPipelineSinkType("S3Bucket");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSinkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSinkType FindValue(string value)
        {
            return FindValue<MediaPipelineSinkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSinkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineSourceType.
    /// </summary>
    public class MediaPipelineSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ChimeSdkMeeting for MediaPipelineSourceType
        /// </summary>
        public static readonly MediaPipelineSourceType ChimeSdkMeeting = new MediaPipelineSourceType("ChimeSdkMeeting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineSourceType FindValue(string value)
        {
            return FindValue<MediaPipelineSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaPipelineStatus.
    /// </summary>
    public class MediaPipelineStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Failed = new MediaPipelineStatus("Failed");
        /// <summary>
        /// Constant Initializing for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Initializing = new MediaPipelineStatus("Initializing");
        /// <summary>
        /// Constant InProgress for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus InProgress = new MediaPipelineStatus("InProgress");
        /// <summary>
        /// Constant Stopped for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopped = new MediaPipelineStatus("Stopped");
        /// <summary>
        /// Constant Stopping for MediaPipelineStatus
        /// </summary>
        public static readonly MediaPipelineStatus Stopping = new MediaPipelineStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaPipelineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaPipelineStatus FindValue(string value)
        {
            return FindValue<MediaPipelineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaPipelineStatus(string value)
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
    /// Constants used for properties of type NotificationTarget.
    /// </summary>
    public class NotificationTarget : ConstantClass
    {

        /// <summary>
        /// Constant EventBridge for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget EventBridge = new NotificationTarget("EventBridge");
        /// <summary>
        /// Constant SNS for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget SNS = new NotificationTarget("SNS");
        /// <summary>
        /// Constant SQS for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget SQS = new NotificationTarget("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationTarget FindValue(string value)
        {
            return FindValue<NotificationTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberSelectionBehavior.
    /// </summary>
    public class NumberSelectionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant AvoidSticky for NumberSelectionBehavior
        /// </summary>
        public static readonly NumberSelectionBehavior AvoidSticky = new NumberSelectionBehavior("AvoidSticky");
        /// <summary>
        /// Constant PreferSticky for NumberSelectionBehavior
        /// </summary>
        public static readonly NumberSelectionBehavior PreferSticky = new NumberSelectionBehavior("PreferSticky");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberSelectionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberSelectionBehavior FindValue(string value)
        {
            return FindValue<NumberSelectionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberSelectionBehavior(string value)
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
    /// Constants used for properties of type OriginationRouteProtocol.
    /// </summary>
    public class OriginationRouteProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for OriginationRouteProtocol
        /// </summary>
        public static readonly OriginationRouteProtocol TCP = new OriginationRouteProtocol("TCP");
        /// <summary>
        /// Constant UDP for OriginationRouteProtocol
        /// </summary>
        public static readonly OriginationRouteProtocol UDP = new OriginationRouteProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginationRouteProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginationRouteProtocol FindValue(string value)
        {
            return FindValue<OriginationRouteProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginationRouteProtocol(string value)
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
    /// Constants used for properties of type ProxySessionStatus.
    /// </summary>
    public class ProxySessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Closed for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus Closed = new ProxySessionStatus("Closed");
        /// <summary>
        /// Constant InProgress for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus InProgress = new ProxySessionStatus("InProgress");
        /// <summary>
        /// Constant Open for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus Open = new ProxySessionStatus("Open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProxySessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxySessionStatus FindValue(string value)
        {
            return FindValue<ProxySessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxySessionStatus(string value)
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
    /// Constants used for properties of type SipRuleTriggerType.
    /// </summary>
    public class SipRuleTriggerType : ConstantClass
    {

        /// <summary>
        /// Constant RequestUriHostname for SipRuleTriggerType
        /// </summary>
        public static readonly SipRuleTriggerType RequestUriHostname = new SipRuleTriggerType("RequestUriHostname");
        /// <summary>
        /// Constant ToPhoneNumber for SipRuleTriggerType
        /// </summary>
        public static readonly SipRuleTriggerType ToPhoneNumber = new SipRuleTriggerType("ToPhoneNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SipRuleTriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SipRuleTriggerType FindValue(string value)
        {
            return FindValue<SipRuleTriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SipRuleTriggerType(string value)
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


    /// <summary>
    /// Constants used for properties of type TranscribeContentIdentificationType.
    /// </summary>
    public class TranscribeContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PII for TranscribeContentIdentificationType
        /// </summary>
        public static readonly TranscribeContentIdentificationType PII = new TranscribeContentIdentificationType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeContentIdentificationType FindValue(string value)
        {
            return FindValue<TranscribeContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeContentRedactionType.
    /// </summary>
    public class TranscribeContentRedactionType : ConstantClass
    {

        /// <summary>
        /// Constant PII for TranscribeContentRedactionType
        /// </summary>
        public static readonly TranscribeContentRedactionType PII = new TranscribeContentRedactionType("PII");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeContentRedactionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeContentRedactionType FindValue(string value)
        {
            return FindValue<TranscribeContentRedactionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeContentRedactionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeLanguageCode.
    /// </summary>
    public class TranscribeLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode DeDE = new TranscribeLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAU for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnAU = new TranscribeLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnGB = new TranscribeLanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EnUS = new TranscribeLanguageCode("en-US");
        /// <summary>
        /// Constant EsUS for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode EsUS = new TranscribeLanguageCode("es-US");
        /// <summary>
        /// Constant FrCA for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode FrCA = new TranscribeLanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode FrFR = new TranscribeLanguageCode("fr-FR");
        /// <summary>
        /// Constant HiIN for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode HiIN = new TranscribeLanguageCode("hi-IN");
        /// <summary>
        /// Constant ItIT for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ItIT = new TranscribeLanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode JaJP = new TranscribeLanguageCode("ja-JP");
        /// <summary>
        /// Constant KoKR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode KoKR = new TranscribeLanguageCode("ko-KR");
        /// <summary>
        /// Constant PtBR for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode PtBR = new TranscribeLanguageCode("pt-BR");
        /// <summary>
        /// Constant ThTH for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ThTH = new TranscribeLanguageCode("th-TH");
        /// <summary>
        /// Constant ZhCN for TranscribeLanguageCode
        /// </summary>
        public static readonly TranscribeLanguageCode ZhCN = new TranscribeLanguageCode("zh-CN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeLanguageCode FindValue(string value)
        {
            return FindValue<TranscribeLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalContentIdentificationType.
    /// </summary>
    public class TranscribeMedicalContentIdentificationType : ConstantClass
    {

        /// <summary>
        /// Constant PHI for TranscribeMedicalContentIdentificationType
        /// </summary>
        public static readonly TranscribeMedicalContentIdentificationType PHI = new TranscribeMedicalContentIdentificationType("PHI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalContentIdentificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalContentIdentificationType FindValue(string value)
        {
            return FindValue<TranscribeMedicalContentIdentificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalContentIdentificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalLanguageCode.
    /// </summary>
    public class TranscribeMedicalLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for TranscribeMedicalLanguageCode
        /// </summary>
        public static readonly TranscribeMedicalLanguageCode EnUS = new TranscribeMedicalLanguageCode("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalLanguageCode FindValue(string value)
        {
            return FindValue<TranscribeMedicalLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalRegion.
    /// </summary>
    public class TranscribeMedicalRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApSoutheast2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion ApSoutheast2 = new TranscribeMedicalRegion("ap-southeast-2");
        /// <summary>
        /// Constant Auto for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion Auto = new TranscribeMedicalRegion("auto");
        /// <summary>
        /// Constant CaCentral1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion CaCentral1 = new TranscribeMedicalRegion("ca-central-1");
        /// <summary>
        /// Constant EuWest1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion EuWest1 = new TranscribeMedicalRegion("eu-west-1");
        /// <summary>
        /// Constant UsEast1 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsEast1 = new TranscribeMedicalRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsEast2 = new TranscribeMedicalRegion("us-east-2");
        /// <summary>
        /// Constant UsWest2 for TranscribeMedicalRegion
        /// </summary>
        public static readonly TranscribeMedicalRegion UsWest2 = new TranscribeMedicalRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalRegion FindValue(string value)
        {
            return FindValue<TranscribeMedicalRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalSpecialty.
    /// </summary>
    public class TranscribeMedicalSpecialty : ConstantClass
    {

        /// <summary>
        /// Constant CARDIOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty CARDIOLOGY = new TranscribeMedicalSpecialty("CARDIOLOGY");
        /// <summary>
        /// Constant NEUROLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty NEUROLOGY = new TranscribeMedicalSpecialty("NEUROLOGY");
        /// <summary>
        /// Constant ONCOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty ONCOLOGY = new TranscribeMedicalSpecialty("ONCOLOGY");
        /// <summary>
        /// Constant PRIMARYCARE for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty PRIMARYCARE = new TranscribeMedicalSpecialty("PRIMARYCARE");
        /// <summary>
        /// Constant RADIOLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty RADIOLOGY = new TranscribeMedicalSpecialty("RADIOLOGY");
        /// <summary>
        /// Constant UROLOGY for TranscribeMedicalSpecialty
        /// </summary>
        public static readonly TranscribeMedicalSpecialty UROLOGY = new TranscribeMedicalSpecialty("UROLOGY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalSpecialty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalSpecialty FindValue(string value)
        {
            return FindValue<TranscribeMedicalSpecialty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalSpecialty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeMedicalType.
    /// </summary>
    public class TranscribeMedicalType : ConstantClass
    {

        /// <summary>
        /// Constant CONVERSATION for TranscribeMedicalType
        /// </summary>
        public static readonly TranscribeMedicalType CONVERSATION = new TranscribeMedicalType("CONVERSATION");
        /// <summary>
        /// Constant DICTATION for TranscribeMedicalType
        /// </summary>
        public static readonly TranscribeMedicalType DICTATION = new TranscribeMedicalType("DICTATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeMedicalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeMedicalType FindValue(string value)
        {
            return FindValue<TranscribeMedicalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeMedicalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribePartialResultsStability.
    /// </summary>
    public class TranscribePartialResultsStability : ConstantClass
    {

        /// <summary>
        /// Constant High for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability High = new TranscribePartialResultsStability("high");
        /// <summary>
        /// Constant Low for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability Low = new TranscribePartialResultsStability("low");
        /// <summary>
        /// Constant Medium for TranscribePartialResultsStability
        /// </summary>
        public static readonly TranscribePartialResultsStability Medium = new TranscribePartialResultsStability("medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribePartialResultsStability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribePartialResultsStability FindValue(string value)
        {
            return FindValue<TranscribePartialResultsStability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribePartialResultsStability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeRegion.
    /// </summary>
    public class TranscribeRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApNortheast1 = new TranscribeRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApNortheast2 = new TranscribeRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSoutheast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion ApSoutheast2 = new TranscribeRegion("ap-southeast-2");
        /// <summary>
        /// Constant Auto for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion Auto = new TranscribeRegion("auto");
        /// <summary>
        /// Constant CaCentral1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion CaCentral1 = new TranscribeRegion("ca-central-1");
        /// <summary>
        /// Constant EuCentral1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuCentral1 = new TranscribeRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuWest1 = new TranscribeRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion EuWest2 = new TranscribeRegion("eu-west-2");
        /// <summary>
        /// Constant SaEast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion SaEast1 = new TranscribeRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsEast1 = new TranscribeRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsEast2 = new TranscribeRegion("us-east-2");
        /// <summary>
        /// Constant UsWest2 for TranscribeRegion
        /// </summary>
        public static readonly TranscribeRegion UsWest2 = new TranscribeRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeRegion FindValue(string value)
        {
            return FindValue<TranscribeRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscribeVocabularyFilterMethod.
    /// </summary>
    public class TranscribeVocabularyFilterMethod : ConstantClass
    {

        /// <summary>
        /// Constant Mask for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Mask = new TranscribeVocabularyFilterMethod("mask");
        /// <summary>
        /// Constant Remove for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Remove = new TranscribeVocabularyFilterMethod("remove");
        /// <summary>
        /// Constant Tag for TranscribeVocabularyFilterMethod
        /// </summary>
        public static readonly TranscribeVocabularyFilterMethod Tag = new TranscribeVocabularyFilterMethod("tag");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscribeVocabularyFilterMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscribeVocabularyFilterMethod FindValue(string value)
        {
            return FindValue<TranscribeVocabularyFilterMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscribeVocabularyFilterMethod(string value)
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


    /// <summary>
    /// Constants used for properties of type VideoMuxType.
    /// </summary>
    public class VideoMuxType : ConstantClass
    {

        /// <summary>
        /// Constant VideoOnly for VideoMuxType
        /// </summary>
        public static readonly VideoMuxType VideoOnly = new VideoMuxType("VideoOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoMuxType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoMuxType FindValue(string value)
        {
            return FindValue<VideoMuxType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoMuxType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceConnectorAwsRegion.
    /// </summary>
    public class VoiceConnectorAwsRegion : ConstantClass
    {

        /// <summary>
        /// Constant UsEast1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion UsEast1 = new VoiceConnectorAwsRegion("us-east-1");
        /// <summary>
        /// Constant UsWest2 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion UsWest2 = new VoiceConnectorAwsRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceConnectorAwsRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceConnectorAwsRegion FindValue(string value)
        {
            return FindValue<VoiceConnectorAwsRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceConnectorAwsRegion(string value)
        {
            return FindValue(value);
        }
    }

}
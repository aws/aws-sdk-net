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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{

    /// <summary>
    /// Constants used for properties of type AccountTakeoverEventActionType.
    /// </summary>
    public class AccountTakeoverEventActionType : ConstantClass
    {

        /// <summary>
        /// Constant BLOCK for AccountTakeoverEventActionType
        /// </summary>
        public static readonly AccountTakeoverEventActionType BLOCK = new AccountTakeoverEventActionType("BLOCK");
        /// <summary>
        /// Constant MFA_IF_CONFIGURED for AccountTakeoverEventActionType
        /// </summary>
        public static readonly AccountTakeoverEventActionType MFA_IF_CONFIGURED = new AccountTakeoverEventActionType("MFA_IF_CONFIGURED");
        /// <summary>
        /// Constant MFA_REQUIRED for AccountTakeoverEventActionType
        /// </summary>
        public static readonly AccountTakeoverEventActionType MFA_REQUIRED = new AccountTakeoverEventActionType("MFA_REQUIRED");
        /// <summary>
        /// Constant NO_ACTION for AccountTakeoverEventActionType
        /// </summary>
        public static readonly AccountTakeoverEventActionType NO_ACTION = new AccountTakeoverEventActionType("NO_ACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountTakeoverEventActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountTakeoverEventActionType FindValue(string value)
        {
            return FindValue<AccountTakeoverEventActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountTakeoverEventActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdvancedSecurityModeType.
    /// </summary>
    public class AdvancedSecurityModeType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIT for AdvancedSecurityModeType
        /// </summary>
        public static readonly AdvancedSecurityModeType AUDIT = new AdvancedSecurityModeType("AUDIT");
        /// <summary>
        /// Constant ENFORCED for AdvancedSecurityModeType
        /// </summary>
        public static readonly AdvancedSecurityModeType ENFORCED = new AdvancedSecurityModeType("ENFORCED");
        /// <summary>
        /// Constant OFF for AdvancedSecurityModeType
        /// </summary>
        public static readonly AdvancedSecurityModeType OFF = new AdvancedSecurityModeType("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdvancedSecurityModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdvancedSecurityModeType FindValue(string value)
        {
            return FindValue<AdvancedSecurityModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdvancedSecurityModeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AliasAttributeType.
    /// </summary>
    public class AliasAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant Email for AliasAttributeType
        /// </summary>
        public static readonly AliasAttributeType Email = new AliasAttributeType("email");
        /// <summary>
        /// Constant Phone_number for AliasAttributeType
        /// </summary>
        public static readonly AliasAttributeType Phone_number = new AliasAttributeType("phone_number");
        /// <summary>
        /// Constant Preferred_username for AliasAttributeType
        /// </summary>
        public static readonly AliasAttributeType Preferred_username = new AliasAttributeType("preferred_username");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AliasAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AliasAttributeType FindValue(string value)
        {
            return FindValue<AliasAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AliasAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeDataType.
    /// </summary>
    public class AttributeDataType : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for AttributeDataType
        /// </summary>
        public static readonly AttributeDataType Boolean = new AttributeDataType("Boolean");
        /// <summary>
        /// Constant DateTime for AttributeDataType
        /// </summary>
        public static readonly AttributeDataType DateTime = new AttributeDataType("DateTime");
        /// <summary>
        /// Constant Number for AttributeDataType
        /// </summary>
        public static readonly AttributeDataType Number = new AttributeDataType("Number");
        /// <summary>
        /// Constant String for AttributeDataType
        /// </summary>
        public static readonly AttributeDataType String = new AttributeDataType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeDataType FindValue(string value)
        {
            return FindValue<AttributeDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthFlowType.
    /// </summary>
    public class AuthFlowType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_NO_SRP_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType ADMIN_NO_SRP_AUTH = new AuthFlowType("ADMIN_NO_SRP_AUTH");
        /// <summary>
        /// Constant CUSTOM_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType CUSTOM_AUTH = new AuthFlowType("CUSTOM_AUTH");
        /// <summary>
        /// Constant REFRESH_TOKEN for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType REFRESH_TOKEN = new AuthFlowType("REFRESH_TOKEN");
        /// <summary>
        /// Constant REFRESH_TOKEN_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType REFRESH_TOKEN_AUTH = new AuthFlowType("REFRESH_TOKEN_AUTH");
        /// <summary>
        /// Constant USER_PASSWORD_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType USER_PASSWORD_AUTH = new AuthFlowType("USER_PASSWORD_AUTH");
        /// <summary>
        /// Constant USER_SRP_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType USER_SRP_AUTH = new AuthFlowType("USER_SRP_AUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthFlowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthFlowType FindValue(string value)
        {
            return FindValue<AuthFlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthFlowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChallengeName.
    /// </summary>
    public class ChallengeName : ConstantClass
    {

        /// <summary>
        /// Constant Mfa for ChallengeName
        /// </summary>
        public static readonly ChallengeName Mfa = new ChallengeName("Mfa");
        /// <summary>
        /// Constant Password for ChallengeName
        /// </summary>
        public static readonly ChallengeName Password = new ChallengeName("Password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChallengeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChallengeName FindValue(string value)
        {
            return FindValue<ChallengeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChallengeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChallengeNameType.
    /// </summary>
    public class ChallengeNameType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_NO_SRP_AUTH for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType ADMIN_NO_SRP_AUTH = new ChallengeNameType("ADMIN_NO_SRP_AUTH");
        /// <summary>
        /// Constant CUSTOM_CHALLENGE for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType CUSTOM_CHALLENGE = new ChallengeNameType("CUSTOM_CHALLENGE");
        /// <summary>
        /// Constant DEVICE_PASSWORD_VERIFIER for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType DEVICE_PASSWORD_VERIFIER = new ChallengeNameType("DEVICE_PASSWORD_VERIFIER");
        /// <summary>
        /// Constant DEVICE_SRP_AUTH for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType DEVICE_SRP_AUTH = new ChallengeNameType("DEVICE_SRP_AUTH");
        /// <summary>
        /// Constant MFA_SETUP for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType MFA_SETUP = new ChallengeNameType("MFA_SETUP");
        /// <summary>
        /// Constant NEW_PASSWORD_REQUIRED for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType NEW_PASSWORD_REQUIRED = new ChallengeNameType("NEW_PASSWORD_REQUIRED");
        /// <summary>
        /// Constant PASSWORD_VERIFIER for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType PASSWORD_VERIFIER = new ChallengeNameType("PASSWORD_VERIFIER");
        /// <summary>
        /// Constant SELECT_MFA_TYPE for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SELECT_MFA_TYPE = new ChallengeNameType("SELECT_MFA_TYPE");
        /// <summary>
        /// Constant SMS_MFA for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SMS_MFA = new ChallengeNameType("SMS_MFA");
        /// <summary>
        /// Constant SOFTWARE_TOKEN_MFA for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SOFTWARE_TOKEN_MFA = new ChallengeNameType("SOFTWARE_TOKEN_MFA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChallengeNameType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChallengeNameType FindValue(string value)
        {
            return FindValue<ChallengeNameType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChallengeNameType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChallengeResponse.
    /// </summary>
    public class ChallengeResponse : ConstantClass
    {

        /// <summary>
        /// Constant Failure for ChallengeResponse
        /// </summary>
        public static readonly ChallengeResponse Failure = new ChallengeResponse("Failure");
        /// <summary>
        /// Constant Success for ChallengeResponse
        /// </summary>
        public static readonly ChallengeResponse Success = new ChallengeResponse("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChallengeResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChallengeResponse FindValue(string value)
        {
            return FindValue<ChallengeResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChallengeResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompromisedCredentialsEventActionType.
    /// </summary>
    public class CompromisedCredentialsEventActionType : ConstantClass
    {

        /// <summary>
        /// Constant BLOCK for CompromisedCredentialsEventActionType
        /// </summary>
        public static readonly CompromisedCredentialsEventActionType BLOCK = new CompromisedCredentialsEventActionType("BLOCK");
        /// <summary>
        /// Constant NO_ACTION for CompromisedCredentialsEventActionType
        /// </summary>
        public static readonly CompromisedCredentialsEventActionType NO_ACTION = new CompromisedCredentialsEventActionType("NO_ACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompromisedCredentialsEventActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompromisedCredentialsEventActionType FindValue(string value)
        {
            return FindValue<CompromisedCredentialsEventActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompromisedCredentialsEventActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultEmailOptionType.
    /// </summary>
    public class DefaultEmailOptionType : ConstantClass
    {

        /// <summary>
        /// Constant CONFIRM_WITH_CODE for DefaultEmailOptionType
        /// </summary>
        public static readonly DefaultEmailOptionType CONFIRM_WITH_CODE = new DefaultEmailOptionType("CONFIRM_WITH_CODE");
        /// <summary>
        /// Constant CONFIRM_WITH_LINK for DefaultEmailOptionType
        /// </summary>
        public static readonly DefaultEmailOptionType CONFIRM_WITH_LINK = new DefaultEmailOptionType("CONFIRM_WITH_LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultEmailOptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultEmailOptionType FindValue(string value)
        {
            return FindValue<DefaultEmailOptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultEmailOptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryMediumType.
    /// </summary>
    public class DeliveryMediumType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for DeliveryMediumType
        /// </summary>
        public static readonly DeliveryMediumType EMAIL = new DeliveryMediumType("EMAIL");
        /// <summary>
        /// Constant SMS for DeliveryMediumType
        /// </summary>
        public static readonly DeliveryMediumType SMS = new DeliveryMediumType("SMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryMediumType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryMediumType FindValue(string value)
        {
            return FindValue<DeliveryMediumType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryMediumType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceRememberedStatusType.
    /// </summary>
    public class DeviceRememberedStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Not_remembered for DeviceRememberedStatusType
        /// </summary>
        public static readonly DeviceRememberedStatusType Not_remembered = new DeviceRememberedStatusType("not_remembered");
        /// <summary>
        /// Constant Remembered for DeviceRememberedStatusType
        /// </summary>
        public static readonly DeviceRememberedStatusType Remembered = new DeviceRememberedStatusType("remembered");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceRememberedStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceRememberedStatusType FindValue(string value)
        {
            return FindValue<DeviceRememberedStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceRememberedStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatusType.
    /// </summary>
    public class DomainStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DomainStatusType
        /// </summary>
        public static readonly DomainStatusType ACTIVE = new DomainStatusType("ACTIVE");
        /// <summary>
        /// Constant CREATING for DomainStatusType
        /// </summary>
        public static readonly DomainStatusType CREATING = new DomainStatusType("CREATING");
        /// <summary>
        /// Constant DELETING for DomainStatusType
        /// </summary>
        public static readonly DomainStatusType DELETING = new DomainStatusType("DELETING");
        /// <summary>
        /// Constant FAILED for DomainStatusType
        /// </summary>
        public static readonly DomainStatusType FAILED = new DomainStatusType("FAILED");
        /// <summary>
        /// Constant UPDATING for DomainStatusType
        /// </summary>
        public static readonly DomainStatusType UPDATING = new DomainStatusType("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatusType FindValue(string value)
        {
            return FindValue<DomainStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventFilterType.
    /// </summary>
    public class EventFilterType : ConstantClass
    {

        /// <summary>
        /// Constant PASSWORD_CHANGE for EventFilterType
        /// </summary>
        public static readonly EventFilterType PASSWORD_CHANGE = new EventFilterType("PASSWORD_CHANGE");
        /// <summary>
        /// Constant SIGN_IN for EventFilterType
        /// </summary>
        public static readonly EventFilterType SIGN_IN = new EventFilterType("SIGN_IN");
        /// <summary>
        /// Constant SIGN_UP for EventFilterType
        /// </summary>
        public static readonly EventFilterType SIGN_UP = new EventFilterType("SIGN_UP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventFilterType FindValue(string value)
        {
            return FindValue<EventFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventResponseType.
    /// </summary>
    public class EventResponseType : ConstantClass
    {

        /// <summary>
        /// Constant Failure for EventResponseType
        /// </summary>
        public static readonly EventResponseType Failure = new EventResponseType("Failure");
        /// <summary>
        /// Constant Success for EventResponseType
        /// </summary>
        public static readonly EventResponseType Success = new EventResponseType("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventResponseType FindValue(string value)
        {
            return FindValue<EventResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventResponseType(string value)
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
        /// Constant ForgotPassword for EventType
        /// </summary>
        public static readonly EventType ForgotPassword = new EventType("ForgotPassword");
        /// <summary>
        /// Constant SignIn for EventType
        /// </summary>
        public static readonly EventType SignIn = new EventType("SignIn");
        /// <summary>
        /// Constant SignUp for EventType
        /// </summary>
        public static readonly EventType SignUp = new EventType("SignUp");

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
    /// Constants used for properties of type ExplicitAuthFlowsType.
    /// </summary>
    public class ExplicitAuthFlowsType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_NO_SRP_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ADMIN_NO_SRP_AUTH = new ExplicitAuthFlowsType("ADMIN_NO_SRP_AUTH");
        /// <summary>
        /// Constant CUSTOM_AUTH_FLOW_ONLY for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType CUSTOM_AUTH_FLOW_ONLY = new ExplicitAuthFlowsType("CUSTOM_AUTH_FLOW_ONLY");
        /// <summary>
        /// Constant USER_PASSWORD_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType USER_PASSWORD_AUTH = new ExplicitAuthFlowsType("USER_PASSWORD_AUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExplicitAuthFlowsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExplicitAuthFlowsType FindValue(string value)
        {
            return FindValue<ExplicitAuthFlowsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExplicitAuthFlowsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedbackValueType.
    /// </summary>
    public class FeedbackValueType : ConstantClass
    {

        /// <summary>
        /// Constant Invalid for FeedbackValueType
        /// </summary>
        public static readonly FeedbackValueType Invalid = new FeedbackValueType("Invalid");
        /// <summary>
        /// Constant Valid for FeedbackValueType
        /// </summary>
        public static readonly FeedbackValueType Valid = new FeedbackValueType("Valid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackValueType FindValue(string value)
        {
            return FindValue<FeedbackValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProviderTypeType.
    /// </summary>
    public class IdentityProviderTypeType : ConstantClass
    {

        /// <summary>
        /// Constant Facebook for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType Facebook = new IdentityProviderTypeType("Facebook");
        /// <summary>
        /// Constant Google for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType Google = new IdentityProviderTypeType("Google");
        /// <summary>
        /// Constant LoginWithAmazon for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType LoginWithAmazon = new IdentityProviderTypeType("LoginWithAmazon");
        /// <summary>
        /// Constant OIDC for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType OIDC = new IdentityProviderTypeType("OIDC");
        /// <summary>
        /// Constant SAML for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType SAML = new IdentityProviderTypeType("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderTypeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderTypeType FindValue(string value)
        {
            return FindValue<IdentityProviderTypeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderTypeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageActionType.
    /// </summary>
    public class MessageActionType : ConstantClass
    {

        /// <summary>
        /// Constant RESEND for MessageActionType
        /// </summary>
        public static readonly MessageActionType RESEND = new MessageActionType("RESEND");
        /// <summary>
        /// Constant SUPPRESS for MessageActionType
        /// </summary>
        public static readonly MessageActionType SUPPRESS = new MessageActionType("SUPPRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageActionType FindValue(string value)
        {
            return FindValue<MessageActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OAuthFlowType.
    /// </summary>
    public class OAuthFlowType : ConstantClass
    {

        /// <summary>
        /// Constant Client_credentials for OAuthFlowType
        /// </summary>
        public static readonly OAuthFlowType Client_credentials = new OAuthFlowType("client_credentials");
        /// <summary>
        /// Constant Code for OAuthFlowType
        /// </summary>
        public static readonly OAuthFlowType Code = new OAuthFlowType("code");
        /// <summary>
        /// Constant Implicit for OAuthFlowType
        /// </summary>
        public static readonly OAuthFlowType Implicit = new OAuthFlowType("implicit");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuthFlowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthFlowType FindValue(string value)
        {
            return FindValue<OAuthFlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthFlowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RiskDecisionType.
    /// </summary>
    public class RiskDecisionType : ConstantClass
    {

        /// <summary>
        /// Constant AccountTakeover for RiskDecisionType
        /// </summary>
        public static readonly RiskDecisionType AccountTakeover = new RiskDecisionType("AccountTakeover");
        /// <summary>
        /// Constant Block for RiskDecisionType
        /// </summary>
        public static readonly RiskDecisionType Block = new RiskDecisionType("Block");
        /// <summary>
        /// Constant NoRisk for RiskDecisionType
        /// </summary>
        public static readonly RiskDecisionType NoRisk = new RiskDecisionType("NoRisk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RiskDecisionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RiskDecisionType FindValue(string value)
        {
            return FindValue<RiskDecisionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RiskDecisionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RiskLevelType.
    /// </summary>
    public class RiskLevelType : ConstantClass
    {

        /// <summary>
        /// Constant High for RiskLevelType
        /// </summary>
        public static readonly RiskLevelType High = new RiskLevelType("High");
        /// <summary>
        /// Constant Low for RiskLevelType
        /// </summary>
        public static readonly RiskLevelType Low = new RiskLevelType("Low");
        /// <summary>
        /// Constant Medium for RiskLevelType
        /// </summary>
        public static readonly RiskLevelType Medium = new RiskLevelType("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RiskLevelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RiskLevelType FindValue(string value)
        {
            return FindValue<RiskLevelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RiskLevelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for StatusType
        /// </summary>
        public static readonly StatusType Disabled = new StatusType("Disabled");
        /// <summary>
        /// Constant Enabled for StatusType
        /// </summary>
        public static readonly StatusType Enabled = new StatusType("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserImportJobStatusType.
    /// </summary>
    public class UserImportJobStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Created for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Created = new UserImportJobStatusType("Created");
        /// <summary>
        /// Constant Expired for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Expired = new UserImportJobStatusType("Expired");
        /// <summary>
        /// Constant Failed for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Failed = new UserImportJobStatusType("Failed");
        /// <summary>
        /// Constant InProgress for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType InProgress = new UserImportJobStatusType("InProgress");
        /// <summary>
        /// Constant Pending for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Pending = new UserImportJobStatusType("Pending");
        /// <summary>
        /// Constant Stopped for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Stopped = new UserImportJobStatusType("Stopped");
        /// <summary>
        /// Constant Stopping for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Stopping = new UserImportJobStatusType("Stopping");
        /// <summary>
        /// Constant Succeeded for UserImportJobStatusType
        /// </summary>
        public static readonly UserImportJobStatusType Succeeded = new UserImportJobStatusType("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserImportJobStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserImportJobStatusType FindValue(string value)
        {
            return FindValue<UserImportJobStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserImportJobStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsernameAttributeType.
    /// </summary>
    public class UsernameAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant Email for UsernameAttributeType
        /// </summary>
        public static readonly UsernameAttributeType Email = new UsernameAttributeType("email");
        /// <summary>
        /// Constant Phone_number for UsernameAttributeType
        /// </summary>
        public static readonly UsernameAttributeType Phone_number = new UsernameAttributeType("phone_number");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsernameAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsernameAttributeType FindValue(string value)
        {
            return FindValue<UsernameAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsernameAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserPoolMfaType.
    /// </summary>
    public class UserPoolMfaType : ConstantClass
    {

        /// <summary>
        /// Constant OFF for UserPoolMfaType
        /// </summary>
        public static readonly UserPoolMfaType OFF = new UserPoolMfaType("OFF");
        /// <summary>
        /// Constant ON for UserPoolMfaType
        /// </summary>
        public static readonly UserPoolMfaType ON = new UserPoolMfaType("ON");
        /// <summary>
        /// Constant OPTIONAL for UserPoolMfaType
        /// </summary>
        public static readonly UserPoolMfaType OPTIONAL = new UserPoolMfaType("OPTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserPoolMfaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserPoolMfaType FindValue(string value)
        {
            return FindValue<UserPoolMfaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserPoolMfaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserStatusType.
    /// </summary>
    public class UserStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for UserStatusType
        /// </summary>
        public static readonly UserStatusType ARCHIVED = new UserStatusType("ARCHIVED");
        /// <summary>
        /// Constant COMPROMISED for UserStatusType
        /// </summary>
        public static readonly UserStatusType COMPROMISED = new UserStatusType("COMPROMISED");
        /// <summary>
        /// Constant CONFIRMED for UserStatusType
        /// </summary>
        public static readonly UserStatusType CONFIRMED = new UserStatusType("CONFIRMED");
        /// <summary>
        /// Constant FORCE_CHANGE_PASSWORD for UserStatusType
        /// </summary>
        public static readonly UserStatusType FORCE_CHANGE_PASSWORD = new UserStatusType("FORCE_CHANGE_PASSWORD");
        /// <summary>
        /// Constant RESET_REQUIRED for UserStatusType
        /// </summary>
        public static readonly UserStatusType RESET_REQUIRED = new UserStatusType("RESET_REQUIRED");
        /// <summary>
        /// Constant UNCONFIRMED for UserStatusType
        /// </summary>
        public static readonly UserStatusType UNCONFIRMED = new UserStatusType("UNCONFIRMED");
        /// <summary>
        /// Constant UNKNOWN for UserStatusType
        /// </summary>
        public static readonly UserStatusType UNKNOWN = new UserStatusType("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserStatusType FindValue(string value)
        {
            return FindValue<UserStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerifiedAttributeType.
    /// </summary>
    public class VerifiedAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant Email for VerifiedAttributeType
        /// </summary>
        public static readonly VerifiedAttributeType Email = new VerifiedAttributeType("email");
        /// <summary>
        /// Constant Phone_number for VerifiedAttributeType
        /// </summary>
        public static readonly VerifiedAttributeType Phone_number = new VerifiedAttributeType("phone_number");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerifiedAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerifiedAttributeType FindValue(string value)
        {
            return FindValue<VerifiedAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerifiedAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerifySoftwareTokenResponseType.
    /// </summary>
    public class VerifySoftwareTokenResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for VerifySoftwareTokenResponseType
        /// </summary>
        public static readonly VerifySoftwareTokenResponseType ERROR = new VerifySoftwareTokenResponseType("ERROR");
        /// <summary>
        /// Constant SUCCESS for VerifySoftwareTokenResponseType
        /// </summary>
        public static readonly VerifySoftwareTokenResponseType SUCCESS = new VerifySoftwareTokenResponseType("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerifySoftwareTokenResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerifySoftwareTokenResponseType FindValue(string value)
        {
            return FindValue<VerifySoftwareTokenResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerifySoftwareTokenResponseType(string value)
        {
            return FindValue(value);
        }
    }

}
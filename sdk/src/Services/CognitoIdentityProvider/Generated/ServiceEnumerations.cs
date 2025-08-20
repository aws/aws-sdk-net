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
    /// Constants used for properties of type AdvancedSecurityEnabledModeType.
    /// </summary>
    public class AdvancedSecurityEnabledModeType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIT for AdvancedSecurityEnabledModeType
        /// </summary>
        public static readonly AdvancedSecurityEnabledModeType AUDIT = new AdvancedSecurityEnabledModeType("AUDIT");
        /// <summary>
        /// Constant ENFORCED for AdvancedSecurityEnabledModeType
        /// </summary>
        public static readonly AdvancedSecurityEnabledModeType ENFORCED = new AdvancedSecurityEnabledModeType("ENFORCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdvancedSecurityEnabledModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdvancedSecurityEnabledModeType FindValue(string value)
        {
            return FindValue<AdvancedSecurityEnabledModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdvancedSecurityEnabledModeType(string value)
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
    /// Constants used for properties of type AssetCategoryType.
    /// </summary>
    public class AssetCategoryType : ConstantClass
    {

        /// <summary>
        /// Constant AUTH_APP_GRAPHIC for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType AUTH_APP_GRAPHIC = new AssetCategoryType("AUTH_APP_GRAPHIC");
        /// <summary>
        /// Constant EMAIL_GRAPHIC for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType EMAIL_GRAPHIC = new AssetCategoryType("EMAIL_GRAPHIC");
        /// <summary>
        /// Constant FAVICON_ICO for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType FAVICON_ICO = new AssetCategoryType("FAVICON_ICO");
        /// <summary>
        /// Constant FAVICON_SVG for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType FAVICON_SVG = new AssetCategoryType("FAVICON_SVG");
        /// <summary>
        /// Constant FORM_BACKGROUND for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType FORM_BACKGROUND = new AssetCategoryType("FORM_BACKGROUND");
        /// <summary>
        /// Constant FORM_LOGO for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType FORM_LOGO = new AssetCategoryType("FORM_LOGO");
        /// <summary>
        /// Constant IDP_BUTTON_ICON for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType IDP_BUTTON_ICON = new AssetCategoryType("IDP_BUTTON_ICON");
        /// <summary>
        /// Constant PAGE_BACKGROUND for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PAGE_BACKGROUND = new AssetCategoryType("PAGE_BACKGROUND");
        /// <summary>
        /// Constant PAGE_FOOTER_BACKGROUND for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PAGE_FOOTER_BACKGROUND = new AssetCategoryType("PAGE_FOOTER_BACKGROUND");
        /// <summary>
        /// Constant PAGE_FOOTER_LOGO for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PAGE_FOOTER_LOGO = new AssetCategoryType("PAGE_FOOTER_LOGO");
        /// <summary>
        /// Constant PAGE_HEADER_BACKGROUND for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PAGE_HEADER_BACKGROUND = new AssetCategoryType("PAGE_HEADER_BACKGROUND");
        /// <summary>
        /// Constant PAGE_HEADER_LOGO for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PAGE_HEADER_LOGO = new AssetCategoryType("PAGE_HEADER_LOGO");
        /// <summary>
        /// Constant PASSKEY_GRAPHIC for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PASSKEY_GRAPHIC = new AssetCategoryType("PASSKEY_GRAPHIC");
        /// <summary>
        /// Constant PASSWORD_GRAPHIC for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType PASSWORD_GRAPHIC = new AssetCategoryType("PASSWORD_GRAPHIC");
        /// <summary>
        /// Constant SMS_GRAPHIC for AssetCategoryType
        /// </summary>
        public static readonly AssetCategoryType SMS_GRAPHIC = new AssetCategoryType("SMS_GRAPHIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetCategoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetCategoryType FindValue(string value)
        {
            return FindValue<AssetCategoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetCategoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetExtensionType.
    /// </summary>
    public class AssetExtensionType : ConstantClass
    {

        /// <summary>
        /// Constant ICO for AssetExtensionType
        /// </summary>
        public static readonly AssetExtensionType ICO = new AssetExtensionType("ICO");
        /// <summary>
        /// Constant JPEG for AssetExtensionType
        /// </summary>
        public static readonly AssetExtensionType JPEG = new AssetExtensionType("JPEG");
        /// <summary>
        /// Constant PNG for AssetExtensionType
        /// </summary>
        public static readonly AssetExtensionType PNG = new AssetExtensionType("PNG");
        /// <summary>
        /// Constant SVG for AssetExtensionType
        /// </summary>
        public static readonly AssetExtensionType SVG = new AssetExtensionType("SVG");
        /// <summary>
        /// Constant WEBP for AssetExtensionType
        /// </summary>
        public static readonly AssetExtensionType WEBP = new AssetExtensionType("WEBP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetExtensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetExtensionType FindValue(string value)
        {
            return FindValue<AssetExtensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetExtensionType(string value)
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
    /// Constants used for properties of type AuthFactorType.
    /// </summary>
    public class AuthFactorType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL_OTP for AuthFactorType
        /// </summary>
        public static readonly AuthFactorType EMAIL_OTP = new AuthFactorType("EMAIL_OTP");
        /// <summary>
        /// Constant PASSWORD for AuthFactorType
        /// </summary>
        public static readonly AuthFactorType PASSWORD = new AuthFactorType("PASSWORD");
        /// <summary>
        /// Constant SMS_OTP for AuthFactorType
        /// </summary>
        public static readonly AuthFactorType SMS_OTP = new AuthFactorType("SMS_OTP");
        /// <summary>
        /// Constant WEB_AUTHN for AuthFactorType
        /// </summary>
        public static readonly AuthFactorType WEB_AUTHN = new AuthFactorType("WEB_AUTHN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthFactorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthFactorType FindValue(string value)
        {
            return FindValue<AuthFactorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthFactorType(string value)
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
        /// Constant ADMIN_USER_PASSWORD_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType ADMIN_USER_PASSWORD_AUTH = new AuthFlowType("ADMIN_USER_PASSWORD_AUTH");
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
        /// Constant USER_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType USER_AUTH = new AuthFlowType("USER_AUTH");
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
        /// Constant EMAIL_OTP for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType EMAIL_OTP = new ChallengeNameType("EMAIL_OTP");
        /// <summary>
        /// Constant MFA_SETUP for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType MFA_SETUP = new ChallengeNameType("MFA_SETUP");
        /// <summary>
        /// Constant NEW_PASSWORD_REQUIRED for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType NEW_PASSWORD_REQUIRED = new ChallengeNameType("NEW_PASSWORD_REQUIRED");
        /// <summary>
        /// Constant PASSWORD for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType PASSWORD = new ChallengeNameType("PASSWORD");
        /// <summary>
        /// Constant PASSWORD_SRP for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType PASSWORD_SRP = new ChallengeNameType("PASSWORD_SRP");
        /// <summary>
        /// Constant PASSWORD_VERIFIER for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType PASSWORD_VERIFIER = new ChallengeNameType("PASSWORD_VERIFIER");
        /// <summary>
        /// Constant SELECT_CHALLENGE for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SELECT_CHALLENGE = new ChallengeNameType("SELECT_CHALLENGE");
        /// <summary>
        /// Constant SELECT_MFA_TYPE for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SELECT_MFA_TYPE = new ChallengeNameType("SELECT_MFA_TYPE");
        /// <summary>
        /// Constant SMS_MFA for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SMS_MFA = new ChallengeNameType("SMS_MFA");
        /// <summary>
        /// Constant SMS_OTP for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SMS_OTP = new ChallengeNameType("SMS_OTP");
        /// <summary>
        /// Constant SOFTWARE_TOKEN_MFA for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SOFTWARE_TOKEN_MFA = new ChallengeNameType("SOFTWARE_TOKEN_MFA");
        /// <summary>
        /// Constant WEB_AUTHN for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType WEB_AUTHN = new ChallengeNameType("WEB_AUTHN");

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
    /// Constants used for properties of type ColorSchemeModeType.
    /// </summary>
    public class ColorSchemeModeType : ConstantClass
    {

        /// <summary>
        /// Constant DARK for ColorSchemeModeType
        /// </summary>
        public static readonly ColorSchemeModeType DARK = new ColorSchemeModeType("DARK");
        /// <summary>
        /// Constant DYNAMIC for ColorSchemeModeType
        /// </summary>
        public static readonly ColorSchemeModeType DYNAMIC = new ColorSchemeModeType("DYNAMIC");
        /// <summary>
        /// Constant LIGHT for ColorSchemeModeType
        /// </summary>
        public static readonly ColorSchemeModeType LIGHT = new ColorSchemeModeType("LIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColorSchemeModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorSchemeModeType FindValue(string value)
        {
            return FindValue<ColorSchemeModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorSchemeModeType(string value)
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
    /// Constants used for properties of type CustomEmailSenderLambdaVersionType.
    /// </summary>
    public class CustomEmailSenderLambdaVersionType : ConstantClass
    {

        /// <summary>
        /// Constant V1_0 for CustomEmailSenderLambdaVersionType
        /// </summary>
        public static readonly CustomEmailSenderLambdaVersionType V1_0 = new CustomEmailSenderLambdaVersionType("V1_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomEmailSenderLambdaVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomEmailSenderLambdaVersionType FindValue(string value)
        {
            return FindValue<CustomEmailSenderLambdaVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomEmailSenderLambdaVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomSMSSenderLambdaVersionType.
    /// </summary>
    public class CustomSMSSenderLambdaVersionType : ConstantClass
    {

        /// <summary>
        /// Constant V1_0 for CustomSMSSenderLambdaVersionType
        /// </summary>
        public static readonly CustomSMSSenderLambdaVersionType V1_0 = new CustomSMSSenderLambdaVersionType("V1_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomSMSSenderLambdaVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomSMSSenderLambdaVersionType FindValue(string value)
        {
            return FindValue<CustomSMSSenderLambdaVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomSMSSenderLambdaVersionType(string value)
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
    /// Constants used for properties of type DeletionProtectionType.
    /// </summary>
    public class DeletionProtectionType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DeletionProtectionType
        /// </summary>
        public static readonly DeletionProtectionType ACTIVE = new DeletionProtectionType("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for DeletionProtectionType
        /// </summary>
        public static readonly DeletionProtectionType INACTIVE = new DeletionProtectionType("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionProtectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionProtectionType FindValue(string value)
        {
            return FindValue<DeletionProtectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionProtectionType(string value)
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
    /// Constants used for properties of type EmailSendingAccountType.
    /// </summary>
    public class EmailSendingAccountType : ConstantClass
    {

        /// <summary>
        /// Constant COGNITO_DEFAULT for EmailSendingAccountType
        /// </summary>
        public static readonly EmailSendingAccountType COGNITO_DEFAULT = new EmailSendingAccountType("COGNITO_DEFAULT");
        /// <summary>
        /// Constant DEVELOPER for EmailSendingAccountType
        /// </summary>
        public static readonly EmailSendingAccountType DEVELOPER = new EmailSendingAccountType("DEVELOPER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmailSendingAccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmailSendingAccountType FindValue(string value)
        {
            return FindValue<EmailSendingAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmailSendingAccountType(string value)
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
        /// Constant Fail for EventResponseType
        /// </summary>
        public static readonly EventResponseType Fail = new EventResponseType("Fail");
        /// <summary>
        /// Constant InProgress for EventResponseType
        /// </summary>
        public static readonly EventResponseType InProgress = new EventResponseType("InProgress");
        /// <summary>
        /// Constant Pass for EventResponseType
        /// </summary>
        public static readonly EventResponseType Pass = new EventResponseType("Pass");

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
    /// Constants used for properties of type EventSourceName.
    /// </summary>
    public class EventSourceName : ConstantClass
    {

        /// <summary>
        /// Constant UserAuthEvents for EventSourceName
        /// </summary>
        public static readonly EventSourceName UserAuthEvents = new EventSourceName("userAuthEvents");
        /// <summary>
        /// Constant UserNotification for EventSourceName
        /// </summary>
        public static readonly EventSourceName UserNotification = new EventSourceName("userNotification");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceName FindValue(string value)
        {
            return FindValue<EventSourceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceName(string value)
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
        /// Constant PasswordChange for EventType
        /// </summary>
        public static readonly EventType PasswordChange = new EventType("PasswordChange");
        /// <summary>
        /// Constant ResendCode for EventType
        /// </summary>
        public static readonly EventType ResendCode = new EventType("ResendCode");
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
        /// Constant ALLOW_ADMIN_USER_PASSWORD_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_ADMIN_USER_PASSWORD_AUTH = new ExplicitAuthFlowsType("ALLOW_ADMIN_USER_PASSWORD_AUTH");
        /// <summary>
        /// Constant ALLOW_CUSTOM_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_CUSTOM_AUTH = new ExplicitAuthFlowsType("ALLOW_CUSTOM_AUTH");
        /// <summary>
        /// Constant ALLOW_REFRESH_TOKEN_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_REFRESH_TOKEN_AUTH = new ExplicitAuthFlowsType("ALLOW_REFRESH_TOKEN_AUTH");
        /// <summary>
        /// Constant ALLOW_USER_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_USER_AUTH = new ExplicitAuthFlowsType("ALLOW_USER_AUTH");
        /// <summary>
        /// Constant ALLOW_USER_PASSWORD_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_USER_PASSWORD_AUTH = new ExplicitAuthFlowsType("ALLOW_USER_PASSWORD_AUTH");
        /// <summary>
        /// Constant ALLOW_USER_SRP_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ALLOW_USER_SRP_AUTH = new ExplicitAuthFlowsType("ALLOW_USER_SRP_AUTH");
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
    /// Constants used for properties of type FeatureType.
    /// </summary>
    public class FeatureType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureType
        /// </summary>
        public static readonly FeatureType DISABLED = new FeatureType("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureType
        /// </summary>
        public static readonly FeatureType ENABLED = new FeatureType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureType FindValue(string value)
        {
            return FindValue<FeatureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureType(string value)
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
        /// Constant SignInWithApple for IdentityProviderTypeType
        /// </summary>
        public static readonly IdentityProviderTypeType SignInWithApple = new IdentityProviderTypeType("SignInWithApple");

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
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
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
    /// Constants used for properties of type PreTokenGenerationLambdaVersionType.
    /// </summary>
    public class PreTokenGenerationLambdaVersionType : ConstantClass
    {

        /// <summary>
        /// Constant V1_0 for PreTokenGenerationLambdaVersionType
        /// </summary>
        public static readonly PreTokenGenerationLambdaVersionType V1_0 = new PreTokenGenerationLambdaVersionType("V1_0");
        /// <summary>
        /// Constant V2_0 for PreTokenGenerationLambdaVersionType
        /// </summary>
        public static readonly PreTokenGenerationLambdaVersionType V2_0 = new PreTokenGenerationLambdaVersionType("V2_0");
        /// <summary>
        /// Constant V3_0 for PreTokenGenerationLambdaVersionType
        /// </summary>
        public static readonly PreTokenGenerationLambdaVersionType V3_0 = new PreTokenGenerationLambdaVersionType("V3_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreTokenGenerationLambdaVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreTokenGenerationLambdaVersionType FindValue(string value)
        {
            return FindValue<PreTokenGenerationLambdaVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreTokenGenerationLambdaVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreventUserExistenceErrorTypes.
    /// </summary>
    public class PreventUserExistenceErrorTypes : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for PreventUserExistenceErrorTypes
        /// </summary>
        public static readonly PreventUserExistenceErrorTypes ENABLED = new PreventUserExistenceErrorTypes("ENABLED");
        /// <summary>
        /// Constant LEGACY for PreventUserExistenceErrorTypes
        /// </summary>
        public static readonly PreventUserExistenceErrorTypes LEGACY = new PreventUserExistenceErrorTypes("LEGACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreventUserExistenceErrorTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreventUserExistenceErrorTypes FindValue(string value)
        {
            return FindValue<PreventUserExistenceErrorTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreventUserExistenceErrorTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryOptionNameType.
    /// </summary>
    public class RecoveryOptionNameType : ConstantClass
    {

        /// <summary>
        /// Constant Admin_only for RecoveryOptionNameType
        /// </summary>
        public static readonly RecoveryOptionNameType Admin_only = new RecoveryOptionNameType("admin_only");
        /// <summary>
        /// Constant Verified_email for RecoveryOptionNameType
        /// </summary>
        public static readonly RecoveryOptionNameType Verified_email = new RecoveryOptionNameType("verified_email");
        /// <summary>
        /// Constant Verified_phone_number for RecoveryOptionNameType
        /// </summary>
        public static readonly RecoveryOptionNameType Verified_phone_number = new RecoveryOptionNameType("verified_phone_number");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryOptionNameType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryOptionNameType FindValue(string value)
        {
            return FindValue<RecoveryOptionNameType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryOptionNameType(string value)
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
    /// Constants used for properties of type TermsEnforcementType.
    /// </summary>
    public class TermsEnforcementType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for TermsEnforcementType
        /// </summary>
        public static readonly TermsEnforcementType NONE = new TermsEnforcementType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermsEnforcementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermsEnforcementType FindValue(string value)
        {
            return FindValue<TermsEnforcementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermsEnforcementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TermsSourceType.
    /// </summary>
    public class TermsSourceType : ConstantClass
    {

        /// <summary>
        /// Constant LINK for TermsSourceType
        /// </summary>
        public static readonly TermsSourceType LINK = new TermsSourceType("LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermsSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermsSourceType FindValue(string value)
        {
            return FindValue<TermsSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermsSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnitsType.
    /// </summary>
    public class TimeUnitsType : ConstantClass
    {

        /// <summary>
        /// Constant Days for TimeUnitsType
        /// </summary>
        public static readonly TimeUnitsType Days = new TimeUnitsType("days");
        /// <summary>
        /// Constant Hours for TimeUnitsType
        /// </summary>
        public static readonly TimeUnitsType Hours = new TimeUnitsType("hours");
        /// <summary>
        /// Constant Minutes for TimeUnitsType
        /// </summary>
        public static readonly TimeUnitsType Minutes = new TimeUnitsType("minutes");
        /// <summary>
        /// Constant Seconds for TimeUnitsType
        /// </summary>
        public static readonly TimeUnitsType Seconds = new TimeUnitsType("seconds");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnitsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnitsType FindValue(string value)
        {
            return FindValue<TimeUnitsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnitsType(string value)
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
    /// Constants used for properties of type UserPoolTierType.
    /// </summary>
    public class UserPoolTierType : ConstantClass
    {

        /// <summary>
        /// Constant ESSENTIALS for UserPoolTierType
        /// </summary>
        public static readonly UserPoolTierType ESSENTIALS = new UserPoolTierType("ESSENTIALS");
        /// <summary>
        /// Constant LITE for UserPoolTierType
        /// </summary>
        public static readonly UserPoolTierType LITE = new UserPoolTierType("LITE");
        /// <summary>
        /// Constant PLUS for UserPoolTierType
        /// </summary>
        public static readonly UserPoolTierType PLUS = new UserPoolTierType("PLUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserPoolTierType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserPoolTierType FindValue(string value)
        {
            return FindValue<UserPoolTierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserPoolTierType(string value)
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
        /// Constant EXTERNAL_PROVIDER for UserStatusType
        /// </summary>
        public static readonly UserStatusType EXTERNAL_PROVIDER = new UserStatusType("EXTERNAL_PROVIDER");
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
    /// Constants used for properties of type UserVerificationType.
    /// </summary>
    public class UserVerificationType : ConstantClass
    {

        /// <summary>
        /// Constant Preferred for UserVerificationType
        /// </summary>
        public static readonly UserVerificationType Preferred = new UserVerificationType("preferred");
        /// <summary>
        /// Constant Required for UserVerificationType
        /// </summary>
        public static readonly UserVerificationType Required = new UserVerificationType("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserVerificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserVerificationType FindValue(string value)
        {
            return FindValue<UserVerificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserVerificationType(string value)
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
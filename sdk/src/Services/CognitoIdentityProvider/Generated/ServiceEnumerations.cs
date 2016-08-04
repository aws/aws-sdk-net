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
        /// Constant REFRESH_TOKEN_AUTH for AuthFlowType
        /// </summary>
        public static readonly AuthFlowType REFRESH_TOKEN_AUTH = new AuthFlowType("REFRESH_TOKEN_AUTH");
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
        /// Constant PASSWORD_VERIFIER for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType PASSWORD_VERIFIER = new ChallengeNameType("PASSWORD_VERIFIER");
        /// <summary>
        /// Constant SMS_MFA for ChallengeNameType
        /// </summary>
        public static readonly ChallengeNameType SMS_MFA = new ChallengeNameType("SMS_MFA");

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
    /// Constants used for properties of type ExplicitAuthFlowsType.
    /// </summary>
    public class ExplicitAuthFlowsType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_NO_SRP_AUTH for ExplicitAuthFlowsType
        /// </summary>
        public static readonly ExplicitAuthFlowsType ADMIN_NO_SRP_AUTH = new ExplicitAuthFlowsType("ADMIN_NO_SRP_AUTH");

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

}
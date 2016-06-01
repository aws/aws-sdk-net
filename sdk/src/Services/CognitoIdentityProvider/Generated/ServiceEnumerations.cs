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
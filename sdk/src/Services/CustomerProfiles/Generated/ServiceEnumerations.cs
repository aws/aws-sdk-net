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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CustomerProfiles
{

    /// <summary>
    /// Constants used for properties of type FieldContentType.
    /// </summary>
    public class FieldContentType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL_ADDRESS for FieldContentType
        /// </summary>
        public static readonly FieldContentType EMAIL_ADDRESS = new FieldContentType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant NAME for FieldContentType
        /// </summary>
        public static readonly FieldContentType NAME = new FieldContentType("NAME");
        /// <summary>
        /// Constant NUMBER for FieldContentType
        /// </summary>
        public static readonly FieldContentType NUMBER = new FieldContentType("NUMBER");
        /// <summary>
        /// Constant PHONE_NUMBER for FieldContentType
        /// </summary>
        public static readonly FieldContentType PHONE_NUMBER = new FieldContentType("PHONE_NUMBER");
        /// <summary>
        /// Constant STRING for FieldContentType
        /// </summary>
        public static readonly FieldContentType STRING = new FieldContentType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldContentType FindValue(string value)
        {
            return FindValue<FieldContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Gender.
    /// </summary>
    public class Gender : ConstantClass
    {

        /// <summary>
        /// Constant FEMALE for Gender
        /// </summary>
        public static readonly Gender FEMALE = new Gender("FEMALE");
        /// <summary>
        /// Constant MALE for Gender
        /// </summary>
        public static readonly Gender MALE = new Gender("MALE");
        /// <summary>
        /// Constant UNSPECIFIED for Gender
        /// </summary>
        public static readonly Gender UNSPECIFIED = new Gender("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Gender(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Gender FindValue(string value)
        {
            return FindValue<Gender>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Gender(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartyType.
    /// </summary>
    public class PartyType : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS for PartyType
        /// </summary>
        public static readonly PartyType BUSINESS = new PartyType("BUSINESS");
        /// <summary>
        /// Constant INDIVIDUAL for PartyType
        /// </summary>
        public static readonly PartyType INDIVIDUAL = new PartyType("INDIVIDUAL");
        /// <summary>
        /// Constant OTHER for PartyType
        /// </summary>
        public static readonly PartyType OTHER = new PartyType("OTHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartyType FindValue(string value)
        {
            return FindValue<PartyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardIdentifier.
    /// </summary>
    public class StandardIdentifier : ConstantClass
    {

        /// <summary>
        /// Constant LOOKUP_ONLY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier LOOKUP_ONLY = new StandardIdentifier("LOOKUP_ONLY");
        /// <summary>
        /// Constant NEW_ONLY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier NEW_ONLY = new StandardIdentifier("NEW_ONLY");
        /// <summary>
        /// Constant PROFILE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier PROFILE = new StandardIdentifier("PROFILE");
        /// <summary>
        /// Constant SECONDARY for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier SECONDARY = new StandardIdentifier("SECONDARY");
        /// <summary>
        /// Constant UNIQUE for StandardIdentifier
        /// </summary>
        public static readonly StandardIdentifier UNIQUE = new StandardIdentifier("UNIQUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardIdentifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardIdentifier FindValue(string value)
        {
            return FindValue<StandardIdentifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardIdentifier(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleNotificationService
{

    /// <summary>
    /// Constants used for properties of type LanguageCodeString.
    /// </summary>
    public class LanguageCodeString : ConstantClass
    {

        /// <summary>
        /// Constant DeDE for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString DeDE = new LanguageCodeString("de-DE");
        /// <summary>
        /// Constant EnGB for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString EnGB = new LanguageCodeString("en-GB");
        /// <summary>
        /// Constant EnUS for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString EnUS = new LanguageCodeString("en-US");
        /// <summary>
        /// Constant Es419 for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString Es419 = new LanguageCodeString("es-419");
        /// <summary>
        /// Constant EsES for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString EsES = new LanguageCodeString("es-ES");
        /// <summary>
        /// Constant FrCA for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString FrCA = new LanguageCodeString("fr-CA");
        /// <summary>
        /// Constant FrFR for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString FrFR = new LanguageCodeString("fr-FR");
        /// <summary>
        /// Constant ItIT for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString ItIT = new LanguageCodeString("it-IT");
        /// <summary>
        /// Constant JaJP for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString JaJP = new LanguageCodeString("ja-JP");
        /// <summary>
        /// Constant KrKR for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString KrKR = new LanguageCodeString("kr-KR");
        /// <summary>
        /// Constant PtBR for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString PtBR = new LanguageCodeString("pt-BR");
        /// <summary>
        /// Constant ZhCN for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString ZhCN = new LanguageCodeString("zh-CN");
        /// <summary>
        /// Constant ZhTW for LanguageCodeString
        /// </summary>
        public static readonly LanguageCodeString ZhTW = new LanguageCodeString("zh-TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCodeString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCodeString FindValue(string value)
        {
            return FindValue<LanguageCodeString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCodeString(string value)
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
    /// Constants used for properties of type RouteType.
    /// </summary>
    public class RouteType : ConstantClass
    {

        /// <summary>
        /// Constant Premium for RouteType
        /// </summary>
        public static readonly RouteType Premium = new RouteType("Premium");
        /// <summary>
        /// Constant Promotional for RouteType
        /// </summary>
        public static readonly RouteType Promotional = new RouteType("Promotional");
        /// <summary>
        /// Constant Transactional for RouteType
        /// </summary>
        public static readonly RouteType Transactional = new RouteType("Transactional");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteType FindValue(string value)
        {
            return FindValue<RouteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SMSSandboxPhoneNumberVerificationStatus.
    /// </summary>
    public class SMSSandboxPhoneNumberVerificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Pending for SMSSandboxPhoneNumberVerificationStatus
        /// </summary>
        public static readonly SMSSandboxPhoneNumberVerificationStatus Pending = new SMSSandboxPhoneNumberVerificationStatus("Pending");
        /// <summary>
        /// Constant Verified for SMSSandboxPhoneNumberVerificationStatus
        /// </summary>
        public static readonly SMSSandboxPhoneNumberVerificationStatus Verified = new SMSSandboxPhoneNumberVerificationStatus("Verified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SMSSandboxPhoneNumberVerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SMSSandboxPhoneNumberVerificationStatus FindValue(string value)
        {
            return FindValue<SMSSandboxPhoneNumberVerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SMSSandboxPhoneNumberVerificationStatus(string value)
        {
            return FindValue(value);
        }
    }

}
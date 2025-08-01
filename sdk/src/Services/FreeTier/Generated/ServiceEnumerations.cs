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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FreeTier
{

    /// <summary>
    /// Constants used for properties of type AccountPlanStatus.
    /// </summary>
    public class AccountPlanStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AccountPlanStatus
        /// </summary>
        public static readonly AccountPlanStatus ACTIVE = new AccountPlanStatus("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for AccountPlanStatus
        /// </summary>
        public static readonly AccountPlanStatus EXPIRED = new AccountPlanStatus("EXPIRED");
        /// <summary>
        /// Constant NOT_STARTED for AccountPlanStatus
        /// </summary>
        public static readonly AccountPlanStatus NOT_STARTED = new AccountPlanStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountPlanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountPlanStatus FindValue(string value)
        {
            return FindValue<AccountPlanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountPlanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountPlanType.
    /// </summary>
    public class AccountPlanType : ConstantClass
    {

        /// <summary>
        /// Constant FREE for AccountPlanType
        /// </summary>
        public static readonly AccountPlanType FREE = new AccountPlanType("FREE");
        /// <summary>
        /// Constant PAID for AccountPlanType
        /// </summary>
        public static readonly AccountPlanType PAID = new AccountPlanType("PAID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountPlanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountPlanType FindValue(string value)
        {
            return FindValue<AccountPlanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountPlanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivityStatus.
    /// </summary>
    public class ActivityStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus COMPLETED = new ActivityStatus("COMPLETED");
        /// <summary>
        /// Constant EXPIRING for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus EXPIRING = new ActivityStatus("EXPIRING");
        /// <summary>
        /// Constant IN_PROGRESS for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus IN_PROGRESS = new ActivityStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ActivityStatus
        /// </summary>
        public static readonly ActivityStatus NOT_STARTED = new ActivityStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStatus FindValue(string value)
        {
            return FindValue<ActivityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant DESCRIPTION for Dimension
        /// </summary>
        public static readonly Dimension DESCRIPTION = new Dimension("DESCRIPTION");
        /// <summary>
        /// Constant FREE_TIER_TYPE for Dimension
        /// </summary>
        public static readonly Dimension FREE_TIER_TYPE = new Dimension("FREE_TIER_TYPE");
        /// <summary>
        /// Constant OPERATION for Dimension
        /// </summary>
        public static readonly Dimension OPERATION = new Dimension("OPERATION");
        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant SERVICE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE = new Dimension("SERVICE");
        /// <summary>
        /// Constant USAGE_PERCENTAGE for Dimension
        /// </summary>
        public static readonly Dimension USAGE_PERCENTAGE = new Dimension("USAGE_PERCENTAGE");
        /// <summary>
        /// Constant USAGE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE = new Dimension("USAGE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Dimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Dimension FindValue(string value)
        {
            return FindValue<Dimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Dimension(string value)
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
        /// Constant DeDE for LanguageCode
        /// </summary>
        public static readonly LanguageCode DeDE = new LanguageCode("de-DE");
        /// <summary>
        /// Constant EnGB for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnGB = new LanguageCode("en-GB");
        /// <summary>
        /// Constant EnUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnUS = new LanguageCode("en-US");
        /// <summary>
        /// Constant EsES for LanguageCode
        /// </summary>
        public static readonly LanguageCode EsES = new LanguageCode("es-ES");
        /// <summary>
        /// Constant FrFR for LanguageCode
        /// </summary>
        public static readonly LanguageCode FrFR = new LanguageCode("fr-FR");
        /// <summary>
        /// Constant IdID for LanguageCode
        /// </summary>
        public static readonly LanguageCode IdID = new LanguageCode("id-ID");
        /// <summary>
        /// Constant ItIT for LanguageCode
        /// </summary>
        public static readonly LanguageCode ItIT = new LanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for LanguageCode
        /// </summary>
        public static readonly LanguageCode JaJP = new LanguageCode("ja-JP");
        /// <summary>
        /// Constant KoKR for LanguageCode
        /// </summary>
        public static readonly LanguageCode KoKR = new LanguageCode("ko-KR");
        /// <summary>
        /// Constant PtPT for LanguageCode
        /// </summary>
        public static readonly LanguageCode PtPT = new LanguageCode("pt-PT");
        /// <summary>
        /// Constant TrTR for LanguageCode
        /// </summary>
        public static readonly LanguageCode TrTR = new LanguageCode("tr-TR");
        /// <summary>
        /// Constant ZhCN for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhCN = new LanguageCode("zh-CN");
        /// <summary>
        /// Constant ZhTW for LanguageCode
        /// </summary>
        public static readonly LanguageCode ZhTW = new LanguageCode("zh-TW");

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
    /// Constants used for properties of type MatchOption.
    /// </summary>
    public class MatchOption : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for MatchOption
        /// </summary>
        public static readonly MatchOption CONTAINS = new MatchOption("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption ENDS_WITH = new MatchOption("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption EQUALS = new MatchOption("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for MatchOption
        /// </summary>
        public static readonly MatchOption GREATER_THAN_OR_EQUAL = new MatchOption("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant STARTS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption STARTS_WITH = new MatchOption("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchOption FindValue(string value)
        {
            return FindValue<MatchOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchOption(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CostExplorer
{

    /// <summary>
    /// Constants used for properties of type AccountScope.
    /// </summary>
    public class AccountScope : ConstantClass
    {

        /// <summary>
        /// Constant PAYER for AccountScope
        /// </summary>
        public static readonly AccountScope PAYER = new AccountScope("PAYER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountScope FindValue(string value)
        {
            return FindValue<AccountScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Context.
    /// </summary>
    public class Context : ConstantClass
    {

        /// <summary>
        /// Constant COST_AND_USAGE for Context
        /// </summary>
        public static readonly Context COST_AND_USAGE = new Context("COST_AND_USAGE");
        /// <summary>
        /// Constant RESERVATIONS for Context
        /// </summary>
        public static readonly Context RESERVATIONS = new Context("RESERVATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Context(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Context FindValue(string value)
        {
            return FindValue<Context>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Context(string value)
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
        /// Constant AZ for Dimension
        /// </summary>
        public static readonly Dimension AZ = new Dimension("AZ");
        /// <summary>
        /// Constant CACHE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension CACHE_ENGINE = new Dimension("CACHE_ENGINE");
        /// <summary>
        /// Constant DATABASE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension DATABASE_ENGINE = new Dimension("DATABASE_ENGINE");
        /// <summary>
        /// Constant DEPLOYMENT_OPTION for Dimension
        /// </summary>
        public static readonly Dimension DEPLOYMENT_OPTION = new Dimension("DEPLOYMENT_OPTION");
        /// <summary>
        /// Constant INSTANCE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE = new Dimension("INSTANCE_TYPE");
        /// <summary>
        /// Constant INSTANCE_TYPE_FAMILY for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE_FAMILY = new Dimension("INSTANCE_TYPE_FAMILY");
        /// <summary>
        /// Constant LEGAL_ENTITY_NAME for Dimension
        /// </summary>
        public static readonly Dimension LEGAL_ENTITY_NAME = new Dimension("LEGAL_ENTITY_NAME");
        /// <summary>
        /// Constant LINKED_ACCOUNT for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT = new Dimension("LINKED_ACCOUNT");
        /// <summary>
        /// Constant OPERATING_SYSTEM for Dimension
        /// </summary>
        public static readonly Dimension OPERATING_SYSTEM = new Dimension("OPERATING_SYSTEM");
        /// <summary>
        /// Constant OPERATION for Dimension
        /// </summary>
        public static readonly Dimension OPERATION = new Dimension("OPERATION");
        /// <summary>
        /// Constant PLATFORM for Dimension
        /// </summary>
        public static readonly Dimension PLATFORM = new Dimension("PLATFORM");
        /// <summary>
        /// Constant PURCHASE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension PURCHASE_TYPE = new Dimension("PURCHASE_TYPE");
        /// <summary>
        /// Constant RECORD_TYPE for Dimension
        /// </summary>
        public static readonly Dimension RECORD_TYPE = new Dimension("RECORD_TYPE");
        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant SCOPE for Dimension
        /// </summary>
        public static readonly Dimension SCOPE = new Dimension("SCOPE");
        /// <summary>
        /// Constant SERVICE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE = new Dimension("SERVICE");
        /// <summary>
        /// Constant SUBSCRIPTION_ID for Dimension
        /// </summary>
        public static readonly Dimension SUBSCRIPTION_ID = new Dimension("SUBSCRIPTION_ID");
        /// <summary>
        /// Constant TENANCY for Dimension
        /// </summary>
        public static readonly Dimension TENANCY = new Dimension("TENANCY");
        /// <summary>
        /// Constant USAGE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE = new Dimension("USAGE_TYPE");
        /// <summary>
        /// Constant USAGE_TYPE_GROUP for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE_GROUP = new Dimension("USAGE_TYPE_GROUP");

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
    /// Constants used for properties of type Granularity.
    /// </summary>
    public class Granularity : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for Granularity
        /// </summary>
        public static readonly Granularity DAILY = new Granularity("DAILY");
        /// <summary>
        /// Constant MONTHLY for Granularity
        /// </summary>
        public static readonly Granularity MONTHLY = new Granularity("MONTHLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Granularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Granularity FindValue(string value)
        {
            return FindValue<Granularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Granularity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupDefinitionType.
    /// </summary>
    public class GroupDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant DIMENSION for GroupDefinitionType
        /// </summary>
        public static readonly GroupDefinitionType DIMENSION = new GroupDefinitionType("DIMENSION");
        /// <summary>
        /// Constant TAG for GroupDefinitionType
        /// </summary>
        public static readonly GroupDefinitionType TAG = new GroupDefinitionType("TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupDefinitionType FindValue(string value)
        {
            return FindValue<GroupDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LookbackPeriodInDays.
    /// </summary>
    public class LookbackPeriodInDays : ConstantClass
    {

        /// <summary>
        /// Constant SEVEN_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays SEVEN_DAYS = new LookbackPeriodInDays("SEVEN_DAYS");
        /// <summary>
        /// Constant SIXTY_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays SIXTY_DAYS = new LookbackPeriodInDays("SIXTY_DAYS");
        /// <summary>
        /// Constant THIRTY_DAYS for LookbackPeriodInDays
        /// </summary>
        public static readonly LookbackPeriodInDays THIRTY_DAYS = new LookbackPeriodInDays("THIRTY_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LookbackPeriodInDays(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookbackPeriodInDays FindValue(string value)
        {
            return FindValue<LookbackPeriodInDays>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LookbackPeriodInDays(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingClass.
    /// </summary>
    public class OfferingClass : ConstantClass
    {

        /// <summary>
        /// Constant CONVERTIBLE for OfferingClass
        /// </summary>
        public static readonly OfferingClass CONVERTIBLE = new OfferingClass("CONVERTIBLE");
        /// <summary>
        /// Constant STANDARD for OfferingClass
        /// </summary>
        public static readonly OfferingClass STANDARD = new OfferingClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingClass FindValue(string value)
        {
            return FindValue<OfferingClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentOption.
    /// </summary>
    public class PaymentOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption ALL_UPFRONT = new PaymentOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption NO_UPFRONT = new PaymentOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for PaymentOption
        /// </summary>
        public static readonly PaymentOption PARTIAL_UPFRONT = new PaymentOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentOption FindValue(string value)
        {
            return FindValue<PaymentOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TermInYears.
    /// </summary>
    public class TermInYears : ConstantClass
    {

        /// <summary>
        /// Constant ONE_YEAR for TermInYears
        /// </summary>
        public static readonly TermInYears ONE_YEAR = new TermInYears("ONE_YEAR");
        /// <summary>
        /// Constant THREE_YEARS for TermInYears
        /// </summary>
        public static readonly TermInYears THREE_YEARS = new TermInYears("THREE_YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermInYears(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermInYears FindValue(string value)
        {
            return FindValue<TermInYears>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermInYears(string value)
        {
            return FindValue(value);
        }
    }

}
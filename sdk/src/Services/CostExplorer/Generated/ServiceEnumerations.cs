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
        /// Constant INSTANCE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE = new Dimension("INSTANCE_TYPE");
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

}
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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Sustainability
{

    /// <summary>
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant SERVICE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE = new Dimension("SERVICE");
        /// <summary>
        /// Constant USAGE_ACCOUNT_ID for Dimension
        /// </summary>
        public static readonly Dimension USAGE_ACCOUNT_ID = new Dimension("USAGE_ACCOUNT_ID");

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
    /// Constants used for properties of type EmissionsType.
    /// </summary>
    public class EmissionsType : ConstantClass
    {

        /// <summary>
        /// Constant TOTAL_LBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_LBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_LBM_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_MBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_MBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_MBM_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_SCOPE_1_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_SCOPE_1_CARBON_EMISSIONS = new EmissionsType("TOTAL_SCOPE_1_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_SCOPE_2_LBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_SCOPE_2_LBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_SCOPE_2_LBM_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_SCOPE_2_MBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_SCOPE_2_MBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_SCOPE_2_MBM_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_SCOPE_3_LBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_SCOPE_3_LBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_SCOPE_3_LBM_CARBON_EMISSIONS");
        /// <summary>
        /// Constant TOTAL_SCOPE_3_MBM_CARBON_EMISSIONS for EmissionsType
        /// </summary>
        public static readonly EmissionsType TOTAL_SCOPE_3_MBM_CARBON_EMISSIONS = new EmissionsType("TOTAL_SCOPE_3_MBM_CARBON_EMISSIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmissionsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmissionsType FindValue(string value)
        {
            return FindValue<EmissionsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmissionsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmissionsUnit.
    /// </summary>
    public class EmissionsUnit : ConstantClass
    {

        /// <summary>
        /// Constant MTCO2e for EmissionsUnit
        /// </summary>
        public static readonly EmissionsUnit MTCO2e = new EmissionsUnit("MTCO2e");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmissionsUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmissionsUnit FindValue(string value)
        {
            return FindValue<EmissionsUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmissionsUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeGranularity.
    /// </summary>
    public class TimeGranularity : ConstantClass
    {

        /// <summary>
        /// Constant MONTHLY for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity MONTHLY = new TimeGranularity("MONTHLY");
        /// <summary>
        /// Constant QUARTERLY_CALENDAR for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity QUARTERLY_CALENDAR = new TimeGranularity("QUARTERLY_CALENDAR");
        /// <summary>
        /// Constant QUARTERLY_FISCAL for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity QUARTERLY_FISCAL = new TimeGranularity("QUARTERLY_FISCAL");
        /// <summary>
        /// Constant YEARLY_CALENDAR for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity YEARLY_CALENDAR = new TimeGranularity("YEARLY_CALENDAR");
        /// <summary>
        /// Constant YEARLY_FISCAL for TimeGranularity
        /// </summary>
        public static readonly TimeGranularity YEARLY_FISCAL = new TimeGranularity("YEARLY_FISCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeGranularity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeGranularity FindValue(string value)
        {
            return FindValue<TimeGranularity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeGranularity(string value)
        {
            return FindValue(value);
        }
    }

}
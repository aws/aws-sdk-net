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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Constructs a custom Dimension for a value not among the defined constants.
        /// </summary>
        public Dimension(string value) : base(value) { }

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
        /// Constructs a custom EmissionsType for a value not among the defined constants.
        /// </summary>
        public EmissionsType(string value) : base(value) { }

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
        /// Constructs a custom EmissionsUnit for a value not among the defined constants.
        /// </summary>
        public EmissionsUnit(string value) : base(value) { }

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
        /// Constructs a custom TimeGranularity for a value not among the defined constants.
        /// </summary>
        public TimeGranularity(string value) : base(value) { }

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

    /// <summary>
    /// Constants used for properties of type WaterAllocationType.
    /// </summary>
    public class WaterAllocationType : ConstantClass
    {
        /// <summary>
        /// Constant TOTAL_WATER_WITHDRAWALS for WaterAllocationType
        /// </summary>
        public static readonly WaterAllocationType TOTAL_WATER_WITHDRAWALS = new WaterAllocationType("TOTAL_WATER_WITHDRAWALS");

        /// <summary>
        /// Constructs a custom WaterAllocationType for a value not among the defined constants.
        /// </summary>
        public WaterAllocationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaterAllocationType FindValue(string value)
        {
            return FindValue<WaterAllocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaterAllocationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type WaterAllocationUnit.
    /// </summary>
    public class WaterAllocationUnit : ConstantClass
    {
        /// <summary>
        /// Constant M3 for WaterAllocationUnit
        /// </summary>
        public static readonly WaterAllocationUnit M3 = new WaterAllocationUnit("m3");

        /// <summary>
        /// Constructs a custom WaterAllocationUnit for a value not among the defined constants.
        /// </summary>
        public WaterAllocationUnit(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WaterAllocationUnit FindValue(string value)
        {
            return FindValue<WaterAllocationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WaterAllocationUnit(string value)
        {
            return FindValue(value);
        }
    }
}

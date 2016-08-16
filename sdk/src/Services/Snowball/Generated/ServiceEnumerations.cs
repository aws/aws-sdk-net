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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Snowball
{

    /// <summary>
    /// Constants used for properties of type JobState.
    /// </summary>
    public class JobState : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for JobState
        /// </summary>
        public static readonly JobState Cancelled = new JobState("Cancelled");
        /// <summary>
        /// Constant Complete for JobState
        /// </summary>
        public static readonly JobState Complete = new JobState("Complete");
        /// <summary>
        /// Constant InProgress for JobState
        /// </summary>
        public static readonly JobState InProgress = new JobState("InProgress");
        /// <summary>
        /// Constant InTransitToAWS for JobState
        /// </summary>
        public static readonly JobState InTransitToAWS = new JobState("InTransitToAWS");
        /// <summary>
        /// Constant InTransitToCustomer for JobState
        /// </summary>
        public static readonly JobState InTransitToCustomer = new JobState("InTransitToCustomer");
        /// <summary>
        /// Constant Listing for JobState
        /// </summary>
        public static readonly JobState Listing = new JobState("Listing");
        /// <summary>
        /// Constant New for JobState
        /// </summary>
        public static readonly JobState New = new JobState("New");
        /// <summary>
        /// Constant Pending for JobState
        /// </summary>
        public static readonly JobState Pending = new JobState("Pending");
        /// <summary>
        /// Constant PreparingAppliance for JobState
        /// </summary>
        public static readonly JobState PreparingAppliance = new JobState("PreparingAppliance");
        /// <summary>
        /// Constant PreparingShipment for JobState
        /// </summary>
        public static readonly JobState PreparingShipment = new JobState("PreparingShipment");
        /// <summary>
        /// Constant WithAWS for JobState
        /// </summary>
        public static readonly JobState WithAWS = new JobState("WithAWS");
        /// <summary>
        /// Constant WithCustomer for JobState
        /// </summary>
        public static readonly JobState WithCustomer = new JobState("WithCustomer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobState FindValue(string value)
        {
            return FindValue<JobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant EXPORT for JobType
        /// </summary>
        public static readonly JobType EXPORT = new JobType("EXPORT");
        /// <summary>
        /// Constant IMPORT for JobType
        /// </summary>
        public static readonly JobType IMPORT = new JobType("IMPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShippingOption.
    /// </summary>
    public class ShippingOption : ConstantClass
    {

        /// <summary>
        /// Constant EXPRESS for ShippingOption
        /// </summary>
        public static readonly ShippingOption EXPRESS = new ShippingOption("EXPRESS");
        /// <summary>
        /// Constant NEXT_DAY for ShippingOption
        /// </summary>
        public static readonly ShippingOption NEXT_DAY = new ShippingOption("NEXT_DAY");
        /// <summary>
        /// Constant SECOND_DAY for ShippingOption
        /// </summary>
        public static readonly ShippingOption SECOND_DAY = new ShippingOption("SECOND_DAY");
        /// <summary>
        /// Constant STANDARD for ShippingOption
        /// </summary>
        public static readonly ShippingOption STANDARD = new ShippingOption("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShippingOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShippingOption FindValue(string value)
        {
            return FindValue<ShippingOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShippingOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnowballCapacity.
    /// </summary>
    public class SnowballCapacity : ConstantClass
    {

        /// <summary>
        /// Constant NoPreference for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity NoPreference = new SnowballCapacity("NoPreference");
        /// <summary>
        /// Constant T50 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T50 = new SnowballCapacity("T50");
        /// <summary>
        /// Constant T80 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T80 = new SnowballCapacity("T80");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnowballCapacity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnowballCapacity FindValue(string value)
        {
            return FindValue<SnowballCapacity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnowballCapacity(string value)
        {
            return FindValue(value);
        }
    }

}
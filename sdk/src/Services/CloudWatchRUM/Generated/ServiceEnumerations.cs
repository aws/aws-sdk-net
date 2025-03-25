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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchRUM
{

    /// <summary>
    /// Constants used for properties of type CustomEventsStatus.
    /// </summary>
    public class CustomEventsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CustomEventsStatus
        /// </summary>
        public static readonly CustomEventsStatus DISABLED = new CustomEventsStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for CustomEventsStatus
        /// </summary>
        public static readonly CustomEventsStatus ENABLED = new CustomEventsStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomEventsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomEventsStatus FindValue(string value)
        {
            return FindValue<CustomEventsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomEventsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeobfuscationStatus.
    /// </summary>
    public class DeobfuscationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DeobfuscationStatus
        /// </summary>
        public static readonly DeobfuscationStatus DISABLED = new DeobfuscationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DeobfuscationStatus
        /// </summary>
        public static readonly DeobfuscationStatus ENABLED = new DeobfuscationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeobfuscationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeobfuscationStatus FindValue(string value)
        {
            return FindValue<DeobfuscationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeobfuscationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricDestination.
    /// </summary>
    public class MetricDestination : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatch for MetricDestination
        /// </summary>
        public static readonly MetricDestination CloudWatch = new MetricDestination("CloudWatch");
        /// <summary>
        /// Constant Evidently for MetricDestination
        /// </summary>
        public static readonly MetricDestination Evidently = new MetricDestination("Evidently");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricDestination FindValue(string value)
        {
            return FindValue<MetricDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StateEnum.
    /// </summary>
    public class StateEnum : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StateEnum
        /// </summary>
        public static readonly StateEnum ACTIVE = new StateEnum("ACTIVE");
        /// <summary>
        /// Constant CREATED for StateEnum
        /// </summary>
        public static readonly StateEnum CREATED = new StateEnum("CREATED");
        /// <summary>
        /// Constant DELETING for StateEnum
        /// </summary>
        public static readonly StateEnum DELETING = new StateEnum("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateEnum FindValue(string value)
        {
            return FindValue<StateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Telemetry.
    /// </summary>
    public class Telemetry : ConstantClass
    {

        /// <summary>
        /// Constant Errors for Telemetry
        /// </summary>
        public static readonly Telemetry Errors = new Telemetry("errors");
        /// <summary>
        /// Constant Http for Telemetry
        /// </summary>
        public static readonly Telemetry Http = new Telemetry("http");
        /// <summary>
        /// Constant Performance for Telemetry
        /// </summary>
        public static readonly Telemetry Performance = new Telemetry("performance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Telemetry(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Telemetry FindValue(string value)
        {
            return FindValue<Telemetry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Telemetry(string value)
        {
            return FindValue(value);
        }
    }

}
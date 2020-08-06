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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Braket
{

    /// <summary>
    /// Constants used for properties of type CancellationStatus.
    /// </summary>
    public class CancellationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for CancellationStatus
        /// </summary>
        public static readonly CancellationStatus CANCELLED = new CancellationStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for CancellationStatus
        /// </summary>
        public static readonly CancellationStatus CANCELLING = new CancellationStatus("CANCELLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CancellationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancellationStatus FindValue(string value)
        {
            return FindValue<CancellationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CancellationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceStatus.
    /// </summary>
    public class DeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus OFFLINE = new DeviceStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus ONLINE = new DeviceStatus("ONLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceStatus FindValue(string value)
        {
            return FindValue<DeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceType.
    /// </summary>
    public class DeviceType : ConstantClass
    {

        /// <summary>
        /// Constant QPU for DeviceType
        /// </summary>
        public static readonly DeviceType QPU = new DeviceType("QPU");
        /// <summary>
        /// Constant SIMULATOR for DeviceType
        /// </summary>
        public static readonly DeviceType SIMULATOR = new DeviceType("SIMULATOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuantumTaskStatus.
    /// </summary>
    public class QuantumTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CANCELLED = new QuantumTaskStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CANCELLING = new QuantumTaskStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus COMPLETED = new QuantumTaskStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus CREATED = new QuantumTaskStatus("CREATED");
        /// <summary>
        /// Constant FAILED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus FAILED = new QuantumTaskStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus QUEUED = new QuantumTaskStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for QuantumTaskStatus
        /// </summary>
        public static readonly QuantumTaskStatus RUNNING = new QuantumTaskStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuantumTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuantumTaskStatus FindValue(string value)
        {
            return FindValue<QuantumTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuantumTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchQuantumTasksFilterOperator.
    /// </summary>
    public class SearchQuantumTasksFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator BETWEEN = new SearchQuantumTasksFilterOperator("BETWEEN");
        /// <summary>
        /// Constant EQUAL for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator EQUAL = new SearchQuantumTasksFilterOperator("EQUAL");
        /// <summary>
        /// Constant GT for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator GT = new SearchQuantumTasksFilterOperator("GT");
        /// <summary>
        /// Constant GTE for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator GTE = new SearchQuantumTasksFilterOperator("GTE");
        /// <summary>
        /// Constant LT for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator LT = new SearchQuantumTasksFilterOperator("LT");
        /// <summary>
        /// Constant LTE for SearchQuantumTasksFilterOperator
        /// </summary>
        public static readonly SearchQuantumTasksFilterOperator LTE = new SearchQuantumTasksFilterOperator("LTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchQuantumTasksFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchQuantumTasksFilterOperator FindValue(string value)
        {
            return FindValue<SearchQuantumTasksFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchQuantumTasksFilterOperator(string value)
        {
            return FindValue(value);
        }
    }

}
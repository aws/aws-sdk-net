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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimSpaceWeaver
{

    /// <summary>
    /// Constants used for properties of type ClockStatus.
    /// </summary>
    public class ClockStatus : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for ClockStatus
        /// </summary>
        public static readonly ClockStatus STARTED = new ClockStatus("STARTED");
        /// <summary>
        /// Constant STARTING for ClockStatus
        /// </summary>
        public static readonly ClockStatus STARTING = new ClockStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for ClockStatus
        /// </summary>
        public static readonly ClockStatus STOPPED = new ClockStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for ClockStatus
        /// </summary>
        public static readonly ClockStatus STOPPING = new ClockStatus("STOPPING");
        /// <summary>
        /// Constant UNKNOWN for ClockStatus
        /// </summary>
        public static readonly ClockStatus UNKNOWN = new ClockStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClockStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClockStatus FindValue(string value)
        {
            return FindValue<ClockStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClockStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClockTargetStatus.
    /// </summary>
    public class ClockTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for ClockTargetStatus
        /// </summary>
        public static readonly ClockTargetStatus STARTED = new ClockTargetStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for ClockTargetStatus
        /// </summary>
        public static readonly ClockTargetStatus STOPPED = new ClockTargetStatus("STOPPED");
        /// <summary>
        /// Constant UNKNOWN for ClockTargetStatus
        /// </summary>
        public static readonly ClockTargetStatus UNKNOWN = new ClockTargetStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClockTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClockTargetStatus FindValue(string value)
        {
            return FindValue<ClockTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClockTargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleManagementStrategy.
    /// </summary>
    public class LifecycleManagementStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ByRequest for LifecycleManagementStrategy
        /// </summary>
        public static readonly LifecycleManagementStrategy ByRequest = new LifecycleManagementStrategy("ByRequest");
        /// <summary>
        /// Constant BySpatialSubdivision for LifecycleManagementStrategy
        /// </summary>
        public static readonly LifecycleManagementStrategy BySpatialSubdivision = new LifecycleManagementStrategy("BySpatialSubdivision");
        /// <summary>
        /// Constant PerWorker for LifecycleManagementStrategy
        /// </summary>
        public static readonly LifecycleManagementStrategy PerWorker = new LifecycleManagementStrategy("PerWorker");
        /// <summary>
        /// Constant Unknown for LifecycleManagementStrategy
        /// </summary>
        public static readonly LifecycleManagementStrategy Unknown = new LifecycleManagementStrategy("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleManagementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleManagementStrategy FindValue(string value)
        {
            return FindValue<LifecycleManagementStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleManagementStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationAppStatus.
    /// </summary>
    public class SimulationAppStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus ERROR = new SimulationAppStatus("ERROR");
        /// <summary>
        /// Constant STARTED for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus STARTED = new SimulationAppStatus("STARTED");
        /// <summary>
        /// Constant STARTING for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus STARTING = new SimulationAppStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus STOPPED = new SimulationAppStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus STOPPING = new SimulationAppStatus("STOPPING");
        /// <summary>
        /// Constant UNKNOWN for SimulationAppStatus
        /// </summary>
        public static readonly SimulationAppStatus UNKNOWN = new SimulationAppStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationAppStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationAppStatus FindValue(string value)
        {
            return FindValue<SimulationAppStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationAppStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationAppTargetStatus.
    /// </summary>
    public class SimulationAppTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for SimulationAppTargetStatus
        /// </summary>
        public static readonly SimulationAppTargetStatus STARTED = new SimulationAppTargetStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for SimulationAppTargetStatus
        /// </summary>
        public static readonly SimulationAppTargetStatus STOPPED = new SimulationAppTargetStatus("STOPPED");
        /// <summary>
        /// Constant UNKNOWN for SimulationAppTargetStatus
        /// </summary>
        public static readonly SimulationAppTargetStatus UNKNOWN = new SimulationAppTargetStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationAppTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationAppTargetStatus FindValue(string value)
        {
            return FindValue<SimulationAppTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationAppTargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationStatus.
    /// </summary>
    public class SimulationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus DELETED = new SimulationStatus("DELETED");
        /// <summary>
        /// Constant DELETING for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus DELETING = new SimulationStatus("DELETING");
        /// <summary>
        /// Constant FAILED for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus FAILED = new SimulationStatus("FAILED");
        /// <summary>
        /// Constant STARTED for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus STARTED = new SimulationStatus("STARTED");
        /// <summary>
        /// Constant STARTING for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus STARTING = new SimulationStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus STOPPED = new SimulationStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus STOPPING = new SimulationStatus("STOPPING");
        /// <summary>
        /// Constant UNKNOWN for SimulationStatus
        /// </summary>
        public static readonly SimulationStatus UNKNOWN = new SimulationStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationStatus FindValue(string value)
        {
            return FindValue<SimulationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SimulationTargetStatus.
    /// </summary>
    public class SimulationTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for SimulationTargetStatus
        /// </summary>
        public static readonly SimulationTargetStatus DELETED = new SimulationTargetStatus("DELETED");
        /// <summary>
        /// Constant STARTED for SimulationTargetStatus
        /// </summary>
        public static readonly SimulationTargetStatus STARTED = new SimulationTargetStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for SimulationTargetStatus
        /// </summary>
        public static readonly SimulationTargetStatus STOPPED = new SimulationTargetStatus("STOPPED");
        /// <summary>
        /// Constant UNKNOWN for SimulationTargetStatus
        /// </summary>
        public static readonly SimulationTargetStatus UNKNOWN = new SimulationTargetStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SimulationTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SimulationTargetStatus FindValue(string value)
        {
            return FindValue<SimulationTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SimulationTargetStatus(string value)
        {
            return FindValue(value);
        }
    }

}
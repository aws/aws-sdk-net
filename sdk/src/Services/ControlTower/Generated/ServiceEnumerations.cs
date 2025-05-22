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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ControlTower
{

    /// <summary>
    /// Constants used for properties of type BaselineOperationStatus.
    /// </summary>
    public class BaselineOperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BaselineOperationStatus
        /// </summary>
        public static readonly BaselineOperationStatus FAILED = new BaselineOperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for BaselineOperationStatus
        /// </summary>
        public static readonly BaselineOperationStatus IN_PROGRESS = new BaselineOperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for BaselineOperationStatus
        /// </summary>
        public static readonly BaselineOperationStatus SUCCEEDED = new BaselineOperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BaselineOperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BaselineOperationStatus FindValue(string value)
        {
            return FindValue<BaselineOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BaselineOperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BaselineOperationType.
    /// </summary>
    public class BaselineOperationType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_BASELINE for BaselineOperationType
        /// </summary>
        public static readonly BaselineOperationType DISABLE_BASELINE = new BaselineOperationType("DISABLE_BASELINE");
        /// <summary>
        /// Constant ENABLE_BASELINE for BaselineOperationType
        /// </summary>
        public static readonly BaselineOperationType ENABLE_BASELINE = new BaselineOperationType("ENABLE_BASELINE");
        /// <summary>
        /// Constant RESET_ENABLED_BASELINE for BaselineOperationType
        /// </summary>
        public static readonly BaselineOperationType RESET_ENABLED_BASELINE = new BaselineOperationType("RESET_ENABLED_BASELINE");
        /// <summary>
        /// Constant UPDATE_ENABLED_BASELINE for BaselineOperationType
        /// </summary>
        public static readonly BaselineOperationType UPDATE_ENABLED_BASELINE = new BaselineOperationType("UPDATE_ENABLED_BASELINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BaselineOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BaselineOperationType FindValue(string value)
        {
            return FindValue<BaselineOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BaselineOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlOperationStatus.
    /// </summary>
    public class ControlOperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus FAILED = new ControlOperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus IN_PROGRESS = new ControlOperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ControlOperationStatus
        /// </summary>
        public static readonly ControlOperationStatus SUCCEEDED = new ControlOperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlOperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlOperationStatus FindValue(string value)
        {
            return FindValue<ControlOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlOperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlOperationType.
    /// </summary>
    public class ControlOperationType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType DISABLE_CONTROL = new ControlOperationType("DISABLE_CONTROL");
        /// <summary>
        /// Constant ENABLE_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType ENABLE_CONTROL = new ControlOperationType("ENABLE_CONTROL");
        /// <summary>
        /// Constant RESET_ENABLED_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType RESET_ENABLED_CONTROL = new ControlOperationType("RESET_ENABLED_CONTROL");
        /// <summary>
        /// Constant UPDATE_ENABLED_CONTROL for ControlOperationType
        /// </summary>
        public static readonly ControlOperationType UPDATE_ENABLED_CONTROL = new ControlOperationType("UPDATE_ENABLED_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlOperationType FindValue(string value)
        {
            return FindValue<ControlOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DriftStatus.
    /// </summary>
    public class DriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRIFTED for DriftStatus
        /// </summary>
        public static readonly DriftStatus DRIFTED = new DriftStatus("DRIFTED");
        /// <summary>
        /// Constant IN_SYNC for DriftStatus
        /// </summary>
        public static readonly DriftStatus IN_SYNC = new DriftStatus("IN_SYNC");
        /// <summary>
        /// Constant NOT_CHECKING for DriftStatus
        /// </summary>
        public static readonly DriftStatus NOT_CHECKING = new DriftStatus("NOT_CHECKING");
        /// <summary>
        /// Constant UNKNOWN for DriftStatus
        /// </summary>
        public static readonly DriftStatus UNKNOWN = new DriftStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DriftStatus FindValue(string value)
        {
            return FindValue<DriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnabledBaselineDriftStatus.
    /// </summary>
    public class EnabledBaselineDriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRIFTED for EnabledBaselineDriftStatus
        /// </summary>
        public static readonly EnabledBaselineDriftStatus DRIFTED = new EnabledBaselineDriftStatus("DRIFTED");
        /// <summary>
        /// Constant IN_SYNC for EnabledBaselineDriftStatus
        /// </summary>
        public static readonly EnabledBaselineDriftStatus IN_SYNC = new EnabledBaselineDriftStatus("IN_SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnabledBaselineDriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnabledBaselineDriftStatus FindValue(string value)
        {
            return FindValue<EnabledBaselineDriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnabledBaselineDriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnablementStatus.
    /// </summary>
    public class EnablementStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for EnablementStatus
        /// </summary>
        public static readonly EnablementStatus FAILED = new EnablementStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for EnablementStatus
        /// </summary>
        public static readonly EnablementStatus SUCCEEDED = new EnablementStatus("SUCCEEDED");
        /// <summary>
        /// Constant UNDER_CHANGE for EnablementStatus
        /// </summary>
        public static readonly EnablementStatus UNDER_CHANGE = new EnablementStatus("UNDER_CHANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnablementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnablementStatus FindValue(string value)
        {
            return FindValue<EnablementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnablementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LandingZoneDriftStatus.
    /// </summary>
    public class LandingZoneDriftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRIFTED for LandingZoneDriftStatus
        /// </summary>
        public static readonly LandingZoneDriftStatus DRIFTED = new LandingZoneDriftStatus("DRIFTED");
        /// <summary>
        /// Constant IN_SYNC for LandingZoneDriftStatus
        /// </summary>
        public static readonly LandingZoneDriftStatus IN_SYNC = new LandingZoneDriftStatus("IN_SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LandingZoneDriftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LandingZoneDriftStatus FindValue(string value)
        {
            return FindValue<LandingZoneDriftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LandingZoneDriftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LandingZoneOperationStatus.
    /// </summary>
    public class LandingZoneOperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LandingZoneOperationStatus
        /// </summary>
        public static readonly LandingZoneOperationStatus FAILED = new LandingZoneOperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LandingZoneOperationStatus
        /// </summary>
        public static readonly LandingZoneOperationStatus IN_PROGRESS = new LandingZoneOperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for LandingZoneOperationStatus
        /// </summary>
        public static readonly LandingZoneOperationStatus SUCCEEDED = new LandingZoneOperationStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LandingZoneOperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LandingZoneOperationStatus FindValue(string value)
        {
            return FindValue<LandingZoneOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LandingZoneOperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LandingZoneOperationType.
    /// </summary>
    public class LandingZoneOperationType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for LandingZoneOperationType
        /// </summary>
        public static readonly LandingZoneOperationType CREATE = new LandingZoneOperationType("CREATE");
        /// <summary>
        /// Constant DELETE for LandingZoneOperationType
        /// </summary>
        public static readonly LandingZoneOperationType DELETE = new LandingZoneOperationType("DELETE");
        /// <summary>
        /// Constant RESET for LandingZoneOperationType
        /// </summary>
        public static readonly LandingZoneOperationType RESET = new LandingZoneOperationType("RESET");
        /// <summary>
        /// Constant UPDATE for LandingZoneOperationType
        /// </summary>
        public static readonly LandingZoneOperationType UPDATE = new LandingZoneOperationType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LandingZoneOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LandingZoneOperationType FindValue(string value)
        {
            return FindValue<LandingZoneOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LandingZoneOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LandingZoneStatus.
    /// </summary>
    public class LandingZoneStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for LandingZoneStatus
        /// </summary>
        public static readonly LandingZoneStatus ACTIVE = new LandingZoneStatus("ACTIVE");
        /// <summary>
        /// Constant FAILED for LandingZoneStatus
        /// </summary>
        public static readonly LandingZoneStatus FAILED = new LandingZoneStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for LandingZoneStatus
        /// </summary>
        public static readonly LandingZoneStatus PROCESSING = new LandingZoneStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LandingZoneStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LandingZoneStatus FindValue(string value)
        {
            return FindValue<LandingZoneStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LandingZoneStatus(string value)
        {
            return FindValue(value);
        }
    }

}
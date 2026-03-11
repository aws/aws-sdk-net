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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ARCZonalShift
{

    /// <summary>
    /// Constants used for properties of type AppliedStatus.
    /// </summary>
    public class AppliedStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPLIED for AppliedStatus
        /// </summary>
        public static readonly AppliedStatus APPLIED = new AppliedStatus("APPLIED");
        /// <summary>
        /// Constant NOT_APPLIED for AppliedStatus
        /// </summary>
        public static readonly AppliedStatus NOT_APPLIED = new AppliedStatus("NOT_APPLIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppliedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppliedStatus FindValue(string value)
        {
            return FindValue<AppliedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppliedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoshiftAppliedStatus.
    /// </summary>
    public class AutoshiftAppliedStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPLIED for AutoshiftAppliedStatus
        /// </summary>
        public static readonly AutoshiftAppliedStatus APPLIED = new AutoshiftAppliedStatus("APPLIED");
        /// <summary>
        /// Constant NOT_APPLIED for AutoshiftAppliedStatus
        /// </summary>
        public static readonly AutoshiftAppliedStatus NOT_APPLIED = new AutoshiftAppliedStatus("NOT_APPLIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoshiftAppliedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoshiftAppliedStatus FindValue(string value)
        {
            return FindValue<AutoshiftAppliedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoshiftAppliedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoshiftExecutionStatus.
    /// </summary>
    public class AutoshiftExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AutoshiftExecutionStatus
        /// </summary>
        public static readonly AutoshiftExecutionStatus ACTIVE = new AutoshiftExecutionStatus("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for AutoshiftExecutionStatus
        /// </summary>
        public static readonly AutoshiftExecutionStatus COMPLETED = new AutoshiftExecutionStatus("COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoshiftExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoshiftExecutionStatus FindValue(string value)
        {
            return FindValue<AutoshiftExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoshiftExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoshiftObserverNotificationStatus.
    /// </summary>
    public class AutoshiftObserverNotificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AutoshiftObserverNotificationStatus
        /// </summary>
        public static readonly AutoshiftObserverNotificationStatus DISABLED = new AutoshiftObserverNotificationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AutoshiftObserverNotificationStatus
        /// </summary>
        public static readonly AutoshiftObserverNotificationStatus ENABLED = new AutoshiftObserverNotificationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoshiftObserverNotificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoshiftObserverNotificationStatus FindValue(string value)
        {
            return FindValue<AutoshiftObserverNotificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoshiftObserverNotificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant AutoShiftEnabled for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason AutoShiftEnabled = new ConflictExceptionReason("AutoShiftEnabled");
        /// <summary>
        /// Constant PracticeBlockingAlarmsRed for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeBlockingAlarmsRed = new ConflictExceptionReason("PracticeBlockingAlarmsRed");
        /// <summary>
        /// Constant PracticeConfigurationAlreadyExists for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeConfigurationAlreadyExists = new ConflictExceptionReason("PracticeConfigurationAlreadyExists");
        /// <summary>
        /// Constant PracticeConfigurationDoesNotExist for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeConfigurationDoesNotExist = new ConflictExceptionReason("PracticeConfigurationDoesNotExist");
        /// <summary>
        /// Constant PracticeInBlockedDates for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeInBlockedDates = new ConflictExceptionReason("PracticeInBlockedDates");
        /// <summary>
        /// Constant PracticeInBlockedWindows for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeInBlockedWindows = new ConflictExceptionReason("PracticeInBlockedWindows");
        /// <summary>
        /// Constant PracticeOutcomeAlarmsRed for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeOutcomeAlarmsRed = new ConflictExceptionReason("PracticeOutcomeAlarmsRed");
        /// <summary>
        /// Constant PracticeOutsideAllowedWindows for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason PracticeOutsideAllowedWindows = new ConflictExceptionReason("PracticeOutsideAllowedWindows");
        /// <summary>
        /// Constant SimultaneousZonalShiftsConflict for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason SimultaneousZonalShiftsConflict = new ConflictExceptionReason("SimultaneousZonalShiftsConflict");
        /// <summary>
        /// Constant ZonalAutoshiftActive for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ZonalAutoshiftActive = new ConflictExceptionReason("ZonalAutoshiftActive");
        /// <summary>
        /// Constant ZonalShiftAlreadyExists for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ZonalShiftAlreadyExists = new ConflictExceptionReason("ZonalShiftAlreadyExists");
        /// <summary>
        /// Constant ZonalShiftStatusNotActive for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason ZonalShiftStatusNotActive = new ConflictExceptionReason("ZonalShiftStatusNotActive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlConditionType.
    /// </summary>
    public class ControlConditionType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDWATCH for ControlConditionType
        /// </summary>
        public static readonly ControlConditionType CLOUDWATCH = new ControlConditionType("CLOUDWATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlConditionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlConditionType FindValue(string value)
        {
            return FindValue<ControlConditionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlConditionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PracticeRunOutcome.
    /// </summary>
    public class PracticeRunOutcome : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_CHECK_FAILED for PracticeRunOutcome
        /// </summary>
        public static readonly PracticeRunOutcome CAPACITY_CHECK_FAILED = new PracticeRunOutcome("CAPACITY_CHECK_FAILED");
        /// <summary>
        /// Constant FAILED for PracticeRunOutcome
        /// </summary>
        public static readonly PracticeRunOutcome FAILED = new PracticeRunOutcome("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for PracticeRunOutcome
        /// </summary>
        public static readonly PracticeRunOutcome INTERRUPTED = new PracticeRunOutcome("INTERRUPTED");
        /// <summary>
        /// Constant PENDING for PracticeRunOutcome
        /// </summary>
        public static readonly PracticeRunOutcome PENDING = new PracticeRunOutcome("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for PracticeRunOutcome
        /// </summary>
        public static readonly PracticeRunOutcome SUCCEEDED = new PracticeRunOutcome("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PracticeRunOutcome(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PracticeRunOutcome FindValue(string value)
        {
            return FindValue<PracticeRunOutcome>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PracticeRunOutcome(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShiftType.
    /// </summary>
    public class ShiftType : ConstantClass
    {

        /// <summary>
        /// Constant FIS_EXPERIMENT for ShiftType
        /// </summary>
        public static readonly ShiftType FIS_EXPERIMENT = new ShiftType("FIS_EXPERIMENT");
        /// <summary>
        /// Constant PRACTICE_RUN for ShiftType
        /// </summary>
        public static readonly ShiftType PRACTICE_RUN = new ShiftType("PRACTICE_RUN");
        /// <summary>
        /// Constant ZONAL_AUTOSHIFT for ShiftType
        /// </summary>
        public static readonly ShiftType ZONAL_AUTOSHIFT = new ShiftType("ZONAL_AUTOSHIFT");
        /// <summary>
        /// Constant ZONAL_SHIFT for ShiftType
        /// </summary>
        public static readonly ShiftType ZONAL_SHIFT = new ShiftType("ZONAL_SHIFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShiftType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShiftType FindValue(string value)
        {
            return FindValue<ShiftType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShiftType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant AutoshiftUpdateNotAllowed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason AutoshiftUpdateNotAllowed = new ValidationExceptionReason("AutoshiftUpdateNotAllowed");
        /// <summary>
        /// Constant FISExperimentUpdateNotAllowed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FISExperimentUpdateNotAllowed = new ValidationExceptionReason("FISExperimentUpdateNotAllowed");
        /// <summary>
        /// Constant InvalidAlarmCondition for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidAlarmCondition = new ValidationExceptionReason("InvalidAlarmCondition");
        /// <summary>
        /// Constant InvalidAz for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidAz = new ValidationExceptionReason("InvalidAz");
        /// <summary>
        /// Constant InvalidConditionType for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidConditionType = new ValidationExceptionReason("InvalidConditionType");
        /// <summary>
        /// Constant InvalidExpiresIn for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidExpiresIn = new ValidationExceptionReason("InvalidExpiresIn");
        /// <summary>
        /// Constant InvalidPracticeAllowedWindow for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidPracticeAllowedWindow = new ValidationExceptionReason("InvalidPracticeAllowedWindow");
        /// <summary>
        /// Constant InvalidPracticeBlocker for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidPracticeBlocker = new ValidationExceptionReason("InvalidPracticeBlocker");
        /// <summary>
        /// Constant InvalidPracticeWindows for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidPracticeWindows = new ValidationExceptionReason("InvalidPracticeWindows");
        /// <summary>
        /// Constant InvalidResourceIdentifier for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidResourceIdentifier = new ValidationExceptionReason("InvalidResourceIdentifier");
        /// <summary>
        /// Constant InvalidStatus for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidStatus = new ValidationExceptionReason("InvalidStatus");
        /// <summary>
        /// Constant InvalidToken for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidToken = new ValidationExceptionReason("InvalidToken");
        /// <summary>
        /// Constant MissingValue for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MissingValue = new ValidationExceptionReason("MissingValue");
        /// <summary>
        /// Constant UnsupportedAz for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedAz = new ValidationExceptionReason("UnsupportedAz");
        /// <summary>
        /// Constant UnsupportedPracticeCancelShiftType for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedPracticeCancelShiftType = new ValidationExceptionReason("UnsupportedPracticeCancelShiftType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZonalAutoshiftStatus.
    /// </summary>
    public class ZonalAutoshiftStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ZonalAutoshiftStatus
        /// </summary>
        public static readonly ZonalAutoshiftStatus DISABLED = new ZonalAutoshiftStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ZonalAutoshiftStatus
        /// </summary>
        public static readonly ZonalAutoshiftStatus ENABLED = new ZonalAutoshiftStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZonalAutoshiftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZonalAutoshiftStatus FindValue(string value)
        {
            return FindValue<ZonalAutoshiftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZonalAutoshiftStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZonalShiftStatus.
    /// </summary>
    public class ZonalShiftStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus ACTIVE = new ZonalShiftStatus("ACTIVE");
        /// <summary>
        /// Constant CANCELED for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus CANCELED = new ZonalShiftStatus("CANCELED");
        /// <summary>
        /// Constant EXPIRED for ZonalShiftStatus
        /// </summary>
        public static readonly ZonalShiftStatus EXPIRED = new ZonalShiftStatus("EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZonalShiftStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZonalShiftStatus FindValue(string value)
        {
            return FindValue<ZonalShiftStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZonalShiftStatus(string value)
        {
            return FindValue(value);
        }
    }

}
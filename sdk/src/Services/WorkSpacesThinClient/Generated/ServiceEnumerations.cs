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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkSpacesThinClient
{

    /// <summary>
    /// Constants used for properties of type ApplyTimeOf.
    /// </summary>
    public class ApplyTimeOf : ConstantClass
    {

        /// <summary>
        /// Constant DEVICE for ApplyTimeOf
        /// </summary>
        public static readonly ApplyTimeOf DEVICE = new ApplyTimeOf("DEVICE");
        /// <summary>
        /// Constant UTC for ApplyTimeOf
        /// </summary>
        public static readonly ApplyTimeOf UTC = new ApplyTimeOf("UTC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplyTimeOf(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplyTimeOf FindValue(string value)
        {
            return FindValue<ApplyTimeOf>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplyTimeOf(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRIDAY = new DayOfWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MONDAY = new DayOfWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SATURDAY = new DayOfWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUNDAY = new DayOfWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THURSDAY = new DayOfWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUESDAY = new DayOfWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WEDNESDAY = new DayOfWeek("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesktopType.
    /// </summary>
    public class DesktopType : ConstantClass
    {

        /// <summary>
        /// Constant Appstream for DesktopType
        /// </summary>
        public static readonly DesktopType Appstream = new DesktopType("appstream");
        /// <summary>
        /// Constant Workspaces for DesktopType
        /// </summary>
        public static readonly DesktopType Workspaces = new DesktopType("workspaces");
        /// <summary>
        /// Constant WorkspacesWeb for DesktopType
        /// </summary>
        public static readonly DesktopType WorkspacesWeb = new DesktopType("workspaces-web");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesktopType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesktopType FindValue(string value)
        {
            return FindValue<DesktopType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesktopType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceSoftwareSetComplianceStatus.
    /// </summary>
    public class DeviceSoftwareSetComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for DeviceSoftwareSetComplianceStatus
        /// </summary>
        public static readonly DeviceSoftwareSetComplianceStatus COMPLIANT = new DeviceSoftwareSetComplianceStatus("COMPLIANT");
        /// <summary>
        /// Constant NONE for DeviceSoftwareSetComplianceStatus
        /// </summary>
        public static readonly DeviceSoftwareSetComplianceStatus NONE = new DeviceSoftwareSetComplianceStatus("NONE");
        /// <summary>
        /// Constant NOT_COMPLIANT for DeviceSoftwareSetComplianceStatus
        /// </summary>
        public static readonly DeviceSoftwareSetComplianceStatus NOT_COMPLIANT = new DeviceSoftwareSetComplianceStatus("NOT_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceSoftwareSetComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceSoftwareSetComplianceStatus FindValue(string value)
        {
            return FindValue<DeviceSoftwareSetComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceSoftwareSetComplianceStatus(string value)
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
        /// Constant ARCHIVED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus ARCHIVED = new DeviceStatus("ARCHIVED");
        /// <summary>
        /// Constant DEREGISTERED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus DEREGISTERED = new DeviceStatus("DEREGISTERED");
        /// <summary>
        /// Constant DEREGISTERING for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus DEREGISTERING = new DeviceStatus("DEREGISTERING");
        /// <summary>
        /// Constant REGISTERED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus REGISTERED = new DeviceStatus("REGISTERED");

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
    /// Constants used for properties of type EnvironmentSoftwareSetComplianceStatus.
    /// </summary>
    public class EnvironmentSoftwareSetComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for EnvironmentSoftwareSetComplianceStatus
        /// </summary>
        public static readonly EnvironmentSoftwareSetComplianceStatus COMPLIANT = new EnvironmentSoftwareSetComplianceStatus("COMPLIANT");
        /// <summary>
        /// Constant NO_REGISTERED_DEVICES for EnvironmentSoftwareSetComplianceStatus
        /// </summary>
        public static readonly EnvironmentSoftwareSetComplianceStatus NO_REGISTERED_DEVICES = new EnvironmentSoftwareSetComplianceStatus("NO_REGISTERED_DEVICES");
        /// <summary>
        /// Constant NOT_COMPLIANT for EnvironmentSoftwareSetComplianceStatus
        /// </summary>
        public static readonly EnvironmentSoftwareSetComplianceStatus NOT_COMPLIANT = new EnvironmentSoftwareSetComplianceStatus("NOT_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentSoftwareSetComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentSoftwareSetComplianceStatus FindValue(string value)
        {
            return FindValue<EnvironmentSoftwareSetComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentSoftwareSetComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowType.
    /// </summary>
    public class MaintenanceWindowType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for MaintenanceWindowType
        /// </summary>
        public static readonly MaintenanceWindowType CUSTOM = new MaintenanceWindowType("CUSTOM");
        /// <summary>
        /// Constant SYSTEM for MaintenanceWindowType
        /// </summary>
        public static readonly MaintenanceWindowType SYSTEM = new MaintenanceWindowType("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowType FindValue(string value)
        {
            return FindValue<MaintenanceWindowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SoftwareSetUpdateMode.
    /// </summary>
    public class SoftwareSetUpdateMode : ConstantClass
    {

        /// <summary>
        /// Constant USE_DESIRED for SoftwareSetUpdateMode
        /// </summary>
        public static readonly SoftwareSetUpdateMode USE_DESIRED = new SoftwareSetUpdateMode("USE_DESIRED");
        /// <summary>
        /// Constant USE_LATEST for SoftwareSetUpdateMode
        /// </summary>
        public static readonly SoftwareSetUpdateMode USE_LATEST = new SoftwareSetUpdateMode("USE_LATEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SoftwareSetUpdateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SoftwareSetUpdateMode FindValue(string value)
        {
            return FindValue<SoftwareSetUpdateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SoftwareSetUpdateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SoftwareSetUpdateSchedule.
    /// </summary>
    public class SoftwareSetUpdateSchedule : ConstantClass
    {

        /// <summary>
        /// Constant APPLY_IMMEDIATELY for SoftwareSetUpdateSchedule
        /// </summary>
        public static readonly SoftwareSetUpdateSchedule APPLY_IMMEDIATELY = new SoftwareSetUpdateSchedule("APPLY_IMMEDIATELY");
        /// <summary>
        /// Constant USE_MAINTENANCE_WINDOW for SoftwareSetUpdateSchedule
        /// </summary>
        public static readonly SoftwareSetUpdateSchedule USE_MAINTENANCE_WINDOW = new SoftwareSetUpdateSchedule("USE_MAINTENANCE_WINDOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SoftwareSetUpdateSchedule(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SoftwareSetUpdateSchedule FindValue(string value)
        {
            return FindValue<SoftwareSetUpdateSchedule>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SoftwareSetUpdateSchedule(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SoftwareSetUpdateStatus.
    /// </summary>
    public class SoftwareSetUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SoftwareSetUpdateStatus
        /// </summary>
        public static readonly SoftwareSetUpdateStatus AVAILABLE = new SoftwareSetUpdateStatus("AVAILABLE");
        /// <summary>
        /// Constant IN_PROGRESS for SoftwareSetUpdateStatus
        /// </summary>
        public static readonly SoftwareSetUpdateStatus IN_PROGRESS = new SoftwareSetUpdateStatus("IN_PROGRESS");
        /// <summary>
        /// Constant UP_TO_DATE for SoftwareSetUpdateStatus
        /// </summary>
        public static readonly SoftwareSetUpdateStatus UP_TO_DATE = new SoftwareSetUpdateStatus("UP_TO_DATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SoftwareSetUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SoftwareSetUpdateStatus FindValue(string value)
        {
            return FindValue<SoftwareSetUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SoftwareSetUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SoftwareSetValidationStatus.
    /// </summary>
    public class SoftwareSetValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_VALIDATED for SoftwareSetValidationStatus
        /// </summary>
        public static readonly SoftwareSetValidationStatus NOT_VALIDATED = new SoftwareSetValidationStatus("NOT_VALIDATED");
        /// <summary>
        /// Constant VALIDATED for SoftwareSetValidationStatus
        /// </summary>
        public static readonly SoftwareSetValidationStatus VALIDATED = new SoftwareSetValidationStatus("VALIDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SoftwareSetValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SoftwareSetValidationStatus FindValue(string value)
        {
            return FindValue<SoftwareSetValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SoftwareSetValidationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDeviceStatus.
    /// </summary>
    public class TargetDeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for TargetDeviceStatus
        /// </summary>
        public static readonly TargetDeviceStatus ARCHIVED = new TargetDeviceStatus("ARCHIVED");
        /// <summary>
        /// Constant DEREGISTERED for TargetDeviceStatus
        /// </summary>
        public static readonly TargetDeviceStatus DEREGISTERED = new TargetDeviceStatus("DEREGISTERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDeviceStatus FindValue(string value)
        {
            return FindValue<TargetDeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDeviceStatus(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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

}
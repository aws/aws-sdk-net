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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Odb
{

    /// <summary>
    /// Constants used for properties of type Access.
    /// </summary>
    public class Access : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Access
        /// </summary>
        public static readonly Access DISABLED = new Access("DISABLED");
        /// <summary>
        /// Constant ENABLED for Access
        /// </summary>
        public static readonly Access ENABLED = new Access("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Access(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Access FindValue(string value)
        {
            return FindValue<Access>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Access(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeModel.
    /// </summary>
    public class ComputeModel : ConstantClass
    {

        /// <summary>
        /// Constant ECPU for ComputeModel
        /// </summary>
        public static readonly ComputeModel ECPU = new ComputeModel("ECPU");
        /// <summary>
        /// Constant OCPU for ComputeModel
        /// </summary>
        public static readonly ComputeModel OCPU = new ComputeModel("OCPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeModel FindValue(string value)
        {
            return FindValue<ComputeModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeekName.
    /// </summary>
    public class DayOfWeekName : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName FRIDAY = new DayOfWeekName("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName MONDAY = new DayOfWeekName("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName SATURDAY = new DayOfWeekName("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName SUNDAY = new DayOfWeekName("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName THURSDAY = new DayOfWeekName("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName TUESDAY = new DayOfWeekName("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeekName
        /// </summary>
        public static readonly DayOfWeekName WEDNESDAY = new DayOfWeekName("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeekName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeekName FindValue(string value)
        {
            return FindValue<DayOfWeekName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeekName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DbNodeMaintenanceType.
    /// </summary>
    public class DbNodeMaintenanceType : ConstantClass
    {

        /// <summary>
        /// Constant VMDB_REBOOT_MIGRATION for DbNodeMaintenanceType
        /// </summary>
        public static readonly DbNodeMaintenanceType VMDB_REBOOT_MIGRATION = new DbNodeMaintenanceType("VMDB_REBOOT_MIGRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DbNodeMaintenanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbNodeMaintenanceType FindValue(string value)
        {
            return FindValue<DbNodeMaintenanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbNodeMaintenanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DbNodeResourceStatus.
    /// </summary>
    public class DbNodeResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus AVAILABLE = new DbNodeResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant FAILED for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus FAILED = new DbNodeResourceStatus("FAILED");
        /// <summary>
        /// Constant PROVISIONING for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus PROVISIONING = new DbNodeResourceStatus("PROVISIONING");
        /// <summary>
        /// Constant STARTING for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus STARTING = new DbNodeResourceStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus STOPPED = new DbNodeResourceStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus STOPPING = new DbNodeResourceStatus("STOPPING");
        /// <summary>
        /// Constant TERMINATED for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus TERMINATED = new DbNodeResourceStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus TERMINATING = new DbNodeResourceStatus("TERMINATING");
        /// <summary>
        /// Constant UPDATING for DbNodeResourceStatus
        /// </summary>
        public static readonly DbNodeResourceStatus UPDATING = new DbNodeResourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DbNodeResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbNodeResourceStatus FindValue(string value)
        {
            return FindValue<DbNodeResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbNodeResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DbServerPatchingStatus.
    /// </summary>
    public class DbServerPatchingStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for DbServerPatchingStatus
        /// </summary>
        public static readonly DbServerPatchingStatus COMPLETE = new DbServerPatchingStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for DbServerPatchingStatus
        /// </summary>
        public static readonly DbServerPatchingStatus FAILED = new DbServerPatchingStatus("FAILED");
        /// <summary>
        /// Constant MAINTENANCE_IN_PROGRESS for DbServerPatchingStatus
        /// </summary>
        public static readonly DbServerPatchingStatus MAINTENANCE_IN_PROGRESS = new DbServerPatchingStatus("MAINTENANCE_IN_PROGRESS");
        /// <summary>
        /// Constant SCHEDULED for DbServerPatchingStatus
        /// </summary>
        public static readonly DbServerPatchingStatus SCHEDULED = new DbServerPatchingStatus("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DbServerPatchingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbServerPatchingStatus FindValue(string value)
        {
            return FindValue<DbServerPatchingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbServerPatchingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskRedundancy.
    /// </summary>
    public class DiskRedundancy : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for DiskRedundancy
        /// </summary>
        public static readonly DiskRedundancy HIGH = new DiskRedundancy("HIGH");
        /// <summary>
        /// Constant NORMAL for DiskRedundancy
        /// </summary>
        public static readonly DiskRedundancy NORMAL = new DiskRedundancy("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskRedundancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskRedundancy FindValue(string value)
        {
            return FindValue<DiskRedundancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskRedundancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IormLifecycleState.
    /// </summary>
    public class IormLifecycleState : ConstantClass
    {

        /// <summary>
        /// Constant BOOTSTRAPPING for IormLifecycleState
        /// </summary>
        public static readonly IormLifecycleState BOOTSTRAPPING = new IormLifecycleState("BOOTSTRAPPING");
        /// <summary>
        /// Constant DISABLED for IormLifecycleState
        /// </summary>
        public static readonly IormLifecycleState DISABLED = new IormLifecycleState("DISABLED");
        /// <summary>
        /// Constant ENABLED for IormLifecycleState
        /// </summary>
        public static readonly IormLifecycleState ENABLED = new IormLifecycleState("ENABLED");
        /// <summary>
        /// Constant FAILED for IormLifecycleState
        /// </summary>
        public static readonly IormLifecycleState FAILED = new IormLifecycleState("FAILED");
        /// <summary>
        /// Constant UPDATING for IormLifecycleState
        /// </summary>
        public static readonly IormLifecycleState UPDATING = new IormLifecycleState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IormLifecycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IormLifecycleState FindValue(string value)
        {
            return FindValue<IormLifecycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IormLifecycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseModel.
    /// </summary>
    public class LicenseModel : ConstantClass
    {

        /// <summary>
        /// Constant BRING_YOUR_OWN_LICENSE for LicenseModel
        /// </summary>
        public static readonly LicenseModel BRING_YOUR_OWN_LICENSE = new LicenseModel("BRING_YOUR_OWN_LICENSE");
        /// <summary>
        /// Constant LICENSE_INCLUDED for LicenseModel
        /// </summary>
        public static readonly LicenseModel LICENSE_INCLUDED = new LicenseModel("LICENSE_INCLUDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseModel FindValue(string value)
        {
            return FindValue<LicenseModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedResourceStatus.
    /// </summary>
    public class ManagedResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ManagedResourceStatus
        /// </summary>
        public static readonly ManagedResourceStatus DISABLED = new ManagedResourceStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for ManagedResourceStatus
        /// </summary>
        public static readonly ManagedResourceStatus DISABLING = new ManagedResourceStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for ManagedResourceStatus
        /// </summary>
        public static readonly ManagedResourceStatus ENABLED = new ManagedResourceStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for ManagedResourceStatus
        /// </summary>
        public static readonly ManagedResourceStatus ENABLING = new ManagedResourceStatus("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedResourceStatus FindValue(string value)
        {
            return FindValue<ManagedResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonthName.
    /// </summary>
    public class MonthName : ConstantClass
    {

        /// <summary>
        /// Constant APRIL for MonthName
        /// </summary>
        public static readonly MonthName APRIL = new MonthName("APRIL");
        /// <summary>
        /// Constant AUGUST for MonthName
        /// </summary>
        public static readonly MonthName AUGUST = new MonthName("AUGUST");
        /// <summary>
        /// Constant DECEMBER for MonthName
        /// </summary>
        public static readonly MonthName DECEMBER = new MonthName("DECEMBER");
        /// <summary>
        /// Constant FEBRUARY for MonthName
        /// </summary>
        public static readonly MonthName FEBRUARY = new MonthName("FEBRUARY");
        /// <summary>
        /// Constant JANUARY for MonthName
        /// </summary>
        public static readonly MonthName JANUARY = new MonthName("JANUARY");
        /// <summary>
        /// Constant JULY for MonthName
        /// </summary>
        public static readonly MonthName JULY = new MonthName("JULY");
        /// <summary>
        /// Constant JUNE for MonthName
        /// </summary>
        public static readonly MonthName JUNE = new MonthName("JUNE");
        /// <summary>
        /// Constant MARCH for MonthName
        /// </summary>
        public static readonly MonthName MARCH = new MonthName("MARCH");
        /// <summary>
        /// Constant MAY for MonthName
        /// </summary>
        public static readonly MonthName MAY = new MonthName("MAY");
        /// <summary>
        /// Constant NOVEMBER for MonthName
        /// </summary>
        public static readonly MonthName NOVEMBER = new MonthName("NOVEMBER");
        /// <summary>
        /// Constant OCTOBER for MonthName
        /// </summary>
        public static readonly MonthName OCTOBER = new MonthName("OCTOBER");
        /// <summary>
        /// Constant SEPTEMBER for MonthName
        /// </summary>
        public static readonly MonthName SEPTEMBER = new MonthName("SEPTEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonthName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonthName FindValue(string value)
        {
            return FindValue<MonthName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonthName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Objective.
    /// </summary>
    public class Objective : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for Objective
        /// </summary>
        public static readonly Objective AUTO = new Objective("AUTO");
        /// <summary>
        /// Constant BALANCED for Objective
        /// </summary>
        public static readonly Objective BALANCED = new Objective("BALANCED");
        /// <summary>
        /// Constant BASIC for Objective
        /// </summary>
        public static readonly Objective BASIC = new Objective("BASIC");
        /// <summary>
        /// Constant HIGH_THROUGHPUT for Objective
        /// </summary>
        public static readonly Objective HIGH_THROUGHPUT = new Objective("HIGH_THROUGHPUT");
        /// <summary>
        /// Constant LOW_LATENCY for Objective
        /// </summary>
        public static readonly Objective LOW_LATENCY = new Objective("LOW_LATENCY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Objective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Objective FindValue(string value)
        {
            return FindValue<Objective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Objective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OciOnboardingStatus.
    /// </summary>
    public class OciOnboardingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus ACTIVATING = new OciOnboardingStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus ACTIVE = new OciOnboardingStatus("ACTIVE");
        /// <summary>
        /// Constant ACTIVE_IN_HOME_REGION for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus ACTIVE_IN_HOME_REGION = new OciOnboardingStatus("ACTIVE_IN_HOME_REGION");
        /// <summary>
        /// Constant ACTIVE_LIMITED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus ACTIVE_LIMITED = new OciOnboardingStatus("ACTIVE_LIMITED");
        /// <summary>
        /// Constant CANCELED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus CANCELED = new OciOnboardingStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus FAILED = new OciOnboardingStatus("FAILED");
        /// <summary>
        /// Constant NOT_STARTED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus NOT_STARTED = new OciOnboardingStatus("NOT_STARTED");
        /// <summary>
        /// Constant PENDING_CUSTOMER_ACTION for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus PENDING_CUSTOMER_ACTION = new OciOnboardingStatus("PENDING_CUSTOMER_ACTION");
        /// <summary>
        /// Constant PENDING_INITIALIZATION for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus PENDING_INITIALIZATION = new OciOnboardingStatus("PENDING_INITIALIZATION");
        /// <summary>
        /// Constant PENDING_LINK_GENERATION for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus PENDING_LINK_GENERATION = new OciOnboardingStatus("PENDING_LINK_GENERATION");
        /// <summary>
        /// Constant PUBLIC_OFFER_UNSUPPORTED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus PUBLIC_OFFER_UNSUPPORTED = new OciOnboardingStatus("PUBLIC_OFFER_UNSUPPORTED");
        /// <summary>
        /// Constant SUSPENDED for OciOnboardingStatus
        /// </summary>
        public static readonly OciOnboardingStatus SUSPENDED = new OciOnboardingStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OciOnboardingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OciOnboardingStatus FindValue(string value)
        {
            return FindValue<OciOnboardingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OciOnboardingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchingModeType.
    /// </summary>
    public class PatchingModeType : ConstantClass
    {

        /// <summary>
        /// Constant NONROLLING for PatchingModeType
        /// </summary>
        public static readonly PatchingModeType NONROLLING = new PatchingModeType("NONROLLING");
        /// <summary>
        /// Constant ROLLING for PatchingModeType
        /// </summary>
        public static readonly PatchingModeType ROLLING = new PatchingModeType("ROLLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchingModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchingModeType FindValue(string value)
        {
            return FindValue<PatchingModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchingModeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreferenceType.
    /// </summary>
    public class PreferenceType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_PREFERENCE for PreferenceType
        /// </summary>
        public static readonly PreferenceType CUSTOM_PREFERENCE = new PreferenceType("CUSTOM_PREFERENCE");
        /// <summary>
        /// Constant NO_PREFERENCE for PreferenceType
        /// </summary>
        public static readonly PreferenceType NO_PREFERENCE = new PreferenceType("NO_PREFERENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreferenceType FindValue(string value)
        {
            return FindValue<PreferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus AVAILABLE = new ResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus FAILED = new ResourceStatus("FAILED");
        /// <summary>
        /// Constant MAINTENANCE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus MAINTENANCE_IN_PROGRESS = new ResourceStatus("MAINTENANCE_IN_PROGRESS");
        /// <summary>
        /// Constant PROVISIONING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus PROVISIONING = new ResourceStatus("PROVISIONING");
        /// <summary>
        /// Constant TERMINATED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus TERMINATED = new ResourceStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus TERMINATING = new ResourceStatus("TERMINATING");
        /// <summary>
        /// Constant UPDATING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATING = new ResourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShapeType.
    /// </summary>
    public class ShapeType : ConstantClass
    {

        /// <summary>
        /// Constant AMD for ShapeType
        /// </summary>
        public static readonly ShapeType AMD = new ShapeType("AMD");
        /// <summary>
        /// Constant AMPERE_FLEX_A1 for ShapeType
        /// </summary>
        public static readonly ShapeType AMPERE_FLEX_A1 = new ShapeType("AMPERE_FLEX_A1");
        /// <summary>
        /// Constant INTEL for ShapeType
        /// </summary>
        public static readonly ShapeType INTEL = new ShapeType("INTEL");
        /// <summary>
        /// Constant INTEL_FLEX_X9 for ShapeType
        /// </summary>
        public static readonly ShapeType INTEL_FLEX_X9 = new ShapeType("INTEL_FLEX_X9");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShapeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShapeType FindValue(string value)
        {
            return FindValue<ShapeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShapeType(string value)
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


    /// <summary>
    /// Constants used for properties of type VpcEndpointType.
    /// </summary>
    public class VpcEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant SERVICENETWORK for VpcEndpointType
        /// </summary>
        public static readonly VpcEndpointType SERVICENETWORK = new VpcEndpointType("SERVICENETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcEndpointType FindValue(string value)
        {
            return FindValue<VpcEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcEndpointType(string value)
        {
            return FindValue(value);
        }
    }

}
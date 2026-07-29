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
    /// Constants used for properties of type AdminPasswordSource.
    /// </summary>
    public class AdminPasswordSource : ConstantClass
    {

        /// <summary>
        /// Constant API_REQUEST_PARAMETER for AdminPasswordSource
        /// </summary>
        public static readonly AdminPasswordSource API_REQUEST_PARAMETER = new AdminPasswordSource("API_REQUEST_PARAMETER");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_AWS_SECRET for AdminPasswordSource
        /// </summary>
        public static readonly AdminPasswordSource CUSTOMER_MANAGED_AWS_SECRET = new AdminPasswordSource("CUSTOMER_MANAGED_AWS_SECRET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminPasswordSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminPasswordSource FindValue(string value)
        {
            return FindValue<AdminPasswordSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminPasswordSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutonomousDatabaseBackupStatus.
    /// </summary>
    public class AutonomousDatabaseBackupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AutonomousDatabaseBackupStatus
        /// </summary>
        public static readonly AutonomousDatabaseBackupStatus ACTIVE = new AutonomousDatabaseBackupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for AutonomousDatabaseBackupStatus
        /// </summary>
        public static readonly AutonomousDatabaseBackupStatus CREATING = new AutonomousDatabaseBackupStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AutonomousDatabaseBackupStatus
        /// </summary>
        public static readonly AutonomousDatabaseBackupStatus DELETING = new AutonomousDatabaseBackupStatus("DELETING");
        /// <summary>
        /// Constant FAILED for AutonomousDatabaseBackupStatus
        /// </summary>
        public static readonly AutonomousDatabaseBackupStatus FAILED = new AutonomousDatabaseBackupStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for AutonomousDatabaseBackupStatus
        /// </summary>
        public static readonly AutonomousDatabaseBackupStatus UPDATING = new AutonomousDatabaseBackupStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutonomousDatabaseBackupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutonomousDatabaseBackupStatus FindValue(string value)
        {
            return FindValue<AutonomousDatabaseBackupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutonomousDatabaseBackupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutonomousDatabaseBackupType.
    /// </summary>
    public class AutonomousDatabaseBackupType : ConstantClass
    {

        /// <summary>
        /// Constant CUMULATIVE_INCREMENTAL for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType CUMULATIVE_INCREMENTAL = new AutonomousDatabaseBackupType("CUMULATIVE_INCREMENTAL");
        /// <summary>
        /// Constant FULL for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType FULL = new AutonomousDatabaseBackupType("FULL");
        /// <summary>
        /// Constant INCREMENTAL for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType INCREMENTAL = new AutonomousDatabaseBackupType("INCREMENTAL");
        /// <summary>
        /// Constant LONGTERM for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType LONGTERM = new AutonomousDatabaseBackupType("LONGTERM");
        /// <summary>
        /// Constant ROLL_FORWARD_IMAGE_COPY for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType ROLL_FORWARD_IMAGE_COPY = new AutonomousDatabaseBackupType("ROLL_FORWARD_IMAGE_COPY");
        /// <summary>
        /// Constant VIRTUAL_FULL for AutonomousDatabaseBackupType
        /// </summary>
        public static readonly AutonomousDatabaseBackupType VIRTUAL_FULL = new AutonomousDatabaseBackupType("VIRTUAL_FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutonomousDatabaseBackupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutonomousDatabaseBackupType FindValue(string value)
        {
            return FindValue<AutonomousDatabaseBackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutonomousDatabaseBackupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutonomousDatabaseResourceStatus.
    /// </summary>
    public class AutonomousDatabaseResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus AVAILABLE = new AutonomousDatabaseResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant AVAILABLE_NEEDS_ATTENTION for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus AVAILABLE_NEEDS_ATTENTION = new AutonomousDatabaseResourceStatus("AVAILABLE_NEEDS_ATTENTION");
        /// <summary>
        /// Constant BACKUP_IN_PROGRESS for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus BACKUP_IN_PROGRESS = new AutonomousDatabaseResourceStatus("BACKUP_IN_PROGRESS");
        /// <summary>
        /// Constant FAILED for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus FAILED = new AutonomousDatabaseResourceStatus("FAILED");
        /// <summary>
        /// Constant INACCESSIBLE for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus INACCESSIBLE = new AutonomousDatabaseResourceStatus("INACCESSIBLE");
        /// <summary>
        /// Constant MAINTENANCE_IN_PROGRESS for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus MAINTENANCE_IN_PROGRESS = new AutonomousDatabaseResourceStatus("MAINTENANCE_IN_PROGRESS");
        /// <summary>
        /// Constant PROVISIONING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus PROVISIONING = new AutonomousDatabaseResourceStatus("PROVISIONING");
        /// <summary>
        /// Constant RECREATING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus RECREATING = new AutonomousDatabaseResourceStatus("RECREATING");
        /// <summary>
        /// Constant RESTARTING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus RESTARTING = new AutonomousDatabaseResourceStatus("RESTARTING");
        /// <summary>
        /// Constant RESTORE_FAILED for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus RESTORE_FAILED = new AutonomousDatabaseResourceStatus("RESTORE_FAILED");
        /// <summary>
        /// Constant RESTORE_IN_PROGRESS for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus RESTORE_IN_PROGRESS = new AutonomousDatabaseResourceStatus("RESTORE_IN_PROGRESS");
        /// <summary>
        /// Constant ROLE_CHANGE_IN_PROGRESS for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus ROLE_CHANGE_IN_PROGRESS = new AutonomousDatabaseResourceStatus("ROLE_CHANGE_IN_PROGRESS");
        /// <summary>
        /// Constant SCALE_IN_PROGRESS for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus SCALE_IN_PROGRESS = new AutonomousDatabaseResourceStatus("SCALE_IN_PROGRESS");
        /// <summary>
        /// Constant STANDBY for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus STANDBY = new AutonomousDatabaseResourceStatus("STANDBY");
        /// <summary>
        /// Constant STARTING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus STARTING = new AutonomousDatabaseResourceStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus STOPPED = new AutonomousDatabaseResourceStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus STOPPING = new AutonomousDatabaseResourceStatus("STOPPING");
        /// <summary>
        /// Constant TERMINATED for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus TERMINATED = new AutonomousDatabaseResourceStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus TERMINATING = new AutonomousDatabaseResourceStatus("TERMINATING");
        /// <summary>
        /// Constant UNAVAILABLE for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus UNAVAILABLE = new AutonomousDatabaseResourceStatus("UNAVAILABLE");
        /// <summary>
        /// Constant UPDATING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus UPDATING = new AutonomousDatabaseResourceStatus("UPDATING");
        /// <summary>
        /// Constant UPGRADING for AutonomousDatabaseResourceStatus
        /// </summary>
        public static readonly AutonomousDatabaseResourceStatus UPGRADING = new AutonomousDatabaseResourceStatus("UPGRADING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutonomousDatabaseResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutonomousDatabaseResourceStatus FindValue(string value)
        {
            return FindValue<AutonomousDatabaseResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutonomousDatabaseResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutonomousDatabaseWalletStatus.
    /// </summary>
    public class AutonomousDatabaseWalletStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AutonomousDatabaseWalletStatus
        /// </summary>
        public static readonly AutonomousDatabaseWalletStatus ACTIVE = new AutonomousDatabaseWalletStatus("ACTIVE");
        /// <summary>
        /// Constant UPDATING for AutonomousDatabaseWalletStatus
        /// </summary>
        public static readonly AutonomousDatabaseWalletStatus UPDATING = new AutonomousDatabaseWalletStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutonomousDatabaseWalletStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutonomousDatabaseWalletStatus FindValue(string value)
        {
            return FindValue<AutonomousDatabaseWalletStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutonomousDatabaseWalletStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutonomousMaintenanceScheduleType.
    /// </summary>
    public class AutonomousMaintenanceScheduleType : ConstantClass
    {

        /// <summary>
        /// Constant EARLY for AutonomousMaintenanceScheduleType
        /// </summary>
        public static readonly AutonomousMaintenanceScheduleType EARLY = new AutonomousMaintenanceScheduleType("EARLY");
        /// <summary>
        /// Constant REGULAR for AutonomousMaintenanceScheduleType
        /// </summary>
        public static readonly AutonomousMaintenanceScheduleType REGULAR = new AutonomousMaintenanceScheduleType("REGULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutonomousMaintenanceScheduleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutonomousMaintenanceScheduleType FindValue(string value)
        {
            return FindValue<AutonomousMaintenanceScheduleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutonomousMaintenanceScheduleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CharacterSetType.
    /// </summary>
    public class CharacterSetType : ConstantClass
    {

        /// <summary>
        /// Constant DATABASE for CharacterSetType
        /// </summary>
        public static readonly CharacterSetType DATABASE = new CharacterSetType("DATABASE");
        /// <summary>
        /// Constant NATIONAL for CharacterSetType
        /// </summary>
        public static readonly CharacterSetType NATIONAL = new CharacterSetType("NATIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CharacterSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CharacterSetType FindValue(string value)
        {
            return FindValue<CharacterSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CharacterSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloneType.
    /// </summary>
    public class CloneType : ConstantClass
    {

        /// <summary>
        /// Constant FULL for CloneType
        /// </summary>
        public static readonly CloneType FULL = new CloneType("FULL");
        /// <summary>
        /// Constant METADATA for CloneType
        /// </summary>
        public static readonly CloneType METADATA = new CloneType("METADATA");
        /// <summary>
        /// Constant PARTIAL for CloneType
        /// </summary>
        public static readonly CloneType PARTIAL = new CloneType("PARTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloneType FindValue(string value)
        {
            return FindValue<CloneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloneType(string value)
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
    /// Constants used for properties of type DatabaseEdition.
    /// </summary>
    public class DatabaseEdition : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE_EDITION for DatabaseEdition
        /// </summary>
        public static readonly DatabaseEdition ENTERPRISE_EDITION = new DatabaseEdition("ENTERPRISE_EDITION");
        /// <summary>
        /// Constant STANDARD_EDITION for DatabaseEdition
        /// </summary>
        public static readonly DatabaseEdition STANDARD_EDITION = new DatabaseEdition("STANDARD_EDITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseEdition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseEdition FindValue(string value)
        {
            return FindValue<DatabaseEdition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseEdition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseManagementStatus.
    /// </summary>
    public class DatabaseManagementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLING for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus DISABLING = new DatabaseManagementStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus ENABLED = new DatabaseManagementStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus ENABLING = new DatabaseManagementStatus("ENABLING");
        /// <summary>
        /// Constant FAILED_DISABLING for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus FAILED_DISABLING = new DatabaseManagementStatus("FAILED_DISABLING");
        /// <summary>
        /// Constant FAILED_ENABLING for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus FAILED_ENABLING = new DatabaseManagementStatus("FAILED_ENABLING");
        /// <summary>
        /// Constant NOT_ENABLED for DatabaseManagementStatus
        /// </summary>
        public static readonly DatabaseManagementStatus NOT_ENABLED = new DatabaseManagementStatus("NOT_ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseManagementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseManagementStatus FindValue(string value)
        {
            return FindValue<DatabaseManagementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseManagementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseType.
    /// </summary>
    public class DatabaseType : ConstantClass
    {

        /// <summary>
        /// Constant CLONE for DatabaseType
        /// </summary>
        public static readonly DatabaseType CLONE = new DatabaseType("CLONE");
        /// <summary>
        /// Constant REGULAR for DatabaseType
        /// </summary>
        public static readonly DatabaseType REGULAR = new DatabaseType("REGULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseType FindValue(string value)
        {
            return FindValue<DatabaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataGuardRole.
    /// </summary>
    public class DataGuardRole : ConstantClass
    {

        /// <summary>
        /// Constant BACKUP_COPY for DataGuardRole
        /// </summary>
        public static readonly DataGuardRole BACKUP_COPY = new DataGuardRole("BACKUP_COPY");
        /// <summary>
        /// Constant DISABLED_STANDBY for DataGuardRole
        /// </summary>
        public static readonly DataGuardRole DISABLED_STANDBY = new DataGuardRole("DISABLED_STANDBY");
        /// <summary>
        /// Constant PRIMARY for DataGuardRole
        /// </summary>
        public static readonly DataGuardRole PRIMARY = new DataGuardRole("PRIMARY");
        /// <summary>
        /// Constant SNAPSHOT_STANDBY for DataGuardRole
        /// </summary>
        public static readonly DataGuardRole SNAPSHOT_STANDBY = new DataGuardRole("SNAPSHOT_STANDBY");
        /// <summary>
        /// Constant STANDBY for DataGuardRole
        /// </summary>
        public static readonly DataGuardRole STANDBY = new DataGuardRole("STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataGuardRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataGuardRole FindValue(string value)
        {
            return FindValue<DataGuardRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataGuardRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSafeStatus.
    /// </summary>
    public class DataSafeStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEREGISTERING for DataSafeStatus
        /// </summary>
        public static readonly DataSafeStatus DEREGISTERING = new DataSafeStatus("DEREGISTERING");
        /// <summary>
        /// Constant FAILED for DataSafeStatus
        /// </summary>
        public static readonly DataSafeStatus FAILED = new DataSafeStatus("FAILED");
        /// <summary>
        /// Constant NOT_REGISTERED for DataSafeStatus
        /// </summary>
        public static readonly DataSafeStatus NOT_REGISTERED = new DataSafeStatus("NOT_REGISTERED");
        /// <summary>
        /// Constant REGISTERED for DataSafeStatus
        /// </summary>
        public static readonly DataSafeStatus REGISTERED = new DataSafeStatus("REGISTERED");
        /// <summary>
        /// Constant REGISTERING for DataSafeStatus
        /// </summary>
        public static readonly DataSafeStatus REGISTERING = new DataSafeStatus("REGISTERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSafeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSafeStatus FindValue(string value)
        {
            return FindValue<DataSafeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSafeStatus(string value)
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
    /// Constants used for properties of type DbWorkload.
    /// </summary>
    public class DbWorkload : ConstantClass
    {

        /// <summary>
        /// Constant AJD for DbWorkload
        /// </summary>
        public static readonly DbWorkload AJD = new DbWorkload("AJD");
        /// <summary>
        /// Constant APEX for DbWorkload
        /// </summary>
        public static readonly DbWorkload APEX = new DbWorkload("APEX");
        /// <summary>
        /// Constant LH for DbWorkload
        /// </summary>
        public static readonly DbWorkload LH = new DbWorkload("LH");
        /// <summary>
        /// Constant OLTP for DbWorkload
        /// </summary>
        public static readonly DbWorkload OLTP = new DbWorkload("OLTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DbWorkload(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DbWorkload FindValue(string value)
        {
            return FindValue<DbWorkload>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DbWorkload(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisasterRecoveryType.
    /// </summary>
    public class DisasterRecoveryType : ConstantClass
    {

        /// <summary>
        /// Constant ADG for DisasterRecoveryType
        /// </summary>
        public static readonly DisasterRecoveryType ADG = new DisasterRecoveryType("ADG");
        /// <summary>
        /// Constant BACKUP_BASED for DisasterRecoveryType
        /// </summary>
        public static readonly DisasterRecoveryType BACKUP_BASED = new DisasterRecoveryType("BACKUP_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisasterRecoveryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisasterRecoveryType FindValue(string value)
        {
            return FindValue<DisasterRecoveryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisasterRecoveryType(string value)
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
    /// Constants used for properties of type EncryptionKeyProvider.
    /// </summary>
    public class EncryptionKeyProvider : ConstantClass
    {

        /// <summary>
        /// Constant AWS_KMS for EncryptionKeyProvider
        /// </summary>
        public static readonly EncryptionKeyProvider AWS_KMS = new EncryptionKeyProvider("AWS_KMS");
        /// <summary>
        /// Constant OCI for EncryptionKeyProvider
        /// </summary>
        public static readonly EncryptionKeyProvider OCI = new EncryptionKeyProvider("OCI");
        /// <summary>
        /// Constant OKV for EncryptionKeyProvider
        /// </summary>
        public static readonly EncryptionKeyProvider OKV = new EncryptionKeyProvider("OKV");
        /// <summary>
        /// Constant ORACLE_MANAGED for EncryptionKeyProvider
        /// </summary>
        public static readonly EncryptionKeyProvider ORACLE_MANAGED = new EncryptionKeyProvider("ORACLE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionKeyProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionKeyProvider FindValue(string value)
        {
            return FindValue<EncryptionKeyProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionKeyProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionKeyProviderInput.
    /// </summary>
    public class EncryptionKeyProviderInput : ConstantClass
    {

        /// <summary>
        /// Constant AWS_KMS for EncryptionKeyProviderInput
        /// </summary>
        public static readonly EncryptionKeyProviderInput AWS_KMS = new EncryptionKeyProviderInput("AWS_KMS");
        /// <summary>
        /// Constant ORACLE_MANAGED for EncryptionKeyProviderInput
        /// </summary>
        public static readonly EncryptionKeyProviderInput ORACLE_MANAGED = new EncryptionKeyProviderInput("ORACLE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionKeyProviderInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionKeyProviderInput FindValue(string value)
        {
            return FindValue<EncryptionKeyProviderInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionKeyProviderInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalIdType.
    /// </summary>
    public class ExternalIdType : ConstantClass
    {

        /// <summary>
        /// Constant Compartment_ocid for ExternalIdType
        /// </summary>
        public static readonly ExternalIdType Compartment_ocid = new ExternalIdType("compartment_ocid");
        /// <summary>
        /// Constant Database_ocid for ExternalIdType
        /// </summary>
        public static readonly ExternalIdType Database_ocid = new ExternalIdType("database_ocid");
        /// <summary>
        /// Constant Tenant_ocid for ExternalIdType
        /// </summary>
        public static readonly ExternalIdType Tenant_ocid = new ExternalIdType("tenant_ocid");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalIdType FindValue(string value)
        {
            return FindValue<ExternalIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IamRoleStatus.
    /// </summary>
    public class IamRoleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATING for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus ASSOCIATING = new IamRoleStatus("ASSOCIATING");
        /// <summary>
        /// Constant CONNECTED for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus CONNECTED = new IamRoleStatus("CONNECTED");
        /// <summary>
        /// Constant DISASSOCIATING for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus DISASSOCIATING = new IamRoleStatus("DISASSOCIATING");
        /// <summary>
        /// Constant DISCONNECTED for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus DISCONNECTED = new IamRoleStatus("DISCONNECTED");
        /// <summary>
        /// Constant FAILED for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus FAILED = new IamRoleStatus("FAILED");
        /// <summary>
        /// Constant PARTIALLY_CONNECTED for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus PARTIALLY_CONNECTED = new IamRoleStatus("PARTIALLY_CONNECTED");
        /// <summary>
        /// Constant UNKNOWN for IamRoleStatus
        /// </summary>
        public static readonly IamRoleStatus UNKNOWN = new IamRoleStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IamRoleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IamRoleStatus FindValue(string value)
        {
            return FindValue<IamRoleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IamRoleStatus(string value)
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
    /// Constants used for properties of type NetServicesArchitecture.
    /// </summary>
    public class NetServicesArchitecture : ConstantClass
    {

        /// <summary>
        /// Constant DEDICATED for NetServicesArchitecture
        /// </summary>
        public static readonly NetServicesArchitecture DEDICATED = new NetServicesArchitecture("DEDICATED");
        /// <summary>
        /// Constant SHARED for NetServicesArchitecture
        /// </summary>
        public static readonly NetServicesArchitecture SHARED = new NetServicesArchitecture("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetServicesArchitecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetServicesArchitecture FindValue(string value)
        {
            return FindValue<NetServicesArchitecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetServicesArchitecture(string value)
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
    /// Constants used for properties of type OciAwsIntegration.
    /// </summary>
    public class OciAwsIntegration : ConstantClass
    {

        /// <summary>
        /// Constant KmsTde for OciAwsIntegration
        /// </summary>
        public static readonly OciAwsIntegration KmsTde = new OciAwsIntegration("KmsTde");
        /// <summary>
        /// Constant SecretsManager for OciAwsIntegration
        /// </summary>
        public static readonly OciAwsIntegration SecretsManager = new OciAwsIntegration("SecretsManager");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OciAwsIntegration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OciAwsIntegration FindValue(string value)
        {
            return FindValue<OciAwsIntegration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OciAwsIntegration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OciIamRoleStatus.
    /// </summary>
    public class OciIamRoleStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for OciIamRoleStatus
        /// </summary>
        public static readonly OciIamRoleStatus AVAILABLE = new OciIamRoleStatus("AVAILABLE");
        /// <summary>
        /// Constant PROVISION_FAILED for OciIamRoleStatus
        /// </summary>
        public static readonly OciIamRoleStatus PROVISION_FAILED = new OciIamRoleStatus("PROVISION_FAILED");
        /// <summary>
        /// Constant PROVISIONING for OciIamRoleStatus
        /// </summary>
        public static readonly OciIamRoleStatus PROVISIONING = new OciIamRoleStatus("PROVISIONING");
        /// <summary>
        /// Constant TERMINATE_FAILED for OciIamRoleStatus
        /// </summary>
        public static readonly OciIamRoleStatus TERMINATE_FAILED = new OciIamRoleStatus("TERMINATE_FAILED");
        /// <summary>
        /// Constant TERMINATING for OciIamRoleStatus
        /// </summary>
        public static readonly OciIamRoleStatus TERMINATING = new OciIamRoleStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OciIamRoleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OciIamRoleStatus FindValue(string value)
        {
            return FindValue<OciIamRoleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OciIamRoleStatus(string value)
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
    /// Constants used for properties of type OpenMode.
    /// </summary>
    public class OpenMode : ConstantClass
    {

        /// <summary>
        /// Constant READ_ONLY for OpenMode
        /// </summary>
        public static readonly OpenMode READ_ONLY = new OpenMode("READ_ONLY");
        /// <summary>
        /// Constant READ_WRITE for OpenMode
        /// </summary>
        public static readonly OpenMode READ_WRITE = new OpenMode("READ_WRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenMode FindValue(string value)
        {
            return FindValue<OpenMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationsInsightsStatus.
    /// </summary>
    public class OperationsInsightsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLING for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus DISABLING = new OperationsInsightsStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus ENABLED = new OperationsInsightsStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus ENABLING = new OperationsInsightsStatus("ENABLING");
        /// <summary>
        /// Constant FAILED_DISABLING for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus FAILED_DISABLING = new OperationsInsightsStatus("FAILED_DISABLING");
        /// <summary>
        /// Constant FAILED_ENABLING for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus FAILED_ENABLING = new OperationsInsightsStatus("FAILED_ENABLING");
        /// <summary>
        /// Constant NOT_ENABLED for OperationsInsightsStatus
        /// </summary>
        public static readonly OperationsInsightsStatus NOT_ENABLED = new OperationsInsightsStatus("NOT_ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationsInsightsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationsInsightsStatus FindValue(string value)
        {
            return FindValue<OperationsInsightsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationsInsightsStatus(string value)
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
    /// Constants used for properties of type PermissionLevel.
    /// </summary>
    public class PermissionLevel : ConstantClass
    {

        /// <summary>
        /// Constant RESTRICTED for PermissionLevel
        /// </summary>
        public static readonly PermissionLevel RESTRICTED = new PermissionLevel("RESTRICTED");
        /// <summary>
        /// Constant UNRESTRICTED for PermissionLevel
        /// </summary>
        public static readonly PermissionLevel UNRESTRICTED = new PermissionLevel("UNRESTRICTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionLevel FindValue(string value)
        {
            return FindValue<PermissionLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionLevel(string value)
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
    /// Constants used for properties of type RefreshableMode.
    /// </summary>
    public class RefreshableMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for RefreshableMode
        /// </summary>
        public static readonly RefreshableMode AUTOMATIC = new RefreshableMode("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for RefreshableMode
        /// </summary>
        public static readonly RefreshableMode MANUAL = new RefreshableMode("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshableMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshableMode FindValue(string value)
        {
            return FindValue<RefreshableMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshableMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshableStatus.
    /// </summary>
    public class RefreshableStatus : ConstantClass
    {

        /// <summary>
        /// Constant NOT_REFRESHING for RefreshableStatus
        /// </summary>
        public static readonly RefreshableStatus NOT_REFRESHING = new RefreshableStatus("NOT_REFRESHING");
        /// <summary>
        /// Constant REFRESHING for RefreshableStatus
        /// </summary>
        public static readonly RefreshableStatus REFRESHING = new RefreshableStatus("REFRESHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshableStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshableStatus FindValue(string value)
        {
            return FindValue<RefreshableStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshableStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepeatCadence.
    /// </summary>
    public class RepeatCadence : ConstantClass
    {

        /// <summary>
        /// Constant MONTHLY for RepeatCadence
        /// </summary>
        public static readonly RepeatCadence MONTHLY = new RepeatCadence("MONTHLY");
        /// <summary>
        /// Constant ONE_TIME for RepeatCadence
        /// </summary>
        public static readonly RepeatCadence ONE_TIME = new RepeatCadence("ONE_TIME");
        /// <summary>
        /// Constant WEEKLY for RepeatCadence
        /// </summary>
        public static readonly RepeatCadence WEEKLY = new RepeatCadence("WEEKLY");
        /// <summary>
        /// Constant YEARLY for RepeatCadence
        /// </summary>
        public static readonly RepeatCadence YEARLY = new RepeatCadence("YEARLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepeatCadence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepeatCadence FindValue(string value)
        {
            return FindValue<RepeatCadence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepeatCadence(string value)
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
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant BACKUP_FROM_ID for SourceType
        /// </summary>
        public static readonly SourceType BACKUP_FROM_ID = new SourceType("BACKUP_FROM_ID");
        /// <summary>
        /// Constant BACKUP_FROM_TIMESTAMP for SourceType
        /// </summary>
        public static readonly SourceType BACKUP_FROM_TIMESTAMP = new SourceType("BACKUP_FROM_TIMESTAMP");
        /// <summary>
        /// Constant CLONE_TO_REFRESHABLE for SourceType
        /// </summary>
        public static readonly SourceType CLONE_TO_REFRESHABLE = new SourceType("CLONE_TO_REFRESHABLE");
        /// <summary>
        /// Constant CROSS_REGION_DATAGUARD for SourceType
        /// </summary>
        public static readonly SourceType CROSS_REGION_DATAGUARD = new SourceType("CROSS_REGION_DATAGUARD");
        /// <summary>
        /// Constant CROSS_REGION_DISASTER_RECOVERY for SourceType
        /// </summary>
        public static readonly SourceType CROSS_REGION_DISASTER_RECOVERY = new SourceType("CROSS_REGION_DISASTER_RECOVERY");
        /// <summary>
        /// Constant DATABASE for SourceType
        /// </summary>
        public static readonly SourceType DATABASE = new SourceType("DATABASE");
        /// <summary>
        /// Constant NONE for SourceType
        /// </summary>
        public static readonly SourceType NONE = new SourceType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandbyAllowlistedIpsSource.
    /// </summary>
    public class StandbyAllowlistedIpsSource : ConstantClass
    {

        /// <summary>
        /// Constant NOT_APPLICABLE for StandbyAllowlistedIpsSource
        /// </summary>
        public static readonly StandbyAllowlistedIpsSource NOT_APPLICABLE = new StandbyAllowlistedIpsSource("NOT_APPLICABLE");
        /// <summary>
        /// Constant PRIMARY for StandbyAllowlistedIpsSource
        /// </summary>
        public static readonly StandbyAllowlistedIpsSource PRIMARY = new StandbyAllowlistedIpsSource("PRIMARY");
        /// <summary>
        /// Constant SEPARATE for StandbyAllowlistedIpsSource
        /// </summary>
        public static readonly StandbyAllowlistedIpsSource SEPARATE = new StandbyAllowlistedIpsSource("SEPARATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandbyAllowlistedIpsSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandbyAllowlistedIpsSource FindValue(string value)
        {
            return FindValue<StandbyAllowlistedIpsSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandbyAllowlistedIpsSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportedAwsIntegration.
    /// </summary>
    public class SupportedAwsIntegration : ConstantClass
    {

        /// <summary>
        /// Constant KmsTde for SupportedAwsIntegration
        /// </summary>
        public static readonly SupportedAwsIntegration KmsTde = new SupportedAwsIntegration("KmsTde");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedAwsIntegration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedAwsIntegration FindValue(string value)
        {
            return FindValue<SupportedAwsIntegration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedAwsIntegration(string value)
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


    /// <summary>
    /// Constants used for properties of type WalletPasswordSource.
    /// </summary>
    public class WalletPasswordSource : ConstantClass
    {

        /// <summary>
        /// Constant API_REQUEST_PARAMETER for WalletPasswordSource
        /// </summary>
        public static readonly WalletPasswordSource API_REQUEST_PARAMETER = new WalletPasswordSource("API_REQUEST_PARAMETER");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_AWS_SECRET for WalletPasswordSource
        /// </summary>
        public static readonly WalletPasswordSource CUSTOMER_MANAGED_AWS_SECRET = new WalletPasswordSource("CUSTOMER_MANAGED_AWS_SECRET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WalletPasswordSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WalletPasswordSource FindValue(string value)
        {
            return FindValue<WalletPasswordSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WalletPasswordSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WalletType.
    /// </summary>
    public class WalletType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for WalletType
        /// </summary>
        public static readonly WalletType INSTANCE = new WalletType("INSTANCE");
        /// <summary>
        /// Constant REGIONAL for WalletType
        /// </summary>
        public static readonly WalletType REGIONAL = new WalletType("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WalletType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WalletType FindValue(string value)
        {
            return FindValue<WalletType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WalletType(string value)
        {
            return FindValue(value);
        }
    }

}
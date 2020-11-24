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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FSx
{

    /// <summary>
    /// Constants used for properties of type ActiveDirectoryErrorType.
    /// </summary>
    public class ActiveDirectoryErrorType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_NOT_FOUND for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType DOMAIN_NOT_FOUND = new ActiveDirectoryErrorType("DOMAIN_NOT_FOUND");
        /// <summary>
        /// Constant INCOMPATIBLE_DOMAIN_MODE for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType INCOMPATIBLE_DOMAIN_MODE = new ActiveDirectoryErrorType("INCOMPATIBLE_DOMAIN_MODE");
        /// <summary>
        /// Constant INVALID_DOMAIN_STAGE for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType INVALID_DOMAIN_STAGE = new ActiveDirectoryErrorType("INVALID_DOMAIN_STAGE");
        /// <summary>
        /// Constant WRONG_VPC for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType WRONG_VPC = new ActiveDirectoryErrorType("WRONG_VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActiveDirectoryErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActiveDirectoryErrorType FindValue(string value)
        {
            return FindValue<ActiveDirectoryErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActiveDirectoryErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdministrativeActionType.
    /// </summary>
    public class AdministrativeActionType : ConstantClass
    {

        /// <summary>
        /// Constant FILE_SYSTEM_ALIAS_ASSOCIATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType FILE_SYSTEM_ALIAS_ASSOCIATION = new AdministrativeActionType("FILE_SYSTEM_ALIAS_ASSOCIATION");
        /// <summary>
        /// Constant FILE_SYSTEM_ALIAS_DISASSOCIATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType FILE_SYSTEM_ALIAS_DISASSOCIATION = new AdministrativeActionType("FILE_SYSTEM_ALIAS_DISASSOCIATION");
        /// <summary>
        /// Constant FILE_SYSTEM_UPDATE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType FILE_SYSTEM_UPDATE = new AdministrativeActionType("FILE_SYSTEM_UPDATE");
        /// <summary>
        /// Constant STORAGE_OPTIMIZATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType STORAGE_OPTIMIZATION = new AdministrativeActionType("STORAGE_OPTIMIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdministrativeActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdministrativeActionType FindValue(string value)
        {
            return FindValue<AdministrativeActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdministrativeActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AliasLifecycle.
    /// </summary>
    public class AliasLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for AliasLifecycle
        /// </summary>
        public static readonly AliasLifecycle AVAILABLE = new AliasLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATE_FAILED for AliasLifecycle
        /// </summary>
        public static readonly AliasLifecycle CREATE_FAILED = new AliasLifecycle("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for AliasLifecycle
        /// </summary>
        public static readonly AliasLifecycle CREATING = new AliasLifecycle("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for AliasLifecycle
        /// </summary>
        public static readonly AliasLifecycle DELETE_FAILED = new AliasLifecycle("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for AliasLifecycle
        /// </summary>
        public static readonly AliasLifecycle DELETING = new AliasLifecycle("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AliasLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AliasLifecycle FindValue(string value)
        {
            return FindValue<AliasLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AliasLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoImportPolicyType.
    /// </summary>
    public class AutoImportPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant NEW for AutoImportPolicyType
        /// </summary>
        public static readonly AutoImportPolicyType NEW = new AutoImportPolicyType("NEW");
        /// <summary>
        /// Constant NEW_CHANGED for AutoImportPolicyType
        /// </summary>
        public static readonly AutoImportPolicyType NEW_CHANGED = new AutoImportPolicyType("NEW_CHANGED");
        /// <summary>
        /// Constant NONE for AutoImportPolicyType
        /// </summary>
        public static readonly AutoImportPolicyType NONE = new AutoImportPolicyType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoImportPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoImportPolicyType FindValue(string value)
        {
            return FindValue<AutoImportPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoImportPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupLifecycle.
    /// </summary>
    public class BackupLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle AVAILABLE = new BackupLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle CREATING = new BackupLifecycle("CREATING");
        /// <summary>
        /// Constant DELETED for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle DELETED = new BackupLifecycle("DELETED");
        /// <summary>
        /// Constant FAILED for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle FAILED = new BackupLifecycle("FAILED");
        /// <summary>
        /// Constant PENDING for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle PENDING = new BackupLifecycle("PENDING");
        /// <summary>
        /// Constant TRANSFERRING for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle TRANSFERRING = new BackupLifecycle("TRANSFERRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupLifecycle FindValue(string value)
        {
            return FindValue<BackupLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupType.
    /// </summary>
    public class BackupType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for BackupType
        /// </summary>
        public static readonly BackupType AUTOMATIC = new BackupType("AUTOMATIC");
        /// <summary>
        /// Constant AWS_BACKUP for BackupType
        /// </summary>
        public static readonly BackupType AWS_BACKUP = new BackupType("AWS_BACKUP");
        /// <summary>
        /// Constant USER_INITIATED for BackupType
        /// </summary>
        public static readonly BackupType USER_INITIATED = new BackupType("USER_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupType FindValue(string value)
        {
            return FindValue<BackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataRepositoryLifecycle.
    /// </summary>
    public class DataRepositoryLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle AVAILABLE = new DataRepositoryLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle CREATING = new DataRepositoryLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle DELETING = new DataRepositoryLifecycle("DELETING");
        /// <summary>
        /// Constant MISCONFIGURED for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle MISCONFIGURED = new DataRepositoryLifecycle("MISCONFIGURED");
        /// <summary>
        /// Constant UPDATING for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle UPDATING = new DataRepositoryLifecycle("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRepositoryLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRepositoryLifecycle FindValue(string value)
        {
            return FindValue<DataRepositoryLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRepositoryLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataRepositoryTaskFilterName.
    /// </summary>
    public class DataRepositoryTaskFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FileSystemId for DataRepositoryTaskFilterName
        /// </summary>
        public static readonly DataRepositoryTaskFilterName FileSystemId = new DataRepositoryTaskFilterName("file-system-id");
        /// <summary>
        /// Constant TaskLifecycle for DataRepositoryTaskFilterName
        /// </summary>
        public static readonly DataRepositoryTaskFilterName TaskLifecycle = new DataRepositoryTaskFilterName("task-lifecycle");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRepositoryTaskFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRepositoryTaskFilterName FindValue(string value)
        {
            return FindValue<DataRepositoryTaskFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRepositoryTaskFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataRepositoryTaskLifecycle.
    /// </summary>
    public class DataRepositoryTaskLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle CANCELED = new DataRepositoryTaskLifecycle("CANCELED");
        /// <summary>
        /// Constant CANCELING for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle CANCELING = new DataRepositoryTaskLifecycle("CANCELING");
        /// <summary>
        /// Constant EXECUTING for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle EXECUTING = new DataRepositoryTaskLifecycle("EXECUTING");
        /// <summary>
        /// Constant FAILED for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle FAILED = new DataRepositoryTaskLifecycle("FAILED");
        /// <summary>
        /// Constant PENDING for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle PENDING = new DataRepositoryTaskLifecycle("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for DataRepositoryTaskLifecycle
        /// </summary>
        public static readonly DataRepositoryTaskLifecycle SUCCEEDED = new DataRepositoryTaskLifecycle("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRepositoryTaskLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRepositoryTaskLifecycle FindValue(string value)
        {
            return FindValue<DataRepositoryTaskLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRepositoryTaskLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataRepositoryTaskType.
    /// </summary>
    public class DataRepositoryTaskType : ConstantClass
    {

        /// <summary>
        /// Constant EXPORT_TO_REPOSITORY for DataRepositoryTaskType
        /// </summary>
        public static readonly DataRepositoryTaskType EXPORT_TO_REPOSITORY = new DataRepositoryTaskType("EXPORT_TO_REPOSITORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRepositoryTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRepositoryTaskType FindValue(string value)
        {
            return FindValue<DataRepositoryTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRepositoryTaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DriveCacheType.
    /// </summary>
    public class DriveCacheType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for DriveCacheType
        /// </summary>
        public static readonly DriveCacheType NONE = new DriveCacheType("NONE");
        /// <summary>
        /// Constant READ for DriveCacheType
        /// </summary>
        public static readonly DriveCacheType READ = new DriveCacheType("READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DriveCacheType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DriveCacheType FindValue(string value)
        {
            return FindValue<DriveCacheType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DriveCacheType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemLifecycle.
    /// </summary>
    public class FileSystemLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle AVAILABLE = new FileSystemLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle CREATING = new FileSystemLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle DELETING = new FileSystemLifecycle("DELETING");
        /// <summary>
        /// Constant FAILED for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle FAILED = new FileSystemLifecycle("FAILED");
        /// <summary>
        /// Constant MISCONFIGURED for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle MISCONFIGURED = new FileSystemLifecycle("MISCONFIGURED");
        /// <summary>
        /// Constant UPDATING for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle UPDATING = new FileSystemLifecycle("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemLifecycle FindValue(string value)
        {
            return FindValue<FileSystemLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemMaintenanceOperation.
    /// </summary>
    public class FileSystemMaintenanceOperation : ConstantClass
    {

        /// <summary>
        /// Constant BACKING_UP for FileSystemMaintenanceOperation
        /// </summary>
        public static readonly FileSystemMaintenanceOperation BACKING_UP = new FileSystemMaintenanceOperation("BACKING_UP");
        /// <summary>
        /// Constant PATCHING for FileSystemMaintenanceOperation
        /// </summary>
        public static readonly FileSystemMaintenanceOperation PATCHING = new FileSystemMaintenanceOperation("PATCHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemMaintenanceOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemMaintenanceOperation FindValue(string value)
        {
            return FindValue<FileSystemMaintenanceOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemMaintenanceOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemType.
    /// </summary>
    public class FileSystemType : ConstantClass
    {

        /// <summary>
        /// Constant LUSTRE for FileSystemType
        /// </summary>
        public static readonly FileSystemType LUSTRE = new FileSystemType("LUSTRE");
        /// <summary>
        /// Constant WINDOWS for FileSystemType
        /// </summary>
        public static readonly FileSystemType WINDOWS = new FileSystemType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemType FindValue(string value)
        {
            return FindValue<FileSystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterName.
    /// </summary>
    public class FilterName : ConstantClass
    {

        /// <summary>
        /// Constant BackupType for FilterName
        /// </summary>
        public static readonly FilterName BackupType = new FilterName("backup-type");
        /// <summary>
        /// Constant FileSystemId for FilterName
        /// </summary>
        public static readonly FilterName FileSystemId = new FilterName("file-system-id");
        /// <summary>
        /// Constant FileSystemType for FilterName
        /// </summary>
        public static readonly FilterName FileSystemType = new FilterName("file-system-type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterName FindValue(string value)
        {
            return FindValue<FilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LustreDeploymentType.
    /// </summary>
    public class LustreDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant PERSISTENT_1 for LustreDeploymentType
        /// </summary>
        public static readonly LustreDeploymentType PERSISTENT_1 = new LustreDeploymentType("PERSISTENT_1");
        /// <summary>
        /// Constant SCRATCH_1 for LustreDeploymentType
        /// </summary>
        public static readonly LustreDeploymentType SCRATCH_1 = new LustreDeploymentType("SCRATCH_1");
        /// <summary>
        /// Constant SCRATCH_2 for LustreDeploymentType
        /// </summary>
        public static readonly LustreDeploymentType SCRATCH_2 = new LustreDeploymentType("SCRATCH_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LustreDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LustreDeploymentType FindValue(string value)
        {
            return FindValue<LustreDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LustreDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormat.
    /// </summary>
    public class ReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant REPORT_CSV_20191124 for ReportFormat
        /// </summary>
        public static readonly ReportFormat REPORT_CSV_20191124 = new ReportFormat("REPORT_CSV_20191124");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormat FindValue(string value)
        {
            return FindValue<ReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportScope.
    /// </summary>
    public class ReportScope : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_FILES_ONLY for ReportScope
        /// </summary>
        public static readonly ReportScope FAILED_FILES_ONLY = new ReportScope("FAILED_FILES_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportScope FindValue(string value)
        {
            return FindValue<ReportScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceLimit.
    /// </summary>
    public class ServiceLimit : ConstantClass
    {

        /// <summary>
        /// Constant FILE_SYSTEM_COUNT for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit FILE_SYSTEM_COUNT = new ServiceLimit("FILE_SYSTEM_COUNT");
        /// <summary>
        /// Constant TOTAL_STORAGE for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_STORAGE = new ServiceLimit("TOTAL_STORAGE");
        /// <summary>
        /// Constant TOTAL_THROUGHPUT_CAPACITY for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_THROUGHPUT_CAPACITY = new ServiceLimit("TOTAL_THROUGHPUT_CAPACITY");
        /// <summary>
        /// Constant TOTAL_USER_INITIATED_BACKUPS for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_USER_INITIATED_BACKUPS = new ServiceLimit("TOTAL_USER_INITIATED_BACKUPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceLimit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceLimit FindValue(string value)
        {
            return FindValue<ServiceLimit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceLimit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for Status
        /// </summary>
        public static readonly Status COMPLETED = new Status("COMPLETED");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");
        /// <summary>
        /// Constant UPDATED_OPTIMIZING for Status
        /// </summary>
        public static readonly Status UPDATED_OPTIMIZING = new Status("UPDATED_OPTIMIZING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageType.
    /// </summary>
    public class StorageType : ConstantClass
    {

        /// <summary>
        /// Constant HDD for StorageType
        /// </summary>
        public static readonly StorageType HDD = new StorageType("HDD");
        /// <summary>
        /// Constant SSD for StorageType
        /// </summary>
        public static readonly StorageType SSD = new StorageType("SSD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageType FindValue(string value)
        {
            return FindValue<StorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WindowsDeploymentType.
    /// </summary>
    public class WindowsDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_AZ_1 for WindowsDeploymentType
        /// </summary>
        public static readonly WindowsDeploymentType MULTI_AZ_1 = new WindowsDeploymentType("MULTI_AZ_1");
        /// <summary>
        /// Constant SINGLE_AZ_1 for WindowsDeploymentType
        /// </summary>
        public static readonly WindowsDeploymentType SINGLE_AZ_1 = new WindowsDeploymentType("SINGLE_AZ_1");
        /// <summary>
        /// Constant SINGLE_AZ_2 for WindowsDeploymentType
        /// </summary>
        public static readonly WindowsDeploymentType SINGLE_AZ_2 = new WindowsDeploymentType("SINGLE_AZ_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WindowsDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WindowsDeploymentType FindValue(string value)
        {
            return FindValue<WindowsDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WindowsDeploymentType(string value)
        {
            return FindValue(value);
        }
    }

}
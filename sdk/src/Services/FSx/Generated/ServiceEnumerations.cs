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
        /// Constant RELEASE_NFS_V3_LOCKS for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType RELEASE_NFS_V3_LOCKS = new AdministrativeActionType("RELEASE_NFS_V3_LOCKS");
        /// <summary>
        /// Constant SNAPSHOT_UPDATE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType SNAPSHOT_UPDATE = new AdministrativeActionType("SNAPSHOT_UPDATE");
        /// <summary>
        /// Constant STORAGE_OPTIMIZATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType STORAGE_OPTIMIZATION = new AdministrativeActionType("STORAGE_OPTIMIZATION");
        /// <summary>
        /// Constant VOLUME_RESTORE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_RESTORE = new AdministrativeActionType("VOLUME_RESTORE");
        /// <summary>
        /// Constant VOLUME_UPDATE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_UPDATE = new AdministrativeActionType("VOLUME_UPDATE");

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
        /// Constant NEW_CHANGED_DELETED for AutoImportPolicyType
        /// </summary>
        public static readonly AutoImportPolicyType NEW_CHANGED_DELETED = new AutoImportPolicyType("NEW_CHANGED_DELETED");
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
        /// Constant COPYING for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle COPYING = new BackupLifecycle("COPYING");
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
    /// Constants used for properties of type DataCompressionType.
    /// </summary>
    public class DataCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant LZ4 for DataCompressionType
        /// </summary>
        public static readonly DataCompressionType LZ4 = new DataCompressionType("LZ4");
        /// <summary>
        /// Constant NONE for DataCompressionType
        /// </summary>
        public static readonly DataCompressionType NONE = new DataCompressionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataCompressionType FindValue(string value)
        {
            return FindValue<DataCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataCompressionType(string value)
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
        /// Constant FAILED for DataRepositoryLifecycle
        /// </summary>
        public static readonly DataRepositoryLifecycle FAILED = new DataRepositoryLifecycle("FAILED");
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
        /// Constant DataRepositoryAssociationId for DataRepositoryTaskFilterName
        /// </summary>
        public static readonly DataRepositoryTaskFilterName DataRepositoryAssociationId = new DataRepositoryTaskFilterName("data-repository-association-id");
        /// <summary>
        /// Constant FileCacheId for DataRepositoryTaskFilterName
        /// </summary>
        public static readonly DataRepositoryTaskFilterName FileCacheId = new DataRepositoryTaskFilterName("file-cache-id");
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
        /// Constant AUTO_RELEASE_DATA for DataRepositoryTaskType
        /// </summary>
        public static readonly DataRepositoryTaskType AUTO_RELEASE_DATA = new DataRepositoryTaskType("AUTO_RELEASE_DATA");
        /// <summary>
        /// Constant EXPORT_TO_REPOSITORY for DataRepositoryTaskType
        /// </summary>
        public static readonly DataRepositoryTaskType EXPORT_TO_REPOSITORY = new DataRepositoryTaskType("EXPORT_TO_REPOSITORY");
        /// <summary>
        /// Constant IMPORT_METADATA_FROM_REPOSITORY for DataRepositoryTaskType
        /// </summary>
        public static readonly DataRepositoryTaskType IMPORT_METADATA_FROM_REPOSITORY = new DataRepositoryTaskType("IMPORT_METADATA_FROM_REPOSITORY");
        /// <summary>
        /// Constant RELEASE_DATA_FROM_FILESYSTEM for DataRepositoryTaskType
        /// </summary>
        public static readonly DataRepositoryTaskType RELEASE_DATA_FROM_FILESYSTEM = new DataRepositoryTaskType("RELEASE_DATA_FROM_FILESYSTEM");

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
    /// Constants used for properties of type DeleteFileSystemOpenZFSOption.
    /// </summary>
    public class DeleteFileSystemOpenZFSOption : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_CHILD_VOLUMES_AND_SNAPSHOTS for DeleteFileSystemOpenZFSOption
        /// </summary>
        public static readonly DeleteFileSystemOpenZFSOption DELETE_CHILD_VOLUMES_AND_SNAPSHOTS = new DeleteFileSystemOpenZFSOption("DELETE_CHILD_VOLUMES_AND_SNAPSHOTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteFileSystemOpenZFSOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteFileSystemOpenZFSOption FindValue(string value)
        {
            return FindValue<DeleteFileSystemOpenZFSOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteFileSystemOpenZFSOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteOpenZFSVolumeOption.
    /// </summary>
    public class DeleteOpenZFSVolumeOption : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_CHILD_VOLUMES_AND_SNAPSHOTS for DeleteOpenZFSVolumeOption
        /// </summary>
        public static readonly DeleteOpenZFSVolumeOption DELETE_CHILD_VOLUMES_AND_SNAPSHOTS = new DeleteOpenZFSVolumeOption("DELETE_CHILD_VOLUMES_AND_SNAPSHOTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteOpenZFSVolumeOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteOpenZFSVolumeOption FindValue(string value)
        {
            return FindValue<DeleteOpenZFSVolumeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteOpenZFSVolumeOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiskIopsConfigurationMode.
    /// </summary>
    public class DiskIopsConfigurationMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for DiskIopsConfigurationMode
        /// </summary>
        public static readonly DiskIopsConfigurationMode AUTOMATIC = new DiskIopsConfigurationMode("AUTOMATIC");
        /// <summary>
        /// Constant USER_PROVISIONED for DiskIopsConfigurationMode
        /// </summary>
        public static readonly DiskIopsConfigurationMode USER_PROVISIONED = new DiskIopsConfigurationMode("USER_PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiskIopsConfigurationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskIopsConfigurationMode FindValue(string value)
        {
            return FindValue<DiskIopsConfigurationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiskIopsConfigurationMode(string value)
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
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant CHANGED for EventType
        /// </summary>
        public static readonly EventType CHANGED = new EventType("CHANGED");
        /// <summary>
        /// Constant DELETED for EventType
        /// </summary>
        public static readonly EventType DELETED = new EventType("DELETED");
        /// <summary>
        /// Constant NEW for EventType
        /// </summary>
        public static readonly EventType NEW = new EventType("NEW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileCacheLifecycle.
    /// </summary>
    public class FileCacheLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for FileCacheLifecycle
        /// </summary>
        public static readonly FileCacheLifecycle AVAILABLE = new FileCacheLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for FileCacheLifecycle
        /// </summary>
        public static readonly FileCacheLifecycle CREATING = new FileCacheLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for FileCacheLifecycle
        /// </summary>
        public static readonly FileCacheLifecycle DELETING = new FileCacheLifecycle("DELETING");
        /// <summary>
        /// Constant FAILED for FileCacheLifecycle
        /// </summary>
        public static readonly FileCacheLifecycle FAILED = new FileCacheLifecycle("FAILED");
        /// <summary>
        /// Constant UPDATING for FileCacheLifecycle
        /// </summary>
        public static readonly FileCacheLifecycle UPDATING = new FileCacheLifecycle("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileCacheLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileCacheLifecycle FindValue(string value)
        {
            return FindValue<FileCacheLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileCacheLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileCacheLustreDeploymentType.
    /// </summary>
    public class FileCacheLustreDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant CACHE_1 for FileCacheLustreDeploymentType
        /// </summary>
        public static readonly FileCacheLustreDeploymentType CACHE_1 = new FileCacheLustreDeploymentType("CACHE_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileCacheLustreDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileCacheLustreDeploymentType FindValue(string value)
        {
            return FindValue<FileCacheLustreDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileCacheLustreDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileCacheType.
    /// </summary>
    public class FileCacheType : ConstantClass
    {

        /// <summary>
        /// Constant LUSTRE for FileCacheType
        /// </summary>
        public static readonly FileCacheType LUSTRE = new FileCacheType("LUSTRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileCacheType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileCacheType FindValue(string value)
        {
            return FindValue<FileCacheType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileCacheType(string value)
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
        /// Constant MISCONFIGURED_UNAVAILABLE for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle MISCONFIGURED_UNAVAILABLE = new FileSystemLifecycle("MISCONFIGURED_UNAVAILABLE");
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
        /// Constant ONTAP for FileSystemType
        /// </summary>
        public static readonly FileSystemType ONTAP = new FileSystemType("ONTAP");
        /// <summary>
        /// Constant OPENZFS for FileSystemType
        /// </summary>
        public static readonly FileSystemType OPENZFS = new FileSystemType("OPENZFS");
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
        /// Constant DataRepositoryType for FilterName
        /// </summary>
        public static readonly FilterName DataRepositoryType = new FilterName("data-repository-type");
        /// <summary>
        /// Constant FileCacheId for FilterName
        /// </summary>
        public static readonly FilterName FileCacheId = new FilterName("file-cache-id");
        /// <summary>
        /// Constant FileCacheType for FilterName
        /// </summary>
        public static readonly FilterName FileCacheType = new FilterName("file-cache-type");
        /// <summary>
        /// Constant FileSystemId for FilterName
        /// </summary>
        public static readonly FilterName FileSystemId = new FilterName("file-system-id");
        /// <summary>
        /// Constant FileSystemType for FilterName
        /// </summary>
        public static readonly FilterName FileSystemType = new FilterName("file-system-type");
        /// <summary>
        /// Constant VolumeId for FilterName
        /// </summary>
        public static readonly FilterName VolumeId = new FilterName("volume-id");

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
    /// Constants used for properties of type FlexCacheEndpointType.
    /// </summary>
    public class FlexCacheEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant CACHE for FlexCacheEndpointType
        /// </summary>
        public static readonly FlexCacheEndpointType CACHE = new FlexCacheEndpointType("CACHE");
        /// <summary>
        /// Constant NONE for FlexCacheEndpointType
        /// </summary>
        public static readonly FlexCacheEndpointType NONE = new FlexCacheEndpointType("NONE");
        /// <summary>
        /// Constant ORIGIN for FlexCacheEndpointType
        /// </summary>
        public static readonly FlexCacheEndpointType ORIGIN = new FlexCacheEndpointType("ORIGIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlexCacheEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlexCacheEndpointType FindValue(string value)
        {
            return FindValue<FlexCacheEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlexCacheEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputOntapVolumeType.
    /// </summary>
    public class InputOntapVolumeType : ConstantClass
    {

        /// <summary>
        /// Constant DP for InputOntapVolumeType
        /// </summary>
        public static readonly InputOntapVolumeType DP = new InputOntapVolumeType("DP");
        /// <summary>
        /// Constant RW for InputOntapVolumeType
        /// </summary>
        public static readonly InputOntapVolumeType RW = new InputOntapVolumeType("RW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputOntapVolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputOntapVolumeType FindValue(string value)
        {
            return FindValue<InputOntapVolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputOntapVolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LustreAccessAuditLogLevel.
    /// </summary>
    public class LustreAccessAuditLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LustreAccessAuditLogLevel
        /// </summary>
        public static readonly LustreAccessAuditLogLevel DISABLED = new LustreAccessAuditLogLevel("DISABLED");
        /// <summary>
        /// Constant ERROR_ONLY for LustreAccessAuditLogLevel
        /// </summary>
        public static readonly LustreAccessAuditLogLevel ERROR_ONLY = new LustreAccessAuditLogLevel("ERROR_ONLY");
        /// <summary>
        /// Constant WARN_ERROR for LustreAccessAuditLogLevel
        /// </summary>
        public static readonly LustreAccessAuditLogLevel WARN_ERROR = new LustreAccessAuditLogLevel("WARN_ERROR");
        /// <summary>
        /// Constant WARN_ONLY for LustreAccessAuditLogLevel
        /// </summary>
        public static readonly LustreAccessAuditLogLevel WARN_ONLY = new LustreAccessAuditLogLevel("WARN_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LustreAccessAuditLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LustreAccessAuditLogLevel FindValue(string value)
        {
            return FindValue<LustreAccessAuditLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LustreAccessAuditLogLevel(string value)
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
        /// Constant PERSISTENT_2 for LustreDeploymentType
        /// </summary>
        public static readonly LustreDeploymentType PERSISTENT_2 = new LustreDeploymentType("PERSISTENT_2");
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
    /// Constants used for properties of type NfsVersion.
    /// </summary>
    public class NfsVersion : ConstantClass
    {

        /// <summary>
        /// Constant NFS3 for NfsVersion
        /// </summary>
        public static readonly NfsVersion NFS3 = new NfsVersion("NFS3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NfsVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NfsVersion FindValue(string value)
        {
            return FindValue<NfsVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NfsVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OntapDeploymentType.
    /// </summary>
    public class OntapDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_AZ_1 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType MULTI_AZ_1 = new OntapDeploymentType("MULTI_AZ_1");
        /// <summary>
        /// Constant SINGLE_AZ_1 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType SINGLE_AZ_1 = new OntapDeploymentType("SINGLE_AZ_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OntapDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OntapDeploymentType FindValue(string value)
        {
            return FindValue<OntapDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OntapDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OntapVolumeType.
    /// </summary>
    public class OntapVolumeType : ConstantClass
    {

        /// <summary>
        /// Constant DP for OntapVolumeType
        /// </summary>
        public static readonly OntapVolumeType DP = new OntapVolumeType("DP");
        /// <summary>
        /// Constant LS for OntapVolumeType
        /// </summary>
        public static readonly OntapVolumeType LS = new OntapVolumeType("LS");
        /// <summary>
        /// Constant RW for OntapVolumeType
        /// </summary>
        public static readonly OntapVolumeType RW = new OntapVolumeType("RW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OntapVolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OntapVolumeType FindValue(string value)
        {
            return FindValue<OntapVolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OntapVolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenZFSCopyStrategy.
    /// </summary>
    public class OpenZFSCopyStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CLONE for OpenZFSCopyStrategy
        /// </summary>
        public static readonly OpenZFSCopyStrategy CLONE = new OpenZFSCopyStrategy("CLONE");
        /// <summary>
        /// Constant FULL_COPY for OpenZFSCopyStrategy
        /// </summary>
        public static readonly OpenZFSCopyStrategy FULL_COPY = new OpenZFSCopyStrategy("FULL_COPY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenZFSCopyStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSCopyStrategy FindValue(string value)
        {
            return FindValue<OpenZFSCopyStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSCopyStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenZFSDataCompressionType.
    /// </summary>
    public class OpenZFSDataCompressionType : ConstantClass
    {

        /// <summary>
        /// Constant LZ4 for OpenZFSDataCompressionType
        /// </summary>
        public static readonly OpenZFSDataCompressionType LZ4 = new OpenZFSDataCompressionType("LZ4");
        /// <summary>
        /// Constant NONE for OpenZFSDataCompressionType
        /// </summary>
        public static readonly OpenZFSDataCompressionType NONE = new OpenZFSDataCompressionType("NONE");
        /// <summary>
        /// Constant ZSTD for OpenZFSDataCompressionType
        /// </summary>
        public static readonly OpenZFSDataCompressionType ZSTD = new OpenZFSDataCompressionType("ZSTD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenZFSDataCompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSDataCompressionType FindValue(string value)
        {
            return FindValue<OpenZFSDataCompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSDataCompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenZFSDeploymentType.
    /// </summary>
    public class OpenZFSDeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant SINGLE_AZ_1 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_1 = new OpenZFSDeploymentType("SINGLE_AZ_1");
        /// <summary>
        /// Constant SINGLE_AZ_2 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_2 = new OpenZFSDeploymentType("SINGLE_AZ_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenZFSDeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSDeploymentType FindValue(string value)
        {
            return FindValue<OpenZFSDeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSDeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenZFSQuotaType.
    /// </summary>
    public class OpenZFSQuotaType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for OpenZFSQuotaType
        /// </summary>
        public static readonly OpenZFSQuotaType GROUP = new OpenZFSQuotaType("GROUP");
        /// <summary>
        /// Constant USER for OpenZFSQuotaType
        /// </summary>
        public static readonly OpenZFSQuotaType USER = new OpenZFSQuotaType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenZFSQuotaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSQuotaType FindValue(string value)
        {
            return FindValue<OpenZFSQuotaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSQuotaType(string value)
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
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant FILE_SYSTEM for ResourceType
        /// </summary>
        public static readonly ResourceType FILE_SYSTEM = new ResourceType("FILE_SYSTEM");
        /// <summary>
        /// Constant VOLUME for ResourceType
        /// </summary>
        public static readonly ResourceType VOLUME = new ResourceType("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreOpenZFSVolumeOption.
    /// </summary>
    public class RestoreOpenZFSVolumeOption : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_CLONED_VOLUMES for RestoreOpenZFSVolumeOption
        /// </summary>
        public static readonly RestoreOpenZFSVolumeOption DELETE_CLONED_VOLUMES = new RestoreOpenZFSVolumeOption("DELETE_CLONED_VOLUMES");
        /// <summary>
        /// Constant DELETE_INTERMEDIATE_SNAPSHOTS for RestoreOpenZFSVolumeOption
        /// </summary>
        public static readonly RestoreOpenZFSVolumeOption DELETE_INTERMEDIATE_SNAPSHOTS = new RestoreOpenZFSVolumeOption("DELETE_INTERMEDIATE_SNAPSHOTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreOpenZFSVolumeOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreOpenZFSVolumeOption FindValue(string value)
        {
            return FindValue<RestoreOpenZFSVolumeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreOpenZFSVolumeOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityStyle.
    /// </summary>
    public class SecurityStyle : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for SecurityStyle
        /// </summary>
        public static readonly SecurityStyle MIXED = new SecurityStyle("MIXED");
        /// <summary>
        /// Constant NTFS for SecurityStyle
        /// </summary>
        public static readonly SecurityStyle NTFS = new SecurityStyle("NTFS");
        /// <summary>
        /// Constant UNIX for SecurityStyle
        /// </summary>
        public static readonly SecurityStyle UNIX = new SecurityStyle("UNIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityStyle FindValue(string value)
        {
            return FindValue<SecurityStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityStyle(string value)
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
        /// Constant FILE_CACHE_COUNT for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit FILE_CACHE_COUNT = new ServiceLimit("FILE_CACHE_COUNT");
        /// <summary>
        /// Constant FILE_SYSTEM_COUNT for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit FILE_SYSTEM_COUNT = new ServiceLimit("FILE_SYSTEM_COUNT");
        /// <summary>
        /// Constant STORAGE_VIRTUAL_MACHINES_PER_FILE_SYSTEM for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit STORAGE_VIRTUAL_MACHINES_PER_FILE_SYSTEM = new ServiceLimit("STORAGE_VIRTUAL_MACHINES_PER_FILE_SYSTEM");
        /// <summary>
        /// Constant TOTAL_IN_PROGRESS_COPY_BACKUPS for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_IN_PROGRESS_COPY_BACKUPS = new ServiceLimit("TOTAL_IN_PROGRESS_COPY_BACKUPS");
        /// <summary>
        /// Constant TOTAL_SSD_IOPS for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_SSD_IOPS = new ServiceLimit("TOTAL_SSD_IOPS");
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
        /// Constant TOTAL_USER_TAGS for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_USER_TAGS = new ServiceLimit("TOTAL_USER_TAGS");
        /// <summary>
        /// Constant VOLUMES_PER_FILE_SYSTEM for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit VOLUMES_PER_FILE_SYSTEM = new ServiceLimit("VOLUMES_PER_FILE_SYSTEM");

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
    /// Constants used for properties of type SnapshotFilterName.
    /// </summary>
    public class SnapshotFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FileSystemId for SnapshotFilterName
        /// </summary>
        public static readonly SnapshotFilterName FileSystemId = new SnapshotFilterName("file-system-id");
        /// <summary>
        /// Constant VolumeId for SnapshotFilterName
        /// </summary>
        public static readonly SnapshotFilterName VolumeId = new SnapshotFilterName("volume-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotFilterName FindValue(string value)
        {
            return FindValue<SnapshotFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotLifecycle.
    /// </summary>
    public class SnapshotLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle AVAILABLE = new SnapshotLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle CREATING = new SnapshotLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle DELETING = new SnapshotLifecycle("DELETING");
        /// <summary>
        /// Constant PENDING for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle PENDING = new SnapshotLifecycle("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotLifecycle FindValue(string value)
        {
            return FindValue<SnapshotLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotLifecycle(string value)
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
    /// Constants used for properties of type StorageVirtualMachineFilterName.
    /// </summary>
    public class StorageVirtualMachineFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FileSystemId for StorageVirtualMachineFilterName
        /// </summary>
        public static readonly StorageVirtualMachineFilterName FileSystemId = new StorageVirtualMachineFilterName("file-system-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageVirtualMachineFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachineFilterName FindValue(string value)
        {
            return FindValue<StorageVirtualMachineFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachineFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageVirtualMachineLifecycle.
    /// </summary>
    public class StorageVirtualMachineLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle CREATED = new StorageVirtualMachineLifecycle("CREATED");
        /// <summary>
        /// Constant CREATING for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle CREATING = new StorageVirtualMachineLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle DELETING = new StorageVirtualMachineLifecycle("DELETING");
        /// <summary>
        /// Constant FAILED for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle FAILED = new StorageVirtualMachineLifecycle("FAILED");
        /// <summary>
        /// Constant MISCONFIGURED for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle MISCONFIGURED = new StorageVirtualMachineLifecycle("MISCONFIGURED");
        /// <summary>
        /// Constant PENDING for StorageVirtualMachineLifecycle
        /// </summary>
        public static readonly StorageVirtualMachineLifecycle PENDING = new StorageVirtualMachineLifecycle("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageVirtualMachineLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachineLifecycle FindValue(string value)
        {
            return FindValue<StorageVirtualMachineLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachineLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageVirtualMachineRootVolumeSecurityStyle.
    /// </summary>
    public class StorageVirtualMachineRootVolumeSecurityStyle : ConstantClass
    {

        /// <summary>
        /// Constant MIXED for StorageVirtualMachineRootVolumeSecurityStyle
        /// </summary>
        public static readonly StorageVirtualMachineRootVolumeSecurityStyle MIXED = new StorageVirtualMachineRootVolumeSecurityStyle("MIXED");
        /// <summary>
        /// Constant NTFS for StorageVirtualMachineRootVolumeSecurityStyle
        /// </summary>
        public static readonly StorageVirtualMachineRootVolumeSecurityStyle NTFS = new StorageVirtualMachineRootVolumeSecurityStyle("NTFS");
        /// <summary>
        /// Constant UNIX for StorageVirtualMachineRootVolumeSecurityStyle
        /// </summary>
        public static readonly StorageVirtualMachineRootVolumeSecurityStyle UNIX = new StorageVirtualMachineRootVolumeSecurityStyle("UNIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageVirtualMachineRootVolumeSecurityStyle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachineRootVolumeSecurityStyle FindValue(string value)
        {
            return FindValue<StorageVirtualMachineRootVolumeSecurityStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachineRootVolumeSecurityStyle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TieringPolicyName.
    /// </summary>
    public class TieringPolicyName : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TieringPolicyName
        /// </summary>
        public static readonly TieringPolicyName ALL = new TieringPolicyName("ALL");
        /// <summary>
        /// Constant AUTO for TieringPolicyName
        /// </summary>
        public static readonly TieringPolicyName AUTO = new TieringPolicyName("AUTO");
        /// <summary>
        /// Constant NONE for TieringPolicyName
        /// </summary>
        public static readonly TieringPolicyName NONE = new TieringPolicyName("NONE");
        /// <summary>
        /// Constant SNAPSHOT_ONLY for TieringPolicyName
        /// </summary>
        public static readonly TieringPolicyName SNAPSHOT_ONLY = new TieringPolicyName("SNAPSHOT_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TieringPolicyName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TieringPolicyName FindValue(string value)
        {
            return FindValue<TieringPolicyName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TieringPolicyName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeFilterName.
    /// </summary>
    public class VolumeFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FileSystemId for VolumeFilterName
        /// </summary>
        public static readonly VolumeFilterName FileSystemId = new VolumeFilterName("file-system-id");
        /// <summary>
        /// Constant StorageVirtualMachineId for VolumeFilterName
        /// </summary>
        public static readonly VolumeFilterName StorageVirtualMachineId = new VolumeFilterName("storage-virtual-machine-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeFilterName FindValue(string value)
        {
            return FindValue<VolumeFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeLifecycle.
    /// </summary>
    public class VolumeLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle AVAILABLE = new VolumeLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATED for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle CREATED = new VolumeLifecycle("CREATED");
        /// <summary>
        /// Constant CREATING for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle CREATING = new VolumeLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle DELETING = new VolumeLifecycle("DELETING");
        /// <summary>
        /// Constant FAILED for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle FAILED = new VolumeLifecycle("FAILED");
        /// <summary>
        /// Constant MISCONFIGURED for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle MISCONFIGURED = new VolumeLifecycle("MISCONFIGURED");
        /// <summary>
        /// Constant PENDING for VolumeLifecycle
        /// </summary>
        public static readonly VolumeLifecycle PENDING = new VolumeLifecycle("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeLifecycle FindValue(string value)
        {
            return FindValue<VolumeLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant ONTAP for VolumeType
        /// </summary>
        public static readonly VolumeType ONTAP = new VolumeType("ONTAP");
        /// <summary>
        /// Constant OPENZFS for VolumeType
        /// </summary>
        public static readonly VolumeType OPENZFS = new VolumeType("OPENZFS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WindowsAccessAuditLogLevel.
    /// </summary>
    public class WindowsAccessAuditLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WindowsAccessAuditLogLevel
        /// </summary>
        public static readonly WindowsAccessAuditLogLevel DISABLED = new WindowsAccessAuditLogLevel("DISABLED");
        /// <summary>
        /// Constant FAILURE_ONLY for WindowsAccessAuditLogLevel
        /// </summary>
        public static readonly WindowsAccessAuditLogLevel FAILURE_ONLY = new WindowsAccessAuditLogLevel("FAILURE_ONLY");
        /// <summary>
        /// Constant SUCCESS_AND_FAILURE for WindowsAccessAuditLogLevel
        /// </summary>
        public static readonly WindowsAccessAuditLogLevel SUCCESS_AND_FAILURE = new WindowsAccessAuditLogLevel("SUCCESS_AND_FAILURE");
        /// <summary>
        /// Constant SUCCESS_ONLY for WindowsAccessAuditLogLevel
        /// </summary>
        public static readonly WindowsAccessAuditLogLevel SUCCESS_ONLY = new WindowsAccessAuditLogLevel("SUCCESS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WindowsAccessAuditLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WindowsAccessAuditLogLevel FindValue(string value)
        {
            return FindValue<WindowsAccessAuditLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WindowsAccessAuditLogLevel(string value)
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
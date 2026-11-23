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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Constant INVALID_NETWORK_TYPE for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType INVALID_NETWORK_TYPE = new ActiveDirectoryErrorType("INVALID_NETWORK_TYPE");

        /// <summary>
        /// Constant WRONG_VPC for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType WRONG_VPC = new ActiveDirectoryErrorType("WRONG_VPC");

        /// <summary>
        /// Constructs a custom ActiveDirectoryErrorType for a value not among the defined constants.
        /// </summary>
        public ActiveDirectoryErrorType(string value) : base(value) { }

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
        /// Constant DOWNLOAD_DATA_FROM_BACKUP for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType DOWNLOAD_DATA_FROM_BACKUP = new AdministrativeActionType("DOWNLOAD_DATA_FROM_BACKUP");

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
        /// Constant IOPS_OPTIMIZATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType IOPS_OPTIMIZATION = new AdministrativeActionType("IOPS_OPTIMIZATION");

        /// <summary>
        /// Constant MISCONFIGURED_STATE_RECOVERY for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType MISCONFIGURED_STATE_RECOVERY = new AdministrativeActionType("MISCONFIGURED_STATE_RECOVERY");

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
        /// Constant STORAGE_TYPE_OPTIMIZATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType STORAGE_TYPE_OPTIMIZATION = new AdministrativeActionType("STORAGE_TYPE_OPTIMIZATION");

        /// <summary>
        /// Constant THROUGHPUT_OPTIMIZATION for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType THROUGHPUT_OPTIMIZATION = new AdministrativeActionType("THROUGHPUT_OPTIMIZATION");

        /// <summary>
        /// Constant VOLUME_CLONE_SPLIT for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_CLONE_SPLIT = new AdministrativeActionType("VOLUME_CLONE_SPLIT");

        /// <summary>
        /// Constant VOLUME_INITIALIZE_WITH_SNAPSHOT for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_INITIALIZE_WITH_SNAPSHOT = new AdministrativeActionType("VOLUME_INITIALIZE_WITH_SNAPSHOT");

        /// <summary>
        /// Constant VOLUME_RESTORE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_RESTORE = new AdministrativeActionType("VOLUME_RESTORE");

        /// <summary>
        /// Constant VOLUME_UPDATE for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_UPDATE = new AdministrativeActionType("VOLUME_UPDATE");

        /// <summary>
        /// Constant VOLUME_UPDATE_WITH_SNAPSHOT for AdministrativeActionType
        /// </summary>
        public static readonly AdministrativeActionType VOLUME_UPDATE_WITH_SNAPSHOT = new AdministrativeActionType("VOLUME_UPDATE_WITH_SNAPSHOT");

        /// <summary>
        /// Constructs a custom AdministrativeActionType for a value not among the defined constants.
        /// </summary>
        public AdministrativeActionType(string value) : base(value) { }

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
        /// Constructs a custom AliasLifecycle for a value not among the defined constants.
        /// </summary>
        public AliasLifecycle(string value) : base(value) { }

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
    /// Constants used for properties of type AllowedSvmMode.
    /// </summary>
    public class AllowedSvmMode : ConstantClass
    {
        /// <summary>
        /// Constant ALL for AllowedSvmMode
        /// </summary>
        public static readonly AllowedSvmMode ALL = new AllowedSvmMode("ALL");

        /// <summary>
        /// Constant NONE for AllowedSvmMode
        /// </summary>
        public static readonly AllowedSvmMode NONE = new AllowedSvmMode("NONE");

        /// <summary>
        /// Constant SPECIFIED for AllowedSvmMode
        /// </summary>
        public static readonly AllowedSvmMode SPECIFIED = new AllowedSvmMode("SPECIFIED");

        /// <summary>
        /// Constructs a custom AllowedSvmMode for a value not among the defined constants.
        /// </summary>
        public AllowedSvmMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowedSvmMode FindValue(string value)
        {
            return FindValue<AllowedSvmMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowedSvmMode(string value)
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
        /// Constructs a custom AutoImportPolicyType for a value not among the defined constants.
        /// </summary>
        public AutoImportPolicyType(string value) : base(value) { }

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
    /// Constants used for properties of type AutocommitPeriodType.
    /// </summary>
    public class AutocommitPeriodType : ConstantClass
    {
        /// <summary>
        /// Constant DAYS for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType DAYS = new AutocommitPeriodType("DAYS");

        /// <summary>
        /// Constant HOURS for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType HOURS = new AutocommitPeriodType("HOURS");

        /// <summary>
        /// Constant MINUTES for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType MINUTES = new AutocommitPeriodType("MINUTES");

        /// <summary>
        /// Constant MONTHS for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType MONTHS = new AutocommitPeriodType("MONTHS");

        /// <summary>
        /// Constant NONE for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType NONE = new AutocommitPeriodType("NONE");

        /// <summary>
        /// Constant YEARS for AutocommitPeriodType
        /// </summary>
        public static readonly AutocommitPeriodType YEARS = new AutocommitPeriodType("YEARS");

        /// <summary>
        /// Constructs a custom AutocommitPeriodType for a value not among the defined constants.
        /// </summary>
        public AutocommitPeriodType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutocommitPeriodType FindValue(string value)
        {
            return FindValue<AutocommitPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutocommitPeriodType(string value)
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
        /// Constructs a custom BackupLifecycle for a value not among the defined constants.
        /// </summary>
        public BackupLifecycle(string value) : base(value) { }

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
        /// Constructs a custom BackupType for a value not among the defined constants.
        /// </summary>
        public BackupType(string value) : base(value) { }

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
    /// Constants used for properties of type CloneSplitAction.
    /// </summary>
    public class CloneSplitAction : ConstantClass
    {
        /// <summary>
        /// Constant START for CloneSplitAction
        /// </summary>
        public static readonly CloneSplitAction START = new CloneSplitAction("START");

        /// <summary>
        /// Constructs a custom CloneSplitAction for a value not among the defined constants.
        /// </summary>
        public CloneSplitAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloneSplitAction FindValue(string value)
        {
            return FindValue<CloneSplitAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloneSplitAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ClusterPeerFilterName.
    /// </summary>
    public class ClusterPeerFilterName : ConstantClass
    {
        /// <summary>
        /// Constant FileSystemId for ClusterPeerFilterName
        /// </summary>
        public static readonly ClusterPeerFilterName FileSystemId = new ClusterPeerFilterName("file-system-id");

        /// <summary>
        /// Constructs a custom ClusterPeerFilterName for a value not among the defined constants.
        /// </summary>
        public ClusterPeerFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterPeerFilterName FindValue(string value)
        {
            return FindValue<ClusterPeerFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterPeerFilterName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ClusterPeerLifecycle.
    /// </summary>
    public class ClusterPeerLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for ClusterPeerLifecycle
        /// </summary>
        public static readonly ClusterPeerLifecycle CREATED = new ClusterPeerLifecycle("CREATED");

        /// <summary>
        /// Constant CREATING for ClusterPeerLifecycle
        /// </summary>
        public static readonly ClusterPeerLifecycle CREATING = new ClusterPeerLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for ClusterPeerLifecycle
        /// </summary>
        public static readonly ClusterPeerLifecycle DELETING = new ClusterPeerLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for ClusterPeerLifecycle
        /// </summary>
        public static readonly ClusterPeerLifecycle FAILED = new ClusterPeerLifecycle("FAILED");

        /// <summary>
        /// Constructs a custom ClusterPeerLifecycle for a value not among the defined constants.
        /// </summary>
        public ClusterPeerLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterPeerLifecycle FindValue(string value)
        {
            return FindValue<ClusterPeerLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterPeerLifecycle(string value)
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
        /// Constructs a custom DataCompressionType for a value not among the defined constants.
        /// </summary>
        public DataCompressionType(string value) : base(value) { }

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
        /// Constructs a custom DataRepositoryLifecycle for a value not among the defined constants.
        /// </summary>
        public DataRepositoryLifecycle(string value) : base(value) { }

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
        /// Constructs a custom DataRepositoryTaskFilterName for a value not among the defined constants.
        /// </summary>
        public DataRepositoryTaskFilterName(string value) : base(value) { }

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
        /// Constructs a custom DataRepositoryTaskLifecycle for a value not among the defined constants.
        /// </summary>
        public DataRepositoryTaskLifecycle(string value) : base(value) { }

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
        /// Constructs a custom DataRepositoryTaskType for a value not among the defined constants.
        /// </summary>
        public DataRepositoryTaskType(string value) : base(value) { }

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
        /// Constructs a custom DeleteFileSystemOpenZFSOption for a value not among the defined constants.
        /// </summary>
        public DeleteFileSystemOpenZFSOption(string value) : base(value) { }

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
        /// Constructs a custom DeleteOpenZFSVolumeOption for a value not among the defined constants.
        /// </summary>
        public DeleteOpenZFSVolumeOption(string value) : base(value) { }

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
        /// Constructs a custom DiskIopsConfigurationMode for a value not among the defined constants.
        /// </summary>
        public DiskIopsConfigurationMode(string value) : base(value) { }

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
        /// Constructs a custom DriveCacheType for a value not among the defined constants.
        /// </summary>
        public DriveCacheType(string value) : base(value) { }

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
        /// Constructs a custom EventType for a value not among the defined constants.
        /// </summary>
        public EventType(string value) : base(value) { }

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
        /// Constructs a custom FileCacheLifecycle for a value not among the defined constants.
        /// </summary>
        public FileCacheLifecycle(string value) : base(value) { }

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
        /// Constructs a custom FileCacheLustreDeploymentType for a value not among the defined constants.
        /// </summary>
        public FileCacheLustreDeploymentType(string value) : base(value) { }

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
        /// Constructs a custom FileCacheType for a value not among the defined constants.
        /// </summary>
        public FileCacheType(string value) : base(value) { }

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
        /// Constructs a custom FileSystemLifecycle for a value not among the defined constants.
        /// </summary>
        public FileSystemLifecycle(string value) : base(value) { }

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
        /// Constructs a custom FileSystemMaintenanceOperation for a value not among the defined constants.
        /// </summary>
        public FileSystemMaintenanceOperation(string value) : base(value) { }

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
        /// Constructs a custom FileSystemType for a value not among the defined constants.
        /// </summary>
        public FileSystemType(string value) : base(value) { }

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
        /// Constructs a custom FilterName for a value not among the defined constants.
        /// </summary>
        public FilterName(string value) : base(value) { }

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
        /// Constructs a custom FlexCacheEndpointType for a value not among the defined constants.
        /// </summary>
        public FlexCacheEndpointType(string value) : base(value) { }

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
        /// Constructs a custom InputOntapVolumeType for a value not among the defined constants.
        /// </summary>
        public InputOntapVolumeType(string value) : base(value) { }

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
        /// Constructs a custom LustreAccessAuditLogLevel for a value not among the defined constants.
        /// </summary>
        public LustreAccessAuditLogLevel(string value) : base(value) { }

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
        /// Constructs a custom LustreDeploymentType for a value not among the defined constants.
        /// </summary>
        public LustreDeploymentType(string value) : base(value) { }

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
    /// Constants used for properties of type LustreReadCacheSizingMode.
    /// </summary>
    public class LustreReadCacheSizingMode : ConstantClass
    {
        /// <summary>
        /// Constant NO_CACHE for LustreReadCacheSizingMode
        /// </summary>
        public static readonly LustreReadCacheSizingMode NO_CACHE = new LustreReadCacheSizingMode("NO_CACHE");

        /// <summary>
        /// Constant PROPORTIONAL_TO_THROUGHPUT_CAPACITY for LustreReadCacheSizingMode
        /// </summary>
        public static readonly LustreReadCacheSizingMode PROPORTIONAL_TO_THROUGHPUT_CAPACITY = new LustreReadCacheSizingMode("PROPORTIONAL_TO_THROUGHPUT_CAPACITY");

        /// <summary>
        /// Constant USER_PROVISIONED for LustreReadCacheSizingMode
        /// </summary>
        public static readonly LustreReadCacheSizingMode USER_PROVISIONED = new LustreReadCacheSizingMode("USER_PROVISIONED");

        /// <summary>
        /// Constructs a custom LustreReadCacheSizingMode for a value not among the defined constants.
        /// </summary>
        public LustreReadCacheSizingMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LustreReadCacheSizingMode FindValue(string value)
        {
            return FindValue<LustreReadCacheSizingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LustreReadCacheSizingMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MetadataConfigurationMode.
    /// </summary>
    public class MetadataConfigurationMode : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for MetadataConfigurationMode
        /// </summary>
        public static readonly MetadataConfigurationMode AUTOMATIC = new MetadataConfigurationMode("AUTOMATIC");

        /// <summary>
        /// Constant USER_PROVISIONED for MetadataConfigurationMode
        /// </summary>
        public static readonly MetadataConfigurationMode USER_PROVISIONED = new MetadataConfigurationMode("USER_PROVISIONED");

        /// <summary>
        /// Constructs a custom MetadataConfigurationMode for a value not among the defined constants.
        /// </summary>
        public MetadataConfigurationMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataConfigurationMode FindValue(string value)
        {
            return FindValue<MetadataConfigurationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataConfigurationMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {
        /// <summary>
        /// Constant DUAL for NetworkType
        /// </summary>
        public static readonly NetworkType DUAL = new NetworkType("DUAL");

        /// <summary>
        /// Constant IPV4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV4 = new NetworkType("IPV4");

        /// <summary>
        /// Constructs a custom NetworkType for a value not among the defined constants.
        /// </summary>
        public NetworkType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
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
        /// Constructs a custom NfsVersion for a value not among the defined constants.
        /// </summary>
        public NfsVersion(string value) : base(value) { }

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
        /// Constant MULTI_AZ_2 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType MULTI_AZ_2 = new OntapDeploymentType("MULTI_AZ_2");

        /// <summary>
        /// Constant MULTI_AZ_3 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType MULTI_AZ_3 = new OntapDeploymentType("MULTI_AZ_3");

        /// <summary>
        /// Constant SINGLE_AZ_1 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType SINGLE_AZ_1 = new OntapDeploymentType("SINGLE_AZ_1");

        /// <summary>
        /// Constant SINGLE_AZ_2 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType SINGLE_AZ_2 = new OntapDeploymentType("SINGLE_AZ_2");

        /// <summary>
        /// Constant SINGLE_AZ_3 for OntapDeploymentType
        /// </summary>
        public static readonly OntapDeploymentType SINGLE_AZ_3 = new OntapDeploymentType("SINGLE_AZ_3");

        /// <summary>
        /// Constructs a custom OntapDeploymentType for a value not among the defined constants.
        /// </summary>
        public OntapDeploymentType(string value) : base(value) { }

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
    /// Constants used for properties of type OntapFileSystemUserType.
    /// </summary>
    public class OntapFileSystemUserType : ConstantClass
    {
        /// <summary>
        /// Constant UNIX for OntapFileSystemUserType
        /// </summary>
        public static readonly OntapFileSystemUserType UNIX = new OntapFileSystemUserType("UNIX");

        /// <summary>
        /// Constant WINDOWS for OntapFileSystemUserType
        /// </summary>
        public static readonly OntapFileSystemUserType WINDOWS = new OntapFileSystemUserType("WINDOWS");

        /// <summary>
        /// Constructs a custom OntapFileSystemUserType for a value not among the defined constants.
        /// </summary>
        public OntapFileSystemUserType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OntapFileSystemUserType FindValue(string value)
        {
            return FindValue<OntapFileSystemUserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OntapFileSystemUserType(string value)
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
        /// Constructs a custom OntapVolumeType for a value not among the defined constants.
        /// </summary>
        public OntapVolumeType(string value) : base(value) { }

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
        /// Constant INCREMENTAL_COPY for OpenZFSCopyStrategy
        /// </summary>
        public static readonly OpenZFSCopyStrategy INCREMENTAL_COPY = new OpenZFSCopyStrategy("INCREMENTAL_COPY");

        /// <summary>
        /// Constructs a custom OpenZFSCopyStrategy for a value not among the defined constants.
        /// </summary>
        public OpenZFSCopyStrategy(string value) : base(value) { }

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
        /// Constructs a custom OpenZFSDataCompressionType for a value not among the defined constants.
        /// </summary>
        public OpenZFSDataCompressionType(string value) : base(value) { }

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
        /// Constant MULTI_AZ_1 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType MULTI_AZ_1 = new OpenZFSDeploymentType("MULTI_AZ_1");

        /// <summary>
        /// Constant SINGLE_AZ_1 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_1 = new OpenZFSDeploymentType("SINGLE_AZ_1");

        /// <summary>
        /// Constant SINGLE_AZ_2 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_2 = new OpenZFSDeploymentType("SINGLE_AZ_2");

        /// <summary>
        /// Constant SINGLE_AZ_HA_1 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_HA_1 = new OpenZFSDeploymentType("SINGLE_AZ_HA_1");

        /// <summary>
        /// Constant SINGLE_AZ_HA_2 for OpenZFSDeploymentType
        /// </summary>
        public static readonly OpenZFSDeploymentType SINGLE_AZ_HA_2 = new OpenZFSDeploymentType("SINGLE_AZ_HA_2");

        /// <summary>
        /// Constructs a custom OpenZFSDeploymentType for a value not among the defined constants.
        /// </summary>
        public OpenZFSDeploymentType(string value) : base(value) { }

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
    /// Constants used for properties of type OpenZFSFileSystemUserType.
    /// </summary>
    public class OpenZFSFileSystemUserType : ConstantClass
    {
        /// <summary>
        /// Constant POSIX for OpenZFSFileSystemUserType
        /// </summary>
        public static readonly OpenZFSFileSystemUserType POSIX = new OpenZFSFileSystemUserType("POSIX");

        /// <summary>
        /// Constructs a custom OpenZFSFileSystemUserType for a value not among the defined constants.
        /// </summary>
        public OpenZFSFileSystemUserType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSFileSystemUserType FindValue(string value)
        {
            return FindValue<OpenZFSFileSystemUserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSFileSystemUserType(string value)
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
        /// Constructs a custom OpenZFSQuotaType for a value not among the defined constants.
        /// </summary>
        public OpenZFSQuotaType(string value) : base(value) { }

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
    /// Constants used for properties of type OpenZFSReadCacheSizingMode.
    /// </summary>
    public class OpenZFSReadCacheSizingMode : ConstantClass
    {
        /// <summary>
        /// Constant NO_CACHE for OpenZFSReadCacheSizingMode
        /// </summary>
        public static readonly OpenZFSReadCacheSizingMode NO_CACHE = new OpenZFSReadCacheSizingMode("NO_CACHE");

        /// <summary>
        /// Constant PROPORTIONAL_TO_THROUGHPUT_CAPACITY for OpenZFSReadCacheSizingMode
        /// </summary>
        public static readonly OpenZFSReadCacheSizingMode PROPORTIONAL_TO_THROUGHPUT_CAPACITY = new OpenZFSReadCacheSizingMode("PROPORTIONAL_TO_THROUGHPUT_CAPACITY");

        /// <summary>
        /// Constant USER_PROVISIONED for OpenZFSReadCacheSizingMode
        /// </summary>
        public static readonly OpenZFSReadCacheSizingMode USER_PROVISIONED = new OpenZFSReadCacheSizingMode("USER_PROVISIONED");

        /// <summary>
        /// Constructs a custom OpenZFSReadCacheSizingMode for a value not among the defined constants.
        /// </summary>
        public OpenZFSReadCacheSizingMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenZFSReadCacheSizingMode FindValue(string value)
        {
            return FindValue<OpenZFSReadCacheSizingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenZFSReadCacheSizingMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PrivilegedDelete.
    /// </summary>
    public class PrivilegedDelete : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for PrivilegedDelete
        /// </summary>
        public static readonly PrivilegedDelete DISABLED = new PrivilegedDelete("DISABLED");

        /// <summary>
        /// Constant ENABLED for PrivilegedDelete
        /// </summary>
        public static readonly PrivilegedDelete ENABLED = new PrivilegedDelete("ENABLED");

        /// <summary>
        /// Constant PERMANENTLY_DISABLED for PrivilegedDelete
        /// </summary>
        public static readonly PrivilegedDelete PERMANENTLY_DISABLED = new PrivilegedDelete("PERMANENTLY_DISABLED");

        /// <summary>
        /// Constructs a custom PrivilegedDelete for a value not among the defined constants.
        /// </summary>
        public PrivilegedDelete(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivilegedDelete FindValue(string value)
        {
            return FindValue<PrivilegedDelete>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivilegedDelete(string value)
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
        /// Constructs a custom ReportFormat for a value not among the defined constants.
        /// </summary>
        public ReportFormat(string value) : base(value) { }

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
        /// Constructs a custom ReportScope for a value not among the defined constants.
        /// </summary>
        public ReportScope(string value) : base(value) { }

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
        /// Constructs a custom ResourceType for a value not among the defined constants.
        /// </summary>
        public ResourceType(string value) : base(value) { }

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
        /// Constructs a custom RestoreOpenZFSVolumeOption for a value not among the defined constants.
        /// </summary>
        public RestoreOpenZFSVolumeOption(string value) : base(value) { }

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
    /// Constants used for properties of type RetentionPeriodType.
    /// </summary>
    public class RetentionPeriodType : ConstantClass
    {
        /// <summary>
        /// Constant DAYS for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType DAYS = new RetentionPeriodType("DAYS");

        /// <summary>
        /// Constant HOURS for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType HOURS = new RetentionPeriodType("HOURS");

        /// <summary>
        /// Constant INFINITE for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType INFINITE = new RetentionPeriodType("INFINITE");

        /// <summary>
        /// Constant MINUTES for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType MINUTES = new RetentionPeriodType("MINUTES");

        /// <summary>
        /// Constant MONTHS for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType MONTHS = new RetentionPeriodType("MONTHS");

        /// <summary>
        /// Constant SECONDS for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType SECONDS = new RetentionPeriodType("SECONDS");

        /// <summary>
        /// Constant UNSPECIFIED for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType UNSPECIFIED = new RetentionPeriodType("UNSPECIFIED");

        /// <summary>
        /// Constant YEARS for RetentionPeriodType
        /// </summary>
        public static readonly RetentionPeriodType YEARS = new RetentionPeriodType("YEARS");

        /// <summary>
        /// Constructs a custom RetentionPeriodType for a value not among the defined constants.
        /// </summary>
        public RetentionPeriodType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionPeriodType FindValue(string value)
        {
            return FindValue<RetentionPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionPeriodType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type S3AccessPointAttachmentLifecycle.
    /// </summary>
    public class S3AccessPointAttachmentLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle AVAILABLE = new S3AccessPointAttachmentLifecycle("AVAILABLE");

        /// <summary>
        /// Constant CREATING for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle CREATING = new S3AccessPointAttachmentLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle DELETING = new S3AccessPointAttachmentLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle FAILED = new S3AccessPointAttachmentLifecycle("FAILED");

        /// <summary>
        /// Constant MISCONFIGURED for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle MISCONFIGURED = new S3AccessPointAttachmentLifecycle("MISCONFIGURED");

        /// <summary>
        /// Constant UPDATING for S3AccessPointAttachmentLifecycle
        /// </summary>
        public static readonly S3AccessPointAttachmentLifecycle UPDATING = new S3AccessPointAttachmentLifecycle("UPDATING");

        /// <summary>
        /// Constructs a custom S3AccessPointAttachmentLifecycle for a value not among the defined constants.
        /// </summary>
        public S3AccessPointAttachmentLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3AccessPointAttachmentLifecycle FindValue(string value)
        {
            return FindValue<S3AccessPointAttachmentLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3AccessPointAttachmentLifecycle(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type S3AccessPointAttachmentType.
    /// </summary>
    public class S3AccessPointAttachmentType : ConstantClass
    {
        /// <summary>
        /// Constant ONTAP for S3AccessPointAttachmentType
        /// </summary>
        public static readonly S3AccessPointAttachmentType ONTAP = new S3AccessPointAttachmentType("ONTAP");

        /// <summary>
        /// Constant OPENZFS for S3AccessPointAttachmentType
        /// </summary>
        public static readonly S3AccessPointAttachmentType OPENZFS = new S3AccessPointAttachmentType("OPENZFS");

        /// <summary>
        /// Constructs a custom S3AccessPointAttachmentType for a value not among the defined constants.
        /// </summary>
        public S3AccessPointAttachmentType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3AccessPointAttachmentType FindValue(string value)
        {
            return FindValue<S3AccessPointAttachmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3AccessPointAttachmentType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type S3AccessPointAttachmentsFilterName.
    /// </summary>
    public class S3AccessPointAttachmentsFilterName : ConstantClass
    {
        /// <summary>
        /// Constant FileSystemId for S3AccessPointAttachmentsFilterName
        /// </summary>
        public static readonly S3AccessPointAttachmentsFilterName FileSystemId = new S3AccessPointAttachmentsFilterName("file-system-id");

        /// <summary>
        /// Constant Type for S3AccessPointAttachmentsFilterName
        /// </summary>
        public static readonly S3AccessPointAttachmentsFilterName Type = new S3AccessPointAttachmentsFilterName("type");

        /// <summary>
        /// Constant VolumeId for S3AccessPointAttachmentsFilterName
        /// </summary>
        public static readonly S3AccessPointAttachmentsFilterName VolumeId = new S3AccessPointAttachmentsFilterName("volume-id");

        /// <summary>
        /// Constructs a custom S3AccessPointAttachmentsFilterName for a value not among the defined constants.
        /// </summary>
        public S3AccessPointAttachmentsFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3AccessPointAttachmentsFilterName FindValue(string value)
        {
            return FindValue<S3AccessPointAttachmentsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3AccessPointAttachmentsFilterName(string value)
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
        /// Constructs a custom SecurityStyle for a value not among the defined constants.
        /// </summary>
        public SecurityStyle(string value) : base(value) { }

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
        /// Constructs a custom ServiceLimit for a value not among the defined constants.
        /// </summary>
        public ServiceLimit(string value) : base(value) { }

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
    /// Constants used for properties of type SnaplockType.
    /// </summary>
    public class SnaplockType : ConstantClass
    {
        /// <summary>
        /// Constant COMPLIANCE for SnaplockType
        /// </summary>
        public static readonly SnaplockType COMPLIANCE = new SnaplockType("COMPLIANCE");

        /// <summary>
        /// Constant ENTERPRISE for SnaplockType
        /// </summary>
        public static readonly SnaplockType ENTERPRISE = new SnaplockType("ENTERPRISE");

        /// <summary>
        /// Constructs a custom SnaplockType for a value not among the defined constants.
        /// </summary>
        public SnaplockType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnaplockType FindValue(string value)
        {
            return FindValue<SnaplockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnaplockType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorPolicyFilterName.
    /// </summary>
    public class SnapmirrorPolicyFilterName : ConstantClass
    {
        /// <summary>
        /// Constant FileSystemId for SnapmirrorPolicyFilterName
        /// </summary>
        public static readonly SnapmirrorPolicyFilterName FileSystemId = new SnapmirrorPolicyFilterName("file-system-id");

        /// <summary>
        /// Constant StorageVirtualMachineId for SnapmirrorPolicyFilterName
        /// </summary>
        public static readonly SnapmirrorPolicyFilterName StorageVirtualMachineId = new SnapmirrorPolicyFilterName("storage-virtual-machine-id");

        /// <summary>
        /// Constructs a custom SnapmirrorPolicyFilterName for a value not among the defined constants.
        /// </summary>
        public SnapmirrorPolicyFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorPolicyFilterName FindValue(string value)
        {
            return FindValue<SnapmirrorPolicyFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorPolicyFilterName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorPolicyLifecycle.
    /// </summary>
    public class SnapmirrorPolicyLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for SnapmirrorPolicyLifecycle
        /// </summary>
        public static readonly SnapmirrorPolicyLifecycle CREATED = new SnapmirrorPolicyLifecycle("CREATED");

        /// <summary>
        /// Constant CREATING for SnapmirrorPolicyLifecycle
        /// </summary>
        public static readonly SnapmirrorPolicyLifecycle CREATING = new SnapmirrorPolicyLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for SnapmirrorPolicyLifecycle
        /// </summary>
        public static readonly SnapmirrorPolicyLifecycle DELETING = new SnapmirrorPolicyLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for SnapmirrorPolicyLifecycle
        /// </summary>
        public static readonly SnapmirrorPolicyLifecycle FAILED = new SnapmirrorPolicyLifecycle("FAILED");

        /// <summary>
        /// Constructs a custom SnapmirrorPolicyLifecycle for a value not among the defined constants.
        /// </summary>
        public SnapmirrorPolicyLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorPolicyLifecycle FindValue(string value)
        {
            return FindValue<SnapmirrorPolicyLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorPolicyLifecycle(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorPolicyScope.
    /// </summary>
    public class SnapmirrorPolicyScope : ConstantClass
    {
        /// <summary>
        /// Constant FILESYSTEM for SnapmirrorPolicyScope
        /// </summary>
        public static readonly SnapmirrorPolicyScope FILESYSTEM = new SnapmirrorPolicyScope("FILESYSTEM");

        /// <summary>
        /// Constant SVM for SnapmirrorPolicyScope
        /// </summary>
        public static readonly SnapmirrorPolicyScope SVM = new SnapmirrorPolicyScope("SVM");

        /// <summary>
        /// Constructs a custom SnapmirrorPolicyScope for a value not among the defined constants.
        /// </summary>
        public SnapmirrorPolicyScope(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorPolicyScope FindValue(string value)
        {
            return FindValue<SnapmirrorPolicyScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorPolicyScope(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorPolicySnapshotCopyMode.
    /// </summary>
    public class SnapmirrorPolicySnapshotCopyMode : ConstantClass
    {
        /// <summary>
        /// Constant COPY_ALL_SOURCE_SNAPSHOTS for SnapmirrorPolicySnapshotCopyMode
        /// </summary>
        public static readonly SnapmirrorPolicySnapshotCopyMode COPY_ALL_SOURCE_SNAPSHOTS = new SnapmirrorPolicySnapshotCopyMode("COPY_ALL_SOURCE_SNAPSHOTS");

        /// <summary>
        /// Constant COPY_LATEST_SOURCE_SNAPSHOT for SnapmirrorPolicySnapshotCopyMode
        /// </summary>
        public static readonly SnapmirrorPolicySnapshotCopyMode COPY_LATEST_SOURCE_SNAPSHOT = new SnapmirrorPolicySnapshotCopyMode("COPY_LATEST_SOURCE_SNAPSHOT");

        /// <summary>
        /// Constant NO_CREATE_SNAPSHOT_ON_SOURCE for SnapmirrorPolicySnapshotCopyMode
        /// </summary>
        public static readonly SnapmirrorPolicySnapshotCopyMode NO_CREATE_SNAPSHOT_ON_SOURCE = new SnapmirrorPolicySnapshotCopyMode("NO_CREATE_SNAPSHOT_ON_SOURCE");

        /// <summary>
        /// Constructs a custom SnapmirrorPolicySnapshotCopyMode for a value not among the defined constants.
        /// </summary>
        public SnapmirrorPolicySnapshotCopyMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorPolicySnapshotCopyMode FindValue(string value)
        {
            return FindValue<SnapmirrorPolicySnapshotCopyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorPolicySnapshotCopyMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorRelationshipFilterName.
    /// </summary>
    public class SnapmirrorRelationshipFilterName : ConstantClass
    {
        /// <summary>
        /// Constant DestinationVolumeId for SnapmirrorRelationshipFilterName
        /// </summary>
        public static readonly SnapmirrorRelationshipFilterName DestinationVolumeId = new SnapmirrorRelationshipFilterName("destination-volume-id");

        /// <summary>
        /// Constant FileSystemId for SnapmirrorRelationshipFilterName
        /// </summary>
        public static readonly SnapmirrorRelationshipFilterName FileSystemId = new SnapmirrorRelationshipFilterName("file-system-id");

        /// <summary>
        /// Constructs a custom SnapmirrorRelationshipFilterName for a value not among the defined constants.
        /// </summary>
        public SnapmirrorRelationshipFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorRelationshipFilterName FindValue(string value)
        {
            return FindValue<SnapmirrorRelationshipFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorRelationshipFilterName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorRelationshipLifecycle.
    /// </summary>
    public class SnapmirrorRelationshipLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for SnapmirrorRelationshipLifecycle
        /// </summary>
        public static readonly SnapmirrorRelationshipLifecycle CREATED = new SnapmirrorRelationshipLifecycle("CREATED");

        /// <summary>
        /// Constant CREATING for SnapmirrorRelationshipLifecycle
        /// </summary>
        public static readonly SnapmirrorRelationshipLifecycle CREATING = new SnapmirrorRelationshipLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for SnapmirrorRelationshipLifecycle
        /// </summary>
        public static readonly SnapmirrorRelationshipLifecycle DELETING = new SnapmirrorRelationshipLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for SnapmirrorRelationshipLifecycle
        /// </summary>
        public static readonly SnapmirrorRelationshipLifecycle FAILED = new SnapmirrorRelationshipLifecycle("FAILED");

        /// <summary>
        /// Constructs a custom SnapmirrorRelationshipLifecycle for a value not among the defined constants.
        /// </summary>
        public SnapmirrorRelationshipLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorRelationshipLifecycle FindValue(string value)
        {
            return FindValue<SnapmirrorRelationshipLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorRelationshipLifecycle(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapmirrorRelationshipState.
    /// </summary>
    public class SnapmirrorRelationshipState : ConstantClass
    {
        /// <summary>
        /// Constant BROKEN_OFF for SnapmirrorRelationshipState
        /// </summary>
        public static readonly SnapmirrorRelationshipState BROKEN_OFF = new SnapmirrorRelationshipState("BROKEN_OFF");

        /// <summary>
        /// Constant PAUSED for SnapmirrorRelationshipState
        /// </summary>
        public static readonly SnapmirrorRelationshipState PAUSED = new SnapmirrorRelationshipState("PAUSED");

        /// <summary>
        /// Constant SNAPMIRRORED for SnapmirrorRelationshipState
        /// </summary>
        public static readonly SnapmirrorRelationshipState SNAPMIRRORED = new SnapmirrorRelationshipState("SNAPMIRRORED");

        /// <summary>
        /// Constant TRANSFERRING for SnapmirrorRelationshipState
        /// </summary>
        public static readonly SnapmirrorRelationshipState TRANSFERRING = new SnapmirrorRelationshipState("TRANSFERRING");

        /// <summary>
        /// Constant UNINITIALIZED for SnapmirrorRelationshipState
        /// </summary>
        public static readonly SnapmirrorRelationshipState UNINITIALIZED = new SnapmirrorRelationshipState("UNINITIALIZED");

        /// <summary>
        /// Constructs a custom SnapmirrorRelationshipState for a value not among the defined constants.
        /// </summary>
        public SnapmirrorRelationshipState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapmirrorRelationshipState FindValue(string value)
        {
            return FindValue<SnapmirrorRelationshipState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapmirrorRelationshipState(string value)
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
        /// Constructs a custom SnapshotFilterName for a value not among the defined constants.
        /// </summary>
        public SnapshotFilterName(string value) : base(value) { }

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
        /// Constant FAILED for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle FAILED = new SnapshotLifecycle("FAILED");

        /// <summary>
        /// Constant PENDING for SnapshotLifecycle
        /// </summary>
        public static readonly SnapshotLifecycle PENDING = new SnapshotLifecycle("PENDING");

        /// <summary>
        /// Constructs a custom SnapshotLifecycle for a value not among the defined constants.
        /// </summary>
        public SnapshotLifecycle(string value) : base(value) { }

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
    /// Constants used for properties of type SnapshotPolicyFilterName.
    /// </summary>
    public class SnapshotPolicyFilterName : ConstantClass
    {
        /// <summary>
        /// Constant FileSystemId for SnapshotPolicyFilterName
        /// </summary>
        public static readonly SnapshotPolicyFilterName FileSystemId = new SnapshotPolicyFilterName("file-system-id");

        /// <summary>
        /// Constant StorageVirtualMachineId for SnapshotPolicyFilterName
        /// </summary>
        public static readonly SnapshotPolicyFilterName StorageVirtualMachineId = new SnapshotPolicyFilterName("storage-virtual-machine-id");

        /// <summary>
        /// Constructs a custom SnapshotPolicyFilterName for a value not among the defined constants.
        /// </summary>
        public SnapshotPolicyFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotPolicyFilterName FindValue(string value)
        {
            return FindValue<SnapshotPolicyFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotPolicyFilterName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapshotPolicyLifecycle.
    /// </summary>
    public class SnapshotPolicyLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for SnapshotPolicyLifecycle
        /// </summary>
        public static readonly SnapshotPolicyLifecycle CREATED = new SnapshotPolicyLifecycle("CREATED");

        /// <summary>
        /// Constant CREATING for SnapshotPolicyLifecycle
        /// </summary>
        public static readonly SnapshotPolicyLifecycle CREATING = new SnapshotPolicyLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for SnapshotPolicyLifecycle
        /// </summary>
        public static readonly SnapshotPolicyLifecycle DELETING = new SnapshotPolicyLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for SnapshotPolicyLifecycle
        /// </summary>
        public static readonly SnapshotPolicyLifecycle FAILED = new SnapshotPolicyLifecycle("FAILED");

        /// <summary>
        /// Constructs a custom SnapshotPolicyLifecycle for a value not among the defined constants.
        /// </summary>
        public SnapshotPolicyLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotPolicyLifecycle FindValue(string value)
        {
            return FindValue<SnapshotPolicyLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotPolicyLifecycle(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapshotPolicyRetentionPeriodType.
    /// </summary>
    public class SnapshotPolicyRetentionPeriodType : ConstantClass
    {
        /// <summary>
        /// Constant DAYS for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType DAYS = new SnapshotPolicyRetentionPeriodType("DAYS");

        /// <summary>
        /// Constant HOURS for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType HOURS = new SnapshotPolicyRetentionPeriodType("HOURS");

        /// <summary>
        /// Constant INFINITE for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType INFINITE = new SnapshotPolicyRetentionPeriodType("INFINITE");

        /// <summary>
        /// Constant MINUTES for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType MINUTES = new SnapshotPolicyRetentionPeriodType("MINUTES");

        /// <summary>
        /// Constant MONTHS for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType MONTHS = new SnapshotPolicyRetentionPeriodType("MONTHS");

        /// <summary>
        /// Constant SECONDS for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType SECONDS = new SnapshotPolicyRetentionPeriodType("SECONDS");

        /// <summary>
        /// Constant YEARS for SnapshotPolicyRetentionPeriodType
        /// </summary>
        public static readonly SnapshotPolicyRetentionPeriodType YEARS = new SnapshotPolicyRetentionPeriodType("YEARS");

        /// <summary>
        /// Constructs a custom SnapshotPolicyRetentionPeriodType for a value not among the defined constants.
        /// </summary>
        public SnapshotPolicyRetentionPeriodType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotPolicyRetentionPeriodType FindValue(string value)
        {
            return FindValue<SnapshotPolicyRetentionPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotPolicyRetentionPeriodType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapshotPolicyScope.
    /// </summary>
    public class SnapshotPolicyScope : ConstantClass
    {
        /// <summary>
        /// Constant FILESYSTEM for SnapshotPolicyScope
        /// </summary>
        public static readonly SnapshotPolicyScope FILESYSTEM = new SnapshotPolicyScope("FILESYSTEM");

        /// <summary>
        /// Constant SVM for SnapshotPolicyScope
        /// </summary>
        public static readonly SnapshotPolicyScope SVM = new SnapshotPolicyScope("SVM");

        /// <summary>
        /// Constructs a custom SnapshotPolicyScope for a value not among the defined constants.
        /// </summary>
        public SnapshotPolicyScope(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotPolicyScope FindValue(string value)
        {
            return FindValue<SnapshotPolicyScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotPolicyScope(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SnapshotType.
    /// </summary>
    public class SnapshotType : ConstantClass
    {
        /// <summary>
        /// Constant ONTAP for SnapshotType
        /// </summary>
        public static readonly SnapshotType ONTAP = new SnapshotType("ONTAP");

        /// <summary>
        /// Constant OPENZFS for SnapshotType
        /// </summary>
        public static readonly SnapshotType OPENZFS = new SnapshotType("OPENZFS");

        /// <summary>
        /// Constructs a custom SnapshotType for a value not among the defined constants.
        /// </summary>
        public SnapshotType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotType FindValue(string value)
        {
            return FindValue<SnapshotType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotType(string value)
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
        /// Constant CANCELLED for Status
        /// </summary>
        public static readonly Status CANCELLED = new Status("CANCELLED");

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
        /// Constant OPTIMIZING for Status
        /// </summary>
        public static readonly Status OPTIMIZING = new Status("OPTIMIZING");

        /// <summary>
        /// Constant PAUSED for Status
        /// </summary>
        public static readonly Status PAUSED = new Status("PAUSED");

        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");

        /// <summary>
        /// Constant UPDATED_OPTIMIZING for Status
        /// </summary>
        public static readonly Status UPDATED_OPTIMIZING = new Status("UPDATED_OPTIMIZING");

        /// <summary>
        /// Constructs a custom Status for a value not among the defined constants.
        /// </summary>
        public Status(string value) : base(value) { }

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
        /// Constant INTELLIGENT_TIERING for StorageType
        /// </summary>
        public static readonly StorageType INTELLIGENT_TIERING = new StorageType("INTELLIGENT_TIERING");

        /// <summary>
        /// Constant SSD for StorageType
        /// </summary>
        public static readonly StorageType SSD = new StorageType("SSD");

        /// <summary>
        /// Constructs a custom StorageType for a value not among the defined constants.
        /// </summary>
        public StorageType(string value) : base(value) { }

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
        /// Constructs a custom StorageVirtualMachineFilterName for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachineFilterName(string value) : base(value) { }

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
        /// Constructs a custom StorageVirtualMachineLifecycle for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachineLifecycle(string value) : base(value) { }

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
    /// Constants used for properties of type StorageVirtualMachinePeerApplication.
    /// </summary>
    public class StorageVirtualMachinePeerApplication : ConstantClass
    {
        /// <summary>
        /// Constant FILE_COPY for StorageVirtualMachinePeerApplication
        /// </summary>
        public static readonly StorageVirtualMachinePeerApplication FILE_COPY = new StorageVirtualMachinePeerApplication("FILE_COPY");

        /// <summary>
        /// Constant FLEXCACHE for StorageVirtualMachinePeerApplication
        /// </summary>
        public static readonly StorageVirtualMachinePeerApplication FLEXCACHE = new StorageVirtualMachinePeerApplication("FLEXCACHE");

        /// <summary>
        /// Constant LUN_COPY for StorageVirtualMachinePeerApplication
        /// </summary>
        public static readonly StorageVirtualMachinePeerApplication LUN_COPY = new StorageVirtualMachinePeerApplication("LUN_COPY");

        /// <summary>
        /// Constant SNAPMIRROR for StorageVirtualMachinePeerApplication
        /// </summary>
        public static readonly StorageVirtualMachinePeerApplication SNAPMIRROR = new StorageVirtualMachinePeerApplication("SNAPMIRROR");

        /// <summary>
        /// Constructs a custom StorageVirtualMachinePeerApplication for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachinePeerApplication(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachinePeerApplication FindValue(string value)
        {
            return FindValue<StorageVirtualMachinePeerApplication>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachinePeerApplication(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StorageVirtualMachinePeerFilterName.
    /// </summary>
    public class StorageVirtualMachinePeerFilterName : ConstantClass
    {
        /// <summary>
        /// Constant FileSystemId for StorageVirtualMachinePeerFilterName
        /// </summary>
        public static readonly StorageVirtualMachinePeerFilterName FileSystemId = new StorageVirtualMachinePeerFilterName("file-system-id");

        /// <summary>
        /// Constant StorageVirtualMachineId for StorageVirtualMachinePeerFilterName
        /// </summary>
        public static readonly StorageVirtualMachinePeerFilterName StorageVirtualMachineId = new StorageVirtualMachinePeerFilterName("storage-virtual-machine-id");

        /// <summary>
        /// Constructs a custom StorageVirtualMachinePeerFilterName for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachinePeerFilterName(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachinePeerFilterName FindValue(string value)
        {
            return FindValue<StorageVirtualMachinePeerFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachinePeerFilterName(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StorageVirtualMachinePeerLifecycle.
    /// </summary>
    public class StorageVirtualMachinePeerLifecycle : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for StorageVirtualMachinePeerLifecycle
        /// </summary>
        public static readonly StorageVirtualMachinePeerLifecycle CREATED = new StorageVirtualMachinePeerLifecycle("CREATED");

        /// <summary>
        /// Constant CREATING for StorageVirtualMachinePeerLifecycle
        /// </summary>
        public static readonly StorageVirtualMachinePeerLifecycle CREATING = new StorageVirtualMachinePeerLifecycle("CREATING");

        /// <summary>
        /// Constant DELETING for StorageVirtualMachinePeerLifecycle
        /// </summary>
        public static readonly StorageVirtualMachinePeerLifecycle DELETING = new StorageVirtualMachinePeerLifecycle("DELETING");

        /// <summary>
        /// Constant FAILED for StorageVirtualMachinePeerLifecycle
        /// </summary>
        public static readonly StorageVirtualMachinePeerLifecycle FAILED = new StorageVirtualMachinePeerLifecycle("FAILED");

        /// <summary>
        /// Constructs a custom StorageVirtualMachinePeerLifecycle for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachinePeerLifecycle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachinePeerLifecycle FindValue(string value)
        {
            return FindValue<StorageVirtualMachinePeerLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachinePeerLifecycle(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StorageVirtualMachinePeerState.
    /// </summary>
    public class StorageVirtualMachinePeerState : ConstantClass
    {
        /// <summary>
        /// Constant INITIALIZING for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState INITIALIZING = new StorageVirtualMachinePeerState("INITIALIZING");

        /// <summary>
        /// Constant INITIATED for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState INITIATED = new StorageVirtualMachinePeerState("INITIATED");

        /// <summary>
        /// Constant PEERED for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState PEERED = new StorageVirtualMachinePeerState("PEERED");

        /// <summary>
        /// Constant PENDING for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState PENDING = new StorageVirtualMachinePeerState("PENDING");

        /// <summary>
        /// Constant REJECTED for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState REJECTED = new StorageVirtualMachinePeerState("REJECTED");

        /// <summary>
        /// Constant SUSPENDED for StorageVirtualMachinePeerState
        /// </summary>
        public static readonly StorageVirtualMachinePeerState SUSPENDED = new StorageVirtualMachinePeerState("SUSPENDED");

        /// <summary>
        /// Constructs a custom StorageVirtualMachinePeerState for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachinePeerState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachinePeerState FindValue(string value)
        {
            return FindValue<StorageVirtualMachinePeerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachinePeerState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type StorageVirtualMachinePeerUpdateState.
    /// </summary>
    public class StorageVirtualMachinePeerUpdateState : ConstantClass
    {
        /// <summary>
        /// Constant PEERED for StorageVirtualMachinePeerUpdateState
        /// </summary>
        public static readonly StorageVirtualMachinePeerUpdateState PEERED = new StorageVirtualMachinePeerUpdateState("PEERED");

        /// <summary>
        /// Constant REJECTED for StorageVirtualMachinePeerUpdateState
        /// </summary>
        public static readonly StorageVirtualMachinePeerUpdateState REJECTED = new StorageVirtualMachinePeerUpdateState("REJECTED");

        /// <summary>
        /// Constant SUSPENDED for StorageVirtualMachinePeerUpdateState
        /// </summary>
        public static readonly StorageVirtualMachinePeerUpdateState SUSPENDED = new StorageVirtualMachinePeerUpdateState("SUSPENDED");

        /// <summary>
        /// Constructs a custom StorageVirtualMachinePeerUpdateState for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachinePeerUpdateState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachinePeerUpdateState FindValue(string value)
        {
            return FindValue<StorageVirtualMachinePeerUpdateState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachinePeerUpdateState(string value)
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
        /// Constructs a custom StorageVirtualMachineRootVolumeSecurityStyle for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachineRootVolumeSecurityStyle(string value) : base(value) { }

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
    /// Constants used for properties of type StorageVirtualMachineSubtype.
    /// </summary>
    public class StorageVirtualMachineSubtype : ConstantClass
    {
        /// <summary>
        /// Constant DEFAULT for StorageVirtualMachineSubtype
        /// </summary>
        public static readonly StorageVirtualMachineSubtype DEFAULT = new StorageVirtualMachineSubtype("DEFAULT");

        /// <summary>
        /// Constant DP_DESTINATION for StorageVirtualMachineSubtype
        /// </summary>
        public static readonly StorageVirtualMachineSubtype DP_DESTINATION = new StorageVirtualMachineSubtype("DP_DESTINATION");

        /// <summary>
        /// Constant SYNC_DESTINATION for StorageVirtualMachineSubtype
        /// </summary>
        public static readonly StorageVirtualMachineSubtype SYNC_DESTINATION = new StorageVirtualMachineSubtype("SYNC_DESTINATION");

        /// <summary>
        /// Constant SYNC_SOURCE for StorageVirtualMachineSubtype
        /// </summary>
        public static readonly StorageVirtualMachineSubtype SYNC_SOURCE = new StorageVirtualMachineSubtype("SYNC_SOURCE");

        /// <summary>
        /// Constructs a custom StorageVirtualMachineSubtype for a value not among the defined constants.
        /// </summary>
        public StorageVirtualMachineSubtype(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageVirtualMachineSubtype FindValue(string value)
        {
            return FindValue<StorageVirtualMachineSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageVirtualMachineSubtype(string value)
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
        /// Constructs a custom TieringPolicyName for a value not among the defined constants.
        /// </summary>
        public TieringPolicyName(string value) : base(value) { }

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
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {
        /// <summary>
        /// Constant DAYS for Unit
        /// </summary>
        public static readonly Unit DAYS = new Unit("DAYS");

        /// <summary>
        /// Constructs a custom Unit for a value not among the defined constants.
        /// </summary>
        public Unit(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdatableSnapmirrorRelationshipState.
    /// </summary>
    public class UpdatableSnapmirrorRelationshipState : ConstantClass
    {
        /// <summary>
        /// Constant BROKEN_OFF for UpdatableSnapmirrorRelationshipState
        /// </summary>
        public static readonly UpdatableSnapmirrorRelationshipState BROKEN_OFF = new UpdatableSnapmirrorRelationshipState("BROKEN_OFF");

        /// <summary>
        /// Constant PAUSED for UpdatableSnapmirrorRelationshipState
        /// </summary>
        public static readonly UpdatableSnapmirrorRelationshipState PAUSED = new UpdatableSnapmirrorRelationshipState("PAUSED");

        /// <summary>
        /// Constant SNAPMIRRORED for UpdatableSnapmirrorRelationshipState
        /// </summary>
        public static readonly UpdatableSnapmirrorRelationshipState SNAPMIRRORED = new UpdatableSnapmirrorRelationshipState("SNAPMIRRORED");

        /// <summary>
        /// Constructs a custom UpdatableSnapmirrorRelationshipState for a value not among the defined constants.
        /// </summary>
        public UpdatableSnapmirrorRelationshipState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdatableSnapmirrorRelationshipState FindValue(string value)
        {
            return FindValue<UpdatableSnapmirrorRelationshipState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdatableSnapmirrorRelationshipState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdateOpenZFSVolumeOption.
    /// </summary>
    public class UpdateOpenZFSVolumeOption : ConstantClass
    {
        /// <summary>
        /// Constant DELETE_CLONED_VOLUMES for UpdateOpenZFSVolumeOption
        /// </summary>
        public static readonly UpdateOpenZFSVolumeOption DELETE_CLONED_VOLUMES = new UpdateOpenZFSVolumeOption("DELETE_CLONED_VOLUMES");

        /// <summary>
        /// Constant DELETE_INTERMEDIATE_DATA for UpdateOpenZFSVolumeOption
        /// </summary>
        public static readonly UpdateOpenZFSVolumeOption DELETE_INTERMEDIATE_DATA = new UpdateOpenZFSVolumeOption("DELETE_INTERMEDIATE_DATA");

        /// <summary>
        /// Constant DELETE_INTERMEDIATE_SNAPSHOTS for UpdateOpenZFSVolumeOption
        /// </summary>
        public static readonly UpdateOpenZFSVolumeOption DELETE_INTERMEDIATE_SNAPSHOTS = new UpdateOpenZFSVolumeOption("DELETE_INTERMEDIATE_SNAPSHOTS");

        /// <summary>
        /// Constructs a custom UpdateOpenZFSVolumeOption for a value not among the defined constants.
        /// </summary>
        public UpdateOpenZFSVolumeOption(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateOpenZFSVolumeOption FindValue(string value)
        {
            return FindValue<UpdateOpenZFSVolumeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateOpenZFSVolumeOption(string value)
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
        /// Constructs a custom VolumeFilterName for a value not among the defined constants.
        /// </summary>
        public VolumeFilterName(string value) : base(value) { }

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
        /// Constructs a custom VolumeLifecycle for a value not among the defined constants.
        /// </summary>
        public VolumeLifecycle(string value) : base(value) { }

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
    /// Constants used for properties of type VolumeStyle.
    /// </summary>
    public class VolumeStyle : ConstantClass
    {
        /// <summary>
        /// Constant FLEXGROUP for VolumeStyle
        /// </summary>
        public static readonly VolumeStyle FLEXGROUP = new VolumeStyle("FLEXGROUP");

        /// <summary>
        /// Constant FLEXVOL for VolumeStyle
        /// </summary>
        public static readonly VolumeStyle FLEXVOL = new VolumeStyle("FLEXVOL");

        /// <summary>
        /// Constructs a custom VolumeStyle for a value not among the defined constants.
        /// </summary>
        public VolumeStyle(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStyle FindValue(string value)
        {
            return FindValue<VolumeStyle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeStyle(string value)
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
        /// Constructs a custom VolumeType for a value not among the defined constants.
        /// </summary>
        public VolumeType(string value) : base(value) { }

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
        /// Constructs a custom WindowsAccessAuditLogLevel for a value not among the defined constants.
        /// </summary>
        public WindowsAccessAuditLogLevel(string value) : base(value) { }

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
        /// Constructs a custom WindowsDeploymentType for a value not among the defined constants.
        /// </summary>
        public WindowsDeploymentType(string value) : base(value) { }

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

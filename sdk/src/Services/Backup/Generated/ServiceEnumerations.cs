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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Backup
{

    /// <summary>
    /// Constants used for properties of type BackupJobState.
    /// </summary>
    public class BackupJobState : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for BackupJobState
        /// </summary>
        public static readonly BackupJobState ABORTED = new BackupJobState("ABORTED");
        /// <summary>
        /// Constant ABORTING for BackupJobState
        /// </summary>
        public static readonly BackupJobState ABORTING = new BackupJobState("ABORTING");
        /// <summary>
        /// Constant COMPLETED for BackupJobState
        /// </summary>
        public static readonly BackupJobState COMPLETED = new BackupJobState("COMPLETED");
        /// <summary>
        /// Constant CREATED for BackupJobState
        /// </summary>
        public static readonly BackupJobState CREATED = new BackupJobState("CREATED");
        /// <summary>
        /// Constant EXPIRED for BackupJobState
        /// </summary>
        public static readonly BackupJobState EXPIRED = new BackupJobState("EXPIRED");
        /// <summary>
        /// Constant FAILED for BackupJobState
        /// </summary>
        public static readonly BackupJobState FAILED = new BackupJobState("FAILED");
        /// <summary>
        /// Constant PARTIAL for BackupJobState
        /// </summary>
        public static readonly BackupJobState PARTIAL = new BackupJobState("PARTIAL");
        /// <summary>
        /// Constant PENDING for BackupJobState
        /// </summary>
        public static readonly BackupJobState PENDING = new BackupJobState("PENDING");
        /// <summary>
        /// Constant RUNNING for BackupJobState
        /// </summary>
        public static readonly BackupJobState RUNNING = new BackupJobState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupJobState FindValue(string value)
        {
            return FindValue<BackupJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupVaultEvent.
    /// </summary>
    public class BackupVaultEvent : ConstantClass
    {

        /// <summary>
        /// Constant BACKUP_JOB_COMPLETED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_JOB_COMPLETED = new BackupVaultEvent("BACKUP_JOB_COMPLETED");
        /// <summary>
        /// Constant BACKUP_JOB_EXPIRED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_JOB_EXPIRED = new BackupVaultEvent("BACKUP_JOB_EXPIRED");
        /// <summary>
        /// Constant BACKUP_JOB_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_JOB_FAILED = new BackupVaultEvent("BACKUP_JOB_FAILED");
        /// <summary>
        /// Constant BACKUP_JOB_STARTED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_JOB_STARTED = new BackupVaultEvent("BACKUP_JOB_STARTED");
        /// <summary>
        /// Constant BACKUP_JOB_SUCCESSFUL for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_JOB_SUCCESSFUL = new BackupVaultEvent("BACKUP_JOB_SUCCESSFUL");
        /// <summary>
        /// Constant BACKUP_PLAN_CREATED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_PLAN_CREATED = new BackupVaultEvent("BACKUP_PLAN_CREATED");
        /// <summary>
        /// Constant BACKUP_PLAN_MODIFIED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent BACKUP_PLAN_MODIFIED = new BackupVaultEvent("BACKUP_PLAN_MODIFIED");
        /// <summary>
        /// Constant COPY_JOB_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent COPY_JOB_FAILED = new BackupVaultEvent("COPY_JOB_FAILED");
        /// <summary>
        /// Constant COPY_JOB_STARTED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent COPY_JOB_STARTED = new BackupVaultEvent("COPY_JOB_STARTED");
        /// <summary>
        /// Constant COPY_JOB_SUCCESSFUL for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent COPY_JOB_SUCCESSFUL = new BackupVaultEvent("COPY_JOB_SUCCESSFUL");
        /// <summary>
        /// Constant RECOVERY_POINT_MODIFIED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RECOVERY_POINT_MODIFIED = new BackupVaultEvent("RECOVERY_POINT_MODIFIED");
        /// <summary>
        /// Constant RESTORE_JOB_COMPLETED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RESTORE_JOB_COMPLETED = new BackupVaultEvent("RESTORE_JOB_COMPLETED");
        /// <summary>
        /// Constant RESTORE_JOB_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RESTORE_JOB_FAILED = new BackupVaultEvent("RESTORE_JOB_FAILED");
        /// <summary>
        /// Constant RESTORE_JOB_STARTED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RESTORE_JOB_STARTED = new BackupVaultEvent("RESTORE_JOB_STARTED");
        /// <summary>
        /// Constant RESTORE_JOB_SUCCESSFUL for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RESTORE_JOB_SUCCESSFUL = new BackupVaultEvent("RESTORE_JOB_SUCCESSFUL");
        /// <summary>
        /// Constant S3_BACKUP_OBJECT_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent S3_BACKUP_OBJECT_FAILED = new BackupVaultEvent("S3_BACKUP_OBJECT_FAILED");
        /// <summary>
        /// Constant S3_RESTORE_OBJECT_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent S3_RESTORE_OBJECT_FAILED = new BackupVaultEvent("S3_RESTORE_OBJECT_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupVaultEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupVaultEvent FindValue(string value)
        {
            return FindValue<BackupVaultEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupVaultEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionType.
    /// </summary>
    public class ConditionType : ConstantClass
    {

        /// <summary>
        /// Constant STRINGEQUALS for ConditionType
        /// </summary>
        public static readonly ConditionType STRINGEQUALS = new ConditionType("STRINGEQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionType FindValue(string value)
        {
            return FindValue<ConditionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CopyJobState.
    /// </summary>
    public class CopyJobState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CopyJobState
        /// </summary>
        public static readonly CopyJobState COMPLETED = new CopyJobState("COMPLETED");
        /// <summary>
        /// Constant CREATED for CopyJobState
        /// </summary>
        public static readonly CopyJobState CREATED = new CopyJobState("CREATED");
        /// <summary>
        /// Constant FAILED for CopyJobState
        /// </summary>
        public static readonly CopyJobState FAILED = new CopyJobState("FAILED");
        /// <summary>
        /// Constant PARTIAL for CopyJobState
        /// </summary>
        public static readonly CopyJobState PARTIAL = new CopyJobState("PARTIAL");
        /// <summary>
        /// Constant RUNNING for CopyJobState
        /// </summary>
        public static readonly CopyJobState RUNNING = new CopyJobState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyJobState FindValue(string value)
        {
            return FindValue<CopyJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LegalHoldStatus.
    /// </summary>
    public class LegalHoldStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for LegalHoldStatus
        /// </summary>
        public static readonly LegalHoldStatus ACTIVE = new LegalHoldStatus("ACTIVE");
        /// <summary>
        /// Constant CANCELED for LegalHoldStatus
        /// </summary>
        public static readonly LegalHoldStatus CANCELED = new LegalHoldStatus("CANCELED");
        /// <summary>
        /// Constant CANCELING for LegalHoldStatus
        /// </summary>
        public static readonly LegalHoldStatus CANCELING = new LegalHoldStatus("CANCELING");
        /// <summary>
        /// Constant CREATING for LegalHoldStatus
        /// </summary>
        public static readonly LegalHoldStatus CREATING = new LegalHoldStatus("CREATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LegalHoldStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LegalHoldStatus FindValue(string value)
        {
            return FindValue<LegalHoldStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LegalHoldStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecoveryPointStatus.
    /// </summary>
    public class RecoveryPointStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus COMPLETED = new RecoveryPointStatus("COMPLETED");
        /// <summary>
        /// Constant DELETING for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus DELETING = new RecoveryPointStatus("DELETING");
        /// <summary>
        /// Constant EXPIRED for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus EXPIRED = new RecoveryPointStatus("EXPIRED");
        /// <summary>
        /// Constant PARTIAL for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus PARTIAL = new RecoveryPointStatus("PARTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecoveryPointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecoveryPointStatus FindValue(string value)
        {
            return FindValue<RecoveryPointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecoveryPointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreJobStatus.
    /// </summary>
    public class RestoreJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for RestoreJobStatus
        /// </summary>
        public static readonly RestoreJobStatus ABORTED = new RestoreJobStatus("ABORTED");
        /// <summary>
        /// Constant COMPLETED for RestoreJobStatus
        /// </summary>
        public static readonly RestoreJobStatus COMPLETED = new RestoreJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for RestoreJobStatus
        /// </summary>
        public static readonly RestoreJobStatus FAILED = new RestoreJobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for RestoreJobStatus
        /// </summary>
        public static readonly RestoreJobStatus PENDING = new RestoreJobStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for RestoreJobStatus
        /// </summary>
        public static readonly RestoreJobStatus RUNNING = new RestoreJobStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreJobStatus FindValue(string value)
        {
            return FindValue<RestoreJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant COLD for StorageClass
        /// </summary>
        public static readonly StorageClass COLD = new StorageClass("COLD");
        /// <summary>
        /// Constant DELETED for StorageClass
        /// </summary>
        public static readonly StorageClass DELETED = new StorageClass("DELETED");
        /// <summary>
        /// Constant WARM for StorageClass
        /// </summary>
        public static readonly StorageClass WARM = new StorageClass("WARM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }

}
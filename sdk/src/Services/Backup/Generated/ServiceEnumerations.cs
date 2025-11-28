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
    /// Constants used for properties of type AggregationPeriod.
    /// </summary>
    public class AggregationPeriod : ConstantClass
    {

        /// <summary>
        /// Constant FOURTEEN_DAYS for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod FOURTEEN_DAYS = new AggregationPeriod("FOURTEEN_DAYS");
        /// <summary>
        /// Constant ONE_DAY for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod ONE_DAY = new AggregationPeriod("ONE_DAY");
        /// <summary>
        /// Constant SEVEN_DAYS for AggregationPeriod
        /// </summary>
        public static readonly AggregationPeriod SEVEN_DAYS = new AggregationPeriod("SEVEN_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationPeriod FindValue(string value)
        {
            return FindValue<AggregationPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationPeriod(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type BackupJobStatus.
    /// </summary>
    public class BackupJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus ABORTED = new BackupJobStatus("ABORTED");
        /// <summary>
        /// Constant ABORTING for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus ABORTING = new BackupJobStatus("ABORTING");
        /// <summary>
        /// Constant AGGREGATE_ALL for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus AGGREGATE_ALL = new BackupJobStatus("AGGREGATE_ALL");
        /// <summary>
        /// Constant ANY for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus ANY = new BackupJobStatus("ANY");
        /// <summary>
        /// Constant COMPLETED for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus COMPLETED = new BackupJobStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus CREATED = new BackupJobStatus("CREATED");
        /// <summary>
        /// Constant EXPIRED for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus EXPIRED = new BackupJobStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus FAILED = new BackupJobStatus("FAILED");
        /// <summary>
        /// Constant PARTIAL for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus PARTIAL = new BackupJobStatus("PARTIAL");
        /// <summary>
        /// Constant PENDING for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus PENDING = new BackupJobStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for BackupJobStatus
        /// </summary>
        public static readonly BackupJobStatus RUNNING = new BackupJobStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupJobStatus FindValue(string value)
        {
            return FindValue<BackupJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupJobStatus(string value)
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
        /// Constant CONTINUOUS_BACKUP_INTERRUPTED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent CONTINUOUS_BACKUP_INTERRUPTED = new BackupVaultEvent("CONTINUOUS_BACKUP_INTERRUPTED");
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
        /// Constant RECOVERY_POINT_INDEX_COMPLETED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RECOVERY_POINT_INDEX_COMPLETED = new BackupVaultEvent("RECOVERY_POINT_INDEX_COMPLETED");
        /// <summary>
        /// Constant RECOVERY_POINT_INDEX_DELETED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RECOVERY_POINT_INDEX_DELETED = new BackupVaultEvent("RECOVERY_POINT_INDEX_DELETED");
        /// <summary>
        /// Constant RECOVERY_POINT_INDEXING_FAILED for BackupVaultEvent
        /// </summary>
        public static readonly BackupVaultEvent RECOVERY_POINT_INDEXING_FAILED = new BackupVaultEvent("RECOVERY_POINT_INDEXING_FAILED");
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
    /// Constants used for properties of type CopyJobStatus.
    /// </summary>
    public class CopyJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus ABORTED = new CopyJobStatus("ABORTED");
        /// <summary>
        /// Constant ABORTING for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus ABORTING = new CopyJobStatus("ABORTING");
        /// <summary>
        /// Constant AGGREGATE_ALL for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus AGGREGATE_ALL = new CopyJobStatus("AGGREGATE_ALL");
        /// <summary>
        /// Constant ANY for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus ANY = new CopyJobStatus("ANY");
        /// <summary>
        /// Constant COMPLETED for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus COMPLETED = new CopyJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETING for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus COMPLETING = new CopyJobStatus("COMPLETING");
        /// <summary>
        /// Constant CREATED for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus CREATED = new CopyJobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus FAILED = new CopyJobStatus("FAILED");
        /// <summary>
        /// Constant FAILING for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus FAILING = new CopyJobStatus("FAILING");
        /// <summary>
        /// Constant PARTIAL for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus PARTIAL = new CopyJobStatus("PARTIAL");
        /// <summary>
        /// Constant RUNNING for CopyJobStatus
        /// </summary>
        public static readonly CopyJobStatus RUNNING = new CopyJobStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyJobStatus FindValue(string value)
        {
            return FindValue<CopyJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionKeyType.
    /// </summary>
    public class EncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for EncryptionKeyType
        /// </summary>
        public static readonly EncryptionKeyType AWS_OWNED_KMS_KEY = new EncryptionKeyType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KMS_KEY for EncryptionKeyType
        /// </summary>
        public static readonly EncryptionKeyType CUSTOMER_MANAGED_KMS_KEY = new EncryptionKeyType("CUSTOMER_MANAGED_KMS_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionKeyType FindValue(string value)
        {
            return FindValue<EncryptionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Index.
    /// </summary>
    public class Index : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Index
        /// </summary>
        public static readonly Index DISABLED = new Index("DISABLED");
        /// <summary>
        /// Constant ENABLED for Index
        /// </summary>
        public static readonly Index ENABLED = new Index("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Index(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Index FindValue(string value)
        {
            return FindValue<Index>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Index(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexStatus.
    /// </summary>
    public class IndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexStatus
        /// </summary>
        public static readonly IndexStatus ACTIVE = new IndexStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for IndexStatus
        /// </summary>
        public static readonly IndexStatus DELETING = new IndexStatus("DELETING");
        /// <summary>
        /// Constant FAILED for IndexStatus
        /// </summary>
        public static readonly IndexStatus FAILED = new IndexStatus("FAILED");
        /// <summary>
        /// Constant PENDING for IndexStatus
        /// </summary>
        public static readonly IndexStatus PENDING = new IndexStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexStatus FindValue(string value)
        {
            return FindValue<IndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexStatus(string value)
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
    /// Constants used for properties of type LifecycleDeleteAfterEvent.
    /// </summary>
    public class LifecycleDeleteAfterEvent : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_AFTER_COPY for LifecycleDeleteAfterEvent
        /// </summary>
        public static readonly LifecycleDeleteAfterEvent DELETE_AFTER_COPY = new LifecycleDeleteAfterEvent("DELETE_AFTER_COPY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleDeleteAfterEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleDeleteAfterEvent FindValue(string value)
        {
            return FindValue<LifecycleDeleteAfterEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleDeleteAfterEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareScanner.
    /// </summary>
    public class MalwareScanner : ConstantClass
    {

        /// <summary>
        /// Constant GUARDDUTY for MalwareScanner
        /// </summary>
        public static readonly MalwareScanner GUARDDUTY = new MalwareScanner("GUARDDUTY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareScanner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareScanner FindValue(string value)
        {
            return FindValue<MalwareScanner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareScanner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpaRevokeSessionStatus.
    /// </summary>
    public class MpaRevokeSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for MpaRevokeSessionStatus
        /// </summary>
        public static readonly MpaRevokeSessionStatus FAILED = new MpaRevokeSessionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for MpaRevokeSessionStatus
        /// </summary>
        public static readonly MpaRevokeSessionStatus PENDING = new MpaRevokeSessionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpaRevokeSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpaRevokeSessionStatus FindValue(string value)
        {
            return FindValue<MpaRevokeSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpaRevokeSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MpaSessionStatus.
    /// </summary>
    public class MpaSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for MpaSessionStatus
        /// </summary>
        public static readonly MpaSessionStatus APPROVED = new MpaSessionStatus("APPROVED");
        /// <summary>
        /// Constant FAILED for MpaSessionStatus
        /// </summary>
        public static readonly MpaSessionStatus FAILED = new MpaSessionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for MpaSessionStatus
        /// </summary>
        public static readonly MpaSessionStatus PENDING = new MpaSessionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MpaSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MpaSessionStatus FindValue(string value)
        {
            return FindValue<MpaSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MpaSessionStatus(string value)
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
        /// Constant AVAILABLE for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus AVAILABLE = new RecoveryPointStatus("AVAILABLE");
        /// <summary>
        /// Constant COMPLETED for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus COMPLETED = new RecoveryPointStatus("COMPLETED");
        /// <summary>
        /// Constant CREATING for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus CREATING = new RecoveryPointStatus("CREATING");
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
        /// Constant STOPPED for RecoveryPointStatus
        /// </summary>
        public static readonly RecoveryPointStatus STOPPED = new RecoveryPointStatus("STOPPED");

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
    /// Constants used for properties of type RestoreDeletionStatus.
    /// </summary>
    public class RestoreDeletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for RestoreDeletionStatus
        /// </summary>
        public static readonly RestoreDeletionStatus DELETING = new RestoreDeletionStatus("DELETING");
        /// <summary>
        /// Constant FAILED for RestoreDeletionStatus
        /// </summary>
        public static readonly RestoreDeletionStatus FAILED = new RestoreDeletionStatus("FAILED");
        /// <summary>
        /// Constant SUCCESSFUL for RestoreDeletionStatus
        /// </summary>
        public static readonly RestoreDeletionStatus SUCCESSFUL = new RestoreDeletionStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreDeletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreDeletionStatus FindValue(string value)
        {
            return FindValue<RestoreDeletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreDeletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreJobState.
    /// </summary>
    public class RestoreJobState : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState ABORTED = new RestoreJobState("ABORTED");
        /// <summary>
        /// Constant AGGREGATE_ALL for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState AGGREGATE_ALL = new RestoreJobState("AGGREGATE_ALL");
        /// <summary>
        /// Constant ANY for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState ANY = new RestoreJobState("ANY");
        /// <summary>
        /// Constant COMPLETED for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState COMPLETED = new RestoreJobState("COMPLETED");
        /// <summary>
        /// Constant CREATED for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState CREATED = new RestoreJobState("CREATED");
        /// <summary>
        /// Constant FAILED for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState FAILED = new RestoreJobState("FAILED");
        /// <summary>
        /// Constant PENDING for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState PENDING = new RestoreJobState("PENDING");
        /// <summary>
        /// Constant RUNNING for RestoreJobState
        /// </summary>
        public static readonly RestoreJobState RUNNING = new RestoreJobState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreJobState FindValue(string value)
        {
            return FindValue<RestoreJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreJobState(string value)
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
    /// Constants used for properties of type RestoreTestingRecoveryPointSelectionAlgorithm.
    /// </summary>
    public class RestoreTestingRecoveryPointSelectionAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant LATEST_WITHIN_WINDOW for RestoreTestingRecoveryPointSelectionAlgorithm
        /// </summary>
        public static readonly RestoreTestingRecoveryPointSelectionAlgorithm LATEST_WITHIN_WINDOW = new RestoreTestingRecoveryPointSelectionAlgorithm("LATEST_WITHIN_WINDOW");
        /// <summary>
        /// Constant RANDOM_WITHIN_WINDOW for RestoreTestingRecoveryPointSelectionAlgorithm
        /// </summary>
        public static readonly RestoreTestingRecoveryPointSelectionAlgorithm RANDOM_WITHIN_WINDOW = new RestoreTestingRecoveryPointSelectionAlgorithm("RANDOM_WITHIN_WINDOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreTestingRecoveryPointSelectionAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreTestingRecoveryPointSelectionAlgorithm FindValue(string value)
        {
            return FindValue<RestoreTestingRecoveryPointSelectionAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreTestingRecoveryPointSelectionAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreTestingRecoveryPointType.
    /// </summary>
    public class RestoreTestingRecoveryPointType : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS for RestoreTestingRecoveryPointType
        /// </summary>
        public static readonly RestoreTestingRecoveryPointType CONTINUOUS = new RestoreTestingRecoveryPointType("CONTINUOUS");
        /// <summary>
        /// Constant SNAPSHOT for RestoreTestingRecoveryPointType
        /// </summary>
        public static readonly RestoreTestingRecoveryPointType SNAPSHOT = new RestoreTestingRecoveryPointType("SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreTestingRecoveryPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreTestingRecoveryPointType FindValue(string value)
        {
            return FindValue<RestoreTestingRecoveryPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreTestingRecoveryPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreValidationStatus.
    /// </summary>
    public class RestoreValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RestoreValidationStatus
        /// </summary>
        public static readonly RestoreValidationStatus FAILED = new RestoreValidationStatus("FAILED");
        /// <summary>
        /// Constant SUCCESSFUL for RestoreValidationStatus
        /// </summary>
        public static readonly RestoreValidationStatus SUCCESSFUL = new RestoreValidationStatus("SUCCESSFUL");
        /// <summary>
        /// Constant TIMED_OUT for RestoreValidationStatus
        /// </summary>
        public static readonly RestoreValidationStatus TIMED_OUT = new RestoreValidationStatus("TIMED_OUT");
        /// <summary>
        /// Constant VALIDATING for RestoreValidationStatus
        /// </summary>
        public static readonly RestoreValidationStatus VALIDATING = new RestoreValidationStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreValidationStatus FindValue(string value)
        {
            return FindValue<RestoreValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreValidationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleExecutionType.
    /// </summary>
    public class RuleExecutionType : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS for RuleExecutionType
        /// </summary>
        public static readonly RuleExecutionType CONTINUOUS = new RuleExecutionType("CONTINUOUS");
        /// <summary>
        /// Constant CONTINUOUS_AND_SNAPSHOTS for RuleExecutionType
        /// </summary>
        public static readonly RuleExecutionType CONTINUOUS_AND_SNAPSHOTS = new RuleExecutionType("CONTINUOUS_AND_SNAPSHOTS");
        /// <summary>
        /// Constant SNAPSHOTS for RuleExecutionType
        /// </summary>
        public static readonly RuleExecutionType SNAPSHOTS = new RuleExecutionType("SNAPSHOTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleExecutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleExecutionType FindValue(string value)
        {
            return FindValue<RuleExecutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleExecutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanFinding.
    /// </summary>
    public class ScanFinding : ConstantClass
    {

        /// <summary>
        /// Constant MALWARE for ScanFinding
        /// </summary>
        public static readonly ScanFinding MALWARE = new ScanFinding("MALWARE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanFinding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanFinding FindValue(string value)
        {
            return FindValue<ScanFinding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanFinding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanJobState.
    /// </summary>
    public class ScanJobState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for ScanJobState
        /// </summary>
        public static readonly ScanJobState CANCELED = new ScanJobState("CANCELED");
        /// <summary>
        /// Constant COMPLETED for ScanJobState
        /// </summary>
        public static readonly ScanJobState COMPLETED = new ScanJobState("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ISSUES for ScanJobState
        /// </summary>
        public static readonly ScanJobState COMPLETED_WITH_ISSUES = new ScanJobState("COMPLETED_WITH_ISSUES");
        /// <summary>
        /// Constant FAILED for ScanJobState
        /// </summary>
        public static readonly ScanJobState FAILED = new ScanJobState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanJobState FindValue(string value)
        {
            return FindValue<ScanJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanJobStatus.
    /// </summary>
    public class ScanJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATE_ALL for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus AGGREGATE_ALL = new ScanJobStatus("AGGREGATE_ALL");
        /// <summary>
        /// Constant ANY for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus ANY = new ScanJobStatus("ANY");
        /// <summary>
        /// Constant CANCELED for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus CANCELED = new ScanJobStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus COMPLETED = new ScanJobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ISSUES for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus COMPLETED_WITH_ISSUES = new ScanJobStatus("COMPLETED_WITH_ISSUES");
        /// <summary>
        /// Constant CREATED for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus CREATED = new ScanJobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus FAILED = new ScanJobStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ScanJobStatus
        /// </summary>
        public static readonly ScanJobStatus RUNNING = new ScanJobStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanJobStatus FindValue(string value)
        {
            return FindValue<ScanJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanMode.
    /// </summary>
    public class ScanMode : ConstantClass
    {

        /// <summary>
        /// Constant FULL_SCAN for ScanMode
        /// </summary>
        public static readonly ScanMode FULL_SCAN = new ScanMode("FULL_SCAN");
        /// <summary>
        /// Constant INCREMENTAL_SCAN for ScanMode
        /// </summary>
        public static readonly ScanMode INCREMENTAL_SCAN = new ScanMode("INCREMENTAL_SCAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanMode FindValue(string value)
        {
            return FindValue<ScanMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanResourceType.
    /// </summary>
    public class ScanResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EBS for ScanResourceType
        /// </summary>
        public static readonly ScanResourceType EBS = new ScanResourceType("EBS");
        /// <summary>
        /// Constant EC2 for ScanResourceType
        /// </summary>
        public static readonly ScanResourceType EC2 = new ScanResourceType("EC2");
        /// <summary>
        /// Constant S3 for ScanResourceType
        /// </summary>
        public static readonly ScanResourceType S3 = new ScanResourceType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanResourceType FindValue(string value)
        {
            return FindValue<ScanResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanResultStatus.
    /// </summary>
    public class ScanResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant NO_THREATS_FOUND for ScanResultStatus
        /// </summary>
        public static readonly ScanResultStatus NO_THREATS_FOUND = new ScanResultStatus("NO_THREATS_FOUND");
        /// <summary>
        /// Constant THREATS_FOUND for ScanResultStatus
        /// </summary>
        public static readonly ScanResultStatus THREATS_FOUND = new ScanResultStatus("THREATS_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanResultStatus FindValue(string value)
        {
            return FindValue<ScanResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanState.
    /// </summary>
    public class ScanState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for ScanState
        /// </summary>
        public static readonly ScanState CANCELED = new ScanState("CANCELED");
        /// <summary>
        /// Constant COMPLETED for ScanState
        /// </summary>
        public static readonly ScanState COMPLETED = new ScanState("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ISSUES for ScanState
        /// </summary>
        public static readonly ScanState COMPLETED_WITH_ISSUES = new ScanState("COMPLETED_WITH_ISSUES");
        /// <summary>
        /// Constant CREATED for ScanState
        /// </summary>
        public static readonly ScanState CREATED = new ScanState("CREATED");
        /// <summary>
        /// Constant FAILED for ScanState
        /// </summary>
        public static readonly ScanState FAILED = new ScanState("FAILED");
        /// <summary>
        /// Constant RUNNING for ScanState
        /// </summary>
        public static readonly ScanState RUNNING = new ScanState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanState FindValue(string value)
        {
            return FindValue<ScanState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanState(string value)
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


    /// <summary>
    /// Constants used for properties of type VaultState.
    /// </summary>
    public class VaultState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VaultState
        /// </summary>
        public static readonly VaultState AVAILABLE = new VaultState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for VaultState
        /// </summary>
        public static readonly VaultState CREATING = new VaultState("CREATING");
        /// <summary>
        /// Constant FAILED for VaultState
        /// </summary>
        public static readonly VaultState FAILED = new VaultState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VaultState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VaultState FindValue(string value)
        {
            return FindValue<VaultState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VaultState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VaultType.
    /// </summary>
    public class VaultType : ConstantClass
    {

        /// <summary>
        /// Constant BACKUP_VAULT for VaultType
        /// </summary>
        public static readonly VaultType BACKUP_VAULT = new VaultType("BACKUP_VAULT");
        /// <summary>
        /// Constant LOGICALLY_AIR_GAPPED_BACKUP_VAULT for VaultType
        /// </summary>
        public static readonly VaultType LOGICALLY_AIR_GAPPED_BACKUP_VAULT = new VaultType("LOGICALLY_AIR_GAPPED_BACKUP_VAULT");
        /// <summary>
        /// Constant RESTORE_ACCESS_BACKUP_VAULT for VaultType
        /// </summary>
        public static readonly VaultType RESTORE_ACCESS_BACKUP_VAULT = new VaultType("RESTORE_ACCESS_BACKUP_VAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VaultType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VaultType FindValue(string value)
        {
            return FindValue<VaultType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VaultType(string value)
        {
            return FindValue(value);
        }
    }

}
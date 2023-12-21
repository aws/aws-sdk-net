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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeCommit
{

    /// <summary>
    /// Constants used for properties of type ApprovalState.
    /// </summary>
    public class ApprovalState : ConstantClass
    {

        /// <summary>
        /// Constant APPROVE for ApprovalState
        /// </summary>
        public static readonly ApprovalState APPROVE = new ApprovalState("APPROVE");
        /// <summary>
        /// Constant REVOKE for ApprovalState
        /// </summary>
        public static readonly ApprovalState REVOKE = new ApprovalState("REVOKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApprovalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalState FindValue(string value)
        {
            return FindValue<ApprovalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchGetRepositoriesErrorCodeEnum.
    /// </summary>
    public class BatchGetRepositoriesErrorCodeEnum : ConstantClass
    {

        /// <summary>
        /// Constant EncryptionIntegrityChecksFailedException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum EncryptionIntegrityChecksFailedException = new BatchGetRepositoriesErrorCodeEnum("EncryptionIntegrityChecksFailedException");
        /// <summary>
        /// Constant EncryptionKeyAccessDeniedException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum EncryptionKeyAccessDeniedException = new BatchGetRepositoriesErrorCodeEnum("EncryptionKeyAccessDeniedException");
        /// <summary>
        /// Constant EncryptionKeyDisabledException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum EncryptionKeyDisabledException = new BatchGetRepositoriesErrorCodeEnum("EncryptionKeyDisabledException");
        /// <summary>
        /// Constant EncryptionKeyNotFoundException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum EncryptionKeyNotFoundException = new BatchGetRepositoriesErrorCodeEnum("EncryptionKeyNotFoundException");
        /// <summary>
        /// Constant EncryptionKeyUnavailableException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum EncryptionKeyUnavailableException = new BatchGetRepositoriesErrorCodeEnum("EncryptionKeyUnavailableException");
        /// <summary>
        /// Constant RepositoryDoesNotExistException for BatchGetRepositoriesErrorCodeEnum
        /// </summary>
        public static readonly BatchGetRepositoriesErrorCodeEnum RepositoryDoesNotExistException = new BatchGetRepositoriesErrorCodeEnum("RepositoryDoesNotExistException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchGetRepositoriesErrorCodeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchGetRepositoriesErrorCodeEnum FindValue(string value)
        {
            return FindValue<BatchGetRepositoriesErrorCodeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchGetRepositoriesErrorCodeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeTypeEnum.
    /// </summary>
    public class ChangeTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant A for ChangeTypeEnum
        /// </summary>
        public static readonly ChangeTypeEnum A = new ChangeTypeEnum("A");
        /// <summary>
        /// Constant D for ChangeTypeEnum
        /// </summary>
        public static readonly ChangeTypeEnum D = new ChangeTypeEnum("D");
        /// <summary>
        /// Constant M for ChangeTypeEnum
        /// </summary>
        public static readonly ChangeTypeEnum M = new ChangeTypeEnum("M");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeTypeEnum FindValue(string value)
        {
            return FindValue<ChangeTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictDetailLevelTypeEnum.
    /// </summary>
    public class ConflictDetailLevelTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant FILE_LEVEL for ConflictDetailLevelTypeEnum
        /// </summary>
        public static readonly ConflictDetailLevelTypeEnum FILE_LEVEL = new ConflictDetailLevelTypeEnum("FILE_LEVEL");
        /// <summary>
        /// Constant LINE_LEVEL for ConflictDetailLevelTypeEnum
        /// </summary>
        public static readonly ConflictDetailLevelTypeEnum LINE_LEVEL = new ConflictDetailLevelTypeEnum("LINE_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictDetailLevelTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictDetailLevelTypeEnum FindValue(string value)
        {
            return FindValue<ConflictDetailLevelTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictDetailLevelTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictResolutionStrategyTypeEnum.
    /// </summary>
    public class ConflictResolutionStrategyTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT_DESTINATION for ConflictResolutionStrategyTypeEnum
        /// </summary>
        public static readonly ConflictResolutionStrategyTypeEnum ACCEPT_DESTINATION = new ConflictResolutionStrategyTypeEnum("ACCEPT_DESTINATION");
        /// <summary>
        /// Constant ACCEPT_SOURCE for ConflictResolutionStrategyTypeEnum
        /// </summary>
        public static readonly ConflictResolutionStrategyTypeEnum ACCEPT_SOURCE = new ConflictResolutionStrategyTypeEnum("ACCEPT_SOURCE");
        /// <summary>
        /// Constant AUTOMERGE for ConflictResolutionStrategyTypeEnum
        /// </summary>
        public static readonly ConflictResolutionStrategyTypeEnum AUTOMERGE = new ConflictResolutionStrategyTypeEnum("AUTOMERGE");
        /// <summary>
        /// Constant NONE for ConflictResolutionStrategyTypeEnum
        /// </summary>
        public static readonly ConflictResolutionStrategyTypeEnum NONE = new ConflictResolutionStrategyTypeEnum("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictResolutionStrategyTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictResolutionStrategyTypeEnum FindValue(string value)
        {
            return FindValue<ConflictResolutionStrategyTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictResolutionStrategyTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileModeTypeEnum.
    /// </summary>
    public class FileModeTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTABLE for FileModeTypeEnum
        /// </summary>
        public static readonly FileModeTypeEnum EXECUTABLE = new FileModeTypeEnum("EXECUTABLE");
        /// <summary>
        /// Constant NORMAL for FileModeTypeEnum
        /// </summary>
        public static readonly FileModeTypeEnum NORMAL = new FileModeTypeEnum("NORMAL");
        /// <summary>
        /// Constant SYMLINK for FileModeTypeEnum
        /// </summary>
        public static readonly FileModeTypeEnum SYMLINK = new FileModeTypeEnum("SYMLINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileModeTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileModeTypeEnum FindValue(string value)
        {
            return FindValue<FileModeTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileModeTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MergeOptionTypeEnum.
    /// </summary>
    public class MergeOptionTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant FAST_FORWARD_MERGE for MergeOptionTypeEnum
        /// </summary>
        public static readonly MergeOptionTypeEnum FAST_FORWARD_MERGE = new MergeOptionTypeEnum("FAST_FORWARD_MERGE");
        /// <summary>
        /// Constant SQUASH_MERGE for MergeOptionTypeEnum
        /// </summary>
        public static readonly MergeOptionTypeEnum SQUASH_MERGE = new MergeOptionTypeEnum("SQUASH_MERGE");
        /// <summary>
        /// Constant THREE_WAY_MERGE for MergeOptionTypeEnum
        /// </summary>
        public static readonly MergeOptionTypeEnum THREE_WAY_MERGE = new MergeOptionTypeEnum("THREE_WAY_MERGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MergeOptionTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MergeOptionTypeEnum FindValue(string value)
        {
            return FindValue<MergeOptionTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MergeOptionTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectTypeEnum.
    /// </summary>
    public class ObjectTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant DIRECTORY for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum DIRECTORY = new ObjectTypeEnum("DIRECTORY");
        /// <summary>
        /// Constant FILE for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum FILE = new ObjectTypeEnum("FILE");
        /// <summary>
        /// Constant GIT_LINK for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum GIT_LINK = new ObjectTypeEnum("GIT_LINK");
        /// <summary>
        /// Constant SYMBOLIC_LINK for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum SYMBOLIC_LINK = new ObjectTypeEnum("SYMBOLIC_LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectTypeEnum FindValue(string value)
        {
            return FindValue<ObjectTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderEnum.
    /// </summary>
    public class OrderEnum : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Ascending = new OrderEnum("ascending");
        /// <summary>
        /// Constant Descending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Descending = new OrderEnum("descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderEnum FindValue(string value)
        {
            return FindValue<OrderEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverrideStatus.
    /// </summary>
    public class OverrideStatus : ConstantClass
    {

        /// <summary>
        /// Constant OVERRIDE for OverrideStatus
        /// </summary>
        public static readonly OverrideStatus OVERRIDE = new OverrideStatus("OVERRIDE");
        /// <summary>
        /// Constant REVOKE for OverrideStatus
        /// </summary>
        public static readonly OverrideStatus REVOKE = new OverrideStatus("REVOKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverrideStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverrideStatus FindValue(string value)
        {
            return FindValue<OverrideStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverrideStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PullRequestEventType.
    /// </summary>
    public class PullRequestEventType : ConstantClass
    {

        /// <summary>
        /// Constant PULL_REQUEST_APPROVAL_RULE_CREATED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_APPROVAL_RULE_CREATED = new PullRequestEventType("PULL_REQUEST_APPROVAL_RULE_CREATED");
        /// <summary>
        /// Constant PULL_REQUEST_APPROVAL_RULE_DELETED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_APPROVAL_RULE_DELETED = new PullRequestEventType("PULL_REQUEST_APPROVAL_RULE_DELETED");
        /// <summary>
        /// Constant PULL_REQUEST_APPROVAL_RULE_OVERRIDDEN for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_APPROVAL_RULE_OVERRIDDEN = new PullRequestEventType("PULL_REQUEST_APPROVAL_RULE_OVERRIDDEN");
        /// <summary>
        /// Constant PULL_REQUEST_APPROVAL_RULE_UPDATED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_APPROVAL_RULE_UPDATED = new PullRequestEventType("PULL_REQUEST_APPROVAL_RULE_UPDATED");
        /// <summary>
        /// Constant PULL_REQUEST_APPROVAL_STATE_CHANGED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_APPROVAL_STATE_CHANGED = new PullRequestEventType("PULL_REQUEST_APPROVAL_STATE_CHANGED");
        /// <summary>
        /// Constant PULL_REQUEST_CREATED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_CREATED = new PullRequestEventType("PULL_REQUEST_CREATED");
        /// <summary>
        /// Constant PULL_REQUEST_MERGE_STATE_CHANGED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_MERGE_STATE_CHANGED = new PullRequestEventType("PULL_REQUEST_MERGE_STATE_CHANGED");
        /// <summary>
        /// Constant PULL_REQUEST_SOURCE_REFERENCE_UPDATED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_SOURCE_REFERENCE_UPDATED = new PullRequestEventType("PULL_REQUEST_SOURCE_REFERENCE_UPDATED");
        /// <summary>
        /// Constant PULL_REQUEST_STATUS_CHANGED for PullRequestEventType
        /// </summary>
        public static readonly PullRequestEventType PULL_REQUEST_STATUS_CHANGED = new PullRequestEventType("PULL_REQUEST_STATUS_CHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PullRequestEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PullRequestEventType FindValue(string value)
        {
            return FindValue<PullRequestEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PullRequestEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PullRequestStatusEnum.
    /// </summary>
    public class PullRequestStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for PullRequestStatusEnum
        /// </summary>
        public static readonly PullRequestStatusEnum CLOSED = new PullRequestStatusEnum("CLOSED");
        /// <summary>
        /// Constant OPEN for PullRequestStatusEnum
        /// </summary>
        public static readonly PullRequestStatusEnum OPEN = new PullRequestStatusEnum("OPEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PullRequestStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PullRequestStatusEnum FindValue(string value)
        {
            return FindValue<PullRequestStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PullRequestStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelativeFileVersionEnum.
    /// </summary>
    public class RelativeFileVersionEnum : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for RelativeFileVersionEnum
        /// </summary>
        public static readonly RelativeFileVersionEnum AFTER = new RelativeFileVersionEnum("AFTER");
        /// <summary>
        /// Constant BEFORE for RelativeFileVersionEnum
        /// </summary>
        public static readonly RelativeFileVersionEnum BEFORE = new RelativeFileVersionEnum("BEFORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelativeFileVersionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelativeFileVersionEnum FindValue(string value)
        {
            return FindValue<RelativeFileVersionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelativeFileVersionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplacementTypeEnum.
    /// </summary>
    public class ReplacementTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant KEEP_BASE for ReplacementTypeEnum
        /// </summary>
        public static readonly ReplacementTypeEnum KEEP_BASE = new ReplacementTypeEnum("KEEP_BASE");
        /// <summary>
        /// Constant KEEP_DESTINATION for ReplacementTypeEnum
        /// </summary>
        public static readonly ReplacementTypeEnum KEEP_DESTINATION = new ReplacementTypeEnum("KEEP_DESTINATION");
        /// <summary>
        /// Constant KEEP_SOURCE for ReplacementTypeEnum
        /// </summary>
        public static readonly ReplacementTypeEnum KEEP_SOURCE = new ReplacementTypeEnum("KEEP_SOURCE");
        /// <summary>
        /// Constant USE_NEW_CONTENT for ReplacementTypeEnum
        /// </summary>
        public static readonly ReplacementTypeEnum USE_NEW_CONTENT = new ReplacementTypeEnum("USE_NEW_CONTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplacementTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplacementTypeEnum FindValue(string value)
        {
            return FindValue<ReplacementTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplacementTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositoryTriggerEventEnum.
    /// </summary>
    public class RepositoryTriggerEventEnum : ConstantClass
    {

        /// <summary>
        /// Constant All for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum All = new RepositoryTriggerEventEnum("all");
        /// <summary>
        /// Constant CreateReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum CreateReference = new RepositoryTriggerEventEnum("createReference");
        /// <summary>
        /// Constant DeleteReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum DeleteReference = new RepositoryTriggerEventEnum("deleteReference");
        /// <summary>
        /// Constant UpdateReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum UpdateReference = new RepositoryTriggerEventEnum("updateReference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryTriggerEventEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryTriggerEventEnum FindValue(string value)
        {
            return FindValue<RepositoryTriggerEventEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryTriggerEventEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortByEnum.
    /// </summary>
    public class SortByEnum : ConstantClass
    {

        /// <summary>
        /// Constant LastModifiedDate for SortByEnum
        /// </summary>
        public static readonly SortByEnum LastModifiedDate = new SortByEnum("lastModifiedDate");
        /// <summary>
        /// Constant RepositoryName for SortByEnum
        /// </summary>
        public static readonly SortByEnum RepositoryName = new SortByEnum("repositoryName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortByEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortByEnum FindValue(string value)
        {
            return FindValue<SortByEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortByEnum(string value)
        {
            return FindValue(value);
        }
    }

}
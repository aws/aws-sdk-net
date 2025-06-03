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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodePipeline
{

    /// <summary>
    /// Constants used for properties of type ActionCategory.
    /// </summary>
    public class ActionCategory : ConstantClass
    {

        /// <summary>
        /// Constant Approval for ActionCategory
        /// </summary>
        public static readonly ActionCategory Approval = new ActionCategory("Approval");
        /// <summary>
        /// Constant Build for ActionCategory
        /// </summary>
        public static readonly ActionCategory Build = new ActionCategory("Build");
        /// <summary>
        /// Constant Compute for ActionCategory
        /// </summary>
        public static readonly ActionCategory Compute = new ActionCategory("Compute");
        /// <summary>
        /// Constant Deploy for ActionCategory
        /// </summary>
        public static readonly ActionCategory Deploy = new ActionCategory("Deploy");
        /// <summary>
        /// Constant Invoke for ActionCategory
        /// </summary>
        public static readonly ActionCategory Invoke = new ActionCategory("Invoke");
        /// <summary>
        /// Constant Source for ActionCategory
        /// </summary>
        public static readonly ActionCategory Source = new ActionCategory("Source");
        /// <summary>
        /// Constant Test for ActionCategory
        /// </summary>
        public static readonly ActionCategory Test = new ActionCategory("Test");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionCategory FindValue(string value)
        {
            return FindValue<ActionCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionConfigurationPropertyType.
    /// </summary>
    public class ActionConfigurationPropertyType : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for ActionConfigurationPropertyType
        /// </summary>
        public static readonly ActionConfigurationPropertyType Boolean = new ActionConfigurationPropertyType("Boolean");
        /// <summary>
        /// Constant Number for ActionConfigurationPropertyType
        /// </summary>
        public static readonly ActionConfigurationPropertyType Number = new ActionConfigurationPropertyType("Number");
        /// <summary>
        /// Constant String for ActionConfigurationPropertyType
        /// </summary>
        public static readonly ActionConfigurationPropertyType String = new ActionConfigurationPropertyType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionConfigurationPropertyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionConfigurationPropertyType FindValue(string value)
        {
            return FindValue<ActionConfigurationPropertyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionConfigurationPropertyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionExecutionStatus.
    /// </summary>
    public class ActionExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Abandoned for ActionExecutionStatus
        /// </summary>
        public static readonly ActionExecutionStatus Abandoned = new ActionExecutionStatus("Abandoned");
        /// <summary>
        /// Constant Failed for ActionExecutionStatus
        /// </summary>
        public static readonly ActionExecutionStatus Failed = new ActionExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for ActionExecutionStatus
        /// </summary>
        public static readonly ActionExecutionStatus InProgress = new ActionExecutionStatus("InProgress");
        /// <summary>
        /// Constant Succeeded for ActionExecutionStatus
        /// </summary>
        public static readonly ActionExecutionStatus Succeeded = new ActionExecutionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionExecutionStatus FindValue(string value)
        {
            return FindValue<ActionExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionOwner.
    /// </summary>
    public class ActionOwner : ConstantClass
    {

        /// <summary>
        /// Constant AWS for ActionOwner
        /// </summary>
        public static readonly ActionOwner AWS = new ActionOwner("AWS");
        /// <summary>
        /// Constant Custom for ActionOwner
        /// </summary>
        public static readonly ActionOwner Custom = new ActionOwner("Custom");
        /// <summary>
        /// Constant ThirdParty for ActionOwner
        /// </summary>
        public static readonly ActionOwner ThirdParty = new ActionOwner("ThirdParty");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionOwner FindValue(string value)
        {
            return FindValue<ActionOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApprovalStatus.
    /// </summary>
    public class ApprovalStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for ApprovalStatus
        /// </summary>
        public static readonly ApprovalStatus Approved = new ApprovalStatus("Approved");
        /// <summary>
        /// Constant Rejected for ApprovalStatus
        /// </summary>
        public static readonly ApprovalStatus Rejected = new ApprovalStatus("Rejected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApprovalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalStatus FindValue(string value)
        {
            return FindValue<ApprovalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactLocationType.
    /// </summary>
    public class ArtifactLocationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for ArtifactLocationType
        /// </summary>
        public static readonly ArtifactLocationType S3 = new ArtifactLocationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactLocationType FindValue(string value)
        {
            return FindValue<ArtifactLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactStoreType.
    /// </summary>
    public class ArtifactStoreType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for ArtifactStoreType
        /// </summary>
        public static readonly ArtifactStoreType S3 = new ArtifactStoreType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactStoreType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactStoreType FindValue(string value)
        {
            return FindValue<ArtifactStoreType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactStoreType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BlockerType.
    /// </summary>
    public class BlockerType : ConstantClass
    {

        /// <summary>
        /// Constant Schedule for BlockerType
        /// </summary>
        public static readonly BlockerType Schedule = new BlockerType("Schedule");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlockerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockerType FindValue(string value)
        {
            return FindValue<BlockerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConditionExecutionStatus.
    /// </summary>
    public class ConditionExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Abandoned for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Abandoned = new ConditionExecutionStatus("Abandoned");
        /// <summary>
        /// Constant Cancelled for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Cancelled = new ConditionExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Errored for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Errored = new ConditionExecutionStatus("Errored");
        /// <summary>
        /// Constant Failed for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Failed = new ConditionExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus InProgress = new ConditionExecutionStatus("InProgress");
        /// <summary>
        /// Constant Overridden for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Overridden = new ConditionExecutionStatus("Overridden");
        /// <summary>
        /// Constant Succeeded for ConditionExecutionStatus
        /// </summary>
        public static readonly ConditionExecutionStatus Succeeded = new ConditionExecutionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConditionExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConditionExecutionStatus FindValue(string value)
        {
            return FindValue<ConditionExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConditionExecutionStatus(string value)
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
        /// Constant BEFORE_ENTRY for ConditionType
        /// </summary>
        public static readonly ConditionType BEFORE_ENTRY = new ConditionType("BEFORE_ENTRY");
        /// <summary>
        /// Constant ON_SUCCESS for ConditionType
        /// </summary>
        public static readonly ConditionType ON_SUCCESS = new ConditionType("ON_SUCCESS");

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
    /// Constants used for properties of type EncryptionKeyType.
    /// </summary>
    public class EncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionKeyType
        /// </summary>
        public static readonly EncryptionKeyType KMS = new EncryptionKeyType("KMS");

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
    /// Constants used for properties of type EnvironmentVariableType.
    /// </summary>
    public class EnvironmentVariableType : ConstantClass
    {

        /// <summary>
        /// Constant PLAINTEXT for EnvironmentVariableType
        /// </summary>
        public static readonly EnvironmentVariableType PLAINTEXT = new EnvironmentVariableType("PLAINTEXT");
        /// <summary>
        /// Constant SECRETS_MANAGER for EnvironmentVariableType
        /// </summary>
        public static readonly EnvironmentVariableType SECRETS_MANAGER = new EnvironmentVariableType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentVariableType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentVariableType FindValue(string value)
        {
            return FindValue<EnvironmentVariableType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentVariableType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionMode.
    /// </summary>
    public class ExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant PARALLEL for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode PARALLEL = new ExecutionMode("PARALLEL");
        /// <summary>
        /// Constant QUEUED for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode QUEUED = new ExecutionMode("QUEUED");
        /// <summary>
        /// Constant SUPERSEDED for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode SUPERSEDED = new ExecutionMode("SUPERSEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionMode FindValue(string value)
        {
            return FindValue<ExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionType.
    /// </summary>
    public class ExecutionType : ConstantClass
    {

        /// <summary>
        /// Constant ROLLBACK for ExecutionType
        /// </summary>
        public static readonly ExecutionType ROLLBACK = new ExecutionType("ROLLBACK");
        /// <summary>
        /// Constant STANDARD for ExecutionType
        /// </summary>
        public static readonly ExecutionType STANDARD = new ExecutionType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionType FindValue(string value)
        {
            return FindValue<ExecutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutorType.
    /// </summary>
    public class ExecutorType : ConstantClass
    {

        /// <summary>
        /// Constant JobWorker for ExecutorType
        /// </summary>
        public static readonly ExecutorType JobWorker = new ExecutorType("JobWorker");
        /// <summary>
        /// Constant Lambda for ExecutorType
        /// </summary>
        public static readonly ExecutorType Lambda = new ExecutorType("Lambda");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutorType FindValue(string value)
        {
            return FindValue<ExecutorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureType.
    /// </summary>
    public class FailureType : ConstantClass
    {

        /// <summary>
        /// Constant ConfigurationError for FailureType
        /// </summary>
        public static readonly FailureType ConfigurationError = new FailureType("ConfigurationError");
        /// <summary>
        /// Constant JobFailed for FailureType
        /// </summary>
        public static readonly FailureType JobFailed = new FailureType("JobFailed");
        /// <summary>
        /// Constant PermissionError for FailureType
        /// </summary>
        public static readonly FailureType PermissionError = new FailureType("PermissionError");
        /// <summary>
        /// Constant RevisionOutOfSync for FailureType
        /// </summary>
        public static readonly FailureType RevisionOutOfSync = new FailureType("RevisionOutOfSync");
        /// <summary>
        /// Constant RevisionUnavailable for FailureType
        /// </summary>
        public static readonly FailureType RevisionUnavailable = new FailureType("RevisionUnavailable");
        /// <summary>
        /// Constant SystemUnavailable for FailureType
        /// </summary>
        public static readonly FailureType SystemUnavailable = new FailureType("SystemUnavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureType FindValue(string value)
        {
            return FindValue<FailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GitPullRequestEventType.
    /// </summary>
    public class GitPullRequestEventType : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for GitPullRequestEventType
        /// </summary>
        public static readonly GitPullRequestEventType CLOSED = new GitPullRequestEventType("CLOSED");
        /// <summary>
        /// Constant OPEN for GitPullRequestEventType
        /// </summary>
        public static readonly GitPullRequestEventType OPEN = new GitPullRequestEventType("OPEN");
        /// <summary>
        /// Constant UPDATED for GitPullRequestEventType
        /// </summary>
        public static readonly GitPullRequestEventType UPDATED = new GitPullRequestEventType("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GitPullRequestEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GitPullRequestEventType FindValue(string value)
        {
            return FindValue<GitPullRequestEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GitPullRequestEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Created for JobStatus
        /// </summary>
        public static readonly JobStatus Created = new JobStatus("Created");
        /// <summary>
        /// Constant Dispatched for JobStatus
        /// </summary>
        public static readonly JobStatus Dispatched = new JobStatus("Dispatched");
        /// <summary>
        /// Constant Failed for JobStatus
        /// </summary>
        public static readonly JobStatus Failed = new JobStatus("Failed");
        /// <summary>
        /// Constant InProgress for JobStatus
        /// </summary>
        public static readonly JobStatus InProgress = new JobStatus("InProgress");
        /// <summary>
        /// Constant Queued for JobStatus
        /// </summary>
        public static readonly JobStatus Queued = new JobStatus("Queued");
        /// <summary>
        /// Constant Succeeded for JobStatus
        /// </summary>
        public static readonly JobStatus Succeeded = new JobStatus("Succeeded");
        /// <summary>
        /// Constant TimedOut for JobStatus
        /// </summary>
        public static readonly JobStatus TimedOut = new JobStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineExecutionStatus.
    /// </summary>
    public class PipelineExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Cancelled = new PipelineExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Failed for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Failed = new PipelineExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus InProgress = new PipelineExecutionStatus("InProgress");
        /// <summary>
        /// Constant Stopped for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Stopped = new PipelineExecutionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Stopping = new PipelineExecutionStatus("Stopping");
        /// <summary>
        /// Constant Succeeded for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Succeeded = new PipelineExecutionStatus("Succeeded");
        /// <summary>
        /// Constant Superseded for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Superseded = new PipelineExecutionStatus("Superseded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineExecutionStatus FindValue(string value)
        {
            return FindValue<PipelineExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineTriggerProviderType.
    /// </summary>
    public class PipelineTriggerProviderType : ConstantClass
    {

        /// <summary>
        /// Constant CodeStarSourceConnection for PipelineTriggerProviderType
        /// </summary>
        public static readonly PipelineTriggerProviderType CodeStarSourceConnection = new PipelineTriggerProviderType("CodeStarSourceConnection");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineTriggerProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineTriggerProviderType FindValue(string value)
        {
            return FindValue<PipelineTriggerProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineTriggerProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineType.
    /// </summary>
    public class PipelineType : ConstantClass
    {

        /// <summary>
        /// Constant V1 for PipelineType
        /// </summary>
        public static readonly PipelineType V1 = new PipelineType("V1");
        /// <summary>
        /// Constant V2 for PipelineType
        /// </summary>
        public static readonly PipelineType V2 = new PipelineType("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineType FindValue(string value)
        {
            return FindValue<PipelineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Result.
    /// </summary>
    public class Result : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for Result
        /// </summary>
        public static readonly Result FAIL = new Result("FAIL");
        /// <summary>
        /// Constant RETRY for Result
        /// </summary>
        public static readonly Result RETRY = new Result("RETRY");
        /// <summary>
        /// Constant ROLLBACK for Result
        /// </summary>
        public static readonly Result ROLLBACK = new Result("ROLLBACK");
        /// <summary>
        /// Constant SKIP for Result
        /// </summary>
        public static readonly Result SKIP = new Result("SKIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Result(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Result FindValue(string value)
        {
            return FindValue<Result>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Result(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryTrigger.
    /// </summary>
    public class RetryTrigger : ConstantClass
    {

        /// <summary>
        /// Constant AutomatedStageRetry for RetryTrigger
        /// </summary>
        public static readonly RetryTrigger AutomatedStageRetry = new RetryTrigger("AutomatedStageRetry");
        /// <summary>
        /// Constant ManualStageRetry for RetryTrigger
        /// </summary>
        public static readonly RetryTrigger ManualStageRetry = new RetryTrigger("ManualStageRetry");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryTrigger(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryTrigger FindValue(string value)
        {
            return FindValue<RetryTrigger>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryTrigger(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleCategory.
    /// </summary>
    public class RuleCategory : ConstantClass
    {

        /// <summary>
        /// Constant Rule for RuleCategory
        /// </summary>
        public static readonly RuleCategory Rule = new RuleCategory("Rule");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleCategory FindValue(string value)
        {
            return FindValue<RuleCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleConfigurationPropertyType.
    /// </summary>
    public class RuleConfigurationPropertyType : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for RuleConfigurationPropertyType
        /// </summary>
        public static readonly RuleConfigurationPropertyType Boolean = new RuleConfigurationPropertyType("Boolean");
        /// <summary>
        /// Constant Number for RuleConfigurationPropertyType
        /// </summary>
        public static readonly RuleConfigurationPropertyType Number = new RuleConfigurationPropertyType("Number");
        /// <summary>
        /// Constant String for RuleConfigurationPropertyType
        /// </summary>
        public static readonly RuleConfigurationPropertyType String = new RuleConfigurationPropertyType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleConfigurationPropertyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleConfigurationPropertyType FindValue(string value)
        {
            return FindValue<RuleConfigurationPropertyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleConfigurationPropertyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleExecutionStatus.
    /// </summary>
    public class RuleExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Abandoned for RuleExecutionStatus
        /// </summary>
        public static readonly RuleExecutionStatus Abandoned = new RuleExecutionStatus("Abandoned");
        /// <summary>
        /// Constant Failed for RuleExecutionStatus
        /// </summary>
        public static readonly RuleExecutionStatus Failed = new RuleExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for RuleExecutionStatus
        /// </summary>
        public static readonly RuleExecutionStatus InProgress = new RuleExecutionStatus("InProgress");
        /// <summary>
        /// Constant Succeeded for RuleExecutionStatus
        /// </summary>
        public static readonly RuleExecutionStatus Succeeded = new RuleExecutionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleExecutionStatus FindValue(string value)
        {
            return FindValue<RuleExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleOwner.
    /// </summary>
    public class RuleOwner : ConstantClass
    {

        /// <summary>
        /// Constant AWS for RuleOwner
        /// </summary>
        public static readonly RuleOwner AWS = new RuleOwner("AWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleOwner FindValue(string value)
        {
            return FindValue<RuleOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceRevisionType.
    /// </summary>
    public class SourceRevisionType : ConstantClass
    {

        /// <summary>
        /// Constant COMMIT_ID for SourceRevisionType
        /// </summary>
        public static readonly SourceRevisionType COMMIT_ID = new SourceRevisionType("COMMIT_ID");
        /// <summary>
        /// Constant IMAGE_DIGEST for SourceRevisionType
        /// </summary>
        public static readonly SourceRevisionType IMAGE_DIGEST = new SourceRevisionType("IMAGE_DIGEST");
        /// <summary>
        /// Constant S3_OBJECT_KEY for SourceRevisionType
        /// </summary>
        public static readonly SourceRevisionType S3_OBJECT_KEY = new SourceRevisionType("S3_OBJECT_KEY");
        /// <summary>
        /// Constant S3_OBJECT_VERSION_ID for SourceRevisionType
        /// </summary>
        public static readonly SourceRevisionType S3_OBJECT_VERSION_ID = new SourceRevisionType("S3_OBJECT_VERSION_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceRevisionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceRevisionType FindValue(string value)
        {
            return FindValue<SourceRevisionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceRevisionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageExecutionStatus.
    /// </summary>
    public class StageExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Cancelled = new StageExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Failed for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Failed = new StageExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus InProgress = new StageExecutionStatus("InProgress");
        /// <summary>
        /// Constant Skipped for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Skipped = new StageExecutionStatus("Skipped");
        /// <summary>
        /// Constant Stopped for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Stopped = new StageExecutionStatus("Stopped");
        /// <summary>
        /// Constant Stopping for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Stopping = new StageExecutionStatus("Stopping");
        /// <summary>
        /// Constant Succeeded for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Succeeded = new StageExecutionStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageExecutionStatus FindValue(string value)
        {
            return FindValue<StageExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageRetryMode.
    /// </summary>
    public class StageRetryMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL_ACTIONS for StageRetryMode
        /// </summary>
        public static readonly StageRetryMode ALL_ACTIONS = new StageRetryMode("ALL_ACTIONS");
        /// <summary>
        /// Constant FAILED_ACTIONS for StageRetryMode
        /// </summary>
        public static readonly StageRetryMode FAILED_ACTIONS = new StageRetryMode("FAILED_ACTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageRetryMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageRetryMode FindValue(string value)
        {
            return FindValue<StageRetryMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageRetryMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageTransitionType.
    /// </summary>
    public class StageTransitionType : ConstantClass
    {

        /// <summary>
        /// Constant Inbound for StageTransitionType
        /// </summary>
        public static readonly StageTransitionType Inbound = new StageTransitionType("Inbound");
        /// <summary>
        /// Constant Outbound for StageTransitionType
        /// </summary>
        public static readonly StageTransitionType Outbound = new StageTransitionType("Outbound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageTransitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageTransitionType FindValue(string value)
        {
            return FindValue<StageTransitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageTransitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartTimeRange.
    /// </summary>
    public class StartTimeRange : ConstantClass
    {

        /// <summary>
        /// Constant All for StartTimeRange
        /// </summary>
        public static readonly StartTimeRange All = new StartTimeRange("All");
        /// <summary>
        /// Constant Latest for StartTimeRange
        /// </summary>
        public static readonly StartTimeRange Latest = new StartTimeRange("Latest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartTimeRange(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartTimeRange FindValue(string value)
        {
            return FindValue<StartTimeRange>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartTimeRange(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetFilterName.
    /// </summary>
    public class TargetFilterName : ConstantClass
    {

        /// <summary>
        /// Constant TARGET_STATUS for TargetFilterName
        /// </summary>
        public static readonly TargetFilterName TARGET_STATUS = new TargetFilterName("TARGET_STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetFilterName FindValue(string value)
        {
            return FindValue<TargetFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant AutomatedRollback for TriggerType
        /// </summary>
        public static readonly TriggerType AutomatedRollback = new TriggerType("AutomatedRollback");
        /// <summary>
        /// Constant CloudWatchEvent for TriggerType
        /// </summary>
        public static readonly TriggerType CloudWatchEvent = new TriggerType("CloudWatchEvent");
        /// <summary>
        /// Constant CreatePipeline for TriggerType
        /// </summary>
        public static readonly TriggerType CreatePipeline = new TriggerType("CreatePipeline");
        /// <summary>
        /// Constant ManualRollback for TriggerType
        /// </summary>
        public static readonly TriggerType ManualRollback = new TriggerType("ManualRollback");
        /// <summary>
        /// Constant PollForSourceChanges for TriggerType
        /// </summary>
        public static readonly TriggerType PollForSourceChanges = new TriggerType("PollForSourceChanges");
        /// <summary>
        /// Constant PutActionRevision for TriggerType
        /// </summary>
        public static readonly TriggerType PutActionRevision = new TriggerType("PutActionRevision");
        /// <summary>
        /// Constant StartPipelineExecution for TriggerType
        /// </summary>
        public static readonly TriggerType StartPipelineExecution = new TriggerType("StartPipelineExecution");
        /// <summary>
        /// Constant Webhook for TriggerType
        /// </summary>
        public static readonly TriggerType Webhook = new TriggerType("Webhook");
        /// <summary>
        /// Constant WebhookV2 for TriggerType
        /// </summary>
        public static readonly TriggerType WebhookV2 = new TriggerType("WebhookV2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookAuthenticationType.
    /// </summary>
    public class WebhookAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant GITHUB_HMAC for WebhookAuthenticationType
        /// </summary>
        public static readonly WebhookAuthenticationType GITHUB_HMAC = new WebhookAuthenticationType("GITHUB_HMAC");
        /// <summary>
        /// Constant IP for WebhookAuthenticationType
        /// </summary>
        public static readonly WebhookAuthenticationType IP = new WebhookAuthenticationType("IP");
        /// <summary>
        /// Constant UNAUTHENTICATED for WebhookAuthenticationType
        /// </summary>
        public static readonly WebhookAuthenticationType UNAUTHENTICATED = new WebhookAuthenticationType("UNAUTHENTICATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookAuthenticationType FindValue(string value)
        {
            return FindValue<WebhookAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }

}
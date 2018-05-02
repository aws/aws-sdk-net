/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// Constant Failed for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus Failed = new PipelineExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for PipelineExecutionStatus
        /// </summary>
        public static readonly PipelineExecutionStatus InProgress = new PipelineExecutionStatus("InProgress");
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
    /// Constants used for properties of type StageExecutionStatus.
    /// </summary>
    public class StageExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus Failed = new StageExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for StageExecutionStatus
        /// </summary>
        public static readonly StageExecutionStatus InProgress = new StageExecutionStatus("InProgress");
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
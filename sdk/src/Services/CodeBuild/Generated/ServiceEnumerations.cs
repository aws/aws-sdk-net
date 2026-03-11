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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeBuild
{

    /// <summary>
    /// Constants used for properties of type ArtifactNamespace.
    /// </summary>
    public class ArtifactNamespace : ConstantClass
    {

        /// <summary>
        /// Constant BUILD_ID for ArtifactNamespace
        /// </summary>
        public static readonly ArtifactNamespace BUILD_ID = new ArtifactNamespace("BUILD_ID");
        /// <summary>
        /// Constant NONE for ArtifactNamespace
        /// </summary>
        public static readonly ArtifactNamespace NONE = new ArtifactNamespace("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactNamespace FindValue(string value)
        {
            return FindValue<ArtifactNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactNamespace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactPackaging.
    /// </summary>
    public class ArtifactPackaging : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ArtifactPackaging
        /// </summary>
        public static readonly ArtifactPackaging NONE = new ArtifactPackaging("NONE");
        /// <summary>
        /// Constant ZIP for ArtifactPackaging
        /// </summary>
        public static readonly ArtifactPackaging ZIP = new ArtifactPackaging("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactPackaging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactPackaging FindValue(string value)
        {
            return FindValue<ArtifactPackaging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactPackaging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactsType.
    /// </summary>
    public class ArtifactsType : ConstantClass
    {

        /// <summary>
        /// Constant CODEPIPELINE for ArtifactsType
        /// </summary>
        public static readonly ArtifactsType CODEPIPELINE = new ArtifactsType("CODEPIPELINE");
        /// <summary>
        /// Constant NO_ARTIFACTS for ArtifactsType
        /// </summary>
        public static readonly ArtifactsType NO_ARTIFACTS = new ArtifactsType("NO_ARTIFACTS");
        /// <summary>
        /// Constant S3 for ArtifactsType
        /// </summary>
        public static readonly ArtifactsType S3 = new ArtifactsType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactsType FindValue(string value)
        {
            return FindValue<ArtifactsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC_AUTH for AuthType
        /// </summary>
        public static readonly AuthType BASIC_AUTH = new AuthType("BASIC_AUTH");
        /// <summary>
        /// Constant CODECONNECTIONS for AuthType
        /// </summary>
        public static readonly AuthType CODECONNECTIONS = new AuthType("CODECONNECTIONS");
        /// <summary>
        /// Constant OAUTH for AuthType
        /// </summary>
        public static readonly AuthType OAUTH = new AuthType("OAUTH");
        /// <summary>
        /// Constant PERSONAL_ACCESS_TOKEN for AuthType
        /// </summary>
        public static readonly AuthType PERSONAL_ACCESS_TOKEN = new AuthType("PERSONAL_ACCESS_TOKEN");
        /// <summary>
        /// Constant SECRETS_MANAGER for AuthType
        /// </summary>
        public static readonly AuthType SECRETS_MANAGER = new AuthType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchReportModeType.
    /// </summary>
    public class BatchReportModeType : ConstantClass
    {

        /// <summary>
        /// Constant REPORT_AGGREGATED_BATCH for BatchReportModeType
        /// </summary>
        public static readonly BatchReportModeType REPORT_AGGREGATED_BATCH = new BatchReportModeType("REPORT_AGGREGATED_BATCH");
        /// <summary>
        /// Constant REPORT_INDIVIDUAL_BUILDS for BatchReportModeType
        /// </summary>
        public static readonly BatchReportModeType REPORT_INDIVIDUAL_BUILDS = new BatchReportModeType("REPORT_INDIVIDUAL_BUILDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchReportModeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchReportModeType FindValue(string value)
        {
            return FindValue<BatchReportModeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchReportModeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketOwnerAccess.
    /// </summary>
    public class BucketOwnerAccess : ConstantClass
    {

        /// <summary>
        /// Constant FULL for BucketOwnerAccess
        /// </summary>
        public static readonly BucketOwnerAccess FULL = new BucketOwnerAccess("FULL");
        /// <summary>
        /// Constant NONE for BucketOwnerAccess
        /// </summary>
        public static readonly BucketOwnerAccess NONE = new BucketOwnerAccess("NONE");
        /// <summary>
        /// Constant READ_ONLY for BucketOwnerAccess
        /// </summary>
        public static readonly BucketOwnerAccess READ_ONLY = new BucketOwnerAccess("READ_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketOwnerAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketOwnerAccess FindValue(string value)
        {
            return FindValue<BucketOwnerAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketOwnerAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuildBatchPhaseType.
    /// </summary>
    public class BuildBatchPhaseType : ConstantClass
    {

        /// <summary>
        /// Constant COMBINE_ARTIFACTS for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType COMBINE_ARTIFACTS = new BuildBatchPhaseType("COMBINE_ARTIFACTS");
        /// <summary>
        /// Constant DOWNLOAD_BATCHSPEC for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType DOWNLOAD_BATCHSPEC = new BuildBatchPhaseType("DOWNLOAD_BATCHSPEC");
        /// <summary>
        /// Constant FAILED for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType FAILED = new BuildBatchPhaseType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType IN_PROGRESS = new BuildBatchPhaseType("IN_PROGRESS");
        /// <summary>
        /// Constant STOPPED for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType STOPPED = new BuildBatchPhaseType("STOPPED");
        /// <summary>
        /// Constant SUBMITTED for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType SUBMITTED = new BuildBatchPhaseType("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for BuildBatchPhaseType
        /// </summary>
        public static readonly BuildBatchPhaseType SUCCEEDED = new BuildBatchPhaseType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildBatchPhaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildBatchPhaseType FindValue(string value)
        {
            return FindValue<BuildBatchPhaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildBatchPhaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuildPhaseType.
    /// </summary>
    public class BuildPhaseType : ConstantClass
    {

        /// <summary>
        /// Constant BUILD for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType BUILD = new BuildPhaseType("BUILD");
        /// <summary>
        /// Constant COMPLETED for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType COMPLETED = new BuildPhaseType("COMPLETED");
        /// <summary>
        /// Constant DOWNLOAD_SOURCE for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType DOWNLOAD_SOURCE = new BuildPhaseType("DOWNLOAD_SOURCE");
        /// <summary>
        /// Constant FINALIZING for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType FINALIZING = new BuildPhaseType("FINALIZING");
        /// <summary>
        /// Constant INSTALL for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType INSTALL = new BuildPhaseType("INSTALL");
        /// <summary>
        /// Constant POST_BUILD for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType POST_BUILD = new BuildPhaseType("POST_BUILD");
        /// <summary>
        /// Constant PRE_BUILD for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType PRE_BUILD = new BuildPhaseType("PRE_BUILD");
        /// <summary>
        /// Constant PROVISIONING for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType PROVISIONING = new BuildPhaseType("PROVISIONING");
        /// <summary>
        /// Constant QUEUED for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType QUEUED = new BuildPhaseType("QUEUED");
        /// <summary>
        /// Constant SUBMITTED for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType SUBMITTED = new BuildPhaseType("SUBMITTED");
        /// <summary>
        /// Constant UPLOAD_ARTIFACTS for BuildPhaseType
        /// </summary>
        public static readonly BuildPhaseType UPLOAD_ARTIFACTS = new BuildPhaseType("UPLOAD_ARTIFACTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildPhaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildPhaseType FindValue(string value)
        {
            return FindValue<BuildPhaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildPhaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheMode.
    /// </summary>
    public class CacheMode : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL_CUSTOM_CACHE for CacheMode
        /// </summary>
        public static readonly CacheMode LOCAL_CUSTOM_CACHE = new CacheMode("LOCAL_CUSTOM_CACHE");
        /// <summary>
        /// Constant LOCAL_DOCKER_LAYER_CACHE for CacheMode
        /// </summary>
        public static readonly CacheMode LOCAL_DOCKER_LAYER_CACHE = new CacheMode("LOCAL_DOCKER_LAYER_CACHE");
        /// <summary>
        /// Constant LOCAL_SOURCE_CACHE for CacheMode
        /// </summary>
        public static readonly CacheMode LOCAL_SOURCE_CACHE = new CacheMode("LOCAL_SOURCE_CACHE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheMode FindValue(string value)
        {
            return FindValue<CacheMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheType.
    /// </summary>
    public class CacheType : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL for CacheType
        /// </summary>
        public static readonly CacheType LOCAL = new CacheType("LOCAL");
        /// <summary>
        /// Constant NO_CACHE for CacheType
        /// </summary>
        public static readonly CacheType NO_CACHE = new CacheType("NO_CACHE");
        /// <summary>
        /// Constant S3 for CacheType
        /// </summary>
        public static readonly CacheType S3 = new CacheType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheType FindValue(string value)
        {
            return FindValue<CacheType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandType.
    /// </summary>
    public class CommandType : ConstantClass
    {

        /// <summary>
        /// Constant SHELL for CommandType
        /// </summary>
        public static readonly CommandType SHELL = new CommandType("SHELL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandType FindValue(string value)
        {
            return FindValue<CommandType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

        /// <summary>
        /// Constant ATTRIBUTE_BASED_COMPUTE for ComputeType
        /// </summary>
        public static readonly ComputeType ATTRIBUTE_BASED_COMPUTE = new ComputeType("ATTRIBUTE_BASED_COMPUTE");
        /// <summary>
        /// Constant BUILD_GENERAL1_2XLARGE for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_2XLARGE = new ComputeType("BUILD_GENERAL1_2XLARGE");
        /// <summary>
        /// Constant BUILD_GENERAL1_LARGE for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_LARGE = new ComputeType("BUILD_GENERAL1_LARGE");
        /// <summary>
        /// Constant BUILD_GENERAL1_MEDIUM for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_MEDIUM = new ComputeType("BUILD_GENERAL1_MEDIUM");
        /// <summary>
        /// Constant BUILD_GENERAL1_SMALL for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_SMALL = new ComputeType("BUILD_GENERAL1_SMALL");
        /// <summary>
        /// Constant BUILD_GENERAL1_XLARGE for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_GENERAL1_XLARGE = new ComputeType("BUILD_GENERAL1_XLARGE");
        /// <summary>
        /// Constant BUILD_LAMBDA_10GB for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_LAMBDA_10GB = new ComputeType("BUILD_LAMBDA_10GB");
        /// <summary>
        /// Constant BUILD_LAMBDA_1GB for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_LAMBDA_1GB = new ComputeType("BUILD_LAMBDA_1GB");
        /// <summary>
        /// Constant BUILD_LAMBDA_2GB for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_LAMBDA_2GB = new ComputeType("BUILD_LAMBDA_2GB");
        /// <summary>
        /// Constant BUILD_LAMBDA_4GB for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_LAMBDA_4GB = new ComputeType("BUILD_LAMBDA_4GB");
        /// <summary>
        /// Constant BUILD_LAMBDA_8GB for ComputeType
        /// </summary>
        public static readonly ComputeType BUILD_LAMBDA_8GB = new ComputeType("BUILD_LAMBDA_8GB");
        /// <summary>
        /// Constant CUSTOM_INSTANCE_TYPE for ComputeType
        /// </summary>
        public static readonly ComputeType CUSTOM_INSTANCE_TYPE = new ComputeType("CUSTOM_INSTANCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeType FindValue(string value)
        {
            return FindValue<ComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CredentialProviderType.
    /// </summary>
    public class CredentialProviderType : ConstantClass
    {

        /// <summary>
        /// Constant SECRETS_MANAGER for CredentialProviderType
        /// </summary>
        public static readonly CredentialProviderType SECRETS_MANAGER = new CredentialProviderType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CredentialProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CredentialProviderType FindValue(string value)
        {
            return FindValue<CredentialProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CredentialProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentType.
    /// </summary>
    public class EnvironmentType : ConstantClass
    {

        /// <summary>
        /// Constant ARM_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType ARM_CONTAINER = new EnvironmentType("ARM_CONTAINER");
        /// <summary>
        /// Constant ARM_EC2 for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType ARM_EC2 = new EnvironmentType("ARM_EC2");
        /// <summary>
        /// Constant ARM_LAMBDA_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType ARM_LAMBDA_CONTAINER = new EnvironmentType("ARM_LAMBDA_CONTAINER");
        /// <summary>
        /// Constant LINUX_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_CONTAINER = new EnvironmentType("LINUX_CONTAINER");
        /// <summary>
        /// Constant LINUX_EC2 for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_EC2 = new EnvironmentType("LINUX_EC2");
        /// <summary>
        /// Constant LINUX_GPU_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_GPU_CONTAINER = new EnvironmentType("LINUX_GPU_CONTAINER");
        /// <summary>
        /// Constant LINUX_LAMBDA_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_LAMBDA_CONTAINER = new EnvironmentType("LINUX_LAMBDA_CONTAINER");
        /// <summary>
        /// Constant MAC_ARM for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType MAC_ARM = new EnvironmentType("MAC_ARM");
        /// <summary>
        /// Constant WINDOWS_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_CONTAINER = new EnvironmentType("WINDOWS_CONTAINER");
        /// <summary>
        /// Constant WINDOWS_EC2 for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_EC2 = new EnvironmentType("WINDOWS_EC2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_SERVER_2019_CONTAINER = new EnvironmentType("WINDOWS_SERVER_2019_CONTAINER");
        /// <summary>
        /// Constant WINDOWS_SERVER_2022_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_SERVER_2022_CONTAINER = new EnvironmentType("WINDOWS_SERVER_2022_CONTAINER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentType FindValue(string value)
        {
            return FindValue<EnvironmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentType(string value)
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
        /// Constant PARAMETER_STORE for EnvironmentVariableType
        /// </summary>
        public static readonly EnvironmentVariableType PARAMETER_STORE = new EnvironmentVariableType("PARAMETER_STORE");
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
    /// Constants used for properties of type FileSystemType.
    /// </summary>
    public class FileSystemType : ConstantClass
    {

        /// <summary>
        /// Constant EFS for FileSystemType
        /// </summary>
        public static readonly FileSystemType EFS = new FileSystemType("EFS");

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
    /// Constants used for properties of type FleetContextCode.
    /// </summary>
    public class FleetContextCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_REQUIRED for FleetContextCode
        /// </summary>
        public static readonly FleetContextCode ACTION_REQUIRED = new FleetContextCode("ACTION_REQUIRED");
        /// <summary>
        /// Constant CREATE_FAILED for FleetContextCode
        /// </summary>
        public static readonly FleetContextCode CREATE_FAILED = new FleetContextCode("CREATE_FAILED");
        /// <summary>
        /// Constant INSUFFICIENT_CAPACITY for FleetContextCode
        /// </summary>
        public static readonly FleetContextCode INSUFFICIENT_CAPACITY = new FleetContextCode("INSUFFICIENT_CAPACITY");
        /// <summary>
        /// Constant PENDING_DELETION for FleetContextCode
        /// </summary>
        public static readonly FleetContextCode PENDING_DELETION = new FleetContextCode("PENDING_DELETION");
        /// <summary>
        /// Constant UPDATE_FAILED for FleetContextCode
        /// </summary>
        public static readonly FleetContextCode UPDATE_FAILED = new FleetContextCode("UPDATE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetContextCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetContextCode FindValue(string value)
        {
            return FindValue<FleetContextCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetContextCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetOverflowBehavior.
    /// </summary>
    public class FleetOverflowBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for FleetOverflowBehavior
        /// </summary>
        public static readonly FleetOverflowBehavior ON_DEMAND = new FleetOverflowBehavior("ON_DEMAND");
        /// <summary>
        /// Constant QUEUE for FleetOverflowBehavior
        /// </summary>
        public static readonly FleetOverflowBehavior QUEUE = new FleetOverflowBehavior("QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetOverflowBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetOverflowBehavior FindValue(string value)
        {
            return FindValue<FleetOverflowBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetOverflowBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetProxyRuleBehavior.
    /// </summary>
    public class FleetProxyRuleBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ALL for FleetProxyRuleBehavior
        /// </summary>
        public static readonly FleetProxyRuleBehavior ALLOW_ALL = new FleetProxyRuleBehavior("ALLOW_ALL");
        /// <summary>
        /// Constant DENY_ALL for FleetProxyRuleBehavior
        /// </summary>
        public static readonly FleetProxyRuleBehavior DENY_ALL = new FleetProxyRuleBehavior("DENY_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetProxyRuleBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetProxyRuleBehavior FindValue(string value)
        {
            return FindValue<FleetProxyRuleBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetProxyRuleBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetProxyRuleEffectType.
    /// </summary>
    public class FleetProxyRuleEffectType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for FleetProxyRuleEffectType
        /// </summary>
        public static readonly FleetProxyRuleEffectType ALLOW = new FleetProxyRuleEffectType("ALLOW");
        /// <summary>
        /// Constant DENY for FleetProxyRuleEffectType
        /// </summary>
        public static readonly FleetProxyRuleEffectType DENY = new FleetProxyRuleEffectType("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetProxyRuleEffectType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetProxyRuleEffectType FindValue(string value)
        {
            return FindValue<FleetProxyRuleEffectType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetProxyRuleEffectType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetProxyRuleType.
    /// </summary>
    public class FleetProxyRuleType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN for FleetProxyRuleType
        /// </summary>
        public static readonly FleetProxyRuleType DOMAIN = new FleetProxyRuleType("DOMAIN");
        /// <summary>
        /// Constant IP for FleetProxyRuleType
        /// </summary>
        public static readonly FleetProxyRuleType IP = new FleetProxyRuleType("IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetProxyRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetProxyRuleType FindValue(string value)
        {
            return FindValue<FleetProxyRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetProxyRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetScalingMetricType.
    /// </summary>
    public class FleetScalingMetricType : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_UTILIZATION_RATE for FleetScalingMetricType
        /// </summary>
        public static readonly FleetScalingMetricType FLEET_UTILIZATION_RATE = new FleetScalingMetricType("FLEET_UTILIZATION_RATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetScalingMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetScalingMetricType FindValue(string value)
        {
            return FindValue<FleetScalingMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetScalingMetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetScalingType.
    /// </summary>
    public class FleetScalingType : ConstantClass
    {

        /// <summary>
        /// Constant TARGET_TRACKING_SCALING for FleetScalingType
        /// </summary>
        public static readonly FleetScalingType TARGET_TRACKING_SCALING = new FleetScalingType("TARGET_TRACKING_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetScalingType FindValue(string value)
        {
            return FindValue<FleetScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetSortByType.
    /// </summary>
    public class FleetSortByType : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIME for FleetSortByType
        /// </summary>
        public static readonly FleetSortByType CREATED_TIME = new FleetSortByType("CREATED_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for FleetSortByType
        /// </summary>
        public static readonly FleetSortByType LAST_MODIFIED_TIME = new FleetSortByType("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant NAME for FleetSortByType
        /// </summary>
        public static readonly FleetSortByType NAME = new FleetSortByType("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetSortByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetSortByType FindValue(string value)
        {
            return FindValue<FleetSortByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetSortByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStatusCode.
    /// </summary>
    public class FleetStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode ACTIVE = new FleetStatusCode("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode CREATE_FAILED = new FleetStatusCode("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode CREATING = new FleetStatusCode("CREATING");
        /// <summary>
        /// Constant DELETING for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode DELETING = new FleetStatusCode("DELETING");
        /// <summary>
        /// Constant PENDING_DELETION for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode PENDING_DELETION = new FleetStatusCode("PENDING_DELETION");
        /// <summary>
        /// Constant ROTATING for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode ROTATING = new FleetStatusCode("ROTATING");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_FAILED for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode UPDATE_ROLLBACK_FAILED = new FleetStatusCode("UPDATE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant UPDATING for FleetStatusCode
        /// </summary>
        public static readonly FleetStatusCode UPDATING = new FleetStatusCode("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStatusCode FindValue(string value)
        {
            return FindValue<FleetStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImagePullCredentialsType.
    /// </summary>
    public class ImagePullCredentialsType : ConstantClass
    {

        /// <summary>
        /// Constant CODEBUILD for ImagePullCredentialsType
        /// </summary>
        public static readonly ImagePullCredentialsType CODEBUILD = new ImagePullCredentialsType("CODEBUILD");
        /// <summary>
        /// Constant SERVICE_ROLE for ImagePullCredentialsType
        /// </summary>
        public static readonly ImagePullCredentialsType SERVICE_ROLE = new ImagePullCredentialsType("SERVICE_ROLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImagePullCredentialsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImagePullCredentialsType FindValue(string value)
        {
            return FindValue<ImagePullCredentialsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImagePullCredentialsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageType.
    /// </summary>
    public class LanguageType : ConstantClass
    {

        /// <summary>
        /// Constant ANDROID for LanguageType
        /// </summary>
        public static readonly LanguageType ANDROID = new LanguageType("ANDROID");
        /// <summary>
        /// Constant BASE for LanguageType
        /// </summary>
        public static readonly LanguageType BASE = new LanguageType("BASE");
        /// <summary>
        /// Constant DOCKER for LanguageType
        /// </summary>
        public static readonly LanguageType DOCKER = new LanguageType("DOCKER");
        /// <summary>
        /// Constant DOTNET for LanguageType
        /// </summary>
        public static readonly LanguageType DOTNET = new LanguageType("DOTNET");
        /// <summary>
        /// Constant GOLANG for LanguageType
        /// </summary>
        public static readonly LanguageType GOLANG = new LanguageType("GOLANG");
        /// <summary>
        /// Constant JAVA for LanguageType
        /// </summary>
        public static readonly LanguageType JAVA = new LanguageType("JAVA");
        /// <summary>
        /// Constant NODE_JS for LanguageType
        /// </summary>
        public static readonly LanguageType NODE_JS = new LanguageType("NODE_JS");
        /// <summary>
        /// Constant PHP for LanguageType
        /// </summary>
        public static readonly LanguageType PHP = new LanguageType("PHP");
        /// <summary>
        /// Constant PYTHON for LanguageType
        /// </summary>
        public static readonly LanguageType PYTHON = new LanguageType("PYTHON");
        /// <summary>
        /// Constant RUBY for LanguageType
        /// </summary>
        public static readonly LanguageType RUBY = new LanguageType("RUBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageType FindValue(string value)
        {
            return FindValue<LanguageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogsConfigStatusType.
    /// </summary>
    public class LogsConfigStatusType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LogsConfigStatusType
        /// </summary>
        public static readonly LogsConfigStatusType DISABLED = new LogsConfigStatusType("DISABLED");
        /// <summary>
        /// Constant ENABLED for LogsConfigStatusType
        /// </summary>
        public static readonly LogsConfigStatusType ENABLED = new LogsConfigStatusType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogsConfigStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogsConfigStatusType FindValue(string value)
        {
            return FindValue<LogsConfigStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogsConfigStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MachineType.
    /// </summary>
    public class MachineType : ConstantClass
    {

        /// <summary>
        /// Constant GENERAL for MachineType
        /// </summary>
        public static readonly MachineType GENERAL = new MachineType("GENERAL");
        /// <summary>
        /// Constant NVME for MachineType
        /// </summary>
        public static readonly MachineType NVME = new MachineType("NVME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MachineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MachineType FindValue(string value)
        {
            return FindValue<MachineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MachineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX for PlatformType
        /// </summary>
        public static readonly PlatformType AMAZON_LINUX = new PlatformType("AMAZON_LINUX");
        /// <summary>
        /// Constant DEBIAN for PlatformType
        /// </summary>
        public static readonly PlatformType DEBIAN = new PlatformType("DEBIAN");
        /// <summary>
        /// Constant UBUNTU for PlatformType
        /// </summary>
        public static readonly PlatformType UBUNTU = new PlatformType("UBUNTU");
        /// <summary>
        /// Constant WINDOWS_SERVER for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS_SERVER = new PlatformType("WINDOWS_SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectSortByType.
    /// </summary>
    public class ProjectSortByType : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIME for ProjectSortByType
        /// </summary>
        public static readonly ProjectSortByType CREATED_TIME = new ProjectSortByType("CREATED_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ProjectSortByType
        /// </summary>
        public static readonly ProjectSortByType LAST_MODIFIED_TIME = new ProjectSortByType("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant NAME for ProjectSortByType
        /// </summary>
        public static readonly ProjectSortByType NAME = new ProjectSortByType("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectSortByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectSortByType FindValue(string value)
        {
            return FindValue<ProjectSortByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectSortByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectVisibilityType.
    /// </summary>
    public class ProjectVisibilityType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for ProjectVisibilityType
        /// </summary>
        public static readonly ProjectVisibilityType PRIVATE = new ProjectVisibilityType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC_READ for ProjectVisibilityType
        /// </summary>
        public static readonly ProjectVisibilityType PUBLIC_READ = new ProjectVisibilityType("PUBLIC_READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectVisibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectVisibilityType FindValue(string value)
        {
            return FindValue<ProjectVisibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectVisibilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PullRequestBuildApproverRole.
    /// </summary>
    public class PullRequestBuildApproverRole : ConstantClass
    {

        /// <summary>
        /// Constant BITBUCKET_ADMIN for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole BITBUCKET_ADMIN = new PullRequestBuildApproverRole("BITBUCKET_ADMIN");
        /// <summary>
        /// Constant BITBUCKET_READ for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole BITBUCKET_READ = new PullRequestBuildApproverRole("BITBUCKET_READ");
        /// <summary>
        /// Constant BITBUCKET_WRITE for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole BITBUCKET_WRITE = new PullRequestBuildApproverRole("BITBUCKET_WRITE");
        /// <summary>
        /// Constant GITHUB_ADMIN for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITHUB_ADMIN = new PullRequestBuildApproverRole("GITHUB_ADMIN");
        /// <summary>
        /// Constant GITHUB_MAINTAIN for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITHUB_MAINTAIN = new PullRequestBuildApproverRole("GITHUB_MAINTAIN");
        /// <summary>
        /// Constant GITHUB_READ for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITHUB_READ = new PullRequestBuildApproverRole("GITHUB_READ");
        /// <summary>
        /// Constant GITHUB_TRIAGE for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITHUB_TRIAGE = new PullRequestBuildApproverRole("GITHUB_TRIAGE");
        /// <summary>
        /// Constant GITHUB_WRITE for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITHUB_WRITE = new PullRequestBuildApproverRole("GITHUB_WRITE");
        /// <summary>
        /// Constant GITLAB_DEVELOPER for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_DEVELOPER = new PullRequestBuildApproverRole("GITLAB_DEVELOPER");
        /// <summary>
        /// Constant GITLAB_GUEST for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_GUEST = new PullRequestBuildApproverRole("GITLAB_GUEST");
        /// <summary>
        /// Constant GITLAB_MAINTAINER for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_MAINTAINER = new PullRequestBuildApproverRole("GITLAB_MAINTAINER");
        /// <summary>
        /// Constant GITLAB_OWNER for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_OWNER = new PullRequestBuildApproverRole("GITLAB_OWNER");
        /// <summary>
        /// Constant GITLAB_PLANNER for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_PLANNER = new PullRequestBuildApproverRole("GITLAB_PLANNER");
        /// <summary>
        /// Constant GITLAB_REPORTER for PullRequestBuildApproverRole
        /// </summary>
        public static readonly PullRequestBuildApproverRole GITLAB_REPORTER = new PullRequestBuildApproverRole("GITLAB_REPORTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PullRequestBuildApproverRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PullRequestBuildApproverRole FindValue(string value)
        {
            return FindValue<PullRequestBuildApproverRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PullRequestBuildApproverRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PullRequestBuildCommentApproval.
    /// </summary>
    public class PullRequestBuildCommentApproval : ConstantClass
    {

        /// <summary>
        /// Constant ALL_PULL_REQUESTS for PullRequestBuildCommentApproval
        /// </summary>
        public static readonly PullRequestBuildCommentApproval ALL_PULL_REQUESTS = new PullRequestBuildCommentApproval("ALL_PULL_REQUESTS");
        /// <summary>
        /// Constant DISABLED for PullRequestBuildCommentApproval
        /// </summary>
        public static readonly PullRequestBuildCommentApproval DISABLED = new PullRequestBuildCommentApproval("DISABLED");
        /// <summary>
        /// Constant FORK_PULL_REQUESTS for PullRequestBuildCommentApproval
        /// </summary>
        public static readonly PullRequestBuildCommentApproval FORK_PULL_REQUESTS = new PullRequestBuildCommentApproval("FORK_PULL_REQUESTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PullRequestBuildCommentApproval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PullRequestBuildCommentApproval FindValue(string value)
        {
            return FindValue<PullRequestBuildCommentApproval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PullRequestBuildCommentApproval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportCodeCoverageSortByType.
    /// </summary>
    public class ReportCodeCoverageSortByType : ConstantClass
    {

        /// <summary>
        /// Constant FILE_PATH for ReportCodeCoverageSortByType
        /// </summary>
        public static readonly ReportCodeCoverageSortByType FILE_PATH = new ReportCodeCoverageSortByType("FILE_PATH");
        /// <summary>
        /// Constant LINE_COVERAGE_PERCENTAGE for ReportCodeCoverageSortByType
        /// </summary>
        public static readonly ReportCodeCoverageSortByType LINE_COVERAGE_PERCENTAGE = new ReportCodeCoverageSortByType("LINE_COVERAGE_PERCENTAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportCodeCoverageSortByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportCodeCoverageSortByType FindValue(string value)
        {
            return FindValue<ReportCodeCoverageSortByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportCodeCoverageSortByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportExportConfigType.
    /// </summary>
    public class ReportExportConfigType : ConstantClass
    {

        /// <summary>
        /// Constant NO_EXPORT for ReportExportConfigType
        /// </summary>
        public static readonly ReportExportConfigType NO_EXPORT = new ReportExportConfigType("NO_EXPORT");
        /// <summary>
        /// Constant S3 for ReportExportConfigType
        /// </summary>
        public static readonly ReportExportConfigType S3 = new ReportExportConfigType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportExportConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportExportConfigType FindValue(string value)
        {
            return FindValue<ReportExportConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportExportConfigType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportGroupSortByType.
    /// </summary>
    public class ReportGroupSortByType : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIME for ReportGroupSortByType
        /// </summary>
        public static readonly ReportGroupSortByType CREATED_TIME = new ReportGroupSortByType("CREATED_TIME");
        /// <summary>
        /// Constant LAST_MODIFIED_TIME for ReportGroupSortByType
        /// </summary>
        public static readonly ReportGroupSortByType LAST_MODIFIED_TIME = new ReportGroupSortByType("LAST_MODIFIED_TIME");
        /// <summary>
        /// Constant NAME for ReportGroupSortByType
        /// </summary>
        public static readonly ReportGroupSortByType NAME = new ReportGroupSortByType("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportGroupSortByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportGroupSortByType FindValue(string value)
        {
            return FindValue<ReportGroupSortByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportGroupSortByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportGroupStatusType.
    /// </summary>
    public class ReportGroupStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReportGroupStatusType
        /// </summary>
        public static readonly ReportGroupStatusType ACTIVE = new ReportGroupStatusType("ACTIVE");
        /// <summary>
        /// Constant DELETING for ReportGroupStatusType
        /// </summary>
        public static readonly ReportGroupStatusType DELETING = new ReportGroupStatusType("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportGroupStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportGroupStatusType FindValue(string value)
        {
            return FindValue<ReportGroupStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportGroupStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportGroupTrendFieldType.
    /// </summary>
    public class ReportGroupTrendFieldType : ConstantClass
    {

        /// <summary>
        /// Constant BRANCH_COVERAGE for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType BRANCH_COVERAGE = new ReportGroupTrendFieldType("BRANCH_COVERAGE");
        /// <summary>
        /// Constant BRANCHES_COVERED for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType BRANCHES_COVERED = new ReportGroupTrendFieldType("BRANCHES_COVERED");
        /// <summary>
        /// Constant BRANCHES_MISSED for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType BRANCHES_MISSED = new ReportGroupTrendFieldType("BRANCHES_MISSED");
        /// <summary>
        /// Constant DURATION for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType DURATION = new ReportGroupTrendFieldType("DURATION");
        /// <summary>
        /// Constant LINE_COVERAGE for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType LINE_COVERAGE = new ReportGroupTrendFieldType("LINE_COVERAGE");
        /// <summary>
        /// Constant LINES_COVERED for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType LINES_COVERED = new ReportGroupTrendFieldType("LINES_COVERED");
        /// <summary>
        /// Constant LINES_MISSED for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType LINES_MISSED = new ReportGroupTrendFieldType("LINES_MISSED");
        /// <summary>
        /// Constant PASS_RATE for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType PASS_RATE = new ReportGroupTrendFieldType("PASS_RATE");
        /// <summary>
        /// Constant TOTAL for ReportGroupTrendFieldType
        /// </summary>
        public static readonly ReportGroupTrendFieldType TOTAL = new ReportGroupTrendFieldType("TOTAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportGroupTrendFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportGroupTrendFieldType FindValue(string value)
        {
            return FindValue<ReportGroupTrendFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportGroupTrendFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportPackagingType.
    /// </summary>
    public class ReportPackagingType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ReportPackagingType
        /// </summary>
        public static readonly ReportPackagingType NONE = new ReportPackagingType("NONE");
        /// <summary>
        /// Constant ZIP for ReportPackagingType
        /// </summary>
        public static readonly ReportPackagingType ZIP = new ReportPackagingType("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportPackagingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportPackagingType FindValue(string value)
        {
            return FindValue<ReportPackagingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportPackagingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStatusType.
    /// </summary>
    public class ReportStatusType : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType DELETING = new ReportStatusType("DELETING");
        /// <summary>
        /// Constant FAILED for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType FAILED = new ReportStatusType("FAILED");
        /// <summary>
        /// Constant GENERATING for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType GENERATING = new ReportStatusType("GENERATING");
        /// <summary>
        /// Constant INCOMPLETE for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType INCOMPLETE = new ReportStatusType("INCOMPLETE");
        /// <summary>
        /// Constant SUCCEEDED for ReportStatusType
        /// </summary>
        public static readonly ReportStatusType SUCCEEDED = new ReportStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStatusType FindValue(string value)
        {
            return FindValue<ReportStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportType.
    /// </summary>
    public class ReportType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_COVERAGE for ReportType
        /// </summary>
        public static readonly ReportType CODE_COVERAGE = new ReportType("CODE_COVERAGE");
        /// <summary>
        /// Constant TEST for ReportType
        /// </summary>
        public static readonly ReportType TEST = new ReportType("TEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportType FindValue(string value)
        {
            return FindValue<ReportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryBuildBatchType.
    /// </summary>
    public class RetryBuildBatchType : ConstantClass
    {

        /// <summary>
        /// Constant RETRY_ALL_BUILDS for RetryBuildBatchType
        /// </summary>
        public static readonly RetryBuildBatchType RETRY_ALL_BUILDS = new RetryBuildBatchType("RETRY_ALL_BUILDS");
        /// <summary>
        /// Constant RETRY_FAILED_BUILDS for RetryBuildBatchType
        /// </summary>
        public static readonly RetryBuildBatchType RETRY_FAILED_BUILDS = new RetryBuildBatchType("RETRY_FAILED_BUILDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryBuildBatchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryBuildBatchType FindValue(string value)
        {
            return FindValue<RetryBuildBatchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryBuildBatchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerType.
    /// </summary>
    public class ServerType : ConstantClass
    {

        /// <summary>
        /// Constant BITBUCKET for ServerType
        /// </summary>
        public static readonly ServerType BITBUCKET = new ServerType("BITBUCKET");
        /// <summary>
        /// Constant GITHUB for ServerType
        /// </summary>
        public static readonly ServerType GITHUB = new ServerType("GITHUB");
        /// <summary>
        /// Constant GITHUB_ENTERPRISE for ServerType
        /// </summary>
        public static readonly ServerType GITHUB_ENTERPRISE = new ServerType("GITHUB_ENTERPRISE");
        /// <summary>
        /// Constant GITLAB for ServerType
        /// </summary>
        public static readonly ServerType GITLAB = new ServerType("GITLAB");
        /// <summary>
        /// Constant GITLAB_SELF_MANAGED for ServerType
        /// </summary>
        public static readonly ServerType GITLAB_SELF_MANAGED = new ServerType("GITLAB_SELF_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerType FindValue(string value)
        {
            return FindValue<ServerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharedResourceSortByType.
    /// </summary>
    public class SharedResourceSortByType : ConstantClass
    {

        /// <summary>
        /// Constant ARN for SharedResourceSortByType
        /// </summary>
        public static readonly SharedResourceSortByType ARN = new SharedResourceSortByType("ARN");
        /// <summary>
        /// Constant MODIFIED_TIME for SharedResourceSortByType
        /// </summary>
        public static readonly SharedResourceSortByType MODIFIED_TIME = new SharedResourceSortByType("MODIFIED_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharedResourceSortByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharedResourceSortByType FindValue(string value)
        {
            return FindValue<SharedResourceSortByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharedResourceSortByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrderType.
    /// </summary>
    public class SortOrderType : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrderType
        /// </summary>
        public static readonly SortOrderType ASCENDING = new SortOrderType("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrderType
        /// </summary>
        public static readonly SortOrderType DESCENDING = new SortOrderType("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrderType FindValue(string value)
        {
            return FindValue<SortOrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceAuthType.
    /// </summary>
    public class SourceAuthType : ConstantClass
    {

        /// <summary>
        /// Constant CODECONNECTIONS for SourceAuthType
        /// </summary>
        public static readonly SourceAuthType CODECONNECTIONS = new SourceAuthType("CODECONNECTIONS");
        /// <summary>
        /// Constant OAUTH for SourceAuthType
        /// </summary>
        public static readonly SourceAuthType OAUTH = new SourceAuthType("OAUTH");
        /// <summary>
        /// Constant SECRETS_MANAGER for SourceAuthType
        /// </summary>
        public static readonly SourceAuthType SECRETS_MANAGER = new SourceAuthType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceAuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceAuthType FindValue(string value)
        {
            return FindValue<SourceAuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceAuthType(string value)
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
        /// Constant BITBUCKET for SourceType
        /// </summary>
        public static readonly SourceType BITBUCKET = new SourceType("BITBUCKET");
        /// <summary>
        /// Constant CODECOMMIT for SourceType
        /// </summary>
        public static readonly SourceType CODECOMMIT = new SourceType("CODECOMMIT");
        /// <summary>
        /// Constant CODEPIPELINE for SourceType
        /// </summary>
        public static readonly SourceType CODEPIPELINE = new SourceType("CODEPIPELINE");
        /// <summary>
        /// Constant GITHUB for SourceType
        /// </summary>
        public static readonly SourceType GITHUB = new SourceType("GITHUB");
        /// <summary>
        /// Constant GITHUB_ENTERPRISE for SourceType
        /// </summary>
        public static readonly SourceType GITHUB_ENTERPRISE = new SourceType("GITHUB_ENTERPRISE");
        /// <summary>
        /// Constant GITLAB for SourceType
        /// </summary>
        public static readonly SourceType GITLAB = new SourceType("GITLAB");
        /// <summary>
        /// Constant GITLAB_SELF_MANAGED for SourceType
        /// </summary>
        public static readonly SourceType GITLAB_SELF_MANAGED = new SourceType("GITLAB_SELF_MANAGED");
        /// <summary>
        /// Constant NO_SOURCE for SourceType
        /// </summary>
        public static readonly SourceType NO_SOURCE = new SourceType("NO_SOURCE");
        /// <summary>
        /// Constant S3 for SourceType
        /// </summary>
        public static readonly SourceType S3 = new SourceType("S3");

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
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for StatusType
        /// </summary>
        public static readonly StatusType FAILED = new StatusType("FAILED");
        /// <summary>
        /// Constant FAULT for StatusType
        /// </summary>
        public static readonly StatusType FAULT = new StatusType("FAULT");
        /// <summary>
        /// Constant IN_PROGRESS for StatusType
        /// </summary>
        public static readonly StatusType IN_PROGRESS = new StatusType("IN_PROGRESS");
        /// <summary>
        /// Constant STOPPED for StatusType
        /// </summary>
        public static readonly StatusType STOPPED = new StatusType("STOPPED");
        /// <summary>
        /// Constant SUCCEEDED for StatusType
        /// </summary>
        public static readonly StatusType SUCCEEDED = new StatusType("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for StatusType
        /// </summary>
        public static readonly StatusType TIMED_OUT = new StatusType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookBuildType.
    /// </summary>
    public class WebhookBuildType : ConstantClass
    {

        /// <summary>
        /// Constant BUILD for WebhookBuildType
        /// </summary>
        public static readonly WebhookBuildType BUILD = new WebhookBuildType("BUILD");
        /// <summary>
        /// Constant BUILD_BATCH for WebhookBuildType
        /// </summary>
        public static readonly WebhookBuildType BUILD_BATCH = new WebhookBuildType("BUILD_BATCH");
        /// <summary>
        /// Constant RUNNER_BUILDKITE_BUILD for WebhookBuildType
        /// </summary>
        public static readonly WebhookBuildType RUNNER_BUILDKITE_BUILD = new WebhookBuildType("RUNNER_BUILDKITE_BUILD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookBuildType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookBuildType FindValue(string value)
        {
            return FindValue<WebhookBuildType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookBuildType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookFilterType.
    /// </summary>
    public class WebhookFilterType : ConstantClass
    {

        /// <summary>
        /// Constant ACTOR_ACCOUNT_ID for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType ACTOR_ACCOUNT_ID = new WebhookFilterType("ACTOR_ACCOUNT_ID");
        /// <summary>
        /// Constant BASE_REF for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType BASE_REF = new WebhookFilterType("BASE_REF");
        /// <summary>
        /// Constant COMMIT_MESSAGE for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType COMMIT_MESSAGE = new WebhookFilterType("COMMIT_MESSAGE");
        /// <summary>
        /// Constant EVENT for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType EVENT = new WebhookFilterType("EVENT");
        /// <summary>
        /// Constant FILE_PATH for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType FILE_PATH = new WebhookFilterType("FILE_PATH");
        /// <summary>
        /// Constant HEAD_REF for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType HEAD_REF = new WebhookFilterType("HEAD_REF");
        /// <summary>
        /// Constant ORGANIZATION_NAME for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType ORGANIZATION_NAME = new WebhookFilterType("ORGANIZATION_NAME");
        /// <summary>
        /// Constant RELEASE_NAME for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType RELEASE_NAME = new WebhookFilterType("RELEASE_NAME");
        /// <summary>
        /// Constant REPOSITORY_NAME for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType REPOSITORY_NAME = new WebhookFilterType("REPOSITORY_NAME");
        /// <summary>
        /// Constant TAG_NAME for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType TAG_NAME = new WebhookFilterType("TAG_NAME");
        /// <summary>
        /// Constant WORKFLOW_NAME for WebhookFilterType
        /// </summary>
        public static readonly WebhookFilterType WORKFLOW_NAME = new WebhookFilterType("WORKFLOW_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookFilterType FindValue(string value)
        {
            return FindValue<WebhookFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookScopeType.
    /// </summary>
    public class WebhookScopeType : ConstantClass
    {

        /// <summary>
        /// Constant GITHUB_GLOBAL for WebhookScopeType
        /// </summary>
        public static readonly WebhookScopeType GITHUB_GLOBAL = new WebhookScopeType("GITHUB_GLOBAL");
        /// <summary>
        /// Constant GITHUB_ORGANIZATION for WebhookScopeType
        /// </summary>
        public static readonly WebhookScopeType GITHUB_ORGANIZATION = new WebhookScopeType("GITHUB_ORGANIZATION");
        /// <summary>
        /// Constant GITLAB_GROUP for WebhookScopeType
        /// </summary>
        public static readonly WebhookScopeType GITLAB_GROUP = new WebhookScopeType("GITLAB_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookScopeType FindValue(string value)
        {
            return FindValue<WebhookScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WebhookStatus.
    /// </summary>
    public class WebhookStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WebhookStatus
        /// </summary>
        public static readonly WebhookStatus ACTIVE = new WebhookStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for WebhookStatus
        /// </summary>
        public static readonly WebhookStatus CREATE_FAILED = new WebhookStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for WebhookStatus
        /// </summary>
        public static readonly WebhookStatus CREATING = new WebhookStatus("CREATING");
        /// <summary>
        /// Constant DELETING for WebhookStatus
        /// </summary>
        public static readonly WebhookStatus DELETING = new WebhookStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WebhookStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WebhookStatus FindValue(string value)
        {
            return FindValue<WebhookStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WebhookStatus(string value)
        {
            return FindValue(value);
        }
    }

}
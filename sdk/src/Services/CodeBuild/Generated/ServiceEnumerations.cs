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
        /// Constant OAUTH for AuthType
        /// </summary>
        public static readonly AuthType OAUTH = new AuthType("OAUTH");
        /// <summary>
        /// Constant PERSONAL_ACCESS_TOKEN for AuthType
        /// </summary>
        public static readonly AuthType PERSONAL_ACCESS_TOKEN = new AuthType("PERSONAL_ACCESS_TOKEN");

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
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

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
        /// Constant LINUX_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_CONTAINER = new EnvironmentType("LINUX_CONTAINER");
        /// <summary>
        /// Constant LINUX_GPU_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_GPU_CONTAINER = new EnvironmentType("LINUX_GPU_CONTAINER");
        /// <summary>
        /// Constant WINDOWS_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_CONTAINER = new EnvironmentType("WINDOWS_CONTAINER");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_SERVER_2019_CONTAINER = new EnvironmentType("WINDOWS_SERVER_2019_CONTAINER");

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
        /// Constant OAUTH for SourceAuthType
        /// </summary>
        public static readonly SourceAuthType OAUTH = new SourceAuthType("OAUTH");

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

}
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
    /// Constants used for properties of type CacheType.
    /// </summary>
    public class CacheType : ConstantClass
    {

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
    /// Constants used for properties of type EnvironmentType.
    /// </summary>
    public class EnvironmentType : ConstantClass
    {

        /// <summary>
        /// Constant LINUX_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType LINUX_CONTAINER = new EnvironmentType("LINUX_CONTAINER");
        /// <summary>
        /// Constant WINDOWS_CONTAINER for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType WINDOWS_CONTAINER = new EnvironmentType("WINDOWS_CONTAINER");

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

}
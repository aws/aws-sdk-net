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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Amplify
{

    /// <summary>
    /// Constants used for properties of type BuildComputeType.
    /// </summary>
    public class BuildComputeType : ConstantClass
    {

        /// <summary>
        /// Constant LARGE_16GB for BuildComputeType
        /// </summary>
        public static readonly BuildComputeType LARGE_16GB = new BuildComputeType("LARGE_16GB");
        /// <summary>
        /// Constant STANDARD_8GB for BuildComputeType
        /// </summary>
        public static readonly BuildComputeType STANDARD_8GB = new BuildComputeType("STANDARD_8GB");
        /// <summary>
        /// Constant XLARGE_72GB for BuildComputeType
        /// </summary>
        public static readonly BuildComputeType XLARGE_72GB = new BuildComputeType("XLARGE_72GB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildComputeType FindValue(string value)
        {
            return FindValue<BuildComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheConfigType.
    /// </summary>
    public class CacheConfigType : ConstantClass
    {

        /// <summary>
        /// Constant AMPLIFY_MANAGED for CacheConfigType
        /// </summary>
        public static readonly CacheConfigType AMPLIFY_MANAGED = new CacheConfigType("AMPLIFY_MANAGED");
        /// <summary>
        /// Constant AMPLIFY_MANAGED_NO_COOKIES for CacheConfigType
        /// </summary>
        public static readonly CacheConfigType AMPLIFY_MANAGED_NO_COOKIES = new CacheConfigType("AMPLIFY_MANAGED_NO_COOKIES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheConfigType FindValue(string value)
        {
            return FindValue<CacheConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheConfigType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateType.
    /// </summary>
    public class CertificateType : ConstantClass
    {

        /// <summary>
        /// Constant AMPLIFY_MANAGED for CertificateType
        /// </summary>
        public static readonly CertificateType AMPLIFY_MANAGED = new CertificateType("AMPLIFY_MANAGED");
        /// <summary>
        /// Constant CUSTOM for CertificateType
        /// </summary>
        public static readonly CertificateType CUSTOM = new CertificateType("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateType FindValue(string value)
        {
            return FindValue<CertificateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainStatus
        /// </summary>
        public static readonly DomainStatus AVAILABLE = new DomainStatus("AVAILABLE");
        /// <summary>
        /// Constant AWAITING_APP_CNAME for DomainStatus
        /// </summary>
        public static readonly DomainStatus AWAITING_APP_CNAME = new DomainStatus("AWAITING_APP_CNAME");
        /// <summary>
        /// Constant CREATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus CREATING = new DomainStatus("CREATING");
        /// <summary>
        /// Constant FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus FAILED = new DomainStatus("FAILED");
        /// <summary>
        /// Constant IMPORTING_CUSTOM_CERTIFICATE for DomainStatus
        /// </summary>
        public static readonly DomainStatus IMPORTING_CUSTOM_CERTIFICATE = new DomainStatus("IMPORTING_CUSTOM_CERTIFICATE");
        /// <summary>
        /// Constant IN_PROGRESS for DomainStatus
        /// </summary>
        public static readonly DomainStatus IN_PROGRESS = new DomainStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING_DEPLOYMENT for DomainStatus
        /// </summary>
        public static readonly DomainStatus PENDING_DEPLOYMENT = new DomainStatus("PENDING_DEPLOYMENT");
        /// <summary>
        /// Constant PENDING_VERIFICATION for DomainStatus
        /// </summary>
        public static readonly DomainStatus PENDING_VERIFICATION = new DomainStatus("PENDING_VERIFICATION");
        /// <summary>
        /// Constant REQUESTING_CERTIFICATE for DomainStatus
        /// </summary>
        public static readonly DomainStatus REQUESTING_CERTIFICATE = new DomainStatus("REQUESTING_CERTIFICATE");
        /// <summary>
        /// Constant UPDATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus UPDATING = new DomainStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
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
        /// Constant CANCELLED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELLED = new JobStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELLING = new JobStatus("CANCELLING");
        /// <summary>
        /// Constant CREATED for JobStatus
        /// </summary>
        public static readonly JobStatus CREATED = new JobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING = new JobStatus("PENDING");
        /// <summary>
        /// Constant PROVISIONING for JobStatus
        /// </summary>
        public static readonly JobStatus PROVISIONING = new JobStatus("PROVISIONING");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEED for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCEED = new JobStatus("SUCCEED");

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
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant MANUAL for JobType
        /// </summary>
        public static readonly JobType MANUAL = new JobType("MANUAL");
        /// <summary>
        /// Constant RELEASE for JobType
        /// </summary>
        public static readonly JobType RELEASE = new JobType("RELEASE");
        /// <summary>
        /// Constant RETRY for JobType
        /// </summary>
        public static readonly JobType RETRY = new JobType("RETRY");
        /// <summary>
        /// Constant WEB_HOOK for JobType
        /// </summary>
        public static readonly JobType WEB_HOOK = new JobType("WEB_HOOK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {

        /// <summary>
        /// Constant WEB for Platform
        /// </summary>
        public static readonly Platform WEB = new Platform("WEB");
        /// <summary>
        /// Constant WEB_COMPUTE for Platform
        /// </summary>
        public static readonly Platform WEB_COMPUTE = new Platform("WEB_COMPUTE");
        /// <summary>
        /// Constant WEB_DYNAMIC for Platform
        /// </summary>
        public static readonly Platform WEB_DYNAMIC = new Platform("WEB_DYNAMIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Platform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Platform FindValue(string value)
        {
            return FindValue<Platform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositoryCloneMethod.
    /// </summary>
    public class RepositoryCloneMethod : ConstantClass
    {

        /// <summary>
        /// Constant SIGV4 for RepositoryCloneMethod
        /// </summary>
        public static readonly RepositoryCloneMethod SIGV4 = new RepositoryCloneMethod("SIGV4");
        /// <summary>
        /// Constant SSH for RepositoryCloneMethod
        /// </summary>
        public static readonly RepositoryCloneMethod SSH = new RepositoryCloneMethod("SSH");
        /// <summary>
        /// Constant TOKEN for RepositoryCloneMethod
        /// </summary>
        public static readonly RepositoryCloneMethod TOKEN = new RepositoryCloneMethod("TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryCloneMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryCloneMethod FindValue(string value)
        {
            return FindValue<RepositoryCloneMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryCloneMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceUrlType.
    /// </summary>
    public class SourceUrlType : ConstantClass
    {

        /// <summary>
        /// Constant BUCKET_PREFIX for SourceUrlType
        /// </summary>
        public static readonly SourceUrlType BUCKET_PREFIX = new SourceUrlType("BUCKET_PREFIX");
        /// <summary>
        /// Constant ZIP for SourceUrlType
        /// </summary>
        public static readonly SourceUrlType ZIP = new SourceUrlType("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceUrlType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceUrlType FindValue(string value)
        {
            return FindValue<SourceUrlType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceUrlType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Stage.
    /// </summary>
    public class Stage : ConstantClass
    {

        /// <summary>
        /// Constant BETA for Stage
        /// </summary>
        public static readonly Stage BETA = new Stage("BETA");
        /// <summary>
        /// Constant DEVELOPMENT for Stage
        /// </summary>
        public static readonly Stage DEVELOPMENT = new Stage("DEVELOPMENT");
        /// <summary>
        /// Constant EXPERIMENTAL for Stage
        /// </summary>
        public static readonly Stage EXPERIMENTAL = new Stage("EXPERIMENTAL");
        /// <summary>
        /// Constant PRODUCTION for Stage
        /// </summary>
        public static readonly Stage PRODUCTION = new Stage("PRODUCTION");
        /// <summary>
        /// Constant PULL_REQUEST for Stage
        /// </summary>
        public static readonly Stage PULL_REQUEST = new Stage("PULL_REQUEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Stage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Stage FindValue(string value)
        {
            return FindValue<Stage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Stage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_APP_CNAME for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus AWAITING_APP_CNAME = new UpdateStatus("AWAITING_APP_CNAME");
        /// <summary>
        /// Constant IMPORTING_CUSTOM_CERTIFICATE for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus IMPORTING_CUSTOM_CERTIFICATE = new UpdateStatus("IMPORTING_CUSTOM_CERTIFICATE");
        /// <summary>
        /// Constant PENDING_DEPLOYMENT for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus PENDING_DEPLOYMENT = new UpdateStatus("PENDING_DEPLOYMENT");
        /// <summary>
        /// Constant PENDING_VERIFICATION for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus PENDING_VERIFICATION = new UpdateStatus("PENDING_VERIFICATION");
        /// <summary>
        /// Constant REQUESTING_CERTIFICATE for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus REQUESTING_CERTIFICATE = new UpdateStatus("REQUESTING_CERTIFICATE");
        /// <summary>
        /// Constant UPDATE_COMPLETE for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus UPDATE_COMPLETE = new UpdateStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus UPDATE_FAILED = new UpdateStatus("UPDATE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WafStatus.
    /// </summary>
    public class WafStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATING for WafStatus
        /// </summary>
        public static readonly WafStatus ASSOCIATING = new WafStatus("ASSOCIATING");
        /// <summary>
        /// Constant ASSOCIATION_FAILED for WafStatus
        /// </summary>
        public static readonly WafStatus ASSOCIATION_FAILED = new WafStatus("ASSOCIATION_FAILED");
        /// <summary>
        /// Constant ASSOCIATION_SUCCESS for WafStatus
        /// </summary>
        public static readonly WafStatus ASSOCIATION_SUCCESS = new WafStatus("ASSOCIATION_SUCCESS");
        /// <summary>
        /// Constant DISASSOCIATING for WafStatus
        /// </summary>
        public static readonly WafStatus DISASSOCIATING = new WafStatus("DISASSOCIATING");
        /// <summary>
        /// Constant DISASSOCIATION_FAILED for WafStatus
        /// </summary>
        public static readonly WafStatus DISASSOCIATION_FAILED = new WafStatus("DISASSOCIATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WafStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafStatus FindValue(string value)
        {
            return FindValue<WafStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafStatus(string value)
        {
            return FindValue(value);
        }
    }

}
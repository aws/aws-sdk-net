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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeArtifact
{

    /// <summary>
    /// Constants used for properties of type AllowPublish.
    /// </summary>
    public class AllowPublish : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AllowPublish
        /// </summary>
        public static readonly AllowPublish ALLOW = new AllowPublish("ALLOW");
        /// <summary>
        /// Constant BLOCK for AllowPublish
        /// </summary>
        public static readonly AllowPublish BLOCK = new AllowPublish("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowPublish(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowPublish FindValue(string value)
        {
            return FindValue<AllowPublish>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowPublish(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowUpstream.
    /// </summary>
    public class AllowUpstream : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AllowUpstream
        /// </summary>
        public static readonly AllowUpstream ALLOW = new AllowUpstream("ALLOW");
        /// <summary>
        /// Constant BLOCK for AllowUpstream
        /// </summary>
        public static readonly AllowUpstream BLOCK = new AllowUpstream("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowUpstream(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowUpstream FindValue(string value)
        {
            return FindValue<AllowUpstream>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowUpstream(string value)
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
        /// Constant Active for DomainStatus
        /// </summary>
        public static readonly DomainStatus Active = new DomainStatus("Active");
        /// <summary>
        /// Constant Deleted for DomainStatus
        /// </summary>
        public static readonly DomainStatus Deleted = new DomainStatus("Deleted");

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
    /// Constants used for properties of type ExternalConnectionStatus.
    /// </summary>
    public class ExternalConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for ExternalConnectionStatus
        /// </summary>
        public static readonly ExternalConnectionStatus Available = new ExternalConnectionStatus("Available");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalConnectionStatus FindValue(string value)
        {
            return FindValue<ExternalConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HashAlgorithm.
    /// </summary>
    public class HashAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant MD5 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm MD5 = new HashAlgorithm("MD5");
        /// <summary>
        /// Constant SHA1 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA1 = new HashAlgorithm("SHA-1");
        /// <summary>
        /// Constant SHA256 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA256 = new HashAlgorithm("SHA-256");
        /// <summary>
        /// Constant SHA512 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA512 = new HashAlgorithm("SHA-512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HashAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HashAlgorithm FindValue(string value)
        {
            return FindValue<HashAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HashAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageFormat.
    /// </summary>
    public class PackageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Generic for PackageFormat
        /// </summary>
        public static readonly PackageFormat Generic = new PackageFormat("generic");
        /// <summary>
        /// Constant Maven for PackageFormat
        /// </summary>
        public static readonly PackageFormat Maven = new PackageFormat("maven");
        /// <summary>
        /// Constant Npm for PackageFormat
        /// </summary>
        public static readonly PackageFormat Npm = new PackageFormat("npm");
        /// <summary>
        /// Constant Nuget for PackageFormat
        /// </summary>
        public static readonly PackageFormat Nuget = new PackageFormat("nuget");
        /// <summary>
        /// Constant Pypi for PackageFormat
        /// </summary>
        public static readonly PackageFormat Pypi = new PackageFormat("pypi");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageFormat FindValue(string value)
        {
            return FindValue<PackageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageVersionErrorCode.
    /// </summary>
    public class PackageVersionErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ALREADY_EXISTS for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode ALREADY_EXISTS = new PackageVersionErrorCode("ALREADY_EXISTS");
        /// <summary>
        /// Constant MISMATCHED_REVISION for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode MISMATCHED_REVISION = new PackageVersionErrorCode("MISMATCHED_REVISION");
        /// <summary>
        /// Constant MISMATCHED_STATUS for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode MISMATCHED_STATUS = new PackageVersionErrorCode("MISMATCHED_STATUS");
        /// <summary>
        /// Constant NOT_ALLOWED for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode NOT_ALLOWED = new PackageVersionErrorCode("NOT_ALLOWED");
        /// <summary>
        /// Constant NOT_FOUND for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode NOT_FOUND = new PackageVersionErrorCode("NOT_FOUND");
        /// <summary>
        /// Constant SKIPPED for PackageVersionErrorCode
        /// </summary>
        public static readonly PackageVersionErrorCode SKIPPED = new PackageVersionErrorCode("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageVersionErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageVersionErrorCode FindValue(string value)
        {
            return FindValue<PackageVersionErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageVersionErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageVersionOriginType.
    /// </summary>
    public class PackageVersionOriginType : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL for PackageVersionOriginType
        /// </summary>
        public static readonly PackageVersionOriginType EXTERNAL = new PackageVersionOriginType("EXTERNAL");
        /// <summary>
        /// Constant INTERNAL for PackageVersionOriginType
        /// </summary>
        public static readonly PackageVersionOriginType INTERNAL = new PackageVersionOriginType("INTERNAL");
        /// <summary>
        /// Constant UNKNOWN for PackageVersionOriginType
        /// </summary>
        public static readonly PackageVersionOriginType UNKNOWN = new PackageVersionOriginType("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageVersionOriginType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageVersionOriginType FindValue(string value)
        {
            return FindValue<PackageVersionOriginType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageVersionOriginType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageVersionSortType.
    /// </summary>
    public class PackageVersionSortType : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED_TIME for PackageVersionSortType
        /// </summary>
        public static readonly PackageVersionSortType PUBLISHED_TIME = new PackageVersionSortType("PUBLISHED_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageVersionSortType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageVersionSortType FindValue(string value)
        {
            return FindValue<PackageVersionSortType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageVersionSortType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageVersionStatus.
    /// </summary>
    public class PackageVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Archived for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Archived = new PackageVersionStatus("Archived");
        /// <summary>
        /// Constant Deleted for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Deleted = new PackageVersionStatus("Deleted");
        /// <summary>
        /// Constant Disposed for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Disposed = new PackageVersionStatus("Disposed");
        /// <summary>
        /// Constant Published for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Published = new PackageVersionStatus("Published");
        /// <summary>
        /// Constant Unfinished for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Unfinished = new PackageVersionStatus("Unfinished");
        /// <summary>
        /// Constant Unlisted for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus Unlisted = new PackageVersionStatus("Unlisted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageVersionStatus FindValue(string value)
        {
            return FindValue<PackageVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageVersionStatus(string value)
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
        /// Constant Asset for ResourceType
        /// </summary>
        public static readonly ResourceType Asset = new ResourceType("asset");
        /// <summary>
        /// Constant Domain for ResourceType
        /// </summary>
        public static readonly ResourceType Domain = new ResourceType("domain");
        /// <summary>
        /// Constant Package for ResourceType
        /// </summary>
        public static readonly ResourceType Package = new ResourceType("package");
        /// <summary>
        /// Constant PackageVersion for ResourceType
        /// </summary>
        public static readonly ResourceType PackageVersion = new ResourceType("package-version");
        /// <summary>
        /// Constant Repository for ResourceType
        /// </summary>
        public static readonly ResourceType Repository = new ResourceType("repository");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant ENCRYPTION_KEY_ERROR for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ENCRYPTION_KEY_ERROR = new ValidationExceptionReason("ENCRYPTION_KEY_ERROR");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}
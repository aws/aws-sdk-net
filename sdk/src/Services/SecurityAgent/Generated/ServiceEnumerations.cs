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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityAgent
{

    /// <summary>
    /// Constants used for properties of type AccessType.
    /// </summary>
    public class AccessType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for AccessType
        /// </summary>
        public static readonly AccessType PRIVATE = new AccessType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for AccessType
        /// </summary>
        public static readonly AccessType PUBLIC = new AccessType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessType FindValue(string value)
        {
            return FindValue<AccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactType.
    /// </summary>
    public class ArtifactType : ConstantClass
    {

        /// <summary>
        /// Constant DOC for ArtifactType
        /// </summary>
        public static readonly ArtifactType DOC = new ArtifactType("DOC");
        /// <summary>
        /// Constant DOCX for ArtifactType
        /// </summary>
        public static readonly ArtifactType DOCX = new ArtifactType("DOCX");
        /// <summary>
        /// Constant JPEG for ArtifactType
        /// </summary>
        public static readonly ArtifactType JPEG = new ArtifactType("JPEG");
        /// <summary>
        /// Constant JSON for ArtifactType
        /// </summary>
        public static readonly ArtifactType JSON = new ArtifactType("JSON");
        /// <summary>
        /// Constant MD for ArtifactType
        /// </summary>
        public static readonly ArtifactType MD = new ArtifactType("MD");
        /// <summary>
        /// Constant PDF for ArtifactType
        /// </summary>
        public static readonly ArtifactType PDF = new ArtifactType("PDF");
        /// <summary>
        /// Constant PNG for ArtifactType
        /// </summary>
        public static readonly ArtifactType PNG = new ArtifactType("PNG");
        /// <summary>
        /// Constant TXT for ArtifactType
        /// </summary>
        public static readonly ArtifactType TXT = new ArtifactType("TXT");
        /// <summary>
        /// Constant YAML for ArtifactType
        /// </summary>
        public static readonly ArtifactType YAML = new ArtifactType("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactType FindValue(string value)
        {
            return FindValue<ArtifactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationProviderType.
    /// </summary>
    public class AuthenticationProviderType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM_ROLE for AuthenticationProviderType
        /// </summary>
        public static readonly AuthenticationProviderType AWS_IAM_ROLE = new AuthenticationProviderType("AWS_IAM_ROLE");
        /// <summary>
        /// Constant AWS_INTERNAL for AuthenticationProviderType
        /// </summary>
        public static readonly AuthenticationProviderType AWS_INTERNAL = new AuthenticationProviderType("AWS_INTERNAL");
        /// <summary>
        /// Constant AWS_LAMBDA for AuthenticationProviderType
        /// </summary>
        public static readonly AuthenticationProviderType AWS_LAMBDA = new AuthenticationProviderType("AWS_LAMBDA");
        /// <summary>
        /// Constant SECRETS_MANAGER for AuthenticationProviderType
        /// </summary>
        public static readonly AuthenticationProviderType SECRETS_MANAGER = new AuthenticationProviderType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationProviderType FindValue(string value)
        {
            return FindValue<AuthenticationProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CleanUpStrategy.
    /// </summary>
    public class CleanUpStrategy : ConstantClass
    {

        /// <summary>
        /// Constant BEST_EFFORT_DELETE for CleanUpStrategy
        /// </summary>
        public static readonly CleanUpStrategy BEST_EFFORT_DELETE = new CleanUpStrategy("BEST_EFFORT_DELETE");
        /// <summary>
        /// Constant RETAIN_ALL for CleanUpStrategy
        /// </summary>
        public static readonly CleanUpStrategy RETAIN_ALL = new CleanUpStrategy("RETAIN_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CleanUpStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CleanUpStrategy FindValue(string value)
        {
            return FindValue<CleanUpStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CleanUpStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRemediationStrategy.
    /// </summary>
    public class CodeRemediationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for CodeRemediationStrategy
        /// </summary>
        public static readonly CodeRemediationStrategy AUTOMATIC = new CodeRemediationStrategy("AUTOMATIC");
        /// <summary>
        /// Constant DISABLED for CodeRemediationStrategy
        /// </summary>
        public static readonly CodeRemediationStrategy DISABLED = new CodeRemediationStrategy("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRemediationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRemediationStrategy FindValue(string value)
        {
            return FindValue<CodeRemediationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRemediationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRemediationTaskStatus.
    /// </summary>
    public class CodeRemediationTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CodeRemediationTaskStatus
        /// </summary>
        public static readonly CodeRemediationTaskStatus COMPLETED = new CodeRemediationTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for CodeRemediationTaskStatus
        /// </summary>
        public static readonly CodeRemediationTaskStatus FAILED = new CodeRemediationTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CodeRemediationTaskStatus
        /// </summary>
        public static readonly CodeRemediationTaskStatus IN_PROGRESS = new CodeRemediationTaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRemediationTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRemediationTaskStatus FindValue(string value)
        {
            return FindValue<CodeRemediationTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRemediationTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfidenceLevel.
    /// </summary>
    public class ConfidenceLevel : ConstantClass
    {

        /// <summary>
        /// Constant FALSE_POSITIVE for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel FALSE_POSITIVE = new ConfidenceLevel("FALSE_POSITIVE");
        /// <summary>
        /// Constant HIGH for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel HIGH = new ConfidenceLevel("HIGH");
        /// <summary>
        /// Constant LOW for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel LOW = new ConfidenceLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel MEDIUM = new ConfidenceLevel("MEDIUM");
        /// <summary>
        /// Constant UNCONFIRMED for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel UNCONFIRMED = new ConfidenceLevel("UNCONFIRMED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfidenceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfidenceLevel FindValue(string value)
        {
            return FindValue<ConfidenceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfidenceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContextType.
    /// </summary>
    public class ContextType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for ContextType
        /// </summary>
        public static readonly ContextType CLIENT_ERROR = new ContextType("CLIENT_ERROR");
        /// <summary>
        /// Constant ERROR for ContextType
        /// </summary>
        public static readonly ContextType ERROR = new ContextType("ERROR");
        /// <summary>
        /// Constant INFO for ContextType
        /// </summary>
        public static readonly ContextType INFO = new ContextType("INFO");
        /// <summary>
        /// Constant WARNING for ContextType
        /// </summary>
        public static readonly ContextType WARNING = new ContextType("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContextType FindValue(string value)
        {
            return FindValue<ContextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContextType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DNSRecordType.
    /// </summary>
    public class DNSRecordType : ConstantClass
    {

        /// <summary>
        /// Constant TXT for DNSRecordType
        /// </summary>
        public static readonly DNSRecordType TXT = new DNSRecordType("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DNSRecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DNSRecordType FindValue(string value)
        {
            return FindValue<DNSRecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DNSRecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainVerificationMethod.
    /// </summary>
    public class DomainVerificationMethod : ConstantClass
    {

        /// <summary>
        /// Constant DNS_TXT for DomainVerificationMethod
        /// </summary>
        public static readonly DomainVerificationMethod DNS_TXT = new DomainVerificationMethod("DNS_TXT");
        /// <summary>
        /// Constant HTTP_ROUTE for DomainVerificationMethod
        /// </summary>
        public static readonly DomainVerificationMethod HTTP_ROUTE = new DomainVerificationMethod("HTTP_ROUTE");
        /// <summary>
        /// Constant PRIVATE_VPC for DomainVerificationMethod
        /// </summary>
        public static readonly DomainVerificationMethod PRIVATE_VPC = new DomainVerificationMethod("PRIVATE_VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainVerificationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainVerificationMethod FindValue(string value)
        {
            return FindValue<DomainVerificationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainVerificationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode CLIENT_ERROR = new ErrorCode("CLIENT_ERROR");
        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant STOPPED_BY_USER for ErrorCode
        /// </summary>
        public static readonly ErrorCode STOPPED_BY_USER = new ErrorCode("STOPPED_BY_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatus.
    /// </summary>
    public class FindingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for FindingStatus
        /// </summary>
        public static readonly FindingStatus ACCEPTED = new FindingStatus("ACCEPTED");
        /// <summary>
        /// Constant ACTIVE for FindingStatus
        /// </summary>
        public static readonly FindingStatus ACTIVE = new FindingStatus("ACTIVE");
        /// <summary>
        /// Constant FALSE_POSITIVE for FindingStatus
        /// </summary>
        public static readonly FindingStatus FALSE_POSITIVE = new FindingStatus("FALSE_POSITIVE");
        /// <summary>
        /// Constant RESOLVED for FindingStatus
        /// </summary>
        public static readonly FindingStatus RESOLVED = new FindingStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatus FindValue(string value)
        {
            return FindValue<FindingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GitLabTokenType.
    /// </summary>
    public class GitLabTokenType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for GitLabTokenType
        /// </summary>
        public static readonly GitLabTokenType GROUP = new GitLabTokenType("GROUP");
        /// <summary>
        /// Constant PERSONAL for GitLabTokenType
        /// </summary>
        public static readonly GitLabTokenType PERSONAL = new GitLabTokenType("PERSONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GitLabTokenType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GitLabTokenType FindValue(string value)
        {
            return FindValue<GitLabTokenType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GitLabTokenType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL_STACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUAL_STACK = new IpAddressType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6 = new IpAddressType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant STOPPED for JobStatus
        /// </summary>
        public static readonly JobStatus STOPPED = new JobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for JobStatus
        /// </summary>
        public static readonly JobStatus STOPPING = new JobStatus("STOPPING");

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
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDWATCH for LogType
        /// </summary>
        public static readonly LogType CLOUDWATCH = new LogType("CLOUDWATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagementType.
    /// </summary>
    public class ManagementType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for ManagementType
        /// </summary>
        public static readonly ManagementType AWS_MANAGED = new ManagementType("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for ManagementType
        /// </summary>
        public static readonly ManagementType CUSTOMER_MANAGED = new ManagementType("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagementType FindValue(string value)
        {
            return FindValue<ManagementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipType.
    /// </summary>
    public class MembershipType : ConstantClass
    {

        /// <summary>
        /// Constant USER for MembershipType
        /// </summary>
        public static readonly MembershipType USER = new MembershipType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipType FindValue(string value)
        {
            return FindValue<MembershipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipTypeFilter.
    /// </summary>
    public class MembershipTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for MembershipTypeFilter
        /// </summary>
        public static readonly MembershipTypeFilter ALL = new MembershipTypeFilter("ALL");
        /// <summary>
        /// Constant USER for MembershipTypeFilter
        /// </summary>
        public static readonly MembershipTypeFilter USER = new MembershipTypeFilter("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipTypeFilter FindValue(string value)
        {
            return FindValue<MembershipTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipTypeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkTrafficRuleEffect.
    /// </summary>
    public class NetworkTrafficRuleEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for NetworkTrafficRuleEffect
        /// </summary>
        public static readonly NetworkTrafficRuleEffect ALLOW = new NetworkTrafficRuleEffect("ALLOW");
        /// <summary>
        /// Constant DENY for NetworkTrafficRuleEffect
        /// </summary>
        public static readonly NetworkTrafficRuleEffect DENY = new NetworkTrafficRuleEffect("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkTrafficRuleEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkTrafficRuleEffect FindValue(string value)
        {
            return FindValue<NetworkTrafficRuleEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkTrafficRuleEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkTrafficRuleType.
    /// </summary>
    public class NetworkTrafficRuleType : ConstantClass
    {

        /// <summary>
        /// Constant URL for NetworkTrafficRuleType
        /// </summary>
        public static readonly NetworkTrafficRuleType URL = new NetworkTrafficRuleType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkTrafficRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkTrafficRuleType FindValue(string value)
        {
            return FindValue<NetworkTrafficRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkTrafficRuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateConnectionStatus.
    /// </summary>
    public class PrivateConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus ACTIVE = new PrivateConnectionStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus CREATE_FAILED = new PrivateConnectionStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus CREATE_IN_PROGRESS = new PrivateConnectionStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus DELETE_FAILED = new PrivateConnectionStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for PrivateConnectionStatus
        /// </summary>
        public static readonly PrivateConnectionStatus DELETE_IN_PROGRESS = new PrivateConnectionStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateConnectionStatus FindValue(string value)
        {
            return FindValue<PrivateConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateConnectionType.
    /// </summary>
    public class PrivateConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant SELF_MANAGED for PrivateConnectionType
        /// </summary>
        public static readonly PrivateConnectionType SELF_MANAGED = new PrivateConnectionType("SELF_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for PrivateConnectionType
        /// </summary>
        public static readonly PrivateConnectionType SERVICE_MANAGED = new PrivateConnectionType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateConnectionType FindValue(string value)
        {
            return FindValue<PrivateConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Provider.
    /// </summary>
    public class Provider : ConstantClass
    {

        /// <summary>
        /// Constant BITBUCKET for Provider
        /// </summary>
        public static readonly Provider BITBUCKET = new Provider("BITBUCKET");
        /// <summary>
        /// Constant CONFLUENCE for Provider
        /// </summary>
        public static readonly Provider CONFLUENCE = new Provider("CONFLUENCE");
        /// <summary>
        /// Constant GITHUB for Provider
        /// </summary>
        public static readonly Provider GITHUB = new Provider("GITHUB");
        /// <summary>
        /// Constant GITLAB for Provider
        /// </summary>
        public static readonly Provider GITLAB = new Provider("GITLAB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Provider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Provider FindValue(string value)
        {
            return FindValue<Provider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Provider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProviderType.
    /// </summary>
    public class ProviderType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENTATION for ProviderType
        /// </summary>
        public static readonly ProviderType DOCUMENTATION = new ProviderType("DOCUMENTATION");
        /// <summary>
        /// Constant SOURCE_CODE for ProviderType
        /// </summary>
        public static readonly ProviderType SOURCE_CODE = new ProviderType("SOURCE_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProviderType FindValue(string value)
        {
            return FindValue<ProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceConfigDnsResolution.
    /// </summary>
    public class ResourceConfigDnsResolution : ConstantClass
    {

        /// <summary>
        /// Constant IN_VPC for ResourceConfigDnsResolution
        /// </summary>
        public static readonly ResourceConfigDnsResolution IN_VPC = new ResourceConfigDnsResolution("IN_VPC");
        /// <summary>
        /// Constant PUBLIC for ResourceConfigDnsResolution
        /// </summary>
        public static readonly ResourceConfigDnsResolution PUBLIC = new ResourceConfigDnsResolution("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceConfigDnsResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceConfigDnsResolution FindValue(string value)
        {
            return FindValue<ResourceConfigDnsResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceConfigDnsResolution(string value)
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
        /// Constant CODE_REPOSITORY for ResourceType
        /// </summary>
        public static readonly ResourceType CODE_REPOSITORY = new ResourceType("CODE_REPOSITORY");
        /// <summary>
        /// Constant DOCUMENT for ResourceType
        /// </summary>
        public static readonly ResourceType DOCUMENT = new ResourceType("DOCUMENT");

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
    /// Constants used for properties of type RiskLevel.
    /// </summary>
    public class RiskLevel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for RiskLevel
        /// </summary>
        public static readonly RiskLevel CRITICAL = new RiskLevel("CRITICAL");
        /// <summary>
        /// Constant HIGH for RiskLevel
        /// </summary>
        public static readonly RiskLevel HIGH = new RiskLevel("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for RiskLevel
        /// </summary>
        public static readonly RiskLevel INFORMATIONAL = new RiskLevel("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for RiskLevel
        /// </summary>
        public static readonly RiskLevel LOW = new RiskLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for RiskLevel
        /// </summary>
        public static readonly RiskLevel MEDIUM = new RiskLevel("MEDIUM");
        /// <summary>
        /// Constant UNKNOWN for RiskLevel
        /// </summary>
        public static readonly RiskLevel UNKNOWN = new RiskLevel("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RiskLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RiskLevel FindValue(string value)
        {
            return FindValue<RiskLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RiskLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RiskType.
    /// </summary>
    public class RiskType : ConstantClass
    {

        /// <summary>
        /// Constant ARBITRARY_FILE_UPLOAD for RiskType
        /// </summary>
        public static readonly RiskType ARBITRARY_FILE_UPLOAD = new RiskType("ARBITRARY_FILE_UPLOAD");
        /// <summary>
        /// Constant BUSINESS_LOGIC_VULNERABILITIES for RiskType
        /// </summary>
        public static readonly RiskType BUSINESS_LOGIC_VULNERABILITIES = new RiskType("BUSINESS_LOGIC_VULNERABILITIES");
        /// <summary>
        /// Constant CODE_INJECTION for RiskType
        /// </summary>
        public static readonly RiskType CODE_INJECTION = new RiskType("CODE_INJECTION");
        /// <summary>
        /// Constant COMMAND_INJECTION for RiskType
        /// </summary>
        public static readonly RiskType COMMAND_INJECTION = new RiskType("COMMAND_INJECTION");
        /// <summary>
        /// Constant CROSS_SITE_SCRIPTING for RiskType
        /// </summary>
        public static readonly RiskType CROSS_SITE_SCRIPTING = new RiskType("CROSS_SITE_SCRIPTING");
        /// <summary>
        /// Constant CRYPTOGRAPHIC_VULNERABILITIES for RiskType
        /// </summary>
        public static readonly RiskType CRYPTOGRAPHIC_VULNERABILITIES = new RiskType("CRYPTOGRAPHIC_VULNERABILITIES");
        /// <summary>
        /// Constant DATABASE_ACCESS for RiskType
        /// </summary>
        public static readonly RiskType DATABASE_ACCESS = new RiskType("DATABASE_ACCESS");
        /// <summary>
        /// Constant DATABASE_MODIFICATION for RiskType
        /// </summary>
        public static readonly RiskType DATABASE_MODIFICATION = new RiskType("DATABASE_MODIFICATION");
        /// <summary>
        /// Constant DEFAULT_CREDENTIALS for RiskType
        /// </summary>
        public static readonly RiskType DEFAULT_CREDENTIALS = new RiskType("DEFAULT_CREDENTIALS");
        /// <summary>
        /// Constant DENIAL_OF_SERVICE for RiskType
        /// </summary>
        public static readonly RiskType DENIAL_OF_SERVICE = new RiskType("DENIAL_OF_SERVICE");
        /// <summary>
        /// Constant FILE_ACCESS for RiskType
        /// </summary>
        public static readonly RiskType FILE_ACCESS = new RiskType("FILE_ACCESS");
        /// <summary>
        /// Constant FILE_CREATION for RiskType
        /// </summary>
        public static readonly RiskType FILE_CREATION = new RiskType("FILE_CREATION");
        /// <summary>
        /// Constant FILE_DELETION for RiskType
        /// </summary>
        public static readonly RiskType FILE_DELETION = new RiskType("FILE_DELETION");
        /// <summary>
        /// Constant GRAPHQL_VULNERABILITIES for RiskType
        /// </summary>
        public static readonly RiskType GRAPHQL_VULNERABILITIES = new RiskType("GRAPHQL_VULNERABILITIES");
        /// <summary>
        /// Constant INFORMATION_DISCLOSURE for RiskType
        /// </summary>
        public static readonly RiskType INFORMATION_DISCLOSURE = new RiskType("INFORMATION_DISCLOSURE");
        /// <summary>
        /// Constant INSECURE_DESERIALIZATION for RiskType
        /// </summary>
        public static readonly RiskType INSECURE_DESERIALIZATION = new RiskType("INSECURE_DESERIALIZATION");
        /// <summary>
        /// Constant INSECURE_DIRECT_OBJECT_REFERENCE for RiskType
        /// </summary>
        public static readonly RiskType INSECURE_DIRECT_OBJECT_REFERENCE = new RiskType("INSECURE_DIRECT_OBJECT_REFERENCE");
        /// <summary>
        /// Constant JSON_WEB_TOKEN_VULNERABILITIES for RiskType
        /// </summary>
        public static readonly RiskType JSON_WEB_TOKEN_VULNERABILITIES = new RiskType("JSON_WEB_TOKEN_VULNERABILITIES");
        /// <summary>
        /// Constant LOCAL_FILE_INCLUSION for RiskType
        /// </summary>
        public static readonly RiskType LOCAL_FILE_INCLUSION = new RiskType("LOCAL_FILE_INCLUSION");
        /// <summary>
        /// Constant OTHER for RiskType
        /// </summary>
        public static readonly RiskType OTHER = new RiskType("OTHER");
        /// <summary>
        /// Constant OUTBOUND_SERVICE_REQUEST for RiskType
        /// </summary>
        public static readonly RiskType OUTBOUND_SERVICE_REQUEST = new RiskType("OUTBOUND_SERVICE_REQUEST");
        /// <summary>
        /// Constant PATH_TRAVERSAL for RiskType
        /// </summary>
        public static readonly RiskType PATH_TRAVERSAL = new RiskType("PATH_TRAVERSAL");
        /// <summary>
        /// Constant PRIVILEGE_ESCALATION for RiskType
        /// </summary>
        public static readonly RiskType PRIVILEGE_ESCALATION = new RiskType("PRIVILEGE_ESCALATION");
        /// <summary>
        /// Constant SERVER_SIDE_REQUEST_FORGERY for RiskType
        /// </summary>
        public static readonly RiskType SERVER_SIDE_REQUEST_FORGERY = new RiskType("SERVER_SIDE_REQUEST_FORGERY");
        /// <summary>
        /// Constant SERVER_SIDE_TEMPLATE_INJECTION for RiskType
        /// </summary>
        public static readonly RiskType SERVER_SIDE_TEMPLATE_INJECTION = new RiskType("SERVER_SIDE_TEMPLATE_INJECTION");
        /// <summary>
        /// Constant SQL_INJECTION for RiskType
        /// </summary>
        public static readonly RiskType SQL_INJECTION = new RiskType("SQL_INJECTION");
        /// <summary>
        /// Constant UNKNOWN for RiskType
        /// </summary>
        public static readonly RiskType UNKNOWN = new RiskType("UNKNOWN");
        /// <summary>
        /// Constant XML_EXTERNAL_ENTITY for RiskType
        /// </summary>
        public static readonly RiskType XML_EXTERNAL_ENTITY = new RiskType("XML_EXTERNAL_ENTITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RiskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RiskType FindValue(string value)
        {
            return FindValue<RiskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RiskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityRequirementArtifactFormat.
    /// </summary>
    public class SecurityRequirementArtifactFormat : ConstantClass
    {

        /// <summary>
        /// Constant DOC for SecurityRequirementArtifactFormat
        /// </summary>
        public static readonly SecurityRequirementArtifactFormat DOC = new SecurityRequirementArtifactFormat("DOC");
        /// <summary>
        /// Constant DOCX for SecurityRequirementArtifactFormat
        /// </summary>
        public static readonly SecurityRequirementArtifactFormat DOCX = new SecurityRequirementArtifactFormat("DOCX");
        /// <summary>
        /// Constant MD for SecurityRequirementArtifactFormat
        /// </summary>
        public static readonly SecurityRequirementArtifactFormat MD = new SecurityRequirementArtifactFormat("MD");
        /// <summary>
        /// Constant PDF for SecurityRequirementArtifactFormat
        /// </summary>
        public static readonly SecurityRequirementArtifactFormat PDF = new SecurityRequirementArtifactFormat("PDF");
        /// <summary>
        /// Constant TXT for SecurityRequirementArtifactFormat
        /// </summary>
        public static readonly SecurityRequirementArtifactFormat TXT = new SecurityRequirementArtifactFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityRequirementArtifactFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityRequirementArtifactFormat FindValue(string value)
        {
            return FindValue<SecurityRequirementArtifactFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityRequirementArtifactFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityRequirementPackImportStatus.
    /// </summary>
    public class SecurityRequirementPackImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SecurityRequirementPackImportStatus
        /// </summary>
        public static readonly SecurityRequirementPackImportStatus COMPLETED = new SecurityRequirementPackImportStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for SecurityRequirementPackImportStatus
        /// </summary>
        public static readonly SecurityRequirementPackImportStatus FAILED = new SecurityRequirementPackImportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SecurityRequirementPackImportStatus
        /// </summary>
        public static readonly SecurityRequirementPackImportStatus IN_PROGRESS = new SecurityRequirementPackImportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for SecurityRequirementPackImportStatus
        /// </summary>
        public static readonly SecurityRequirementPackImportStatus PENDING = new SecurityRequirementPackImportStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityRequirementPackImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityRequirementPackImportStatus FindValue(string value)
        {
            return FindValue<SecurityRequirementPackImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityRequirementPackImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityRequirementPackStatus.
    /// </summary>
    public class SecurityRequirementPackStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SecurityRequirementPackStatus
        /// </summary>
        public static readonly SecurityRequirementPackStatus DISABLED = new SecurityRequirementPackStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for SecurityRequirementPackStatus
        /// </summary>
        public static readonly SecurityRequirementPackStatus ENABLED = new SecurityRequirementPackStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityRequirementPackStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityRequirementPackStatus FindValue(string value)
        {
            return FindValue<SecurityRequirementPackStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityRequirementPackStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SkillType.
    /// </summary>
    public class SkillType : ConstantClass
    {

        /// <summary>
        /// Constant FINDING_PERSONALIZATION for SkillType
        /// </summary>
        public static readonly SkillType FINDING_PERSONALIZATION = new SkillType("FINDING_PERSONALIZATION");
        /// <summary>
        /// Constant LOGIN_OPTIMIZATION for SkillType
        /// </summary>
        public static readonly SkillType LOGIN_OPTIMIZATION = new SkillType("LOGIN_OPTIMIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SkillType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SkillType FindValue(string value)
        {
            return FindValue<SkillType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SkillType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepName.
    /// </summary>
    public class StepName : ConstantClass
    {

        /// <summary>
        /// Constant FINALIZING for StepName
        /// </summary>
        public static readonly StepName FINALIZING = new StepName("FINALIZING");
        /// <summary>
        /// Constant PENTEST for StepName
        /// </summary>
        public static readonly StepName PENTEST = new StepName("PENTEST");
        /// <summary>
        /// Constant PREFLIGHT for StepName
        /// </summary>
        public static readonly StepName PREFLIGHT = new StepName("PREFLIGHT");
        /// <summary>
        /// Constant STATIC_ANALYSIS for StepName
        /// </summary>
        public static readonly StepName STATIC_ANALYSIS = new StepName("STATIC_ANALYSIS");
        /// <summary>
        /// Constant VALIDATION for StepName
        /// </summary>
        public static readonly StepName VALIDATION = new StepName("VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepName FindValue(string value)
        {
            return FindValue<StepName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepStatus.
    /// </summary>
    public class StepStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for StepStatus
        /// </summary>
        public static readonly StepStatus COMPLETED = new StepStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for StepStatus
        /// </summary>
        public static readonly StepStatus FAILED = new StepStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for StepStatus
        /// </summary>
        public static readonly StepStatus IN_PROGRESS = new StepStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for StepStatus
        /// </summary>
        public static readonly StepStatus NOT_STARTED = new StepStatus("NOT_STARTED");
        /// <summary>
        /// Constant STOPPED for StepStatus
        /// </summary>
        public static readonly StepStatus STOPPED = new StepStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepStatus FindValue(string value)
        {
            return FindValue<StepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StrideCategory.
    /// </summary>
    public class StrideCategory : ConstantClass
    {

        /// <summary>
        /// Constant DENIAL_OF_SERVICE for StrideCategory
        /// </summary>
        public static readonly StrideCategory DENIAL_OF_SERVICE = new StrideCategory("DENIAL_OF_SERVICE");
        /// <summary>
        /// Constant ELEVATION_OF_PRIVILEGE for StrideCategory
        /// </summary>
        public static readonly StrideCategory ELEVATION_OF_PRIVILEGE = new StrideCategory("ELEVATION_OF_PRIVILEGE");
        /// <summary>
        /// Constant INFORMATION_DISCLOSURE for StrideCategory
        /// </summary>
        public static readonly StrideCategory INFORMATION_DISCLOSURE = new StrideCategory("INFORMATION_DISCLOSURE");
        /// <summary>
        /// Constant REPUDIATION for StrideCategory
        /// </summary>
        public static readonly StrideCategory REPUDIATION = new StrideCategory("REPUDIATION");
        /// <summary>
        /// Constant SPOOFING for StrideCategory
        /// </summary>
        public static readonly StrideCategory SPOOFING = new StrideCategory("SPOOFING");
        /// <summary>
        /// Constant TAMPERING for StrideCategory
        /// </summary>
        public static readonly StrideCategory TAMPERING = new StrideCategory("TAMPERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StrideCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StrideCategory FindValue(string value)
        {
            return FindValue<StrideCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StrideCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDomainStatus.
    /// </summary>
    public class TargetDomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for TargetDomainStatus
        /// </summary>
        public static readonly TargetDomainStatus FAILED = new TargetDomainStatus("FAILED");
        /// <summary>
        /// Constant PENDING for TargetDomainStatus
        /// </summary>
        public static readonly TargetDomainStatus PENDING = new TargetDomainStatus("PENDING");
        /// <summary>
        /// Constant UNREACHABLE for TargetDomainStatus
        /// </summary>
        public static readonly TargetDomainStatus UNREACHABLE = new TargetDomainStatus("UNREACHABLE");
        /// <summary>
        /// Constant VERIFIED for TargetDomainStatus
        /// </summary>
        public static readonly TargetDomainStatus VERIFIED = new TargetDomainStatus("VERIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDomainStatus FindValue(string value)
        {
            return FindValue<TargetDomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskExecutionStatus.
    /// </summary>
    public class TaskExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus ABORTED = new TaskExecutionStatus("ABORTED");
        /// <summary>
        /// Constant COMPLETED for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus COMPLETED = new TaskExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus FAILED = new TaskExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus IN_PROGRESS = new TaskExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INTERNAL_ERROR for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus INTERNAL_ERROR = new TaskExecutionStatus("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskExecutionStatus FindValue(string value)
        {
            return FindValue<TaskExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatActor.
    /// </summary>
    public class ThreatActor : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ThreatActor
        /// </summary>
        public static readonly ThreatActor AGENT = new ThreatActor("AGENT");
        /// <summary>
        /// Constant CUSTOMER for ThreatActor
        /// </summary>
        public static readonly ThreatActor CUSTOMER = new ThreatActor("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatActor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatActor FindValue(string value)
        {
            return FindValue<ThreatActor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatActor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatSeverity.
    /// </summary>
    public class ThreatSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for ThreatSeverity
        /// </summary>
        public static readonly ThreatSeverity CRITICAL = new ThreatSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for ThreatSeverity
        /// </summary>
        public static readonly ThreatSeverity HIGH = new ThreatSeverity("HIGH");
        /// <summary>
        /// Constant INFO for ThreatSeverity
        /// </summary>
        public static readonly ThreatSeverity INFO = new ThreatSeverity("INFO");
        /// <summary>
        /// Constant LOW for ThreatSeverity
        /// </summary>
        public static readonly ThreatSeverity LOW = new ThreatSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for ThreatSeverity
        /// </summary>
        public static readonly ThreatSeverity MEDIUM = new ThreatSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatSeverity FindValue(string value)
        {
            return FindValue<ThreatSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatStatus.
    /// </summary>
    public class ThreatStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISMISSED for ThreatStatus
        /// </summary>
        public static readonly ThreatStatus DISMISSED = new ThreatStatus("DISMISSED");
        /// <summary>
        /// Constant OPEN for ThreatStatus
        /// </summary>
        public static readonly ThreatStatus OPEN = new ThreatStatus("OPEN");
        /// <summary>
        /// Constant RESOLVED for ThreatStatus
        /// </summary>
        public static readonly ThreatStatus RESOLVED = new ThreatStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatStatus FindValue(string value)
        {
            return FindValue<ThreatStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserRole.
    /// </summary>
    public class UserRole : ConstantClass
    {

        /// <summary>
        /// Constant MEMBER for UserRole
        /// </summary>
        public static readonly UserRole MEMBER = new UserRole("MEMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserRole FindValue(string value)
        {
            return FindValue<UserRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationMode.
    /// </summary>
    public class ValidationMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ValidationMode
        /// </summary>
        public static readonly ValidationMode DISABLED = new ValidationMode("DISABLED");
        /// <summary>
        /// Constant SIMULATED for ValidationMode
        /// </summary>
        public static readonly ValidationMode SIMULATED = new ValidationMode("SIMULATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationMode FindValue(string value)
        {
            return FindValue<ValidationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationStatus.
    /// </summary>
    public class ValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIRMED for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus CONFIRMED = new ValidationStatus("CONFIRMED");
        /// <summary>
        /// Constant NOT_REPRODUCED for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus NOT_REPRODUCED = new ValidationStatus("NOT_REPRODUCED");
        /// <summary>
        /// Constant NOT_VALIDATED for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus NOT_VALIDATED = new ValidationStatus("NOT_VALIDATED");
        /// <summary>
        /// Constant VALIDATING for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus VALIDATING = new ValidationStatus("VALIDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for ValidationStatus
        /// </summary>
        public static readonly ValidationStatus VALIDATION_FAILED = new ValidationStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationStatus FindValue(string value)
        {
            return FindValue<ValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationStatus(string value)
        {
            return FindValue(value);
        }
    }

}
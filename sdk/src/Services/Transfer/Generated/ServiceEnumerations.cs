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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Transfer
{

    /// <summary>
    /// Constants used for properties of type AgreementStatusType.
    /// </summary>
    public class AgreementStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AgreementStatusType
        /// </summary>
        public static readonly AgreementStatusType ACTIVE = new AgreementStatusType("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AgreementStatusType
        /// </summary>
        public static readonly AgreementStatusType INACTIVE = new AgreementStatusType("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgreementStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgreementStatusType FindValue(string value)
        {
            return FindValue<AgreementStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgreementStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type As2Transport.
    /// </summary>
    public class As2Transport : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for As2Transport
        /// </summary>
        public static readonly As2Transport HTTP = new As2Transport("HTTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public As2Transport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static As2Transport FindValue(string value)
        {
            return FindValue<As2Transport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator As2Transport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateStatusType.
    /// </summary>
    public class CertificateStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CertificateStatusType
        /// </summary>
        public static readonly CertificateStatusType ACTIVE = new CertificateStatusType("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CertificateStatusType
        /// </summary>
        public static readonly CertificateStatusType INACTIVE = new CertificateStatusType("INACTIVE");
        /// <summary>
        /// Constant PENDING_ROTATION for CertificateStatusType
        /// </summary>
        public static readonly CertificateStatusType PENDING_ROTATION = new CertificateStatusType("PENDING_ROTATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateStatusType FindValue(string value)
        {
            return FindValue<CertificateStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateStatusType(string value)
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
        /// Constant CERTIFICATE for CertificateType
        /// </summary>
        public static readonly CertificateType CERTIFICATE = new CertificateType("CERTIFICATE");
        /// <summary>
        /// Constant CERTIFICATE_WITH_PRIVATE_KEY for CertificateType
        /// </summary>
        public static readonly CertificateType CERTIFICATE_WITH_PRIVATE_KEY = new CertificateType("CERTIFICATE_WITH_PRIVATE_KEY");

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
    /// Constants used for properties of type CertificateUsageType.
    /// </summary>
    public class CertificateUsageType : ConstantClass
    {

        /// <summary>
        /// Constant ENCRYPTION for CertificateUsageType
        /// </summary>
        public static readonly CertificateUsageType ENCRYPTION = new CertificateUsageType("ENCRYPTION");
        /// <summary>
        /// Constant SIGNING for CertificateUsageType
        /// </summary>
        public static readonly CertificateUsageType SIGNING = new CertificateUsageType("SIGNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateUsageType FindValue(string value)
        {
            return FindValue<CertificateUsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateUsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionEnum.
    /// </summary>
    public class CompressionEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CompressionEnum
        /// </summary>
        public static readonly CompressionEnum DISABLED = new CompressionEnum("DISABLED");
        /// <summary>
        /// Constant ZLIB for CompressionEnum
        /// </summary>
        public static readonly CompressionEnum ZLIB = new CompressionEnum("ZLIB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionEnum FindValue(string value)
        {
            return FindValue<CompressionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomStepStatus.
    /// </summary>
    public class CustomStepStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for CustomStepStatus
        /// </summary>
        public static readonly CustomStepStatus FAILURE = new CustomStepStatus("FAILURE");
        /// <summary>
        /// Constant SUCCESS for CustomStepStatus
        /// </summary>
        public static readonly CustomStepStatus SUCCESS = new CustomStepStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomStepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomStepStatus FindValue(string value)
        {
            return FindValue<CustomStepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomStepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Domain.
    /// </summary>
    public class Domain : ConstantClass
    {

        /// <summary>
        /// Constant EFS for Domain
        /// </summary>
        public static readonly Domain EFS = new Domain("EFS");
        /// <summary>
        /// Constant S3 for Domain
        /// </summary>
        public static readonly Domain S3 = new Domain("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Domain(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Domain FindValue(string value)
        {
            return FindValue<Domain>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Domain(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionAlg.
    /// </summary>
    public class EncryptionAlg : ConstantClass
    {

        /// <summary>
        /// Constant AES128_CBC for EncryptionAlg
        /// </summary>
        public static readonly EncryptionAlg AES128_CBC = new EncryptionAlg("AES128_CBC");
        /// <summary>
        /// Constant AES192_CBC for EncryptionAlg
        /// </summary>
        public static readonly EncryptionAlg AES192_CBC = new EncryptionAlg("AES192_CBC");
        /// <summary>
        /// Constant AES256_CBC for EncryptionAlg
        /// </summary>
        public static readonly EncryptionAlg AES256_CBC = new EncryptionAlg("AES256_CBC");
        /// <summary>
        /// Constant NONE for EncryptionAlg
        /// </summary>
        public static readonly EncryptionAlg NONE = new EncryptionAlg("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionAlg(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionAlg FindValue(string value)
        {
            return FindValue<EncryptionAlg>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionAlg(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant PGP for EncryptionType
        /// </summary>
        public static readonly EncryptionType PGP = new EncryptionType("PGP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for EndpointType
        /// </summary>
        public static readonly EndpointType PUBLIC = new EndpointType("PUBLIC");
        /// <summary>
        /// Constant VPC for EndpointType
        /// </summary>
        public static readonly EndpointType VPC = new EndpointType("VPC");
        /// <summary>
        /// Constant VPC_ENDPOINT for EndpointType
        /// </summary>
        public static readonly EndpointType VPC_ENDPOINT = new EndpointType("VPC_ENDPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionErrorType.
    /// </summary>
    public class ExecutionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ALREADY_EXISTS for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType ALREADY_EXISTS = new ExecutionErrorType("ALREADY_EXISTS");
        /// <summary>
        /// Constant BAD_REQUEST for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType BAD_REQUEST = new ExecutionErrorType("BAD_REQUEST");
        /// <summary>
        /// Constant CUSTOM_STEP_FAILED for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType CUSTOM_STEP_FAILED = new ExecutionErrorType("CUSTOM_STEP_FAILED");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType INTERNAL_SERVER_ERROR = new ExecutionErrorType("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType NOT_FOUND = new ExecutionErrorType("NOT_FOUND");
        /// <summary>
        /// Constant PERMISSION_DENIED for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType PERMISSION_DENIED = new ExecutionErrorType("PERMISSION_DENIED");
        /// <summary>
        /// Constant THROTTLED for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType THROTTLED = new ExecutionErrorType("THROTTLED");
        /// <summary>
        /// Constant TIMEOUT for ExecutionErrorType
        /// </summary>
        public static readonly ExecutionErrorType TIMEOUT = new ExecutionErrorType("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionErrorType FindValue(string value)
        {
            return FindValue<ExecutionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus COMPLETED = new ExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant EXCEPTION for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus EXCEPTION = new ExecutionStatus("EXCEPTION");
        /// <summary>
        /// Constant HANDLING_EXCEPTION for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus HANDLING_EXCEPTION = new ExecutionStatus("HANDLING_EXCEPTION");
        /// <summary>
        /// Constant IN_PROGRESS for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus IN_PROGRESS = new ExecutionStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HomeDirectoryType.
    /// </summary>
    public class HomeDirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant LOGICAL for HomeDirectoryType
        /// </summary>
        public static readonly HomeDirectoryType LOGICAL = new HomeDirectoryType("LOGICAL");
        /// <summary>
        /// Constant PATH for HomeDirectoryType
        /// </summary>
        public static readonly HomeDirectoryType PATH = new HomeDirectoryType("PATH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HomeDirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HomeDirectoryType FindValue(string value)
        {
            return FindValue<HomeDirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HomeDirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProviderType.
    /// </summary>
    public class IdentityProviderType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType API_GATEWAY = new IdentityProviderType("API_GATEWAY");
        /// <summary>
        /// Constant AWS_DIRECTORY_SERVICE for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType AWS_DIRECTORY_SERVICE = new IdentityProviderType("AWS_DIRECTORY_SERVICE");
        /// <summary>
        /// Constant AWS_LAMBDA for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType AWS_LAMBDA = new IdentityProviderType("AWS_LAMBDA");
        /// <summary>
        /// Constant SERVICE_MANAGED for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType SERVICE_MANAGED = new IdentityProviderType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderType FindValue(string value)
        {
            return FindValue<IdentityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MdnResponse.
    /// </summary>
    public class MdnResponse : ConstantClass
    {

        /// <summary>
        /// Constant NONE for MdnResponse
        /// </summary>
        public static readonly MdnResponse NONE = new MdnResponse("NONE");
        /// <summary>
        /// Constant SYNC for MdnResponse
        /// </summary>
        public static readonly MdnResponse SYNC = new MdnResponse("SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MdnResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MdnResponse FindValue(string value)
        {
            return FindValue<MdnResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MdnResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MdnSigningAlg.
    /// </summary>
    public class MdnSigningAlg : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg DEFAULT = new MdnSigningAlg("DEFAULT");
        /// <summary>
        /// Constant NONE for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg NONE = new MdnSigningAlg("NONE");
        /// <summary>
        /// Constant SHA1 for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg SHA1 = new MdnSigningAlg("SHA1");
        /// <summary>
        /// Constant SHA256 for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg SHA256 = new MdnSigningAlg("SHA256");
        /// <summary>
        /// Constant SHA384 for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg SHA384 = new MdnSigningAlg("SHA384");
        /// <summary>
        /// Constant SHA512 for MdnSigningAlg
        /// </summary>
        public static readonly MdnSigningAlg SHA512 = new MdnSigningAlg("SHA512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MdnSigningAlg(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MdnSigningAlg FindValue(string value)
        {
            return FindValue<MdnSigningAlg>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MdnSigningAlg(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverwriteExisting.
    /// </summary>
    public class OverwriteExisting : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for OverwriteExisting
        /// </summary>
        public static readonly OverwriteExisting FALSE = new OverwriteExisting("FALSE");
        /// <summary>
        /// Constant TRUE for OverwriteExisting
        /// </summary>
        public static readonly OverwriteExisting TRUE = new OverwriteExisting("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverwriteExisting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverwriteExisting FindValue(string value)
        {
            return FindValue<OverwriteExisting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverwriteExisting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileType.
    /// </summary>
    public class ProfileType : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL for ProfileType
        /// </summary>
        public static readonly ProfileType LOCAL = new ProfileType("LOCAL");
        /// <summary>
        /// Constant PARTNER for ProfileType
        /// </summary>
        public static readonly ProfileType PARTNER = new ProfileType("PARTNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileType FindValue(string value)
        {
            return FindValue<ProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant AS2 for Protocol
        /// </summary>
        public static readonly Protocol AS2 = new Protocol("AS2");
        /// <summary>
        /// Constant FTP for Protocol
        /// </summary>
        public static readonly Protocol FTP = new Protocol("FTP");
        /// <summary>
        /// Constant FTPS for Protocol
        /// </summary>
        public static readonly Protocol FTPS = new Protocol("FTPS");
        /// <summary>
        /// Constant SFTP for Protocol
        /// </summary>
        public static readonly Protocol SFTP = new Protocol("SFTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SetStatOption.
    /// </summary>
    public class SetStatOption : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for SetStatOption
        /// </summary>
        public static readonly SetStatOption DEFAULT = new SetStatOption("DEFAULT");
        /// <summary>
        /// Constant ENABLE_NO_OP for SetStatOption
        /// </summary>
        public static readonly SetStatOption ENABLE_NO_OP = new SetStatOption("ENABLE_NO_OP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SetStatOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SetStatOption FindValue(string value)
        {
            return FindValue<SetStatOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SetStatOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SigningAlg.
    /// </summary>
    public class SigningAlg : ConstantClass
    {

        /// <summary>
        /// Constant NONE for SigningAlg
        /// </summary>
        public static readonly SigningAlg NONE = new SigningAlg("NONE");
        /// <summary>
        /// Constant SHA1 for SigningAlg
        /// </summary>
        public static readonly SigningAlg SHA1 = new SigningAlg("SHA1");
        /// <summary>
        /// Constant SHA256 for SigningAlg
        /// </summary>
        public static readonly SigningAlg SHA256 = new SigningAlg("SHA256");
        /// <summary>
        /// Constant SHA384 for SigningAlg
        /// </summary>
        public static readonly SigningAlg SHA384 = new SigningAlg("SHA384");
        /// <summary>
        /// Constant SHA512 for SigningAlg
        /// </summary>
        public static readonly SigningAlg SHA512 = new SigningAlg("SHA512");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningAlg(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningAlg FindValue(string value)
        {
            return FindValue<SigningAlg>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningAlg(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for State
        /// </summary>
        public static readonly State OFFLINE = new State("OFFLINE");
        /// <summary>
        /// Constant ONLINE for State
        /// </summary>
        public static readonly State ONLINE = new State("ONLINE");
        /// <summary>
        /// Constant START_FAILED for State
        /// </summary>
        public static readonly State START_FAILED = new State("START_FAILED");
        /// <summary>
        /// Constant STARTING for State
        /// </summary>
        public static readonly State STARTING = new State("STARTING");
        /// <summary>
        /// Constant STOP_FAILED for State
        /// </summary>
        public static readonly State STOP_FAILED = new State("STOP_FAILED");
        /// <summary>
        /// Constant STOPPING for State
        /// </summary>
        public static readonly State STOPPING = new State("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TlsSessionResumptionMode.
    /// </summary>
    public class TlsSessionResumptionMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for TlsSessionResumptionMode
        /// </summary>
        public static readonly TlsSessionResumptionMode DISABLED = new TlsSessionResumptionMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for TlsSessionResumptionMode
        /// </summary>
        public static readonly TlsSessionResumptionMode ENABLED = new TlsSessionResumptionMode("ENABLED");
        /// <summary>
        /// Constant ENFORCED for TlsSessionResumptionMode
        /// </summary>
        public static readonly TlsSessionResumptionMode ENFORCED = new TlsSessionResumptionMode("ENFORCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TlsSessionResumptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TlsSessionResumptionMode FindValue(string value)
        {
            return FindValue<TlsSessionResumptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TlsSessionResumptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStepType.
    /// </summary>
    public class WorkflowStepType : ConstantClass
    {

        /// <summary>
        /// Constant COPY for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType COPY = new WorkflowStepType("COPY");
        /// <summary>
        /// Constant CUSTOM for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType CUSTOM = new WorkflowStepType("CUSTOM");
        /// <summary>
        /// Constant DECRYPT for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType DECRYPT = new WorkflowStepType("DECRYPT");
        /// <summary>
        /// Constant DELETE for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType DELETE = new WorkflowStepType("DELETE");
        /// <summary>
        /// Constant TAG for WorkflowStepType
        /// </summary>
        public static readonly WorkflowStepType TAG = new WorkflowStepType("TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStepType FindValue(string value)
        {
            return FindValue<WorkflowStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStepType(string value)
        {
            return FindValue(value);
        }
    }

}
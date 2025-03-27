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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ACMPCA
{

    /// <summary>
    /// Constants used for properties of type AccessMethodType.
    /// </summary>
    public class AccessMethodType : ConstantClass
    {

        /// <summary>
        /// Constant CA_REPOSITORY for AccessMethodType
        /// </summary>
        public static readonly AccessMethodType CA_REPOSITORY = new AccessMethodType("CA_REPOSITORY");
        /// <summary>
        /// Constant RESOURCE_PKI_MANIFEST for AccessMethodType
        /// </summary>
        public static readonly AccessMethodType RESOURCE_PKI_MANIFEST = new AccessMethodType("RESOURCE_PKI_MANIFEST");
        /// <summary>
        /// Constant RESOURCE_PKI_NOTIFY for AccessMethodType
        /// </summary>
        public static readonly AccessMethodType RESOURCE_PKI_NOTIFY = new AccessMethodType("RESOURCE_PKI_NOTIFY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessMethodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessMethodType FindValue(string value)
        {
            return FindValue<AccessMethodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessMethodType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant GetCertificate for ActionType
        /// </summary>
        public static readonly ActionType GetCertificate = new ActionType("GetCertificate");
        /// <summary>
        /// Constant IssueCertificate for ActionType
        /// </summary>
        public static readonly ActionType IssueCertificate = new ActionType("IssueCertificate");
        /// <summary>
        /// Constant ListPermissions for ActionType
        /// </summary>
        public static readonly ActionType ListPermissions = new ActionType("ListPermissions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditReportResponseFormat.
    /// </summary>
    public class AuditReportResponseFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for AuditReportResponseFormat
        /// </summary>
        public static readonly AuditReportResponseFormat CSV = new AuditReportResponseFormat("CSV");
        /// <summary>
        /// Constant JSON for AuditReportResponseFormat
        /// </summary>
        public static readonly AuditReportResponseFormat JSON = new AuditReportResponseFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditReportResponseFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditReportResponseFormat FindValue(string value)
        {
            return FindValue<AuditReportResponseFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditReportResponseFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditReportStatus.
    /// </summary>
    public class AuditReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for AuditReportStatus
        /// </summary>
        public static readonly AuditReportStatus CREATING = new AuditReportStatus("CREATING");
        /// <summary>
        /// Constant FAILED for AuditReportStatus
        /// </summary>
        public static readonly AuditReportStatus FAILED = new AuditReportStatus("FAILED");
        /// <summary>
        /// Constant SUCCESS for AuditReportStatus
        /// </summary>
        public static readonly AuditReportStatus SUCCESS = new AuditReportStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditReportStatus FindValue(string value)
        {
            return FindValue<AuditReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateAuthorityStatus.
    /// </summary>
    public class CertificateAuthorityStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus ACTIVE = new CertificateAuthorityStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus CREATING = new CertificateAuthorityStatus("CREATING");
        /// <summary>
        /// Constant DELETED for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus DELETED = new CertificateAuthorityStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus DISABLED = new CertificateAuthorityStatus("DISABLED");
        /// <summary>
        /// Constant EXPIRED for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus EXPIRED = new CertificateAuthorityStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus FAILED = new CertificateAuthorityStatus("FAILED");
        /// <summary>
        /// Constant PENDING_CERTIFICATE for CertificateAuthorityStatus
        /// </summary>
        public static readonly CertificateAuthorityStatus PENDING_CERTIFICATE = new CertificateAuthorityStatus("PENDING_CERTIFICATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateAuthorityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateAuthorityStatus FindValue(string value)
        {
            return FindValue<CertificateAuthorityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateAuthorityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateAuthorityType.
    /// </summary>
    public class CertificateAuthorityType : ConstantClass
    {

        /// <summary>
        /// Constant ROOT for CertificateAuthorityType
        /// </summary>
        public static readonly CertificateAuthorityType ROOT = new CertificateAuthorityType("ROOT");
        /// <summary>
        /// Constant SUBORDINATE for CertificateAuthorityType
        /// </summary>
        public static readonly CertificateAuthorityType SUBORDINATE = new CertificateAuthorityType("SUBORDINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateAuthorityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateAuthorityType FindValue(string value)
        {
            return FindValue<CertificateAuthorityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateAuthorityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateAuthorityUsageMode.
    /// </summary>
    public class CertificateAuthorityUsageMode : ConstantClass
    {

        /// <summary>
        /// Constant GENERAL_PURPOSE for CertificateAuthorityUsageMode
        /// </summary>
        public static readonly CertificateAuthorityUsageMode GENERAL_PURPOSE = new CertificateAuthorityUsageMode("GENERAL_PURPOSE");
        /// <summary>
        /// Constant SHORT_LIVED_CERTIFICATE for CertificateAuthorityUsageMode
        /// </summary>
        public static readonly CertificateAuthorityUsageMode SHORT_LIVED_CERTIFICATE = new CertificateAuthorityUsageMode("SHORT_LIVED_CERTIFICATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateAuthorityUsageMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateAuthorityUsageMode FindValue(string value)
        {
            return FindValue<CertificateAuthorityUsageMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateAuthorityUsageMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrlType.
    /// </summary>
    public class CrlType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for CrlType
        /// </summary>
        public static readonly CrlType COMPLETE = new CrlType("COMPLETE");
        /// <summary>
        /// Constant PARTITIONED for CrlType
        /// </summary>
        public static readonly CrlType PARTITIONED = new CrlType("PARTITIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrlType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrlType FindValue(string value)
        {
            return FindValue<CrlType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrlType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExtendedKeyUsageType.
    /// </summary>
    public class ExtendedKeyUsageType : ConstantClass
    {

        /// <summary>
        /// Constant CERTIFICATE_TRANSPARENCY for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType CERTIFICATE_TRANSPARENCY = new ExtendedKeyUsageType("CERTIFICATE_TRANSPARENCY");
        /// <summary>
        /// Constant CLIENT_AUTH for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType CLIENT_AUTH = new ExtendedKeyUsageType("CLIENT_AUTH");
        /// <summary>
        /// Constant CODE_SIGNING for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType CODE_SIGNING = new ExtendedKeyUsageType("CODE_SIGNING");
        /// <summary>
        /// Constant DOCUMENT_SIGNING for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType DOCUMENT_SIGNING = new ExtendedKeyUsageType("DOCUMENT_SIGNING");
        /// <summary>
        /// Constant EMAIL_PROTECTION for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType EMAIL_PROTECTION = new ExtendedKeyUsageType("EMAIL_PROTECTION");
        /// <summary>
        /// Constant OCSP_SIGNING for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType OCSP_SIGNING = new ExtendedKeyUsageType("OCSP_SIGNING");
        /// <summary>
        /// Constant SERVER_AUTH for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType SERVER_AUTH = new ExtendedKeyUsageType("SERVER_AUTH");
        /// <summary>
        /// Constant SMART_CARD_LOGIN for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType SMART_CARD_LOGIN = new ExtendedKeyUsageType("SMART_CARD_LOGIN");
        /// <summary>
        /// Constant TIME_STAMPING for ExtendedKeyUsageType
        /// </summary>
        public static readonly ExtendedKeyUsageType TIME_STAMPING = new ExtendedKeyUsageType("TIME_STAMPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExtendedKeyUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtendedKeyUsageType FindValue(string value)
        {
            return FindValue<ExtendedKeyUsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtendedKeyUsageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureReason.
    /// </summary>
    public class FailureReason : ConstantClass
    {

        /// <summary>
        /// Constant OTHER for FailureReason
        /// </summary>
        public static readonly FailureReason OTHER = new FailureReason("OTHER");
        /// <summary>
        /// Constant REQUEST_TIMED_OUT for FailureReason
        /// </summary>
        public static readonly FailureReason REQUEST_TIMED_OUT = new FailureReason("REQUEST_TIMED_OUT");
        /// <summary>
        /// Constant UNSUPPORTED_ALGORITHM for FailureReason
        /// </summary>
        public static readonly FailureReason UNSUPPORTED_ALGORITHM = new FailureReason("UNSUPPORTED_ALGORITHM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureReason FindValue(string value)
        {
            return FindValue<FailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyAlgorithm.
    /// </summary>
    public class KeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant EC_prime256v1 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm EC_prime256v1 = new KeyAlgorithm("EC_prime256v1");
        /// <summary>
        /// Constant EC_secp384r1 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm EC_secp384r1 = new KeyAlgorithm("EC_secp384r1");
        /// <summary>
        /// Constant EC_secp521r1 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm EC_secp521r1 = new KeyAlgorithm("EC_secp521r1");
        /// <summary>
        /// Constant RSA_2048 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_2048 = new KeyAlgorithm("RSA_2048");
        /// <summary>
        /// Constant RSA_3072 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_3072 = new KeyAlgorithm("RSA_3072");
        /// <summary>
        /// Constant RSA_4096 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_4096 = new KeyAlgorithm("RSA_4096");
        /// <summary>
        /// Constant SM2 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm SM2 = new KeyAlgorithm("SM2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyAlgorithm FindValue(string value)
        {
            return FindValue<KeyAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyStorageSecurityStandard.
    /// </summary>
    public class KeyStorageSecurityStandard : ConstantClass
    {

        /// <summary>
        /// Constant CCPC_LEVEL_1_OR_HIGHER for KeyStorageSecurityStandard
        /// </summary>
        public static readonly KeyStorageSecurityStandard CCPC_LEVEL_1_OR_HIGHER = new KeyStorageSecurityStandard("CCPC_LEVEL_1_OR_HIGHER");
        /// <summary>
        /// Constant FIPS_140_2_LEVEL_2_OR_HIGHER for KeyStorageSecurityStandard
        /// </summary>
        public static readonly KeyStorageSecurityStandard FIPS_140_2_LEVEL_2_OR_HIGHER = new KeyStorageSecurityStandard("FIPS_140_2_LEVEL_2_OR_HIGHER");
        /// <summary>
        /// Constant FIPS_140_2_LEVEL_3_OR_HIGHER for KeyStorageSecurityStandard
        /// </summary>
        public static readonly KeyStorageSecurityStandard FIPS_140_2_LEVEL_3_OR_HIGHER = new KeyStorageSecurityStandard("FIPS_140_2_LEVEL_3_OR_HIGHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyStorageSecurityStandard(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyStorageSecurityStandard FindValue(string value)
        {
            return FindValue<KeyStorageSecurityStandard>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyStorageSecurityStandard(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyQualifierId.
    /// </summary>
    public class PolicyQualifierId : ConstantClass
    {

        /// <summary>
        /// Constant CPS for PolicyQualifierId
        /// </summary>
        public static readonly PolicyQualifierId CPS = new PolicyQualifierId("CPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyQualifierId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyQualifierId FindValue(string value)
        {
            return FindValue<PolicyQualifierId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyQualifierId(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {

        /// <summary>
        /// Constant OTHER_ACCOUNTS for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner OTHER_ACCOUNTS = new ResourceOwner("OTHER_ACCOUNTS");
        /// <summary>
        /// Constant SELF for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SELF = new ResourceOwner("SELF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevocationReason.
    /// </summary>
    public class RevocationReason : ConstantClass
    {

        /// <summary>
        /// Constant A_A_COMPROMISE for RevocationReason
        /// </summary>
        public static readonly RevocationReason A_A_COMPROMISE = new RevocationReason("A_A_COMPROMISE");
        /// <summary>
        /// Constant AFFILIATION_CHANGED for RevocationReason
        /// </summary>
        public static readonly RevocationReason AFFILIATION_CHANGED = new RevocationReason("AFFILIATION_CHANGED");
        /// <summary>
        /// Constant CERTIFICATE_AUTHORITY_COMPROMISE for RevocationReason
        /// </summary>
        public static readonly RevocationReason CERTIFICATE_AUTHORITY_COMPROMISE = new RevocationReason("CERTIFICATE_AUTHORITY_COMPROMISE");
        /// <summary>
        /// Constant CESSATION_OF_OPERATION for RevocationReason
        /// </summary>
        public static readonly RevocationReason CESSATION_OF_OPERATION = new RevocationReason("CESSATION_OF_OPERATION");
        /// <summary>
        /// Constant KEY_COMPROMISE for RevocationReason
        /// </summary>
        public static readonly RevocationReason KEY_COMPROMISE = new RevocationReason("KEY_COMPROMISE");
        /// <summary>
        /// Constant PRIVILEGE_WITHDRAWN for RevocationReason
        /// </summary>
        public static readonly RevocationReason PRIVILEGE_WITHDRAWN = new RevocationReason("PRIVILEGE_WITHDRAWN");
        /// <summary>
        /// Constant SUPERSEDED for RevocationReason
        /// </summary>
        public static readonly RevocationReason SUPERSEDED = new RevocationReason("SUPERSEDED");
        /// <summary>
        /// Constant UNSPECIFIED for RevocationReason
        /// </summary>
        public static readonly RevocationReason UNSPECIFIED = new RevocationReason("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevocationReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevocationReason FindValue(string value)
        {
            return FindValue<RevocationReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevocationReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ObjectAcl.
    /// </summary>
    public class S3ObjectAcl : ConstantClass
    {

        /// <summary>
        /// Constant BUCKET_OWNER_FULL_CONTROL for S3ObjectAcl
        /// </summary>
        public static readonly S3ObjectAcl BUCKET_OWNER_FULL_CONTROL = new S3ObjectAcl("BUCKET_OWNER_FULL_CONTROL");
        /// <summary>
        /// Constant PUBLIC_READ for S3ObjectAcl
        /// </summary>
        public static readonly S3ObjectAcl PUBLIC_READ = new S3ObjectAcl("PUBLIC_READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ObjectAcl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ObjectAcl FindValue(string value)
        {
            return FindValue<S3ObjectAcl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ObjectAcl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SigningAlgorithm.
    /// </summary>
    public class SigningAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant SHA256WITHECDSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA256WITHECDSA = new SigningAlgorithm("SHA256WITHECDSA");
        /// <summary>
        /// Constant SHA256WITHRSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA256WITHRSA = new SigningAlgorithm("SHA256WITHRSA");
        /// <summary>
        /// Constant SHA384WITHECDSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA384WITHECDSA = new SigningAlgorithm("SHA384WITHECDSA");
        /// <summary>
        /// Constant SHA384WITHRSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA384WITHRSA = new SigningAlgorithm("SHA384WITHRSA");
        /// <summary>
        /// Constant SHA512WITHECDSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA512WITHECDSA = new SigningAlgorithm("SHA512WITHECDSA");
        /// <summary>
        /// Constant SHA512WITHRSA for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SHA512WITHRSA = new SigningAlgorithm("SHA512WITHRSA");
        /// <summary>
        /// Constant SM3WITHSM2 for SigningAlgorithm
        /// </summary>
        public static readonly SigningAlgorithm SM3WITHSM2 = new SigningAlgorithm("SM3WITHSM2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SigningAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SigningAlgorithm FindValue(string value)
        {
            return FindValue<SigningAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SigningAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidityPeriodType.
    /// </summary>
    public class ValidityPeriodType : ConstantClass
    {

        /// <summary>
        /// Constant ABSOLUTE for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType ABSOLUTE = new ValidityPeriodType("ABSOLUTE");
        /// <summary>
        /// Constant DAYS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType DAYS = new ValidityPeriodType("DAYS");
        /// <summary>
        /// Constant END_DATE for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType END_DATE = new ValidityPeriodType("END_DATE");
        /// <summary>
        /// Constant MONTHS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType MONTHS = new ValidityPeriodType("MONTHS");
        /// <summary>
        /// Constant YEARS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType YEARS = new ValidityPeriodType("YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidityPeriodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidityPeriodType FindValue(string value)
        {
            return FindValue<ValidityPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidityPeriodType(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ACMPCA
{

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
        /// Constant RSA_2048 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_2048 = new KeyAlgorithm("RSA_2048");
        /// <summary>
        /// Constant RSA_4096 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_4096 = new KeyAlgorithm("RSA_4096");

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
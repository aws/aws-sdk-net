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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CertificateManager
{

    /// <summary>
    /// Constants used for properties of type AcmeAccountStatus.
    /// </summary>
    public class AcmeAccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEACTIVATED for AcmeAccountStatus
        /// </summary>
        public static readonly AcmeAccountStatus DEACTIVATED = new AcmeAccountStatus("DEACTIVATED");
        /// <summary>
        /// Constant REVOKED for AcmeAccountStatus
        /// </summary>
        public static readonly AcmeAccountStatus REVOKED = new AcmeAccountStatus("REVOKED");
        /// <summary>
        /// Constant VALID for AcmeAccountStatus
        /// </summary>
        public static readonly AcmeAccountStatus VALID = new AcmeAccountStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeAccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeAccountStatus FindValue(string value)
        {
            return FindValue<AcmeAccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeAccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcmeAuthorizationBehavior.
    /// </summary>
    public class AcmeAuthorizationBehavior : ConstantClass
    {

        /// <summary>
        /// Constant PRE_APPROVED for AcmeAuthorizationBehavior
        /// </summary>
        public static readonly AcmeAuthorizationBehavior PRE_APPROVED = new AcmeAuthorizationBehavior("PRE_APPROVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeAuthorizationBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeAuthorizationBehavior FindValue(string value)
        {
            return FindValue<AcmeAuthorizationBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeAuthorizationBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcmeContact.
    /// </summary>
    public class AcmeContact : ConstantClass
    {

        /// <summary>
        /// Constant NOT_REQUIRED for AcmeContact
        /// </summary>
        public static readonly AcmeContact NOT_REQUIRED = new AcmeContact("NOT_REQUIRED");
        /// <summary>
        /// Constant REQUIRED for AcmeContact
        /// </summary>
        public static readonly AcmeContact REQUIRED = new AcmeContact("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeContact(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeContact FindValue(string value)
        {
            return FindValue<AcmeContact>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeContact(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcmeDomainValidationFailureReason.
    /// </summary>
    public class AcmeDomainValidationFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason ACCESS_DENIED = new AcmeDomainValidationFailureReason("ACCESS_DENIED");
        /// <summary>
        /// Constant DOMAIN_MISMATCH for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason DOMAIN_MISMATCH = new AcmeDomainValidationFailureReason("DOMAIN_MISMATCH");
        /// <summary>
        /// Constant DOMAIN_NOT_ALLOWED for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason DOMAIN_NOT_ALLOWED = new AcmeDomainValidationFailureReason("DOMAIN_NOT_ALLOWED");
        /// <summary>
        /// Constant ENDPOINT_NOT_ACTIVE for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason ENDPOINT_NOT_ACTIVE = new AcmeDomainValidationFailureReason("ENDPOINT_NOT_ACTIVE");
        /// <summary>
        /// Constant HOSTED_ZONE_NOT_FOUND for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason HOSTED_ZONE_NOT_FOUND = new AcmeDomainValidationFailureReason("HOSTED_ZONE_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason INTERNAL_FAILURE = new AcmeDomainValidationFailureReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant INVALID_CHANGE_BATCH for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason INVALID_CHANGE_BATCH = new AcmeDomainValidationFailureReason("INVALID_CHANGE_BATCH");
        /// <summary>
        /// Constant INVALID_PUBLIC_DOMAIN for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason INVALID_PUBLIC_DOMAIN = new AcmeDomainValidationFailureReason("INVALID_PUBLIC_DOMAIN");
        /// <summary>
        /// Constant TIMED_OUT for AcmeDomainValidationFailureReason
        /// </summary>
        public static readonly AcmeDomainValidationFailureReason TIMED_OUT = new AcmeDomainValidationFailureReason("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeDomainValidationFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeDomainValidationFailureReason FindValue(string value)
        {
            return FindValue<AcmeDomainValidationFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeDomainValidationFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcmeDomainValidationStatus.
    /// </summary>
    public class AcmeDomainValidationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for AcmeDomainValidationStatus
        /// </summary>
        public static readonly AcmeDomainValidationStatus DELETING = new AcmeDomainValidationStatus("DELETING");
        /// <summary>
        /// Constant INVALID for AcmeDomainValidationStatus
        /// </summary>
        public static readonly AcmeDomainValidationStatus INVALID = new AcmeDomainValidationStatus("INVALID");
        /// <summary>
        /// Constant VALID for AcmeDomainValidationStatus
        /// </summary>
        public static readonly AcmeDomainValidationStatus VALID = new AcmeDomainValidationStatus("VALID");
        /// <summary>
        /// Constant VALIDATING for AcmeDomainValidationStatus
        /// </summary>
        public static readonly AcmeDomainValidationStatus VALIDATING = new AcmeDomainValidationStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeDomainValidationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeDomainValidationStatus FindValue(string value)
        {
            return FindValue<AcmeDomainValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeDomainValidationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcmeEndpointStatus.
    /// </summary>
    public class AcmeEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AcmeEndpointStatus
        /// </summary>
        public static readonly AcmeEndpointStatus ACTIVE = new AcmeEndpointStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for AcmeEndpointStatus
        /// </summary>
        public static readonly AcmeEndpointStatus CREATING = new AcmeEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AcmeEndpointStatus
        /// </summary>
        public static readonly AcmeEndpointStatus DELETING = new AcmeEndpointStatus("DELETING");
        /// <summary>
        /// Constant FAILED for AcmeEndpointStatus
        /// </summary>
        public static readonly AcmeEndpointStatus FAILED = new AcmeEndpointStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcmeEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcmeEndpointStatus FindValue(string value)
        {
            return FindValue<AcmeEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcmeEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateExport.
    /// </summary>
    public class CertificateExport : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CertificateExport
        /// </summary>
        public static readonly CertificateExport DISABLED = new CertificateExport("DISABLED");
        /// <summary>
        /// Constant ENABLED for CertificateExport
        /// </summary>
        public static readonly CertificateExport ENABLED = new CertificateExport("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateExport(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateExport FindValue(string value)
        {
            return FindValue<CertificateExport>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateExport(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateKeyPairOrigin.
    /// </summary>
    public class CertificateKeyPairOrigin : ConstantClass
    {

        /// <summary>
        /// Constant ACME for CertificateKeyPairOrigin
        /// </summary>
        public static readonly CertificateKeyPairOrigin ACME = new CertificateKeyPairOrigin("ACME");
        /// <summary>
        /// Constant AWS_MANAGED for CertificateKeyPairOrigin
        /// </summary>
        public static readonly CertificateKeyPairOrigin AWS_MANAGED = new CertificateKeyPairOrigin("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_PROVIDED for CertificateKeyPairOrigin
        /// </summary>
        public static readonly CertificateKeyPairOrigin CUSTOMER_PROVIDED = new CertificateKeyPairOrigin("CUSTOMER_PROVIDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateKeyPairOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateKeyPairOrigin FindValue(string value)
        {
            return FindValue<CertificateKeyPairOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateKeyPairOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateManagedBy.
    /// </summary>
    public class CertificateManagedBy : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFRONT for CertificateManagedBy
        /// </summary>
        public static readonly CertificateManagedBy CLOUDFRONT = new CertificateManagedBy("CLOUDFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateManagedBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateManagedBy FindValue(string value)
        {
            return FindValue<CertificateManagedBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateManagedBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateStatus.
    /// </summary>
    public class CertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXPIRED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus EXPIRED = new CertificateStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus FAILED = new CertificateStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus INACTIVE = new CertificateStatus("INACTIVE");
        /// <summary>
        /// Constant ISSUED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus ISSUED = new CertificateStatus("ISSUED");
        /// <summary>
        /// Constant PENDING_VALIDATION for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_VALIDATION = new CertificateStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant REVOKED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REVOKED = new CertificateStatus("REVOKED");
        /// <summary>
        /// Constant VALIDATION_TIMED_OUT for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus VALIDATION_TIMED_OUT = new CertificateStatus("VALIDATION_TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateStatus FindValue(string value)
        {
            return FindValue<CertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateTransparencyLoggingPreference.
    /// </summary>
    public class CertificateTransparencyLoggingPreference : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CertificateTransparencyLoggingPreference
        /// </summary>
        public static readonly CertificateTransparencyLoggingPreference DISABLED = new CertificateTransparencyLoggingPreference("DISABLED");
        /// <summary>
        /// Constant ENABLED for CertificateTransparencyLoggingPreference
        /// </summary>
        public static readonly CertificateTransparencyLoggingPreference ENABLED = new CertificateTransparencyLoggingPreference("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateTransparencyLoggingPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateTransparencyLoggingPreference FindValue(string value)
        {
            return FindValue<CertificateTransparencyLoggingPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateTransparencyLoggingPreference(string value)
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
        /// Constant AMAZON_ISSUED for CertificateType
        /// </summary>
        public static readonly CertificateType AMAZON_ISSUED = new CertificateType("AMAZON_ISSUED");
        /// <summary>
        /// Constant IMPORTED for CertificateType
        /// </summary>
        public static readonly CertificateType IMPORTED = new CertificateType("IMPORTED");
        /// <summary>
        /// Constant PRIVATE for CertificateType
        /// </summary>
        public static readonly CertificateType PRIVATE = new CertificateType("PRIVATE");

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
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator CONTAINS = new ComparisonOperator("CONTAINS");
        /// <summary>
        /// Constant EQUALS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUALS = new ComparisonOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainScopeOption.
    /// </summary>
    public class DomainScopeOption : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DomainScopeOption
        /// </summary>
        public static readonly DomainScopeOption DISABLED = new DomainScopeOption("DISABLED");
        /// <summary>
        /// Constant ENABLED for DomainScopeOption
        /// </summary>
        public static readonly DomainScopeOption ENABLED = new DomainScopeOption("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainScopeOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainScopeOption FindValue(string value)
        {
            return FindValue<DomainScopeOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainScopeOption(string value)
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
        /// Constant FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus FAILED = new DomainStatus("FAILED");
        /// <summary>
        /// Constant PENDING_VALIDATION for DomainStatus
        /// </summary>
        public static readonly DomainStatus PENDING_VALIDATION = new DomainStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for DomainStatus
        /// </summary>
        public static readonly DomainStatus SUCCESS = new DomainStatus("SUCCESS");

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
    /// Constants used for properties of type ExtendedKeyUsageName.
    /// </summary>
    public class ExtendedKeyUsageName : ConstantClass
    {

        /// <summary>
        /// Constant ANY for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName ANY = new ExtendedKeyUsageName("ANY");
        /// <summary>
        /// Constant CODE_SIGNING for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName CODE_SIGNING = new ExtendedKeyUsageName("CODE_SIGNING");
        /// <summary>
        /// Constant CUSTOM for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName CUSTOM = new ExtendedKeyUsageName("CUSTOM");
        /// <summary>
        /// Constant EMAIL_PROTECTION for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName EMAIL_PROTECTION = new ExtendedKeyUsageName("EMAIL_PROTECTION");
        /// <summary>
        /// Constant IPSEC_END_SYSTEM for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName IPSEC_END_SYSTEM = new ExtendedKeyUsageName("IPSEC_END_SYSTEM");
        /// <summary>
        /// Constant IPSEC_TUNNEL for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName IPSEC_TUNNEL = new ExtendedKeyUsageName("IPSEC_TUNNEL");
        /// <summary>
        /// Constant IPSEC_USER for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName IPSEC_USER = new ExtendedKeyUsageName("IPSEC_USER");
        /// <summary>
        /// Constant NONE for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName NONE = new ExtendedKeyUsageName("NONE");
        /// <summary>
        /// Constant OCSP_SIGNING for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName OCSP_SIGNING = new ExtendedKeyUsageName("OCSP_SIGNING");
        /// <summary>
        /// Constant TIME_STAMPING for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName TIME_STAMPING = new ExtendedKeyUsageName("TIME_STAMPING");
        /// <summary>
        /// Constant TLS_WEB_CLIENT_AUTHENTICATION for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName TLS_WEB_CLIENT_AUTHENTICATION = new ExtendedKeyUsageName("TLS_WEB_CLIENT_AUTHENTICATION");
        /// <summary>
        /// Constant TLS_WEB_SERVER_AUTHENTICATION for ExtendedKeyUsageName
        /// </summary>
        public static readonly ExtendedKeyUsageName TLS_WEB_SERVER_AUTHENTICATION = new ExtendedKeyUsageName("TLS_WEB_SERVER_AUTHENTICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExtendedKeyUsageName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtendedKeyUsageName FindValue(string value)
        {
            return FindValue<ExtendedKeyUsageName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtendedKeyUsageName(string value)
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
        /// Constant ADDITIONAL_VERIFICATION_REQUIRED for FailureReason
        /// </summary>
        public static readonly FailureReason ADDITIONAL_VERIFICATION_REQUIRED = new FailureReason("ADDITIONAL_VERIFICATION_REQUIRED");
        /// <summary>
        /// Constant CAA_ERROR for FailureReason
        /// </summary>
        public static readonly FailureReason CAA_ERROR = new FailureReason("CAA_ERROR");
        /// <summary>
        /// Constant DOMAIN_NOT_ALLOWED for FailureReason
        /// </summary>
        public static readonly FailureReason DOMAIN_NOT_ALLOWED = new FailureReason("DOMAIN_NOT_ALLOWED");
        /// <summary>
        /// Constant DOMAIN_VALIDATION_DENIED for FailureReason
        /// </summary>
        public static readonly FailureReason DOMAIN_VALIDATION_DENIED = new FailureReason("DOMAIN_VALIDATION_DENIED");
        /// <summary>
        /// Constant INVALID_PUBLIC_DOMAIN for FailureReason
        /// </summary>
        public static readonly FailureReason INVALID_PUBLIC_DOMAIN = new FailureReason("INVALID_PUBLIC_DOMAIN");
        /// <summary>
        /// Constant NO_AVAILABLE_CONTACTS for FailureReason
        /// </summary>
        public static readonly FailureReason NO_AVAILABLE_CONTACTS = new FailureReason("NO_AVAILABLE_CONTACTS");
        /// <summary>
        /// Constant OTHER for FailureReason
        /// </summary>
        public static readonly FailureReason OTHER = new FailureReason("OTHER");
        /// <summary>
        /// Constant PCA_ACCESS_DENIED for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_ACCESS_DENIED = new FailureReason("PCA_ACCESS_DENIED");
        /// <summary>
        /// Constant PCA_INVALID_ARGS for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_INVALID_ARGS = new FailureReason("PCA_INVALID_ARGS");
        /// <summary>
        /// Constant PCA_INVALID_ARN for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_INVALID_ARN = new FailureReason("PCA_INVALID_ARN");
        /// <summary>
        /// Constant PCA_INVALID_DURATION for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_INVALID_DURATION = new FailureReason("PCA_INVALID_DURATION");
        /// <summary>
        /// Constant PCA_INVALID_STATE for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_INVALID_STATE = new FailureReason("PCA_INVALID_STATE");
        /// <summary>
        /// Constant PCA_LIMIT_EXCEEDED for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_LIMIT_EXCEEDED = new FailureReason("PCA_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant PCA_NAME_CONSTRAINTS_VALIDATION for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_NAME_CONSTRAINTS_VALIDATION = new FailureReason("PCA_NAME_CONSTRAINTS_VALIDATION");
        /// <summary>
        /// Constant PCA_REQUEST_FAILED for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_REQUEST_FAILED = new FailureReason("PCA_REQUEST_FAILED");
        /// <summary>
        /// Constant PCA_RESOURCE_NOT_FOUND for FailureReason
        /// </summary>
        public static readonly FailureReason PCA_RESOURCE_NOT_FOUND = new FailureReason("PCA_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SLR_NOT_FOUND for FailureReason
        /// </summary>
        public static readonly FailureReason SLR_NOT_FOUND = new FailureReason("SLR_NOT_FOUND");

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
        /// Constant RSA_1024 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_1024 = new KeyAlgorithm("RSA_1024");
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
    /// Constants used for properties of type KeyUsageName.
    /// </summary>
    public class KeyUsageName : ConstantClass
    {

        /// <summary>
        /// Constant ANY for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName ANY = new KeyUsageName("ANY");
        /// <summary>
        /// Constant CERTIFICATE_SIGNING for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName CERTIFICATE_SIGNING = new KeyUsageName("CERTIFICATE_SIGNING");
        /// <summary>
        /// Constant CRL_SIGNING for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName CRL_SIGNING = new KeyUsageName("CRL_SIGNING");
        /// <summary>
        /// Constant CUSTOM for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName CUSTOM = new KeyUsageName("CUSTOM");
        /// <summary>
        /// Constant DATA_ENCIPHERMENT for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName DATA_ENCIPHERMENT = new KeyUsageName("DATA_ENCIPHERMENT");
        /// <summary>
        /// Constant DECIPHER_ONLY for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName DECIPHER_ONLY = new KeyUsageName("DECIPHER_ONLY");
        /// <summary>
        /// Constant DIGITAL_SIGNATURE for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName DIGITAL_SIGNATURE = new KeyUsageName("DIGITAL_SIGNATURE");
        /// <summary>
        /// Constant ENCIPHER_ONLY for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName ENCIPHER_ONLY = new KeyUsageName("ENCIPHER_ONLY");
        /// <summary>
        /// Constant KEY_AGREEMENT for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName KEY_AGREEMENT = new KeyUsageName("KEY_AGREEMENT");
        /// <summary>
        /// Constant KEY_ENCIPHERMENT for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName KEY_ENCIPHERMENT = new KeyUsageName("KEY_ENCIPHERMENT");
        /// <summary>
        /// Constant NON_REPUDIATION for KeyUsageName
        /// </summary>
        public static readonly KeyUsageName NON_REPUDIATION = new KeyUsageName("NON_REPUDIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyUsageName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyUsageName FindValue(string value)
        {
            return FindValue<KeyUsageName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyUsageName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrevalidationType.
    /// </summary>
    public class PrevalidationType : ConstantClass
    {

        /// <summary>
        /// Constant DNS_PREVALIDATION for PrevalidationType
        /// </summary>
        public static readonly PrevalidationType DNS_PREVALIDATION = new PrevalidationType("DNS_PREVALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrevalidationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrevalidationType FindValue(string value)
        {
            return FindValue<PrevalidationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrevalidationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublicKeyAlgorithm.
    /// </summary>
    public class PublicKeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant EC_prime256v1 for PublicKeyAlgorithm
        /// </summary>
        public static readonly PublicKeyAlgorithm EC_prime256v1 = new PublicKeyAlgorithm("EC_prime256v1");
        /// <summary>
        /// Constant EC_secp384r1 for PublicKeyAlgorithm
        /// </summary>
        public static readonly PublicKeyAlgorithm EC_secp384r1 = new PublicKeyAlgorithm("EC_secp384r1");
        /// <summary>
        /// Constant RSA_2048 for PublicKeyAlgorithm
        /// </summary>
        public static readonly PublicKeyAlgorithm RSA_2048 = new PublicKeyAlgorithm("RSA_2048");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublicKeyAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublicKeyAlgorithm FindValue(string value)
        {
            return FindValue<PublicKeyAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublicKeyAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordType.
    /// </summary>
    public class RecordType : ConstantClass
    {

        /// <summary>
        /// Constant CNAME for RecordType
        /// </summary>
        public static readonly RecordType CNAME = new RecordType("CNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordType FindValue(string value)
        {
            return FindValue<RecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenewalEligibility.
    /// </summary>
    public class RenewalEligibility : ConstantClass
    {

        /// <summary>
        /// Constant ELIGIBLE for RenewalEligibility
        /// </summary>
        public static readonly RenewalEligibility ELIGIBLE = new RenewalEligibility("ELIGIBLE");
        /// <summary>
        /// Constant INELIGIBLE for RenewalEligibility
        /// </summary>
        public static readonly RenewalEligibility INELIGIBLE = new RenewalEligibility("INELIGIBLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenewalEligibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenewalEligibility FindValue(string value)
        {
            return FindValue<RenewalEligibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenewalEligibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenewalStatus.
    /// </summary>
    public class RenewalStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus FAILED = new RenewalStatus("FAILED");
        /// <summary>
        /// Constant PENDING_AUTO_RENEWAL for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus PENDING_AUTO_RENEWAL = new RenewalStatus("PENDING_AUTO_RENEWAL");
        /// <summary>
        /// Constant PENDING_VALIDATION for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus PENDING_VALIDATION = new RenewalStatus("PENDING_VALIDATION");
        /// <summary>
        /// Constant SUCCESS for RenewalStatus
        /// </summary>
        public static readonly RenewalStatus SUCCESS = new RenewalStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenewalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenewalStatus FindValue(string value)
        {
            return FindValue<RenewalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenewalStatus(string value)
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
        /// Constant CA_COMPROMISE for RevocationReason
        /// </summary>
        public static readonly RevocationReason CA_COMPROMISE = new RevocationReason("CA_COMPROMISE");
        /// <summary>
        /// Constant CERTIFICATE_HOLD for RevocationReason
        /// </summary>
        public static readonly RevocationReason CERTIFICATE_HOLD = new RevocationReason("CERTIFICATE_HOLD");
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
        /// Constant REMOVE_FROM_CRL for RevocationReason
        /// </summary>
        public static readonly RevocationReason REMOVE_FROM_CRL = new RevocationReason("REMOVE_FROM_CRL");
        /// <summary>
        /// Constant SUPERCEDED for RevocationReason
        /// </summary>
        public static readonly RevocationReason SUPERCEDED = new RevocationReason("SUPERCEDED");
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
    /// Constants used for properties of type SearchCertificatesSortBy.
    /// </summary>
    public class SearchCertificatesSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ACME_ACCOUNT_ID for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy ACME_ACCOUNT_ID = new SearchCertificatesSortBy("ACME_ACCOUNT_ID");
        /// <summary>
        /// Constant ACME_ENDPOINT_ARN for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy ACME_ENDPOINT_ARN = new SearchCertificatesSortBy("ACME_ENDPOINT_ARN");
        /// <summary>
        /// Constant CERTIFICATE_ARN for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy CERTIFICATE_ARN = new SearchCertificatesSortBy("CERTIFICATE_ARN");
        /// <summary>
        /// Constant CERTIFICATE_KEY_PAIR_ORIGIN for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy CERTIFICATE_KEY_PAIR_ORIGIN = new SearchCertificatesSortBy("CERTIFICATE_KEY_PAIR_ORIGIN");
        /// <summary>
        /// Constant COMMON_NAME for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy COMMON_NAME = new SearchCertificatesSortBy("COMMON_NAME");
        /// <summary>
        /// Constant CREATED_AT for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy CREATED_AT = new SearchCertificatesSortBy("CREATED_AT");
        /// <summary>
        /// Constant EXPORT_OPTION for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy EXPORT_OPTION = new SearchCertificatesSortBy("EXPORT_OPTION");
        /// <summary>
        /// Constant EXPORTED for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy EXPORTED = new SearchCertificatesSortBy("EXPORTED");
        /// <summary>
        /// Constant IMPORTED_AT for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy IMPORTED_AT = new SearchCertificatesSortBy("IMPORTED_AT");
        /// <summary>
        /// Constant IN_USE for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy IN_USE = new SearchCertificatesSortBy("IN_USE");
        /// <summary>
        /// Constant ISSUED_AT for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy ISSUED_AT = new SearchCertificatesSortBy("ISSUED_AT");
        /// <summary>
        /// Constant KEY_ALGORITHM for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy KEY_ALGORITHM = new SearchCertificatesSortBy("KEY_ALGORITHM");
        /// <summary>
        /// Constant MANAGED_BY for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy MANAGED_BY = new SearchCertificatesSortBy("MANAGED_BY");
        /// <summary>
        /// Constant NOT_AFTER for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy NOT_AFTER = new SearchCertificatesSortBy("NOT_AFTER");
        /// <summary>
        /// Constant NOT_BEFORE for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy NOT_BEFORE = new SearchCertificatesSortBy("NOT_BEFORE");
        /// <summary>
        /// Constant RENEWAL_ELIGIBILITY for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy RENEWAL_ELIGIBILITY = new SearchCertificatesSortBy("RENEWAL_ELIGIBILITY");
        /// <summary>
        /// Constant RENEWAL_STATUS for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy RENEWAL_STATUS = new SearchCertificatesSortBy("RENEWAL_STATUS");
        /// <summary>
        /// Constant REVOKED_AT for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy REVOKED_AT = new SearchCertificatesSortBy("REVOKED_AT");
        /// <summary>
        /// Constant STATUS for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy STATUS = new SearchCertificatesSortBy("STATUS");
        /// <summary>
        /// Constant TYPE for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy TYPE = new SearchCertificatesSortBy("TYPE");
        /// <summary>
        /// Constant VALIDATION_METHOD for SearchCertificatesSortBy
        /// </summary>
        public static readonly SearchCertificatesSortBy VALIDATION_METHOD = new SearchCertificatesSortBy("VALIDATION_METHOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchCertificatesSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchCertificatesSortBy FindValue(string value)
        {
            return FindValue<SearchCertificatesSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchCertificatesSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchCertificatesSortOrder.
    /// </summary>
    public class SearchCertificatesSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SearchCertificatesSortOrder
        /// </summary>
        public static readonly SearchCertificatesSortOrder ASCENDING = new SearchCertificatesSortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SearchCertificatesSortOrder
        /// </summary>
        public static readonly SearchCertificatesSortOrder DESCENDING = new SearchCertificatesSortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchCertificatesSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchCertificatesSortOrder FindValue(string value)
        {
            return FindValue<SearchCertificatesSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchCertificatesSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_AT for SortBy
        /// </summary>
        public static readonly SortBy CREATED_AT = new SortBy("CREATED_AT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortBy FindValue(string value)
        {
            return FindValue<SortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeType.
    /// </summary>
    public class TimeType : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for TimeType
        /// </summary>
        public static readonly TimeType DAYS = new TimeType("DAYS");
        /// <summary>
        /// Constant HOURS for TimeType
        /// </summary>
        public static readonly TimeType HOURS = new TimeType("HOURS");
        /// <summary>
        /// Constant MINUTES for TimeType
        /// </summary>
        public static readonly TimeType MINUTES = new TimeType("MINUTES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeType FindValue(string value)
        {
            return FindValue<TimeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationMethod.
    /// </summary>
    public class ValidationMethod : ConstantClass
    {

        /// <summary>
        /// Constant DNS for ValidationMethod
        /// </summary>
        public static readonly ValidationMethod DNS = new ValidationMethod("DNS");
        /// <summary>
        /// Constant EMAIL for ValidationMethod
        /// </summary>
        public static readonly ValidationMethod EMAIL = new ValidationMethod("EMAIL");
        /// <summary>
        /// Constant HTTP for ValidationMethod
        /// </summary>
        public static readonly ValidationMethod HTTP = new ValidationMethod("HTTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationMethod FindValue(string value)
        {
            return FindValue<ValidationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationMethod(string value)
        {
            return FindValue(value);
        }
    }

}
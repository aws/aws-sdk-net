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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CertificateManager
{

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
    /// Constants used for properties of type KeyAlgorithm.
    /// </summary>
    public class KeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant EC_prime256v1 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm EC_prime256v1 = new KeyAlgorithm("EC_prime256v1");
        /// <summary>
        /// Constant RSA_2048 for KeyAlgorithm
        /// </summary>
        public static readonly KeyAlgorithm RSA_2048 = new KeyAlgorithm("RSA_2048");

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

}
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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IAMRolesAnywhere
{

    /// <summary>
    /// Constants used for properties of type CertificateField.
    /// </summary>
    public class CertificateField : ConstantClass
    {

        /// <summary>
        /// Constant X509Issuer for CertificateField
        /// </summary>
        public static readonly CertificateField X509Issuer = new CertificateField("x509Issuer");
        /// <summary>
        /// Constant X509SAN for CertificateField
        /// </summary>
        public static readonly CertificateField X509SAN = new CertificateField("x509SAN");
        /// <summary>
        /// Constant X509Subject for CertificateField
        /// </summary>
        public static readonly CertificateField X509Subject = new CertificateField("x509Subject");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateField FindValue(string value)
        {
            return FindValue<CertificateField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationChannel.
    /// </summary>
    public class NotificationChannel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for NotificationChannel
        /// </summary>
        public static readonly NotificationChannel ALL = new NotificationChannel("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationChannel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationChannel FindValue(string value)
        {
            return FindValue<NotificationChannel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationChannel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationEvent.
    /// </summary>
    public class NotificationEvent : ConstantClass
    {

        /// <summary>
        /// Constant CA_CERTIFICATE_EXPIRY for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent CA_CERTIFICATE_EXPIRY = new NotificationEvent("CA_CERTIFICATE_EXPIRY");
        /// <summary>
        /// Constant END_ENTITY_CERTIFICATE_EXPIRY for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent END_ENTITY_CERTIFICATE_EXPIRY = new NotificationEvent("END_ENTITY_CERTIFICATE_EXPIRY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationEvent FindValue(string value)
        {
            return FindValue<NotificationEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustAnchorType.
    /// </summary>
    public class TrustAnchorType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACM_PCA for TrustAnchorType
        /// </summary>
        public static readonly TrustAnchorType AWS_ACM_PCA = new TrustAnchorType("AWS_ACM_PCA");
        /// <summary>
        /// Constant CERTIFICATE_BUNDLE for TrustAnchorType
        /// </summary>
        public static readonly TrustAnchorType CERTIFICATE_BUNDLE = new TrustAnchorType("CERTIFICATE_BUNDLE");
        /// <summary>
        /// Constant SELF_SIGNED_REPOSITORY for TrustAnchorType
        /// </summary>
        public static readonly TrustAnchorType SELF_SIGNED_REPOSITORY = new TrustAnchorType("SELF_SIGNED_REPOSITORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustAnchorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustAnchorType FindValue(string value)
        {
            return FindValue<TrustAnchorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustAnchorType(string value)
        {
            return FindValue(value);
        }
    }

}
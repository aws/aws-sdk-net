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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.ELBProxy
{
    /// <summary>
    /// Constants used for properties of type CertificateAssociationStatusCode.
    /// </summary>
    public class CertificateAssociationStatusCode : ConstantClass
    {
        /// <summary>
        /// Constant Active for CertificateAssociationStatusCode
        /// </summary>
        public static readonly CertificateAssociationStatusCode Active = new CertificateAssociationStatusCode("active");

        /// <summary>
        /// Constant AssociateFailed for CertificateAssociationStatusCode
        /// </summary>
        public static readonly CertificateAssociationStatusCode AssociateFailed = new CertificateAssociationStatusCode("associate-failed");

        /// <summary>
        /// Constant AssociateInProgress for CertificateAssociationStatusCode
        /// </summary>
        public static readonly CertificateAssociationStatusCode AssociateInProgress = new CertificateAssociationStatusCode("associate-in-progress");

        /// <summary>
        /// Constant DisassociateInProgress for CertificateAssociationStatusCode
        /// </summary>
        public static readonly CertificateAssociationStatusCode DisassociateInProgress = new CertificateAssociationStatusCode("disassociate-in-progress");

        /// <summary>
        /// Constant Disassociated for CertificateAssociationStatusCode
        /// </summary>
        public static readonly CertificateAssociationStatusCode Disassociated = new CertificateAssociationStatusCode("disassociated");

        /// <summary>
        /// Constructs a custom CertificateAssociationStatusCode for a value not among the defined constants.
        /// </summary>
        public CertificateAssociationStatusCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateAssociationStatusCode FindValue(string value)
        {
            return FindValue<CertificateAssociationStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateAssociationStatusCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyIpv4Addressability.
    /// </summary>
    public class ProxyIpv4Addressability : ConstantClass
    {
        /// <summary>
        /// Constant Internal for ProxyIpv4Addressability
        /// </summary>
        public static readonly ProxyIpv4Addressability Internal = new ProxyIpv4Addressability("internal");

        /// <summary>
        /// Constant InternetFacing for ProxyIpv4Addressability
        /// </summary>
        public static readonly ProxyIpv4Addressability InternetFacing = new ProxyIpv4Addressability("internet-facing");

        /// <summary>
        /// Constant Off for ProxyIpv4Addressability
        /// </summary>
        public static readonly ProxyIpv4Addressability Off = new ProxyIpv4Addressability("off");

        /// <summary>
        /// Constructs a custom ProxyIpv4Addressability for a value not among the defined constants.
        /// </summary>
        public ProxyIpv4Addressability(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyIpv4Addressability FindValue(string value)
        {
            return FindValue<ProxyIpv4Addressability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyIpv4Addressability(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyIpv6Addressability.
    /// </summary>
    public class ProxyIpv6Addressability : ConstantClass
    {
        /// <summary>
        /// Constant Internal for ProxyIpv6Addressability
        /// </summary>
        public static readonly ProxyIpv6Addressability Internal = new ProxyIpv6Addressability("internal");

        /// <summary>
        /// Constant InternetFacing for ProxyIpv6Addressability
        /// </summary>
        public static readonly ProxyIpv6Addressability InternetFacing = new ProxyIpv6Addressability("internet-facing");

        /// <summary>
        /// Constant Off for ProxyIpv6Addressability
        /// </summary>
        public static readonly ProxyIpv6Addressability Off = new ProxyIpv6Addressability("off");

        /// <summary>
        /// Constructs a custom ProxyIpv6Addressability for a value not among the defined constants.
        /// </summary>
        public ProxyIpv6Addressability(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyIpv6Addressability FindValue(string value)
        {
            return FindValue<ProxyIpv6Addressability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyIpv6Addressability(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyStatusCode.
    /// </summary>
    public class ProxyStatusCode : ConstantClass
    {
        /// <summary>
        /// Constant ActionRequired for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode ActionRequired = new ProxyStatusCode("action-required");

        /// <summary>
        /// Constant Active for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode Active = new ProxyStatusCode("active");

        /// <summary>
        /// Constant CancelUpdateInProgress for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode CancelUpdateInProgress = new ProxyStatusCode("cancel-update-in-progress");

        /// <summary>
        /// Constant CreateFailed for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode CreateFailed = new ProxyStatusCode("create-failed");

        /// <summary>
        /// Constant CreateInProgress for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode CreateInProgress = new ProxyStatusCode("create-in-progress");

        /// <summary>
        /// Constant DeleteInProgress for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode DeleteInProgress = new ProxyStatusCode("delete-in-progress");

        /// <summary>
        /// Constant Deleted for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode Deleted = new ProxyStatusCode("deleted");

        /// <summary>
        /// Constant UpdateInProgress for ProxyStatusCode
        /// </summary>
        public static readonly ProxyStatusCode UpdateInProgress = new ProxyStatusCode("update-in-progress");

        /// <summary>
        /// Constructs a custom ProxyStatusCode for a value not among the defined constants.
        /// </summary>
        public ProxyStatusCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyStatusCode FindValue(string value)
        {
            return FindValue<ProxyStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyStatusCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyType.
    /// </summary>
    public class ProxyType : ConstantClass
    {
        /// <summary>
        /// Constant Envoy for ProxyType
        /// </summary>
        public static readonly ProxyType Envoy = new ProxyType("envoy");

        /// <summary>
        /// Constructs a custom ProxyType for a value not among the defined constants.
        /// </summary>
        public ProxyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyType FindValue(string value)
        {
            return FindValue<ProxyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyUpdatePropagationStatus.
    /// </summary>
    public class ProxyUpdatePropagationStatus : ConstantClass
    {
        /// <summary>
        /// Constant Cancelled for ProxyUpdatePropagationStatus
        /// </summary>
        public static readonly ProxyUpdatePropagationStatus Cancelled = new ProxyUpdatePropagationStatus("cancelled");

        /// <summary>
        /// Constant Complete for ProxyUpdatePropagationStatus
        /// </summary>
        public static readonly ProxyUpdatePropagationStatus Complete = new ProxyUpdatePropagationStatus("complete");

        /// <summary>
        /// Constant Failed for ProxyUpdatePropagationStatus
        /// </summary>
        public static readonly ProxyUpdatePropagationStatus Failed = new ProxyUpdatePropagationStatus("failed");

        /// <summary>
        /// Constant InProgress for ProxyUpdatePropagationStatus
        /// </summary>
        public static readonly ProxyUpdatePropagationStatus InProgress = new ProxyUpdatePropagationStatus("in-progress");

        /// <summary>
        /// Constant Skipped for ProxyUpdatePropagationStatus
        /// </summary>
        public static readonly ProxyUpdatePropagationStatus Skipped = new ProxyUpdatePropagationStatus("skipped");

        /// <summary>
        /// Constructs a custom ProxyUpdatePropagationStatus for a value not among the defined constants.
        /// </summary>
        public ProxyUpdatePropagationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyUpdatePropagationStatus FindValue(string value)
        {
            return FindValue<ProxyUpdatePropagationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyUpdatePropagationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyUpdateType.
    /// </summary>
    public class ProxyUpdateType : ConstantClass
    {
        /// <summary>
        /// Constant UpdateProxyConfiguration for ProxyUpdateType
        /// </summary>
        public static readonly ProxyUpdateType UpdateProxyConfiguration = new ProxyUpdateType("update-proxy-configuration");

        /// <summary>
        /// Constructs a custom ProxyUpdateType for a value not among the defined constants.
        /// </summary>
        public ProxyUpdateType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyUpdateType FindValue(string value)
        {
            return FindValue<ProxyUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyUpdateType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyUpdateValidationStatus.
    /// </summary>
    public class ProxyUpdateValidationStatus : ConstantClass
    {
        /// <summary>
        /// Constant Invalid for ProxyUpdateValidationStatus
        /// </summary>
        public static readonly ProxyUpdateValidationStatus Invalid = new ProxyUpdateValidationStatus("invalid");

        /// <summary>
        /// Constant NotValidated for ProxyUpdateValidationStatus
        /// </summary>
        public static readonly ProxyUpdateValidationStatus NotValidated = new ProxyUpdateValidationStatus("not-validated");

        /// <summary>
        /// Constant Valid for ProxyUpdateValidationStatus
        /// </summary>
        public static readonly ProxyUpdateValidationStatus Valid = new ProxyUpdateValidationStatus("valid");

        /// <summary>
        /// Constructs a custom ProxyUpdateValidationStatus for a value not among the defined constants.
        /// </summary>
        public ProxyUpdateValidationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyUpdateValidationStatus FindValue(string value)
        {
            return FindValue<ProxyUpdateValidationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyUpdateValidationStatus(string value)
        {
            return FindValue(value);
        }
    }
}

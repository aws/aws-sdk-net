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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PcaConnectorAd
{

    /// <summary>
    /// Constants used for properties of type AccessRight.
    /// </summary>
    public class AccessRight : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AccessRight
        /// </summary>
        public static readonly AccessRight ALLOW = new AccessRight("ALLOW");
        /// <summary>
        /// Constant DENY for AccessRight
        /// </summary>
        public static readonly AccessRight DENY = new AccessRight("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessRight(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessRight FindValue(string value)
        {
            return FindValue<AccessRight>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessRight(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationPolicyType.
    /// </summary>
    public class ApplicationPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_APPLICATION_POLICIES for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ALL_APPLICATION_POLICIES = new ApplicationPolicyType("ALL_APPLICATION_POLICIES");
        /// <summary>
        /// Constant ANY_PURPOSE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ANY_PURPOSE = new ApplicationPolicyType("ANY_PURPOSE");
        /// <summary>
        /// Constant ATTESTATION_IDENTITY_KEY_CERTIFICATE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ATTESTATION_IDENTITY_KEY_CERTIFICATE = new ApplicationPolicyType("ATTESTATION_IDENTITY_KEY_CERTIFICATE");
        /// <summary>
        /// Constant CERTIFICATE_REQUEST_AGENT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType CERTIFICATE_REQUEST_AGENT = new ApplicationPolicyType("CERTIFICATE_REQUEST_AGENT");
        /// <summary>
        /// Constant CLIENT_AUTHENTICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType CLIENT_AUTHENTICATION = new ApplicationPolicyType("CLIENT_AUTHENTICATION");
        /// <summary>
        /// Constant CODE_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType CODE_SIGNING = new ApplicationPolicyType("CODE_SIGNING");
        /// <summary>
        /// Constant CTL_USAGE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType CTL_USAGE = new ApplicationPolicyType("CTL_USAGE");
        /// <summary>
        /// Constant DIGITAL_RIGHTS for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DIGITAL_RIGHTS = new ApplicationPolicyType("DIGITAL_RIGHTS");
        /// <summary>
        /// Constant DIRECTORY_SERVICE_EMAIL_REPLICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DIRECTORY_SERVICE_EMAIL_REPLICATION = new ApplicationPolicyType("DIRECTORY_SERVICE_EMAIL_REPLICATION");
        /// <summary>
        /// Constant DISALLOWED_LIST for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DISALLOWED_LIST = new ApplicationPolicyType("DISALLOWED_LIST");
        /// <summary>
        /// Constant DNS_SERVER_TRUST for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DNS_SERVER_TRUST = new ApplicationPolicyType("DNS_SERVER_TRUST");
        /// <summary>
        /// Constant DOCUMENT_ENCRYPTION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DOCUMENT_ENCRYPTION = new ApplicationPolicyType("DOCUMENT_ENCRYPTION");
        /// <summary>
        /// Constant DOCUMENT_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DOCUMENT_SIGNING = new ApplicationPolicyType("DOCUMENT_SIGNING");
        /// <summary>
        /// Constant DYNAMIC_CODE_GENERATOR for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType DYNAMIC_CODE_GENERATOR = new ApplicationPolicyType("DYNAMIC_CODE_GENERATOR");
        /// <summary>
        /// Constant EARLY_LAUNCH_ANTIMALWARE_DRIVER for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType EARLY_LAUNCH_ANTIMALWARE_DRIVER = new ApplicationPolicyType("EARLY_LAUNCH_ANTIMALWARE_DRIVER");
        /// <summary>
        /// Constant EMBEDDED_WINDOWS_SYSTEM_COMPONENT_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType EMBEDDED_WINDOWS_SYSTEM_COMPONENT_VERIFICATION = new ApplicationPolicyType("EMBEDDED_WINDOWS_SYSTEM_COMPONENT_VERIFICATION");
        /// <summary>
        /// Constant ENCLAVE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ENCLAVE = new ApplicationPolicyType("ENCLAVE");
        /// <summary>
        /// Constant ENCRYPTING_FILE_SYSTEM for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ENCRYPTING_FILE_SYSTEM = new ApplicationPolicyType("ENCRYPTING_FILE_SYSTEM");
        /// <summary>
        /// Constant ENDORSEMENT_KEY_CERTIFICATE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ENDORSEMENT_KEY_CERTIFICATE = new ApplicationPolicyType("ENDORSEMENT_KEY_CERTIFICATE");
        /// <summary>
        /// Constant FILE_RECOVERY for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType FILE_RECOVERY = new ApplicationPolicyType("FILE_RECOVERY");
        /// <summary>
        /// Constant HAL_EXTENSION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType HAL_EXTENSION = new ApplicationPolicyType("HAL_EXTENSION");
        /// <summary>
        /// Constant IP_SECURITY_END_SYSTEM for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType IP_SECURITY_END_SYSTEM = new ApplicationPolicyType("IP_SECURITY_END_SYSTEM");
        /// <summary>
        /// Constant IP_SECURITY_IKE_INTERMEDIATE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType IP_SECURITY_IKE_INTERMEDIATE = new ApplicationPolicyType("IP_SECURITY_IKE_INTERMEDIATE");
        /// <summary>
        /// Constant IP_SECURITY_TUNNEL_TERMINATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType IP_SECURITY_TUNNEL_TERMINATION = new ApplicationPolicyType("IP_SECURITY_TUNNEL_TERMINATION");
        /// <summary>
        /// Constant IP_SECURITY_USER for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType IP_SECURITY_USER = new ApplicationPolicyType("IP_SECURITY_USER");
        /// <summary>
        /// Constant ISOLATED_USER_MODE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ISOLATED_USER_MODE = new ApplicationPolicyType("ISOLATED_USER_MODE");
        /// <summary>
        /// Constant KDC_AUTHENTICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType KDC_AUTHENTICATION = new ApplicationPolicyType("KDC_AUTHENTICATION");
        /// <summary>
        /// Constant KERNEL_MODE_CODE_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType KERNEL_MODE_CODE_SIGNING = new ApplicationPolicyType("KERNEL_MODE_CODE_SIGNING");
        /// <summary>
        /// Constant KEY_PACK_LICENSES for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType KEY_PACK_LICENSES = new ApplicationPolicyType("KEY_PACK_LICENSES");
        /// <summary>
        /// Constant KEY_RECOVERY for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType KEY_RECOVERY = new ApplicationPolicyType("KEY_RECOVERY");
        /// <summary>
        /// Constant KEY_RECOVERY_AGENT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType KEY_RECOVERY_AGENT = new ApplicationPolicyType("KEY_RECOVERY_AGENT");
        /// <summary>
        /// Constant LICENSE_SERVER_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType LICENSE_SERVER_VERIFICATION = new ApplicationPolicyType("LICENSE_SERVER_VERIFICATION");
        /// <summary>
        /// Constant LIFETIME_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType LIFETIME_SIGNING = new ApplicationPolicyType("LIFETIME_SIGNING");
        /// <summary>
        /// Constant MICROSOFT_PUBLISHER for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType MICROSOFT_PUBLISHER = new ApplicationPolicyType("MICROSOFT_PUBLISHER");
        /// <summary>
        /// Constant MICROSOFT_TIME_STAMPING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType MICROSOFT_TIME_STAMPING = new ApplicationPolicyType("MICROSOFT_TIME_STAMPING");
        /// <summary>
        /// Constant MICROSOFT_TRUST_LIST_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType MICROSOFT_TRUST_LIST_SIGNING = new ApplicationPolicyType("MICROSOFT_TRUST_LIST_SIGNING");
        /// <summary>
        /// Constant OCSP_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType OCSP_SIGNING = new ApplicationPolicyType("OCSP_SIGNING");
        /// <summary>
        /// Constant OEM_WINDOWS_SYSTEM_COMPONENT_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType OEM_WINDOWS_SYSTEM_COMPONENT_VERIFICATION = new ApplicationPolicyType("OEM_WINDOWS_SYSTEM_COMPONENT_VERIFICATION");
        /// <summary>
        /// Constant PLATFORM_CERTIFICATE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType PLATFORM_CERTIFICATE = new ApplicationPolicyType("PLATFORM_CERTIFICATE");
        /// <summary>
        /// Constant PREVIEW_BUILD_SIGNING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType PREVIEW_BUILD_SIGNING = new ApplicationPolicyType("PREVIEW_BUILD_SIGNING");
        /// <summary>
        /// Constant PRIVATE_KEY_ARCHIVAL for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType PRIVATE_KEY_ARCHIVAL = new ApplicationPolicyType("PRIVATE_KEY_ARCHIVAL");
        /// <summary>
        /// Constant PROTECTED_PROCESS_LIGHT_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType PROTECTED_PROCESS_LIGHT_VERIFICATION = new ApplicationPolicyType("PROTECTED_PROCESS_LIGHT_VERIFICATION");
        /// <summary>
        /// Constant PROTECTED_PROCESS_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType PROTECTED_PROCESS_VERIFICATION = new ApplicationPolicyType("PROTECTED_PROCESS_VERIFICATION");
        /// <summary>
        /// Constant QUALIFIED_SUBORDINATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType QUALIFIED_SUBORDINATION = new ApplicationPolicyType("QUALIFIED_SUBORDINATION");
        /// <summary>
        /// Constant REVOKED_LIST_SIGNER for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType REVOKED_LIST_SIGNER = new ApplicationPolicyType("REVOKED_LIST_SIGNER");
        /// <summary>
        /// Constant ROOT_LIST_SIGNER for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ROOT_LIST_SIGNER = new ApplicationPolicyType("ROOT_LIST_SIGNER");
        /// <summary>
        /// Constant ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION = new ApplicationPolicyType("ROOT_PROGRAM_AUTO_UPDATE_CA_REVOCATION");
        /// <summary>
        /// Constant ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION = new ApplicationPolicyType("ROOT_PROGRAM_AUTO_UPDATE_END_REVOCATION");
        /// <summary>
        /// Constant ROOT_PROGRAM_NO_OSCP_FAILOVER_TO_CRL for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType ROOT_PROGRAM_NO_OSCP_FAILOVER_TO_CRL = new ApplicationPolicyType("ROOT_PROGRAM_NO_OSCP_FAILOVER_TO_CRL");
        /// <summary>
        /// Constant SECURE_EMAIL for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType SECURE_EMAIL = new ApplicationPolicyType("SECURE_EMAIL");
        /// <summary>
        /// Constant SERVER_AUTHENTICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType SERVER_AUTHENTICATION = new ApplicationPolicyType("SERVER_AUTHENTICATION");
        /// <summary>
        /// Constant SMART_CARD_LOGIN for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType SMART_CARD_LOGIN = new ApplicationPolicyType("SMART_CARD_LOGIN");
        /// <summary>
        /// Constant SPC_ENCRYPTED_DIGEST_RETRY_COUNT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType SPC_ENCRYPTED_DIGEST_RETRY_COUNT = new ApplicationPolicyType("SPC_ENCRYPTED_DIGEST_RETRY_COUNT");
        /// <summary>
        /// Constant SPC_RELAXED_PE_MARKER_CHECK for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType SPC_RELAXED_PE_MARKER_CHECK = new ApplicationPolicyType("SPC_RELAXED_PE_MARKER_CHECK");
        /// <summary>
        /// Constant TIME_STAMPING for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType TIME_STAMPING = new ApplicationPolicyType("TIME_STAMPING");
        /// <summary>
        /// Constant WINDOWS_HARDWARE_DRIVER_ATTESTED_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_HARDWARE_DRIVER_ATTESTED_VERIFICATION = new ApplicationPolicyType("WINDOWS_HARDWARE_DRIVER_ATTESTED_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_HARDWARE_DRIVER_EXTENDED_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_HARDWARE_DRIVER_EXTENDED_VERIFICATION = new ApplicationPolicyType("WINDOWS_HARDWARE_DRIVER_EXTENDED_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_HARDWARE_DRIVER_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_HARDWARE_DRIVER_VERIFICATION = new ApplicationPolicyType("WINDOWS_HARDWARE_DRIVER_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_HELLO_RECOVERY_KEY_ENCRYPTION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_HELLO_RECOVERY_KEY_ENCRYPTION = new ApplicationPolicyType("WINDOWS_HELLO_RECOVERY_KEY_ENCRYPTION");
        /// <summary>
        /// Constant WINDOWS_KITS_COMPONENT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_KITS_COMPONENT = new ApplicationPolicyType("WINDOWS_KITS_COMPONENT");
        /// <summary>
        /// Constant WINDOWS_RT_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_RT_VERIFICATION = new ApplicationPolicyType("WINDOWS_RT_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_SOFTWARE_EXTENSION_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_SOFTWARE_EXTENSION_VERIFICATION = new ApplicationPolicyType("WINDOWS_SOFTWARE_EXTENSION_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_STORE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_STORE = new ApplicationPolicyType("WINDOWS_STORE");
        /// <summary>
        /// Constant WINDOWS_SYSTEM_COMPONENT_VERIFICATION for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_SYSTEM_COMPONENT_VERIFICATION = new ApplicationPolicyType("WINDOWS_SYSTEM_COMPONENT_VERIFICATION");
        /// <summary>
        /// Constant WINDOWS_TCB_COMPONENT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_TCB_COMPONENT = new ApplicationPolicyType("WINDOWS_TCB_COMPONENT");
        /// <summary>
        /// Constant WINDOWS_THIRD_PARTY_APPLICATION_COMPONENT for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_THIRD_PARTY_APPLICATION_COMPONENT = new ApplicationPolicyType("WINDOWS_THIRD_PARTY_APPLICATION_COMPONENT");
        /// <summary>
        /// Constant WINDOWS_UPDATE for ApplicationPolicyType
        /// </summary>
        public static readonly ApplicationPolicyType WINDOWS_UPDATE = new ApplicationPolicyType("WINDOWS_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationPolicyType FindValue(string value)
        {
            return FindValue<ApplicationPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientCompatibilityV2.
    /// </summary>
    public class ClientCompatibilityV2 : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS_SERVER_2003 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2003 = new ClientCompatibilityV2("WINDOWS_SERVER_2003");
        /// <summary>
        /// Constant WINDOWS_SERVER_2008 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2008 = new ClientCompatibilityV2("WINDOWS_SERVER_2008");
        /// <summary>
        /// Constant WINDOWS_SERVER_2008_R2 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2008_R2 = new ClientCompatibilityV2("WINDOWS_SERVER_2008_R2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2012 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2012 = new ClientCompatibilityV2("WINDOWS_SERVER_2012");
        /// <summary>
        /// Constant WINDOWS_SERVER_2012_R2 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2012_R2 = new ClientCompatibilityV2("WINDOWS_SERVER_2012_R2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016 for ClientCompatibilityV2
        /// </summary>
        public static readonly ClientCompatibilityV2 WINDOWS_SERVER_2016 = new ClientCompatibilityV2("WINDOWS_SERVER_2016");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientCompatibilityV2(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientCompatibilityV2 FindValue(string value)
        {
            return FindValue<ClientCompatibilityV2>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientCompatibilityV2(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientCompatibilityV3.
    /// </summary>
    public class ClientCompatibilityV3 : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS_SERVER_2008 for ClientCompatibilityV3
        /// </summary>
        public static readonly ClientCompatibilityV3 WINDOWS_SERVER_2008 = new ClientCompatibilityV3("WINDOWS_SERVER_2008");
        /// <summary>
        /// Constant WINDOWS_SERVER_2008_R2 for ClientCompatibilityV3
        /// </summary>
        public static readonly ClientCompatibilityV3 WINDOWS_SERVER_2008_R2 = new ClientCompatibilityV3("WINDOWS_SERVER_2008_R2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2012 for ClientCompatibilityV3
        /// </summary>
        public static readonly ClientCompatibilityV3 WINDOWS_SERVER_2012 = new ClientCompatibilityV3("WINDOWS_SERVER_2012");
        /// <summary>
        /// Constant WINDOWS_SERVER_2012_R2 for ClientCompatibilityV3
        /// </summary>
        public static readonly ClientCompatibilityV3 WINDOWS_SERVER_2012_R2 = new ClientCompatibilityV3("WINDOWS_SERVER_2012_R2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016 for ClientCompatibilityV3
        /// </summary>
        public static readonly ClientCompatibilityV3 WINDOWS_SERVER_2016 = new ClientCompatibilityV3("WINDOWS_SERVER_2016");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientCompatibilityV3(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientCompatibilityV3 FindValue(string value)
        {
            return FindValue<ClientCompatibilityV3>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientCompatibilityV3(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientCompatibilityV4.
    /// </summary>
    public class ClientCompatibilityV4 : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS_SERVER_2012 for ClientCompatibilityV4
        /// </summary>
        public static readonly ClientCompatibilityV4 WINDOWS_SERVER_2012 = new ClientCompatibilityV4("WINDOWS_SERVER_2012");
        /// <summary>
        /// Constant WINDOWS_SERVER_2012_R2 for ClientCompatibilityV4
        /// </summary>
        public static readonly ClientCompatibilityV4 WINDOWS_SERVER_2012_R2 = new ClientCompatibilityV4("WINDOWS_SERVER_2012_R2");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016 for ClientCompatibilityV4
        /// </summary>
        public static readonly ClientCompatibilityV4 WINDOWS_SERVER_2016 = new ClientCompatibilityV4("WINDOWS_SERVER_2016");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientCompatibilityV4(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientCompatibilityV4 FindValue(string value)
        {
            return FindValue<ClientCompatibilityV4>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientCompatibilityV4(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatus.
    /// </summary>
    public class ConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus ACTIVE = new ConnectorStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus CREATING = new ConnectorStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus DELETING = new ConnectorStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus FAILED = new ConnectorStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatus FindValue(string value)
        {
            return FindValue<ConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatusReason.
    /// </summary>
    public class ConnectorStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant CA_CERTIFICATE_REGISTRATION_FAILED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason CA_CERTIFICATE_REGISTRATION_FAILED = new ConnectorStatusReason("CA_CERTIFICATE_REGISTRATION_FAILED");
        /// <summary>
        /// Constant DIRECTORY_ACCESS_DENIED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason DIRECTORY_ACCESS_DENIED = new ConnectorStatusReason("DIRECTORY_ACCESS_DENIED");
        /// <summary>
        /// Constant INSUFFICIENT_FREE_ADDRESSES for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason INSUFFICIENT_FREE_ADDRESSES = new ConnectorStatusReason("INSUFFICIENT_FREE_ADDRESSES");
        /// <summary>
        /// Constant INTERNAL_FAILURE for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason INTERNAL_FAILURE = new ConnectorStatusReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant INVALID_SUBNET_IP_PROTOCOL for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason INVALID_SUBNET_IP_PROTOCOL = new ConnectorStatusReason("INVALID_SUBNET_IP_PROTOCOL");
        /// <summary>
        /// Constant PRIVATECA_ACCESS_DENIED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason PRIVATECA_ACCESS_DENIED = new ConnectorStatusReason("PRIVATECA_ACCESS_DENIED");
        /// <summary>
        /// Constant PRIVATECA_RESOURCE_NOT_FOUND for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason PRIVATECA_RESOURCE_NOT_FOUND = new ConnectorStatusReason("PRIVATECA_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SECURITY_GROUP_NOT_IN_VPC for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason SECURITY_GROUP_NOT_IN_VPC = new ConnectorStatusReason("SECURITY_GROUP_NOT_IN_VPC");
        /// <summary>
        /// Constant VPC_ACCESS_DENIED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason VPC_ACCESS_DENIED = new ConnectorStatusReason("VPC_ACCESS_DENIED");
        /// <summary>
        /// Constant VPC_ENDPOINT_LIMIT_EXCEEDED for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason VPC_ENDPOINT_LIMIT_EXCEEDED = new ConnectorStatusReason("VPC_ENDPOINT_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant VPC_RESOURCE_NOT_FOUND for ConnectorStatusReason
        /// </summary>
        public static readonly ConnectorStatusReason VPC_RESOURCE_NOT_FOUND = new ConnectorStatusReason("VPC_RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatusReason FindValue(string value)
        {
            return FindValue<ConnectorStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryRegistrationStatus.
    /// </summary>
    public class DirectoryRegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DirectoryRegistrationStatus
        /// </summary>
        public static readonly DirectoryRegistrationStatus ACTIVE = new DirectoryRegistrationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DirectoryRegistrationStatus
        /// </summary>
        public static readonly DirectoryRegistrationStatus CREATING = new DirectoryRegistrationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DirectoryRegistrationStatus
        /// </summary>
        public static readonly DirectoryRegistrationStatus DELETING = new DirectoryRegistrationStatus("DELETING");
        /// <summary>
        /// Constant FAILED for DirectoryRegistrationStatus
        /// </summary>
        public static readonly DirectoryRegistrationStatus FAILED = new DirectoryRegistrationStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryRegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryRegistrationStatus FindValue(string value)
        {
            return FindValue<DirectoryRegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryRegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryRegistrationStatusReason.
    /// </summary>
    public class DirectoryRegistrationStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant DIRECTORY_ACCESS_DENIED for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason DIRECTORY_ACCESS_DENIED = new DirectoryRegistrationStatusReason("DIRECTORY_ACCESS_DENIED");
        /// <summary>
        /// Constant DIRECTORY_NOT_ACTIVE for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason DIRECTORY_NOT_ACTIVE = new DirectoryRegistrationStatusReason("DIRECTORY_NOT_ACTIVE");
        /// <summary>
        /// Constant DIRECTORY_NOT_REACHABLE for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason DIRECTORY_NOT_REACHABLE = new DirectoryRegistrationStatusReason("DIRECTORY_NOT_REACHABLE");
        /// <summary>
        /// Constant DIRECTORY_RESOURCE_NOT_FOUND for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason DIRECTORY_RESOURCE_NOT_FOUND = new DirectoryRegistrationStatusReason("DIRECTORY_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant DIRECTORY_TYPE_NOT_SUPPORTED for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason DIRECTORY_TYPE_NOT_SUPPORTED = new DirectoryRegistrationStatusReason("DIRECTORY_TYPE_NOT_SUPPORTED");
        /// <summary>
        /// Constant INTERNAL_FAILURE for DirectoryRegistrationStatusReason
        /// </summary>
        public static readonly DirectoryRegistrationStatusReason INTERNAL_FAILURE = new DirectoryRegistrationStatusReason("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryRegistrationStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryRegistrationStatusReason FindValue(string value)
        {
            return FindValue<DirectoryRegistrationStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryRegistrationStatusReason(string value)
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
        /// Constant SHA256 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA256 = new HashAlgorithm("SHA256");
        /// <summary>
        /// Constant SHA384 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA384 = new HashAlgorithm("SHA384");
        /// <summary>
        /// Constant SHA512 for HashAlgorithm
        /// </summary>
        public static readonly HashAlgorithm SHA512 = new HashAlgorithm("SHA512");

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
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUALSTACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUALSTACK = new IpAddressType("DUALSTACK");
        /// <summary>
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");

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
    /// Constants used for properties of type KeySpec.
    /// </summary>
    public class KeySpec : ConstantClass
    {

        /// <summary>
        /// Constant KEY_EXCHANGE for KeySpec
        /// </summary>
        public static readonly KeySpec KEY_EXCHANGE = new KeySpec("KEY_EXCHANGE");
        /// <summary>
        /// Constant SIGNATURE for KeySpec
        /// </summary>
        public static readonly KeySpec SIGNATURE = new KeySpec("SIGNATURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeySpec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeySpec FindValue(string value)
        {
            return FindValue<KeySpec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeySpec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyUsagePropertyType.
    /// </summary>
    public class KeyUsagePropertyType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for KeyUsagePropertyType
        /// </summary>
        public static readonly KeyUsagePropertyType ALL = new KeyUsagePropertyType("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyUsagePropertyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyUsagePropertyType FindValue(string value)
        {
            return FindValue<KeyUsagePropertyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyUsagePropertyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateKeyAlgorithm.
    /// </summary>
    public class PrivateKeyAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant ECDH_P256 for PrivateKeyAlgorithm
        /// </summary>
        public static readonly PrivateKeyAlgorithm ECDH_P256 = new PrivateKeyAlgorithm("ECDH_P256");
        /// <summary>
        /// Constant ECDH_P384 for PrivateKeyAlgorithm
        /// </summary>
        public static readonly PrivateKeyAlgorithm ECDH_P384 = new PrivateKeyAlgorithm("ECDH_P384");
        /// <summary>
        /// Constant ECDH_P521 for PrivateKeyAlgorithm
        /// </summary>
        public static readonly PrivateKeyAlgorithm ECDH_P521 = new PrivateKeyAlgorithm("ECDH_P521");
        /// <summary>
        /// Constant RSA for PrivateKeyAlgorithm
        /// </summary>
        public static readonly PrivateKeyAlgorithm RSA = new PrivateKeyAlgorithm("RSA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateKeyAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateKeyAlgorithm FindValue(string value)
        {
            return FindValue<PrivateKeyAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateKeyAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServicePrincipalNameStatus.
    /// </summary>
    public class ServicePrincipalNameStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServicePrincipalNameStatus
        /// </summary>
        public static readonly ServicePrincipalNameStatus ACTIVE = new ServicePrincipalNameStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ServicePrincipalNameStatus
        /// </summary>
        public static readonly ServicePrincipalNameStatus CREATING = new ServicePrincipalNameStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ServicePrincipalNameStatus
        /// </summary>
        public static readonly ServicePrincipalNameStatus DELETING = new ServicePrincipalNameStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ServicePrincipalNameStatus
        /// </summary>
        public static readonly ServicePrincipalNameStatus FAILED = new ServicePrincipalNameStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServicePrincipalNameStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServicePrincipalNameStatus FindValue(string value)
        {
            return FindValue<ServicePrincipalNameStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServicePrincipalNameStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServicePrincipalNameStatusReason.
    /// </summary>
    public class ServicePrincipalNameStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant DIRECTORY_ACCESS_DENIED for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason DIRECTORY_ACCESS_DENIED = new ServicePrincipalNameStatusReason("DIRECTORY_ACCESS_DENIED");
        /// <summary>
        /// Constant DIRECTORY_NOT_REACHABLE for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason DIRECTORY_NOT_REACHABLE = new ServicePrincipalNameStatusReason("DIRECTORY_NOT_REACHABLE");
        /// <summary>
        /// Constant DIRECTORY_RESOURCE_NOT_FOUND for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason DIRECTORY_RESOURCE_NOT_FOUND = new ServicePrincipalNameStatusReason("DIRECTORY_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason INTERNAL_FAILURE = new ServicePrincipalNameStatusReason("INTERNAL_FAILURE");
        /// <summary>
        /// Constant SPN_EXISTS_ON_DIFFERENT_AD_OBJECT for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason SPN_EXISTS_ON_DIFFERENT_AD_OBJECT = new ServicePrincipalNameStatusReason("SPN_EXISTS_ON_DIFFERENT_AD_OBJECT");
        /// <summary>
        /// Constant SPN_LIMIT_EXCEEDED for ServicePrincipalNameStatusReason
        /// </summary>
        public static readonly ServicePrincipalNameStatusReason SPN_LIMIT_EXCEEDED = new ServicePrincipalNameStatusReason("SPN_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServicePrincipalNameStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServicePrincipalNameStatusReason FindValue(string value)
        {
            return FindValue<ServicePrincipalNameStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServicePrincipalNameStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateStatus.
    /// </summary>
    public class TemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus ACTIVE = new TemplateStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus DELETING = new TemplateStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateStatus FindValue(string value)
        {
            return FindValue<TemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateStatus(string value)
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
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant INVALID_CA_SUBJECT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CA_SUBJECT = new ValidationExceptionReason("INVALID_CA_SUBJECT");
        /// <summary>
        /// Constant INVALID_PERMISSION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PERMISSION = new ValidationExceptionReason("INVALID_PERMISSION");
        /// <summary>
        /// Constant INVALID_STATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_STATE = new ValidationExceptionReason("INVALID_STATE");
        /// <summary>
        /// Constant MISMATCHED_CONNECTOR for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_CONNECTOR = new ValidationExceptionReason("MISMATCHED_CONNECTOR");
        /// <summary>
        /// Constant MISMATCHED_VPC for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISMATCHED_VPC = new ValidationExceptionReason("MISMATCHED_VPC");
        /// <summary>
        /// Constant NO_CLIENT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason NO_CLIENT_TOKEN = new ValidationExceptionReason("NO_CLIENT_TOKEN");
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


    /// <summary>
    /// Constants used for properties of type ValidityPeriodType.
    /// </summary>
    public class ValidityPeriodType : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType DAYS = new ValidityPeriodType("DAYS");
        /// <summary>
        /// Constant HOURS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType HOURS = new ValidityPeriodType("HOURS");
        /// <summary>
        /// Constant MONTHS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType MONTHS = new ValidityPeriodType("MONTHS");
        /// <summary>
        /// Constant WEEKS for ValidityPeriodType
        /// </summary>
        public static readonly ValidityPeriodType WEEKS = new ValidityPeriodType("WEEKS");
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
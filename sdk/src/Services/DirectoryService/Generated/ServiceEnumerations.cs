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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DirectoryService
{

    /// <summary>
    /// Constants used for properties of type CaEnrollmentPolicyStatus.
    /// </summary>
    public class CaEnrollmentPolicyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus Disabled = new CaEnrollmentPolicyStatus("Disabled");
        /// <summary>
        /// Constant Disabling for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus Disabling = new CaEnrollmentPolicyStatus("Disabling");
        /// <summary>
        /// Constant Failed for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus Failed = new CaEnrollmentPolicyStatus("Failed");
        /// <summary>
        /// Constant Impaired for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus Impaired = new CaEnrollmentPolicyStatus("Impaired");
        /// <summary>
        /// Constant InProgress for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus InProgress = new CaEnrollmentPolicyStatus("InProgress");
        /// <summary>
        /// Constant Success for CaEnrollmentPolicyStatus
        /// </summary>
        public static readonly CaEnrollmentPolicyStatus Success = new CaEnrollmentPolicyStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaEnrollmentPolicyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaEnrollmentPolicyStatus FindValue(string value)
        {
            return FindValue<CaEnrollmentPolicyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaEnrollmentPolicyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateState.
    /// </summary>
    public class CertificateState : ConstantClass
    {

        /// <summary>
        /// Constant Deregistered for CertificateState
        /// </summary>
        public static readonly CertificateState Deregistered = new CertificateState("Deregistered");
        /// <summary>
        /// Constant DeregisterFailed for CertificateState
        /// </summary>
        public static readonly CertificateState DeregisterFailed = new CertificateState("DeregisterFailed");
        /// <summary>
        /// Constant Deregistering for CertificateState
        /// </summary>
        public static readonly CertificateState Deregistering = new CertificateState("Deregistering");
        /// <summary>
        /// Constant Registered for CertificateState
        /// </summary>
        public static readonly CertificateState Registered = new CertificateState("Registered");
        /// <summary>
        /// Constant RegisterFailed for CertificateState
        /// </summary>
        public static readonly CertificateState RegisterFailed = new CertificateState("RegisterFailed");
        /// <summary>
        /// Constant Registering for CertificateState
        /// </summary>
        public static readonly CertificateState Registering = new CertificateState("Registering");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateState FindValue(string value)
        {
            return FindValue<CertificateState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateState(string value)
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
        /// Constant ClientCertAuth for CertificateType
        /// </summary>
        public static readonly CertificateType ClientCertAuth = new CertificateType("ClientCertAuth");
        /// <summary>
        /// Constant ClientLDAPS for CertificateType
        /// </summary>
        public static readonly CertificateType ClientLDAPS = new CertificateType("ClientLDAPS");

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
    /// Constants used for properties of type ClientAuthenticationStatus.
    /// </summary>
    public class ClientAuthenticationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ClientAuthenticationStatus
        /// </summary>
        public static readonly ClientAuthenticationStatus Disabled = new ClientAuthenticationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ClientAuthenticationStatus
        /// </summary>
        public static readonly ClientAuthenticationStatus Enabled = new ClientAuthenticationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientAuthenticationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientAuthenticationStatus FindValue(string value)
        {
            return FindValue<ClientAuthenticationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientAuthenticationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientAuthenticationType.
    /// </summary>
    public class ClientAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant SmartCard for ClientAuthenticationType
        /// </summary>
        public static readonly ClientAuthenticationType SmartCard = new ClientAuthenticationType("SmartCard");
        /// <summary>
        /// Constant SmartCardOrPassword for ClientAuthenticationType
        /// </summary>
        public static readonly ClientAuthenticationType SmartCardOrPassword = new ClientAuthenticationType("SmartCardOrPassword");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientAuthenticationType FindValue(string value)
        {
            return FindValue<ClientAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataAccessStatus.
    /// </summary>
    public class DataAccessStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DataAccessStatus
        /// </summary>
        public static readonly DataAccessStatus Disabled = new DataAccessStatus("Disabled");
        /// <summary>
        /// Constant Disabling for DataAccessStatus
        /// </summary>
        public static readonly DataAccessStatus Disabling = new DataAccessStatus("Disabling");
        /// <summary>
        /// Constant Enabled for DataAccessStatus
        /// </summary>
        public static readonly DataAccessStatus Enabled = new DataAccessStatus("Enabled");
        /// <summary>
        /// Constant Enabling for DataAccessStatus
        /// </summary>
        public static readonly DataAccessStatus Enabling = new DataAccessStatus("Enabling");
        /// <summary>
        /// Constant Failed for DataAccessStatus
        /// </summary>
        public static readonly DataAccessStatus Failed = new DataAccessStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAccessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAccessStatus FindValue(string value)
        {
            return FindValue<DataAccessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAccessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryConfigurationStatus.
    /// </summary>
    public class DirectoryConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Default for DirectoryConfigurationStatus
        /// </summary>
        public static readonly DirectoryConfigurationStatus Default = new DirectoryConfigurationStatus("Default");
        /// <summary>
        /// Constant Failed for DirectoryConfigurationStatus
        /// </summary>
        public static readonly DirectoryConfigurationStatus Failed = new DirectoryConfigurationStatus("Failed");
        /// <summary>
        /// Constant Requested for DirectoryConfigurationStatus
        /// </summary>
        public static readonly DirectoryConfigurationStatus Requested = new DirectoryConfigurationStatus("Requested");
        /// <summary>
        /// Constant Updated for DirectoryConfigurationStatus
        /// </summary>
        public static readonly DirectoryConfigurationStatus Updated = new DirectoryConfigurationStatus("Updated");
        /// <summary>
        /// Constant Updating for DirectoryConfigurationStatus
        /// </summary>
        public static readonly DirectoryConfigurationStatus Updating = new DirectoryConfigurationStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryConfigurationStatus FindValue(string value)
        {
            return FindValue<DirectoryConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryEdition.
    /// </summary>
    public class DirectoryEdition : ConstantClass
    {

        /// <summary>
        /// Constant Enterprise for DirectoryEdition
        /// </summary>
        public static readonly DirectoryEdition Enterprise = new DirectoryEdition("Enterprise");
        /// <summary>
        /// Constant Hybrid for DirectoryEdition
        /// </summary>
        public static readonly DirectoryEdition Hybrid = new DirectoryEdition("Hybrid");
        /// <summary>
        /// Constant Standard for DirectoryEdition
        /// </summary>
        public static readonly DirectoryEdition Standard = new DirectoryEdition("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryEdition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryEdition FindValue(string value)
        {
            return FindValue<DirectoryEdition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryEdition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectorySize.
    /// </summary>
    public class DirectorySize : ConstantClass
    {

        /// <summary>
        /// Constant Large for DirectorySize
        /// </summary>
        public static readonly DirectorySize Large = new DirectorySize("Large");
        /// <summary>
        /// Constant Small for DirectorySize
        /// </summary>
        public static readonly DirectorySize Small = new DirectorySize("Small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectorySize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectorySize FindValue(string value)
        {
            return FindValue<DirectorySize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectorySize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryStage.
    /// </summary>
    public class DirectoryStage : ConstantClass
    {

        /// <summary>
        /// Constant Active for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Active = new DirectoryStage("Active");
        /// <summary>
        /// Constant Created for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Created = new DirectoryStage("Created");
        /// <summary>
        /// Constant Creating for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Creating = new DirectoryStage("Creating");
        /// <summary>
        /// Constant Deleted for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Deleted = new DirectoryStage("Deleted");
        /// <summary>
        /// Constant Deleting for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Deleting = new DirectoryStage("Deleting");
        /// <summary>
        /// Constant Failed for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Failed = new DirectoryStage("Failed");
        /// <summary>
        /// Constant Impaired for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Impaired = new DirectoryStage("Impaired");
        /// <summary>
        /// Constant Inoperable for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Inoperable = new DirectoryStage("Inoperable");
        /// <summary>
        /// Constant Requested for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Requested = new DirectoryStage("Requested");
        /// <summary>
        /// Constant RestoreFailed for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage RestoreFailed = new DirectoryStage("RestoreFailed");
        /// <summary>
        /// Constant Restoring for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Restoring = new DirectoryStage("Restoring");
        /// <summary>
        /// Constant Updating for DirectoryStage
        /// </summary>
        public static readonly DirectoryStage Updating = new DirectoryStage("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryStage FindValue(string value)
        {
            return FindValue<DirectoryStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryType.
    /// </summary>
    public class DirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant ADConnector for DirectoryType
        /// </summary>
        public static readonly DirectoryType ADConnector = new DirectoryType("ADConnector");
        /// <summary>
        /// Constant MicrosoftAD for DirectoryType
        /// </summary>
        public static readonly DirectoryType MicrosoftAD = new DirectoryType("MicrosoftAD");
        /// <summary>
        /// Constant SharedMicrosoftAD for DirectoryType
        /// </summary>
        public static readonly DirectoryType SharedMicrosoftAD = new DirectoryType("SharedMicrosoftAD");
        /// <summary>
        /// Constant SimpleAD for DirectoryType
        /// </summary>
        public static readonly DirectoryType SimpleAD = new DirectoryType("SimpleAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryType FindValue(string value)
        {
            return FindValue<DirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainControllerStatus.
    /// </summary>
    public class DomainControllerStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Active = new DomainControllerStatus("Active");
        /// <summary>
        /// Constant Creating for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Creating = new DomainControllerStatus("Creating");
        /// <summary>
        /// Constant Deleted for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Deleted = new DomainControllerStatus("Deleted");
        /// <summary>
        /// Constant Deleting for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Deleting = new DomainControllerStatus("Deleting");
        /// <summary>
        /// Constant Failed for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Failed = new DomainControllerStatus("Failed");
        /// <summary>
        /// Constant Impaired for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Impaired = new DomainControllerStatus("Impaired");
        /// <summary>
        /// Constant Restoring for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Restoring = new DomainControllerStatus("Restoring");
        /// <summary>
        /// Constant Updating for DomainControllerStatus
        /// </summary>
        public static readonly DomainControllerStatus Updating = new DomainControllerStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainControllerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainControllerStatus FindValue(string value)
        {
            return FindValue<DomainControllerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainControllerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HybridUpdateType.
    /// </summary>
    public class HybridUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant HybridAdministratorAccount for HybridUpdateType
        /// </summary>
        public static readonly HybridUpdateType HybridAdministratorAccount = new HybridUpdateType("HybridAdministratorAccount");
        /// <summary>
        /// Constant SelfManagedInstances for HybridUpdateType
        /// </summary>
        public static readonly HybridUpdateType SelfManagedInstances = new HybridUpdateType("SelfManagedInstances");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HybridUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HybridUpdateType FindValue(string value)
        {
            return FindValue<HybridUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HybridUpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpRouteStatusMsg.
    /// </summary>
    public class IpRouteStatusMsg : ConstantClass
    {

        /// <summary>
        /// Constant Added for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg Added = new IpRouteStatusMsg("Added");
        /// <summary>
        /// Constant AddFailed for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg AddFailed = new IpRouteStatusMsg("AddFailed");
        /// <summary>
        /// Constant Adding for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg Adding = new IpRouteStatusMsg("Adding");
        /// <summary>
        /// Constant Removed for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg Removed = new IpRouteStatusMsg("Removed");
        /// <summary>
        /// Constant RemoveFailed for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg RemoveFailed = new IpRouteStatusMsg("RemoveFailed");
        /// <summary>
        /// Constant Removing for IpRouteStatusMsg
        /// </summary>
        public static readonly IpRouteStatusMsg Removing = new IpRouteStatusMsg("Removing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpRouteStatusMsg(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpRouteStatusMsg FindValue(string value)
        {
            return FindValue<IpRouteStatusMsg>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpRouteStatusMsg(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LDAPSStatus.
    /// </summary>
    public class LDAPSStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for LDAPSStatus
        /// </summary>
        public static readonly LDAPSStatus Disabled = new LDAPSStatus("Disabled");
        /// <summary>
        /// Constant Enabled for LDAPSStatus
        /// </summary>
        public static readonly LDAPSStatus Enabled = new LDAPSStatus("Enabled");
        /// <summary>
        /// Constant EnableFailed for LDAPSStatus
        /// </summary>
        public static readonly LDAPSStatus EnableFailed = new LDAPSStatus("EnableFailed");
        /// <summary>
        /// Constant Enabling for LDAPSStatus
        /// </summary>
        public static readonly LDAPSStatus Enabling = new LDAPSStatus("Enabling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LDAPSStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LDAPSStatus FindValue(string value)
        {
            return FindValue<LDAPSStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LDAPSStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LDAPSType.
    /// </summary>
    public class LDAPSType : ConstantClass
    {

        /// <summary>
        /// Constant Client for LDAPSType
        /// </summary>
        public static readonly LDAPSType Client = new LDAPSType("Client");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LDAPSType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LDAPSType FindValue(string value)
        {
            return FindValue<LDAPSType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LDAPSType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant DualStack for NetworkType
        /// </summary>
        public static readonly NetworkType DualStack = new NetworkType("Dual-stack");
        /// <summary>
        /// Constant IPv4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPv4 = new NetworkType("IPv4");
        /// <summary>
        /// Constant IPv6 for NetworkType
        /// </summary>
        public static readonly NetworkType IPv6 = new NetworkType("IPv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OSVersion.
    /// </summary>
    public class OSVersion : ConstantClass
    {

        /// <summary>
        /// Constant SERVER_2012 for OSVersion
        /// </summary>
        public static readonly OSVersion SERVER_2012 = new OSVersion("SERVER_2012");
        /// <summary>
        /// Constant SERVER_2019 for OSVersion
        /// </summary>
        public static readonly OSVersion SERVER_2019 = new OSVersion("SERVER_2019");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OSVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OSVersion FindValue(string value)
        {
            return FindValue<OSVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OSVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RadiusAuthenticationProtocol.
    /// </summary>
    public class RadiusAuthenticationProtocol : ConstantClass
    {

        /// <summary>
        /// Constant CHAP for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol CHAP = new RadiusAuthenticationProtocol("CHAP");
        /// <summary>
        /// Constant MSCHAPv1 for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol MSCHAPv1 = new RadiusAuthenticationProtocol("MS-CHAPv1");
        /// <summary>
        /// Constant MSCHAPv2 for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol MSCHAPv2 = new RadiusAuthenticationProtocol("MS-CHAPv2");
        /// <summary>
        /// Constant PAP for RadiusAuthenticationProtocol
        /// </summary>
        public static readonly RadiusAuthenticationProtocol PAP = new RadiusAuthenticationProtocol("PAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RadiusAuthenticationProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RadiusAuthenticationProtocol FindValue(string value)
        {
            return FindValue<RadiusAuthenticationProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RadiusAuthenticationProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RadiusStatus.
    /// </summary>
    public class RadiusStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Completed = new RadiusStatus("Completed");
        /// <summary>
        /// Constant Creating for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Creating = new RadiusStatus("Creating");
        /// <summary>
        /// Constant Failed for RadiusStatus
        /// </summary>
        public static readonly RadiusStatus Failed = new RadiusStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RadiusStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RadiusStatus FindValue(string value)
        {
            return FindValue<RadiusStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RadiusStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionType.
    /// </summary>
    public class RegionType : ConstantClass
    {

        /// <summary>
        /// Constant Additional for RegionType
        /// </summary>
        public static readonly RegionType Additional = new RegionType("Additional");
        /// <summary>
        /// Constant Primary for RegionType
        /// </summary>
        public static readonly RegionType Primary = new RegionType("Primary");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionType FindValue(string value)
        {
            return FindValue<RegionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationScope.
    /// </summary>
    public class ReplicationScope : ConstantClass
    {

        /// <summary>
        /// Constant Domain for ReplicationScope
        /// </summary>
        public static readonly ReplicationScope Domain = new ReplicationScope("Domain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationScope FindValue(string value)
        {
            return FindValue<ReplicationScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaExtensionStatus.
    /// </summary>
    public class SchemaExtensionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CancelInProgress for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus CancelInProgress = new SchemaExtensionStatus("CancelInProgress");
        /// <summary>
        /// Constant Cancelled for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus Cancelled = new SchemaExtensionStatus("Cancelled");
        /// <summary>
        /// Constant Completed for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus Completed = new SchemaExtensionStatus("Completed");
        /// <summary>
        /// Constant CreatingSnapshot for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus CreatingSnapshot = new SchemaExtensionStatus("CreatingSnapshot");
        /// <summary>
        /// Constant Failed for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus Failed = new SchemaExtensionStatus("Failed");
        /// <summary>
        /// Constant Initializing for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus Initializing = new SchemaExtensionStatus("Initializing");
        /// <summary>
        /// Constant Replicating for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus Replicating = new SchemaExtensionStatus("Replicating");
        /// <summary>
        /// Constant RollbackInProgress for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus RollbackInProgress = new SchemaExtensionStatus("RollbackInProgress");
        /// <summary>
        /// Constant UpdatingSchema for SchemaExtensionStatus
        /// </summary>
        public static readonly SchemaExtensionStatus UpdatingSchema = new SchemaExtensionStatus("UpdatingSchema");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaExtensionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaExtensionStatus FindValue(string value)
        {
            return FindValue<SchemaExtensionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaExtensionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectiveAuth.
    /// </summary>
    public class SelectiveAuth : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for SelectiveAuth
        /// </summary>
        public static readonly SelectiveAuth Disabled = new SelectiveAuth("Disabled");
        /// <summary>
        /// Constant Enabled for SelectiveAuth
        /// </summary>
        public static readonly SelectiveAuth Enabled = new SelectiveAuth("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectiveAuth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectiveAuth FindValue(string value)
        {
            return FindValue<SelectiveAuth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectiveAuth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareMethod.
    /// </summary>
    public class ShareMethod : ConstantClass
    {

        /// <summary>
        /// Constant HANDSHAKE for ShareMethod
        /// </summary>
        public static readonly ShareMethod HANDSHAKE = new ShareMethod("HANDSHAKE");
        /// <summary>
        /// Constant ORGANIZATIONS for ShareMethod
        /// </summary>
        public static readonly ShareMethod ORGANIZATIONS = new ShareMethod("ORGANIZATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareMethod FindValue(string value)
        {
            return FindValue<ShareMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareStatus.
    /// </summary>
    public class ShareStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for ShareStatus
        /// </summary>
        public static readonly ShareStatus Deleted = new ShareStatus("Deleted");
        /// <summary>
        /// Constant Deleting for ShareStatus
        /// </summary>
        public static readonly ShareStatus Deleting = new ShareStatus("Deleting");
        /// <summary>
        /// Constant PendingAcceptance for ShareStatus
        /// </summary>
        public static readonly ShareStatus PendingAcceptance = new ShareStatus("PendingAcceptance");
        /// <summary>
        /// Constant Rejected for ShareStatus
        /// </summary>
        public static readonly ShareStatus Rejected = new ShareStatus("Rejected");
        /// <summary>
        /// Constant RejectFailed for ShareStatus
        /// </summary>
        public static readonly ShareStatus RejectFailed = new ShareStatus("RejectFailed");
        /// <summary>
        /// Constant Rejecting for ShareStatus
        /// </summary>
        public static readonly ShareStatus Rejecting = new ShareStatus("Rejecting");
        /// <summary>
        /// Constant Shared for ShareStatus
        /// </summary>
        public static readonly ShareStatus Shared = new ShareStatus("Shared");
        /// <summary>
        /// Constant ShareFailed for ShareStatus
        /// </summary>
        public static readonly ShareStatus ShareFailed = new ShareStatus("ShareFailed");
        /// <summary>
        /// Constant Sharing for ShareStatus
        /// </summary>
        public static readonly ShareStatus Sharing = new ShareStatus("Sharing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatus FindValue(string value)
        {
            return FindValue<ShareStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Completed = new SnapshotStatus("Completed");
        /// <summary>
        /// Constant Creating for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Creating = new SnapshotStatus("Creating");
        /// <summary>
        /// Constant Failed for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus Failed = new SnapshotStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotType.
    /// </summary>
    public class SnapshotType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for SnapshotType
        /// </summary>
        public static readonly SnapshotType Auto = new SnapshotType("Auto");
        /// <summary>
        /// Constant Manual for SnapshotType
        /// </summary>
        public static readonly SnapshotType Manual = new SnapshotType("Manual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotType FindValue(string value)
        {
            return FindValue<SnapshotType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for TargetType
        /// </summary>
        public static readonly TargetType ACCOUNT = new TargetType("ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopicStatus.
    /// </summary>
    public class TopicStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleted for TopicStatus
        /// </summary>
        public static readonly TopicStatus Deleted = new TopicStatus("Deleted");
        /// <summary>
        /// Constant Failed for TopicStatus
        /// </summary>
        public static readonly TopicStatus Failed = new TopicStatus("Failed");
        /// <summary>
        /// Constant Registered for TopicStatus
        /// </summary>
        public static readonly TopicStatus Registered = new TopicStatus("Registered");
        /// <summary>
        /// Constant TopicNotFound for TopicStatus
        /// </summary>
        public static readonly TopicStatus TopicNotFound = new TopicStatus("Topic not found");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopicStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopicStatus FindValue(string value)
        {
            return FindValue<TopicStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopicStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustDirection.
    /// </summary>
    public class TrustDirection : ConstantClass
    {

        /// <summary>
        /// Constant OneWayIncoming for TrustDirection
        /// </summary>
        public static readonly TrustDirection OneWayIncoming = new TrustDirection("One-Way: Incoming");
        /// <summary>
        /// Constant OneWayOutgoing for TrustDirection
        /// </summary>
        public static readonly TrustDirection OneWayOutgoing = new TrustDirection("One-Way: Outgoing");
        /// <summary>
        /// Constant TwoWay for TrustDirection
        /// </summary>
        public static readonly TrustDirection TwoWay = new TrustDirection("Two-Way");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustDirection FindValue(string value)
        {
            return FindValue<TrustDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustState.
    /// </summary>
    public class TrustState : ConstantClass
    {

        /// <summary>
        /// Constant Created for TrustState
        /// </summary>
        public static readonly TrustState Created = new TrustState("Created");
        /// <summary>
        /// Constant Creating for TrustState
        /// </summary>
        public static readonly TrustState Creating = new TrustState("Creating");
        /// <summary>
        /// Constant Deleted for TrustState
        /// </summary>
        public static readonly TrustState Deleted = new TrustState("Deleted");
        /// <summary>
        /// Constant Deleting for TrustState
        /// </summary>
        public static readonly TrustState Deleting = new TrustState("Deleting");
        /// <summary>
        /// Constant Failed for TrustState
        /// </summary>
        public static readonly TrustState Failed = new TrustState("Failed");
        /// <summary>
        /// Constant Updated for TrustState
        /// </summary>
        public static readonly TrustState Updated = new TrustState("Updated");
        /// <summary>
        /// Constant UpdateFailed for TrustState
        /// </summary>
        public static readonly TrustState UpdateFailed = new TrustState("UpdateFailed");
        /// <summary>
        /// Constant Updating for TrustState
        /// </summary>
        public static readonly TrustState Updating = new TrustState("Updating");
        /// <summary>
        /// Constant Verified for TrustState
        /// </summary>
        public static readonly TrustState Verified = new TrustState("Verified");
        /// <summary>
        /// Constant VerifyFailed for TrustState
        /// </summary>
        public static readonly TrustState VerifyFailed = new TrustState("VerifyFailed");
        /// <summary>
        /// Constant Verifying for TrustState
        /// </summary>
        public static readonly TrustState Verifying = new TrustState("Verifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustState FindValue(string value)
        {
            return FindValue<TrustState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustType.
    /// </summary>
    public class TrustType : ConstantClass
    {

        /// <summary>
        /// Constant External for TrustType
        /// </summary>
        public static readonly TrustType External = new TrustType("External");
        /// <summary>
        /// Constant Forest for TrustType
        /// </summary>
        public static readonly TrustType Forest = new TrustType("Forest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustType FindValue(string value)
        {
            return FindValue<TrustType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Updated for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Updated = new UpdateStatus("Updated");
        /// <summary>
        /// Constant UpdateFailed for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus UpdateFailed = new UpdateStatus("UpdateFailed");
        /// <summary>
        /// Constant Updating for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Updating = new UpdateStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateType.
    /// </summary>
    public class UpdateType : ConstantClass
    {

        /// <summary>
        /// Constant NETWORK for UpdateType
        /// </summary>
        public static readonly UpdateType NETWORK = new UpdateType("NETWORK");
        /// <summary>
        /// Constant OS for UpdateType
        /// </summary>
        public static readonly UpdateType OS = new UpdateType("OS");
        /// <summary>
        /// Constant SIZE for UpdateType
        /// </summary>
        public static readonly UpdateType SIZE = new UpdateType("SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateType FindValue(string value)
        {
            return FindValue<UpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateType(string value)
        {
            return FindValue(value);
        }
    }

}
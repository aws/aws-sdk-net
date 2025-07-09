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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTManagedIntegrations
{

    /// <summary>
    /// Constants used for properties of type AbortCriteriaAction.
    /// </summary>
    public class AbortCriteriaAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for AbortCriteriaAction
        /// </summary>
        public static readonly AbortCriteriaAction CANCEL = new AbortCriteriaAction("CANCEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AbortCriteriaAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AbortCriteriaAction FindValue(string value)
        {
            return FindValue<AbortCriteriaAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AbortCriteriaAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AbortCriteriaFailureType.
    /// </summary>
    public class AbortCriteriaFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AbortCriteriaFailureType
        /// </summary>
        public static readonly AbortCriteriaFailureType ALL = new AbortCriteriaFailureType("ALL");
        /// <summary>
        /// Constant FAILED for AbortCriteriaFailureType
        /// </summary>
        public static readonly AbortCriteriaFailureType FAILED = new AbortCriteriaFailureType("FAILED");
        /// <summary>
        /// Constant REJECTED for AbortCriteriaFailureType
        /// </summary>
        public static readonly AbortCriteriaFailureType REJECTED = new AbortCriteriaFailureType("REJECTED");
        /// <summary>
        /// Constant TIMED_OUT for AbortCriteriaFailureType
        /// </summary>
        public static readonly AbortCriteriaFailureType TIMED_OUT = new AbortCriteriaFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AbortCriteriaFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AbortCriteriaFailureType FindValue(string value)
        {
            return FindValue<AbortCriteriaFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AbortCriteriaFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationState.
    /// </summary>
    public class AssociationState : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATION_DELETING for AssociationState
        /// </summary>
        public static readonly AssociationState ASSOCIATION_DELETING = new AssociationState("ASSOCIATION_DELETING");
        /// <summary>
        /// Constant ASSOCIATION_FAILED for AssociationState
        /// </summary>
        public static readonly AssociationState ASSOCIATION_FAILED = new AssociationState("ASSOCIATION_FAILED");
        /// <summary>
        /// Constant ASSOCIATION_IN_PROGRESS for AssociationState
        /// </summary>
        public static readonly AssociationState ASSOCIATION_IN_PROGRESS = new AssociationState("ASSOCIATION_IN_PROGRESS");
        /// <summary>
        /// Constant ASSOCIATION_SUCCEEDED for AssociationState
        /// </summary>
        public static readonly AssociationState ASSOCIATION_SUCCEEDED = new AssociationState("ASSOCIATION_SUCCEEDED");
        /// <summary>
        /// Constant REFRESH_TOKEN_EXPIRED for AssociationState
        /// </summary>
        public static readonly AssociationState REFRESH_TOKEN_EXPIRED = new AssociationState("REFRESH_TOKEN_EXPIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationState FindValue(string value)
        {
            return FindValue<AssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthMaterialType.
    /// </summary>
    public class AuthMaterialType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_PROTOCOL_QR_BAR_CODE for AuthMaterialType
        /// </summary>
        public static readonly AuthMaterialType CUSTOM_PROTOCOL_QR_BAR_CODE = new AuthMaterialType("CUSTOM_PROTOCOL_QR_BAR_CODE");
        /// <summary>
        /// Constant DISCOVERED_DEVICE for AuthMaterialType
        /// </summary>
        public static readonly AuthMaterialType DISCOVERED_DEVICE = new AuthMaterialType("DISCOVERED_DEVICE");
        /// <summary>
        /// Constant WIFI_SETUP_QR_BAR_CODE for AuthMaterialType
        /// </summary>
        public static readonly AuthMaterialType WIFI_SETUP_QR_BAR_CODE = new AuthMaterialType("WIFI_SETUP_QR_BAR_CODE");
        /// <summary>
        /// Constant ZIGBEE_QR_BAR_CODE for AuthMaterialType
        /// </summary>
        public static readonly AuthMaterialType ZIGBEE_QR_BAR_CODE = new AuthMaterialType("ZIGBEE_QR_BAR_CODE");
        /// <summary>
        /// Constant ZWAVE_QR_BAR_CODE for AuthMaterialType
        /// </summary>
        public static readonly AuthMaterialType ZWAVE_QR_BAR_CODE = new AuthMaterialType("ZWAVE_QR_BAR_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthMaterialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthMaterialType FindValue(string value)
        {
            return FindValue<AuthMaterialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthMaterialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant OAUTH for AuthType
        /// </summary>
        public static readonly AuthType OAUTH = new AuthType("OAUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudConnectorType.
    /// </summary>
    public class CloudConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant LISTED for CloudConnectorType
        /// </summary>
        public static readonly CloudConnectorType LISTED = new CloudConnectorType("LISTED");
        /// <summary>
        /// Constant UNLISTED for CloudConnectorType
        /// </summary>
        public static readonly CloudConnectorType UNLISTED = new CloudConnectorType("UNLISTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudConnectorType FindValue(string value)
        {
            return FindValue<CloudConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationState.
    /// </summary>
    public class ConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState ENABLED = new ConfigurationState("ENABLED");
        /// <summary>
        /// Constant UPDATE_FAILED for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState UPDATE_FAILED = new ConfigurationState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ConfigurationState
        /// </summary>
        public static readonly ConfigurationState UPDATE_IN_PROGRESS = new ConfigurationState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationState FindValue(string value)
        {
            return FindValue<ConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorEventOperation.
    /// </summary>
    public class ConnectorEventOperation : ConstantClass
    {

        /// <summary>
        /// Constant DEVICE_COMMAND_REQUEST for ConnectorEventOperation
        /// </summary>
        public static readonly ConnectorEventOperation DEVICE_COMMAND_REQUEST = new ConnectorEventOperation("DEVICE_COMMAND_REQUEST");
        /// <summary>
        /// Constant DEVICE_COMMAND_RESPONSE for ConnectorEventOperation
        /// </summary>
        public static readonly ConnectorEventOperation DEVICE_COMMAND_RESPONSE = new ConnectorEventOperation("DEVICE_COMMAND_RESPONSE");
        /// <summary>
        /// Constant DEVICE_DISCOVERY for ConnectorEventOperation
        /// </summary>
        public static readonly ConnectorEventOperation DEVICE_DISCOVERY = new ConnectorEventOperation("DEVICE_DISCOVERY");
        /// <summary>
        /// Constant DEVICE_EVENT for ConnectorEventOperation
        /// </summary>
        public static readonly ConnectorEventOperation DEVICE_EVENT = new ConnectorEventOperation("DEVICE_EVENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorEventOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorEventOperation FindValue(string value)
        {
            return FindValue<ConnectorEventOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorEventOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryDestinationType.
    /// </summary>
    public class DeliveryDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant KINESIS for DeliveryDestinationType
        /// </summary>
        public static readonly DeliveryDestinationType KINESIS = new DeliveryDestinationType("KINESIS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryDestinationType FindValue(string value)
        {
            return FindValue<DeliveryDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceDiscoveryStatus.
    /// </summary>
    public class DeviceDiscoveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DeviceDiscoveryStatus
        /// </summary>
        public static readonly DeviceDiscoveryStatus FAILED = new DeviceDiscoveryStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for DeviceDiscoveryStatus
        /// </summary>
        public static readonly DeviceDiscoveryStatus RUNNING = new DeviceDiscoveryStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for DeviceDiscoveryStatus
        /// </summary>
        public static readonly DeviceDiscoveryStatus SUCCEEDED = new DeviceDiscoveryStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for DeviceDiscoveryStatus
        /// </summary>
        public static readonly DeviceDiscoveryStatus TIMED_OUT = new DeviceDiscoveryStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceDiscoveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceDiscoveryStatus FindValue(string value)
        {
            return FindValue<DeviceDiscoveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceDiscoveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisconnectReasonValue.
    /// </summary>
    public class DisconnectReasonValue : ConstantClass
    {

        /// <summary>
        /// Constant AUTH_ERROR for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue AUTH_ERROR = new DisconnectReasonValue("AUTH_ERROR");
        /// <summary>
        /// Constant CLIENT_ERROR for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue CLIENT_ERROR = new DisconnectReasonValue("CLIENT_ERROR");
        /// <summary>
        /// Constant CLIENT_INITIATED_DISCONNECT for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue CLIENT_INITIATED_DISCONNECT = new DisconnectReasonValue("CLIENT_INITIATED_DISCONNECT");
        /// <summary>
        /// Constant CONNECTION_LOST for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue CONNECTION_LOST = new DisconnectReasonValue("CONNECTION_LOST");
        /// <summary>
        /// Constant CUSTOMAUTH_TTL_EXPIRATION for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue CUSTOMAUTH_TTL_EXPIRATION = new DisconnectReasonValue("CUSTOMAUTH_TTL_EXPIRATION");
        /// <summary>
        /// Constant DUPLICATE_CLIENTID for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue DUPLICATE_CLIENTID = new DisconnectReasonValue("DUPLICATE_CLIENTID");
        /// <summary>
        /// Constant FORBIDDEN_ACCESS for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue FORBIDDEN_ACCESS = new DisconnectReasonValue("FORBIDDEN_ACCESS");
        /// <summary>
        /// Constant MQTT_KEEP_ALIVE_TIMEOUT for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue MQTT_KEEP_ALIVE_TIMEOUT = new DisconnectReasonValue("MQTT_KEEP_ALIVE_TIMEOUT");
        /// <summary>
        /// Constant NONE for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue NONE = new DisconnectReasonValue("NONE");
        /// <summary>
        /// Constant SERVER_ERROR for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue SERVER_ERROR = new DisconnectReasonValue("SERVER_ERROR");
        /// <summary>
        /// Constant SERVER_INITIATED_DISCONNECT for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue SERVER_INITIATED_DISCONNECT = new DisconnectReasonValue("SERVER_INITIATED_DISCONNECT");
        /// <summary>
        /// Constant THROTTLED for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue THROTTLED = new DisconnectReasonValue("THROTTLED");
        /// <summary>
        /// Constant UNKNOWN for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue UNKNOWN = new DisconnectReasonValue("UNKNOWN");
        /// <summary>
        /// Constant WEBSOCKET_TTL_EXPIRATION for DisconnectReasonValue
        /// </summary>
        public static readonly DisconnectReasonValue WEBSOCKET_TTL_EXPIRATION = new DisconnectReasonValue("WEBSOCKET_TTL_EXPIRATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisconnectReasonValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisconnectReasonValue FindValue(string value)
        {
            return FindValue<DisconnectReasonValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisconnectReasonValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscoveryAuthMaterialType.
    /// </summary>
    public class DiscoveryAuthMaterialType : ConstantClass
    {

        /// <summary>
        /// Constant ZWAVE_INSTALL_CODE for DiscoveryAuthMaterialType
        /// </summary>
        public static readonly DiscoveryAuthMaterialType ZWAVE_INSTALL_CODE = new DiscoveryAuthMaterialType("ZWAVE_INSTALL_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscoveryAuthMaterialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryAuthMaterialType FindValue(string value)
        {
            return FindValue<DiscoveryAuthMaterialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryAuthMaterialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscoveryModification.
    /// </summary>
    public class DiscoveryModification : ConstantClass
    {

        /// <summary>
        /// Constant DISCOVERED for DiscoveryModification
        /// </summary>
        public static readonly DiscoveryModification DISCOVERED = new DiscoveryModification("DISCOVERED");
        /// <summary>
        /// Constant NO_CHANGE for DiscoveryModification
        /// </summary>
        public static readonly DiscoveryModification NO_CHANGE = new DiscoveryModification("NO_CHANGE");
        /// <summary>
        /// Constant UPDATED for DiscoveryModification
        /// </summary>
        public static readonly DiscoveryModification UPDATED = new DiscoveryModification("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscoveryModification(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryModification FindValue(string value)
        {
            return FindValue<DiscoveryModification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryModification(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscoveryType.
    /// </summary>
    public class DiscoveryType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType CLOUD = new DiscoveryType("CLOUD");
        /// <summary>
        /// Constant CUSTOM for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType CUSTOM = new DiscoveryType("CUSTOM");
        /// <summary>
        /// Constant ZIGBEE for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType ZIGBEE = new DiscoveryType("ZIGBEE");
        /// <summary>
        /// Constant ZWAVE for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType ZWAVE = new DiscoveryType("ZWAVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscoveryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryType FindValue(string value)
        {
            return FindValue<DiscoveryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryType(string value)
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
        /// Constant CUSTOMER_KEY_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_KEY_ENCRYPTION = new EncryptionType("CUSTOMER_KEY_ENCRYPTION");
        /// <summary>
        /// Constant MANAGED_INTEGRATIONS_DEFAULT_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType MANAGED_INTEGRATIONS_DEFAULT_ENCRYPTION = new EncryptionType("MANAGED_INTEGRATIONS_DEFAULT_ENCRYPTION");

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
        /// Constant LAMBDA for EndpointType
        /// </summary>
        public static readonly EndpointType LAMBDA = new EndpointType("LAMBDA");

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
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ASSOCIATION for EventType
        /// </summary>
        public static readonly EventType ACCOUNT_ASSOCIATION = new EventType("ACCOUNT_ASSOCIATION");
        /// <summary>
        /// Constant CONNECTOR_ASSOCIATION for EventType
        /// </summary>
        public static readonly EventType CONNECTOR_ASSOCIATION = new EventType("CONNECTOR_ASSOCIATION");
        /// <summary>
        /// Constant CONNECTOR_ERROR_REPORT for EventType
        /// </summary>
        public static readonly EventType CONNECTOR_ERROR_REPORT = new EventType("CONNECTOR_ERROR_REPORT");
        /// <summary>
        /// Constant DEVICE_COMMAND for EventType
        /// </summary>
        public static readonly EventType DEVICE_COMMAND = new EventType("DEVICE_COMMAND");
        /// <summary>
        /// Constant DEVICE_COMMAND_REQUEST for EventType
        /// </summary>
        public static readonly EventType DEVICE_COMMAND_REQUEST = new EventType("DEVICE_COMMAND_REQUEST");
        /// <summary>
        /// Constant DEVICE_DISCOVERY_STATUS for EventType
        /// </summary>
        public static readonly EventType DEVICE_DISCOVERY_STATUS = new EventType("DEVICE_DISCOVERY_STATUS");
        /// <summary>
        /// Constant DEVICE_EVENT for EventType
        /// </summary>
        public static readonly EventType DEVICE_EVENT = new EventType("DEVICE_EVENT");
        /// <summary>
        /// Constant DEVICE_LIFE_CYCLE for EventType
        /// </summary>
        public static readonly EventType DEVICE_LIFE_CYCLE = new EventType("DEVICE_LIFE_CYCLE");
        /// <summary>
        /// Constant DEVICE_OTA for EventType
        /// </summary>
        public static readonly EventType DEVICE_OTA = new EventType("DEVICE_OTA");
        /// <summary>
        /// Constant DEVICE_STATE for EventType
        /// </summary>
        public static readonly EventType DEVICE_STATE = new EventType("DEVICE_STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HubNetworkMode.
    /// </summary>
    public class HubNetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant NETWORK_WIDE_EXCLUSION for HubNetworkMode
        /// </summary>
        public static readonly HubNetworkMode NETWORK_WIDE_EXCLUSION = new HubNetworkMode("NETWORK_WIDE_EXCLUSION");
        /// <summary>
        /// Constant STANDARD for HubNetworkMode
        /// </summary>
        public static readonly HubNetworkMode STANDARD = new HubNetworkMode("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HubNetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HubNetworkMode FindValue(string value)
        {
            return FindValue<HubNetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HubNetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LogLevel
        /// </summary>
        public static readonly LogLevel DEBUG = new LogLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant WARN for LogLevel
        /// </summary>
        public static readonly LogLevel WARN = new LogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtaMechanism.
    /// </summary>
    public class OtaMechanism : ConstantClass
    {

        /// <summary>
        /// Constant PUSH for OtaMechanism
        /// </summary>
        public static readonly OtaMechanism PUSH = new OtaMechanism("PUSH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtaMechanism(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtaMechanism FindValue(string value)
        {
            return FindValue<OtaMechanism>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtaMechanism(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtaProtocol.
    /// </summary>
    public class OtaProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for OtaProtocol
        /// </summary>
        public static readonly OtaProtocol HTTP = new OtaProtocol("HTTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtaProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtaProtocol FindValue(string value)
        {
            return FindValue<OtaProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtaProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtaStatus.
    /// </summary>
    public class OtaStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for OtaStatus
        /// </summary>
        public static readonly OtaStatus CANCELED = new OtaStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for OtaStatus
        /// </summary>
        public static readonly OtaStatus COMPLETED = new OtaStatus("COMPLETED");
        /// <summary>
        /// Constant DELETION_IN_PROGRESS for OtaStatus
        /// </summary>
        public static readonly OtaStatus DELETION_IN_PROGRESS = new OtaStatus("DELETION_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for OtaStatus
        /// </summary>
        public static readonly OtaStatus IN_PROGRESS = new OtaStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SCHEDULED for OtaStatus
        /// </summary>
        public static readonly OtaStatus SCHEDULED = new OtaStatus("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtaStatus FindValue(string value)
        {
            return FindValue<OtaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtaTaskExecutionStatus.
    /// </summary>
    public class OtaTaskExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus CANCELED = new OtaTaskExecutionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus FAILED = new OtaTaskExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus IN_PROGRESS = new OtaTaskExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus QUEUED = new OtaTaskExecutionStatus("QUEUED");
        /// <summary>
        /// Constant REJECTED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus REJECTED = new OtaTaskExecutionStatus("REJECTED");
        /// <summary>
        /// Constant REMOVED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus REMOVED = new OtaTaskExecutionStatus("REMOVED");
        /// <summary>
        /// Constant SUCCEEDED for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus SUCCEEDED = new OtaTaskExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for OtaTaskExecutionStatus
        /// </summary>
        public static readonly OtaTaskExecutionStatus TIMED_OUT = new OtaTaskExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtaTaskExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtaTaskExecutionStatus FindValue(string value)
        {
            return FindValue<OtaTaskExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtaTaskExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OtaType.
    /// </summary>
    public class OtaType : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS for OtaType
        /// </summary>
        public static readonly OtaType CONTINUOUS = new OtaType("CONTINUOUS");
        /// <summary>
        /// Constant ONE_TIME for OtaType
        /// </summary>
        public static readonly OtaType ONE_TIME = new OtaType("ONE_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OtaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OtaType FindValue(string value)
        {
            return FindValue<OtaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OtaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningStatus.
    /// </summary>
    public class ProvisioningStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus ACTIVATED = new ProvisioningStatus("ACTIVATED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus DELETE_IN_PROGRESS = new ProvisioningStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus DELETED = new ProvisioningStatus("DELETED");
        /// <summary>
        /// Constant DELETION_FAILED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus DELETION_FAILED = new ProvisioningStatus("DELETION_FAILED");
        /// <summary>
        /// Constant DISCOVERED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus DISCOVERED = new ProvisioningStatus("DISCOVERED");
        /// <summary>
        /// Constant ISOLATED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus ISOLATED = new ProvisioningStatus("ISOLATED");
        /// <summary>
        /// Constant PRE_ASSOCIATED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus PRE_ASSOCIATED = new ProvisioningStatus("PRE_ASSOCIATED");
        /// <summary>
        /// Constant UNASSOCIATED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus UNASSOCIATED = new ProvisioningStatus("UNASSOCIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningStatus FindValue(string value)
        {
            return FindValue<ProvisioningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningType.
    /// </summary>
    public class ProvisioningType : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_PROVISIONING for ProvisioningType
        /// </summary>
        public static readonly ProvisioningType FLEET_PROVISIONING = new ProvisioningType("FLEET_PROVISIONING");
        /// <summary>
        /// Constant JITR for ProvisioningType
        /// </summary>
        public static readonly ProvisioningType JITR = new ProvisioningType("JITR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningType FindValue(string value)
        {
            return FindValue<ProvisioningType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryCriteriaFailureType.
    /// </summary>
    public class RetryCriteriaFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RetryCriteriaFailureType
        /// </summary>
        public static readonly RetryCriteriaFailureType ALL = new RetryCriteriaFailureType("ALL");
        /// <summary>
        /// Constant FAILED for RetryCriteriaFailureType
        /// </summary>
        public static readonly RetryCriteriaFailureType FAILED = new RetryCriteriaFailureType("FAILED");
        /// <summary>
        /// Constant TIMED_OUT for RetryCriteriaFailureType
        /// </summary>
        public static readonly RetryCriteriaFailureType TIMED_OUT = new RetryCriteriaFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryCriteriaFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryCriteriaFailureType FindValue(string value)
        {
            return FindValue<RetryCriteriaFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryCriteriaFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Role.
    /// </summary>
    public class Role : ConstantClass
    {

        /// <summary>
        /// Constant CONTROLLER for Role
        /// </summary>
        public static readonly Role CONTROLLER = new Role("CONTROLLER");
        /// <summary>
        /// Constant DEVICE for Role
        /// </summary>
        public static readonly Role DEVICE = new Role("DEVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Role(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Role FindValue(string value)
        {
            return FindValue<Role>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Role(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchedulingConfigEndBehavior.
    /// </summary>
    public class SchedulingConfigEndBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for SchedulingConfigEndBehavior
        /// </summary>
        public static readonly SchedulingConfigEndBehavior CANCEL = new SchedulingConfigEndBehavior("CANCEL");
        /// <summary>
        /// Constant FORCE_CANCEL for SchedulingConfigEndBehavior
        /// </summary>
        public static readonly SchedulingConfigEndBehavior FORCE_CANCEL = new SchedulingConfigEndBehavior("FORCE_CANCEL");
        /// <summary>
        /// Constant STOP_ROLLOUT for SchedulingConfigEndBehavior
        /// </summary>
        public static readonly SchedulingConfigEndBehavior STOP_ROLLOUT = new SchedulingConfigEndBehavior("STOP_ROLLOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchedulingConfigEndBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchedulingConfigEndBehavior FindValue(string value)
        {
            return FindValue<SchedulingConfigEndBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchedulingConfigEndBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaVersionFormat.
    /// </summary>
    public class SchemaVersionFormat : ConstantClass
    {

        /// <summary>
        /// Constant AWS for SchemaVersionFormat
        /// </summary>
        public static readonly SchemaVersionFormat AWS = new SchemaVersionFormat("AWS");
        /// <summary>
        /// Constant CONNECTOR for SchemaVersionFormat
        /// </summary>
        public static readonly SchemaVersionFormat CONNECTOR = new SchemaVersionFormat("CONNECTOR");
        /// <summary>
        /// Constant ZCL for SchemaVersionFormat
        /// </summary>
        public static readonly SchemaVersionFormat ZCL = new SchemaVersionFormat("ZCL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaVersionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaVersionFormat FindValue(string value)
        {
            return FindValue<SchemaVersionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaVersionFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaVersionType.
    /// </summary>
    public class SchemaVersionType : ConstantClass
    {

        /// <summary>
        /// Constant Capability for SchemaVersionType
        /// </summary>
        public static readonly SchemaVersionType Capability = new SchemaVersionType("capability");
        /// <summary>
        /// Constant Definition for SchemaVersionType
        /// </summary>
        public static readonly SchemaVersionType Definition = new SchemaVersionType("definition");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaVersionType FindValue(string value)
        {
            return FindValue<SchemaVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaVersionVisibility.
    /// </summary>
    public class SchemaVersionVisibility : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for SchemaVersionVisibility
        /// </summary>
        public static readonly SchemaVersionVisibility PRIVATE = new SchemaVersionVisibility("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for SchemaVersionVisibility
        /// </summary>
        public static readonly SchemaVersionVisibility PUBLIC = new SchemaVersionVisibility("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaVersionVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaVersionVisibility FindValue(string value)
        {
            return FindValue<SchemaVersionVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaVersionVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TokenEndpointAuthenticationScheme.
    /// </summary>
    public class TokenEndpointAuthenticationScheme : ConstantClass
    {

        /// <summary>
        /// Constant HTTP_BASIC for TokenEndpointAuthenticationScheme
        /// </summary>
        public static readonly TokenEndpointAuthenticationScheme HTTP_BASIC = new TokenEndpointAuthenticationScheme("HTTP_BASIC");
        /// <summary>
        /// Constant REQUEST_BODY_CREDENTIALS for TokenEndpointAuthenticationScheme
        /// </summary>
        public static readonly TokenEndpointAuthenticationScheme REQUEST_BODY_CREDENTIALS = new TokenEndpointAuthenticationScheme("REQUEST_BODY_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TokenEndpointAuthenticationScheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TokenEndpointAuthenticationScheme FindValue(string value)
        {
            return FindValue<TokenEndpointAuthenticationScheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TokenEndpointAuthenticationScheme(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTWireless
{

    /// <summary>
    /// Constants used for properties of type BatteryLevel.
    /// </summary>
    public class BatteryLevel : ConstantClass
    {

        /// <summary>
        /// Constant Critical for BatteryLevel
        /// </summary>
        public static readonly BatteryLevel Critical = new BatteryLevel("critical");
        /// <summary>
        /// Constant Low for BatteryLevel
        /// </summary>
        public static readonly BatteryLevel Low = new BatteryLevel("low");
        /// <summary>
        /// Constant Normal for BatteryLevel
        /// </summary>
        public static readonly BatteryLevel Normal = new BatteryLevel("normal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatteryLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatteryLevel FindValue(string value)
        {
            return FindValue<BatteryLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatteryLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connected for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus Connected = new ConnectionStatus("Connected");
        /// <summary>
        /// Constant Disconnected for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus Disconnected = new ConnectionStatus("Disconnected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceState.
    /// </summary>
    public class DeviceState : ConstantClass
    {

        /// <summary>
        /// Constant Provisioned for DeviceState
        /// </summary>
        public static readonly DeviceState Provisioned = new DeviceState("Provisioned");
        /// <summary>
        /// Constant RegisteredNotSeen for DeviceState
        /// </summary>
        public static readonly DeviceState RegisteredNotSeen = new DeviceState("RegisteredNotSeen");
        /// <summary>
        /// Constant RegisteredReachable for DeviceState
        /// </summary>
        public static readonly DeviceState RegisteredReachable = new DeviceState("RegisteredReachable");
        /// <summary>
        /// Constant RegisteredUnreachable for DeviceState
        /// </summary>
        public static readonly DeviceState RegisteredUnreachable = new DeviceState("RegisteredUnreachable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceState FindValue(string value)
        {
            return FindValue<DeviceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Event.
    /// </summary>
    public class Event : ConstantClass
    {

        /// <summary>
        /// Constant Ack for Event
        /// </summary>
        public static readonly Event Ack = new Event("ack");
        /// <summary>
        /// Constant Discovered for Event
        /// </summary>
        public static readonly Event Discovered = new Event("discovered");
        /// <summary>
        /// Constant Lost for Event
        /// </summary>
        public static readonly Event Lost = new Event("lost");
        /// <summary>
        /// Constant Nack for Event
        /// </summary>
        public static readonly Event Nack = new Event("nack");
        /// <summary>
        /// Constant Passthrough for Event
        /// </summary>
        public static readonly Event Passthrough = new Event("passthrough");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Event(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Event FindValue(string value)
        {
            return FindValue<Event>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Event(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpressionType.
    /// </summary>
    public class ExpressionType : ConstantClass
    {

        /// <summary>
        /// Constant MqttTopic for ExpressionType
        /// </summary>
        public static readonly ExpressionType MqttTopic = new ExpressionType("MqttTopic");
        /// <summary>
        /// Constant RuleName for ExpressionType
        /// </summary>
        public static readonly ExpressionType RuleName = new ExpressionType("RuleName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpressionType FindValue(string value)
        {
            return FindValue<ExpressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpressionType(string value)
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
        /// Constant DISABLED for LogLevel
        /// </summary>
        public static readonly LogLevel DISABLED = new LogLevel("DISABLED");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");

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
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_COMMAND_ID_GET for MessageType
        /// </summary>
        public static readonly MessageType CUSTOM_COMMAND_ID_GET = new MessageType("CUSTOM_COMMAND_ID_GET");
        /// <summary>
        /// Constant CUSTOM_COMMAND_ID_NOTIFY for MessageType
        /// </summary>
        public static readonly MessageType CUSTOM_COMMAND_ID_NOTIFY = new MessageType("CUSTOM_COMMAND_ID_NOTIFY");
        /// <summary>
        /// Constant CUSTOM_COMMAND_ID_RESP for MessageType
        /// </summary>
        public static readonly MessageType CUSTOM_COMMAND_ID_RESP = new MessageType("CUSTOM_COMMAND_ID_RESP");
        /// <summary>
        /// Constant CUSTOM_COMMAND_ID_SET for MessageType
        /// </summary>
        public static readonly MessageType CUSTOM_COMMAND_ID_SET = new MessageType("CUSTOM_COMMAND_ID_SET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartnerType.
    /// </summary>
    public class PartnerType : ConstantClass
    {

        /// <summary>
        /// Constant Sidewalk for PartnerType
        /// </summary>
        public static readonly PartnerType Sidewalk = new PartnerType("Sidewalk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartnerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartnerType FindValue(string value)
        {
            return FindValue<PartnerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartnerType(string value)
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
        /// Constant Ed25519 for SigningAlg
        /// </summary>
        public static readonly SigningAlg Ed25519 = new SigningAlg("Ed25519");
        /// <summary>
        /// Constant P256r1 for SigningAlg
        /// </summary>
        public static readonly SigningAlg P256r1 = new SigningAlg("P256r1");

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
    /// Constants used for properties of type WirelessDeviceEvent.
    /// </summary>
    public class WirelessDeviceEvent : ConstantClass
    {

        /// <summary>
        /// Constant Downlink_Data for WirelessDeviceEvent
        /// </summary>
        public static readonly WirelessDeviceEvent Downlink_Data = new WirelessDeviceEvent("Downlink_Data");
        /// <summary>
        /// Constant Join for WirelessDeviceEvent
        /// </summary>
        public static readonly WirelessDeviceEvent Join = new WirelessDeviceEvent("Join");
        /// <summary>
        /// Constant Registration for WirelessDeviceEvent
        /// </summary>
        public static readonly WirelessDeviceEvent Registration = new WirelessDeviceEvent("Registration");
        /// <summary>
        /// Constant Rejoin for WirelessDeviceEvent
        /// </summary>
        public static readonly WirelessDeviceEvent Rejoin = new WirelessDeviceEvent("Rejoin");
        /// <summary>
        /// Constant Uplink_Data for WirelessDeviceEvent
        /// </summary>
        public static readonly WirelessDeviceEvent Uplink_Data = new WirelessDeviceEvent("Uplink_Data");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessDeviceEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessDeviceEvent FindValue(string value)
        {
            return FindValue<WirelessDeviceEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessDeviceEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessDeviceIdType.
    /// </summary>
    public class WirelessDeviceIdType : ConstantClass
    {

        /// <summary>
        /// Constant DevEui for WirelessDeviceIdType
        /// </summary>
        public static readonly WirelessDeviceIdType DevEui = new WirelessDeviceIdType("DevEui");
        /// <summary>
        /// Constant SidewalkManufacturingSn for WirelessDeviceIdType
        /// </summary>
        public static readonly WirelessDeviceIdType SidewalkManufacturingSn = new WirelessDeviceIdType("SidewalkManufacturingSn");
        /// <summary>
        /// Constant ThingName for WirelessDeviceIdType
        /// </summary>
        public static readonly WirelessDeviceIdType ThingName = new WirelessDeviceIdType("ThingName");
        /// <summary>
        /// Constant WirelessDeviceId for WirelessDeviceIdType
        /// </summary>
        public static readonly WirelessDeviceIdType WirelessDeviceId = new WirelessDeviceIdType("WirelessDeviceId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessDeviceIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessDeviceIdType FindValue(string value)
        {
            return FindValue<WirelessDeviceIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessDeviceIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessDeviceType.
    /// </summary>
    public class WirelessDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant LoRaWAN for WirelessDeviceType
        /// </summary>
        public static readonly WirelessDeviceType LoRaWAN = new WirelessDeviceType("LoRaWAN");
        /// <summary>
        /// Constant Sidewalk for WirelessDeviceType
        /// </summary>
        public static readonly WirelessDeviceType Sidewalk = new WirelessDeviceType("Sidewalk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessDeviceType FindValue(string value)
        {
            return FindValue<WirelessDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayEvent.
    /// </summary>
    public class WirelessGatewayEvent : ConstantClass
    {

        /// <summary>
        /// Constant Certificate for WirelessGatewayEvent
        /// </summary>
        public static readonly WirelessGatewayEvent Certificate = new WirelessGatewayEvent("Certificate");
        /// <summary>
        /// Constant CUPS_Request for WirelessGatewayEvent
        /// </summary>
        public static readonly WirelessGatewayEvent CUPS_Request = new WirelessGatewayEvent("CUPS_Request");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayEvent FindValue(string value)
        {
            return FindValue<WirelessGatewayEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayIdType.
    /// </summary>
    public class WirelessGatewayIdType : ConstantClass
    {

        /// <summary>
        /// Constant GatewayEui for WirelessGatewayIdType
        /// </summary>
        public static readonly WirelessGatewayIdType GatewayEui = new WirelessGatewayIdType("GatewayEui");
        /// <summary>
        /// Constant ThingName for WirelessGatewayIdType
        /// </summary>
        public static readonly WirelessGatewayIdType ThingName = new WirelessGatewayIdType("ThingName");
        /// <summary>
        /// Constant WirelessGatewayId for WirelessGatewayIdType
        /// </summary>
        public static readonly WirelessGatewayIdType WirelessGatewayId = new WirelessGatewayIdType("WirelessGatewayId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayIdType FindValue(string value)
        {
            return FindValue<WirelessGatewayIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayServiceType.
    /// </summary>
    public class WirelessGatewayServiceType : ConstantClass
    {

        /// <summary>
        /// Constant CUPS for WirelessGatewayServiceType
        /// </summary>
        public static readonly WirelessGatewayServiceType CUPS = new WirelessGatewayServiceType("CUPS");
        /// <summary>
        /// Constant LNS for WirelessGatewayServiceType
        /// </summary>
        public static readonly WirelessGatewayServiceType LNS = new WirelessGatewayServiceType("LNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayServiceType FindValue(string value)
        {
            return FindValue<WirelessGatewayServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayServiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayTaskDefinitionType.
    /// </summary>
    public class WirelessGatewayTaskDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant UPDATE for WirelessGatewayTaskDefinitionType
        /// </summary>
        public static readonly WirelessGatewayTaskDefinitionType UPDATE = new WirelessGatewayTaskDefinitionType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayTaskDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayTaskDefinitionType FindValue(string value)
        {
            return FindValue<WirelessGatewayTaskDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayTaskDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayTaskStatus.
    /// </summary>
    public class WirelessGatewayTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus COMPLETED = new WirelessGatewayTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus FAILED = new WirelessGatewayTaskStatus("FAILED");
        /// <summary>
        /// Constant FIRST_RETRY for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus FIRST_RETRY = new WirelessGatewayTaskStatus("FIRST_RETRY");
        /// <summary>
        /// Constant IN_PROGRESS for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus IN_PROGRESS = new WirelessGatewayTaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus PENDING = new WirelessGatewayTaskStatus("PENDING");
        /// <summary>
        /// Constant SECOND_RETRY for WirelessGatewayTaskStatus
        /// </summary>
        public static readonly WirelessGatewayTaskStatus SECOND_RETRY = new WirelessGatewayTaskStatus("SECOND_RETRY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayTaskStatus FindValue(string value)
        {
            return FindValue<WirelessGatewayTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WirelessGatewayType.
    /// </summary>
    public class WirelessGatewayType : ConstantClass
    {

        /// <summary>
        /// Constant LoRaWAN for WirelessGatewayType
        /// </summary>
        public static readonly WirelessGatewayType LoRaWAN = new WirelessGatewayType("LoRaWAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessGatewayType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessGatewayType FindValue(string value)
        {
            return FindValue<WirelessGatewayType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessGatewayType(string value)
        {
            return FindValue(value);
        }
    }

}
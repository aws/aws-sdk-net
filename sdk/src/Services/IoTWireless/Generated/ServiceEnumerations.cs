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
    /// Constants used for properties of type ApplicationConfigType.
    /// </summary>
    public class ApplicationConfigType : ConstantClass
    {

        /// <summary>
        /// Constant SemtechGeolocation for ApplicationConfigType
        /// </summary>
        public static readonly ApplicationConfigType SemtechGeolocation = new ApplicationConfigType("SemtechGeolocation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationConfigType FindValue(string value)
        {
            return FindValue<ApplicationConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationConfigType(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type DeviceProfileType.
    /// </summary>
    public class DeviceProfileType : ConstantClass
    {

        /// <summary>
        /// Constant LoRaWAN for DeviceProfileType
        /// </summary>
        public static readonly DeviceProfileType LoRaWAN = new DeviceProfileType("LoRaWAN");
        /// <summary>
        /// Constant Sidewalk for DeviceProfileType
        /// </summary>
        public static readonly DeviceProfileType Sidewalk = new DeviceProfileType("Sidewalk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceProfileType FindValue(string value)
        {
            return FindValue<DeviceProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceProfileType(string value)
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
    /// Constants used for properties of type DlClass.
    /// </summary>
    public class DlClass : ConstantClass
    {

        /// <summary>
        /// Constant ClassB for DlClass
        /// </summary>
        public static readonly DlClass ClassB = new DlClass("ClassB");
        /// <summary>
        /// Constant ClassC for DlClass
        /// </summary>
        public static readonly DlClass ClassC = new DlClass("ClassC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DlClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DlClass FindValue(string value)
        {
            return FindValue<DlClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DlClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DownlinkMode.
    /// </summary>
    public class DownlinkMode : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT for DownlinkMode
        /// </summary>
        public static readonly DownlinkMode CONCURRENT = new DownlinkMode("CONCURRENT");
        /// <summary>
        /// Constant SEQUENTIAL for DownlinkMode
        /// </summary>
        public static readonly DownlinkMode SEQUENTIAL = new DownlinkMode("SEQUENTIAL");
        /// <summary>
        /// Constant USING_UPLINK_GATEWAY for DownlinkMode
        /// </summary>
        public static readonly DownlinkMode USING_UPLINK_GATEWAY = new DownlinkMode("USING_UPLINK_GATEWAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DownlinkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DownlinkMode FindValue(string value)
        {
            return FindValue<DownlinkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DownlinkMode(string value)
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
    /// Constants used for properties of type EventNotificationPartnerType.
    /// </summary>
    public class EventNotificationPartnerType : ConstantClass
    {

        /// <summary>
        /// Constant Sidewalk for EventNotificationPartnerType
        /// </summary>
        public static readonly EventNotificationPartnerType Sidewalk = new EventNotificationPartnerType("Sidewalk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventNotificationPartnerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventNotificationPartnerType FindValue(string value)
        {
            return FindValue<EventNotificationPartnerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventNotificationPartnerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventNotificationResourceType.
    /// </summary>
    public class EventNotificationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant SidewalkAccount for EventNotificationResourceType
        /// </summary>
        public static readonly EventNotificationResourceType SidewalkAccount = new EventNotificationResourceType("SidewalkAccount");
        /// <summary>
        /// Constant WirelessDevice for EventNotificationResourceType
        /// </summary>
        public static readonly EventNotificationResourceType WirelessDevice = new EventNotificationResourceType("WirelessDevice");
        /// <summary>
        /// Constant WirelessGateway for EventNotificationResourceType
        /// </summary>
        public static readonly EventNotificationResourceType WirelessGateway = new EventNotificationResourceType("WirelessGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventNotificationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventNotificationResourceType FindValue(string value)
        {
            return FindValue<EventNotificationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventNotificationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventNotificationTopicStatus.
    /// </summary>
    public class EventNotificationTopicStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for EventNotificationTopicStatus
        /// </summary>
        public static readonly EventNotificationTopicStatus Disabled = new EventNotificationTopicStatus("Disabled");
        /// <summary>
        /// Constant Enabled for EventNotificationTopicStatus
        /// </summary>
        public static readonly EventNotificationTopicStatus Enabled = new EventNotificationTopicStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventNotificationTopicStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventNotificationTopicStatus FindValue(string value)
        {
            return FindValue<EventNotificationTopicStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventNotificationTopicStatus(string value)
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
    /// Constants used for properties of type FuotaDeviceStatus.
    /// </summary>
    public class FuotaDeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant FragAlgo_unsupported for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus FragAlgo_unsupported = new FuotaDeviceStatus("FragAlgo_unsupported");
        /// <summary>
        /// Constant FragIndex_unsupported for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus FragIndex_unsupported = new FuotaDeviceStatus("FragIndex_unsupported");
        /// <summary>
        /// Constant Initial for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus Initial = new FuotaDeviceStatus("Initial");
        /// <summary>
        /// Constant MemoryError for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus MemoryError = new FuotaDeviceStatus("MemoryError");
        /// <summary>
        /// Constant MICError for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus MICError = new FuotaDeviceStatus("MICError");
        /// <summary>
        /// Constant MissingFrag for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus MissingFrag = new FuotaDeviceStatus("MissingFrag");
        /// <summary>
        /// Constant Not_enough_memory for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus Not_enough_memory = new FuotaDeviceStatus("Not_enough_memory");
        /// <summary>
        /// Constant Package_Not_Supported for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus Package_Not_Supported = new FuotaDeviceStatus("Package_Not_Supported");
        /// <summary>
        /// Constant SessionCnt_replay for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus SessionCnt_replay = new FuotaDeviceStatus("SessionCnt_replay");
        /// <summary>
        /// Constant Successful for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus Successful = new FuotaDeviceStatus("Successful");
        /// <summary>
        /// Constant Wrong_descriptor for FuotaDeviceStatus
        /// </summary>
        public static readonly FuotaDeviceStatus Wrong_descriptor = new FuotaDeviceStatus("Wrong_descriptor");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FuotaDeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FuotaDeviceStatus FindValue(string value)
        {
            return FindValue<FuotaDeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FuotaDeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FuotaTaskStatus.
    /// </summary>
    public class FuotaTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant Delete_Waiting for FuotaTaskStatus
        /// </summary>
        public static readonly FuotaTaskStatus Delete_Waiting = new FuotaTaskStatus("Delete_Waiting");
        /// <summary>
        /// Constant FuotaDone for FuotaTaskStatus
        /// </summary>
        public static readonly FuotaTaskStatus FuotaDone = new FuotaTaskStatus("FuotaDone");
        /// <summary>
        /// Constant FuotaSession_Waiting for FuotaTaskStatus
        /// </summary>
        public static readonly FuotaTaskStatus FuotaSession_Waiting = new FuotaTaskStatus("FuotaSession_Waiting");
        /// <summary>
        /// Constant In_FuotaSession for FuotaTaskStatus
        /// </summary>
        public static readonly FuotaTaskStatus In_FuotaSession = new FuotaTaskStatus("In_FuotaSession");
        /// <summary>
        /// Constant Pending for FuotaTaskStatus
        /// </summary>
        public static readonly FuotaTaskStatus Pending = new FuotaTaskStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FuotaTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FuotaTaskStatus FindValue(string value)
        {
            return FindValue<FuotaTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FuotaTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentifierType.
    /// </summary>
    public class IdentifierType : ConstantClass
    {

        /// <summary>
        /// Constant DevEui for IdentifierType
        /// </summary>
        public static readonly IdentifierType DevEui = new IdentifierType("DevEui");
        /// <summary>
        /// Constant GatewayEui for IdentifierType
        /// </summary>
        public static readonly IdentifierType GatewayEui = new IdentifierType("GatewayEui");
        /// <summary>
        /// Constant PartnerAccountId for IdentifierType
        /// </summary>
        public static readonly IdentifierType PartnerAccountId = new IdentifierType("PartnerAccountId");
        /// <summary>
        /// Constant WirelessDeviceId for IdentifierType
        /// </summary>
        public static readonly IdentifierType WirelessDeviceId = new IdentifierType("WirelessDeviceId");
        /// <summary>
        /// Constant WirelessGatewayId for IdentifierType
        /// </summary>
        public static readonly IdentifierType WirelessGatewayId = new IdentifierType("WirelessGatewayId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentifierType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentifierType FindValue(string value)
        {
            return FindValue<IdentifierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentifierType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportTaskStatus.
    /// </summary>
    public class ImportTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus COMPLETE = new ImportTaskStatus("COMPLETE");
        /// <summary>
        /// Constant DELETING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus DELETING = new ImportTaskStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus FAILED = new ImportTaskStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus INITIALIZED = new ImportTaskStatus("INITIALIZED");
        /// <summary>
        /// Constant INITIALIZING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus INITIALIZING = new ImportTaskStatus("INITIALIZING");
        /// <summary>
        /// Constant PENDING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus PENDING = new ImportTaskStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportTaskStatus FindValue(string value)
        {
            return FindValue<ImportTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportTaskStatus(string value)
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
    /// Constants used for properties of type OnboardStatus.
    /// </summary>
    public class OnboardStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for OnboardStatus
        /// </summary>
        public static readonly OnboardStatus FAILED = new OnboardStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for OnboardStatus
        /// </summary>
        public static readonly OnboardStatus INITIALIZED = new OnboardStatus("INITIALIZED");
        /// <summary>
        /// Constant ONBOARDED for OnboardStatus
        /// </summary>
        public static readonly OnboardStatus ONBOARDED = new OnboardStatus("ONBOARDED");
        /// <summary>
        /// Constant PENDING for OnboardStatus
        /// </summary>
        public static readonly OnboardStatus PENDING = new OnboardStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnboardStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnboardStatus FindValue(string value)
        {
            return FindValue<OnboardStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnboardStatus(string value)
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
    /// Constants used for properties of type PositionConfigurationFec.
    /// </summary>
    public class PositionConfigurationFec : ConstantClass
    {

        /// <summary>
        /// Constant NONE for PositionConfigurationFec
        /// </summary>
        public static readonly PositionConfigurationFec NONE = new PositionConfigurationFec("NONE");
        /// <summary>
        /// Constant ROSE for PositionConfigurationFec
        /// </summary>
        public static readonly PositionConfigurationFec ROSE = new PositionConfigurationFec("ROSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionConfigurationFec(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionConfigurationFec FindValue(string value)
        {
            return FindValue<PositionConfigurationFec>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionConfigurationFec(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionConfigurationStatus.
    /// </summary>
    public class PositionConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for PositionConfigurationStatus
        /// </summary>
        public static readonly PositionConfigurationStatus Disabled = new PositionConfigurationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for PositionConfigurationStatus
        /// </summary>
        public static readonly PositionConfigurationStatus Enabled = new PositionConfigurationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionConfigurationStatus FindValue(string value)
        {
            return FindValue<PositionConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositioningConfigStatus.
    /// </summary>
    public class PositioningConfigStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for PositioningConfigStatus
        /// </summary>
        public static readonly PositioningConfigStatus Disabled = new PositioningConfigStatus("Disabled");
        /// <summary>
        /// Constant Enabled for PositioningConfigStatus
        /// </summary>
        public static readonly PositioningConfigStatus Enabled = new PositioningConfigStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositioningConfigStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositioningConfigStatus FindValue(string value)
        {
            return FindValue<PositioningConfigStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositioningConfigStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionResourceType.
    /// </summary>
    public class PositionResourceType : ConstantClass
    {

        /// <summary>
        /// Constant WirelessDevice for PositionResourceType
        /// </summary>
        public static readonly PositionResourceType WirelessDevice = new PositionResourceType("WirelessDevice");
        /// <summary>
        /// Constant WirelessGateway for PositionResourceType
        /// </summary>
        public static readonly PositionResourceType WirelessGateway = new PositionResourceType("WirelessGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionResourceType FindValue(string value)
        {
            return FindValue<PositionResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionSolverProvider.
    /// </summary>
    public class PositionSolverProvider : ConstantClass
    {

        /// <summary>
        /// Constant Semtech for PositionSolverProvider
        /// </summary>
        public static readonly PositionSolverProvider Semtech = new PositionSolverProvider("Semtech");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionSolverProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionSolverProvider FindValue(string value)
        {
            return FindValue<PositionSolverProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionSolverProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionSolverType.
    /// </summary>
    public class PositionSolverType : ConstantClass
    {

        /// <summary>
        /// Constant GNSS for PositionSolverType
        /// </summary>
        public static readonly PositionSolverType GNSS = new PositionSolverType("GNSS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionSolverType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionSolverType FindValue(string value)
        {
            return FindValue<PositionSolverType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionSolverType(string value)
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
    /// Constants used for properties of type SupportedRfRegion.
    /// </summary>
    public class SupportedRfRegion : ConstantClass
    {

        /// <summary>
        /// Constant AS9231 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion AS9231 = new SupportedRfRegion("AS923-1");
        /// <summary>
        /// Constant AS9232 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion AS9232 = new SupportedRfRegion("AS923-2");
        /// <summary>
        /// Constant AS9233 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion AS9233 = new SupportedRfRegion("AS923-3");
        /// <summary>
        /// Constant AS9234 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion AS9234 = new SupportedRfRegion("AS923-4");
        /// <summary>
        /// Constant AU915 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion AU915 = new SupportedRfRegion("AU915");
        /// <summary>
        /// Constant CN470 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion CN470 = new SupportedRfRegion("CN470");
        /// <summary>
        /// Constant CN779 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion CN779 = new SupportedRfRegion("CN779");
        /// <summary>
        /// Constant EU433 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion EU433 = new SupportedRfRegion("EU433");
        /// <summary>
        /// Constant EU868 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion EU868 = new SupportedRfRegion("EU868");
        /// <summary>
        /// Constant IN865 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion IN865 = new SupportedRfRegion("IN865");
        /// <summary>
        /// Constant KR920 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion KR920 = new SupportedRfRegion("KR920");
        /// <summary>
        /// Constant RU864 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion RU864 = new SupportedRfRegion("RU864");
        /// <summary>
        /// Constant US915 for SupportedRfRegion
        /// </summary>
        public static readonly SupportedRfRegion US915 = new SupportedRfRegion("US915");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportedRfRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportedRfRegion FindValue(string value)
        {
            return FindValue<SupportedRfRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportedRfRegion(string value)
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
    /// Constants used for properties of type WirelessDeviceFrameInfo.
    /// </summary>
    public class WirelessDeviceFrameInfo : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WirelessDeviceFrameInfo
        /// </summary>
        public static readonly WirelessDeviceFrameInfo DISABLED = new WirelessDeviceFrameInfo("DISABLED");
        /// <summary>
        /// Constant ENABLED for WirelessDeviceFrameInfo
        /// </summary>
        public static readonly WirelessDeviceFrameInfo ENABLED = new WirelessDeviceFrameInfo("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessDeviceFrameInfo(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessDeviceFrameInfo FindValue(string value)
        {
            return FindValue<WirelessDeviceFrameInfo>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessDeviceFrameInfo(string value)
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
    /// Constants used for properties of type WirelessDeviceSidewalkStatus.
    /// </summary>
    public class WirelessDeviceSidewalkStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for WirelessDeviceSidewalkStatus
        /// </summary>
        public static readonly WirelessDeviceSidewalkStatus ACTIVATED = new WirelessDeviceSidewalkStatus("ACTIVATED");
        /// <summary>
        /// Constant PROVISIONED for WirelessDeviceSidewalkStatus
        /// </summary>
        public static readonly WirelessDeviceSidewalkStatus PROVISIONED = new WirelessDeviceSidewalkStatus("PROVISIONED");
        /// <summary>
        /// Constant REGISTERED for WirelessDeviceSidewalkStatus
        /// </summary>
        public static readonly WirelessDeviceSidewalkStatus REGISTERED = new WirelessDeviceSidewalkStatus("REGISTERED");
        /// <summary>
        /// Constant UNKNOWN for WirelessDeviceSidewalkStatus
        /// </summary>
        public static readonly WirelessDeviceSidewalkStatus UNKNOWN = new WirelessDeviceSidewalkStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WirelessDeviceSidewalkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WirelessDeviceSidewalkStatus FindValue(string value)
        {
            return FindValue<WirelessDeviceSidewalkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WirelessDeviceSidewalkStatus(string value)
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
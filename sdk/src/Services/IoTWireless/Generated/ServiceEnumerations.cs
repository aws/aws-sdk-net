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
    /// Constants used for properties of type ExpressionType.
    /// </summary>
    public class ExpressionType : ConstantClass
    {

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
    /// Constants used for properties of type WirelessDeviceIdType.
    /// </summary>
    public class WirelessDeviceIdType : ConstantClass
    {

        /// <summary>
        /// Constant DevEui for WirelessDeviceIdType
        /// </summary>
        public static readonly WirelessDeviceIdType DevEui = new WirelessDeviceIdType("DevEui");
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

}
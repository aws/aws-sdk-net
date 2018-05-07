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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AlexaForBusiness
{

    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus OFFLINE = new ConnectionStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus ONLINE = new ConnectionStatus("ONLINE");

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
    /// Constants used for properties of type DeviceEventType.
    /// </summary>
    public class DeviceEventType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTION_STATUS for DeviceEventType
        /// </summary>
        public static readonly DeviceEventType CONNECTION_STATUS = new DeviceEventType("CONNECTION_STATUS");
        /// <summary>
        /// Constant DEVICE_STATUS for DeviceEventType
        /// </summary>
        public static readonly DeviceEventType DEVICE_STATUS = new DeviceEventType("DEVICE_STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceEventType FindValue(string value)
        {
            return FindValue<DeviceEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceStatus.
    /// </summary>
    public class DeviceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEREGISTERED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus DEREGISTERED = new DeviceStatus("DEREGISTERED");
        /// <summary>
        /// Constant PENDING for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus PENDING = new DeviceStatus("PENDING");
        /// <summary>
        /// Constant READY for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus READY = new DeviceStatus("READY");
        /// <summary>
        /// Constant WAS_OFFLINE for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus WAS_OFFLINE = new DeviceStatus("WAS_OFFLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceStatus FindValue(string value)
        {
            return FindValue<DeviceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceStatusDetailCode.
    /// </summary>
    public class DeviceStatusDetailCode : ConstantClass
    {

        /// <summary>
        /// Constant DEVICE_SOFTWARE_UPDATE_NEEDED for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DEVICE_SOFTWARE_UPDATE_NEEDED = new DeviceStatusDetailCode("DEVICE_SOFTWARE_UPDATE_NEEDED");
        /// <summary>
        /// Constant DEVICE_WAS_OFFLINE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DEVICE_WAS_OFFLINE = new DeviceStatusDetailCode("DEVICE_WAS_OFFLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceStatusDetailCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceStatusDetailCode FindValue(string value)
        {
            return FindValue<DeviceStatusDetailCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceStatusDetailCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DistanceUnit.
    /// </summary>
    public class DistanceUnit : ConstantClass
    {

        /// <summary>
        /// Constant IMPERIAL for DistanceUnit
        /// </summary>
        public static readonly DistanceUnit IMPERIAL = new DistanceUnit("IMPERIAL");
        /// <summary>
        /// Constant METRIC for DistanceUnit
        /// </summary>
        public static readonly DistanceUnit METRIC = new DistanceUnit("METRIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DistanceUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DistanceUnit FindValue(string value)
        {
            return FindValue<DistanceUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DistanceUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnrollmentStatus.
    /// </summary>
    public class EnrollmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEREGISTERING for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus DEREGISTERING = new EnrollmentStatus("DEREGISTERING");
        /// <summary>
        /// Constant DISASSOCIATING for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus DISASSOCIATING = new EnrollmentStatus("DISASSOCIATING");
        /// <summary>
        /// Constant INITIALIZED for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus INITIALIZED = new EnrollmentStatus("INITIALIZED");
        /// <summary>
        /// Constant PENDING for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus PENDING = new EnrollmentStatus("PENDING");
        /// <summary>
        /// Constant REGISTERED for EnrollmentStatus
        /// </summary>
        public static readonly EnrollmentStatus REGISTERED = new EnrollmentStatus("REGISTERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnrollmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnrollmentStatus FindValue(string value)
        {
            return FindValue<EnrollmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnrollmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Feature.
    /// </summary>
    public class Feature : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Feature
        /// </summary>
        public static readonly Feature ALL = new Feature("ALL");
        /// <summary>
        /// Constant BLUETOOTH for Feature
        /// </summary>
        public static readonly Feature BLUETOOTH = new Feature("BLUETOOTH");
        /// <summary>
        /// Constant LISTS for Feature
        /// </summary>
        public static readonly Feature LISTS = new Feature("LISTS");
        /// <summary>
        /// Constant NOTIFICATIONS for Feature
        /// </summary>
        public static readonly Feature NOTIFICATIONS = new Feature("NOTIFICATIONS");
        /// <summary>
        /// Constant SKILLS for Feature
        /// </summary>
        public static readonly Feature SKILLS = new Feature("SKILLS");
        /// <summary>
        /// Constant VOLUME for Feature
        /// </summary>
        public static readonly Feature VOLUME = new Feature("VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Feature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Feature FindValue(string value)
        {
            return FindValue<Feature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Feature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortValue.
    /// </summary>
    public class SortValue : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortValue
        /// </summary>
        public static readonly SortValue ASC = new SortValue("ASC");
        /// <summary>
        /// Constant DESC for SortValue
        /// </summary>
        public static readonly SortValue DESC = new SortValue("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortValue FindValue(string value)
        {
            return FindValue<SortValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemperatureUnit.
    /// </summary>
    public class TemperatureUnit : ConstantClass
    {

        /// <summary>
        /// Constant CELSIUS for TemperatureUnit
        /// </summary>
        public static readonly TemperatureUnit CELSIUS = new TemperatureUnit("CELSIUS");
        /// <summary>
        /// Constant FAHRENHEIT for TemperatureUnit
        /// </summary>
        public static readonly TemperatureUnit FAHRENHEIT = new TemperatureUnit("FAHRENHEIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemperatureUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemperatureUnit FindValue(string value)
        {
            return FindValue<TemperatureUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemperatureUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WakeWord.
    /// </summary>
    public class WakeWord : ConstantClass
    {

        /// <summary>
        /// Constant ALEXA for WakeWord
        /// </summary>
        public static readonly WakeWord ALEXA = new WakeWord("ALEXA");
        /// <summary>
        /// Constant AMAZON for WakeWord
        /// </summary>
        public static readonly WakeWord AMAZON = new WakeWord("AMAZON");
        /// <summary>
        /// Constant COMPUTER for WakeWord
        /// </summary>
        public static readonly WakeWord COMPUTER = new WakeWord("COMPUTER");
        /// <summary>
        /// Constant ECHO for WakeWord
        /// </summary>
        public static readonly WakeWord ECHO = new WakeWord("ECHO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WakeWord(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WakeWord FindValue(string value)
        {
            return FindValue<WakeWord>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WakeWord(string value)
        {
            return FindValue(value);
        }
    }

}
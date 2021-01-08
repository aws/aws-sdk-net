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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AlexaForBusiness
{

    /// <summary>
    /// Constants used for properties of type BusinessReportFailureCode.
    /// </summary>
    public class BusinessReportFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for BusinessReportFailureCode
        /// </summary>
        public static readonly BusinessReportFailureCode ACCESS_DENIED = new BusinessReportFailureCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_FAILURE for BusinessReportFailureCode
        /// </summary>
        public static readonly BusinessReportFailureCode INTERNAL_FAILURE = new BusinessReportFailureCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant NO_SUCH_BUCKET for BusinessReportFailureCode
        /// </summary>
        public static readonly BusinessReportFailureCode NO_SUCH_BUCKET = new BusinessReportFailureCode("NO_SUCH_BUCKET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusinessReportFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusinessReportFailureCode FindValue(string value)
        {
            return FindValue<BusinessReportFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusinessReportFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BusinessReportFormat.
    /// </summary>
    public class BusinessReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for BusinessReportFormat
        /// </summary>
        public static readonly BusinessReportFormat CSV = new BusinessReportFormat("CSV");
        /// <summary>
        /// Constant CSV_ZIP for BusinessReportFormat
        /// </summary>
        public static readonly BusinessReportFormat CSV_ZIP = new BusinessReportFormat("CSV_ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusinessReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusinessReportFormat FindValue(string value)
        {
            return FindValue<BusinessReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusinessReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BusinessReportInterval.
    /// </summary>
    public class BusinessReportInterval : ConstantClass
    {

        /// <summary>
        /// Constant ONE_DAY for BusinessReportInterval
        /// </summary>
        public static readonly BusinessReportInterval ONE_DAY = new BusinessReportInterval("ONE_DAY");
        /// <summary>
        /// Constant ONE_WEEK for BusinessReportInterval
        /// </summary>
        public static readonly BusinessReportInterval ONE_WEEK = new BusinessReportInterval("ONE_WEEK");
        /// <summary>
        /// Constant THIRTY_DAYS for BusinessReportInterval
        /// </summary>
        public static readonly BusinessReportInterval THIRTY_DAYS = new BusinessReportInterval("THIRTY_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusinessReportInterval(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusinessReportInterval FindValue(string value)
        {
            return FindValue<BusinessReportInterval>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusinessReportInterval(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BusinessReportStatus.
    /// </summary>
    public class BusinessReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BusinessReportStatus
        /// </summary>
        public static readonly BusinessReportStatus FAILED = new BusinessReportStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for BusinessReportStatus
        /// </summary>
        public static readonly BusinessReportStatus RUNNING = new BusinessReportStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for BusinessReportStatus
        /// </summary>
        public static readonly BusinessReportStatus SUCCEEDED = new BusinessReportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BusinessReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BusinessReportStatus FindValue(string value)
        {
            return FindValue<BusinessReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BusinessReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommsProtocol.
    /// </summary>
    public class CommsProtocol : ConstantClass
    {

        /// <summary>
        /// Constant H323 for CommsProtocol
        /// </summary>
        public static readonly CommsProtocol H323 = new CommsProtocol("H323");
        /// <summary>
        /// Constant SIP for CommsProtocol
        /// </summary>
        public static readonly CommsProtocol SIP = new CommsProtocol("SIP");
        /// <summary>
        /// Constant SIPS for CommsProtocol
        /// </summary>
        public static readonly CommsProtocol SIPS = new CommsProtocol("SIPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommsProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommsProtocol FindValue(string value)
        {
            return FindValue<CommsProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommsProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConferenceProviderType.
    /// </summary>
    public class ConferenceProviderType : ConstantClass
    {

        /// <summary>
        /// Constant BLUEJEANS for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType BLUEJEANS = new ConferenceProviderType("BLUEJEANS");
        /// <summary>
        /// Constant CHIME for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType CHIME = new ConferenceProviderType("CHIME");
        /// <summary>
        /// Constant CUSTOM for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType CUSTOM = new ConferenceProviderType("CUSTOM");
        /// <summary>
        /// Constant FUZE for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType FUZE = new ConferenceProviderType("FUZE");
        /// <summary>
        /// Constant GOOGLE_HANGOUTS for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType GOOGLE_HANGOUTS = new ConferenceProviderType("GOOGLE_HANGOUTS");
        /// <summary>
        /// Constant POLYCOM for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType POLYCOM = new ConferenceProviderType("POLYCOM");
        /// <summary>
        /// Constant RINGCENTRAL for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType RINGCENTRAL = new ConferenceProviderType("RINGCENTRAL");
        /// <summary>
        /// Constant SKYPE_FOR_BUSINESS for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType SKYPE_FOR_BUSINESS = new ConferenceProviderType("SKYPE_FOR_BUSINESS");
        /// <summary>
        /// Constant WEBEX for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType WEBEX = new ConferenceProviderType("WEBEX");
        /// <summary>
        /// Constant ZOOM for ConferenceProviderType
        /// </summary>
        public static readonly ConferenceProviderType ZOOM = new ConferenceProviderType("ZOOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConferenceProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConferenceProviderType FindValue(string value)
        {
            return FindValue<ConferenceProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConferenceProviderType(string value)
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
        /// Constant FAILED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus FAILED = new DeviceStatus("FAILED");
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
        /// Constant ASSOCIATION_REJECTION for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode ASSOCIATION_REJECTION = new DeviceStatusDetailCode("ASSOCIATION_REJECTION");
        /// <summary>
        /// Constant AUTHENTICATION_FAILURE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode AUTHENTICATION_FAILURE = new DeviceStatusDetailCode("AUTHENTICATION_FAILURE");
        /// <summary>
        /// Constant CERTIFICATE_AUTHORITY_ACCESS_DENIED for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode CERTIFICATE_AUTHORITY_ACCESS_DENIED = new DeviceStatusDetailCode("CERTIFICATE_AUTHORITY_ACCESS_DENIED");
        /// <summary>
        /// Constant CERTIFICATE_ISSUING_LIMIT_EXCEEDED for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode CERTIFICATE_ISSUING_LIMIT_EXCEEDED = new DeviceStatusDetailCode("CERTIFICATE_ISSUING_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant CREDENTIALS_ACCESS_FAILURE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode CREDENTIALS_ACCESS_FAILURE = new DeviceStatusDetailCode("CREDENTIALS_ACCESS_FAILURE");
        /// <summary>
        /// Constant DEVICE_SOFTWARE_UPDATE_NEEDED for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DEVICE_SOFTWARE_UPDATE_NEEDED = new DeviceStatusDetailCode("DEVICE_SOFTWARE_UPDATE_NEEDED");
        /// <summary>
        /// Constant DEVICE_WAS_OFFLINE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DEVICE_WAS_OFFLINE = new DeviceStatusDetailCode("DEVICE_WAS_OFFLINE");
        /// <summary>
        /// Constant DHCP_FAILURE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DHCP_FAILURE = new DeviceStatusDetailCode("DHCP_FAILURE");
        /// <summary>
        /// Constant DNS_FAILURE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode DNS_FAILURE = new DeviceStatusDetailCode("DNS_FAILURE");
        /// <summary>
        /// Constant INTERNET_UNAVAILABLE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode INTERNET_UNAVAILABLE = new DeviceStatusDetailCode("INTERNET_UNAVAILABLE");
        /// <summary>
        /// Constant INVALID_CERTIFICATE_AUTHORITY for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode INVALID_CERTIFICATE_AUTHORITY = new DeviceStatusDetailCode("INVALID_CERTIFICATE_AUTHORITY");
        /// <summary>
        /// Constant INVALID_PASSWORD_STATE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode INVALID_PASSWORD_STATE = new DeviceStatusDetailCode("INVALID_PASSWORD_STATE");
        /// <summary>
        /// Constant NETWORK_PROFILE_NOT_FOUND for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode NETWORK_PROFILE_NOT_FOUND = new DeviceStatusDetailCode("NETWORK_PROFILE_NOT_FOUND");
        /// <summary>
        /// Constant PASSWORD_MANAGER_ACCESS_DENIED for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode PASSWORD_MANAGER_ACCESS_DENIED = new DeviceStatusDetailCode("PASSWORD_MANAGER_ACCESS_DENIED");
        /// <summary>
        /// Constant PASSWORD_NOT_FOUND for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode PASSWORD_NOT_FOUND = new DeviceStatusDetailCode("PASSWORD_NOT_FOUND");
        /// <summary>
        /// Constant TLS_VERSION_MISMATCH for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode TLS_VERSION_MISMATCH = new DeviceStatusDetailCode("TLS_VERSION_MISMATCH");
        /// <summary>
        /// Constant UNKNOWN_FAILURE for DeviceStatusDetailCode
        /// </summary>
        public static readonly DeviceStatusDetailCode UNKNOWN_FAILURE = new DeviceStatusDetailCode("UNKNOWN_FAILURE");

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
    /// Constants used for properties of type DeviceUsageType.
    /// </summary>
    public class DeviceUsageType : ConstantClass
    {

        /// <summary>
        /// Constant VOICE for DeviceUsageType
        /// </summary>
        public static readonly DeviceUsageType VOICE = new DeviceUsageType("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceUsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceUsageType FindValue(string value)
        {
            return FindValue<DeviceUsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceUsageType(string value)
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
    /// Constants used for properties of type EnablementType.
    /// </summary>
    public class EnablementType : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for EnablementType
        /// </summary>
        public static readonly EnablementType ENABLED = new EnablementType("ENABLED");
        /// <summary>
        /// Constant PENDING for EnablementType
        /// </summary>
        public static readonly EnablementType PENDING = new EnablementType("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnablementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnablementType FindValue(string value)
        {
            return FindValue<EnablementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnablementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnablementTypeFilter.
    /// </summary>
    public class EnablementTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for EnablementTypeFilter
        /// </summary>
        public static readonly EnablementTypeFilter ENABLED = new EnablementTypeFilter("ENABLED");
        /// <summary>
        /// Constant PENDING for EnablementTypeFilter
        /// </summary>
        public static readonly EnablementTypeFilter PENDING = new EnablementTypeFilter("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnablementTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnablementTypeFilter FindValue(string value)
        {
            return FindValue<EnablementTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnablementTypeFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndOfMeetingReminderType.
    /// </summary>
    public class EndOfMeetingReminderType : ConstantClass
    {

        /// <summary>
        /// Constant ANNOUNCEMENT_TIME_CHECK for EndOfMeetingReminderType
        /// </summary>
        public static readonly EndOfMeetingReminderType ANNOUNCEMENT_TIME_CHECK = new EndOfMeetingReminderType("ANNOUNCEMENT_TIME_CHECK");
        /// <summary>
        /// Constant ANNOUNCEMENT_VARIABLE_TIME_LEFT for EndOfMeetingReminderType
        /// </summary>
        public static readonly EndOfMeetingReminderType ANNOUNCEMENT_VARIABLE_TIME_LEFT = new EndOfMeetingReminderType("ANNOUNCEMENT_VARIABLE_TIME_LEFT");
        /// <summary>
        /// Constant CHIME for EndOfMeetingReminderType
        /// </summary>
        public static readonly EndOfMeetingReminderType CHIME = new EndOfMeetingReminderType("CHIME");
        /// <summary>
        /// Constant KNOCK for EndOfMeetingReminderType
        /// </summary>
        public static readonly EndOfMeetingReminderType KNOCK = new EndOfMeetingReminderType("KNOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndOfMeetingReminderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndOfMeetingReminderType FindValue(string value)
        {
            return FindValue<EndOfMeetingReminderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndOfMeetingReminderType(string value)
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
        /// Constant NETWORK_PROFILE for Feature
        /// </summary>
        public static readonly Feature NETWORK_PROFILE = new Feature("NETWORK_PROFILE");
        /// <summary>
        /// Constant NOTIFICATIONS for Feature
        /// </summary>
        public static readonly Feature NOTIFICATIONS = new Feature("NOTIFICATIONS");
        /// <summary>
        /// Constant SETTINGS for Feature
        /// </summary>
        public static readonly Feature SETTINGS = new Feature("SETTINGS");
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
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for Locale
        /// </summary>
        public static readonly Locale EnUS = new Locale("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Locale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkEapMethod.
    /// </summary>
    public class NetworkEapMethod : ConstantClass
    {

        /// <summary>
        /// Constant EAP_TLS for NetworkEapMethod
        /// </summary>
        public static readonly NetworkEapMethod EAP_TLS = new NetworkEapMethod("EAP_TLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkEapMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkEapMethod FindValue(string value)
        {
            return FindValue<NetworkEapMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkEapMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkSecurityType.
    /// </summary>
    public class NetworkSecurityType : ConstantClass
    {

        /// <summary>
        /// Constant OPEN for NetworkSecurityType
        /// </summary>
        public static readonly NetworkSecurityType OPEN = new NetworkSecurityType("OPEN");
        /// <summary>
        /// Constant WEP for NetworkSecurityType
        /// </summary>
        public static readonly NetworkSecurityType WEP = new NetworkSecurityType("WEP");
        /// <summary>
        /// Constant WPA_PSK for NetworkSecurityType
        /// </summary>
        public static readonly NetworkSecurityType WPA_PSK = new NetworkSecurityType("WPA_PSK");
        /// <summary>
        /// Constant WPA2_ENTERPRISE for NetworkSecurityType
        /// </summary>
        public static readonly NetworkSecurityType WPA2_ENTERPRISE = new NetworkSecurityType("WPA2_ENTERPRISE");
        /// <summary>
        /// Constant WPA2_PSK for NetworkSecurityType
        /// </summary>
        public static readonly NetworkSecurityType WPA2_PSK = new NetworkSecurityType("WPA2_PSK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkSecurityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkSecurityType FindValue(string value)
        {
            return FindValue<NetworkSecurityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkSecurityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberType.
    /// </summary>
    public class PhoneNumberType : ConstantClass
    {

        /// <summary>
        /// Constant HOME for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType HOME = new PhoneNumberType("HOME");
        /// <summary>
        /// Constant MOBILE for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType MOBILE = new PhoneNumberType("MOBILE");
        /// <summary>
        /// Constant WORK for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType WORK = new PhoneNumberType("WORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberType FindValue(string value)
        {
            return FindValue<PhoneNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequirePin.
    /// </summary>
    public class RequirePin : ConstantClass
    {

        /// <summary>
        /// Constant NO for RequirePin
        /// </summary>
        public static readonly RequirePin NO = new RequirePin("NO");
        /// <summary>
        /// Constant OPTIONAL for RequirePin
        /// </summary>
        public static readonly RequirePin OPTIONAL = new RequirePin("OPTIONAL");
        /// <summary>
        /// Constant YES for RequirePin
        /// </summary>
        public static readonly RequirePin YES = new RequirePin("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequirePin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequirePin FindValue(string value)
        {
            return FindValue<RequirePin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequirePin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SipType.
    /// </summary>
    public class SipType : ConstantClass
    {

        /// <summary>
        /// Constant WORK for SipType
        /// </summary>
        public static readonly SipType WORK = new SipType("WORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SipType FindValue(string value)
        {
            return FindValue<SipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SkillType.
    /// </summary>
    public class SkillType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for SkillType
        /// </summary>
        public static readonly SkillType PRIVATE = new SkillType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for SkillType
        /// </summary>
        public static readonly SkillType PUBLIC = new SkillType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SkillType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SkillType FindValue(string value)
        {
            return FindValue<SkillType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SkillType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SkillTypeFilter.
    /// </summary>
    public class SkillTypeFilter : ConstantClass
    {

        /// <summary>
        /// Constant ALL for SkillTypeFilter
        /// </summary>
        public static readonly SkillTypeFilter ALL = new SkillTypeFilter("ALL");
        /// <summary>
        /// Constant PRIVATE for SkillTypeFilter
        /// </summary>
        public static readonly SkillTypeFilter PRIVATE = new SkillTypeFilter("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for SkillTypeFilter
        /// </summary>
        public static readonly SkillTypeFilter PUBLIC = new SkillTypeFilter("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SkillTypeFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SkillTypeFilter FindValue(string value)
        {
            return FindValue<SkillTypeFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SkillTypeFilter(string value)
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
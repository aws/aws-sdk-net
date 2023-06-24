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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Panorama
{

    /// <summary>
    /// Constants used for properties of type ApplicationInstanceHealthStatus.
    /// </summary>
    public class ApplicationInstanceHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for ApplicationInstanceHealthStatus
        /// </summary>
        public static readonly ApplicationInstanceHealthStatus ERROR = new ApplicationInstanceHealthStatus("ERROR");
        /// <summary>
        /// Constant NOT_AVAILABLE for ApplicationInstanceHealthStatus
        /// </summary>
        public static readonly ApplicationInstanceHealthStatus NOT_AVAILABLE = new ApplicationInstanceHealthStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant RUNNING for ApplicationInstanceHealthStatus
        /// </summary>
        public static readonly ApplicationInstanceHealthStatus RUNNING = new ApplicationInstanceHealthStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationInstanceHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationInstanceHealthStatus FindValue(string value)
        {
            return FindValue<ApplicationInstanceHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationInstanceHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationInstanceStatus.
    /// </summary>
    public class ApplicationInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYMENT_ERROR for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_ERROR = new ApplicationInstanceStatus("DEPLOYMENT_ERROR");
        /// <summary>
        /// Constant DEPLOYMENT_FAILED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_FAILED = new ApplicationInstanceStatus("DEPLOYMENT_FAILED");
        /// <summary>
        /// Constant DEPLOYMENT_IN_PROGRESS for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_IN_PROGRESS = new ApplicationInstanceStatus("DEPLOYMENT_IN_PROGRESS");
        /// <summary>
        /// Constant DEPLOYMENT_PENDING for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_PENDING = new ApplicationInstanceStatus("DEPLOYMENT_PENDING");
        /// <summary>
        /// Constant DEPLOYMENT_REQUESTED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_REQUESTED = new ApplicationInstanceStatus("DEPLOYMENT_REQUESTED");
        /// <summary>
        /// Constant DEPLOYMENT_SUCCEEDED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus DEPLOYMENT_SUCCEEDED = new ApplicationInstanceStatus("DEPLOYMENT_SUCCEEDED");
        /// <summary>
        /// Constant REMOVAL_FAILED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus REMOVAL_FAILED = new ApplicationInstanceStatus("REMOVAL_FAILED");
        /// <summary>
        /// Constant REMOVAL_IN_PROGRESS for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus REMOVAL_IN_PROGRESS = new ApplicationInstanceStatus("REMOVAL_IN_PROGRESS");
        /// <summary>
        /// Constant REMOVAL_PENDING for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus REMOVAL_PENDING = new ApplicationInstanceStatus("REMOVAL_PENDING");
        /// <summary>
        /// Constant REMOVAL_REQUESTED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus REMOVAL_REQUESTED = new ApplicationInstanceStatus("REMOVAL_REQUESTED");
        /// <summary>
        /// Constant REMOVAL_SUCCEEDED for ApplicationInstanceStatus
        /// </summary>
        public static readonly ApplicationInstanceStatus REMOVAL_SUCCEEDED = new ApplicationInstanceStatus("REMOVAL_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationInstanceStatus FindValue(string value)
        {
            return FindValue<ApplicationInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant DHCP for ConnectionType
        /// </summary>
        public static readonly ConnectionType DHCP = new ConnectionType("DHCP");
        /// <summary>
        /// Constant STATIC_IP for ConnectionType
        /// </summary>
        public static readonly ConnectionType STATIC_IP = new ConnectionType("STATIC_IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredState.
    /// </summary>
    public class DesiredState : ConstantClass
    {

        /// <summary>
        /// Constant REMOVED for DesiredState
        /// </summary>
        public static readonly DesiredState REMOVED = new DesiredState("REMOVED");
        /// <summary>
        /// Constant RUNNING for DesiredState
        /// </summary>
        public static readonly DesiredState RUNNING = new DesiredState("RUNNING");
        /// <summary>
        /// Constant STOPPED for DesiredState
        /// </summary>
        public static readonly DesiredState STOPPED = new DesiredState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredState FindValue(string value)
        {
            return FindValue<DesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceAggregatedStatus.
    /// </summary>
    public class DeviceAggregatedStatus : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_PROVISIONING for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus AWAITING_PROVISIONING = new DeviceAggregatedStatus("AWAITING_PROVISIONING");
        /// <summary>
        /// Constant DELETING for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus DELETING = new DeviceAggregatedStatus("DELETING");
        /// <summary>
        /// Constant ERROR for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus ERROR = new DeviceAggregatedStatus("ERROR");
        /// <summary>
        /// Constant FAILED for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus FAILED = new DeviceAggregatedStatus("FAILED");
        /// <summary>
        /// Constant LEASE_EXPIRED for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus LEASE_EXPIRED = new DeviceAggregatedStatus("LEASE_EXPIRED");
        /// <summary>
        /// Constant OFFLINE for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus OFFLINE = new DeviceAggregatedStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus ONLINE = new DeviceAggregatedStatus("ONLINE");
        /// <summary>
        /// Constant PENDING for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus PENDING = new DeviceAggregatedStatus("PENDING");
        /// <summary>
        /// Constant REBOOTING for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus REBOOTING = new DeviceAggregatedStatus("REBOOTING");
        /// <summary>
        /// Constant UPDATE_NEEDED for DeviceAggregatedStatus
        /// </summary>
        public static readonly DeviceAggregatedStatus UPDATE_NEEDED = new DeviceAggregatedStatus("UPDATE_NEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceAggregatedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceAggregatedStatus FindValue(string value)
        {
            return FindValue<DeviceAggregatedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceAggregatedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceBrand.
    /// </summary>
    public class DeviceBrand : ConstantClass
    {

        /// <summary>
        /// Constant AWS_PANORAMA for DeviceBrand
        /// </summary>
        public static readonly DeviceBrand AWS_PANORAMA = new DeviceBrand("AWS_PANORAMA");
        /// <summary>
        /// Constant LENOVO for DeviceBrand
        /// </summary>
        public static readonly DeviceBrand LENOVO = new DeviceBrand("LENOVO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceBrand(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceBrand FindValue(string value)
        {
            return FindValue<DeviceBrand>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceBrand(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceConnectionStatus.
    /// </summary>
    public class DeviceConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AWAITING_CREDENTIALS for DeviceConnectionStatus
        /// </summary>
        public static readonly DeviceConnectionStatus AWAITING_CREDENTIALS = new DeviceConnectionStatus("AWAITING_CREDENTIALS");
        /// <summary>
        /// Constant ERROR for DeviceConnectionStatus
        /// </summary>
        public static readonly DeviceConnectionStatus ERROR = new DeviceConnectionStatus("ERROR");
        /// <summary>
        /// Constant NOT_AVAILABLE for DeviceConnectionStatus
        /// </summary>
        public static readonly DeviceConnectionStatus NOT_AVAILABLE = new DeviceConnectionStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant OFFLINE for DeviceConnectionStatus
        /// </summary>
        public static readonly DeviceConnectionStatus OFFLINE = new DeviceConnectionStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for DeviceConnectionStatus
        /// </summary>
        public static readonly DeviceConnectionStatus ONLINE = new DeviceConnectionStatus("ONLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceConnectionStatus FindValue(string value)
        {
            return FindValue<DeviceConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceReportedStatus.
    /// </summary>
    public class DeviceReportedStatus : ConstantClass
    {

        /// <summary>
        /// Constant INSTALL_ERROR for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus INSTALL_ERROR = new DeviceReportedStatus("INSTALL_ERROR");
        /// <summary>
        /// Constant INSTALL_IN_PROGRESS for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus INSTALL_IN_PROGRESS = new DeviceReportedStatus("INSTALL_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_ERROR for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus LAUNCH_ERROR = new DeviceReportedStatus("LAUNCH_ERROR");
        /// <summary>
        /// Constant LAUNCHED for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus LAUNCHED = new DeviceReportedStatus("LAUNCHED");
        /// <summary>
        /// Constant REMOVAL_FAILED for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus REMOVAL_FAILED = new DeviceReportedStatus("REMOVAL_FAILED");
        /// <summary>
        /// Constant REMOVAL_IN_PROGRESS for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus REMOVAL_IN_PROGRESS = new DeviceReportedStatus("REMOVAL_IN_PROGRESS");
        /// <summary>
        /// Constant RUNNING for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus RUNNING = new DeviceReportedStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus STARTING = new DeviceReportedStatus("STARTING");
        /// <summary>
        /// Constant STOP_ERROR for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus STOP_ERROR = new DeviceReportedStatus("STOP_ERROR");
        /// <summary>
        /// Constant STOPPED for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus STOPPED = new DeviceReportedStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for DeviceReportedStatus
        /// </summary>
        public static readonly DeviceReportedStatus STOPPING = new DeviceReportedStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceReportedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceReportedStatus FindValue(string value)
        {
            return FindValue<DeviceReportedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceReportedStatus(string value)
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
        /// Constant AWAITING_PROVISIONING for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus AWAITING_PROVISIONING = new DeviceStatus("AWAITING_PROVISIONING");
        /// <summary>
        /// Constant DELETING for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus DELETING = new DeviceStatus("DELETING");
        /// <summary>
        /// Constant ERROR for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus ERROR = new DeviceStatus("ERROR");
        /// <summary>
        /// Constant FAILED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus FAILED = new DeviceStatus("FAILED");
        /// <summary>
        /// Constant PENDING for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus PENDING = new DeviceStatus("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for DeviceStatus
        /// </summary>
        public static readonly DeviceStatus SUCCEEDED = new DeviceStatus("SUCCEEDED");

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
    /// Constants used for properties of type DeviceType.
    /// </summary>
    public class DeviceType : ConstantClass
    {

        /// <summary>
        /// Constant PANORAMA_APPLIANCE for DeviceType
        /// </summary>
        public static readonly DeviceType PANORAMA_APPLIANCE = new DeviceType("PANORAMA_APPLIANCE");
        /// <summary>
        /// Constant PANORAMA_APPLIANCE_DEVELOPER_KIT for DeviceType
        /// </summary>
        public static readonly DeviceType PANORAMA_APPLIANCE_DEVELOPER_KIT = new DeviceType("PANORAMA_APPLIANCE_DEVELOPER_KIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobResourceType.
    /// </summary>
    public class JobResourceType : ConstantClass
    {

        /// <summary>
        /// Constant PACKAGE for JobResourceType
        /// </summary>
        public static readonly JobResourceType PACKAGE = new JobResourceType("PACKAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobResourceType FindValue(string value)
        {
            return FindValue<JobResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant OTA for JobType
        /// </summary>
        public static readonly JobType OTA = new JobType("OTA");
        /// <summary>
        /// Constant REBOOT for JobType
        /// </summary>
        public static readonly JobType REBOOT = new JobType("REBOOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListDevicesSortBy.
    /// </summary>
    public class ListDevicesSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIME for ListDevicesSortBy
        /// </summary>
        public static readonly ListDevicesSortBy CREATED_TIME = new ListDevicesSortBy("CREATED_TIME");
        /// <summary>
        /// Constant DEVICE_AGGREGATED_STATUS for ListDevicesSortBy
        /// </summary>
        public static readonly ListDevicesSortBy DEVICE_AGGREGATED_STATUS = new ListDevicesSortBy("DEVICE_AGGREGATED_STATUS");
        /// <summary>
        /// Constant DEVICE_ID for ListDevicesSortBy
        /// </summary>
        public static readonly ListDevicesSortBy DEVICE_ID = new ListDevicesSortBy("DEVICE_ID");
        /// <summary>
        /// Constant NAME for ListDevicesSortBy
        /// </summary>
        public static readonly ListDevicesSortBy NAME = new ListDevicesSortBy("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListDevicesSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListDevicesSortBy FindValue(string value)
        {
            return FindValue<ListDevicesSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListDevicesSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectionStatus.
    /// </summary>
    public class NetworkConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for NetworkConnectionStatus
        /// </summary>
        public static readonly NetworkConnectionStatus CONNECTED = new NetworkConnectionStatus("CONNECTED");
        /// <summary>
        /// Constant CONNECTING for NetworkConnectionStatus
        /// </summary>
        public static readonly NetworkConnectionStatus CONNECTING = new NetworkConnectionStatus("CONNECTING");
        /// <summary>
        /// Constant NOT_CONNECTED for NetworkConnectionStatus
        /// </summary>
        public static readonly NetworkConnectionStatus NOT_CONNECTED = new NetworkConnectionStatus("NOT_CONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectionStatus FindValue(string value)
        {
            return FindValue<NetworkConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeCategory.
    /// </summary>
    public class NodeCategory : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS_LOGIC for NodeCategory
        /// </summary>
        public static readonly NodeCategory BUSINESS_LOGIC = new NodeCategory("BUSINESS_LOGIC");
        /// <summary>
        /// Constant MEDIA_SINK for NodeCategory
        /// </summary>
        public static readonly NodeCategory MEDIA_SINK = new NodeCategory("MEDIA_SINK");
        /// <summary>
        /// Constant MEDIA_SOURCE for NodeCategory
        /// </summary>
        public static readonly NodeCategory MEDIA_SOURCE = new NodeCategory("MEDIA_SOURCE");
        /// <summary>
        /// Constant ML_MODEL for NodeCategory
        /// </summary>
        public static readonly NodeCategory ML_MODEL = new NodeCategory("ML_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeCategory FindValue(string value)
        {
            return FindValue<NodeCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeFromTemplateJobStatus.
    /// </summary>
    public class NodeFromTemplateJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for NodeFromTemplateJobStatus
        /// </summary>
        public static readonly NodeFromTemplateJobStatus FAILED = new NodeFromTemplateJobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for NodeFromTemplateJobStatus
        /// </summary>
        public static readonly NodeFromTemplateJobStatus PENDING = new NodeFromTemplateJobStatus("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for NodeFromTemplateJobStatus
        /// </summary>
        public static readonly NodeFromTemplateJobStatus SUCCEEDED = new NodeFromTemplateJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeFromTemplateJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeFromTemplateJobStatus FindValue(string value)
        {
            return FindValue<NodeFromTemplateJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeFromTemplateJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeInstanceStatus.
    /// </summary>
    public class NodeInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for NodeInstanceStatus
        /// </summary>
        public static readonly NodeInstanceStatus ERROR = new NodeInstanceStatus("ERROR");
        /// <summary>
        /// Constant NOT_AVAILABLE for NodeInstanceStatus
        /// </summary>
        public static readonly NodeInstanceStatus NOT_AVAILABLE = new NodeInstanceStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant PAUSED for NodeInstanceStatus
        /// </summary>
        public static readonly NodeInstanceStatus PAUSED = new NodeInstanceStatus("PAUSED");
        /// <summary>
        /// Constant RUNNING for NodeInstanceStatus
        /// </summary>
        public static readonly NodeInstanceStatus RUNNING = new NodeInstanceStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeInstanceStatus FindValue(string value)
        {
            return FindValue<NodeInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeSignalValue.
    /// </summary>
    public class NodeSignalValue : ConstantClass
    {

        /// <summary>
        /// Constant PAUSE for NodeSignalValue
        /// </summary>
        public static readonly NodeSignalValue PAUSE = new NodeSignalValue("PAUSE");
        /// <summary>
        /// Constant RESUME for NodeSignalValue
        /// </summary>
        public static readonly NodeSignalValue RESUME = new NodeSignalValue("RESUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeSignalValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeSignalValue FindValue(string value)
        {
            return FindValue<NodeSignalValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeSignalValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageImportJobStatus.
    /// </summary>
    public class PackageImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for PackageImportJobStatus
        /// </summary>
        public static readonly PackageImportJobStatus FAILED = new PackageImportJobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for PackageImportJobStatus
        /// </summary>
        public static readonly PackageImportJobStatus PENDING = new PackageImportJobStatus("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for PackageImportJobStatus
        /// </summary>
        public static readonly PackageImportJobStatus SUCCEEDED = new PackageImportJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageImportJobStatus FindValue(string value)
        {
            return FindValue<PackageImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageImportJobType.
    /// </summary>
    public class PackageImportJobType : ConstantClass
    {

        /// <summary>
        /// Constant MARKETPLACE_NODE_PACKAGE_VERSION for PackageImportJobType
        /// </summary>
        public static readonly PackageImportJobType MARKETPLACE_NODE_PACKAGE_VERSION = new PackageImportJobType("MARKETPLACE_NODE_PACKAGE_VERSION");
        /// <summary>
        /// Constant NODE_PACKAGE_VERSION for PackageImportJobType
        /// </summary>
        public static readonly PackageImportJobType NODE_PACKAGE_VERSION = new PackageImportJobType("NODE_PACKAGE_VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageImportJobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageImportJobType FindValue(string value)
        {
            return FindValue<PackageImportJobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageImportJobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageVersionStatus.
    /// </summary>
    public class PackageVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus DELETING = new PackageVersionStatus("DELETING");
        /// <summary>
        /// Constant FAILED for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus FAILED = new PackageVersionStatus("FAILED");
        /// <summary>
        /// Constant REGISTER_COMPLETED for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus REGISTER_COMPLETED = new PackageVersionStatus("REGISTER_COMPLETED");
        /// <summary>
        /// Constant REGISTER_PENDING for PackageVersionStatus
        /// </summary>
        public static readonly PackageVersionStatus REGISTER_PENDING = new PackageVersionStatus("REGISTER_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageVersionStatus FindValue(string value)
        {
            return FindValue<PackageVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortType.
    /// </summary>
    public class PortType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for PortType
        /// </summary>
        public static readonly PortType BOOLEAN = new PortType("BOOLEAN");
        /// <summary>
        /// Constant FLOAT32 for PortType
        /// </summary>
        public static readonly PortType FLOAT32 = new PortType("FLOAT32");
        /// <summary>
        /// Constant INT32 for PortType
        /// </summary>
        public static readonly PortType INT32 = new PortType("INT32");
        /// <summary>
        /// Constant MEDIA for PortType
        /// </summary>
        public static readonly PortType MEDIA = new PortType("MEDIA");
        /// <summary>
        /// Constant STRING for PortType
        /// </summary>
        public static readonly PortType STRING = new PortType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortType FindValue(string value)
        {
            return FindValue<PortType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusFilter.
    /// </summary>
    public class StatusFilter : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYMENT_ERROR for StatusFilter
        /// </summary>
        public static readonly StatusFilter DEPLOYMENT_ERROR = new StatusFilter("DEPLOYMENT_ERROR");
        /// <summary>
        /// Constant DEPLOYMENT_FAILED for StatusFilter
        /// </summary>
        public static readonly StatusFilter DEPLOYMENT_FAILED = new StatusFilter("DEPLOYMENT_FAILED");
        /// <summary>
        /// Constant DEPLOYMENT_SUCCEEDED for StatusFilter
        /// </summary>
        public static readonly StatusFilter DEPLOYMENT_SUCCEEDED = new StatusFilter("DEPLOYMENT_SUCCEEDED");
        /// <summary>
        /// Constant PROCESSING_DEPLOYMENT for StatusFilter
        /// </summary>
        public static readonly StatusFilter PROCESSING_DEPLOYMENT = new StatusFilter("PROCESSING_DEPLOYMENT");
        /// <summary>
        /// Constant PROCESSING_REMOVAL for StatusFilter
        /// </summary>
        public static readonly StatusFilter PROCESSING_REMOVAL = new StatusFilter("PROCESSING_REMOVAL");
        /// <summary>
        /// Constant REMOVAL_FAILED for StatusFilter
        /// </summary>
        public static readonly StatusFilter REMOVAL_FAILED = new StatusFilter("REMOVAL_FAILED");
        /// <summary>
        /// Constant REMOVAL_SUCCEEDED for StatusFilter
        /// </summary>
        public static readonly StatusFilter REMOVAL_SUCCEEDED = new StatusFilter("REMOVAL_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusFilter FindValue(string value)
        {
            return FindValue<StatusFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateType.
    /// </summary>
    public class TemplateType : ConstantClass
    {

        /// <summary>
        /// Constant RTSP_CAMERA_STREAM for TemplateType
        /// </summary>
        public static readonly TemplateType RTSP_CAMERA_STREAM = new TemplateType("RTSP_CAMERA_STREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateType FindValue(string value)
        {
            return FindValue<TemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateProgress.
    /// </summary>
    public class UpdateProgress : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress COMPLETED = new UpdateProgress("COMPLETED");
        /// <summary>
        /// Constant DOWNLOADING for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress DOWNLOADING = new UpdateProgress("DOWNLOADING");
        /// <summary>
        /// Constant FAILED for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress FAILED = new UpdateProgress("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress IN_PROGRESS = new UpdateProgress("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress PENDING = new UpdateProgress("PENDING");
        /// <summary>
        /// Constant REBOOTING for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress REBOOTING = new UpdateProgress("REBOOTING");
        /// <summary>
        /// Constant VERIFYING for UpdateProgress
        /// </summary>
        public static readonly UpdateProgress VERIFYING = new UpdateProgress("VERIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateProgress(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateProgress FindValue(string value)
        {
            return FindValue<UpdateProgress>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateProgress(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
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

}
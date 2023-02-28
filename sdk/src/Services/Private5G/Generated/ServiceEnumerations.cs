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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Private5G
{

    /// <summary>
    /// Constants used for properties of type AcknowledgmentStatus.
    /// </summary>
    public class AcknowledgmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACKNOWLEDGED for AcknowledgmentStatus
        /// </summary>
        public static readonly AcknowledgmentStatus ACKNOWLEDGED = new AcknowledgmentStatus("ACKNOWLEDGED");
        /// <summary>
        /// Constant ACKNOWLEDGING for AcknowledgmentStatus
        /// </summary>
        public static readonly AcknowledgmentStatus ACKNOWLEDGING = new AcknowledgmentStatus("ACKNOWLEDGING");
        /// <summary>
        /// Constant UNACKNOWLEDGED for AcknowledgmentStatus
        /// </summary>
        public static readonly AcknowledgmentStatus UNACKNOWLEDGED = new AcknowledgmentStatus("UNACKNOWLEDGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcknowledgmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcknowledgmentStatus FindValue(string value)
        {
            return FindValue<AcknowledgmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcknowledgmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceIdentifierFilterKeys.
    /// </summary>
    public class DeviceIdentifierFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant ORDER for DeviceIdentifierFilterKeys
        /// </summary>
        public static readonly DeviceIdentifierFilterKeys ORDER = new DeviceIdentifierFilterKeys("ORDER");
        /// <summary>
        /// Constant STATUS for DeviceIdentifierFilterKeys
        /// </summary>
        public static readonly DeviceIdentifierFilterKeys STATUS = new DeviceIdentifierFilterKeys("STATUS");
        /// <summary>
        /// Constant TRAFFIC_GROUP for DeviceIdentifierFilterKeys
        /// </summary>
        public static readonly DeviceIdentifierFilterKeys TRAFFIC_GROUP = new DeviceIdentifierFilterKeys("TRAFFIC_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceIdentifierFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceIdentifierFilterKeys FindValue(string value)
        {
            return FindValue<DeviceIdentifierFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceIdentifierFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceIdentifierStatus.
    /// </summary>
    public class DeviceIdentifierStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DeviceIdentifierStatus
        /// </summary>
        public static readonly DeviceIdentifierStatus ACTIVE = new DeviceIdentifierStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for DeviceIdentifierStatus
        /// </summary>
        public static readonly DeviceIdentifierStatus INACTIVE = new DeviceIdentifierStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceIdentifierStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceIdentifierStatus FindValue(string value)
        {
            return FindValue<DeviceIdentifierStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceIdentifierStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElevationReference.
    /// </summary>
    public class ElevationReference : ConstantClass
    {

        /// <summary>
        /// Constant AGL for ElevationReference
        /// </summary>
        public static readonly ElevationReference AGL = new ElevationReference("AGL");
        /// <summary>
        /// Constant AMSL for ElevationReference
        /// </summary>
        public static readonly ElevationReference AMSL = new ElevationReference("AMSL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElevationReference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElevationReference FindValue(string value)
        {
            return FindValue<ElevationReference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElevationReference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ElevationUnit.
    /// </summary>
    public class ElevationUnit : ConstantClass
    {

        /// <summary>
        /// Constant FEET for ElevationUnit
        /// </summary>
        public static readonly ElevationUnit FEET = new ElevationUnit("FEET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ElevationUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ElevationUnit FindValue(string value)
        {
            return FindValue<ElevationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ElevationUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthStatus.
    /// </summary>
    public class HealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus HEALTHY = new HealthStatus("HEALTHY");
        /// <summary>
        /// Constant INITIAL for HealthStatus
        /// </summary>
        public static readonly HealthStatus INITIAL = new HealthStatus("INITIAL");
        /// <summary>
        /// Constant UNHEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus UNHEALTHY = new HealthStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthStatus FindValue(string value)
        {
            return FindValue<HealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkFilterKeys.
    /// </summary>
    public class NetworkFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant STATUS for NetworkFilterKeys
        /// </summary>
        public static readonly NetworkFilterKeys STATUS = new NetworkFilterKeys("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkFilterKeys FindValue(string value)
        {
            return FindValue<NetworkFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkResourceDefinitionType.
    /// </summary>
    public class NetworkResourceDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant DEVICE_IDENTIFIER for NetworkResourceDefinitionType
        /// </summary>
        public static readonly NetworkResourceDefinitionType DEVICE_IDENTIFIER = new NetworkResourceDefinitionType("DEVICE_IDENTIFIER");
        /// <summary>
        /// Constant RADIO_UNIT for NetworkResourceDefinitionType
        /// </summary>
        public static readonly NetworkResourceDefinitionType RADIO_UNIT = new NetworkResourceDefinitionType("RADIO_UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkResourceDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkResourceDefinitionType FindValue(string value)
        {
            return FindValue<NetworkResourceDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkResourceDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkResourceFilterKeys.
    /// </summary>
    public class NetworkResourceFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant ORDER for NetworkResourceFilterKeys
        /// </summary>
        public static readonly NetworkResourceFilterKeys ORDER = new NetworkResourceFilterKeys("ORDER");
        /// <summary>
        /// Constant STATUS for NetworkResourceFilterKeys
        /// </summary>
        public static readonly NetworkResourceFilterKeys STATUS = new NetworkResourceFilterKeys("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkResourceFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkResourceFilterKeys FindValue(string value)
        {
            return FindValue<NetworkResourceFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkResourceFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkResourceStatus.
    /// </summary>
    public class NetworkResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus AVAILABLE = new NetworkResourceStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING_SHIPPING_LABEL for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus CREATING_SHIPPING_LABEL = new NetworkResourceStatus("CREATING_SHIPPING_LABEL");
        /// <summary>
        /// Constant DELETED for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus DELETED = new NetworkResourceStatus("DELETED");
        /// <summary>
        /// Constant DELETING for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus DELETING = new NetworkResourceStatus("DELETING");
        /// <summary>
        /// Constant PENDING for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus PENDING = new NetworkResourceStatus("PENDING");
        /// <summary>
        /// Constant PENDING_RETURN for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus PENDING_RETURN = new NetworkResourceStatus("PENDING_RETURN");
        /// <summary>
        /// Constant PROVISIONED for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus PROVISIONED = new NetworkResourceStatus("PROVISIONED");
        /// <summary>
        /// Constant PROVISIONING for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus PROVISIONING = new NetworkResourceStatus("PROVISIONING");
        /// <summary>
        /// Constant SHIPPED for NetworkResourceStatus
        /// </summary>
        public static readonly NetworkResourceStatus SHIPPED = new NetworkResourceStatus("SHIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkResourceStatus FindValue(string value)
        {
            return FindValue<NetworkResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkResourceType.
    /// </summary>
    public class NetworkResourceType : ConstantClass
    {

        /// <summary>
        /// Constant RADIO_UNIT for NetworkResourceType
        /// </summary>
        public static readonly NetworkResourceType RADIO_UNIT = new NetworkResourceType("RADIO_UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkResourceType FindValue(string value)
        {
            return FindValue<NetworkResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkSiteFilterKeys.
    /// </summary>
    public class NetworkSiteFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant STATUS for NetworkSiteFilterKeys
        /// </summary>
        public static readonly NetworkSiteFilterKeys STATUS = new NetworkSiteFilterKeys("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkSiteFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkSiteFilterKeys FindValue(string value)
        {
            return FindValue<NetworkSiteFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkSiteFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkSiteStatus.
    /// </summary>
    public class NetworkSiteStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NetworkSiteStatus
        /// </summary>
        public static readonly NetworkSiteStatus AVAILABLE = new NetworkSiteStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATED for NetworkSiteStatus
        /// </summary>
        public static readonly NetworkSiteStatus CREATED = new NetworkSiteStatus("CREATED");
        /// <summary>
        /// Constant DELETED for NetworkSiteStatus
        /// </summary>
        public static readonly NetworkSiteStatus DELETED = new NetworkSiteStatus("DELETED");
        /// <summary>
        /// Constant DEPROVISIONING for NetworkSiteStatus
        /// </summary>
        public static readonly NetworkSiteStatus DEPROVISIONING = new NetworkSiteStatus("DEPROVISIONING");
        /// <summary>
        /// Constant PROVISIONING for NetworkSiteStatus
        /// </summary>
        public static readonly NetworkSiteStatus PROVISIONING = new NetworkSiteStatus("PROVISIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkSiteStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkSiteStatus FindValue(string value)
        {
            return FindValue<NetworkSiteStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkSiteStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkStatus.
    /// </summary>
    public class NetworkStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus AVAILABLE = new NetworkStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATED for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus CREATED = new NetworkStatus("CREATED");
        /// <summary>
        /// Constant DELETED for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus DELETED = new NetworkStatus("DELETED");
        /// <summary>
        /// Constant DEPROVISIONING for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus DEPROVISIONING = new NetworkStatus("DEPROVISIONING");
        /// <summary>
        /// Constant PROVISIONING for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus PROVISIONING = new NetworkStatus("PROVISIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkStatus FindValue(string value)
        {
            return FindValue<NetworkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderFilterKeys.
    /// </summary>
    public class OrderFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant NETWORK_SITE for OrderFilterKeys
        /// </summary>
        public static readonly OrderFilterKeys NETWORK_SITE = new OrderFilterKeys("NETWORK_SITE");
        /// <summary>
        /// Constant STATUS for OrderFilterKeys
        /// </summary>
        public static readonly OrderFilterKeys STATUS = new OrderFilterKeys("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderFilterKeys FindValue(string value)
        {
            return FindValue<OrderFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderFilterKeys(string value)
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
        /// Constant REPLACE for UpdateType
        /// </summary>
        public static readonly UpdateType REPLACE = new UpdateType("REPLACE");
        /// <summary>
        /// Constant RETURN for UpdateType
        /// </summary>
        public static readonly UpdateType RETURN = new UpdateType("RETURN");

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


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_ASSUME_ROLE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_ASSUME_ROLE = new ValidationExceptionReason("CANNOT_ASSUME_ROLE");
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
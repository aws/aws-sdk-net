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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NetworkManager
{

    /// <summary>
    /// Constants used for properties of type ConnectionState.
    /// </summary>
    public class ConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ConnectionState
        /// </summary>
        public static readonly ConnectionState AVAILABLE = new ConnectionState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for ConnectionState
        /// </summary>
        public static readonly ConnectionState DELETING = new ConnectionState("DELETING");
        /// <summary>
        /// Constant PENDING for ConnectionState
        /// </summary>
        public static readonly ConnectionState PENDING = new ConnectionState("PENDING");
        /// <summary>
        /// Constant UPDATING for ConnectionState
        /// </summary>
        public static readonly ConnectionState UPDATING = new ConnectionState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionState FindValue(string value)
        {
            return FindValue<ConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerGatewayAssociationState.
    /// </summary>
    public class CustomerGatewayAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for CustomerGatewayAssociationState
        /// </summary>
        public static readonly CustomerGatewayAssociationState AVAILABLE = new CustomerGatewayAssociationState("AVAILABLE");
        /// <summary>
        /// Constant DELETED for CustomerGatewayAssociationState
        /// </summary>
        public static readonly CustomerGatewayAssociationState DELETED = new CustomerGatewayAssociationState("DELETED");
        /// <summary>
        /// Constant DELETING for CustomerGatewayAssociationState
        /// </summary>
        public static readonly CustomerGatewayAssociationState DELETING = new CustomerGatewayAssociationState("DELETING");
        /// <summary>
        /// Constant PENDING for CustomerGatewayAssociationState
        /// </summary>
        public static readonly CustomerGatewayAssociationState PENDING = new CustomerGatewayAssociationState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerGatewayAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerGatewayAssociationState FindValue(string value)
        {
            return FindValue<CustomerGatewayAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerGatewayAssociationState(string value)
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
        /// Constant AVAILABLE for DeviceState
        /// </summary>
        public static readonly DeviceState AVAILABLE = new DeviceState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for DeviceState
        /// </summary>
        public static readonly DeviceState DELETING = new DeviceState("DELETING");
        /// <summary>
        /// Constant PENDING for DeviceState
        /// </summary>
        public static readonly DeviceState PENDING = new DeviceState("PENDING");
        /// <summary>
        /// Constant UPDATING for DeviceState
        /// </summary>
        public static readonly DeviceState UPDATING = new DeviceState("UPDATING");

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
    /// Constants used for properties of type GlobalNetworkState.
    /// </summary>
    public class GlobalNetworkState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for GlobalNetworkState
        /// </summary>
        public static readonly GlobalNetworkState AVAILABLE = new GlobalNetworkState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for GlobalNetworkState
        /// </summary>
        public static readonly GlobalNetworkState DELETING = new GlobalNetworkState("DELETING");
        /// <summary>
        /// Constant PENDING for GlobalNetworkState
        /// </summary>
        public static readonly GlobalNetworkState PENDING = new GlobalNetworkState("PENDING");
        /// <summary>
        /// Constant UPDATING for GlobalNetworkState
        /// </summary>
        public static readonly GlobalNetworkState UPDATING = new GlobalNetworkState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlobalNetworkState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlobalNetworkState FindValue(string value)
        {
            return FindValue<GlobalNetworkState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlobalNetworkState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LinkAssociationState.
    /// </summary>
    public class LinkAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LinkAssociationState
        /// </summary>
        public static readonly LinkAssociationState AVAILABLE = new LinkAssociationState("AVAILABLE");
        /// <summary>
        /// Constant DELETED for LinkAssociationState
        /// </summary>
        public static readonly LinkAssociationState DELETED = new LinkAssociationState("DELETED");
        /// <summary>
        /// Constant DELETING for LinkAssociationState
        /// </summary>
        public static readonly LinkAssociationState DELETING = new LinkAssociationState("DELETING");
        /// <summary>
        /// Constant PENDING for LinkAssociationState
        /// </summary>
        public static readonly LinkAssociationState PENDING = new LinkAssociationState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LinkAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkAssociationState FindValue(string value)
        {
            return FindValue<LinkAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LinkState.
    /// </summary>
    public class LinkState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LinkState
        /// </summary>
        public static readonly LinkState AVAILABLE = new LinkState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for LinkState
        /// </summary>
        public static readonly LinkState DELETING = new LinkState("DELETING");
        /// <summary>
        /// Constant PENDING for LinkState
        /// </summary>
        public static readonly LinkState PENDING = new LinkState("PENDING");
        /// <summary>
        /// Constant UPDATING for LinkState
        /// </summary>
        public static readonly LinkState UPDATING = new LinkState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LinkState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkState FindValue(string value)
        {
            return FindValue<LinkState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SiteState.
    /// </summary>
    public class SiteState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SiteState
        /// </summary>
        public static readonly SiteState AVAILABLE = new SiteState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for SiteState
        /// </summary>
        public static readonly SiteState DELETING = new SiteState("DELETING");
        /// <summary>
        /// Constant PENDING for SiteState
        /// </summary>
        public static readonly SiteState PENDING = new SiteState("PENDING");
        /// <summary>
        /// Constant UPDATING for SiteState
        /// </summary>
        public static readonly SiteState UPDATING = new SiteState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SiteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SiteState FindValue(string value)
        {
            return FindValue<SiteState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SiteState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayConnectPeerAssociationState.
    /// </summary>
    public class TransitGatewayConnectPeerAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for TransitGatewayConnectPeerAssociationState
        /// </summary>
        public static readonly TransitGatewayConnectPeerAssociationState AVAILABLE = new TransitGatewayConnectPeerAssociationState("AVAILABLE");
        /// <summary>
        /// Constant DELETED for TransitGatewayConnectPeerAssociationState
        /// </summary>
        public static readonly TransitGatewayConnectPeerAssociationState DELETED = new TransitGatewayConnectPeerAssociationState("DELETED");
        /// <summary>
        /// Constant DELETING for TransitGatewayConnectPeerAssociationState
        /// </summary>
        public static readonly TransitGatewayConnectPeerAssociationState DELETING = new TransitGatewayConnectPeerAssociationState("DELETING");
        /// <summary>
        /// Constant PENDING for TransitGatewayConnectPeerAssociationState
        /// </summary>
        public static readonly TransitGatewayConnectPeerAssociationState PENDING = new TransitGatewayConnectPeerAssociationState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayConnectPeerAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayConnectPeerAssociationState FindValue(string value)
        {
            return FindValue<TransitGatewayConnectPeerAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayConnectPeerAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitGatewayRegistrationState.
    /// </summary>
    public class TransitGatewayRegistrationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for TransitGatewayRegistrationState
        /// </summary>
        public static readonly TransitGatewayRegistrationState AVAILABLE = new TransitGatewayRegistrationState("AVAILABLE");
        /// <summary>
        /// Constant DELETED for TransitGatewayRegistrationState
        /// </summary>
        public static readonly TransitGatewayRegistrationState DELETED = new TransitGatewayRegistrationState("DELETED");
        /// <summary>
        /// Constant DELETING for TransitGatewayRegistrationState
        /// </summary>
        public static readonly TransitGatewayRegistrationState DELETING = new TransitGatewayRegistrationState("DELETING");
        /// <summary>
        /// Constant FAILED for TransitGatewayRegistrationState
        /// </summary>
        public static readonly TransitGatewayRegistrationState FAILED = new TransitGatewayRegistrationState("FAILED");
        /// <summary>
        /// Constant PENDING for TransitGatewayRegistrationState
        /// </summary>
        public static readonly TransitGatewayRegistrationState PENDING = new TransitGatewayRegistrationState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitGatewayRegistrationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayRegistrationState FindValue(string value)
        {
            return FindValue<TransitGatewayRegistrationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayRegistrationState(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("Other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("UnknownOperation");

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
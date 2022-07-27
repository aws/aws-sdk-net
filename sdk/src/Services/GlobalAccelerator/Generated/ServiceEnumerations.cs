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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GlobalAccelerator
{

    /// <summary>
    /// Constants used for properties of type AcceleratorStatus.
    /// </summary>
    public class AcceleratorStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for AcceleratorStatus
        /// </summary>
        public static readonly AcceleratorStatus DEPLOYED = new AcceleratorStatus("DEPLOYED");
        /// <summary>
        /// Constant IN_PROGRESS for AcceleratorStatus
        /// </summary>
        public static readonly AcceleratorStatus IN_PROGRESS = new AcceleratorStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorStatus FindValue(string value)
        {
            return FindValue<AcceleratorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ByoipCidrState.
    /// </summary>
    public class ByoipCidrState : ConstantClass
    {

        /// <summary>
        /// Constant ADVERTISING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState ADVERTISING = new ByoipCidrState("ADVERTISING");
        /// <summary>
        /// Constant DEPROVISIONED for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState DEPROVISIONED = new ByoipCidrState("DEPROVISIONED");
        /// <summary>
        /// Constant FAILED_ADVERTISING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FAILED_ADVERTISING = new ByoipCidrState("FAILED_ADVERTISING");
        /// <summary>
        /// Constant FAILED_DEPROVISION for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FAILED_DEPROVISION = new ByoipCidrState("FAILED_DEPROVISION");
        /// <summary>
        /// Constant FAILED_PROVISION for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FAILED_PROVISION = new ByoipCidrState("FAILED_PROVISION");
        /// <summary>
        /// Constant FAILED_WITHDRAW for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState FAILED_WITHDRAW = new ByoipCidrState("FAILED_WITHDRAW");
        /// <summary>
        /// Constant PENDING_ADVERTISING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PENDING_ADVERTISING = new ByoipCidrState("PENDING_ADVERTISING");
        /// <summary>
        /// Constant PENDING_DEPROVISIONING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PENDING_DEPROVISIONING = new ByoipCidrState("PENDING_DEPROVISIONING");
        /// <summary>
        /// Constant PENDING_PROVISIONING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PENDING_PROVISIONING = new ByoipCidrState("PENDING_PROVISIONING");
        /// <summary>
        /// Constant PENDING_WITHDRAWING for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState PENDING_WITHDRAWING = new ByoipCidrState("PENDING_WITHDRAWING");
        /// <summary>
        /// Constant READY for ByoipCidrState
        /// </summary>
        public static readonly ByoipCidrState READY = new ByoipCidrState("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ByoipCidrState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ByoipCidrState FindValue(string value)
        {
            return FindValue<ByoipCidrState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ByoipCidrState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientAffinity.
    /// </summary>
    public class ClientAffinity : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ClientAffinity
        /// </summary>
        public static readonly ClientAffinity NONE = new ClientAffinity("NONE");
        /// <summary>
        /// Constant SOURCE_IP for ClientAffinity
        /// </summary>
        public static readonly ClientAffinity SOURCE_IP = new ClientAffinity("SOURCE_IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientAffinity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientAffinity FindValue(string value)
        {
            return FindValue<ClientAffinity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientAffinity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomRoutingAcceleratorStatus.
    /// </summary>
    public class CustomRoutingAcceleratorStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for CustomRoutingAcceleratorStatus
        /// </summary>
        public static readonly CustomRoutingAcceleratorStatus DEPLOYED = new CustomRoutingAcceleratorStatus("DEPLOYED");
        /// <summary>
        /// Constant IN_PROGRESS for CustomRoutingAcceleratorStatus
        /// </summary>
        public static readonly CustomRoutingAcceleratorStatus IN_PROGRESS = new CustomRoutingAcceleratorStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomRoutingAcceleratorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomRoutingAcceleratorStatus FindValue(string value)
        {
            return FindValue<CustomRoutingAcceleratorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomRoutingAcceleratorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomRoutingDestinationTrafficState.
    /// </summary>
    public class CustomRoutingDestinationTrafficState : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for CustomRoutingDestinationTrafficState
        /// </summary>
        public static readonly CustomRoutingDestinationTrafficState ALLOW = new CustomRoutingDestinationTrafficState("ALLOW");
        /// <summary>
        /// Constant DENY for CustomRoutingDestinationTrafficState
        /// </summary>
        public static readonly CustomRoutingDestinationTrafficState DENY = new CustomRoutingDestinationTrafficState("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomRoutingDestinationTrafficState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomRoutingDestinationTrafficState FindValue(string value)
        {
            return FindValue<CustomRoutingDestinationTrafficState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomRoutingDestinationTrafficState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomRoutingProtocol.
    /// </summary>
    public class CustomRoutingProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for CustomRoutingProtocol
        /// </summary>
        public static readonly CustomRoutingProtocol TCP = new CustomRoutingProtocol("TCP");
        /// <summary>
        /// Constant UDP for CustomRoutingProtocol
        /// </summary>
        public static readonly CustomRoutingProtocol UDP = new CustomRoutingProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomRoutingProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomRoutingProtocol FindValue(string value)
        {
            return FindValue<CustomRoutingProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomRoutingProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckProtocol.
    /// </summary>
    public class HealthCheckProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for HealthCheckProtocol
        /// </summary>
        public static readonly HealthCheckProtocol HTTP = new HealthCheckProtocol("HTTP");
        /// <summary>
        /// Constant HTTPS for HealthCheckProtocol
        /// </summary>
        public static readonly HealthCheckProtocol HTTPS = new HealthCheckProtocol("HTTPS");
        /// <summary>
        /// Constant TCP for HealthCheckProtocol
        /// </summary>
        public static readonly HealthCheckProtocol TCP = new HealthCheckProtocol("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckProtocol FindValue(string value)
        {
            return FindValue<HealthCheckProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthState.
    /// </summary>
    public class HealthState : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for HealthState
        /// </summary>
        public static readonly HealthState HEALTHY = new HealthState("HEALTHY");
        /// <summary>
        /// Constant INITIAL for HealthState
        /// </summary>
        public static readonly HealthState INITIAL = new HealthState("INITIAL");
        /// <summary>
        /// Constant UNHEALTHY for HealthState
        /// </summary>
        public static readonly HealthState UNHEALTHY = new HealthState("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthState FindValue(string value)
        {
            return FindValue<HealthState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressFamily.
    /// </summary>
    public class IpAddressFamily : ConstantClass
    {

        /// <summary>
        /// Constant IPv4 for IpAddressFamily
        /// </summary>
        public static readonly IpAddressFamily IPv4 = new IpAddressFamily("IPv4");
        /// <summary>
        /// Constant IPv6 for IpAddressFamily
        /// </summary>
        public static readonly IpAddressFamily IPv6 = new IpAddressFamily("IPv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressFamily FindValue(string value)
        {
            return FindValue<IpAddressFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL_STACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUAL_STACK = new IpAddressType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for Protocol
        /// </summary>
        public static readonly Protocol TCP = new Protocol("TCP");
        /// <summary>
        /// Constant UDP for Protocol
        /// </summary>
        public static readonly Protocol UDP = new Protocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }

}
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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LambdaCore
{

    /// <summary>
    /// Constants used for properties of type ComputeResourceType.
    /// </summary>
    public class ComputeResourceType : ConstantClass
    {

        /// <summary>
        /// Constant MicroVm for ComputeResourceType
        /// </summary>
        public static readonly ComputeResourceType MicroVm = new ComputeResourceType("MicroVm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeResourceType FindValue(string value)
        {
            return FindValue<ComputeResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectorLastUpdateStatus.
    /// </summary>
    public class NetworkConnectorLastUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for NetworkConnectorLastUpdateStatus
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatus Failed = new NetworkConnectorLastUpdateStatus("Failed");
        /// <summary>
        /// Constant InProgress for NetworkConnectorLastUpdateStatus
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatus InProgress = new NetworkConnectorLastUpdateStatus("InProgress");
        /// <summary>
        /// Constant Successful for NetworkConnectorLastUpdateStatus
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatus Successful = new NetworkConnectorLastUpdateStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectorLastUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectorLastUpdateStatus FindValue(string value)
        {
            return FindValue<NetworkConnectorLastUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectorLastUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectorLastUpdateStatusReasonCode.
    /// </summary>
    public class NetworkConnectorLastUpdateStatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant DisallowedByVpcEncryptionControl for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode DisallowedByVpcEncryptionControl = new NetworkConnectorLastUpdateStatusReasonCode("DisallowedByVpcEncryptionControl");
        /// <summary>
        /// Constant Ec2RequestLimitExceeded for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode Ec2RequestLimitExceeded = new NetworkConnectorLastUpdateStatusReasonCode("Ec2RequestLimitExceeded");
        /// <summary>
        /// Constant InsufficientRolePermissions for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode InsufficientRolePermissions = new NetworkConnectorLastUpdateStatusReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode InternalError = new NetworkConnectorLastUpdateStatusReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidSecurityGroup for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode InvalidSecurityGroup = new NetworkConnectorLastUpdateStatusReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidSubnet for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode InvalidSubnet = new NetworkConnectorLastUpdateStatusReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for NetworkConnectorLastUpdateStatusReasonCode
        /// </summary>
        public static readonly NetworkConnectorLastUpdateStatusReasonCode SubnetOutOfIPAddresses = new NetworkConnectorLastUpdateStatusReasonCode("SubnetOutOfIPAddresses");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectorLastUpdateStatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectorLastUpdateStatusReasonCode FindValue(string value)
        {
            return FindValue<NetworkConnectorLastUpdateStatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectorLastUpdateStatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectorState.
    /// </summary>
    public class NetworkConnectorState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState ACTIVE = new NetworkConnectorState("ACTIVE");
        /// <summary>
        /// Constant DELETE_FAILED for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState DELETE_FAILED = new NetworkConnectorState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState DELETING = new NetworkConnectorState("DELETING");
        /// <summary>
        /// Constant FAILED for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState FAILED = new NetworkConnectorState("FAILED");
        /// <summary>
        /// Constant INACTIVE for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState INACTIVE = new NetworkConnectorState("INACTIVE");
        /// <summary>
        /// Constant PENDING for NetworkConnectorState
        /// </summary>
        public static readonly NetworkConnectorState PENDING = new NetworkConnectorState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectorState FindValue(string value)
        {
            return FindValue<NetworkConnectorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectorStateReasonCode.
    /// </summary>
    public class NetworkConnectorStateReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant DisallowedByVpcEncryptionControl for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode DisallowedByVpcEncryptionControl = new NetworkConnectorStateReasonCode("DisallowedByVpcEncryptionControl");
        /// <summary>
        /// Constant Ec2RequestLimitExceeded for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode Ec2RequestLimitExceeded = new NetworkConnectorStateReasonCode("Ec2RequestLimitExceeded");
        /// <summary>
        /// Constant InsufficientRolePermissions for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode InsufficientRolePermissions = new NetworkConnectorStateReasonCode("InsufficientRolePermissions");
        /// <summary>
        /// Constant InternalError for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode InternalError = new NetworkConnectorStateReasonCode("InternalError");
        /// <summary>
        /// Constant InvalidSecurityGroup for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode InvalidSecurityGroup = new NetworkConnectorStateReasonCode("InvalidSecurityGroup");
        /// <summary>
        /// Constant InvalidSubnet for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode InvalidSubnet = new NetworkConnectorStateReasonCode("InvalidSubnet");
        /// <summary>
        /// Constant SubnetOutOfIPAddresses for NetworkConnectorStateReasonCode
        /// </summary>
        public static readonly NetworkConnectorStateReasonCode SubnetOutOfIPAddresses = new NetworkConnectorStateReasonCode("SubnetOutOfIPAddresses");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectorStateReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectorStateReasonCode FindValue(string value)
        {
            return FindValue<NetworkConnectorStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectorStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkConnectorType.
    /// </summary>
    public class NetworkConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant VPC_EGRESS for NetworkConnectorType
        /// </summary>
        public static readonly NetworkConnectorType VPC_EGRESS = new NetworkConnectorType("VPC_EGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkConnectorType FindValue(string value)
        {
            return FindValue<NetworkConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkProtocol.
    /// </summary>
    public class NetworkProtocol : ConstantClass
    {

        /// <summary>
        /// Constant DualStack for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol DualStack = new NetworkProtocol("DualStack");
        /// <summary>
        /// Constant IPv4 for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol IPv4 = new NetworkProtocol("IPv4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkProtocol FindValue(string value)
        {
            return FindValue<NetworkProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThrottleReason.
    /// </summary>
    public class ThrottleReason : ConstantClass
    {

        /// <summary>
        /// Constant CallerRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason CallerRateLimitExceeded = new ThrottleReason("CallerRateLimitExceeded");
        /// <summary>
        /// Constant ConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentInvocationLimitExceeded = new ThrottleReason("ConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ConcurrentSnapshotCreateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ConcurrentSnapshotCreateLimitExceeded = new ThrottleReason("ConcurrentSnapshotCreateLimitExceeded");
        /// <summary>
        /// Constant FunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason FunctionInvocationRateLimitExceeded = new ThrottleReason("FunctionInvocationRateLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionConcurrentInvocationLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionConcurrentInvocationLimitExceeded = new ThrottleReason("ReservedFunctionConcurrentInvocationLimitExceeded");
        /// <summary>
        /// Constant ReservedFunctionInvocationRateLimitExceeded for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason ReservedFunctionInvocationRateLimitExceeded = new ThrottleReason("ReservedFunctionInvocationRateLimitExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThrottleReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThrottleReason FindValue(string value)
        {
            return FindValue<ThrottleReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThrottleReason(string value)
        {
            return FindValue(value);
        }
    }

}
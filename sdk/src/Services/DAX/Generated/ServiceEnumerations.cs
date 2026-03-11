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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DAX
{

    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant IMMEDIATE for ChangeType
        /// </summary>
        public static readonly ChangeType IMMEDIATE = new ChangeType("IMMEDIATE");
        /// <summary>
        /// Constant REQUIRES_REBOOT for ChangeType
        /// </summary>
        public static readonly ChangeType REQUIRES_REBOOT = new ChangeType("REQUIRES_REBOOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterEndpointEncryptionType.
    /// </summary>
    public class ClusterEndpointEncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ClusterEndpointEncryptionType
        /// </summary>
        public static readonly ClusterEndpointEncryptionType NONE = new ClusterEndpointEncryptionType("NONE");
        /// <summary>
        /// Constant TLS for ClusterEndpointEncryptionType
        /// </summary>
        public static readonly ClusterEndpointEncryptionType TLS = new ClusterEndpointEncryptionType("TLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterEndpointEncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterEndpointEncryptionType FindValue(string value)
        {
            return FindValue<ClusterEndpointEncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterEndpointEncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IsModifiable.
    /// </summary>
    public class IsModifiable : ConstantClass
    {

        /// <summary>
        /// Constant CONDITIONAL for IsModifiable
        /// </summary>
        public static readonly IsModifiable CONDITIONAL = new IsModifiable("CONDITIONAL");
        /// <summary>
        /// Constant FALSE for IsModifiable
        /// </summary>
        public static readonly IsModifiable FALSE = new IsModifiable("FALSE");
        /// <summary>
        /// Constant TRUE for IsModifiable
        /// </summary>
        public static readonly IsModifiable TRUE = new IsModifiable("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IsModifiable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IsModifiable FindValue(string value)
        {
            return FindValue<IsModifiable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IsModifiable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant Dual_stack for NetworkType
        /// </summary>
        public static readonly NetworkType Dual_stack = new NetworkType("dual_stack");
        /// <summary>
        /// Constant Ipv4 for NetworkType
        /// </summary>
        public static readonly NetworkType Ipv4 = new NetworkType("ipv4");
        /// <summary>
        /// Constant Ipv6 for NetworkType
        /// </summary>
        public static readonly NetworkType Ipv6 = new NetworkType("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for ParameterType
        /// </summary>
        public static readonly ParameterType DEFAULT = new ParameterType("DEFAULT");
        /// <summary>
        /// Constant NODE_TYPE_SPECIFIC for ParameterType
        /// </summary>
        public static readonly ParameterType NODE_TYPE_SPECIFIC = new ParameterType("NODE_TYPE_SPECIFIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant CLUSTER for SourceType
        /// </summary>
        public static readonly SourceType CLUSTER = new SourceType("CLUSTER");
        /// <summary>
        /// Constant PARAMETER_GROUP for SourceType
        /// </summary>
        public static readonly SourceType PARAMETER_GROUP = new SourceType("PARAMETER_GROUP");
        /// <summary>
        /// Constant SUBNET_GROUP for SourceType
        /// </summary>
        public static readonly SourceType SUBNET_GROUP = new SourceType("SUBNET_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SSEStatus.
    /// </summary>
    public class SSEStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SSEStatus
        /// </summary>
        public static readonly SSEStatus DISABLED = new SSEStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for SSEStatus
        /// </summary>
        public static readonly SSEStatus DISABLING = new SSEStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for SSEStatus
        /// </summary>
        public static readonly SSEStatus ENABLED = new SSEStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for SSEStatus
        /// </summary>
        public static readonly SSEStatus ENABLING = new SSEStatus("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSEStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSEStatus FindValue(string value)
        {
            return FindValue<SSEStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSEStatus(string value)
        {
            return FindValue(value);
        }
    }

}
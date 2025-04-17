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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MemoryDB
{

    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant Iam for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType Iam = new AuthenticationType("iam");
        /// <summary>
        /// Constant NoPassword for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType NoPassword = new AuthenticationType("no-password");
        /// <summary>
        /// Constant Password for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType Password = new AuthenticationType("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AZStatus.
    /// </summary>
    public class AZStatus : ConstantClass
    {

        /// <summary>
        /// Constant Multiaz for AZStatus
        /// </summary>
        public static readonly AZStatus Multiaz = new AZStatus("multiaz");
        /// <summary>
        /// Constant Singleaz for AZStatus
        /// </summary>
        public static readonly AZStatus Singleaz = new AZStatus("singleaz");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AZStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AZStatus FindValue(string value)
        {
            return FindValue<AZStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AZStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataTieringStatus.
    /// </summary>
    public class DataTieringStatus : ConstantClass
    {

        /// <summary>
        /// Constant False for DataTieringStatus
        /// </summary>
        public static readonly DataTieringStatus False = new DataTieringStatus("false");
        /// <summary>
        /// Constant True for DataTieringStatus
        /// </summary>
        public static readonly DataTieringStatus True = new DataTieringStatus("true");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataTieringStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataTieringStatus FindValue(string value)
        {
            return FindValue<DataTieringStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataTieringStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputAuthenticationType.
    /// </summary>
    public class InputAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant Iam for InputAuthenticationType
        /// </summary>
        public static readonly InputAuthenticationType Iam = new InputAuthenticationType("iam");
        /// <summary>
        /// Constant Password for InputAuthenticationType
        /// </summary>
        public static readonly InputAuthenticationType Password = new InputAuthenticationType("password");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputAuthenticationType FindValue(string value)
        {
            return FindValue<InputAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpDiscovery.
    /// </summary>
    public class IpDiscovery : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for IpDiscovery
        /// </summary>
        public static readonly IpDiscovery Ipv4 = new IpDiscovery("ipv4");
        /// <summary>
        /// Constant Ipv6 for IpDiscovery
        /// </summary>
        public static readonly IpDiscovery Ipv6 = new IpDiscovery("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpDiscovery(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpDiscovery FindValue(string value)
        {
            return FindValue<IpDiscovery>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpDiscovery(string value)
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
    /// Constants used for properties of type ServiceUpdateStatus.
    /// </summary>
    public class ServiceUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Available = new ServiceUpdateStatus("available");
        /// <summary>
        /// Constant Complete for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Complete = new ServiceUpdateStatus("complete");
        /// <summary>
        /// Constant InProgress for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus InProgress = new ServiceUpdateStatus("in-progress");
        /// <summary>
        /// Constant Scheduled for ServiceUpdateStatus
        /// </summary>
        public static readonly ServiceUpdateStatus Scheduled = new ServiceUpdateStatus("scheduled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceUpdateStatus FindValue(string value)
        {
            return FindValue<ServiceUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceUpdateType.
    /// </summary>
    public class ServiceUpdateType : ConstantClass
    {

        /// <summary>
        /// Constant SecurityUpdate for ServiceUpdateType
        /// </summary>
        public static readonly ServiceUpdateType SecurityUpdate = new ServiceUpdateType("security-update");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceUpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceUpdateType FindValue(string value)
        {
            return FindValue<ServiceUpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceUpdateType(string value)
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
        /// Constant Acl for SourceType
        /// </summary>
        public static readonly SourceType Acl = new SourceType("acl");
        /// <summary>
        /// Constant Cluster for SourceType
        /// </summary>
        public static readonly SourceType Cluster = new SourceType("cluster");
        /// <summary>
        /// Constant Node for SourceType
        /// </summary>
        public static readonly SourceType Node = new SourceType("node");
        /// <summary>
        /// Constant ParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType ParameterGroup = new SourceType("parameter-group");
        /// <summary>
        /// Constant SubnetGroup for SourceType
        /// </summary>
        public static readonly SourceType SubnetGroup = new SourceType("subnet-group");
        /// <summary>
        /// Constant User for SourceType
        /// </summary>
        public static readonly SourceType User = new SourceType("user");

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
    /// Constants used for properties of type UpdateStrategy.
    /// </summary>
    public class UpdateStrategy : ConstantClass
    {

        /// <summary>
        /// Constant Coordinated for UpdateStrategy
        /// </summary>
        public static readonly UpdateStrategy Coordinated = new UpdateStrategy("coordinated");
        /// <summary>
        /// Constant Uncoordinated for UpdateStrategy
        /// </summary>
        public static readonly UpdateStrategy Uncoordinated = new UpdateStrategy("uncoordinated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStrategy FindValue(string value)
        {
            return FindValue<UpdateStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStrategy(string value)
        {
            return FindValue(value);
        }
    }

}
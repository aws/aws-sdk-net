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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.VPCLattice
{

    /// <summary>
    /// Constants used for properties of type AuthPolicyState.
    /// </summary>
    public class AuthPolicyState : ConstantClass
    {

        /// <summary>
        /// Constant Active for AuthPolicyState
        /// </summary>
        public static readonly AuthPolicyState Active = new AuthPolicyState("Active");
        /// <summary>
        /// Constant Inactive for AuthPolicyState
        /// </summary>
        public static readonly AuthPolicyState Inactive = new AuthPolicyState("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthPolicyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthPolicyState FindValue(string value)
        {
            return FindValue<AuthPolicyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthPolicyState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for AuthType
        /// </summary>
        public static readonly AuthType AWS_IAM = new AuthType("AWS_IAM");
        /// <summary>
        /// Constant NONE for AuthType
        /// </summary>
        public static readonly AuthType NONE = new AuthType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckProtocolVersion.
    /// </summary>
    public class HealthCheckProtocolVersion : ConstantClass
    {

        /// <summary>
        /// Constant HTTP1 for HealthCheckProtocolVersion
        /// </summary>
        public static readonly HealthCheckProtocolVersion HTTP1 = new HealthCheckProtocolVersion("HTTP1");
        /// <summary>
        /// Constant HTTP2 for HealthCheckProtocolVersion
        /// </summary>
        public static readonly HealthCheckProtocolVersion HTTP2 = new HealthCheckProtocolVersion("HTTP2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckProtocolVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckProtocolVersion FindValue(string value)
        {
            return FindValue<HealthCheckProtocolVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckProtocolVersion(string value)
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
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6 = new IpAddressType("IPV6");

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
    /// Constants used for properties of type LambdaEventStructureVersion.
    /// </summary>
    public class LambdaEventStructureVersion : ConstantClass
    {

        /// <summary>
        /// Constant V1 for LambdaEventStructureVersion
        /// </summary>
        public static readonly LambdaEventStructureVersion V1 = new LambdaEventStructureVersion("V1");
        /// <summary>
        /// Constant V2 for LambdaEventStructureVersion
        /// </summary>
        public static readonly LambdaEventStructureVersion V2 = new LambdaEventStructureVersion("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaEventStructureVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaEventStructureVersion FindValue(string value)
        {
            return FindValue<LambdaEventStructureVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaEventStructureVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListenerProtocol.
    /// </summary>
    public class ListenerProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for ListenerProtocol
        /// </summary>
        public static readonly ListenerProtocol HTTP = new ListenerProtocol("HTTP");
        /// <summary>
        /// Constant HTTPS for ListenerProtocol
        /// </summary>
        public static readonly ListenerProtocol HTTPS = new ListenerProtocol("HTTPS");
        /// <summary>
        /// Constant TLS_PASSTHROUGH for ListenerProtocol
        /// </summary>
        public static readonly ListenerProtocol TLS_PASSTHROUGH = new ListenerProtocol("TLS_PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListenerProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListenerProtocol FindValue(string value)
        {
            return FindValue<ListenerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListenerProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtocolType.
    /// </summary>
    public class ProtocolType : ConstantClass
    {

        /// <summary>
        /// Constant TCP for ProtocolType
        /// </summary>
        public static readonly ProtocolType TCP = new ProtocolType("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtocolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtocolType FindValue(string value)
        {
            return FindValue<ProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtocolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceConfigurationIpAddressType.
    /// </summary>
    public class ResourceConfigurationIpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUALSTACK for ResourceConfigurationIpAddressType
        /// </summary>
        public static readonly ResourceConfigurationIpAddressType DUALSTACK = new ResourceConfigurationIpAddressType("DUALSTACK");
        /// <summary>
        /// Constant IPV4 for ResourceConfigurationIpAddressType
        /// </summary>
        public static readonly ResourceConfigurationIpAddressType IPV4 = new ResourceConfigurationIpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for ResourceConfigurationIpAddressType
        /// </summary>
        public static readonly ResourceConfigurationIpAddressType IPV6 = new ResourceConfigurationIpAddressType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceConfigurationIpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceConfigurationIpAddressType FindValue(string value)
        {
            return FindValue<ResourceConfigurationIpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceConfigurationIpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceConfigurationStatus.
    /// </summary>
    public class ResourceConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus ACTIVE = new ResourceConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus CREATE_FAILED = new ResourceConfigurationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus CREATE_IN_PROGRESS = new ResourceConfigurationStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus DELETE_FAILED = new ResourceConfigurationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus DELETE_IN_PROGRESS = new ResourceConfigurationStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus UPDATE_FAILED = new ResourceConfigurationStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ResourceConfigurationStatus
        /// </summary>
        public static readonly ResourceConfigurationStatus UPDATE_IN_PROGRESS = new ResourceConfigurationStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceConfigurationStatus FindValue(string value)
        {
            return FindValue<ResourceConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceConfigurationType.
    /// </summary>
    public class ResourceConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant ARN for ResourceConfigurationType
        /// </summary>
        public static readonly ResourceConfigurationType ARN = new ResourceConfigurationType("ARN");
        /// <summary>
        /// Constant CHILD for ResourceConfigurationType
        /// </summary>
        public static readonly ResourceConfigurationType CHILD = new ResourceConfigurationType("CHILD");
        /// <summary>
        /// Constant GROUP for ResourceConfigurationType
        /// </summary>
        public static readonly ResourceConfigurationType GROUP = new ResourceConfigurationType("GROUP");
        /// <summary>
        /// Constant SINGLE for ResourceConfigurationType
        /// </summary>
        public static readonly ResourceConfigurationType SINGLE = new ResourceConfigurationType("SINGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceConfigurationType FindValue(string value)
        {
            return FindValue<ResourceConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceGatewayIpAddressType.
    /// </summary>
    public class ResourceGatewayIpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUALSTACK for ResourceGatewayIpAddressType
        /// </summary>
        public static readonly ResourceGatewayIpAddressType DUALSTACK = new ResourceGatewayIpAddressType("DUALSTACK");
        /// <summary>
        /// Constant IPV4 for ResourceGatewayIpAddressType
        /// </summary>
        public static readonly ResourceGatewayIpAddressType IPV4 = new ResourceGatewayIpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for ResourceGatewayIpAddressType
        /// </summary>
        public static readonly ResourceGatewayIpAddressType IPV6 = new ResourceGatewayIpAddressType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceGatewayIpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceGatewayIpAddressType FindValue(string value)
        {
            return FindValue<ResourceGatewayIpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceGatewayIpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceGatewayStatus.
    /// </summary>
    public class ResourceGatewayStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus ACTIVE = new ResourceGatewayStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus CREATE_FAILED = new ResourceGatewayStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus CREATE_IN_PROGRESS = new ResourceGatewayStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus DELETE_FAILED = new ResourceGatewayStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus DELETE_IN_PROGRESS = new ResourceGatewayStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus UPDATE_FAILED = new ResourceGatewayStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ResourceGatewayStatus
        /// </summary>
        public static readonly ResourceGatewayStatus UPDATE_IN_PROGRESS = new ResourceGatewayStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceGatewayStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceGatewayStatus FindValue(string value)
        {
            return FindValue<ResourceGatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceGatewayStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNetworkLogType.
    /// </summary>
    public class ServiceNetworkLogType : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE for ServiceNetworkLogType
        /// </summary>
        public static readonly ServiceNetworkLogType RESOURCE = new ServiceNetworkLogType("RESOURCE");
        /// <summary>
        /// Constant SERVICE for ServiceNetworkLogType
        /// </summary>
        public static readonly ServiceNetworkLogType SERVICE = new ServiceNetworkLogType("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNetworkLogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNetworkLogType FindValue(string value)
        {
            return FindValue<ServiceNetworkLogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNetworkLogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNetworkResourceAssociationStatus.
    /// </summary>
    public class ServiceNetworkResourceAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus ACTIVE = new ServiceNetworkResourceAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus CREATE_FAILED = new ServiceNetworkResourceAssociationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus CREATE_IN_PROGRESS = new ServiceNetworkResourceAssociationStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus DELETE_FAILED = new ServiceNetworkResourceAssociationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus DELETE_IN_PROGRESS = new ServiceNetworkResourceAssociationStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant PARTIAL for ServiceNetworkResourceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkResourceAssociationStatus PARTIAL = new ServiceNetworkResourceAssociationStatus("PARTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNetworkResourceAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNetworkResourceAssociationStatus FindValue(string value)
        {
            return FindValue<ServiceNetworkResourceAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNetworkResourceAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNetworkServiceAssociationStatus.
    /// </summary>
    public class ServiceNetworkServiceAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceNetworkServiceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkServiceAssociationStatus ACTIVE = new ServiceNetworkServiceAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ServiceNetworkServiceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkServiceAssociationStatus CREATE_FAILED = new ServiceNetworkServiceAssociationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ServiceNetworkServiceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkServiceAssociationStatus CREATE_IN_PROGRESS = new ServiceNetworkServiceAssociationStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceNetworkServiceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkServiceAssociationStatus DELETE_FAILED = new ServiceNetworkServiceAssociationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ServiceNetworkServiceAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkServiceAssociationStatus DELETE_IN_PROGRESS = new ServiceNetworkServiceAssociationStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNetworkServiceAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNetworkServiceAssociationStatus FindValue(string value)
        {
            return FindValue<ServiceNetworkServiceAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNetworkServiceAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNetworkVpcAssociationStatus.
    /// </summary>
    public class ServiceNetworkVpcAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus ACTIVE = new ServiceNetworkVpcAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus CREATE_FAILED = new ServiceNetworkVpcAssociationStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus CREATE_IN_PROGRESS = new ServiceNetworkVpcAssociationStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus DELETE_FAILED = new ServiceNetworkVpcAssociationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus DELETE_IN_PROGRESS = new ServiceNetworkVpcAssociationStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_FAILED for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus UPDATE_FAILED = new ServiceNetworkVpcAssociationStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ServiceNetworkVpcAssociationStatus
        /// </summary>
        public static readonly ServiceNetworkVpcAssociationStatus UPDATE_IN_PROGRESS = new ServiceNetworkVpcAssociationStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNetworkVpcAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNetworkVpcAssociationStatus FindValue(string value)
        {
            return FindValue<ServiceNetworkVpcAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNetworkVpcAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceStatus.
    /// </summary>
    public class ServiceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus ACTIVE = new ServiceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_FAILED = new ServiceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus CREATE_IN_PROGRESS = new ServiceStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETE_FAILED = new ServiceStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ServiceStatus
        /// </summary>
        public static readonly ServiceStatus DELETE_IN_PROGRESS = new ServiceStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceStatus FindValue(string value)
        {
            return FindValue<ServiceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetGroupProtocol.
    /// </summary>
    public class TargetGroupProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for TargetGroupProtocol
        /// </summary>
        public static readonly TargetGroupProtocol HTTP = new TargetGroupProtocol("HTTP");
        /// <summary>
        /// Constant HTTPS for TargetGroupProtocol
        /// </summary>
        public static readonly TargetGroupProtocol HTTPS = new TargetGroupProtocol("HTTPS");
        /// <summary>
        /// Constant TCP for TargetGroupProtocol
        /// </summary>
        public static readonly TargetGroupProtocol TCP = new TargetGroupProtocol("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetGroupProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetGroupProtocol FindValue(string value)
        {
            return FindValue<TargetGroupProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetGroupProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetGroupProtocolVersion.
    /// </summary>
    public class TargetGroupProtocolVersion : ConstantClass
    {

        /// <summary>
        /// Constant GRPC for TargetGroupProtocolVersion
        /// </summary>
        public static readonly TargetGroupProtocolVersion GRPC = new TargetGroupProtocolVersion("GRPC");
        /// <summary>
        /// Constant HTTP1 for TargetGroupProtocolVersion
        /// </summary>
        public static readonly TargetGroupProtocolVersion HTTP1 = new TargetGroupProtocolVersion("HTTP1");
        /// <summary>
        /// Constant HTTP2 for TargetGroupProtocolVersion
        /// </summary>
        public static readonly TargetGroupProtocolVersion HTTP2 = new TargetGroupProtocolVersion("HTTP2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetGroupProtocolVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetGroupProtocolVersion FindValue(string value)
        {
            return FindValue<TargetGroupProtocolVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetGroupProtocolVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetGroupStatus.
    /// </summary>
    public class TargetGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TargetGroupStatus
        /// </summary>
        public static readonly TargetGroupStatus ACTIVE = new TargetGroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for TargetGroupStatus
        /// </summary>
        public static readonly TargetGroupStatus CREATE_FAILED = new TargetGroupStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for TargetGroupStatus
        /// </summary>
        public static readonly TargetGroupStatus CREATE_IN_PROGRESS = new TargetGroupStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for TargetGroupStatus
        /// </summary>
        public static readonly TargetGroupStatus DELETE_FAILED = new TargetGroupStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for TargetGroupStatus
        /// </summary>
        public static readonly TargetGroupStatus DELETE_IN_PROGRESS = new TargetGroupStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetGroupStatus FindValue(string value)
        {
            return FindValue<TargetGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetGroupType.
    /// </summary>
    public class TargetGroupType : ConstantClass
    {

        /// <summary>
        /// Constant ALB for TargetGroupType
        /// </summary>
        public static readonly TargetGroupType ALB = new TargetGroupType("ALB");
        /// <summary>
        /// Constant INSTANCE for TargetGroupType
        /// </summary>
        public static readonly TargetGroupType INSTANCE = new TargetGroupType("INSTANCE");
        /// <summary>
        /// Constant IP for TargetGroupType
        /// </summary>
        public static readonly TargetGroupType IP = new TargetGroupType("IP");
        /// <summary>
        /// Constant LAMBDA for TargetGroupType
        /// </summary>
        public static readonly TargetGroupType LAMBDA = new TargetGroupType("LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetGroupType FindValue(string value)
        {
            return FindValue<TargetGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetGroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetStatus.
    /// </summary>
    public class TargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRAINING for TargetStatus
        /// </summary>
        public static readonly TargetStatus DRAINING = new TargetStatus("DRAINING");
        /// <summary>
        /// Constant HEALTHY for TargetStatus
        /// </summary>
        public static readonly TargetStatus HEALTHY = new TargetStatus("HEALTHY");
        /// <summary>
        /// Constant INITIAL for TargetStatus
        /// </summary>
        public static readonly TargetStatus INITIAL = new TargetStatus("INITIAL");
        /// <summary>
        /// Constant UNAVAILABLE for TargetStatus
        /// </summary>
        public static readonly TargetStatus UNAVAILABLE = new TargetStatus("UNAVAILABLE");
        /// <summary>
        /// Constant UNHEALTHY for TargetStatus
        /// </summary>
        public static readonly TargetStatus UNHEALTHY = new TargetStatus("UNHEALTHY");
        /// <summary>
        /// Constant UNUSED for TargetStatus
        /// </summary>
        public static readonly TargetStatus UNUSED = new TargetStatus("UNUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetStatus FindValue(string value)
        {
            return FindValue<TargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetStatus(string value)
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
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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
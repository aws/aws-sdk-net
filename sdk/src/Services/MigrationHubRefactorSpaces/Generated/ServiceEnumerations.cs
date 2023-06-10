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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MigrationHubRefactorSpaces
{

    /// <summary>
    /// Constants used for properties of type ApiGatewayEndpointType.
    /// </summary>
    public class ApiGatewayEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for ApiGatewayEndpointType
        /// </summary>
        public static readonly ApiGatewayEndpointType PRIVATE = new ApiGatewayEndpointType("PRIVATE");
        /// <summary>
        /// Constant REGIONAL for ApiGatewayEndpointType
        /// </summary>
        public static readonly ApiGatewayEndpointType REGIONAL = new ApiGatewayEndpointType("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiGatewayEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiGatewayEndpointType FindValue(string value)
        {
            return FindValue<ApiGatewayEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiGatewayEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationState.
    /// </summary>
    public class ApplicationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ApplicationState
        /// </summary>
        public static readonly ApplicationState ACTIVE = new ApplicationState("ACTIVE");
        /// <summary>
        /// Constant CREATING for ApplicationState
        /// </summary>
        public static readonly ApplicationState CREATING = new ApplicationState("CREATING");
        /// <summary>
        /// Constant DELETING for ApplicationState
        /// </summary>
        public static readonly ApplicationState DELETING = new ApplicationState("DELETING");
        /// <summary>
        /// Constant FAILED for ApplicationState
        /// </summary>
        public static readonly ApplicationState FAILED = new ApplicationState("FAILED");
        /// <summary>
        /// Constant UPDATING for ApplicationState
        /// </summary>
        public static readonly ApplicationState UPDATING = new ApplicationState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationState FindValue(string value)
        {
            return FindValue<ApplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentState.
    /// </summary>
    public class EnvironmentState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState ACTIVE = new EnvironmentState("ACTIVE");
        /// <summary>
        /// Constant CREATING for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState CREATING = new EnvironmentState("CREATING");
        /// <summary>
        /// Constant DELETING for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState DELETING = new EnvironmentState("DELETING");
        /// <summary>
        /// Constant FAILED for EnvironmentState
        /// </summary>
        public static readonly EnvironmentState FAILED = new EnvironmentState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentState FindValue(string value)
        {
            return FindValue<EnvironmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_RESOURCE_STATE for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_RESOURCE_STATE = new ErrorCode("INVALID_RESOURCE_STATE");
        /// <summary>
        /// Constant NOT_AUTHORIZED for ErrorCode
        /// </summary>
        public static readonly ErrorCode NOT_AUTHORIZED = new ErrorCode("NOT_AUTHORIZED");
        /// <summary>
        /// Constant REQUEST_LIMIT_EXCEEDED for ErrorCode
        /// </summary>
        public static readonly ErrorCode REQUEST_LIMIT_EXCEEDED = new ErrorCode("REQUEST_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant RESOURCE_CREATION_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_CREATION_FAILURE = new ErrorCode("RESOURCE_CREATION_FAILURE");
        /// <summary>
        /// Constant RESOURCE_DELETION_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_DELETION_FAILURE = new ErrorCode("RESOURCE_DELETION_FAILURE");
        /// <summary>
        /// Constant RESOURCE_IN_USE for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_IN_USE = new ErrorCode("RESOURCE_IN_USE");
        /// <summary>
        /// Constant RESOURCE_LIMIT_EXCEEDED for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_LIMIT_EXCEEDED = new ErrorCode("RESOURCE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_NOT_FOUND = new ErrorCode("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant RESOURCE_RETRIEVAL_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_RETRIEVAL_FAILURE = new ErrorCode("RESOURCE_RETRIEVAL_FAILURE");
        /// <summary>
        /// Constant RESOURCE_UPDATE_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_UPDATE_FAILURE = new ErrorCode("RESOURCE_UPDATE_FAILURE");
        /// <summary>
        /// Constant SERVICE_ENDPOINT_HEALTH_CHECK_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode SERVICE_ENDPOINT_HEALTH_CHECK_FAILURE = new ErrorCode("SERVICE_ENDPOINT_HEALTH_CHECK_FAILURE");
        /// <summary>
        /// Constant STATE_TRANSITION_FAILURE for ErrorCode
        /// </summary>
        public static readonly ErrorCode STATE_TRANSITION_FAILURE = new ErrorCode("STATE_TRANSITION_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorResourceType.
    /// </summary>
    public class ErrorResourceType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType API_GATEWAY = new ErrorResourceType("API_GATEWAY");
        /// <summary>
        /// Constant APPLICATION for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType APPLICATION = new ErrorResourceType("APPLICATION");
        /// <summary>
        /// Constant ENVIRONMENT for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType ENVIRONMENT = new ErrorResourceType("ENVIRONMENT");
        /// <summary>
        /// Constant IAM_ROLE for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType IAM_ROLE = new ErrorResourceType("IAM_ROLE");
        /// <summary>
        /// Constant LAMBDA for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType LAMBDA = new ErrorResourceType("LAMBDA");
        /// <summary>
        /// Constant LOAD_BALANCER_LISTENER for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType LOAD_BALANCER_LISTENER = new ErrorResourceType("LOAD_BALANCER_LISTENER");
        /// <summary>
        /// Constant NLB for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType NLB = new ErrorResourceType("NLB");
        /// <summary>
        /// Constant RESOURCE_SHARE for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType RESOURCE_SHARE = new ErrorResourceType("RESOURCE_SHARE");
        /// <summary>
        /// Constant ROUTE for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType ROUTE = new ErrorResourceType("ROUTE");
        /// <summary>
        /// Constant ROUTE_TABLE for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType ROUTE_TABLE = new ErrorResourceType("ROUTE_TABLE");
        /// <summary>
        /// Constant SECURITY_GROUP for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType SECURITY_GROUP = new ErrorResourceType("SECURITY_GROUP");
        /// <summary>
        /// Constant SERVICE for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType SERVICE = new ErrorResourceType("SERVICE");
        /// <summary>
        /// Constant SUBNET for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType SUBNET = new ErrorResourceType("SUBNET");
        /// <summary>
        /// Constant TARGET_GROUP for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType TARGET_GROUP = new ErrorResourceType("TARGET_GROUP");
        /// <summary>
        /// Constant TRANSIT_GATEWAY for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType TRANSIT_GATEWAY = new ErrorResourceType("TRANSIT_GATEWAY");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ATTACHMENT for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType TRANSIT_GATEWAY_ATTACHMENT = new ErrorResourceType("TRANSIT_GATEWAY_ATTACHMENT");
        /// <summary>
        /// Constant VPC for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType VPC = new ErrorResourceType("VPC");
        /// <summary>
        /// Constant VPC_ENDPOINT_SERVICE_CONFIGURATION for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType VPC_ENDPOINT_SERVICE_CONFIGURATION = new ErrorResourceType("VPC_ENDPOINT_SERVICE_CONFIGURATION");
        /// <summary>
        /// Constant VPC_LINK for ErrorResourceType
        /// </summary>
        public static readonly ErrorResourceType VPC_LINK = new ErrorResourceType("VPC_LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorResourceType FindValue(string value)
        {
            return FindValue<ErrorResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpMethod.
    /// </summary>
    public class HttpMethod : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for HttpMethod
        /// </summary>
        public static readonly HttpMethod DELETE = new HttpMethod("DELETE");
        /// <summary>
        /// Constant GET for HttpMethod
        /// </summary>
        public static readonly HttpMethod GET = new HttpMethod("GET");
        /// <summary>
        /// Constant HEAD for HttpMethod
        /// </summary>
        public static readonly HttpMethod HEAD = new HttpMethod("HEAD");
        /// <summary>
        /// Constant OPTIONS for HttpMethod
        /// </summary>
        public static readonly HttpMethod OPTIONS = new HttpMethod("OPTIONS");
        /// <summary>
        /// Constant PATCH for HttpMethod
        /// </summary>
        public static readonly HttpMethod PATCH = new HttpMethod("PATCH");
        /// <summary>
        /// Constant POST for HttpMethod
        /// </summary>
        public static readonly HttpMethod POST = new HttpMethod("POST");
        /// <summary>
        /// Constant PUT for HttpMethod
        /// </summary>
        public static readonly HttpMethod PUT = new HttpMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpMethod FindValue(string value)
        {
            return FindValue<HttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkFabricType.
    /// </summary>
    public class NetworkFabricType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for NetworkFabricType
        /// </summary>
        public static readonly NetworkFabricType NONE = new NetworkFabricType("NONE");
        /// <summary>
        /// Constant TRANSIT_GATEWAY for NetworkFabricType
        /// </summary>
        public static readonly NetworkFabricType TRANSIT_GATEWAY = new NetworkFabricType("TRANSIT_GATEWAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkFabricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkFabricType FindValue(string value)
        {
            return FindValue<NetworkFabricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkFabricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProxyType.
    /// </summary>
    public class ProxyType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for ProxyType
        /// </summary>
        public static readonly ProxyType API_GATEWAY = new ProxyType("API_GATEWAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProxyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyType FindValue(string value)
        {
            return FindValue<ProxyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteActivationState.
    /// </summary>
    public class RouteActivationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouteActivationState
        /// </summary>
        public static readonly RouteActivationState ACTIVE = new RouteActivationState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for RouteActivationState
        /// </summary>
        public static readonly RouteActivationState INACTIVE = new RouteActivationState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteActivationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteActivationState FindValue(string value)
        {
            return FindValue<RouteActivationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteActivationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteState.
    /// </summary>
    public class RouteState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouteState
        /// </summary>
        public static readonly RouteState ACTIVE = new RouteState("ACTIVE");
        /// <summary>
        /// Constant CREATING for RouteState
        /// </summary>
        public static readonly RouteState CREATING = new RouteState("CREATING");
        /// <summary>
        /// Constant DELETING for RouteState
        /// </summary>
        public static readonly RouteState DELETING = new RouteState("DELETING");
        /// <summary>
        /// Constant FAILED for RouteState
        /// </summary>
        public static readonly RouteState FAILED = new RouteState("FAILED");
        /// <summary>
        /// Constant INACTIVE for RouteState
        /// </summary>
        public static readonly RouteState INACTIVE = new RouteState("INACTIVE");
        /// <summary>
        /// Constant UPDATING for RouteState
        /// </summary>
        public static readonly RouteState UPDATING = new RouteState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteState FindValue(string value)
        {
            return FindValue<RouteState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteType.
    /// </summary>
    public class RouteType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for RouteType
        /// </summary>
        public static readonly RouteType DEFAULT = new RouteType("DEFAULT");
        /// <summary>
        /// Constant URI_PATH for RouteType
        /// </summary>
        public static readonly RouteType URI_PATH = new RouteType("URI_PATH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteType FindValue(string value)
        {
            return FindValue<RouteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceEndpointType.
    /// </summary>
    public class ServiceEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant LAMBDA for ServiceEndpointType
        /// </summary>
        public static readonly ServiceEndpointType LAMBDA = new ServiceEndpointType("LAMBDA");
        /// <summary>
        /// Constant URL for ServiceEndpointType
        /// </summary>
        public static readonly ServiceEndpointType URL = new ServiceEndpointType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceEndpointType FindValue(string value)
        {
            return FindValue<ServiceEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceState.
    /// </summary>
    public class ServiceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ServiceState
        /// </summary>
        public static readonly ServiceState ACTIVE = new ServiceState("ACTIVE");
        /// <summary>
        /// Constant CREATING for ServiceState
        /// </summary>
        public static readonly ServiceState CREATING = new ServiceState("CREATING");
        /// <summary>
        /// Constant DELETING for ServiceState
        /// </summary>
        public static readonly ServiceState DELETING = new ServiceState("DELETING");
        /// <summary>
        /// Constant FAILED for ServiceState
        /// </summary>
        public static readonly ServiceState FAILED = new ServiceState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceState FindValue(string value)
        {
            return FindValue<ServiceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceState(string value)
        {
            return FindValue(value);
        }
    }

}
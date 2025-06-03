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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApiGatewayV2
{

    /// <summary>
    /// Constants used for properties of type AuthorizationType.
    /// </summary>
    public class AuthorizationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for AuthorizationType
        /// </summary>
        public static readonly AuthorizationType AWS_IAM = new AuthorizationType("AWS_IAM");
        /// <summary>
        /// Constant CUSTOM for AuthorizationType
        /// </summary>
        public static readonly AuthorizationType CUSTOM = new AuthorizationType("CUSTOM");
        /// <summary>
        /// Constant JWT for AuthorizationType
        /// </summary>
        public static readonly AuthorizationType JWT = new AuthorizationType("JWT");
        /// <summary>
        /// Constant NONE for AuthorizationType
        /// </summary>
        public static readonly AuthorizationType NONE = new AuthorizationType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizationType FindValue(string value)
        {
            return FindValue<AuthorizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizerType.
    /// </summary>
    public class AuthorizerType : ConstantClass
    {

        /// <summary>
        /// Constant JWT for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType JWT = new AuthorizerType("JWT");
        /// <summary>
        /// Constant REQUEST for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType REQUEST = new AuthorizerType("REQUEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizerType FindValue(string value)
        {
            return FindValue<AuthorizerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizerType(string value)
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
        /// Constant INTERNET for ConnectionType
        /// </summary>
        public static readonly ConnectionType INTERNET = new ConnectionType("INTERNET");
        /// <summary>
        /// Constant VPC_LINK for ConnectionType
        /// </summary>
        public static readonly ConnectionType VPC_LINK = new ConnectionType("VPC_LINK");

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
    /// Constants used for properties of type ContentHandlingStrategy.
    /// </summary>
    public class ContentHandlingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CONVERT_TO_BINARY for ContentHandlingStrategy
        /// </summary>
        public static readonly ContentHandlingStrategy CONVERT_TO_BINARY = new ContentHandlingStrategy("CONVERT_TO_BINARY");
        /// <summary>
        /// Constant CONVERT_TO_TEXT for ContentHandlingStrategy
        /// </summary>
        public static readonly ContentHandlingStrategy CONVERT_TO_TEXT = new ContentHandlingStrategy("CONVERT_TO_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentHandlingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentHandlingStrategy FindValue(string value)
        {
            return FindValue<ContentHandlingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentHandlingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus DEPLOYED = new DeploymentStatus("DEPLOYED");
        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant PENDING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus PENDING = new DeploymentStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainNameStatus.
    /// </summary>
    public class DomainNameStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus AVAILABLE = new DomainNameStatus("AVAILABLE");
        /// <summary>
        /// Constant PENDING_CERTIFICATE_REIMPORT for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus PENDING_CERTIFICATE_REIMPORT = new DomainNameStatus("PENDING_CERTIFICATE_REIMPORT");
        /// <summary>
        /// Constant PENDING_OWNERSHIP_VERIFICATION for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus PENDING_OWNERSHIP_VERIFICATION = new DomainNameStatus("PENDING_OWNERSHIP_VERIFICATION");
        /// <summary>
        /// Constant UPDATING for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus UPDATING = new DomainNameStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainNameStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainNameStatus FindValue(string value)
        {
            return FindValue<DomainNameStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainNameStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant EDGE for EndpointType
        /// </summary>
        public static readonly EndpointType EDGE = new EndpointType("EDGE");
        /// <summary>
        /// Constant REGIONAL for EndpointType
        /// </summary>
        public static readonly EndpointType REGIONAL = new EndpointType("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS = new IntegrationType("AWS");
        /// <summary>
        /// Constant AWS_PROXY for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS_PROXY = new IntegrationType("AWS_PROXY");
        /// <summary>
        /// Constant HTTP for IntegrationType
        /// </summary>
        public static readonly IntegrationType HTTP = new IntegrationType("HTTP");
        /// <summary>
        /// Constant HTTP_PROXY for IntegrationType
        /// </summary>
        public static readonly IntegrationType HTTP_PROXY = new IntegrationType("HTTP_PROXY");
        /// <summary>
        /// Constant MOCK for IntegrationType
        /// </summary>
        public static readonly IntegrationType MOCK = new IntegrationType("MOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
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
        /// Constant Dualstack for IpAddressType
        /// </summary>
        public static readonly IpAddressType Dualstack = new IpAddressType("dualstack");
        /// <summary>
        /// Constant Ipv4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType Ipv4 = new IpAddressType("ipv4");

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
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");
        /// <summary>
        /// Constant INFO for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel INFO = new LoggingLevel("INFO");
        /// <summary>
        /// Constant OFF for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel OFF = new LoggingLevel("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PassthroughBehavior.
    /// </summary>
    public class PassthroughBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NEVER for PassthroughBehavior
        /// </summary>
        public static readonly PassthroughBehavior NEVER = new PassthroughBehavior("NEVER");
        /// <summary>
        /// Constant WHEN_NO_MATCH for PassthroughBehavior
        /// </summary>
        public static readonly PassthroughBehavior WHEN_NO_MATCH = new PassthroughBehavior("WHEN_NO_MATCH");
        /// <summary>
        /// Constant WHEN_NO_TEMPLATES for PassthroughBehavior
        /// </summary>
        public static readonly PassthroughBehavior WHEN_NO_TEMPLATES = new PassthroughBehavior("WHEN_NO_TEMPLATES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PassthroughBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PassthroughBehavior FindValue(string value)
        {
            return FindValue<PassthroughBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PassthroughBehavior(string value)
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
        /// Constant HTTP for ProtocolType
        /// </summary>
        public static readonly ProtocolType HTTP = new ProtocolType("HTTP");
        /// <summary>
        /// Constant WEBSOCKET for ProtocolType
        /// </summary>
        public static readonly ProtocolType WEBSOCKET = new ProtocolType("WEBSOCKET");

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
    /// Constants used for properties of type RoutingMode.
    /// </summary>
    public class RoutingMode : ConstantClass
    {

        /// <summary>
        /// Constant API_MAPPING_ONLY for RoutingMode
        /// </summary>
        public static readonly RoutingMode API_MAPPING_ONLY = new RoutingMode("API_MAPPING_ONLY");
        /// <summary>
        /// Constant ROUTING_RULE_ONLY for RoutingMode
        /// </summary>
        public static readonly RoutingMode ROUTING_RULE_ONLY = new RoutingMode("ROUTING_RULE_ONLY");
        /// <summary>
        /// Constant ROUTING_RULE_THEN_API_MAPPING for RoutingMode
        /// </summary>
        public static readonly RoutingMode ROUTING_RULE_THEN_API_MAPPING = new RoutingMode("ROUTING_RULE_THEN_API_MAPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingMode FindValue(string value)
        {
            return FindValue<RoutingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityPolicy.
    /// </summary>
    public class SecurityPolicy : ConstantClass
    {

        /// <summary>
        /// Constant TLS_1_0 for SecurityPolicy
        /// </summary>
        public static readonly SecurityPolicy TLS_1_0 = new SecurityPolicy("TLS_1_0");
        /// <summary>
        /// Constant TLS_1_2 for SecurityPolicy
        /// </summary>
        public static readonly SecurityPolicy TLS_1_2 = new SecurityPolicy("TLS_1_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityPolicy FindValue(string value)
        {
            return FindValue<SecurityPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcLinkStatus.
    /// </summary>
    public class VpcLinkStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus AVAILABLE = new VpcLinkStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus DELETING = new VpcLinkStatus("DELETING");
        /// <summary>
        /// Constant FAILED for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus FAILED = new VpcLinkStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus INACTIVE = new VpcLinkStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus PENDING = new VpcLinkStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcLinkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcLinkStatus FindValue(string value)
        {
            return FindValue<VpcLinkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcLinkStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcLinkVersion.
    /// </summary>
    public class VpcLinkVersion : ConstantClass
    {

        /// <summary>
        /// Constant V2 for VpcLinkVersion
        /// </summary>
        public static readonly VpcLinkVersion V2 = new VpcLinkVersion("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcLinkVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcLinkVersion FindValue(string value)
        {
            return FindValue<VpcLinkVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcLinkVersion(string value)
        {
            return FindValue(value);
        }
    }

}
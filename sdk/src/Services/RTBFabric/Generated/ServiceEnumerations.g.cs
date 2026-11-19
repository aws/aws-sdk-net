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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.RTBFabric
{
    /// <summary>
    /// Constants used for properties of type CertificateAssociationStatus.
    /// </summary>
    public class CertificateAssociationStatus : ConstantClass
    {
        /// <summary>
        /// Constant ASSOCIATED for CertificateAssociationStatus
        /// </summary>
        public static readonly CertificateAssociationStatus ASSOCIATED = new CertificateAssociationStatus("ASSOCIATED");

        /// <summary>
        /// Constant DISASSOCIATED for CertificateAssociationStatus
        /// </summary>
        public static readonly CertificateAssociationStatus DISASSOCIATED = new CertificateAssociationStatus("DISASSOCIATED");

        /// <summary>
        /// Constant FAILED for CertificateAssociationStatus
        /// </summary>
        public static readonly CertificateAssociationStatus FAILED = new CertificateAssociationStatus("FAILED");

        /// <summary>
        /// Constant PENDING_ASSOCIATION for CertificateAssociationStatus
        /// </summary>
        public static readonly CertificateAssociationStatus PENDING_ASSOCIATION = new CertificateAssociationStatus("PENDING_ASSOCIATION");

        /// <summary>
        /// Constant PENDING_DISASSOCIATION for CertificateAssociationStatus
        /// </summary>
        public static readonly CertificateAssociationStatus PENDING_DISASSOCIATION = new CertificateAssociationStatus("PENDING_DISASSOCIATION");

        /// <summary>
        /// Constructs a custom CertificateAssociationStatus for a value not among the defined constants.
        /// </summary>
        public CertificateAssociationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateAssociationStatus FindValue(string value)
        {
            return FindValue<CertificateAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ClientRoutingPolicy.
    /// </summary>
    public class ClientRoutingPolicy : ConstantClass
    {
        /// <summary>
        /// Constant ANY_AVAILABILITY_ZONE for ClientRoutingPolicy
        /// </summary>
        public static readonly ClientRoutingPolicy ANY_AVAILABILITY_ZONE = new ClientRoutingPolicy("ANY_AVAILABILITY_ZONE");

        /// <summary>
        /// Constant AVAILABILITY_ZONE_AFFINITY for ClientRoutingPolicy
        /// </summary>
        public static readonly ClientRoutingPolicy AVAILABILITY_ZONE_AFFINITY = new ClientRoutingPolicy("AVAILABILITY_ZONE_AFFINITY");

        /// <summary>
        /// Constructs a custom ClientRoutingPolicy for a value not among the defined constants.
        /// </summary>
        public ClientRoutingPolicy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientRoutingPolicy FindValue(string value)
        {
            return FindValue<ClientRoutingPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientRoutingPolicy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ConfigurableAction.
    /// </summary>
    public class ConfigurableAction : ConstantClass
    {
        /// <summary>
        /// Constant ENRICH_REQUEST_EXT for ConfigurableAction
        /// </summary>
        public static readonly ConfigurableAction ENRICH_REQUEST_EXT = new ConfigurableAction("ENRICH_REQUEST_EXT");

        /// <summary>
        /// Constant ENRICH_REQUEST_HEADERS for ConfigurableAction
        /// </summary>
        public static readonly ConfigurableAction ENRICH_REQUEST_HEADERS = new ConfigurableAction("ENRICH_REQUEST_HEADERS");

        /// <summary>
        /// Constant FILTER for ConfigurableAction
        /// </summary>
        public static readonly ConfigurableAction FILTER = new ConfigurableAction("FILTER");

        /// <summary>
        /// Constant OBSERVE for ConfigurableAction
        /// </summary>
        public static readonly ConfigurableAction OBSERVE = new ConfigurableAction("OBSERVE");

        /// <summary>
        /// Constructs a custom ConfigurableAction for a value not among the defined constants.
        /// </summary>
        public ConfigurableAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurableAction FindValue(string value)
        {
            return FindValue<ConfigurableAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurableAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ConnectivityType.
    /// </summary>
    public class ConnectivityType : ConstantClass
    {
        /// <summary>
        /// Constant DEFAULT for ConnectivityType
        /// </summary>
        public static readonly ConnectivityType DEFAULT = new ConnectivityType("DEFAULT");

        /// <summary>
        /// Constant EXTERNAL_INBOUND for ConnectivityType
        /// </summary>
        public static readonly ConnectivityType EXTERNAL_INBOUND = new ConnectivityType("EXTERNAL_INBOUND");

        /// <summary>
        /// Constant PUBLIC_EGRESS for ConnectivityType
        /// </summary>
        public static readonly ConnectivityType PUBLIC_EGRESS = new ConnectivityType("PUBLIC_EGRESS");

        /// <summary>
        /// Constant PUBLIC_INGRESS for ConnectivityType
        /// </summary>
        public static readonly ConnectivityType PUBLIC_INGRESS = new ConnectivityType("PUBLIC_INGRESS");

        /// <summary>
        /// Constructs a custom ConnectivityType for a value not among the defined constants.
        /// </summary>
        public ConnectivityType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectivityType FindValue(string value)
        {
            return FindValue<ConnectivityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectivityType(string value)
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
        /// Constant EC2_SECURITY_GROUP_NOT_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode EC2_SECURITY_GROUP_NOT_FOUND = new ErrorCode("EC2_SECURITY_GROUP_NOT_FOUND");

        /// <summary>
        /// Constant EC2_SUBNET_IP_EXHAUSTION for ErrorCode
        /// </summary>
        public static readonly ErrorCode EC2_SUBNET_IP_EXHAUSTION = new ErrorCode("EC2_SUBNET_IP_EXHAUSTION");

        /// <summary>
        /// Constant EC2_SUBNET_NOT_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode EC2_SUBNET_NOT_FOUND = new ErrorCode("EC2_SUBNET_NOT_FOUND");

        /// <summary>
        /// Constant IAM_ASSUME_ROLE_ACCESS_DENIED for ErrorCode
        /// </summary>
        public static readonly ErrorCode IAM_ASSUME_ROLE_ACCESS_DENIED = new ErrorCode("IAM_ASSUME_ROLE_ACCESS_DENIED");

        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// Constant VPC_NOT_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode VPC_NOT_FOUND = new ErrorCode("VPC_NOT_FOUND");

        /// <summary>
        /// Constructs a custom ErrorCode for a value not among the defined constants.
        /// </summary>
        public ErrorCode(string value) : base(value) { }

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
    /// Constants used for properties of type FailureMode.
    /// </summary>
    public class FailureMode : ConstantClass
    {
        /// <summary>
        /// Constant CLOSED for FailureMode
        /// </summary>
        public static readonly FailureMode CLOSED = new FailureMode("CLOSED");

        /// <summary>
        /// Constant OPEN for FailureMode
        /// </summary>
        public static readonly FailureMode OPEN = new FailureMode("OPEN");

        /// <summary>
        /// Constructs a custom FailureMode for a value not among the defined constants.
        /// </summary>
        public FailureMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureMode FindValue(string value)
        {
            return FindValue<FailureMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FilterType.
    /// </summary>
    public class FilterType : ConstantClass
    {
        /// <summary>
        /// Constant EXCLUDE for FilterType
        /// </summary>
        public static readonly FilterType EXCLUDE = new FilterType("EXCLUDE");

        /// <summary>
        /// Constant INCLUDE for FilterType
        /// </summary>
        public static readonly FilterType INCLUDE = new FilterType("INCLUDE");

        /// <summary>
        /// Constructs a custom FilterType for a value not among the defined constants.
        /// </summary>
        public FilterType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterType FindValue(string value)
        {
            return FindValue<FilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type GatewayType.
    /// </summary>
    public class GatewayType : ConstantClass
    {
        /// <summary>
        /// Constant EXTERNAL for GatewayType
        /// </summary>
        public static readonly GatewayType EXTERNAL = new GatewayType("EXTERNAL");

        /// <summary>
        /// Constant INTERNAL for GatewayType
        /// </summary>
        public static readonly GatewayType INTERNAL = new GatewayType("INTERNAL");

        /// <summary>
        /// Constructs a custom GatewayType for a value not among the defined constants.
        /// </summary>
        public GatewayType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayType FindValue(string value)
        {
            return FindValue<GatewayType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LinkDirection.
    /// </summary>
    public class LinkDirection : ConstantClass
    {
        /// <summary>
        /// Constant REQUEST for LinkDirection
        /// </summary>
        public static readonly LinkDirection REQUEST = new LinkDirection("REQUEST");

        /// <summary>
        /// Constant RESPONSE for LinkDirection
        /// </summary>
        public static readonly LinkDirection RESPONSE = new LinkDirection("RESPONSE");

        /// <summary>
        /// Constructs a custom LinkDirection for a value not among the defined constants.
        /// </summary>
        public LinkDirection(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkDirection FindValue(string value)
        {
            return FindValue<LinkDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkDirection(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LinkStatus.
    /// </summary>
    public class LinkStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACCEPTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus ACCEPTED = new LinkStatus("ACCEPTED");

        /// <summary>
        /// Constant ACTIVE for LinkStatus
        /// </summary>
        public static readonly LinkStatus ACTIVE = new LinkStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for LinkStatus
        /// </summary>
        public static readonly LinkStatus CREATE_FAILED = new LinkStatus("CREATE_FAILED");

        /// <summary>
        /// Constant DELETED for LinkStatus
        /// </summary>
        public static readonly LinkStatus DELETED = new LinkStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for LinkStatus
        /// </summary>
        public static readonly LinkStatus DELETE_FAILED = new LinkStatus("DELETE_FAILED");

        /// <summary>
        /// Constant FAILED for LinkStatus
        /// </summary>
        public static readonly LinkStatus FAILED = new LinkStatus("FAILED");

        /// <summary>
        /// Constant ISOLATED for LinkStatus
        /// </summary>
        public static readonly LinkStatus ISOLATED = new LinkStatus("ISOLATED");

        /// <summary>
        /// Constant PENDING_CREATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_CREATION = new LinkStatus("PENDING_CREATION");

        /// <summary>
        /// Constant PENDING_DELETION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_DELETION = new LinkStatus("PENDING_DELETION");

        /// <summary>
        /// Constant PENDING_ISOLATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_ISOLATION = new LinkStatus("PENDING_ISOLATION");

        /// <summary>
        /// Constant PENDING_REQUEST for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_REQUEST = new LinkStatus("PENDING_REQUEST");

        /// <summary>
        /// Constant PENDING_RESTORATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_RESTORATION = new LinkStatus("PENDING_RESTORATION");

        /// <summary>
        /// Constant PENDING_UPDATE for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_UPDATE = new LinkStatus("PENDING_UPDATE");

        /// <summary>
        /// Constant REJECTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus REJECTED = new LinkStatus("REJECTED");

        /// <summary>
        /// Constant REQUESTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus REQUESTED = new LinkStatus("REQUESTED");

        /// <summary>
        /// Constructs a custom LinkStatus for a value not among the defined constants.
        /// </summary>
        public LinkStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkStatus FindValue(string value)
        {
            return FindValue<LinkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ModulePermission.
    /// </summary>
    public class ModulePermission : ConstantClass
    {
        /// <summary>
        /// Constant ENRICH_REQUEST_EXT for ModulePermission
        /// </summary>
        public static readonly ModulePermission ENRICH_REQUEST_EXT = new ModulePermission("ENRICH_REQUEST_EXT");

        /// <summary>
        /// Constant ENRICH_REQUEST_HEADERS for ModulePermission
        /// </summary>
        public static readonly ModulePermission ENRICH_REQUEST_HEADERS = new ModulePermission("ENRICH_REQUEST_HEADERS");

        /// <summary>
        /// Constant FILTER for ModulePermission
        /// </summary>
        public static readonly ModulePermission FILTER = new ModulePermission("FILTER");

        /// <summary>
        /// Constant MUTATE_REQUEST_BODY for ModulePermission
        /// </summary>
        public static readonly ModulePermission MUTATE_REQUEST_BODY = new ModulePermission("MUTATE_REQUEST_BODY");

        /// <summary>
        /// Constant READ_REQUEST_BODY for ModulePermission
        /// </summary>
        public static readonly ModulePermission READ_REQUEST_BODY = new ModulePermission("READ_REQUEST_BODY");

        /// <summary>
        /// Constant READ_REQUEST_HEADERS for ModulePermission
        /// </summary>
        public static readonly ModulePermission READ_REQUEST_HEADERS = new ModulePermission("READ_REQUEST_HEADERS");

        /// <summary>
        /// Constructs a custom ModulePermission for a value not among the defined constants.
        /// </summary>
        public ModulePermission(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModulePermission FindValue(string value)
        {
            return FindValue<ModulePermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModulePermission(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ModuleVersionStatus.
    /// </summary>
    public class ModuleVersionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for ModuleVersionStatus
        /// </summary>
        public static readonly ModuleVersionStatus ACTIVE = new ModuleVersionStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for ModuleVersionStatus
        /// </summary>
        public static readonly ModuleVersionStatus CREATE_FAILED = new ModuleVersionStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for ModuleVersionStatus
        /// </summary>
        public static readonly ModuleVersionStatus CREATING = new ModuleVersionStatus("CREATING");

        /// <summary>
        /// Constant DEPRECATED for ModuleVersionStatus
        /// </summary>
        public static readonly ModuleVersionStatus DEPRECATED = new ModuleVersionStatus("DEPRECATED");

        /// <summary>
        /// Constructs a custom ModuleVersionStatus for a value not among the defined constants.
        /// </summary>
        public ModuleVersionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModuleVersionStatus FindValue(string value)
        {
            return FindValue<ModuleVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModuleVersionStatus(string value)
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
        /// Constant HTTP for Protocol
        /// </summary>
        public static readonly Protocol HTTP = new Protocol("HTTP");

        /// <summary>
        /// Constant HTTPS for Protocol
        /// </summary>
        public static readonly Protocol HTTPS = new Protocol("HTTPS");

        /// <summary>
        /// Constructs a custom Protocol for a value not among the defined constants.
        /// </summary>
        public Protocol(string value) : base(value) { }

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

    /// <summary>
    /// Constants used for properties of type RequesterGatewayStatus.
    /// </summary>
    public class RequesterGatewayStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ACTIVE = new RequesterGatewayStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus CREATE_FAILED = new RequesterGatewayStatus("CREATE_FAILED");

        /// <summary>
        /// Constant DELETED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus DELETED = new RequesterGatewayStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus DELETE_FAILED = new RequesterGatewayStatus("DELETE_FAILED");

        /// <summary>
        /// Constant ERROR for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ERROR = new RequesterGatewayStatus("ERROR");

        /// <summary>
        /// Constant ISOLATED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ISOLATED = new RequesterGatewayStatus("ISOLATED");

        /// <summary>
        /// Constant PENDING_CREATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_CREATION = new RequesterGatewayStatus("PENDING_CREATION");

        /// <summary>
        /// Constant PENDING_DELETION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_DELETION = new RequesterGatewayStatus("PENDING_DELETION");

        /// <summary>
        /// Constant PENDING_ISOLATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_ISOLATION = new RequesterGatewayStatus("PENDING_ISOLATION");

        /// <summary>
        /// Constant PENDING_RESTORATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_RESTORATION = new RequesterGatewayStatus("PENDING_RESTORATION");

        /// <summary>
        /// Constant PENDING_UPDATE for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_UPDATE = new RequesterGatewayStatus("PENDING_UPDATE");

        /// <summary>
        /// Constructs a custom RequesterGatewayStatus for a value not among the defined constants.
        /// </summary>
        public RequesterGatewayStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequesterGatewayStatus FindValue(string value)
        {
            return FindValue<RequesterGatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequesterGatewayStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResponderErrorMaskingAction.
    /// </summary>
    public class ResponderErrorMaskingAction : ConstantClass
    {
        /// <summary>
        /// Constant NO_BID for ResponderErrorMaskingAction
        /// </summary>
        public static readonly ResponderErrorMaskingAction NO_BID = new ResponderErrorMaskingAction("NO_BID");

        /// <summary>
        /// Constant PASSTHROUGH for ResponderErrorMaskingAction
        /// </summary>
        public static readonly ResponderErrorMaskingAction PASSTHROUGH = new ResponderErrorMaskingAction("PASSTHROUGH");

        /// <summary>
        /// Constructs a custom ResponderErrorMaskingAction for a value not among the defined constants.
        /// </summary>
        public ResponderErrorMaskingAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderErrorMaskingAction FindValue(string value)
        {
            return FindValue<ResponderErrorMaskingAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderErrorMaskingAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResponderErrorMaskingLoggingType.
    /// </summary>
    public class ResponderErrorMaskingLoggingType : ConstantClass
    {
        /// <summary>
        /// Constant METRIC for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType METRIC = new ResponderErrorMaskingLoggingType("METRIC");

        /// <summary>
        /// Constant NONE for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType NONE = new ResponderErrorMaskingLoggingType("NONE");

        /// <summary>
        /// Constant RESPONSE for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType RESPONSE = new ResponderErrorMaskingLoggingType("RESPONSE");

        /// <summary>
        /// Constructs a custom ResponderErrorMaskingLoggingType for a value not among the defined constants.
        /// </summary>
        public ResponderErrorMaskingLoggingType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderErrorMaskingLoggingType FindValue(string value)
        {
            return FindValue<ResponderErrorMaskingLoggingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderErrorMaskingLoggingType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResponderGatewayStatus.
    /// </summary>
    public class ResponderGatewayStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ACTIVE = new ResponderGatewayStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus CREATE_FAILED = new ResponderGatewayStatus("CREATE_FAILED");

        /// <summary>
        /// Constant DELETED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus DELETED = new ResponderGatewayStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus DELETE_FAILED = new ResponderGatewayStatus("DELETE_FAILED");

        /// <summary>
        /// Constant ERROR for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ERROR = new ResponderGatewayStatus("ERROR");

        /// <summary>
        /// Constant ISOLATED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ISOLATED = new ResponderGatewayStatus("ISOLATED");

        /// <summary>
        /// Constant PENDING_CREATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_CREATION = new ResponderGatewayStatus("PENDING_CREATION");

        /// <summary>
        /// Constant PENDING_DELETION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_DELETION = new ResponderGatewayStatus("PENDING_DELETION");

        /// <summary>
        /// Constant PENDING_ISOLATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_ISOLATION = new ResponderGatewayStatus("PENDING_ISOLATION");

        /// <summary>
        /// Constant PENDING_RESTORATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_RESTORATION = new ResponderGatewayStatus("PENDING_RESTORATION");

        /// <summary>
        /// Constant PENDING_UPDATE for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_UPDATE = new ResponderGatewayStatus("PENDING_UPDATE");

        /// <summary>
        /// Constructs a custom ResponderGatewayStatus for a value not among the defined constants.
        /// </summary>
        public ResponderGatewayStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderGatewayStatus FindValue(string value)
        {
            return FindValue<ResponderGatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderGatewayStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RuleStatus.
    /// </summary>
    public class RuleStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for RuleStatus
        /// </summary>
        public static readonly RuleStatus ACTIVE = new RuleStatus("ACTIVE");

        /// <summary>
        /// Constant CREATE_FAILED for RuleStatus
        /// </summary>
        public static readonly RuleStatus CREATE_FAILED = new RuleStatus("CREATE_FAILED");

        /// <summary>
        /// Constant CREATION_IN_PROGRESS for RuleStatus
        /// </summary>
        public static readonly RuleStatus CREATION_IN_PROGRESS = new RuleStatus("CREATION_IN_PROGRESS");

        /// <summary>
        /// Constant DELETED for RuleStatus
        /// </summary>
        public static readonly RuleStatus DELETED = new RuleStatus("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for RuleStatus
        /// </summary>
        public static readonly RuleStatus DELETE_FAILED = new RuleStatus("DELETE_FAILED");

        /// <summary>
        /// Constant DELETION_IN_PROGRESS for RuleStatus
        /// </summary>
        public static readonly RuleStatus DELETION_IN_PROGRESS = new RuleStatus("DELETION_IN_PROGRESS");

        /// <summary>
        /// Constant FAILED for RuleStatus
        /// </summary>
        public static readonly RuleStatus FAILED = new RuleStatus("FAILED");

        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for RuleStatus
        /// </summary>
        public static readonly RuleStatus UPDATE_IN_PROGRESS = new RuleStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// Constructs a custom RuleStatus for a value not among the defined constants.
        /// </summary>
        public RuleStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStatus FindValue(string value)
        {
            return FindValue<RuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus ACTIVE = new SubscriptionStatus("ACTIVE");

        /// <summary>
        /// Constant EXPIRED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus EXPIRED = new SubscriptionStatus("EXPIRED");

        /// <summary>
        /// Constructs a custom SubscriptionStatus for a value not among the defined constants.
        /// </summary>
        public SubscriptionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SubscriptionType.
    /// </summary>
    public class SubscriptionType : ConstantClass
    {
        /// <summary>
        /// Constant AWS_BUILT_IN for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType AWS_BUILT_IN = new SubscriptionType("AWS_BUILT_IN");

        /// <summary>
        /// Constant MARKETPLACE for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType MARKETPLACE = new SubscriptionType("MARKETPLACE");

        /// <summary>
        /// Constant PRIVATE for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType PRIVATE = new SubscriptionType("PRIVATE");

        /// <summary>
        /// Constructs a custom SubscriptionType for a value not among the defined constants.
        /// </summary>
        public SubscriptionType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionType FindValue(string value)
        {
            return FindValue<SubscriptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus FAILED = new UpdateStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus IN_PROGRESS = new UpdateStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCESSFUL for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus SUCCESSFUL = new UpdateStatus("SUCCESSFUL");

        /// <summary>
        /// Constructs a custom UpdateStatus for a value not among the defined constants.
        /// </summary>
        public UpdateStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
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
        /// Constant GATEWAY_CONFIG_UPDATE for UpdateType
        /// </summary>
        public static readonly UpdateType GATEWAY_CONFIG_UPDATE = new UpdateType("GATEWAY_CONFIG_UPDATE");

        /// <summary>
        /// Constant LINK_CONFIG_UPDATE for UpdateType
        /// </summary>
        public static readonly UpdateType LINK_CONFIG_UPDATE = new UpdateType("LINK_CONFIG_UPDATE");

        /// <summary>
        /// Constant LINK_FLOW_UPDATE for UpdateType
        /// </summary>
        public static readonly UpdateType LINK_FLOW_UPDATE = new UpdateType("LINK_FLOW_UPDATE");

        /// <summary>
        /// Constant ROUTING_RULE_UPDATE for UpdateType
        /// </summary>
        public static readonly UpdateType ROUTING_RULE_UPDATE = new UpdateType("ROUTING_RULE_UPDATE");

        /// <summary>
        /// Constructs a custom UpdateType for a value not among the defined constants.
        /// </summary>
        public UpdateType(string value) : base(value) { }

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
}

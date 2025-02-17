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
    /// Constants used for properties of type AttachmentErrorCode.
    /// </summary>
    public class AttachmentErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_CONNECT_GATEWAY_EXISTING_ATTACHMENTS for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode DIRECT_CONNECT_GATEWAY_EXISTING_ATTACHMENTS = new AttachmentErrorCode("DIRECT_CONNECT_GATEWAY_EXISTING_ATTACHMENTS");
        /// <summary>
        /// Constant DIRECT_CONNECT_GATEWAY_NO_PRIVATE_VIF for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode DIRECT_CONNECT_GATEWAY_NO_PRIVATE_VIF = new AttachmentErrorCode("DIRECT_CONNECT_GATEWAY_NO_PRIVATE_VIF");
        /// <summary>
        /// Constant DIRECT_CONNECT_GATEWAY_NOT_FOUND for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode DIRECT_CONNECT_GATEWAY_NOT_FOUND = new AttachmentErrorCode("DIRECT_CONNECT_GATEWAY_NOT_FOUND");
        /// <summary>
        /// Constant MAXIMUM_NO_ENCAP_LIMIT_EXCEEDED for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode MAXIMUM_NO_ENCAP_LIMIT_EXCEEDED = new AttachmentErrorCode("MAXIMUM_NO_ENCAP_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SUBNET_DUPLICATED_IN_AVAILABILITY_ZONE for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode SUBNET_DUPLICATED_IN_AVAILABILITY_ZONE = new AttachmentErrorCode("SUBNET_DUPLICATED_IN_AVAILABILITY_ZONE");
        /// <summary>
        /// Constant SUBNET_NO_FREE_ADDRESSES for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode SUBNET_NO_FREE_ADDRESSES = new AttachmentErrorCode("SUBNET_NO_FREE_ADDRESSES");
        /// <summary>
        /// Constant SUBNET_NO_IPV6_CIDRS for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode SUBNET_NO_IPV6_CIDRS = new AttachmentErrorCode("SUBNET_NO_IPV6_CIDRS");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode SUBNET_NOT_FOUND = new AttachmentErrorCode("SUBNET_NOT_FOUND");
        /// <summary>
        /// Constant SUBNET_UNSUPPORTED_AVAILABILITY_ZONE for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode SUBNET_UNSUPPORTED_AVAILABILITY_ZONE = new AttachmentErrorCode("SUBNET_UNSUPPORTED_AVAILABILITY_ZONE");
        /// <summary>
        /// Constant VPC_NOT_FOUND for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode VPC_NOT_FOUND = new AttachmentErrorCode("VPC_NOT_FOUND");
        /// <summary>
        /// Constant VPN_CONNECTION_NOT_FOUND for AttachmentErrorCode
        /// </summary>
        public static readonly AttachmentErrorCode VPN_CONNECTION_NOT_FOUND = new AttachmentErrorCode("VPN_CONNECTION_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentErrorCode FindValue(string value)
        {
            return FindValue<AttachmentErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentState.
    /// </summary>
    public class AttachmentState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for AttachmentState
        /// </summary>
        public static readonly AttachmentState AVAILABLE = new AttachmentState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for AttachmentState
        /// </summary>
        public static readonly AttachmentState CREATING = new AttachmentState("CREATING");
        /// <summary>
        /// Constant DELETING for AttachmentState
        /// </summary>
        public static readonly AttachmentState DELETING = new AttachmentState("DELETING");
        /// <summary>
        /// Constant FAILED for AttachmentState
        /// </summary>
        public static readonly AttachmentState FAILED = new AttachmentState("FAILED");
        /// <summary>
        /// Constant PENDING_ATTACHMENT_ACCEPTANCE for AttachmentState
        /// </summary>
        public static readonly AttachmentState PENDING_ATTACHMENT_ACCEPTANCE = new AttachmentState("PENDING_ATTACHMENT_ACCEPTANCE");
        /// <summary>
        /// Constant PENDING_NETWORK_UPDATE for AttachmentState
        /// </summary>
        public static readonly AttachmentState PENDING_NETWORK_UPDATE = new AttachmentState("PENDING_NETWORK_UPDATE");
        /// <summary>
        /// Constant PENDING_TAG_ACCEPTANCE for AttachmentState
        /// </summary>
        public static readonly AttachmentState PENDING_TAG_ACCEPTANCE = new AttachmentState("PENDING_TAG_ACCEPTANCE");
        /// <summary>
        /// Constant REJECTED for AttachmentState
        /// </summary>
        public static readonly AttachmentState REJECTED = new AttachmentState("REJECTED");
        /// <summary>
        /// Constant UPDATING for AttachmentState
        /// </summary>
        public static readonly AttachmentState UPDATING = new AttachmentState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentState FindValue(string value)
        {
            return FindValue<AttachmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentType.
    /// </summary>
    public class AttachmentType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT for AttachmentType
        /// </summary>
        public static readonly AttachmentType CONNECT = new AttachmentType("CONNECT");
        /// <summary>
        /// Constant DIRECT_CONNECT_GATEWAY for AttachmentType
        /// </summary>
        public static readonly AttachmentType DIRECT_CONNECT_GATEWAY = new AttachmentType("DIRECT_CONNECT_GATEWAY");
        /// <summary>
        /// Constant SITE_TO_SITE_VPN for AttachmentType
        /// </summary>
        public static readonly AttachmentType SITE_TO_SITE_VPN = new AttachmentType("SITE_TO_SITE_VPN");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ROUTE_TABLE for AttachmentType
        /// </summary>
        public static readonly AttachmentType TRANSIT_GATEWAY_ROUTE_TABLE = new AttachmentType("TRANSIT_GATEWAY_ROUTE_TABLE");
        /// <summary>
        /// Constant VPC for AttachmentType
        /// </summary>
        public static readonly AttachmentType VPC = new AttachmentType("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentType FindValue(string value)
        {
            return FindValue<AttachmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant ADD for ChangeAction
        /// </summary>
        public static readonly ChangeAction ADD = new ChangeAction("ADD");
        /// <summary>
        /// Constant MODIFY for ChangeAction
        /// </summary>
        public static readonly ChangeAction MODIFY = new ChangeAction("MODIFY");
        /// <summary>
        /// Constant REMOVE for ChangeAction
        /// </summary>
        public static readonly ChangeAction REMOVE = new ChangeAction("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeSetState.
    /// </summary>
    public class ChangeSetState : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTING for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState EXECUTING = new ChangeSetState("EXECUTING");
        /// <summary>
        /// Constant EXECUTION_SUCCEEDED for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState EXECUTION_SUCCEEDED = new ChangeSetState("EXECUTION_SUCCEEDED");
        /// <summary>
        /// Constant FAILED_GENERATION for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState FAILED_GENERATION = new ChangeSetState("FAILED_GENERATION");
        /// <summary>
        /// Constant OUT_OF_DATE for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState OUT_OF_DATE = new ChangeSetState("OUT_OF_DATE");
        /// <summary>
        /// Constant PENDING_GENERATION for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState PENDING_GENERATION = new ChangeSetState("PENDING_GENERATION");
        /// <summary>
        /// Constant READY_TO_EXECUTE for ChangeSetState
        /// </summary>
        public static readonly ChangeSetState READY_TO_EXECUTE = new ChangeSetState("READY_TO_EXECUTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeSetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeSetState FindValue(string value)
        {
            return FindValue<ChangeSetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeSetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeStatus.
    /// </summary>
    public class ChangeStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus COMPLETE = new ChangeStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus FAILED = new ChangeStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus IN_PROGRESS = new ChangeStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus NOT_STARTED = new ChangeStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeStatus FindValue(string value)
        {
            return FindValue<ChangeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT_MAPPING for ChangeType
        /// </summary>
        public static readonly ChangeType ATTACHMENT_MAPPING = new ChangeType("ATTACHMENT_MAPPING");
        /// <summary>
        /// Constant ATTACHMENT_POLICIES_CONFIGURATION for ChangeType
        /// </summary>
        public static readonly ChangeType ATTACHMENT_POLICIES_CONFIGURATION = new ChangeType("ATTACHMENT_POLICIES_CONFIGURATION");
        /// <summary>
        /// Constant ATTACHMENT_ROUTE_PROPAGATION for ChangeType
        /// </summary>
        public static readonly ChangeType ATTACHMENT_ROUTE_PROPAGATION = new ChangeType("ATTACHMENT_ROUTE_PROPAGATION");
        /// <summary>
        /// Constant ATTACHMENT_ROUTE_STATIC for ChangeType
        /// </summary>
        public static readonly ChangeType ATTACHMENT_ROUTE_STATIC = new ChangeType("ATTACHMENT_ROUTE_STATIC");
        /// <summary>
        /// Constant CORE_NETWORK_CONFIGURATION for ChangeType
        /// </summary>
        public static readonly ChangeType CORE_NETWORK_CONFIGURATION = new ChangeType("CORE_NETWORK_CONFIGURATION");
        /// <summary>
        /// Constant CORE_NETWORK_EDGE for ChangeType
        /// </summary>
        public static readonly ChangeType CORE_NETWORK_EDGE = new ChangeType("CORE_NETWORK_EDGE");
        /// <summary>
        /// Constant CORE_NETWORK_SEGMENT for ChangeType
        /// </summary>
        public static readonly ChangeType CORE_NETWORK_SEGMENT = new ChangeType("CORE_NETWORK_SEGMENT");
        /// <summary>
        /// Constant NETWORK_FUNCTION_GROUP for ChangeType
        /// </summary>
        public static readonly ChangeType NETWORK_FUNCTION_GROUP = new ChangeType("NETWORK_FUNCTION_GROUP");
        /// <summary>
        /// Constant SEGMENT_ACTIONS_CONFIGURATION for ChangeType
        /// </summary>
        public static readonly ChangeType SEGMENT_ACTIONS_CONFIGURATION = new ChangeType("SEGMENT_ACTIONS_CONFIGURATION");
        /// <summary>
        /// Constant SEGMENTS_CONFIGURATION for ChangeType
        /// </summary>
        public static readonly ChangeType SEGMENTS_CONFIGURATION = new ChangeType("SEGMENTS_CONFIGURATION");

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
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DOWN for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DOWN = new ConnectionStatus("DOWN");
        /// <summary>
        /// Constant UP for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus UP = new ConnectionStatus("UP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
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
        /// Constant BGP for ConnectionType
        /// </summary>
        public static readonly ConnectionType BGP = new ConnectionType("BGP");
        /// <summary>
        /// Constant IPSEC for ConnectionType
        /// </summary>
        public static readonly ConnectionType IPSEC = new ConnectionType("IPSEC");

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
    /// Constants used for properties of type ConnectPeerAssociationState.
    /// </summary>
    public class ConnectPeerAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ConnectPeerAssociationState
        /// </summary>
        public static readonly ConnectPeerAssociationState AVAILABLE = new ConnectPeerAssociationState("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ConnectPeerAssociationState
        /// </summary>
        public static readonly ConnectPeerAssociationState DELETED = new ConnectPeerAssociationState("DELETED");
        /// <summary>
        /// Constant DELETING for ConnectPeerAssociationState
        /// </summary>
        public static readonly ConnectPeerAssociationState DELETING = new ConnectPeerAssociationState("DELETING");
        /// <summary>
        /// Constant PENDING for ConnectPeerAssociationState
        /// </summary>
        public static readonly ConnectPeerAssociationState PENDING = new ConnectPeerAssociationState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectPeerAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectPeerAssociationState FindValue(string value)
        {
            return FindValue<ConnectPeerAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectPeerAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectPeerErrorCode.
    /// </summary>
    public class ConnectPeerErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant EDGE_LOCATION_NO_FREE_IPS for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode EDGE_LOCATION_NO_FREE_IPS = new ConnectPeerErrorCode("EDGE_LOCATION_NO_FREE_IPS");
        /// <summary>
        /// Constant EDGE_LOCATION_PEER_DUPLICATE for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode EDGE_LOCATION_PEER_DUPLICATE = new ConnectPeerErrorCode("EDGE_LOCATION_PEER_DUPLICATE");
        /// <summary>
        /// Constant INVALID_INSIDE_CIDR_BLOCK for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode INVALID_INSIDE_CIDR_BLOCK = new ConnectPeerErrorCode("INVALID_INSIDE_CIDR_BLOCK");
        /// <summary>
        /// Constant IP_OUTSIDE_SUBNET_CIDR_RANGE for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode IP_OUTSIDE_SUBNET_CIDR_RANGE = new ConnectPeerErrorCode("IP_OUTSIDE_SUBNET_CIDR_RANGE");
        /// <summary>
        /// Constant NO_ASSOCIATED_CIDR_BLOCK for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode NO_ASSOCIATED_CIDR_BLOCK = new ConnectPeerErrorCode("NO_ASSOCIATED_CIDR_BLOCK");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for ConnectPeerErrorCode
        /// </summary>
        public static readonly ConnectPeerErrorCode SUBNET_NOT_FOUND = new ConnectPeerErrorCode("SUBNET_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectPeerErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectPeerErrorCode FindValue(string value)
        {
            return FindValue<ConnectPeerErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectPeerErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectPeerState.
    /// </summary>
    public class ConnectPeerState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ConnectPeerState
        /// </summary>
        public static readonly ConnectPeerState AVAILABLE = new ConnectPeerState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for ConnectPeerState
        /// </summary>
        public static readonly ConnectPeerState CREATING = new ConnectPeerState("CREATING");
        /// <summary>
        /// Constant DELETING for ConnectPeerState
        /// </summary>
        public static readonly ConnectPeerState DELETING = new ConnectPeerState("DELETING");
        /// <summary>
        /// Constant FAILED for ConnectPeerState
        /// </summary>
        public static readonly ConnectPeerState FAILED = new ConnectPeerState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectPeerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectPeerState FindValue(string value)
        {
            return FindValue<ConnectPeerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectPeerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoreNetworkPolicyAlias.
    /// </summary>
    public class CoreNetworkPolicyAlias : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for CoreNetworkPolicyAlias
        /// </summary>
        public static readonly CoreNetworkPolicyAlias LATEST = new CoreNetworkPolicyAlias("LATEST");
        /// <summary>
        /// Constant LIVE for CoreNetworkPolicyAlias
        /// </summary>
        public static readonly CoreNetworkPolicyAlias LIVE = new CoreNetworkPolicyAlias("LIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoreNetworkPolicyAlias(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoreNetworkPolicyAlias FindValue(string value)
        {
            return FindValue<CoreNetworkPolicyAlias>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoreNetworkPolicyAlias(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoreNetworkState.
    /// </summary>
    public class CoreNetworkState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for CoreNetworkState
        /// </summary>
        public static readonly CoreNetworkState AVAILABLE = new CoreNetworkState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for CoreNetworkState
        /// </summary>
        public static readonly CoreNetworkState CREATING = new CoreNetworkState("CREATING");
        /// <summary>
        /// Constant DELETING for CoreNetworkState
        /// </summary>
        public static readonly CoreNetworkState DELETING = new CoreNetworkState("DELETING");
        /// <summary>
        /// Constant UPDATING for CoreNetworkState
        /// </summary>
        public static readonly CoreNetworkState UPDATING = new CoreNetworkState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoreNetworkState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoreNetworkState FindValue(string value)
        {
            return FindValue<CoreNetworkState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoreNetworkState(string value)
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
    /// Constants used for properties of type PeeringErrorCode.
    /// </summary>
    public class PeeringErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant EDGE_LOCATION_PEER_DUPLICATE for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode EDGE_LOCATION_PEER_DUPLICATE = new PeeringErrorCode("EDGE_LOCATION_PEER_DUPLICATE");
        /// <summary>
        /// Constant INTERNAL_ERROR for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode INTERNAL_ERROR = new PeeringErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_TRANSIT_GATEWAY_STATE for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode INVALID_TRANSIT_GATEWAY_STATE = new PeeringErrorCode("INVALID_TRANSIT_GATEWAY_STATE");
        /// <summary>
        /// Constant MISSING_PERMISSIONS for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode MISSING_PERMISSIONS = new PeeringErrorCode("MISSING_PERMISSIONS");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_NOT_FOUND for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode TRANSIT_GATEWAY_NOT_FOUND = new PeeringErrorCode("TRANSIT_GATEWAY_NOT_FOUND");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_PEERS_LIMIT_EXCEEDED for PeeringErrorCode
        /// </summary>
        public static readonly PeeringErrorCode TRANSIT_GATEWAY_PEERS_LIMIT_EXCEEDED = new PeeringErrorCode("TRANSIT_GATEWAY_PEERS_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeeringErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeeringErrorCode FindValue(string value)
        {
            return FindValue<PeeringErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeeringErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PeeringState.
    /// </summary>
    public class PeeringState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for PeeringState
        /// </summary>
        public static readonly PeeringState AVAILABLE = new PeeringState("AVAILABLE");
        /// <summary>
        /// Constant CREATING for PeeringState
        /// </summary>
        public static readonly PeeringState CREATING = new PeeringState("CREATING");
        /// <summary>
        /// Constant DELETING for PeeringState
        /// </summary>
        public static readonly PeeringState DELETING = new PeeringState("DELETING");
        /// <summary>
        /// Constant FAILED for PeeringState
        /// </summary>
        public static readonly PeeringState FAILED = new PeeringState("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeeringState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeeringState FindValue(string value)
        {
            return FindValue<PeeringState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeeringState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PeeringType.
    /// </summary>
    public class PeeringType : ConstantClass
    {

        /// <summary>
        /// Constant TRANSIT_GATEWAY for PeeringType
        /// </summary>
        public static readonly PeeringType TRANSIT_GATEWAY = new PeeringType("TRANSIT_GATEWAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeeringType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeeringType FindValue(string value)
        {
            return FindValue<PeeringType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeeringType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteAnalysisCompletionReasonCode.
    /// </summary>
    public class RouteAnalysisCompletionReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant BLACKHOLE_ROUTE_FOR_DESTINATION_FOUND for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode BLACKHOLE_ROUTE_FOR_DESTINATION_FOUND = new RouteAnalysisCompletionReasonCode("BLACKHOLE_ROUTE_FOR_DESTINATION_FOUND");
        /// <summary>
        /// Constant CYCLIC_PATH_DETECTED for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode CYCLIC_PATH_DETECTED = new RouteAnalysisCompletionReasonCode("CYCLIC_PATH_DETECTED");
        /// <summary>
        /// Constant INACTIVE_ROUTE_FOR_DESTINATION_FOUND for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode INACTIVE_ROUTE_FOR_DESTINATION_FOUND = new RouteAnalysisCompletionReasonCode("INACTIVE_ROUTE_FOR_DESTINATION_FOUND");
        /// <summary>
        /// Constant MAX_HOPS_EXCEEDED for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode MAX_HOPS_EXCEEDED = new RouteAnalysisCompletionReasonCode("MAX_HOPS_EXCEEDED");
        /// <summary>
        /// Constant NO_DESTINATION_ARN_PROVIDED for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode NO_DESTINATION_ARN_PROVIDED = new RouteAnalysisCompletionReasonCode("NO_DESTINATION_ARN_PROVIDED");
        /// <summary>
        /// Constant POSSIBLE_MIDDLEBOX for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode POSSIBLE_MIDDLEBOX = new RouteAnalysisCompletionReasonCode("POSSIBLE_MIDDLEBOX");
        /// <summary>
        /// Constant ROUTE_NOT_FOUND for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode ROUTE_NOT_FOUND = new RouteAnalysisCompletionReasonCode("ROUTE_NOT_FOUND");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ATTACHMENT_ATTACH_ARN_NO_MATCH for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode TRANSIT_GATEWAY_ATTACHMENT_ATTACH_ARN_NO_MATCH = new RouteAnalysisCompletionReasonCode("TRANSIT_GATEWAY_ATTACHMENT_ATTACH_ARN_NO_MATCH");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ATTACHMENT_NOT_FOUND for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode TRANSIT_GATEWAY_ATTACHMENT_NOT_FOUND = new RouteAnalysisCompletionReasonCode("TRANSIT_GATEWAY_ATTACHMENT_NOT_FOUND");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ATTACHMENT_NOT_IN_TRANSIT_GATEWAY for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode TRANSIT_GATEWAY_ATTACHMENT_NOT_IN_TRANSIT_GATEWAY = new RouteAnalysisCompletionReasonCode("TRANSIT_GATEWAY_ATTACHMENT_NOT_IN_TRANSIT_GATEWAY");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ATTACHMENT_STABLE_ROUTE_TABLE_NOT_FOUND for RouteAnalysisCompletionReasonCode
        /// </summary>
        public static readonly RouteAnalysisCompletionReasonCode TRANSIT_GATEWAY_ATTACHMENT_STABLE_ROUTE_TABLE_NOT_FOUND = new RouteAnalysisCompletionReasonCode("TRANSIT_GATEWAY_ATTACHMENT_STABLE_ROUTE_TABLE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteAnalysisCompletionReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteAnalysisCompletionReasonCode FindValue(string value)
        {
            return FindValue<RouteAnalysisCompletionReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteAnalysisCompletionReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteAnalysisCompletionResultCode.
    /// </summary>
    public class RouteAnalysisCompletionResultCode : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for RouteAnalysisCompletionResultCode
        /// </summary>
        public static readonly RouteAnalysisCompletionResultCode CONNECTED = new RouteAnalysisCompletionResultCode("CONNECTED");
        /// <summary>
        /// Constant NOT_CONNECTED for RouteAnalysisCompletionResultCode
        /// </summary>
        public static readonly RouteAnalysisCompletionResultCode NOT_CONNECTED = new RouteAnalysisCompletionResultCode("NOT_CONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteAnalysisCompletionResultCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteAnalysisCompletionResultCode FindValue(string value)
        {
            return FindValue<RouteAnalysisCompletionResultCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteAnalysisCompletionResultCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouteAnalysisStatus.
    /// </summary>
    public class RouteAnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for RouteAnalysisStatus
        /// </summary>
        public static readonly RouteAnalysisStatus COMPLETED = new RouteAnalysisStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for RouteAnalysisStatus
        /// </summary>
        public static readonly RouteAnalysisStatus FAILED = new RouteAnalysisStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for RouteAnalysisStatus
        /// </summary>
        public static readonly RouteAnalysisStatus RUNNING = new RouteAnalysisStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteAnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteAnalysisStatus FindValue(string value)
        {
            return FindValue<RouteAnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteAnalysisStatus(string value)
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
        /// Constant BLACKHOLE for RouteState
        /// </summary>
        public static readonly RouteState BLACKHOLE = new RouteState("BLACKHOLE");

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
    /// Constants used for properties of type RouteTableType.
    /// </summary>
    public class RouteTableType : ConstantClass
    {

        /// <summary>
        /// Constant CORE_NETWORK_SEGMENT for RouteTableType
        /// </summary>
        public static readonly RouteTableType CORE_NETWORK_SEGMENT = new RouteTableType("CORE_NETWORK_SEGMENT");
        /// <summary>
        /// Constant NETWORK_FUNCTION_GROUP for RouteTableType
        /// </summary>
        public static readonly RouteTableType NETWORK_FUNCTION_GROUP = new RouteTableType("NETWORK_FUNCTION_GROUP");
        /// <summary>
        /// Constant TRANSIT_GATEWAY_ROUTE_TABLE for RouteTableType
        /// </summary>
        public static readonly RouteTableType TRANSIT_GATEWAY_ROUTE_TABLE = new RouteTableType("TRANSIT_GATEWAY_ROUTE_TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouteTableType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteTableType FindValue(string value)
        {
            return FindValue<RouteTableType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouteTableType(string value)
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
        /// Constant PROPAGATED for RouteType
        /// </summary>
        public static readonly RouteType PROPAGATED = new RouteType("PROPAGATED");
        /// <summary>
        /// Constant STATIC for RouteType
        /// </summary>
        public static readonly RouteType STATIC = new RouteType("STATIC");

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
    /// Constants used for properties of type SegmentActionServiceInsertion.
    /// </summary>
    public class SegmentActionServiceInsertion : ConstantClass
    {

        /// <summary>
        /// Constant SendTo for SegmentActionServiceInsertion
        /// </summary>
        public static readonly SegmentActionServiceInsertion SendTo = new SegmentActionServiceInsertion("send-to");
        /// <summary>
        /// Constant SendVia for SegmentActionServiceInsertion
        /// </summary>
        public static readonly SegmentActionServiceInsertion SendVia = new SegmentActionServiceInsertion("send-via");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentActionServiceInsertion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentActionServiceInsertion FindValue(string value)
        {
            return FindValue<SegmentActionServiceInsertion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentActionServiceInsertion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SendViaMode.
    /// </summary>
    public class SendViaMode : ConstantClass
    {

        /// <summary>
        /// Constant DualHop for SendViaMode
        /// </summary>
        public static readonly SendViaMode DualHop = new SendViaMode("dual-hop");
        /// <summary>
        /// Constant SingleHop for SendViaMode
        /// </summary>
        public static readonly SendViaMode SingleHop = new SendViaMode("single-hop");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SendViaMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SendViaMode FindValue(string value)
        {
            return FindValue<SendViaMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SendViaMode(string value)
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
    /// Constants used for properties of type TunnelProtocol.
    /// </summary>
    public class TunnelProtocol : ConstantClass
    {

        /// <summary>
        /// Constant GRE for TunnelProtocol
        /// </summary>
        public static readonly TunnelProtocol GRE = new TunnelProtocol("GRE");
        /// <summary>
        /// Constant NO_ENCAP for TunnelProtocol
        /// </summary>
        public static readonly TunnelProtocol NO_ENCAP = new TunnelProtocol("NO_ENCAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TunnelProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TunnelProtocol FindValue(string value)
        {
            return FindValue<TunnelProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TunnelProtocol(string value)
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
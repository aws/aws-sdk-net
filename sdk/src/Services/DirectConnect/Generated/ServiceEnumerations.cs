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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DirectConnect
{

    /// <summary>
    /// Constants used for properties of type AddressFamily.
    /// </summary>
    public class AddressFamily : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for AddressFamily
        /// </summary>
        public static readonly AddressFamily Ipv4 = new AddressFamily("ipv4");
        /// <summary>
        /// Constant Ipv6 for AddressFamily
        /// </summary>
        public static readonly AddressFamily Ipv6 = new AddressFamily("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddressFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddressFamily FindValue(string value)
        {
            return FindValue<AddressFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddressFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BGPPeerState.
    /// </summary>
    public class BGPPeerState : ConstantClass
    {

        /// <summary>
        /// Constant Available for BGPPeerState
        /// </summary>
        public static readonly BGPPeerState Available = new BGPPeerState("available");
        /// <summary>
        /// Constant Deleted for BGPPeerState
        /// </summary>
        public static readonly BGPPeerState Deleted = new BGPPeerState("deleted");
        /// <summary>
        /// Constant Deleting for BGPPeerState
        /// </summary>
        public static readonly BGPPeerState Deleting = new BGPPeerState("deleting");
        /// <summary>
        /// Constant Pending for BGPPeerState
        /// </summary>
        public static readonly BGPPeerState Pending = new BGPPeerState("pending");
        /// <summary>
        /// Constant Verifying for BGPPeerState
        /// </summary>
        public static readonly BGPPeerState Verifying = new BGPPeerState("verifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BGPPeerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BGPPeerState FindValue(string value)
        {
            return FindValue<BGPPeerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BGPPeerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BGPStatus.
    /// </summary>
    public class BGPStatus : ConstantClass
    {

        /// <summary>
        /// Constant Down for BGPStatus
        /// </summary>
        public static readonly BGPStatus Down = new BGPStatus("down");
        /// <summary>
        /// Constant Unknown for BGPStatus
        /// </summary>
        public static readonly BGPStatus Unknown = new BGPStatus("unknown");
        /// <summary>
        /// Constant Up for BGPStatus
        /// </summary>
        public static readonly BGPStatus Up = new BGPStatus("up");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BGPStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BGPStatus FindValue(string value)
        {
            return FindValue<BGPStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BGPStatus(string value)
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
        /// Constant Available for ConnectionState
        /// </summary>
        public static readonly ConnectionState Available = new ConnectionState("available");
        /// <summary>
        /// Constant Deleted for ConnectionState
        /// </summary>
        public static readonly ConnectionState Deleted = new ConnectionState("deleted");
        /// <summary>
        /// Constant Deleting for ConnectionState
        /// </summary>
        public static readonly ConnectionState Deleting = new ConnectionState("deleting");
        /// <summary>
        /// Constant Down for ConnectionState
        /// </summary>
        public static readonly ConnectionState Down = new ConnectionState("down");
        /// <summary>
        /// Constant Ordering for ConnectionState
        /// </summary>
        public static readonly ConnectionState Ordering = new ConnectionState("ordering");
        /// <summary>
        /// Constant Pending for ConnectionState
        /// </summary>
        public static readonly ConnectionState Pending = new ConnectionState("pending");
        /// <summary>
        /// Constant Rejected for ConnectionState
        /// </summary>
        public static readonly ConnectionState Rejected = new ConnectionState("rejected");
        /// <summary>
        /// Constant Requested for ConnectionState
        /// </summary>
        public static readonly ConnectionState Requested = new ConnectionState("requested");
        /// <summary>
        /// Constant Unknown for ConnectionState
        /// </summary>
        public static readonly ConnectionState Unknown = new ConnectionState("unknown");

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
    /// Constants used for properties of type DirectConnectGatewayAssociationProposalState.
    /// </summary>
    public class DirectConnectGatewayAssociationProposalState : ConstantClass
    {

        /// <summary>
        /// Constant Accepted for DirectConnectGatewayAssociationProposalState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationProposalState Accepted = new DirectConnectGatewayAssociationProposalState("accepted");
        /// <summary>
        /// Constant Deleted for DirectConnectGatewayAssociationProposalState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationProposalState Deleted = new DirectConnectGatewayAssociationProposalState("deleted");
        /// <summary>
        /// Constant Requested for DirectConnectGatewayAssociationProposalState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationProposalState Requested = new DirectConnectGatewayAssociationProposalState("requested");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectConnectGatewayAssociationProposalState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectConnectGatewayAssociationProposalState FindValue(string value)
        {
            return FindValue<DirectConnectGatewayAssociationProposalState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectConnectGatewayAssociationProposalState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectConnectGatewayAssociationState.
    /// </summary>
    public class DirectConnectGatewayAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant Associated for DirectConnectGatewayAssociationState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationState Associated = new DirectConnectGatewayAssociationState("associated");
        /// <summary>
        /// Constant Associating for DirectConnectGatewayAssociationState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationState Associating = new DirectConnectGatewayAssociationState("associating");
        /// <summary>
        /// Constant Disassociated for DirectConnectGatewayAssociationState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationState Disassociated = new DirectConnectGatewayAssociationState("disassociated");
        /// <summary>
        /// Constant Disassociating for DirectConnectGatewayAssociationState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationState Disassociating = new DirectConnectGatewayAssociationState("disassociating");
        /// <summary>
        /// Constant Updating for DirectConnectGatewayAssociationState
        /// </summary>
        public static readonly DirectConnectGatewayAssociationState Updating = new DirectConnectGatewayAssociationState("updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectConnectGatewayAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectConnectGatewayAssociationState FindValue(string value)
        {
            return FindValue<DirectConnectGatewayAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectConnectGatewayAssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectConnectGatewayAttachmentState.
    /// </summary>
    public class DirectConnectGatewayAttachmentState : ConstantClass
    {

        /// <summary>
        /// Constant Attached for DirectConnectGatewayAttachmentState
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentState Attached = new DirectConnectGatewayAttachmentState("attached");
        /// <summary>
        /// Constant Attaching for DirectConnectGatewayAttachmentState
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentState Attaching = new DirectConnectGatewayAttachmentState("attaching");
        /// <summary>
        /// Constant Detached for DirectConnectGatewayAttachmentState
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentState Detached = new DirectConnectGatewayAttachmentState("detached");
        /// <summary>
        /// Constant Detaching for DirectConnectGatewayAttachmentState
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentState Detaching = new DirectConnectGatewayAttachmentState("detaching");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectConnectGatewayAttachmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectConnectGatewayAttachmentState FindValue(string value)
        {
            return FindValue<DirectConnectGatewayAttachmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectConnectGatewayAttachmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectConnectGatewayAttachmentType.
    /// </summary>
    public class DirectConnectGatewayAttachmentType : ConstantClass
    {

        /// <summary>
        /// Constant PrivateVirtualInterface for DirectConnectGatewayAttachmentType
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentType PrivateVirtualInterface = new DirectConnectGatewayAttachmentType("PrivateVirtualInterface");
        /// <summary>
        /// Constant TransitVirtualInterface for DirectConnectGatewayAttachmentType
        /// </summary>
        public static readonly DirectConnectGatewayAttachmentType TransitVirtualInterface = new DirectConnectGatewayAttachmentType("TransitVirtualInterface");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectConnectGatewayAttachmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectConnectGatewayAttachmentType FindValue(string value)
        {
            return FindValue<DirectConnectGatewayAttachmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectConnectGatewayAttachmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectConnectGatewayState.
    /// </summary>
    public class DirectConnectGatewayState : ConstantClass
    {

        /// <summary>
        /// Constant Available for DirectConnectGatewayState
        /// </summary>
        public static readonly DirectConnectGatewayState Available = new DirectConnectGatewayState("available");
        /// <summary>
        /// Constant Deleted for DirectConnectGatewayState
        /// </summary>
        public static readonly DirectConnectGatewayState Deleted = new DirectConnectGatewayState("deleted");
        /// <summary>
        /// Constant Deleting for DirectConnectGatewayState
        /// </summary>
        public static readonly DirectConnectGatewayState Deleting = new DirectConnectGatewayState("deleting");
        /// <summary>
        /// Constant Pending for DirectConnectGatewayState
        /// </summary>
        public static readonly DirectConnectGatewayState Pending = new DirectConnectGatewayState("pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectConnectGatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectConnectGatewayState FindValue(string value)
        {
            return FindValue<DirectConnectGatewayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectConnectGatewayState(string value)
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
        /// Constant TransitGateway for GatewayType
        /// </summary>
        public static readonly GatewayType TransitGateway = new GatewayType("transitGateway");
        /// <summary>
        /// Constant VirtualPrivateGateway for GatewayType
        /// </summary>
        public static readonly GatewayType VirtualPrivateGateway = new GatewayType("virtualPrivateGateway");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type HasLogicalRedundancy.
    /// </summary>
    public class HasLogicalRedundancy : ConstantClass
    {

        /// <summary>
        /// Constant No for HasLogicalRedundancy
        /// </summary>
        public static readonly HasLogicalRedundancy No = new HasLogicalRedundancy("no");
        /// <summary>
        /// Constant Unknown for HasLogicalRedundancy
        /// </summary>
        public static readonly HasLogicalRedundancy Unknown = new HasLogicalRedundancy("unknown");
        /// <summary>
        /// Constant Yes for HasLogicalRedundancy
        /// </summary>
        public static readonly HasLogicalRedundancy Yes = new HasLogicalRedundancy("yes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HasLogicalRedundancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HasLogicalRedundancy FindValue(string value)
        {
            return FindValue<HasLogicalRedundancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HasLogicalRedundancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InterconnectState.
    /// </summary>
    public class InterconnectState : ConstantClass
    {

        /// <summary>
        /// Constant Available for InterconnectState
        /// </summary>
        public static readonly InterconnectState Available = new InterconnectState("available");
        /// <summary>
        /// Constant Deleted for InterconnectState
        /// </summary>
        public static readonly InterconnectState Deleted = new InterconnectState("deleted");
        /// <summary>
        /// Constant Deleting for InterconnectState
        /// </summary>
        public static readonly InterconnectState Deleting = new InterconnectState("deleting");
        /// <summary>
        /// Constant Down for InterconnectState
        /// </summary>
        public static readonly InterconnectState Down = new InterconnectState("down");
        /// <summary>
        /// Constant Pending for InterconnectState
        /// </summary>
        public static readonly InterconnectState Pending = new InterconnectState("pending");
        /// <summary>
        /// Constant Requested for InterconnectState
        /// </summary>
        public static readonly InterconnectState Requested = new InterconnectState("requested");
        /// <summary>
        /// Constant Unknown for InterconnectState
        /// </summary>
        public static readonly InterconnectState Unknown = new InterconnectState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterconnectState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterconnectState FindValue(string value)
        {
            return FindValue<InterconnectState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterconnectState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LagState.
    /// </summary>
    public class LagState : ConstantClass
    {

        /// <summary>
        /// Constant Available for LagState
        /// </summary>
        public static readonly LagState Available = new LagState("available");
        /// <summary>
        /// Constant Deleted for LagState
        /// </summary>
        public static readonly LagState Deleted = new LagState("deleted");
        /// <summary>
        /// Constant Deleting for LagState
        /// </summary>
        public static readonly LagState Deleting = new LagState("deleting");
        /// <summary>
        /// Constant Down for LagState
        /// </summary>
        public static readonly LagState Down = new LagState("down");
        /// <summary>
        /// Constant Pending for LagState
        /// </summary>
        public static readonly LagState Pending = new LagState("pending");
        /// <summary>
        /// Constant Requested for LagState
        /// </summary>
        public static readonly LagState Requested = new LagState("requested");
        /// <summary>
        /// Constant Unknown for LagState
        /// </summary>
        public static readonly LagState Unknown = new LagState("unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LagState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LagState FindValue(string value)
        {
            return FindValue<LagState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LagState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoaContentType.
    /// </summary>
    public class LoaContentType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationPdf for LoaContentType
        /// </summary>
        public static readonly LoaContentType ApplicationPdf = new LoaContentType("application/pdf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoaContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoaContentType FindValue(string value)
        {
            return FindValue<LoaContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoaContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NniPartnerType.
    /// </summary>
    public class NniPartnerType : ConstantClass
    {

        /// <summary>
        /// Constant NonPartner for NniPartnerType
        /// </summary>
        public static readonly NniPartnerType NonPartner = new NniPartnerType("nonPartner");
        /// <summary>
        /// Constant V1 for NniPartnerType
        /// </summary>
        public static readonly NniPartnerType V1 = new NniPartnerType("v1");
        /// <summary>
        /// Constant V2 for NniPartnerType
        /// </summary>
        public static readonly NniPartnerType V2 = new NniPartnerType("v2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NniPartnerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NniPartnerType FindValue(string value)
        {
            return FindValue<NniPartnerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NniPartnerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VirtualInterfaceState.
    /// </summary>
    public class VirtualInterfaceState : ConstantClass
    {

        /// <summary>
        /// Constant Available for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Available = new VirtualInterfaceState("available");
        /// <summary>
        /// Constant Confirming for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Confirming = new VirtualInterfaceState("confirming");
        /// <summary>
        /// Constant Deleted for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Deleted = new VirtualInterfaceState("deleted");
        /// <summary>
        /// Constant Deleting for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Deleting = new VirtualInterfaceState("deleting");
        /// <summary>
        /// Constant Down for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Down = new VirtualInterfaceState("down");
        /// <summary>
        /// Constant Pending for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Pending = new VirtualInterfaceState("pending");
        /// <summary>
        /// Constant Rejected for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Rejected = new VirtualInterfaceState("rejected");
        /// <summary>
        /// Constant Testing for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Testing = new VirtualInterfaceState("testing");
        /// <summary>
        /// Constant Unknown for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Unknown = new VirtualInterfaceState("unknown");
        /// <summary>
        /// Constant Verifying for VirtualInterfaceState
        /// </summary>
        public static readonly VirtualInterfaceState Verifying = new VirtualInterfaceState("verifying");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VirtualInterfaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualInterfaceState FindValue(string value)
        {
            return FindValue<VirtualInterfaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VirtualInterfaceState(string value)
        {
            return FindValue(value);
        }
    }

}
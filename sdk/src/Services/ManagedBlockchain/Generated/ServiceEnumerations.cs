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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ManagedBlockchain
{

    /// <summary>
    /// Constants used for properties of type AccessorNetworkType.
    /// </summary>
    public class AccessorNetworkType : ConstantClass
    {

        /// <summary>
        /// Constant ETHEREUM_GOERLI for AccessorNetworkType
        /// </summary>
        public static readonly AccessorNetworkType ETHEREUM_GOERLI = new AccessorNetworkType("ETHEREUM_GOERLI");
        /// <summary>
        /// Constant ETHEREUM_MAINNET for AccessorNetworkType
        /// </summary>
        public static readonly AccessorNetworkType ETHEREUM_MAINNET = new AccessorNetworkType("ETHEREUM_MAINNET");
        /// <summary>
        /// Constant ETHEREUM_MAINNET_AND_GOERLI for AccessorNetworkType
        /// </summary>
        public static readonly AccessorNetworkType ETHEREUM_MAINNET_AND_GOERLI = new AccessorNetworkType("ETHEREUM_MAINNET_AND_GOERLI");
        /// <summary>
        /// Constant POLYGON_MAINNET for AccessorNetworkType
        /// </summary>
        public static readonly AccessorNetworkType POLYGON_MAINNET = new AccessorNetworkType("POLYGON_MAINNET");
        /// <summary>
        /// Constant POLYGON_MUMBAI for AccessorNetworkType
        /// </summary>
        public static readonly AccessorNetworkType POLYGON_MUMBAI = new AccessorNetworkType("POLYGON_MUMBAI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessorNetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessorNetworkType FindValue(string value)
        {
            return FindValue<AccessorNetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessorNetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessorStatus.
    /// </summary>
    public class AccessorStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for AccessorStatus
        /// </summary>
        public static readonly AccessorStatus AVAILABLE = new AccessorStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for AccessorStatus
        /// </summary>
        public static readonly AccessorStatus DELETED = new AccessorStatus("DELETED");
        /// <summary>
        /// Constant PENDING_DELETION for AccessorStatus
        /// </summary>
        public static readonly AccessorStatus PENDING_DELETION = new AccessorStatus("PENDING_DELETION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessorStatus FindValue(string value)
        {
            return FindValue<AccessorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessorType.
    /// </summary>
    public class AccessorType : ConstantClass
    {

        /// <summary>
        /// Constant BILLING_TOKEN for AccessorType
        /// </summary>
        public static readonly AccessorType BILLING_TOKEN = new AccessorType("BILLING_TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessorType FindValue(string value)
        {
            return FindValue<AccessorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Edition.
    /// </summary>
    public class Edition : ConstantClass
    {

        /// <summary>
        /// Constant STANDARD for Edition
        /// </summary>
        public static readonly Edition STANDARD = new Edition("STANDARD");
        /// <summary>
        /// Constant STARTER for Edition
        /// </summary>
        public static readonly Edition STARTER = new Edition("STARTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Edition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Edition FindValue(string value)
        {
            return FindValue<Edition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Edition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Framework.
    /// </summary>
    public class Framework : ConstantClass
    {

        /// <summary>
        /// Constant ETHEREUM for Framework
        /// </summary>
        public static readonly Framework ETHEREUM = new Framework("ETHEREUM");
        /// <summary>
        /// Constant HYPERLEDGER_FABRIC for Framework
        /// </summary>
        public static readonly Framework HYPERLEDGER_FABRIC = new Framework("HYPERLEDGER_FABRIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Framework(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Framework FindValue(string value)
        {
            return FindValue<Framework>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Framework(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvitationStatus.
    /// </summary>
    public class InvitationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus ACCEPTED = new InvitationStatus("ACCEPTED");
        /// <summary>
        /// Constant ACCEPTING for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus ACCEPTING = new InvitationStatus("ACCEPTING");
        /// <summary>
        /// Constant EXPIRED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus EXPIRED = new InvitationStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus PENDING = new InvitationStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus REJECTED = new InvitationStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvitationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvitationStatus FindValue(string value)
        {
            return FindValue<InvitationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvitationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberStatus.
    /// </summary>
    public class MemberStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for MemberStatus
        /// </summary>
        public static readonly MemberStatus AVAILABLE = new MemberStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_FAILED for MemberStatus
        /// </summary>
        public static readonly MemberStatus CREATE_FAILED = new MemberStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for MemberStatus
        /// </summary>
        public static readonly MemberStatus CREATING = new MemberStatus("CREATING");
        /// <summary>
        /// Constant DELETED for MemberStatus
        /// </summary>
        public static readonly MemberStatus DELETED = new MemberStatus("DELETED");
        /// <summary>
        /// Constant DELETING for MemberStatus
        /// </summary>
        public static readonly MemberStatus DELETING = new MemberStatus("DELETING");
        /// <summary>
        /// Constant INACCESSIBLE_ENCRYPTION_KEY for MemberStatus
        /// </summary>
        public static readonly MemberStatus INACCESSIBLE_ENCRYPTION_KEY = new MemberStatus("INACCESSIBLE_ENCRYPTION_KEY");
        /// <summary>
        /// Constant UPDATING for MemberStatus
        /// </summary>
        public static readonly MemberStatus UPDATING = new MemberStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberStatus FindValue(string value)
        {
            return FindValue<MemberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkStatus.
    /// </summary>
    public class NetworkStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus AVAILABLE = new NetworkStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_FAILED for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus CREATE_FAILED = new NetworkStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus CREATING = new NetworkStatus("CREATING");
        /// <summary>
        /// Constant DELETED for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus DELETED = new NetworkStatus("DELETED");
        /// <summary>
        /// Constant DELETING for NetworkStatus
        /// </summary>
        public static readonly NetworkStatus DELETING = new NetworkStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkStatus FindValue(string value)
        {
            return FindValue<NetworkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeStatus.
    /// </summary>
    public class NodeStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for NodeStatus
        /// </summary>
        public static readonly NodeStatus AVAILABLE = new NodeStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_FAILED for NodeStatus
        /// </summary>
        public static readonly NodeStatus CREATE_FAILED = new NodeStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for NodeStatus
        /// </summary>
        public static readonly NodeStatus CREATING = new NodeStatus("CREATING");
        /// <summary>
        /// Constant DELETED for NodeStatus
        /// </summary>
        public static readonly NodeStatus DELETED = new NodeStatus("DELETED");
        /// <summary>
        /// Constant DELETING for NodeStatus
        /// </summary>
        public static readonly NodeStatus DELETING = new NodeStatus("DELETING");
        /// <summary>
        /// Constant FAILED for NodeStatus
        /// </summary>
        public static readonly NodeStatus FAILED = new NodeStatus("FAILED");
        /// <summary>
        /// Constant INACCESSIBLE_ENCRYPTION_KEY for NodeStatus
        /// </summary>
        public static readonly NodeStatus INACCESSIBLE_ENCRYPTION_KEY = new NodeStatus("INACCESSIBLE_ENCRYPTION_KEY");
        /// <summary>
        /// Constant UNHEALTHY for NodeStatus
        /// </summary>
        public static readonly NodeStatus UNHEALTHY = new NodeStatus("UNHEALTHY");
        /// <summary>
        /// Constant UPDATING for NodeStatus
        /// </summary>
        public static readonly NodeStatus UPDATING = new NodeStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeStatus FindValue(string value)
        {
            return FindValue<NodeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProposalStatus.
    /// </summary>
    public class ProposalStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_FAILED for ProposalStatus
        /// </summary>
        public static readonly ProposalStatus ACTION_FAILED = new ProposalStatus("ACTION_FAILED");
        /// <summary>
        /// Constant APPROVED for ProposalStatus
        /// </summary>
        public static readonly ProposalStatus APPROVED = new ProposalStatus("APPROVED");
        /// <summary>
        /// Constant EXPIRED for ProposalStatus
        /// </summary>
        public static readonly ProposalStatus EXPIRED = new ProposalStatus("EXPIRED");
        /// <summary>
        /// Constant IN_PROGRESS for ProposalStatus
        /// </summary>
        public static readonly ProposalStatus IN_PROGRESS = new ProposalStatus("IN_PROGRESS");
        /// <summary>
        /// Constant REJECTED for ProposalStatus
        /// </summary>
        public static readonly ProposalStatus REJECTED = new ProposalStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProposalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProposalStatus FindValue(string value)
        {
            return FindValue<ProposalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProposalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StateDBType.
    /// </summary>
    public class StateDBType : ConstantClass
    {

        /// <summary>
        /// Constant CouchDB for StateDBType
        /// </summary>
        public static readonly StateDBType CouchDB = new StateDBType("CouchDB");
        /// <summary>
        /// Constant LevelDB for StateDBType
        /// </summary>
        public static readonly StateDBType LevelDB = new StateDBType("LevelDB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StateDBType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StateDBType FindValue(string value)
        {
            return FindValue<StateDBType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StateDBType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThresholdComparator.
    /// </summary>
    public class ThresholdComparator : ConstantClass
    {

        /// <summary>
        /// Constant GREATER_THAN for ThresholdComparator
        /// </summary>
        public static readonly ThresholdComparator GREATER_THAN = new ThresholdComparator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for ThresholdComparator
        /// </summary>
        public static readonly ThresholdComparator GREATER_THAN_OR_EQUAL_TO = new ThresholdComparator("GREATER_THAN_OR_EQUAL_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThresholdComparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThresholdComparator FindValue(string value)
        {
            return FindValue<ThresholdComparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThresholdComparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoteValue.
    /// </summary>
    public class VoteValue : ConstantClass
    {

        /// <summary>
        /// Constant NO for VoteValue
        /// </summary>
        public static readonly VoteValue NO = new VoteValue("NO");
        /// <summary>
        /// Constant YES for VoteValue
        /// </summary>
        public static readonly VoteValue YES = new VoteValue("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoteValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoteValue FindValue(string value)
        {
            return FindValue<VoteValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoteValue(string value)
        {
            return FindValue(value);
        }
    }

}
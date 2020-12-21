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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties of a node.
    /// </summary>
    public partial class Node
    {
        private string _availabilityZone;
        private DateTime? _creationDate;
        private NodeFrameworkAttributes _frameworkAttributes;
        private string _id;
        private string _instanceType;
        private NodeLogPublishingConfiguration _logPublishingConfiguration;
        private string _memberId;
        private string _networkId;
        private StateDBType _stateDB;
        private NodeStatus _status;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the node exists.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the node was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes of the blockchain framework being used.
        /// </para>
        /// </summary>
        public NodeFrameworkAttributes FrameworkAttributes
        {
            get { return this._frameworkAttributes; }
            set { this._frameworkAttributes = value; }
        }

        // Check to see if FrameworkAttributes property is set
        internal bool IsSetFrameworkAttributes()
        {
            return this._frameworkAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the node.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingConfiguration. 
        /// <para>
        /// Configuration properties for logging events associated with a peer node on a Hyperledger
        /// Fabric network on Managed Blockchain.
        /// </para>
        /// </summary>
        public NodeLogPublishingConfiguration LogPublishingConfiguration
        {
            get { return this._logPublishingConfiguration; }
            set { this._logPublishingConfiguration = value; }
        }

        // Check to see if LogPublishingConfiguration property is set
        internal bool IsSetLogPublishingConfiguration()
        {
            return this._logPublishingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        /// The unique identifier of the member to which the node belongs.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string MemberId
        {
            get { return this._memberId; }
            set { this._memberId = value; }
        }

        // Check to see if MemberId property is set
        internal bool IsSetMemberId()
        {
            return this._memberId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network that the node is on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property StateDB. 
        /// <para>
        /// The state database that the node uses. Values are <code>LevelDB</code> or <code>CouchDB</code>.
        /// </para>
        ///  
        /// <para>
        /// Applies only to Hyperledger Fabric.
        /// </para>
        /// </summary>
        public StateDBType StateDB
        {
            get { return this._stateDB; }
            set { this._stateDB = value; }
        }

        // Check to see if StateDB property is set
        internal bool IsSetStateDB()
        {
            return this._stateDB != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the node.
        /// </para>
        /// </summary>
        public NodeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
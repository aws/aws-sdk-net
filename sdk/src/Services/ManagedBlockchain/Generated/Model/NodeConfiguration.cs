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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties of a node.
    /// </summary>
    public partial class NodeConfiguration
    {
        private string _availabilityZone;
        private string _instanceType;
        private NodeLogPublishingConfiguration _logPublishingConfiguration;
        private StateDBType _stateDB;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the node exists. Required for Ethereum nodes. 
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon Managed Blockchain instance type for the node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StateDB. 
        /// <para>
        /// The state database that the node uses. Values are <c>LevelDB</c> or <c>CouchDB</c>.
        /// When using an Amazon Managed Blockchain network with Hyperledger Fabric version 1.4
        /// or later, the default is <c>CouchDB</c>.
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

    }
}
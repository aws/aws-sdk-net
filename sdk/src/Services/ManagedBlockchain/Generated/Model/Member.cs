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
    /// Member configuration properties.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Member
    {
        private string _arn;
        private DateTime? _creationDate;
        private string _description;
        private MemberFrameworkAttributes _frameworkAttributes;
        private string _id;
        private string _kmsKeyArn;
        private MemberLogPublishingConfiguration _logPublishingConfiguration;
        private string _name;
        private string _networkId;
        private MemberStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the member. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the member was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the member.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes relevant to a member for the blockchain framework that the Managed Blockchain
        /// network uses.
        /// </para>
        /// </summary>
        public MemberFrameworkAttributes FrameworkAttributes
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
        /// The unique identifier of the member.
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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed key in Key Management Service
        /// (KMS) that the member uses for encryption at rest. If the value of this parameter
        /// is <code>"AWS Owned KMS Key"</code>, the member uses an Amazon Web Services owned
        /// KMS key for encryption. This parameter is inherited by the nodes that this member
        /// owns.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/managed-blockchain-encryption-at-rest.html">Encryption
        /// at Rest</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogPublishingConfiguration. 
        /// <para>
        /// Configuration properties for logging events associated with a member.
        /// </para>
        /// </summary>
        public MemberLogPublishingConfiguration LogPublishingConfiguration
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network to which the member belongs.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a member.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - The Amazon Web Services account is in the process of creating
        /// a member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The member has been created and can participate in the network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_FAILED</code> - The Amazon Web Services account attempted to create
        /// a member and creation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATING</code> - The member is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - The member and all associated resources are in the process
        /// of being deleted. Either the Amazon Web Services account that owns the member deleted
        /// it, or the member is being deleted as the result of an <code>APPROVED</code> <code>PROPOSAL</code>
        /// to remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - The member can no longer participate on the network and all
        /// associated resources are deleted. Either the Amazon Web Services account that owns
        /// the member deleted it, or the member is being deleted as the result of an <code>APPROVED</code>
        /// <code>PROPOSAL</code> to remove the member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INACCESSIBLE_ENCRYPTION_KEY</code> - The member is impaired and might not function
        /// as expected because it cannot access the specified customer managed key in KMS for
        /// encryption at rest. Either the KMS key was disabled or deleted, or the grants on the
        /// key were revoked.
        /// </para>
        ///  
        /// <para>
        /// The effect of disabling or deleting a key or of revoking a grant isn't immediate.
        /// It might take some time for the member resource to discover that the key is inaccessible.
        /// When a resource is in this state, we recommend deleting and recreating the resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MemberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the member. Tags consist of a key and optional value.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
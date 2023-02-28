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
    /// Container for the parameters to the CreateNetwork operation.
    /// Creates a new blockchain network using Amazon Managed Blockchain.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class CreateNetworkRequest : AmazonManagedBlockchainRequest
    {
        private string _clientRequestToken;
        private string _description;
        private Framework _framework;
        private NetworkFrameworkConfiguration _frameworkConfiguration;
        private string _frameworkVersion;
        private MemberConfiguration _memberConfiguration;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private VotingPolicy _votingPolicy;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// This is a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the operation. An idempotent operation completes no more than once. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an Amazon Web Services SDK or the Amazon Web Services
        /// CLI. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the network.
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
        /// Gets and sets the property Framework. 
        /// <para>
        /// The blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Framework Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkConfiguration. 
        /// <para>
        ///  Configuration properties of the blockchain framework relevant to the network configuration.
        /// 
        /// </para>
        /// </summary>
        public NetworkFrameworkConfiguration FrameworkConfiguration
        {
            get { return this._frameworkConfiguration; }
            set { this._frameworkConfiguration = value; }
        }

        // Check to see if FrameworkConfiguration property is set
        internal bool IsSetFrameworkConfiguration()
        {
            return this._frameworkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The version of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public string FrameworkVersion
        {
            get { return this._frameworkVersion; }
            set { this._frameworkVersion = value; }
        }

        // Check to see if FrameworkVersion property is set
        internal bool IsSetFrameworkVersion()
        {
            return this._frameworkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MemberConfiguration. 
        /// <para>
        /// Configuration properties for the first member within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberConfiguration MemberConfiguration
        {
            get { return this._memberConfiguration; }
            set { this._memberConfiguration = value; }
        }

        // Check to see if MemberConfiguration property is set
        internal bool IsSetMemberConfiguration()
        {
            return this._memberConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the network.
        /// </para>
        ///  
        /// <para>
        ///  Each tag consists of a key and an optional value. You can specify multiple key-value
        /// pairs in a single request with an overall maximum of 50 tags allowed per resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property VotingPolicy. 
        /// <para>
        ///  The voting rules used by the network to determine if a proposal is approved. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VotingPolicy VotingPolicy
        {
            get { return this._votingPolicy; }
            set { this._votingPolicy = value; }
        }

        // Check to see if VotingPolicy property is set
        internal bool IsSetVotingPolicy()
        {
            return this._votingPolicy != null;
        }

    }
}
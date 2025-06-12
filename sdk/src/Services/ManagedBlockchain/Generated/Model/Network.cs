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
    /// Network configuration properties.
    /// </summary>
    public partial class Network
    {
        private string _arn;
        private DateTime? _creationDate;
        private string _description;
        private Framework _framework;
        private NetworkFrameworkAttributes _frameworkAttributes;
        private string _frameworkVersion;
        private string _id;
        private string _name;
        private NetworkStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VotingPolicy _votingPolicy;
        private string _vpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network. For more information about ARNs and
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
        /// The date and time that the network was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// Attributes of the blockchain framework for the network.
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
        /// Gets and sets the property FrameworkAttributes. 
        /// <para>
        /// Attributes of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        public NetworkFrameworkAttributes FrameworkAttributes
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
        /// Gets and sets the property FrameworkVersion. 
        /// <para>
        /// The version of the blockchain framework that the network uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the network.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the network.
        /// </para>
        /// </summary>
        public NetworkStatus Status
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
        /// Tags assigned to the network. Each tag consists of a key and optional value.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VotingPolicy. 
        /// <para>
        /// The voting rules that the network uses to decide if a proposal is accepted.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. 
        /// <para>
        /// The VPC endpoint service name of the VPC endpoint service of the network. Members
        /// use the VPC endpoint service name to create a VPC endpoint to access network resources.
        /// </para>
        /// </summary>
        public string VpcEndpointServiceName
        {
            get { return this._vpcEndpointServiceName; }
            set { this._vpcEndpointServiceName = value; }
        }

        // Check to see if VpcEndpointServiceName property is set
        internal bool IsSetVpcEndpointServiceName()
        {
            return this._vpcEndpointServiceName != null;
        }

    }
}
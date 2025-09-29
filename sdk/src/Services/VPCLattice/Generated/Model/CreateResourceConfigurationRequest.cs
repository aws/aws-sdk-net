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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceConfiguration operation.
    /// Creates a resource configuration. A resource configuration defines a specific resource.
    /// You can associate a resource configuration with a service network or a VPC endpoint.
    /// </summary>
    public partial class CreateResourceConfigurationRequest : AmazonVPCLatticeRequest
    {
        private bool? _allowAssociationToShareableServiceNetwork;
        private string _clientToken;
        private string _name;
        private List<string> _portRanges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtocolType _protocol;
        private ResourceConfigurationDefinition _resourceConfigurationDefinition;
        private string _resourceConfigurationGroupIdentifier;
        private string _resourceGatewayIdentifier;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ResourceConfigurationType _type;

        /// <summary>
        /// Gets and sets the property AllowAssociationToShareableServiceNetwork. 
        /// <para>
        /// (SINGLE, GROUP, ARN) Specifies whether the resource configuration can be associated
        /// with a sharable service network. The default is false.
        /// </para>
        /// </summary>
        public bool? AllowAssociationToShareableServiceNetwork
        {
            get { return this._allowAssociationToShareableServiceNetwork; }
            set { this._allowAssociationToShareableServiceNetwork = value; }
        }

        // Check to see if AllowAssociationToShareableServiceNetwork property is set
        internal bool IsSetAllowAssociationToShareableServiceNetwork()
        {
            return this._allowAssociationToShareableServiceNetwork.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource configuration. The name must be unique within the account.
        /// The valid characters are a-z, 0-9, and hyphens (-). You can't use a hyphen as the
        /// first or last character, or immediately after another hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=40)]
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
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// (SINGLE, GROUP, CHILD) The TCP port ranges that a consumer can use to access a resource
        /// configuration (for example: 1-65535). You can separate port ranges using commas (for
        /// example: 1,2,22-30).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PortRanges
        {
            get { return this._portRanges; }
            set { this._portRanges = value; }
        }

        // Check to see if PortRanges property is set
        internal bool IsSetPortRanges()
        {
            return this._portRanges != null && (this._portRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// (SINGLE, GROUP) The protocol accepted by the resource configuration.
        /// </para>
        /// </summary>
        public ProtocolType Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationDefinition. 
        /// <para>
        /// Identifies the resource configuration in one of the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Resource Name (ARN)</b> - Supported resource-types that are provisioned
        /// by Amazon Web Services services, such as RDS databases, can be identified by their
        /// ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Domain name</b> - Any domain name that is publicly resolvable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IP address</b> - For IPv4 and IPv6, only IP addresses in the VPC are supported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceConfigurationDefinition ResourceConfigurationDefinition
        {
            get { return this._resourceConfigurationDefinition; }
            set { this._resourceConfigurationDefinition = value; }
        }

        // Check to see if ResourceConfigurationDefinition property is set
        internal bool IsSetResourceConfigurationDefinition()
        {
            return this._resourceConfigurationDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationGroupIdentifier. 
        /// <para>
        /// (CHILD) The ID or ARN of the parent resource configuration of type <c>GROUP</c>. This
        /// is used to associate a child resource configuration with a group resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationGroupIdentifier
        {
            get { return this._resourceConfigurationGroupIdentifier; }
            set { this._resourceConfigurationGroupIdentifier = value; }
        }

        // Check to see if ResourceConfigurationGroupIdentifier property is set
        internal bool IsSetResourceConfigurationGroupIdentifier()
        {
            return this._resourceConfigurationGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// (SINGLE, GROUP, ARN) The ID or ARN of the resource gateway used to connect to the
        /// resource configuration. For a child resource configuration, this value is inherited
        /// from the parent resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=2048)]
        public string ResourceGatewayIdentifier
        {
            get { return this._resourceGatewayIdentifier; }
            set { this._resourceGatewayIdentifier = value; }
        }

        // Check to see if ResourceGatewayIdentifier property is set
        internal bool IsSetResourceGatewayIdentifier()
        {
            return this._resourceGatewayIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the resource configuration.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource configuration. A resource configuration can be one of the following
        /// types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SINGLE</b> - A single resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GROUP</b> - A group of resources. You must create a group resource configuration
        /// before you create a child resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CHILD</b> - A single resource that is part of a group resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ARN</b> - An Amazon Web Services resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceConfigurationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
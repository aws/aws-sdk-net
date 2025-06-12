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
    /// This is the response object from the UpdateResourceConfiguration operation.
    /// </summary>
    public partial class UpdateResourceConfigurationResponse : AmazonWebServiceResponse
    {
        private bool? _allowAssociationToShareableServiceNetwork;
        private string _arn;
        private string _id;
        private string _name;
        private List<string> _portRanges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtocolType _protocol;
        private ResourceConfigurationDefinition _resourceConfigurationDefinition;
        private string _resourceConfigurationGroupId;
        private string _resourceGatewayId;
        private ResourceConfigurationStatus _status;
        private ResourceConfigurationType _type;

        /// <summary>
        /// Gets and sets the property AllowAssociationToShareableServiceNetwork. 
        /// <para>
        /// Indicates whether to add the resource configuration to service networks that are shared
        /// with other accounts.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// The name of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// The TCP port ranges that a consumer can use to access a resource configuration. You
        /// can separate port ranges with a comma. Example: 1-65535 or 1,2,22-30
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
        /// The TCP protocol accepted by the specified resource configuration.
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
        /// The resource configuration.
        /// </para>
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
        /// Gets and sets the property ResourceConfigurationGroupId. 
        /// <para>
        /// The ID of the group resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string ResourceConfigurationGroupId
        {
            get { return this._resourceConfigurationGroupId; }
            set { this._resourceConfigurationGroupId = value; }
        }

        // Check to see if ResourceConfigurationGroupId property is set
        internal bool IsSetResourceConfigurationGroupId()
        {
            return this._resourceConfigurationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The ID of the resource gateway associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ResourceGatewayId
        {
            get { return this._resourceGatewayId; }
            set { this._resourceGatewayId = value; }
        }

        // Check to see if ResourceGatewayId property is set
        internal bool IsSetResourceGatewayId()
        {
            return this._resourceGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource configuration.
        /// </para>
        /// </summary>
        public ResourceConfigurationStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE</c> - A single resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUP</c> - A group of resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHILD</c> - A single resource that is part of a group resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARN</c> - An Amazon Web Services resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
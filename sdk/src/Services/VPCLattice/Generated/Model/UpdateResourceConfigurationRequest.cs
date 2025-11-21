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
    /// Container for the parameters to the UpdateResourceConfiguration operation.
    /// Updates the specified resource configuration.
    /// </summary>
    public partial class UpdateResourceConfigurationRequest : AmazonVPCLatticeRequest
    {
        private bool? _allowAssociationToShareableServiceNetwork;
        private List<string> _portRanges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceConfigurationDefinition _resourceConfigurationDefinition;
        private string _resourceConfigurationIdentifier;

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
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceConfigurationIdentifier
        {
            get { return this._resourceConfigurationIdentifier; }
            set { this._resourceConfigurationIdentifier = value; }
        }

        // Check to see if ResourceConfigurationIdentifier property is set
        internal bool IsSetResourceConfigurationIdentifier()
        {
            return this._resourceConfigurationIdentifier != null;
        }

    }
}
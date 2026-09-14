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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateResourceConfiguration operation. Updates
    /// the specified resource configuration.
    /// </summary>
    public partial class UpdateResourceConfigurationRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property AllowAssociationToShareableServiceNetwork. 
        /// <para>
        /// Indicates whether to add the resource configuration to service networks that are shared
        /// with other accounts.
        /// </para>
        /// </summary>
        public bool? AllowAssociationToShareableServiceNetwork { get; set; }

        /// <summary>
        /// Checks to see if the AllowAssociationToShareableServiceNetwork property is set.
        /// </summary>
        internal bool IsSetAllowAssociationToShareableServiceNetwork() => this.AllowAssociationToShareableServiceNetwork.HasValue;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The TCP port ranges that a consumer can use to access a resource configuration. You
        /// can separate port ranges with a comma. Example: 1-65535 or 1,2,22-30
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ResourceConfigurationDefinition ResourceConfigurationDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationDefinition property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationDefinition() => this.ResourceConfigurationDefinition != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationIdentifier() => this.ResourceConfigurationIdentifier != null;
    }
}

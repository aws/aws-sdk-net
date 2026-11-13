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
    /// Container for the parameters to the UpdateResourceGateway operation. Updates the specified
    /// resource gateway.
    /// </summary>
    public partial class UpdateResourceGatewayRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceConfigDnsResolution. 
        /// <para>
        /// Indicates how DNS is resolved for resource configurations associated with this resource
        /// gateway.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_VPC</c> - DNS resolution occurs privately within the resource gateway's VPC.
        /// Use this when your resource domain names are hosted in private Route 53 hosted zones
        /// or on-premises DNS servers reachable from the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC</c> - DNS resolution occurs against public DNS resolvers. Use this when
        /// your resource domain names are publicly resolvable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceConfigDnsResolution ResourceConfigDnsResolution { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigDnsResolution property is set.
        /// </summary>
        internal bool IsSetResourceConfigDnsResolution() => this.ResourceConfigDnsResolution != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// The ID or ARN of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ResourceGatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceGatewayIdentifier() => this.ResourceGatewayIdentifier != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups associated with the resource gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

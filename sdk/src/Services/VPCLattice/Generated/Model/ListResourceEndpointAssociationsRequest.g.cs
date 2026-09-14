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
    /// Container for the parameters to the ListResourceEndpointAssociations operation. Lists
    /// the associations for the specified VPC endpoint.
    /// </summary>
    public partial class ListResourceEndpointAssociationsRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ID for the resource configuration associated with the VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationIdentifier() => this.ResourceConfigurationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceEndpointAssociationIdentifier. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 2048)]
        public string ResourceEndpointAssociationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceEndpointAssociationIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceEndpointAssociationIdentifier() => this.ResourceEndpointAssociationIdentifier != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The owner of the VPC endpoint in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string VpcEndpointOwner { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointOwner property is set.
        /// </summary>
        internal bool IsSetVpcEndpointOwner() => this.VpcEndpointOwner != null;
    }
}

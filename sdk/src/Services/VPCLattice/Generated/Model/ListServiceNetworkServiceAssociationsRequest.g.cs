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
    /// Container for the parameters to the ListServiceNetworkServiceAssociations operation.
    /// Lists the associations between a service network and a service. You can filter the
    /// list either by service or service network. You must provide either the service network
    /// identifier or the service identifier. <para> Every association in Amazon VPC Lattice
    /// has a unique Amazon Resource Name (ARN), such as when a service network is associated
    /// with a VPC or when a service is associated with a service network. If the association
    /// is for a resource is shared with another account, the association includes the local
    /// account ID as the prefix in the ARN. </para>
    /// </summary>
    public partial class ListServiceNetworkServiceAssociationsRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID or ARN of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 2048)]
        public string ServiceNetworkIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNetworkIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceNetworkIdentifier() => this.ServiceNetworkIdentifier != null;
    }
}

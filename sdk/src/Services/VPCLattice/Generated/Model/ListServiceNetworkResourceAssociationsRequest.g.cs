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
    /// Container for the parameters to the ListServiceNetworkResourceAssociations operation.
    /// Lists the associations between a service network and a resource configuration.
    /// </summary>
    public partial class ListServiceNetworkResourceAssociationsRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeChildren. 
        /// <para>
        /// Include service network resource associations of the child resource configuration
        /// with the grouped resource configuration.
        /// </para>
        ///  
        /// <para>
        /// The type is boolean and the default value is false.
        /// </para>
        /// </summary>
        public bool? IncludeChildren { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChildren property is set.
        /// </summary>
        internal bool IsSetIncludeChildren() => this.IncludeChildren.HasValue;

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
        /// If there are additional results, a pagination token for the next page of results.
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
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationIdentifier() => this.ResourceConfigurationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID of the service network.
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

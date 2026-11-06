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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListCidrBlocks operation. Returns a paginated
    /// list of location objects and their CIDR blocks.
    /// </summary>
    public partial class ListCidrBlocksRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The UUID of the CIDR collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// The name of the CIDR collection location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public string LocationName { get; set; }

        /// <summary>
        /// Checks to see if the LocationName property is set.
        /// </summary>
        internal bool IsSetLocationName() => this.LocationName != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token to indicate where the service is to begin enumerating results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results you want returned.
        /// </para>
        /// </summary>
        public string MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults != null;
    }
}

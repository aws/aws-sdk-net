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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceSnapshots operation. Retrieves a list
    /// of resource view snapshots based on specified criteria. This operation supports various
    /// use cases, including: <ul> <li> <para> Fetching all snapshots associated with an engagement.
    /// </para> </li> <li> <para> Retrieving snapshots of a specific resource type within
    /// an engagement. </para> </li> <li> <para> Obtaining snapshots for a particular resource
    /// using a specified template. </para> </li> <li> <para> Accessing the latest snapshot
    /// of a resource within an engagement. </para> </li> <li> <para> Filtering snapshots
    /// by resource owner. </para> </li> </ul>
    /// </summary>
    public partial class ListResourceSnapshotsRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        ///  Specifies the catalog related to the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Filters the response to include only snapshots of resources owned by the specified
        /// AWS account. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  The unique identifier of the engagement associated with the snapshots. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  Filters the response to include only snapshots of the specified resource. 
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateIdentifier. 
        /// <para>
        /// Filters the response to include only snapshots created using the specified template.
        /// </para>
        /// </summary>
        public string ResourceSnapshotTemplateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotTemplateIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotTemplateIdentifier() => this.ResourceSnapshotTemplateIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  Filters the response to include only snapshots of the specified resource type. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}

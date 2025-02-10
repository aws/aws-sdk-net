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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// Container for the parameters to the ListResourceSnapshots operation.
    /// Retrieves a list of resource view snapshots based on specified criteria. This operation
    /// supports various use cases, including: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Fetching all snapshots associated with an engagement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieving snapshots of a specific resource type within an engagement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Obtaining snapshots for a particular resource using a specified template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Accessing the latest snapshot of a resource within an engagement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filtering snapshots by resource owner.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListResourceSnapshotsRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _createdBy;
        private string _engagementIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceIdentifier;
        private string _resourceSnapshotTemplateIdentifier;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        ///  Specifies the catalog related to the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Filters the response to include only snapshots of resources owned by the specified
        /// AWS account. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  The unique identifier of the engagement associated with the snapshots. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngagementIdentifier
        {
            get { return this._engagementIdentifier; }
            set { this._engagementIdentifier = value; }
        }

        // Check to see if EngagementIdentifier property is set
        internal bool IsSetEngagementIdentifier()
        {
            return this._engagementIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  Filters the response to include only snapshots of the specified resource. 
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateIdentifier. 
        /// <para>
        /// Filters the response to include only snapshots created using the specified template.
        /// </para>
        /// </summary>
        public string ResourceSnapshotTemplateIdentifier
        {
            get { return this._resourceSnapshotTemplateIdentifier; }
            set { this._resourceSnapshotTemplateIdentifier = value; }
        }

        // Check to see if ResourceSnapshotTemplateIdentifier property is set
        internal bool IsSetResourceSnapshotTemplateIdentifier()
        {
            return this._resourceSnapshotTemplateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  Filters the response to include only snapshots of the specified resource type. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}
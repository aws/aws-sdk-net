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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Container for the parameters to the SearchImageSets operation.
    /// Search image sets based on defined input attributes.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>SearchImageSets</c> accepts a single search query parameter and returns a paginated
    /// response of all image sets that have the matching criteria. All date range queries
    /// must be input as <c>(lowerBound, upperBound)</c>.
    /// </para>
    ///  
    /// <para>
    /// By default, <c>SearchImageSets</c> uses the <c>updatedAt</c> field for sorting in
    /// descending order from newest to oldest.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchImageSetsRequest : AmazonMedicalImagingRequest
    {
        private string _datastoreId;
        private int? _maxResults;
        private string _nextToken;
        private SearchCriteria _searchCriteria;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The identifier of the data store where the image sets reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that can be returned in a search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The token used for pagination of results returned in the response. Use the token returned
        /// from the previous request to continue results where the previous request ended.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// The search criteria that filters by applying a maximum of 1 item to <c>SearchByAttribute</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SearchCriteria SearchCriteria
        {
            get { return this._searchCriteria; }
            set { this._searchCriteria = value; }
        }

        // Check to see if SearchCriteria property is set
        internal bool IsSetSearchCriteria()
        {
            return this._searchCriteria != null;
        }

    }
}
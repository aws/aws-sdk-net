/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// The result of a <code>Search</code> request. Contains the documents that match the
    /// specified search criteria and any requested fields, highlights, and facet information.
    /// </summary>
    public partial class SearchResult : AmazonWebServiceResponse
    {
        private Dictionary<string, BucketInfo> _facets = new Dictionary<string, BucketInfo>();
        private Hits _hits;
        private SearchStatus _status;

        /// <summary>
        /// Gets and sets the property Facets. 
        /// <para>
        /// The requested facet information.
        /// </para>
        /// </summary>
        public Dictionary<string, BucketInfo> Facets
        {
            get { return this._facets; }
            set { this._facets = value; }
        }

        // Check to see if Facets property is set
        internal bool IsSetFacets()
        {
            return this._facets != null && this._facets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Hits. 
        /// <para>
        /// The documents that match the search criteria.
        /// </para>
        /// </summary>
        public Hits Hits
        {
            get { return this._hits; }
            set { this._hits = value; }
        }

        // Check to see if Hits property is set
        internal bool IsSetHits()
        {
            return this._hits != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status information returned for the search request.
        /// </para>
        /// </summary>
        public SearchStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
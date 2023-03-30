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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A set of featured results that are displayed at the top of your search results. Featured
    /// results are placed above all other results for certain queries. If there's an exact
    /// match of a query, then one or more specific documents are featured in the search results.
    /// </summary>
    public partial class FeaturedResultsSet
    {
        private long? _creationTimestamp;
        private string _description;
        private List<FeaturedDocument> _featuredDocuments = new List<FeaturedDocument>();
        private string _featuredResultsSetId;
        private string _featuredResultsSetName;
        private long? _lastUpdatedTimestamp;
        private List<string> _queryTexts = new List<string>();
        private FeaturedResultsSetStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix timestamp when the set of featured results was created.
        /// </para>
        /// </summary>
        public long CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturedDocuments. 
        /// <para>
        /// The list of document IDs for the documents you want to feature at the top of the search
        /// results page. You can use the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Query.html">Query</a>
        /// API to search for specific documents with their document IDs included in the result
        /// items, or you can use the console.
        /// </para>
        ///  
        /// <para>
        /// You can add up to four featured documents. You can request to increase this limit
        /// by contacting <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        ///  
        /// <para>
        /// Specific queries are mapped to specific documents for featuring in the results. If
        /// a query contains an exact match, then one or more specific documents are featured
        /// in the results. The exact match applies to the full query. For example, if you only
        /// specify 'Kendra', queries such as 'How does kendra semantically rank results?' will
        /// not render the featured results. Featured results are designed for specific queries,
        /// rather than queries that are too broad in scope.
        /// </para>
        /// </summary>
        public List<FeaturedDocument> FeaturedDocuments
        {
            get { return this._featuredDocuments; }
            set { this._featuredDocuments = value; }
        }

        // Check to see if FeaturedDocuments property is set
        internal bool IsSetFeaturedDocuments()
        {
            return this._featuredDocuments != null && this._featuredDocuments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetId. 
        /// <para>
        /// The identifier of the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FeaturedResultsSetId
        {
            get { return this._featuredResultsSetId; }
            set { this._featuredResultsSetId = value; }
        }

        // Check to see if FeaturedResultsSetId property is set
        internal bool IsSetFeaturedResultsSetId()
        {
            return this._featuredResultsSetId != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetName. 
        /// <para>
        /// The name for the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string FeaturedResultsSetName
        {
            get { return this._featuredResultsSetName; }
            set { this._featuredResultsSetName = value; }
        }

        // Check to see if FeaturedResultsSetName property is set
        internal bool IsSetFeaturedResultsSetName()
        {
            return this._featuredResultsSetName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The Unix timestamp when the set of featured results was last updated.
        /// </para>
        /// </summary>
        public long LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryTexts. 
        /// <para>
        /// The list of queries for featuring results.
        /// </para>
        ///  
        /// <para>
        /// Specific queries are mapped to specific documents for featuring in the results. If
        /// a query contains an exact match, then one or more specific documents are featured
        /// in the results. The exact match applies to the full query. For example, if you only
        /// specify 'Kendra', queries such as 'How does kendra semantically rank results?' will
        /// not render the featured results. Featured results are designed for specific queries,
        /// rather than queries that are too broad in scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=49)]
        public List<string> QueryTexts
        {
            get { return this._queryTexts; }
            set { this._queryTexts = value; }
        }

        // Check to see if QueryTexts property is set
        internal bool IsSetQueryTexts()
        {
            return this._queryTexts != null && this._queryTexts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the set of featured results. When the value is <code>ACTIVE</code>,
        /// featured results are ready for use. You can still configure your settings before setting
        /// the status to <code>ACTIVE</code>. You can set the status to <code>ACTIVE</code> or
        /// <code>INACTIVE</code> using the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateFeaturedResultsSet.html">UpdateFeaturedResultsSet</a>
        /// API. The queries you specify for featured results must be unique per featured results
        /// set for each index, whether the status is <code>ACTIVE</code> or <code>INACTIVE</code>.
        /// </para>
        /// </summary>
        public FeaturedResultsSetStatus Status
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
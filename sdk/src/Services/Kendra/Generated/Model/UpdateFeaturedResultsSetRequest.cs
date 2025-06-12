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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFeaturedResultsSet operation.
    /// Updates a set of featured results. Features results are placed above all other results
    /// for certain queries. You map specific queries to specific documents for featuring
    /// in the results. If a query contains an exact match of a query, then one or more specific
    /// documents are featured in the search results.
    /// </summary>
    public partial class UpdateFeaturedResultsSetRequest : AmazonKendraRequest
    {
        private string _description;
        private List<FeaturedDocument> _featuredDocuments = AWSConfigs.InitializeCollections ? new List<FeaturedDocument>() : null;
        private string _featuredResultsSetId;
        private string _featuredResultsSetName;
        private string _indexId;
        private List<string> _queryTexts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FeaturedResultsSetStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the set of featured results.
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
        /// A list of document IDs for the documents you want to feature at the top of the search
        /// results page. For more information on the list of featured documents, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_FeaturedResultsSet.html">FeaturedResultsSet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FeaturedDocument> FeaturedDocuments
        {
            get { return this._featuredDocuments; }
            set { this._featuredDocuments = value; }
        }

        // Check to see if FeaturedDocuments property is set
        internal bool IsSetFeaturedDocuments()
        {
            return this._featuredDocuments != null && (this._featuredDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetId. 
        /// <para>
        /// The identifier of the set of featured results that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// A new name for the set of featured results.
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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index used for featuring results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryTexts. 
        /// <para>
        /// A list of queries for featuring results. For more information on the list of queries,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_FeaturedResultsSet.html">FeaturedResultsSet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._queryTexts != null && (this._queryTexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// You can set the status to <c>ACTIVE</c> or <c>INACTIVE</c>. When the value is <c>ACTIVE</c>,
        /// featured results are ready for use. You can still configure your settings before setting
        /// the status to <c>ACTIVE</c>. The queries you specify for featured results must be
        /// unique per featured results set for each index, whether the status is <c>ACTIVE</c>
        /// or <c>INACTIVE</c>.
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
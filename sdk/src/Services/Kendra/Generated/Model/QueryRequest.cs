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
    /// Container for the parameters to the Query operation.
    /// Searches an active index. Use this API to search your documents using query. The <code>Query</code>
    /// API enables to do faceted search and to filter results based on document attributes.
    /// 
    ///  
    /// <para>
    /// It also enables you to provide user context that Amazon Kendra uses to enforce document
    /// access control in the search results.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kendra searches your index for text content and question and answer (FAQ) content.
    /// By default the response contains three types of results.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Relevant passages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Matching FAQs
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Relevant documents
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can specify that the query return only one type of result using the <code>QueryResultTypeConfig</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// Each query returns the 100 most relevant results. 
    /// </para>
    /// </summary>
    public partial class QueryRequest : AmazonKendraRequest
    {
        private AttributeFilter _attributeFilter;
        private List<DocumentRelevanceConfiguration> _documentRelevanceOverrideConfigurations = new List<DocumentRelevanceConfiguration>();
        private List<Facet> _facets = new List<Facet>();
        private string _indexId;
        private int? _pageNumber;
        private int? _pageSize;
        private QueryResultType _queryResultTypeFilter;
        private string _queryText;
        private List<string> _requestedDocumentAttributes = new List<string>();
        private SortingConfiguration _sortingConfiguration;
        private SpellCorrectionConfiguration _spellCorrectionConfiguration;
        private UserContext _userContext;
        private string _visitorId;

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Enables filtered searches based on document attributes. You can only provide one attribute
        /// filter; however, the <code>AndAllFilters</code>, <code>NotFilter</code>, and <code>OrAllFilters</code>
        /// parameters contain a list of other filters.
        /// </para>
        ///  
        /// <para>
        /// The <code>AttributeFilter</code> parameter enables you to create a set of filtering
        /// rules that a document must satisfy to be included in the query results.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentRelevanceOverrideConfigurations. 
        /// <para>
        /// Overrides relevance tuning configurations of fields or attributes set at the index
        /// level.
        /// </para>
        ///  
        /// <para>
        /// If you use this API to override the relevance tuning configured at the index level,
        /// but there is no relevance tuning configured at the index level, then Amazon Kendra
        /// does not apply any relevance tuning.
        /// </para>
        ///  
        /// <para>
        /// If there is relevance tuning configured at the index level, but you do not use this
        /// API to override any relevance tuning in the index, then Amazon Kendra uses the relevance
        /// tuning that is configured at the index level.
        /// </para>
        ///  
        /// <para>
        /// If there is relevance tuning configured for fields at the index level, but you use
        /// this API to override only some of these fields, then for the fields you did not override,
        /// the importance is set to 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<DocumentRelevanceConfiguration> DocumentRelevanceOverrideConfigurations
        {
            get { return this._documentRelevanceOverrideConfigurations; }
            set { this._documentRelevanceOverrideConfigurations = value; }
        }

        // Check to see if DocumentRelevanceOverrideConfigurations property is set
        internal bool IsSetDocumentRelevanceOverrideConfigurations()
        {
            return this._documentRelevanceOverrideConfigurations != null && this._documentRelevanceOverrideConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Facets. 
        /// <para>
        /// An array of documents attributes. Amazon Kendra returns a count for each attribute
        /// key specified. This helps your users narrow their search.
        /// </para>
        /// </summary>
        public List<Facet> Facets
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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index to search. The identifier is returned in the response
        /// from the <code>CreateIndex</code> API.
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
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// Query results are returned in pages the size of the <code>PageSize</code> parameter.
        /// By default, Amazon Kendra returns the first page of results. Use this parameter to
        /// get result pages after the first one.
        /// </para>
        /// </summary>
        public int PageNumber
        {
            get { return this._pageNumber.GetValueOrDefault(); }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Sets the number of results that are returned in each page of results. The default
        /// page size is 10. The maximum number of results returned is 100. If you ask for more
        /// than 100 results, only 100 are returned.
        /// </para>
        /// </summary>
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryResultTypeFilter. 
        /// <para>
        /// Sets the type of query. Only results for the specified query type are returned.
        /// </para>
        /// </summary>
        public QueryResultType QueryResultTypeFilter
        {
            get { return this._queryResultTypeFilter; }
            set { this._queryResultTypeFilter = value; }
        }

        // Check to see if QueryResultTypeFilter property is set
        internal bool IsSetQueryResultTypeFilter()
        {
            return this._queryResultTypeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The input query text for the search. Amazon Kendra truncates queries at 30 token words,
        /// which excludes punctuation and stop words. Truncation still applies if you use Boolean
        /// or more advanced, complex queries. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedDocumentAttributes. 
        /// <para>
        /// An array of document attributes to include in the response. You can limit the response
        /// to include certain document attributes. By default all document attributes are included
        /// in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RequestedDocumentAttributes
        {
            get { return this._requestedDocumentAttributes; }
            set { this._requestedDocumentAttributes = value; }
        }

        // Check to see if RequestedDocumentAttributes property is set
        internal bool IsSetRequestedDocumentAttributes()
        {
            return this._requestedDocumentAttributes != null && this._requestedDocumentAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortingConfiguration. 
        /// <para>
        /// Provides information that determines how the results of the query are sorted. You
        /// can set the field that Amazon Kendra should sort the results on, and specify whether
        /// the results should be sorted in ascending or descending order. In the case of ties
        /// in sorting the results, the results are sorted by relevance.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide sorting configuration, the results are sorted by the relevance
        /// that Amazon Kendra determines for the result.
        /// </para>
        /// </summary>
        public SortingConfiguration SortingConfiguration
        {
            get { return this._sortingConfiguration; }
            set { this._sortingConfiguration = value; }
        }

        // Check to see if SortingConfiguration property is set
        internal bool IsSetSortingConfiguration()
        {
            return this._sortingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SpellCorrectionConfiguration. 
        /// <para>
        /// Enables suggested spell corrections for queries.
        /// </para>
        /// </summary>
        public SpellCorrectionConfiguration SpellCorrectionConfiguration
        {
            get { return this._spellCorrectionConfiguration; }
            set { this._spellCorrectionConfiguration = value; }
        }

        // Check to see if SpellCorrectionConfiguration property is set
        internal bool IsSetSpellCorrectionConfiguration()
        {
            return this._spellCorrectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserContext. 
        /// <para>
        /// The user context token or user and group information.
        /// </para>
        /// </summary>
        public UserContext UserContext
        {
            get { return this._userContext; }
            set { this._userContext = value; }
        }

        // Check to see if UserContext property is set
        internal bool IsSetUserContext()
        {
            return this._userContext != null;
        }

        /// <summary>
        /// Gets and sets the property VisitorId. 
        /// <para>
        /// Provides an identifier for a specific user. The <code>VisitorId</code> should be a
        /// unique identifier, such as a GUID. Don't use personally identifiable information,
        /// such as the user's email address, as the <code>VisitorId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VisitorId
        {
            get { return this._visitorId; }
            set { this._visitorId = value; }
        }

        // Check to see if VisitorId property is set
        internal bool IsSetVisitorId()
        {
            return this._visitorId != null;
        }

    }
}
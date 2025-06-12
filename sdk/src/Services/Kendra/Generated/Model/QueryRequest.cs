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
    /// Container for the parameters to the Query operation.
    /// Searches an index given an input query.
    /// 
    ///  <note> 
    /// <para>
    /// If you are working with large language models (LLMs) or implementing retrieval augmented
    /// generation (RAG) systems, you can use Amazon Kendra's <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Retrieve.html">Retrieve</a>
    /// API, which can return longer semantically relevant passages. We recommend using the
    /// <c>Retrieve</c> API instead of filing a service limit increase to increase the <c>Query</c>
    /// API document excerpt length.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can configure boosting or relevance tuning at the query level to override boosting
    /// at the index level, filter based on document fields/attributes and faceted search,
    /// and filter based on the user or their group access to documents. You can also include
    /// certain fields in the response that might provide useful additional information.
    /// </para>
    ///  
    /// <para>
    /// A query response contains three types of results.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Relevant suggested answers. The answers can be either a text excerpt or table excerpt.
    /// The answer can be highlighted in the excerpt.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Matching FAQs or questions-answer from your FAQ file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Relevant documents. This result type includes an excerpt of the document with the
    /// document title. The searched terms can be highlighted in the excerpt.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can specify that the query return only one type of result using the <c>QueryResultTypeFilter</c>
    /// parameter. Each query returns the 100 most relevant results. If you filter result
    /// type to only question-answers, a maximum of four results are returned. If you filter
    /// result type to only answers, a maximum of three results are returned.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you're using an Amazon Kendra Gen AI Enterprise Edition index, you can only use
    /// <c>ATTRIBUTE_FILTER</c> to filter search results by user context. If you're using
    /// an Amazon Kendra Gen AI Enterprise Edition index and you try to use <c>USER_TOKEN</c>
    /// to configure user context policy, Amazon Kendra returns a <c>ValidationException</c>
    /// error.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class QueryRequest : AmazonKendraRequest
    {
        private AttributeFilter _attributeFilter;
        private CollapseConfiguration _collapseConfiguration;
        private List<DocumentRelevanceConfiguration> _documentRelevanceOverrideConfigurations = AWSConfigs.InitializeCollections ? new List<DocumentRelevanceConfiguration>() : null;
        private List<Facet> _facets = AWSConfigs.InitializeCollections ? new List<Facet>() : null;
        private string _indexId;
        private int? _pageNumber;
        private int? _pageSize;
        private QueryResultType _queryResultTypeFilter;
        private string _queryText;
        private List<string> _requestedDocumentAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SortingConfiguration _sortingConfiguration;
        private List<SortingConfiguration> _sortingConfigurations = AWSConfigs.InitializeCollections ? new List<SortingConfiguration>() : null;
        private SpellCorrectionConfiguration _spellCorrectionConfiguration;
        private UserContext _userContext;
        private string _visitorId;

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Filters search results by document fields/attributes. You can only provide one attribute
        /// filter; however, the <c>AndAllFilters</c>, <c>NotFilter</c>, and <c>OrAllFilters</c>
        /// parameters contain a list of other filters.
        /// </para>
        ///  
        /// <para>
        /// The <c>AttributeFilter</c> parameter means you can create a set of filtering rules
        /// that a document must satisfy to be included in the query results.
        /// </para>
        ///  <note> 
        /// <para>
        /// For Amazon Kendra Gen AI Enterprise Edition indices use <c>AttributeFilter</c> to
        /// enable document filtering for end users using <c>_email_id</c> or include public documents
        /// (<c>_email_id=null</c>).
        /// </para>
        ///  </note>
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
        /// Gets and sets the property CollapseConfiguration. 
        /// <para>
        /// Provides configuration to determine how to group results by document attribute value,
        /// and how to display them (collapsed or expanded) under a designated primary document
        /// for each group.
        /// </para>
        /// </summary>
        public CollapseConfiguration CollapseConfiguration
        {
            get { return this._collapseConfiguration; }
            set { this._collapseConfiguration = value; }
        }

        // Check to see if CollapseConfiguration property is set
        internal bool IsSetCollapseConfiguration()
        {
            return this._collapseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentRelevanceOverrideConfigurations. 
        /// <para>
        /// Overrides relevance tuning configurations of fields/attributes set at the index level.
        /// </para>
        ///  
        /// <para>
        /// If you use this API to override the relevance tuning configured at the index level,
        /// but there is no relevance tuning configured at the index level, then Amazon Kendra
        /// does not apply any relevance tuning.
        /// </para>
        ///  
        /// <para>
        /// If there is relevance tuning configured for fields at the index level, and you use
        /// this API to override only some of these fields, then for the fields you did not override,
        /// the importance is set to 1.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._documentRelevanceOverrideConfigurations != null && (this._documentRelevanceOverrideConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Facets. 
        /// <para>
        /// An array of documents fields/attributes for faceted search. Amazon Kendra returns
        /// a count for each field key specified. This helps your users narrow their search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Facet> Facets
        {
            get { return this._facets; }
            set { this._facets = value; }
        }

        // Check to see if Facets property is set
        internal bool IsSetFacets()
        {
            return this._facets != null && (this._facets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for the search.
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
        /// Query results are returned in pages the size of the <c>PageSize</c> parameter. By
        /// default, Amazon Kendra returns the first page of results. Use this parameter to get
        /// result pages after the first one.
        /// </para>
        /// </summary>
        public int? PageNumber
        {
            get { return this._pageNumber; }
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
        public int? PageSize
        {
            get { return this._pageSize; }
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
        /// Sets the type of query result or response. Only results for the specified type are
        /// returned.
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
        /// or more advanced, complex queries. For example, <c>Timeoff AND October AND Category:HR</c>
        /// is counted as 3 tokens: <c>timeoff</c>, <c>october</c>, <c>hr</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/searching-example.html#searching-index-query-syntax">Searching
        /// with advanced query syntax</a> in the Amazon Kendra Developer Guide. 
        /// </para>
        /// </summary>
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
        /// An array of document fields/attributes to include in the response. You can limit the
        /// response to include certain document fields. By default, all document attributes are
        /// included in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._requestedDocumentAttributes != null && (this._requestedDocumentAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property SortingConfigurations. 
        /// <para>
        /// Provides configuration information to determine how the results of a query are sorted.
        /// </para>
        ///  
        /// <para>
        /// You can set upto 3 fields that Amazon Kendra should sort the results on, and specify
        /// whether the results should be sorted in ascending or descending order. The sort field
        /// quota can be increased.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide a sorting configuration, the results are sorted by the relevance
        /// that Amazon Kendra determines for the result. In the case of ties in sorting the results,
        /// the results are sorted by relevance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<SortingConfiguration> SortingConfigurations
        {
            get { return this._sortingConfigurations; }
            set { this._sortingConfigurations = value; }
        }

        // Check to see if SortingConfigurations property is set
        internal bool IsSetSortingConfigurations()
        {
            return this._sortingConfigurations != null && (this._sortingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Provides an identifier for a specific user. The <c>VisitorId</c> should be a unique
        /// identifier, such as a GUID. Don't use personally identifiable information, such as
        /// the user's email address, as the <c>VisitorId</c>.
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
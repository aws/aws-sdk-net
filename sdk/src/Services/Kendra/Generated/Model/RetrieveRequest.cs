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
    /// Container for the parameters to the Retrieve operation.
    /// Retrieves relevant passages or text excerpts given an input query.
    /// 
    ///  
    /// <para>
    /// This API is similar to the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Query.html">Query</a>
    /// API. However, by default, the <c>Query</c> API only returns excerpt passages of up
    /// to 100 token words. With the <c>Retrieve</c> API, you can retrieve longer passages
    /// of up to 200 token words and up to 100 semantically relevant passages. This doesn't
    /// include question-answer or FAQ type responses from your index. The passages are text
    /// excerpts that can be semantically extracted from multiple documents and multiple parts
    /// of the same document. If in extreme cases your documents produce zero passages using
    /// the <c>Retrieve</c> API, you can alternatively use the <c>Query</c> API and its types
    /// of responses.
    /// </para>
    ///  
    /// <para>
    /// You can also do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Override boosting at the index level
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filter based on document fields or attributes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filter based on the user or their group access to documents
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the confidence score bucket for a retrieved passage result. The confidence bucket
    /// provides a relative ranking that indicates how confident Amazon Kendra is that the
    /// response is relevant to the query.
    /// </para>
    ///  <note> 
    /// <para>
    /// Confidence score buckets are currently available only for English.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// You can also include certain fields in the response that might provide useful additional
    /// information.
    /// </para>
    ///  
    /// <para>
    /// The <c>Retrieve</c> API shares the number of <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_CapacityUnitsConfiguration.html">query
    /// capacity units</a> that you set for your index. For more information on what's included
    /// in a single capacity unit and the default base capacity for an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/adjusting-capacity.html">Adjusting
    /// capacity</a>.
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
    public partial class RetrieveRequest : AmazonKendraRequest
    {
        private AttributeFilter _attributeFilter;
        private List<DocumentRelevanceConfiguration> _documentRelevanceOverrideConfigurations = AWSConfigs.InitializeCollections ? new List<DocumentRelevanceConfiguration>() : null;
        private string _indexId;
        private int? _pageNumber;
        private int? _pageSize;
        private string _queryText;
        private List<string> _requestedDocumentAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private UserContext _userContext;

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
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index to retrieve relevant passages for the search.
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
        /// Retrieved relevant passages are returned in pages the size of the <c>PageSize</c>
        /// parameter. By default, Amazon Kendra returns the first page of results. Use this parameter
        /// to get result pages after the first one.
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
        /// Sets the number of retrieved relevant passages that are returned in each page of results.
        /// The default page size is 10. The maximum number of results returned is 100. If you
        /// ask for more than 100 results, only 100 are returned.
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
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The input query text to retrieve relevant passages for the search. Amazon Kendra truncates
        /// queries at 30 token words, which excludes punctuation and stop words. Truncation still
        /// applies if you use Boolean or more advanced, complex queries. For example, <c>Timeoff
        /// AND October AND Category:HR</c> is counted as 3 tokens: <c>timeoff</c>, <c>october</c>,
        /// <c>hr</c>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/searching-example.html#searching-index-query-syntax">Searching
        /// with advanced query syntax</a> in the Amazon Kendra Developer Guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of document fields/attributes to include in the response. You can limit the
        /// response to include certain document fields. By default, all document fields are included
        /// in the response.
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

    }
}
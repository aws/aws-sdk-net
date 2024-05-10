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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Container for the parameters to the Search operation.
    /// Retrieves a list of documents that match the specified search criteria. How you specify
    /// the search criteria depends on which query parser you use. Amazon CloudSearch supports
    /// four query parsers:
    /// 
    ///  <ul> <li><c>simple</c>: search all <c>text</c> and <c>text-array</c> fields for the
    /// specified string. Search for phrases, individual terms, and prefixes. </li> <li><c>structured</c>:
    /// search specific fields, construct compound queries using Boolean operators, and use
    /// advanced features such as term boosting and proximity searching.</li> <li><c>lucene</c>:
    /// specify search criteria using the Apache Lucene query parser syntax.</li> <li><c>dismax</c>:
    /// specify search criteria using the simplified subset of the Apache Lucene query parser
    /// syntax defined by the DisMax query parser.</li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching.html">Searching
    /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for submitting <c>Search</c> requests is domain-specific. You submit
    /// search requests to a domain's search endpoint. To get the search endpoint for your
    /// domain, use the Amazon CloudSearch configuration service <c>DescribeDomains</c> action.
    /// A domain's endpoints are also displayed on the domain dashboard in the Amazon CloudSearch
    /// console. 
    /// </para>
    /// </summary>
    public partial class SearchRequest : AmazonCloudSearchDomainRequest
    {
        private string _cursor;
        private string _expr;
        private string _facet;
        private string _filterQuery;
        private string _highlight;
        private bool? _partial;
        private string _query;
        private string _queryOptions;
        private QueryParser _queryParser;
        private string _return;
        private long? _size;
        private string _sort;
        private long? _start;
        private string _stats;

        /// <summary>
        /// Gets and sets the property Cursor. 
        /// <para>
        /// Retrieves a cursor value you can use to page through large result sets. Use the <c>size</c>
        /// parameter to control the number of hits to include in each response. You can specify
        /// either the <c>cursor</c> or <c>start</c> parameter in a request; they are mutually
        /// exclusive. To get the first cursor, set the cursor value to <c>initial</c>. In subsequent
        /// requests, specify the cursor value returned in the hits section of the response. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/paginating-results.html">Paginating
        /// Results</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Cursor
        {
            get { return this._cursor; }
            set { this._cursor = value; }
        }

        // Check to see if Cursor property is set
        internal bool IsSetCursor()
        {
            return this._cursor != null;
        }

        /// <summary>
        /// Gets and sets the property Expr. 
        /// <para>
        /// Defines one or more numeric expressions that can be used to sort results or specify
        /// search or filter criteria. You can also specify expressions as return fields. 
        /// </para>
        ///  
        /// <para>
        /// You specify the expressions in JSON using the form <c>{"EXPRESSIONNAME":"EXPRESSION"}</c>.
        /// You can define and use multiple expressions in a search request. For example:
        /// </para>
        ///  
        /// <para>
        /// <c> {"expression1":"_score*rating", "expression2":"(1/rank)*year"} </c> 
        /// </para>
        ///  
        /// <para>
        /// For information about the variables, operators, and functions you can use in expressions,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html#writing-expressions">Writing
        /// Expressions</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Expr
        {
            get { return this._expr; }
            set { this._expr = value; }
        }

        // Check to see if Expr property is set
        internal bool IsSetExpr()
        {
            return this._expr != null;
        }

        /// <summary>
        /// Gets and sets the property Facet. 
        /// <para>
        /// Specifies one or more fields for which to get facet information, and options that
        /// control how the facet information is returned. Each specified field must be facet-enabled
        /// in the domain configuration. The fields and options are specified in JSON using the
        /// form <c>{"FIELD":{"OPTION":VALUE,"OPTION:"STRING"},"FIELD":{"OPTION":VALUE,"OPTION":"STRING"}}</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following faceting options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <c>buckets</c> specifies an array of the facet values or ranges to count. Ranges are
        /// specified using the same syntax that you use to search for a range of values. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching-ranges.html">
        /// Searching for a Range of Values</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// Buckets are returned in the order they are specified in the request. The <c>sort</c>
        /// and <c>size</c> options are not valid if you specify <c>buckets</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <c>size</c> specifies the maximum number of facets to include in the results. By default,
        /// Amazon CloudSearch returns counts for the top 10. The <c>size</c> parameter is only
        /// valid when you specify the <c>sort</c> option; it cannot be used in conjunction with
        /// <c>buckets</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <c>sort</c> specifies how you want to sort the facets in the results: <c>bucket</c>
        /// or <c>count</c>. Specify <c>bucket</c> to sort alphabetically or numerically by facet
        /// value (in ascending order). Specify <c>count</c> to sort by the facet counts computed
        /// for each facet value (in descending order). To retrieve facet counts for particular
        /// values or ranges of values, use the <c>buckets</c> option instead of <c>sort</c>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no facet options are specified, facet counts are computed for all field values,
        /// the facets are sorted by facet count, and the top 10 facets are returned in the results.
        /// </para>
        ///  
        /// <para>
        /// To count particular buckets of values, use the <c>buckets</c> option. For example,
        /// the following request uses the <c>buckets</c> option to calculate and return facet
        /// counts by decade.
        /// </para>
        ///  
        /// <para>
        /// <c> {"year":{"buckets":["[1970,1979]","[1980,1989]","[1990,1999]","[2000,2009]","[2010,}"]}}
        /// </c>
        /// </para>
        ///  
        /// <para>
        /// To sort facets by facet count, use the <c>count</c> option. For example, the following
        /// request sets the <c>sort</c> option to <c>count</c> to sort the facet values by facet
        /// count, with the facet values that have the most matching documents listed first. Setting
        /// the <c>size</c> option to 3 returns only the top three facet values.
        /// </para>
        ///  
        /// <para>
        /// <c> {"year":{"sort":"count","size":3}} </c>
        /// </para>
        ///  
        /// <para>
        /// To sort the facets by value, use the <c>bucket</c> option. For example, the following
        /// request sets the <c>sort</c> option to <c>bucket</c> to sort the facet values numerically
        /// by year, with earliest year listed first. 
        /// </para>
        ///  
        /// <para>
        /// <c> {"year":{"sort":"bucket"}} </c>
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/faceting.html">Getting
        /// and Using Facet Information</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Facet
        {
            get { return this._facet; }
            set { this._facet = value; }
        }

        // Check to see if Facet property is set
        internal bool IsSetFacet()
        {
            return this._facet != null;
        }

        /// <summary>
        /// Gets and sets the property FilterQuery. 
        /// <para>
        /// Specifies a structured query that filters the results of a search without affecting
        /// how the results are scored and sorted. You use <c>filterQuery</c> in conjunction with
        /// the <c>query</c> parameter to filter the documents that match the constraints specified
        /// in the <c>query</c> parameter. Specifying a filter controls only which matching documents
        /// are included in the results, it has no effect on how they are scored and sorted. The
        /// <c>filterQuery</c> parameter supports the full structured query syntax. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using filters, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/filtering-results.html">Filtering
        /// Matching Documents</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string FilterQuery
        {
            get { return this._filterQuery; }
            set { this._filterQuery = value; }
        }

        // Check to see if FilterQuery property is set
        internal bool IsSetFilterQuery()
        {
            return this._filterQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Highlight. 
        /// <para>
        /// Retrieves highlights for matches in the specified <c>text</c> or <c>text-array</c>
        /// fields. Each specified field must be highlight enabled in the domain configuration.
        /// The fields and options are specified in JSON using the form <c>{"FIELD":{"OPTION":VALUE,"OPTION:"STRING"},"FIELD":{"OPTION":VALUE,"OPTION":"STRING"}}</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following highlight options:
        /// </para>
        ///  <ul> <li> <c>format</c>: specifies the format of the data in the text field: <c>text</c>
        /// or <c>html</c>. When data is returned as HTML, all non-alphanumeric characters are
        /// encoded. The default is <c>html</c>. </li> <li> <c>max_phrases</c>: specifies the
        /// maximum number of occurrences of the search term(s) you want to highlight. By default,
        /// the first occurrence is highlighted. </li> <li> <c>pre_tag</c>: specifies the string
        /// to prepend to an occurrence of a search term. The default for HTML highlights is <c>&amp;lt;em&amp;gt;</c>.
        /// The default for text highlights is <c>*</c>. </li> <li> <c>post_tag</c>: specifies
        /// the string to append to an occurrence of a search term. The default for HTML highlights
        /// is <c>&amp;lt;/em&amp;gt;</c>. The default for text highlights is <c>*</c>. </li>
        /// </ul> 
        /// <para>
        /// If no highlight options are specified for a field, the returned field text is treated
        /// as HTML and the first match is highlighted with emphasis tags: <c>&amp;lt;em&gt;search-term&amp;lt;/em&amp;gt;</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, the following request retrieves highlights for the <c>actors</c> and
        /// <c>title</c> fields.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "actors": {}, "title": {"format": "text","max_phrases": 2,"pre_tag": "<b>","post_tag":
        /// "</b>"} }</c>
        /// </para>
        /// </summary>
        public string Highlight
        {
            get { return this._highlight; }
            set { this._highlight = value; }
        }

        // Check to see if Highlight property is set
        internal bool IsSetHighlight()
        {
            return this._highlight != null;
        }

        /// <summary>
        /// Gets and sets the property Partial. 
        /// <para>
        /// Enables partial results to be returned if one or more index partitions are unavailable.
        /// When your search index is partitioned across multiple search instances, by default
        /// Amazon CloudSearch only returns results if every partition can be queried. This means
        /// that the failure of a single search instance can result in 5xx (internal server) errors.
        /// When you enable partial results, Amazon CloudSearch returns whatever results are available
        /// and includes the percentage of documents searched in the search results (percent-searched).
        /// This enables you to more gracefully degrade your users' search experience. For example,
        /// rather than displaying no results, you could display the partial results and a message
        /// indicating that the results might be incomplete due to a temporary system outage.
        /// </para>
        /// </summary>
        public bool? Partial
        {
            get { return this._partial; }
            set { this._partial = value; }
        }

        // Check to see if Partial property is set
        internal bool IsSetPartial()
        {
            return this._partial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// Specifies the search criteria for the request. How you specify the search criteria
        /// depends on the query parser used for the request and the parser options specified
        /// in the <c>queryOptions</c> parameter. By default, the <c>simple</c> query parser is
        /// used to process requests. To use the <c>structured</c>, <c>lucene</c>, or <c>dismax</c>
        /// query parser, you must also specify the <c>queryParser</c> parameter. 
        /// </para>
        ///  
        /// <para>
        /// For more information about specifying search criteria, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching.html">Searching
        /// Your Data</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property QueryOptions. 
        /// <para>
        /// Configures options for the query parser specified in the <c>queryParser</c> parameter.
        /// You specify the options in JSON using the following form <c>{"OPTION1":"VALUE1","OPTION2":VALUE2"..."OPTIONN":"VALUEN"}.</c>
        /// </para>
        ///  
        /// <para>
        /// The options you can configure vary according to which parser you use:
        /// </para>
        ///  <ul> <li><c>defaultOperator</c>: The default operator used to combine individual
        /// terms in the search string. For example: <c>defaultOperator: 'or'</c>. For the <c>dismax</c>
        /// parser, you specify a percentage that represents the percentage of terms in the search
        /// string (rounded down) that must match, rather than a default operator. A value of
        /// <c>0%</c> is the equivalent to OR, and a value of <c>100%</c> is equivalent to AND.
        /// The percentage must be specified as a value in the range 0-100 followed by the percent
        /// (%) symbol. For example, <c>defaultOperator: 50%</c>. Valid values: <c>and</c>, <c>or</c>,
        /// a percentage in the range 0%-100% (<c>dismax</c>). Default: <c>and</c> (<c>simple</c>,
        /// <c>structured</c>, <c>lucene</c>) or <c>100</c> (<c>dismax</c>). Valid for: <c>simple</c>,
        /// <c>structured</c>, <c>lucene</c>, and <c>dismax</c>.</li> <li><c>fields</c>: An array
        /// of the fields to search when no fields are specified in a search. If no fields are
        /// specified in a search and this option is not specified, all text and text-array fields
        /// are searched. You can specify a weight for each field to control the relative importance
        /// of each field when Amazon CloudSearch calculates relevance scores. To specify a field
        /// weight, append a caret (<c>^</c>) symbol and the weight to the field name. For example,
        /// to boost the importance of the <c>title</c> field over the <c>description</c> field
        /// you could specify: <c>"fields":["title^5","description"]</c>. Valid values: The name
        /// of any configured field and an optional numeric value greater than zero. Default:
        /// All <c>text</c> and <c>text-array</c> fields. Valid for: <c>simple</c>, <c>structured</c>,
        /// <c>lucene</c>, and <c>dismax</c>.</li> <li><c>operators</c>: An array of the operators
        /// or special characters you want to disable for the simple query parser. If you disable
        /// the <c>and</c>, <c>or</c>, or <c>not</c> operators, the corresponding operators (<c>+</c>,
        /// <c>|</c>, <c>-</c>) have no special meaning and are dropped from the search string.
        /// Similarly, disabling <c>prefix</c> disables the wildcard operator (<c>*</c>) and disabling
        /// <c>phrase</c> disables the ability to search for phrases by enclosing phrases in double
        /// quotes. Disabling precedence disables the ability to control order of precedence using
        /// parentheses. Disabling <c>near</c> disables the ability to use the ~ operator to perform
        /// a sloppy phrase search. Disabling the <c>fuzzy</c> operator disables the ability to
        /// use the ~ operator to perform a fuzzy search. <c>escape</c> disables the ability to
        /// use a backslash (<c>\</c>) to escape special characters within the search string.
        /// Disabling whitespace is an advanced option that prevents the parser from tokenizing
        /// on whitespace, which can be useful for Vietnamese. (It prevents Vietnamese words from
        /// being split incorrectly.) For example, you could disable all operators other than
        /// the phrase operator to support just simple term and phrase queries: <c>"operators":["and","not","or",
        /// "prefix"]</c>. Valid values: <c>and</c>, <c>escape</c>, <c>fuzzy</c>, <c>near</c>,
        /// <c>not</c>, <c>or</c>, <c>phrase</c>, <c>precedence</c>, <c>prefix</c>, <c>whitespace</c>.
        /// Default: All operators and special characters are enabled. Valid for: <c>simple</c>.</li>
        /// <li><c>phraseFields</c>: An array of the <c>text</c> or <c>text-array</c> fields you
        /// want to use for phrase searches. When the terms in the search string appear in close
        /// proximity within a field, the field scores higher. You can specify a weight for each
        /// field to boost that score. The <c>phraseSlop</c> option controls how much the matches
        /// can deviate from the search string and still be boosted. To specify a field weight,
        /// append a caret (<c>^</c>) symbol and the weight to the field name. For example, to
        /// boost phrase matches in the <c>title</c> field over the <c>abstract</c> field, you
        /// could specify: <c>"phraseFields":["title^3", "plot"]</c> Valid values: The name of
        /// any <c>text</c> or <c>text-array</c> field and an optional numeric value greater than
        /// zero. Default: No fields. If you don't specify any fields with <c>phraseFields</c>,
        /// proximity scoring is disabled even if <c>phraseSlop</c> is specified. Valid for: <c>dismax</c>.</li>
        /// <li><c>phraseSlop</c>: An integer value that specifies how much matches can deviate
        /// from the search phrase and still be boosted according to the weights specified in
        /// the <c>phraseFields</c> option; for example, <c>phraseSlop: 2</c>. You must also specify
        /// <c>phraseFields</c> to enable proximity scoring. Valid values: positive integers.
        /// Default: 0. Valid for: <c>dismax</c>.</li> <li><c>explicitPhraseSlop</c>: An integer
        /// value that specifies how much a match can deviate from the search phrase when the
        /// phrase is enclosed in double quotes in the search string. (Phrases that exceed this
        /// proximity distance are not considered a match.) For example, to specify a slop of
        /// three for dismax phrase queries, you would specify <c>"explicitPhraseSlop":3</c>.
        /// Valid values: positive integers. Default: 0. Valid for: <c>dismax</c>.</li> <li><c>tieBreaker</c>:
        /// When a term in the search string is found in a document's field, a score is calculated
        /// for that field based on how common the word is in that field compared to other documents.
        /// If the term occurs in multiple fields within a document, by default only the highest
        /// scoring field contributes to the document's overall score. You can specify a <c>tieBreaker</c>
        /// value to enable the matches in lower-scoring fields to contribute to the document's
        /// score. That way, if two documents have the same max field score for a particular term,
        /// the score for the document that has matches in more fields will be higher. The formula
        /// for calculating the score with a tieBreaker is <c>(max field score) + (tieBreaker)
        /// * (sum of the scores for the rest of the matching fields)</c>. Set <c>tieBreaker</c>
        /// to 0 to disregard all but the highest scoring field (pure max): <c>"tieBreaker":0</c>.
        /// Set to 1 to sum the scores from all fields (pure sum): <c>"tieBreaker":1</c>. Valid
        /// values: 0.0 to 1.0. Default: 0.0. Valid for: <c>dismax</c>. </li> </ul>
        /// </summary>
        public string QueryOptions
        {
            get { return this._queryOptions; }
            set { this._queryOptions = value; }
        }

        // Check to see if QueryOptions property is set
        internal bool IsSetQueryOptions()
        {
            return this._queryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParser. 
        /// <para>
        /// Specifies which query parser to use to process the request. If <c>queryParser</c>
        /// is not specified, Amazon CloudSearch uses the <c>simple</c> query parser. 
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudSearch supports four query parsers:
        /// </para>
        ///  <ul> <li> <c>simple</c>: perform simple searches of <c>text</c> and <c>text-array</c>
        /// fields. By default, the <c>simple</c> query parser searches all <c>text</c> and <c>text-array</c>
        /// fields. You can specify which fields to search by with the <c>queryOptions</c> parameter.
        /// If you prefix a search term with a plus sign (+) documents must contain the term to
        /// be considered a match. (This is the default, unless you configure the default operator
        /// with the <c>queryOptions</c> parameter.) You can use the <c>-</c> (NOT), <c>|</c>
        /// (OR), and <c>*</c> (wildcard) operators to exclude particular terms, find results
        /// that match any of the specified terms, or search for a prefix. To search for a phrase
        /// rather than individual terms, enclose the phrase in double quotes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching-text.html">Searching
        /// for Text</a> in the <i>Amazon CloudSearch Developer Guide</i>. </li> <li> <c>structured</c>:
        /// perform advanced searches by combining multiple expressions to define the search criteria.
        /// You can also search within particular fields, search for values and ranges of values,
        /// and use advanced options such as term boosting, <c>matchall</c>, and <c>near</c>.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/searching-compound-queries.html">Constructing
        /// Compound Queries</a> in the <i>Amazon CloudSearch Developer Guide</i>. </li> <li>
        /// <c>lucene</c>: search using the Apache Lucene query parser syntax. For more information,
        /// see <a href="http://lucene.apache.org/core/4_6_0/queryparser/org/apache/lucene/queryparser/classic/package-summary.html#package_description">Apache
        /// Lucene Query Parser Syntax</a>. </li> <li> <c>dismax</c>: search using the simplified
        /// subset of the Apache Lucene query parser syntax defined by the DisMax query parser.
        /// For more information, see <a href="http://wiki.apache.org/solr/DisMaxQParserPlugin#Query_Syntax">DisMax
        /// Query Parser Syntax</a>. </li> </ul>
        /// </summary>
        public QueryParser QueryParser
        {
            get { return this._queryParser; }
            set { this._queryParser = value; }
        }

        // Check to see if QueryParser property is set
        internal bool IsSetQueryParser()
        {
            return this._queryParser != null;
        }

        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// Specifies the field and expression values to include in the response. Multiple fields
        /// or expressions are specified as a comma-separated list. By default, a search response
        /// includes all return enabled fields (<c>_all_fields</c>). To return only the document
        /// IDs for the matching documents, specify <c>_no_fields</c>. To retrieve the relevance
        /// score calculated for each document, specify <c>_score</c>. 
        /// </para>
        /// </summary>
        public string Return
        {
            get { return this._return; }
            set { this._return = value; }
        }

        // Check to see if Return property is set
        internal bool IsSetReturn()
        {
            return this._return != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// Specifies the maximum number of search hits to include in the response. 
        /// </para>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the fields or custom expressions to use to sort the search results. Multiple
        /// fields or expressions are specified as a comma-separated list. You must specify the
        /// sort direction (<c>asc</c> or <c>desc</c>) for each field; for example, <c>year desc,title
        /// asc</c>. To use a field to sort results, the field must be sort-enabled in the domain
        /// configuration. Array type fields cannot be used for sorting. If no <c>sort</c> parameter
        /// is specified, results are sorted by their default relevance scores in descending order:
        /// <c>_score desc</c>. You can also sort by document ID (<c>_id asc</c>) and version
        /// (<c>_version desc</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/sorting-results.html">Sorting
        /// Results</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Specifies the offset of the first search hit you want to return. Note that the result
        /// set is zero-based; the first result is at index 0. You can specify either the <c>start</c>
        /// or <c>cursor</c> parameter in a request, they are mutually exclusive. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/paginating-results.html">Paginating
        /// Results</a> in the <i>Amazon CloudSearch Developer Guide</i>.
        /// </para>
        /// </summary>
        public long? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stats. 
        /// <para>
        /// Specifies one or more fields for which to get statistics information. Each specified
        /// field must be facet-enabled in the domain configuration. The fields are specified
        /// in JSON using the form:
        /// </para>
        ///  <c>{"FIELD-A":{},"FIELD-B":{}}</c> 
        /// <para>
        /// There are currently no options supported for statistics.
        /// </para>
        /// </summary>
        public string Stats
        {
            get { return this._stats; }
            set { this._stats = value; }
        }

        // Check to see if Stats property is set
        internal bool IsSetStats()
        {
            return this._stats != null;
        }

    }
}
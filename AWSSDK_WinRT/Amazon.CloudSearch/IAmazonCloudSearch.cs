/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.CloudSearch.Model;

namespace Amazon.CloudSearch
{
    /// <summary>
    /// Interface for accessing AmazonCloudSearch.
    /// 
    /// Amazon CloudSearch Configuration Service <para>You use the Amazon CloudSearch configuration service to create, configure, and manage search
    /// domains. Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted
    /// via HTTP GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
    /// cloudsearch. <i>region</i> .amazonaws.com. For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region">Regions and Endpoints</a> .</para>
    /// </summary>
	public partial interface IAmazonCloudSearch : IDisposable
    {
 
        /// <summary>
        /// <para>Indexes the search suggestions. </para>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<BuildSuggestersResponse> BuildSuggestersAsync(BuildSuggestersRequest buildSuggestersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates a new search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html">Creating a Search Domain</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures an analysis scheme for a domain. An analysis scheme defines language-specific text processing options for a <c>text</c>
        /// field. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineAnalysisSchemeResponse> DefineAnalysisSchemeAsync(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures an <c> Expression </c> for the search domain. Used to create new expressions and modify existing ones. If the expression
        /// exists, the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineExpressionResponse> DefineExpressionAsync(DefineExpressionRequest defineExpressionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures an <c> IndexField </c> for the search domain. Used to create new fields and modify existing ones. You must specify the name
        /// of the domain you are configuring and an index field configuration. The index field configuration specifies a unique name, the index field
        /// type, and the options you want to configure for the field. The options you can specify depend on the <c> IndexFieldType </c> . If the field
        /// exists, the new configuration replaces the old one. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html">Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest defineIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures a suggester for a domain. A suggester enables you to display possible matches before users finish typing their queries.
        /// When you configure a suggester, you must specify the name of the text field you want to search for possible matches and a unique name for
        /// the suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineSuggesterResponse> DefineSuggesterAsync(DefineSuggesterRequest defineSuggesterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes an analysis scheme. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html.html">Configuring Analysis Schemes</a>
        /// in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAnalysisSchemeResponse> DeleteAnalysisSchemeAsync(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data. Once a domain has been deleted, it cannot be recovered. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html">Deleting a Search Domain</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes an <c> Expression </c> from the search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteExpressionResponse> DeleteExpressionAsync(DeleteExpressionRequest deleteExpressionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes an <c> IndexField </c> from the search domain. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html">Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest deleteIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes a suggester. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteSuggesterResponse> DeleteSuggesterAsync(DeleteSuggesterRequest deleteSuggesterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific text processing options for a
        /// <c>text</c> field. Can be limited to specific analysis schemes by name. By default, shows all analysis schemes and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html">Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAnalysisSchemesResponse> DescribeAnalysisSchemesAsync(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the availability options configured for a domain. By default, shows the configuration with any pending changes. Set the
        /// <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html">Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.DisabledOperationException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html">Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest describeDomainsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the expressions configured for the search domain. Can be limited to specific expressions by name. By default, shows all
        /// expressions and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html">Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeExpressionsResponse> DescribeExpressionsAsync(DescribeExpressionsRequest describeExpressionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. By default,
        /// shows all fields and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html">Getting Domain Information</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest describeIndexFieldsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the scaling parameters configured for a domain. A domain's scaling parameters specify the desired search instance type and
        /// replication count. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html">Configuring Scaling Options</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScalingParametersResponse> DescribeScalingParametersAsync(DescribeScalingParametersRequest describeScalingParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the access policies that control access to the domain's document and search endpoints. By default, shows the
        /// configuration with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending
        /// changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html">Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        /// service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the suggesters configured for a domain. A suggester enables you to display possible matches before users finish typing their
        /// queries. Can be limited to specific suggesters by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more
        /// information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html">Getting Search
        /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeSuggestersResponse> DescribeSuggestersAsync(DescribeSuggestersRequest describeSuggestersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest indexing options. This operation must be invoked to activate
        /// options whose OptionStatus is <c>RequiresIndexDocuments</c> .</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest indexDocumentsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest listDomainNamesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures the availability options for a domain. Enabling the Multi-AZ option expands an Amazon CloudSearch domain to an additional
        /// Availability Zone in the same Region to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ option can
        /// take about half an hour to become active. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html">Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.DisabledOperationException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures scaling parameters for a domain. A domain's scaling parameters specify the desired search instance type and replication
        /// count. Amazon CloudSearch will still automatically scale your domain based on the volume of data and traffic, but not below the desired
        /// instance type and replication count. If the Multi-AZ option is enabled, these values control the resources used per Availability Zone. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html">Configuring
        /// Scaling Options</a> in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateScalingParametersResponse> UpdateScalingParametersAsync(UpdateScalingParametersRequest updateScalingParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures the access rules that control access to the domain's document and search endpoints. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"> Configuring Access for an Amazon CloudSearch
        /// Domain</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}

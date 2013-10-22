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
    /// Amazon CloudSearch Configuration Service <para>You use the configuration service to create, configure, and manage search domains.
    /// Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted via HTTP
    /// GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
    /// cloudsearch. <i>region</i> .amazonaws.com. For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region">Regions and Endpoints</a> .</para>
    /// </summary>
	public partial interface IAmazonCloudSearch : IDisposable
    {
 
        /// <summary>
        /// <para>Creates a new search domain.</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures an <c>IndexField</c> for the search domain. Used to create new fields and modify existing ones. If the field exists, the
        /// new configuration replaces the old one. You can configure a maximum of 200 index fields.</para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest defineIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures a <c>RankExpression</c> for the search domain. Used to create new rank expressions and modify existing ones. If the
        /// expression exists, the new configuration replaces the old one. You can configure a maximum of 50 rank expressions.</para>
        /// </summary>
        /// 
        /// <param name="defineRankExpressionRequest">Container for the necessary parameters to execute the DefineRankExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DefineRankExpressionResponse> DefineRankExpressionAsync(DefineRankExpressionRequest defineRankExpressionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data.</para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes an <c>IndexField</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest deleteIndexFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes a <c>RankExpression</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteRankExpressionRequest">Container for the necessary parameters to execute the DeleteRankExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteRankExpressionResponse> DeleteRankExpressionAsync(DeleteRankExpressionRequest deleteRankExpressionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the default search field configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeDefaultSearchFieldRequest">Container for the necessary parameters to execute the DescribeDefaultSearchField service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDefaultSearchFieldResponse> DescribeDefaultSearchFieldAsync(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest describeDomainsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. Shows all fields
        /// by default.</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest describeIndexFieldsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the rank expressions configured for the search domain. Can be limited to specific rank expressions by name. Shows all rank
        /// expressions by default. </para>
        /// </summary>
        /// 
        /// <param name="describeRankExpressionsRequest">Container for the necessary parameters to execute the DescribeRankExpressions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeRankExpressionsResponse> DescribeRankExpressionsAsync(DescribeRankExpressionsRequest describeRankExpressionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the resource-based policies that control access to the domain's document and search services.</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        /// service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the stemming dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStemmingOptionsRequest">Container for the necessary parameters to execute the DescribeStemmingOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeStemmingOptionsResponse> DescribeStemmingOptionsAsync(DescribeStemmingOptionsRequest describeStemmingOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the stopwords configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStopwordOptionsRequest">Container for the necessary parameters to execute the DescribeStopwordOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeStopwordOptionsResponse> DescribeStopwordOptionsAsync(DescribeStopwordOptionsRequest describeStopwordOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets the synonym dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeSynonymOptionsRequest">Container for the necessary parameters to execute the DescribeSynonymOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeSynonymOptionsResponse> DescribeSynonymOptionsAsync(DescribeSynonymOptionsRequest describeSynonymOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest text processing options and <c>IndexFields</c> . This
        /// operation must be invoked to make options whose OptionStatus has <c>OptionState</c> of <c>RequiresIndexDocuments</c> visible in search
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest indexDocumentsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures the default search field for the search domain. The default search field is the text field that is searched when a search
        /// request does not specify which fields to search. By default, it is configured to include the contents of all of the domain's text fields.
        /// </para>
        /// </summary>
        /// 
        /// <param name="updateDefaultSearchFieldRequest">Container for the necessary parameters to execute the UpdateDefaultSearchField service method
        /// on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateDefaultSearchFieldResponse> UpdateDefaultSearchFieldAsync(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures the policies that control access to the domain's document and search services. The maximum size of an access policy
        /// document is 100 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures a stemming dictionary for the search domain. The stemming dictionary is used during indexing and when processing search
        /// requests. The maximum size of the stemming dictionary is 500 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStemmingOptionsRequest">Container for the necessary parameters to execute the UpdateStemmingOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateStemmingOptionsResponse> UpdateStemmingOptionsAsync(UpdateStemmingOptionsRequest updateStemmingOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures stopwords for the search domain. Stopwords are used during indexing and when processing search requests. The maximum size
        /// of the stopwords dictionary is 10 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStopwordOptionsRequest">Container for the necessary parameters to execute the UpdateStopwordOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateStopwordOptionsResponse> UpdateStopwordOptionsAsync(UpdateStopwordOptionsRequest updateStopwordOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Configures a synonym dictionary for the search domain. The synonym dictionary is used during indexing to configure mappings for terms
        /// that occur in text fields. The maximum size of the synonym dictionary is 100 KB. </para>
        /// </summary>
        /// 
        /// <param name="updateSynonymOptionsRequest">Container for the necessary parameters to execute the UpdateSynonymOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateSynonymOptionsResponse> UpdateSynonymOptionsAsync(UpdateSynonymOptionsRequest updateSynonymOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}

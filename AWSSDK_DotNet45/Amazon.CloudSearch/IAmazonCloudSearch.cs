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
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures an <c>IndexField</c> for the search domain. Used to create new fields and modify existing ones. If the field exists, the
        /// new configuration replaces the old one. You can configure a maximum of 200 index fields.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures a <c>RankExpression</c> for the search domain. Used to create new rank expressions and modify existing ones. If the
        /// expression exists, the new configuration replaces the old one. You can configure a maximum of 50 rank expressions.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		DefineRankExpressionResponse DefineRankExpression(DefineRankExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineRankExpression"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DefineRankExpressionResponse> DefineRankExpressionAsync(DefineRankExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes an <c>IndexField</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes a <c>RankExpression</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		DeleteRankExpressionResponse DeleteRankExpression(DeleteRankExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteRankExpression"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteRankExpressionResponse> DeleteRankExpressionAsync(DeleteRankExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets the default search field configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeDefaultSearchFieldResponse DescribeDefaultSearchField(DescribeDefaultSearchFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeDefaultSearchFieldResponse> DescribeDefaultSearchFieldAsync(DescribeDefaultSearchFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeDomainsResponse DescribeDomains();
 

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. Shows all fields
        /// by default.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets the rank expressions configured for the search domain. Can be limited to specific rank expressions by name. Shows all rank
        /// expressions by default. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeRankExpressionsResponse DescribeRankExpressions(DescribeRankExpressionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeRankExpressions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeRankExpressionsResponse> DescribeRankExpressionsAsync(DescribeRankExpressionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets information about the resource-based policies that control access to the domain's document and search services.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        /// service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets the stemming dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeStemmingOptionsResponse DescribeStemmingOptions(DescribeStemmingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeStemmingOptionsResponse> DescribeStemmingOptionsAsync(DescribeStemmingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets the stopwords configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeStopwordOptionsResponse DescribeStopwordOptions(DescribeStopwordOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeStopwordOptionsResponse> DescribeStopwordOptionsAsync(DescribeStopwordOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Gets the synonym dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		DescribeSynonymOptionsResponse DescribeSynonymOptions(DescribeSynonymOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSynonymOptionsResponse> DescribeSynonymOptionsAsync(DescribeSynonymOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest text processing options and <c>IndexFields</c> . This
        /// operation must be invoked to make options whose OptionStatus has <c>OptionState</c> of <c>RequiresIndexDocuments</c> visible in search
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
		IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures the default search field for the search domain. The default search field is the text field that is searched when a search
        /// request does not specify which fields to search. By default, it is configured to include the contents of all of the domain's text fields.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField service method
        /// on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		UpdateDefaultSearchFieldResponse UpdateDefaultSearchField(UpdateDefaultSearchFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateDefaultSearchFieldResponse> UpdateDefaultSearchFieldAsync(UpdateDefaultSearchFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures the policies that control access to the domain's document and search services. The maximum size of an access policy
        /// document is 100 KB.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        /// method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures a stemming dictionary for the search domain. The stemming dictionary is used during indexing and when processing search
        /// requests. The maximum size of the stemming dictionary is 500 KB.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		UpdateStemmingOptionsResponse UpdateStemmingOptions(UpdateStemmingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateStemmingOptionsResponse> UpdateStemmingOptionsAsync(UpdateStemmingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures stopwords for the search domain. Stopwords are used during indexing and when processing search requests. The maximum size
        /// of the stopwords dictionary is 10 KB.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		UpdateStopwordOptionsResponse UpdateStopwordOptions(UpdateStopwordOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateStopwordOptionsResponse> UpdateStopwordOptionsAsync(UpdateStopwordOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Configures a synonym dictionary for the search domain. The synonym dictionary is used during indexing to configure mappings for terms
        /// that occur in text fields. The maximum size of the synonym dictionary is 100 KB. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions service method on
        /// AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudSearch.Model.BaseException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InternalException" />
        /// <exception cref="T:Amazon.CloudSearch.Model.InvalidTypeException" />
		UpdateSynonymOptionsResponse UpdateSynonymOptions(UpdateSynonymOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateSynonymOptionsResponse> UpdateSynonymOptionsAsync(UpdateSynonymOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}

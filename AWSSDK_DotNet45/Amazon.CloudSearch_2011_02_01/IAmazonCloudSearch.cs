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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudSearch_2011_02_01.Model;

namespace Amazon.CloudSearch_2011_02_01
{
    /// <summary>
    /// Interface for accessing CloudSearch
    ///
    /// Amazon CloudSearch Configuration Service 
    /// <para>
    /// You use the configuration service to create, configure, and manage search domains.
    /// Configuration service requests are submitted using the AWS Query protocol. AWS Query
    /// requests are HTTP or HTTPS requests submitted via HTTP GET or POST with a query parameter
    /// named Action.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: cloudsearch.<i>region</i>.amazonaws.com.
    /// For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported
    /// regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region">Regions
    /// and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudSearch : IDisposable
    {

        
        #region  CreateDomain

        /// <summary>
        /// Creates a new search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DefineIndexField

        /// <summary>
        /// Configures an <code>IndexField</code> for the search domain. Used to create new fields
        /// and modify existing ones. If the field exists, the new configuration replaces the
        /// old one. You can configure a maximum of 200 index fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField service method.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DefineIndexFieldResponse> DefineIndexFieldAsync(DefineIndexFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DefineRankExpression

        /// <summary>
        /// Configures a <code>RankExpression</code> for the search domain. Used to create new
        /// rank expressions and modify existing ones. If the expression exists, the new configuration
        /// replaces the old one. You can configure a maximum of 50 rank expressions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression service method.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DefineRankExpressionResponse DefineRankExpression(DefineRankExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineRankExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DefineRankExpressionResponse> DefineRankExpressionAsync(DefineRankExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Permanently deletes a search domain and all of its data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIndexField

        /// <summary>
        /// Removes an <code>IndexField</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField service method.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIndexFieldResponse> DeleteIndexFieldAsync(DeleteIndexFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRankExpression

        /// <summary>
        /// Removes a <code>RankExpression</code> from the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression service method.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DeleteRankExpressionResponse DeleteRankExpression(DeleteRankExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRankExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRankExpressionResponse> DeleteRankExpressionAsync(DeleteRankExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAvailabilityOptions

        /// <summary>
        /// Gets the availability options configured for a domain. By default, shows the configuration
        /// with any pending changes. Set the <code>Deployed</code> option to <code>true</code>
        /// to show the active configuration and exclude pending changes. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAvailabilityOptionsResponse> DescribeAvailabilityOptionsAsync(DescribeAvailabilityOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDefaultSearchField

        /// <summary>
        /// Gets the default search field configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeDefaultSearchFieldResponse DescribeDefaultSearchField(DescribeDefaultSearchFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultSearchField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDefaultSearchFieldResponse> DescribeDefaultSearchFieldAsync(DescribeDefaultSearchFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDomains

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        DescribeDomainsResponse DescribeDomains();

        /// <summary>
        /// Gets information about the search domains owned by this account. Can be limited to
        /// specific domains. Shows all domains by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIndexFields

        /// <summary>
        /// Gets information about the index fields configured for the search domain. Can be limited
        /// to specific fields by name. Shows all fields by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields service method.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeIndexFieldsResponse> DescribeIndexFieldsAsync(DescribeIndexFieldsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRankExpressions

        /// <summary>
        /// Gets the rank expressions configured for the search domain. Can be limited to specific
        /// rank expressions by name. Shows all rank expressions by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions service method.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeRankExpressionsResponse DescribeRankExpressions(DescribeRankExpressionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRankExpressions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRankExpressionsResponse> DescribeRankExpressionsAsync(DescribeRankExpressionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServiceAccessPolicies

        /// <summary>
        /// Gets information about the resource-based policies that control access to the domain's
        /// document and search services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeServiceAccessPoliciesResponse> DescribeServiceAccessPoliciesAsync(DescribeServiceAccessPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStemmingOptions

        /// <summary>
        /// Gets the stemming dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeStemmingOptionsResponse DescribeStemmingOptions(DescribeStemmingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStemmingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStemmingOptionsResponse> DescribeStemmingOptionsAsync(DescribeStemmingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStopwordOptions

        /// <summary>
        /// Gets the stopwords configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeStopwordOptionsResponse DescribeStopwordOptions(DescribeStopwordOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStopwordOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStopwordOptionsResponse> DescribeStopwordOptionsAsync(DescribeStopwordOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSynonymOptions

        /// <summary>
        /// Gets the synonym dictionary configured for the search domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        DescribeSynonymOptionsResponse DescribeSynonymOptions(DescribeSynonymOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSynonymOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSynonymOptionsResponse> DescribeSynonymOptionsAsync(DescribeSynonymOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IndexDocuments

        /// <summary>
        /// Tells the search domain to start indexing its documents using the latest text processing
        /// options and <code>IndexFields</code>. This operation must be invoked to make options
        /// whose <a>OptionStatus</a> has <code>OptionState</code> of <code>RequiresIndexDocuments</code>
        /// visible in search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments service method.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<IndexDocumentsResponse> IndexDocumentsAsync(IndexDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAvailabilityOptions

        /// <summary>
        /// Configures the availability options for a domain. Enabling the Multi-AZ option expands
        /// an Amazon CloudSearch domain to an additional Availability Zone in the same Region
        /// to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ
        /// option can take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
        /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.DisabledOperationException">
        /// The request was rejected because it attempted an operation which is not enabled.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAvailabilityOptionsResponse> UpdateAvailabilityOptionsAsync(UpdateAvailabilityOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDefaultSearchField

        /// <summary>
        /// Configures the default search field for the search domain. The default search field
        /// is the text field that is searched when a search request does not specify which fields
        /// to search. By default, it is configured to include the contents of all of the domain's
        /// text fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateDefaultSearchFieldResponse UpdateDefaultSearchField(UpdateDefaultSearchFieldRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultSearchField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDefaultSearchFieldResponse> UpdateDefaultSearchFieldAsync(UpdateDefaultSearchFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceAccessPolicies

        /// <summary>
        /// Configures the policies that control access to the domain's document and search services.
        /// The maximum size of an access policy document is 100 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateServiceAccessPoliciesResponse> UpdateServiceAccessPoliciesAsync(UpdateServiceAccessPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStemmingOptions

        /// <summary>
        /// Configures a stemming dictionary for the search domain. The stemming dictionary is
        /// used during indexing and when processing search requests. The maximum size of the
        /// stemming dictionary is 500 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateStemmingOptionsResponse UpdateStemmingOptions(UpdateStemmingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStemmingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateStemmingOptionsResponse> UpdateStemmingOptionsAsync(UpdateStemmingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStopwordOptions

        /// <summary>
        /// Configures stopwords for the search domain. Stopwords are used during indexing and
        /// when processing search requests. The maximum size of the stopwords dictionary is 10
        /// KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateStopwordOptionsResponse UpdateStopwordOptions(UpdateStopwordOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStopwordOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateStopwordOptionsResponse> UpdateStopwordOptionsAsync(UpdateStopwordOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSynonymOptions

        /// <summary>
        /// Configures a synonym dictionary for the search domain. The synonym dictionary is used
        /// during indexing to configure mappings for terms that occur in text fields. The maximum
        /// size of the synonym dictionary is 100 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by CloudSearch.</returns>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InternalException">
        /// An internal error occurred while processing the request. If this problem persists,
        /// report an issue from the <a href="http://status.aws.amazon.com/">Service Health Dashboard</a>.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.InvalidTypeException">
        /// The request was rejected because it specified an invalid type definition.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.LimitExceededException">
        /// The request was rejected because a resource limit has already been met.
        /// </exception>
        /// <exception cref="Amazon.CloudSearch_2011_02_01.Model.ResourceNotFoundException">
        /// The request was rejected because it attempted to reference a resource that does not
        /// exist.
        /// </exception>
        UpdateSynonymOptionsResponse UpdateSynonymOptions(UpdateSynonymOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSynonymOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateSynonymOptionsResponse> UpdateSynonymOptionsAsync(UpdateSynonymOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
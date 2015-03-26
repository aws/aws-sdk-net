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
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from CloudSearch.</returns>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DefineIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineIndexField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a  DefineIndexFieldResult from CloudSearch.</returns>
        DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DefineRankExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineRankExpression
        ///         operation.</returns>
        IAsyncResult BeginDefineRankExpression(DefineRankExpressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DefineRankExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineRankExpression.</param>
        /// 
        /// <returns>Returns a  DefineRankExpressionResult from CloudSearch.</returns>
        DefineRankExpressionResponse EndDefineRankExpression(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from CloudSearch.</returns>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndexField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a  DeleteIndexFieldResult from CloudSearch.</returns>
        DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteRankExpression operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRankExpression
        ///         operation.</returns>
        IAsyncResult BeginDeleteRankExpression(DeleteRankExpressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRankExpression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRankExpression.</param>
        /// 
        /// <returns>Returns a  DeleteRankExpressionResult from CloudSearch.</returns>
        DeleteRankExpressionResponse EndDeleteRankExpression(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityOptionsResult from CloudSearch.</returns>
        DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultSearchField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultSearchField
        ///         operation.</returns>
        IAsyncResult BeginDescribeDefaultSearchField(DescribeDefaultSearchFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultSearchField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultSearchField.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultSearchFieldResult from CloudSearch.</returns>
        DescribeDefaultSearchFieldResponse EndDescribeDefaultSearchField(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        IAsyncResult BeginDescribeDomains(DescribeDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a  DescribeDomainsResult from CloudSearch.</returns>
        DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexFields operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndexFields
        ///         operation.</returns>
        IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndexFields operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a  DescribeIndexFieldsResult from CloudSearch.</returns>
        DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRankExpressions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRankExpressions
        ///         operation.</returns>
        IAsyncResult BeginDescribeRankExpressions(DescribeRankExpressionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRankExpressions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRankExpressions.</param>
        /// 
        /// <returns>Returns a  DescribeRankExpressionsResult from CloudSearch.</returns>
        DescribeRankExpressionsResponse EndDescribeRankExpressions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceAccessPolicies
        ///         operation.</returns>
        IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeServiceAccessPoliciesResult from CloudSearch.</returns>
        DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStemmingOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStemmingOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeStemmingOptions(DescribeStemmingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStemmingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStemmingOptions.</param>
        /// 
        /// <returns>Returns a  DescribeStemmingOptionsResult from CloudSearch.</returns>
        DescribeStemmingOptionsResponse EndDescribeStemmingOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStopwordOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStopwordOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeStopwordOptions(DescribeStopwordOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStopwordOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStopwordOptions.</param>
        /// 
        /// <returns>Returns a  DescribeStopwordOptionsResult from CloudSearch.</returns>
        DescribeStopwordOptionsResponse EndDescribeStopwordOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSynonymOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSynonymOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeSynonymOptions(DescribeSynonymOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSynonymOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSynonymOptions.</param>
        /// 
        /// <returns>Returns a  DescribeSynonymOptionsResult from CloudSearch.</returns>
        DescribeSynonymOptionsResponse EndDescribeSynonymOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the IndexDocuments operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        IAsyncResult BeginIndexDocuments(IndexDocumentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IndexDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a  IndexDocumentsResult from CloudSearch.</returns>
        IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityOptions
        ///         operation.</returns>
        IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityOptionsResult from CloudSearch.</returns>
        UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultSearchField operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultSearchField
        ///         operation.</returns>
        IAsyncResult BeginUpdateDefaultSearchField(UpdateDefaultSearchFieldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultSearchField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultSearchField.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultSearchFieldResult from CloudSearch.</returns>
        UpdateDefaultSearchFieldResponse EndUpdateDefaultSearchField(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceAccessPolicies
        ///         operation.</returns>
        IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a  UpdateServiceAccessPoliciesResult from CloudSearch.</returns>
        UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStemmingOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStemmingOptions
        ///         operation.</returns>
        IAsyncResult BeginUpdateStemmingOptions(UpdateStemmingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStemmingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStemmingOptions.</param>
        /// 
        /// <returns>Returns a  UpdateStemmingOptionsResult from CloudSearch.</returns>
        UpdateStemmingOptionsResponse EndUpdateStemmingOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStopwordOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStopwordOptions
        ///         operation.</returns>
        IAsyncResult BeginUpdateStopwordOptions(UpdateStopwordOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStopwordOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStopwordOptions.</param>
        /// 
        /// <returns>Returns a  UpdateStopwordOptionsResult from CloudSearch.</returns>
        UpdateStopwordOptionsResponse EndUpdateStopwordOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateSynonymOptions operation on AmazonCloudSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSynonymOptions
        ///         operation.</returns>
        IAsyncResult BeginUpdateSynonymOptions(UpdateSynonymOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSynonymOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSynonymOptions.</param>
        /// 
        /// <returns>Returns a  UpdateSynonymOptionsResult from CloudSearch.</returns>
        UpdateSynonymOptionsResponse EndUpdateSynonymOptions(IAsyncResult asyncResult);

        #endregion
        
    }
}
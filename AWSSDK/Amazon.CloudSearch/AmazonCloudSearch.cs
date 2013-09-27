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

using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;

namespace Amazon.CloudSearch
{
    /// <summary>
    /// Interface for accessing AmazonCloudSearch.
    ///  
    ///  Amazon CloudSearch Configuration Service <para>You use the configuration service to create, configure, and manage search domains.
    /// Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted via HTTP
    /// GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
    /// cloudsearch. <i>region</i> .amazonaws.com. For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see Regions and Endpoints.</para>
    /// </summary>
    public interface AmazonCloudSearch : IDisposable
    {
        

        #region UpdateDefaultSearchField

        /// <summary>
        /// <para>Configures the default search field for the search domain. The default search field is the text field that is searched when a search
        /// request does not specify which fields to search. By default, it is configured to include the contents of all of the domain's text fields.
        /// </para>
        /// </summary>
        /// 
        /// <param name="updateDefaultSearchFieldRequest">Container for the necessary parameters to execute the UpdateDefaultSearchField service method
        ///          on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        UpdateDefaultSearchFieldResponse UpdateDefaultSearchField(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="updateDefaultSearchFieldRequest">Container for the necessary parameters to execute the UpdateDefaultSearchField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateDefaultSearchField operation.</returns>
        IAsyncResult BeginUpdateDefaultSearchField(UpdateDefaultSearchFieldRequest updateDefaultSearchFieldRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultSearchField.</param>
        /// 
        /// <returns>Returns a UpdateDefaultSearchFieldResult from AmazonCloudSearch.</returns>
        UpdateDefaultSearchFieldResponse EndUpdateDefaultSearchField(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteRankExpression

        /// <summary>
        /// <para>Removes a <c>RankExpression</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteRankExpressionRequest">Container for the necessary parameters to execute the DeleteRankExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        DeleteRankExpressionResponse DeleteRankExpression(DeleteRankExpressionRequest deleteRankExpressionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteRankExpression"/>
        /// </summary>
        /// 
        /// <param name="deleteRankExpressionRequest">Container for the necessary parameters to execute the DeleteRankExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteRankExpression operation.</returns>
        IAsyncResult BeginDeleteRankExpression(DeleteRankExpressionRequest deleteRankExpressionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteRankExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRankExpression.</param>
        /// 
        /// <returns>Returns a DeleteRankExpressionResult from AmazonCloudSearch.</returns>
        DeleteRankExpressionResponse EndDeleteRankExpression(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeRankExpressions

        /// <summary>
        /// <para>Gets the rank expressions configured for the search domain. Can be limited to specific rank expressions by name. Shows all rank
        /// expressions by default. </para>
        /// </summary>
        /// 
        /// <param name="describeRankExpressionsRequest">Container for the necessary parameters to execute the DescribeRankExpressions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeRankExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeRankExpressionsResponse DescribeRankExpressions(DescribeRankExpressionsRequest describeRankExpressionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeRankExpressions"/>
        /// </summary>
        /// 
        /// <param name="describeRankExpressionsRequest">Container for the necessary parameters to execute the DescribeRankExpressions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeRankExpressions operation.</returns>
        IAsyncResult BeginDescribeRankExpressions(DescribeRankExpressionsRequest describeRankExpressionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRankExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeRankExpressions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRankExpressions.</param>
        /// 
        /// <returns>Returns a DescribeRankExpressionsResult from AmazonCloudSearch.</returns>
        DescribeRankExpressionsResponse EndDescribeRankExpressions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateDomain

        /// <summary>
        /// <para>Creates a new search domain.</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        IAsyncResult BeginCreateDomain(CreateDomainRequest createDomainRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a CreateDomainResult from AmazonCloudSearch.</returns>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateServiceAccessPolicies

        /// <summary>
        /// <para>Configures the policies that control access to the domain's document and search services. The maximum size of an access policy
        /// document is 100 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateServiceAccessPolicies operation.</returns>
        IAsyncResult BeginUpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a UpdateServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineIndexField

        /// <summary>
        /// <para>Configures an <c>IndexField</c> for the search domain. Used to create new fields and modify existing ones. If the field exists, the
        /// new configuration replaces the old one. You can configure a maximum of 200 index fields.</para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineIndexField
        ///         operation.</returns>
        IAsyncResult BeginDefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a DefineIndexFieldResult from AmazonCloudSearch.</returns>
        DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineRankExpression

        /// <summary>
        /// <para>Configures a <c>RankExpression</c> for the search domain. Used to create new rank expressions and modify existing ones. If the
        /// expression exists, the new configuration replaces the old one. You can configure a maximum of 50 rank expressions.</para>
        /// </summary>
        /// 
        /// <param name="defineRankExpressionRequest">Container for the necessary parameters to execute the DefineRankExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineRankExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        DefineRankExpressionResponse DefineRankExpression(DefineRankExpressionRequest defineRankExpressionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DefineRankExpression"/>
        /// </summary>
        /// 
        /// <param name="defineRankExpressionRequest">Container for the necessary parameters to execute the DefineRankExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDefineRankExpression operation.</returns>
        IAsyncResult BeginDefineRankExpression(DefineRankExpressionRequest defineRankExpressionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DefineRankExpression operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DefineRankExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineRankExpression.</param>
        /// 
        /// <returns>Returns a DefineRankExpressionResult from AmazonCloudSearch.</returns>
        DefineRankExpressionResponse EndDefineRankExpression(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeSynonymOptions

        /// <summary>
        /// <para>Gets the synonym dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeSynonymOptionsRequest">Container for the necessary parameters to execute the DescribeSynonymOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeSynonymOptionsResponse DescribeSynonymOptions(DescribeSynonymOptionsRequest describeSynonymOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="describeSynonymOptionsRequest">Container for the necessary parameters to execute the DescribeSynonymOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSynonymOptions operation.</returns>
        IAsyncResult BeginDescribeSynonymOptions(DescribeSynonymOptionsRequest describeSynonymOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSynonymOptions.</param>
        /// 
        /// <returns>Returns a DescribeSynonymOptionsResult from AmazonCloudSearch.</returns>
        DescribeSynonymOptionsResponse EndDescribeSynonymOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeStopwordOptions

        /// <summary>
        /// <para>Gets the stopwords configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStopwordOptionsRequest">Container for the necessary parameters to execute the DescribeStopwordOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeStopwordOptionsResponse DescribeStopwordOptions(DescribeStopwordOptionsRequest describeStopwordOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="describeStopwordOptionsRequest">Container for the necessary parameters to execute the DescribeStopwordOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStopwordOptions operation.</returns>
        IAsyncResult BeginDescribeStopwordOptions(DescribeStopwordOptionsRequest describeStopwordOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStopwordOptions.</param>
        /// 
        /// <returns>Returns a DescribeStopwordOptionsResult from AmazonCloudSearch.</returns>
        DescribeStopwordOptionsResponse EndDescribeStopwordOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteDomain

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data.</para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest deleteDomainRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a DeleteDomainResult from AmazonCloudSearch.</returns>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeServiceAccessPolicies

        /// <summary>
        /// <para>Gets information about the resource-based policies that control access to the domain's document and search services.</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          operation on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeServiceAccessPolicies operation.</returns>
        IAsyncResult BeginDescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a DescribeServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeDefaultSearchField

        /// <summary>
        /// <para>Gets the default search field configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeDefaultSearchFieldRequest">Container for the necessary parameters to execute the DescribeDefaultSearchField service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDefaultSearchField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeDefaultSearchFieldResponse DescribeDefaultSearchField(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="describeDefaultSearchFieldRequest">Container for the necessary parameters to execute the DescribeDefaultSearchField operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDefaultSearchField operation.</returns>
        IAsyncResult BeginDescribeDefaultSearchField(DescribeDefaultSearchFieldRequest describeDefaultSearchFieldRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDefaultSearchField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeDefaultSearchField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultSearchField.</param>
        /// 
        /// <returns>Returns a DescribeDefaultSearchFieldResult from AmazonCloudSearch.</returns>
        DescribeDefaultSearchFieldResponse EndDescribeDefaultSearchField(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateStopwordOptions

        /// <summary>
        /// <para>Configures stopwords for the search domain. Stopwords are used during indexing and when processing search requests. The maximum size
        /// of the stopwords dictionary is 10 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStopwordOptionsRequest">Container for the necessary parameters to execute the UpdateStopwordOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStopwordOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        UpdateStopwordOptionsResponse UpdateStopwordOptions(UpdateStopwordOptionsRequest updateStopwordOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="updateStopwordOptionsRequest">Container for the necessary parameters to execute the UpdateStopwordOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStopwordOptions operation.</returns>
        IAsyncResult BeginUpdateStopwordOptions(UpdateStopwordOptionsRequest updateStopwordOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStopwordOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStopwordOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStopwordOptions.</param>
        /// 
        /// <returns>Returns a UpdateStopwordOptionsResult from AmazonCloudSearch.</returns>
        UpdateStopwordOptionsResponse EndUpdateStopwordOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateSynonymOptions

        /// <summary>
        /// <para>Configures a synonym dictionary for the search domain. The synonym dictionary is used during indexing to configure mappings for terms
        /// that occur in text fields. The maximum size of the synonym dictionary is 100 KB. </para>
        /// </summary>
        /// 
        /// <param name="updateSynonymOptionsRequest">Container for the necessary parameters to execute the UpdateSynonymOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateSynonymOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        UpdateSynonymOptionsResponse UpdateSynonymOptions(UpdateSynonymOptionsRequest updateSynonymOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="updateSynonymOptionsRequest">Container for the necessary parameters to execute the UpdateSynonymOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateSynonymOptions operation.</returns>
        IAsyncResult BeginUpdateSynonymOptions(UpdateSynonymOptionsRequest updateSynonymOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSynonymOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateSynonymOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSynonymOptions.</param>
        /// 
        /// <returns>Returns a UpdateSynonymOptionsResult from AmazonCloudSearch.</returns>
        UpdateSynonymOptionsResponse EndUpdateSynonymOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateStemmingOptions

        /// <summary>
        /// <para>Configures a stemming dictionary for the search domain. The stemming dictionary is used during indexing and when processing search
        /// requests. The maximum size of the stemming dictionary is 500 KB.</para>
        /// </summary>
        /// 
        /// <param name="updateStemmingOptionsRequest">Container for the necessary parameters to execute the UpdateStemmingOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        UpdateStemmingOptionsResponse UpdateStemmingOptions(UpdateStemmingOptionsRequest updateStemmingOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="updateStemmingOptionsRequest">Container for the necessary parameters to execute the UpdateStemmingOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateStemmingOptions operation.</returns>
        IAsyncResult BeginUpdateStemmingOptions(UpdateStemmingOptionsRequest updateStemmingOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStemmingOptions.</param>
        /// 
        /// <returns>Returns a UpdateStemmingOptionsResult from AmazonCloudSearch.</returns>
        UpdateStemmingOptionsResponse EndUpdateStemmingOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeStemmingOptions

        /// <summary>
        /// <para>Gets the stemming dictionary configured for the search domain.</para>
        /// </summary>
        /// 
        /// <param name="describeStemmingOptionsRequest">Container for the necessary parameters to execute the DescribeStemmingOptions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeStemmingOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeStemmingOptionsResponse DescribeStemmingOptions(DescribeStemmingOptionsRequest describeStemmingOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="describeStemmingOptionsRequest">Container for the necessary parameters to execute the DescribeStemmingOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStemmingOptions operation.</returns>
        IAsyncResult BeginDescribeStemmingOptions(DescribeStemmingOptionsRequest describeStemmingOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStemmingOptions operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeStemmingOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStemmingOptions.</param>
        /// 
        /// <returns>Returns a DescribeStemmingOptionsResult from AmazonCloudSearch.</returns>
        DescribeStemmingOptionsResponse EndDescribeStemmingOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeDomains

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
        DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest describeDomainsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        IAsyncResult BeginDescribeDomains(DescribeDomainsRequest describeDomainsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a DescribeDomainsResult from AmazonCloudSearch.</returns>
        DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by
        /// default.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="InternalException"/>
        DescribeDomainsResponse DescribeDomains();
        
        #endregion
        
    

        #region IndexDocuments

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest text processing options and <c>IndexFields</c> . This
        /// operation must be invoked to make options whose OptionStatus has <c>OptionState</c> of <c>RequiresIndexDocuments</c> visible in search
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest indexDocumentsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIndexDocuments
        ///         operation.</returns>
        IAsyncResult BeginIndexDocuments(IndexDocumentsRequest indexDocumentsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a IndexDocumentsResult from AmazonCloudSearch.</returns>
        IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeIndexFields

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. Shows all fields
        /// by default.</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeIndexFields operation.</returns>
        IAsyncResult BeginDescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a DescribeIndexFieldsResult from AmazonCloudSearch.</returns>
        DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteIndexField

        /// <summary>
        /// <para>Removes an <c>IndexField</c> from the search domain.</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndexField
        ///         operation.</returns>
        IAsyncResult BeginDeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a DeleteIndexFieldResult from AmazonCloudSearch.</returns>
        DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    

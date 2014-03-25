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
using System;

using Amazon.CloudSearch;
using Amazon.CloudSearch.Model;

namespace Amazon.CloudSearch
{
    /// <summary>
    /// Interface for accessing AmazonCloudSearch.
    ///  
    ///  Amazon CloudSearch Configuration Service <para>You use the Amazon CloudSearch configuration service to create, configure, and manage search
    /// domains. Configuration service requests are submitted using the AWS Query protocol. AWS Query requests are HTTP or HTTPS requests submitted
    /// via HTTP GET or POST with a query parameter named Action.</para> <para>The endpoint for configuration service requests is region-specific:
    /// cloudsearch. <i>region</i> .amazonaws.com. For example, cloudsearch.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#cloudsearch_region" >Regions and Endpoints</a> .</para>
    /// </summary>
    public partial interface IAmazonCloudSearch : IDisposable
    {


        #region BuildSuggesters

        /// <summary>
        /// <para>Indexes the search suggestions. </para>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the BuildSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        BuildSuggestersResponse BuildSuggesters(BuildSuggestersRequest buildSuggestersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.BuildSuggesters"/>
        /// </summary>
        /// 
        /// <param name="buildSuggestersRequest">Container for the necessary parameters to execute the BuildSuggesters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBuildSuggesters
        ///         operation.</returns>
        IAsyncResult BeginBuildSuggesters(BuildSuggestersRequest buildSuggestersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BuildSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.BuildSuggesters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBuildSuggesters.</param>
        /// 
        /// <returns>Returns a BuildSuggestersResult from AmazonCloudSearch.</returns>
        BuildSuggestersResponse EndBuildSuggesters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateDomain

        /// <summary>
        /// <para>Creates a new search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/creating-domains.html" >Creating a Search Domain</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDomainRequest">Container for the necessary parameters to execute the CreateDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.CreateDomain"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.CreateDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a CreateDomainResult from AmazonCloudSearch.</returns>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineAnalysisScheme

        /// <summary>
        /// <para>Configures an analysis scheme for a domain. An analysis scheme defines language-specific text processing options for a <c>text</c>
        /// field. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        DefineAnalysisSchemeResponse DefineAnalysisScheme(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="defineAnalysisSchemeRequest">Container for the necessary parameters to execute the DefineAnalysisScheme operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDefineAnalysisScheme operation.</returns>
        IAsyncResult BeginDefineAnalysisScheme(DefineAnalysisSchemeRequest defineAnalysisSchemeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DefineAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineAnalysisScheme.</param>
        /// 
        /// <returns>Returns a DefineAnalysisSchemeResult from AmazonCloudSearch.</returns>
        DefineAnalysisSchemeResponse EndDefineAnalysisScheme(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineExpression

        /// <summary>
        /// <para>Configures an <c> Expression </c> for the search domain. Used to create new expressions and modify existing ones. If the expression
        /// exists, the new configuration replaces the old one. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        DefineExpressionResponse DefineExpression(DefineExpressionRequest defineExpressionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineExpression"/>
        /// </summary>
        /// 
        /// <param name="defineExpressionRequest">Container for the necessary parameters to execute the DefineExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineExpression
        ///         operation.</returns>
        IAsyncResult BeginDefineExpression(DefineExpressionRequest defineExpressionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DefineExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineExpression.</param>
        /// 
        /// <returns>Returns a DefineExpressionResult from AmazonCloudSearch.</returns>
        DefineExpressionResponse EndDefineExpression(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineIndexField

        /// <summary>
        /// <para>Configures an <c> IndexField </c> for the search domain. Used to create new fields and modify existing ones. You must specify the name
        /// of the domain you are configuring and an index field configuration. The index field configuration specifies a unique name, the index field
        /// type, and the options you want to configure for the field. The options you can specify depend on the <c> IndexFieldType </c> . If the field
        /// exists, the new configuration replaces the old one. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" >Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="defineIndexFieldRequest">Container for the necessary parameters to execute the DefineIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        DefineIndexFieldResponse DefineIndexField(DefineIndexFieldRequest defineIndexFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineIndexField"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineIndexField.</param>
        /// 
        /// <returns>Returns a DefineIndexFieldResult from AmazonCloudSearch.</returns>
        DefineIndexFieldResponse EndDefineIndexField(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DefineSuggester

        /// <summary>
        /// <para>Configures a suggester for a domain. A suggester enables you to display possible matches before users finish typing their queries.
        /// When you configure a suggester, you must specify the name of the text field you want to search for possible matches and a unique name for
        /// the suggester. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DefineSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        DefineSuggesterResponse DefineSuggester(DefineSuggesterRequest defineSuggesterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineSuggester"/>
        /// </summary>
        /// 
        /// <param name="defineSuggesterRequest">Container for the necessary parameters to execute the DefineSuggester operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDefineSuggester
        ///         operation.</returns>
        IAsyncResult BeginDefineSuggester(DefineSuggesterRequest defineSuggesterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DefineSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DefineSuggester"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDefineSuggester.</param>
        /// 
        /// <returns>Returns a DefineSuggesterResult from AmazonCloudSearch.</returns>
        DefineSuggesterResponse EndDefineSuggester(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAnalysisScheme

        /// <summary>
        /// <para>Deletes an analysis scheme. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html.html" >Configuring Analysis Schemes</a>
        /// in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteAnalysisScheme service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DeleteAnalysisSchemeResponse DeleteAnalysisScheme(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="deleteAnalysisSchemeRequest">Container for the necessary parameters to execute the DeleteAnalysisScheme operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteAnalysisScheme operation.</returns>
        IAsyncResult BeginDeleteAnalysisScheme(DeleteAnalysisSchemeRequest deleteAnalysisSchemeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAnalysisScheme operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteAnalysisScheme"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnalysisScheme.</param>
        /// 
        /// <returns>Returns a DeleteAnalysisSchemeResult from AmazonCloudSearch.</returns>
        DeleteAnalysisSchemeResponse EndDeleteAnalysisScheme(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteDomain

        /// <summary>
        /// <para>Permanently deletes a search domain and all of its data. Once a domain has been deleted, it cannot be recovered. For more information,
        /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/deleting-domains.html" >Deleting a Search Domain</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="deleteDomainRequest">Container for the necessary parameters to execute the DeleteDomain service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteDomain"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a DeleteDomainResult from AmazonCloudSearch.</returns>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteExpression

        /// <summary>
        /// <para>Removes an <c> Expression </c> from the search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteExpression service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DeleteExpressionResponse DeleteExpression(DeleteExpressionRequest deleteExpressionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteExpression"/>
        /// </summary>
        /// 
        /// <param name="deleteExpressionRequest">Container for the necessary parameters to execute the DeleteExpression operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExpression
        ///         operation.</returns>
        IAsyncResult BeginDeleteExpression(DeleteExpressionRequest deleteExpressionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteExpression operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteExpression"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExpression.</param>
        /// 
        /// <returns>Returns a DeleteExpressionResult from AmazonCloudSearch.</returns>
        DeleteExpressionResponse EndDeleteExpression(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteIndexField

        /// <summary>
        /// <para>Removes an <c> IndexField </c> from the search domain. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html" >Configuring Index Fields</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteIndexFieldRequest">Container for the necessary parameters to execute the DeleteIndexField service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteIndexField service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DeleteIndexFieldResponse DeleteIndexField(DeleteIndexFieldRequest deleteIndexFieldRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndexField operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteIndexField"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteIndexField"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndexField.</param>
        /// 
        /// <returns>Returns a DeleteIndexFieldResult from AmazonCloudSearch.</returns>
        DeleteIndexFieldResponse EndDeleteIndexField(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSuggester

        /// <summary>
        /// <para>Deletes a suggester. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search Suggestions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DeleteSuggester service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DeleteSuggesterResponse DeleteSuggester(DeleteSuggesterRequest deleteSuggesterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteSuggester"/>
        /// </summary>
        /// 
        /// <param name="deleteSuggesterRequest">Container for the necessary parameters to execute the DeleteSuggester operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSuggester
        ///         operation.</returns>
        IAsyncResult BeginDeleteSuggester(DeleteSuggesterRequest deleteSuggesterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSuggester operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DeleteSuggester"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSuggester.</param>
        /// 
        /// <returns>Returns a DeleteSuggesterResult from AmazonCloudSearch.</returns>
        DeleteSuggesterResponse EndDeleteSuggester(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAnalysisSchemes

        /// <summary>
        /// <para>Gets the analysis schemes configured for a domain. An analysis scheme defines language-specific text processing options for a
        /// <c>text</c> field. Can be limited to specific analysis schemes by name. By default, shows all analysis schemes and includes any pending
        /// changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes.
        /// For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-analysis-schemes.html"
        /// >Configuring Analysis Schemes</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAnalysisSchemes service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeAnalysisSchemesResponse DescribeAnalysisSchemes(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAnalysisSchemes"/>
        /// </summary>
        /// 
        /// <param name="describeAnalysisSchemesRequest">Container for the necessary parameters to execute the DescribeAnalysisSchemes operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAnalysisSchemes operation.</returns>
        IAsyncResult BeginDescribeAnalysisSchemes(DescribeAnalysisSchemesRequest describeAnalysisSchemesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAnalysisSchemes operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAnalysisSchemes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnalysisSchemes.</param>
        /// 
        /// <returns>Returns a DescribeAnalysisSchemesResult from AmazonCloudSearch.</returns>
        DescribeAnalysisSchemesResponse EndDescribeAnalysisSchemes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAvailabilityOptions

        /// <summary>
        /// <para>Gets the availability options configured for a domain. By default, shows the configuration with any pending changes. Set the
        /// <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html" >Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="DisabledOperationException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        DescribeAvailabilityOptionsResponse DescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityOptionsRequest">Container for the necessary parameters to execute the DescribeAvailabilityOptions operation
        ///          on AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAvailabilityOptions operation.</returns>
        IAsyncResult BeginDescribeAvailabilityOptions(DescribeAvailabilityOptionsRequest describeAvailabilityOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a DescribeAvailabilityOptionsResult from AmazonCloudSearch.</returns>
        DescribeAvailabilityOptionsResponse EndDescribeAvailabilityOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeDomains

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDomainsRequest">Container for the necessary parameters to execute the DescribeDomains service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest describeDomainsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDomains"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeDomains"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a DescribeDomainsResult from AmazonCloudSearch.</returns>
        DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Gets information about the search domains owned by this account. Can be limited to specific domains. Shows all domains by default. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Information about
        /// a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="BaseException"/>
        DescribeDomainsResponse DescribeDomains();
        
        #endregion
        
    

        #region DescribeExpressions

        /// <summary>
        /// <para>Gets the expressions configured for the search domain. Can be limited to specific expressions by name. By default, shows all
        /// expressions and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-expressions.html" >Configuring Expressions</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeExpressions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeExpressionsResponse DescribeExpressions(DescribeExpressionsRequest describeExpressionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeExpressions"/>
        /// </summary>
        /// 
        /// <param name="describeExpressionsRequest">Container for the necessary parameters to execute the DescribeExpressions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeExpressions operation.</returns>
        IAsyncResult BeginDescribeExpressions(DescribeExpressionsRequest describeExpressionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeExpressions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeExpressions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExpressions.</param>
        /// 
        /// <returns>Returns a DescribeExpressionsResult from AmazonCloudSearch.</returns>
        DescribeExpressionsResponse EndDescribeExpressions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeIndexFields

        /// <summary>
        /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. By default,
        /// shows all fields and includes any pending changes to the configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active
        /// configuration and exclude pending changes. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getdomainstatus.html" >Getting Domain Information</a> in the <i>Amazon
        /// CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeIndexFieldsRequest">Container for the necessary parameters to execute the DescribeIndexFields service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeIndexFields service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeIndexFieldsResponse DescribeIndexFields(DescribeIndexFieldsRequest describeIndexFieldsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndexFields operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeIndexFields"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeIndexFields"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndexFields.</param>
        /// 
        /// <returns>Returns a DescribeIndexFieldsResult from AmazonCloudSearch.</returns>
        DescribeIndexFieldsResponse EndDescribeIndexFields(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeScalingParameters

        /// <summary>
        /// <para>Gets the scaling parameters configured for a domain. A domain's scaling parameters specify the desired search instance type and
        /// replication count. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html" >Configuring Scaling Options</a> in the
        /// <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeScalingParametersResponse DescribeScalingParameters(DescribeScalingParametersRequest describeScalingParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="describeScalingParametersRequest">Container for the necessary parameters to execute the DescribeScalingParameters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingParameters operation.</returns>
        IAsyncResult BeginDescribeScalingParameters(DescribeScalingParametersRequest describeScalingParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingParameters.</param>
        /// 
        /// <returns>Returns a DescribeScalingParametersResult from AmazonCloudSearch.</returns>
        DescribeScalingParametersResponse EndDescribeScalingParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeServiceAccessPolicies

        /// <summary>
        /// <para>Gets information about the access policies that control access to the domain's document and search endpoints. By default, shows the
        /// configuration with any pending changes. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending
        /// changes. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html"
        /// >Configuring Access for a Search Domain</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeServiceAccessPoliciesRequest">Container for the necessary parameters to execute the DescribeServiceAccessPolicies
        ///          service method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeServiceAccessPoliciesResponse DescribeServiceAccessPolicies(DescribeServiceAccessPoliciesRequest describeServiceAccessPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeServiceAccessPolicies"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a DescribeServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        DescribeServiceAccessPoliciesResponse EndDescribeServiceAccessPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeSuggesters

        /// <summary>
        /// <para>Gets the suggesters configured for a domain. A suggester enables you to display possible matches before users finish typing their
        /// queries. Can be limited to specific suggesters by name. By default, shows all suggesters and includes any pending changes to the
        /// configuration. Set the <c>Deployed</c> option to <c>true</c> to show the active configuration and exclude pending changes. For more
        /// information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/getting-search-suggestions.html" >Getting Search
        /// Suggestions</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the DescribeSuggesters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        DescribeSuggestersResponse DescribeSuggesters(DescribeSuggestersRequest describeSuggestersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSuggesters"/>
        /// </summary>
        /// 
        /// <param name="describeSuggestersRequest">Container for the necessary parameters to execute the DescribeSuggesters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSuggesters operation.</returns>
        IAsyncResult BeginDescribeSuggesters(DescribeSuggestersRequest describeSuggestersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSuggesters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.DescribeSuggesters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSuggesters.</param>
        /// 
        /// <returns>Returns a DescribeSuggestersResult from AmazonCloudSearch.</returns>
        DescribeSuggestersResponse EndDescribeSuggesters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region IndexDocuments

        /// <summary>
        /// <para>Tells the search domain to start indexing its documents using the latest indexing options. This operation must be invoked to activate
        /// options whose OptionStatus is <c>RequiresIndexDocuments</c> .</para>
        /// </summary>
        /// 
        /// <param name="indexDocumentsRequest">Container for the necessary parameters to execute the IndexDocuments service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the IndexDocuments service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="BaseException"/>
        IndexDocumentsResponse IndexDocuments(IndexDocumentsRequest indexDocumentsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the IndexDocuments operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.IndexDocuments"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.IndexDocuments"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIndexDocuments.</param>
        /// 
        /// <returns>Returns a IndexDocumentsResult from AmazonCloudSearch.</returns>
        IndexDocumentsResponse EndIndexDocuments(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListDomainNames

        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest listDomainNamesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.ListDomainNames"/>
        /// </summary>
        /// 
        /// <param name="listDomainNamesRequest">Container for the necessary parameters to execute the ListDomainNames operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        IAsyncResult BeginListDomainNames(ListDomainNamesRequest listDomainNamesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListDomainNames operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.ListDomainNames"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a ListDomainNamesResult from AmazonCloudSearch.</returns>
        ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists all search domains owned by an account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="BaseException"/>
        ListDomainNamesResponse ListDomainNames();
        
        #endregion
        
    

        #region UpdateAvailabilityOptions

        /// <summary>
        /// <para>Configures the availability options for a domain. Enabling the Multi-AZ option expands an Amazon CloudSearch domain to an additional
        /// Availability Zone in the same Region to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ option can
        /// take about half an hour to become active. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html" >Configuring Availability
        /// Options</a> in the <i>Amazon CloudSearch Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityOptions service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="DisabledOperationException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        UpdateAvailabilityOptionsResponse UpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="updateAvailabilityOptionsRequest">Container for the necessary parameters to execute the UpdateAvailabilityOptions operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateAvailabilityOptions operation.</returns>
        IAsyncResult BeginUpdateAvailabilityOptions(UpdateAvailabilityOptionsRequest updateAvailabilityOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAvailabilityOptions operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateAvailabilityOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityOptions.</param>
        /// 
        /// <returns>Returns a UpdateAvailabilityOptionsResult from AmazonCloudSearch.</returns>
        UpdateAvailabilityOptionsResponse EndUpdateAvailabilityOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateScalingParameters

        /// <summary>
        /// <para>Configures scaling parameters for a domain. A domain's scaling parameters specify the desired search instance type and replication
        /// count. Amazon CloudSearch will still automatically scale your domain based on the volume of data and traffic, but not below the desired
        /// instance type and replication count. If the Multi-AZ option is enabled, these values control the resources used per Availability Zone. For
        /// more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-scaling-options.html" >Configuring
        /// Scaling Options</a> in the <i>Amazon CloudSearch Developer Guide</i> . </para>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters service method on
        ///          AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateScalingParameters service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        UpdateScalingParametersResponse UpdateScalingParameters(UpdateScalingParametersRequest updateScalingParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="updateScalingParametersRequest">Container for the necessary parameters to execute the UpdateScalingParameters operation on
        ///          AmazonCloudSearch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateScalingParameters operation.</returns>
        IAsyncResult BeginUpdateScalingParameters(UpdateScalingParametersRequest updateScalingParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateScalingParameters operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateScalingParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScalingParameters.</param>
        /// 
        /// <returns>Returns a UpdateScalingParametersResult from AmazonCloudSearch.</returns>
        UpdateScalingParametersResponse EndUpdateScalingParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateServiceAccessPolicies

        /// <summary>
        /// <para>Configures the access rules that control access to the domain's document and search endpoints. For more information, see <a
        /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-access.html" > Configuring Access for an Amazon CloudSearch
        /// Domain</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateServiceAccessPoliciesRequest">Container for the necessary parameters to execute the UpdateServiceAccessPolicies service
        ///          method on AmazonCloudSearch.</param>
        /// 
        /// <returns>The response from the UpdateServiceAccessPolicies service method, as returned by AmazonCloudSearch.</returns>
        /// 
        /// <exception cref="InternalException"/>
        /// <exception cref="InvalidTypeException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="BaseException"/>
        UpdateServiceAccessPoliciesResponse UpdateServiceAccessPolicies(UpdateServiceAccessPoliciesRequest updateServiceAccessPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAccessPolicies operation.
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateServiceAccessPolicies"/>
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
        /// <seealso cref="Amazon.CloudSearch.IAmazonCloudSearch.UpdateServiceAccessPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAccessPolicies.</param>
        /// 
        /// <returns>Returns a UpdateServiceAccessPoliciesResult from AmazonCloudSearch.</returns>
        UpdateServiceAccessPoliciesResponse EndUpdateServiceAccessPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    

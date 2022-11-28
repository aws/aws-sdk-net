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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OAM.Model;

namespace Amazon.OAM
{
    /// <summary>
    /// Interface for accessing OAM
    ///
    /// Use Amazon CloudWatch Observability Access Manager to create and manage links between
    /// source accounts and monitoring accounts by using <i>CloudWatch cross-account observability</i>.
    /// With CloudWatch cross-account observability, you can monitor and troubleshoot applications
    /// that span multiple accounts within a Region. Seamlessly search, visualize, and analyze
    /// your metrics, logs, and traces in any of the linked accounts without account boundaries.
    /// 
    ///  <pre><code> &lt;p&gt;Set up one or more Amazon Web Services accounts as &lt;i&gt;monitoring
    /// accounts&lt;/i&gt; and link them with multiple &lt;i&gt;source accounts&lt;/i&gt;.
    /// A monitoring account is a central Amazon Web Services account that can view and interact
    /// with observability data generated from source accounts. A source account is an individual
    /// Amazon Web Services account that generates observability data for the resources that
    /// reside in it. Source accounts share their observability data with the monitoring account.
    /// The shared observability data can include metrics in Amazon CloudWatch, logs in Amazon
    /// CloudWatch Logs, and traces in X-Ray.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial interface IAmazonOAM : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOAMPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateLink


        /// <summary>
        /// Creates a link between a source account and a sink that you have created in a monitoring
        /// account.
        /// 
        ///  
        /// <para>
        /// Before you create a link, you must create a sink in the monitoring account and create
        /// a sink policy in that account. The sink policy must permit the source account to link
        /// to it. You can grant permission to source accounts by granting permission to an entire
        /// organization or to individual accounts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_CreateSink.html">CreateSink</a>
        /// and <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_PutSinkPolicy.html">PutSinkPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Each monitoring account can be linked to as many as 100,000 source accounts.
        /// </para>
        ///  
        /// <para>
        /// Each source account can be linked to as many as five monitoring accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse CreateLink(CreateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateLink">REST API Reference for CreateLink Operation</seealso>
        IAsyncResult BeginCreateLink(CreateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLink.</param>
        /// 
        /// <returns>Returns a  CreateLinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateLink">REST API Reference for CreateLink Operation</seealso>
        CreateLinkResponse EndCreateLink(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSink


        /// <summary>
        /// Use this to create a <i>sink</i> in the current account, so that it can be used as
        /// a monitoring account in CloudWatch cross-account observability. A sink is a resource
        /// that represents an attachment point in a monitoring account. Source accounts can link
        /// to the sink to send observability data.
        /// 
        ///  
        /// <para>
        /// After you create a sink, you must create a sink policy that allows source accounts
        /// to attach to it. For more information, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_PutSinkPolicy.html">PutSinkPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Each account can contain one sink. If you delete a sink, you can then create a new
        /// one in that account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSink service method.</param>
        /// 
        /// <returns>The response from the CreateSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateSink">REST API Reference for CreateSink Operation</seealso>
        CreateSinkResponse CreateSink(CreateSinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateSink">REST API Reference for CreateSink Operation</seealso>
        IAsyncResult BeginCreateSink(CreateSinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSink.</param>
        /// 
        /// <returns>Returns a  CreateSinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateSink">REST API Reference for CreateSink Operation</seealso>
        CreateSinkResponse EndCreateSink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLink


        /// <summary>
        /// Deletes a link between a monitoring account sink and a source account. You must run
        /// this operation in the source account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse DeleteLink(DeleteLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        IAsyncResult BeginDeleteLink(DeleteLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLink.</param>
        /// 
        /// <returns>Returns a  DeleteLinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        DeleteLinkResponse EndDeleteLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSink


        /// <summary>
        /// Deletes a sink. You must delete all links to a sink before you can delete that sink.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSink service method.</param>
        /// 
        /// <returns>The response from the DeleteSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteSink">REST API Reference for DeleteSink Operation</seealso>
        DeleteSinkResponse DeleteSink(DeleteSinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteSink">REST API Reference for DeleteSink Operation</seealso>
        IAsyncResult BeginDeleteSink(DeleteSinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSink.</param>
        /// 
        /// <returns>Returns a  DeleteSinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteSink">REST API Reference for DeleteSink Operation</seealso>
        DeleteSinkResponse EndDeleteSink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLink


        /// <summary>
        /// Returns complete information about one link.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the link ARN. To retrieve a list of link ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetLink">REST API Reference for GetLink Operation</seealso>
        GetLinkResponse GetLink(GetLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetLink">REST API Reference for GetLink Operation</seealso>
        IAsyncResult BeginGetLink(GetLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLink.</param>
        /// 
        /// <returns>Returns a  GetLinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetLink">REST API Reference for GetLink Operation</seealso>
        GetLinkResponse EndGetLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSink


        /// <summary>
        /// Returns complete information about one monitoring account sink.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSink service method.</param>
        /// 
        /// <returns>The response from the GetSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSink">REST API Reference for GetSink Operation</seealso>
        GetSinkResponse GetSink(GetSinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSink">REST API Reference for GetSink Operation</seealso>
        IAsyncResult BeginGetSink(GetSinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSink.</param>
        /// 
        /// <returns>Returns a  GetSinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSink">REST API Reference for GetSink Operation</seealso>
        GetSinkResponse EndGetSink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSinkPolicy


        /// <summary>
        /// Returns the current sink policy attached to this sink. The sink policy specifies what
        /// accounts can attach to this sink as source accounts, and what types of data they can
        /// share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSinkPolicy service method.</param>
        /// 
        /// <returns>The response from the GetSinkPolicy service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSinkPolicy">REST API Reference for GetSinkPolicy Operation</seealso>
        GetSinkPolicyResponse GetSinkPolicy(GetSinkPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSinkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSinkPolicy operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSinkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSinkPolicy">REST API Reference for GetSinkPolicy Operation</seealso>
        IAsyncResult BeginGetSinkPolicy(GetSinkPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSinkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSinkPolicy.</param>
        /// 
        /// <returns>Returns a  GetSinkPolicyResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSinkPolicy">REST API Reference for GetSinkPolicy Operation</seealso>
        GetSinkPolicyResponse EndGetSinkPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedLinks


        /// <summary>
        /// Returns a list of source account links that are linked to this monitoring account
        /// sink.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
        /// </para>
        ///  
        /// <para>
        /// To find a list of links for one source account, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedLinks service method.</param>
        /// 
        /// <returns>The response from the ListAttachedLinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListAttachedLinks">REST API Reference for ListAttachedLinks Operation</seealso>
        ListAttachedLinksResponse ListAttachedLinks(ListAttachedLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedLinks operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListAttachedLinks">REST API Reference for ListAttachedLinks Operation</seealso>
        IAsyncResult BeginListAttachedLinks(ListAttachedLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedLinks.</param>
        /// 
        /// <returns>Returns a  ListAttachedLinksResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListAttachedLinks">REST API Reference for ListAttachedLinks Operation</seealso>
        ListAttachedLinksResponse EndListAttachedLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLinks


        /// <summary>
        /// Use this operation in a source account to return a list of links to monitoring account
        /// sinks that this source account has.
        /// 
        ///  
        /// <para>
        /// To find a list of links for one monitoring account sink, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListAttachedLinks.html">ListAttachedLinks</a>
        /// from within the monitoring account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListLinks">REST API Reference for ListLinks Operation</seealso>
        ListLinksResponse ListLinks(ListLinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinks operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListLinks">REST API Reference for ListLinks Operation</seealso>
        IAsyncResult BeginListLinks(ListLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinks.</param>
        /// 
        /// <returns>Returns a  ListLinksResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListLinks">REST API Reference for ListLinks Operation</seealso>
        ListLinksResponse EndListLinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSinks


        /// <summary>
        /// Use this operation in a monitoring account to return the list of sinks created in
        /// that account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSinks service method.</param>
        /// 
        /// <returns>The response from the ListSinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListSinks">REST API Reference for ListSinks Operation</seealso>
        ListSinksResponse ListSinks(ListSinksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSinks operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListSinks">REST API Reference for ListSinks Operation</seealso>
        IAsyncResult BeginListSinks(ListSinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSinks.</param>
        /// 
        /// <returns>Returns a  ListSinksResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListSinks">REST API Reference for ListSinks Operation</seealso>
        ListSinksResponse EndListSinks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a resource. Both sinks and links support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSinkPolicy


        /// <summary>
        /// Creates or updates the resource policy that grants permissions to source accounts
        /// to link to the monitoring account sink. When you create a sink policy, you can grant
        /// permissions to all accounts in an organization or to individual accounts.
        /// 
        ///  
        /// <para>
        /// You can also use a sink policy to limit the types of data that is shared. The three
        /// types that you can allow or deny are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Metrics</b> - Specify with <code>AWS::CloudWatch::Metric</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Log groups</b> - Specify with <code>AWS::Logs::LogGroup</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Traces</b> - Specify with <code>AWS::XRay::Trace</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See the examples in this section to see how to specify permitted source accounts and
        /// data types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSinkPolicy service method.</param>
        /// 
        /// <returns>The response from the PutSinkPolicy service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/PutSinkPolicy">REST API Reference for PutSinkPolicy Operation</seealso>
        PutSinkPolicyResponse PutSinkPolicy(PutSinkPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSinkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSinkPolicy operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSinkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/PutSinkPolicy">REST API Reference for PutSinkPolicy Operation</seealso>
        IAsyncResult BeginPutSinkPolicy(PutSinkPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSinkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSinkPolicy.</param>
        /// 
        /// <returns>Returns a  PutSinkPolicyResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/PutSinkPolicy">REST API Reference for PutSinkPolicy Operation</seealso>
        PutSinkPolicyResponse EndPutSinkPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource. Both sinks and
        /// links can be tagged. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  <important> 
        /// <para>
        /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
        /// links and sinks you must have the <code>oam:ResourceTag</code> permission. The <code>iam:ResourceTag</code>
        /// permission does not allow you to tag and untag links and sinks.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.TooManyTagsException">
        /// A resource can have no more than 50 tags.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// 
        ///  <important> 
        /// <para>
        /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
        /// links and sinks you must have the <code>oam:ResourceTag</code> permission. The <code>iam:TagResource</code>
        /// permission does not allow you to tag and untag links and sinks.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLink


        /// <summary>
        /// Use this operation to change what types of data are shared from a source account to
        /// its linked monitoring account sink. You can't change the sink or change the monitoring
        /// account with this operation.
        /// 
        ///  
        /// <para>
        /// To update the list of tags associated with the sink, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse UpdateLink(UpdateLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink operation on AmazonOAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        IAsyncResult BeginUpdateLink(UpdateLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLink.</param>
        /// 
        /// <returns>Returns a  UpdateLinkResult from OAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        UpdateLinkResponse EndUpdateLink(IAsyncResult asyncResult);

        #endregion
        
    }
}
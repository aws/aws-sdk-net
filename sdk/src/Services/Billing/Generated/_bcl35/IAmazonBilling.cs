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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Billing.Model;

#pragma warning disable CS1570
namespace Amazon.Billing
{
    /// <summary>
    /// <para>Interface for accessing Billing</para>
    ///
    /// You can use the Billing API to programatically list the billing views available to
    /// you for a given time period. A billing view represents a set of billing data. 
    /// 
    ///  
    /// <para>
    /// The Billing API provides the following endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <c>https://billing.us-east-1.api.aws</c> 
    /// </para>
    /// </summary>
    public partial interface IAmazonBilling : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBillingPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateSourceViews


        /// <summary>
        /// Associates one or more source billing views with an existing billing view. This allows
        /// creating aggregate billing views that combine data from multiple sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceViews service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/AssociateSourceViews">REST API Reference for AssociateSourceViews Operation</seealso>
        AssociateSourceViewsResponse AssociateSourceViews(AssociateSourceViewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSourceViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceViews operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSourceViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/AssociateSourceViews">REST API Reference for AssociateSourceViews Operation</seealso>
        IAsyncResult BeginAssociateSourceViews(AssociateSourceViewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSourceViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSourceViews.</param>
        /// 
        /// <returns>Returns a  AssociateSourceViewsResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/AssociateSourceViews">REST API Reference for AssociateSourceViews Operation</seealso>
        AssociateSourceViewsResponse EndAssociateSourceViews(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBillingView


        /// <summary>
        /// Creates a billing view with the specified billing view attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingView service method.</param>
        /// 
        /// <returns>The response from the CreateBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/CreateBillingView">REST API Reference for CreateBillingView Operation</seealso>
        CreateBillingViewResponse CreateBillingView(CreateBillingViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillingView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingView operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillingView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/CreateBillingView">REST API Reference for CreateBillingView Operation</seealso>
        IAsyncResult BeginCreateBillingView(CreateBillingViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillingView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillingView.</param>
        /// 
        /// <returns>Returns a  CreateBillingViewResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/CreateBillingView">REST API Reference for CreateBillingView Operation</seealso>
        CreateBillingViewResponse EndCreateBillingView(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBillingView


        /// <summary>
        /// Deletes the specified billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingView service method.</param>
        /// 
        /// <returns>The response from the DeleteBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DeleteBillingView">REST API Reference for DeleteBillingView Operation</seealso>
        DeleteBillingViewResponse DeleteBillingView(DeleteBillingViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillingView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingView operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillingView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DeleteBillingView">REST API Reference for DeleteBillingView Operation</seealso>
        IAsyncResult BeginDeleteBillingView(DeleteBillingViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillingView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillingView.</param>
        /// 
        /// <returns>Returns a  DeleteBillingViewResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DeleteBillingView">REST API Reference for DeleteBillingView Operation</seealso>
        DeleteBillingViewResponse EndDeleteBillingView(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSourceViews


        /// <summary>
        /// Removes the association between one or more source billing views and an existing
        /// billing view. This allows modifying the composition of aggregate billing views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceViews service method.</param>
        /// 
        /// <returns>The response from the DisassociateSourceViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DisassociateSourceViews">REST API Reference for DisassociateSourceViews Operation</seealso>
        DisassociateSourceViewsResponse DisassociateSourceViews(DisassociateSourceViewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSourceViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceViews operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSourceViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DisassociateSourceViews">REST API Reference for DisassociateSourceViews Operation</seealso>
        IAsyncResult BeginDisassociateSourceViews(DisassociateSourceViewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSourceViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSourceViews.</param>
        /// 
        /// <returns>Returns a  DisassociateSourceViewsResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DisassociateSourceViews">REST API Reference for DisassociateSourceViews Operation</seealso>
        DisassociateSourceViewsResponse EndDisassociateSourceViews(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBillingView


        /// <summary>
        /// Returns the metadata associated to the specified billing view ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillingView service method.</param>
        /// 
        /// <returns>The response from the GetBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetBillingView">REST API Reference for GetBillingView Operation</seealso>
        GetBillingViewResponse GetBillingView(GetBillingViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillingView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillingView operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillingView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetBillingView">REST API Reference for GetBillingView Operation</seealso>
        IAsyncResult BeginGetBillingView(GetBillingViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillingView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillingView.</param>
        /// 
        /// <returns>Returns a  GetBillingViewResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetBillingView">REST API Reference for GetBillingView Operation</seealso>
        GetBillingViewResponse EndGetBillingView(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns the resource-based policy document attached to the resource in <c>JSON</c>
        /// format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillingViews


        /// <summary>
        /// Lists the billing views available for a given time period. 
        /// 
        ///  
        /// <para>
        /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
        /// the billing data available by default. Accounts that use Billing Conductor also have
        /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
        /// created billing group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews service method.</param>
        /// 
        /// <returns>The response from the ListBillingViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        ListBillingViewsResponse ListBillingViews(ListBillingViewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillingViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillingViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        IAsyncResult BeginListBillingViews(ListBillingViewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingViews.</param>
        /// 
        /// <returns>Returns a  ListBillingViewsResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        ListBillingViewsResponse EndListBillingViews(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceViewsForBillingView


        /// <summary>
        /// Lists the source views (managed Amazon Web Services billing views) associated with
        /// the billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceViewsForBillingView service method.</param>
        /// 
        /// <returns>The response from the ListSourceViewsForBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListSourceViewsForBillingView">REST API Reference for ListSourceViewsForBillingView Operation</seealso>
        ListSourceViewsForBillingViewResponse ListSourceViewsForBillingView(ListSourceViewsForBillingViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceViewsForBillingView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceViewsForBillingView operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceViewsForBillingView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListSourceViewsForBillingView">REST API Reference for ListSourceViewsForBillingView Operation</seealso>
        IAsyncResult BeginListSourceViewsForBillingView(ListSourceViewsForBillingViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceViewsForBillingView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceViewsForBillingView.</param>
        /// 
        /// <returns>Returns a  ListSourceViewsForBillingViewResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListSourceViewsForBillingView">REST API Reference for ListSourceViewsForBillingView Operation</seealso>
        ListSourceViewsForBillingViewResponse EndListSourceViewsForBillingView(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags associated with the billing view resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// An API operation for adding one or more tags (key-value pairs) to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource. Specify only tag keys in your request.
        /// Don't specify the value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBillingView


        /// <summary>
        /// An API to update the attributes of the billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingView service method.</param>
        /// 
        /// <returns>The response from the UpdateBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UpdateBillingView">REST API Reference for UpdateBillingView Operation</seealso>
        UpdateBillingViewResponse UpdateBillingView(UpdateBillingViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillingView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingView operation on AmazonBillingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillingView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UpdateBillingView">REST API Reference for UpdateBillingView Operation</seealso>
        IAsyncResult BeginUpdateBillingView(UpdateBillingViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillingView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillingView.</param>
        /// 
        /// <returns>Returns a  UpdateBillingViewResult from Billing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UpdateBillingView">REST API Reference for UpdateBillingView Operation</seealso>
        UpdateBillingViewResponse EndUpdateBillingView(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}
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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Invoicing.Model;

#pragma warning disable CS1570
namespace Amazon.Invoicing
{
    /// <summary>
    /// <para>Interface for accessing Invoicing</para>
    ///
    /// <b>Amazon Web Services Invoice Configuration</b> 
    /// 
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration APIs to programmatically create,
    /// update, delete, get, and list invoice units. You can also programmatically fetch the
    /// information of the invoice receiver. For example, business legal name, address, and
    /// invoicing contacts. 
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration to receive separate Amazon Web
    /// Services invoices based your organizational needs. By using Amazon Web Services Invoice
    /// Configuration, you can configure invoice units that are groups of Amazon Web Services
    /// accounts that represent your business entities, and receive separate invoices for
    /// each business entity. You can also assign a unique member or payer account as the
    /// invoice receiver for each invoice unit. As you create new accounts within your Organizations
    /// using Amazon Web Services Invoice Configuration APIs, you can automate the creation
    /// of new invoice units and subsequently automate the addition of new accounts to your
    /// invoice units.
    /// </para>
    ///  
    /// <para>
    /// Service endpoint
    /// </para>
    ///  
    /// <para>
    /// You can use the following endpoints for Amazon Web Services Invoice Configuration:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://invoicing.us-east-1.api.aws</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonInvoicing : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInvoicingPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchGetInvoiceProfile


        /// <summary>
        /// This gets the invoice profile associated with a set of accounts. The accounts must
        /// be linked accounts under the requester management account organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetInvoiceProfile service method.</param>
        /// 
        /// <returns>The response from the BatchGetInvoiceProfile service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        BatchGetInvoiceProfileResponse BatchGetInvoiceProfile(BatchGetInvoiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetInvoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetInvoiceProfile operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetInvoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        IAsyncResult BeginBatchGetInvoiceProfile(BatchGetInvoiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetInvoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetInvoiceProfile.</param>
        /// 
        /// <returns>Returns a  BatchGetInvoiceProfileResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        BatchGetInvoiceProfileResponse EndBatchGetInvoiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInvoiceUnit


        /// <summary>
        /// This creates a new invoice unit with the provided definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the CreateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        CreateInvoiceUnitResponse CreateInvoiceUnit(CreateInvoiceUnitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        IAsyncResult BeginCreateInvoiceUnit(CreateInvoiceUnitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  CreateInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        CreateInvoiceUnitResponse EndCreateInvoiceUnit(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInvoiceUnit


        /// <summary>
        /// This deletes an invoice unit with the provided invoice unit ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the DeleteInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        DeleteInvoiceUnitResponse DeleteInvoiceUnit(DeleteInvoiceUnitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        IAsyncResult BeginDeleteInvoiceUnit(DeleteInvoiceUnitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  DeleteInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        DeleteInvoiceUnitResponse EndDeleteInvoiceUnit(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvoicePDF


        /// <summary>
        /// Returns a URL to download the invoice document and supplemental documents associated
        /// with an invoice. The URLs are pre-signed and have expiration time. For special cases
        /// like Brazil, where Amazon Web Services generated invoice identifiers and government
        /// provided identifiers do not match, use the Amazon Web Services generated invoice identifier
        /// when making API requests. To grant IAM permission to use this operation, the caller
        /// needs the <c>invoicing:GetInvoicePDF</c> policy action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvoicePDF service method.</param>
        /// 
        /// <returns>The response from the GetInvoicePDF service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoicePDF">REST API Reference for GetInvoicePDF Operation</seealso>
        GetInvoicePDFResponse GetInvoicePDF(GetInvoicePDFRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvoicePDF operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvoicePDF operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvoicePDF
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoicePDF">REST API Reference for GetInvoicePDF Operation</seealso>
        IAsyncResult BeginGetInvoicePDF(GetInvoicePDFRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvoicePDF operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvoicePDF.</param>
        /// 
        /// <returns>Returns a  GetInvoicePDFResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoicePDF">REST API Reference for GetInvoicePDF Operation</seealso>
        GetInvoicePDFResponse EndGetInvoicePDF(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvoiceUnit


        /// <summary>
        /// This retrieves the invoice unit definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the GetInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        GetInvoiceUnitResponse GetInvoiceUnit(GetInvoiceUnitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        IAsyncResult BeginGetInvoiceUnit(GetInvoiceUnitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  GetInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        GetInvoiceUnitResponse EndGetInvoiceUnit(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvoiceSummaries


        /// <summary>
        /// Retrieves your invoice details programmatically, without line item details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceSummaries service method.</param>
        /// 
        /// <returns>The response from the ListInvoiceSummaries service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceSummaries">REST API Reference for ListInvoiceSummaries Operation</seealso>
        ListInvoiceSummariesResponse ListInvoiceSummaries(ListInvoiceSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvoiceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceSummaries operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvoiceSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceSummaries">REST API Reference for ListInvoiceSummaries Operation</seealso>
        IAsyncResult BeginListInvoiceSummaries(ListInvoiceSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvoiceSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvoiceSummaries.</param>
        /// 
        /// <returns>Returns a  ListInvoiceSummariesResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceSummaries">REST API Reference for ListInvoiceSummaries Operation</seealso>
        ListInvoiceSummariesResponse EndListInvoiceSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvoiceUnits


        /// <summary>
        /// This fetches a list of all invoice unit definitions for a given account, as of the
        /// provided <c>AsOf</c> date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceUnits service method.</param>
        /// 
        /// <returns>The response from the ListInvoiceUnits service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        ListInvoiceUnitsResponse ListInvoiceUnits(ListInvoiceUnitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvoiceUnits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceUnits operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvoiceUnits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        IAsyncResult BeginListInvoiceUnits(ListInvoiceUnitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvoiceUnits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvoiceUnits.</param>
        /// 
        /// <returns>Returns a  ListInvoiceUnitsResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        ListInvoiceUnitsResponse EndListInvoiceUnits(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ServiceQuotaExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInvoiceUnit


        /// <summary>
        /// You can update the invoice unit configuration at any time, and Amazon Web Services
        /// will use the latest configuration at the end of the month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the UpdateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        UpdateInvoiceUnitResponse UpdateInvoiceUnit(UpdateInvoiceUnitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        IAsyncResult BeginUpdateInvoiceUnit(UpdateInvoiceUnitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  UpdateInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        UpdateInvoiceUnitResponse EndUpdateInvoiceUnit(IAsyncResult asyncResult);

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
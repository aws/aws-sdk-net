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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpenSearchService.Model;

namespace Amazon.OpenSearchService
{
    /// <summary>
    /// Interface for accessing OpenSearchService
    ///
    /// Amazon OpenSearch Configuration Service 
    /// <para>
    /// Use the Amazon OpenSearch configuration API to create, configure, and manage Amazon
    /// OpenSearch Service domains.
    /// </para>
    ///  
    /// <para>
    /// For sample code that uses the configuration API, see the <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/opensearch-configuration-samples.html">
    /// Amazon OpenSearch Service Developer Guide</a>. The guide also contains <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/request-signing.html">
    /// sample code for sending signed HTTP requests to the OpenSearch APIs</a>. 
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#service-regions"
    /// target="_blank">Regions and Endpoints</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonOpenSearchService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOpenSearchServicePaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptInboundConnection


        /// <summary>
        /// Allows the remote domain owner to accept an inbound cross-cluster connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AcceptInboundConnection">REST API Reference for AcceptInboundConnection Operation</seealso>
        AcceptInboundConnectionResponse AcceptInboundConnection(AcceptInboundConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundConnection operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInboundConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AcceptInboundConnection">REST API Reference for AcceptInboundConnection Operation</seealso>
        IAsyncResult BeginAcceptInboundConnection(AcceptInboundConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInboundConnection.</param>
        /// 
        /// <returns>Returns a  AcceptInboundConnectionResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AcceptInboundConnection">REST API Reference for AcceptInboundConnection Operation</seealso>
        AcceptInboundConnectionResponse EndAcceptInboundConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Attaches tags to an existing domain. Tags are a set of case-sensitive key value pairs.
        /// An domain can have up to 10 tags. See <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains.html#managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon OpenSearch Service domains</a> for more information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePackage


        /// <summary>
        /// Associates a package with an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        AssociatePackageResponse AssociatePackage(AssociatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        IAsyncResult BeginAssociatePackage(AssociatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePackage.</param>
        /// 
        /// <returns>Returns a  AssociatePackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        AssociatePackageResponse EndAssociatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelServiceSoftwareUpdate


        /// <summary>
        /// Cancels a scheduled service software update for an Amazon OpenSearch Service domain.
        /// You can only perform this operation before the <code>AutomatedUpdateDate</code> and
        /// when the <code>UpdateStatus</code> is in the <code>PENDING_UPDATE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the CancelServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelServiceSoftwareUpdate">REST API Reference for CancelServiceSoftwareUpdate Operation</seealso>
        CancelServiceSoftwareUpdateResponse CancelServiceSoftwareUpdate(CancelServiceSoftwareUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceSoftwareUpdate operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelServiceSoftwareUpdate">REST API Reference for CancelServiceSoftwareUpdate Operation</seealso>
        IAsyncResult BeginCancelServiceSoftwareUpdate(CancelServiceSoftwareUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  CancelServiceSoftwareUpdateResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelServiceSoftwareUpdate">REST API Reference for CancelServiceSoftwareUpdate Operation</seealso>
        CancelServiceSoftwareUpdateResponse EndCancelServiceSoftwareUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a new Amazon OpenSearch Service domain. For more information, see <a href="http://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html"
        /// target="_blank">Creating and managing Amazon OpenSearch Service domains </a> in the
        /// <i>Amazon OpenSearch Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOutboundConnection


        /// <summary>
        /// Creates a new cross-cluster connection from a local OpenSearch domain to a remote
        /// OpenSearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundConnection service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateOutboundConnection">REST API Reference for CreateOutboundConnection Operation</seealso>
        CreateOutboundConnectionResponse CreateOutboundConnection(CreateOutboundConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutboundConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundConnection operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutboundConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateOutboundConnection">REST API Reference for CreateOutboundConnection Operation</seealso>
        IAsyncResult BeginCreateOutboundConnection(CreateOutboundConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutboundConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutboundConnection.</param>
        /// 
        /// <returns>Returns a  CreateOutboundConnectionResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateOutboundConnection">REST API Reference for CreateOutboundConnection Operation</seealso>
        CreateOutboundConnectionResponse EndCreateOutboundConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePackage


        /// <summary>
        /// Create a package for use with Amazon OpenSearch Service domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        CreatePackageResponse CreatePackage(CreatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        IAsyncResult BeginCreatePackage(CreatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackage.</param>
        /// 
        /// <returns>Returns a  CreatePackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        CreatePackageResponse EndCreatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Permanently deletes the specified domain and all of its data. Once a domain is deleted,
        /// it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInboundConnection


        /// <summary>
        /// Allows the remote domain owner to delete an existing inbound cross-cluster connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteInboundConnection">REST API Reference for DeleteInboundConnection Operation</seealso>
        DeleteInboundConnectionResponse DeleteInboundConnection(DeleteInboundConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundConnection operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInboundConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteInboundConnection">REST API Reference for DeleteInboundConnection Operation</seealso>
        IAsyncResult BeginDeleteInboundConnection(DeleteInboundConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInboundConnection.</param>
        /// 
        /// <returns>Returns a  DeleteInboundConnectionResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteInboundConnection">REST API Reference for DeleteInboundConnection Operation</seealso>
        DeleteInboundConnectionResponse EndDeleteInboundConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOutboundConnection


        /// <summary>
        /// Allows the local domain owner to delete an existing outbound cross-cluster connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteOutboundConnection">REST API Reference for DeleteOutboundConnection Operation</seealso>
        DeleteOutboundConnectionResponse DeleteOutboundConnection(DeleteOutboundConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutboundConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundConnection operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutboundConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteOutboundConnection">REST API Reference for DeleteOutboundConnection Operation</seealso>
        IAsyncResult BeginDeleteOutboundConnection(DeleteOutboundConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutboundConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutboundConnection.</param>
        /// 
        /// <returns>Returns a  DeleteOutboundConnectionResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteOutboundConnection">REST API Reference for DeleteOutboundConnection Operation</seealso>
        DeleteOutboundConnectionResponse EndDeleteOutboundConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePackage


        /// <summary>
        /// Deletes the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse DeletePackage(DeletePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        IAsyncResult BeginDeletePackage(DeletePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackage.</param>
        /// 
        /// <returns>Returns a  DeletePackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse EndDeletePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomain


        /// <summary>
        /// Returns domain configuration information about the specified domain, including the
        /// domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse DescribeDomain(DescribeDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainAutoTunes


        /// <summary>
        /// Provides scheduled Auto-Tune action details for the domain, such as Auto-Tune action
        /// type, description, severity, and scheduled date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainAutoTunes service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        DescribeDomainAutoTunesResponse DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainAutoTunes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        IAsyncResult BeginDescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainAutoTunes.</param>
        /// 
        /// <returns>Returns a  DescribeDomainAutoTunesResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        DescribeDomainAutoTunesResponse EndDescribeDomainAutoTunes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainChangeProgress


        /// <summary>
        /// Returns information about the current blue/green deployment happening on a domain,
        /// including a change ID, status, and progress stages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainChangeProgress service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        DescribeDomainChangeProgressResponse DescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainChangeProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        IAsyncResult BeginDescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainChangeProgress.</param>
        /// 
        /// <returns>Returns a  DescribeDomainChangeProgressResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        DescribeDomainChangeProgressResponse EndDescribeDomainChangeProgress(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainConfig


        /// <summary>
        /// Provides cluster configuration information about the specified domain, such as the
        /// state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainConfig">REST API Reference for DescribeDomainConfig Operation</seealso>
        DescribeDomainConfigResponse DescribeDomainConfig(DescribeDomainConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfig operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainConfig">REST API Reference for DescribeDomainConfig Operation</seealso>
        IAsyncResult BeginDescribeDomainConfig(DescribeDomainConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainConfig.</param>
        /// 
        /// <returns>Returns a  DescribeDomainConfigResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainConfig">REST API Reference for DescribeDomainConfig Operation</seealso>
        DescribeDomainConfigResponse EndDescribeDomainConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomains


        /// <summary>
        /// Returns domain configuration information about the specified domains, including the
        /// domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        IAsyncResult BeginDescribeDomains(DescribeDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomains.</param>
        /// 
        /// <returns>Returns a  DescribeDomainsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        DescribeDomainsResponse EndDescribeDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInboundConnections


        /// <summary>
        /// Lists all the inbound cross-cluster connections for a remote domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeInboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInboundConnections">REST API Reference for DescribeInboundConnections Operation</seealso>
        DescribeInboundConnectionsResponse DescribeInboundConnections(DescribeInboundConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInboundConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundConnections operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInboundConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInboundConnections">REST API Reference for DescribeInboundConnections Operation</seealso>
        IAsyncResult BeginDescribeInboundConnections(DescribeInboundConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInboundConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInboundConnections.</param>
        /// 
        /// <returns>Returns a  DescribeInboundConnectionsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInboundConnections">REST API Reference for DescribeInboundConnections Operation</seealso>
        DescribeInboundConnectionsResponse EndDescribeInboundConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceTypeLimits


        /// <summary>
        /// Describe the limits for a given instance type and OpenSearch or Elasticsearch version.
        /// When modifying an existing domain, specify the <code> <a>DomainName</a> </code> to
        /// see which limits you can modify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceTypeLimits service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInstanceTypeLimits">REST API Reference for DescribeInstanceTypeLimits Operation</seealso>
        DescribeInstanceTypeLimitsResponse DescribeInstanceTypeLimits(DescribeInstanceTypeLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypeLimits operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceTypeLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInstanceTypeLimits">REST API Reference for DescribeInstanceTypeLimits Operation</seealso>
        IAsyncResult BeginDescribeInstanceTypeLimits(DescribeInstanceTypeLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceTypeLimits.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceTypeLimitsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInstanceTypeLimits">REST API Reference for DescribeInstanceTypeLimits Operation</seealso>
        DescribeInstanceTypeLimitsResponse EndDescribeInstanceTypeLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOutboundConnections


        /// <summary>
        /// Lists all the outbound cross-cluster connections for a local domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeOutboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeOutboundConnections">REST API Reference for DescribeOutboundConnections Operation</seealso>
        DescribeOutboundConnectionsResponse DescribeOutboundConnections(DescribeOutboundConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOutboundConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundConnections operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOutboundConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeOutboundConnections">REST API Reference for DescribeOutboundConnections Operation</seealso>
        IAsyncResult BeginDescribeOutboundConnections(DescribeOutboundConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOutboundConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOutboundConnections.</param>
        /// 
        /// <returns>Returns a  DescribeOutboundConnectionsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeOutboundConnections">REST API Reference for DescribeOutboundConnections Operation</seealso>
        DescribeOutboundConnectionsResponse EndDescribeOutboundConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePackages


        /// <summary>
        /// Describes all packages available to Amazon OpenSearch Service domains. Includes options
        /// for filtering, limiting the number of results, and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        DescribePackagesResponse DescribePackages(DescribePackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        IAsyncResult BeginDescribePackages(DescribePackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackages.</param>
        /// 
        /// <returns>Returns a  DescribePackagesResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        DescribePackagesResponse EndDescribePackages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstanceOfferings


        /// <summary>
        /// Lists available reserved OpenSearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstanceOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstanceOfferings service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstanceOfferings">REST API Reference for DescribeReservedInstanceOfferings Operation</seealso>
        DescribeReservedInstanceOfferingsResponse DescribeReservedInstanceOfferings(DescribeReservedInstanceOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstanceOfferings operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstanceOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstanceOfferings">REST API Reference for DescribeReservedInstanceOfferings Operation</seealso>
        IAsyncResult BeginDescribeReservedInstanceOfferings(DescribeReservedInstanceOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstanceOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstanceOfferingsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstanceOfferings">REST API Reference for DescribeReservedInstanceOfferings Operation</seealso>
        DescribeReservedInstanceOfferingsResponse EndDescribeReservedInstanceOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstances


        /// <summary>
        /// Returns information about reserved OpenSearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        DescribeReservedInstancesResponse EndDescribeReservedInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DissociatePackage


        /// <summary>
        /// Dissociates a package from the Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        DissociatePackageResponse DissociatePackage(DissociatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDissociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        IAsyncResult BeginDissociatePackage(DissociatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDissociatePackage.</param>
        /// 
        /// <returns>Returns a  DissociatePackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        DissociatePackageResponse EndDissociatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCompatibleVersions


        /// <summary>
        /// Returns a list of upgrade-compatible versions of OpenSearch/Elasticsearch. You can
        /// optionally pass a <code> <a>DomainName</a> </code> to get all upgrade-compatible versions
        /// of OpenSearch/Elasticsearch for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetCompatibleVersions">REST API Reference for GetCompatibleVersions Operation</seealso>
        GetCompatibleVersionsResponse GetCompatibleVersions(GetCompatibleVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleVersions operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetCompatibleVersions">REST API Reference for GetCompatibleVersions Operation</seealso>
        IAsyncResult BeginGetCompatibleVersions(GetCompatibleVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleVersionsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetCompatibleVersions">REST API Reference for GetCompatibleVersions Operation</seealso>
        GetCompatibleVersionsResponse EndGetCompatibleVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPackageVersionHistory


        /// <summary>
        /// Returns a list of package versions, along with their creation time and commit message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        GetPackageVersionHistoryResponse GetPackageVersionHistory(GetPackageVersionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPackageVersionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        IAsyncResult BeginGetPackageVersionHistory(GetPackageVersionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPackageVersionHistory.</param>
        /// 
        /// <returns>Returns a  GetPackageVersionHistoryResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        GetPackageVersionHistoryResponse EndGetPackageVersionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUpgradeHistory


        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        IAsyncResult BeginGetUpgradeHistory(GetUpgradeHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeHistory.</param>
        /// 
        /// <returns>Returns a  GetUpgradeHistoryResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        GetUpgradeHistoryResponse EndGetUpgradeHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUpgradeStatus


        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check performed
        /// on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        IAsyncResult BeginGetUpgradeStatus(GetUpgradeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeStatus.</param>
        /// 
        /// <returns>Returns a  GetUpgradeStatusResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        GetUpgradeStatusResponse EndGetUpgradeStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainNames


        /// <summary>
        /// Returns the names of all domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainsForPackage


        /// <summary>
        /// Lists all Amazon OpenSearch Service domains associated with the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        ListDomainsForPackageResponse ListDomainsForPackage(ListDomainsForPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainsForPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        IAsyncResult BeginListDomainsForPackage(ListDomainsForPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainsForPackage.</param>
        /// 
        /// <returns>Returns a  ListDomainsForPackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        ListDomainsForPackageResponse EndListDomainsForPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceTypeDetails


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypeDetails service method.</param>
        /// 
        /// <returns>The response from the ListInstanceTypeDetails service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListInstanceTypeDetails">REST API Reference for ListInstanceTypeDetails Operation</seealso>
        ListInstanceTypeDetailsResponse ListInstanceTypeDetails(ListInstanceTypeDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceTypeDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypeDetails operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceTypeDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListInstanceTypeDetails">REST API Reference for ListInstanceTypeDetails Operation</seealso>
        IAsyncResult BeginListInstanceTypeDetails(ListInstanceTypeDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceTypeDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceTypeDetails.</param>
        /// 
        /// <returns>Returns a  ListInstanceTypeDetailsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListInstanceTypeDetails">REST API Reference for ListInstanceTypeDetails Operation</seealso>
        ListInstanceTypeDetailsResponse EndListInstanceTypeDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPackagesForDomain


        /// <summary>
        /// Lists all packages associated with the Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        ListPackagesForDomainResponse ListPackagesForDomain(ListPackagesForDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackagesForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        IAsyncResult BeginListPackagesForDomain(ListPackagesForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackagesForDomain.</param>
        /// 
        /// <returns>Returns a  ListPackagesForDomainResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        ListPackagesForDomainResponse EndListPackagesForDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns all tags for the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVersions


        /// <summary>
        /// List all supported versions of OpenSearch and Elasticsearch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVersions">REST API Reference for ListVersions Operation</seealso>
        IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedInstanceOffering


        /// <summary>
        /// Allows you to purchase reserved OpenSearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstanceOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstanceOffering service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/PurchaseReservedInstanceOffering">REST API Reference for PurchaseReservedInstanceOffering Operation</seealso>
        PurchaseReservedInstanceOfferingResponse PurchaseReservedInstanceOffering(PurchaseReservedInstanceOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstanceOffering operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedInstanceOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/PurchaseReservedInstanceOffering">REST API Reference for PurchaseReservedInstanceOffering Operation</seealso>
        IAsyncResult BeginPurchaseReservedInstanceOffering(PurchaseReservedInstanceOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstanceOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedInstanceOfferingResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/PurchaseReservedInstanceOffering">REST API Reference for PurchaseReservedInstanceOffering Operation</seealso>
        PurchaseReservedInstanceOfferingResponse EndPurchaseReservedInstanceOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectInboundConnection


        /// <summary>
        /// Allows the remote domain owner to reject an inbound cross-cluster connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundConnection service method.</param>
        /// 
        /// <returns>The response from the RejectInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RejectInboundConnection">REST API Reference for RejectInboundConnection Operation</seealso>
        RejectInboundConnectionResponse RejectInboundConnection(RejectInboundConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundConnection operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInboundConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RejectInboundConnection">REST API Reference for RejectInboundConnection Operation</seealso>
        IAsyncResult BeginRejectInboundConnection(RejectInboundConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInboundConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInboundConnection.</param>
        /// 
        /// <returns>Returns a  RejectInboundConnectionResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RejectInboundConnection">REST API Reference for RejectInboundConnection Operation</seealso>
        RejectInboundConnectionResponse EndRejectInboundConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified set of tags from the given domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult);

        #endregion
        
        #region  StartServiceSoftwareUpdate


        /// <summary>
        /// Schedules a service software update for an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the StartServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartServiceSoftwareUpdate">REST API Reference for StartServiceSoftwareUpdate Operation</seealso>
        StartServiceSoftwareUpdateResponse StartServiceSoftwareUpdate(StartServiceSoftwareUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartServiceSoftwareUpdate operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartServiceSoftwareUpdate">REST API Reference for StartServiceSoftwareUpdate Operation</seealso>
        IAsyncResult BeginStartServiceSoftwareUpdate(StartServiceSoftwareUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  StartServiceSoftwareUpdateResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartServiceSoftwareUpdate">REST API Reference for StartServiceSoftwareUpdate Operation</seealso>
        StartServiceSoftwareUpdateResponse EndStartServiceSoftwareUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainConfig


        /// <summary>
        /// Modifies the cluster configuration of the specified domain, such as setting the instance
        /// type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDomainConfig">REST API Reference for UpdateDomainConfig Operation</seealso>
        UpdateDomainConfigResponse UpdateDomainConfig(UpdateDomainConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfig operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDomainConfig">REST API Reference for UpdateDomainConfig Operation</seealso>
        IAsyncResult BeginUpdateDomainConfig(UpdateDomainConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainConfig.</param>
        /// 
        /// <returns>Returns a  UpdateDomainConfigResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDomainConfig">REST API Reference for UpdateDomainConfig Operation</seealso>
        UpdateDomainConfigResponse EndUpdateDomainConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePackage


        /// <summary>
        /// Updates a package for use with Amazon OpenSearch Service domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        UpdatePackageResponse UpdatePackage(UpdatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        IAsyncResult BeginUpdatePackage(UpdatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePackage.</param>
        /// 
        /// <returns>Returns a  UpdatePackageResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        UpdatePackageResponse EndUpdatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpgradeDomain


        /// <summary>
        /// Allows you to either upgrade your domain or perform an upgrade eligibility check to
        /// a compatible version of OpenSearch or Elasticsearch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeDomain service method.</param>
        /// 
        /// <returns>The response from the UpgradeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpgradeDomain">REST API Reference for UpgradeDomain Operation</seealso>
        UpgradeDomainResponse UpgradeDomain(UpgradeDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeDomain operation on AmazonOpenSearchServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpgradeDomain">REST API Reference for UpgradeDomain Operation</seealso>
        IAsyncResult BeginUpgradeDomain(UpgradeDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeDomain.</param>
        /// 
        /// <returns>Returns a  UpgradeDomainResult from OpenSearchService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpgradeDomain">REST API Reference for UpgradeDomain Operation</seealso>
        UpgradeDomainResponse EndUpgradeDomain(IAsyncResult asyncResult);

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Elasticsearch.Model;

namespace Amazon.Elasticsearch
{
    /// <summary>
    /// Interface for accessing Elasticsearch
    ///
    /// Amazon Elasticsearch Configuration Service 
    /// <para>
    /// Use the Amazon Elasticsearch Configuration API to create, configure, and manage Elasticsearch
    /// domains.
    /// </para>
    ///  
    /// <para>
    /// For sample code that uses the Configuration API, see the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-configuration-samples.html">Amazon
    /// Elasticsearch Service Developer Guide</a>. The guide also contains <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-request-signing.html">sample
    /// code for sending signed HTTP requests to the Elasticsearch APIs</a>.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticsearch-service-regions"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticsearch : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElasticsearchPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptInboundCrossClusterSearchConnection


        /// <summary>
        /// Allows the destination domain owner to accept an inbound cross-cluster search connection
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        AcceptInboundCrossClusterSearchConnectionResponse AcceptInboundCrossClusterSearchConnection(AcceptInboundCrossClusterSearchConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        IAsyncResult BeginAcceptInboundCrossClusterSearchConnection(AcceptInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  AcceptInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        AcceptInboundCrossClusterSearchConnectionResponse EndAcceptInboundCrossClusterSearchConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Attaches tags to an existing Elasticsearch domain. Tags are a set of case-sensitive
        /// key value pairs. An Elasticsearch domain may have up to 10 tags. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon Elasticsearch Service Domains for more information.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePackage


        /// <summary>
        /// Associates a package with an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        AssociatePackageResponse AssociatePackage(AssociatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        IAsyncResult BeginAssociatePackage(AssociatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePackage.</param>
        /// 
        /// <returns>Returns a  AssociatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        AssociatePackageResponse EndAssociatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeVpcEndpointAccess


        /// <summary>
        /// Provides access to an Amazon OpenSearch Service domain through the use of an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        AuthorizeVpcEndpointAccessResponse AuthorizeVpcEndpointAccess(AuthorizeVpcEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        IAsyncResult BeginAuthorizeVpcEndpointAccess(AuthorizeVpcEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        AuthorizeVpcEndpointAccessResponse EndAuthorizeVpcEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelElasticsearchServiceSoftwareUpdate


        /// <summary>
        /// Cancels a scheduled service software update for an Amazon ES domain. You can only
        /// perform this operation before the <code>AutomatedUpdateDate</code> and when the <code>UpdateStatus</code>
        /// is in the <code>PENDING_UPDATE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the CancelElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        CancelElasticsearchServiceSoftwareUpdateResponse CancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        IAsyncResult BeginCancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  CancelElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        CancelElasticsearchServiceSoftwareUpdateResponse EndCancelElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateElasticsearchDomain


        /// <summary>
        /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the CreateElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        IAsyncResult BeginCreateElasticsearchDomain(CreateElasticsearchDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  CreateElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        CreateElasticsearchDomainResponse EndCreateElasticsearchDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOutboundCrossClusterSearchConnection


        /// <summary>
        /// Creates a new cross-cluster search connection from a source domain to a destination
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        CreateOutboundCrossClusterSearchConnectionResponse CreateOutboundCrossClusterSearchConnection(CreateOutboundCrossClusterSearchConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        IAsyncResult BeginCreateOutboundCrossClusterSearchConnection(CreateOutboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  CreateOutboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        CreateOutboundCrossClusterSearchConnectionResponse EndCreateOutboundCrossClusterSearchConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePackage


        /// <summary>
        /// Create a package for use with Amazon ES domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        CreatePackageResponse CreatePackage(CreatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        IAsyncResult BeginCreatePackage(CreatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackage.</param>
        /// 
        /// <returns>Returns a  CreatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        CreatePackageResponse EndCreatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcEndpoint


        /// <summary>
        /// Creates an Amazon OpenSearch Service-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteElasticsearchDomain


        /// <summary>
        /// Permanently deletes the specified Elasticsearch domain and all of its data. Once a
        /// domain is deleted, it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        IAsyncResult BeginDeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        DeleteElasticsearchDomainResponse EndDeleteElasticsearchDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteElasticsearchServiceRole


        /// <summary>
        /// Deletes the service-linked role that Elasticsearch Service uses to manage and maintain
        /// VPC domains. Role deletion will fail if any existing VPC domains use the role. You
        /// must delete any such Elasticsearch domains before deleting the role. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-enabling-slr"
        /// target="_blank">Deleting Elasticsearch Service Role</a> in <i>VPC Endpoints for Amazon
        /// Elasticsearch Service Domains</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchServiceRole service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        DeleteElasticsearchServiceRoleResponse DeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchServiceRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        IAsyncResult BeginDeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchServiceRole.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchServiceRoleResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        DeleteElasticsearchServiceRoleResponse EndDeleteElasticsearchServiceRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInboundCrossClusterSearchConnection


        /// <summary>
        /// Allows the destination domain owner to delete an existing inbound cross-cluster search
        /// connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        DeleteInboundCrossClusterSearchConnectionResponse DeleteInboundCrossClusterSearchConnection(DeleteInboundCrossClusterSearchConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        IAsyncResult BeginDeleteInboundCrossClusterSearchConnection(DeleteInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  DeleteInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        DeleteInboundCrossClusterSearchConnectionResponse EndDeleteInboundCrossClusterSearchConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOutboundCrossClusterSearchConnection


        /// <summary>
        /// Allows the source domain owner to delete an existing outbound cross-cluster search
        /// connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        DeleteOutboundCrossClusterSearchConnectionResponse DeleteOutboundCrossClusterSearchConnection(DeleteOutboundCrossClusterSearchConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        IAsyncResult BeginDeleteOutboundCrossClusterSearchConnection(DeleteOutboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  DeleteOutboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        DeleteOutboundCrossClusterSearchConnectionResponse EndDeleteOutboundCrossClusterSearchConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePackage


        /// <summary>
        /// Delete the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse DeletePackage(DeletePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        IAsyncResult BeginDeletePackage(DeletePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackage.</param>
        /// 
        /// <returns>Returns a  DeletePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse EndDeletePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcEndpoint


        /// <summary>
        /// Deletes an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        IAsyncResult BeginDeleteVpcEndpoint(DeleteVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        DeleteVpcEndpointResponse EndDeleteVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainAutoTunes


        /// <summary>
        /// Provides scheduled Auto-Tune action details for the Elasticsearch domain, such as
        /// Auto-Tune action type, description, severity, and scheduled date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainAutoTunes service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        DescribeDomainAutoTunesResponse DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainAutoTunes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        IAsyncResult BeginDescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainAutoTunes.</param>
        /// 
        /// <returns>Returns a  DescribeDomainAutoTunesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        DescribeDomainAutoTunesResponse EndDescribeDomainAutoTunes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainChangeProgress


        /// <summary>
        /// Returns information about the current blue/green deployment happening on a domain,
        /// including a change ID, status, and progress stages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainChangeProgress service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        DescribeDomainChangeProgressResponse DescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainChangeProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        IAsyncResult BeginDescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainChangeProgress.</param>
        /// 
        /// <returns>Returns a  DescribeDomainChangeProgressResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        DescribeDomainChangeProgressResponse EndDescribeDomainChangeProgress(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticsearchDomain


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domain,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        IAsyncResult BeginDescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        DescribeElasticsearchDomainResponse EndDescribeElasticsearchDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticsearchDomainConfig


        /// <summary>
        /// Provides cluster configuration information about the specified Elasticsearch domain,
        /// such as the state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        IAsyncResult BeginDescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainConfigResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        DescribeElasticsearchDomainConfigResponse EndDescribeElasticsearchDomainConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticsearchDomains


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domains,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomains service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        IAsyncResult BeginDescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomains.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        DescribeElasticsearchDomainsResponse EndDescribeElasticsearchDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticsearchInstanceTypeLimits


        /// <summary>
        /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
        /// When modifying existing Domain, specify the <code> <a>DomainName</a> </code> to know
        /// what Limits are supported for modifying.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchInstanceTypeLimits service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        DescribeElasticsearchInstanceTypeLimitsResponse DescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchInstanceTypeLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        IAsyncResult BeginDescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchInstanceTypeLimits.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchInstanceTypeLimitsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        DescribeElasticsearchInstanceTypeLimitsResponse EndDescribeElasticsearchInstanceTypeLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInboundCrossClusterSearchConnections


        /// <summary>
        /// Lists all the inbound cross-cluster search connections for a destination domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundCrossClusterSearchConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeInboundCrossClusterSearchConnections service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        DescribeInboundCrossClusterSearchConnectionsResponse DescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundCrossClusterSearchConnections operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInboundCrossClusterSearchConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        IAsyncResult BeginDescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInboundCrossClusterSearchConnections.</param>
        /// 
        /// <returns>Returns a  DescribeInboundCrossClusterSearchConnectionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        DescribeInboundCrossClusterSearchConnectionsResponse EndDescribeInboundCrossClusterSearchConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOutboundCrossClusterSearchConnections


        /// <summary>
        /// Lists all the outbound cross-cluster search connections for a source domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundCrossClusterSearchConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeOutboundCrossClusterSearchConnections service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        DescribeOutboundCrossClusterSearchConnectionsResponse DescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOutboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundCrossClusterSearchConnections operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOutboundCrossClusterSearchConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        IAsyncResult BeginDescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOutboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOutboundCrossClusterSearchConnections.</param>
        /// 
        /// <returns>Returns a  DescribeOutboundCrossClusterSearchConnectionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        DescribeOutboundCrossClusterSearchConnectionsResponse EndDescribeOutboundCrossClusterSearchConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePackages


        /// <summary>
        /// Describes all packages available to Amazon ES. Includes options for filtering, limiting
        /// the number of results, and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        DescribePackagesResponse DescribePackages(DescribePackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        IAsyncResult BeginDescribePackages(DescribePackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackages.</param>
        /// 
        /// <returns>Returns a  DescribePackagesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        DescribePackagesResponse EndDescribePackages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedElasticsearchInstanceOfferings


        /// <summary>
        /// Lists available reserved Elasticsearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstanceOfferings service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        DescribeReservedElasticsearchInstanceOfferingsResponse DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstanceOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        IAsyncResult BeginDescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstanceOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstanceOfferingsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        DescribeReservedElasticsearchInstanceOfferingsResponse EndDescribeReservedElasticsearchInstanceOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedElasticsearchInstances


        /// <summary>
        /// Returns information about reserved Elasticsearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstances service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        DescribeReservedElasticsearchInstancesResponse DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        IAsyncResult BeginDescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstancesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        DescribeReservedElasticsearchInstancesResponse EndDescribeReservedElasticsearchInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpoints


        /// <summary>
        /// Describes one or more Amazon OpenSearch Service-managed VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpoints(DescribeVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        DescribeVpcEndpointsResponse EndDescribeVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DissociatePackage


        /// <summary>
        /// Dissociates a package from the Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        DissociatePackageResponse DissociatePackage(DissociatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDissociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        IAsyncResult BeginDissociatePackage(DissociatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDissociatePackage.</param>
        /// 
        /// <returns>Returns a  DissociatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        DissociatePackageResponse EndDissociatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCompatibleElasticsearchVersions


        /// <summary>
        /// Returns a list of upgrade compatible Elastisearch versions. You can optionally pass
        /// a <code> <a>DomainName</a> </code> to get all upgrade compatible Elasticsearch versions
        /// for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        GetCompatibleElasticsearchVersionsResponse GetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleElasticsearchVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        IAsyncResult BeginGetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleElasticsearchVersionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        GetCompatibleElasticsearchVersionsResponse EndGetCompatibleElasticsearchVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPackageVersionHistory


        /// <summary>
        /// Returns a list of versions of the package, along with their creation time and commit
        /// message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        GetPackageVersionHistoryResponse GetPackageVersionHistory(GetPackageVersionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPackageVersionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        IAsyncResult BeginGetPackageVersionHistory(GetPackageVersionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPackageVersionHistory.</param>
        /// 
        /// <returns>Returns a  GetPackageVersionHistoryResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        GetPackageVersionHistoryResponse EndGetPackageVersionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUpgradeHistory


        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades that were performed on the
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        IAsyncResult BeginGetUpgradeHistory(GetUpgradeHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeHistory.</param>
        /// 
        /// <returns>Returns a  GetUpgradeHistoryResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        GetUpgradeHistoryResponse EndGetUpgradeHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUpgradeStatus


        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check that
        /// was performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        IAsyncResult BeginGetUpgradeStatus(GetUpgradeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeStatus.</param>
        /// 
        /// <returns>Returns a  GetUpgradeStatusResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        GetUpgradeStatusResponse EndGetUpgradeStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainNames


        /// <summary>
        /// Returns the name of all Elasticsearch domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainsForPackage


        /// <summary>
        /// Lists all Amazon ES domains associated with the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        ListDomainsForPackageResponse ListDomainsForPackage(ListDomainsForPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainsForPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        IAsyncResult BeginListDomainsForPackage(ListDomainsForPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainsForPackage.</param>
        /// 
        /// <returns>Returns a  ListDomainsForPackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        ListDomainsForPackageResponse EndListDomainsForPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListElasticsearchInstanceTypes


        /// <summary>
        /// List all Elasticsearch instance types that are supported for given ElasticsearchVersion
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchInstanceTypes service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        ListElasticsearchInstanceTypesResponse ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        IAsyncResult BeginListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchInstanceTypesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        ListElasticsearchInstanceTypesResponse EndListElasticsearchInstanceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListElasticsearchVersions


        /// <summary>
        /// List all supported Elasticsearch versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        ListElasticsearchVersionsResponse ListElasticsearchVersions(ListElasticsearchVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        IAsyncResult BeginListElasticsearchVersions(ListElasticsearchVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchVersionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        ListElasticsearchVersionsResponse EndListElasticsearchVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPackagesForDomain


        /// <summary>
        /// Lists all packages associated with the Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        ListPackagesForDomainResponse ListPackagesForDomain(ListPackagesForDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackagesForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        IAsyncResult BeginListPackagesForDomain(ListPackagesForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackagesForDomain.</param>
        /// 
        /// <returns>Returns a  ListPackagesForDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        ListPackagesForDomainResponse EndListPackagesForDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns all tags for the given Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcEndpointAccess


        /// <summary>
        /// Retrieves information about each principal that is allowed to access a given Amazon
        /// OpenSearch Service domain through the use of an interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        ListVpcEndpointAccessResponse ListVpcEndpointAccess(ListVpcEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        IAsyncResult BeginListVpcEndpointAccess(ListVpcEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        ListVpcEndpointAccessResponse EndListVpcEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcEndpoints


        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints in the current account
        /// and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        IAsyncResult BeginListVpcEndpoints(ListVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        ListVpcEndpointsResponse EndListVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcEndpointsForDomain


        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints associated with a particular
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpointsForDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        ListVpcEndpointsForDomainResponse ListVpcEndpointsForDomain(ListVpcEndpointsForDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpointsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpointsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        IAsyncResult BeginListVpcEndpointsForDomain(ListVpcEndpointsForDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpointsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpointsForDomain.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointsForDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        ListVpcEndpointsForDomainResponse EndListVpcEndpointsForDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedElasticsearchInstanceOffering


        /// <summary>
        /// Allows you to purchase reserved Elasticsearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedElasticsearchInstanceOffering service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        PurchaseReservedElasticsearchInstanceOfferingResponse PurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedElasticsearchInstanceOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        IAsyncResult BeginPurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedElasticsearchInstanceOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedElasticsearchInstanceOfferingResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        PurchaseReservedElasticsearchInstanceOfferingResponse EndPurchaseReservedElasticsearchInstanceOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectInboundCrossClusterSearchConnection


        /// <summary>
        /// Allows the destination domain owner to reject an inbound cross-cluster search connection
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the RejectInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        RejectInboundCrossClusterSearchConnectionResponse RejectInboundCrossClusterSearchConnection(RejectInboundCrossClusterSearchConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        IAsyncResult BeginRejectInboundCrossClusterSearchConnection(RejectInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  RejectInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        RejectInboundCrossClusterSearchConnectionResponse EndRejectInboundCrossClusterSearchConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified set of tags from the specified Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeVpcEndpointAccess


        /// <summary>
        /// Revokes access to an Amazon OpenSearch Service domain that was provided through an
        /// interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        RevokeVpcEndpointAccessResponse RevokeVpcEndpointAccess(RevokeVpcEndpointAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        IAsyncResult BeginRevokeVpcEndpointAccess(RevokeVpcEndpointAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  RevokeVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        RevokeVpcEndpointAccessResponse EndRevokeVpcEndpointAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  StartElasticsearchServiceSoftwareUpdate


        /// <summary>
        /// Schedules a service software update for an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the StartElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        StartElasticsearchServiceSoftwareUpdateResponse StartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        IAsyncResult BeginStartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  StartElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        StartElasticsearchServiceSoftwareUpdateResponse EndStartElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateElasticsearchDomainConfig


        /// <summary>
        /// Modifies the cluster configuration of the specified Elasticsearch domain, setting
        /// as setting the instance type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticsearchDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        IAsyncResult BeginUpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  UpdateElasticsearchDomainConfigResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        UpdateElasticsearchDomainConfigResponse EndUpdateElasticsearchDomainConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePackage


        /// <summary>
        /// Updates a package for use with Amazon ES domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        UpdatePackageResponse UpdatePackage(UpdatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        IAsyncResult BeginUpdatePackage(UpdatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePackage.</param>
        /// 
        /// <returns>Returns a  UpdatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        UpdatePackageResponse EndUpdatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVpcEndpoint


        /// <summary>
        /// Modifies an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        UpdateVpcEndpointResponse UpdateVpcEndpoint(UpdateVpcEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        IAsyncResult BeginUpdateVpcEndpoint(UpdateVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        UpdateVpcEndpointResponse EndUpdateVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpgradeElasticsearchDomain


        /// <summary>
        /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
        /// a compatible Elasticsearch version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the UpgradeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        UpgradeElasticsearchDomainResponse UpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        IAsyncResult BeginUpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  UpgradeElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        UpgradeElasticsearchDomainResponse EndUpgradeElasticsearchDomain(IAsyncResult asyncResult);

        #endregion
        
    }
}
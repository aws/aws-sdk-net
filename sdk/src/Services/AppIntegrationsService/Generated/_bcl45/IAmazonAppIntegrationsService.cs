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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppIntegrationsService.Model;

#pragma warning disable CS1570
namespace Amazon.AppIntegrationsService
{
    /// <summary>
    /// <para>Interface for accessing AppIntegrationsService</para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_AppIntegrations_Service.html">Amazon
    /// AppIntegrations actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_AppIntegrations_Service.html">Amazon
    /// AppIntegrations data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The Amazon AppIntegrations service enables you to configure and reuse connections
    /// to external applications.
    /// </para>
    ///  
    /// <para>
    /// For information about how you can use external applications with Amazon Connect, see
    /// the following topics in the <i>Amazon Connect Administrator Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/3p-apps.html">Third-party
    /// applications (3p apps) in the agent workspace</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-q-connect.html">Use
    /// Amazon Q in Connect for generative AI–powered agent assistance in real-time</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonAppIntegrationsService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppIntegrationsServicePaginatorFactory Paginators { get; }

        
        #region  CreateApplication


        /// <summary>
        /// Creates and persists an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);



        /// <summary>
        /// Creates and persists an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataIntegration


        /// <summary>
        /// Creates and persists a DataIntegration resource.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <c>CreateDataIntegration</c> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        CreateDataIntegrationResponse CreateDataIntegration(CreateDataIntegrationRequest request);



        /// <summary>
        /// Creates and persists a DataIntegration resource.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <c>CreateDataIntegration</c> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        Task<CreateDataIntegrationResponse> CreateDataIntegrationAsync(CreateDataIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataIntegrationAssociation


        /// <summary>
        /// Creates and persists a DataIntegrationAssociation resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDataIntegrationAssociation service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegrationAssociation">REST API Reference for CreateDataIntegrationAssociation Operation</seealso>
        CreateDataIntegrationAssociationResponse CreateDataIntegrationAssociation(CreateDataIntegrationAssociationRequest request);



        /// <summary>
        /// Creates and persists a DataIntegrationAssociation resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataIntegrationAssociation service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegrationAssociation">REST API Reference for CreateDataIntegrationAssociation Operation</seealso>
        Task<CreateDataIntegrationAssociationResponse> CreateDataIntegrationAssociationAsync(CreateDataIntegrationAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventIntegration


        /// <summary>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon EventBridge bus in your account and a partner event source that pushes
        /// events to that bus. No objects are created in the your account, only metadata that
        /// is persisted on the EventIntegration control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        CreateEventIntegrationResponse CreateEventIntegration(CreateEventIntegrationRequest request);



        /// <summary>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon EventBridge bus in your account and a partner event source that pushes
        /// events to that bus. No objects are created in the your account, only metadata that
        /// is persisted on the EventIntegration control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        Task<CreateEventIntegrationResponse> CreateEventIntegrationAsync(CreateEventIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the Application. Only Applications that don't have any Application Associations
        /// can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);



        /// <summary>
        /// Deletes the Application. Only Applications that don't have any Application Associations
        /// can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataIntegration


        /// <summary>
        /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
        /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
        /// flow and service linked role. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        DeleteDataIntegrationResponse DeleteDataIntegration(DeleteDataIntegrationRequest request);



        /// <summary>
        /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
        /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
        /// flow and service linked role. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        Task<DeleteDataIntegrationResponse> DeleteDataIntegrationAsync(DeleteDataIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventIntegration


        /// <summary>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        DeleteEventIntegrationResponse DeleteEventIntegration(DeleteEventIntegrationRequest request);



        /// <summary>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        Task<DeleteEventIntegrationResponse> DeleteEventIntegrationAsync(DeleteEventIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Get an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);



        /// <summary>
        /// Get an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataIntegration


        /// <summary>
        /// Returns information about the DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        GetDataIntegrationResponse GetDataIntegration(GetDataIntegrationRequest request);



        /// <summary>
        /// Returns information about the DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        Task<GetDataIntegrationResponse> GetDataIntegrationAsync(GetDataIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEventIntegration


        /// <summary>
        /// Returns information about the event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        GetEventIntegrationResponse GetEventIntegration(GetEventIntegrationRequest request);



        /// <summary>
        /// Returns information about the event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        Task<GetEventIntegrationResponse> GetEventIntegrationAsync(GetEventIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplicationAssociations


        /// <summary>
        /// Returns a paginated list of application associations for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListApplicationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListApplicationAssociations">REST API Reference for ListApplicationAssociations Operation</seealso>
        ListApplicationAssociationsResponse ListApplicationAssociations(ListApplicationAssociationsRequest request);



        /// <summary>
        /// Returns a paginated list of application associations for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListApplicationAssociations">REST API Reference for ListApplicationAssociations Operation</seealso>
        Task<ListApplicationAssociationsResponse> ListApplicationAssociationsAsync(ListApplicationAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists applications in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



        /// <summary>
        /// Lists applications in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of DataIntegration associations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        ListDataIntegrationAssociationsResponse ListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request);



        /// <summary>
        /// Returns a paginated list of DataIntegration associations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        Task<ListDataIntegrationAssociationsResponse> ListDataIntegrationAssociationsAsync(ListDataIntegrationAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataIntegrations


        /// <summary>
        /// Returns a paginated list of DataIntegrations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        ListDataIntegrationsResponse ListDataIntegrations(ListDataIntegrationsRequest request);



        /// <summary>
        /// Returns a paginated list of DataIntegrations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        Task<ListDataIntegrationsResponse> ListDataIntegrationsAsync(ListDataIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of event integration associations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        ListEventIntegrationAssociationsResponse ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request);



        /// <summary>
        /// Returns a paginated list of event integration associations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        Task<ListEventIntegrationAssociationsResponse> ListEventIntegrationAssociationsAsync(ListEventIntegrationAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEventIntegrations


        /// <summary>
        /// Returns a paginated list of event integrations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        ListEventIntegrationsResponse ListEventIntegrations(ListEventIntegrationsRequest request);



        /// <summary>
        /// Returns a paginated list of event integrations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        Task<ListEventIntegrationsResponse> ListEventIntegrationsAsync(ListEventIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates and persists an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);



        /// <summary>
        /// Updates and persists an Application resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.UnsupportedOperationException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataIntegration


        /// <summary>
        /// Updates the description of a DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        UpdateDataIntegrationResponse UpdateDataIntegration(UpdateDataIntegrationRequest request);



        /// <summary>
        /// Updates the description of a DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        Task<UpdateDataIntegrationResponse> UpdateDataIntegrationAsync(UpdateDataIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataIntegrationAssociation


        /// <summary>
        /// Updates and persists a DataIntegrationAssociation resource.
        /// 
        ///  <note> 
        /// <para>
        ///  Updating a DataIntegrationAssociation with ExecutionConfiguration will rerun the
        /// on-demand job. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDataIntegrationAssociation service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegrationAssociation">REST API Reference for UpdateDataIntegrationAssociation Operation</seealso>
        UpdateDataIntegrationAssociationResponse UpdateDataIntegrationAssociation(UpdateDataIntegrationAssociationRequest request);



        /// <summary>
        /// Updates and persists a DataIntegrationAssociation resource.
        /// 
        ///  <note> 
        /// <para>
        ///  Updating a DataIntegrationAssociation with ExecutionConfiguration will rerun the
        /// on-demand job. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataIntegrationAssociation service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegrationAssociation">REST API Reference for UpdateDataIntegrationAssociation Operation</seealso>
        Task<UpdateDataIntegrationAssociationResponse> UpdateDataIntegrationAssociationAsync(UpdateDataIntegrationAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventIntegration


        /// <summary>
        /// Updates the description of an event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        UpdateEventIntegrationResponse UpdateEventIntegration(UpdateEventIntegrationRequest request);



        /// <summary>
        /// Updates the description of an event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        Task<UpdateEventIntegrationResponse> UpdateEventIntegrationAsync(UpdateEventIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
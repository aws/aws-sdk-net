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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMQuickSetup.Model;

#pragma warning disable CS1570
namespace Amazon.SSMQuickSetup
{
    /// <summary>
    /// <para>Interface for accessing SSMQuickSetup</para>
    ///
    /// Quick Setup helps you quickly configure frequently used services and features with
    /// recommended best practices. Quick Setup simplifies setting up services, including
    /// Systems Manager, by automating common or recommended tasks.
    /// </summary>
    public partial interface IAmazonSSMQuickSetup : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMQuickSetupPaginatorFactory Paginators { get; }

        
        #region  CreateConfigurationManager


        /// <summary>
        /// Creates a Quick Setup configuration manager resource. This object is a collection
        /// of desired state configurations for multiple configuration definitions and summaries
        /// describing the deployments of those definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        CreateConfigurationManagerResponse CreateConfigurationManager(CreateConfigurationManagerRequest request);



        /// <summary>
        /// Creates a Quick Setup configuration manager resource. This object is a collection
        /// of desired state configurations for multiple configuration definitions and summaries
        /// describing the deployments of those definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        Task<CreateConfigurationManagerResponse> CreateConfigurationManagerAsync(CreateConfigurationManagerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationManager


        /// <summary>
        /// Deletes a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        DeleteConfigurationManagerResponse DeleteConfigurationManager(DeleteConfigurationManagerRequest request);



        /// <summary>
        /// Deletes a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        Task<DeleteConfigurationManagerResponse> DeleteConfigurationManagerAsync(DeleteConfigurationManagerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfiguration


        /// <summary>
        /// Returns details about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse GetConfiguration(GetConfigurationRequest request);



        /// <summary>
        /// Returns details about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfigurationManager


        /// <summary>
        /// Returns a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        GetConfigurationManagerResponse GetConfigurationManager(GetConfigurationManagerRequest request);



        /// <summary>
        /// Returns a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        Task<GetConfigurationManagerResponse> GetConfigurationManagerAsync(GetConfigurationManagerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Returns settings configured for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);



        /// <summary>
        /// Returns settings configured for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurationManagers


        /// <summary>
        /// Returns Quick Setup configuration managers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationManagers service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        ListConfigurationManagersResponse ListConfigurationManagers(ListConfigurationManagersRequest request);



        /// <summary>
        /// Returns Quick Setup configuration managers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationManagers service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        Task<ListConfigurationManagersResponse> ListConfigurationManagersAsync(ListConfigurationManagersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Returns configurations deployed by Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);



        /// <summary>
        /// Returns configurations deployed by Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQuickSetupTypes


        /// <summary>
        /// Returns the available Quick Setup types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes service method.</param>
        /// 
        /// <returns>The response from the ListQuickSetupTypes service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        ListQuickSetupTypesResponse ListQuickSetupTypes(ListQuickSetupTypesRequest request);



        /// <summary>
        /// Returns the available Quick Setup types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuickSetupTypes service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        Task<ListQuickSetupTypesResponse> ListQuickSetupTypesAsync(ListQuickSetupTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns key-value pairs of metadata to Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns key-value pairs of metadata to Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationDefinition


        /// <summary>
        /// Updates a Quick Setup configuration definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationDefinition service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        UpdateConfigurationDefinitionResponse UpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request);



        /// <summary>
        /// Updates a Quick Setup configuration definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationDefinition service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        Task<UpdateConfigurationDefinitionResponse> UpdateConfigurationDefinitionAsync(UpdateConfigurationDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfigurationManager


        /// <summary>
        /// Updates a Quick Setup configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        UpdateConfigurationManagerResponse UpdateConfigurationManager(UpdateConfigurationManagerRequest request);



        /// <summary>
        /// Updates a Quick Setup configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        Task<UpdateConfigurationManagerResponse> UpdateConfigurationManagerAsync(UpdateConfigurationManagerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates settings configured for Quick Setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);



        /// <summary>
        /// Updates settings configured for Quick Setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
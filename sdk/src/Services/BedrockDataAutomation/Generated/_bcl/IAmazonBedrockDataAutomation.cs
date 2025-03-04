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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockDataAutomation.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomation
{
    /// <summary>
    /// <para>Interface for accessing BedrockDataAutomation</para>
    ///
    /// Amazon Bedrock Data Automation BuildTime
    /// </summary>
    public partial interface IAmazonBedrockDataAutomation : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockDataAutomationPaginatorFactory Paginators { get; }

        
        #region  CreateBlueprint


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request);



        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        Task<CreateBlueprintResponse> CreateBlueprintAsync(CreateBlueprintRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBlueprintVersion


        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprintVersion service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        CreateBlueprintVersionResponse CreateBlueprintVersion(CreateBlueprintVersionRequest request);



        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBlueprintVersion service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        Task<CreateBlueprintVersionResponse> CreateBlueprintVersionAsync(CreateBlueprintVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataAutomationProject


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the CreateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        CreateDataAutomationProjectResponse CreateDataAutomationProject(CreateDataAutomationProjectRequest request);



        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        Task<CreateDataAutomationProjectResponse> CreateDataAutomationProjectAsync(CreateDataAutomationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBlueprint


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request);



        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        Task<DeleteBlueprintResponse> DeleteBlueprintAsync(DeleteBlueprintRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataAutomationProject


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the DeleteDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        DeleteDataAutomationProjectResponse DeleteDataAutomationProject(DeleteDataAutomationProjectRequest request);



        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        Task<DeleteDataAutomationProjectResponse> DeleteDataAutomationProjectAsync(DeleteDataAutomationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBlueprint


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        GetBlueprintResponse GetBlueprint(GetBlueprintRequest request);



        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        Task<GetBlueprintResponse> GetBlueprintAsync(GetBlueprintRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataAutomationProject


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the GetDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        GetDataAutomationProjectResponse GetDataAutomationProject(GetDataAutomationProjectRequest request);



        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        Task<GetDataAutomationProjectResponse> GetDataAutomationProjectAsync(GetDataAutomationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBlueprints


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request);



        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        Task<ListBlueprintsResponse> ListBlueprintsAsync(ListBlueprintsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataAutomationProjects


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
        /// 
        /// <returns>The response from the ListDataAutomationProjects service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        ListDataAutomationProjectsResponse ListDataAutomationProjects(ListDataAutomationProjectsRequest request);



        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataAutomationProjects service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        Task<ListDataAutomationProjectsResponse> ListDataAutomationProjectsAsync(ListDataAutomationProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBlueprint


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request);



        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        Task<UpdateBlueprintResponse> UpdateBlueprintAsync(UpdateBlueprintRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataAutomationProject


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the UpdateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        UpdateDataAutomationProjectResponse UpdateDataAutomationProject(UpdateDataAutomationProjectRequest request);



        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        Task<UpdateDataAutomationProjectResponse> UpdateDataAutomationProjectAsync(UpdateDataAutomationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
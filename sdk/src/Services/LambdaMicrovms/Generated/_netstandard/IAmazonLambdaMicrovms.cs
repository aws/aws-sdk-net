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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LambdaMicrovms.Model;

#pragma warning disable CS1570
namespace Amazon.LambdaMicrovms
{
    /// <summary>
    /// <para>Interface for accessing LambdaMicrovms</para>
    ///
    /// Provides APIs to create, manage, and operate AWS Lambda MicroVMs and their associated
    /// MicroVM Image environments.
    /// </summary>
    public partial interface IAmazonLambdaMicrovms : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILambdaMicrovmsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateMicrovmAuthToken



        /// <summary>
        /// Creates an authentication token for accessing a running MicroVM. The token grants
        /// access to the specified ports on the MicroVM endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmAuthToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmAuthToken service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmAuthToken">REST API Reference for CreateMicrovmAuthToken Operation</seealso>
        Task<CreateMicrovmAuthTokenResponse> CreateMicrovmAuthTokenAsync(CreateMicrovmAuthTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMicrovmImage



        /// <summary>
        /// Creates a MicroVM image from the specified code artifact and base image. The build
        /// is asynchronous — the image transitions from CREATING to CREATED on success, or CREATE_FAILED
        /// on failure. Use GetMicrovmImage to poll for completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmImage">REST API Reference for CreateMicrovmImage Operation</seealso>
        Task<CreateMicrovmImageResponse> CreateMicrovmImageAsync(CreateMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMicrovmShellAuthToken



        /// <summary>
        /// Creates a shell authentication token for interactive shell access to a running MicroVM.
        /// The MicroVM must have been run with the SHELL_INGRESS network connector attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrovmShellAuthToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrovmShellAuthToken service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/CreateMicrovmShellAuthToken">REST API Reference for CreateMicrovmShellAuthToken Operation</seealso>
        Task<CreateMicrovmShellAuthTokenResponse> CreateMicrovmShellAuthTokenAsync(CreateMicrovmShellAuthTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMicrovmImage



        /// <summary>
        /// Deletes a MicroVM image. This operation is idempotent; deleting an image that has
        /// already been deleted succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/DeleteMicrovmImage">REST API Reference for DeleteMicrovmImage Operation</seealso>
        Task<DeleteMicrovmImageResponse> DeleteMicrovmImageAsync(DeleteMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMicrovmImageVersion



        /// <summary>
        /// Deletes a specific version of a MicroVM image. This operation is idempotent; deleting
        /// a version that has already been deleted succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/DeleteMicrovmImageVersion">REST API Reference for DeleteMicrovmImageVersion Operation</seealso>
        Task<DeleteMicrovmImageVersionResponse> DeleteMicrovmImageVersionAsync(DeleteMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMicrovm



        /// <summary>
        /// Retrieves the details of a specific MicroVM, including its state, endpoint, image
        /// information, and configuration. The state field is eventually consistent — determine
        /// readiness by connecting to the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovm">REST API Reference for GetMicrovm Operation</seealso>
        Task<GetMicrovmResponse> GetMicrovmAsync(GetMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMicrovmImage



        /// <summary>
        /// Retrieves the details of a MicroVM image, including its state, versions, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImage">REST API Reference for GetMicrovmImage Operation</seealso>
        Task<GetMicrovmImageResponse> GetMicrovmImageAsync(GetMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMicrovmImageBuild



        /// <summary>
        /// Retrieves the details of a specific MicroVM image build, including its state, target
        /// architecture, and snapshot information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImageBuild service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImageBuild service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImageBuild">REST API Reference for GetMicrovmImageBuild Operation</seealso>
        Task<GetMicrovmImageBuildResponse> GetMicrovmImageBuildAsync(GetMicrovmImageBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMicrovmImageVersion



        /// <summary>
        /// Retrieves the details of a specific version of a MicroVM image, including its configuration,
        /// state, and build information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/GetMicrovmImageVersion">REST API Reference for GetMicrovmImageVersion Operation</seealso>
        Task<GetMicrovmImageVersionResponse> GetMicrovmImageVersionAsync(GetMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedMicrovmImages



        /// <summary>
        /// Lists AWS managed MicroVM images available for use as base images. We recommend using
        /// pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedMicrovmImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedMicrovmImages service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListManagedMicrovmImages">REST API Reference for ListManagedMicrovmImages Operation</seealso>
        Task<ListManagedMicrovmImagesResponse> ListManagedMicrovmImagesAsync(ListManagedMicrovmImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedMicrovmImageVersions



        /// <summary>
        /// Lists versions of a managed MicroVM image. We recommend using pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedMicrovmImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedMicrovmImageVersions service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListManagedMicrovmImageVersions">REST API Reference for ListManagedMicrovmImageVersions Operation</seealso>
        Task<ListManagedMicrovmImageVersionsResponse> ListManagedMicrovmImageVersionsAsync(ListManagedMicrovmImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMicrovmImageBuilds



        /// <summary>
        /// Lists builds for a MicroVM image version with optional filtering by architecture and
        /// chipset. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImageBuilds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImageBuilds service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImageBuilds">REST API Reference for ListMicrovmImageBuilds Operation</seealso>
        Task<ListMicrovmImageBuildsResponse> ListMicrovmImageBuildsAsync(ListMicrovmImageBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMicrovmImages



        /// <summary>
        /// Lists MicroVM images in the account with optional name filtering. We recommend using
        /// pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImages service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImages">REST API Reference for ListMicrovmImages Operation</seealso>
        Task<ListMicrovmImagesResponse> ListMicrovmImagesAsync(ListMicrovmImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMicrovmImageVersions



        /// <summary>
        /// Lists versions of a MicroVM image. We recommend using pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovmImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovmImageVersions service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovmImageVersions">REST API Reference for ListMicrovmImageVersions Operation</seealso>
        Task<ListMicrovmImageVersionsResponse> ListMicrovmImageVersionsAsync(ListMicrovmImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMicrovms



        /// <summary>
        /// Lists MicroVMs in the account with optional filtering by image and version. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrovms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrovms service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListMicrovms">REST API Reference for ListMicrovms Operation</seealso>
        Task<ListMicrovmsResponse> ListMicrovmsAsync(ListMicrovmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Lists the tags associated with a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResumeMicrovm



        /// <summary>
        /// Resumes a suspended MicroVM, restoring it to RUNNING state with all state intact.
        /// The MicroVM must be in SUSPENDED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/ResumeMicrovm">REST API Reference for ResumeMicrovm Operation</seealso>
        Task<ResumeMicrovmResponse> ResumeMicrovmAsync(ResumeMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RunMicrovm



        /// <summary>
        /// Runs a new MicroVM from the specified image. The MicroVM starts in PENDING state and
        /// transitions to RUNNING once provisioning completes. To connect, generate an authentication
        /// token using CreateMicrovmAuthToken.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/RunMicrovm">REST API Reference for RunMicrovm Operation</seealso>
        Task<RunMicrovmResponse> RunMicrovmAsync(RunMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SuspendMicrovm



        /// <summary>
        /// Suspends a running MicroVM, preserving its full memory and disk state. The MicroVM
        /// transitions through SUSPENDING to SUSPENDED. To restore, call ResumeMicrovm or send
        /// traffic to the endpoint if autoResumeEnabled is true.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/SuspendMicrovm">REST API Reference for SuspendMicrovm Operation</seealso>
        Task<SuspendMicrovmResponse> SuspendMicrovmAsync(SuspendMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateMicrovm



        /// <summary>
        /// Terminates a MicroVM. This operation is idempotent; terminating a MicroVM that has
        /// already been terminated succeeds without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateMicrovm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateMicrovm service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/TerminateMicrovm">REST API Reference for TerminateMicrovm Operation</seealso>
        Task<TerminateMicrovmResponse> TerminateMicrovmAsync(TerminateMicrovmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a Lambda MicroVM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceException">
        /// The AWS Lambda MicroVMs service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. Retry the request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMicrovmImage



        /// <summary>
        /// Updates the configuration of a MicroVM image and triggers a new version build. This
        /// operation uses PUT semantics — all required fields (codeArtifact, baseImageArn, buildRoleArn)
        /// must be provided with every request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrovmImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrovmImage service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota for Lambda MicroVMs.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UpdateMicrovmImage">REST API Reference for UpdateMicrovmImage Operation</seealso>
        Task<UpdateMicrovmImageResponse> UpdateMicrovmImageAsync(UpdateMicrovmImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMicrovmImageVersion



        /// <summary>
        /// Updates the status of a specific MicroVM image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrovmImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrovmImageVersion service method, as returned by LambdaMicrovms.</returns>
        /// <exception cref="Amazon.LambdaMicrovms.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.InternalServerException">
        /// An internal server error occurred. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ThrottlingException">
        /// The request was denied due to request throttling. Retry the request later.
        /// </exception>
        /// <exception cref="Amazon.LambdaMicrovms.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-microvms-2025-09-09/UpdateMicrovmImageVersion">REST API Reference for UpdateMicrovmImageVersion Operation</seealso>
        Task<UpdateMicrovmImageVersionResponse> UpdateMicrovmImageVersionAsync(UpdateMicrovmImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonLambdaMicrovmsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonLambdaMicrovmsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonLambdaMicrovmsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonLambdaMicrovmsConfig to create AmazonLambdaMicrovmsClient");
            }

            return awsCredentials == null ? 
                    new AmazonLambdaMicrovmsClient(serviceClientConfig) :
                    new AmazonLambdaMicrovmsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
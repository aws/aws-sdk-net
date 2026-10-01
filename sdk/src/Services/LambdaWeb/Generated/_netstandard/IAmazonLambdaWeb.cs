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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LambdaWeb.Model;

#pragma warning disable CS1570
namespace Amazon.LambdaWeb
{
    /// <summary>
    /// <para>Interface for accessing LambdaWeb</para>
    ///
    /// AWS Lambda Web Functions let you run web applications and APIs as HTTP servers on
    /// Lambda. A web function has one or more immutable revisions (code and configuration)
    /// and one or more endpoints that expose it over HTTPS.
    /// </summary>
    public partial interface IAmazonLambdaWeb : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILambdaWebPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateWebFunction



        /// <summary>
        /// Creates a web function with an initial revision and endpoint. To create a web function,
        /// you provide the function name, revision configuration (code and service settings),
        /// and endpoint configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunction</c> permission on the
        /// web function. You don't need separate permissions for the initial revision or endpoint.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunction">REST API Reference for CreateWebFunction Operation</seealso>
        Task<CreateWebFunctionResponse> CreateWebFunctionAsync(CreateWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWebFunctionEndpoint



        /// <summary>
        /// Creates an endpoint for a web function. An endpoint exposes the web function over
        /// HTTPS and routes traffic to one or more revisions.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionEndpoint</c> permission
        /// on the web function, not on the endpoint being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionEndpoint">REST API Reference for CreateWebFunctionEndpoint Operation</seealso>
        Task<CreateWebFunctionEndpointResponse> CreateWebFunctionEndpointAsync(CreateWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWebFunctionRevision



        /// <summary>
        /// Creates an immutable revision for a web function. A revision represents a specific
        /// version of the function code and configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionRevision</c> permission
        /// on the web function, not on the revision being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionRevision">REST API Reference for CreateWebFunctionRevision Operation</seealso>
        Task<CreateWebFunctionRevisionResponse> CreateWebFunctionRevisionAsync(CreateWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourcePolicy



        /// <summary>
        /// Removes the resource-based policy from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWebFunction



        /// <summary>
        /// Deletes a web function and all of its associated revisions and endpoints.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>DeleteWebFunction</c> permission on the
        /// web function. You don't need the <c>DeleteWebFunctionRevision</c> or <c>DeleteWebFunctionEndpoint</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunction">REST API Reference for DeleteWebFunction Operation</seealso>
        Task<DeleteWebFunctionResponse> DeleteWebFunctionAsync(DeleteWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWebFunctionEndpoint



        /// <summary>
        /// Deletes a web function endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionEndpoint">REST API Reference for DeleteWebFunctionEndpoint Operation</seealso>
        Task<DeleteWebFunctionEndpointResponse> DeleteWebFunctionEndpointAsync(DeleteWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWebFunctionRevision



        /// <summary>
        /// Deletes a web function revision. You cannot delete a revision that is currently serving
        /// traffic on an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionRevision">REST API Reference for DeleteWebFunctionRevision Operation</seealso>
        Task<DeleteWebFunctionRevisionResponse> DeleteWebFunctionRevisionAsync(DeleteWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourcePolicy



        /// <summary>
        /// Retrieves the resource-based policy attached to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWebAccountSettings



        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        Task<GetWebAccountSettingsResponse> GetWebAccountSettingsAsync(GetWebAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWebFunction



        /// <summary>
        /// Retrieves details about a web function, including its current state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunction">REST API Reference for GetWebFunction Operation</seealso>
        Task<GetWebFunctionResponse> GetWebFunctionAsync(GetWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWebFunctionEndpoint



        /// <summary>
        /// Retrieves details about a web function endpoint, including its current state, configuration,
        /// and domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionEndpoint">REST API Reference for GetWebFunctionEndpoint Operation</seealso>
        Task<GetWebFunctionEndpointResponse> GetWebFunctionEndpointAsync(GetWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWebFunctionRevision



        /// <summary>
        /// Retrieves details about a web function revision, including its state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionRevision">REST API Reference for GetWebFunctionRevision Operation</seealso>
        Task<GetWebFunctionRevisionResponse> GetWebFunctionRevisionAsync(GetWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Returns a list of tags applied to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWebFunctionEndpoints



        /// <summary>
        /// Lists endpoints for a web function. We recommend using pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctionEndpoints service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionEndpoints">REST API Reference for ListWebFunctionEndpoints Operation</seealso>
        Task<ListWebFunctionEndpointsResponse> ListWebFunctionEndpointsAsync(ListWebFunctionEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWebFunctionRevisions



        /// <summary>
        /// Lists revisions for a web function. We recommend using pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctionRevisions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionRevisions">REST API Reference for ListWebFunctionRevisions Operation</seealso>
        Task<ListWebFunctionRevisionsResponse> ListWebFunctionRevisionsAsync(ListWebFunctionRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWebFunctions



        /// <summary>
        /// Lists web functions in your account. We recommend using pagination to ensure that
        /// the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctions">REST API Reference for ListWebFunctions Operation</seealso>
        Task<ListWebFunctionsResponse> ListWebFunctionsAsync(ListWebFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourcePolicy



        /// <summary>
        /// Adds or updates a resource-based policy on a web function. A resource-based policy
        /// grants permissions to other AWS accounts or services to perform actions on the web
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a web function. If a tag key already exists, the existing value is overwritten
        /// with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWebFunctionEndpoint



        /// <summary>
        /// Updates the configuration of a web function endpoint. You can modify the authorization
        /// type, auto-deployment mode, revision weights, scaling, and throttling settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. Resolve the conflict
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded. Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was throttled. Reduce the frequency of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UpdateWebFunctionEndpoint">REST API Reference for UpdateWebFunctionEndpoint Operation</seealso>
        Task<UpdateWebFunctionEndpointResponse> UpdateWebFunctionEndpointAsync(UpdateWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonLambdaWebConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonLambdaWebConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonLambdaWebConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonLambdaWebConfig to create AmazonLambdaWebClient");
            }

            return awsCredentials == null ? 
                    new AmazonLambdaWebClient(serviceClientConfig) :
                    new AmazonLambdaWebClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
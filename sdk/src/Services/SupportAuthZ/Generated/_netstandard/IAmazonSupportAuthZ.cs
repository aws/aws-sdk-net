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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SupportAuthZ.Model;

#pragma warning disable CS1570
namespace Amazon.SupportAuthZ
{
    /// <summary>
    /// <para>Interface for accessing SupportAuthZ</para>
    ///
    /// AWS Support Authorization 
    /// <para>
    /// AWS SupportAuthZ enables you to control and authorize the actions that AWS support
    /// operators can perform on your resources. You create cryptographically signed support
    /// permits specifying which actions operators can perform, on which resources, and under
    /// what time-window conditions. Permits are signed using a customer-managed AWS KMS key
    /// (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonSupportAuthZ : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISupportAuthZPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateSupportPermit



        /// <summary>
        /// Creates a support permit that authorizes an AWS support operator to perform specified
        /// actions on specified resources. The permit is cryptographically signed using a customer-managed
        /// AWS KMS key (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/CreateSupportPermit">REST API Reference for CreateSupportPermit Operation</seealso>
        Task<CreateSupportPermitResponse> CreateSupportPermitAsync(CreateSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSupportPermit



        /// <summary>
        /// Deletes a support permit, revoking the authorization previously granted to the AWS
        /// support operator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/DeleteSupportPermit">REST API Reference for DeleteSupportPermit Operation</seealso>
        Task<DeleteSupportPermitResponse> DeleteSupportPermitAsync(DeleteSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAction



        /// <summary>
        /// Retrieves the description of a specific support action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetAction">REST API Reference for GetAction Operation</seealso>
        Task<GetActionResponse> GetActionAsync(GetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSupportPermit



        /// <summary>
        /// Retrieves the details of a support permit by its ARN or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetSupportPermit">REST API Reference for GetSupportPermit Operation</seealso>
        Task<GetSupportPermitResponse> GetSupportPermitAsync(GetSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActions



        /// <summary>
        /// Lists available support actions for a specified AWS service. Use pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListActions">REST API Reference for ListActions Operation</seealso>
        Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSupportPermitRequests



        /// <summary>
        /// Lists permit requests from AWS support operators. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermitRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportPermitRequests service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermitRequests">REST API Reference for ListSupportPermitRequests Operation</seealso>
        Task<ListSupportPermitRequestsResponse> ListSupportPermitRequestsAsync(ListSupportPermitRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSupportPermits



        /// <summary>
        /// Lists all support permits in the caller's account. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportPermits service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermits">REST API Reference for ListSupportPermits Operation</seealso>
        Task<ListSupportPermitsResponse> ListSupportPermitsAsync(ListSupportPermitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags associated with a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectSupportPermitRequest



        /// <summary>
        /// Rejects a permit request from an AWS support operator. The operator cannot proceed
        /// with the requested action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSupportPermitRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSupportPermitRequest service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/RejectSupportPermitRequest">REST API Reference for RejectSupportPermitRequest Operation</seealso>
        Task<RejectSupportPermitRequestResponse> RejectSupportPermitRequestAsync(RejectSupportPermitRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or overwrites one or more tags for a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSupportAuthZConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSupportAuthZConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSupportAuthZConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSupportAuthZConfig to create AmazonSupportAuthZClient");
            }

            return awsCredentials == null ? 
                    new AmazonSupportAuthZClient(serviceClientConfig) :
                    new AmazonSupportAuthZClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
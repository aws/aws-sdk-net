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
 * Do not modify this file. This file is generated from the account-access-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AccountAccess.Model;

#pragma warning disable CS1570
namespace Amazon.AccountAccess
{
    /// <summary>
    /// <para>Interface for accessing AccountAccess</para>
    ///
    /// Account access manager enables you to manage applications and entitlements that grant
    /// IAM Identity Center principals access to IAM roles across accounts.
    /// </summary>
    public partial interface IAmazonAccountAccess : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAccountAccessPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateApplication



        /// <summary>
        /// Creates an account access manager instance and its Amazon Web Services account access
        /// application in the associated IAM Identity Center instance. This operation is idempotent;
        /// calling it multiple times with the same parameters returns the existing application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.AlreadyCreatedException">
        /// The resource you are trying to create already exists. To retrieve the existing resource,
        /// use the corresponding Get operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEntitlement



        /// <summary>
        /// Creates an entitlement (assignment) in account access manager. An entitlement (assignment)
        /// grants a principal (IAM Identity Center user or group) permission to assume a specified
        /// IAM role in an Amazon Web Services account. This operation is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/CreateEntitlement">REST API Reference for CreateEntitlement Operation</seealso>
        Task<CreateEntitlementResponse> CreateEntitlementAsync(CreateEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes an account access manager application. This operation is idempotent; deleting
        /// an application that has already been deleted does not return an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEntitlement



        /// <summary>
        /// Deletes an entitlement from an account access manager application. This operation
        /// is idempotent; deleting an entitlement that has already been deleted does not return
        /// an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/DeleteEntitlement">REST API Reference for DeleteEntitlement Operation</seealso>
        Task<DeleteEntitlementResponse> DeleteEntitlementAsync(DeleteEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Retrieves details about an account access manager application, including its status,
        /// identity source, and tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEntitlement



        /// <summary>
        /// Retrieves details about a specific entitlement for an account access manager application,
        /// including the principal, IAM role, and target account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/GetEntitlement">REST API Reference for GetEntitlement Operation</seealso>
        Task<GetEntitlementResponse> GetEntitlementAsync(GetEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Lists the account access manager applications in your account. Use pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEntitlements



        /// <summary>
        /// Lists the entitlements for a specified account access manager application. You can
        /// filter results by principal, IAM role, or account. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        Task<ListEntitlementsResponse> ListEntitlementsAsync(ListEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags associated with an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAccountAccessConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAccountAccessConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAccountAccessConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAccountAccessConfig to create AmazonAccountAccessClient");
            }

            return awsCredentials == null ? 
                    new AmazonAccountAccessClient(serviceClientConfig) :
                    new AmazonAccountAccessClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
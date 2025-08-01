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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkspacesInstances.Model;

#pragma warning disable CS1570
namespace Amazon.WorkspacesInstances
{
    /// <summary>
    /// <para>Interface for accessing WorkspacesInstances</para>
    ///
    /// Amazon WorkSpaces Instances provides an API framework for managing virtual workspace
    /// environments across multiple AWS regions, enabling programmatic creation and configuration
    /// of desktop infrastructure.
    /// </summary>
    public partial interface IAmazonWorkspacesInstances : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkspacesInstancesPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateVolume



        /// <summary>
        /// Attaches a volume to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        Task<AssociateVolumeResponse> AssociateVolumeAsync(AssociateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVolume



        /// <summary>
        /// Creates a new volume for WorkSpace Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceInstance



        /// <summary>
        /// Launches a new WorkSpace Instance with specified configuration parameters, enabling
        /// programmatic workspace deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        Task<CreateWorkspaceInstanceResponse> CreateWorkspaceInstanceAsync(CreateWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVolume



        /// <summary>
        /// Deletes a specified volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceInstance



        /// <summary>
        /// Deletes the specified WorkSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        Task<DeleteWorkspaceInstanceResponse> DeleteWorkspaceInstanceAsync(DeleteWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateVolume



        /// <summary>
        /// Detaches a volume from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        Task<DisassociateVolumeResponse> DisassociateVolumeAsync(DisassociateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkspaceInstance



        /// <summary>
        /// Retrieves detailed information about a specific WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        Task<GetWorkspaceInstanceResponse> GetWorkspaceInstanceAsync(GetWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceTypes



        /// <summary>
        /// Retrieves a list of instance types supported by Amazon WorkSpaces Instances, enabling
        /// precise workspace infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceTypes service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        Task<ListInstanceTypesResponse> ListInstanceTypesAsync(ListInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRegions



        /// <summary>
        /// Retrieves a list of AWS regions supported by Amazon WorkSpaces Instances, enabling
        /// region discovery for workspace deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Retrieves tags for a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkspaceInstances



        /// <summary>
        /// Retrieves a collection of WorkSpaces Instances based on specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaceInstances service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        Task<ListWorkspaceInstancesResponse> ListWorkspaceInstancesAsync(ListWorkspaceInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonWorkspacesInstancesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonWorkspacesInstancesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonWorkspacesInstancesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonWorkspacesInstancesConfig to create AmazonWorkspacesInstancesClient");
            }

            return awsCredentials == null ? 
                    new AmazonWorkspacesInstancesClient(serviceClientConfig) :
                    new AmazonWorkspacesInstancesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
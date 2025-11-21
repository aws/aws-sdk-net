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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Evs.Model;

#pragma warning disable CS1570
namespace Amazon.Evs
{
    /// <summary>
    /// <para>Interface for accessing Evs</para>
    ///
    /// Amazon Elastic VMware Service (Amazon EVS) is a service that you can use to deploy
    /// a VMware Cloud Foundation (VCF) software environment directly on EC2 bare metal instances
    /// within an Amazon Virtual Private Cloud (VPC).
    /// 
    ///  
    /// <para>
    /// Workloads running on Amazon EVS are fully compatible with workloads running on any
    /// standard VMware vSphere environment. This means that you can migrate any VMware-based
    /// workload to Amazon EVS without workload modification.
    /// </para>
    /// </summary>
    public partial interface IAmazonEvs : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEvsPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateEipToVlan



        /// <summary>
        /// Associates an Elastic IP address with a public HCX VLAN. This operation is only allowed
        /// for public HCX VLANs at this time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEipToVlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEipToVlan service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ThrottlingException">
        /// The operation couldn't be performed because the service is throttling requests. This
        /// exception is thrown when there are too many requests accepted concurrently from the
        /// service endpoint.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/AssociateEipToVlan">REST API Reference for AssociateEipToVlan Operation</seealso>
        Task<AssociateEipToVlanResponse> AssociateEipToVlanAsync(AssociateEipToVlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironment



        /// <summary>
        /// Creates an Amazon EVS environment that runs VCF software, such as SDDC Manager, NSX
        /// Manager, and vCenter Server.
        /// 
        ///  
        /// <para>
        /// During environment creation, Amazon EVS performs validations on DNS settings, provisions
        /// VLAN subnets and hosts, and deploys the supplied version of VCF.
        /// </para>
        ///  
        /// <para>
        /// It can take several hours to create an environment. After the deployment completes,
        /// you can configure VCF in the vSphere user interface according to your needs.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
        /// in the same <c>CreateEnvironment</c> action. This results in a <c>ValidationException</c>
        /// response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironmentHost



        /// <summary>
        /// Creates an ESXi host and adds it to an Amazon EVS environment. Amazon EVS supports
        /// 4-16 hosts per environment.
        /// 
        ///  
        /// <para>
        /// This action can only be used after the Amazon EVS environment is deployed.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>dedicatedHostId</c> parameter to specify an Amazon EC2 Dedicated
        /// Host for ESXi host creation.
        /// </para>
        ///  
        /// <para>
        ///  You can use the <c>placementGroupId</c> parameter to specify a cluster or partition
        /// placement group to launch EC2 instances into.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
        /// in the same <c>CreateEnvironmentHost</c> action. This results in a <c>ValidationException</c>
        /// response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentHost service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ThrottlingException">
        /// The operation couldn't be performed because the service is throttling requests. This
        /// exception is thrown when there are too many requests accepted concurrently from the
        /// service endpoint.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/CreateEnvironmentHost">REST API Reference for CreateEnvironmentHost Operation</seealso>
        Task<CreateEnvironmentHostResponse> CreateEnvironmentHostAsync(CreateEnvironmentHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironment



        /// <summary>
        /// Deletes an Amazon EVS environment.
        /// 
        ///  
        /// <para>
        /// Amazon EVS environments will only be enabled for deletion once the hosts are deleted.
        /// You can delete hosts using the <c>DeleteEnvironmentHost</c> action.
        /// </para>
        ///  
        /// <para>
        /// Environment deletion also deletes the associated Amazon EVS VLAN subnets and Amazon
        /// Web Services Secrets Manager secrets that Amazon EVS created. Amazon Web Services
        /// resources that you create are not deleted. These resources may continue to incur costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironmentHost



        /// <summary>
        /// Deletes a host from an Amazon EVS environment.
        /// 
        ///  <note> 
        /// <para>
        /// Before deleting a host, you must unassign and decommission the host from within the
        /// SDDC Manager user interface. Not doing so could impact the availability of your virtual
        /// machines or result in data loss.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentHost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentHost service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DeleteEnvironmentHost">REST API Reference for DeleteEnvironmentHost Operation</seealso>
        Task<DeleteEnvironmentHostResponse> DeleteEnvironmentHostAsync(DeleteEnvironmentHostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateEipFromVlan



        /// <summary>
        /// Disassociates an Elastic IP address from a public HCX VLAN. This operation is only
        /// allowed for public HCX VLANs at this time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEipFromVlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEipFromVlan service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ThrottlingException">
        /// The operation couldn't be performed because the service is throttling requests. This
        /// exception is thrown when there are too many requests accepted concurrently from the
        /// service endpoint.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/DisassociateEipFromVlan">REST API Reference for DisassociateEipFromVlan Operation</seealso>
        Task<DisassociateEipFromVlanResponse> DisassociateEipFromVlanAsync(DisassociateEipFromVlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironment



        /// <summary>
        /// Returns a description of the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironmentHosts



        /// <summary>
        /// List the hosts within an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentHosts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentHosts service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentHosts">REST API Reference for ListEnvironmentHosts Operation</seealso>
        Task<ListEnvironmentHostsResponse> ListEnvironmentHostsAsync(ListEnvironmentHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironments



        /// <summary>
        /// Lists the Amazon EVS environments in your Amazon Web Services account in the specified
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironmentVlans



        /// <summary>
        /// Lists environment VLANs that are associated with the specified environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentVlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentVlans service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ValidationException">
        /// The input fails to satisfy the specified constraints. You will see this exception
        /// if invalid inputs are provided for any of the Amazon EVS environment operations, or
        /// if a list operation is performed on an environment resource that is still initializing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListEnvironmentVlans">REST API Reference for ListEnvironmentVlans Operation</seealso>
        Task<ListEnvironmentVlansResponse> ListEnvironmentVlansAsync(ListEnvironmentVlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for an Amazon EVS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associates the specified tags to an Amazon EVS resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted. Tags that you create for Amazon EVS resources don't propagate to any other
        /// resources associated with the environment. For example, if you tag an environment
        /// with this operation, that tag doesn't automatically propagate to the VLAN subnets
        /// and hosts associated with the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.ServiceQuotaExceededException">
        /// The number of one or more Amazon EVS resources exceeds the maximum allowed. For a
        /// list of Amazon EVS quotas, see <a href="https://docs.aws.amazon.com/evs/latest/userguide/service-quotas-evs.html">Amazon
        /// EVS endpoints and quotas</a> in the <i>Amazon EVS User Guide</i>. Delete some resources
        /// or request an increase in your service quota. To request an increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Web Services Service Quotas</a> in the <i>Amazon Web Services General Reference Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TagPolicyException">
        /// <note> 
        /// <para>
        ///  <c>TagPolicyException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ValidationException.html">
        /// <c>ValidationException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// The request doesn't comply with IAM tag policy. Correct your request and then retry
        /// it.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TooManyTagsException">
        /// <note> 
        /// <para>
        ///  <c>TooManyTagsException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ServiceQuotaExceededException.html">
        /// <c>ServiceQuotaExceededException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// A service resource associated with the request has more than 200 tags.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes specified tags from an Amazon EVS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Evs.</returns>
        /// <exception cref="Amazon.Evs.Model.ResourceNotFoundException">
        /// A service resource associated with the request could not be found. The resource might
        /// not be specified correctly, or it may have a <c>state</c> of <c>DELETED</c>.
        /// </exception>
        /// <exception cref="Amazon.Evs.Model.TagPolicyException">
        /// <note> 
        /// <para>
        ///  <c>TagPolicyException</c> is deprecated. See <a href="https://docs.aws.amazon.com/evs/latest/APIReference/API_ValidationException.html">
        /// <c>ValidationException</c> </a> instead.
        /// 
        ///  </note> 
        /// <para>
        /// The request doesn't comply with IAM tag policy. Correct your request and then retry
        /// it.
        /// </para>
        /// 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evs-2023-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonEvsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonEvsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonEvsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonEvsConfig to create AmazonEvsClient");
            }

            return awsCredentials == null ? 
                    new AmazonEvsClient(serviceClientConfig) :
                    new AmazonEvsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
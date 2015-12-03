/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// Elastic Load Balancing distributes incoming traffic across your EC2 instances.
    /// </para>
    ///  
    /// <para>
    /// For information about the features of Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elastic-load-balancing.html">What
    /// Is Elastic Load Balancing?</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about the AWS regions supported by Elastic Load Balancing, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Regions
    /// and Endpoints - Elastic Load Balancing</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are <i>idempotent</i>, which means that they
    /// complete at most one time. If you repeat an operation, it succeeds with a 200 OK response
    /// code.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticLoadBalancing : IDisposable
    {
                
        #region  AddTags


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApplySecurityGroupsToLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachLoadBalancerToSubnets


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConfigureHealthCheck


        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppCookieStickinessPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLBCookieStickinessPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoadBalancerListeners


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoadBalancerPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoadBalancerListeners


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoadBalancerPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterInstancesFromLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceHealth


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancerPolicies


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancerPolicyTypes


        /// <summary>
        /// Describes the specified load balancer policy types.
        /// 
        ///  
        /// <para>
        /// You can use these policy types with <a>CreateLoadBalancerPolicy</a> to create policy
        /// configurations for a load balancer.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachLoadBalancerFromSubnets


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterInstancesWithLoadBalancer


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTags


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetLoadBalancerListenerSSLCertificate


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetLoadBalancerPoliciesForBackendServer


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetLoadBalancerPoliciesOfListener


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
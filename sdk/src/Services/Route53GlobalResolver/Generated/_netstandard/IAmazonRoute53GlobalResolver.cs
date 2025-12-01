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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53GlobalResolver.Model;

#pragma warning disable CS1570
namespace Amazon.Route53GlobalResolver
{
    /// <summary>
    /// <para>Interface for accessing Route53GlobalResolver</para>
    ///
    /// Amazon Route 53 Global Resolver is a global, internet-accessible DNS resolver that
    /// enables customers to resolve and forward traffic for both public and private domains
    /// while ensuring security and authenticity of queries over the internet. Route 53 Global
    /// Resolver supports DNS-over-port 53 (Do53), DNS-over-TLS (DoT), and DNS-over-HTTPS
    /// (DoH) protocols through global anycast IP addresses.
    /// </summary>
    public partial interface IAmazonRoute53GlobalResolver : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53GlobalResolverPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateHostedZone



        /// <summary>
        /// Associates a Route 53 private hosted zone with a Route 53 Global Resolver resource.
        /// This allows the resolver to resolve DNS queries for the private hosted zone from anywhere
        /// globally.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHostedZone service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/AssociateHostedZone">REST API Reference for AssociateHostedZone Operation</seealso>
        Task<AssociateHostedZoneResponse> AssociateHostedZoneAsync(AssociateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateFirewallRule



        /// <summary>
        /// Creates multiple DNS firewall rules in a single operation. This is more efficient
        /// than creating rules individually when you need to set up multiple rules at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchCreateFirewallRule">REST API Reference for BatchCreateFirewallRule Operation</seealso>
        Task<BatchCreateFirewallRuleResponse> BatchCreateFirewallRuleAsync(BatchCreateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteFirewallRule



        /// <summary>
        /// Deletes multiple DNS firewall rules in a single operation. This is more efficient
        /// than deleting rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchDeleteFirewallRule">REST API Reference for BatchDeleteFirewallRule Operation</seealso>
        Task<BatchDeleteFirewallRuleResponse> BatchDeleteFirewallRuleAsync(BatchDeleteFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateFirewallRule



        /// <summary>
        /// Updates multiple DNS firewall rules in a single operation. This is more efficient
        /// than updating rules individually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/BatchUpdateFirewallRule">REST API Reference for BatchUpdateFirewallRule Operation</seealso>
        Task<BatchUpdateFirewallRuleResponse> BatchUpdateFirewallRuleAsync(BatchUpdateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessSource



        /// <summary>
        /// Creates an access source for a DNS view. Access sources define IP addresses or CIDR
        /// ranges that are allowed to send DNS queries to the Route 53 Global Resolver, along
        /// with the permitted DNS protocols.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessSource">REST API Reference for CreateAccessSource Operation</seealso>
        Task<CreateAccessSourceResponse> CreateAccessSourceAsync(CreateAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessToken



        /// <summary>
        /// Creates an access token for a DNS view. Access tokens provide token-based authentication
        /// for DNS-over-HTTPS (DoH) and DNS-over-TLS (DoT) connections to the Route 53 Global
        /// Resolver.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        Task<CreateAccessTokenResponse> CreateAccessTokenAsync(CreateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDNSView



        /// <summary>
        /// Creates a DNS view within a Route 53 Global Resolver. A DNS view models end users,
        /// user groups, networks, and devices, and serves as a parent resource that holds configurations
        /// controlling access, authorization, DNS firewall rules, and forwarding rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateDNSView">REST API Reference for CreateDNSView Operation</seealso>
        Task<CreateDNSViewResponse> CreateDNSViewAsync(CreateDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFirewallDomainList



        /// <summary>
        /// Creates a firewall domain list. Domain lists are reusable sets of domain specifications
        /// that you use in DNS firewall rules to allow, block, or alert on DNS queries to specific
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        Task<CreateFirewallDomainListResponse> CreateFirewallDomainListAsync(CreateFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFirewallRule



        /// <summary>
        /// Creates a DNS firewall rule. Firewall rules define actions (ALLOW, BLOCK, or ALERT)
        /// to take on DNS queries that match specified domain lists, managed domain lists, or
        /// advanced threat protections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        Task<CreateFirewallRuleResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGlobalResolver



        /// <summary>
        /// Creates a new Route 53 Global Resolver instance. A Route 53 Global Resolver is a global,
        /// internet-accessible DNS resolver that provides secure DNS resolution for both public
        /// and private domains through global anycast IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/CreateGlobalResolver">REST API Reference for CreateGlobalResolver Operation</seealso>
        Task<CreateGlobalResolverResponse> CreateGlobalResolverAsync(CreateGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessSource



        /// <summary>
        /// Deletes an access source. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessSource">REST API Reference for DeleteAccessSource Operation</seealso>
        Task<DeleteAccessSourceResponse> DeleteAccessSourceAsync(DeleteAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessToken



        /// <summary>
        /// Deletes an access token. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        Task<DeleteAccessTokenResponse> DeleteAccessTokenAsync(DeleteAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDNSView



        /// <summary>
        /// Deletes a DNS view. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteDNSView">REST API Reference for DeleteDNSView Operation</seealso>
        Task<DeleteDNSViewResponse> DeleteDNSViewAsync(DeleteDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFirewallDomainList



        /// <summary>
        /// Deletes a firewall domain list. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        Task<DeleteFirewallDomainListResponse> DeleteFirewallDomainListAsync(DeleteFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFirewallRule



        /// <summary>
        /// Deletes a DNS firewall rule. This operation cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        Task<DeleteFirewallRuleResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGlobalResolver



        /// <summary>
        /// Deletes a Route 53 Global Resolver instance. This operation cannot be undone. All
        /// associated DNS views, access sources, tokens, and firewall rules are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DeleteGlobalResolver">REST API Reference for DeleteGlobalResolver Operation</seealso>
        Task<DeleteGlobalResolverResponse> DeleteGlobalResolverAsync(DeleteGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableDNSView



        /// <summary>
        /// Disables a DNS view, preventing it from serving DNS queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisableDNSView">REST API Reference for DisableDNSView Operation</seealso>
        Task<DisableDNSViewResponse> DisableDNSViewAsync(DisableDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateHostedZone



        /// <summary>
        /// Disassociates a Route 53 private hosted zone from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateHostedZone service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/DisassociateHostedZone">REST API Reference for DisassociateHostedZone Operation</seealso>
        Task<DisassociateHostedZoneResponse> DisassociateHostedZoneAsync(DisassociateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableDNSView



        /// <summary>
        /// Enables a disabled DNS view, allowing it to serve DNS queries again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/EnableDNSView">REST API Reference for EnableDNSView Operation</seealso>
        Task<EnableDNSViewResponse> EnableDNSViewAsync(EnableDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessSource



        /// <summary>
        /// Retrieves information about an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessSource">REST API Reference for GetAccessSource Operation</seealso>
        Task<GetAccessSourceResponse> GetAccessSourceAsync(GetAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessToken



        /// <summary>
        /// Retrieves information about an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDNSView



        /// <summary>
        /// Retrieves information about a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetDNSView">REST API Reference for GetDNSView Operation</seealso>
        Task<GetDNSViewResponse> GetDNSViewAsync(GetDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFirewallDomainList



        /// <summary>
        /// Retrieves information about a firewall domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        Task<GetFirewallDomainListResponse> GetFirewallDomainListAsync(GetFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFirewallRule



        /// <summary>
        /// Retrieves information about a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetFirewallRule">REST API Reference for GetFirewallRule Operation</seealso>
        Task<GetFirewallRuleResponse> GetFirewallRuleAsync(GetFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGlobalResolver



        /// <summary>
        /// Retrieves information about a Route 53 Global Resolver instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetGlobalResolver">REST API Reference for GetGlobalResolver Operation</seealso>
        Task<GetGlobalResolverResponse> GetGlobalResolverAsync(GetGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZoneAssociation



        /// <summary>
        /// Retrieves information about a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneAssociation service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetHostedZoneAssociation">REST API Reference for GetHostedZoneAssociation Operation</seealso>
        Task<GetHostedZoneAssociationResponse> GetHostedZoneAssociationAsync(GetHostedZoneAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetManagedFirewallDomainList



        /// <summary>
        /// Retrieves information about an AWS-managed firewall domain list. Managed domain lists
        /// contain domains associated with malicious activity, content categories, or specific
        /// threats.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedFirewallDomainList service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/GetManagedFirewallDomainList">REST API Reference for GetManagedFirewallDomainList Operation</seealso>
        Task<GetManagedFirewallDomainListResponse> GetManagedFirewallDomainListAsync(GetManagedFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportFirewallDomains



        /// <summary>
        /// Imports a list of domains from an Amazon S3 file into a firewall domain list. The
        /// file should contain one domain per line.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        Task<ImportFirewallDomainsResponse> ImportFirewallDomainsAsync(ImportFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessSources



        /// <summary>
        /// Lists all access sources with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessSources service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessSources">REST API Reference for ListAccessSources Operation</seealso>
        Task<ListAccessSourcesResponse> ListAccessSourcesAsync(ListAccessSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessTokens



        /// <summary>
        /// Lists all access tokens for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessTokens service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        Task<ListAccessTokensResponse> ListAccessTokensAsync(ListAccessTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDNSViews



        /// <summary>
        /// Lists all DNS views for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDNSViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDNSViews service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListDNSViews">REST API Reference for ListDNSViews Operation</seealso>
        Task<ListDNSViewsResponse> ListDNSViewsAsync(ListDNSViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFirewallDomainLists



        /// <summary>
        /// Lists all firewall domain lists for a Route 53 Global Resolver with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomainLists service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        Task<ListFirewallDomainListsResponse> ListFirewallDomainListsAsync(ListFirewallDomainListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFirewallDomains



        /// <summary>
        /// Lists all the domains in DNS Firewall domain list you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        Task<ListFirewallDomainsResponse> ListFirewallDomainsAsync(ListFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFirewallRules



        /// <summary>
        /// Lists all DNS firewall rules for a DNS view with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallRules service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        Task<ListFirewallRulesResponse> ListFirewallRulesAsync(ListFirewallRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGlobalResolvers



        /// <summary>
        /// Lists all Route 53 Global Resolver instances in your account with pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalResolvers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGlobalResolvers service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListGlobalResolvers">REST API Reference for ListGlobalResolvers Operation</seealso>
        Task<ListGlobalResolversResponse> ListGlobalResolversAsync(ListGlobalResolversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZoneAssociations



        /// <summary>
        /// Lists all hosted zone associations for a Route 53 Global Resolver resource with pagination
        /// support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZoneAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZoneAssociations service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListHostedZoneAssociations">REST API Reference for ListHostedZoneAssociations Operation</seealso>
        Task<ListHostedZoneAssociationsResponse> ListHostedZoneAssociationsAsync(ListHostedZoneAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListManagedFirewallDomainLists



        /// <summary>
        /// Returns a paginated list of the AWS Managed DNS Lists and the categories for DNS Firewall.
        /// The categories are either <c>THREAT</c> or <c>CONTENT</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedFirewallDomainLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedFirewallDomainLists service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListManagedFirewallDomainLists">REST API Reference for ListManagedFirewallDomainLists Operation</seealso>
        Task<ListManagedFirewallDomainListsResponse> ListManagedFirewallDomainListsAsync(ListManagedFirewallDomainListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags associated with a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for a Route 53 Global Resolver resource. Tags are key-value pairs
        /// that help you organize and identify your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a Route 53 Global Resolver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessSource



        /// <summary>
        /// Updates the configuration of an access source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessSource service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ServiceQuotaExceededException">
        /// The request would exceed one or more service quotas. Check your current usage and
        /// quotas, then try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessSource">REST API Reference for UpdateAccessSource Operation</seealso>
        Task<UpdateAccessSourceResponse> UpdateAccessSourceAsync(UpdateAccessSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessToken



        /// <summary>
        /// Updates the configuration of an access token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessToken service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateAccessToken">REST API Reference for UpdateAccessToken Operation</seealso>
        Task<UpdateAccessTokenResponse> UpdateAccessTokenAsync(UpdateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDNSView



        /// <summary>
        /// Updates the configuration of a DNS view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDNSView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDNSView service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateDNSView">REST API Reference for UpdateDNSView Operation</seealso>
        Task<UpdateDNSViewResponse> UpdateDNSViewAsync(UpdateDNSViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFirewallDomains



        /// <summary>
        /// Updates a DNS Firewall domain list from an array of specified domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallDomains service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        Task<UpdateFirewallDomainsResponse> UpdateFirewallDomainsAsync(UpdateFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFirewallRule



        /// <summary>
        /// Updates the configuration of a DNS firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallRule service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        Task<UpdateFirewallRuleResponse> UpdateFirewallRuleAsync(UpdateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlobalResolver



        /// <summary>
        /// Updates the configuration of a Route 53 Global Resolver instance. You can modify the
        /// name, description, and observability region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalResolver service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalResolver service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateGlobalResolver">REST API Reference for UpdateGlobalResolver Operation</seealso>
        Task<UpdateGlobalResolverResponse> UpdateGlobalResolverAsync(UpdateGlobalResolverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHostedZoneAssociation



        /// <summary>
        /// Updates the configuration of a hosted zone association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHostedZoneAssociation service method, as returned by Route53GlobalResolver.</returns>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check your IAM permissions and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This can occur when
        /// trying to modify a resource that is not in a valid state for the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.InternalServerException">
        /// An internal server error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify the resource ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Wait a moment and try again.
        /// </exception>
        /// <exception cref="Amazon.Route53GlobalResolver.Model.ValidationException">
        /// The input parameters are invalid. Check the parameter values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53globalresolver-2022-09-27/UpdateHostedZoneAssociation">REST API Reference for UpdateHostedZoneAssociation Operation</seealso>
        Task<UpdateHostedZoneAssociationResponse> UpdateHostedZoneAssociationAsync(UpdateHostedZoneAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
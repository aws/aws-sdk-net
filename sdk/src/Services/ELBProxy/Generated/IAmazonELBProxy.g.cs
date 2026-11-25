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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.ELBProxy.Model;

#pragma warning disable CS1570

namespace Amazon.ELBProxy
{
    /// <summary>
    /// <para>Interface for accessing ELBProxy</para>
    ///
    /// Elastic Load Balancing for Envoy is a fully managed service that runs the open-source
    /// Envoy proxy on your behalf. You bring your Envoy configuration, and AWS provisions
    /// the proxy, scales it, upgrades the Envoy version, patches the operating system, and
    /// monitors its health. The proxy runs on Amazon EC2 instances inside your own virtual
    /// private cloud (VPC), so you keep full control of your network, security groups, and
    /// IAM.
    /// </summary>
    public partial interface IAmazonELBProxy : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IELBProxyPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associates an ACM certificate with the specified Proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <returns>The response from the AssociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        AssociateCertificateResponse AssociateCertificate(AssociateCertificateRequest request);
#endif

        /// <summary>
        /// Associates an ACM certificate with the specified Proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/AssociateCertificate">REST API Reference for AssociateCertificate Operation</seealso>
        Task<AssociateCertificateResponse> AssociateCertificateAsync(AssociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a proxy. A proxy is a fully managed, Envoy-based proxy that runs your Envoy
        /// configuration on Amazon EC2 instances inside your own virtual private cloud (VPC).
        /// AWS provisions and scales the proxy, upgrades the Envoy version, patches the operating
        /// system, and monitors its health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy service method.</param>
        /// <returns>The response from the CreateProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        CreateProxyResponse CreateProxy(CreateProxyRequest request);
#endif

        /// <summary>
        /// Creates a proxy. A proxy is a fully managed, Envoy-based proxy that runs your Envoy
        /// configuration on Amazon EC2 instances inside your own virtual private cloud (VPC).
        /// AWS provisions and scales the proxy, upgrades the Envoy version, patches the operating
        /// system, and monitors its health.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        Task<CreateProxyResponse> CreateProxyAsync(CreateProxyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy service method.</param>
        /// <returns>The response from the DeleteProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        DeleteProxyResponse DeleteProxy(DeleteProxyRequest request);
#endif

        /// <summary>
        /// Deletes a proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        Task<DeleteProxyResponse> DeleteProxyAsync(DeleteProxyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociates an ACM certificate from the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        DisassociateCertificateResponse DisassociateCertificate(DisassociateCertificateRequest request);
#endif

        /// <summary>
        /// Disassociates an ACM certificate from the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateCertificate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/DisassociateCertificate">REST API Reference for DisassociateCertificate Operation</seealso>
        Task<DisassociateCertificateResponse> DisassociateCertificateAsync(DisassociateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxy service method.</param>
        /// <returns>The response from the GetProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxy">REST API Reference for GetProxy Operation</seealso>
        GetProxyResponse GetProxy(GetProxyRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxy service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxy">REST API Reference for GetProxy Operation</seealso>
        Task<GetProxyResponse> GetProxyAsync(GetProxyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyAttributes service method.</param>
        /// <returns>The response from the GetProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyAttributes">REST API Reference for GetProxyAttributes Operation</seealso>
        GetProxyAttributesResponse GetProxyAttributes(GetProxyAttributesRequest request);
#endif

        /// <summary>
        /// Retrieves the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyAttributes">REST API Reference for GetProxyAttributes Operation</seealso>
        Task<GetProxyAttributesResponse> GetProxyAttributesAsync(GetProxyAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the configuration file, the configuration archive, or both for the specified
        /// proxy. This operation is separate from GetProxy so that you can grant access to proxy
        /// metadata without granting access to the configuration content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyConfigurationContents service method.</param>
        /// <returns>The response from the GetProxyConfigurationContents service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyConfigurationContents">REST API Reference for GetProxyConfigurationContents Operation</seealso>
        GetProxyConfigurationContentsResponse GetProxyConfigurationContents(GetProxyConfigurationContentsRequest request);
#endif

        /// <summary>
        /// Retrieves the configuration file, the configuration archive, or both for the specified
        /// proxy. This operation is separate from GetProxy so that you can grant access to proxy
        /// metadata without granting access to the configuration content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyConfigurationContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyConfigurationContents service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyConfigurationContents">REST API Reference for GetProxyConfigurationContents Operation</seealso>
        Task<GetProxyConfigurationContentsResponse> GetProxyConfigurationContentsAsync(GetProxyConfigurationContentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified proxy update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyUpdate service method.</param>
        /// <returns>The response from the GetProxyUpdate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyUpdate">REST API Reference for GetProxyUpdate Operation</seealso>
        GetProxyUpdateResponse GetProxyUpdate(GetProxyUpdateRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified proxy update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxyUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProxyUpdate service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/GetProxyUpdate">REST API Reference for GetProxyUpdate Operation</seealso>
        Task<GetProxyUpdateResponse> GetProxyUpdateAsync(GetProxyUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the ACM certificate associations for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        ListCertificateAssociationsResponse ListCertificateAssociations(ListCertificateAssociationsRequest request);
#endif

        /// <summary>
        /// Lists the ACM certificate associations for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCertificateAssociations service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListCertificateAssociations">REST API Reference for ListCertificateAssociations Operation</seealso>
        Task<ListCertificateAssociationsResponse> ListCertificateAssociationsAsync(ListCertificateAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the proxies owned by the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxies service method.</param>
        /// <returns>The response from the ListProxies service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxies">REST API Reference for ListProxies Operation</seealso>
        ListProxiesResponse ListProxies(ListProxiesRequest request);
#endif

        /// <summary>
        /// Lists the proxies owned by the caller account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxies service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxies">REST API Reference for ListProxies Operation</seealso>
        Task<ListProxiesResponse> ListProxiesAsync(ListProxiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the updates for the specified proxy, most recently submitted first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyUpdates service method.</param>
        /// <returns>The response from the ListProxyUpdates service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyUpdates">REST API Reference for ListProxyUpdates Operation</seealso>
        ListProxyUpdatesResponse ListProxyUpdates(ListProxyUpdatesRequest request);
#endif

        /// <summary>
        /// Lists the updates for the specified proxy, most recently submitted first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxyUpdates service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyUpdates">REST API Reference for ListProxyUpdates Operation</seealso>
        Task<ListProxyUpdatesResponse> ListProxyUpdatesAsync(ListProxyUpdatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the available proxy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyVersions service method.</param>
        /// <returns>The response from the ListProxyVersions service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyVersions">REST API Reference for ListProxyVersions Operation</seealso>
        ListProxyVersionsResponse ListProxyVersions(ListProxyVersionsRequest request);
#endif

        /// <summary>
        /// Lists the available proxy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProxyVersions service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListProxyVersions">REST API Reference for ListProxyVersions Operation</seealso>
        Task<ListProxyVersionsResponse> ListProxyVersionsAsync(ListProxyVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyAttributes service method.</param>
        /// <returns>The response from the UpdateProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyAttributes">REST API Reference for UpdateProxyAttributes Operation</seealso>
        UpdateProxyAttributesResponse UpdateProxyAttributes(UpdateProxyAttributesRequest request);
#endif

        /// <summary>
        /// Updates the attributes for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyAttributes service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyAttributes">REST API Reference for UpdateProxyAttributes Operation</seealso>
        Task<UpdateProxyAttributesResponse> UpdateProxyAttributesAsync(UpdateProxyAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the configuration for the specified proxy. You can update the configuration
        /// file, the configuration archive, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration service method.</param>
        /// <returns>The response from the UpdateProxyConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.PriorRequestNotCompletedException">
        /// The request could not be completed because a prior request has not yet completed.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        UpdateProxyConfigurationResponse UpdateProxyConfiguration(UpdateProxyConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the configuration for the specified proxy. You can update the configuration
        /// file, the configuration archive, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.PriorRequestNotCompletedException">
        /// The request could not be completed because a prior request has not yet completed.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        Task<UpdateProxyConfigurationResponse> UpdateProxyConfigurationAsync(UpdateProxyConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the network configuration for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyNetworkConfiguration service method.</param>
        /// <returns>The response from the UpdateProxyNetworkConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyNetworkConfiguration">REST API Reference for UpdateProxyNetworkConfiguration Operation</seealso>
        UpdateProxyNetworkConfigurationResponse UpdateProxyNetworkConfiguration(UpdateProxyNetworkConfigurationRequest request);
#endif

        /// <summary>
        /// Updates the network configuration for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyNetworkConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProxyNetworkConfiguration service method, as returned by ELBProxy.</returns>
        /// <exception cref="Amazon.ELBProxy.Model.AccessDeniedException">
        /// The user does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ELBProxy.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elb-proxy-2026-11-20/UpdateProxyNetworkConfiguration">REST API Reference for UpdateProxyNetworkConfiguration Operation</seealso>
        Task<UpdateProxyNetworkConfigurationResponse> UpdateProxyNetworkConfigurationAsync(UpdateProxyNetworkConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonELBProxyConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonELBProxyConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonELBProxyConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonELBProxyConfig to create AmazonELBProxyClient");
            }

            return awsCredentials == null ?
                    new AmazonELBProxyClient(serviceClientConfig) :
                    new AmazonELBProxyClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}

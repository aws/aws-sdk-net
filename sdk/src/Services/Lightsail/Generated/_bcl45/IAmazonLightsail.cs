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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lightsail.Model;

namespace Amazon.Lightsail
{
    /// <summary>
    /// Interface for accessing Lightsail
    ///
    /// Amazon Lightsail is the easiest way to get started with Amazon Web Services (AWS)
    /// for developers who need to build websites or web applications. It includes everything
    /// you need to launch your project quickly - instances (virtual private servers), container
    /// services, managed databases, SSD-based block storage, static IP addresses, load balancers,
    /// content delivery network (CDN) distributions, DNS management of registered domains,
    /// and resource snapshots (backups) - for a low, predictable monthly price.
    /// 
    ///  
    /// <para>
    /// You can manage your Lightsail resources using the Lightsail console, Lightsail API,
    /// AWS Command Line Interface (AWS CLI), or SDKs. For more information about Lightsail
    /// concepts and tasks, see the <a href="http://lightsail.aws.amazon.com/ls/docs/how-to/article/lightsail-how-to-set-up-access-keys-to-use-sdk-api-cli">Lightsail
    /// Dev Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This API Reference provides detailed information about the actions, data types, parameters,
    /// and errors of the Lightsail service. For more information about the supported AWS
    /// Regions, endpoints, and service quotas of the Lightsail service, see <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon
    /// Lightsail Endpoints and Quotas</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonLightsail : IAmazonService, IDisposable
    {


        
        #region  AllocateStaticIp


        /// <summary>
        /// Allocates a static IP address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp service method.</param>
        /// 
        /// <returns>The response from the AllocateStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request);



        /// <summary>
        /// Allocates a static IP address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        Task<AllocateStaticIpResponse> AllocateStaticIpAsync(AllocateStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachCertificateToDistribution


        /// <summary>
        /// Attaches an SSL/TLS certificate to your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is attached, your distribution accepts HTTPS traffic for all
        /// of the domains that are associated with the certificate.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>CreateCertificate</code> action to create a certificate that you can
        /// attach to your distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only certificates created in the <code>us-east-1</code> AWS Region can be attached
        /// to Lightsail distributions. Lightsail distributions are global resources that can
        /// reference an origin in any AWS Region, and distribute its content globally. However,
        /// all distributions are located in the <code>us-east-1</code> Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachCertificateToDistribution service method.</param>
        /// 
        /// <returns>The response from the AttachCertificateToDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachCertificateToDistribution">REST API Reference for AttachCertificateToDistribution Operation</seealso>
        AttachCertificateToDistributionResponse AttachCertificateToDistribution(AttachCertificateToDistributionRequest request);



        /// <summary>
        /// Attaches an SSL/TLS certificate to your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is attached, your distribution accepts HTTPS traffic for all
        /// of the domains that are associated with the certificate.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>CreateCertificate</code> action to create a certificate that you can
        /// attach to your distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only certificates created in the <code>us-east-1</code> AWS Region can be attached
        /// to Lightsail distributions. Lightsail distributions are global resources that can
        /// reference an origin in any AWS Region, and distribute its content globally. However,
        /// all distributions are located in the <code>us-east-1</code> Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachCertificateToDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachCertificateToDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachCertificateToDistribution">REST API Reference for AttachCertificateToDistribution Operation</seealso>
        Task<AttachCertificateToDistributionResponse> AttachCertificateToDistributionAsync(AttachCertificateToDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachDisk


        /// <summary>
        /// Attaches a block storage disk to a running or stopped Lightsail instance and exposes
        /// it to the instance with the specified disk name.
        /// 
        ///  
        /// <para>
        /// The <code>attach disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachDisk service method.</param>
        /// 
        /// <returns>The response from the AttachDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachDisk">REST API Reference for AttachDisk Operation</seealso>
        AttachDiskResponse AttachDisk(AttachDiskRequest request);



        /// <summary>
        /// Attaches a block storage disk to a running or stopped Lightsail instance and exposes
        /// it to the instance with the specified disk name.
        /// 
        ///  
        /// <para>
        /// The <code>attach disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachDisk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachDisk">REST API Reference for AttachDisk Operation</seealso>
        Task<AttachDiskResponse> AttachDiskAsync(AttachDiskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachInstancesToLoadBalancer


        /// <summary>
        /// Attaches one or more Lightsail instances to a load balancer.
        /// 
        ///  
        /// <para>
        /// After some time, the instances are attached to the load balancer and the health check
        /// status is available.
        /// </para>
        ///  
        /// <para>
        /// The <code>attach instances to load balancer</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstancesToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the AttachInstancesToLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachInstancesToLoadBalancer">REST API Reference for AttachInstancesToLoadBalancer Operation</seealso>
        AttachInstancesToLoadBalancerResponse AttachInstancesToLoadBalancer(AttachInstancesToLoadBalancerRequest request);



        /// <summary>
        /// Attaches one or more Lightsail instances to a load balancer.
        /// 
        ///  
        /// <para>
        /// After some time, the instances are attached to the load balancer and the health check
        /// status is available.
        /// </para>
        ///  
        /// <para>
        /// The <code>attach instances to load balancer</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstancesToLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachInstancesToLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachInstancesToLoadBalancer">REST API Reference for AttachInstancesToLoadBalancer Operation</seealso>
        Task<AttachInstancesToLoadBalancerResponse> AttachInstancesToLoadBalancerAsync(AttachInstancesToLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachLoadBalancerTlsCertificate


        /// <summary>
        /// Attaches a Transport Layer Security (TLS) certificate to your load balancer. TLS is
        /// just an updated, more secure version of Secure Socket Layer (SSL).
        /// 
        ///  
        /// <para>
        /// Once you create and validate your certificate, you can attach it to your load balancer.
        /// You can also use this API to rotate the certificates on your account. Use the <code>AttachLoadBalancerTlsCertificate</code>
        /// action with the non-attached certificate, and it will replace the existing one and
        /// become the attached certificate.
        /// </para>
        ///  
        /// <para>
        /// The <code>AttachLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTlsCertificate service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachLoadBalancerTlsCertificate">REST API Reference for AttachLoadBalancerTlsCertificate Operation</seealso>
        AttachLoadBalancerTlsCertificateResponse AttachLoadBalancerTlsCertificate(AttachLoadBalancerTlsCertificateRequest request);



        /// <summary>
        /// Attaches a Transport Layer Security (TLS) certificate to your load balancer. TLS is
        /// just an updated, more secure version of Secure Socket Layer (SSL).
        /// 
        ///  
        /// <para>
        /// Once you create and validate your certificate, you can attach it to your load balancer.
        /// You can also use this API to rotate the certificates on your account. Use the <code>AttachLoadBalancerTlsCertificate</code>
        /// action with the non-attached certificate, and it will replace the existing one and
        /// become the attached certificate.
        /// </para>
        ///  
        /// <para>
        /// The <code>AttachLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTlsCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachLoadBalancerTlsCertificate">REST API Reference for AttachLoadBalancerTlsCertificate Operation</seealso>
        Task<AttachLoadBalancerTlsCertificateResponse> AttachLoadBalancerTlsCertificateAsync(AttachLoadBalancerTlsCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachStaticIp


        /// <summary>
        /// Attaches a static IP address to a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp service method.</param>
        /// 
        /// <returns>The response from the AttachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request);



        /// <summary>
        /// Attaches a static IP address to a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        Task<AttachStaticIpResponse> AttachStaticIpAsync(AttachStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CloseInstancePublicPorts


        /// <summary>
        /// Closes ports for a specific Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>CloseInstancePublicPorts</code> action supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instanceName</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the CloseInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request);



        /// <summary>
        /// Closes ports for a specific Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>CloseInstancePublicPorts</code> action supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instanceName</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        Task<CloseInstancePublicPortsResponse> CloseInstancePublicPortsAsync(CloseInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// Copies a manual snapshot of an instance or disk as another manual snapshot, or copies
        /// an automatic snapshot of an instance or disk as a manual snapshot. This operation
        /// can also be used to copy a manual or automatic snapshot of an instance or a disk from
        /// one AWS Region to another in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// When copying a <i>manual snapshot</i>, be sure to define the <code>source region</code>,
        /// <code>source snapshot name</code>, and <code>target snapshot name</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// When copying an <i>automatic snapshot</i>, be sure to define the <code>source region</code>,
        /// <code>source resource name</code>, <code>target snapshot name</code>, and either the
        /// <code>restore date</code> or the <code>use latest restorable auto snapshot</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);



        /// <summary>
        /// Copies a manual snapshot of an instance or disk as another manual snapshot, or copies
        /// an automatic snapshot of an instance or disk as a manual snapshot. This operation
        /// can also be used to copy a manual or automatic snapshot of an instance or a disk from
        /// one AWS Region to another in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// When copying a <i>manual snapshot</i>, be sure to define the <code>source region</code>,
        /// <code>source snapshot name</code>, and <code>target snapshot name</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// When copying an <i>automatic snapshot</i>, be sure to define the <code>source region</code>,
        /// <code>source resource name</code>, <code>target snapshot name</code>, and either the
        /// <code>restore date</code> or the <code>use latest restorable auto snapshot</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCertificate


        /// <summary>
        /// Creates an SSL/TLS certificate for a Amazon Lightsail content delivery network (CDN)
        /// distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is created, use the <code>AttachCertificateToDistribution</code>
        /// action to attach the certificate to your distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only certificates created in the <code>us-east-1</code> AWS Region can be attached
        /// to Lightsail distributions. Lightsail distributions are global resources that can
        /// reference an origin in any AWS Region, and distribute its content globally. However,
        /// all distributions are located in the <code>us-east-1</code> Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCertificate">REST API Reference for CreateCertificate Operation</seealso>
        CreateCertificateResponse CreateCertificate(CreateCertificateRequest request);



        /// <summary>
        /// Creates an SSL/TLS certificate for a Amazon Lightsail content delivery network (CDN)
        /// distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is created, use the <code>AttachCertificateToDistribution</code>
        /// action to attach the certificate to your distribution.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only certificates created in the <code>us-east-1</code> AWS Region can be attached
        /// to Lightsail distributions. Lightsail distributions are global resources that can
        /// reference an origin in any AWS Region, and distribute its content globally. However,
        /// all distributions are located in the <code>us-east-1</code> Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCertificate">REST API Reference for CreateCertificate Operation</seealso>
        Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCloudFormationStack


        /// <summary>
        /// Creates an AWS CloudFormation stack, which creates a new Amazon EC2 instance from
        /// an exported Amazon Lightsail snapshot. This operation results in a CloudFormation
        /// stack record that can be used to track the AWS CloudFormation stack created. Use the
        /// <code>get cloud formation stack records</code> operation to get a list of the CloudFormation
        /// stacks created.
        /// 
        ///  <important> 
        /// <para>
        /// Wait until after your new Amazon EC2 instance is created before running the <code>create
        /// cloud formation stack</code> operation again with the same export snapshot record.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationStack service method.</param>
        /// 
        /// <returns>The response from the CreateCloudFormationStack service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCloudFormationStack">REST API Reference for CreateCloudFormationStack Operation</seealso>
        CreateCloudFormationStackResponse CreateCloudFormationStack(CreateCloudFormationStackRequest request);



        /// <summary>
        /// Creates an AWS CloudFormation stack, which creates a new Amazon EC2 instance from
        /// an exported Amazon Lightsail snapshot. This operation results in a CloudFormation
        /// stack record that can be used to track the AWS CloudFormation stack created. Use the
        /// <code>get cloud formation stack records</code> operation to get a list of the CloudFormation
        /// stacks created.
        /// 
        ///  <important> 
        /// <para>
        /// Wait until after your new Amazon EC2 instance is created before running the <code>create
        /// cloud formation stack</code> operation again with the same export snapshot record.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudFormationStack service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCloudFormationStack">REST API Reference for CreateCloudFormationStack Operation</seealso>
        Task<CreateCloudFormationStackResponse> CreateCloudFormationStackAsync(CreateCloudFormationStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateContactMethod


        /// <summary>
        /// Creates an email or SMS text message contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactMethod service method.</param>
        /// 
        /// <returns>The response from the CreateContactMethod service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContactMethod">REST API Reference for CreateContactMethod Operation</seealso>
        CreateContactMethodResponse CreateContactMethod(CreateContactMethodRequest request);



        /// <summary>
        /// Creates an email or SMS text message contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContactMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContactMethod service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContactMethod">REST API Reference for CreateContactMethod Operation</seealso>
        Task<CreateContactMethodResponse> CreateContactMethodAsync(CreateContactMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateContainerService


        /// <summary>
        /// Creates an Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// A Lightsail container service is a compute resource to which you can deploy containers.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-containers">Container
        /// services in Amazon Lightsail</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerService service method.</param>
        /// 
        /// <returns>The response from the CreateContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerService">REST API Reference for CreateContainerService Operation</seealso>
        CreateContainerServiceResponse CreateContainerService(CreateContainerServiceRequest request);



        /// <summary>
        /// Creates an Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// A Lightsail container service is a compute resource to which you can deploy containers.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-containers">Container
        /// services in Amazon Lightsail</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerService">REST API Reference for CreateContainerService Operation</seealso>
        Task<CreateContainerServiceResponse> CreateContainerServiceAsync(CreateContainerServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateContainerServiceDeployment


        /// <summary>
        /// Creates a deployment for your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// A deployment specifies the containers that will be launched on the container service
        /// and their settings, such as the ports to open, the environment variables to apply,
        /// and the launch command to run. It also specifies the container that will serve as
        /// the public endpoint of the deployment and its settings, such as the HTTP or HTTPS
        /// port to use, and the health check configuration.
        /// </para>
        ///  
        /// <para>
        /// You can deploy containers to your container service using container images from a
        /// public registry like Docker Hub, or from your local machine. For more information,
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-images">Creating
        /// container images for your Amazon Lightsail container services</a> in the <i>Lightsail
        /// Dev Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateContainerServiceDeployment service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceDeployment">REST API Reference for CreateContainerServiceDeployment Operation</seealso>
        CreateContainerServiceDeploymentResponse CreateContainerServiceDeployment(CreateContainerServiceDeploymentRequest request);



        /// <summary>
        /// Creates a deployment for your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// A deployment specifies the containers that will be launched on the container service
        /// and their settings, such as the ports to open, the environment variables to apply,
        /// and the launch command to run. It also specifies the container that will serve as
        /// the public endpoint of the deployment and its settings, such as the HTTP or HTTPS
        /// port to use, and the health check configuration.
        /// </para>
        ///  
        /// <para>
        /// You can deploy containers to your container service using container images from a
        /// public registry like Docker Hub, or from your local machine. For more information,
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-images">Creating
        /// container images for your Amazon Lightsail container services</a> in the <i>Lightsail
        /// Dev Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainerServiceDeployment service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceDeployment">REST API Reference for CreateContainerServiceDeployment Operation</seealso>
        Task<CreateContainerServiceDeploymentResponse> CreateContainerServiceDeploymentAsync(CreateContainerServiceDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateContainerServiceRegistryLogin


        /// <summary>
        /// Creates a temporary set of log in credentials that you can use to log in to the Docker
        /// process on your local machine. After you're logged in, you can use the native Docker
        /// commands to push your local container images to the container image registry of your
        /// Amazon Lightsail account so that you can use them with your Lightsail container service.
        /// The log in credentials expire 12 hours after they are created, at which point you
        /// will need to create a new set of log in credentials.
        /// 
        ///  <note> 
        /// <para>
        /// You can only push container images to the container service registry of your Lightsail
        /// account. You cannot pull container images perform any other container image management
        /// actions on the container service registry of your Lightsail account.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you push your container images to the container image registry of your Lightsail
        /// account, use the <code>RegisterContainerImage</code> action to register the pushed
        /// images to a specific Lightsail container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not required if you install and use the Lightsail Control (lightsailctl)
        /// plugin to push container images to your Lightsail container service. For more information,
        /// see <a href="amazon-lightsail-pushing-container-images">Pushing and managing container
        /// images on your Amazon Lightsail container services</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceRegistryLogin service method.</param>
        /// 
        /// <returns>The response from the CreateContainerServiceRegistryLogin service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceRegistryLogin">REST API Reference for CreateContainerServiceRegistryLogin Operation</seealso>
        CreateContainerServiceRegistryLoginResponse CreateContainerServiceRegistryLogin(CreateContainerServiceRegistryLoginRequest request);



        /// <summary>
        /// Creates a temporary set of log in credentials that you can use to log in to the Docker
        /// process on your local machine. After you're logged in, you can use the native Docker
        /// commands to push your local container images to the container image registry of your
        /// Amazon Lightsail account so that you can use them with your Lightsail container service.
        /// The log in credentials expire 12 hours after they are created, at which point you
        /// will need to create a new set of log in credentials.
        /// 
        ///  <note> 
        /// <para>
        /// You can only push container images to the container service registry of your Lightsail
        /// account. You cannot pull container images perform any other container image management
        /// actions on the container service registry of your Lightsail account.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you push your container images to the container image registry of your Lightsail
        /// account, use the <code>RegisterContainerImage</code> action to register the pushed
        /// images to a specific Lightsail container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not required if you install and use the Lightsail Control (lightsailctl)
        /// plugin to push container images to your Lightsail container service. For more information,
        /// see <a href="amazon-lightsail-pushing-container-images">Pushing and managing container
        /// images on your Amazon Lightsail container services</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceRegistryLogin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContainerServiceRegistryLogin service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceRegistryLogin">REST API Reference for CreateContainerServiceRegistryLogin Operation</seealso>
        Task<CreateContainerServiceRegistryLoginResponse> CreateContainerServiceRegistryLoginAsync(CreateContainerServiceRegistryLoginRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDisk


        /// <summary>
        /// Creates a block storage disk that can be attached to an Amazon Lightsail instance
        /// in the same Availability Zone (e.g., <code>us-east-2a</code>).
        /// 
        ///  
        /// <para>
        /// The <code>create disk</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDisk service method.</param>
        /// 
        /// <returns>The response from the CreateDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDisk">REST API Reference for CreateDisk Operation</seealso>
        CreateDiskResponse CreateDisk(CreateDiskRequest request);



        /// <summary>
        /// Creates a block storage disk that can be attached to an Amazon Lightsail instance
        /// in the same Availability Zone (e.g., <code>us-east-2a</code>).
        /// 
        ///  
        /// <para>
        /// The <code>create disk</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDisk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDisk">REST API Reference for CreateDisk Operation</seealso>
        Task<CreateDiskResponse> CreateDiskAsync(CreateDiskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDiskFromSnapshot


        /// <summary>
        /// Creates a block storage disk from a manual or automatic snapshot of a disk. The resulting
        /// disk can be attached to an Amazon Lightsail instance in the same Availability Zone
        /// (e.g., <code>us-east-2a</code>).
        /// 
        ///  
        /// <para>
        /// The <code>create disk from snapshot</code> operation supports tag-based access control
        /// via request tags and resource tags applied to the resource identified by <code>disk
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDiskFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskFromSnapshot">REST API Reference for CreateDiskFromSnapshot Operation</seealso>
        CreateDiskFromSnapshotResponse CreateDiskFromSnapshot(CreateDiskFromSnapshotRequest request);



        /// <summary>
        /// Creates a block storage disk from a manual or automatic snapshot of a disk. The resulting
        /// disk can be attached to an Amazon Lightsail instance in the same Availability Zone
        /// (e.g., <code>us-east-2a</code>).
        /// 
        ///  
        /// <para>
        /// The <code>create disk from snapshot</code> operation supports tag-based access control
        /// via request tags and resource tags applied to the resource identified by <code>disk
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDiskFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskFromSnapshot">REST API Reference for CreateDiskFromSnapshot Operation</seealso>
        Task<CreateDiskFromSnapshotResponse> CreateDiskFromSnapshotAsync(CreateDiskFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDiskSnapshot


        /// <summary>
        /// Creates a snapshot of a block storage disk. You can use snapshots for backups, to
        /// make copies of disks, and to save data before shutting down a Lightsail instance.
        /// 
        ///  
        /// <para>
        /// You can take a snapshot of an attached disk that is in use; however, snapshots only
        /// capture data that has been written to your disk at the time the snapshot command is
        /// issued. This may exclude any data that has been cached by any applications or the
        /// operating system. If you can pause any file systems on the disk long enough to take
        /// a snapshot, your snapshot should be complete. Nevertheless, if you cannot pause all
        /// file writes to the disk, you should unmount the disk from within the Lightsail instance,
        /// issue the create disk snapshot command, and then remount the disk to ensure a consistent
        /// and complete snapshot. You may remount and use your disk while the snapshot status
        /// is pending.
        /// </para>
        ///  
        /// <para>
        /// You can also use this operation to create a snapshot of an instance's system volume.
        /// You might want to do this, for example, to recover data from the system volume of
        /// a botched instance or to create a backup of the system volume like you would for a
        /// block storage disk. To create a snapshot of a system volume, just define the <code>instance
        /// name</code> parameter when issuing the snapshot command, and a snapshot of the defined
        /// instance's system volume will be created. After the snapshot is available, you can
        /// create a block storage disk from the snapshot and attach it to a running instance
        /// to access the data on the disk.
        /// </para>
        ///  
        /// <para>
        /// The <code>create disk snapshot</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskSnapshot">REST API Reference for CreateDiskSnapshot Operation</seealso>
        CreateDiskSnapshotResponse CreateDiskSnapshot(CreateDiskSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of a block storage disk. You can use snapshots for backups, to
        /// make copies of disks, and to save data before shutting down a Lightsail instance.
        /// 
        ///  
        /// <para>
        /// You can take a snapshot of an attached disk that is in use; however, snapshots only
        /// capture data that has been written to your disk at the time the snapshot command is
        /// issued. This may exclude any data that has been cached by any applications or the
        /// operating system. If you can pause any file systems on the disk long enough to take
        /// a snapshot, your snapshot should be complete. Nevertheless, if you cannot pause all
        /// file writes to the disk, you should unmount the disk from within the Lightsail instance,
        /// issue the create disk snapshot command, and then remount the disk to ensure a consistent
        /// and complete snapshot. You may remount and use your disk while the snapshot status
        /// is pending.
        /// </para>
        ///  
        /// <para>
        /// You can also use this operation to create a snapshot of an instance's system volume.
        /// You might want to do this, for example, to recover data from the system volume of
        /// a botched instance or to create a backup of the system volume like you would for a
        /// block storage disk. To create a snapshot of a system volume, just define the <code>instance
        /// name</code> parameter when issuing the snapshot command, and a snapshot of the defined
        /// instance's system volume will be created. After the snapshot is available, you can
        /// create a block storage disk from the snapshot and attach it to a running instance
        /// to access the data on the disk.
        /// </para>
        ///  
        /// <para>
        /// The <code>create disk snapshot</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskSnapshot">REST API Reference for CreateDiskSnapshot Operation</seealso>
        Task<CreateDiskSnapshotResponse> CreateDiskSnapshotAsync(CreateDiskSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDistribution


        /// <summary>
        /// Creates an Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// A distribution is a globally distributed network of caching servers that improve the
        /// performance of your website or web application hosted on a Lightsail instance. For
        /// more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-content-delivery-network-distributions">Content
        /// delivery networks in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        CreateDistributionResponse CreateDistribution(CreateDistributionRequest request);



        /// <summary>
        /// Creates an Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// A distribution is a globally distributed network of caching servers that improve the
        /// performance of your website or web application hosted on a Lightsail instance. For
        /// more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-content-delivery-network-distributions">Content
        /// delivery networks in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain resource for the specified domain (e.g., example.com).
        /// 
        ///  
        /// <para>
        /// The <code>create domain</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);



        /// <summary>
        /// Creates a domain resource for the specified domain (e.g., example.com).
        /// 
        ///  
        /// <para>
        /// The <code>create domain</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomainEntry


        /// <summary>
        /// Creates one of the following domain name system (DNS) records in a domain DNS zone:
        /// Address (A), canonical name (CNAME), mail exchanger (MX), name server (NS), start
        /// of authority (SOA), service locator (SRV), or text (TXT).
        /// 
        ///  
        /// <para>
        /// The <code>create domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the CreateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request);



        /// <summary>
        /// Creates one of the following domain name system (DNS) records in a domain DNS zone:
        /// Address (A), canonical name (CNAME), mail exchanger (MX), name server (NS), start
        /// of authority (SOA), service locator (SRV), or text (TXT).
        /// 
        ///  
        /// <para>
        /// The <code>create domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        Task<CreateDomainEntryResponse> CreateDomainEntryAsync(CreateDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstances


        /// <summary>
        /// Creates one or more Amazon Lightsail instances.
        /// 
        ///  
        /// <para>
        /// The <code>create instances</code> operation supports tag-based access control via
        /// request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances service method.</param>
        /// 
        /// <returns>The response from the CreateInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        CreateInstancesResponse CreateInstances(CreateInstancesRequest request);



        /// <summary>
        /// Creates one or more Amazon Lightsail instances.
        /// 
        ///  
        /// <para>
        /// The <code>create instances</code> operation supports tag-based access control via
        /// request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        Task<CreateInstancesResponse> CreateInstancesAsync(CreateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstancesFromSnapshot


        /// <summary>
        /// Creates one or more new instances from a manual or automatic snapshot of an instance.
        /// 
        ///  
        /// <para>
        /// The <code>create instances from snapshot</code> operation supports tag-based access
        /// control via request tags and resource tags applied to the resource identified by <code>instance
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstancesFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request);



        /// <summary>
        /// Creates one or more new instances from a manual or automatic snapshot of an instance.
        /// 
        ///  
        /// <para>
        /// The <code>create instances from snapshot</code> operation supports tag-based access
        /// control via request tags and resource tags applied to the resource identified by <code>instance
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstancesFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        Task<CreateInstancesFromSnapshotResponse> CreateInstancesFromSnapshotAsync(CreateInstancesFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstanceSnapshot


        /// <summary>
        /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
        /// use a snapshot to create a new instance that is based on that snapshot.
        /// 
        ///  
        /// <para>
        /// The <code>create instance snapshot</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
        /// use a snapshot to create a new instance that is based on that snapshot.
        /// 
        ///  
        /// <para>
        /// The <code>create instance snapshot</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(CreateInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKeyPair


        /// <summary>
        /// Creates an SSH key pair.
        /// 
        ///  
        /// <para>
        /// The <code>create key pair</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);



        /// <summary>
        /// Creates an SSH key pair.
        /// 
        ///  
        /// <para>
        /// The <code>create key pair</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates a Lightsail load balancer. To learn more about deciding whether to load balance
        /// your application, see <a href="https://lightsail.aws.amazon.com/ls/docs/how-to/article/configure-lightsail-instances-for-load-balancing">Configure
        /// your Lightsail instances for load balancing</a>. You can create up to 5 load balancers
        /// per AWS Region in your account.
        /// 
        ///  
        /// <para>
        /// When you create a load balancer, you can specify a unique name and port settings.
        /// To change additional load balancer settings, use the <code>UpdateLoadBalancerAttribute</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>create load balancer</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);



        /// <summary>
        /// Creates a Lightsail load balancer. To learn more about deciding whether to load balance
        /// your application, see <a href="https://lightsail.aws.amazon.com/ls/docs/how-to/article/configure-lightsail-instances-for-load-balancing">Configure
        /// your Lightsail instances for load balancing</a>. You can create up to 5 load balancers
        /// per AWS Region in your account.
        /// 
        ///  
        /// <para>
        /// When you create a load balancer, you can specify a unique name and port settings.
        /// To change additional load balancer settings, use the <code>UpdateLoadBalancerAttribute</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>create load balancer</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancerTlsCertificate


        /// <summary>
        /// Creates a Lightsail load balancer TLS certificate.
        /// 
        ///  
        /// <para>
        /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerTlsCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancerTlsCertificate">REST API Reference for CreateLoadBalancerTlsCertificate Operation</seealso>
        CreateLoadBalancerTlsCertificateResponse CreateLoadBalancerTlsCertificate(CreateLoadBalancerTlsCertificateRequest request);



        /// <summary>
        /// Creates a Lightsail load balancer TLS certificate.
        /// 
        ///  
        /// <para>
        /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerTlsCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancerTlsCertificate">REST API Reference for CreateLoadBalancerTlsCertificate Operation</seealso>
        Task<CreateLoadBalancerTlsCertificateResponse> CreateLoadBalancerTlsCertificateAsync(CreateLoadBalancerTlsCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRelationalDatabase


        /// <summary>
        /// Creates a new database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabase">REST API Reference for CreateRelationalDatabase Operation</seealso>
        CreateRelationalDatabaseResponse CreateRelationalDatabase(CreateRelationalDatabaseRequest request);



        /// <summary>
        /// Creates a new database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabase">REST API Reference for CreateRelationalDatabase Operation</seealso>
        Task<CreateRelationalDatabaseResponse> CreateRelationalDatabaseAsync(CreateRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRelationalDatabaseFromSnapshot


        /// <summary>
        /// Creates a new database from an existing database snapshot in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// You can create a new database from a snapshot in if something goes wrong with your
        /// original database, or to change it to a different plan, such as a high availability
        /// or standard plan.
        /// </para>
        ///  
        /// <para>
        /// The <code>create relational database from snapshot</code> operation supports tag-based
        /// access control via request tags and resource tags applied to the resource identified
        /// by relationalDatabaseSnapshotName. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateRelationalDatabaseFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseFromSnapshot">REST API Reference for CreateRelationalDatabaseFromSnapshot Operation</seealso>
        CreateRelationalDatabaseFromSnapshotResponse CreateRelationalDatabaseFromSnapshot(CreateRelationalDatabaseFromSnapshotRequest request);



        /// <summary>
        /// Creates a new database from an existing database snapshot in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// You can create a new database from a snapshot in if something goes wrong with your
        /// original database, or to change it to a different plan, such as a high availability
        /// or standard plan.
        /// </para>
        ///  
        /// <para>
        /// The <code>create relational database from snapshot</code> operation supports tag-based
        /// access control via request tags and resource tags applied to the resource identified
        /// by relationalDatabaseSnapshotName. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelationalDatabaseFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseFromSnapshot">REST API Reference for CreateRelationalDatabaseFromSnapshot Operation</seealso>
        Task<CreateRelationalDatabaseFromSnapshotResponse> CreateRelationalDatabaseFromSnapshotAsync(CreateRelationalDatabaseFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRelationalDatabaseSnapshot


        /// <summary>
        /// Creates a snapshot of your database in Amazon Lightsail. You can use snapshots for
        /// backups, to make copies of a database, and to save data before deleting a database.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database snapshot</code> operation supports tag-based
        /// access control via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseSnapshot">REST API Reference for CreateRelationalDatabaseSnapshot Operation</seealso>
        CreateRelationalDatabaseSnapshotResponse CreateRelationalDatabaseSnapshot(CreateRelationalDatabaseSnapshotRequest request);



        /// <summary>
        /// Creates a snapshot of your database in Amazon Lightsail. You can use snapshots for
        /// backups, to make copies of a database, and to save data before deleting a database.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database snapshot</code> operation supports tag-based
        /// access control via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseSnapshot">REST API Reference for CreateRelationalDatabaseSnapshot Operation</seealso>
        Task<CreateRelationalDatabaseSnapshotResponse> CreateRelationalDatabaseSnapshotAsync(CreateRelationalDatabaseSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlarm


        /// <summary>
        /// Deletes an alarm.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarm service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAlarm">REST API Reference for DeleteAlarm Operation</seealso>
        DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest request);



        /// <summary>
        /// Deletes an alarm.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAlarm">REST API Reference for DeleteAlarm Operation</seealso>
        Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAutoSnapshot


        /// <summary>
        /// Deletes an automatic snapshot of an instance or disk. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAutoSnapshot">REST API Reference for DeleteAutoSnapshot Operation</seealso>
        DeleteAutoSnapshotResponse DeleteAutoSnapshot(DeleteAutoSnapshotRequest request);



        /// <summary>
        /// Deletes an automatic snapshot of an instance or disk. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutoSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAutoSnapshot">REST API Reference for DeleteAutoSnapshot Operation</seealso>
        Task<DeleteAutoSnapshotResponse> DeleteAutoSnapshotAsync(DeleteAutoSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes an SSL/TLS certificate for your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Certificates that are currently attached to a distribution cannot be deleted. Use
        /// the <code>DetachCertificateFromDistribution</code> action to detach a certificate
        /// from a distribution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);



        /// <summary>
        /// Deletes an SSL/TLS certificate for your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Certificates that are currently attached to a distribution cannot be deleted. Use
        /// the <code>DetachCertificateFromDistribution</code> action to detach a certificate
        /// from a distribution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteContactMethod


        /// <summary>
        /// Deletes a contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactMethod service method.</param>
        /// 
        /// <returns>The response from the DeleteContactMethod service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContactMethod">REST API Reference for DeleteContactMethod Operation</seealso>
        DeleteContactMethodResponse DeleteContactMethod(DeleteContactMethodRequest request);



        /// <summary>
        /// Deletes a contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContactMethod service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContactMethod">REST API Reference for DeleteContactMethod Operation</seealso>
        Task<DeleteContactMethodResponse> DeleteContactMethodAsync(DeleteContactMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteContainerImage


        /// <summary>
        /// Deletes a container image that is registered to your Amazon Lightsail container service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerImage service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerImage service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerImage">REST API Reference for DeleteContainerImage Operation</seealso>
        DeleteContainerImageResponse DeleteContainerImage(DeleteContainerImageRequest request);



        /// <summary>
        /// Deletes a container image that is registered to your Amazon Lightsail container service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainerImage service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerImage">REST API Reference for DeleteContainerImage Operation</seealso>
        Task<DeleteContainerImageResponse> DeleteContainerImageAsync(DeleteContainerImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteContainerService


        /// <summary>
        /// Deletes your Amazon Lightsail container service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerService service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerService">REST API Reference for DeleteContainerService Operation</seealso>
        DeleteContainerServiceResponse DeleteContainerService(DeleteContainerServiceRequest request);



        /// <summary>
        /// Deletes your Amazon Lightsail container service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerService">REST API Reference for DeleteContainerService Operation</seealso>
        Task<DeleteContainerServiceResponse> DeleteContainerServiceAsync(DeleteContainerServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDisk


        /// <summary>
        /// Deletes the specified block storage disk. The disk must be in the <code>available</code>
        /// state (not attached to a Lightsail instance).
        /// 
        ///  <note> 
        /// <para>
        /// The disk may remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>delete disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDisk service method.</param>
        /// 
        /// <returns>The response from the DeleteDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDisk">REST API Reference for DeleteDisk Operation</seealso>
        DeleteDiskResponse DeleteDisk(DeleteDiskRequest request);



        /// <summary>
        /// Deletes the specified block storage disk. The disk must be in the <code>available</code>
        /// state (not attached to a Lightsail instance).
        /// 
        ///  <note> 
        /// <para>
        /// The disk may remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>delete disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDisk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDisk">REST API Reference for DeleteDisk Operation</seealso>
        Task<DeleteDiskResponse> DeleteDiskAsync(DeleteDiskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDiskSnapshot


        /// <summary>
        /// Deletes the specified disk snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a disk, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the disk.
        /// </para>
        ///  
        /// <para>
        /// The <code>delete disk snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>disk snapshot name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiskSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDiskSnapshot">REST API Reference for DeleteDiskSnapshot Operation</seealso>
        DeleteDiskSnapshotResponse DeleteDiskSnapshot(DeleteDiskSnapshotRequest request);



        /// <summary>
        /// Deletes the specified disk snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a disk, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the disk.
        /// </para>
        ///  
        /// <para>
        /// The <code>delete disk snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>disk snapshot name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiskSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDiskSnapshot">REST API Reference for DeleteDiskSnapshot Operation</seealso>
        Task<DeleteDiskSnapshotResponse> DeleteDiskSnapshotAsync(DeleteDiskSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDistribution


        /// <summary>
        /// Deletes your Amazon Lightsail content delivery network (CDN) distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request);



        /// <summary>
        /// Deletes your Amazon Lightsail content delivery network (CDN) distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>domain name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);



        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>domain name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomainEntry


        /// <summary>
        /// Deletes a specific domain entry.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request);



        /// <summary>
        /// Deletes a specific domain entry.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        Task<DeleteDomainEntryResponse> DeleteDomainEntryAsync(DeleteDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes an Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>delete instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);



        /// <summary>
        /// Deletes an Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>delete instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstanceSnapshot


        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// 
        ///  
        /// <para>
        /// The <code>delete instance snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instance snapshot name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request);



        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// 
        ///  
        /// <para>
        /// The <code>delete instance snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instance snapshot name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(DeleteInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes a specific SSH key pair.
        /// 
        ///  
        /// <para>
        /// The <code>delete key pair</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>key pair name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);



        /// <summary>
        /// Deletes a specific SSH key pair.
        /// 
        ///  
        /// <para>
        /// The <code>delete key pair</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>key pair name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKnownHostKeys


        /// <summary>
        /// Deletes the known host key or certificate used by the Amazon Lightsail browser-based
        /// SSH or RDP clients to authenticate an instance. This operation enables the Lightsail
        /// browser-based SSH or RDP clients to connect to the instance after a host key mismatch.
        /// 
        ///  <important> 
        /// <para>
        /// Perform this operation only if you were expecting the host key or certificate mismatch
        /// or if you are familiar with the new host key or certificate on the instance. For more
        /// information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-troubleshooting-browser-based-ssh-rdp-client-connection">Troubleshooting
        /// connection issues when using the Amazon Lightsail browser-based SSH or RDP client</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnownHostKeys service method.</param>
        /// 
        /// <returns>The response from the DeleteKnownHostKeys service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKnownHostKeys">REST API Reference for DeleteKnownHostKeys Operation</seealso>
        DeleteKnownHostKeysResponse DeleteKnownHostKeys(DeleteKnownHostKeysRequest request);



        /// <summary>
        /// Deletes the known host key or certificate used by the Amazon Lightsail browser-based
        /// SSH or RDP clients to authenticate an instance. This operation enables the Lightsail
        /// browser-based SSH or RDP clients to connect to the instance after a host key mismatch.
        /// 
        ///  <important> 
        /// <para>
        /// Perform this operation only if you were expecting the host key or certificate mismatch
        /// or if you are familiar with the new host key or certificate on the instance. For more
        /// information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-troubleshooting-browser-based-ssh-rdp-client-connection">Troubleshooting
        /// connection issues when using the Amazon Lightsail browser-based SSH or RDP client</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnownHostKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKnownHostKeys service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKnownHostKeys">REST API Reference for DeleteKnownHostKeys Operation</seealso>
        Task<DeleteKnownHostKeysResponse> DeleteKnownHostKeysAsync(DeleteKnownHostKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes a Lightsail load balancer and all its associated SSL/TLS certificates. Once
        /// the load balancer is deleted, you will need to create a new load balancer, create
        /// a new certificate, and verify domain ownership again.
        /// 
        ///  
        /// <para>
        /// The <code>delete load balancer</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>load balancer name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);



        /// <summary>
        /// Deletes a Lightsail load balancer and all its associated SSL/TLS certificates. Once
        /// the load balancer is deleted, you will need to create a new load balancer, create
        /// a new certificate, and verify domain ownership again.
        /// 
        ///  
        /// <para>
        /// The <code>delete load balancer</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>load balancer name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancerTlsCertificate


        /// <summary>
        /// Deletes an SSL/TLS certificate associated with a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerTlsCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancerTlsCertificate">REST API Reference for DeleteLoadBalancerTlsCertificate Operation</seealso>
        DeleteLoadBalancerTlsCertificateResponse DeleteLoadBalancerTlsCertificate(DeleteLoadBalancerTlsCertificateRequest request);



        /// <summary>
        /// Deletes an SSL/TLS certificate associated with a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerTlsCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerTlsCertificate service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancerTlsCertificate">REST API Reference for DeleteLoadBalancerTlsCertificate Operation</seealso>
        Task<DeleteLoadBalancerTlsCertificateResponse> DeleteLoadBalancerTlsCertificateAsync(DeleteLoadBalancerTlsCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRelationalDatabase


        /// <summary>
        /// Deletes a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabase">REST API Reference for DeleteRelationalDatabase Operation</seealso>
        DeleteRelationalDatabaseResponse DeleteRelationalDatabase(DeleteRelationalDatabaseRequest request);



        /// <summary>
        /// Deletes a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabase">REST API Reference for DeleteRelationalDatabase Operation</seealso>
        Task<DeleteRelationalDatabaseResponse> DeleteRelationalDatabaseAsync(DeleteRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRelationalDatabaseSnapshot


        /// <summary>
        /// Deletes a database snapshot in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database snapshot</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabaseSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabaseSnapshot">REST API Reference for DeleteRelationalDatabaseSnapshot Operation</seealso>
        DeleteRelationalDatabaseSnapshotResponse DeleteRelationalDatabaseSnapshot(DeleteRelationalDatabaseSnapshotRequest request);



        /// <summary>
        /// Deletes a database snapshot in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database snapshot</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabaseSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabaseSnapshot">REST API Reference for DeleteRelationalDatabaseSnapshot Operation</seealso>
        Task<DeleteRelationalDatabaseSnapshotResponse> DeleteRelationalDatabaseSnapshotAsync(DeleteRelationalDatabaseSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachCertificateFromDistribution


        /// <summary>
        /// Detaches an SSL/TLS certificate from your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is detached, your distribution stops accepting traffic for all
        /// of the domains that are associated with the certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachCertificateFromDistribution service method.</param>
        /// 
        /// <returns>The response from the DetachCertificateFromDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachCertificateFromDistribution">REST API Reference for DetachCertificateFromDistribution Operation</seealso>
        DetachCertificateFromDistributionResponse DetachCertificateFromDistribution(DetachCertificateFromDistributionRequest request);



        /// <summary>
        /// Detaches an SSL/TLS certificate from your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After the certificate is detached, your distribution stops accepting traffic for all
        /// of the domains that are associated with the certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachCertificateFromDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachCertificateFromDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachCertificateFromDistribution">REST API Reference for DetachCertificateFromDistribution Operation</seealso>
        Task<DetachCertificateFromDistributionResponse> DetachCertificateFromDistributionAsync(DetachCertificateFromDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachDisk


        /// <summary>
        /// Detaches a stopped block storage disk from a Lightsail instance. Make sure to unmount
        /// any file systems on the device within your operating system before stopping the instance
        /// and detaching the disk.
        /// 
        ///  
        /// <para>
        /// The <code>detach disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachDisk service method.</param>
        /// 
        /// <returns>The response from the DetachDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachDisk">REST API Reference for DetachDisk Operation</seealso>
        DetachDiskResponse DetachDisk(DetachDiskRequest request);



        /// <summary>
        /// Detaches a stopped block storage disk from a Lightsail instance. Make sure to unmount
        /// any file systems on the device within your operating system before stopping the instance
        /// and detaching the disk.
        /// 
        ///  
        /// <para>
        /// The <code>detach disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>disk name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachDisk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachDisk">REST API Reference for DetachDisk Operation</seealso>
        Task<DetachDiskResponse> DetachDiskAsync(DetachDiskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachInstancesFromLoadBalancer


        /// <summary>
        /// Detaches the specified instances from a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// This operation waits until the instances are no longer needed before they are detached
        /// from the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The <code>detach instances from load balancer</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by <code>load
        /// balancer name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DetachInstancesFromLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachInstancesFromLoadBalancer">REST API Reference for DetachInstancesFromLoadBalancer Operation</seealso>
        DetachInstancesFromLoadBalancerResponse DetachInstancesFromLoadBalancer(DetachInstancesFromLoadBalancerRequest request);



        /// <summary>
        /// Detaches the specified instances from a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// This operation waits until the instances are no longer needed before they are detached
        /// from the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The <code>detach instances from load balancer</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by <code>load
        /// balancer name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstancesFromLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachInstancesFromLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachInstancesFromLoadBalancer">REST API Reference for DetachInstancesFromLoadBalancer Operation</seealso>
        Task<DetachInstancesFromLoadBalancerResponse> DetachInstancesFromLoadBalancerAsync(DetachInstancesFromLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachStaticIp


        /// <summary>
        /// Detaches a static IP from the Amazon Lightsail instance to which it is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp service method.</param>
        /// 
        /// <returns>The response from the DetachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request);



        /// <summary>
        /// Detaches a static IP from the Amazon Lightsail instance to which it is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        Task<DetachStaticIpResponse> DetachStaticIpAsync(DetachStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableAddOn


        /// <summary>
        /// Disables an add-on for an Amazon Lightsail resource. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAddOn service method.</param>
        /// 
        /// <returns>The response from the DisableAddOn service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DisableAddOn">REST API Reference for DisableAddOn Operation</seealso>
        DisableAddOnResponse DisableAddOn(DisableAddOnRequest request);



        /// <summary>
        /// Disables an add-on for an Amazon Lightsail resource. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAddOn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableAddOn service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DisableAddOn">REST API Reference for DisableAddOn Operation</seealso>
        Task<DisableAddOnResponse> DisableAddOnAsync(DisableAddOnRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DownloadDefaultKeyPair


        /// <summary>
        /// Downloads the default SSH key pair from the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair service method.</param>
        /// 
        /// <returns>The response from the DownloadDefaultKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request);



        /// <summary>
        /// Downloads the default SSH key pair from the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DownloadDefaultKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        Task<DownloadDefaultKeyPairResponse> DownloadDefaultKeyPairAsync(DownloadDefaultKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableAddOn


        /// <summary>
        /// Enables or modifies an add-on for an Amazon Lightsail resource. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAddOn service method.</param>
        /// 
        /// <returns>The response from the EnableAddOn service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/EnableAddOn">REST API Reference for EnableAddOn Operation</seealso>
        EnableAddOnResponse EnableAddOn(EnableAddOnRequest request);



        /// <summary>
        /// Enables or modifies an add-on for an Amazon Lightsail resource. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAddOn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableAddOn service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/EnableAddOn">REST API Reference for EnableAddOn Operation</seealso>
        Task<EnableAddOnResponse> EnableAddOnAsync(EnableAddOnRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportSnapshot


        /// <summary>
        /// Exports an Amazon Lightsail instance or block storage disk snapshot to Amazon Elastic
        /// Compute Cloud (Amazon EC2). This operation results in an export snapshot record that
        /// can be used with the <code>create cloud formation stack</code> operation to create
        /// new Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Exported instance snapshots appear in Amazon EC2 as Amazon Machine Images (AMIs),
        /// and the instance system disk appears as an Amazon Elastic Block Store (Amazon EBS)
        /// volume. Exported disk snapshots appear in Amazon EC2 as Amazon EBS volumes. Snapshots
        /// are exported to the same Amazon Web Services Region in Amazon EC2 as the source Lightsail
        /// snapshot.
        /// </para>
        ///   
        /// <para>
        /// The <code>export snapshot</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>source snapshot name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use the <code>get instance snapshots</code> or <code>get disk snapshots</code> operations
        /// to get a list of snapshots that you can export to Amazon EC2.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
        /// 
        /// <returns>The response from the ExportSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request);



        /// <summary>
        /// Exports an Amazon Lightsail instance or block storage disk snapshot to Amazon Elastic
        /// Compute Cloud (Amazon EC2). This operation results in an export snapshot record that
        /// can be used with the <code>create cloud formation stack</code> operation to create
        /// new Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Exported instance snapshots appear in Amazon EC2 as Amazon Machine Images (AMIs),
        /// and the instance system disk appears as an Amazon Elastic Block Store (Amazon EBS)
        /// volume. Exported disk snapshots appear in Amazon EC2 as Amazon EBS volumes. Snapshots
        /// are exported to the same Amazon Web Services Region in Amazon EC2 as the source Lightsail
        /// snapshot.
        /// </para>
        ///   
        /// <para>
        /// The <code>export snapshot</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>source snapshot name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use the <code>get instance snapshots</code> or <code>get disk snapshots</code> operations
        /// to get a list of snapshots that you can export to Amazon EC2.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetActiveNames


        /// <summary>
        /// Returns the names of all active (not deleted) resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames service method.</param>
        /// 
        /// <returns>The response from the GetActiveNames service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request);



        /// <summary>
        /// Returns the names of all active (not deleted) resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetActiveNames service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        Task<GetActiveNamesResponse> GetActiveNamesAsync(GetActiveNamesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAlarms


        /// <summary>
        /// Returns information about the configured alarms. Specify an alarm name in your request
        /// to return information about a specific alarm, or specify a monitored resource name
        /// to return information about all alarms for a specific resource.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlarms service method.</param>
        /// 
        /// <returns>The response from the GetAlarms service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAlarms">REST API Reference for GetAlarms Operation</seealso>
        GetAlarmsResponse GetAlarms(GetAlarmsRequest request);



        /// <summary>
        /// Returns information about the configured alarms. Specify an alarm name in your request
        /// to return information about a specific alarm, or specify a monitored resource name
        /// to return information about all alarms for a specific resource.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlarms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlarms service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAlarms">REST API Reference for GetAlarms Operation</seealso>
        Task<GetAlarmsResponse> GetAlarmsAsync(GetAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAutoSnapshots


        /// <summary>
        /// Returns the available automatic snapshots for an instance or disk. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetAutoSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAutoSnapshots">REST API Reference for GetAutoSnapshots Operation</seealso>
        GetAutoSnapshotsResponse GetAutoSnapshots(GetAutoSnapshotsRequest request);



        /// <summary>
        /// Returns the available automatic snapshots for an instance or disk. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
        /// Dev Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAutoSnapshots">REST API Reference for GetAutoSnapshots Operation</seealso>
        Task<GetAutoSnapshotsResponse> GetAutoSnapshotsAsync(GetAutoSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBlueprints


        /// <summary>
        /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
        /// blueprint to create a new instance already running a specific operating system, as
        /// well as a preinstalled app or development stack. The software each instance is running
        /// depends on the blueprint image you choose.
        /// 
        ///  <note> 
        /// <para>
        /// Use active blueprints when creating new instances. Inactive blueprints are listed
        /// to support customers with existing instances and are not necessarily available to
        /// create new instances. Blueprints are marked inactive when they become outdated due
        /// to operating system updates or new application releases.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints service method.</param>
        /// 
        /// <returns>The response from the GetBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request);



        /// <summary>
        /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
        /// blueprint to create a new instance already running a specific operating system, as
        /// well as a preinstalled app or development stack. The software each instance is running
        /// depends on the blueprint image you choose.
        /// 
        ///  <note> 
        /// <para>
        /// Use active blueprints when creating new instances. Inactive blueprints are listed
        /// to support customers with existing instances and are not necessarily available to
        /// create new instances. Blueprints are marked inactive when they become outdated due
        /// to operating system updates or new application releases.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        Task<GetBlueprintsResponse> GetBlueprintsAsync(GetBlueprintsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBundles


        /// <summary>
        /// Returns the list of bundles that are available for purchase. A bundle describes the
        /// specs for your virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBundles service method.</param>
        /// 
        /// <returns>The response from the GetBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        GetBundlesResponse GetBundles(GetBundlesRequest request);



        /// <summary>
        /// Returns the list of bundles that are available for purchase. A bundle describes the
        /// specs for your virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        Task<GetBundlesResponse> GetBundlesAsync(GetBundlesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificates


        /// <summary>
        /// Returns information about one or more Amazon Lightsail SSL/TLS certificates.
        /// 
        ///  <note> 
        /// <para>
        /// To get a summary of a certificate, ommit <code>includeCertificateDetails</code> from
        /// your request. The response will include only the certificate Amazon Resource Name
        /// (ARN), certificate name, domain name, and tags.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificates service method.</param>
        /// 
        /// <returns>The response from the GetCertificates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCertificates">REST API Reference for GetCertificates Operation</seealso>
        GetCertificatesResponse GetCertificates(GetCertificatesRequest request);



        /// <summary>
        /// Returns information about one or more Amazon Lightsail SSL/TLS certificates.
        /// 
        ///  <note> 
        /// <para>
        /// To get a summary of a certificate, ommit <code>includeCertificateDetails</code> from
        /// your request. The response will include only the certificate Amazon Resource Name
        /// (ARN), certificate name, domain name, and tags.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCertificates">REST API Reference for GetCertificates Operation</seealso>
        Task<GetCertificatesResponse> GetCertificatesAsync(GetCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCloudFormationStackRecords


        /// <summary>
        /// Returns the CloudFormation stack record created as a result of the <code>create cloud
        /// formation stack</code> operation.
        /// 
        ///  
        /// <para>
        /// An AWS CloudFormation stack is used to create a new Amazon EC2 instance from an exported
        /// Lightsail snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationStackRecords service method.</param>
        /// 
        /// <returns>The response from the GetCloudFormationStackRecords service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCloudFormationStackRecords">REST API Reference for GetCloudFormationStackRecords Operation</seealso>
        GetCloudFormationStackRecordsResponse GetCloudFormationStackRecords(GetCloudFormationStackRecordsRequest request);



        /// <summary>
        /// Returns the CloudFormation stack record created as a result of the <code>create cloud
        /// formation stack</code> operation.
        /// 
        ///  
        /// <para>
        /// An AWS CloudFormation stack is used to create a new Amazon EC2 instance from an exported
        /// Lightsail snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationStackRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFormationStackRecords service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCloudFormationStackRecords">REST API Reference for GetCloudFormationStackRecords Operation</seealso>
        Task<GetCloudFormationStackRecordsResponse> GetCloudFormationStackRecordsAsync(GetCloudFormationStackRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContactMethods


        /// <summary>
        /// Returns information about the configured contact methods. Specify a protocol in your
        /// request to return information about a specific contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactMethods service method.</param>
        /// 
        /// <returns>The response from the GetContactMethods service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContactMethods">REST API Reference for GetContactMethods Operation</seealso>
        GetContactMethodsResponse GetContactMethods(GetContactMethodsRequest request);



        /// <summary>
        /// Returns information about the configured contact methods. Specify a protocol in your
        /// request to return information about a specific contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactMethods service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactMethods service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContactMethods">REST API Reference for GetContactMethods Operation</seealso>
        Task<GetContactMethodsResponse> GetContactMethodsAsync(GetContactMethodsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerAPIMetadata


        /// <summary>
        /// Returns information about Amazon Lightsail containers, such as the current version
        /// of the Lightsail Control (lightsailctl) plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerAPIMetadata service method.</param>
        /// 
        /// <returns>The response from the GetContainerAPIMetadata service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerAPIMetadata">REST API Reference for GetContainerAPIMetadata Operation</seealso>
        GetContainerAPIMetadataResponse GetContainerAPIMetadata(GetContainerAPIMetadataRequest request);



        /// <summary>
        /// Returns information about Amazon Lightsail containers, such as the current version
        /// of the Lightsail Control (lightsailctl) plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerAPIMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerAPIMetadata service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerAPIMetadata">REST API Reference for GetContainerAPIMetadata Operation</seealso>
        Task<GetContainerAPIMetadataResponse> GetContainerAPIMetadataAsync(GetContainerAPIMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerImages


        /// <summary>
        /// Returns the container images that are registered to your Amazon Lightsail container
        /// service.
        /// 
        ///  <note> 
        /// <para>
        /// If you created a deployment on your Lightsail container service that uses container
        /// images from a public registry like Docker Hub, those images are not returned as part
        /// of this action. Those images are not registered to your Lightsail container service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerImages service method.</param>
        /// 
        /// <returns>The response from the GetContainerImages service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerImages">REST API Reference for GetContainerImages Operation</seealso>
        GetContainerImagesResponse GetContainerImages(GetContainerImagesRequest request);



        /// <summary>
        /// Returns the container images that are registered to your Amazon Lightsail container
        /// service.
        /// 
        ///  <note> 
        /// <para>
        /// If you created a deployment on your Lightsail container service that uses container
        /// images from a public registry like Docker Hub, those images are not returned as part
        /// of this action. Those images are not registered to your Lightsail container service.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerImages service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerImages">REST API Reference for GetContainerImages Operation</seealso>
        Task<GetContainerImagesResponse> GetContainerImagesAsync(GetContainerImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerLog


        /// <summary>
        /// Returns the log events of a container of your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// If your container service has more than one node (i.e., a scale greater than 1), then
        /// the log events that are returned for the specified container are merged from all nodes
        /// on your container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// Container logs are retained for a certain amount of time. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon Lightsail
        /// endpoints and quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerLog service method.</param>
        /// 
        /// <returns>The response from the GetContainerLog service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerLog">REST API Reference for GetContainerLog Operation</seealso>
        GetContainerLogResponse GetContainerLog(GetContainerLogRequest request);



        /// <summary>
        /// Returns the log events of a container of your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// If your container service has more than one node (i.e., a scale greater than 1), then
        /// the log events that are returned for the specified container are merged from all nodes
        /// on your container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// Container logs are retained for a certain amount of time. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon Lightsail
        /// endpoints and quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerLog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerLog service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerLog">REST API Reference for GetContainerLog Operation</seealso>
        Task<GetContainerLogResponse> GetContainerLogAsync(GetContainerLogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerServiceDeployments


        /// <summary>
        /// Returns the deployments for your Amazon Lightsail container service
        /// 
        ///  
        /// <para>
        /// A deployment specifies the settings, such as the ports and launch command, of containers
        /// that are deployed to your container service.
        /// </para>
        ///  
        /// <para>
        /// The deployments are ordered by version in ascending order. The newest version is listed
        /// at the top of the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// A set number of deployments are kept before the oldest one is replaced with the newest
        /// one. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon
        /// Lightsail endpoints and quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceDeployments service method.</param>
        /// 
        /// <returns>The response from the GetContainerServiceDeployments service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceDeployments">REST API Reference for GetContainerServiceDeployments Operation</seealso>
        GetContainerServiceDeploymentsResponse GetContainerServiceDeployments(GetContainerServiceDeploymentsRequest request);



        /// <summary>
        /// Returns the deployments for your Amazon Lightsail container service
        /// 
        ///  
        /// <para>
        /// A deployment specifies the settings, such as the ports and launch command, of containers
        /// that are deployed to your container service.
        /// </para>
        ///  
        /// <para>
        /// The deployments are ordered by version in ascending order. The newest version is listed
        /// at the top of the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// A set number of deployments are kept before the oldest one is replaced with the newest
        /// one. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon
        /// Lightsail endpoints and quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerServiceDeployments service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceDeployments">REST API Reference for GetContainerServiceDeployments Operation</seealso>
        Task<GetContainerServiceDeploymentsResponse> GetContainerServiceDeploymentsAsync(GetContainerServiceDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerServiceMetricData


        /// <summary>
        /// Returns the data points of a specific metric of your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources. Monitor and collect metric data
        /// regularly to maintain the reliability, availability, and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceMetricData service method.</param>
        /// 
        /// <returns>The response from the GetContainerServiceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceMetricData">REST API Reference for GetContainerServiceMetricData Operation</seealso>
        GetContainerServiceMetricDataResponse GetContainerServiceMetricData(GetContainerServiceMetricDataRequest request);



        /// <summary>
        /// Returns the data points of a specific metric of your Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources. Monitor and collect metric data
        /// regularly to maintain the reliability, availability, and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerServiceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceMetricData">REST API Reference for GetContainerServiceMetricData Operation</seealso>
        Task<GetContainerServiceMetricDataResponse> GetContainerServiceMetricDataAsync(GetContainerServiceMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerServicePowers


        /// <summary>
        /// Returns the list of powers that can be specified for your Amazon Lightsail container
        /// services.
        /// 
        ///  
        /// <para>
        /// The power specifies the amount of memory, the number of vCPUs, and the base price
        /// of the container service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServicePowers service method.</param>
        /// 
        /// <returns>The response from the GetContainerServicePowers service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServicePowers">REST API Reference for GetContainerServicePowers Operation</seealso>
        GetContainerServicePowersResponse GetContainerServicePowers(GetContainerServicePowersRequest request);



        /// <summary>
        /// Returns the list of powers that can be specified for your Amazon Lightsail container
        /// services.
        /// 
        ///  
        /// <para>
        /// The power specifies the amount of memory, the number of vCPUs, and the base price
        /// of the container service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServicePowers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerServicePowers service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServicePowers">REST API Reference for GetContainerServicePowers Operation</seealso>
        Task<GetContainerServicePowersResponse> GetContainerServicePowersAsync(GetContainerServicePowersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerServices


        /// <summary>
        /// Returns information about one or more of your Amazon Lightsail container services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServices service method.</param>
        /// 
        /// <returns>The response from the GetContainerServices service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServices">REST API Reference for GetContainerServices Operation</seealso>
        GetContainerServicesResponse GetContainerServices(GetContainerServicesRequest request);



        /// <summary>
        /// Returns information about one or more of your Amazon Lightsail container services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContainerServices service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServices">REST API Reference for GetContainerServices Operation</seealso>
        Task<GetContainerServicesResponse> GetContainerServicesAsync(GetContainerServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDisk


        /// <summary>
        /// Returns information about a specific block storage disk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDisk service method.</param>
        /// 
        /// <returns>The response from the GetDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisk">REST API Reference for GetDisk Operation</seealso>
        GetDiskResponse GetDisk(GetDiskRequest request);



        /// <summary>
        /// Returns information about a specific block storage disk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDisk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDisk service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisk">REST API Reference for GetDisk Operation</seealso>
        Task<GetDiskResponse> GetDiskAsync(GetDiskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDisks


        /// <summary>
        /// Returns information about all block storage disks in your AWS account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDisks service method.</param>
        /// 
        /// <returns>The response from the GetDisks service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisks">REST API Reference for GetDisks Operation</seealso>
        GetDisksResponse GetDisks(GetDisksRequest request);



        /// <summary>
        /// Returns information about all block storage disks in your AWS account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDisks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDisks service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisks">REST API Reference for GetDisks Operation</seealso>
        Task<GetDisksResponse> GetDisksAsync(GetDisksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDiskSnapshot


        /// <summary>
        /// Returns information about a specific block storage disk snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshot">REST API Reference for GetDiskSnapshot Operation</seealso>
        GetDiskSnapshotResponse GetDiskSnapshot(GetDiskSnapshotRequest request);



        /// <summary>
        /// Returns information about a specific block storage disk snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiskSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshot">REST API Reference for GetDiskSnapshot Operation</seealso>
        Task<GetDiskSnapshotResponse> GetDiskSnapshotAsync(GetDiskSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDiskSnapshots


        /// <summary>
        /// Returns information about all block storage disk snapshots in your AWS account and
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetDiskSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshots">REST API Reference for GetDiskSnapshots Operation</seealso>
        GetDiskSnapshotsResponse GetDiskSnapshots(GetDiskSnapshotsRequest request);



        /// <summary>
        /// Returns information about all block storage disk snapshots in your AWS account and
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiskSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshots">REST API Reference for GetDiskSnapshots Operation</seealso>
        Task<GetDiskSnapshotsResponse> GetDiskSnapshotsAsync(GetDiskSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistributionBundles


        /// <summary>
        /// Returns the list bundles that can be applied to you Amazon Lightsail content delivery
        /// network (CDN) distributions.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your dsitribution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionBundles service method.</param>
        /// 
        /// <returns>The response from the GetDistributionBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionBundles">REST API Reference for GetDistributionBundles Operation</seealso>
        GetDistributionBundlesResponse GetDistributionBundles(GetDistributionBundlesRequest request);



        /// <summary>
        /// Returns the list bundles that can be applied to you Amazon Lightsail content delivery
        /// network (CDN) distributions.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your dsitribution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionBundles">REST API Reference for GetDistributionBundles Operation</seealso>
        Task<GetDistributionBundlesResponse> GetDistributionBundlesAsync(GetDistributionBundlesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistributionLatestCacheReset


        /// <summary>
        /// Returns the timestamp and status of the last cache reset of a specific Amazon Lightsail
        /// content delivery network (CDN) distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionLatestCacheReset service method.</param>
        /// 
        /// <returns>The response from the GetDistributionLatestCacheReset service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionLatestCacheReset">REST API Reference for GetDistributionLatestCacheReset Operation</seealso>
        GetDistributionLatestCacheResetResponse GetDistributionLatestCacheReset(GetDistributionLatestCacheResetRequest request);



        /// <summary>
        /// Returns the timestamp and status of the last cache reset of a specific Amazon Lightsail
        /// content delivery network (CDN) distribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionLatestCacheReset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionLatestCacheReset service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionLatestCacheReset">REST API Reference for GetDistributionLatestCacheReset Operation</seealso>
        Task<GetDistributionLatestCacheResetResponse> GetDistributionLatestCacheResetAsync(GetDistributionLatestCacheResetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistributionMetricData


        /// <summary>
        /// Returns the data points of a specific metric for an Amazon Lightsail content delivery
        /// network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionMetricData service method.</param>
        /// 
        /// <returns>The response from the GetDistributionMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionMetricData">REST API Reference for GetDistributionMetricData Operation</seealso>
        GetDistributionMetricDataResponse GetDistributionMetricData(GetDistributionMetricDataRequest request);



        /// <summary>
        /// Returns the data points of a specific metric for an Amazon Lightsail content delivery
        /// network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionMetricData">REST API Reference for GetDistributionMetricData Operation</seealso>
        Task<GetDistributionMetricDataResponse> GetDistributionMetricDataAsync(GetDistributionMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDistributions


        /// <summary>
        /// Returns information about one or more of your Amazon Lightsail content delivery network
        /// (CDN) distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributions service method.</param>
        /// 
        /// <returns>The response from the GetDistributions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributions">REST API Reference for GetDistributions Operation</seealso>
        GetDistributionsResponse GetDistributions(GetDistributionsRequest request);



        /// <summary>
        /// Returns information about one or more of your Amazon Lightsail content delivery network
        /// (CDN) distributions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDistributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributions">REST API Reference for GetDistributions Operation</seealso>
        Task<GetDistributionsResponse> GetDistributionsAsync(GetDistributionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Returns information about a specific domain recordset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);



        /// <summary>
        /// Returns information about a specific domain recordset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomains


        /// <summary>
        /// Returns a list of all domains in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomains service method.</param>
        /// 
        /// <returns>The response from the GetDomains service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        GetDomainsResponse GetDomains(GetDomainsRequest request);



        /// <summary>
        /// Returns a list of all domains in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomains service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        Task<GetDomainsResponse> GetDomainsAsync(GetDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExportSnapshotRecords


        /// <summary>
        /// Returns the export snapshot record created as a result of the <code>export snapshot</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// An export snapshot record can be used to create a new Amazon EC2 instance and its
        /// related resources with the <code>create cloud formation stack</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportSnapshotRecords service method.</param>
        /// 
        /// <returns>The response from the GetExportSnapshotRecords service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetExportSnapshotRecords">REST API Reference for GetExportSnapshotRecords Operation</seealso>
        GetExportSnapshotRecordsResponse GetExportSnapshotRecords(GetExportSnapshotRecordsRequest request);



        /// <summary>
        /// Returns the export snapshot record created as a result of the <code>export snapshot</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// An export snapshot record can be used to create a new Amazon EC2 instance and its
        /// related resources with the <code>create cloud formation stack</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportSnapshotRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExportSnapshotRecords service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetExportSnapshotRecords">REST API Reference for GetExportSnapshotRecords Operation</seealso>
        Task<GetExportSnapshotRecordsResponse> GetExportSnapshotRecordsAsync(GetExportSnapshotRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstance


        /// <summary>
        /// Returns information about a specific Amazon Lightsail instance, which is a virtual
        /// private server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse GetInstance(GetInstanceRequest request);



        /// <summary>
        /// Returns information about a specific Amazon Lightsail instance, which is a virtual
        /// private server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceAccessDetails


        /// <summary>
        /// Returns temporary SSH keys you can use to connect to a specific virtual private server,
        /// or <i>instance</i>.
        /// 
        ///  
        /// <para>
        /// The <code>get instance access details</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instance name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails service method.</param>
        /// 
        /// <returns>The response from the GetInstanceAccessDetails service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request);



        /// <summary>
        /// Returns temporary SSH keys you can use to connect to a specific virtual private server,
        /// or <i>instance</i>.
        /// 
        ///  
        /// <para>
        /// The <code>get instance access details</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instance name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceAccessDetails service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        Task<GetInstanceAccessDetailsResponse> GetInstanceAccessDetailsAsync(GetInstanceAccessDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceMetricData


        /// <summary>
        /// Returns the data points for the specified Amazon Lightsail instance metric, given
        /// an instance name.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData service method.</param>
        /// 
        /// <returns>The response from the GetInstanceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request);



        /// <summary>
        /// Returns the data points for the specified Amazon Lightsail instance metric, given
        /// an instance name.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        Task<GetInstanceMetricDataResponse> GetInstanceMetricDataAsync(GetInstanceMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstancePortStates


        /// <summary>
        /// Returns the firewall port states for a specific Amazon Lightsail instance, the IP
        /// addresses allowed to connect to the instance through the ports, and the protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates service method.</param>
        /// 
        /// <returns>The response from the GetInstancePortStates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request);



        /// <summary>
        /// Returns the firewall port states for a specific Amazon Lightsail instance, the IP
        /// addresses allowed to connect to the instance through the ports, and the protocol.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstancePortStates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        Task<GetInstancePortStatesResponse> GetInstancePortStatesAsync(GetInstancePortStatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstances


        /// <summary>
        /// Returns information about all Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstances service method.</param>
        /// 
        /// <returns>The response from the GetInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        GetInstancesResponse GetInstances(GetInstancesRequest request);



        /// <summary>
        /// Returns information about all Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceSnapshot


        /// <summary>
        /// Returns information about a specific instance snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request);



        /// <summary>
        /// Returns information about a specific instance snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(GetInstanceSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceSnapshots


        /// <summary>
        /// Returns all instance snapshots for the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request);



        /// <summary>
        /// Returns all instance snapshots for the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        Task<GetInstanceSnapshotsResponse> GetInstanceSnapshotsAsync(GetInstanceSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceState


        /// <summary>
        /// Returns the state of a specific instance. Works on one instance at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState service method.</param>
        /// 
        /// <returns>The response from the GetInstanceState service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request);



        /// <summary>
        /// Returns the state of a specific instance. Works on one instance at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstanceState service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        Task<GetInstanceStateResponse> GetInstanceStateAsync(GetInstanceStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyPair


        /// <summary>
        /// Returns information about a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair service method.</param>
        /// 
        /// <returns>The response from the GetKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        GetKeyPairResponse GetKeyPair(GetKeyPairRequest request);



        /// <summary>
        /// Returns information about a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        Task<GetKeyPairResponse> GetKeyPairAsync(GetKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKeyPairs


        /// <summary>
        /// Returns information about all key pairs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs service method.</param>
        /// 
        /// <returns>The response from the GetKeyPairs service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request);



        /// <summary>
        /// Returns information about all key pairs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPairs service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        Task<GetKeyPairsResponse> GetKeyPairsAsync(GetKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoadBalancer


        /// <summary>
        /// Returns information about the specified Lightsail load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the GetLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancer">REST API Reference for GetLoadBalancer Operation</seealso>
        GetLoadBalancerResponse GetLoadBalancer(GetLoadBalancerRequest request);



        /// <summary>
        /// Returns information about the specified Lightsail load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoadBalancer service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancer">REST API Reference for GetLoadBalancer Operation</seealso>
        Task<GetLoadBalancerResponse> GetLoadBalancerAsync(GetLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoadBalancerMetricData


        /// <summary>
        /// Returns information about health metrics for your Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerMetricData service method.</param>
        /// 
        /// <returns>The response from the GetLoadBalancerMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerMetricData">REST API Reference for GetLoadBalancerMetricData Operation</seealso>
        GetLoadBalancerMetricDataResponse GetLoadBalancerMetricData(GetLoadBalancerMetricDataRequest request);



        /// <summary>
        /// Returns information about health metrics for your Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoadBalancerMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerMetricData">REST API Reference for GetLoadBalancerMetricData Operation</seealso>
        Task<GetLoadBalancerMetricDataResponse> GetLoadBalancerMetricDataAsync(GetLoadBalancerMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoadBalancers


        /// <summary>
        /// Returns information about all load balancers in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the GetLoadBalancers service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancers">REST API Reference for GetLoadBalancers Operation</seealso>
        GetLoadBalancersResponse GetLoadBalancers(GetLoadBalancersRequest request);



        /// <summary>
        /// Returns information about all load balancers in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoadBalancers service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancers">REST API Reference for GetLoadBalancers Operation</seealso>
        Task<GetLoadBalancersResponse> GetLoadBalancersAsync(GetLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoadBalancerTlsCertificates


        /// <summary>
        /// Returns information about the TLS certificates that are associated with the specified
        /// Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 2 certificates associated with a Lightsail load balancer.
        /// One is active and the other is inactive.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsCertificates service method.</param>
        /// 
        /// <returns>The response from the GetLoadBalancerTlsCertificates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsCertificates">REST API Reference for GetLoadBalancerTlsCertificates Operation</seealso>
        GetLoadBalancerTlsCertificatesResponse GetLoadBalancerTlsCertificates(GetLoadBalancerTlsCertificatesRequest request);



        /// <summary>
        /// Returns information about the TLS certificates that are associated with the specified
        /// Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 2 certificates associated with a Lightsail load balancer.
        /// One is active and the other is inactive.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoadBalancerTlsCertificates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsCertificates">REST API Reference for GetLoadBalancerTlsCertificates Operation</seealso>
        Task<GetLoadBalancerTlsCertificatesResponse> GetLoadBalancerTlsCertificatesAsync(GetLoadBalancerTlsCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// Returns information about a specific operation. Operations include events such as
        /// when you create an instance, allocate a static IP, attach a static IP, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse GetOperation(GetOperationRequest request);



        /// <summary>
        /// Returns information about a specific operation. Operations include events such as
        /// when you create an instance, allocate a static IP, attach a static IP, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperations


        /// <summary>
        /// Returns information about all operations.
        /// 
        ///  
        /// <para>
        /// Results are returned from oldest to newest, up to a maximum of 200. Results can be
        /// paged by making each subsequent call to <code>GetOperations</code> use the maximum
        /// (last) <code>statusChangedAt</code> value from the previous request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperations service method.</param>
        /// 
        /// <returns>The response from the GetOperations service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        GetOperationsResponse GetOperations(GetOperationsRequest request);



        /// <summary>
        /// Returns information about all operations.
        /// 
        ///  
        /// <para>
        /// Results are returned from oldest to newest, up to a maximum of 200. Results can be
        /// paged by making each subsequent call to <code>GetOperations</code> use the maximum
        /// (last) <code>statusChangedAt</code> value from the previous request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperations service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        Task<GetOperationsResponse> GetOperationsAsync(GetOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperationsForResource


        /// <summary>
        /// Gets operations for a specific resource (e.g., an instance or a static IP).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource service method.</param>
        /// 
        /// <returns>The response from the GetOperationsForResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request);



        /// <summary>
        /// Gets operations for a specific resource (e.g., an instance or a static IP).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperationsForResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        Task<GetOperationsForResourceResponse> GetOperationsForResourceAsync(GetOperationsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegions


        /// <summary>
        /// Returns a list of all valid regions for Amazon Lightsail. Use the <code>include availability
        /// zones</code> parameter to also return the Availability Zones in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegions service method.</param>
        /// 
        /// <returns>The response from the GetRegions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        GetRegionsResponse GetRegions(GetRegionsRequest request);



        /// <summary>
        /// Returns a list of all valid regions for Amazon Lightsail. Use the <code>include availability
        /// zones</code> parameter to also return the Availability Zones in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        Task<GetRegionsResponse> GetRegionsAsync(GetRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabase


        /// <summary>
        /// Returns information about a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabase">REST API Reference for GetRelationalDatabase Operation</seealso>
        GetRelationalDatabaseResponse GetRelationalDatabase(GetRelationalDatabaseRequest request);



        /// <summary>
        /// Returns information about a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabase">REST API Reference for GetRelationalDatabase Operation</seealso>
        Task<GetRelationalDatabaseResponse> GetRelationalDatabaseAsync(GetRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseBlueprints


        /// <summary>
        /// Returns a list of available database blueprints in Amazon Lightsail. A blueprint describes
        /// the major engine version of a database.
        /// 
        ///  
        /// <para>
        /// You can use a blueprint ID to create a new database that runs a specific database
        /// engine.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBlueprints service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBlueprints">REST API Reference for GetRelationalDatabaseBlueprints Operation</seealso>
        GetRelationalDatabaseBlueprintsResponse GetRelationalDatabaseBlueprints(GetRelationalDatabaseBlueprintsRequest request);



        /// <summary>
        /// Returns a list of available database blueprints in Amazon Lightsail. A blueprint describes
        /// the major engine version of a database.
        /// 
        ///  
        /// <para>
        /// You can use a blueprint ID to create a new database that runs a specific database
        /// engine.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBlueprints">REST API Reference for GetRelationalDatabaseBlueprints Operation</seealso>
        Task<GetRelationalDatabaseBlueprintsResponse> GetRelationalDatabaseBlueprintsAsync(GetRelationalDatabaseBlueprintsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseBundles


        /// <summary>
        /// Returns the list of bundles that are available in Amazon Lightsail. A bundle describes
        /// the performance specifications for a database.
        /// 
        ///  
        /// <para>
        /// You can use a bundle ID to create a new database with explicit performance specifications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBundles service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBundles">REST API Reference for GetRelationalDatabaseBundles Operation</seealso>
        GetRelationalDatabaseBundlesResponse GetRelationalDatabaseBundles(GetRelationalDatabaseBundlesRequest request);



        /// <summary>
        /// Returns the list of bundles that are available in Amazon Lightsail. A bundle describes
        /// the performance specifications for a database.
        /// 
        ///  
        /// <para>
        /// You can use a bundle ID to create a new database with explicit performance specifications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBundles">REST API Reference for GetRelationalDatabaseBundles Operation</seealso>
        Task<GetRelationalDatabaseBundlesResponse> GetRelationalDatabaseBundlesAsync(GetRelationalDatabaseBundlesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseEvents


        /// <summary>
        /// Returns a list of events for a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseEvents service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseEvents service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseEvents">REST API Reference for GetRelationalDatabaseEvents Operation</seealso>
        GetRelationalDatabaseEventsResponse GetRelationalDatabaseEvents(GetRelationalDatabaseEventsRequest request);



        /// <summary>
        /// Returns a list of events for a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseEvents service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseEvents">REST API Reference for GetRelationalDatabaseEvents Operation</seealso>
        Task<GetRelationalDatabaseEventsResponse> GetRelationalDatabaseEventsAsync(GetRelationalDatabaseEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseLogEvents


        /// <summary>
        /// Returns a list of log events for a database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogEvents service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseLogEvents service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogEvents">REST API Reference for GetRelationalDatabaseLogEvents Operation</seealso>
        GetRelationalDatabaseLogEventsResponse GetRelationalDatabaseLogEvents(GetRelationalDatabaseLogEventsRequest request);



        /// <summary>
        /// Returns a list of log events for a database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseLogEvents service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogEvents">REST API Reference for GetRelationalDatabaseLogEvents Operation</seealso>
        Task<GetRelationalDatabaseLogEventsResponse> GetRelationalDatabaseLogEventsAsync(GetRelationalDatabaseLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseLogStreams


        /// <summary>
        /// Returns a list of available log streams for a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogStreams service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseLogStreams service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogStreams">REST API Reference for GetRelationalDatabaseLogStreams Operation</seealso>
        GetRelationalDatabaseLogStreamsResponse GetRelationalDatabaseLogStreams(GetRelationalDatabaseLogStreamsRequest request);



        /// <summary>
        /// Returns a list of available log streams for a specific database in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseLogStreams service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogStreams">REST API Reference for GetRelationalDatabaseLogStreams Operation</seealso>
        Task<GetRelationalDatabaseLogStreamsResponse> GetRelationalDatabaseLogStreamsAsync(GetRelationalDatabaseLogStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseMasterUserPassword


        /// <summary>
        /// Returns the current, previous, or pending versions of the master user password for
        /// a Lightsail database.
        /// 
        ///  
        /// <para>
        /// The <code>GetRelationalDatabaseMasterUserPassword</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMasterUserPassword service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseMasterUserPassword service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMasterUserPassword">REST API Reference for GetRelationalDatabaseMasterUserPassword Operation</seealso>
        GetRelationalDatabaseMasterUserPasswordResponse GetRelationalDatabaseMasterUserPassword(GetRelationalDatabaseMasterUserPasswordRequest request);



        /// <summary>
        /// Returns the current, previous, or pending versions of the master user password for
        /// a Lightsail database.
        /// 
        ///  
        /// <para>
        /// The <code>GetRelationalDatabaseMasterUserPassword</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMasterUserPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseMasterUserPassword service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMasterUserPassword">REST API Reference for GetRelationalDatabaseMasterUserPassword Operation</seealso>
        Task<GetRelationalDatabaseMasterUserPasswordResponse> GetRelationalDatabaseMasterUserPasswordAsync(GetRelationalDatabaseMasterUserPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseMetricData


        /// <summary>
        /// Returns the data points of the specified metric for a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMetricData service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMetricData">REST API Reference for GetRelationalDatabaseMetricData Operation</seealso>
        GetRelationalDatabaseMetricDataResponse GetRelationalDatabaseMetricData(GetRelationalDatabaseMetricDataRequest request);



        /// <summary>
        /// Returns the data points of the specified metric for a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of your resources, and the error counts generated by
        /// them. Monitor and collect metric data regularly to maintain the reliability, availability,
        /// and performance of your resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMetricData">REST API Reference for GetRelationalDatabaseMetricData Operation</seealso>
        Task<GetRelationalDatabaseMetricDataResponse> GetRelationalDatabaseMetricDataAsync(GetRelationalDatabaseMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseParameters


        /// <summary>
        /// Returns all of the runtime parameters offered by the underlying database software,
        /// or engine, for a specific database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// In addition to the parameter names and values, this operation returns other information
        /// about each parameter. This information includes whether changes require a reboot,
        /// whether the parameter is modifiable, the allowed values, and the data types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseParameters service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseParameters service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseParameters">REST API Reference for GetRelationalDatabaseParameters Operation</seealso>
        GetRelationalDatabaseParametersResponse GetRelationalDatabaseParameters(GetRelationalDatabaseParametersRequest request);



        /// <summary>
        /// Returns all of the runtime parameters offered by the underlying database software,
        /// or engine, for a specific database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// In addition to the parameter names and values, this operation returns other information
        /// about each parameter. This information includes whether changes require a reboot,
        /// whether the parameter is modifiable, the allowed values, and the data types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseParameters service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseParameters">REST API Reference for GetRelationalDatabaseParameters Operation</seealso>
        Task<GetRelationalDatabaseParametersResponse> GetRelationalDatabaseParametersAsync(GetRelationalDatabaseParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabases


        /// <summary>
        /// Returns information about all of your databases in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabases service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabases service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabases">REST API Reference for GetRelationalDatabases Operation</seealso>
        GetRelationalDatabasesResponse GetRelationalDatabases(GetRelationalDatabasesRequest request);



        /// <summary>
        /// Returns information about all of your databases in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabases service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabases">REST API Reference for GetRelationalDatabases Operation</seealso>
        Task<GetRelationalDatabasesResponse> GetRelationalDatabasesAsync(GetRelationalDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseSnapshot


        /// <summary>
        /// Returns information about a specific database snapshot in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshot">REST API Reference for GetRelationalDatabaseSnapshot Operation</seealso>
        GetRelationalDatabaseSnapshotResponse GetRelationalDatabaseSnapshot(GetRelationalDatabaseSnapshotRequest request);



        /// <summary>
        /// Returns information about a specific database snapshot in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshot">REST API Reference for GetRelationalDatabaseSnapshot Operation</seealso>
        Task<GetRelationalDatabaseSnapshotResponse> GetRelationalDatabaseSnapshotAsync(GetRelationalDatabaseSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRelationalDatabaseSnapshots


        /// <summary>
        /// Returns information about all of your database snapshots in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshots">REST API Reference for GetRelationalDatabaseSnapshots Operation</seealso>
        GetRelationalDatabaseSnapshotsResponse GetRelationalDatabaseSnapshots(GetRelationalDatabaseSnapshotsRequest request);



        /// <summary>
        /// Returns information about all of your database snapshots in Amazon Lightsail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationalDatabaseSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshots">REST API Reference for GetRelationalDatabaseSnapshots Operation</seealso>
        Task<GetRelationalDatabaseSnapshotsResponse> GetRelationalDatabaseSnapshotsAsync(GetRelationalDatabaseSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStaticIp


        /// <summary>
        /// Returns information about a specific static IP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp service method.</param>
        /// 
        /// <returns>The response from the GetStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        GetStaticIpResponse GetStaticIp(GetStaticIpRequest request);



        /// <summary>
        /// Returns information about a specific static IP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        Task<GetStaticIpResponse> GetStaticIpAsync(GetStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStaticIps


        /// <summary>
        /// Returns information about all static IPs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps service method.</param>
        /// 
        /// <returns>The response from the GetStaticIps service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request);



        /// <summary>
        /// Returns information about all static IPs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStaticIps service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        Task<GetStaticIpsResponse> GetStaticIpsAsync(GetStaticIpsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportKeyPair


        /// <summary>
        /// Imports a public SSH key from a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);



        /// <summary>
        /// Imports a public SSH key from a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IsVpcPeered


        /// <summary>
        /// Returns a Boolean value indicating whether your Lightsail VPC is peered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered service method.</param>
        /// 
        /// <returns>The response from the IsVpcPeered service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request);



        /// <summary>
        /// Returns a Boolean value indicating whether your Lightsail VPC is peered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IsVpcPeered service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        Task<IsVpcPeeredResponse> IsVpcPeeredAsync(IsVpcPeeredRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  OpenInstancePublicPorts


        /// <summary>
        /// Opens ports for a specific Amazon Lightsail instance, and specifies the IP addresses
        /// allowed to connect to the instance through the ports, and the protocol.
        /// 
        ///  
        /// <para>
        /// The <code>OpenInstancePublicPorts</code> action supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instanceName</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the OpenInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request);



        /// <summary>
        /// Opens ports for a specific Amazon Lightsail instance, and specifies the IP addresses
        /// allowed to connect to the instance through the ports, and the protocol.
        /// 
        ///  
        /// <para>
        /// The <code>OpenInstancePublicPorts</code> action supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instanceName</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OpenInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        Task<OpenInstancePublicPortsResponse> OpenInstancePublicPortsAsync(OpenInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PeerVpc


        /// <summary>
        /// Tries to peer the Lightsail VPC with the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc service method.</param>
        /// 
        /// <returns>The response from the PeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        PeerVpcResponse PeerVpc(PeerVpcRequest request);



        /// <summary>
        /// Tries to peer the Lightsail VPC with the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        Task<PeerVpcResponse> PeerVpcAsync(PeerVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAlarm


        /// <summary>
        /// Creates or updates an alarm, and associates it with the specified metric.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        /// When this action creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is then evaluated and its state is set appropriately. Any actions associated
        /// with the new state are then executed.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm. The alarm is then evaluated with
        /// the updated configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlarm service method.</param>
        /// 
        /// <returns>The response from the PutAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutAlarm">REST API Reference for PutAlarm Operation</seealso>
        PutAlarmResponse PutAlarm(PutAlarmRequest request);



        /// <summary>
        /// Creates or updates an alarm, and associates it with the specified metric.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        /// When this action creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is then evaluated and its state is set appropriately. Any actions associated
        /// with the new state are then executed.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm. The alarm is then evaluated with
        /// the updated configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutAlarm">REST API Reference for PutAlarm Operation</seealso>
        Task<PutAlarmResponse> PutAlarmAsync(PutAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutInstancePublicPorts


        /// <summary>
        /// Opens ports for a specific Amazon Lightsail instance, and specifies the IP addresses
        /// allowed to connect to the instance through the ports, and the protocol. This action
        /// also closes all currently open ports that are not included in the request. Include
        /// all of the ports and the protocols you want to open in your <code>PutInstancePublicPorts</code>request.
        /// Or use the <code>OpenInstancePublicPorts</code> action to open ports without closing
        /// currently open ports.
        /// 
        ///  
        /// <para>
        /// The <code>PutInstancePublicPorts</code> action supports tag-based access control via
        /// resource tags applied to the resource identified by <code>instanceName</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the PutInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request);



        /// <summary>
        /// Opens ports for a specific Amazon Lightsail instance, and specifies the IP addresses
        /// allowed to connect to the instance through the ports, and the protocol. This action
        /// also closes all currently open ports that are not included in the request. Include
        /// all of the ports and the protocols you want to open in your <code>PutInstancePublicPorts</code>request.
        /// Or use the <code>OpenInstancePublicPorts</code> action to open ports without closing
        /// currently open ports.
        /// 
        ///  
        /// <para>
        /// The <code>PutInstancePublicPorts</code> action supports tag-based access control via
        /// resource tags applied to the resource identified by <code>instanceName</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        Task<PutInstancePublicPortsResponse> PutInstancePublicPortsAsync(PutInstancePublicPortsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Restarts a specific instance.
        /// 
        ///  
        /// <para>
        /// The <code>reboot instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        RebootInstanceResponse RebootInstance(RebootInstanceRequest request);



        /// <summary>
        /// Restarts a specific instance.
        /// 
        ///  
        /// <para>
        /// The <code>reboot instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootRelationalDatabase


        /// <summary>
        /// Restarts a specific database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>reboot relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the RebootRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootRelationalDatabase">REST API Reference for RebootRelationalDatabase Operation</seealso>
        RebootRelationalDatabaseResponse RebootRelationalDatabase(RebootRelationalDatabaseRequest request);



        /// <summary>
        /// Restarts a specific database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>reboot relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootRelationalDatabase">REST API Reference for RebootRelationalDatabase Operation</seealso>
        Task<RebootRelationalDatabaseResponse> RebootRelationalDatabaseAsync(RebootRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterContainerImage


        /// <summary>
        /// Registers a container image to your Amazon Lightsail container service.
        /// 
        ///  <note> 
        /// <para>
        /// This action is not required if you install and use the Lightsail Control (lightsailctl)
        /// plugin to push container images to your Lightsail container service. For more information,
        /// see <a href="amazon-lightsail-pushing-container-images">Pushing and managing container
        /// images on your Amazon Lightsail container services</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterContainerImage service method.</param>
        /// 
        /// <returns>The response from the RegisterContainerImage service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RegisterContainerImage">REST API Reference for RegisterContainerImage Operation</seealso>
        RegisterContainerImageResponse RegisterContainerImage(RegisterContainerImageRequest request);



        /// <summary>
        /// Registers a container image to your Amazon Lightsail container service.
        /// 
        ///  <note> 
        /// <para>
        /// This action is not required if you install and use the Lightsail Control (lightsailctl)
        /// plugin to push container images to your Lightsail container service. For more information,
        /// see <a href="amazon-lightsail-pushing-container-images">Pushing and managing container
        /// images on your Amazon Lightsail container services</a> in the <i>Lightsail Dev Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterContainerImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterContainerImage service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RegisterContainerImage">REST API Reference for RegisterContainerImage Operation</seealso>
        Task<RegisterContainerImageResponse> RegisterContainerImageAsync(RegisterContainerImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReleaseStaticIp


        /// <summary>
        /// Deletes a specific static IP from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp service method.</param>
        /// 
        /// <returns>The response from the ReleaseStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request);



        /// <summary>
        /// Deletes a specific static IP from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        Task<ReleaseStaticIpResponse> ReleaseStaticIpAsync(ReleaseStaticIpRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetDistributionCache


        /// <summary>
        /// Deletes currently cached content from your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After resetting the cache, the next time a content request is made, your distribution
        /// pulls, serves, and caches it from the origin.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDistributionCache service method.</param>
        /// 
        /// <returns>The response from the ResetDistributionCache service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ResetDistributionCache">REST API Reference for ResetDistributionCache Operation</seealso>
        ResetDistributionCacheResponse ResetDistributionCache(ResetDistributionCacheRequest request);



        /// <summary>
        /// Deletes currently cached content from your Amazon Lightsail content delivery network
        /// (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// After resetting the cache, the next time a content request is made, your distribution
        /// pulls, serves, and caches it from the origin.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDistributionCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDistributionCache service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ResetDistributionCache">REST API Reference for ResetDistributionCache Operation</seealso>
        Task<ResetDistributionCacheResponse> ResetDistributionCacheAsync(ResetDistributionCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendContactMethodVerification


        /// <summary>
        /// Sends a verification request to an email contact method to ensure it's owned by the
        /// requester. SMS contact methods don't need to be verified.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        /// A verification request is sent to the contact method when you initially create it.
        /// Use this action to send another verification request if a previous verification request
        /// was deleted, or has expired.
        /// </para>
        ///  <important> 
        /// <para>
        /// Notifications are not sent to an email contact method until after it is verified,
        /// and confirmed as valid.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendContactMethodVerification service method.</param>
        /// 
        /// <returns>The response from the SendContactMethodVerification service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SendContactMethodVerification">REST API Reference for SendContactMethodVerification Operation</seealso>
        SendContactMethodVerificationResponse SendContactMethodVerification(SendContactMethodVerificationRequest request);



        /// <summary>
        /// Sends a verification request to an email contact method to ensure it's owned by the
        /// requester. SMS contact methods don't need to be verified.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each AWS
        /// Region. However, SMS text messaging is not supported in some AWS Regions, and SMS
        /// text messages cannot be sent to some countries/regions. For more information, see
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        ///  
        /// <para>
        /// A verification request is sent to the contact method when you initially create it.
        /// Use this action to send another verification request if a previous verification request
        /// was deleted, or has expired.
        /// </para>
        ///  <important> 
        /// <para>
        /// Notifications are not sent to an email contact method until after it is verified,
        /// and confirmed as valid.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendContactMethodVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendContactMethodVerification service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SendContactMethodVerification">REST API Reference for SendContactMethodVerification Operation</seealso>
        Task<SendContactMethodVerificationResponse> SendContactMethodVerificationAsync(SendContactMethodVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartInstance


        /// <summary>
        /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
        /// use the <code>reboot instance</code> operation.
        /// 
        ///  <note> 
        /// <para>
        /// When you start a stopped instance, Lightsail assigns a new public IP address to the
        /// instance. To use the same IP address after stopping and starting an instance, create
        /// a static IP address and attach it to the instance. For more information, see the <a
        /// href="https://lightsail.aws.amazon.com/ls/docs/en/articles/lightsail-create-static-ip">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>start instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        StartInstanceResponse StartInstance(StartInstanceRequest request);



        /// <summary>
        /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
        /// use the <code>reboot instance</code> operation.
        /// 
        ///  <note> 
        /// <para>
        /// When you start a stopped instance, Lightsail assigns a new public IP address to the
        /// instance. To use the same IP address after stopping and starting an instance, create
        /// a static IP address and attach it to the instance. For more information, see the <a
        /// href="https://lightsail.aws.amazon.com/ls/docs/en/articles/lightsail-create-static-ip">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>start instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRelationalDatabase


        /// <summary>
        /// Starts a specific database from a stopped state in Amazon Lightsail. To restart a
        /// database, use the <code>reboot relational database</code> operation.
        /// 
        ///  
        /// <para>
        /// The <code>start relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the StartRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartRelationalDatabase">REST API Reference for StartRelationalDatabase Operation</seealso>
        StartRelationalDatabaseResponse StartRelationalDatabase(StartRelationalDatabaseRequest request);



        /// <summary>
        /// Starts a specific database from a stopped state in Amazon Lightsail. To restart a
        /// database, use the <code>reboot relational database</code> operation.
        /// 
        ///  
        /// <para>
        /// The <code>start relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartRelationalDatabase">REST API Reference for StartRelationalDatabase Operation</seealso>
        Task<StartRelationalDatabaseResponse> StartRelationalDatabaseAsync(StartRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopInstance


        /// <summary>
        /// Stops a specific Amazon Lightsail instance that is currently running.
        /// 
        ///  <note> 
        /// <para>
        /// When you start a stopped instance, Lightsail assigns a new public IP address to the
        /// instance. To use the same IP address after stopping and starting an instance, create
        /// a static IP address and attach it to the instance. For more information, see the <a
        /// href="https://lightsail.aws.amazon.com/ls/docs/en/articles/lightsail-create-static-ip">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>stop instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        StopInstanceResponse StopInstance(StopInstanceRequest request);



        /// <summary>
        /// Stops a specific Amazon Lightsail instance that is currently running.
        /// 
        ///  <note> 
        /// <para>
        /// When you start a stopped instance, Lightsail assigns a new public IP address to the
        /// instance. To use the same IP address after stopping and starting an instance, create
        /// a static IP address and attach it to the instance. For more information, see the <a
        /// href="https://lightsail.aws.amazon.com/ls/docs/en/articles/lightsail-create-static-ip">Lightsail
        /// Dev Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>stop instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopRelationalDatabase


        /// <summary>
        /// Stops a specific database that is currently running in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>stop relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the StopRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopRelationalDatabase">REST API Reference for StopRelationalDatabase Operation</seealso>
        StopRelationalDatabaseResponse StopRelationalDatabase(StopRelationalDatabaseRequest request);



        /// <summary>
        /// Stops a specific database that is currently running in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>stop relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopRelationalDatabase">REST API Reference for StopRelationalDatabase Operation</seealso>
        Task<StopRelationalDatabaseResponse> StopRelationalDatabaseAsync(StopRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified Amazon Lightsail resource. Each resource can
        /// have a maximum of 50 tags. Each tag consists of a key and an optional value. Tag keys
        /// must be unique per resource. For more information about tags, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Lightsail
        /// Dev Guide</a>.
        /// 
        ///  
        /// <para>
        /// The <code>tag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by <code>resource name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds one or more tags to the specified Amazon Lightsail resource. Each resource can
        /// have a maximum of 50 tags. Each tag consists of a key and an optional value. Tag keys
        /// must be unique per resource. For more information about tags, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Lightsail
        /// Dev Guide</a>.
        /// 
        ///  
        /// <para>
        /// The <code>tag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by <code>resource name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestAlarm


        /// <summary>
        /// Tests an alarm by displaying a banner on the Amazon Lightsail console. If a notification
        /// trigger is configured for the specified alarm, the test also sends a notification
        /// to the notification protocol (<code>Email</code> and/or <code>SMS</code>) configured
        /// for the alarm.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAlarm service method.</param>
        /// 
        /// <returns>The response from the TestAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TestAlarm">REST API Reference for TestAlarm Operation</seealso>
        TestAlarmResponse TestAlarm(TestAlarmRequest request);



        /// <summary>
        /// Tests an alarm by displaying a banner on the Amazon Lightsail console. If a notification
        /// trigger is configured for the specified alarm, the test also sends a notification
        /// to the notification protocol (<code>Email</code> and/or <code>SMS</code>) configured
        /// for the alarm.
        /// 
        ///  
        /// <para>
        /// An alarm is used to monitor a single metric for one of your resources. When a metric
        /// condition is met, the alarm can notify you by email, SMS text message, and a banner
        /// displayed on the Amazon Lightsail console. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-alarms">Alarms
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestAlarm service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TestAlarm">REST API Reference for TestAlarm Operation</seealso>
        Task<TestAlarmResponse> TestAlarmAsync(TestAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnpeerVpc


        /// <summary>
        /// Attempts to unpeer the Lightsail VPC from the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc service method.</param>
        /// 
        /// <returns>The response from the UnpeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request);



        /// <summary>
        /// Attempts to unpeer the Lightsail VPC from the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnpeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        Task<UnpeerVpcResponse> UnpeerVpcAsync(UnpeerVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the specified set of tag keys and their values from the specified Amazon Lightsail
        /// resource.
        /// 
        ///  
        /// <para>
        /// The <code>untag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by <code>resource name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes the specified set of tag keys and their values from the specified Amazon Lightsail
        /// resource.
        /// 
        ///  
        /// <para>
        /// The <code>untag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by <code>resource name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateContainerService


        /// <summary>
        /// Updates the configuration of your Amazon Lightsail container service, such as its
        /// power, scale, and public domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerService service method.</param>
        /// 
        /// <returns>The response from the UpdateContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateContainerService">REST API Reference for UpdateContainerService Operation</seealso>
        UpdateContainerServiceResponse UpdateContainerService(UpdateContainerServiceRequest request);



        /// <summary>
        /// Updates the configuration of your Amazon Lightsail container service, such as its
        /// power, scale, and public domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContainerService service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateContainerService">REST API Reference for UpdateContainerService Operation</seealso>
        Task<UpdateContainerServiceResponse> UpdateContainerServiceAsync(UpdateContainerServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Updates an existing Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Use this action to update the configuration of your existing distribution
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request);



        /// <summary>
        /// Updates an existing Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Use this action to update the configuration of your existing distribution
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDistribution service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDistributionBundle


        /// <summary>
        /// Updates the bundle of your Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your dsitribution.
        /// </para>
        ///  
        /// <para>
        /// Update your distribution's bundle if your distribution is going over its monthly network
        /// transfer quota and is incurring an overage fee.
        /// </para>
        ///  
        /// <para>
        /// You can update your distribution's bundle only one time within your monthly AWS billing
        /// cycle. To determine if you can update your distribution's bundle, use the <code>GetDistributions</code>
        /// action. The <code>ableToUpdateBundle</code> parameter in the result will indicate
        /// whether you can currently update your distribution's bundle.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionBundle service method.</param>
        /// 
        /// <returns>The response from the UpdateDistributionBundle service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistributionBundle">REST API Reference for UpdateDistributionBundle Operation</seealso>
        UpdateDistributionBundleResponse UpdateDistributionBundle(UpdateDistributionBundleRequest request);



        /// <summary>
        /// Updates the bundle of your Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your dsitribution.
        /// </para>
        ///  
        /// <para>
        /// Update your distribution's bundle if your distribution is going over its monthly network
        /// transfer quota and is incurring an overage fee.
        /// </para>
        ///  
        /// <para>
        /// You can update your distribution's bundle only one time within your monthly AWS billing
        /// cycle. To determine if you can update your distribution's bundle, use the <code>GetDistributions</code>
        /// action. The <code>ableToUpdateBundle</code> parameter in the result will indicate
        /// whether you can currently update your distribution's bundle.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDistributionBundle service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistributionBundle">REST API Reference for UpdateDistributionBundle Operation</seealso>
        Task<UpdateDistributionBundleResponse> UpdateDistributionBundleAsync(UpdateDistributionBundleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainEntry


        /// <summary>
        /// Updates a domain recordset after it is created.
        /// 
        ///  
        /// <para>
        /// The <code>update domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request);



        /// <summary>
        /// Updates a domain recordset after it is created.
        /// 
        ///  
        /// <para>
        /// The <code>update domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        Task<UpdateDomainEntryResponse> UpdateDomainEntryAsync(UpdateDomainEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLoadBalancerAttribute


        /// <summary>
        /// Updates the specified attribute for a load balancer. You can only update one attribute
        /// at a time.
        /// 
        ///  
        /// <para>
        /// The <code>update load balancer attribute</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoadBalancerAttribute service method.</param>
        /// 
        /// <returns>The response from the UpdateLoadBalancerAttribute service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateLoadBalancerAttribute">REST API Reference for UpdateLoadBalancerAttribute Operation</seealso>
        UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request);



        /// <summary>
        /// Updates the specified attribute for a load balancer. You can only update one attribute
        /// at a time.
        /// 
        ///  
        /// <para>
        /// The <code>update load balancer attribute</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoadBalancerAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoadBalancerAttribute service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateLoadBalancerAttribute">REST API Reference for UpdateLoadBalancerAttribute Operation</seealso>
        Task<UpdateLoadBalancerAttributeResponse> UpdateLoadBalancerAttributeAsync(UpdateLoadBalancerAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRelationalDatabase


        /// <summary>
        /// Allows the update of one or more attributes of a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Updates are applied immediately, or in cases where the updates could result in an
        /// outage, are applied during the database's predefined maintenance window.
        /// </para>
        ///  
        /// <para>
        /// The <code>update relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabase">REST API Reference for UpdateRelationalDatabase Operation</seealso>
        UpdateRelationalDatabaseResponse UpdateRelationalDatabase(UpdateRelationalDatabaseRequest request);



        /// <summary>
        /// Allows the update of one or more attributes of a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Updates are applied immediately, or in cases where the updates could result in an
        /// outage, are applied during the database's predefined maintenance window.
        /// </para>
        ///  
        /// <para>
        /// The <code>update relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelationalDatabase service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabase">REST API Reference for UpdateRelationalDatabase Operation</seealso>
        Task<UpdateRelationalDatabaseResponse> UpdateRelationalDatabaseAsync(UpdateRelationalDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRelationalDatabaseParameters


        /// <summary>
        /// Allows the update of one or more parameters of a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Parameter updates don't cause outages; therefore, their application is not subject
        /// to the preferred maintenance window. However, there are two ways in which parameter
        /// updates are applied: <code>dynamic</code> or <code>pending-reboot</code>. Parameters
        /// marked with a <code>dynamic</code> apply type are applied immediately. Parameters
        /// marked with a <code>pending-reboot</code> apply type are applied only after the database
        /// is rebooted using the <code>reboot relational database</code> operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>update relational database parameters</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabaseParameters service method.</param>
        /// 
        /// <returns>The response from the UpdateRelationalDatabaseParameters service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabaseParameters">REST API Reference for UpdateRelationalDatabaseParameters Operation</seealso>
        UpdateRelationalDatabaseParametersResponse UpdateRelationalDatabaseParameters(UpdateRelationalDatabaseParametersRequest request);



        /// <summary>
        /// Allows the update of one or more parameters of a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Parameter updates don't cause outages; therefore, their application is not subject
        /// to the preferred maintenance window. However, there are two ways in which parameter
        /// updates are applied: <code>dynamic</code> or <code>pending-reboot</code>. Parameters
        /// marked with a <code>dynamic</code> apply type are applied immediately. Parameters
        /// marked with a <code>pending-reboot</code> apply type are applied only after the database
        /// is rebooted using the <code>reboot relational database</code> operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>update relational database parameters</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabaseParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelationalDatabaseParameters service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your AWS Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabaseParameters">REST API Reference for UpdateRelationalDatabaseParameters Operation</seealso>
        Task<UpdateRelationalDatabaseParametersResponse> UpdateRelationalDatabaseParametersAsync(UpdateRelationalDatabaseParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lightsail.Model;

namespace Amazon.Lightsail
{
    /// <summary>
    /// Interface for accessing Lightsail
    ///
    /// Amazon Lightsail is the easiest way to get started with Amazon Web Services (Amazon
    /// Web Services) for developers who need to build websites or web applications. It includes
    /// everything you need to launch your project quickly - instances (virtual private servers),
    /// container services, storage buckets, managed databases, SSD-based block storage, static
    /// IP addresses, load balancers, content delivery network (CDN) distributions, DNS management
    /// of registered domains, and resource snapshots (backups) - for a low, predictable monthly
    /// price.
    /// 
    ///  
    /// <para>
    /// You can manage your Lightsail resources using the Lightsail console, Lightsail API,
    /// Command Line Interface (CLI), or SDKs. For more information about Lightsail concepts
    /// and tasks, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/lightsail-how-to-set-up-access-keys-to-use-sdk-api-cli">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This API Reference provides detailed information about the actions, data types, parameters,
    /// and errors of the Lightsail service. For more information about the supported Amazon
    /// Web Services Regions, endpoints, and service quotas of the Lightsail service, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/lightsail.html">Amazon Lightsail
    /// Endpoints and Quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        IAsyncResult BeginAllocateStaticIp(AllocateStaticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateStaticIp.</param>
        /// 
        /// <returns>Returns a  AllocateStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        AllocateStaticIpResponse EndAllocateStaticIp(IAsyncResult asyncResult);

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
        /// Only certificates created in the <code>us-east-1</code> Amazon Web Services Region
        /// can be attached to Lightsail distributions. Lightsail distributions are global resources
        /// that can reference an origin in any Amazon Web Services Region, and distribute its
        /// content globally. However, all distributions are located in the <code>us-east-1</code>
        /// Region.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AttachCertificateToDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachCertificateToDistribution operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachCertificateToDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachCertificateToDistribution">REST API Reference for AttachCertificateToDistribution Operation</seealso>
        IAsyncResult BeginAttachCertificateToDistribution(AttachCertificateToDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachCertificateToDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachCertificateToDistribution.</param>
        /// 
        /// <returns>Returns a  AttachCertificateToDistributionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachCertificateToDistribution">REST API Reference for AttachCertificateToDistribution Operation</seealso>
        AttachCertificateToDistributionResponse EndAttachCertificateToDistribution(IAsyncResult asyncResult);

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
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AttachDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachDisk operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachDisk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachDisk">REST API Reference for AttachDisk Operation</seealso>
        IAsyncResult BeginAttachDisk(AttachDiskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachDisk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachDisk.</param>
        /// 
        /// <returns>Returns a  AttachDiskResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachDisk">REST API Reference for AttachDisk Operation</seealso>
        AttachDiskResponse EndAttachDisk(IAsyncResult asyncResult);

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
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AttachInstancesToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstancesToLoadBalancer operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachInstancesToLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachInstancesToLoadBalancer">REST API Reference for AttachInstancesToLoadBalancer Operation</seealso>
        IAsyncResult BeginAttachInstancesToLoadBalancer(AttachInstancesToLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInstancesToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInstancesToLoadBalancer.</param>
        /// 
        /// <returns>Returns a  AttachInstancesToLoadBalancerResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachInstancesToLoadBalancer">REST API Reference for AttachInstancesToLoadBalancer Operation</seealso>
        AttachInstancesToLoadBalancerResponse EndAttachInstancesToLoadBalancer(IAsyncResult asyncResult);

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
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AttachLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTlsCertificate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachLoadBalancerTlsCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachLoadBalancerTlsCertificate">REST API Reference for AttachLoadBalancerTlsCertificate Operation</seealso>
        IAsyncResult BeginAttachLoadBalancerTlsCertificate(AttachLoadBalancerTlsCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerTlsCertificate.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancerTlsCertificateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachLoadBalancerTlsCertificate">REST API Reference for AttachLoadBalancerTlsCertificate Operation</seealso>
        AttachLoadBalancerTlsCertificateResponse EndAttachLoadBalancerTlsCertificate(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        IAsyncResult BeginAttachStaticIp(AttachStaticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachStaticIp.</param>
        /// 
        /// <returns>Returns a  AttachStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        AttachStaticIpResponse EndAttachStaticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  CloseInstancePublicPorts


        /// <summary>
        /// Closes ports for a specific Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>CloseInstancePublicPorts</code> action supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instanceName</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        IAsyncResult BeginCloseInstancePublicPorts(CloseInstancePublicPortsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  CloseInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        CloseInstancePublicPortsResponse EndCloseInstancePublicPorts(IAsyncResult asyncResult);

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// Copies a manual snapshot of an instance or disk as another manual snapshot, or copies
        /// an automatic snapshot of an instance or disk as a manual snapshot. This operation
        /// can also be used to copy a manual or automatic snapshot of an instance or a disk from
        /// one Amazon Web Services Region to another in Amazon Lightsail.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBucket


        /// <summary>
        /// Creates an Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// A bucket is a cloud storage resource available in the Lightsail object storage service.
        /// Use buckets to store objects such as data and its descriptive metadata. For more information
        /// about buckets, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/buckets-in-amazon-lightsail">Buckets
        /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket service method.</param>
        /// 
        /// <returns>The response from the CreateBucket service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        CreateBucketResponse CreateBucket(CreateBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        IAsyncResult BeginCreateBucket(CreateBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBucket.</param>
        /// 
        /// <returns>Returns a  CreateBucketResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        CreateBucketResponse EndCreateBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBucketAccessKey


        /// <summary>
        /// Creates a new access key for the specified Amazon Lightsail bucket. Access keys consist
        /// of an access key ID and corresponding secret access key.
        /// 
        ///  
        /// <para>
        /// Access keys grant full programmatic access to the specified bucket and its objects.
        /// You can have a maximum of two access keys per bucket. Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBucketAccessKeys.html">GetBucketAccessKeys</a>
        /// action to get a list of current access keys for a specific bucket. For more information
        /// about access keys, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-bucket-access-keys">Creating
        /// access keys for a bucket in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <code>secretAccessKey</code> value is returned only in response to the <code>CreateBucketAccessKey</code>
        /// action. You can get a secret access key only when you first create an access key;
        /// you cannot get the secret access key later. If you lose the secret access key, you
        /// must create a new access key.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBucketAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateBucketAccessKey service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucketAccessKey">REST API Reference for CreateBucketAccessKey Operation</seealso>
        CreateBucketAccessKeyResponse CreateBucketAccessKey(CreateBucketAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBucketAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBucketAccessKey operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBucketAccessKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucketAccessKey">REST API Reference for CreateBucketAccessKey Operation</seealso>
        IAsyncResult BeginCreateBucketAccessKey(CreateBucketAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBucketAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBucketAccessKey.</param>
        /// 
        /// <returns>Returns a  CreateBucketAccessKeyResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateBucketAccessKey">REST API Reference for CreateBucketAccessKey Operation</seealso>
        CreateBucketAccessKeyResponse EndCreateBucketAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCertificate


        /// <summary>
        /// Creates an SSL/TLS certificate for an Amazon Lightsail content delivery network (CDN)
        /// distribution and a container service.
        /// 
        ///  
        /// <para>
        /// After the certificate is valid, use the <code>AttachCertificateToDistribution</code>
        /// action to use the certificate and its domains with your distribution. Or use the <code>UpdateContainerService</code>
        /// action to use the certificate and its domains with your container service.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only certificates created in the <code>us-east-1</code> Amazon Web Services Region
        /// can be attached to Lightsail distributions. Lightsail distributions are global resources
        /// that can reference an origin in any Amazon Web Services Region, and distribute its
        /// content globally. However, all distributions are located in the <code>us-east-1</code>
        /// Region.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCertificate">REST API Reference for CreateCertificate Operation</seealso>
        IAsyncResult BeginCreateCertificate(CreateCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCertificate.</param>
        /// 
        /// <returns>Returns a  CreateCertificateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCertificate">REST API Reference for CreateCertificate Operation</seealso>
        CreateCertificateResponse EndCreateCertificate(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateCloudFormationStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationStack operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudFormationStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCloudFormationStack">REST API Reference for CreateCloudFormationStack Operation</seealso>
        IAsyncResult BeginCreateCloudFormationStack(CreateCloudFormationStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudFormationStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudFormationStack.</param>
        /// 
        /// <returns>Returns a  CreateCloudFormationStackResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCloudFormationStack">REST API Reference for CreateCloudFormationStack Operation</seealso>
        CreateCloudFormationStackResponse EndCreateCloudFormationStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContactMethod


        /// <summary>
        /// Creates an email or SMS text message contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each Amazon
        /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
        /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateContactMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContactMethod operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContactMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContactMethod">REST API Reference for CreateContactMethod Operation</seealso>
        IAsyncResult BeginCreateContactMethod(CreateContactMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContactMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContactMethod.</param>
        /// 
        /// <returns>Returns a  CreateContactMethodResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContactMethod">REST API Reference for CreateContactMethod Operation</seealso>
        CreateContactMethodResponse EndCreateContactMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateContainerService


        /// <summary>
        /// Creates an Amazon Lightsail container service.
        /// 
        ///  
        /// <para>
        /// A Lightsail container service is a compute resource to which you can deploy containers.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-container-services">Container
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateContainerService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerService operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContainerService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerService">REST API Reference for CreateContainerService Operation</seealso>
        IAsyncResult BeginCreateContainerService(CreateContainerServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContainerService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContainerService.</param>
        /// 
        /// <returns>Returns a  CreateContainerServiceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerService">REST API Reference for CreateContainerService Operation</seealso>
        CreateContainerServiceResponse EndCreateContainerService(IAsyncResult asyncResult);

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
        /// public registry such as Amazon ECR Public, or from your local machine. For more information,
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-container-images">Creating
        /// container images for your Amazon Lightsail container services</a> in the <i>Amazon
        /// Lightsail Developer Guide</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateContainerServiceDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceDeployment operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContainerServiceDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceDeployment">REST API Reference for CreateContainerServiceDeployment Operation</seealso>
        IAsyncResult BeginCreateContainerServiceDeployment(CreateContainerServiceDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContainerServiceDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContainerServiceDeployment.</param>
        /// 
        /// <returns>Returns a  CreateContainerServiceDeploymentResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceDeployment">REST API Reference for CreateContainerServiceDeployment Operation</seealso>
        CreateContainerServiceDeploymentResponse EndCreateContainerServiceDeployment(IAsyncResult asyncResult);

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
        /// account. You cannot pull container images or perform any other container image management
        /// actions on the container service registry.
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
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-pushing-container-images">Pushing
        /// and managing container images on your Amazon Lightsail container services</a> in the
        /// <i>Amazon Lightsail Developer Guide</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateContainerServiceRegistryLogin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainerServiceRegistryLogin operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateContainerServiceRegistryLogin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceRegistryLogin">REST API Reference for CreateContainerServiceRegistryLogin Operation</seealso>
        IAsyncResult BeginCreateContainerServiceRegistryLogin(CreateContainerServiceRegistryLoginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateContainerServiceRegistryLogin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateContainerServiceRegistryLogin.</param>
        /// 
        /// <returns>Returns a  CreateContainerServiceRegistryLoginResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateContainerServiceRegistryLogin">REST API Reference for CreateContainerServiceRegistryLogin Operation</seealso>
        CreateContainerServiceRegistryLoginResponse EndCreateContainerServiceRegistryLogin(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDisk


        /// <summary>
        /// Creates a block storage disk that can be attached to an Amazon Lightsail instance
        /// in the same Availability Zone (e.g., <code>us-east-2a</code>).
        /// 
        ///  
        /// <para>
        /// The <code>create disk</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDisk operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDisk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDisk">REST API Reference for CreateDisk Operation</seealso>
        IAsyncResult BeginCreateDisk(CreateDiskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDisk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDisk.</param>
        /// 
        /// <returns>Returns a  CreateDiskResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDisk">REST API Reference for CreateDisk Operation</seealso>
        CreateDiskResponse EndCreateDisk(IAsyncResult asyncResult);

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
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDiskFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskFromSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDiskFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskFromSnapshot">REST API Reference for CreateDiskFromSnapshot Operation</seealso>
        IAsyncResult BeginCreateDiskFromSnapshot(CreateDiskFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDiskFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDiskFromSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateDiskFromSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskFromSnapshot">REST API Reference for CreateDiskFromSnapshot Operation</seealso>
        CreateDiskFromSnapshotResponse EndCreateDiskFromSnapshot(IAsyncResult asyncResult);

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
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDiskSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskSnapshot">REST API Reference for CreateDiskSnapshot Operation</seealso>
        IAsyncResult BeginCreateDiskSnapshot(CreateDiskSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDiskSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateDiskSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskSnapshot">REST API Reference for CreateDiskSnapshot Operation</seealso>
        CreateDiskSnapshotResponse EndCreateDiskSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        IAsyncResult BeginCreateDistribution(CreateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDistribution.</param>
        /// 
        /// <returns>Returns a  CreateDistributionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        CreateDistributionResponse EndCreateDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain resource for the specified domain (e.g., example.com).
        /// 
        ///  
        /// <para>
        /// The <code>create domain</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult);

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
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        IAsyncResult BeginCreateDomainEntry(CreateDomainEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainEntry.</param>
        /// 
        /// <returns>Returns a  CreateDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        CreateDomainEntryResponse EndCreateDomainEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGUISessionAccessDetails


        /// <summary>
        /// Creates two URLs that are used to access a virtual computer’s graphical user interface
        /// (GUI) session. The primary URL initiates a web-based NICE DCV session to the virtual
        /// computer's application. The secondary URL initiates a web-based NICE DCV session to
        /// the virtual computer's operating session. 
        /// 
        ///  
        /// <para>
        /// Use <code>StartGUISession</code> to open the session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGUISessionAccessDetails service method.</param>
        /// 
        /// <returns>The response from the CreateGUISessionAccessDetails service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateGUISessionAccessDetails">REST API Reference for CreateGUISessionAccessDetails Operation</seealso>
        CreateGUISessionAccessDetailsResponse CreateGUISessionAccessDetails(CreateGUISessionAccessDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGUISessionAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGUISessionAccessDetails operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGUISessionAccessDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateGUISessionAccessDetails">REST API Reference for CreateGUISessionAccessDetails Operation</seealso>
        IAsyncResult BeginCreateGUISessionAccessDetails(CreateGUISessionAccessDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGUISessionAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGUISessionAccessDetails.</param>
        /// 
        /// <returns>Returns a  CreateGUISessionAccessDetailsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateGUISessionAccessDetails">REST API Reference for CreateGUISessionAccessDetails Operation</seealso>
        CreateGUISessionAccessDetailsResponse EndCreateGUISessionAccessDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstances


        /// <summary>
        /// Creates one or more Amazon Lightsail instances.
        /// 
        ///  
        /// <para>
        /// The <code>create instances</code> operation supports tag-based access control via
        /// request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
        /// Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        IAsyncResult BeginCreateInstances(CreateInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstances.</param>
        /// 
        /// <returns>Returns a  CreateInstancesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        CreateInstancesResponse EndCreateInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstancesFromSnapshot


        /// <summary>
        /// Creates one or more new instances from a manual or automatic snapshot of an instance.
        /// 
        ///  
        /// <para>
        /// The <code>create instances from snapshot</code> operation supports tag-based access
        /// control via request tags and resource tags applied to the resource identified by <code>instance
        /// snapshot name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstancesFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        IAsyncResult BeginCreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstancesFromSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateInstancesFromSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        CreateInstancesFromSnapshotResponse EndCreateInstancesFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceSnapshot


        /// <summary>
        /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
        /// use a snapshot to create a new instance that is based on that snapshot.
        /// 
        ///  
        /// <para>
        /// The <code>create instance snapshot</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        IAsyncResult BeginCreateInstanceSnapshot(CreateInstanceSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        CreateInstanceSnapshotResponse EndCreateInstanceSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeyPair


        /// <summary>
        /// Creates a custom SSH key pair that you can use with an Amazon Lightsail instance.
        /// 
        ///  <note> 
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_DownloadDefaultKeyPair.html">DownloadDefaultKeyPair</a>
        /// action to create a Lightsail default key pair in an Amazon Web Services Region where
        /// a default key pair does not currently exist.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>create key pair</code> operation supports tag-based access control via request
        /// tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a  CreateKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates a Lightsail load balancer. To learn more about deciding whether to load balance
        /// your application, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/configure-lightsail-instances-for-load-balancing">Configure
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
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        IAsyncResult BeginCreateLoadBalancer(CreateLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancer.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        CreateLoadBalancerResponse EndCreateLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoadBalancerTlsCertificate


        /// <summary>
        /// Creates an SSL/TLS certificate for an Amazon Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerTlsCertificate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoadBalancerTlsCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancerTlsCertificate">REST API Reference for CreateLoadBalancerTlsCertificate Operation</seealso>
        IAsyncResult BeginCreateLoadBalancerTlsCertificate(CreateLoadBalancerTlsCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoadBalancerTlsCertificate.</param>
        /// 
        /// <returns>Returns a  CreateLoadBalancerTlsCertificateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancerTlsCertificate">REST API Reference for CreateLoadBalancerTlsCertificate Operation</seealso>
        CreateLoadBalancerTlsCertificateResponse EndCreateLoadBalancerTlsCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRelationalDatabase


        /// <summary>
        /// Creates a new database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database</code> operation supports tag-based access control
        /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabase">REST API Reference for CreateRelationalDatabase Operation</seealso>
        IAsyncResult BeginCreateRelationalDatabase(CreateRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  CreateRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabase">REST API Reference for CreateRelationalDatabase Operation</seealso>
        CreateRelationalDatabaseResponse EndCreateRelationalDatabase(IAsyncResult asyncResult);

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
        /// by relationalDatabaseSnapshotName. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateRelationalDatabaseFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseFromSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelationalDatabaseFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseFromSnapshot">REST API Reference for CreateRelationalDatabaseFromSnapshot Operation</seealso>
        IAsyncResult BeginCreateRelationalDatabaseFromSnapshot(CreateRelationalDatabaseFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelationalDatabaseFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelationalDatabaseFromSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateRelationalDatabaseFromSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseFromSnapshot">REST API Reference for CreateRelationalDatabaseFromSnapshot Operation</seealso>
        CreateRelationalDatabaseFromSnapshotResponse EndCreateRelationalDatabaseFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRelationalDatabaseSnapshot


        /// <summary>
        /// Creates a snapshot of your database in Amazon Lightsail. You can use snapshots for
        /// backups, to make copies of a database, and to save data before deleting a database.
        /// 
        ///  
        /// <para>
        /// The <code>create relational database snapshot</code> operation supports tag-based
        /// access control via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the CreateRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelationalDatabaseSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseSnapshot">REST API Reference for CreateRelationalDatabaseSnapshot Operation</seealso>
        IAsyncResult BeginCreateRelationalDatabaseSnapshot(CreateRelationalDatabaseSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelationalDatabaseSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateRelationalDatabaseSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseSnapshot">REST API Reference for CreateRelationalDatabaseSnapshot Operation</seealso>
        CreateRelationalDatabaseSnapshotResponse EndCreateRelationalDatabaseSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarm operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAlarm">REST API Reference for DeleteAlarm Operation</seealso>
        IAsyncResult BeginDeleteAlarm(DeleteAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarm.</param>
        /// 
        /// <returns>Returns a  DeleteAlarmResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAlarm">REST API Reference for DeleteAlarm Operation</seealso>
        DeleteAlarmResponse EndDeleteAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAutoSnapshot


        /// <summary>
        /// Deletes an automatic snapshot of an instance or disk. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteAutoSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutoSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAutoSnapshot">REST API Reference for DeleteAutoSnapshot Operation</seealso>
        IAsyncResult BeginDeleteAutoSnapshot(DeleteAutoSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutoSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteAutoSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteAutoSnapshot">REST API Reference for DeleteAutoSnapshot Operation</seealso>
        DeleteAutoSnapshotResponse EndDeleteAutoSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucket


        /// <summary>
        /// Deletes a Amazon Lightsail bucket.
        /// 
        ///  <note> 
        /// <para>
        /// When you delete your bucket, the bucket name is released and can be reused for a new
        /// bucket in your account or another Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        DeleteBucketResponse DeleteBucket(DeleteBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// 
        /// <returns>Returns a  DeleteBucketResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBucketAccessKey


        /// <summary>
        /// Deletes an access key for the specified Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// We recommend that you delete an access key if the secret access key is compromised.
        /// </para>
        ///  
        /// <para>
        /// For more information about access keys, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-bucket-access-keys">Creating
        /// access keys for a bucket in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketAccessKey service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucketAccessKey">REST API Reference for DeleteBucketAccessKey Operation</seealso>
        DeleteBucketAccessKeyResponse DeleteBucketAccessKey(DeleteBucketAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAccessKey operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBucketAccessKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucketAccessKey">REST API Reference for DeleteBucketAccessKey Operation</seealso>
        IAsyncResult BeginDeleteBucketAccessKey(DeleteBucketAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBucketAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketAccessKey.</param>
        /// 
        /// <returns>Returns a  DeleteBucketAccessKeyResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteBucketAccessKey">REST API Reference for DeleteBucketAccessKey Operation</seealso>
        DeleteBucketAccessKeyResponse EndDeleteBucketAccessKey(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteContactMethod


        /// <summary>
        /// Deletes a contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each Amazon
        /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
        /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteContactMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContactMethod operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContactMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContactMethod">REST API Reference for DeleteContactMethod Operation</seealso>
        IAsyncResult BeginDeleteContactMethod(DeleteContactMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContactMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContactMethod.</param>
        /// 
        /// <returns>Returns a  DeleteContactMethodResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContactMethod">REST API Reference for DeleteContactMethod Operation</seealso>
        DeleteContactMethodResponse EndDeleteContactMethod(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteContainerImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerImage operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContainerImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerImage">REST API Reference for DeleteContainerImage Operation</seealso>
        IAsyncResult BeginDeleteContainerImage(DeleteContainerImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContainerImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContainerImage.</param>
        /// 
        /// <returns>Returns a  DeleteContainerImageResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerImage">REST API Reference for DeleteContainerImage Operation</seealso>
        DeleteContainerImageResponse EndDeleteContainerImage(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteContainerService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerService operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteContainerService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerService">REST API Reference for DeleteContainerService Operation</seealso>
        IAsyncResult BeginDeleteContainerService(DeleteContainerServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteContainerService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteContainerService.</param>
        /// 
        /// <returns>Returns a  DeleteContainerServiceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteContainerService">REST API Reference for DeleteContainerService Operation</seealso>
        DeleteContainerServiceResponse EndDeleteContainerService(IAsyncResult asyncResult);

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
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDisk operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDisk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDisk">REST API Reference for DeleteDisk Operation</seealso>
        IAsyncResult BeginDeleteDisk(DeleteDiskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDisk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDisk.</param>
        /// 
        /// <returns>Returns a  DeleteDiskResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDisk">REST API Reference for DeleteDisk Operation</seealso>
        DeleteDiskResponse EndDeleteDisk(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiskSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDiskSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDiskSnapshot">REST API Reference for DeleteDiskSnapshot Operation</seealso>
        IAsyncResult BeginDeleteDiskSnapshot(DeleteDiskSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDiskSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteDiskSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDiskSnapshot">REST API Reference for DeleteDiskSnapshot Operation</seealso>
        DeleteDiskSnapshotResponse EndDeleteDiskSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        IAsyncResult BeginDeleteDistribution(DeleteDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDistribution.</param>
        /// 
        /// <returns>Returns a  DeleteDistributionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        DeleteDistributionResponse EndDeleteDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>domain name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomainEntry


        /// <summary>
        /// Deletes a specific domain entry.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        IAsyncResult BeginDeleteDomainEntry(DeleteDomainEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainEntry.</param>
        /// 
        /// <returns>Returns a  DeleteDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        DeleteDomainEntryResponse EndDeleteDomainEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes an Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>delete instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstanceSnapshot


        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// 
        ///  
        /// <para>
        /// The <code>delete instance snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by <code>instance snapshot name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        IAsyncResult BeginDeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        DeleteInstanceSnapshotResponse EndDeleteInstanceSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes the specified key pair by removing the public key from Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// You can delete key pairs that were created using the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_ImportKeyPair.html">ImportKeyPair</a>
        /// and <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateKeyPair.html">CreateKeyPair</a>
        /// actions, as well as the Lightsail default key pair. A new default key pair will not
        /// be created unless you launch an instance without specifying a custom key pair, or
        /// you call the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_DownloadDefaultKeyPair.html">DownloadDefaultKeyPair</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// The <code>delete key pair</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>key pair name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        /// 
        /// <returns>Returns a  DeleteKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult);

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
        /// information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-troubleshooting-browser-based-ssh-rdp-client-connection">Troubleshooting
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteKnownHostKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKnownHostKeys operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKnownHostKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKnownHostKeys">REST API Reference for DeleteKnownHostKeys Operation</seealso>
        IAsyncResult BeginDeleteKnownHostKeys(DeleteKnownHostKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKnownHostKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKnownHostKeys.</param>
        /// 
        /// <returns>Returns a  DeleteKnownHostKeysResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKnownHostKeys">REST API Reference for DeleteKnownHostKeys Operation</seealso>
        DeleteKnownHostKeysResponse EndDeleteKnownHostKeys(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        IAsyncResult BeginDeleteLoadBalancer(DeleteLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        DeleteLoadBalancerResponse EndDeleteLoadBalancer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoadBalancerTlsCertificate


        /// <summary>
        /// Deletes an SSL/TLS certificate associated with a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteLoadBalancerTlsCertificate</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by <code>load balancer
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerTlsCertificate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoadBalancerTlsCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancerTlsCertificate">REST API Reference for DeleteLoadBalancerTlsCertificate Operation</seealso>
        IAsyncResult BeginDeleteLoadBalancerTlsCertificate(DeleteLoadBalancerTlsCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoadBalancerTlsCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteLoadBalancerTlsCertificateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancerTlsCertificate">REST API Reference for DeleteLoadBalancerTlsCertificate Operation</seealso>
        DeleteLoadBalancerTlsCertificateResponse EndDeleteLoadBalancerTlsCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRelationalDatabase


        /// <summary>
        /// Deletes a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabase">REST API Reference for DeleteRelationalDatabase Operation</seealso>
        IAsyncResult BeginDeleteRelationalDatabase(DeleteRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabase">REST API Reference for DeleteRelationalDatabase Operation</seealso>
        DeleteRelationalDatabaseResponse EndDeleteRelationalDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRelationalDatabaseSnapshot


        /// <summary>
        /// Deletes a database snapshot in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>delete relational database snapshot</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by relationalDatabaseName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DeleteRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabaseSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelationalDatabaseSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabaseSnapshot">REST API Reference for DeleteRelationalDatabaseSnapshot Operation</seealso>
        IAsyncResult BeginDeleteRelationalDatabaseSnapshot(DeleteRelationalDatabaseSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelationalDatabaseSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteRelationalDatabaseSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabaseSnapshot">REST API Reference for DeleteRelationalDatabaseSnapshot Operation</seealso>
        DeleteRelationalDatabaseSnapshotResponse EndDeleteRelationalDatabaseSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DetachCertificateFromDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachCertificateFromDistribution operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachCertificateFromDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachCertificateFromDistribution">REST API Reference for DetachCertificateFromDistribution Operation</seealso>
        IAsyncResult BeginDetachCertificateFromDistribution(DetachCertificateFromDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachCertificateFromDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachCertificateFromDistribution.</param>
        /// 
        /// <returns>Returns a  DetachCertificateFromDistributionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachCertificateFromDistribution">REST API Reference for DetachCertificateFromDistribution Operation</seealso>
        DetachCertificateFromDistributionResponse EndDetachCertificateFromDistribution(IAsyncResult asyncResult);

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
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DetachDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachDisk operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachDisk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachDisk">REST API Reference for DetachDisk Operation</seealso>
        IAsyncResult BeginDetachDisk(DetachDiskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachDisk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachDisk.</param>
        /// 
        /// <returns>Returns a  DetachDiskResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachDisk">REST API Reference for DetachDisk Operation</seealso>
        DetachDiskResponse EndDetachDisk(IAsyncResult asyncResult);

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
        /// balancer name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DetachInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstancesFromLoadBalancer operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachInstancesFromLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachInstancesFromLoadBalancer">REST API Reference for DetachInstancesFromLoadBalancer Operation</seealso>
        IAsyncResult BeginDetachInstancesFromLoadBalancer(DetachInstancesFromLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInstancesFromLoadBalancer.</param>
        /// 
        /// <returns>Returns a  DetachInstancesFromLoadBalancerResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachInstancesFromLoadBalancer">REST API Reference for DetachInstancesFromLoadBalancer Operation</seealso>
        DetachInstancesFromLoadBalancerResponse EndDetachInstancesFromLoadBalancer(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        IAsyncResult BeginDetachStaticIp(DetachStaticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachStaticIp.</param>
        /// 
        /// <returns>Returns a  DetachStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        DetachStaticIpResponse EndDetachStaticIp(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableAddOn


        /// <summary>
        /// Disables an add-on for an Amazon Lightsail resource. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DisableAddOn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAddOn operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAddOn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DisableAddOn">REST API Reference for DisableAddOn Operation</seealso>
        IAsyncResult BeginDisableAddOn(DisableAddOnRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAddOn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAddOn.</param>
        /// 
        /// <returns>Returns a  DisableAddOnResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DisableAddOn">REST API Reference for DisableAddOn Operation</seealso>
        DisableAddOnResponse EndDisableAddOn(IAsyncResult asyncResult);

        #endregion
        
        #region  DownloadDefaultKeyPair


        /// <summary>
        /// Downloads the regional Amazon Lightsail default key pair.
        /// 
        ///  
        /// <para>
        /// This action also creates a Lightsail default key pair if a default key pair does not
        /// currently exist in the Amazon Web Services Region.
        /// </para>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDownloadDefaultKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        IAsyncResult BeginDownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadDefaultKeyPair.</param>
        /// 
        /// <returns>Returns a  DownloadDefaultKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        DownloadDefaultKeyPairResponse EndDownloadDefaultKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableAddOn


        /// <summary>
        /// Enables or modifies an add-on for an Amazon Lightsail resource. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the EnableAddOn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAddOn operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAddOn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/EnableAddOn">REST API Reference for EnableAddOn Operation</seealso>
        IAsyncResult BeginEnableAddOn(EnableAddOnRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAddOn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAddOn.</param>
        /// 
        /// <returns>Returns a  EnableAddOnResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/EnableAddOn">REST API Reference for EnableAddOn Operation</seealso>
        EnableAddOnResponse EndEnableAddOn(IAsyncResult asyncResult);

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
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        IAsyncResult BeginExportSnapshot(ExportSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportSnapshot.</param>
        /// 
        /// <returns>Returns a  ExportSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        ExportSnapshotResponse EndExportSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetActiveNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        IAsyncResult BeginGetActiveNames(GetActiveNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActiveNames.</param>
        /// 
        /// <returns>Returns a  GetActiveNamesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        GetActiveNamesResponse EndGetActiveNames(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlarms operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAlarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAlarms">REST API Reference for GetAlarms Operation</seealso>
        IAsyncResult BeginGetAlarms(GetAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlarms.</param>
        /// 
        /// <returns>Returns a  GetAlarmsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAlarms">REST API Reference for GetAlarms Operation</seealso>
        GetAlarmsResponse EndGetAlarms(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutoSnapshots


        /// <summary>
        /// Returns the available automatic snapshots for an instance or disk. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetAutoSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoSnapshots operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAutoSnapshots">REST API Reference for GetAutoSnapshots Operation</seealso>
        IAsyncResult BeginGetAutoSnapshots(GetAutoSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoSnapshots.</param>
        /// 
        /// <returns>Returns a  GetAutoSnapshotsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetAutoSnapshots">REST API Reference for GetAutoSnapshots Operation</seealso>
        GetAutoSnapshotsResponse EndGetAutoSnapshots(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        IAsyncResult BeginGetBlueprints(GetBlueprintsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprints.</param>
        /// 
        /// <returns>Returns a  GetBlueprintsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        GetBlueprintsResponse EndGetBlueprints(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketAccessKeys


        /// <summary>
        /// Returns the existing access key IDs for the specified Amazon Lightsail bucket.
        /// 
        ///  <important> 
        /// <para>
        /// This action does not return the secret access key value of an access key. You can
        /// get a secret access key only when you create it from the response of the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateBucketAccessKey.html">CreateBucketAccessKey</a>
        /// action. If you lose the secret access key, you must create a new access key.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccessKeys service method.</param>
        /// 
        /// <returns>The response from the GetBucketAccessKeys service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketAccessKeys">REST API Reference for GetBucketAccessKeys Operation</seealso>
        GetBucketAccessKeysResponse GetBucketAccessKeys(GetBucketAccessKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccessKeys operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketAccessKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketAccessKeys">REST API Reference for GetBucketAccessKeys Operation</seealso>
        IAsyncResult BeginGetBucketAccessKeys(GetBucketAccessKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketAccessKeys.</param>
        /// 
        /// <returns>Returns a  GetBucketAccessKeysResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketAccessKeys">REST API Reference for GetBucketAccessKeys Operation</seealso>
        GetBucketAccessKeysResponse EndGetBucketAccessKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketBundles


        /// <summary>
        /// Returns the bundles that you can apply to a Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// The bucket bundle specifies the monthly cost, storage quota, and data transfer quota
        /// for a bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to update the bundle for a bucket.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketBundles service method.</param>
        /// 
        /// <returns>The response from the GetBucketBundles service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketBundles">REST API Reference for GetBucketBundles Operation</seealso>
        GetBucketBundlesResponse GetBucketBundles(GetBucketBundlesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketBundles operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketBundles">REST API Reference for GetBucketBundles Operation</seealso>
        IAsyncResult BeginGetBucketBundles(GetBucketBundlesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketBundles.</param>
        /// 
        /// <returns>Returns a  GetBucketBundlesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketBundles">REST API Reference for GetBucketBundles Operation</seealso>
        GetBucketBundlesResponse EndGetBucketBundles(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketMetricData


        /// <summary>
        /// Returns the data points of a specific metric for an Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// Metrics report the utilization of a bucket. View and collect metric data regularly
        /// to monitor the number of objects stored in a bucket (including object versions) and
        /// the storage space used by those objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricData service method.</param>
        /// 
        /// <returns>The response from the GetBucketMetricData service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketMetricData">REST API Reference for GetBucketMetricData Operation</seealso>
        GetBucketMetricDataResponse GetBucketMetricData(GetBucketMetricDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketMetricData">REST API Reference for GetBucketMetricData Operation</seealso>
        IAsyncResult BeginGetBucketMetricData(GetBucketMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketMetricData.</param>
        /// 
        /// <returns>Returns a  GetBucketMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBucketMetricData">REST API Reference for GetBucketMetricData Operation</seealso>
        GetBucketMetricDataResponse EndGetBucketMetricData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBuckets


        /// <summary>
        /// Returns information about one or more Amazon Lightsail buckets. The information returned
        /// includes the synchronization status of the Amazon Simple Storage Service (Amazon S3)
        /// account-level block public access feature for your Lightsail buckets.
        /// 
        ///  
        /// <para>
        /// For more information about buckets, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/buckets-in-amazon-lightsail">Buckets
        /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuckets service method.</param>
        /// 
        /// <returns>The response from the GetBuckets service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBuckets">REST API Reference for GetBuckets Operation</seealso>
        GetBucketsResponse GetBuckets(GetBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBuckets operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBuckets">REST API Reference for GetBuckets Operation</seealso>
        IAsyncResult BeginGetBuckets(GetBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBuckets.</param>
        /// 
        /// <returns>Returns a  GetBucketsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBuckets">REST API Reference for GetBuckets Operation</seealso>
        GetBucketsResponse EndGetBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBundles


        /// <summary>
        /// Returns the bundles that you can apply to an Amazon Lightsail instance when you create
        /// it.
        /// 
        ///  
        /// <para>
        /// A bundle describes the specifications of an instance, such as the monthly cost, amount
        /// of memory, the number of vCPUs, amount of storage space, and monthly network data
        /// transfer quota.
        /// </para>
        ///  <note> 
        /// <para>
        /// Bundles are referred to as <i>instance plans</i> in the Lightsail console.
        /// </para>
        ///  </note>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBundles operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        IAsyncResult BeginGetBundles(GetBundlesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBundles.</param>
        /// 
        /// <returns>Returns a  GetBundlesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        GetBundlesResponse EndGetBundles(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificates operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCertificates">REST API Reference for GetCertificates Operation</seealso>
        IAsyncResult BeginGetCertificates(GetCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificates.</param>
        /// 
        /// <returns>Returns a  GetCertificatesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCertificates">REST API Reference for GetCertificates Operation</seealso>
        GetCertificatesResponse EndGetCertificates(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetCloudFormationStackRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationStackRecords operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudFormationStackRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCloudFormationStackRecords">REST API Reference for GetCloudFormationStackRecords Operation</seealso>
        IAsyncResult BeginGetCloudFormationStackRecords(GetCloudFormationStackRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudFormationStackRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudFormationStackRecords.</param>
        /// 
        /// <returns>Returns a  GetCloudFormationStackRecordsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCloudFormationStackRecords">REST API Reference for GetCloudFormationStackRecords Operation</seealso>
        GetCloudFormationStackRecordsResponse EndGetCloudFormationStackRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContactMethods


        /// <summary>
        /// Returns information about the configured contact methods. Specify a protocol in your
        /// request to return information about a specific contact method.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each Amazon
        /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
        /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContactMethods operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactMethods operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactMethods
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContactMethods">REST API Reference for GetContactMethods Operation</seealso>
        IAsyncResult BeginGetContactMethods(GetContactMethodsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactMethods operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactMethods.</param>
        /// 
        /// <returns>Returns a  GetContactMethodsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContactMethods">REST API Reference for GetContactMethods Operation</seealso>
        GetContactMethodsResponse EndGetContactMethods(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetContainerAPIMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerAPIMetadata operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerAPIMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerAPIMetadata">REST API Reference for GetContainerAPIMetadata Operation</seealso>
        IAsyncResult BeginGetContainerAPIMetadata(GetContainerAPIMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerAPIMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerAPIMetadata.</param>
        /// 
        /// <returns>Returns a  GetContainerAPIMetadataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerAPIMetadata">REST API Reference for GetContainerAPIMetadata Operation</seealso>
        GetContainerAPIMetadataResponse EndGetContainerAPIMetadata(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerImages operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerImages">REST API Reference for GetContainerImages Operation</seealso>
        IAsyncResult BeginGetContainerImages(GetContainerImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerImages.</param>
        /// 
        /// <returns>Returns a  GetContainerImagesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerImages">REST API Reference for GetContainerImages Operation</seealso>
        GetContainerImagesResponse EndGetContainerImages(IAsyncResult asyncResult);

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
        /// endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerLog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerLog operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerLog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerLog">REST API Reference for GetContainerLog Operation</seealso>
        IAsyncResult BeginGetContainerLog(GetContainerLogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerLog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerLog.</param>
        /// 
        /// <returns>Returns a  GetContainerLogResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerLog">REST API Reference for GetContainerLog Operation</seealso>
        GetContainerLogResponse EndGetContainerLog(IAsyncResult asyncResult);

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
        /// Lightsail endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerServiceDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceDeployments operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerServiceDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceDeployments">REST API Reference for GetContainerServiceDeployments Operation</seealso>
        IAsyncResult BeginGetContainerServiceDeployments(GetContainerServiceDeploymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerServiceDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerServiceDeployments.</param>
        /// 
        /// <returns>Returns a  GetContainerServiceDeploymentsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceDeployments">REST API Reference for GetContainerServiceDeployments Operation</seealso>
        GetContainerServiceDeploymentsResponse EndGetContainerServiceDeployments(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerServiceMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServiceMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerServiceMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceMetricData">REST API Reference for GetContainerServiceMetricData Operation</seealso>
        IAsyncResult BeginGetContainerServiceMetricData(GetContainerServiceMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerServiceMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerServiceMetricData.</param>
        /// 
        /// <returns>Returns a  GetContainerServiceMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServiceMetricData">REST API Reference for GetContainerServiceMetricData Operation</seealso>
        GetContainerServiceMetricDataResponse EndGetContainerServiceMetricData(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerServicePowers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServicePowers operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerServicePowers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServicePowers">REST API Reference for GetContainerServicePowers Operation</seealso>
        IAsyncResult BeginGetContainerServicePowers(GetContainerServicePowersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerServicePowers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerServicePowers.</param>
        /// 
        /// <returns>Returns a  GetContainerServicePowersResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServicePowers">REST API Reference for GetContainerServicePowers Operation</seealso>
        GetContainerServicePowersResponse EndGetContainerServicePowers(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetContainerServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerServices operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContainerServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServices">REST API Reference for GetContainerServices Operation</seealso>
        IAsyncResult BeginGetContainerServices(GetContainerServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContainerServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContainerServices.</param>
        /// 
        /// <returns>Returns a  GetContainerServicesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetContainerServices">REST API Reference for GetContainerServices Operation</seealso>
        GetContainerServicesResponse EndGetContainerServices(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCostEstimate


        /// <summary>
        /// Retrieves information about the cost estimate for a specified resource. A cost estimate
        /// will not generate for a resource that has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostEstimate service method.</param>
        /// 
        /// <returns>The response from the GetCostEstimate service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCostEstimate">REST API Reference for GetCostEstimate Operation</seealso>
        GetCostEstimateResponse GetCostEstimate(GetCostEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCostEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCostEstimate operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCostEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCostEstimate">REST API Reference for GetCostEstimate Operation</seealso>
        IAsyncResult BeginGetCostEstimate(GetCostEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCostEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCostEstimate.</param>
        /// 
        /// <returns>Returns a  GetCostEstimateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCostEstimate">REST API Reference for GetCostEstimate Operation</seealso>
        GetCostEstimateResponse EndGetCostEstimate(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDisk operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDisk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisk">REST API Reference for GetDisk Operation</seealso>
        IAsyncResult BeginGetDisk(GetDiskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDisk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDisk.</param>
        /// 
        /// <returns>Returns a  GetDiskResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisk">REST API Reference for GetDisk Operation</seealso>
        GetDiskResponse EndGetDisk(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDisks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDisks operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDisks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisks">REST API Reference for GetDisks Operation</seealso>
        IAsyncResult BeginGetDisks(GetDisksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDisks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDisks.</param>
        /// 
        /// <returns>Returns a  GetDisksResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisks">REST API Reference for GetDisks Operation</seealso>
        GetDisksResponse EndGetDisks(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiskSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshot">REST API Reference for GetDiskSnapshot Operation</seealso>
        IAsyncResult BeginGetDiskSnapshot(GetDiskSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiskSnapshot.</param>
        /// 
        /// <returns>Returns a  GetDiskSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshot">REST API Reference for GetDiskSnapshot Operation</seealso>
        GetDiskSnapshotResponse EndGetDiskSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDiskSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshots operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiskSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshots">REST API Reference for GetDiskSnapshots Operation</seealso>
        IAsyncResult BeginGetDiskSnapshots(GetDiskSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiskSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiskSnapshots.</param>
        /// 
        /// <returns>Returns a  GetDiskSnapshotsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshots">REST API Reference for GetDiskSnapshots Operation</seealso>
        GetDiskSnapshotsResponse EndGetDiskSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDistributionBundles


        /// <summary>
        /// Returns the bundles that can be applied to your Amazon Lightsail content delivery
        /// network (CDN) distributions.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your distribution.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDistributionBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionBundles operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionBundles">REST API Reference for GetDistributionBundles Operation</seealso>
        IAsyncResult BeginGetDistributionBundles(GetDistributionBundlesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionBundles.</param>
        /// 
        /// <returns>Returns a  GetDistributionBundlesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionBundles">REST API Reference for GetDistributionBundles Operation</seealso>
        GetDistributionBundlesResponse EndGetDistributionBundles(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDistributionLatestCacheReset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionLatestCacheReset operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionLatestCacheReset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionLatestCacheReset">REST API Reference for GetDistributionLatestCacheReset Operation</seealso>
        IAsyncResult BeginGetDistributionLatestCacheReset(GetDistributionLatestCacheResetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionLatestCacheReset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionLatestCacheReset.</param>
        /// 
        /// <returns>Returns a  GetDistributionLatestCacheResetResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionLatestCacheReset">REST API Reference for GetDistributionLatestCacheReset Operation</seealso>
        GetDistributionLatestCacheResetResponse EndGetDistributionLatestCacheReset(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDistributionMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributionMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionMetricData">REST API Reference for GetDistributionMetricData Operation</seealso>
        IAsyncResult BeginGetDistributionMetricData(GetDistributionMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributionMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributionMetricData.</param>
        /// 
        /// <returns>Returns a  GetDistributionMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributionMetricData">REST API Reference for GetDistributionMetricData Operation</seealso>
        GetDistributionMetricDataResponse EndGetDistributionMetricData(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributions operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDistributions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributions">REST API Reference for GetDistributions Operation</seealso>
        IAsyncResult BeginGetDistributions(GetDistributionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDistributions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDistributions.</param>
        /// 
        /// <returns>Returns a  GetDistributionsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDistributions">REST API Reference for GetDistributions Operation</seealso>
        GetDistributionsResponse EndGetDistributions(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        IAsyncResult BeginGetDomain(GetDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomain.</param>
        /// 
        /// <returns>Returns a  GetDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse EndGetDomain(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomains operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        IAsyncResult BeginGetDomains(GetDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomains.</param>
        /// 
        /// <returns>Returns a  GetDomainsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        GetDomainsResponse EndGetDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExportSnapshotRecords


        /// <summary>
        /// Returns all export snapshot records created as a result of the <code>export snapshot</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// An export snapshot record can be used to create a new Amazon EC2 instance and its
        /// related resources with the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateCloudFormationStack.html">CreateCloudFormationStack</a>
        /// action.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetExportSnapshotRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportSnapshotRecords operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportSnapshotRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetExportSnapshotRecords">REST API Reference for GetExportSnapshotRecords Operation</seealso>
        IAsyncResult BeginGetExportSnapshotRecords(GetExportSnapshotRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportSnapshotRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportSnapshotRecords.</param>
        /// 
        /// <returns>Returns a  GetExportSnapshotRecordsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetExportSnapshotRecords">REST API Reference for GetExportSnapshotRecords Operation</seealso>
        GetExportSnapshotRecordsResponse EndGetExportSnapshotRecords(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        GetInstanceResponse EndGetInstance(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceAccessDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        IAsyncResult BeginGetInstanceAccessDetails(GetInstanceAccessDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceAccessDetails.</param>
        /// 
        /// <returns>Returns a  GetInstanceAccessDetailsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        GetInstanceAccessDetailsResponse EndGetInstanceAccessDetails(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        IAsyncResult BeginGetInstanceMetricData(GetInstanceMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceMetricData.</param>
        /// 
        /// <returns>Returns a  GetInstanceMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        GetInstanceMetricDataResponse EndGetInstanceMetricData(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstancePortStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        IAsyncResult BeginGetInstancePortStates(GetInstancePortStatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstancePortStates.</param>
        /// 
        /// <returns>Returns a  GetInstancePortStatesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        GetInstancePortStatesResponse EndGetInstancePortStates(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstances operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        IAsyncResult BeginGetInstances(GetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstances.</param>
        /// 
        /// <returns>Returns a  GetInstancesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        GetInstancesResponse EndGetInstances(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        IAsyncResult BeginGetInstanceSnapshot(GetInstanceSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  GetInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        GetInstanceSnapshotResponse EndGetInstanceSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        IAsyncResult BeginGetInstanceSnapshots(GetInstanceSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceSnapshots.</param>
        /// 
        /// <returns>Returns a  GetInstanceSnapshotsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        GetInstanceSnapshotsResponse EndGetInstanceSnapshots(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        IAsyncResult BeginGetInstanceState(GetInstanceStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceState.</param>
        /// 
        /// <returns>Returns a  GetInstanceStateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        GetInstanceStateResponse EndGetInstanceState(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        IAsyncResult BeginGetKeyPair(GetKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyPair.</param>
        /// 
        /// <returns>Returns a  GetKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        GetKeyPairResponse EndGetKeyPair(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyPairs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        IAsyncResult BeginGetKeyPairs(GetKeyPairsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyPairs.</param>
        /// 
        /// <returns>Returns a  GetKeyPairsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        GetKeyPairsResponse EndGetKeyPairs(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancer operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoadBalancer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancer">REST API Reference for GetLoadBalancer Operation</seealso>
        IAsyncResult BeginGetLoadBalancer(GetLoadBalancerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoadBalancer.</param>
        /// 
        /// <returns>Returns a  GetLoadBalancerResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancer">REST API Reference for GetLoadBalancer Operation</seealso>
        GetLoadBalancerResponse EndGetLoadBalancer(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetLoadBalancerMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoadBalancerMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerMetricData">REST API Reference for GetLoadBalancerMetricData Operation</seealso>
        IAsyncResult BeginGetLoadBalancerMetricData(GetLoadBalancerMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoadBalancerMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoadBalancerMetricData.</param>
        /// 
        /// <returns>Returns a  GetLoadBalancerMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerMetricData">REST API Reference for GetLoadBalancerMetricData Operation</seealso>
        GetLoadBalancerMetricDataResponse EndGetLoadBalancerMetricData(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancers operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoadBalancers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancers">REST API Reference for GetLoadBalancers Operation</seealso>
        IAsyncResult BeginGetLoadBalancers(GetLoadBalancersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoadBalancers.</param>
        /// 
        /// <returns>Returns a  GetLoadBalancersResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancers">REST API Reference for GetLoadBalancers Operation</seealso>
        GetLoadBalancersResponse EndGetLoadBalancers(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetLoadBalancerTlsCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsCertificates operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoadBalancerTlsCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsCertificates">REST API Reference for GetLoadBalancerTlsCertificates Operation</seealso>
        IAsyncResult BeginGetLoadBalancerTlsCertificates(GetLoadBalancerTlsCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoadBalancerTlsCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoadBalancerTlsCertificates.</param>
        /// 
        /// <returns>Returns a  GetLoadBalancerTlsCertificatesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsCertificates">REST API Reference for GetLoadBalancerTlsCertificates Operation</seealso>
        GetLoadBalancerTlsCertificatesResponse EndGetLoadBalancerTlsCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoadBalancerTlsPolicies


        /// <summary>
        /// Returns a list of TLS security policies that you can apply to Lightsail load balancers.
        /// 
        ///  
        /// <para>
        /// For more information about load balancer TLS security policies, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configure-load-balancer-tls-security-policy">Configuring
        /// TLS security policies on your Amazon Lightsail load balancers</a> in the <i>Amazon
        /// Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsPolicies service method.</param>
        /// 
        /// <returns>The response from the GetLoadBalancerTlsPolicies service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsPolicies">REST API Reference for GetLoadBalancerTlsPolicies Operation</seealso>
        GetLoadBalancerTlsPoliciesResponse GetLoadBalancerTlsPolicies(GetLoadBalancerTlsPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoadBalancerTlsPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsPolicies operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoadBalancerTlsPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsPolicies">REST API Reference for GetLoadBalancerTlsPolicies Operation</seealso>
        IAsyncResult BeginGetLoadBalancerTlsPolicies(GetLoadBalancerTlsPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoadBalancerTlsPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoadBalancerTlsPolicies.</param>
        /// 
        /// <returns>Returns a  GetLoadBalancerTlsPoliciesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsPolicies">REST API Reference for GetLoadBalancerTlsPolicies Operation</seealso>
        GetLoadBalancerTlsPoliciesResponse EndGetLoadBalancerTlsPolicies(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse EndGetOperation(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperations operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        IAsyncResult BeginGetOperations(GetOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperations.</param>
        /// 
        /// <returns>Returns a  GetOperationsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        GetOperationsResponse EndGetOperations(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperationsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        IAsyncResult BeginGetOperationsForResource(GetOperationsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperationsForResource.</param>
        /// 
        /// <returns>Returns a  GetOperationsForResourceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        GetOperationsForResourceResponse EndGetOperationsForResource(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegions operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        IAsyncResult BeginGetRegions(GetRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegions.</param>
        /// 
        /// <returns>Returns a  GetRegionsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        GetRegionsResponse EndGetRegions(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabase">REST API Reference for GetRelationalDatabase Operation</seealso>
        IAsyncResult BeginGetRelationalDatabase(GetRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabase">REST API Reference for GetRelationalDatabase Operation</seealso>
        GetRelationalDatabaseResponse EndGetRelationalDatabase(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBlueprints operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBlueprints">REST API Reference for GetRelationalDatabaseBlueprints Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseBlueprints(GetRelationalDatabaseBlueprintsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseBlueprints.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseBlueprintsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBlueprints">REST API Reference for GetRelationalDatabaseBlueprints Operation</seealso>
        GetRelationalDatabaseBlueprintsResponse EndGetRelationalDatabaseBlueprints(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBundles operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBundles">REST API Reference for GetRelationalDatabaseBundles Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseBundles(GetRelationalDatabaseBundlesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseBundles.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseBundlesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBundles">REST API Reference for GetRelationalDatabaseBundles Operation</seealso>
        GetRelationalDatabaseBundlesResponse EndGetRelationalDatabaseBundles(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseEvents operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseEvents">REST API Reference for GetRelationalDatabaseEvents Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseEvents(GetRelationalDatabaseEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseEvents.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseEventsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseEvents">REST API Reference for GetRelationalDatabaseEvents Operation</seealso>
        GetRelationalDatabaseEventsResponse EndGetRelationalDatabaseEvents(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogEvents operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseLogEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogEvents">REST API Reference for GetRelationalDatabaseLogEvents Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseLogEvents(GetRelationalDatabaseLogEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseLogEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseLogEvents.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseLogEventsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogEvents">REST API Reference for GetRelationalDatabaseLogEvents Operation</seealso>
        GetRelationalDatabaseLogEventsResponse EndGetRelationalDatabaseLogEvents(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseLogStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogStreams operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseLogStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogStreams">REST API Reference for GetRelationalDatabaseLogStreams Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseLogStreams(GetRelationalDatabaseLogStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseLogStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseLogStreams.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseLogStreamsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogStreams">REST API Reference for GetRelationalDatabaseLogStreams Operation</seealso>
        GetRelationalDatabaseLogStreamsResponse EndGetRelationalDatabaseLogStreams(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseMasterUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMasterUserPassword operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseMasterUserPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMasterUserPassword">REST API Reference for GetRelationalDatabaseMasterUserPassword Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseMasterUserPassword(GetRelationalDatabaseMasterUserPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseMasterUserPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseMasterUserPassword.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseMasterUserPasswordResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMasterUserPassword">REST API Reference for GetRelationalDatabaseMasterUserPassword Operation</seealso>
        GetRelationalDatabaseMasterUserPasswordResponse EndGetRelationalDatabaseMasterUserPassword(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMetricData">REST API Reference for GetRelationalDatabaseMetricData Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseMetricData(GetRelationalDatabaseMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseMetricData.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMetricData">REST API Reference for GetRelationalDatabaseMetricData Operation</seealso>
        GetRelationalDatabaseMetricDataResponse EndGetRelationalDatabaseMetricData(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseParameters operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseParameters">REST API Reference for GetRelationalDatabaseParameters Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseParameters(GetRelationalDatabaseParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseParameters.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseParametersResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseParameters">REST API Reference for GetRelationalDatabaseParameters Operation</seealso>
        GetRelationalDatabaseParametersResponse EndGetRelationalDatabaseParameters(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabases operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabases">REST API Reference for GetRelationalDatabases Operation</seealso>
        IAsyncResult BeginGetRelationalDatabases(GetRelationalDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabases.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabasesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabases">REST API Reference for GetRelationalDatabases Operation</seealso>
        GetRelationalDatabasesResponse EndGetRelationalDatabases(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshot">REST API Reference for GetRelationalDatabaseSnapshot Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseSnapshot(GetRelationalDatabaseSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseSnapshot.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshot">REST API Reference for GetRelationalDatabaseSnapshot Operation</seealso>
        GetRelationalDatabaseSnapshotResponse EndGetRelationalDatabaseSnapshot(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetRelationalDatabaseSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshots operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelationalDatabaseSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshots">REST API Reference for GetRelationalDatabaseSnapshots Operation</seealso>
        IAsyncResult BeginGetRelationalDatabaseSnapshots(GetRelationalDatabaseSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelationalDatabaseSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelationalDatabaseSnapshots.</param>
        /// 
        /// <returns>Returns a  GetRelationalDatabaseSnapshotsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshots">REST API Reference for GetRelationalDatabaseSnapshots Operation</seealso>
        GetRelationalDatabaseSnapshotsResponse EndGetRelationalDatabaseSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStaticIp


        /// <summary>
        /// Returns information about an Amazon Lightsail static IP.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        IAsyncResult BeginGetStaticIp(GetStaticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticIp.</param>
        /// 
        /// <returns>Returns a  GetStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        GetStaticIpResponse EndGetStaticIp(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStaticIps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        IAsyncResult BeginGetStaticIps(GetStaticIpsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticIps.</param>
        /// 
        /// <returns>Returns a  GetStaticIpsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        GetStaticIpsResponse EndGetStaticIps(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        IAsyncResult BeginImportKeyPair(ImportKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsVpcPeered
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        IAsyncResult BeginIsVpcPeered(IsVpcPeeredRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsVpcPeered.</param>
        /// 
        /// <returns>Returns a  IsVpcPeeredResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        IsVpcPeeredResponse EndIsVpcPeered(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOpenInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        IAsyncResult BeginOpenInstancePublicPorts(OpenInstancePublicPortsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOpenInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  OpenInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        OpenInstancePublicPortsResponse EndOpenInstancePublicPorts(IAsyncResult asyncResult);

        #endregion
        
        #region  PeerVpc


        /// <summary>
        /// Peers the Lightsail VPC with the user's default VPC.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPeerVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        IAsyncResult BeginPeerVpc(PeerVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPeerVpc.</param>
        /// 
        /// <returns>Returns a  PeerVpcResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        PeerVpcResponse EndPeerVpc(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the PutAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAlarm operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutAlarm">REST API Reference for PutAlarm Operation</seealso>
        IAsyncResult BeginPutAlarm(PutAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAlarm.</param>
        /// 
        /// <returns>Returns a  PutAlarmResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutAlarm">REST API Reference for PutAlarm Operation</seealso>
        PutAlarmResponse EndPutAlarm(IAsyncResult asyncResult);

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
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        IAsyncResult BeginPutInstancePublicPorts(PutInstancePublicPortsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  PutInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        PutInstancePublicPortsResponse EndPutInstancePublicPorts(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Restarts a specific instance.
        /// 
        ///  
        /// <para>
        /// The <code>reboot instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        IAsyncResult BeginRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        /// 
        /// <returns>Returns a  RebootInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootRelationalDatabase


        /// <summary>
        /// Restarts a specific database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>reboot relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the RebootRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootRelationalDatabase">REST API Reference for RebootRelationalDatabase Operation</seealso>
        IAsyncResult BeginRebootRelationalDatabase(RebootRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  RebootRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootRelationalDatabase">REST API Reference for RebootRelationalDatabase Operation</seealso>
        RebootRelationalDatabaseResponse EndRebootRelationalDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterContainerImage


        /// <summary>
        /// Registers a container image to your Amazon Lightsail container service.
        /// 
        ///  <note> 
        /// <para>
        /// This action is not required if you install and use the Lightsail Control (lightsailctl)
        /// plugin to push container images to your Lightsail container service. For more information,
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-pushing-container-images">Pushing
        /// and managing container images on your Amazon Lightsail container services</a> in the
        /// <i>Amazon Lightsail Developer Guide</i>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the RegisterContainerImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterContainerImage operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterContainerImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RegisterContainerImage">REST API Reference for RegisterContainerImage Operation</seealso>
        IAsyncResult BeginRegisterContainerImage(RegisterContainerImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterContainerImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterContainerImage.</param>
        /// 
        /// <returns>Returns a  RegisterContainerImageResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RegisterContainerImage">REST API Reference for RegisterContainerImage Operation</seealso>
        RegisterContainerImageResponse EndRegisterContainerImage(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        IAsyncResult BeginReleaseStaticIp(ReleaseStaticIpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseStaticIp.</param>
        /// 
        /// <returns>Returns a  ReleaseStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        ReleaseStaticIpResponse EndReleaseStaticIp(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the ResetDistributionCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDistributionCache operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDistributionCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ResetDistributionCache">REST API Reference for ResetDistributionCache Operation</seealso>
        IAsyncResult BeginResetDistributionCache(ResetDistributionCacheRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDistributionCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDistributionCache.</param>
        /// 
        /// <returns>Returns a  ResetDistributionCacheResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ResetDistributionCache">REST API Reference for ResetDistributionCache Operation</seealso>
        ResetDistributionCacheResponse EndResetDistributionCache(IAsyncResult asyncResult);

        #endregion
        
        #region  SendContactMethodVerification


        /// <summary>
        /// Sends a verification request to an email contact method to ensure it's owned by the
        /// requester. SMS contact methods don't need to be verified.
        /// 
        ///  
        /// <para>
        /// A contact method is used to send you notifications about your Amazon Lightsail resources.
        /// You can add one email address and one mobile phone number contact method in each Amazon
        /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
        /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
        /// For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-notifications">Notifications
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the SendContactMethodVerification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendContactMethodVerification operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendContactMethodVerification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SendContactMethodVerification">REST API Reference for SendContactMethodVerification Operation</seealso>
        IAsyncResult BeginSendContactMethodVerification(SendContactMethodVerificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendContactMethodVerification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendContactMethodVerification.</param>
        /// 
        /// <returns>Returns a  SendContactMethodVerificationResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SendContactMethodVerification">REST API Reference for SendContactMethodVerification Operation</seealso>
        SendContactMethodVerificationResponse EndSendContactMethodVerification(IAsyncResult asyncResult);

        #endregion
        
        #region  SetIpAddressType


        /// <summary>
        /// Sets the IP address type for an Amazon Lightsail resource.
        /// 
        ///  
        /// <para>
        /// Use this action to enable dual-stack for a resource, which enables IPv4 and IPv6 for
        /// the specified resource. Alternately, you can use this action to disable dual-stack,
        /// and enable IPv4 only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType service method.</param>
        /// 
        /// <returns>The response from the SetIpAddressType service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        SetIpAddressTypeResponse SetIpAddressType(SetIpAddressTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetIpAddressType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIpAddressType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        IAsyncResult BeginSetIpAddressType(SetIpAddressTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetIpAddressType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIpAddressType.</param>
        /// 
        /// <returns>Returns a  SetIpAddressTypeResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        SetIpAddressTypeResponse EndSetIpAddressType(IAsyncResult asyncResult);

        #endregion
        
        #region  SetResourceAccessForBucket


        /// <summary>
        /// Sets the Amazon Lightsail resources that can access the specified Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// Lightsail buckets currently support setting access for Lightsail instances in the
        /// same Amazon Web Services Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetResourceAccessForBucket service method.</param>
        /// 
        /// <returns>The response from the SetResourceAccessForBucket service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetResourceAccessForBucket">REST API Reference for SetResourceAccessForBucket Operation</seealso>
        SetResourceAccessForBucketResponse SetResourceAccessForBucket(SetResourceAccessForBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetResourceAccessForBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetResourceAccessForBucket operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetResourceAccessForBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetResourceAccessForBucket">REST API Reference for SetResourceAccessForBucket Operation</seealso>
        IAsyncResult BeginSetResourceAccessForBucket(SetResourceAccessForBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetResourceAccessForBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetResourceAccessForBucket.</param>
        /// 
        /// <returns>Returns a  SetResourceAccessForBucketResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/SetResourceAccessForBucket">REST API Reference for SetResourceAccessForBucket Operation</seealso>
        SetResourceAccessForBucketResponse EndSetResourceAccessForBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  StartGUISession


        /// <summary>
        /// Initiates a graphical user interface (GUI) session that’s used to access a virtual
        /// computer’s operating system and application. The session will be active for 1 hour.
        /// Use this action to resume the session after it expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGUISession service method.</param>
        /// 
        /// <returns>The response from the StartGUISession service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartGUISession">REST API Reference for StartGUISession Operation</seealso>
        StartGUISessionResponse StartGUISession(StartGUISessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartGUISession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGUISession operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGUISession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartGUISession">REST API Reference for StartGUISession Operation</seealso>
        IAsyncResult BeginStartGUISession(StartGUISessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartGUISession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGUISession.</param>
        /// 
        /// <returns>Returns a  StartGUISessionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartGUISession">REST API Reference for StartGUISession Operation</seealso>
        StartGUISessionResponse EndStartGUISession(IAsyncResult asyncResult);

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
        /// href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/lightsail-create-static-ip">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>start instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        IAsyncResult BeginStartInstance(StartInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        /// 
        /// <returns>Returns a  StartInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        StartInstanceResponse EndStartInstance(IAsyncResult asyncResult);

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
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the StartRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartRelationalDatabase">REST API Reference for StartRelationalDatabase Operation</seealso>
        IAsyncResult BeginStartRelationalDatabase(StartRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  StartRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartRelationalDatabase">REST API Reference for StartRelationalDatabase Operation</seealso>
        StartRelationalDatabaseResponse EndStartRelationalDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  StopGUISession


        /// <summary>
        /// Terminates a web-based NICE DCV session that’s used to access a virtual computer’s
        /// operating system or application. The session will close and any unsaved data will
        /// be lost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGUISession service method.</param>
        /// 
        /// <returns>The response from the StopGUISession service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopGUISession">REST API Reference for StopGUISession Operation</seealso>
        StopGUISessionResponse StopGUISession(StopGUISessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopGUISession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGUISession operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopGUISession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopGUISession">REST API Reference for StopGUISession Operation</seealso>
        IAsyncResult BeginStopGUISession(StopGUISessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopGUISession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopGUISession.</param>
        /// 
        /// <returns>Returns a  StopGUISessionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopGUISession">REST API Reference for StopGUISession Operation</seealso>
        StopGUISessionResponse EndStopGUISession(IAsyncResult asyncResult);

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
        /// href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/lightsail-create-static-ip">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>stop instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by <code>instance name</code>. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        IAsyncResult BeginStopInstance(StopInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        /// 
        /// <returns>Returns a  StopInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        StopInstanceResponse EndStopInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StopRelationalDatabase


        /// <summary>
        /// Stops a specific database that is currently running in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// The <code>stop relational database</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by relationalDatabaseName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the StopRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopRelationalDatabase">REST API Reference for StopRelationalDatabase Operation</seealso>
        IAsyncResult BeginStopRelationalDatabase(StopRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  StopRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopRelationalDatabase">REST API Reference for StopRelationalDatabase Operation</seealso>
        StopRelationalDatabaseResponse EndStopRelationalDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified Amazon Lightsail resource. Each resource can
        /// have a maximum of 50 tags. Each tag consists of a key and an optional value. Tag keys
        /// must be unique per resource. For more information about tags, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// 
        ///  
        /// <para>
        /// The <code>tag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by <code>resource name</code>.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the TestAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestAlarm operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TestAlarm">REST API Reference for TestAlarm Operation</seealso>
        IAsyncResult BeginTestAlarm(TestAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestAlarm.</param>
        /// 
        /// <returns>Returns a  TestAlarmResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TestAlarm">REST API Reference for TestAlarm Operation</seealso>
        TestAlarmResponse EndTestAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  UnpeerVpc


        /// <summary>
        /// Unpeers the Lightsail VPC from the user's default VPC.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnpeerVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        IAsyncResult BeginUnpeerVpc(UnpeerVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnpeerVpc.</param>
        /// 
        /// <returns>Returns a  UnpeerVpcResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        UnpeerVpcResponse EndUnpeerVpc(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBucket


        /// <summary>
        /// Updates an existing Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// Use this action to update the configuration of an existing bucket, such as versioning,
        /// public accessibility, and the Amazon Web Services accounts that can access the bucket.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBucket service method.</param>
        /// 
        /// <returns>The response from the UpdateBucket service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucket">REST API Reference for UpdateBucket Operation</seealso>
        UpdateBucketResponse UpdateBucket(UpdateBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBucket operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucket">REST API Reference for UpdateBucket Operation</seealso>
        IAsyncResult BeginUpdateBucket(UpdateBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBucket.</param>
        /// 
        /// <returns>Returns a  UpdateBucketResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucket">REST API Reference for UpdateBucket Operation</seealso>
        UpdateBucketResponse EndUpdateBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBucketBundle


        /// <summary>
        /// Updates the bundle, or storage plan, of an existing Amazon Lightsail bucket.
        /// 
        ///  
        /// <para>
        /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
        /// for a bucket. You can update a bucket's bundle only one time within a monthly Amazon
        /// Web Services billing cycle. To determine if you can update a bucket's bundle, use
        /// the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBuckets.html">GetBuckets</a>
        /// action. The <code>ableToUpdateBundle</code> parameter in the response will indicate
        /// whether you can currently update a bucket's bundle.
        /// </para>
        ///  
        /// <para>
        /// Update a bucket's bundle if it's consistently going over its storage space or data
        /// transfer quota, or if a bucket's usage is consistently in the lower range of its storage
        /// space or data transfer quota. Due to the unpredictable usage fluctuations that a bucket
        /// might experience, we strongly recommend that you update a bucket's bundle only as
        /// a long-term strategy, instead of as a short-term, monthly cost-cutting measure. Choose
        /// a bucket bundle that will provide the bucket with ample storage space and data transfer
        /// for a long time to come.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBucketBundle service method.</param>
        /// 
        /// <returns>The response from the UpdateBucketBundle service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucketBundle">REST API Reference for UpdateBucketBundle Operation</seealso>
        UpdateBucketBundleResponse UpdateBucketBundle(UpdateBucketBundleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBucketBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBucketBundle operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBucketBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucketBundle">REST API Reference for UpdateBucketBundle Operation</seealso>
        IAsyncResult BeginUpdateBucketBundle(UpdateBucketBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBucketBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBucketBundle.</param>
        /// 
        /// <returns>Returns a  UpdateBucketBundleResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateBucketBundle">REST API Reference for UpdateBucketBundle Operation</seealso>
        UpdateBucketBundleResponse EndUpdateBucketBundle(IAsyncResult asyncResult);

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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateContainerService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateContainerService operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateContainerService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateContainerService">REST API Reference for UpdateContainerService Operation</seealso>
        IAsyncResult BeginUpdateContainerService(UpdateContainerServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateContainerService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateContainerService.</param>
        /// 
        /// <returns>Returns a  UpdateContainerServiceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateContainerService">REST API Reference for UpdateContainerService Operation</seealso>
        UpdateContainerServiceResponse EndUpdateContainerService(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistribution


        /// <summary>
        /// Updates an existing Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Use this action to update the configuration of your existing distribution.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistribution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        IAsyncResult BeginUpdateDistribution(UpdateDistributionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistribution.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        UpdateDistributionResponse EndUpdateDistribution(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDistributionBundle


        /// <summary>
        /// Updates the bundle of your Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// A distribution bundle specifies the monthly network transfer quota and monthly cost
        /// of your distribution.
        /// </para>
        ///  
        /// <para>
        /// Update your distribution's bundle if your distribution is going over its monthly network
        /// transfer quota and is incurring an overage fee.
        /// </para>
        ///  
        /// <para>
        /// You can update your distribution's bundle only one time within your monthly Amazon
        /// Web Services billing cycle. To determine if you can update your distribution's bundle,
        /// use the <code>GetDistributions</code> action. The <code>ableToUpdateBundle</code>
        /// parameter in the result will indicate whether you can currently update your distribution's
        /// bundle.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateDistributionBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistributionBundle operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDistributionBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistributionBundle">REST API Reference for UpdateDistributionBundle Operation</seealso>
        IAsyncResult BeginUpdateDistributionBundle(UpdateDistributionBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDistributionBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDistributionBundle.</param>
        /// 
        /// <returns>Returns a  UpdateDistributionBundleResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDistributionBundle">REST API Reference for UpdateDistributionBundle Operation</seealso>
        UpdateDistributionBundleResponse EndUpdateDistributionBundle(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainEntry


        /// <summary>
        /// Updates a domain recordset after it is created.
        /// 
        ///  
        /// <para>
        /// The <code>update domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by <code>domain name</code>. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        IAsyncResult BeginUpdateDomainEntry(UpdateDomainEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainEntry.</param>
        /// 
        /// <returns>Returns a  UpdateDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        UpdateDomainEntryResponse EndUpdateDomainEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstanceMetadataOptions


        /// <summary>
        /// Modifies the Amazon Lightsail instance metadata parameters on a running or stopped
        /// instance. When you modify the parameters on a running instance, the <code>GetInstance</code>
        /// or <code>GetInstances</code> API operation initially responds with a state of <code>pending</code>.
        /// After the parameter modifications are successfully applied, the state changes to <code>applied</code>
        /// in subsequent <code>GetInstance</code> or <code>GetInstances</code> API calls. For
        /// more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-instance-metadata-service">Use
        /// IMDSv2 with an Amazon Lightsail instance</a> in the <i>Amazon Lightsail Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceMetadataOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceMetadataOptions service method, as returned by Lightsail.</returns>
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateInstanceMetadataOptions">REST API Reference for UpdateInstanceMetadataOptions Operation</seealso>
        UpdateInstanceMetadataOptionsResponse UpdateInstanceMetadataOptions(UpdateInstanceMetadataOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceMetadataOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceMetadataOptions operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceMetadataOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateInstanceMetadataOptions">REST API Reference for UpdateInstanceMetadataOptions Operation</seealso>
        IAsyncResult BeginUpdateInstanceMetadataOptions(UpdateInstanceMetadataOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceMetadataOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceMetadataOptions.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceMetadataOptionsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateInstanceMetadataOptions">REST API Reference for UpdateInstanceMetadataOptions Operation</seealso>
        UpdateInstanceMetadataOptionsResponse EndUpdateInstanceMetadataOptions(IAsyncResult asyncResult);

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
        /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateLoadBalancerAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoadBalancerAttribute operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoadBalancerAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateLoadBalancerAttribute">REST API Reference for UpdateLoadBalancerAttribute Operation</seealso>
        IAsyncResult BeginUpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoadBalancerAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoadBalancerAttribute.</param>
        /// 
        /// <returns>Returns a  UpdateLoadBalancerAttributeResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateLoadBalancerAttribute">REST API Reference for UpdateLoadBalancerAttribute Operation</seealso>
        UpdateLoadBalancerAttributeResponse EndUpdateLoadBalancerAttribute(IAsyncResult asyncResult);

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
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabase operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelationalDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabase">REST API Reference for UpdateRelationalDatabase Operation</seealso>
        IAsyncResult BeginUpdateRelationalDatabase(UpdateRelationalDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelationalDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateRelationalDatabaseResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabase">REST API Reference for UpdateRelationalDatabase Operation</seealso>
        UpdateRelationalDatabaseResponse EndUpdateRelationalDatabase(IAsyncResult asyncResult);

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
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
        /// Domain and distribution APIs are only available in the N. Virginia (<code>us-east-1</code>)
        /// Amazon Web Services Region. Please set your Amazon Web Services Region configuration
        /// to <code>us-east-1</code> to create, view, or edit these resources.
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
        /// Initiates the asynchronous execution of the UpdateRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabaseParameters operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelationalDatabaseParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabaseParameters">REST API Reference for UpdateRelationalDatabaseParameters Operation</seealso>
        IAsyncResult BeginUpdateRelationalDatabaseParameters(UpdateRelationalDatabaseParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelationalDatabaseParameters.</param>
        /// 
        /// <returns>Returns a  UpdateRelationalDatabaseParametersResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabaseParameters">REST API Reference for UpdateRelationalDatabaseParameters Operation</seealso>
        UpdateRelationalDatabaseParametersResponse EndUpdateRelationalDatabaseParameters(IAsyncResult asyncResult);

        #endregion
        
    }
}